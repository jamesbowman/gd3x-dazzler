import array
import sys

(aa, bb) = [array.array("I", open(f, "rb").read()) for f in sys.argv[1:]]

for (a, b) in zip(aa, bb):
    print("%08x  %08x" % (a, b))
    if a != b:
        break;
