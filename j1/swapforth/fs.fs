: sd.ff     $ff >spi ;
: sd.s      sd.ff sel  sd.ff ;
: sd.u      sd.ff idle sd.ff ;

: cmd ( c ) sd.s $40 or >spi ;
: addr      >< >spiw >< >spiw ;
: crc       $95 >spi ;

: ccmd ( c )
    cmd 0. addr crc ;

: response ( - u )
    begin
        spi>
        dup $80 and
    while
        drop
    repeat
    ;

: R1 ( - u )
    response sd.u ;

: sdR3_7 ( - a. )
    response drop
    spiw> >< spiw> >< swap sd.u
    ;

: appcmd ( cc lba. )
    55 ccmd
    R1 drop
    2>r cmd 2r> addr crc ;

variable ccs

:  cmd17 ( a. )  \ sector offset
    ccs @ 0= if
        9 0 do d2* loop
    then
    17 cmd addr crc
    R1 drop
    sel
    begin spi> $fe = until
    ;

: bit30 ( d. - u )
    nip $4000 and 0<> ;

: /sd
    ESPI /spi/
    sd.u 10 0 do sd.ff loop

    begin
        20 ms
        0 ccmd R1
        dup cr .x
        1 =
    until

    8 cmd $1aa. addr $87 >spi
    sdR3_7 cr ." 8 says:" .x .x
    dup cr ." sdhc: " .
    1 ms
    begin
        41 0 1 14 lshift appcmd
        R1
        cr ." cmd41: " dup . .s
        1 and 0=
        10 ms
    until

    cr 58 ccmd sdR3_7 bit30
    cr ." ccs: " dup .
    ccs !
    ;

create scratch 48 allot
2variable sector
2variable clus
variable cnt
: scr ( u )     scratch + postpone literal ;

: 2@l           2@ swap ;
: rs ( d. )     sector 2! 0 cnt ! ;
defer sector+ ( s. -- s.' ) \ next sector
: sd>s \ aligned sector read
    sd.u sector 2@ 
    \ cr ." [fetch] " 2dup d.
    2dup sector+ sector 2!
    cmd17 ;
: sd> ( -- u )
    cnt @ 511 and 0= if
        sd>s
    then
    1 cnt +! spi> ;
: skip ( n )    0 ?do sd> drop loop ;
: get ( n )     scratch swap bounds ?do sd> i c! loop ;
: fin           512 cnt @ 511 and - skip sd.u ;

2variable fat_begin_lba             \ LBA_Begin + RsvdSecCnt
2variable cluster_begin_lba         \ LBA_Begin + RsvdSecCnt + (NumFATs * FATSz32);
variable sectors_per_cluster        \ SecPerClus
2variable root_dir_first_cluster    \ RootClus

: c>s ( c. -- s. )
    -2. d+
    sectors_per_cluster @ 1 m*/
    cluster_begin_lba 2@ d+ ;

:noname ( s. -- s.' ) \ next sector
    1. d+
    over sectors_per_cluster c@ 1- and if exit then
    \ cluster wrap
    2drop
    clus 2@ 128 um/mod
    0 fat_begin_lba 2@ d+
    rs 4 * skip 4 get fin
    [ 0 scr ] 2@l 2dup clus 2!
    c>s
    ;
is sector+

: partition ( lba_begin. )
    2dup rs
    48 get
    fin

    [ $0e scr ] @ 0 d+ 2dup fat_begin_lba 2!
    [ $24 scr ] 2@l d2* d+  cluster_begin_lba 2!
    [ $0d scr ] c@ sectors_per_cluster !
    [ $2c scr ] 2@l root_dir_first_cluster 2!
;

: /fat32
    0 mux0 /sd

    0. rs
    446 skip
    4 0 do
        16 get
        [ 4 scr ] c@ $B $D within if
            fin [ 8 scr ] 2@l partition
            unloop exit
        then
    loop
;

: cluster ( c. ) \ start reading cluster
    2dup clus 2! c>s rs ;

: cseg ( a u u - a' )
    do i scratch + c@ over c! 1+ 2 +loop ;

: newname pad 128 erase ;

: pad0 ( - a u )    \ The NUL-terminated string at PAD
    pad dup
    begin
        dup c@
    while
        1+
    repeat
    over - ;

: root ( xt )
    root_dir_first_cluster 2@ cluster
    newname
    begin
        32 get
        [ $00 scr ] c@
    while
        [ $00 scr ] c@ $e5 <> if
            [ $0b scr ] c@ $0f = if
                [ 0 scr ] c@ $3f and 1- 13 * pad +
                11 1 cseg
                26 14 cseg
                32 28 cseg drop
            then
            [ $0b scr ] c@ $18 and 0= if
                dup >r execute r>
                newname
            then
        then
    repeat
    fin
    drop ;

: f.size    [ $1c scr ] 2@l ;
: f.clus    [ $1a scr ] @ [ $14 scr ] @ ;
: (ls)      cr f.clus 10 d.r f.size 10 d.r space pad0 type ;
: ls        ['] (ls) root cr ;

2variable size

: (open) ( a u -- a u | c. 0 0 )
    2dup pad0 compare 0= if
        f.size size 2!
        2drop
        f.clus
        0.
    then ;
                
: open ( a u - ior )
    ['] (open) root nip     ( u | cl. 0 )
    ?dup 0= if
        cluster 0
    then
    ;

0 [IF]
: cat ( a u )
    open 0= if
        size 2@ drop 0 do
            sd> emit
        loop
    then
    fin
    ;

: hd ( a u )
    open 0= if
        size 2@ drop 0 do
            i 15 and 0= if
                cr i .x space
            then
            sd> .x2
        loop
    then
    fin
    ;

: bench ( a u )
    open 0= if
        size 2@ 512 um/mod
        0 ?do
            \ cr 512 . i .
            sd>s
            512 0 do
                spi> drop
            loop
        loop
        0 ?do
            \ cr i .
            sd> .x2
        loop
        fin
    then ;
[THEN]


: has512
    CSPI
    begin cmdspace 511 > until stream
    stream
    ESPI
    ;

: fplay ( a u )
cr ." fplay " .s
    open
cr ." Open: " .s
    0= if
        size 2@ 512 um/mod
        0 ?do
            cr 512 . i .
            sd>s
            has512
            256 0 do
                spiw> $102 io!
            loop
        loop
        has512
        0 ?do
            \ cr i .
            sd> $101 io!
        loop
        fin
    then
    CSPI finish ESPI
    ;
