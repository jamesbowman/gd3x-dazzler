
: icap!
    $12 io! ;

:  icap-idle
    2 icap! ;

: icap-clk
    dup icap! 
    dup 1+ icap! 
    icap! ;

variable swiz

: >icap ( u )
    7 flip
    $13 io!
    0 icap-clk ;

: icap> ( - u )
    icap-idle
    6 icap!
    $13 io@ .x
    4 icap-clk
    $13 io@ .x
    6 icap!
    icap-idle
    ;

: sync
    icap-idle

    $ffff >icap
    $ffff >icap
    $ffff >icap
    $ffff >icap
    $aa99 >icap
    $5566 >icap ;

: post
    $2000 >icap $2000 >icap
    $2000 >icap $2000 >icap
    $2000 >icap $2000 >icap
    $2000 >icap $2000 >icap
    ;

: x
    sync
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    $2901 >icap     \ Write Type1 packet header to read STAT register
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    icap>           \ Read one word from the STAT register to the configuration interface
    $30A1 >icap     \ Type 1 Write 1 Word to CMD
    $000D >icap     \ DESYNC Command
    $2000 >icap     \ NOOP
    $2000 >icap     \ NOOP
    ;

\ https://pdfs.semanticscholar.org/9ed4/0cc06ae964c7dc944da003ce453cc38e8138.pdf (Table 3)
: iprog ( d. )
    sync
    $31e1 >icap $ffff >icap
    $3261 >icap swap  >icap
    $3281 >icap $0300 or >icap
    $32a1 >icap $0000 >icap
    $32c1 >icap $0300 >icap
    $3301 >icap $2100 >icap
    $3201 >icap $001F >icap
    $30a1 >icap $000e >icap
    post ;

: reboot 0. iprog ;
