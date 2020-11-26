#include daznuc.fs

: e.cmd ( u ) $ff00 or true >spid ;

#include _textmode.fs

2variable cursor
0. cursor 2!
cursor cell+ constant cursorx
variable yo

variable fg $ffff fg !
variable bg $1082 0 and bg !

: Hmod ( u )
    dup H < invert H and - ;

: yoff ( y - y' )
    yo @ + Hmod ;

: gaddr ( x y )
    yoff
    >r
    gx um*
    r> gy * 0 d+
    fb d+ ;

: caddr ( x y )
    yoff
    2* swap
    cx * + 0
    ;

: /t
    0 mux0
    1 playstream

    /eve-qpi
    stream
    ;

: e.memzero     $1c e.cmd ;
: e.memwrite    $1a e.cmd ;
: e.memcpy      $1d e.cmd ;

: setscroll
    >r
    e.memwrite
    REG_MACRO_0 >spid
    4. >spid
    H r> - h2 * y_bar +
    16 um*
    \ 2dup d.
    $ff and $2c00 or
    \ dup .x over .x
    >spid
    ;

: scroll
    \ W 0 do
    \     i H 1- caddr eve!
    \     bg @ >spiw
    \ loop
    0 H 1- caddr
    W 0 do
        2dup eve! bg @ >spiw
        cx m+
    loop 2drop
    stream
    
    yo @ 1+ Hmod dup yo !
    setscroll
    ;

: t.home    0. cursor 2! ;
: t.cr 0 cursorx ! ;
: t.lf
    cursor @ 1+
    dup H 1- <> if
        cursor ! exit
    then
    drop
    scroll
    ;

: right1
    cursorx @ 1+
    dup cursorx ! W <> if
        exit
    then
    t.cr t.lf ;

: drawch ( c )
    e.memcpy
    cursor 2@ gaddr >spid
    $20 - wh um* fm d+ >spid
    wh 0 >spid

    cursor 2@ caddr 2dup eve!
    fg @ >spiw
    cz m+ eve!
    bg @ >spiw
    stream

    right1
    ;

: cls
    e.memzero
    fb >spid
    sz >spid
    e.memzero
    cm >spid
    cz 2 um* >spid
    0 yo !
    0 setscroll
    t.home
    finish stream
    ;

: t.clrline ( u )
    >r cursor 2@
    0 r> cursor 2!
    W 0 do bl drawch loop
    cursor 2!
    ;

: bar
    2000 0 do
        i 7 mod '0' + drawch
    loop
    ;

: t.type
    bounds
    do
        i c@ drawch
    loop ;

#include sincos.fs

: t.x
    [ cursor cell+ ] literal ! ;

: wave
    0
    begin
        dup 2000 * isin 50 m* nip 36 + t.x
        dup 1359 * fg !
        dup 1 and if
            s" GAMEDUINO"
        else
            s"  DAZZLER "
        then
        t.type t.cr t.lf
        1+ 40 ms
    again
    ;

: bench
    10 0 do
        t.home
        1000 0 do
            'x' drawch
        loop
    loop
    ;

: t.emit
    case
    $0a of t.lf endof
    $0d of t.cr endof
    drawch
    endcase ;

: x
    CSPI /qpi/
    cls
    \ begin
    \     $19 io@ if
    \         $1a io@ dup emit t.emit
    \     then
    \ again

    999 0 do
        i s>d <# #s #> t.type t.cr t.lf
        i 60 > 60 and ms
    loop
    ;

CSPI
