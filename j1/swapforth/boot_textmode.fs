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
        8 of cx @ 1- 0 max cx ! endof
        10 of down1 endof
        13 of 0 cx ! endof
        27 of csi endof
        dup 32 127 within if dup plain then
        endcase
    again
    ;

: /t
    0 mux0
    CSPI idle sack
    REG_ID eve@ $7c <> if
        /eve-spi
    then
    0 playstream
    /eve-qpi
    stream
    0. cy 2!
    ;

6000 constant BLINK         \ blink timer, higher is slower
$200 constant CDELAY        \ delay before cursor appears
CDELAY $8000 + constant CDELAY2

:noname
    0.
    begin
        service
        dup CDELAY  = if showcursor then
        dup CDELAY2 = if hidecursor then
        6000 m+
        $019 io@
    until
    CDELAY CDELAY2 within if hidecursor then
    drop

    $01a io@
; is getc

:noname
    200 ms key? if
        quit
    else
        /t
        terminal
    then
; init !
