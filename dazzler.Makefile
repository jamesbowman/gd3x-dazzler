project = dazzler
vendor = xilinx
family = spartan3s
part = xc6slx9-ftg256-3
top_module = top
flashsize = 2048

vfiles = dazzler.v HDMI_test.v convert_30to15_fifo.v serdes_n_to_1.v DRAM16XN.v audio/HDMIDirect.v uart.v j1.v stack2.v
ifiles = j1/build/nuc.hex j1/build/dazzler.hex audio/sintab.i

include xilinx.mk
