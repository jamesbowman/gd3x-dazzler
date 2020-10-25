
next-arg r/o bin open-file drop constant ans
s" out" w/o bin create-file drop constant out

create c 1 allot
: getc
    c 1 ans read-file throw
    0= if
        cr ." FINISHED " .s cr depth 0<> throw
        out close-file drop
        bye
    then
    c c@
;

create spot 4 allot
: >spid ( d. )
    drop
    spot l! spot 4 out write-file throw
;

: >gd >spid ;
: w>gd 0 >spid ;

0 constant BG
2 constant FG
include _textmode.fs

: cmd ( u ) 0 $ffffff00. d+ >gd ;
: cmd_memcpy ( dst src n )
    $1d cmd ;

variable cx variable cy     0 cx ! 0 cy !
2variable colors            7. colors 2!
create args 8 cells allot

: number ( -- k u )
    0
    begin
        getc
        dup $30 $3a within
    while
        swap 10 * swap $30 - +
    repeat
    swap ;

: getargs ( nargs k )
    args 8 cells erase
    8 0 do
        number args i cells + !
        dup ';' <> if
            i 1+ swap unloop exit
        then
        drop
    loop
    \ xxx
    ;

: cop ( color code )
    10 mod
    swap 8 and +
    ;

: setcolor
    cmd_memcpy
    w>gd
    2* 4 + w>gd
    2 w>gd
    ;

: sgr ( n )
    colors 2@
    rot 0 ?do
        args i cells + @
        case
        0 of    2drop 7.                    endof
        1 of    swap 8 or swap              endof
        5 of    8 or                        endof
        39 of   8 and 7 or                  endof
        49 of   swap 8 and swap             endof
        dup 30 38 within if >r swap r> cop swap 0 then
        dup 40 48 within if cop 0 then
        endcase
    loop
    2dup colors 2!
    BG setcolor FG setcolor
    ;

: csi
    getc '[' <> if exit then
    getargs     ( nargs k )
    case
    'm' of sgr endof
    endcase
;

: plain
    cmd_memcpy
    cy @ t.W * cx @ + dup >r
    t.g um*
    t.fb 0
    d+ >gd
    $20 - t.g *
    t.fm + w>gd
    t.g w>gd

    cmd_memcpy
    t.ca 
    r> 2* +
    dup w>gd
    FG w>gd
    2 w>gd

    cmd_memcpy
    t.ca1 + w>gd
    BG w>gd
    2 w>gd

    1 cx +!
    ;

: process
    case
    10 of 1 cy +! endof
    13 of 0 cx ! endof
    27 of csi endof
    dup plain
    endcase
    ;

:noname
    begin
        getc
        process
    again
; execute
bye
