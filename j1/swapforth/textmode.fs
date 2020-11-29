#include daznuc.fs

: e.cmd ( u ) $ff00 or true >spid ;

CSPI
: >gd   >spid ;
: w>gd  0 >gd ;

: getc 'a' ;

#include ../../textmode/_textmode.fs
#include ../../textmode/textmode2.fs
