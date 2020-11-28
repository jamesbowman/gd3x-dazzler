variable space 0 space !
: >gd
    space @ 0= if
        begin cmdspace $500 > until
        $100 space !
        stream
    then
    >spid
    -1 space +!
    ;

: lines
    $0004 $1f00 >gd ;

900 constant WIDTH

variable x                  \ beam position, DVG coordinates
variable y
variable sg                 \ global scale
variable sl                 \ local scale
variable bright             \ brightness, 0-15
variable (bright)

: fetch ( pc -- pc' insn )
    dup 1+ swap dvg@    ( pc insn )
    ;

: hi4 ( u -- u x )
    dup 12 rshift ;

\ return x * (2 ^ s)
\ where s is (sg - 9 + sl), sg is signed 4-bit

: scale ( x - x )
    sg @ dup 8 and 2* -
    9 - sl @ +
    dup 0< if
        negate rshift
    else
        lshift
    then ;

: signed10 ( u -- x )
    dup $3ff and scale
    swap $400 and if negate then
    ;

: signed2 ( u -- x )
    $700 and signed10
    ;

\ brightness of 0 means move
: setbright
    bright @ 
    dup 0= if
        lines drop exit
    then
    dup (bright) @ = if
        drop exit
    then
    dup (bright) !
    16 * $1000 >gd
    ;

\ from native 0-1023 to EVE coordinate
: screen
    512 -
    12 * 2/
    ;

: plot
    setbright
    \ cr ." xy " x @ . y @ . bright @ .
    y @ screen negate $7fff and
    x @ screen tuck 15 lshift or
    swap $7fff and 2/ $4000 or
    >gd
    ;

: draw ( x y )
    y +! x +!  plot
    ;

: handle-VEC ( pc insn op -- pc' )
    \ cr 14 spaces ." VEC "
    sl !
    signed10 >r
    fetch hi4 bright !
    signed10 
    r> draw
    ;

: handle-SVEC ( insn )
    \ cr 14 spaces ." SVEC "
    dup >r
    4 rshift $f and bright !
    r@ 11 rshift 1 and 
    r@ 2 rshift 2 and +
    2 + sl !
    r@ >< signed2 r> signed2 draw
    ;

: handle-LABS ( pc insn op -- pc' )
    $3ff and y !
    fetch hi4 sg ! $3ff and x !
    0 bright !
    plot ;

: dvg-preamble
    $ff00 $ffff >gd     \ cmd_dlstart
    $1010 $0210 >gd     \ ClearColor
    $0007 $2600 >gd     \ Clear
    $0003 $2700 >gd     \ VertexFormat(0)
    $0011 $0b00 >gd     \ gd.BlendFunc(eve.SRC_ALPHA, 1)
    $2800 $2b00 >gd     \ screen center
    $1680 $2c00 >gd
    lines
    ;

: dvg
    0
    begin
        fetch
        \ cr over 1- hex. dup hex.
        hi4
        case
        $a of handle-LABS endof     ( LABS )
        $b of 2drop exit endof      ( HALT )
        $c of $fff and endof        ( JSRL )
        $d of 2drop endof           ( RTSL )
        $e of nip $fff and endof    ( JMPL )
        $f of handle-SVEC endof     ( SVEC )
        handle-VEC 0                ( VEC  )
        endcase
    again
    ;

: render
    -1 (bright) !
    dvg

    $23000000. >gd
    $1f000001. >gd
    $40000000. >gd

    0 0 >gd
    $ff01 $ffff >gd
    ;

\ ------------------------------------------------------------

