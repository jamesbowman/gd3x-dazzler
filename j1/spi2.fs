\ Uses port $0008 bits:
\   bit 0       CS
\   bit 1       MOSI
\   bit 2       SCK
\   bit 3       MISO
\

new

%0111 2 io!

: idle
    1 1 io!
;

: spix
    8 lshift
    8 0 do
        dup 0< 2 and            \ extract MS bit
        dup 1 io!               \ lower SCK, update MOSI
        4 + 1 io!               \ raise SCK
        2*                      \ next bit
        1 io@ 8 and +           \ read MISO, accumulate
    loop
    2/ 2/ 2/
;

: >spi      spix drop ;
: spi>      0 spix ;

: num ( base -- x )
    base @ >r
    base !
    0. parse-name >number
    2drop drop
    r> base !
;

: START cr ." Start " ;
: STOP  idle ;
: TX    16 num >spi ;
: RX    16 num drop spi> .x2 ;
: DELAY 10 num ms ;

#noverbose
idle
start
