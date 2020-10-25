import sys
import bteve as eve
import textmode
import array

class Recorder(eve.Gameduino):
    
    def __init__(self):
        eve.Gameduino.__init__(self)

        self.pb = b''

    def cc(self, s):
        self.pb += s

    def flush(self):
        pass

if __name__ == "__main__":
    gd = Recorder()
    t = textmode.Textmode(gd, 'L')
    t.dump_fs()
    gd.pb = b''

    fn = sys.argv[1]
    with open(fn, "rb") as f:
        def getc():
            return f.read(1)
        t.render(getc)
    with open(fn + ".ref", "wb") as f:
        f.write(gd.pb)
    if 1:
        [print("%08x" % x) for x in array.array("I", gd.pb)]
        print()
