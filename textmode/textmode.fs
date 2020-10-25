
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

variable cx variable cy
0 cx ! 0 cy !

: process
    cmd_memcpy
    t.fb 0 cx @ t.g um* d+ >gd
    $20 - t.g *
    t.fm + w>gd
    t.g w>gd

    cmd_memcpy
    t.ca 
    cx @ 2* +
    dup w>gd
    FG w>gd
    2 w>gd

    cmd_memcpy
    t.ca1 + w>gd
    BG w>gd
    2 w>gd

    1 cx +!
    ;

:noname
    begin
        getc
        process
    again
; execute
bye
