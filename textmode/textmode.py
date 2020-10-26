import sys
import time
import bteve as eve
import zlib
import array
import struct
import random
rr = random.randrange
from PIL import Image, ImageDraw, ImageFont, ImageFilter, ImageChops
import json

from spidriver import SPIDriver

def as565(r, g, b):
    return ((r >> 3) << 11) | ((g >> 2) << 5) | (b >> 3)

FG = 2      # Keep the foreground and background colors in EVE RAM
BG = 0

def x565(r):
    c = r["rgb"]
    return as565(c["r"], c["g"], c["b"])
c256 = [x565(r) for r in json.load(open("data.json"))]

colorblk = array.array('H',
            [c256[0], c256[7]] +
            c256).tobytes()

class Textmode:
    def __init__(self, gd, mode = 'P'):

        if mode == 'L':
            gd.cmd_setrotate(0)
            (sw, sh) = (1280, 720)
        elif mode == 'P':
            gd.cmd_setrotate(2)
            (sw, sh) = (720, 1280)

        font = ImageFont.truetype("../../../.fonts/IBMPlexMono-Medium.otf", 14)
        ch = [chr(i) for i in range(32, 255)]

        im = Image.new("L", (256, 256))
        draw = ImageDraw.Draw(im)
        for c in ch:
            draw.text((128, 128), c, font=font, fill=255)
        (x0, y0, _, _) = im.getbbox()
        im = im.crop(im.getbbox())
        # im.save("out.png")

        (w, h) = im.size

        w2 = w + 1
        h2 = h * 28 // 22
        (W, H) = (sw // w2, (sh // h2) + 1)
        ht = H * h2
        y_bar = (sh - (H - 1) * h2) // 2
        x_bar = (sw - (W * w2)) // 2

        print('Screen size', (W, H - 1))
        print('Bars', (x_bar, y_bar))

        fim = Image.new("L", (w2 * len(ch), h))
        draw = ImageDraw.Draw(fim)
        for i,c in enumerate(ch):
            draw.text(((128 - x0) + (w2 * i) + 1, (128 - y0)), c, font=font, fill=255)
        fim = fim.transpose(Image.TRANSPOSE)
        # fim.save("out.png")

        def size(a, b):
            gd.BitmapSize(eve.NEAREST, eve.BORDER, eve.BORDER, a, b)
            gd.BitmapSizeH(a >> 9, b >> 9)

        gx = w * ht             # glyph x term
        gy = w * h2             # glyph y term
        cx = 2 * H              # color x term
        cz = 2 * H * W          # color z term
        wh = w * h
        sz = w * W * h2 * H

        cm = len(colorblk)
        fm = cm + 2 * cz
        fb = fm + len(fim.tobytes())

        self.gd = gd

        self.gx = gx
        self.gy = gy
        self.cx = cx
        self.cz = cz
        self.wh = wh
        self.sz = sz
        self.cm = cm
        self.fm = fm
        self.fb = fb
        self.w2 = w2
        self.h2 = h2
        self.w = w
        self.h = h
        self.W = W
        self.H = H

        gd.Clear()
        gd.swap()

        gd.cmd_memwrite(0, len(colorblk))
        gd.cc(eve.align4(colorblk))

        gd.cmd_inflate(fm)
        c = eve.align4(zlib.compress(fim.tobytes()))
        gd.cc(c)

        gd.BitmapHandle(0)
        gd.cmd_setbitmap(fb, eve.L8, h, w2 * W)
        size(w2 * W, h)
        gd.cmd_memzero(fb, H * h * w2 * W)

        gd.BitmapHandle(1)
        gd.cmd_setbitmap(cm, eve.RGB565, W, 1)
        size(w2 * W, h2)
        if 1:
            random.seed(0)
            b = bytes([rr(256) for i in range(2 * 2 * W * H)])
            gd.cmd_memwrite(cm, len(b))
            gd.cc(eve.align4(b))

        def gaddr(x, y):
            return fb + x * (w2 * h) + y * (w2 * h * W)
        def caddr(x, y, z):
            return cm + 2 * (x + W * (y + (z * H)))
        def drawch(x, y, c, color = 0xffff, bg = 0x0000):
            dst = gaddr(x, y)
            src = fm + (ord(c) - 0x20) * (w2 * h)
            gd.cmd_memcpy(dst, src, w2 * h)

            gd.cmd_memwrite(caddr(x, y, 0), 2)
            gd.cc(struct.pack("<I", color))
            gd.cmd_memwrite(caddr(x, y, 1), 2)
            gd.cc(struct.pack("<I", bg))
        for i in range(20):
            drawch(0, i, str(i % 10))
            if i & 1:
                drawch(W - 1, i, str(i % 10))
                
        def colorpass(z):
            gd.SaveContext()
            gd.BitmapHandle(1)
            gd.BitmapSource(caddr(0, 0, z))
            gd.BitmapTransformA(0x8000 // w2, 1)
            gd.BitmapTransformC(0x10)
            gd.BitmapTransformE(0)
            for i in range(H - 1):
                gd.Cell(i)
                gd.Vertex2f(0, i * h2)
            gd.RestoreContext()

        gd.VertexFormat(0)
        gd.ClearColorA(0)
        gd.Clear()
        gd.Begin(eve.BITMAPS)
        gd.ColorMask(1, 1, 1, 0)
        colorpass(1)

        gd.SaveContext()
        gd.ColorMask(0, 0, 0, 1)
        gd.BlendFunc(1, 0)
        gd.BitmapTransformA(0)
        gd.BitmapTransformB(0x8000, 1)
        gd.BitmapTransformD(0x8000, 1)
        gd.BitmapTransformE(0)
        gd.BitmapHandle(0)
        for i in range(H - 1):
            gd.Cell(i)
            gd.Vertex2f(0, i * h2)
        gd.RestoreContext()

        gd.ColorMask(1, 1, 1, 0)
        gd.BlendFunc(eve.DST_ALPHA, eve.ONE_MINUS_DST_ALPHA)
        colorpass(0)

        gd.swap()

        self.colors = (7, 0)

    def gaddr(self, x, y):
        return self.fb + x * (self.w2 * self.h) + y * (self.w2 * self.h * self.W)

    def caddr(self, x, y, z):
        return self.cm + 2 * (x + self.W * (y + (z * self.H)))

    def drawch(self, x, y, c):
        gd = self.gd
        dst = self.gaddr(x, y)
        src = self.fm + (c - 0x20) * (self.w2 * self.h)
        gd.cmd_memcpy(dst, src, self.w2 * self.h)

        a = self.caddr(x, y, 0)
        gd.cmd_memcpy(a, FG, 2)
        gd.cmd_memcpy(a + self.cz, BG, 2)


    def dump_fs(self):
        with open("_textmode.fs", "wt") as f:
            f.write("%d constant t.fm\n" % self.fm)
            f.write("%d constant t.ca\n" % self.caddr(0, 0, 0))
            f.write("%d constant t.ca1\n" % (2 * self.W * self.H))
            fb = self.gaddr(0, 0)
            f.write("%d constant t.fb\n" % fb)
            f.write("%d constant t.g\n" % (self.w2 * self.h))
            f.write("%d constant t.W\n" % self.W)
            f.write("%d constant t.H\n" % self.H)

    def cls(self):
        gd = self.gd
        a = self.caddr(0, 0, 0)
        s = self.caddr(0, 0, 2) - a
        gd.cmd_memcpy(a, 0, 2)
        gd.cmd_memcpy(a + 2, a, s - 2)

    def pattern(self):
        for i in range(self.W):
            for j in range(self.H - 1):
                if (i ^ j) & 1:
                    self.drawch(i, j, ord('M'))

    def handle_m(self, args):
        gd = self.gd
        (fg, bg) = self.colors
        while args:
            g = args.pop(0)
            if g == 0:
                fg,bg = (7, 0)
            elif g == 1:
                fg |= 8
            elif g == 5:
                bg |= 8
            elif 30 <= g <= 37:
                fg = (g - 30) | (fg & 8)
            elif g == 39:
                fg = 7 | (fg & 8)
                print('fg', fg)
            elif 40 <= g <= 47:
                bg = (g - 40) | (bg & 8)
            elif g == 49:
                bg = 0 | (bg & 8)
            elif g in (29,):
                pass
            elif g == 38:
                if args.pop(0) == 5:
                    fg = args.pop(0)
            elif g == 48:
                if args.pop(0) == 5:
                    bg = args.pop(0)
            else:
                assert 0, repr(g)
        gd.cmd_memcpy(BG, 4 + 2 * bg, 2)
        gd.cmd_memcpy(FG, 4 + 2 * fg, 2)
        self.colors = (fg, bg)

    def render(self, getc):
        (cx, cy) = (0, 0)
        cs = []
        gd = self.gd
        while True:
            c = getc()
            if not c:
                break
            if c[0] == 10:
                cy += 1
            elif c[0] == 13:
                cx = 0
            elif c[0] == 27:
                if getc() != b'[':
                    continue
                args = b''
                while True:
                    c = getc()
                    if b'\x30' <= c <= b'\x3f':
                        args += c
                    else:
                        break
                if c == b'':
                    break
                def default(s, n):
                    if s:
                        return int(s)
                    return n
                print('code', c)
                if c == b'A':
                    cy = max(0, (cy - default(args, 1)))
                elif c == b'B':
                    cy = min((self.H - 1) - 1, cy + default(args, 1))
                elif c == b'C':
                    # assert cx + default(args, 1) < columns, (cx, default(args, 1))
                    cx = min(self.W - 1, cx + default(args, 1))
                elif c == b'D':
                    cx = max(0, cx - default(args, 1))
                elif c in b'Hf':
                    aa = [default(a, 1) for a in args.split(b';')]
                    if len(aa) == 2:
                        assert 0
                        (cx, cy) = (aa[1] - 1, aa[0] - 1)
                    else:
                        (cx, cy) = (0, aa[0] - 1)
                elif c == b'J':
                    c = default(args, 0)
                    if c == 0:
                        self.clrteol()
                    elif c == 2:
                        (cx, cy) = (0, 0)
                        self.cls()
                    else:
                        assert 0, c
                elif c == b's':
                    cs.append((cx, cy))
                elif c == b'u':
                    (cx, cy) = cs.pop(-1)
                elif c == b'm':
                    self.handle_m([default(a, 0) for a in args.split(b';')])
                else:
                    print('seq %s: ' % c, args)
            else:
                print(cx, cy)
                self.drawch(cx, cy, c[0])
                cx += 1
                if cx == self.W:
                    (cx, cy) = (0, cy + 1)
            if cy == self.H:
                lastline = columns * ((self.H - 1) - 1) * 2
                e.cmd_memcpy(0, 160, lastline)
                e.cmd_memset(lastline, 0, 2 * columns)
                cy -= 1

        
if __name__ == "__main__":
    gd = eve.GameduinoSPIDriver(SPIDriver(sys.argv[1]))
    gd.init()
    t = Textmode(gd, 'L')
    if 1:
        t.cls()
        # t.pattern()
        fn = "ans/786welcc.ans"
        fn = "256color.ans"
        fn = "intro.ans"
        with open(fn, "rb") as f:
            def getc():
                return f.read(1)
            t.render(getc)
    gd.flush()
