: slot ( u - d )  $10 * 0 swap ;

: run ( slot# )     \ Boot from a slot
    slot
    0 mux0 DSPI
    2dup $24 m+ read
    spiw> $5a61 = if
        icap-13
        $0 $3f80 bounds chain
    then
    iprog
    ;

: reboot        \ Boot from slot 0
    0 run ;

: origin ( - d )    \ Which slot we boot from?
    $14 icap@ 4 rshift 7 and ;

\ A valid slot starts with 22 DA 1E 55, then has a 32-byte 0-terminated string
: slotvalid
    slot read
    spiw> $22DA =
    spiw> $551E =
    and ;

: slot?
    slotvalid
    0= if '-' emit exit then
    begin
        spi> ?dup
    while
        emit
    repeat ;

: slots
    0 mux0 DSPI
    8 0 do
        cr i . i slot?
    loop cr ;
