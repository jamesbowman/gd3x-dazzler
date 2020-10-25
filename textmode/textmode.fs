
s" ans" r/o bin open-file abort" No such file" constant ans
s" out" w/o bin create-file drop constant out

create c 1 allot
: getc
    ans 1 r@ read-file throw
    0= if
        bye
    then
;

create spot 2 allot
: >spid ( d. )
    swap
    spot w! spot 2 out write-file throw
    spot w! spot 2 out write-file throw
;
