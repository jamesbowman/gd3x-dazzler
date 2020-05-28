\ new
variable w0y
: array create does> swap cells + ;
array shadow   256 cells allot

3 constant UNIT-ID

UNIT-ID 2* $a0 + constant ADDR

: reg@
    case
    $00 of  $5501 endof
    $01 of  256 io@ endof
        dup shadow @ swap
    endcase ;

: reg!
    dup $40 $c1 within if
        2dup io!
        shadow !
    else
        2drop
    then ;

\ ------------------------------------------------------------

variable (byte) : byte (byte) @ execute ;
' drop (byte) !
: expect ' postpone literal postpone (byte) postpone ! ; immediate

variable reg variable val

: tx ( b -- )
    2 io!
    begin 0 io@ until
    begin 0 io@ 0= until ;

: respond
    reg @ reg@
    2 0 do
        8 0 do
            dup 0< tx 2*
        loop
        1 tx
    loop
    drop ;

: val1 ( bb -- ) val @ 8 lshift + reg @ reg! expect drop ;
: val0  ( bb - ) val ! expect val1 ;
: wrreg ( bb -- ) reg ! expect val0 ;

: device ( bb -- )
    case
    ADDR    of  expect wrreg endof
    ADDR 1+ of  respond endof
                expect drop
    endcase ;

\ ------------------------------------------------------------

variable bit#
variable acc

: start
    expect device
    0 bit# ! ;

: stop      ;
: bit
    1 bit# +!
    bit# @ 9 = if
        drop
        0 bit# !
        acc c@ byte
    else
        acc @ 2* + acc !
    then ;

\ ------------------------------------------------------------


: sense ( -- sdascl )
    1 io@ 2* 0 io@ + ;

: change ( hist -- hist )
    begin
        sense over 3 and over =
    while
        drop
    repeat
    swap 2* 2* + ;

: x
    1 2 io!     \ SPI pullup
    0 w0y !
    0
    15 0 do
        40 i $40 + shadow !         ( PX )
        i 40 * i $80 + shadow !     ( W0X )
    loop
    begin
        change
        dup %1111 and %1101 = if start then
        dup %1111 and %0111 = if stop then
        dup %111111 and %000100 = if 0 bit then
        dup %111111 and %101110 = if 1 bit then
    again ;

' x init !
unused .
