#include daznuc.fs

#include wii.fs


: showid
    cr ." id: "
    REG_ID eve@ .x ;

\ After eve-start:
\  EVE is running and ready for commands
\  Memory b00000 has the IDcode string
\  Memory b00100 has the build ID string


: eve?
    showid
    cr ." FLASH_STATUS: " REG_FLASH_STATUS eve@ .x
    cr ." FRAMES "        REG_FRAMES eve@ .
    cr ." CLOCK "         REG_CLOCK eve@. d.
    ;

: trim! ( u )
    REG_TRIM eve! >spi ;
    
: eve-measure
    REG_FRAMES eve@ >r REG_CLOCK eve@.
    1000 ms
    REG_CLOCK eve@. 2swap d- $7fff and d.
    REG_FRAMES eve@ r> - u.
    ;

: eve-frames ( u )
    REG_FRAMES eve@ +
    begin
        dup REG_FRAMES eve@ =
    until
    drop ;

: manufacturer
    DSPI
    cr $9f cmd spi> .x spi> .x spi> .x idle ;

: fl.check ( d. )
    0. read
    0 >r
    begin
        2dup or
    while
        r> spi> + >r
        -1. d+
    repeat
    2drop r> cr .x ;

\ ------------------------------------------------------------

create cmd.bringup
#include _bringup.fs

create cmd.flash
#include _flash.fs

: commands
    stream
    count 4 * >>eve
    finish ;

\ Passfail indicators are bytes 0..n in RGB332 format
\ $e0 is red, $1c is green

: passed ( tf u  set indicator u )
    cr ." Check " dup . over if ." pass " else ." FAIL" then
    CSPI
    s>d eve!
    0<> [ $1c $e0 xor ] literal and $e0 xor >spi ;

: check-u2
    CSPI
    REG_FLASH_STATUS eve@ 2 =
    dup if
        drop
        cmd.flash commands
        REG_FLASH_STATUS eve@ 3 =
    then
    0 passed
    ;

: check-u4
    DSPI
    $9f cmd
    spi> $ef =
    spi> $40 = and
    spi> $17 = and
    1 passed
    ;

: check-u4q
    DSPI
    $94 cmd
    /qpi/ /out/
    $00 >spi
    $00 >spi
    $00 >spi
    $00 >spi
    /in/
    spi> drop
    spi> drop
    spi> ><
    spi> + $ef16 =
    /spi/
    2 passed
    ;

: audio $17 io@ $4000 and 0<> 1 and ;

: check-audio
    0                   \ make a 2-bit histogram of (0,1) s
    10000 0 do
        1 audio lshift or
    loop
    3 =
    3 passed ;


: check-eveq
    /eve-qpi

    REG_ID eve@ $7c =
    /eve-spi

    4 passed ;

: io@. ( a -- d. )
    dup io@ swap 1+ io@ ;

: check-bus
    $200 ion 1 ms $200 ioff
    30 ms
    $200 io@. cr .x .x cr
    $200 io@. $7ffffff. d=
    $202 io@. $0000000. d= and
    5 passed ;

: i2c-ok ( port - f )
    pl !
    0 i2c! -1 i2c! 1 ms
    i2c@ 5 and 5 = ;

: check-i2c
    false i2c-ok
    true i2c-ok
    and 6 passed ;

: check-clock
    true 7 passed ;

: eve-diag
    eve-start
    cmd.bringup commands
    check-u2
    check-u4
    check-u4q
    check-audio
    check-eveq
    check-bus
    check-i2c
    check-clock
    ;


: poweron
    eve-start
    0 playstream
    5 MUX0
    ;

\ ------------------------------------------------------------

: .16 ( u )
    16 0 do
        dup 1 and . 2/
        i 3 and 3 = if '_' emit then
    loop drop ;

: scope
    begin
        cr
        $16 io@ .16
        space space
        $17 io@ .16
    again ;

: sig ( b c u -- b' )
    type '=' emit dup 1 and . 2/ ;

: scope-eve
    begin
        $18 io@
        cr
        s" PCLK"    sig
        s" DE"      sig
        s" HSYNC"   sig
        s" VSYNC"   sig
        .
    again ;

: everlock
    begin $18 io@ 4 rshift 3 <> until ;

: dcnt
    begin
        cr $23 io@ $22 io@ d.
    again ;

: everdcnt
    begin
        $23 io@ $22 io@
        1237499. d= 0=
    until ;

\ ------------------------------------------------------------


: fl.dump ( a. u )
    -rot
    read
    0 do
        spi> .x2
    loop ;

: serial-snoop
    begin
        $19 io@ if
            cr $1a io@ .x2
        then
    again ;

: result
    finish
    REG_CMD_WRITE eve@ 4 -
    $fff and s>d $308000. d+
    eve@. ;

2variable flashoff  \ flash offset for e2fl
0. flashoff 2!

: addro ( d. )
    flashoff 2@ d+ addr ;

: e2fl ( d. )
    manufacturer
    DSPI
    dup 1+ 0 do
        cr i .
        $d8 wcmd 0 i addro notbusy
    loop

    CSPI $1000. evea /in/ spi> drop
    DSPI

    $100 um/mod nip 1+
    0 do
        i 100 mod 0= if cr i . then
        $02 wcmd i $100 um* addro
        $40 0 do
            CSPI spid> DSPI >spid
        loop
        notbusy
    loop
    ;

\ : x
\     CSPI 0 MUX0 /spi/
\     \ eve-diag
\     eve-start showid
\     cr cr
\     /eve-qpi
\ 
\     \ sel /out/
\     \ $30 >spi
\     \ $2000 >< >spiw
\     \ /in/
\     \ spi> .x
\     \ spi> .x
\     \ spi> .x
\     cr REG_ID eve@-1 .x
\     1. eve! $45 >spi sel
\     cr REG_ID eve@-1 .x
\     cr 1. eve@-1 .x
\ 
\     /eve-spi
\     showid
\ ;

: play REG_SOUND eve! >spiw REG_PLAY eve! $1 >spi ;

: #spi  $3f and 1+ ;

: (spidriver)
    dup $80 and if
        dup $40 and if
            #spi 0 do
                key >spi
            loop
            exit
        then
        #spi pad swap bounds
        2dup do
            key i c!
        loop
        do
            i c@ spix emit
        loop
        exit
    then
    case
        'e' of  key emit endof
        'u' of  idle    endof
        's' of  sel      endof
        'a' of  key drop endof
        'b' of  key drop endof
    endcase
    ;

: spidriver
    0 MUX0 cspi idle
    '@' emit
    begin
        key
        (spidriver)
    again
    ;

: (loadbin)
    \ Now: $ffff8: length, $ffffc: CRC
    cspi
    $ffffc. eve@. result d=
    dup if
        $ffff8. eve@. e2fl
    then
    8 passed
    ;

: loadbin
    0 MUX0 CSPI
    begin
        begin cmdspace 255 > until stream
        $b8 emit
        key
    while
        256 0 do
            key >spi
        loop
    repeat 
    finish

    (loadbin)
    ;

: load ( d )    \ Load a slot from serial binary stream
    flashoff 2!
    eve-diag
    loadbin
;

: autoexec
    $13 icap@ $14 icap@ $ff and   \ recover the base load address
    $54000. d+                      \ first 4K after .bit
    DSPI read
    $3f80 dup                       \ top of RAM
    begin
        spi> dup $ff <>
    while
        over c! 1+
    repeat
    drop over -
    2dup type
    evaluate ;

: general5
    $17 icap@ ;

: sep space '|' emit space ;

: cold
    ." cold"                    sep
    ." slot " origin .          sep
    dna type                    sep
    stamp type                  sep
    ." GENERAL5=" general5 .x   sep

    general5 $DA22 = if
        eve-diag loadbin begin again
    then
    200 ms key? if
        quit
    else
        \ poweron wii-main
        autoexec
        quit
    then ;
' cold init !

: put ( c a dst. )
    DSPI
    2dup $20 wcmd addr notbusy
    $02 wcmd addr

    bounds ?do
        i c@ >spi
    loop
    notbusy ;

include fs.fs

: x
    begin
        $017 io@ 12 rshift 1 and .
    again
;

: loadsd
    eve-diag
    /fat32
    s" _loadflash2.bin" fplay
    (loadbin)
    ;

\ ------------------------------------------------------------

: hi ( p ) 3 swap $400 + io! ;
: lo ( p ) 2 swap $400 + io! ;
: in ( p ) 0 swap $400 + io! ;
: p@ ( p ) $16 io@ $17 io@ rot 0 do d2/ loop drop 1 and ;

29 constant RES
28 constant PHI

: ?6502
    3 spaces
    $16 io@ $17 io@
    d2/ d2/ d2/ 7 flip .x2 .x ;

: clock
    PHI hi PHI lo ;

: reset
    RES lo clock clock clock RES hi ;

: >gd >spid ;

: 6502nop
    \ ea = 1110_1010
    19 hi
    20 hi
    21 hi
    22 lo

    23 hi
    24 lo
    25 hi
    26 lo
    ;

: y
    30 3 do i in loop
    0 MUX0 CSPI

    PHI lo
    reset

    6502nop

    20 0 do
        clock
        cr i . $17 io@ .x $16 io@ .x ?6502
    loop
    ;

: x
    PHI lo reset
    6502nop
    50 0 do
        cr $16 io@ $17 io@ d.  PHI hi
        cr $16 io@ $17 io@ d.  PHI lo
    loop
    ;

\ : xxx
\     begin
\         30 3 do i lo loop 1000 ms  cr $17 io@ .x $16 io@ .x
\         30 3 do i hi loop 1000 ms  cr $17 io@ .x $16 io@ .x
\     again
\ ;

: frob ( u )
    begin
        dup hi 1 ms
        dup lo 1 ms
    again ;
: hail
    30 3 do i in loop
    begin
        30 4 do i hi 2 +loop  1 ms
        30 4 do i lo 2 +loop  1 ms
    again ;
