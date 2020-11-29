#include daznuc.fs

: e.cmd ( u ) $ff00 or true >spid ;

CSPI
: >gd   >spid ;
: w>gd  0 >gd ;

defer getc

#include ../../textmode/_textmode.fs
#include ../../textmode/textmode2.fs

: terminal
    begin
        getc
        case
        10 of down1 endof
        13 of 0 cx ! endof
        27 of csi endof
        dup plain
        endcase
    again
    ;

2variable playback
: setbuf playback 2! ;
:noname
    playback 2@
    dup 0= if quit then
    over c@ -rot
    1 /string
    setbuf
; is getc

: x
    0 mux0
    0 playstream
    stream
    ;

: y s" brilliant" setbuf terminal ;
