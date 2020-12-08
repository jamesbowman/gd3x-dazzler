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

: dialog ( a u )
    CSPI
    0. eve! >>eve 0 >spi
    2 playstream
    begin
        wii-edge $0004 =
    until
    ;

: sd-det
    $16 io@ 0< invert ;

: image.dazzler s" image.dazzler" ;

defer failmsg

: (loadsd) ( s failmsg )
    is failmsg
    dup 0 8 within invert if
        s" Slot number must be 0-7" failmsg exit
    then
    sd-det 0= if
        s" No microSD card inserted" failmsg exit
    then
    /fat32
    ls
    image.dazzler open if
        s" Cannot find file 'image.dazzler'" failmsg exit
    then
    3 playstream
    image.dazzler fplay
    CSPI
    dup 0= if
        $1024. eve@ $5a61 = if
            s" Slot 0 must a full boot image" failmsg drop exit
        then
    then
    slot flashoff 2!
    1 display
    (loadbin)
    ;

: bootloop
    ['] chars is menu
    ['] dialog is failmsg
    0 mux0
    eve-start
    CSPI
    slotnames
    1 playstream

    0
    begin
        wii-edge
        dup if cr .s then
        case
        $1000 of run endof
        $0800 of ['] dialog (loadsd) exit endof
        $0040 of 1+ endof
        $0100 of 1- endof
        endcase

        p2 det $20 and or
        p1 det $10 and or
        sd-det $08 and or
        dup display
        $7 and

        check-ctrl-c

    again
;

: bootmenu begin bootloop again ;

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

: sep space '|' emit space ;

:noname
    ." boot_base"               sep
    ." slot " origin .          sep
    dna type                    sep
    stamp type                  sep
    ." GENERAL5=" general5 .x   sep

    general5 $DA22 = if
        eve-start loadbin begin again
    then
    ['] bootmenu is menu            \ START+X+Y brings up the bootmenu
    wii-poll
    200 ms key? if                  \ Keypress in 200 ms, drop to prompt
        quit
    then
    cr
    cr ." Gameduino 3X Dazzler"
    cr ." Press ^C for command prompt"
    cr
    CSPI idle sack
    eve-start                       \ init EVE
    wii-poll                        \ Check for START+X+Y
    0 playstream                    \ The load screen
    5 MUX0                          \ User has the SPI
    wii-main                        \ wii port loop, never returns
; init !

\ --------------------------------------------- command-line

: loadsd ( u )  \ load SD slot u from microSD image.dazzler
    0 mux0 cspi
    ['] type (loadsd)
    ;

: zslot ( u )   \ erase slot u
    dup 0= if drop ." Not erasing slot 0" exit then
    slot
    DSPI
    $d8 wcmd addro notbusy
    ;

' loadsd is serv-load               \ Allow SPI slot loading
