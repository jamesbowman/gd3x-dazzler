new
decimal

#include dna.fs
#include icap.fs
#include wii.fs

: umin 2dup u< if drop else nip then ;

: ion   1 swap io! ;
: ioff  0 swap io! ;

\ 5    4    3    2    1    0
\ CS   SCK  IO3  IO2  MISO MOSI

: rspi  $777 + ;
: CSPI  $8100 ['] rspi ! ;
: DSPI  $8110 ['] rspi ! ;
: ESPI  $8120 ['] rspi ! ;

: rspi! ( u r )                 rspi io! ;
: /spi/     $0 $5 rspi! ;
: /qpi/     $1 $5 rspi! ;
: /out/     $0 $4 rspi! ;
: /in/      $1 $4 rspi! ;

: SPIM@ 0 rspi io@ ;
: SPIM! 0 rspi! ;
: idle  $20 SPIM!  ;
: sel   $20 SPIM! $00 SPIM! ;

DSPI /spi/
CSPI /spi/

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
: spix
    >spi
    $1 rspi io@
    ;
: spi>
    $ff spix
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
    sel /out/ >spi >< >spiw ;

: eve@ ( a. - u ) evea /in/ spi> drop spiw> ;

: eve@. ( a. - d. )
    eve@ spiw> ;

: eve!
    $80 or evea ;

: >>eve ( a u )
    bounds do
        i c@ >spi
    loop ;

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
    $44     host        \ external clock
\   $48     host        \ internal clock
    $00     host

    200 ms
    $b0000. eve! dna >>eve 0 >spi
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

: eve-frames ( u )
    REG_FRAMES eve@ +
    begin
        dup REG_FRAMES eve@ =
    until
    drop ;

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

: audio $17 io@ $2000 and 0<> 1 and ;

: check-audio
    0                   \ make a 2-bit histogram of (0,1) s
    10000 0 do
        1 audio lshift or
    loop
    3 =
    3 passed ;

: /eve-qpi
    CSPI 
    REG_SPI_WIDTH eve! $2 >spi /qpi/
    ;

: /eve-spi
    REG_SPI_WIDTH eve! $00 >spi idle /spi/
    ;

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
    ;

\ ------------------------------------------------------------
    ;

\ ------------------------------------------------------------
    ;

\ ------------------------------------------------------------
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

\ ------------------------------------------------------------


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
    eve@. ;

: e2fl ( d. )
    manufacturer
    DSPI
    dup 1+ 0 do
        cr i .
        $d8 wcmd 0 i addr notbusy
    loop

    CSPI $1000. evea /in/ spi> drop
    DSPI

    $100 um/mod nip 1+
    0 do
        i 100 mod 0= if cr i . then
        $02 wcmd i $100 um* addr
        $40 0 do
            CSPI spid> DSPI >spid
        loop
        notbusy
    loop
    ;

#include textmode.fs

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

: cold
    ." cold " dna type space
    200 ms key? if
        quit
    else
        \ poweron wii-main

        eve-diag
        loadbin
        begin again
    then ;
' cold init !

: cmd ( c )
    sel $40 or >spi ;
: addr >< >spiw >< >spiw ;
: crc >spi ;

: response ( - u )
    begin
        spi>
        dup $80 and
    while
        drop
    repeat
    ;

: blanks ( n )
    0 do $ff >spi loop ;

: R1 ( - u )
    response idle 1 blanks ;

: sdR7 ( - u )
    response 4 blanks idle ;

: appcmd ( cc lba. )
    $55 cmd 0. addr $95 crc
    R1 drop
    2>r cmd 2r> addr $95 crc ;

: x
    ESPI /spi/
    idle
    idle 10 blanks

    begin
        20 ms
        0 cmd 0. addr $95 crc
        response
        idle 1 blanks
        dup cr .x
        1 =
    until

    8 cmd $1aa. addr $87 crc
    sdR7 1 = 1 and ( sdhc )
    dup cr ." sdhc: " .
    cr
    begin
        41 0 over 14 lshift appcmd
        R1
        dup .
        1 and 0=
    until
    ;
