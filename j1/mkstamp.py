import sys
from datetime import datetime

def gen(fn):
    n = datetime.now()
    s = n.strftime("%d %b %Y %H:%M")
    with open(fn, "wt") as f:
        f.write(': stamp ( -- a u ) s" ' + s + '" ;')

gen(sys.argv[1])
