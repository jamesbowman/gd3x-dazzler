SUBDIRS=..

EXTSUFFIX := $(shell python -c "import sysconfig;print(sysconfig.get_config_var('EXT_SUFFIX'))")
J1LIB := build/lib/python/vsimj1a$(EXTSUFFIX)

all: ../build/nuc.hex $(J1LIB) # obj_dir/Vj1a

VERILOGS=j1a.v ../../j1.v ../../stack2.v ../../hdmi.v

verilator_version.h: Makefile
	(echo -n "#define VERSION " ; verilator --version|cut -d' ' -f2|sed 's/\.//') > verilator_version.h

obj_dir/Vj1a obj_dir/Vj1a__ALL.a: $(VERILOGS) sim_main.cpp Makefile verilator_version.h
	verilator -Wall --cc -DVERILATOR=1 $(VERILOGS) --top-module j1a --exe sim_main.cpp
	$(MAKE) -C obj_dir CXXFLAGS="-fPIC -O3" OPT_FAST="-O2" -f Vj1a.mk Vj1a

../build/nuc.hex:
	$(MAKE) -C ..

$(J1LIB): setup.py obj_dir/Vj1a__ALL.a vsim.cpp verilator_version.h
	verilator --version
	python setup.py install --home build

clean:
	rm -rf build
	rm -rf obj_dir
	rm -f newmem.dat

.PHONY: all
