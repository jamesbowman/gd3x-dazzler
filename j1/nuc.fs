\ SwapForth nucleus for J1a
\
\ This is a 16-bit forth nucleus. It provides *just enough*
\ of a Forth for the remainder of SwapForth to be compiled
\ from the UART connection.
\
\ The code here is Forth-like J1a assembler code.
\ It is compiled by cross.fs to produce nuc.hex, the boot
\ image.
\
\ Some notes on idioms in this file:
\   header xxx  creates a header entry
\   h# xxx      hex literal
\   d# xxx      decimal literal
\
\ Note that (like Colorforth) colon definitions can run
\ into each other, so ": x : y" is legal.
\
\ The J1a has some instructions that are combined versions
\ of traditional Forth words. For example 2dupxor has the
\ same action as "2dup xor". See TYPE for an example.
\

header 1+       : 1+        d# 1 + ;
header negate   : negate    invert 1+ ;
header 1-       : 1-        d# 1 - ;
header 0=       : 0=        d# 0 = ;
header cell+    : cell+     d# 2 + ;

header <>       : <>        = invert ;
header 0<>      : 0<>       d# 0 <> ;
header >        : >         swap < ;
header 0<       : 0<        d# 0 < ;
header 0>       : 0>        d# 0 > ;
header u>       : u>        swap u< ;
header !        : _!        ! ;
header io!      : _io!      io! ;
header ><       : ><        d# 8 flip ;
header c!       : _c!       c! ;

: off   ( a -- ) \ store 0 to a
    d# 0 swap
    _!
;

header key?
: key?
    d# 2
: uart-stat ( mask -- f ) \ is bit in UART status register on?
    h# 2000 io@ and 0<>
;

header key
: key
    begin
        key?
    until
: key>
    h# 1000 io@
;

header emit
: emit
    begin
        d# 1 uart-stat
    until
    h# 1000 _io!
;

header space
: space
    d# 32 emit
;

header cr
: cr
    d# 10
    d# 13
: 2emit
    emit emit
;

header bl
: bl
    d# 32
;

: hex4
    dup ><
    DOUBLE
: hex2
    dup d# 4 rshift
    DOUBLE
    h# f and
    dup d# 10 < if
        [char] 0
    else
        d# 55
    then
    +
    emit
;

header .x2
: .x2 hex2 space ;

header .x
: . hex4 space ;

header execute
: execute
    >r
: noop
;

: var: r> ;                 \ variable defining word

header false    : false d# 0 ;
header true     : true  d# -1 ;
header rot      : rot   >r swap r> swap ;
header -rot     : -rot  swap >r swap var: ;
header tuck     : tuck  swap over ;
header 2drop    : 2drop drop drop ;
header ?dup     : ?dup  dup if dup then ;

header 2dup     : 2dup  over over ;
header +!       : +!    tuck @ + swap _! ;
header 2swap    : 2swap rot >r rot var: ;
header 2over    : 2over >r >r 2dup r> r> 2swap ;

header min      : min   2dup<
: minmax                if drop else nip then ;
header max      : max   2dup< invert minmax ;

header count
: count
    d# 1 over+ swap c@
;

header bounds
: bounds ( a n -- a+n a )
    over+ swap
;

header type
: type
    bounds
    begin
        2dupxor
    while
        count emit
    repeat
    2drop
;

create scratch 0 ,
header base  :noname var: create base     $a ,
header state :noname var: create state    0 ,
header >in   :noname var: create >in      0 ,
header tth   :noname var: create tethered 0 , \ tethered mode flag
header forth :noname var: create forth    0 ,
create dp       0 ,         \ Data pointer, grows up
create lastword 0 ,
create thisxt   0 ,
create sourceC  0 , create sourceA 0 ,
create sourceid 0 ,
create rO       0 ,
create leaves   0 ,
create fineforoptimisation 0 ,
create tib      #128 allot

: nextword
    @ h# 7ffe and
;

header words : words
    forth @
    begin
        dup
    while
        dup cell+
        count type
        space
        nextword
    repeat
    drop
;

\ Not used: swapforth.fs has DUMP instead
\
\ header dump
\ : dump ( addr u -- )
\     cr over hex4
\     begin  ( addr u )
\         ?dup
\     while
\         over c@ space hex2
\         1- swap 1+   ( u' addr' )
\         dup h# f and 0= if  ( next line? )
\             cr dup hex4
\         then
\         swap
\     repeat
\     drop cr
\ ;

header abs      : abs       dup
                : ?neg      0<
                            asm-0branch noop
                            negate ;
header here     : here      dp @ ;

header /string
: /string
    dup >r - swap r> + swap         \ XXX
;

: 1/string
    d# 1
    /string
;

header aligned
: aligned
    1+ 2/ 2*
;

header d+
: d+                                ( al ah bl bh )
    swap >r + swap                  ( h al )
    r@ + swap                       ( l h )
    over r> u< -
;

header dnegate
: dnegate
    invert
    swap                        ( ~hi lo )
    negate                      ( ~hi -lo )
    tuck                        ( -lo ~hi -lo )
    0= -
;

header dabs
: dabs ( d -- ud )
    dup
: ?dneg ( d n -- d2 ) \ negate d if n is negative
    0<
    asm-0branch noop
    dnegate
;

header s>d
: s>d dup 0< ;

header m+
: m+
    s>d d+
;

header d0=
: d0=
    or 0=
;

\ : snap
\     cr depth hex2 space
\     begin
\         depth
\     while
\         .
\     repeat
\     cr
\     [char] # emit
\     begin again
\ ;

header d2*
: d2*
    2* over d# 0 < d# 1 and + swap 2* swap
;

header um*
: um*  ( u1 u2 -- ud )
    2dup *h >r * r> ;

header m*
: m*
    2dupxor >r
    abs swap abs um*
    r> ?dneg
;

\ see Hacker's Delight (2nd ed) 9-4 "Unsigned Long Division"

: divstep  \ ( y x z )
    DOUBLE DOUBLE
    >r
    s>d >r
    d2*
    dup r> or r@ u< invert if
        r@ -
        swap 1+ swap
    then
    r>
;

header um/mod
: um/mod \ ( ud u1 -- u2 u3 ) ( 6.1.2370 )
    divstep divstep divstep divstep
    drop swap
;

: 3rd   >r over r> swap ;

: lower ( c1 -- c2 ) \ c2 is the lower-case of c1
    dup [char] A - d# 26 u<
    h# 20 and +
;

: i<> ( c1 c2 -- f ) \ case-insensitive difference
    2dupxor h# 1f and if
        drop ;
    then
    lower swap lower xor
;

: sameword ( c-addr u wp -- c-addr u wp flag )
    2dup cell+ c@ = if              \ lengths match?
        3rd 3rd 3rd                 \ 3dup
        d# 3 + >r                   \ R: word in dictionary
        bounds
        begin
            2dupxor
        while
            dup c@ r@ c@ i<> if
                2drop rdrop false ;
            then
            1+
            r> 1+ >r
        repeat
        2drop rdrop true
    else
        false
    then
;

: >xt ( dict -- xt )    \ find the xt for a dictionary entry
    cell+
    count +
    aligned
;

header align
: align
    here
    aligned
    dp _!
;


header sfind
: sfind
    forth @
    begin
        dup
    while
        sameword
        if
            nip nip
            dup >xt
            swap        ( xt wp )
                        \ wp lsb 0 means non-immediate, return -1
                        \        1 means immediate,     return  1
            @ d# 1 and 2* 1-
            ;
        then
        nextword
    repeat
;

: digit? ( c -- u f )
   lower
   dup h# 39 > h# 100 and +
   dup h# 160 > h# 127 and - h# 30 -
   dup base @ u<
;

\ : ud* ( ud1 u -- ud2 ) \ ud2 is the product of ud1 and u
\     tuck * >r
\     um* r> +
\ ;

header >number
: >number ( ud1 c-addr1 u1 -- ud2 c-addr2 u2 )
    begin
        dup
    while
        over c@ digit?
        0= if drop ; then
        >r 2swap base @
        tuck * >r um* r> + \ inlined UD* above
        r> m+ 2swap
        1/string
    repeat
;

header fill
: fill ( c-addr u char -- ) ( 6.1.1540 )
    >r  bounds
    begin
        2dupxor
    while
        r@ over c! 1+
    repeat
    rdrop 2drop
;

header cmove
: cmove ( addr1 addr2 u -- )
    bounds rot >r
    begin
        2dupxor
    while
        r@ c@ over c!
        r> 1+ >r
        1+
    repeat
    rdrop 2drop
;

header cmove>
: cmove> \ ( addr1 addr2 u -- )
    begin
        dup
    while
        1- >r
        over r@ + c@
        over r@ + c!
        r>
    repeat
    drop 2drop
;

header 2@
: 2@ \ ( a -- lo hi )
    dup cell+ @ swap @
;

header 2!
: 2! \ ( lo hi a -- )
    tuck _!
    cell+ _!
;

header source
: source
    sourceC 2@
;

: source! ( addr u -- ) \ set the source
    sourceC 2!
;

header source-id
: source-id
    sourceid @
;

header-imm \
:noname
    sourceC @
: >in!
    >in _!
;

\ From Forth200x - public domain

: isspace? ( c -- f )
    h# 21 u< ;

: isnotspace? ( c -- f )
    isspace? 0= ;

: xt-skip   ( addr1 n1 xt -- addr2 n2 ) \ gforth
    \ skip all characters satisfying xt ( c -- f )
    >r
    BEGIN
        over c@ r@ execute
        overand
    WHILE
        1/string
    REPEAT
    rdrop ;

header parse-name
: parse-name ( "name" -- c-addr u )
    source >in @ /string
    ['] isspace? xt-skip over >r
    ['] isnotspace?
: _parse
    xt-skip ( end-word restlen r: start-word )
    2dup 0<> - sourceA @ - >in!
    drop r>
    tuck -
;

: isnotdelim
    scratch @ <>
;

header parse
: parse ( "ccc<char" -- c-addr u )
    scratch _!
    source >in @ /string
    over >r
    ['] isnotdelim
    _parse
;

header allot
: tallot
    dp +!
;

header ,
: w,
    here _!
    d# 2 tallot
;

header c,
: c,
    here c!
    d# 1 tallot
;

header compile,
: compile,
    2/ h# 4000
: orw,
    or w,
;


header s,
: s,
    dup c,
    bounds
    begin
        2dupxor
    while
        count c,
    repeat
    2drop
    align
;

: (sliteral)
    r>
    count
    2dup+ aligned
    >r
;

header-imm sliteral
:noname
    ['] (sliteral) compile,
    s,
;

: mkheader
    align
    here lastword _!
    forth @ w,
    parse-name
    s,
    dp @ thisxt _!
;

header immediate
:noname
    lastword @
    dup @ d# 1 or swap _!
;

header ]
: t]
    fineforoptimisation off  \  : --> No opcodes written yet - never recognize header bytes as opcodes !
    d# 3                      \ ] --> Something strange might just went on. Careful !
: state!
    state _!
;

header-imm [
: t[
    d# 0 state!
;

header :
:noname
    mkheader t]
;

header :noname
:noname
    align dp @
    dup thisxt _!
    lastword off
    t]
;

: (loopdone)  ( 0 -- )
    drop
    r> r> rO _! >r
;

: prev
    dp @ d# 2 -
;

\ Do not handle ALU instructions for size reasons, as only negative literals and R-Stack cause ALUs to be compiled

header-imm exit
: texit
    fineforoptimisation @
    if
      prev @ h# 4000 xor
      dup h# e000 and
      if
        drop
      else
        prev _!
        exit
      then
    then

    inline: exit
;

header-imm ;
:noname
    texit
    t[
: attach
    lastword @ ?dup if
        forth _!
    then
;

\ Represent forward branches in one word
\ using the high-3 bits for the branch type,
\ and low 13 bits for the address.
\ THEN does the work of extracting the pieces.

header-imm ahead
: tahead
    here h# 0000 w,     \ forward unconditional branch
;

header-imm if
: tif
    here h# 2000 w,     \ forward conditional branch
;

header-imm begin  ( -- insn )
: tbegin
    dp @ 2/
;

header-imm then     ( addr -- )
: tthen
    tbegin
    swap +!
;

header-imm again
: tagain
    w,                  \ backward unconditional
;

header-imm until
: tuntil
    h# 2000 orw,        \ backward conditional 
;

header does>
:noname
    r> 2/
    lastword @
    >xt cell+  \ ready to patch the RETURN
    _!
;

header-imm recurse
:noname
    thisxt @ compile,
;

\
\ How DO...LOOP is implemented
\
\ Uses top of R-stack (R) and a variable rO:
\    R is the counter; it starts negative and counts up. When it reaches 0, loop exits
\    rO is the offset. It is set up at loop start so that I can be computed from (rC+rO)
\
\ So DO receives ( limit start ) on the stack. It needs to compute:
\      R = start - limit
\      rO = limit
\
\ E.g. for "13 3 DO"
\      rC = -10
\      rO = 13
\
\ So the loop runs:
\      R      -10 -9 -8 -7 -6 -5 -4 -3 -2 -1
\      I        3  4  5  6  7  8  9 10 11 12
\
\

: (do)  ( limit start -- start-limit )
    r> rO @ >r >r
    over rO _!
    swap -
;

: do-common     \ common prefix for DO and ?DO
    leaves @ leaves off
    ['] (do) compile,
;

header-imm do
:noname
    do-common
: dotail
    tbegin
    inline: >r
;

header-imm leave
: leave
    inline: r>
: leave,
    dp @
    leaves @ w,
    leaves _!
;

: (?do)  ( start-limit -- start-limit start=limit )
    d# 0 over=
;

header-imm ?do
:noname
    do-common
    ['] (?do) compile,
    tif leave, tthen
    dotail
;

\ Finish compiling DO..LOOP
\ resolve each LEAVE by walking the chain starting at 'leaves'
\ compile a call to (loopdone)

: (loopnext)
    d# 1 + d# 0 over=
;

header-imm loop
:noname
    inline: r>
    ['] (loopnext) compile,
    tuntil
: resolveleaves
    leaves @
    begin
        dup
    while
        dup @ swap        ( next leaveptr )
        tbegin
        swap _!
    repeat
    drop
    leaves _!
    ['] (loopdone) compile,
;

: (+loopnext) ( inc R -- R finished )
    over 0< if
        dup>r +
        r> over ( R old new )
        u<
    else
        dup>r +
        r> over ( R old new )
        u>
    then
;

header-imm +loop
:noname
    inline: r>
    ['] (+loopnext) compile,
    tuntil
    resolveleaves
;

header i
: i
    r>
    r@ rO @ +
    swap execute
;

header j
: j
    r> r>
    r> r> 2dup+ -rot
    >r >r
    -rot
    >r execute
;

header-imm unloop
:noname
    inline: r>
    ['] (loopdone) compile,
;

header decimal
: decimal
    d# 10
: setbase
    base _!
;

header 2*       :noname     2*          ;
header 2/       :noname     2/          ;
header +        :noname     +           ;
header @        :noname     @           ;
header *        :noname     *           ;
header c@       :noname     c@          ;
header lshift   :noname     lshift      ;
header rshift   :noname     rshift      ;
header flip     :noname     flip        ;
header -        :noname     -           ;
header xor      :noname     xor         ;
header and      :noname     and         ;
header or       :noname     or          ;
header invert   :noname     invert      ;
header =        :noname     =           ;
header <        :noname     <           ;
header u<       :noname     u<          ;
header swap     :noname     swap        ;
header dup      :noname     dup         ;
header drop     :noname     drop        ;
header over     :noname     over        ;
header nip      :noname     nip         ;
header io@      :noname     io@         ;
header depth    :noname     depth       ;
header-imm >r   :noname     inline: >r  ;
header-imm r>   :noname     inline: r>  ;
header-imm r@   :noname     inline: r@  ;
header cells    :noname     2*          ;
header char+    :noname     1+          ;
header chars    :noname     noop        ;

: jumptable ( u -- ) \ add u to the return address
    r> + execute ;

header abort
: abort
    [char] ? emit
    d# 2 execute
;

header '
:noname
    parse-name
    sfind
    0=
: ?abort
    asm-0branch noop
    abort
;

: consume1 ( caddr u ch -- caddr' u' f )
    >r over c@ r> =
    over 0<> and
    dup>r negate /string r>
;

create signflag 0 ,

: ((doubleAlso))
    h# 0. 2swap
    [char] - consume1 signflag _!
    >number
    [char] . consume1 >r            \ 0 is single, -1 double
    nip ?abort                      \ any chars remain: abort
    signflag @ ?dneg               \ is negative
    r> ?dup and                     \ if single, remove high cell
;

: base((doubleAlso))
    base @ >r setbase
    ((doubleAlso))
    r> setbase
;

: is' ( f caddr -- f' ) \ f remains true if caddr is '
    c@ [char] ' = and
;

: is'c' ( caddr u -- f )
    d# 3 =
    over is'
    swap d# 2 + is'
;

\   (doubleAlso) ( c-addr u -- x 0 | x x 1 )
\               If the string is legal, give a single or double cell number
\               and size of the number.

: (doubleAlso)
    [char] $ consume1 if
        d# 16 base((doubleAlso)) ;
    then
    [char] # consume1 if
        d# 10 base((doubleAlso)) ;
    then
    [char] % consume1 if
        d# 2 base((doubleAlso)) ;
    then
    2dup is'c' if
        drop 1+ c@ false ;
    then
    ((doubleAlso))
;

: doubleAlso
    (doubleAlso) drop
;

header-imm literal
: tliteral
    s>d if
        invert tliteral
        inline: invert
    else
        h# 8000 orw,
    then
;

header-imm postpone
:noname
    parse-name sfind
    dup 0= ?abort
    0< if
        tliteral
        ['] compile,
    then
    compile,
;

header char
:noname
    parse-name drop c@
;

: doubleAlso,
    (doubleAlso)
    if
        swap tliteral
    then
    tliteral
;


: opticompile,  \ Classic compilation gives no pathological cases.
  compile,       \ Cannot handle this in compile, as some of the pathological cases use compile, themselves.
  true fineforoptimisation _!
;

\ Literals are fine for optimisation, too, but currently no optimisation cases handle literals.

: optiexecute   \ All pathological conditions are caused by immediate definitions.
  execute
  fineforoptimisation off
;

: dispatch
    jumptable
    jmp execute                 \      -1      0       non-immediate
    jmp doubleAlso              \      0       0       number
    jmp execute                 \      1       0       immediate

    jmp opticompile,            \      -1      2       non-immediate
    jmp doubleAlso,             \      0       2       number
    jmp optiexecute             \      1       2       immediate

: interpret
    begin
        parse-name
        dup
    while
        sfind
        state @ +
        1+ 2* dispatch
    repeat
    2drop
;

\ Unicode-friendly ACCEPT contibuted by Matthias Koch

: delchar ( addr len -- addr len )
    dup if d# 8 emit space d# 8 emit then

    begin
        dup 0= if exit then
        1- 2dup+ c@
        h# C0 and h# 80 <>
    until
;

header accept
: accept
    tethered @ if d# 30 emit then

    >r d# 0  ( addr len R: maxlen )

    begin
        key    ( addr len key R: maxlen )

        d# 9 over= if drop d# 32 then
        d# 127 over= if drop d# 8 then

        dup d# 31 u>
        if
            over r@ u<
            if
                tethered @ 0= if dup emit then
                >r 2dup+ r@ swap c! 1+ r>
            then
        then

        d# 8 over= if >r delchar r> then

        d# 10 over= swap d# 13 = or
    until

    rdrop nip
    space
;

header refill
: refill
    source-id 0= dup
    if
        tib dup d# 128 accept
        source!
: 0>in
        >in off
    then
;

: sourceid!
    sourceid ! ;

header evaluate
:noname
    source >r >r >in @ >r
    source-id >r true sourceid!
    source! 0>in
    interpret
    r> sourceid!
    r> >in! r> r> source!
;

header quit
: quit
    d# 0 sourceid!
    begin
        refill drop
        interpret
        space
        [char] k
        [char] o 2emit
        cr
    again

header .s
: .s
    [char] < emit depth hex2 [char] > emit space
: (.s)
    depth if
        >r (.s) r>
        dup .
    then
;

header init :noname var:
create init meta t' quit 2* target ,

: main
    cr
    decimal
    tethered off
    t[
    key> drop
    init @ execute
;

\ Word "chain" lives at the top of RAM,
\ Reading from SPI flash into main memory, one word at a time.
\ It is self-contained (i.e. it has no calls) so it can run
\ while the bottom of memory is being replaced.
\ At the end of loading, it wraps to address 0
meta
tdp @ $4000 $30 - org
target
header chain
: chain ( a u )
    begin
        h# 0 h# 112 io!
        begin h# 113 io@ until
        h# 112 io@ d# 8 flip
        over !
        d# 2 +
        2dup=
    until
meta
org
target

meta
    link @ t' forth tw!
    there  t' dp tw!
target
