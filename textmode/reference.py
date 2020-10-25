import bteve as eve
import textmode

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

    fn = "ans/786welcc.ans"
    fn = "256color.ans"
    fn = "intro.ans"
    fn = "empty.ans"
    fn = "A.ans"
    with open(fn, "rb") as f:
        def getc():
            return f.read(1)
        t.render(getc)
    with open(fn + ".ref", "wb") as f:
        f.write(gd.pb)
