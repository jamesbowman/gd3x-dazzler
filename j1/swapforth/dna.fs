
: dna@      ( -- u )    $204 io@ ;
: dna!      ( u -- )    $204 io! ;
: dnaclk    ( u -- )    dup dna! 1+ dna! ;
: dnaread   ( )         4 dnaclk ;
: dnashift  ( )         2 dnaclk ;
: dnabyte   ( -- u )    \ read byte from DNA
    0
    8 0 do 2* dna@ + dnashift loop ;
: b2 2drop dnabyte s>d # # ;
: DNA ( addr u )    \ The 56-bit Xilinx DNA, as a string
    dnaread dnashift
    base @ hex
    0. <# b2 6 0 do ':' hold b2 loop #> rot base ! ;

