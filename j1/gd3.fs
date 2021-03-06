\ Uses port $0008 bits:
\   bit 0       CS
\   bit 1       MOSI
\   bit 2       SCK
\   bit 3       MISO
\
\ So the PMOD looks like:
\
\
\ CS    1   7
\ MOSI  2   8
\ SCK   3   9
\ MISO  4  10
\ gnd   5  11
\ 3v3   6  12

new

%0111 2 io!     \ Set Pmod port directions

: idle
    1 1 io!
;

: us 0 do dup drop loop ;

: spix  ( x1 -- x2 ) \ SPI byte transmit x1, receive x2
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

: >spi
    8 lshift
    8 0 do
        dup 0< 2 and            \ extract MS bit
        dup 1 io!               \ lower SCK, update MOSI
        4 + 1 io!               \ raise SCK
        2*                      \ next bit
    loop
    drop
;

: spi>      0 spix ;

\ #noverbose

: 2constant create , , does> dup cell+ @ swap @ ;

$302008. 2constant REG_CLOCK
$302100. 2constant REG_CMD_DL
$3020f8. 2constant REG_CMD_READ
$3020fc. 2constant REG_CMD_WRITE
$302020. 2constant REG_CPURESET
$302068. 2constant REG_CSPREAD
$302060. 2constant REG_DITHER
$302054. 2constant REG_DLSWAP
$302004. 2constant REG_FRAMES
$30200c. 2constant REG_FREQUENCY
$302094. 2constant REG_GPIO
$302090. 2constant REG_GPIO_DIR
$30202c. 2constant REG_HCYCLE
$302030. 2constant REG_HOFFSET
$302034. 2constant REG_HSIZE
$302038. 2constant REG_HSYNC0
$30203c. 2constant REG_HSYNC1
$302000. 2constant REG_ID
$3020ac. 2constant REG_INT_EN
$3020a8. 2constant REG_INT_FLAGS
$3020b0. 2constant REG_INT_MASK
$3020d8. 2constant REG_MACRO_0
$3020dc. 2constant REG_MACRO_1
$30205c. 2constant REG_OUTBITS
$302070. 2constant REG_PCLK
$30206c. 2constant REG_PCLK_POL
$302058. 2constant REG_ROTATE
$302064. 2constant REG_SWIZZLE
$302180. 2constant REG_TRIM
$302040. 2constant REG_VCYCLE
$302044. 2constant REG_VOFFSET
$302080. 2constant REG_VOL_PB
$302084. 2constant REG_VOL_SOUND
$302048. 2constant REG_VSIZE
$30204c. 2constant REG_VSYNC0
$302050. 2constant REG_VSYNC1
$302574. 2constant REG_CMDB_SPACE
$302578. 2constant REG_CMDB_WRITE

: addr ( a. -- )    idle >spi dup 8 rshift >spi >spi ;
: u>spi ( u -- )    dup >spi 8 rshift >spi ;
: spi>u ( -- u )    spi> spi> 8 lshift + ;
: hostcmd ( u -- )  idle >spi 0 u>spi idle 200 ms ;

( Register read/write single and double cell )
: rd ( a. -- u )    addr 0 >spi spi>u ;
: rdd ( a. -- u. )  rd spi>u ;
: wr ( u a. -- )    $80 + addr u>spi ;
: wrd ( u. a. -- )  wr u>spi ;

: gostream          REG_CMDB_WRITE $80 + addr ;
: >gd ( u. -- )     2dup .x .x cr
    swap u>spi u>spi ;
: cmd ( u -- )      $ff00 or true >gd ;
: +dl ( d. u -- )   8 lshift + >gd ;

: GD.CLEARCOLORRGB  2 +dl ;
: GD.CLEAR          7. 38 +dl ;
: GD.swap
    $00000000. >gd  \ DISPLAY
    $01 cmd         \ cmd_swap
    $00 cmd         \ cmd_dlstart
;

: x
    100 ms
    $00 hostcmd     \ ACTIVE
    $68 hostcmd     \ CORERST
    1000 ms
    cr
    REG_ID rd .x cr
    $c0000. rd .x cr
;

: measure
    REG_CLOCK rdd
    1000 ms
    REG_CLOCK rdd
;

: report
    2swap dnegate d+ decimal d.
;


: v
    x
    1344    REG_HCYCLE wr
    160     REG_HOFFSET wr
    1024    REG_HSIZE wr
    0       REG_HSYNC0 wr
    24      REG_HSYNC1 wr

    806     REG_VCYCLE wr
    9       REG_VOFFSET wr
    768     REG_VSIZE wr
    0       REG_VSYNC0 wr
    6       REG_VSYNC1 wr
    0       REG_DITHER wr
    0       REG_PCLK_POL wr
    1       REG_PCLK wr

    \ gostream
    \ $ff00ff. GD.CLEARCOLORRGB
    \ GD.CLEAR
    \ GD.swap
    \ idle

    REG_FRAMES rd
    1000 ms
    REG_FRAMES rd
    swap - .
; 
