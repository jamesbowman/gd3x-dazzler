import serial
import sys
import time

def scmload(port, hexfile):
    with serial.Serial(port, 115200, timeout=.01) as ser:
        ser.read(99999)
        print('Opened port')
        ser.write(b'.\r')
        while not b'*' in ser.read():
            pass
        print('Got prompt')
        print(ser.read(80))
        with open(hexfile, "rb") as hf:
            d = hf.read().replace(b'\n', b'\r')
            for c in d:
                ser.write(bytes([c]))
        time.sleep(.1)
        ser.write(b'G 8000\r')
        ser.flush()
        print("[SENT]")
        while True:
            sys.stdout.write(ser.read(800).decode('utf-8'))

if __name__ == "__main__":
    scmload(sys.argv[1], sys.argv[2])
