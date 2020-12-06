import sys
import textwrap
import struct
import array
from PIL import Image, ImageDraw, ImageFont, ImageFilter, ImageChops
import bteve as eve
import zlib
import wave
from io import BytesIO
from itertools import groupby
from gameduino2.convert import convert
import random
import binascii
def crc(s):     # CRC-32 of string s
    return binascii.crc32(s) & 0xffffffff
import common
from spidriver import SPIDriver

sys.path.append("../textmode")
import textmode

random.seed(7)
rr = random.randrange

__VERSION__ = "1.0.6"

FONTDIR="../../../.fonts/"

def gentext(s):
    fn = FONTDIR + "Arista-Pro-Alternate-Light-trial.ttf"
    font = ImageFont.truetype(fn, 250)
    im = Image.new("L", (2000, 1000))
    draw = ImageDraw.Draw(im)
    draw.text((200, 200), s, font=font, fill = 255)
    glow = im.filter(ImageFilter.GaussianBlur(10))
    im = ImageChops.add(im, glow)
    return im.crop(im.getbbox())

def preview(cmdbuf):
    print('preview is', len(cmdbuf), 'bytes')
    d = SPIDriver("/dev/serial/by-id/usb-FTDI_FT230X_Basic_UART_DO02C71A-if00-port0")
    from bteve.gameduino_spidriver import GameduinoSPIDriver
    gd = GameduinoSPIDriver(d)
    gd.init()
    gd.cc(cmdbuf)
    gd.finish()
    
class Gameduino(eve.Gameduino):
    def __init__(self):
        self.buf = b''

    def cc(self, s):
        assert (len(s) % 4) == 0
        self.buf += s

    def pack(self):
        print(len(self.buf), "bytes used")
        while len(self.buf) < (4096 - 4):
            self.cmd_dlstart()
        self.cc(struct.pack("I", 0x7c6a0100))
        assert len(self.buf) == 4096

    def flush(self):
        pass

    def finish(self):
        pass

    def video_signal(self, h_Active, h_Front, h_Sync, h_Back, h_Total, v_Active, v_Front, v_Sync, v_Back, v_Total):
        assert((h_Active + h_Front + h_Sync + h_Back) == h_Total)
        assert((v_Active + v_Front + v_Sync + v_Back) == v_Total)

        # self.cmd_regwrite(eve.REG_ADAPTIVE_FRAMERATE, 0)

        self.cmd_regwrite(eve.REG_HCYCLE, h_Total)
        self.cmd_regwrite(eve.REG_HOFFSET, h_Sync + h_Back)
        self.cmd_regwrite(eve.REG_HSIZE, h_Active)

        self.cmd_regwrite(eve.REG_VCYCLE, v_Total)
        self.cmd_regwrite(eve.REG_VOFFSET, v_Sync + v_Back)
        self.cmd_regwrite(eve.REG_VSIZE, v_Active)

        # See CEA-861 p.21
        self.cmd_regwrite(eve.REG_HSYNC1, 0)
        self.cmd_regwrite(eve.REG_HSYNC0, h_Sync)

        self.cmd_regwrite(eve.REG_VSYNC1, 0)
        self.cmd_regwrite(eve.REG_VSYNC0, v_Sync)

        if 0:
            self.cmd_regwrite(eve.REG_TRIM, 23)
            self.cmd_regwrite(0x302614, 0x8c1)

        self.cmd_regwrite(eve.REG_PCLK, 1)
    def setup_1280x720(self):
        if 1:

            self.Clear()
            self.swap()
            setup = [
                (eve.REG_OUTBITS, 0),
                (eve.REG_DITHER, 0),
                (eve.REG_GPIO, 0x83),
                (eve.REG_CSPREAD, 0),
                (eve.REG_PCLK_POL, 0),
                (eve.REG_ADAPTIVE_FRAMERATE, 0),
            ]
            for (a, v) in setup:
                self.cmd_regwrite(a, v)

            self.video_signal(
                h_Active = 1280,
                h_Front = 110,
                h_Sync = 40,
                h_Back = 220,
                h_Total = 1650,
                v_Active = 720,
                v_Front = 5,
                v_Sync = 5,
                v_Back = 20,
                v_Total = 750)
            self.w = 1280
            self.h = 720
            return

    def setup_640_480(self):
        if 1:

            self.Clear()
            self.swap()
            setup = [
                # (eve.REG_OUTBITS, 0),
                (eve.REG_DITHER, 0),
                (eve.REG_GPIO, 0x83),
                (eve.REG_CSPREAD, 0),
                (eve.REG_PCLK_POL, 0),
                (eve.REG_ADAPTIVE_FRAMERATE, 0),

                (eve.REG_HCYCLE, 800),
                (eve.REG_HOFFSET, 16 + 96),
                (eve.REG_HSIZE, 640),

                (eve.REG_HSYNC1, 0),
                (eve.REG_HSYNC0, 96),

                (eve.REG_VCYCLE, 525),
                (eve.REG_VOFFSET, 12),
                (eve.REG_VSIZE, 480),

                (eve.REG_VSYNC1, 0),
                (eve.REG_VSYNC0, 10),
            ]
            for (a, v) in setup:
                self.cmd_regwrite(a, v)

        if 0:
            self.cmd_regwrite(eve.REG_TRIM, 23)
            self.cmd_regwrite(0x302614, 0x8c1)

        self.cmd_regwrite(eve.REG_PCLK, 3)
        self.w = 640
        self.h = 480

def make_fallback():
    gd = Gameduino()
    # gd.setup_640_480()
    gd.setup_1280x720()

    gd.ClearColorRGB(0, 40, 0)
    gd.Clear()
    gd.cmd_text(100, 100, 31, 0, "FALLBACK")
    gd.swap()

    return gd.buf

def sector_1():
    gd = Gameduino()
    gd.setup_1280x720()
    gd.pack()
    return gd.buf

def make_flash():
    gd = Gameduino()
    blob_addr = 0x8000
    gd.cmd_inflate(blob_addr)
    img = open("assets/unified.blob", "rb").read() + sector_1()
    assert len(img) == 8192
    c = eve.align4(zlib.compress(img, 9))
    gd.cc(c)
    gd.cmd_flashupdate(0, blob_addr, len(img))
    gd.cmd_flashfast()
    return gd.buf

def make_bringup():
    gd = Gameduino()
    gd.setup_1280x720()

    if 1:
        gd.VertexFormat(0)
        gd.ClearColorRGB(0xff, 0xff, 0xff)
        gd.SaveContext()
        gd.Clear()
        gd.ClearColorRGB(0, 0, 0)
        gd.ScissorSize(1280 - 2, 720 - 2)
        gd.ScissorXY(1, 1)
        gd.Clear()

        (x0, x1) = (20, 1280 - 20)
        (y, H, Y) = (20, 50, 120)
        for i,(cname, rgb) in enumerate([("red", 0xff0000), ("green", 0xff00), ("blue", 0xff), ("white", 0xffffff)]):
            gd.ScissorSize(x1 - x0, H)
            gd.ScissorXY(x0, y)
            gd.cmd_gradient(x0, 0, 0x000000, x1, 0, rgb)
            y += Y
        gd.RestoreContext()

        gd.cmd_setbitmap(0, eve.RGB332, 1, 1)
        gd.BitmapSize(eve.NEAREST, eve.REPEAT, eve.REPEAT, 40, 40)

        def part(i, name):
            x = 200 + 300 * (i // 3)
            y = 470 + 60 * (i % 3)
            gd.cmd_text(x + 190, y, 31, eve.OPT_RIGHTX, name + "")
            gd.Cell(i)
            gd.Vertex2f(x + 220, y + 5)
        tests = ["flash U2",
                 "flash U4",
                 "U4 quad",
                 "EVE audio",
                 "EVE quad",
                 "video bus",
                 "i2c",
                 "clock",
                 "Loaded" ]
        [part(i, n) for (i, n) in enumerate(tests)]
        gd.cmd_memset(0, 0b01001001, len(tests)) # all gray initially

        gd.cmd_text(640, 690, 31, eve.OPT_CENTER, __VERSION__)

        if 0:
            gd.Cell(0)
            gd.cmd_setbitmap(0x1000, eve.RGB565, 512, 400)
            gd.Vertex2f(5, 5)

        gd.ColorRGB(0xe0, 0xe0, 0xe0)
        gd.cmd_text(10, 690, 29, eve.OPT_CENTERY | eve.OPT_FORMAT, "%s", 0xb0000)
        gd.cmd_text(1270, 690, 29, eve.OPT_RIGHTX | eve.OPT_CENTERY | eve.OPT_FORMAT, "%s", 0xb0100)

        gd.swap()

    return gd.buf

# 8-bit display, controlled by ClearStencil:
#   0-3 slot highlight
#   4   microSD on
#   5   Player 1 on
#   6   Player 2 on

def make_menu():
    gd = Gameduino()

    if 1:
        gd.cmd_memwrite(eve.REG_MACRO_0, 4)
        gd.ClearStencil(0x10 | 0x08 | 2)

    if 0:
        gd.cmd_memzero(0x0, 32 * 8)
        def setlabel(n, s):
            gd.cmd_memwrite(32 * n, len(s) + 1)
            gd.cc(eve.align4(s + bytes([0])))
        setlabel(0, b"Dazzler boot 1.1.0")
        setlabel(1, b"Text mode 1.1.0")
        setlabel(2, b"Asteroids")

    gd.setup_1280x720()

    ld = common.Loader(gd, 0x200)
    ld.add = ld.uadd

    # Handle 0: microSD
    gd.BitmapHandle(0)
    im = Image.open("assets/microsd.png").convert("L")
    ld.L8(im)

    # Handle 1: Wii
    gd.BitmapHandle(1)
    im = Image.open("assets/Wii_Classic_Controller_Icon.png").convert("L")
    ld.L8(im)

    gd.VertexFormat(2)
    gd.ClearColorRGB(0x20, 0x00, 0x00)
    gd.Macro(0)
    gd.Clear()
    gd.StencilMask(0)

    rim = [
        (96, (0x40, 0x40, 0x40)),
        (64, (0x18, 0x00, 0x00))]

    px = 110 - 4
    for s in range(8):
        y = 90 * s
        gd.Begin(eve.RECTS)
        for (w,col) in rim:
            gd.ColorRGB(*col)
            gd.LineWidth(w)
            gd.Vertex2f(110, y + 10)
            gd.Vertex2f(700, y + 80)

        gd.SaveContext()
        gd.StencilFunc(eve.EQUAL, s, 0x07)
        gd.ColorRGB(0x40, 0x40, 0x40)
        gd.Vertex2f(110, y + 10)
        gd.Vertex2f(700, y + 80)
        gd.RestoreContext()

        gd.Begin(eve.POINTS)
        for (w,col) in rim:
            gd.ColorRGB(*col)
            gd.PointSize(16 * 20 + w)
            gd.Vertex2f(px, y + 45)

        gd.ColorRGB(0xff, 0xff, 0xff)
        gd.cmd_number(px, y + 45, 29, eve.OPT_CENTER, s)
        gd.cmd_text(160, y + 45, 30, eve.OPT_CENTERY | eve.OPT_FORMAT, "%s", 32 * s)

    s = "Press A to launch the slot. Press X to load it from microSD"
    gd.ColorRGB(255, 255, 255)
    gd.cmd_fillwidth(400)
    gd.cmd_text(810, 110, 30, eve.OPT_FILL, s)

    gd.Begin(eve.BITMAPS)

    def light(mask, dr):
        gd.StencilFunc(eve.ALWAYS, 0, 0)
        gd.ColorRGB(0x40, 0x40, 0x40)
        dr()
        gd.StencilFunc(eve.EQUAL, mask, mask)
        gd.ColorRGB(0xc0, 0xc0, 0xc0)
        dr()

    gd.BitmapHandle(0)
    light(0x08, lambda: gd.Vertex2f(740, 610))

    gd.BitmapHandle(1)
    light(0x10, lambda: gd.Vertex2f(824, 600))

    light(0x20, lambda: gd.Vertex2f(1050, 600))

    gd.swap()

    for i in range(0):
        for j in range(10):
            gd.cmd_sync()
        gd.cmd_memwrite(eve.REG_MACRO_0, 4)
        gd.ClearStencil(i)
    return gd.buf

def poweron():
    gd = Gameduino()
    gd.setup_1280x720()

    # Make sure $c0000 is 0x15
    gd.cmd_memwrite(0xc0000, 1)
    gd.cc(b'\x15' * 4)

    ld = common.Loader(gd)
    ld.add = ld.uadd

    # Handle 0: gameduino logo
    gd.BitmapHandle(0)
    im = Image.open("assets/gameduino.png").convert("RGB")
    ld.RGB565(im)
    (w, h) = im.size
    gd.BitmapSize(eve.NEAREST, eve.BORDER, eve.BORDER, 0, 3 * h)

    # Handle 1: grid
    H = 0x60
    grid = Image.frombytes("L", (4, 4), bytes([
        H, H, H, H,
        H, 0, 0, 0,
        H, 0, 0, 0,
        H, 0, 0, 0]))
    gd.BitmapHandle(1)
    ld.L8(grid)
    gd.BitmapSize(eve.BILINEAR, eve.REPEAT, eve.REPEAT, 0, 3 * h)

    # Handle 2: dazzler glowing text
    daz = gentext("dazzler")
    gd.BitmapHandle(2)
    ld.L8(daz)


    gd.ClearColorRGB(0x20, 0x00, 0x00)
    gd.Clear()
    gd.Begin(eve.BITMAPS)

    gd.SaveContext()
    gd.cmd_scale(3, 3)
    gd.cmd_setmatrix()
    gd.BitmapHandle(0)
    gd.Vertex2f((1280 - 3*w) / 2, 65)
    gd.RestoreContext()

    gd.SaveContext()
    gd.cmd_loadidentity()
    gd.cmd_scale(0.75, 0.75)
    gd.cmd_setmatrix()
    gd.ColorRGB(0x20, 0x00, 0x00)

    gd.BitmapHandle(1)
    gd.Vertex2f(0, 0)
    gd.RestoreContext()

    gd.BitmapHandle(2)
    gd.ColorA(0xf0)
    (x, y) = ((1280 - daz.size[0]) / 2, 380)
    gd.Vertex2f(x, y)

    gd.cmd_text(640, 690, 31, eve.OPT_CENTER, __VERSION__)
    gd.ColorRGB(0xe0, 0xe0, 0xe0)
    gd.cmd_text(10, 690, 29, eve.OPT_CENTERY | eve.OPT_FORMAT, "%s", 0xb0000)
    gd.cmd_text(1270, 690, 29, eve.OPT_RIGHTX | eve.OPT_CENTERY | eve.OPT_FORMAT, "%s", 0xb0100)

    gd.swap()
    print('poweron is', len(gd.buf), 'bytes')
    return gd.buf

def make_loadflash(fn, fl):
    cd = zlib.compress(fl, 9)
    print('%s: bitstream is %d bytes, compresses to %d bytes' % (fn, len(fl), len(cd)))
    assert len(fl) % 256 == 0, len(fl)
    LP = 0x1000 # load point
    gd = Gameduino()
    gd.cmd_inflate(LP)
    gd.cc(eve.align4(cd))
    ecrc = crc(fl)

    gd.cmd_memwrite(0xffff8, 8)
    gd.c4(len(fl))
    gd.c4(ecrc)
    gd.cmd_memcrc(LP, len(fl), 0)
    print('Expected CRC %x' % crc(fl))

    b = gd.buf
    padw = (-len(b) & 0xff) // 4
    b = (padw * struct.pack("I", 0xffffff5b)) + b
    with open(fn, "wb") as h:
        h.write(b)

    with open(fn.replace(".bin", ".h"), "wt") as f:
        for i in range(0, len(b), 100):
            f.write("".join(["%d," % x for x in b[i:i + 100]]) + "\n")

def bootheader(s):
    return (
        bytes([0xda,0x22,0x1e,0x55]) +
        (s.encode('utf-8') + b"\x00").ljust(32, b'\xff'))

with open("../dazzler.bit", "rb") as f:
    dazzler_bit = f.read()[96:]
    desync = bytes([0x30, 0xa1, 0x00, 0x0d])
    set_general5 = bytes([0x32, 0xe1, 0xda, 0x22])
    dazzler_bit = dazzler_bit.replace(desync, desync + set_general5)

with open("_jtagboot.h", "wt") as f:
    for i in range(0, len(dazzler_bit), 100):
        f.write("".join(["%d,"%b for b in dazzler_bit[i:i + 100]]) + "\n")

def make_heavyboot(title, streams, binfile):
    fl = bootheader(title) + dazzler_bit
    fl = fl.ljust(0x54000, b'\xff')
    def autoexec(cmd):
        return (fl + cmd).ljust(0x54100, b'\xff')
    def cust():
        f = autoexec(b'poweron')
        f = f.ljust(512 * 1024, b'\xff')
        f += struct.pack("H", 0x947a)
        for s in streams:
            f += struct.pack("I", len(s)) + s
        f += b'\xff' * (-len(f) & 0xff)
        return f
    make_loadflash(binfile, cust())

def make_liteboot(title, hexfile, streams, binfile):
    with open(hexfile) as f:
        code = array.array("H", [int(w, 16) for w in f]).tobytes()
    fl = (bootheader(title) + b'aZ' + code)
    fl = fl.ljust(512 * 1024, b'\xff')
    fl += struct.pack("H", 0x947a)
    for s in streams:
        fl += struct.pack("I", len(s)) + s
    fl += b'\xff' * (-len(fl) & 0xff)
    make_loadflash(binfile, fl)

def dump_include(filename, bb, op = ">spi"):
    tb = " ".join([("%d %s" % (b, op)) for b in bb])
    with open(filename, "wt") as f:
        f.write("eve-start stream\n")
        f.write(textwrap.fill(tb, 127))
        f.write("\nfinish\n")

def dump_init(filename, bb):
    print(filename, "is", len(bb) // 4)
    lc = len(bb) // 4
    tb = " ".join([("%d %s" % (b, "c,")) for b in [lc] + list(bb)])
    with open(filename, "wt") as f:
        f.write(textwrap.fill(tb, 127))
        f.write("\n")

def make_sector_1():
    gd = Gameduino()
    gd.setup_1280x720()
    gd.pack()
    print("Sector 1 CRC %08X" % crc(gd.buf))
    cd = eve.align4(zlib.compress(gd.buf, 9))
    with open("_sector1.h", "wt") as f:
        f.write(",".join([str(s) for s in cd]))
        f.write("\n")

def sample(fn):
    with wave.open(fn, 'rb') as wf:
        nf = wf.getnframes()
        by = array.array('H', wf.readframes(nf))
        mono = by[::2]
        return mono.tobytes()

if __name__ == "__main__":
    make_sector_1()

    br = make_bringup()
    dump_init("_bringup.fs", br)

    fl = make_flash()
    dump_init("_flash.fs", fl)

    au = sample("assets/bassoon-g4.wav")

    po = poweron()
    fa = make_fallback()
    me = make_menu()
    # print([hex(i) for i in array.array('I', me[:32])])
    # preview(me)
    dump_include("_fallback.fs", fa)

    # ---------------------------- Base
    make_heavyboot("Dazzler boot (%s)" % __VERSION__,
                   [po, me, au],
                   "_loadflash_base.bin")

    # ---------------------------- Asteroids
    gd = Gameduino()
    gd.setup_1280x720()


    sfx = [
        "explode1.wav",
        "explode2.wav",
        "explode3.wav",
        "fire.wav",
        "life.wav",
        "lsaucer.wav",
        "sfire.wav",
        "ssaucer.wav",
        "thrust.wav",
        "thumphi.wav",
        "thumplo.wav"
    ]

    ld = common.Loader(gd)
    ld.add = ld.uadd
    ld.Lastc("assets/asteroids_internal.astc")

    gd.Clear()
    gd.cmd_text(640, 360, 31, eve.OPT_CENTER, "Asteroids is loading")
    gd.Vertex2f(0, 0)
    gd.swap()

    make_liteboot("Asteroids",
                  "../j1/build/asteroids.hex",
                  [gd.buf],
                  "_loadflash_asteroids.bin")

    # ---------------------------- Textmode
    gd = Gameduino()
    gd.setup_1280x720()
    t = textmode.Textmode(gd, 'L')
    t.dump_fs()

    with open("../textmode/textmode.gd2", "rb") as f:
        textmode_l = f.read()
    make_liteboot("Text mode",
                  "../j1/build/textmode.hex",
                  [gd.buf],
                  "_loadflash_textmode.bin")
