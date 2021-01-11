import sys
import textwrap
import struct
import array
from PIL import Image, ImageDraw, ImageFont, ImageFilter, ImageChops
import bteve as eve
import zlib
import wave
import binascii
def crc(s):     # CRC-32 of string s
    return binascii.crc32(s) & 0xffffffff
import common

sys.path.append("../textmode")
import textmode

__VERSION__ = "1.1.0"

LP = 0x1000 # load point for flash images
FONTDIR="../fonts/"

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
    from spidriver import SPIDriver

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

        self.cmd_regwrite(eve.REG_PCLK, 1)

    def setup_1280x720(self):
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

# 8-bit display, controlled by ClearStencil:
#   0-3 slot highlight
#   4   microSD on
#   5   Player 1 on
#   6   Player 2 on

def make_menu():
    gd = Gameduino()

    if 1:
        gd.cmd_memwrite(eve.REG_MACRO_0, 4)
        gd.ClearStencil(0x20 | 0x10 | 0x08 | 2)

    if 0:
        gd.cmd_memzero(0x0, 32 * 8)
        def setlabel(n, s):
            gd.cmd_memwrite(32 * n, len(s) + 1)
            gd.cc(eve.align4(s + bytes([0])))
        setlabel(0, b"Dazzler boot 1.1.0")
        setlabel(1, b"Text mode 1.1.0")
        setlabel(2, b"Asteroids")
        setlabel(7, b"SAYS 7")

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

def make_messagebox():
    gd = Gameduino()

    if 0:
        gd.cmd_memzero(0x0, 32 * 8)
        def setlabel(n, s):
            gd.cmd_memwrite(32 * n, len(s) + 1)
            gd.cc(eve.align4(s + bytes([0])))
        setlabel(0, b"[MESSAGE 123abc]")

    gd.VertexFormat(2)
    gd.ClearColorRGB(0x20, 0x00, 0x00)
    gd.Clear()

    gd.cmd_text(640, 240, 31, eve.OPT_CENTER | eve.OPT_FORMAT, "%s", 0)

    s = "Press START to return to the boot menu"
    gd.cmd_text(640, 480, 31, eve.OPT_CENTER, s)

    gd.swap()

    for i in range(0):
        for j in range(10):
            gd.cmd_sync()
        gd.cmd_memwrite(eve.REG_MACRO_0, 4)
        gd.ClearStencil(i)
    return gd.buf

def make_loadscreen():
    gd = Gameduino()

    gd.cmd_memwrite(eve.REG_MACRO_0, 4)
    gd.ClearStencil(0)

    gd.cmd_memzero(0, 2**20)
    if 0:
        gd.cmd_memset(0, 0x69, 2**20)
        gd.cmd_memwrite(0, 2**16)
        import random
        gd.cc(bytes([random.randrange(0x40, 0x60) for _ in range(2**16)]))

    gd.BitmapHandle(0)
    gd.cmd_setbitmap(0, eve.RGB565, 256, 128)
    gd.BitmapSize(eve.NEAREST, eve.BORDER, eve.BORDER, 4 * 256, 4)
    gd.BitmapSizeH((4 * 256) >> 9, (4) >> 9)

    ld = common.Loader(gd, 2**20-8-16)
    ld.add = ld.uadd
    H = 150
    grid = Image.frombytes("L", (4, 4), bytes([
        H, H, H, H,
        H, 0, 0, 0,
        H, 0, 0, 0,
        H, 0, 0, 0]))
    gd.BitmapHandle(1)
    ld.L8(grid)
    gd.BitmapSize(eve.NEAREST, eve.REPEAT, eve.REPEAT, 4 * 256, 4 * 128)
    gd.BitmapSizeH((4 * 256) >> 9, (4 * 128) >> 9)

    gd.BitmapHandle(2)
    gd.cmd_setbitmap(LP + 4, eve.TEXT8X8, 8 * 32, 8 * 1)
    gd.BitmapSize(eve.NEAREST, eve.BORDER, eve.BORDER, 512, 16)
    gd.BitmapSizeH(512 >> 9, 16 >> 9)

    gd.VertexFormat(2)
    gd.ClearColorRGB(0x20, 0x00, 0x00)
    gd.Macro(0)
    gd.Clear()
    gd.StencilMask(0)

    gd.StencilFunc(eve.EQUAL, 0, 0xff)
    gd.cmd_text(640, 60, 31, eve.OPT_CENTER, "Unpacking slot image, please wait")

    gd.StencilFunc(eve.EQUAL, 1, 0xff)
    gd.cmd_text(640, 60, 31, eve.OPT_CENTER, "Writing to flash, please wait")

    gd.StencilFunc(eve.ALWAYS, 1, 0xff)

    gd.Begin(eve.BITMAPS)
    gd.SaveContext()
    gd.ColorRGB(200, 255, 200)
    gd.cmd_scale(2, 2)
    gd.cmd_setmatrix()
    gd.BitmapHandle(2)
    gd.Vertex2f(640 - 256, 120)
    gd.RestoreContext()

    gd.SaveContext()
    gd.cmd_loadidentity()
    gd.cmd_scale(4, 4)
    gd.cmd_setmatrix()
    gd.BitmapHandle(0)
    gd.BlendFunc(1, 0)
    (x, y) = ((1280 - 1024) / 2, (720 - 512) / 2 + 80)
    for i in range(128):
        gd.BitmapSource(LP + 8192 * i)
        gd.Vertex2f(x, y + 4 * i)
    gd.RestoreContext()

    gd.BitmapHandle(1)
    gd.ColorRGB(0, 0, 0)
    gd.Vertex2f(x, y)

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
    print('%s: flash image is %d bytes, compresses to %d bytes' % (fn, len(fl), len(cd)))
    assert len(fl) % 256 == 0, len(fl)
    gd = Gameduino()
    gd.cmd_inflate(LP)
    gd.cc(eve.align4(cd))
    ecrc = crc(fl)

    gd.cmd_memwrite(0xffff8, 8)
    gd.c4(len(fl))
    gd.c4(ecrc)
    gd.cmd_memcrc(LP, len(fl), 0)
    print('Expected CRC %x' % ecrc)

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

def set_da22(fl):
    desync = bytes([0x30, 0xa1, 0x00, 0x0d])
    set_general5 = bytes([0x32, 0xe1, 0xda, 0x22])
    return fl.replace(desync, set_general5 + desync)

with open("../dazzler.bit", "rb") as f:
    bitfile = f.read()

bitfile_da22 = set_da22(bitfile)
open("../dazzler-da22.bit", "wb").write(bitfile_da22)
bit_da22 = bitfile_da22[96:]

dazzler_bit = bitfile[96:]
# dazzler_bit = dazzler_bit.replace(desync, set_general5 + desync)

with open("_jtagboot.h", "wt") as f:
    for i in range(0, len(bit_da22), 100):
        f.write("".join(["%d,"%b for b in bit_da22[i:i + 100]]) + "\n")

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

def sample(fn):
    with wave.open(fn, 'rb') as wf:
        nf = wf.getnframes()
        by = array.array('H', wf.readframes(nf))
        mono = by[::2]
        return mono.tobytes()

if __name__ == "__main__":
    po = poweron()
    me = make_menu()
    mb = make_messagebox()
    ld = make_loadscreen()
    # preview(ld)

    # ---------------------------- Base
    make_heavyboot("Dazzler boot (%s)" % __VERSION__,
                   [po, me, mb, ld],
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
    def ldwav(fn):
        return sample("assets/asteroids_samples/" + fn)
    wavs = [ldwav(fn) for fn in sfx]

    ld = common.Loader(gd)
    ld.add = ld.uadd
    ld.Lastc("assets/asteroids_internal.astc")

    gd.Clear()
    gd.cmd_text(640, 360, 31, eve.OPT_CENTER, "Asteroids is loading")
    gd.Vertex2f(0, 0)
    gd.swap()

    make_liteboot("Asteroids",
                  "../j1/build/asteroids.hex",
                  [gd.buf] + wavs,
                  "_loadflash_asteroids.bin")

    # ---------------------------- Textmode
    gd = Gameduino()
    t = textmode.Textmode(gd)
    def tm(mode, fontsize):
        gd.buf = b''
        gd.setup_1280x720()
        t.configure(mode, fontsize)
        return gd.buf
    modes = [tm(mode, fontsize) for (mode, fontsize) in textmode.tmodes]

    make_liteboot("Text mode",
                  "../j1/build/textmode.hex",
                  modes,
                  "_loadflash_textmode.bin")
