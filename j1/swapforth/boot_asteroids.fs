#include daznuc.fs
#include wii.fs

\ IO ports:                     R               W
\
\   300     DVG RAM ACCESS      dvg_d           dvg_a
\   301                         debug           run,reset
\   302                         dvg_go_flag
\   500                                         switches

: dvg@
    2* dup $300 io! $300 io@
    swap 1+ $300 io! $300 io@
    >< or ;

#include dvg.fs

: dvg?
    cr ." DUMP"
    2048 0 do
        i 31 and 0= if cr i .x space space then
        i $300 io! $300 io@ .x2
    loop
    ;

: c $301 io! ;

: 6502-reset
    1 c 3 c 1 ms 2 c 1 ms 0 c
    ;

: button ( b dst-mask bit byte -- b' )
    wiistate + c@ and 0= and or ;

: controls
    0
    wiistate 4 + @ if
        $0008 $08 5 button      \ (X) SWHYPER
        $0010 $10 5 button      \ (A) SWFIRE
        $0800 $04 4 button      \ (+) SW1START
        $2000 $40 5 button      \ (B) SWTHRUST
        $4000 $80 4 button      \ (BDR) SWROTRGHT
        $8000 $02 5 button      \ (BDL) SWROTLEFT
    then
    $500 io! ;

: asteroids
    0 mux0
    CSPI
    eve-start 0 playstream finish

    /eve-qpi

    0 $500 io!
    6502-reset

    0
    begin
\ cr .s
        stream dvg-preamble
        2 c
        $302 io@
        begin dup $302 io@ <> until
        drop
        0 c

        render
        wii-poll controls
        finish
        REG_FRAMES eve@ tuck - -1 <> if cr ." dropped" .s then
    again
    ;

: cold
    cr ." Asteroids"
    200 ms key? if
        quit
    else
        asteroids
        quit
    then ;
' cold init !

\ : s
\         stream dvg-preamble
\         2 c
\         $302 io@
\         begin dup $302 io@ <> until
\         drop
\         0 c
\         render finish
\         dvg?
\ ;
\ 
\ 
\ 


: x
    begin
        wii-poll
        wiistate 6 dump .s
    again
    ;

