import spidriver
import time
import sys

states = {
  0 : (1,  0 , "Test-Logic-Reset",    ),
  1 : (1,  2 , "Run-Test/Idle",       ),
  2 : (3,  9 , "Select-DR-Scan",      ),
  3 : (4,  5 , "Capture-DR",          ),
  4 : (4,  5 , "Shift-DR",            ),
  5 : (6,  8 , "Exit1-DR",            ),
  6 : (6,  7 , "Pause-DR",            ),
  7 : (4,  8 , "Exit2-DR",            ),
  8 : (1,  2 , "Update-DR",           ),
  9 : (10, 0 , "Select-IR-Scan",      ),
  10: (11, 12, "Capture-IR",          ),
  11: (11, 12, "Shift-IR",            ),
  12: (13, 15, "Exit1-IR",            ),
  13: (13, 14, "Pause-IR",            ),
  14: (11, 15, "Exit2-IR",            ),
  15: (1,  2 , "Update-IR",           ),
}

EXTEST       = 0b001111
SAMPLE       = 0b000001
USER1        = 0b000010
USER2        = 0b000011
CFG_OUT      = 0b000100
CFG_IN       = 0b000101
INTEST       = 0b000111
USERCODE     = 0b001000
IDCODE       = 0b001001
HIGHZ        = 0b001010
JPROGRAM     = 0b001011
JSTART       = 0b001100
JSHUTDOWN    = 0b001101
ISC_ENABLE   = 0b010000
ISC_PROGRAM  = 0b010001
ISC_NOOP     = 0b010100
ISC_READ     = 0b010101
ISC_DISABLE  = 0b010110
ISC_DNA      = 0b110001
BYPASS       = 0b111111

class JTAG(spidriver.SPIDriver):
    def jtag(self):
        self.ser.write(b'J')
        self.st = 0

    def bit(self, tms, tdi = 0):
        assert tms in (0,1)
        assert tdi in (0,1)
        m = b'b' + bytes([2 * tms + tdi])
        self.ser.write(m)
        return 1 & (self.ser.read(1)[0] >> 7)

    def go_state(self, *ss):
        for s in ss:
            self.bit(s)
            self.st = states[self.st][s]

    def in_state(self, e):
        a = states[self.st][2]
        assert a == e, "State fault: expected %s but actual %s" % (a, e)

    def transfer(self, n, m):
        tdo = 0
        for i in range(n):
            islast = i == (n - 1)
            b = self.bit(islast, 1 & (m >> i))
            tdo |= b << i
        self.st = states[self.st][1]
        return tdo

    def tlr(self):
        # Go to Test-Logic-Reset
        while self.st != 0:
            self.go_state(1)
        self.in_state("Test-Logic-Reset")

    def rti(self):
        self.go_state(1, 1, 1, 1, 1, 0)

    def LoadBSIR(self, instruction):
        self.rti()
        j.go_state(1, 1, 0, 0)
        self.in_state("Shift-IR")
        self.transfer(6, instruction)
        self.go_state(1)
        self.in_state("Update-IR")
        self.go_state(0)
        self.in_state("Run-Test/Idle")

    def LoadBSIRthenBSDR(self, instruction, send):
        self.rti()
        j.go_state(1, 1, 0, 0)
        self.in_state("Shift-IR")
        self.transfer(6, instruction)

        self.go_state(1)
        self.in_state("Update-IR")
        self.go_state(1, 0, 0)
        self.in_state("Shift-DR")

        r = self.transfer(32, send)

        self.go_state(1);
        self.in_state("Update-DR")
        self.go_state(0);
        self.in_state("Run-Test/Idle")
        return r

    def LoadBSIR_BS(self, instruction):
        self.rti();
        self.go_state(1, 1, 0, 0)
        self.in_state("Shift-IR")

        self.transfer(6, instruction)
        self.go_state(1)
        self.in_state("Update-IR")
        self.go_state(1, 0, 0)
        self.in_state("Shift-DR")
    
        bit = open("dazzler.bit", "rb").read()[0x60:]
        w = 64
        t0 = time.time()
        for i in range(0, len(bit), w):
            # print(i, len(bit))
            sub = bit[i:i + w]
            self.ser.write(b'B' + bytes([len(sub) & 0xff]) + sub)
            self.ser.read(1)
        print("took", time.time() - t0)

        self.go_state(1);
        self.go_state(1);
        self.in_state("Update-DR")
        self.go_state(0);
        self.in_state("Run-Test/Idle")

    def bitstream(self):
        self.LoadBSIR(JPROGRAM)
        self.LoadBSIR(CFG_IN)
        time.sleep(0.001)
        self.LoadBSIR_BS(CFG_IN)
        self.tlr()
        self.LoadBSIR(JSTART)

    def status(self):
        id = j.LoadBSIRthenBSDR(IDCODE, 0)
        print('IDCODE   ', hex(id))
        print('USERCODE ', hex(j.LoadBSIRthenBSDR(USERCODE, 0)))
        if id != 0x24001093:
            sys.exit(1)

if __name__ == "__main__":
    j = JTAG("/dev/serial/by-id/usb-FTDI_FT230X_Basic_UART_DO01IMGJ-if00-port0")
    j.jtag()
    j.status()
    j.bitstream()
    j.status()
