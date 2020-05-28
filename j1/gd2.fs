\ Uses port $0008 bits:
\   bit 0       CS
\   bit 1       MOSI
\   bit 2       SCK
\   bit 3       MISO
\

new

create xx

: unsel
    1 1 io!  ;

: sel ;

: >spi
    8 lshift
    8 0 do
        dup 0< 2 and            \ extract MS bit
        dup 1 io!               \ lower SCK, update MOSI
        4 + 1 io!               \ raise SCK
        2*                      \ next bit
    loop
    drop ;

: spi>
    0
    8 0 do
        2 1 io!                 \ lower SCK, MOSI high
        6 1 io!                 \ raise SCK
        2*                      \ next bit
        1 io@ 8 and +           \ read MISO, accumulate
    loop
    2/ 2/ 2/
;

: gd2-spi-init
    %0111 2 io! unsel ;

\ Send 16-bits little-endian to SPI
: w>spi ( x -- )
    dup >spi 8 rshift >spi ;

: hostcmd2 ( u0 u1 -- )     \ Send (u0, u1, 00) to hw
    sel
    swap >spi
    >spi
    00 >spi
    unsel
    60 ms ;

: hostcmd ( u )             \ Send (u, 00, 00) to hw
    0 hostcmd2 ;

hex

\ Register definitions. Uncomment as needed.

  2408 constant _CLOCK
\ 24ec constant _CMD_DL
  24e4 constant _CMD_READ
  24e8 constant _CMD_WRITE
\ 241c constant _CPURESET
\ 2464 constant _CSPREAD
\ 245c constant _DITHER
\ 2450 constant _DLSWAP
\ 2404 constant _FRAMES
\ 240c constant _FREQUENCY
  2490 constant _GPIO
  248c constant _GPIO_DIR
\ 2428 constant _HCYCLE
\ 242c constant _HOFFSET
\ 2430 constant _HSIZE
\ 2434 constant _HSYNC0
\ 2438 constant _HSYNC1
\ 2400 constant _ID
\ 249c constant _INT_EN
\ 2498 constant _INT_FLAGS
\ 24a0 constant _INT_MASK
\ 24c8 constant _MACRO_0
\ 24cc constant _MACRO_1
\ 2458 constant _OUTBITS
  246c constant _PCLK
  2468 constant _PCLK_POL
\ 2488 constant _PLAY
\ 24b4 constant _PLAYBACK_FORMAT
\ 24b0 constant _PLAYBACK_FREQ
\ 24a8 constant _PLAYBACK_LENGTH
\ 24b8 constant _PLAYBACK_LOOP
\ 24bc constant _PLAYBACK_PLAY
\ 24ac constant _PLAYBACK_READPTR
\ 24a4 constant _PLAYBACK_START
\ 24c4 constant _PWM_DUTY
\ 24c0 constant _PWM_HZ
  2454 constant _ROTATE
\ 2484 constant _SOUND
  2460 constant _SWIZZLE
\ 2478 constant _TAG
\ 2470 constant _TAG_X
\ 2474 constant _TAG_Y
\ 2574 constant _TOUCH_DIRECT_XY
\ 2578 constant _TOUCH_DIRECT_Z1Z2
\ 2508 constant _TOUCH_RAW_XY
\ 250c constant _TOUCH_RZ
\ 2504 constant _TOUCH_RZTHRESH
  2510 constant _TOUCH_SCREEN_XY
  2518 constant _TOUCH_TAG
\ 2514 constant _TOUCH_TAG_XY
\ 251c constant _TOUCH_TRANSFORM_A
\ 9000 constant _TRACKER
  256c constant _TRIM
\ 243c constant _VCYCLE
\ 2440 constant _VOFFSET
\ 247c constant _VOL_PB
\ 2480 constant _VOL_SOUND
\ 2444 constant _VSIZE
\ 2448 constant _VSYNC0
\ 244c constant _VSYNC1
\ 8000 constant _CMD
\ 0000 constant _DL

0600 constant _CENTER
0200 constant _CENTERX
0400 constant _CENTERY
0100 constant _FLAT
0001 constant _MONO
1000 constant _NOBACK
0002 constant _NODL
c000 constant _NOHANDS
4000 constant _NOHM
4000 constant _NOPOINTER
8000 constant _NOSECS
2000 constant _NOTICKS
0800 constant _RIGHTX
0100 constant _SIGNED
0008 constant _FULLSCREEN     \ FT81x only

0001 constant _BITMAPS
0002 constant _POINTS
0003 constant _LINES
0004 constant _LINE_STRIP
0009 constant _RECTS

\ Start an SPI transaction with a 24-bit big-endian address
: a24 ( lo16 hi8 -- )
    unsel sel
    >spi
    dup 8 rshift >spi >spi ;

\ Write to GPU register memory
: g! ( val regaddr -- )
    090 a24
    w>spi ;

\ Read from GPU register memory
: g@ ( regaddr -- val )
    010 a24
    0ff >spi
    spi> spi> 8 lshift + ;

variable wp                 \ FIFO write pointer

: wp@
    wp @ 0fff and ;

: stream
    wp@ 08000 + 090 a24 ;

: sendn ( u -- )
    wp +! ;
: send4
    4 sendn ;

\ These all send N words to GPU in stack order
: hh  ( x0 x1 -- )
    send4 swap w>spi w>spi ;
: hhhh ( x0 x1 x2 x3 -- )
    >r >r hh r> r> hh ;
: hhhhhh ( x0 x1 x2 x3 x4 x5 -- )
    >r >r hhhh r> r> hh ;
: hhhhhhhh ( x0 x1 x2 x3 x4 x5 x6 x7 -- )
    >r >r hhhhhh r> r> hh ;

: cmd ( xx -- ) \ Send command word 0xffffffxx to GPU
    $ff00 + true hh ;

\ These instructions are single-bit. 
: GD.Begin  ( prim )            $1f00 hh ;
: GD.BitmapHandle ( handle )    $0500 hh ;
: GD.BitmapSource ( addr. )     $0100 + hh ;
: GD.Cell                       $0600 hh ;
: GD.Clear                      7 $2600 hh ;
: GD.ColorA ( a )               $1000 hh ;
: GD.PointSize ( size )         $0d00 hh ;
: GD.LineWidth ( width )        $0e00 hh ;
: GD.SaveContext                0 $2200 hh ;
: GD.RestoreContext             0 $2300 hh ;
: GD.Tag                        $2400 hh ;
: GD.TagMask ( m )              $1400 hh ;

: GD.ClearColorRGB ( r g b )    send4 >spi >spi >spi $02 >spi ;
: GD.ColorRGB ( r g b )         send4 >spi >spi >spi $04 >spi ;

\ These commands are always 32-bit, but are composed of variable-sized
\ bitfields.  Accumulate one bit at a time in acc, flushing each byte
\ as the counter bit# reaches 7.
\
variable acc variable bit#

: 1> ( u -- ) \ Send low bit of u to SPI
    1 and bit# @ 7 and tuck lshift acc +!
    7 = if
        acc @ >spi 0 acc !
    then
    1 bit# +! ;
: >> ( u n -- ) \ Send n bit value to SPI
    0 do dup 1> 2/ loop drop ;

decimal

: fin   0 bit# ! 0 acc ! ;      \ reset counter and accumulator
: opcode ( op -- )              \ Pad to 24 bits and send opcode
    24 bit# @ ?do
        acc @ >spi
    8 +loop
    >spi fin ;

: GD.AlphaFunc ( func ref )     send4 8 >> 3 >> $09 opcode ;
: GD.BitmapLayout ( fmt bw h )  send4 9 >> 10 >> 5 >> $07 opcode ;
: GD.BitmapSize ( f wx wy w h ) send4 9 >> 9 >> 1> 1> 1> $08 opcode ;
: GD.BlendFunc ( src dst )      send4 3 >> 3 >> $0b opcode ;
: GD.ColorMask ( r g b a )      send4 1> 1> 1> 1> $20 opcode ;
: GD.ScissorSize ( w h )        send4 12 >> 12 >> $1c opcode ;
: GD.ScissorXY ( x y )          send4 11 >> 11 >> $1b opcode ;

: GD.Vertex2ii ( x y h cell )   send4 7 >> 5 >> 9 >> 9 >> 2 2 >> fin ;
: GD.Vertex2f ( x y )           send4 15 >> 15 >>       1 2 >> fin ;
hex

: GD.flush  \ Force all pending commands out to the GPU
    wp@ _CMD_WRITE g!
    stream ;
: GD.finish \ GD.flush, and then wait for everything to execute
    GD.flush
    begin
        _CMD_READ g@ wp@ =
    until
    stream ;

variable tag variable x variable y

: GD.swap
    0. hh              \ DISPLAY
    01 cmd             \ cmd_swap
    00 cmd             \ cmd_dlstart
    GD.finish unsel
    _TOUCH_TAG           g@ tag !
    _TOUCH_SCREEN_XY     g@ y !
    _TOUCH_SCREEN_XY 2 + g@ x !
    stream ;
: GD.xy@    x @ y @ ;
: GD.tag@   tag @ ;

\ s>gd appends a string to the command buffer, appends a
\ zero byte, and pads to the next 32-bit boundary.  It
\ iterates through the string, ORing the characters into the
\ 32-bit accumulator on top-of-stack. Every fourth character,
\ it sends the word to the hardware, and clears the
\ accumulator. After the loop, it flushes the partially-filled
\ accumulator to the hardware.

: s>gd   ( addr u -- ) \ send RAM string to the command buffer
    >r
    r@ 4 + -4 and sendn
    r@ bounds ?do
        i c@ >spi
    loop
    4 r> 3 and do
        0 >spi
    loop ;

: >"    \ Send embedded string to the command buffer
    [char] " parse
    postpone sliteral postpone s>gd ; immediate

: GD.r! ( val reg# )
    01a cmd             \ cmd_memwrite
    $10 hh
    2. hh
    0 hh
    GD.flush ;

: GD.cmd_number  ( x y font options n. -- )
    02e cmd hhhhhh ;
: GD.cmd_text  ( x y font options -- )  \ string follows
    00c cmd hhhh ;
: GD.cmd_button  ( x y w h font options -- )  \ string follows
    00d cmd hhhhhh ;
: GD.cmd_clock  ( x y r options h m s ms -- )
    014 cmd hhhhhhhh ;
: GD.cmd_coldstart  ( -- )
    032 cmd ;
: GD.cmd_dial  ( x y r options val -- )
    02d cmd 0 hhhhhh ;
: GD.cmd_gauge  ( x y r options major minor val range -- )
    013 cmd hhhhhhhh ;
: GD.cmd_gradient  ( x0 y0 rgb0 x1 y1 rgb1 -- )
    00b cmd hhhhhhhh ;
: GD.cmd_keys  ( x y w h font options -- )    \ string follows
    00e cmd hhhhhh ;
: GD.cmd_loadidentity  ( -- )
    026 cmd ;
: GD.cmd_loadimage  ( ptr. options -- )
    024 cmd 0 hhhh ;
: GD.cmd_progress  ( x y w h options val range -- )
    00f cmd 0 hhhhhhhh ;
: GD.cmd_rotate  ( a -- )
    029 cmd 0 hh ;
: GD.cmd_scale  ( sx sy -- )
    028 cmd hhhh ;
: GD.cmd_scrollbar  ( x y w h options val size range -- )
    011 cmd hhhhhhhh ;
: GD.cmd_sketch  ( x y w h ptr. format -- )
    030 cmd 0 hhhhhhhh ;
: GD.cmd_slider  ( x y w h options val range -- )
    010 cmd 0 hhhhhhhh ;
: GD.cmd_stop  ( -- )
    017 cmd ;
: GD.cmd_toggle  ( x y w font options state -- )  \ string follows
    012 cmd hhhhhh ;
: GD.cmd_track  ( x y w h tag -- )
    02c cmd 0 hhhhhh ;
: GD.cmd_translate  ( tx ty -- )
    027 cmd hhhh ;

decimal

: measure ( -- u ) \ count FT800 cycles in 1 ms
    _CLOCK g@ 1 ms _CLOCK g@ swap - ;

: GD.init
    gd2-spi-init
    unsel
    $00 hostcmd
    $62 hostcmd     \ CLK48M: for no-crystal parts like GD2
    $68 hostcmd     \ CORERST

    \ _ID g@ .      \ Should print 7C, the FT800 IDE register
    #32 0 do
        i _TRIM g!
        measure #46000 u> if leave then
    loop

    $80 _GPIO_DIR     g!    \ Enable display
    $80 _GPIO         g!
    1 _PCLK_POL       g!    \
    3 _SWIZZLE        g!    \ B,G,R color order
    1 _ROTATE         g!    \ Gameduino 2 is upside-down

    fin
    0 wp !
    stream
    GD.Clear
    GD.swap
    5 _PCLK GD.r! ;         \ Turn on display clock

here xx - .

: ??
    $8000 wp @ bounds do
        i u. i g@ $ff and u. cr
    loop ;

: helloworld
    GD.init
    0 64 0 GD.ClearColorRGB
    GD.Clear
    240 106 31 _CENTER GD.cmd_text >" Hello world"
    240 166 31 _CENTER GD.cmd_text 123. <# #s #> s>gd
    _POINTS GD.Begin
    $11 $22 0 0 GD.Vertex2ii
    255 0 100 GD.ColorRGB
    128 GD.ColorA
    1600 GD.PointSize
    240 132 0 0 GD.Vertex2ii
    GD.swap ;

: calibrate
    GD.Clear
    240 136 29 _CENTER GD.cmd_text >" Please tap on the dot"
    $15 cmd 0. hh
    GD.finish
    00 cmd ;           \ cmd_dlstart

: touchdemo
    GD.init
    calibrate
    begin
        GD.Clear
        320 GD.PointSize
        _POINTS GD.Begin
        GD.xy@ 0 0 GD.Vertex2ii
        GD.swap
        wp @ .x cr
    again ;

: thrash
    GD.init
    0.
    begin
        0 64 0 GD.ClearColorRGB
        GD.Clear
        240 136 31 _CENTER GD.cmd_text
        2dup <# #s #> s>gd
        1. d+
        GD.swap
    again ;

variable seed $0947 seed !

: random
    seed @ $5ce1 + dup 6 lshift +
    $2000 io@ $10 and 0= xor
    dup seed ! ;

: rr 
    random um* nip ;

16 60 * constant pointsize
: fizz
    GD.init
    480 16 * 272 16 *   ( width height )
    120 0 do
        GD.Clear
        _POINTS GD.Begin
        200 0 do
            pointsize rr GD.PointSize
            random random random GD.ColorRGB
            random GD.ColorA
            over rr over rr GD.Vertex2f
        loop
        GD.swap
    loop ;
