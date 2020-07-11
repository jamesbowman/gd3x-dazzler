new
decimal

: umin 2dup u< if drop else nip then ;

: ion   1 swap io! ;
: ioff  0 swap io! ;

\ 5    4    3    2    1    0
\ CS   SCK  IO3  IO2  MISO MOSI

variable spibase
: rspi  spibase @ + ;

: CSPI  $100 spibase ! ;
: DSPI  $110 spibase ! ;

: SPIM@ spibase @ io@ ;
: SPIM! spibase @ io! ;

: idle  $20 SPIM!  ;
: sel   $20 SPIM! $00 SPIM! ;

: spidir $4 rspi io! ;
: qout $0 spidir ;
: qin  $f spidir ;
: spi  $2 spidir ;

0 [IF]
: spix
    8 lshift
    8 0 do
        dup 0< 1 and            \ extract MS bit
        dup SPIM!               \ lower SCK, update MOSI
        $10 + SPIM!             \ raise SCK
        2*                      \ next bit
        SPIM@ 2 and +           \ read MISO, accumulate
    loop
    2/
;
: >spi      spix drop ;
: spi>      0 spix ;
: >spiw     dup >spi >< >spi ;
: spiw>     spi> spi> >< + ;
[ELSE]
: >spi
    $1 rspi io!
    begin $3 rspi io@ until
    ;
: spi>
    $ff >spi
    $1 rspi io@
    ;
: >spiw
    $2 rspi io!
    begin $3 rspi io@ until
    ;
: spiw>
    $ffff >spiw
    $2 rspi io@ ><
    ;
[THEN]

: >spid     swap >spiw >spiw ;
: spid>     spiw> spiw> ;

: pulse ( u )
    $f and
    dup SPIM! $10 or SPIM! ;

: >qpi ( u )
    qout
    dup 4 rshift pulse
    pulse
    ;

: qpi> ( -- u )
    qin
    $f pulse SPIM@ $f and 4 lshift
    $f pulse SPIM@ $f and or
    ;

: MUX0      $11 io! ;

: host2 ( a b )     sel swap >spi >spi 0 >spi 40 ms ;
: host ( a )        0 host2 ;

: reg
    create ,
    does> @ $30 ;

$2000 reg REG_ID
$2004 reg REG_FRAMES
$2008 reg REG_CLOCK
$2070 reg REG_PCLK
$2088 reg REG_SOUND
$208c reg REG_PLAY
$20d8 reg REG_MACRO_0
$20fc reg REG_CMD_WRITE
$2180 reg REG_TRIM
$2574 reg REG_CMDB_SPACE
$2578 reg REG_CMDB_WRITE
$25f0 reg REG_FLASH_STATUS
$2188 reg REG_SPI_WIDTH

: evea ( a. - u )
    sel >spi dup >< >spi >spi ;

: eve@ ( a. - u )
    evea
    spi> drop
    spiw> ;
: eve@. ( a. - d. )
    eve@ spiw> ;

: eve!
    $80 or evea ;

: cmdspace  REG_CMDB_SPACE eve@ ;
: finish    begin cmdspace $ffc = until ;
: stream    REG_CMDB_WRITE eve! ;

: showid
    cr ." id: "
    REG_ID eve@ .x ;

: eve-start
    $14 ioff 5 ms $14 ion
    0 MUX0
    CSPI

    $61 $46 host2
    $48     host
    $00     host

    200 ms
    ;

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

: cmd ( x )         sel >spi ;
: wcmd ( x )        $06 cmd cmd ;
: status ( - x )    $05 cmd spi> ;
: notbusy           begin status 1 and 0= until ;
: chiperase         $c7 wcmd notbusy ;
: addr ( d. )       >spi dup >< >spi >spi ;
: read ( d. )       $03 cmd addr ;

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
    count 4 * bounds
    do
        i c@ >spi
    loop
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
    qout
    $00 >qpi
    $00 >qpi
    $00 >qpi
    $00 >qpi
    qin
    qpi> drop
    qpi> drop
    qpi> ><
    qpi> + $ef16 =
    spi
    2 passed
    ;

: audio $17 io@ $2000 and 0<> 1 and ;

: check-audio
    0                   \ make a 2-bit histogram of (0,1) s
    10000 0 do
        1 audio lshift or
    loop
    3 =
    3 passed ;

: qevea ( a. )
    sel >qpi dup >< >qpi >qpi ;
    
: check-eveq
    CSPI 
    REG_SPI_WIDTH eve! $2 >spi

    REG_ID qevea
    qpi> drop
    qpi> $7c =

    REG_SPI_WIDTH $80 or qevea
    $00 >qpi idle

    spi
    4 passed ;

: eve-diag
    eve-start
    cmd.bringup commands
    check-u2
    check-u4
    check-u4q
    check-audio
    check-eveq
    ;

\ ------------------------------------------------------------

\ At $80000 block is:
\ $947a     signature
\   length    4         in bytes
\   stream    length
\   etc.

: playstream ( u  play back commands from flash )
    DSPI
    $080000. read
    spiw> $947a <> if
        drop
        CSPI
        eve-diag
    else
        $080002.
        rot 0 ?do
            2dup read 4. d+
            spid> d+
        loop
        read spid>
        begin
            2dup or
        while
            CSPI
            2dup 0<> or \ fold hi word to $ffff
            cmdspace
            umin
\ cr dup .x
            stream
            dup 0 ?do
                DSPI spi>
                CSPI >spi
            loop
            idle
            0 d-
        repeat
        2drop
    then
    ;

: poweron
    eve-start
    0 playstream
    1 MUX0
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

: play REG_SOUND eve! >spiw REG_PLAY eve! $1 >spi ;
: x
    REG_SOUND eve! $44 >spi
    REG_PLAY eve! $1 >spi
    500 0 do $18 io@ . loop
    ;

\ ------------------------------------------------------------

#include wii.fs

\ ------------------------------------------------------------

: cold ." cold " 200 ms key? if quit else poweron wii-main then ;
' cold init !


#include icap.fs

: fl.dump (  )
    0. read
    1024 0 do
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
    hex eve@. .x .x ;

: e2fl ( d. )
    manufacturer
    DSPI
    dup 1+ 0 do
        cr i .
        $d8 wcmd 0 i addr notbusy
    loop

    CSPI 0. evea spi> drop
    DSPI

    $100 um/mod nip 1+
    0 do
        i 100 mod 0= if cr i . then
        $02 wcmd i $100 um* addr
        $100 0 do
            CSPI spi> DSPI >spi
        loop
        notbusy
    loop
    ;

#include textmode.fs

: y ( u )
    $20 io!
    begin $21 io@ until
    $20 io@ .x ;
: x
    CSPI 0 MUX0
    sel

    $3020 y
    $0000 y
    $0000 y
    idle
;

: spix'
    $1 rspi io!
    begin $3 rspi io@ until
    $1 rspi io@
    ;

: x
    eve-start

    CSPI 0 MUX0
    spi
    sel

    10 0 do
        cr $00 spix' .x
    loop
;

: y
    DSPI 0 MUX0
    spi
    sel

    cr $9f spix' .x
    cr $00 spix' .x
    cr $00 spix' .x
    cr $00 spix' .x
;
