#include daznuc.fs
#include wii.fs
#include fs.fs

\ --------------------------------------------- boot menu

: display ( u )
    REG_MACRO_0 eve! >spiw $1100 >spiw ;

: slotnames
    CSPI 0. eve!
    8 0 do
        DSPI i slotvalid if
            32 0 do
                DSPI spi> CSPI >spi
            loop
        else
            CSPI 32 0 do 0 >spi loop
        then
    loop ;

variable s_ 0 s_ !

: wii-edge
    wii-poll
    s_ @
    wiistate 4 + @          ( old new )
    dup s_ !
    invert and ;

: button ( bit byte -- t/f )
    wiistate + c@ and 0= ;

: bootmenu
    ['] chars is menu
    0 mux0
    eve-start
    CSPI
    slotnames
    1 playstream

    0
    begin
        cr .s

        wii-edge case
        $1000 of run endof
        $0040 of 1+ endof
        $0100 of 1- endof
        endcase

        $7 and
        p2 det $20 and or
        p1 det $10 and or
        dup display

    again
;

: /sd-present
    ESPI /spi/
    sd.u 10 0 do sd.ff loop

    20 0 do
        1 ms
        0 ccmd R1
        dup cr .x
        1 =
    loop
    ;

:noname
    ['] bootmenu is menu            \ START+X+Y brings up the bootmenu
    wii-poll
    200 ms key? if                  \ Keypress in 200 ms, drop to prompt
        quit
    else
    eve-start                       \ init EVE
    wii-poll                        \ Check for START+X+Y
    0 playstream                    \ The load screen
    5 MUX0                          \ User has the SPI
    wii-main                        \ wii port loop, never returns
; init !
