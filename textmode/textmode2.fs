0 constant BG
2 constant FG


: cmd ( u ) 0 $ffffff00. d+ >gd ;
: cmd_memcpy \ dst src n
    $1d cmd ;
: cmd_memwrite \ dst n
    $1a cmd ;

2variable cy                    \ so "cy 2@" is ( x y )
cy cell+ constant cx
0. cy 2!
variable yo 0 yo !
2variable csave
2variable colors            7. colors 2!
create argv 10 cells allot
variable pa

: arg  ( -- a ) pa @ @ 1 cells pa +! ;
\ Missing args are -1
: present   0< invert ;

: number ( -- k u )
    0
    begin
        getc
        dup $30 $3a within
    while
        $30 - swap 10 * +
    repeat
    swap ;

: getargs ( k )
    argv 10 cells -1 fill
    argv pa !
    8 0 do
        number argv i cells + !
        dup ';' <> if
            unloop exit
        then
        drop
    loop
    \ xxx
    ;

: cop ( color code )
    swap 8 and + ;

: c256 ( color -- color )
    arg 5 = if
        drop arg
    then ;

: setcolor
    cmd_memcpy
    w>gd
    2* 4 + w>gd
    2 w>gd
    ;

: sgr
    colors 2@
    begin
        arg dup present
    while
        \ cr dup .
        case
        0 of    2drop 7.                    endof
        1 of    swap 8 or swap              endof
        5 of    8 or                        endof
        38 of   swap c256 swap              endof
        39 of   swap 8 and 7 or swap        endof
        48 of   c256                        endof
        49 of   8 and                       endof
        dup 30 38 within if 30 - rot swap cop swap 0 then
        dup 40 48 within if 40 - cop 0 then
        endcase
        \ .s
    repeat
    drop
    2dup colors 2!
    BG setcolor FG setcolor
    ;

: hmod
    t.H 1- over <
    t.H and - ;

: yoff yo @ + hmod ;
: cursor
    cy 2@
    yoff
    t.W * + ;

: ++ ( a b u -- a+u b+u )
    tuck + >r + r> ;

: aclr ( a0 a1 )
    cmd_memcpy
    over w>gd
    BG w>gd
    2 w>gd

    cmd_memcpy
    over 2 + w>gd
    over w>gd
    swap - 2 - w>gd
    ;

: aclr2 ( a0 a1 )
    2dup aclr t.ca1 ++ aclr ;

:  lineclr ( x0 x1 )
    2* swap 2* swap
    cy @ yoff t.W * 2* t.ca +
    ++                  ( a0 a1 )
    aclr2 ;

: a0
    arg 1 max ;

: csi
    getc '[' <> if exit then
    getargs     ( k )
    case
    'm' of sgr endof
    'A' of
        cy @ a0 - 0 max cy !
    endof
    'B' of
        cy @ a0 + t.H 2 - min cy !
    endof
    'C' of
        cx @ a0 +  t.W 1- min cx !
    endof
    'D' of
        cx @ a0 -  0 max cx !
    endof
    'H' of
        a0 1- cy !
        a0 1- cx !
    endof
    'J' of
        arg 1 > if
            0. cy 2!
        then
        cursor 2* t.ca1
        t.ca ++
        aclr2
    endof
    'K' of
        arg 0 max
        case
        0 of cx @ t.W        lineclr endof
        1 of 0 cx @ 1+       lineclr endof
        2 of 0 t.W           lineclr endof
        endcase
    endof
    's' of cy 2@ csave 2! endof
    'u' of csave 2@ cy 2! endof

    cr ." Unhandled >>> " emit
    endcase
;

: down1
    1 cy +!
    cy @ t.H 1- = if
        yo @ 1+ hmod yo !
        -1 cy +!
        0 t.W lineclr
        cmd_memcpy
        $3020d8. >gd
        yo @ 4 * t.scr + w>gd
        4 w>gd
    then
;

: plain
    \ cr cx @ . cy @ .
    cmd_memcpy
    cursor dup >r
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
    cx @ t.W = if
        0 cx !
        down1
    then
    ;

: v2f ( x y )
    $7fff and swap
    tuck 15 lshift or
    swap $7fff and 2/ $4000 or
    >gd ;

: macro1
    cmd_memwrite
    $3020dc. >gd
    4 w>gd
    ;

: showcursor
    macro1
    cx @ t.w2 *
    cy @ 1+ t.h2 * t.curh -
    v2f
    ;

: hidecursor
    macro1
    $2d000000. >gd ;
