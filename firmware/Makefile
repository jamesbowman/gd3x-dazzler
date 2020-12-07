all: stage1 stage2

stage1: _bringup.fs _flash.fs _textmode.fs

stage2: _loadflash_textmode.bin

_bringup.fs _flash.fs _textmode.fs: Makefile basics.py ../textmode/textmode.py
	python basics.py

_loadflash_textmode.bin: ../j1/build/textmode.hex ../textmode/textmode.py ../dazzler.bit
	python makeboot.py
