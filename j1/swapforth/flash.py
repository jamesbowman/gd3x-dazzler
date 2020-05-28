new

\ 5    4    3    2    1    0
\ CS   SCK  IO3  IO2  MISO MOSI

: idle
    -1 2 io!
;

: spix
    8 lshift
    8 0 do
        dup 0< 1 and            \ extract MS bit
        dup 2 io!               \ lower SCK, update MOSI
        $10 + 2 io!             \ raise SCK
        2*                      \ next bit
        2 io@ 2 and +           \ read MISO, accumulate
    loop
    2/
;

: >spi      spix drop ;
: spi>      0 spix ;

: cmd ( x )         idle >spi ;
: wcmd ( x )        $06 cmd cmd ;
: status ( - x )    $05 cmd spi> dup . ;
: notbusy           begin status 1 and 0= until ;
: erase             $c7 wcmd notbusy ;

: manufacturer
    $9f cmd spi> .x spi> .x spi> .x idle ;

: hh ( a u -- x a' ) 0. 2swap >number drop nip ;
: 2h ( a   -- x a' ) 2 hh ;
: 4h ( a   -- x a' ) 4 hh ;
: ramload                       \ copy Intel HEX records to DPTR
    hex
    begin
        pad dup 80 accept drop
        1+ 2h 4h 2h             ( count addr type a )
        swap                    ( count addr a type )
        case                    ( count addr a )
            $00 of
                nip swap        ( a count )
                0 ?do
                    2h swap .
                loop
                drop
            endof
            $01 of
                2drop drop exit
            endof
            $04 of
                4h .
                2drop drop
            endof
        endcase
    again
    2drop drop ;

\ ramload
\ #include ../../dazzler.mcs


