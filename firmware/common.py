import colorsys
import zlib
import math
import random
import struct
import binascii
def crc(s):     # CRC-32 of string s
    return binascii.crc32(s) & 0xffffffff

from PIL import Image, ImageFont, ImageDraw, ImageChops
import numpy as np

import bteve as eve
import gameduino2.prep
import gameduino2.convert

def lerp(t, a, b):
    return a + (b - a) * t
def smoothstep(t):
    return t * t * (3.0 - 2.0 * t)
def map(x, x0, x1, y0 = 0, y1 = 1):
    t = (x - x0) / (x1 - x0)
    t = max(0, min(t, 1))
    return lerp(t, y0, y1)

class LoggingGameduinoSPIDriver(eve.GameduinoSPIDriver):
    
    def __init__(self):
        GameduinoSPIDriver.__init__(self)

        self.seq = 0
        self.spool()

    def spool(self):
        self.cmd_dump = open("%04d.cmd" % self.seq, "wb")
        self.seq += 1

    def write(self, s):
        GameduinoSPIDriver.write(self, s)
        self.cmd_dump.write(s)

    def swap(self):
        GameduinoSPIDriver.swap(self)
        self.spool()

def hex3(u):
    return (0xff & (u >> 16), 0xff & (u >> 8), 0xff & u)

def hsv(h, s, v):
    (r, g, b) = colorsys.hsv_to_rgb(h, s, v)
    return tuple([int(c * 255) for c in (r, g, b)])

class Loader:
    def __init__(self, gd, a = 0):
        self.gd = gd
        self.a = a

    def uadd(self, d):
        self.a = (self.a + 1) & ~1
        self.gd.cmd_inflate(self.a)
        self.gd.cc(eve.align4(zlib.compress(d)))
        self.a += len(d)

    def add(self, d):
        gd = self.gd
        self.a = (self.a + 1) & ~1
        gd.cmd_memcrc(self.a, len(d), 0)
        if crc(d) == gd.result():
            print('skipping loading', len(d), 'bytes')
        else:
            self.gd.cmd_inflate(self.a)
            self.gd.cc(eve.align4(zlib.compress(d)))
        self.a += len(d)
        
    def L8(self, im):
        (w, h) = im.size
        self.gd.cmd_setbitmap(self.a, eve.L8, w, h)
        self.add(im.tobytes())

    def ARGB4(self, im):
        (w, h) = im.size
        self.gd.cmd_setbitmap(self.a, eve.ARGB4, w, h)
        (_, d) = gameduino2.convert.convert(im, False, eve.ARGB4)
        self.add(d)

    def RGB565(self, im):
        (w, h) = im.size
        self.gd.cmd_setbitmap(self.a, eve.RGB565, w, h)
        (_, d) = gameduino2.convert.convert(im, False, eve.RGB565)
        self.add(d)

    def ARGB4s(self, ims):
        im = ims[0]
        (w, h) = im.size
        self.gd.cmd_setbitmap(self.a, eve.ARGB4, w, h)
        for im in ims:
            (_, d) = gameduino2.convert.convert(im, False, eve.ARGB4)
            self.add(d)

    def L4(self, im):
        (w, h) = im.size
        self.gd.cmd_setbitmap(self.a, eve.L4, w, h)
        (_, d) = gameduino2.convert.convert(im.convert("L"), False, eve.L4)
        self.add(d)

    def Lastc(self, filename):
        gd = self.gd

        with open(filename, "rb") as f:
            (_,w,h,_,iw,_,ih,_,_,_) = struct.unpack("<IBBBHBHBHB", f.read(16))
            print(w, h, iw, ih)
            (bw, bh) = ((iw + (w - 1)) // w, (ih + (h - 1)) // h)
            d = gameduino2.prep.tile2(f.read(), bw, bh)
            gd.cmd_setbitmap(self.a, eval("eve.ASTC_%dx%d" % (w, h)), iw, ih)
            self.add(d)

class Pt:
    def __init__(self, x = None, y = None):
        (self.x, self.y) = (x, y)

    @classmethod
    def randrot(cls):
        a = random.uniform(0, 2 * math.pi)
        return cls(math.sin(a), math.cos(a))

    @classmethod
    def polar(cls, r, th):
        return cls(math.sin(th), math.cos(th)) * r

    def __add__(self, other):
        return Pt(self.x + other.x, self.y + other.y)
    def __sub__(self, other):
        return Pt(self.x - other.x, self.y - other.y)
    def __mul__(self, other):
        return Pt(self.x * other, self.y * other)
    def mag(self):
        return math.sqrt(self.x ** 2 + self.y ** 2)
    def tuple(self):
        return (self.x, self.y)

    def draw(self, gd):
        gd.Vertex2f(self.x, self.y)

    def __repr__(self):
        return "<%r, %r>" % self.tuple()

class TextElement:
    def __init__(self, ld, ttfname, h, s):
        self.eve = ld.gd
        eve = self.eve
        font = ImageFont.truetype(ttfname, h)
        im = Image.new("L", (1280, 720))
        dr = ImageDraw.Draw(im)
        dr.text((100, 100), s, font = font, fill = 255)
        self.im = im.crop(im.getbbox())
        ld.L8(self.im)

    def draw_center(self, y):
        eve = self.eve
        (w, h) = self.im.size
        eve.Vertex2f(640 - w // 2, y - h // 2)

class Branded:
    def textload(self, ld, ttfname, scale = 1.0):
        gd = self.gd
        gd.BitmapHandle(1)
        self.te_gameduino = TextElement(ld, ttfname, int(100 * scale), "GAMEDUINO 3X")
        gd.BitmapHandle(2)
        self.te_dazzler = TextElement(ld, ttfname, int(300 * scale), "dazzler")

    def textdraw(self):
        gd = self.gd
        gd.BitmapHandle(1)
        self.te_gameduino.draw_center(200)
        gd.BitmapHandle(2)
        self.te_dazzler.draw_center(450)

def norm(v):
    return v / np.amax(v)

def glow(r):
    w = 2 * r
    x = np.tile(np.linspace(-1, 1, w), w)
    y = np.repeat(np.linspace(-1, 1, w), w)
    c = np.sqrt(.10)
    gauss_x = np.exp(-(x*x) / (2 * c ** 2))
    gauss_y = np.exp(-(y*y) / (2 * c ** 2))
    t = norm(gauss_x * gauss_y)
    ti = (255 * t).astype(np.uint8).reshape(w, w)
    return Image.fromarray(ti, "L")
