#include ../swapforth.fs
#flash ../build/swapforth.hex

#include ../swapforth/boot_base.fs
#flash ../build/base.hex

#include ../swapforth/boot_asteroids.fs
#flash ../build/asteroids.hex

#include ../swapforth/boot_textmode.fs
#flash ../build/textmode.hex

#include ../swapforth/boot_bringup.fs
#flash ../build/bringup.hex

#bye
