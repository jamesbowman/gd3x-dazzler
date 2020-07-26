#!/usr/bin/env python
from __future__ import print_function

import sys
import time
import array
import os

# sys.path.append("../shell")
import swapforth

class TetheredJ1a(swapforth.TetheredTarget):
    cellsize = 2

    def open_ser(self, port, speed):
        try:
            import serial
        except:
            print("This tool needs PySerial, but it was not found")
            sys.exit(1)
        self.ser = serial.Serial(port, 1000000, timeout=None, rtscts=0)
        print('opened', port)

    def reset(self, fullreset = True):
        ser = self.ser

        def waitsp():
            while ser.read(1) != b' ':
                pass

        print('reset')
        if 0:
            ser.setDTR(1)
            time.sleep(.01)
            ser.setDTR(0)
        else:
            ser.setDTR(0)
            ser.break_condition = True
            time.sleep(.1)
            ser.break_condition = False
        time.sleep(.1)
        print('recv', repr(ser.read(ser.in_waiting)))

        print('waitcr')
        ser.write(b'   ')
        waitsp()
        print('got it')
        time.sleep(.05)
        print('recv', repr(ser.read(ser.in_waiting)))

        cmd = ' 1 tth !'
        for c in cmd:
            ser.write(c.encode('utf-8'))
            ser.flush()
            time.sleep(0.001)
            ser.flushInput()
            print('write', c, 'recv', repr(ser.read(ser.inWaiting())))
        ser.write(b'\r')

        while 1:
            c = ser.read(1)
            print(repr(c))
            if c == b'\x1e':
                break

    def boot(self, bootfile = None):
        sys.stdout.write('Contacting... ')
        self.reset()
        print('established')

    def interrupt(self):
        self.reset(False)

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
        if c.startswith('binclude'):
            (_, word, fn) = c.split()
        
            self.ser.write(b'\r')
            while True:
                c = self.ser.read(1)
                print('extra output char', repr(c))
                if c == bytes([30]):
                    break

if __name__ == '__main__':
    swapforth.main(TetheredJ1a)
