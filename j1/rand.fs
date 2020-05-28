new

: rand1
    100 0 do loop
    $2000 io@ 4 rshift 1 and
;

: rand
    begin
        rand1 rand1 2dup =
    while
        2drop
    repeat
    drop
;

: rand
    rand1 rand1 xor
;

: x
    0 begin
        0
        16 0 do
            2* rand +
        loop
        cr .x dup .x
        1- dup 0=
    until drop
;
