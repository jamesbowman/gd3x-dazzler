# gd3x-dazzler

[![Build Status](https://travis-ci.org/jamesbowman/gd3x-dazzler.svg?branch=master)](https://travis-ci.org/jamesbowman/gd3x-dazzler)

Firmware for the Gameduino 3X Dazzler FPGA

To build:

1. Make sure you are running Python 3 in a virtual environment. The build is tested with 3.7 onwards

2. Install the tools:
   sudo apt-get -y install verilator gforth

3. Install the Python requirements:
   pip install -r requirements.txt

Then edit `xilinxmake` to point to you Xilinx WebPack installation.

After this `make` will build the firmware.


