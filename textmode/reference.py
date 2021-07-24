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
    vizmode = (sys.argv[1] == '-v')
    if vizmode:
        sys.argv.pop(1)

    gd = Recorder()
    if vizmode:
        gd.cmd_regwrite(eve.REG_HSIZE, 1280)
        gd.cmd_regwrite(eve.REG_VSIZE, 720)
    t = textmode.Textmode(gd)
    t.configure('L', 14)
    t.dump_fs()
    if not vizmode:
        gd.pb = b''

    fn = sys.argv[1]
    with open(fn, "rb") as f:
        def getc():
            return f.read(1)
        t.render(getc)
    with open(fn + ".ref", "wb") as f:
        f.write(gd.pb)
