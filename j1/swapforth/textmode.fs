: >spiw
    begin $21 io@ until
    8 flip
    $20 io!
    ;
    
: >spid $00 SPIM! swap >spiw >spiw ;

: e.cmd ( u ) $ff00 or s>d >spid ;

: x
    begin
        $19 io@ if
            cr $1a io@ .x2
        then
    again ;

#include _textmode.fs

2variable cursor
0. cursor 2!
cursor cell+ constant cursorx

: gaddr ( x y )
    >r
    gx um*
    r> gy um* d+
    fb d+ ;

: caddr ( x y z )
    >r >r
    cx um* r> 2 um* d+ r> cz um* d+
    cm d+ ;

: /t
    0 mux0
    1 playstream

    CSPI
    stream
    ;

: e.memzero     $1c e.cmd ;
: e.memwrite    $1a e.cmd ;
: e.memcpy      $1d e.cmd ;

: t.home    0. cursor 2! ;
: t.cr 0 cursorx ! ;
: t.lf
    cursor @ 1+
    dup H <> if
        cursor ! exit
    then
    drop
    ."  scroll"
    ;

: right1
    cursorx @ 1+
    dup W <> if
        cursorx ! exit
    then
    drop
    t.cr t.lf ;

variable fg $ffff fg !

: drawch ( c )
    e.memcpy
    cursor 2@ gaddr >spid
    $20 - wh um* fm d+ >spid
    wh s>d >spid

    e.memwrite
    cursor 2@ 0 caddr >spid
    2. >spid
    fg @ 0 >spid

    e.memwrite
    cursor 2@ 1 caddr >spid
    2. >spid
    \ $1082. >spid
    $0000. >spid

    right1
    ;

:  cls
    e.memzero
    fb >spid
    sz >spid
    e.memzero
    cm >spid
    cz 2 um* >spid
    t.home
    finish stream
    ;

: t.clrline ( u )
    >r cursor 2@
    0 r> cursor 2!
    W 0 do bl drawch loop
    cursor 2!
    ;

: setscroll
    >r
    e.memwrite
    REG_MACRO_0 >spid
    4. >spid
    H r> - h2 * y_bar +
    16 um*
    2dup d.
    $ff and $2c00 or
    dup .x over .x
    >spid
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
    cls
    H 0 do
        i 2000 * isin 50 m* nip 36 + t.x
        i 1 and if
            s" GAMEDUINO"
        else
            s"  DAZZLER "
        then
        i 1359 * fg !
        t.type $ea drawch t.cr t.lf
    loop
    ;

: bench
    t.home
    1152 0 do
        'x' drawch
    loop ;

CSPI
