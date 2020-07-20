from __future__ import print_function
import sys
from datetime import datetime
import time
import array
import struct
import os

sys.path.append("build/lib/python/")
import vsimj1a

sys.path.append("../swapforth")
sys.path.append("../../../hdmi/")
import swapforth

def oneframe(dut):
    import tv
    def mock():
        for y in range(750):
            vsync = y < 5
            for x in range(1650):
                hsync = x < 40
                de = (260 <= x < (260 + 1280)) and (25 <= y < (25 + 720))
                yield (0x112233, de, hsync, vsync)
    d = tv.Decoder()
    with open("log", "wt") as f:
        for sigs in mock():
            dut.mockeve(*sigs)
            dut.cycle()
            v = dut.hdmi()
            # f.write("%08x\n" % v)
            ch = [v & 0x3ff, (v >> 10) & 0x3ff, (v >> 20) & 0x3ff]
            (d.datum(ch))
    d.im().save("out.png")
    print('done')

class TetheredJ1a(swapforth.TetheredTarget):
    cellsize = 2

    def open_ser(self, port, speed):
        self.ser = vsimj1a.vsimj1a()

    def reset(self):
        ser = self.ser
        ser.reset()
        for c in '    1 tth !':
            ser.write(c)
        ser.write('\r')

        while 1:
            c = ser.read(1)
            # print(repr(c))
            if c == b'\x1e':
                break

    def boot(self, bootfile = None):
        sys.stdout.write('Contacting... ')
        self.reset()
        print('established')

    def interrupt(self):
        self.reset()

    def serialize(self):
        l = self.command_response('0 here dump')
        lines = l.strip().replace('\r', '').split('\n')
        s = []
        for l in lines:
            l = l.split()
            s += [int(b, 16) for b in l[1:17]]
        s = array.array('B', s).tostring().ljust(16384, b'\xff')
        return array.array('H', s)

    def extra_command(self, c):
        if c == 'oneframe':
            oneframe(self.ser)

if __name__ == '__main__':
    swapforth.main(TetheredJ1a)
