\ Micron N25Q032A SPI flash driver
new

\ Uses port $0008 bits:
\   bit 0       CS
\   bit 1       MOSI
\   bit 2       SCK
\ and port $2000:
\   bit 2       MISO
\

anew funt

: idle
    1 8 io!
;

: spix
    8 lshift
    8 0 do
        dup 0< 2 and            \ extract MS bit
        dup 8 io!               \ lower SCK, update MOSI
        4 + 8 io!               \ raise SCK
        2*                      \ next bit
        $2000 io@ 4 and +       \ read MISO, accumulate
    loop
    2/ 2/
;

: >spi      spix drop ;
: spi>      0 spix ;

cr
$9e >spi
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
spi> .x
idle
cr

: status ( -- u )
    $05 >spi spi> idle ;

: x
    $06 >spi idle                               \ unlock
    $d8 >spi $01 >spi $01 >spi $01 >spi idle    \ sector (64KByte) erase
    begin                                       \ until status[0] clears
        status 1 and 0=
    until
    \ 100 0 do $05 >spi spi> .x cr 20 ms loop
;
