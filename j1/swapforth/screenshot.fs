\ 
\ Send a buffer as a sequence of run/literal pairs
\ a pair looks like:
\   #-to-repeat #-to-insert <literals>
\
\ The initial value at the start of the run is 0
\
variable tx

: send-length ( u -- )
    begin
        dup 254 >
    while
        255 -
        $ff emit
    repeat
    emit
;

: flush ( mode a -- mode )
    over if
        tx @ 2dup -         ( a tx u -- )
        dup send-length type
    else
        dup tx @ -
        send-length
    then
    tx !
    invert
;

: rlc
    2dup + >r       \ end-of-buffer
    over tx !
    0 -1            ( mode prev )
    2swap
    bounds do
        i @ <>      ( mode cmp )
        over xor    ( mode ok )
        if
            i flush
        then
        i @         ( mode prev )
    4 +loop
    drop
    r> flush
    if
        0 send-length
    then
;

: send32
    dup emit >< emit 0 emit 0 emit
;

$2010 reg         REG_SCREENSHOT_EN     \ Set to enable screenshot mode
$2014 reg         REG_SCREENSHOT_Y      \ Y line register
$2018 reg         REG_SCREENSHOT_START  \ Screenshot start trigger
$20e8 reg         REG_SCREENSHOT_BUSY   \ Screenshot ready flags
$2174 reg         REG_SCREENSHOT_READ   \ Set to enable readout
$3c2000. 2constant RAM_SCREENSHOT       \ Screenshot readout buffer

\ Send a compressed screenshot 
\ Uses 512 bytes at PAD

: GD.!
    eve! >spiw ;

: GD.move   ( caddr u a -- ) \ copy u bytes to caddr from GD memory a
    (eve@) bounds do spi> i c! loop ;

: screenshot
    0 mux0
    finish

    1 REG_SCREENSHOT_EN GD.!
    0 REG_PCLK GD.!
    cr ." !screenshot"
    REG_HSIZE eve@ send32 REG_VSIZE eve@ send32
    REG_VSIZE eve@ 0 do
        i REG_SCREENSHOT_Y GD.!
        1 REG_SCREENSHOT_START GD.!
        1 ms
        \ begin
        \     REG_SCREENSHOT_BUSY dup eve@
        \     swap cell+ eve@ or 0=
        \ until
        begin
            REG_SCREENSHOT_BUSY eve@
            spiw> or spiw> or spiw> or 0=
        until

        1 REG_SCREENSHOT_READ GD.!

        \ REG_HSIZE eve@ 4 * 0 do
        \     REG_HSIZE eve@ 4 * i - 512 min
        \     pad over RAM_SCREENSHOT i m+ GD.move
        \     pad over rlc \ type
        \ +loop
        0 send-length
        REG_HSIZE eve@ dup send-length
        RAM_SCREENSHOT (eve@) 
        0 do
            spi> >r
            spi> >r
            spi>
            emit r> emit r> emit
            spi> drop
        loop

        0 REG_SCREENSHOT_READ GD.!
    loop
    0 REG_SCREENSHOT_EN GD.!
    1 REG_PCLK GD.!
    \ key [char] k <> 100 and throw
;
