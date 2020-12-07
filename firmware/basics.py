import sys
import textwrap
import struct
import array
from PIL import Image, ImageDraw, ImageFont, ImageFilter, ImageChops
import bteve as eve
import zlib
import binascii
def crc(s):     # CRC-32 of string s
    return binascii.crc32(s) & 0xffffffff

sys.path.append("../textmode")
import textmode

__VERSION__ = "1.0.6"

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

if __name__ == "__main__":
    make_sector_1()

    br = make_bringup()
    dump_init("_bringup.fs", br)

    fl = make_flash()
    dump_init("_flash.fs", fl)

    gd = Gameduino()
    t = textmode.Textmode(gd)
    [t.configure(mode, fontsize) for (mode, fontsize) in textmode.tmodes]
    t.dump_fs()
