
warnings off

next-arg r/o bin open-file drop constant ans
s" out" w/o bin create-file drop constant out

: playstream drop ; : stream ;
$00302070. 2constant REG_PCLK 
variable mode

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
: w>gd
    dup 65535 > throw
    0 >spid ;

: mconstant
    create
    does>   @ ;

include _textmode.fs
include textmode2.fs

: terminal
    begin
        getc
        case
        10 of down1 endof
        13 of 0 cx ! endof
        27 of csi endof
        dup plain
        endcase
    again
    ;

terminal
bye
