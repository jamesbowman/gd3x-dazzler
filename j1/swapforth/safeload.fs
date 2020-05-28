new
decimal

: ion   1 swap io! ;
: ioff  0 swap io! ;

\ 5    4    3    2    1    0
\ CS   SCK  IO3  IO2  MISO MOSI

variable spidev
: CSPI  $10 spidev ! ;
: DSPI  $0f spidev ! ;

: SPIM@ spidev @ io@ ;
: SPIM! spidev @ io! ;

: idle
    $20 SPIM!
;

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
: >spiw     dup >spi 8 rshift >spi ;
: >spid     swap >spiw >spiw ;
: spi>      0 spix ;
: spiw>     spi> spi> 8 lshift + ;
: spid>     spiw> spiw> ;

: MUX0      $11 io! ;

: cmd ( x )         idle >spi ;
: wcmd ( x )        $06 cmd cmd ;
: status ( - x )    $05 cmd spi> ;
: notbusy           begin status 1 and 0= until ;
: chiperase         $c7 wcmd notbusy ;
: addr ( d. )       >spi dup 8 rshift >spi >spi ;
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

0 MUX0
DSPI
#include _loadflash.fs
