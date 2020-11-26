#include nuc.fs

: dvg?
    cr ." DUMP"
    2048 0 do
        i 31 and 0= if cr i .x space space then
        i $300 io! $300 io@ .x2
    loop
    ;

: c $301 io! ;
: run
    1 c 1 ms 0 c
    2 c
    30 0 do
        cr $301 io@ .x
    loop ;

: dvg@
    2* dup $300 io! $300 io@
    swap 1+ $300 io! $300 io@
    >< or ;

#include dvg.fs

: x
    0 mux0
    CSPI
    0
    begin
        stream dvg-preamble
        2 c
        $302 io@
        begin dup $302 io@ <> until
        drop
        0 c

        render finish
        REG_FRAMES eve@ tuck - -1 <> if cr ." dropped" .s then
    again
    ;

: s
        stream dvg-preamble
        2 c
        $302 io@
        begin dup $302 io@ <> until
        drop
        0 c
        render finish
        dvg?
;


