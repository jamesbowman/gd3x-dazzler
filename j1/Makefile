build/nuc.hex: cross.fs basewords.fs nuc.fs  build/stamp.fs
	mkdir -p build
	gforth cross.fs basewords.fs nuc.fs

build/bringup.hex: build/nuc.hex verilator/bootstrap swapforth.fs swapforth/*.fs build/stamp.fs
	make -C verilator
	(cd ./verilator/; ./bootstrap)

build/stamp.fs:
	mkdir -p build
	python mkstamp.py build/stamp.fs

clean:
	rm -f build/nuc.hex
	make -C verilator clean

UNAME_S := $(shell uname -s)
ifeq ($(UNAME_S),Linux)

connect: /dev/ttyUSB1
	sudo python shell.py -h /dev/ttyUSB1 -p ../common/

j4a:
	make -C icestorm j4a

j1a8k:
	make -C icestorm j1a8k

j1a:
	make -C icestorm j1a

endif

ifeq ($(UNAME_S),Darwin)

/dev/tty.usbserial-*B: mackextload

connect: /dev/tty.usbserial-*B
	sudo python shell.py -h /dev/tty.usbserial-*B -p ../common/

j4a: mackextunload
	make -C icestorm j4a

j1a8k: mackextunload
	make -C icestorm j1a8k

j1a: mackextunload
	make -C icestorm j1a

mackextunload:
	sudo kextunload -bundle-id com.apple.driver.AppleUSBFTDI

mackextload:
	sudo kextload -bundle-id com.apple.driver.AppleUSBFTDI

endif

.PHONY: connect clean bootstrap mackextload mackextunload macconnect build/stamp.fs
