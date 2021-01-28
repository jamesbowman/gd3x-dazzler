new
decimal
' quit init !

#include dna.fs
#include ../build/stamp.fs

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
$2034 reg REG_HSIZE
$2048 reg REG_VSIZE
$2070 reg REG_PCLK
$2088 reg REG_SOUND
$208c reg REG_PLAY
$20d8 reg REG_MACRO_0
$20fc reg REG_CMD_WRITE
$2100 reg REG_CMD_DL
$2180 reg REG_TRIM
$2188 reg REG_SPI_WIDTH
$2574 reg REG_CMDB_SPACE
$2578 reg REG_CMDB_WRITE
$25f0 reg REG_FLASH_STATUS

: evea ( a. - u )
    sel /out/ >spi >< >spiw ;

: (eve@) ( a. ) evea /in/ spi> drop ;
: eve@ ( a. - u ) (eve@) spiw> ;

: eve@. ( a. - d. )
    eve@ spiw> ;

: eve!
    $80 or evea ;

: >>eve ( a u )
    bounds do
        i c@ >spi
    loop ;

: cmdspace  REG_CMDB_SPACE eve@ ;
: finish
    begin
        cmdspace
        dup 1 and if cr ." EXCEPTION" begin again then
        $ffc =
    until
    ;
: stream    REG_CMDB_WRITE eve! ;

: eve-ready
    250 0 do
        REG_ID eve@ $7c = if unloop exit then
        1 ms
    loop ;

: eve-start
    $14 ioff 5 ms $14 ion
    0 MUX0
    CSPI /spi/

    $61 $46 host2
    $44     host        \ external clock
\   $48     host        \ internal clock
    $00     host

    eve-ready
    $b0000. eve! dna >>eve 0 >spi
    $b0100. eve! stamp >>eve 0 >spi
    ;

: /eve-qpi
    CSPI 
    REG_SPI_WIDTH eve! $2 >spi /qpi/
    ;

: /eve-spi
    REG_SPI_WIDTH eve! $00 >spi idle /spi/
    ;

\ ------------------------------------------------------------
: cmd ( x )         sel >spi ;
: wcmd ( x )        $06 cmd cmd ;
: status ( - x )    $05 cmd spi> ;
: notbusy           begin status 1 and 0= until ;
: chiperase         $c7 wcmd notbusy ;
: addr ( d. )       >spi dup >< >spi >spi ;
: read ( d. )       $03 cmd addr ;
\ ------------------------------------------------------------

#include icap.fs
#include slots.fs

\ ------------------------------------------------------------

\ At $80000 block is:
\ $947a     signature
\   length    4         in bytes
\   stream    length
\   etc.

: playstream ( u ) \ play back commands from flash
    DSPI
    origin slot $080000. d+ read
    spiw> $947a <> if
        drop exit
    then
    origin slot $080002. d+
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
        stream
        dup 0 ?do
            DSPI spi>
            CSPI >spi
        loop
        idle
        0 d-
    repeat
    2drop
    ;

\ ------------------------------------------------------------

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

: (loadbin)
    \ Now: $ffff8: length, $ffffc: CRC
    CSPI
    $ffffc. eve@. result d=
    dup if
        $ffff8. eve@.
        cr ." Writing to flash, length: " 2dup d.
        e2fl
        cr ." Load complete"
    else
        cr ." CRC mismatch. Not loading."
    then
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
    cr ." finishing"
    finish
    cr ." Finished EVE transfer"

    (loadbin)
    ;

: load ( d )    \ Load a slot from serial binary stream
    flashoff 2!
    eve-start
    loadbin
;

\ ------------------------------------------------------------

: sack
    $00 $600 io! ;

defer serv-load ' drop is serv-load

: service
    $600 io@ if
        $601 io@
cr ." CMD:" dup .x
        dup $ff and swap >< $ff and
        case
        $40 of eve-start drop endof
        $41 of sack run endof
        $42 of serv-load endof
        drop
        endcase
        sack
    then ;
