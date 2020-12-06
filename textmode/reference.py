import sys
import bteve as eve
import textmode
import array
import textwrap

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
    gd.pb = b''

    fn = sys.argv[1]
    with open(fn, "rb") as f:
        def getc():
            return f.read(1)
        t.render(getc)
    with open(fn + ".ref", "wb") as f:
        f.write(gd.pb)
    if 0:
        [print("%08x" % x) for x in array.array("I", gd.pb)]
        print()

    with open(fn, "rb") as f:
        dd = f.read()
        tb = " ".join([("%d c," % b) for b in dd])
        with open(fn + ".fs", "w") as fs:
            fs.write("here\n")
            fs.write(textwrap.fill(tb, 127))
            fs.write("\n%d setbuf terminal\n" % len(dd)) 
