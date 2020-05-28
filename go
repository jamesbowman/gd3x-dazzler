set -e

# ./smoke ; exit

# python sine.py
make -C j1
# make clean
(
  . /data/Xilinx/14.7/ISE_DS/settings64.sh
  make -f dazzler.Makefile
  # promgen -w -s 2048 -p bin -spi -o dazzler.spi.bin -u 0 dazzler.bit
  python jtag.py
  # python ~/tmp/ser.py 
  # sudo ./send dazzler.bit
)
