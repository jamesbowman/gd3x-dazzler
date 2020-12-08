\ bit   2       1       0
\       WRITE   CE      CLK

: icap!
    \ cr dup .
    $12 io! \ $12 io@ .x2
    ;

:  icap-idle
    2 icap! ;

: icap-clk
    dup icap! 
    dup 1+ icap! 
    icap! ;

: >icap ( u )
    7 flip
    $13 io!
    0 icap-clk ;

: icap> ( n - u0 .. un-1 )
    %010 icap!     \ CE deassert
    %110 icap!     \ WRITE assert
    %110 icap-clk
    %100 icap-clk
    0 do
        %100 icap-clk $13 io@ 7 flip
    loop
    %110 icap!     \ CE deassert
    %010 icap!     \ WRITE deassert
    2 icap-clk
    %000 icap!     \ CE assert
    ;

: sync
    icap-idle

    6 0 do
        $ffff >icap
    loop
    $aa99 >icap
    $5566 >icap ;

: post
    8 0 do
        $2000 >icap
    loop ;

\ https://pdfs.semanticscholar.org/9ed4/0cc06ae964c7dc944da003ce453cc38e8138.pdf (Table 3)
\ Load register 13,14
: icap-13 ( d. )
    sync
    $31e1 >icap $ffff >icap
    $3261 >icap swap  >icap
    $3281 >icap $0300 or >icap
    ;

: iprog ( d. )
    icap-13
    $32a1 >icap $0000 >icap
    $32c1 >icap $0300 >icap
    $3301 >icap $2100 >icap
    $3201 >icap $001F >icap
    $30a1 >icap $000e >icap
    post ;

: micap@ ( a u -- n... )
    sync
    $2000 >icap     \ NOOP
    swap 5 lshift
    over or
    $2800 or >icap
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    icap>
    $30A1 >icap     \ Type 1 Write 1 Word to CMD
    $000D >icap     \ DESYNC Command
    post ;

: icap@ 1 micap@ ;

: icap?
    $23 $00 do
        cr i .x2 i icap@ .x
    loop ;

: general5
    $17 icap@ ;

