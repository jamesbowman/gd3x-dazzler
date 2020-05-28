\ https://wiibrew.org/wiki/Wiimote/Extension_Controllers

\ new

\ Port 2 and 3
\   2   1   0
\  SCL DET SDA

variable pl false pl !  \ player select, 

: i2cr ( 2 or 3 ) 2 pl @ - ;
: i2cw ( 7 4 or 10 7 ) pl @ 3 and 7 + dup 3 - ;

: i2c!  i2cr io! ;
: i2c@  i2cr io@ ;

: det ( -- f )
    i2c@ 2 and 0<> ;
: >SDA    ( f -- )    \ write f to the SDA line
    1 and
    i2c@ 4 and or i2c! ;
: SDA>    ( -- f )    \ read the state of the SDA line
    i2c@ 1 and ;
: SCL-0   ( -- )      \ drive SCL low
    SDA> i2c! ;
: SCL-1   ( -- )      \ drive SCL high
    SDA> 4 + i2c!
    begin i2c@ 4 and until \ wait for it to rise
    ;
: half    ( -- )      \ half-cycle delay
    20 0 do loop ;


: i2c-rx-bit ( -- b )
    1 >SDA half SCL-1 half SDA> SCL-0 ;
: i2c-tx-bit ( f -- )
    0<> >SDA half SCL-1 half SCL-0 ;
: i2c-tx    ( b -- nak )
    8 0 do dup 128 and i2c-tx-bit 2* loop drop i2c-rx-bit ;
: i2c-rx    ( nak -- b )
    0 8 0 do 2* i2c-rx-bit + loop swap i2c-tx-bit ;

: i2c-start ( dev - nak )
    1 >SDA half SCL-1 half 0 >SDA half SCL-0
    i2c-tx
    ;
: i2c-stop
    0 >SDA half SCL-1 half 1 >SDA half ;

: i2c-reset
    9 0 do i2c-rx-bit drop loop i2c-stop ;

: tx ( x )              \ Send byte to i2c
    i2c-tx drop ;

defer restart

: ack
    if ( cr ." Panic" ) restart then ;

: wii ( reg )
    $52 2* i2c-start ack tx ;
: wii! ( val reg )
    wii tx i2c-stop ;
: wii@ ( reg )
    wii i2c-stop
    $52 2* 1+ i2c-start ack ;

\ : wii-idcode
\     $fa wii@
\     0 i2c-rx .x
\     0 i2c-rx .x
\     0 i2c-rx .x
\     0 i2c-rx .x
\     0 i2c-rx .x
\     1 i2c-rx .x
\     i2c-stop ;
\ 
\ : scan
\     120 8 do
\         i 2* i2c-start i2c-stop
\         cr i .x .
\     loop ;

: present ( - f  true if present )
    det dup
    0= if
        i2cw do
            0 i io!
        loop
    then ;

: /wii
    present if
        i2c-reset
        $55 $f0 wii!
        $00 $fb wii!
        \ wii-idcode
    then ;

: sense
    present if
        $00 wii@
        i2cw do
            0 i2c-rx 
            0 i2c-rx >< +
            i io!
        loop
        1 i2c-rx drop
        i2c-stop
    then
    ;

: both ( xt ) false pl ! dup execute true pl ! execute ;

: wii-main
    ['] /wii both
    begin
        ['] sense both
    again ;

' wii-main is restart
\ ' quit is restart

: wii?
    begin
        cr
        2 io@ .x
        3 io@ .x
    again ;
