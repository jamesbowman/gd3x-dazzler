all: _loadflash_base.bin

_loadflash_base.bin:
	make -C firmware stage1
	make -C j1
	make -C j1/verilator
	# make -f dazzler.Makefile
	make -C firmware stage2
