manufacturer hex
: m >spi ;
: r 0 do dup >spi loop drop ;
20 wcmd 0 m 0 m 0 m notbusy \ 0x0
02 wcmd 0 m 0 m 0 m \ 0x0 
ff 10 r aa m 99 m 55 m 66 m 30 m a1 m 0 m 7 m 20 m 0 m 31 m a1 m 3 m 80 m 31 m 41 m 3d m 4 m 31 m 61 m 9 m ee m 31 m c2 m 4 m
0 m 10 m 93 m 30 m e1 m 0 m cf m 30 m c1 m 0 m 81 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20
m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 33 m 81 m 3c m c8 m 31 m 81 m 8 m 81 m 34 m 21 m
0 2 r 32 m 1 m 0 m 1f m 31 m e1 m ff 2 r 33 m 21 m 0 m 5 m 33 m 41 m 0 m 4 m 33 m 1 2 r 0 m 32 m 61 m 0 2 r 32 m 81 m 0 2 r 32
m a1 m 0 2 r 32 m c1 m 0 2 r 32 m e1 m 0 2 r 33 m a1 m 1b m e2 m 33 m c2 m 0 4 r 20 m 0 m 20 m 0 m 30 m 22 m 0 4 r 30 m a1 m 0
m 1 m 50 m 60 m 0 2 r 1 m 86 m 0 43 r 1 m 0 14 r notbusy
02 wcmd 0 m 1 m 0 m \ 0x100 
0 6d r 82 m 0 3 r 2 m 0 7d r 4 m 0 3 r 4 m 0 c r notbusy
02 wcmd 0 m 2 m 0 m \ 0x200 
0 36 r a4 m 0 70 r 10 m 0 8 r 88 m 0 40 r 1 m 0 e r notbusy
02 wcmd 0 m 3 m 0 m \ 0x300 
0 b5 r 31 m 2c m 34 m 30 m a1 m 0 m 2 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 33 m 64 m 0 8
r 30 m 22 m 0 m 1 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m 0 m e m 33 m 64 m 0 2
r notbusy
02 wcmd 0 m 4 m 0 m \ 0x400 
0 6 r 30 m 22 m 0 m 1 m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m 0 m 11 m 33 m 64
m 0 8 r 30 m 22 m 0 m 1 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m 0 m 19 m 33 m
64 m 0 8 r 30 m 22 m 0 m 1 m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 0 m 2 m 0 m 17 m 33
m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m e m 33
m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m 11 m
33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m 12 m 33 m 64 m 0 2 r notbusy
02 wcmd 0 m 5 m 0 m \ 0x500 
0 6 r 30 m 22 m 0 m 4 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m 15 m 33 m 64
m 0 8 r 30 m 22 m 0 m 4 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 0 m 4 m 0 m 18 m 33 m
64 m 0 8 r 30 m 22 m 0 m 7 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m e m 33 m
64 m 0 8 r 30 m 22 m 0 m 7 m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m 11 m 33
m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m 14 m
33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m 15 m 33 m 64 m 0 2 r notbusy
02 wcmd 0 m 6 m 0 m \ 0x600 
0 6 r 30 m 22 m 0 m 7 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 0 m 7 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 0 m 8 m 0 m 17 m 33 m 64
m 0 8 r 30 m 22 m 0 m 9 m 0 m 1e m 33 m 64 m 0 8 r 30 m 22 m 0 m e m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 0 m e m 0 m 16 m 33 m
64 m 0 8 r 30 m 22 m 0 m 10 m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m 0 m 11 m 0 m 7 m 33 m 64 m 0 8 r 30 m 22 m 0 m 11 m 0 m 15 m
33 m 64 m 0 8 r 30 m 22 m 0 m 11 m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 0 m 11 m 0 m 19 m 33 m 64 m 0 8 r 30 m 22 m 0 m 11 m 0 m
1a m 33 m 64 m 0 8 r 30 m 22 m 0 m 11 m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 0 m 11 m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m 0 m 1 m
0 m 2 m 30 m a1 m 0 m 1 m 50 m 60 m 0 2 r 2 m cb m 0 a r notbusy
02 wcmd 0 m 7 m 0 m \ 0x700 
0 17 r 8 m 0 17 r 80 m 0 1e r 10 m 0 42 r 8 m 0 7 r 1 m 0 7 r 84 m 0 f r 4 m 0 1e r 80 m 0 2f r notbusy
02 wcmd 0 m 8 m 0 m \ 0x800 
0 2 r 88 m 0 7 r 2 m 0 c r 40 m 0 9 r 4 m 0 m 4 m 0 3 r 9 m 0 b r 8 m 0 81 r 1 m 0 4a r notbusy
02 wcmd 0 m 9 m 0 m \ 0x900 
0 e r 8 m 0 3 r 10 m 0 c r 4 m 0 3d r 3 m 0 25 r 82 m 0 14 r 5 m a0 m 0 2 r 10 m 0 3 r 3 m 1 m 0 2 r 3 m 0 5 r 10 m 0 55 r
notbusy
02 wcmd 0 m a m 0 m \ 0xa00 
0 a r 10 m 8 m 0 2 r 2 m 0 12 r 40 m 0 45 r 4 m 0 24 r 80 m 0 73 r notbusy
02 wcmd 0 m b m 0 m \ 0xb00 
0 e r 1 m 0 d r c0 m 0 73 r 20 m 0 4 r a0 m 0 2 r 5 m 82 m 41 m 0 m 10 m 0 m 5 m a0 m 5 m 0 m 10 m 0 2 r a0 m 21 m 0 m 8 m 0 m
10 m 0 7 r 10 m 0 9 r 10 m 0 m 5 m 0 13 r 10 m 0 b r 10 m 0 21 r notbusy
02 wcmd 0 m c m 0 m \ 0xc00 
0 a r ff 82 r 0 m 30 m a8 m c9 m 30 m 22 m 0 m 1 m 0 m 12 m 50 m 60 m 0 3 r 82 m 0 41 r 2 m 0 22 r notbusy
02 wcmd 0 m d m 0 m \ 0xd00 
0 1e r ff 82 r 0 m 1a m 14 m 5d m 30 m 22 m 0 m 1 m 0 m 14 m 50 m 60 m 0 3 r 82 m 0 e r e0 m 7 m 0 16 r e0 m 7 m 0 16 r e0 m 7
m 0 10 r notbusy
02 wcmd 0 m e m 0 m \ 0xe00 
0 32 r ff 82 r 0 m 7 m 60 m 96 m 30 m 22 m 0 m 1 m 0 m 16 m 50 m 60 m 0 2 r 1 m 4 m 0 8 r 2 m 10 m 0 2 r 80 m 1 m 0 12 r 2 m
10 m 0 2 r 80 m 1 m 0 12 r 2 m 10 m 0 2 r notbusy
02 wcmd 0 m f m 0 m \ 0xf00 
80 m 1 m 0 96 r 2 m 0 29 r 1 m 4c m a0 m 0 m 31 m 0 b r 40 m 48 m 12 m 2 m 0 14 r 40 m 48 m 12 m 2 m 0 12 r notbusy
20 wcmd 0 m 10 m 0 m notbusy \ 0x1000
02 wcmd 0 m 10 m 0 m \ 0x1000 
0 2 r 40 m 48 m 12 m 2 m 0 44 r ff 82 r 0 m 4 m 1a m 3 m 30 m 22 m 0 m 1 m 0 m 1c m 50 m 60 m 0 2 r 6 m 9a m 0 9 r 80 m 0 4 r
1 m 0 12 r 80 m 0 2 r notbusy
02 wcmd 0 m 11 m 0 m \ 0x1100 
0 2 r 1 m 0 12 r 80 m 0 4 r 1 m 0 4d r 9 2 r 0 16 r 9 2 r 0 16 r 9 2 r 0 19 r 1 m 0 36 r 20 m 0 15 r notbusy
02 wcmd 0 m 12 m 0 m \ 0x1200 
0 a r 20 m 0 m c0 m 0 96 r 3 m 0 40 r 20 m 0 m 40 m 0 m 1 m 0 m 11 m 0 m 21 m 0 m 4 m 0 m 10 m 0 m 10 m 0 m 1 m 4 m 41 m 0 2 r
2 m 0 6 r notbusy
02 wcmd 0 m 13 m 0 m \ 0x1300 
0 2 r 1 m 2 m 4 m 20 m 1 m 0 2 r 20 m 0 2 r 4 m 80 m 4 m 84 m 4 m 80 m 5 m 80 m 0 1c r 4 m 0 6 r 20 m 0 5 r 20 m 0 14 r 4 m 0
13 r 80 m 0 m 80 m 0 m 20 m 0 m a0 m 0 m 84 m 0 m 80 m 0 m 20 m 0 3 r 4 m 1 m 84 m 0 2 r 1 m 0 8 r 40 m 1 m 80 m 1 m 4 m 0 2 r
1 m 0 2 r 80 m 4 m 80 m 5 m 80 m 4 m c0 m 4 m 0 1c r 80 m 0 6 r 1 m 0 5 r 1 m 0 14 r 80 m 0 14 r 20 m 0 m 20 m 0 3 r 20 m 1 m
0 5 r 1 m 21 m 1 m 2 m 0 m 4 m 0 m 5 m 0 m 20 m notbusy
02 wcmd 0 m 14 m 0 m \ 0x1400 
0 7 r 2 m 0 3 r 4 m 0 5 r 4 m 0 m 2 m 0 m 9 m 0 m 3 m 0 7 r 40 m 0 m 11 m 0 m 2 m 0 3 r 20 m 0 13 r 11 m 0 2f r 1 m 0 m 1 m 0
3 r 1 m 40 m 0 5 r 20 m 0 m 20 m 0 e r 1 m 0 3 r 1 m 0 5 r 1 m 0 m 1 m 0 2 r 9 m 0 10 r 1 m 0 44 r c1 m 0 2 r 21 m 85 m 80 m
84 m 0 2 r 80 m 0 m a0 m 0 m 20 m 10 m 8 m 83 m 0 m notbusy
02 wcmd 0 m 15 m 0 m \ 0x1500 
85 m 0 m 84 m 0 m 85 m 0 m 1 m 40 m 41 m 0 m a0 m 10 m 41 m 80 m 84 m 80 m 0 m 20 m a0 m 20 m 1 m 80 m 0 m 80 m 0 5 r 80 m 0 4
r 84 m 80 m 0 m 80 m 0 m 80 m 84 m 0 m 10 m 0 5 r 1 m 80 m 1 m 0 m 1 m 0 2 r 80 m 8 m 80 m 0 m 80 m 0 3 r 80 m 0 m 80 m 0 m 80
m 0 3 r 80 m 82 m 80 m 0 m 80 m 0 6 r 1 m 3 m 1 m 0 2 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 12 r 10 m 0 3 r 10 m 8 m 0 3 r 4 m 0
m 5 m 0 m 1 m 80 m 1 m 4 m 88 m 4 m 82 m 0 2 r 40 m 82 m 40 m 1 m 88 m 84 m 8 m 85 m 40 m 4 m 0 m 20 m 5 m 1 m 21 m 89 m 20 m
2 m 5 m 2 m 3 m 2 m 0 3 r 20 m 10 m 0 3 r 5 m 2 m 0 m 20 m 0 m 20 m 0 5 r 1 m 5 m 0 m 4 m 20 m 4 m 0 m 4 m 0 2 r 20 m 8 m 20 m
0 m 20 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 6 r 4 m 0 m 4 m 0 2 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 11 r
3 m 2 m 8 m 0 m 20 m 88 m 8 m 20 m 0 m 20 m 8 2 r 4 m 83 m 8 m notbusy
02 wcmd 0 m 16 m 0 m \ 0x1600 
84 m 11 m a0 m 9 m 40 2 r 0 m 9 m 0 m 2 m 84 m 4 m 84 m 0 m 90 m 0 3 r c0 m 3 m 88 m 40 m 90 m 20 m 0 m 2 m 40 m 0 m 82 m 0 m
40 m 82 m 0 m 40 m 4 m 0 m 4 m 2 m 4 m 0 m 40 m 0 m 4 m 9 m 0 m 20 m 4 m 0 3 r 84 m 20 m 0 4 r c0 m 20 m 0 4 r 8 m 0 2 r 20 m
0 4 r 20 m 11 m 90 m 0 9 r 4 m 0 4 r 4 m 0 3 r 9 m 0 m 20 m 0 17 r 1 m 0 m 1 m 0 m 1 m 0 2 r 80 m 0 2 r 1 m 40 m 0 5 r 80 m 0
12 r 1 m 0 m 1 m 0 5 r 2 m 0 2 r 80 m 0 m 80 m 1 m 80 m 0 3 r 80 m 0 2 r 1 m 80 m 0 4 r 1 m 0 5 r 1 m 0 7 r 1 m 0 30 r 8 m a1
m 1 m 85 m 83 m 85 m 0 m 80 m 0 m 8 m 82 m 8 m notbusy
02 wcmd 0 m 17 m 0 m \ 0x1700 
0 m 8 m 84 m 88 m 10 m 0 4 r 9 m 4 m 9 m 90 m 0 2 r 10 2 r 2 m 9 m 2 m 0 m 2 m 83 m 0 m c0 m 4 m a0 m 4 m 0 m a0 m 0 m 20 m 1
m 0 2 r 20 m 4 m 0 m 83 m 9 m 0 m 80 m 84 m 20 m 4 m 0 3 r 4 m 0 m a0 m 0 3 r 1 m 0 4 r 20 m 0 4 r 10 m 0 3 r 84 m 0 a r 80 m
1 m 0 2 r 80 m 1 m 0 2 r 80 m 1 m 0 3 r 85 m 0 1a r 20 m 4 m 8 m 10 m 20 m 0 m 20 m 0 m 8 m 3 m 8 m 0 2 r 11 m 4 m 80 m 0 m 3
m a0 m 0 2 r 80 m 0 2 r a0 m 0 m 1 m 11 m 1 m 40 m 1 m 3 m 84 m 20 m 84 m 0 m 1 m 0 m 85 m 0 m 5 m 21 m 1 m 4 m 2 m 3 m 85 m
83 m 0 m 4 m 2 m 0 m 20 m 3 m 1 m 80 m 0 3 r 80 m 0 m 10 m 0 3 r 4 m 82 m 0 3 r 1 m 0 13 r 20 m 4 m 0 2 r 20 m 4 m 0 2 r 20 m
4 m 0 3 r 4 m 0 3 r 3 m 0 m 5 m 0 m 41 m 0 11 r 41 m 3 m 88 2 r 84 m 90 m 20 m 21 m notbusy
02 wcmd 0 m 18 m 0 m \ 0x1800 
11 m 2 m a0 m 11 m 88 m 20 m 10 3 r a1 m a0 m 88 m 0 m 9 m 40 2 r 2 m 90 m 0 m 11 m a0 m 85 m 0 m 2 m 8 m 5 m a1 m 10 m 8 m 20
m 8 2 r 3 m 11 m 90 2 r 0 m 8 m 82 m 8 m 10 m 88 m 1 m 40 m 0 m 90 m 20 m 10 m 8 2 r 0 m 88 m 0 m 40 m 8 m 4 m 0 2 r 2 2 r 10
m 90 m 0 m 10 m 2 2 r 20 m 88 m 0 m 20 m 0 m 20 m 2 2 r 11 m 90 2 r 20 m 0 m 20 m 82 2 r 40 m 90 m 40 m 20 m 0 m 82 m 90 m 10
2 r 90 m 0 m 88 m 0 m 10 m 90 m 20 m 8 2 r 40 2 r 0 m 88 m 82 m 4 m 0 10 r 90 m c1 m 91 m 11 m 80 m 3 m 0 m 9 m 91 m 85 m 91 m
83 m 5 m 20 m 80 m a0 m 80 m 8 m 85 m 8 m 0 m 3 m 0 m 11 m 80 m 40 m 3 2 r 80 m 88 m 0 m 10 m 3 m 90 2 r 20 m 40 m 20 m 0 m 20
2 r 11 m 0 m 20 m 0 m 41 m 80 m 0 3 r 10 m 0 4 r 80 m 3 m 0 4 r 80 m 0 m 80 m 0 3 r 80 m 0 4 r 80 2 r 0 6 r 80 2 r 90 m 0 5 r
80 3 r 0 4 r 80 m 0 2 r a0 m 0 4 r 80 m 0 8 r 80 2 r 0 10 r 2 m 0 m 88 m 21 m notbusy
02 wcmd 0 m 19 m 0 m \ 0x1900 
9 m 5 m 89 m 83 m 8 m 84 m 91 m 21 m a0 m 83 m 20 m a0 m 0 2 r 40 2 r 5 m 0 m c1 m 88 m 41 m 80 m 82 m 0 m 5 m 8 m 88 2 r a0 m
41 m 21 m 8 m 20 m 3 m 20 m a0 m 11 m 82 m 21 m 10 m 85 m 2 m 20 2 r 10 m 0 m 3 m 40 m 0 m 80 2 r 0 3 r 80 m 41 m 80 m 11 m 80
m 0 6 r 2 m 80 3 r 0 4 r 41 m 80 m 0 6 r 5 m 0 m 80 2 r 0 4 r 10 m 80 m 8 m 0 4 r 80 m 10 m 0 m 80 m 0 5 r 10 m 0 b r 10 m 0 8
r 10 m 2 m 21 m 0 m 2 2 r 5 m 88 m 3 m 5 m 11 m 0 m 8 m 11 m 20 m 90 2 r c0 m 20 m 1 m 9 m 88 m 5 m a0 m 0 m c0 m 82 m 0 m 1 2
r c1 m a1 m 10 m 21 m 20 m 0 m 8 m 9 m 20 m a0 m 3 m 91 m 10 m 1 m 82 m 88 m 8 m 0 m 3 m 0 m 40 m 0 m 8 m 2 m 10 m 0 m 8 m 0 m
4 m 0 m 2 m 90 m 4 m 0 3 r 20 m 0 m 2 m 0 m 2 m 82 m 4 m 0 m 20 m 0 m 88 m 1 m 84 m 90 m a0 m 20 m 90 m 0 m 90 m 0 m 8 m 40 m
4 m 0 m 90 m 0 m 40 m 1 m 2 m 9 m 88 m 0 m 90 m 0 m 20 m 1 m 88 m 10 m 8 m 0 m 8 m 0 m 40 m 1 m 88 2 r 8 m 0 8 r 1 m 0 8 r
notbusy
02 wcmd 0 m 1a m 0 m \ 0x1a00 
90 2 r 0 m 88 m 10 m 88 m c0 m 91 m 10 m 88 m 40 m 10 m a0 m 20 m 2 m 20 m 4 m 90 m 0 m 90 m 0 m 2 m 4 2 r 8 m 2 m 1 m 88 m 2
m 90 m 20 m 1 m 20 m 11 m 40 m 8 m a0 m 82 m 9 m 90 m 2 m 10 2 r 8 m a0 m 8 m 11 m 10 3 r 0 m 40 m 10 m a0 m 20 m 10 m 88 m 2
m 0 m 4 m 0 m 8 m 20 m 4 m 0 2 r 2 m 20 m 0 m 40 m 10 m 4 3 r c0 m 88 m 0 m 82 m 0 m 88 m c0 m 40 m 8 m 90 m 0 m a0 m 0 m 20 3
r 2 m 90 m 0 m 40 m 0 m 10 3 r 88 m 90 m 0 m 88 m 10 2 r 88 m 20 m 88 m 90 m 0 m 8 m 0 m 40 m 88 m 4 m 0 11 r 9 3 r 89 m 9 m
80 m 41 m 0 m 10 m 83 m a1 m 91 m 20 m 89 m 10 m 0 m 10 m 9 m 10 m 8 m 90 m 80 m 90 m 80 m 5 m 8 m 2 m 3 m 11 m 0 m 40 m 0 m
a0 m 88 m 20 m c1 m 20 m 8 m 20 m 80 m 41 m 80 m 85 m c1 m 10 m 8 m 5 m 0 m 40 m 0 m 20 m 80 m 8 m 0 m 80 m 0 m 80 m 0 m 80 m
0 m 80 m 0 m 80 m 0 5 r 80 m 0 m 80 m 90 m 80 2 r 0 2 r 80 m 0 2 r 91 m 0 9 r 80 m 0 5 r 80 2 r 0 4 r 80 m 0 m 10 m 0 6 r 80 m
0 m 80 m 0 c r notbusy
02 wcmd 0 m 1b m 0 m \ 0x1b00 
0 4 r c1 2 r 10 m 40 m 2 m 0 m 8 m 9 m 10 m 91 m 20 m 40 m 91 m 80 m 10 2 r 0 m 84 m 11 m 20 m 8 m 80 m 89 m 0 m 2 m 80 m 8 m
10 2 r 0 m 3 m 10 m 20 m 8 m 20 m 40 m 5 m 0 m 3 m 20 m 0 m 8 m 0 m 20 m 5 m 80 m 0 m 3 m 0 2 r 80 m a0 m 0 4 r 80 m 11 m 0 m
20 m 0 m 80 2 r 0 3 r 80 m 10 m 80 m a0 m 0 m 80 m 0 4 r 80 m c0 m 80 2 r 0 3 r 3 m 0 m 21 m 0 6 r 80 m 10 m 0 7 r c1 m 0 5 r
8 m 80 m a0 m 0 m 80 m 0 12 r 5 m 41 m 88 2 r 20 2 r 88 m 0 m 11 m 5 m 20 2 r 11 m 10 m 9 m 1 m 20 m c1 m 8 m c0 m 91 m 40 m 4
m 0 2 r 40 m 1 m 8 m 0 m a0 m 1 m 0 m 20 m 21 m 20 2 r 10 m 40 2 r 0 m 10 m 20 m 10 m 88 m 8 m c0 m 20 m 0 m 8 m 0 m 40 m 2 m
20 2 r 88 m 0 m 4 m 0 m 88 2 r 20 m 40 m 4 m 0 3 r 4 m 1 m 20 m 82 m 40 m 2 m 20 m 0 m 88 m 0 m 2 m c0 m 2 2 r 20 m 0 m 90 m 0
m 20 5 r 88 m 40 m 0 m 84 m 8 m 10 2 r 20 m 0 m 10 m 0 m 88 m 82 m 20 m 88 m 8 m 0 m 40 m 1 m 20 3 r 2 m 8 m 0 9 r notbusy
02 wcmd 0 m 1c m 0 m \ 0x1c00 
0 8 r 81 m 0 2 r 90 m b m 0 m 82 2 r 0 3 r d0 m b m 0 3 r 60 m 0 2 r 90 m b m 0 m 60 m 0 7 r 88 m 0 4 r d0 m b m 0 m 88 m 0 4
r 90 m b m 0 2 r 6 m 0 4 r b m 0 7 r b m 0 9 r b m 0 7 r b m 0 m 41 m 6 m 0 4 r b m 0 7 r b m 0 7 r b m 0 7 r b m 0 13 r fd m
ff m 4 m 0 m 66 4 r ff m bf m ff 2 r 66 m 36 m 66 2 r f0 2 r f4 m f0 m ff m 0 m ff m 0 5 r e2 m 40 m e2 m 40 m 3e m 3c 3 r ff
m 40 m bf m 0 m 7f m 10 m ff m 0 m 66 2 r 72 m 66 m ff m bf m 0 m 20 m ff m 10 m ef m 0 m ff 2 r 0 m 20 m 3c 4 r 0 2 r ff 2 r
0 2 r f7 m 10 m ff m 0 m 66 4 r ff m fb m 0 m 20 m 3c 2 r 7c m 3c m 66 4 r ff m 3f m ff m 7f m e6 m 66 m e7 m 66 m ff 2 r c m
8 m ff m 0 m ff m 38 m 7f 2 r ff m 7f m f0 2 r b4 2 r 0 4 r notbusy
02 wcmd 0 m 1d m 0 m \ 0x1d00 
0 c r ff 2 r 0 2 r 76 m 66 m 46 m 66 m 0 m 20 m 0 2 r 66 4 r f0 2 r d0 m f0 m ef m 20 m ff m 0 5 r e2 m 40 m e2 m 40 m 38 m 3c
3 r ff m 0 m ff m 0 m ff m 0 m ff m 0 m 66 4 r ff 2 r 0 2 r ff m 0 m ff m 0 m ff m df m 0 2 r 7c m 1c m 3c 2 r 0 2 r ef m ff m
20 m 0 m ff m 0 m ff m 0 m 36 m 66 3 r ff 2 r 0 2 r 3c 2 r 1c m 3c m 72 m 66 3 r c0 m 0 m 80 m 0 m 26 m 66 m 24 m 66 m f3 m f7
m 0 2 r ff m 0 m c7 m 0 m 10 2 r 0 m 10 m f0 3 r b4 m 0 10 r ff 72 r notbusy
02 wcmd 0 m 1e m 0 m \ 0x1e00 
ff 10 r 0 m 34 m b7 m 41 m 30 m 22 m 0 m 2 m 0 m 18 m 50 m 60 m 0 2 r c m b2 m 0 m 2 m ff m bf m 0 2 r ff 2 r 66 m 46 m 66 m
76 m 0 m ff m 8 m fe m 0 m 2 m ff 5 r ef m b8 m f0 m 1d m 99 m 69 2 r f0 2 r 0 m 8 m f7 m ff 2 r fd m ff 2 r 0 m 8 m ff 2 r 3c
3 r 3d m f m d m f m 4f m 4 m fd m 0 m ff m f 2 r 2f m f m 0 m ff m 8 m ff m 0 4 r ff 2 r 0 m ff m 20 m ef m f 4 r 0 m 8 m f7
m ff m 0 m ff m 2 m ff m 0 m 20 m df m ff m e3 m ff 3 r 0 m 83 m 7c m ff m 66 2 r e6 m e7 m 76 2 r 66 m 76 m 66 3 r 27 m 1c m
0 m ff 2 r 0 12 r ff 2 r 0 m 4 m ff m fd m 66 4 r 0 m ff m 0 m ff m 0 2 r ff m fd m 0 3 r 20 m d1 m f0 m 8b m 99 m 69 2 r f 2
r 0 2 r ff 2 r 0 m 4 m 0 4 r ff m f7 m 3c 3 r 34 m f 4 r 0 m ff m 0 m ff m f 2 r b m f m 0 m ff m 0 m f7 m 0 3 r 4 m ff m df m
0 m ff m 0 m ff m f 2 r b m 2f m 0 2 r ff 2 r 0 m ff m 0 m fd m 0 2 r ff 2 r 0 m 1c m 0 2 r notbusy
02 wcmd 0 m 1f m 0 m \ 0x1f00 
0 2 r ff 2 r 66 2 r 26 m 24 m 46 2 r 66 m 46 m 66 2 r 27 2 r 0 2 r e3 m ff m 0 11 r 61 m 0 m a m c0 m 1 m 0 3 r 61 m 0 m f m 0
m d m 0 3 r 61 m 0 m a m c0 m d m 0 3 r 61 m 0 m 6 m 0 m d m 0 m 5 m 0 m 61 m 0 m f m 0 m d m 0 3 r 61 m 0 m e m 0 m d m 0 3 r
61 m 0 m e m 0 m d m 0 5 r 8 m 0 9 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 8 r 10 m 0 b r 55 m a5 m 14 m d4
m 0 2 r 90 m 9f m ff m ef m 0 m 4 m aa 2 r b2 m aa m 96 m a5 m 96 m a5 m fc m ff 3 r 88 m 66 m 22 m 99 m bc m ff 3 r f 4 r 3c
m bc m 3c 2 r a5 4 r c m fc m 30 m 3f m 0 2a r notbusy
20 wcmd 0 m 20 m 0 m notbusy \ 0x2000
02 wcmd 0 m 20 m 0 m \ 0x2000 
0 1e r 80 m 0 9 r aa m 5a m d7 m 17 m f m 0 m 9f 2 r ff 2 r 0 2 r aa 4 r 69 m 5a m 69 m 5a m 30 m fc 2 r ff m 99 m 44 m 66 m
11 m 3c m fc m ff 2 r 1e m f 3 r 3c m 1c m 3c 2 r 5a 4 r c m fc m 30 m 3f m 0 4 r 3 m 0 m 3 m 0 3c r 2 m 0 e r bb 2 r ff 2 r
33 2 r cc 2 r 75 m 45 m 55 2 r 3c 2 r b4 m 3c m 5 m c3 m fa m 3c m 0 m f0 m f 2 r 0 2 r 4 m 20 m f8 m ee m bb m f2 m ff 2 r fe
m ff m aa m b2 m aa 2 r 0 2 r f m 0 2 r 20 2 r fa m 0 4 r fc 4 r 0 1e r notbusy
02 wcmd 0 m 21 m 0 m \ 0x2100 
0 2c r 11 m bb m 0 m ff m 55 m ff m 55 m ff m 55 4 r 3c 4 r f5 m c3 m a m 3c m 0 2 r f0 2 r 1 m 80 m 5 m a0 m 80 m 0 2 r 20 m
1 m 0 3 r aa 4 r 0 7 r a0 m 0 4 r fc 4 r 0 4e r 20 m 0 5 r 1 m 0 m 1 m 0 3 r 90 m 0 m 1 m 0 m 88 m 0 5 r 1 m 4 m 0 3 r 2 m 0 4
r 21 m 0 8 r 2 m 0 m 20 m 0 11 r 2 m 0 4 r 20 m 0 b r notbusy
02 wcmd 0 m 22 m 0 m \ 0x2200 
0 34 r 10 m 0 5 r 4 m 0 m 4 m 0 5 r 4 m 0 7 r 20 m 0 9 r 20 m 0 8 r 1 m 0 m 1 m 0 8 r 41 m 0 8 r 3 m 0 4 r 10 m 0 47 r 4 m 0 3
r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 80 m 20 m 0 m 20 m 0 m 4 4 r 20 m 0 m 20 m 10 m 20 m 0 m 20 m 0 5 r 88 m 0 6 r 80 m 0 3 r 80
m 0 9 r 2 m 0 m 9 m 0 a r notbusy
02 wcmd 0 m 23 m 0 m \ 0x2300 
0 4 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 12 r 20 m 0 m 20 m 0 3 r 20 m 0 m 80 m 0 5 r 8 m 0 12 r 5 m 0 m 80 m 0 3 r 80 m 0 m 80 m 0
m 80 m 0 m 80 m 10 m 80 m 0 m 80 m 0 m 80 m 1 m 80 m 1 m 80 m 0 m 80 m 1 m 80 m 0 m 80 m 0 c r 2 m 0 3 r 2 m 0 13 r 4 m 0 6 r
80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 12 r 5 m 0 m 1 m 0 3 r 1 m 0 m 4 m 0 5 r 1 m 0 b r 4 m 0 m 4 m 0 m 80 m 0 5 r 5 m 1 m 3 m 0
m 10 m 1 m 20 m 1 m 4 m 0 m 11 m 0 m 80 m 0 m 85 m 0 m 84 m 0 m 80 m 0 m 80 m 0 3 r 90 m 0 2 r 4 m 0 m 4 m 0 8 r 10 m 0 m 80 m
0 m 10 m 0 5 r 4 m 0 m 20 m 0 4 r 1 m 0 3 r 1 m 0 m notbusy
02 wcmd 0 m 24 m 0 m \ 0x2400 
0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 2 r 1 m 0 8 r 80 m 0 7 r 20 m 4 m 0 4 r 80 m 0 3 r 80 m 0 m 80 m 0 10 r 4 m 0 3 r 41 m
84 m 41 m 4 m 10 m 0 m 41 m a0 m 3 m 0 m 4 m 84 m 21 m 4 m 20 m 1 m 20 m 0 m 11 m 90 m 9 m 4 m 9 m 4 m 5 2 r 9 m 4 m 10 2 r 41
m a0 m 21 m 11 m 41 m a0 m a1 m 4 m 90 m 0 m 40 m a0 m 40 m 82 m 0 m 4 m 0 m 21 m 8 m 2 m 41 m 83 m 3 m 90 m 0 2 r 5 m 0 2 r 1
m 0 2 r 5 m 0 m 4 m 84 m 9 m 0 m 4 m 0 m 21 m 20 m 21 m 20 m 9 m 20 m 41 m 20 m 3 m 0 m 4 m 0 5 r 40 m 0 2 r 4 m 0 2 r 5 m 0 4
r 20 m 4 m 88 m 11 m 0 2 r 20 m 0 3 r 20 m 0 m 20 m 0 12 r 84 m 0 m 82 m 0 m 20 m 0 2 r 20 m 1 m 20 m 90 m 2 m 0 m 20 2 r 0 m
82 m 0 2 r 41 m 20 m 41 m c0 m a0 m 41 m 20 m 40 m 89 m 20 m 82 m 8 m 10 m c0 m 0 m 10 2 r 2 m 0 m 82 m 0 4 r 89 m 0 m 21 m 0
4 r 8 m 0 4 r 80 m a0 m 0 m 84 m 0 2 r 3 m 0 2 r 4 m 0 2 r 11 m notbusy
02 wcmd 0 m 25 m 0 m \ 0x2500 
4 m 3 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 3 r 2 m 0 5 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 20 m 0 m 20 m 8 m 20 m 0 m 20 m
0 m 9 m 0 m 89 m 0 m 20 m 0 m 80 m 0 16 r 80 m 0 2 r 1 m 40 m 1 m 0 m 1 m 40 m 1 m 80 m 0 5 r 80 m 0 2 r 9 m 40 m 1 m 0 m 20 m
80 m 21 m 80 m 89 m 0 3 r 1 m 80 m 0 6 r 20 m 0 b r 20 m 0 7 r 1 m 80 m 0 3 r 80 m 84 m 0 3 r 9 m 0 m 1 m 0 m 1 m 0 m 1 m 0 9
r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 3 r 20 m 0 m 1 m 0 m 4 m 0 11 r 80 m 21 m 0 m c1 m 11 m c0 m
11 m 88 m 0 m c0 m 0 5 r 4 m 41 m 40 m 5 m 40 m 4 m 0 m 11 m 20 m 0 m 1 m 40 m 20 m a0 m 20 m a0 m 0 2 r 1 m 10 m c0 m 0 m 8 m
85 m 82 m 11 m 0 2 r 89 m 0 m a0 m c1 m 0 5 r 20 m 40 m 3 m 82 m 0 m 10 m 0 2 r 4 m 0 4 r notbusy
02 wcmd 0 m 26 m 0 m \ 0x2600 
84 m 0 3 r 40 m 41 m c0 m 0 2 r 41 m 0 m 41 m 0 3 r 4 m 88 2 r 0 5 r 80 m 1 m 0 3 r 90 m 80 m 0 m 80 m 1 m 2 m 0 m 80 m 1 m 0
m 40 m 80 m 0 19 r 4 m a0 m 20 2 r a0 m 41 m 90 m 41 m 0 2 r 2 m 0 3 r 90 m 4 m 88 m 0 m 8 m 11 m 4 m 40 m 8 m 80 m 0 m 20 m 0
m 80 m 4 m 85 m 4 m 3 m 84 m 20 m 5 m 11 m 0 m 83 m 4 m 11 m 8 m 0 2 r 4 m a0 m 0 m 2 m 8 m c0 m 21 m c0 m 0 2 r 3 m 0 m 4 m 0
m 9 m c0 m 0 m 4 m 0 4 r 21 m 0 9 r 3 m 90 m 0 3 r 4 m 40 m 20 m 0 2 r 3 m 0 m 40 m 20 2 r 0 3 r 21 m 4 m 5 m 4 2 r 88 m 0 m
20 m 4 2 r 11 m 20 m 40 m 4 m 0 m 4 m 0 m 4 m 9 m 88 m 0 4 r 3 m 0 c r 21 m 0 2 r a0 m 21 m 40 m 82 m 4 m 11 m c0 m 0 2 r 11 m
20 m 0 m 90 m 0 m 84 m 0 2 r 21 m 0 m 3 m a0 m 41 m 20 m 41 m 10 m 0 m 1 m 0 m 20 m 4 m 0 m 10 m 0 2 r c0 m 21 m 0 m 82 m 4 m
9 m c0 m 21 m 83 m 2 m 0 m 9 m 84 m 2 m 0 3 r 11 m 82 m 0 2 r 80 m 0 m 80 m notbusy
02 wcmd 0 m 27 m 0 m \ 0x2700 
40 m 0 3 r 4 m 0 m 4 m 0 3 r 90 m 0 4 r 3 m 0 m 41 m 0 4 r 40 m 0 m 4 m 0 8 r 9 m 0 2 r 90 m 0 m 88 m 0 a r 2 m 0 19 r 20 m 80
m 0 m 9 m 0 3 r 88 m 0 7 r 21 m 0 3 r 80 m 0 3 r 40 m 0 m 80 m 0 2 r 1 m 0 5 r 20 m 80 m 0 3 r 4 m 1 m 0 b r 20 m 0 m 20 m 0 4
r 80 m 0 m 80 m 0 f r 40 m 0 m 80 m 0 5 r 21 m 0 28 r 1 m 2 m 0 3 r 40 m 88 m 1 m 88 m 2 2 r 40 m 10 m 1 m 2 m 0 m 8 m 40 2 r
0 m 8 m 91 m 2 m 1 m 10 m 84 m 90 m 8 m 2 m 11 m 88 m 0 m 41 m 40 m 90 m a0 m 3 m 40 m 9 m 1 m 41 m 88 m 3 m 8 2 r 0 m c0 m 41
m 40 m 82 m a0 2 r 0 m c0 m 10 m notbusy
02 wcmd 0 m 28 m 0 m \ 0x2800 
0 m 90 m 0 m 40 m 8 m 82 m 0 2 r 10 m 4 m 0 m 4 m 0 m 40 m 2 m 4 m 88 m 10 m 0 m 82 m 0 m 90 m 2 2 r 91 m 20 m 82 m 4 m 0 m 82
m 90 2 r 0 2 r 4 m 1 m 85 m 1 m 0 m 1 m c0 m a0 m 0 m 88 m 0 m 88 m 8 2 r 40 2 r 0 m 90 m 0 m 2 m c0 m 8 m 0 11 r 41 m 2 m 10
m c0 m 3 m 0 m 10 m 80 m 0 m 2 m 0 2 r 80 m 0 m 80 m 8 m 83 m 8 2 r c0 m c1 m 0 m 8 m 10 m 80 m 40 m 0 m 80 m 0 2 r 80 m 40 m
88 m 10 m 40 m 85 m 9 m 0 m 90 m 40 m a0 m 21 m 3 m 0 m 10 m 80 m 40 m 0 m 80 m 83 m 0 5 r c0 m 80 m 0 3 r 80 m 0 4 r a0 m 80
m 0 3 r 80 3 r 0 6 r 80 2 r 10 m 0 4 r 80 m 0 3 r 10 m 85 m 10 m 84 m 5 m 0 m 3 m 80 m 0 7 r 80 2 r 0 3 r 80 2 r 0 11 r 2 m 0
m 10 m 0 m 83 m 40 m 10 m 3 m 20 m 0 m 83 m 3 m c0 m 10 m 4 m 2 m 3 m 80 m 8 m 0 m 41 m 0 m 4 m 40 m 0 m 9 m 0 m 21 m 91 m 40
m 41 m 11 m 88 m 80 m 9 m 11 m 20 m 80 m 10 m c0 m 2 m 0 m 9 m 21 m 40 m 0 m 21 m 82 m 2 m 0 m 40 m 0 m 83 m 21 m notbusy
02 wcmd 0 m 29 m 0 m \ 0x2900 
40 m 3 m 0 3 r 5 m 80 2 r 0 6 r 80 m 21 m 80 m 0 m 80 2 r 0 2 r 80 m 8 m 80 2 r 0 5 r 21 m 0 4 r 8 m 0 m 10 m 0 m 11 m 0 m 3 2
r 0 3 r 20 m 0 4 r 80 m 0 2 r 5 m 0 m 8 m 0 12 r 4 m a0 m 21 m 0 m 8 m 1 m c0 m 0 m 91 m a0 m 11 m 0 m 3 m 88 m 40 m 2 m 0 m 2
m 0 5 r 1 m 20 m 88 m 90 m 0 m 41 m 88 m 89 m 20 m 4 m c0 m 4 m 0 2 r 84 m 83 m 9 m 40 m a0 m c0 m 0 m a1 m 82 m 3 m 5 m c1 m
40 m 90 m 0 m 4 m 1 m c1 m 41 m 20 m 0 m 90 m 0 m 40 2 r 82 m 0 3 r 10 m 0 m 10 m 0 m 40 m 8 m 4 m 10 m 90 m 0 m 2 m 0 m 2 2 r
82 m 0 m 90 m 0 m 90 m 0 m 88 m 90 2 r 0 2 r a0 m 1 m 0 3 r 1 m 21 m 90 m 0 m 10 m 0 m a0 m c0 m 8 m 0 m 40 m 0 m 90 m 0 m a0
m 8 m 82 m 0 m 20 m 0 10 r 1 m 0 m 1 m 4 m 0 3 r 2 m 90 m 0 m 2 m c0 m 10 2 r 11 m 8 m 0 m 1 m 0 m 2 m 0 m 40 m 0 m 90 m 2 m
a0 m 90 m 0 m 21 m 90 2 r 4 m 3 m 0 m 4 m 0 m 4 m 82 m a1 m 40 m 10 m 1 m 40 m 41 m 8 m 21 2 r 2 m 83 m notbusy
02 wcmd 0 m 2a m 0 m \ 0x2a00 
0 m 40 m 82 m 0 m 1 m a1 m 40 2 r 0 m 90 m 40 m 90 m 2 m 82 m 0 2 r 10 m 20 m 0 m 8 m 0 m 8 m c0 m 4 m 82 2 r 0 m 40 m 82 m 90
m 8 2 r 90 m 88 m 0 m 82 m 0 m 4 m 8 2 r 0 m 1 3 r 0 m 1 m 0 m 1 m 8 m 2 m 0 m 88 m 8 m 88 3 r 4 m 40 m 0 m 90 m 8 m 82 m 88 m
91 m 0 11 r 40 m 4 m 10 m 2 m 10 m 0 m 2 m 80 m 41 m 0 m 84 m 0 m 5 m 88 m 82 m 80 m 11 m 8 m 5 m c1 m 8 m 11 m 4 m 0 m 91 m 0
m 21 m 0 m 21 m 4 m 9 m 80 m 88 m 21 m 91 m 10 m 9 m 20 m 88 m 0 m a0 m 40 m 83 m 5 m 41 m 2 m 40 m 80 m 10 m 0 3 r 40 m 9 m
a0 m 80 m 0 3 r 80 m 0 m 80 m 0 3 r 80 m 0 4 r 80 3 r 0 3 r 80 m 0 d r 10 m 40 m 10 m 3 m 20 m 0 m 10 m 0 m 80 m 0 6 r 80 2 r
0 5 r 11 m 0 10 r 41 m a0 m 3 m 0 m 2 m 80 m 10 m 40 m 10 m 80 m c0 2 r 9 m 80 m 85 m 5 m 8 m 89 m 41 m 40 m 11 m 0 m 10 2 r
11 m 89 m 40 m 5 m 21 m 0 m 9 m 11 m 10 m 8 m 3 m 0 m 10 m 0 m 88 m 41 m 20 m a1 m 40 m 8 m 40 m 0 m notbusy
02 wcmd 0 m 2b m 0 m \ 0x2b00 
5 m 10 m 41 m 80 m 20 m 80 m 40 m 0 m 10 m 5 m 0 m 20 m 0 m a0 m 0 5 r 2 m 80 m 4 m 80 m 40 m 80 3 r 0 m 80 m 0 2 r 40 m 80 3
r 0 4 r 2 m 0 m 80 m 0 2 r 10 m 0 m 11 m 0 m 20 m 0 m 8 m 40 m 80 m 0 2 r 8 m 0 5 r 8 m 80 m a1 m 0 15 r 9 m 0 m 88 m 0 m 40 m
1 2 r 11 m c0 m 3 m 10 m 88 m 84 m 10 m 0 2 r c0 m 0 4 r 1 2 r 90 m c1 m 21 m 20 m 91 m 90 m 20 m 1 m 82 m 10 m 83 m 4 m 1 m
82 m 89 m 1 m 4 m 3 m 89 m 88 m 2 m 8 m 20 m 1 m 0 m 2 m 0 m 82 m 0 m 88 m 1 m 0 m 90 m 0 m 82 m 2 m 8 2 r 82 m 0 3 r 4 m 0 m
10 m c0 m 40 m 2 m 4 m 0 m 2 m 0 m 90 2 r 2 2 r 4 m 0 m 4 m 0 m 82 2 r 90 m 8 2 r 0 m 1 m 88 m 0 4 r 1 2 r 40 m 0 m 88 5 r 0 m
90 m 1 m 2 2 r 8 2 r 90 m 0 14 r d0 m 9 m 0 6 r 90 m b m 0 m 42 m 0 4 r d0 m b m 0 m 84 m 0 4 r 90 m b m 0 m 50 m 0 4 r d0 m 0
2 r 42 m 12 m 0 2 r notbusy
02 wcmd 0 m 2c m 0 m \ 0x2c00 
0 2 r b m 0 f r b m 0 m 50 m 0 7 r b m 0 2 r 41 m 0 4 r b m 0 7 r b m 0 6 r d0 m 0 8 r b m 0 m 42 m 0 4 r c8 m b m 0 2 r 6 m 0
6 r e0 m 0 11 r f0 4 r aa 4 r 0 8 r 3c 3 r 3a m 3c m bc m 3c 2 r ff 4 r cc m 33 m cc m 33 m 3c m 34 m 3c m 3e m f0 3 r f2 m 0
4 r 33 2 r cc 2 r 0 m ff m 8 m ff m 0 m ff m 0 m ff m 0 2 r f0 2 r e0 m f4 m aa 2 r a2 m ae m 3c m bc m 3c 2 r f0 m e8 m f0 2
r 0 m 80 m ff m bf m 34 m 3e m 0 m ff m 0 8 r ea m aa m fa m aa 2 r ac m aa m ac m 3c 2 r 3d m 3f m 0 m c0 m 3f m ff m 0 18 r
f0 m d0 m f0 m f8 m aa 2 r 8a m ba m 0 8 r 3c 5 r 1c m 3c 2 r 0 m 82 m 55 m d7 m cc m 33 m notbusy
02 wcmd 0 m 2d m 0 m \ 0x2d00 
99 m 66 m 3c 4 r f0 3 r 70 m 0 4 r cc 2 r 33 2 r 0 m ff m 0 m f7 m 0 m ff m 20 m ef m 0 2 r f0 4 r aa 4 r 3c m 1c m 3c 2 r f0
4 r 80 2 r bf 2 r 0 m ff m 0 m ff m 0 8 r 2a m aa m a m aa 2 r ac m aa 2 r 3c 2 r 38 m 30 m 0 m 40 m bf m ff m 0 m 10 m 0 2 r
80 m 0 f r ff 2 r 66 m 0 m ff 2 r 0 2 r ff 2 r f7 m ff m 55 2 r 5d m 55 m 0 4 r 2f m 7 m f 2 r 3c 4 r 56 m 2 m 1 m 0 m b8 2 r
e2 2 r ff m 10 m ef m 0 m ff m 0 m ef m 4 m f0 3 r f m 69 2 r 96 2 r 55 2 r 5d m 55 5 r 0 2 r ff m 0 m ff m 0 m 35 m 55 3 r ff
m 8 m f7 m 0 m bf m ff m 10 m 0 m ff m 8 m f7 m 0 m ff m 2f m ff 2 r 0 8 r ff 2 r 0 m e m 7d m 28 m 7f m 20 m 57 m 55 m d7 m
55 m ff m 0 m ff m 0 3 r 40 m 48 m 0 10 r ff 2 r 66 m ff m fe m ff m 4 m 0 3 r 4 m 0 m 55 2 r 51 m 55 m 0 4 r f 4 r 3d m 3c m
38 m 3c m 9a m 10 m notbusy
02 wcmd 0 m 2e m 0 m \ 0x2e00 
20 m 0 m f8 2 r f2 2 r ff m 0 m ff m 0 m ff m 0 m ff m 0 m f 3 r f0 m 99 m 69 m 66 m 96 m 55 2 r 51 m 55 m 5c m 55 3 r 0 2 r
f7 m 4 m ff m 0 m 55 4 r ff m 0 m ff m 0 m ff 2 r 0 2 r ff m 28 m d7 m 0 2 r 7 m 0 a r ff m f1 m 0 2 r ff m 0 m ff m 0 m 54 m
55 m 14 m 55 m ff m 7 m f8 m 0 12 r 61 m 0 m 1 m 0 m 1 m 0 3 r 61 m 0 m e m 0 m 9 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m
e m 0 m d m 0 3 r 61 m 40 m 1 m 0 m 11 m 0 3 r 61 m 0 m e m 0 m d m 0 3 r 61 m 50 m 6 m 0 m d m 0 5 r 8 m 0 9 r 8 m 0 7 r 8 m
0 7 r 8 m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 5 r 61 m 0 m e m 0 m 9 m 0 12 r 55 m 5d m 55 m 51 m 3c 3 r 7c m 99 m 66 2 r
99 m ff 4 r df m ff 3 r 0 m 8 m ff m fd m fc m 2b m 14 m 0 m 14 m 41 m notbusy
02 wcmd 0 m 2f m 0 m \ 0x2f00 
44 2 r ff m f7 m ff 2 r aa 2 r b2 m aa m 50 m 5 m 39 m 6c m 40 m 0 m bf m 0 m fe m be m ef m ee m 3c m ff m 3c m 0 23 r 5c 2 r
3c 2 r 2c m 7c m 2c m 7c m 0 c r ff 2 r 0 4 r 1 2 r 80 m 0 b r 55 4 r 3c 3 r 2c m 66 m 99 2 r 66 m 24 m e7 m 18 m db m 8 m 0 5
r ff 2 r 3 m d4 m eb m ff m 41 m 14 m 44 m 4 m 8 m 0 3 r aa 4 r 63 m c9 m a m a0 m ff m bf m ff m 40 m e m be m e0 m ee m 3c m
aa m 3c m 55 m 0 22 r 3c m 5c m 3c 2 r 2c m 7c m 3c 2 r 0 c r ff 2 r 0 5 r 4 m 0 c r df m ff m 10 m 0 m aa 2 r ba m aa m 0 4 r
99 m 66 2 r 99 m ff 2 r f7 m ff m 0 m 80 m ff 2 r 0 2 r notbusy
20 wcmd 0 m 30 m 0 m notbusy \ 0x3000
02 wcmd 0 m 30 m 0 m \ 0x3000 
0 3 r aa m 0 m 55 m df m 10 m ff m 0 m f0 2 r e0 m f4 m 96 m 66 m f0 m 0 m 1d m de m e2 m 21 m 0 4 r 20 m ba m 28 m be m 0 22
r df m ff m 10 m 0 m bf m ff m bf 2 r 0 11 r 80 m 0 4 r 40 m 0 9 r ff 2 r 0 2 r aa 2 r 8a m aa m 0 4 r 66 m 99 2 r 66 m 0 2 r
4 m 0 3 r ff m 7f m 0 4 r 55 m 0 m aa m 0 m ff m 0 m ff m 0 m f0 4 r 0 m f m 66 m 69 m b8 m 7b m 47 m 84 m 0 5 r a0 m 20 m ba
m 0 22 r 5f m ff m 50 m 0 m 80 m 0 m 80 2 r 0 10 r 2 m 0 10 r 10 m 0 4 r 4 m 0 3 r 4 m 0 5 r 82 m 11 m 0 4 r notbusy
02 wcmd 0 m 31 m 0 m \ 0x3100 
90 m 0 m 20 m 0 5 r 82 m 0 6 r 9 m 0 f r 41 m 0 2 r 20 m 0 a r 9 m 0 5 r 2 m 0 44 r 11 m 0 15 r 11 m 0 b r 10 m 0 b r 10 m 0
59 r notbusy
02 wcmd 0 m 32 m 0 m \ 0x3200 
0 30 r 8 m 0 5 r 8 m 0 c r 11 m 0 94 r 41 m 0 21 r 90 m 0 5 r notbusy
02 wcmd 0 m 33 m 0 m \ 0x3300 
0 2 r 40 m 0 m 20 m 0 m 90 m 0 m 20 m 0 5 r 88 m 0 3 r 88 m 0 m 20 m 0 m 10 m 3 m c0 m 0 m 88 m 0 m 8 m 0 m 10 m 0 m 90 m 0 3
r a0 m 0 m a0 m 0 m 8 m 5 m 88 m 0 5 r 90 m 0 15 r 82 m 0 m c0 m 0 7 r c0 m 0 9 r 82 m 0 m 90 m 0 3 r 90 m 0 m 90 m 0 m a0 m 0
10 r 40 m 0 3 r 88 m 0 4 r 10 m 0 2 r 2 m 0 2 r 9 m 10 m 0 m 4 m 11 m 10 m 9 m 90 m 5 m 0 3 r 11 m 0 m 9 m 0 m 3 m 4 m 21 m 0
3 r 9 m a0 m 21 m 82 m 4 m 0 m 3 m 88 m 0 2 r 4 m 0 m 41 m 0 m 5 m 0 3 r 9 m 0 10 r 10 m 20 m 0 6 r 88 m 0 6 r 11 m 0 3 r 20 m
0 4 r 88 m 0 8 r 3 m 90 m 0 19 r 20 m 4 m 0 5 r notbusy
02 wcmd 0 m 34 m 0 m \ 0x3400 
4 m 0 5 r 20 m 0 a r 10 m 90 m 0 15 r c0 m 0 a r 41 m 0 6 r c0 m 0 13 r 84 m 0 m 8 m 0 e r 41 m 0 18 r 21 m 0 3 r 4 m 0 m 4 m
0 2 r 88 m 10 m 20 2 r 0 m 3 m 10 m 0 4 r 4 m 88 m 40 m 0 2 r c0 m 0 4 r 21 m 0 4 r 2 m 0 2 r 20 m 0 m 21 m 0 8 r c0 m 0 b r
90 m 0 m 90 m 0 13 r 88 m 0 12 r 20 m 0 21 r notbusy
02 wcmd 0 m 35 m 0 m \ 0x3500 
0 b r 4 m 0 6 r 90 m 0 12 r 11 m 4 m 0 a r 11 m 0 4 r 4 m 0 5 r 4 m 0 d r c0 m 0 7 r 84 m 0 f r 90 m 0 m 10 m 0 17 r 5 m 0 3 r
2 m 10 m 0 2 r 20 m 0 2 r 82 m 0 m 2 m 20 m 4 m 0 m c0 m 0 m 88 m 0 m a0 m 10 m 90 m 11 m 0 m 5 m 0 m 5 m 88 m 5 m 20 m 0 m 90
m 21 m 90 m 9 m 2 m 0 2 r 5 m 0 m 8 m 0 2 r 88 m 0 m 84 m 8 m 0 5 r 21 m 84 m 9 m 0 m 5 m 0 3 r 8 m 0 5 r 3 m 0 7 r 40 m 4 m 0
2 r 40 m 0 m 20 m 0 m 9 m 88 m 5 m 88 m 5 m 0 m 9 m 88 m 0 m 88 m 41 m 2 m 11 m 0 2 r 2 m 0 m c0 m 0 m 90 m 11 m 88 m 11 m 40
m 0 m 4 m 10 m 0 9 r 41 m 0 a r 11 m notbusy
02 wcmd 0 m 36 m 0 m \ 0x3600 
0 14 r 4 m 0 3 r 82 m 0 5 r 4 m 0 m 4 m 0 7 r 88 m 0 m 90 m 0 m 4 m 0 8 r 5 m 0 7 r 20 m 0 2a r 10 m 0 17 r 3 m 10 m 40 m 0 m
20 2 r 8 m 0 m 3 m 0 3 r 11 m 0 m 20 m 0 3 r 40 m 0 m 3 m c0 m 0 m c0 m 0 m 20 m 0 m 4 2 r 0 8 r 4 m 8 m 0 3 r 21 m 0 7 r 4 m
0 11 r 5 m 0 15 r 11 m 0 f r 20 m 0 m 20 m 0 m 41 m 4 m 20 m 0 f r notbusy
02 wcmd 0 m 37 m 0 m \ 0x3700 
0 2 r ff 82 r 0 m 3b m d3 m 6a m 30 m 22 m 0 m 5 m 0 2 r 50 m 60 m 0 2 r 12 m ca m 0 c r a0 m 0 3 r 1 m 0 9 r 1 m 0 f r 1 m 2
m 0 15 r 2 m 0 a r 4 m 0 5 r c0 m 0 8 r 8 m 0 10 r notbusy
02 wcmd 0 m 38 m 0 m \ 0x3800 
0 f r 8 m 0 12 r 21 m 0 3 r 4 m 0 3 r 9 m 0 5 r 20 m 0 f r 4 m 0 16 r 3 m 0 a r 80 m 0 2e r 1 m 0 6 r 91 m 0 m 91 m 0 m 1 m 0
m 4 m 0 7 r 1 m 10 m 0 20 r 84 m 0 5 r 90 m 0 a r 1 m 0 3 r 41 m 0 m 41 m 0 2 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 4 r 20 m 0 m 20
m 2 m 0 f r notbusy
02 wcmd 0 m 39 m 0 m \ 0x3900 
8 m 0 6 r 41 m 0 2 r 20 m 0 5 r 10 m 0 2 r 80 m 0 4 r 40 m 8 m 4 m 0 m 4 m 0 m 4 m 0 m 80 m 0 7 r 8 m 0 12 r c0 m 0 28 r 80 m
0 m 80 m 0 m 80 m 0 m 80 m 0 4 r 1 m 0 m 1 m 0 2 r 40 m 0 m 9 m 0 1b r 80 m 0 2 r 4 m 0 4 r 80 m 1 m 0 4 r 20 m 0 m 88 m 0 9 r
89 m 0 m 89 m 90 m 20 m 9 m 88 m 20 m 0 m 80 m 0 m 4 m 0 m 80 m 40 m 4 m 84 m 0 m 40 m 0 m 82 m 0 4 r 80 m 4 m 0 m 84 m 80 m
85 m 0 2 r 20 m 82 m 20 m 0 m 20 m a0 m 20 m 0 2 r 1 m 0 2 r 2 m 20 m 0 7 r 90 m 0 2 r 9 m 0 2 r 88 m 0 5 r 88 m 0 5 r 84 m 0
m 88 m 0 2 r 4 m 0 m 21 m 0 3 r 83 m notbusy
02 wcmd 0 m 3a m 0 m \ 0x3a00 
4 m 3 m 40 m 83 m 84 m 0 m 4 m 0 m 4 m 0 m 40 m 20 m 84 m 4 m 0 7 r 11 m 0 b r 88 m 80 m a0 m 0 9 r a0 m 20 m 0 m 20 2 r 85 m
4 m 9 m 1 m 0 m 2 m 0 m 1 m 0 m 4 m 0 m 1 m 4 m 0 8 r 20 m 80 m 0 m 5 m 20 m 4 m 0 2 r 1 m 41 m 1 m 0 m 1 m 0 m 1 m 0 2 r 4 m
0 13 r 11 m 0 m 11 m 88 m 0 7 r 20 m 0 6 r 4 m 0 2 r 20 m 80 m 0 2 r 20 m 0 2 r 80 m 82 m 80 m 0 2 r 1 m 0 m 1 m 0 10 r 90 m 4
m 20 m 0 m 8 m 0 m 8 m 0 3 r 84 m 40 m 20 m 0 m 82 m 0 2 r 80 m 0 m 80 m 5 m 0 2 r 5 m 0 m 4 m 0 m 4 m 0 4 r 84 m 80 m 84 m 0
m 85 m 0 m 20 m 0 2 r 41 m 0 2 r 8 m 4 m 0 m 4 2 r 10 m 0 2 r 82 m 0 d r 1 m 0 m 4 m 0 m 82 m 0 3 r 84 m 0 m 84 m 0 m 4 m 0 m
4 m 0 m a0 m 80 m 0 m 80 m 0 m 80 m 0 3 r 20 m a0 m 20 m 82 m 20 m notbusy
02 wcmd 0 m 3b m 0 m \ 0x3b00 
82 m 20 m 82 m 0 8 r 80 m 0 m 80 m 0 15 r 1 m 80 m 0 m 80 m 0 m 80 m 82 m 20 m 0 2 r 1 m 11 m 0 m 20 m 2 m 41 m 4 m 41 m 4 m
84 m 0 m 21 m 0 3 r 4 m 90 m 0 5 r 4 m 0 2 r 20 m 4 m 80 m 0 9 r 80 m 0 4 r c0 m 0 9 r 4 m 0 m 1 m 4 m 0 m c1 m 0 5 r 5 m 0 m
41 m 0 m 80 m 0 m a1 m 0 2 r 20 m 0 m 20 m 0 m 20 m 0 3 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 41 m 84 m 0 2 r 5 m 0 2 r 84 m 0 m 4 m 0
m 4 m 0 m 88 m 0 m 88 m 0 8 r 5 m 0 9 r 84 m 0 m 20 m 0 2 r 2 m 0 2 r 20 m 4 m 20 m 10 m 88 m 4 m 10 m 2 m a0 m 3 m 82 m 2 m
83 m 11 m 88 m 4 m 1 m 0 2 r 11 m 1 m 0 4 r 4 m 0 m 21 m 0 m 4 m a0 m 0 3 r 4 m 2 m 0 4 r 4 m 0 2 r 41 m 4 m 41 m 4 m 20 m a0
m 20 m 82 m 20 m 4 m 0 4 r 20 m 0 2 r 4 m 0 3 r 90 m 0 2 r 2 m 88 m 0 m 84 m 0 2 r 21 m 0 3 r 20 m 0 m 11 m 0 m 80 m notbusy
02 wcmd 0 m 3c m 0 m \ 0x3c00 
4 m 80 m 0 m a0 m 0 m 80 m 0 2 r 4 m 0 m 4 m 0 m 88 m 80 m 0 m 20 m 8 m 20 m 0 m 80 m 0 m a0 m 0 m 11 m 0 m 11 m 0 3 r 11 m 0
9 r 8 m 0 2 r 80 m 0 2 r a0 m 0 2 r 80 m 1 m 80 m 0 2 r 1 m 0 m 90 m 0 2 r 3 m 4 m 20 m 0 3 r 20 m 0 m 4 m 20 2 r 4 m 5 m 0 m
5 m 1 m 9 m 0 m 5 m 1 m 0 2 r 4 m 0 m 80 m 0 m 20 m 90 m 0 2 r 80 m 0 3 r 80 m 0 m 80 m 1 m 0 m 1 m 0 m 1 m 85 m 90 m 0 3 r 1
m 0 2 r 80 m 0 4 r 88 m 0 6 r 40 m 0 4 r 20 m 0 m 90 m 0 m 20 m 0 m 20 m 0 m 20 m 5 m 20 m 0 m 88 m 80 m 0 m 85 m 0 2 r 20 m
10 m 1 m 0 m 1 m 0 m 20 m 0 m 21 m 0 10 r c0 m 0 m 84 m 80 m c0 m 0 m 20 m 4 m 82 m 84 m 82 m 21 m 1 m 10 m 20 m 0 m 90 m 80 m
91 m 0 m 83 m 0 m 40 m 84 m 0 m 4 m 0 m 4 m 1 m 0 2 r 10 m 20 m 4 m 0 3 r 89 m 88 m 2 m 0 6 r 4 m 0 m 82 m 9 m 82 m 0 m 4 m 0
5 r a0 m 0 m 4 m 0 2 r 20 m 0 5 r 20 m 0 m 20 m 4 m 20 m 4 m 0 9 r 20 m 21 m 0 m 21 m notbusy
02 wcmd 0 m 3d m 0 m \ 0x3d00 
1 m 0 9 r 4 m 0 3 r 84 m 0 m 84 m 0 2 r 9 m 0 m 4 m 0 m 4 m 0 m 4 m 0 10 r 3 m 0 2 r 4 m 0 2 r 85 m 91 m 0 m 5 m 3 m 4 m 20 m
1 m 80 m 84 m 3 m 20 m 4 m 0 m 20 m 2 m 0 m 21 m 0 m 82 m 0 2 r 8 m 82 m 0 m 3 m 80 m 0 4 r 4 m 0 2 r 11 m 0 5 r 80 m 0 5 r 80
m 0 7 r 80 m 0 2 r 1 m 0 5 r 1 m 0 m 1 m 80 m 1 m 80 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 2 r 3 m 4 m 41 m 0 m 4 m 0 2 r 10 m 21 m
10 m 0 3 r 10 m 80 m 0 4 r 84 m 0 m a0 m 10 m 4 m 3 m 1 m 0 m 1 m 10 m 1 m 0 10 r 4 m 0 m 88 m 1 m 20 m 0 m 4 m 1 m c1 m c0 m
10 m 40 m 88 m 11 m 20 m 82 m c0 m 40 m 1 m 91 m 21 m 20 m 8 m 9 m c0 m 2 m 40 m 8 m 85 m 9 m c0 m 21 m 0 m 1 m 2 m 0 m 88 m 1
m 0 2 r 88 m 8 m 0 m 90 m 0 m 2 m 4 m 20 m 40 3 r 88 m 0 m 82 m 90 m 10 m c0 m 2 m 8 m 4 m 0 m 82 m 10 2 r 0 2 r 2 2 r 90 m 88
m 0 m 82 2 r 10 m 4 m 90 m 0 m 10 m 0 m 8 m c0 m 88 m 91 m 90 m notbusy
02 wcmd 0 m 3e m 0 m \ 0x3e00 
20 m 2 m 0 m 90 m 20 m 82 m 10 m 90 m 0 m 84 m 0 m 88 m 20 2 r 40 2 r 84 m 8 m 0 m 82 m 20 m 2 m 40 m 84 m 1 m 40 m 21 m 91 m
c0 m 21 m 0 10 r 80 m 9 m 11 m 10 m 8 m 20 m 0 m 10 m 82 m 88 m 41 m 5 m 8 2 r 0 m 10 m 80 m a0 m 3 m 10 m 41 m 20 m 0 m 10 m
80 m 89 m 0 m 4 m 11 m c0 m 80 m 4 m 20 m 10 m 20 m 21 m 20 m 10 m 0 m 10 m 0 m 80 m 0 4 r 80 m 0 m 40 m 0 4 r 80 m 0 m 80 5 r
0 m 80 m 0 4 r 80 2 r 0 3 r 80 3 r 8 m 0 2 r 80 m 0 m 80 2 r 0 m 10 m 0 2 r 80 m 0 3 r 80 2 r 0 7 r 80 2 r 0 m 80 m 0 m 80 m 0
2 r 80 m 5 m 20 m a0 m 2 m 10 m 0 m 10 m 0 10 r 82 m 0 m 8 m 0 m 20 m 40 m 3 m 91 m 41 m 89 m 5 m a0 m c0 m a0 m 90 m 10 m 88
m 0 m 10 2 r 3 m 4 m 10 m 8 m 89 m 80 m a0 m c1 m 90 m 80 m 2 m 85 m 11 m 0 m 21 m 0 m 10 m 0 m 10 m 3 m 80 m 0 2 r 20 m 0 m 5
m 0 5 r 21 m 80 3 r 0 m 80 m 0 m 80 m 5 m 80 3 r 0 3 r 80 m 0 2 r 10 m 0 7 r 11 m 80 m 0 m notbusy
02 wcmd 0 m 3f m 0 m \ 0x3f00 
0 4 r 80 m 21 m 0 m 80 2 r 0 4 r 5 m 80 m 0 6 r 8 m 0 m 20 m 0 2 r 2 m 80 m a0 m 41 m 10 m 88 m 10 m 11 m 80 m 0 4 r 20 m 0 a
r 41 m 20 m a0 m 40 m 2 m 1 2 r 20 m c0 m 41 m 20 m 83 m 4 m c0 2 r 4 2 r 8 m 91 m 1 m 20 m 21 m 9 m 20 m 10 m 4 2 r 83 2 r c0
m 41 m 9 m 0 m 20 m 0 2 r 1 m 0 m 1 2 r 40 m 0 m 90 m 0 m 90 m 89 m 82 m 84 m 90 m 0 m 40 m 0 m 40 m 10 m 8 m 0 m 4 m 0 m 4 m
0 m 2 m 10 m 8 m 0 3 r 2 m 0 m 90 m 1 m 90 m 88 2 r 0 m 90 m 0 m 4 m 0 m 40 m 88 2 r 0 m 90 m 0 m 82 m 0 m 8 m 84 m 82 m 20 m
90 m 0 m 90 m 0 m 84 m 90 m 88 m 84 m 2 m 0 m 88 m 1 m 20 2 r 84 m 0 m 84 m 2 m 40 m 0 m a1 m 84 m 21 m a0 m 40 m 0 f r 1 m 4
m 1 m 5 m 8 m 10 m 0 m 11 m 90 m 40 m 0 m 20 m 82 m 4 m c0 2 r 88 m 9 m 40 m 89 m 8 m 20 m 91 m 85 m c0 m 84 m 0 m 5 m 82 m 2
m c1 m 41 m 0 3 r 1 m 0 4 r 88 m 10 m 0 m 90 m 0 m 10 2 r 20 m 90 2 r 0 m 88 m 0 m 40 m 20 m 10 m 4 2 r 0 m 4 m 10 m 4 m 20 2
r 0 m 1 m a0 m 88 m 0 m 88 m 0 m 4 m 88 2 r 4 m 90 m notbusy
20 wcmd 0 m 40 m 0 m notbusy \ 0x4000
02 wcmd 0 m 40 m 0 m \ 0x4000 
0 m 20 m 0 m 2 m c0 m 10 m 40 2 r 0 m 20 m 2 m 20 2 r 90 m 8 m 90 m 0 m 40 m 88 m 84 m a0 2 r 88 2 r 0 m 40 m 84 m 8 m 20 m 2
m a0 m 85 m 0 m 40 2 r 91 m 2 m 21 m 0 10 r 41 m 8 3 r c1 m 41 m 20 m a0 m 5 m 91 m 11 m 5 m 20 m 90 m 80 m 85 m 0 m 40 m 21 m
10 m 8 2 r 10 2 r c1 m 80 m 3 m 83 m 40 m 85 m 91 m 2 m 0 m 20 2 r 8 m 41 m 3 m 0 m 2 m 0 m 80 m 0 4 r 80 m 0 6 r 80 m 0 m 80
3 r 0 m 80 m 0 m 80 m 0 3 r 3 m 0 5 r 80 m 0 5 r 80 m 0 2 r 80 4 r 0 2 r 80 m 0 6 r 80 m 0 7 r 80 m 0 m 80 m 2 m 0 2 r 10 m 11
m a0 m 20 m 10 m 80 m 10 m 0 10 r 8 m 20 m 8 m 83 m 8 m 0 m 3 m 8 m 88 m c0 m 85 m 80 m 88 m 20 m 41 m 11 m 10 m 89 2 r 82 m
10 m 0 m 20 m c0 m 21 m 80 m 10 m 80 m 85 m 80 m 82 m 11 m 20 m 2 m 8 m 0 m 8 m 0 m 20 m 11 m 0 m 4 m 80 m 20 m 0 5 r 40 m 0 m
40 m 80 m 0 3 r 80 m 0 m 80 m c0 m 0 5 r 1 m 0 2 r 80 m 40 m 80 2 r notbusy
02 wcmd 0 m 41 m 0 m \ 0x4100 
0 3 r 11 m 80 m 82 m 0 m 80 m 0 3 r 10 m 80 m c0 m 80 2 r 0 2 r 80 m 4 m 80 m 88 m 0 2 r 80 m 0 3 r 80 m 88 m 0 4 r 11 m 80 m
10 m 4 m 5 m 0 m 5 m 41 m 0 11 r 20 m 1 m 9 m 0 3 r 1 m c1 m 2 m 20 m c0 m 11 m 21 m 82 m 10 m 5 m 40 m 82 m 83 m 9 m 88 2 r
11 m 91 m 2 m 11 m c0 m 9 m c0 m 5 m 1 m 0 m 20 m 1 m 0 m 1 m 0 3 r 90 m 0 m 20 m 88 m 20 3 r 0 m 40 m 0 m 88 2 r 2 m 40 m 2 m
0 m 4 m 0 m 40 2 r 20 2 r 40 m 0 2 r 1 m 10 m 0 m 4 m 88 m 2 m c0 m 88 m 0 m 4 m 0 m 8 m 10 m 88 m 40 m 8 m 0 m 20 m 1 m 20 m
2 3 r 40 m 0 m 40 m 1 m 20 m 4 m 20 2 r 2 m 0 m 84 m 0 m 82 2 r 20 2 r 88 m 0 m 84 m 2 m 91 2 r 20 m 40 2 r 1 m 0 13 r d0 m 43
m 0 m 50 m 0 4 r d0 m 9 m 0 m 48 m 42 m 0 3 r d0 m b m 0 m 84 m 81 m 50 m 0 2 r 90 m 9 m 0 m 48 m 42 m 0 3 r d0 m 0 8 r b m 0
7 r b m 0 7 r b m 0 m 42 m 0 5 r notbusy
02 wcmd 0 m 42 m 0 m \ 0x4200 
0 2 r b m 0 2 r 6 m 0 4 r b m 0 2 r 82 m 0 4 r b m 0 7 r b m 0 7 r b m 0 6 r d0 m b m 0 2 r 6 m 0 e r e0 m 7 m 0 4 r 55 m aa 2
r 55 m 0 8 r bc m 3c m 2c m 3c m f0 m f4 m f0 m d0 m 0 10 r bc m 2c m 3c 2 r ff m bf m ff 2 r 66 m 72 m 66 2 r ff 2 r 4 m 0 m
66 m 36 m 66 6 r 0 2 r f7 m ff m 10 m 0 m 3e m 38 m 3c 6 r ff m fb m 4 m 0 m ff m 0 m ff m 0 m ff m 10 m ef m 0 m bc m 2c m bc
m 2c m e7 m 24 m 67 m 64 m 7f m 7e m 10 m 18 m f8 m e0 m f8 m e0 m 36 m 3c 3 r f0 2 r fd m f0 m 0 14 r aa m 55 2 r aa m 0 8 r
3c 4 r f0 4 r 0 10 r 3c 4 r 0 m 20 m 0 2 r 66 4 r fb m ff m 0 2 r 66 4 r 76 m 46 m 66 2 r notbusy
02 wcmd 0 m 43 m 0 m \ 0x4300 
0 2 r ff 2 r 0 2 r 3c 4 r 7e m 18 m 3e m 38 m ff m f3 m c m 0 m bf m 20 m ff m 0 m ff m 0 m ff m 0 m 3c 2 r bc m 2c m 66 4 r
ff 2 r 0 2 r f0 2 r f8 m e0 m 36 m 3c m 36 m 3c m f0 2 r 40 m f0 m 0 8 r 2 m 10 m 0 2 r 80 m 1 m 0 a r 43 m 10 m 20 m 0 2 r 88
m 11 m 6 m 0 8 r 2 m 10 m 20 m 0 2 r 88 m 10 m 4 m 0 5c r 40 m 48 m 12 m 2 m 0 6 r 55 m a5 m 55 m a5 m 0 8 r ff m df m ff 4 r
fd m ff m 0 11 r 20 m ff m ef m 0 m 8 m ff m fe m 3c 2 r 36 m 3c m 0 m 8 m ff 2 r f m d m f m 4f m notbusy
02 wcmd 0 m 44 m 0 m \ 0x4400 
0 m 8 m f7 m ff m 0 2 r 3c 2 r 3e m 3c m 0 m 8 m ff 2 r 3c 2 r f m 3c m 0 m ff m 0 m ff m 4 m df m 0 m ff m 0 m ff m 2 m fe m
cb m ff 3 r c m cf m d m 4f m 8 m ef m f 2 r c m 0 m fc m ff m 67 m 66 m 67 2 r 9b m ff 3 r 0 14 r 55 m a5 m 55 m a5 m 0 b r
20 m 0 2 r 4 m 0 13 r ff 2 r 0 2 r ff 2 r 3c 4 r 0 2 r ff m f7 m f 4 r 0 2 r ff 2 r 0 2 r 3c 2 r 38 m 3c m 0 2 r ff m f7 m 3c
2 r 2d m 3c m 24 m e7 m 4 m f7 m 0 m ff m 0 m ff m 0 m ff m 0 m ff m 0 m 34 m 0 2 r f 8 r 8 m 0 m fe m ff m 64 m 66 m 64 2 r 0
m 64 m 0 12 r 5 m 61 m a m 9 m 5 m 1 m 0 m a0 m 0 m 61 m 0 m 1 m 0 m 91 m 0 m 5 m 0 m 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 4 m
c0 m 1 m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 7 r 8 m 0 4 r notbusy
02 wcmd 0 m 45 m 0 m \ 0x4500 
0 3 r 8 m 0 9 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 5 r 1 m 80 m 0 5 r 9 2 r 0 4 r ff m
ef m ff 3 r f7 m ff 4 r 0 2 r 1c m 3c m bc m 3c m 3e m 34 m 3c 2 r ff 3 r bf m e1 m 0 m 1e m ff m 5a m a5 2 r 5a m ff m fe m
ff 2 r 0 m 8 m f7 m ff m 0 42 r 75 m 55 m f5 m 55 m ff m fe m ff m fc m 0 3 r 4 m 0 d r 4 m 0 5 r 8 m fe m ff m 4 m 0 m 3c 8 r
0 3 r 10 m e1 m ff m 1e m 0 m 5a m a5 2 r 5a m 0 m 4 m 0 4 r ff 2 r 0 c r notbusy
02 wcmd 0 m 46 m 0 m \ 0x4600 
0 36 r 45 m 55 m 5 m 55 m 0 m 4 m 0 m c m 0 6 r 40 m 0 2 r 80 m 0 4 r 1 m 0 m ff m f7 m 8 m 0 m aa m 3a m aa 2 r 57 m 55 m 54
m 55 m aa m ba m aa 2 r df m ff m 10 m 0 2 r ff m 80 m bf m c0 m 3f m 82 m 7d m 2a m d5 m ea m 15 m ff 2 r fe m ff m 3c m 2c m
3c m 7c m 0 42 r ff m f7 m 0 m 4 m ff m fe m ff m fa m 2 m 0 7 r 2 m 0 6 r 40 m ff 2 r 0 2 r aa 4 r 55 4 r aa m 8a m aa 2 r ff
2 r 0 3 r ff m 0 m ff m fc m 3 m be m 41 m 80 m 7f m bf m 40 m 1 m 0 3 r 3c 4 r 0 8 r notbusy
02 wcmd 0 m 47 m 0 m \ 0x4700 
0 3a r ff m f5 m 0 m 5 m 0 m 2 m 0 m a m 0 14 r 20 m 5 m 1 m 0 5 r 20 m 0 4 r 20 m 0 m 20 m 0 3 r 80 m 0 a r 8 m 0 5 r 8 m 0 3
r 20 m 0 21 r 20 m 0 b r 1 m 0 m 4 m 0 m 1 m 0 2 r 80 m 0 19 r 20 m 0 a r 80 m 0 m 4 m 0 a r 1 m 0 m 1 m 11 m 0 2 r 4 m 0 4 r
41 m 0 f r notbusy
02 wcmd 0 m 48 m 0 m \ 0x4800 
0 15 r 3 m 0 18 r 4 m 0 m 80 m 0 m 4 m 0 2 r 20 m 0 b r c0 m 0 14 r 1 m 0 m 1 m 0 3 r 1 m 40 m 0 13 r 41 m 88 m 0 m 88 m 0 22
r 3 m 0 b r 40 m 0 14 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 7 r 88 m 0 11 r 20 m 0 m 20 m 0 3 r 20 m 0 1e r 84 m 0 2 r notbusy
02 wcmd 0 m 49 m 0 m \ 0x4900 
41 m 0 m 2 m 0 1d r 40 m 0 19 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 1c r 4 m 0 m 8 m 0 2 r 1 m 0 2 r 20 m 0 m 20 m 1 m 11 m 20 m
11 m 20 m 2 m 20 2 r 0 3 r 80 m 0 m 20 m 0 m c1 m 0 4 r 84 m 11 m 0 m 21 m 0 f r 21 m 0 c r 1 m 0 4 r 2 m 1 m 11 m 0 2 r 84 m
0 m 5 m 0 m 4 m 0 2 r 20 m 0 m a0 m 4 m 20 m 0 m 20 m 0 14 r 84 m 0 15 r 3 m a0 m 40 m 0 m 3 m 0 m 4 m 0 2 r 1 m 3 m a1 m 4 m
90 m c1 m 82 m 83 m a0 m 80 m a1 m 21 m 84 m 40 m 20 m 9 m 1 m 9 m 20 m 5 m 0 m 41 m 0 m 41 m 90 m notbusy
02 wcmd 0 m 4a m 0 m \ 0x4a00 
3 m 0 m 21 m 0 m 21 m 0 4 r 84 m 3 m 0 6 r a0 m 40 m 0 b r 4 m 0 m 8 m 0 2 r 2 m 4 m 0 m 8 m 84 m 5 m 0 m 84 m 0 m c1 m 0 2 r
1 m 0 m 21 m 80 m 1 m 40 m 1 m 0 4 r 10 m 0 m 5 m 0 3 r 41 m 0 m 20 m 0 m 21 m 0 5 r 8 m 0 3 r 40 m 0 f r a0 m 91 m 2 m 0 m 8
m 11 m 0 m 41 m 90 m 80 m 88 m 0 m 2 m 0 m 2 m 0 5 r 82 m 0 6 r 3 m 0 2 r 88 m 0 4 r 4 m 82 m 4 m 0 m 4 m 2 m 0 4 r 41 m 2 m 9
m 0 3 r 4 m 0 3 r 41 m 0 5 r 4 m 0 6 r 4 m 0 m 4 m 0 3 r 40 m 0 c r 11 m 0 3 r 9 m 0 4 r 20 m 0 m 4 m 0 m 4 m 0 6 r a0 m 0 m
a0 m 0 m 20 m 0 13 r 20 m 0 7 r 20 m 0 m 88 m 0 14 r notbusy
02 wcmd 0 m 4b m 0 m \ 0x4b00 
0 3 r 1 m 8 m 1 m 0 m 1 m 10 m 0 a r 1 m 0 a r 3 m 0 2 r 1 m 0 2 r 80 m 0 m 80 m 0 19 r 80 m 0 m 80 m 0 m 80 m 0 6 r 5 m 0 m 5
m 0 m 41 m 0 13 r 21 m c0 m 20 m 88 m 0 m a1 m 3 m 84 m 0 m 4 m 0 m 83 m 3 m 0 m 4 m 40 m 80 m 0 m 82 m 0 m 80 m 9 m 80 m 4 m
0 m 4 m 0 m 40 m 11 m c1 m 4 m 20 m 4 m 0 2 r 20 m 21 m 20 m 0 2 r 4 m 20 m 0 m 20 m 0 2 r 4 m 0 m 4 m 0 m 4 m 0 3 r 4 m 0 a r
40 m 0 m 40 m 0 5 r c1 m 41 m 1 m 80 m 0 2 r c0 m 0 m 40 m 0 b r 10 m 0 m 84 m 0 m 4 m 0 3 r 41 m 0 m a0 m 41 m 0 m 4 m 0 m 20
m 0 m 11 m 0 m 20 m 0 2 r 84 m 0 2 r 11 m 0 a r 9 m 88 m 0 m 1 m 40 m 8 m 4 m 0 3 r 80 m a0 m 4 m 0 m 3 m 2 m 40 m 20 m 0 m 20
5 r 83 m 0 m a1 m 0 m notbusy
02 wcmd 0 m 4c m 0 m \ 0x4c00 
41 m 0 m 4 m 1 m 80 m 1 m 41 m 0 m a1 m a0 m c1 m 90 m 5 m 1 m a1 m 88 m 80 m 84 m 0 m 1 m 0 m 1 m 0 m 1 m 21 m a0 m 40 m 1 m
0 a r 40 m 4 m 40 m 10 m 0 m 2 m 20 m a0 m 4 m 2 m 4 m 20 m 0 m 4 m 40 m 4 m 21 m 0 m 3 m 0 m 3 m 0 m 5 m 0 m 9 m 0 m 40 m 0 3
r 10 m 4 m 80 m c0 m 0 m 4 2 r 0 4 r 1 m 41 m 0 m 21 m 0 m 21 m 0 m 3 m 0 m 3 m 0 b r 10 m 0 m c0 m 20 m a0 m 21 m c0 m 20 m 0
m 5 m 0 m 40 m 2 m 0 m 88 m 0 m 4 m 20 m 0 2 r 2 m 9 m 0 8 r 4 m 2 m 84 m 4 m 2 m 0 m c1 m 2 m 82 m 21 m a0 m 11 m 20 m 0 2 r
4 m 40 m 4 m 20 m 0 m 1 m 0 4 r a1 m 0 m 80 m 0 12 r 4 m 0 m 40 m 0 2 r 5 m 1 m 0 2 r 20 m 0 3 r 9 m 0 6 r 10 m 0 m 10 m 0 m
20 m 0 m 5 m 0 m c0 m c1 m 4 2 r 0 5 r 4 m 0 m 84 m 0 7 r 20 m 0 9 r 41 m 3 m 0 2 r 1 m 0 9 r 1 m 0 8 r notbusy
02 wcmd 0 m 4d m 0 m \ 0x4d00 
0 2 r 11 m 0 m 80 m 0 2 r 1 m 0 2 r 20 m 0 5 r 80 m 0 2 r 1 m 0 m 41 m 80 m 0 m 20 m 0 4 r 4 m 0 m 4 m 3 m 0 11 r 80 m 0 5 r 4
m 0 2 r 1 m 0 e r 80 m 0 m a0 m 0 2 r 4 m 80 m 0 2 r 88 m 0 m 90 m 0 m 1 m 0 m 21 m 0 10 r c0 m 2 m 0 m 2 m 1 m 90 m 4 m 2 3 r
0 m 4 m 0 m 88 m 10 2 r 90 m 91 m 4 m 2 m 82 m 10 m 88 m a1 m 8 2 r 82 m 90 m 40 m 8 m 82 m c0 m 0 3 r 1 m 2 m 0 6 r 1 m 2 m 0
5 r 1 m 0 m 84 m 0 d r 8 2 r 0 m 2 m 0 m 90 m 10 2 r 2 m 90 m 20 m 4 m 0 m c0 m 2 m 82 m c0 m a0 m 0 m 40 m 0 m 20 m 8 2 r 89
m 88 m 0 m 8 m 0 m c0 m 20 m 2 m 40 2 r 4 m 2 2 r 8 m c0 m 83 m a0 m a1 m 0 m 8 m 84 m 3 m 8 m 9 m 0 2 r 20 m 0 2 r 41 m 0 m 1
m 0 8 r 83 m 0 2 r 80 m 20 m 0 m 80 4 r 0 4 r 80 2 r 8 m 10 m 83 2 r notbusy
02 wcmd 0 m 4e m 0 m \ 0x4e00 
40 m 10 m 0 m 8 2 r 0 4 r 80 2 r 0 2 r 8 m 11 m 10 m c0 m 3 m 0 m 5 m 0 m 20 m 5 m 3 m 85 m 11 m 0 m 5 m 0 m 5 m 8 m 20 m c0 m
8 m 0 m 20 m 0 a r 8 m 0 7 r 83 m 0 5 r 80 3 r 0 7 r 8 m 0 6 r 80 2 r c1 m 3 m 83 m a0 m 8 m 80 m 88 m 0 m 10 m 3 2 r a0 m 82
m 80 m 10 m 8 m 11 m 0 m 20 m 41 m 83 m 0 m 3 m 0 9 r 40 m 80 m 3 m 0 m a0 m 80 m 0 m 80 m 0 2 r 4 m 80 2 r 0 2 r 10 m 0 m 21
m 3 m 90 m 0 m 10 m 3 m 0 3 r 40 m 0 m 80 m 0 2 r 8 m 0 m 3 m 0 m 3 m 0 m 2 m 5 m 20 m 0 m 5 m 0 m 9 m 0 m 8 m 91 m 10 m 80 m
3 m 0 m 8 m 0 m 20 2 r 0 d r 21 m 80 2 r 0 2 r 80 m 0 2 r 21 m 80 m 0 m 80 m 0 4 r 3 m 80 2 r 0 2 r 80 m 0 2 r 8 m 80 m c1 m 0
2 r 20 m 80 m 83 m 41 m 3 m 83 m 88 m 11 m 10 m 0 m 3 m 8 m 2 m 80 m 10 m 90 m 41 m 0 4 r 80 m 83 m 5 m 0 8 r 2 m 1 m 2 m 0 m
82 m 40 m 4 m 0 m 2 m 0 m c0 m 0 m 4 m 2 m 88 m 0 m notbusy
02 wcmd 0 m 4f m 0 m \ 0x4f00 
91 m 8 m c0 m 0 m 40 m 10 m 21 m 1 m 8 m 0 m 90 m 0 m 8 m 40 m 82 m 0 2 r 8 m 1 m 0 4 r 20 m 0 m 20 m 0 4 r 1 m 2 m 1 m 2 m 0
5 r 20 m 0 a r 8 m 0 m 8 m 0 m 8 m 10 2 r 0 m 2 m 0 m c0 m 0 m 8 m c0 m 2 m 0 m 20 m 0 m a0 m 1 m 84 m 2 m 8 m 20 m 40 m 0 m 8
m 0 m 8 m 40 m 20 m 0 m 4 m 40 2 r 0 m 10 2 r 9 m 0 m a1 m 90 m 88 m 1 m 89 m 2 m 9 m 5 m 9 m 0 m 20 m 0 2 r 82 m 83 m 1 m 0 8
r 10 m 2 m 84 m 2 m 0 m 4 m 10 m 2 m 4 m 2 m 0 m 8 m 10 m 88 m 8 2 r a0 m 3 m 0 m 10 m 0 m 9 m 89 m 11 m 82 m 41 m 0 m 9 m 8 m
20 m 8 2 r 0 4 r 2 m 0 5 r 1 m 0 9 r 8 m 0 d r 88 m 40 m 0 m 88 m 2 m 90 m 2 2 r 20 m 40 m 0 m 88 m 4 m 40 m 90 m c0 m 20 m 40
m 0 m 82 m 40 m 2 m 21 m 20 m 4 m 8 m 0 m 88 m 0 m 10 m 20 m 8 m 88 m c0 m 0 m 8 m 1 m 5 m 10 m c0 m 20 m 89 m 0 m 3 m 0 m 9 m
a0 m 21 m 0 4 r 1 m 0 m 2 2 r 0 8 r 80 m 0 4 r 80 m 88 m 80 3 r 0 m 80 m notbusy
20 wcmd 0 m 50 m 0 m notbusy \ 0x5000
02 wcmd 0 m 50 m 0 m \ 0x5000 
80 m 0 4 r 90 m 4 m 10 m 41 m 85 m 2 m 88 m 0 m c0 m 0 m 4 m 80 m 4 m 0 m c0 m 0 m 3 m 11 m 41 m 2 m 8 m 0 m 5 m 0 m 20 m 8 m
21 m 9 2 r 0 m 5 m 0 m 41 2 r 8 m 2 2 r 0 m 5 m 0 b r 80 m 0 4 r 82 m 80 m 0 m 80 m 0 3 r 80 m 0 3 r 80 m 0 3 r 80 m 2 m 0 7 r
9 m 0 2 r 11 m 10 m 8 m 10 m 85 m 89 m 11 m 0 m 10 m 21 m 85 m 3 m 2 m 0 m 10 m 0 4 r 41 m 0 m 80 2 r 4 m 0 8 r 9 m 0 m 5 m 0
m 80 2 r 0 m 80 m 0 2 r 85 m 0 m 80 m 0 2 r 10 m 82 m 10 m 40 m 85 m 0 m 20 m 40 m 0 m 4 m 0 m 10 m 80 3 r 0 m 20 m 80 m 9 m 0
m 2 m 0 m 20 m 5 m 10 m 91 m 8 m 0 m 9 m 0 m 5 2 r 41 m 80 m 8 m 0 m 2 m 0 m 8 m 2 m 0 9 r 2 m 0 3 r 8 m 0 m 80 2 r 0 2 r 20 m
0 m 2 m 80 2 r 0 3 r 2 m 80 m 85 m 80 2 r 0 2 r 80 m 40 m 0 m 90 m 0 m 80 m 0 2 r 3 m 88 m 8 m 20 m c1 m 91 3 r 3 m 85 m 5 m
90 m 2 m 80 m 20 m 10 m 0 m 20 m 0 m 5 m 3 m 41 m 21 m 0 9 r 2 m 0 m 2 2 r a0 m 40 m 4 m 0 m notbusy
02 wcmd 0 m 51 m 0 m \ 0x5100 
40 m 0 m 40 m 2 m 88 m 10 m 40 m 0 m 91 m 3 m c0 m 10 m 2 m 8 m 88 m 1 m 90 m 0 m 8 m c1 m 40 m 8 m 10 m 0 2 r c0 m 0 6 r 1 m
2 m 1 m 0 6 r 40 m 0 4 r 1 m 0 b r 2 m 0 m 90 2 r 10 m 84 m 2 m 0 m 4 m 0 m 88 m 89 m 40 2 r 20 m 0 m 90 m 1 m 20 m 82 m 2 2 r
40 m 0 m 10 m 1 m c0 m 20 2 r 2 m 8 m 0 m 4 m c1 m 8 2 r 4 m 5 m 10 m 90 m 82 2 r c0 m 3 m 9 m c0 m 88 m 9 m 0 3 r 1 2 r 0 e r
c8 m b m 0 m 60 m 0 5 r b m 0 6 r d0 m b m 0 3 r 48 m 0 2 r 90 m b m 0 6 r d0 m 0 2 r 42 m 0 4 r d0 m 0 7 r d0 m 0 12 r b m 0
7 r b m 0 7 r b m 0 m 60 m 0 4 r c8 m b m 0 6 r d0 m b m 0 m 42 m 12 m 0 3 r d0 m b m 0 2 r a m 0 3 r c8 m 43 m 0 b r f0 4 r
notbusy
02 wcmd 0 m 52 m 0 m \ 0x5200 
20 m ef m 0 m ff m 3c 2 r bc m 3c 4 r 78 m f0 4 r 0 m 80 m 7f m ff m f0 3 r f2 m 0 m 80 m ff 2 r 0 22 r aa m a2 m aa m ae m f0
4 r 8a m aa m ba m aa m 0 m 8 m ff m fd m 0 m ff m 0 m ff m 3c m b4 m 3c 2 r 0 2 r ff 2 r 80 m fd m 80 m fd m 0 m a m ff m fa
m e0 m 0 m ff 2 r 3c m 2c m 3c m 7c m 0 m b m ff 2 r 0 10 r f0 3 r e8 m 0 m ff m 0 m ff m 3c 2 r 1c m 3c 5 r f0 2 r d0 m f8 m
0 2 r ff 2 r f0 3 r 70 m 0 2 r ff m 7f m 0 22 r aa 4 r f0 3 r 78 m aa 4 r 0 2 r ff 2 r 0 m ff m 20 m 7f m 3c 4 r 0 m a2 m 5d m
ff m 80 m fd m 0 m ff m 0 m 2 m ff m fe m 0 2 r 1f m ff m 2c 2 r 7c 2 r 0 2 r ff m f4 m 0 m 10 m 0 2 r 54 m a9 m 14 m a8 m 0 8
r notbusy
02 wcmd 0 m 53 m 0 m \ 0x5300 
3c m 2d m 3c 2 r ff m 10 m ff m 0 m ff 3 r fb m bf m 1 m ff m 0 m 3c m 3d m 3c 2 r ff 2 r 0 2 r 7c m 3c 3 r 55 4 r 0 22 r ff m
fe m ff 3 r 0 m ff m 4 m f 2 r 1f m b m 2f m 7 m f 2 r ff m 8 m f7 m 0 m f m 17 m f 2 r ff m 2f m ff 2 r df m 10 m ff m 0 m 3c
m 3f m 3c m 3e m 3c 4 r ff m 30 m ff m 20 m ff m a8 m ff m 0 m 10 m 4 m 0 m 80 m 1 m 0 m 20 m 8 m 0 8 r 3c 4 r ef m 0 m ff m 0
3 r 4 m 0 m ff m 0 m ff m 0 m 3c m 38 m 3c 2 r ef m ff m 4 m 0 m 2c m 3c 3 r 5d m 55 m 51 m 55 m 0 22 r 1 m 0 3 r ff m 0 m fb
m 0 m f 8 r ff m 0 m ff m 0 m f 4 r 0 m 7 m 0 2 r df m 10 m df m 10 m 3c m 30 m 3c m 34 m 3d m 7d m 38 m 28 m cf m 0 m df m 0
m 57 m 0 m ff m 0 d r notbusy
02 wcmd 0 m 54 m 0 m \ 0x5400 
0 5 r 61 m 0 m f m 0 m d m 0 5 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m e m c0 m 9 m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 3 r
61 m 0 m 1 m 0 m 1 m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 f r 8 m 0 7 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m e m 0 m d m 0 3 r 61 m 0 m 9 m 0
m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 22 r bf m ff 3 r aa 4 r 0 4 r 3f m cf m 3a m ca m ff m ef m 10 m 0 2 r ff m 8 m ff 3 r 10 m
0 m aa 2 r b2 m aa m 35 m 55 3 r 20 m 0 m ff 2 r 0 2a r f 2 r df m f m 0 m ff m 0 m ff m bf m 10 m ff m 0 m f0 m aa m b2 m aa
m 0 2 r 40 m 90 m 9a m 0 3 r notbusy
02 wcmd 0 m 55 m 0 m \ 0x5500 
0 18 r 1 m 0 3 r aa 2 r 8a m ba m 0 4 r 3f m cf m 3a m ca m ff 2 r 0 3 r ff m 0 m f7 m ef m ff m 0 2 r aa 4 r 55 4 r 0 2 r df
m ff m 0 2a r f 2 r 8 m f m 30 m 3f m 20 m 7f m 3f m 30 m ff m 0 m aa 4 r 0 4 r f m f0 m f m f1 m 0 18 r 55 m 5d m 55 2 r aa 4
r 0 8 r ff m 0 m ff m 0 m f0 m f8 m f0 2 r ff m 0 m ff m 0 m df m ff 5 r 0 2 r f0 3 r b4 m 0 2a r 3c m 3f m 3c m 3e m ff 2 r
fe m fc m 5f m ff m 7f m ff m af m ff m ef m ff m 0 4 r notbusy
02 wcmd 0 m 56 m 0 m \ 0x5600 
0 1c r 55 m 51 m 55 2 r aa m 8a m aa m ba m 0 8 r f7 m 4 m ff m 0 m f0 m d0 m f0 2 r ef m 4 m ff m 0 3 r 20 m 0 m ff m fb m 4
m 0 m f0 4 r 0 2a r 3c m 30 m 3c m 34 m 0 2 r 4 m c m 50 m 0 m 40 m 0 m a0 m 0 m 20 m 0 2 r 20 m 0 4 r 4 m 0 19 r 4 m 0 m 4 m
0 m 4 m 0 5d r notbusy
02 wcmd 0 m 57 m 0 m \ 0x5700 
0 10 r 9 m 0 2 r 40 m 0 b r 82 m 0 d r 4 m 0 m 4 m 0 13 r 82 m 0 m 82 m 0 m 82 m 0 d r c0 m 0 4 r 21 m 0 f r 41 m 0 5 r 21 m 0
4 r 40 m 0 35 r 40 m 0 m 4 m 0 52 r notbusy
02 wcmd 0 m 58 m 0 m \ 0x5800 
0 3 r 10 m 0 22 r 2 m 0 3 r 2 m 0 2 r 4 m 0 6a r 90 m 0 m 88 m 0 m 90 m 0 m a0 m 0 3 r 88 m 0 3 r 88 m 0 m 88 m 0 3 r 90 m 0 3
r 8 m 0 3 r 88 m 0 m 90 m 0 m 88 m 0 27 r 2 m 0 7 r 40 m 0 3 r a0 m 0 5 r 40 m 0 m 40 m 0 7 r 4 m 0 3 r notbusy
02 wcmd 0 m 59 m 0 m \ 0x5900 
0 4 r 88 m 0 13 r 21 m c0 m 0 c r 3 m 0 m 9 m 0 3 r 9 m 0 m 11 m 88 m 0 2 r 11 m 40 m 0 2 r 9 m 0 m 5 m 0 9 r 20 m 0 3 r 41 m
0 13 r 5 m 0 m 5 m 0 5 r 21 m 0 3 r 5 m 88 m 11 m 0 2 r 4 m 0 4 r 2 m 0 m 9 m 0 3 r 21 m 0 3 r 41 m 0 2 r 20 m 4 m c0 m 20 m 0
m 21 m 0 m 40 m 4 m 0 1e r 84 m 0 5 r 2 m 0 a r 40 m 0 7 r 40 m 0 9 r 40 m 0 25 r 40 m 0 m 40 m 0 m 40 m 0 m 40 m 0 m 4 m 0 5
r 4 m 0 4 r notbusy
02 wcmd 0 m 5a m 0 m \ 0x5a00 
0 2 r 88 m 0 1a r 88 m 0 m 90 m 0 6 r 5 m 0 7 r 21 m 0 m 2 m 0 m 20 m 0 m 5 m 0 6 r 20 m 0 c r 5 m 0 m 9 m 0 2 r 4 m 8 m 10 m
0 a r 11 m 0 2b r 4 m 0 m 4 m 90 m 0 m 90 m 0 32 r 84 m 0 13 r 8 m 0 5 r 90 m 0 21 r 40 m 0 5 r notbusy
02 wcmd 0 m 5b m 0 m \ 0x5b00 
0 4 r 10 m 0 1d r 21 m c0 m 0 2 r 9 m 0 8 r 2 m 20 m 90 m 0 2 r 21 m 0 m 11 m 0 m 11 m 0 m 3 m 0 m 8 m 0 3 r 11 m 0 m 21 m 0 5
r 21 m 0 4 r 2 m 20 m 84 m 0 m 88 m 0 3 r 88 m 9 m 0 d r 5 m 10 m 0 m 10 m 0 6 r 5 m 88 m 11 m 0 m 9 m 0 a r 2 m 0 m 10 m 40 m
0 2 r c0 m 5 m c0 m 0 3 r 90 m 0 m 90 m 41 m 90 m 40 m 88 m 40 m 0 5 r 10 m 0 m 3 m 0 9 r 20 m 0 9 r 20 m 0 m 2 m 0 d r 8 m 0
5 r 90 m 0 f r 8 m 0 6 r 11 m 0 a r 84 m 0 b r 90 m 0 7 r 84 m 0 7 r notbusy
02 wcmd 0 m 5c m 0 m \ 0x5c00 
0 4 r 90 m 0 1f r 20 m 0 m 9 m 0 15 r 20 m 88 m 20 m 0 2 r 40 m 2 m 0 m 3 m 40 m 0 3 r 40 m 2 m 0 2 r 4 m 0 2 r 20 m 2 m 20 m
0 m 9 m 2 m 0 3 r 10 m 11 m 90 m 21 m 0 m 41 m 0 7 r 41 m 0 3 r 5 m 0 2 r 2 m 0 12 r 20 m 0 2 r 4 m 0 b r 90 m 9 m 0 2 r 90 m
5 m 0 11 r ff 5a r notbusy
02 wcmd 0 m 5d m 0 m \ 0x5d00 
ff 28 r 0 m 3 m c9 m 8b m 30 m 22 m 0 m 8 m 0 2 r 50 m 60 m 0 2 r 6 m 18 m 0 2 r 4 m 0 m 4 m 0 m 4 m 0 11 r 1 m 0 6 r 80 m 0 4
r 40 m 0 m c0 m 0 2 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 8 m 0 4 r 1 m 4 m 0 m 80 m 0 m 80 m 0 3 r 80 m 0 9 r 80 m 0 50 r 20
m 0 6 r 20 m 0 9 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 1 m 0 4 r 10 m 1 m 0 m 20 m 0 m 20 m 0 3 r 20 m 0 m 3 m 0 4 r notbusy
02 wcmd 0 m 5e m 0 m \ 0x5e00 
0 3 r 20 m 0 4 r 41 m 0 m 21 m 0 1f r 10 m 0 19 r 20 m 0 27 r 1 m 0 10 r 1 m 0 2b r 41 m 0 m 41 m 0 21 r 82 m 0 20 r 20 m 0 11
r notbusy
02 wcmd 0 m 5f m 0 m \ 0x5f00 
0 44 r 90 m 0 3 r 82 m 0 6 r 11 m 9 m 0 5 r 8 m 0 m 82 m 0 3 r 88 m 0 3 r 90 m 0 5 r a0 m 0 2 r 5 m 0 7 r a1 m 0 2 r 84 m 0 m
88 m 0 5 r 1 m 0 5 r a0 m 3 m c0 m 0 m 82 m 0 2 r 3 m 0 3 r 4 m 0 m 2 m 20 m 4 m 84 m 0 5 r 82 m 0 3 r 88 m 0 5 r 82 m 0 3 r
20 m 0 m 1 m 20 m 0 2 r 4 m 0 2 r 80 m a0 m 0 m 10 m 0 11 r 9 m 0 d r 4 m 0 6 r 82 m 21 m 0 b r 8 m 0 c r 20 m 0 3 r 90 m 0 2
r 3 m 0 m 41 m 82 m 4 m 82 m notbusy
20 wcmd 0 m 60 m 0 m notbusy \ 0x6000
02 wcmd 0 m 60 m 0 m \ 0x6000 
0 m 82 m 0 6 r 21 m 0 6 r 1 m 40 m 0 2 r 1 m 5 m 0 9 r 2 m 0 8 r 2 m 0 2 r 4 m 1 m 0 2 r 80 m 0 2 r 20 m 0 12 r 4 m 80 m 82 m
80 m 0 2 r 82 m 0 m 8 m 80 m 0 2 r 82 m 0 3 r 4 m 0 3 r 4 m 80 m 4 m 0 m 82 m 0 m 20 m 0 m 82 m 80 m 20 m 0 3 r 8 m 0 m 84 m 0
m 8 m 0 m 82 m 0 3 r a0 m 0 m c0 m 0 2 r 20 m 1 m 0 m 82 m a0 m 40 m 20 2 r 80 m 20 m 0 2 r 80 m 20 m 0 7 r 8 m 0 m 8 m 80 m 0
m 80 m 0 6 r 84 m 0 5 r 82 m 20 m 0 4 r 84 m 0 6 r 80 m 0 1d r 20 m 0 m 20 m 0 m 82 m 0 2 r 10 m 20 m 10 m 0 m 3 m 0 m 41 m 0
m 3 m 0 m 4 m 0 m 80 m 20 m c1 m 0 m 21 m 0 m 80 m 0 m 41 m 4 m a1 m 0 2 r a0 m 21 m 90 m 0 m 88 m 11 m 90 m 0 9 r a1 m 4 m 0
2 r 9 m 0 m 1 m 80 m 4 m notbusy
02 wcmd 0 m 61 m 0 m \ 0x6100 
80 m 0 2 r 4 m 80 m 0 4 r 40 m 0 2 r 8 m 0 2 r 20 m 0 m 4 m 41 m 0 9 r 20 m 0 m 3 m 0 m 20 m 0 a r 20 m 0 2 r 10 m 0 2 r 4 m 0
m 90 m 0 14 r 84 m 0 3 r 1 m 0 m 84 m 85 m 8 m 0 m 4 m 10 m 0 2 r 84 m 11 m 8 m 2 m 4 m 20 m 0 2 r 8 m 20 m 82 m 80 m 0 m 80 m
91 m 20 m 0 2 r 90 m 21 m 84 m 20 m 0 m 20 m 0 m 20 m a0 m 0 m 82 m 0 m 82 m 0 m 82 m 0 4 r 80 m 85 m 3 m 90 m 80 m 4 m 5 m 0
m 90 m 84 m 0 6 r 20 m a0 m 20 m 8 m 20 m 0 4 r 20 m 0 m 20 m 4 m 20 2 r 84 m 20 m 0 2 r 4 m 20 m 4 m 20 m 0 m 20 m 4 m 0 m 4
m 0 m 4 m 20 m 4 m 20 m 0 2 r 4 m 20 m 40 m 0 m 1 m 20 m a0 m 0 4 r a0 m 0 12 r 9 m 88 m 4 m 0 2 r 20 m 0 2 r 89 m 0 5 r 8 m
90 m 89 m 1 m 0 2 r 8 m 83 m 0 m 20 m 0 m 20 m 4 m 0 3 r 5 m 0 2 r 1 m 0 m 1 m 0 m 1 m 0 b r 20 m 4 m 0 m notbusy
02 wcmd 0 m 62 m 0 m \ 0x6200 
0 m 20 m 80 m 0 2 r 20 m 0 7 r 1 m 0 m 1 m 0 m 1 m 0 4 r 80 m 0 m 80 m 1 m 80 m 20 m 0 m 1 m 0 2 r 80 m 1 m 83 m 1 m 0 m 1 m
80 m 0 m 80 m 0 m 82 m 1 m 80 m 1 m 0 2 r 80 m 1 m 0 2 r 4 m 1 m 9 m 0 3 r 9 m 21 m 0 11 r 4 m 0 5 r 4 2 r 0 2 r 20 m 4 m 80 m
5 m 20 m 8 m 20 m 8 m 0 3 r 8 m 0 m c0 m 3 m a0 m 0 2 r 3 m 4 m 3 m 83 m 0 m a0 m 84 2 r 4 m 0 m 4 m 0 2 r a0 m 0 3 r 88 m 0 2
r 21 m 1 m 0 m 20 m 0 m 88 m 4 m 82 m 20 m 5 m 2 m 84 m 80 m 4 m 89 m 0 3 r 3 m 0 5 r 40 m 20 m 0 7 r 4 m 0 m 4 m 20 m 0 2 r
82 m 0 m 4 m 0 2 r 20 m 0 m 20 m c0 m 0 m 82 m 0 m 4 m 41 m 0 2 r 82 m 0 4 r 20 m 0 m 20 m 0 15 r 84 m 41 m 0 3 r 80 m 0 2 r 1
m 80 m 20 m 84 m 0 2 r 1 m 3 m 0 m 8 m 0 m 3 m 20 m 3 m 82 m 0 3 r 2 m 80 m 82 m 4 m 0 2 r 20 m 0 7 r 88 m 0 3 r 4 m 0 2 r
notbusy
02 wcmd 0 m 63 m 0 m \ 0x6300 
20 m 0 m 80 m 0 5 r 20 m 0 m 21 m 4 m 80 m 4 m 0 a r 80 m 0 7 r 80 m 0 m 80 m 1 m 20 m 0 3 r 91 m 0 2 r 1 m 0 m 1 m 9 m 0 3 r
80 m 0 8 r 1 m 0 m 1 m 0 2 r 40 m 0 2 r 2 m 0 c r 88 m 0 2 r 10 m 0 m 2 m 20 2 r 40 m 20 2 r 40 m 0 m 90 m c0 m 10 m 40 m 2 m
90 2 r 0 m 8 m c0 m 2 m 10 2 r 0 m 8 m 0 m 10 m c0 m 2 2 r 4 m 0 m 20 m 0 m 90 m 2 3 r 88 m 0 m 90 m 0 m 84 m 88 m 2 m 8 m 3 m
84 m 88 m 0 m 21 m 10 m 82 m 40 m 41 m 21 m 2 m 90 m 20 m 40 m 10 m 0 2 r 4 2 r a0 m 2 m 0 m 8 m 82 m a0 m 0 m 1 m 0 m 1 m 20
m 0 3 r 20 m 2 m 0 m 8 m 0 m 84 m c0 m 40 m 10 m 84 m 4 m 90 m 0 m 82 m 4 2 r 20 m 2 m 8 m 4 m 0 m 82 m 4 m 40 m a1 m a0 m 0 m
84 m 0 m 2 m c0 m 4 m 0 13 r 80 m 0 m 80 m 0 2 r a0 m 0 2 r 80 m 0 2 r 80 4 r 0 3 r 80 3 r 91 m 80 m 0 m 80 m 40 m 80 m 0 m 80
m 20 m 80 m 0 4 r 80 3 r 0 5 r notbusy
02 wcmd 0 m 64 m 0 m \ 0x6400 
0 m 80 2 r 41 m 0 m 9 m 0 m 2 m 0 m 89 m 40 m 8 m 41 m 90 m 8 m 2 m 0 m a0 m 0 2 r 80 2 r 0 m 80 m 0 2 r 80 m 0 m 40 m 8 m 11
m 3 m 8 m 41 m 0 m 10 m 20 m 80 m 0 m 80 m 0 2 r 80 m 0 m 5 m 0 m 80 m 0 2 r 80 3 r 20 m 80 2 r 0 2 r 80 2 r 0 m 4 m 0 4 r 80
3 r 0 12 r 80 m 0 7 r 80 m 41 m 80 m 91 m 0 2 r 80 m 0 2 r 10 m 80 m 85 m 80 m 0 m 80 m 4 m 0 m 4 m 0 m c0 m 80 m 0 4 r 20 m
80 3 r 0 m 80 m 0 2 r 10 m 0 2 r 80 m 0 m 83 m 0 m 20 m 2 m 40 m 0 m 41 m 40 m 82 m 80 m 83 m 21 m 90 m 82 2 r 3 m 0 2 r 80 m
0 2 r 11 m 0 m 80 2 r 0 m 10 m 80 m 3 m 0 m 20 2 r 10 m 20 m 0 2 r 80 m 21 m 80 2 r 0 5 r 21 m 80 3 r 0 3 r 80 m 21 m 80 2 r 0
5 r 3 m 0 m 80 3 r 0 12 r 10 m 0 m 84 m 90 2 r 0 m 20 m 0 m 10 m 0 m 10 m 40 m 90 m 0 m 8 m 0 m 10 m 0 m 2 2 r 82 m 0 m 10 m 0
m 2 m 1 m a0 m 41 m 8 m 0 m 88 m 0 m 2 m 0 m 84 m 40 m 2 m 90 m 8 m 0 m notbusy
02 wcmd 0 m 65 m 0 m \ 0x6500 
90 m 1 m 4 m c0 m 2 m 0 m 8 m 90 m 2 m 0 m 21 m 20 m 91 m 0 m 8 m 40 m 3 m 0 m 41 m 10 m 8 m 91 m 0 2 r 4 m 0 m c0 m 0 m 8 m 4
2 r 0 m 1 m 40 m 1 m 0 4 r 20 m 90 m 0 m 10 m 0 m 40 m 10 m 40 m 0 m 2 m 0 m 90 m 0 m 2 m 10 m 4 m 0 m 40 m 0 m 10 m 0 m 40 m
10 m 40 m 0 m a0 m 0 m 90 m 1 m c0 m 40 m 4 m 2 m 0 10 r 88 m 90 m 0 m 88 m 0 2 r 8 m a0 m c0 m 20 m 0 m 88 m 0 m 20 m c0 m 20
m 10 2 r 0 m 90 m 0 m 2 m c0 m 8 m a0 m 4 m 82 m 10 m 0 m 8 m 89 m 88 m 2 2 r 0 m 20 m 0 m 40 m 20 2 r 8 m 88 m 0 m 90 m 0 m
88 m 10 m 8 2 r c0 m 0 m 10 m 0 m 20 m 90 2 r 8 m 3 m 1 m 21 m 1 m 84 m 4 m 10 m 0 2 r 10 2 r 0 m 8 m 0 m 4 m 2 m 40 m 0 m 1 m
0 m 1 m 0 4 r 20 m 90 m 0 m 20 m 0 m 84 m 10 m 40 m 88 m 2 m 0 m 8 m 2 2 r 20 m 10 m 20 m 2 m 0 m 4 m 0 m 8 m 4 m 40 m 4 2 r 0
m 20 m 0 m 84 m 2 m 4 m 0 18 r 80 m 0 5 r 80 m 0 6 r 80 m 85 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 2 m 0 2 r 80 m 0 4 r notbusy
02 wcmd 0 m 66 m 0 m \ 0x6600 
40 m 0 m 80 m 0 5 r 80 3 r 3 m 40 m 83 m 41 m 0 2 r 20 m 80 m 88 m 10 m 83 m 10 m 2 m 82 m a0 m 0 2 r 80 2 r 0 3 r 80 2 r 0 2
r 8 m 11 m 3 m 20 m 10 m 40 m 20 m 0 3 r 80 m 0 2 r 40 m 0 2 r 80 m 0 m 80 3 r 0 m 80 m 0 m 80 m 0 3 r 80 m c0 m 0 m 80 2 r 0
m 80 m 0 2 r 85 m 80 m 0 11 r 10 m 0 m 21 m 0 4 r 80 m 10 m 80 m a1 m 0 5 r 5 m 80 m 82 m 80 2 r 0 2 r 80 m 5 m 80 m 5 m 0 m
80 m 0 3 r 2 m 80 m a0 m 0 5 r 4 m 0 m 5 m 80 m 0 3 r c1 m 83 m 21 m 5 m 3 m 0 m 20 m 5 m 88 m 9 m 10 m 40 m 82 m 0 m 10 2 r 0
2 r 80 m 11 m 0 m c0 m 80 2 r 0 2 r 8 m 40 m 21 m 9 m 10 m 0 m 3 m 11 m 80 m 3 m 80 m c0 m 0 5 r 4 m 80 m a0 m 80 m 0 m 80 m 0
m 80 m 0 m 80 m a0 m 0 2 r 80 m 0 2 r 3 m 80 m 40 m 80 2 r 0 12 r 88 m 1 m 88 2 r 20 3 r 0 m 8 m 1 m 2 2 r 20 3 r 0 m 90 m 0 m
20 m 83 m 2 2 r 10 m 0 m 4 m 0 m 10 m 90 m a0 m 40 m 88 m 0 m 82 m 0 m notbusy
02 wcmd 0 m 67 m 0 m \ 0x6700 
20 m 82 m 20 2 r 40 m 0 m 88 m 0 m 10 m a0 m 40 m 90 m 88 m 0 m 9 m 2 m a0 m 90 2 r a0 m 89 m 0 m 3 m 88 m 21 m 20 m 40 m 88 m
89 m 1 m 0 2 r 4 m 0 m 8 m 20 m 2 m 4 m 82 m 0 m 1 m 88 m 0 4 r 1 m 0 m 4 m 0 m 82 m 2 m 84 2 r 10 m 0 m 90 m 1 m 40 m 8 m 40
m 20 m 4 m 0 m 4 m 0 m 82 m 2 m 4 3 r 0 m 90 m 0 m 2 m a0 m 84 m c0 2 r 0 15 r b m 0 7 r b m 0 m 82 m 6 m 0 4 r b m 0 2 r 6 m
0 3 r c8 m b m 0 7 r b m 0 7 r b m 0 6 r c8 m b m 0 6 r d0 m b m 0 m 60 m 0 7 r b m 0 6 r d0 m 0 8 r b m 0 2 r 12 m 0 4 r b m
0 7 r b m 0 7 r b m 0 2 r 6 m 0 10 r 66 2 r 76 m 66 m ff 2 r 10 2 r ff 2 r 0 2 r f8 m e0 m f0 2 r 3c 4 r 7f m ff m 40 m 0 m f0
m f4 m f0 2 r ff m fb m notbusy
02 wcmd 0 m 68 m 0 m \ 0x6800 
ff 2 r 66 m 76 m 66 m 46 m bc m 2c m 3c 2 r e4 m 66 3 r ff m 0 m ff m 0 m ff m 0 m ff m 0 m 3e m 3c 3 r 36 m 3c 3 r ff m 4 m
fb m 0 3 r f0 4 r ff 2 r bf m ff m 0 8 r 7f m ff m 40 m 0 m f3 m f1 m f0 2 r ff 2 r ef m e7 m bc m bd m 2c m 24 m ff 2 r 0 2 r
bc m 2c m 3c 2 r ff m ef m ff m 6f m f0 4 r 0 10 r 66 2 r 76 m 66 m ff 2 r 0 2 r bf m ff m 20 m 0 m f0 4 r 7c m 1c m 3c 2 r ff
2 r 0 2 r f0 m d0 m f0 2 r 4 m 0 3 r 66 4 r 3c 4 r 66 4 r ff m 20 m df m 0 m bf m 20 m ff m 0 m 38 m 3c 7 r ff m 0 m ff m 0 3
r b4 m f0 3 r 40 m 0 b r 7e m ff m 42 m 0 m 30 m 70 m f0 2 r 0 2 r 20 m 24 m 3c 4 r 6e m ff m 62 m 0 m bd m 24 m 3c 2 r 0 m 20
m 0 m 60 m f7 m 10 m f0 2 r 0 10 r ff 1a r notbusy
02 wcmd 0 m 69 m 0 m \ 0x6900 
ff 68 r 0 m 37 m 6d m 49 m 30 m 22 m 0 m 8 m 0 m 18 m 50 m 60 m 0 2 r 9 m a6 m f 4 r 0 m f9 m 0 m ff m 3c 2 r 3e m 3c m b m f
m 2f m f 5 r 3c 3 r 6c m ff 2 r df m ff m 0 m df m 20 m ff m f 4 r 0 m ff m 20 m ef m f 4 r 66 2 r 64 m 67 m 38 m 3e m 3c 2 r
ff 3 r ef m 66 4 r 0 m 2 m ff 2 r 0 2 r 3c 4 r 0 m 8 m ff m ef m 0 9 r 8 m f7 m ff m 66 2 r 27 2 r 1f m f m 3f m f m 0 m ff m
20 m bf m 0 2 r ff 2 r 66 2 r f m 66 3 r 46 m 76 m 66 4 r 0 10 r f m b m f m b m 0 m ff m notbusy
02 wcmd 0 m 6a m 0 m \ 0x6a00 
0 m ff m 3c 2 r 38 m 3c m f 5 r b m f m 2f m 3c 4 r 0 3 r 20 m 0 m ff m 0 m ff m f m b m f m 2f m 0 m ff m 0 m ff m f 3 r 27 m
66 4 r 3c 4 r 0 3 r 20 m 66 3 r 6c m 0 2 r ff m fd m 0 2 r 3c 3 r 36 m 0 2 r ff 2 r 0 9 r 18 m e7 m ff m 66 2 r 27 m 66 m 7 m
f m 3 m f m 0 m ff m 30 m 3f m 8 m c m ef m cf m 66 2 r 27 m 66 m 46 m 76 m 46 m 76 m 66 2 r 2 m fe m 0 13 r 8 m 0 7 r 8 m 0 7
r 8 m 0 5 r 61 m 0 m f m 0 m d m 0 5 r 8 m 0 7 r 8 m 0 7 r 8 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 7 r 8 m 0 5 r 61 m 0 m 1 m
0 m 1 m 0 5 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 16 r notbusy
02 wcmd 0 m 6b m 0 m \ 0x6b00 
0 2e r f m 55 m ff m 3c m c0 2 r fc 2 r ff m f7 m ff m f5 m ff m fe m ff m fa m 0 a r fd m 8 m fd m 8 m f0 m f1 m f0 m f5 m 0
60 r f m 55 m 0 m 3c m c0 2 r fc 2 r 0 m 4 m 0 m 5 m 0 m 40 m 0 m 50 m 0 a r ff m 0 m fd m 8 m f0 m b0 m f0 m a0 m 0 2e r
notbusy
02 wcmd 0 m 6c m 0 m \ 0x6c00 
0 32 r f 2 r 55 2 r f0 2 r aa 2 r 55 4 r f0 2 r 78 m f0 m 0 a r f 4 r 3c 2 r ac m 3c m 0 60 r ff m 0 m 3c 2 r 0 m ff m 3c 2 r
5d m 51 m 5f m 50 m f0 2 r 3c m f0 m 0 a r 17 m f m 17 2 r 3c 2 r aa m 3c m 0 2a r notbusy
02 wcmd 0 m 6d m 0 m \ 0x6d00 
0 14 r 8 m 0 5 r 2 m 0 m 88 m 0 4 r 80 m 0 m 80 m 0 m 80 m 0 2 r 90 m 0 m 84 m 0 4 r 82 m 0 m 85 m 0 m 20 m 0 m 20 m 0 4 r 20
m 0 f r 20 m 0 3 r 88 m 0 e r 80 m 0 m a0 m 0 m 80 m 0 3 r 80 m 0 6 r 1 m 20 m 0 28 r 80 m 0 5 r 80 m 0 6 r 20 m 0 m 20 m 0 m
20 m 0 9 r 20 m 0 m 20 m 0 m 1 m 0 m 1 m 0 11 r 3 m 0 14 r 40 m 20 m 0 m 21 m 0 m 20 m 0 3 r 20 m 0 6 r 8 m 0 11 r notbusy
02 wcmd 0 m 6e m 0 m \ 0x6e00 
0 15 r 40 m 0 2 r 8 m 0 m 5 m 0 m 5 m 4 2 r 0 m 3 m 0 2a r 3 m 0 1f r 10 m 0 7 r 40 m 0 m 20 m 0 d r 40 m 0 13 r 1 m 0 2 r 80
m 0 m 82 m 0 m 82 m 1 m 80 m 0 m 84 m 0 4 r c0 m 0 3 r 8 m 5 m 0 16 r 8 m 0 7 r 8 m 0 19 r 40 m 0 7 r 8 m 0 9 r 1 m 0 8 r
notbusy
02 wcmd 0 m 6f m 0 m \ 0x6f00 
0 d r 40 m 0 m 5 m 1 m 0 m 1 m 0 6 r 10 m 0 c r 1 m 0 a r 4 m 0 3 r 4 m 0 7 r 3 m 0 m 4 m 1 m 4 m 0 m 21 m 0 m 4 m 0 3 r 21 m
0 7 r 11 m 0 3 r 21 m 0 2 r c0 m 0 2 r 4 m 0 4 r 4 m 0 m 4 m 0 2 r 2 m 0 4 r 4 m 0 m a0 m 0 m 4 m 0 b r c0 m 0 m 90 m 0 m a0 m
0 11 r 3 m 0 m 4 m 0 m 4 m 0 m 11 m 0 m 21 m 0 e r 8 m 4 m c0 m 40 m 0 m 41 m 0 m 41 m 84 m 0 3 r 1 m 0 3 r 1 m 0 2 r 3 m 0 m
11 m 0 m 41 m 0 2 r 1 m 20 m 5 m 40 m 0 m 21 m 1 m 0 5 r 2 m 0 5 r c0 m 0 2 r 8 m 0 m 3 m 0 m 5 m 0 7 r 80 m 0 m 80 m 0 m 10 m
2 m 41 m 0 m 9 m 0 m 80 m 0 m 21 m 0 m 80 m 90 m 0 b r 4 m 0 2 r notbusy
20 wcmd 0 m 70 m 0 m notbusy \ 0x7000
02 wcmd 0 m 70 m 0 m \ 0x7000 
0 14 r 82 m 0 m 82 m 0 m 2 m 0 5 r 4 m 0 3 r a0 m 0 m 20 m 0 2 r 80 m a0 m 80 m 0 2 r 40 m 0 3 r 88 m 0 m 20 m 0 m 20 m 0 m 40
m 80 m 20 m 0 3 r 40 m 0 2 r 41 m 0 8 r a0 m 0 7 r 88 m 0 b r 84 m 0 3 r 40 m 0 6 r 2 m 8 m 0 7 r 10 m 0 5 r 8 m 0 m 82 m 0 6
r 20 m 0 3 r 20 m 2 m 0 f r 3 m 0 m 3 m 40 m 41 m 0 3 r 3 m 0 3 r 80 m 0 5 r 83 m 0 2 r 4 m 41 m 4 m 21 m 0 5 r 11 m 0 m 80 m
0 m 80 m 0 2 r 4 m 80 m 0 a r 88 m 0 8 r 3 m 0 d r 5 m 0 b r 40 m 0 3 r 5 m 0 m 10 m 0 5 r 40 m 0 b r notbusy
02 wcmd 0 m 71 m 0 m \ 0x7100 
41 m 1 m 0 3 r 1 m 0 10 r a0 m 0 m 82 m 2 m 0 2 r 4 m 20 m 82 m 0 m 8 m 0 m 82 m 0 m 82 m 0 m 8 m 0 4 r 11 m c0 m 0 4 r 3 m a0
m c1 m 4 m 0 m 82 m 4 m 0 8 r a0 m 0 3 r 8 m 0 4 r 5 m 82 m 4 m 0 m 80 m 0 3 r 21 m 0 3 r 3 m 0 4 r a0 m 0 2 r 21 m 0 2 r 84 m
0 d r 84 m 0 9 r 40 m 41 m 0 2 r 8 m 0 m 8 m 0 3 r c0 m 0 7 r a0 m 0 d r 21 m 0 m 41 m 2 m 20 m 88 m a1 m 1 m 3 m 0 m 9 m 0 m
41 m c0 m 0 2 r 8 m 0 5 r 9 m 0 2 r 4 m 40 m 0 2 r 20 m 80 m 0 2 r 1 m 21 m 0 m 41 m 0 3 r 21 m c0 m 0 m 88 m 11 m 0 2 r 84 m
0 m a0 m 20 m 0 m 40 m 3 m 8 m 4 m 21 m c0 m 41 m a0 m 21 m 0 2 r c0 m 0 8 r 3 m 0 4 r 4 m 0 2 r 3 m 0 7 r 5 m 0 m 9 m 0 2 r
c0 m 0 8 r 80 m 0 m notbusy
02 wcmd 0 m 72 m 0 m \ 0x7200 
0 2 r 5 m 0 3 r 40 m 0 13 r 4 m c0 m 0 m 20 m 0 m 20 m 0 2 r 8 m 10 m 0 2 r 1 m 9 m 8 m 11 m 8 m 0 3 r 20 m 0 2 r a1 m 0 m 2 m
4 m 0 m 82 m 0 3 r 40 m 0 m 4 2 r 40 m 91 m 4 m 9 m 0 3 r 21 m 0 2 r 8 m 0 m 20 m 40 m 0 2 r 20 m 0 2 r 40 m 0 m 11 m 90 m 21
m 0 e r 2 m 0 m 2 m 0 m 2 m 0 m 2 m 0 5 r 10 m 0 d r 84 m 41 m 0 2 r 8 m 0 3 r c0 m 0 2 r 80 m 0 12 r 80 m 20 m 0 m 1 m 0 m 1
m 0 6 r 4 m 0 m c1 m 0 5 r 80 m 0 m 41 m 4 m 0 2 r 80 m 0 3 r 41 m 0 6 r 4 m 0 a r 80 m 0 m 10 m 0 m 80 m 0 5 r 40 m 0 1a r 2
m 0 9 r 2 m 10 m 2 m 40 m 0 m notbusy
02 wcmd 0 m 73 m 0 m \ 0x7300 
0 a r 41 m 20 m 0 m 2 m 41 m 0 f r c0 m 2 m c0 m 88 m 0 m c0 2 r 82 m 90 m 0 5 r 8 m 0 m 2 m c0 m 1 m 90 m 20 m 82 2 r 20 m c0
m 4 m 0 m 8 m 0 m 8 m 4 m 10 m 0 2 r 1 m 0 m 82 m 0 3 r 40 m 4 m 0 m 88 m 0 m 4 m 10 2 r 0 2 r 40 m 0 m 40 m 0 1d r 40 m 8 m 4
m 84 m 0 m 82 m 10 2 r 90 m 88 m 0 m 20 m 0 m 82 m c0 m 82 m 0 8 r 40 m 8 m 88 m 4 m 0 m 8 m c0 m 82 m 0 2 r 4 m 0 2 r c1 m 0
m 1 m 0 8 r 80 3 r 0 3 r 80 2 r 0 6 r 80 m 0 m 80 2 r 8 m 0 m 8 m 0 4 r 80 m 0 m 80 m 0 m 80 m 0 3 r 2 m 3 m 40 m 8 m 2 m 0 m
40 m 85 m 80 m 0 3 r 80 3 r 40 m 4 m 9 m 21 m 10 m 2 m 0 m 11 m 0 1a r 85 m 0 m 80 m 0 2 r 80 m 0 2 r 40 m 0 2 r 80 m 0 2 r
notbusy
02 wcmd 0 m 74 m 0 m \ 0x7400 
80 m 0 9 r 80 m 0 2 r 80 m 0 2 r 80 2 r 0 m 3 m 80 m 5 m 0 m 3 m 0 m 3 m 0 b r 41 m 80 m 0 3 r 80 m 0 7 r c1 m 0 m 82 m 40 m
88 m 82 m 90 m 11 m 80 m 0 2 r 8 m 0 2 r 80 m 0 m 2 m 80 m 9 m 0 m 5 m 2 2 r 40 m 80 m 0 m 80 m 21 m 0 m 4 m 0 m 80 m 10 m 80
m 9 m 0 m 40 m 0 m 2 m 5 m 0 1d r 10 m 80 m 85 m 0 m 80 m 0 2 r 80 m 21 m 80 2 r 0 c r 80 m 5 m 0 m 8 m 0 2 r c1 m 0 m 80 m 0
2 r 80 m 83 m 41 m 0 8 r 40 m 0 m a0 m 1 m 2 m 10 m 88 m 0 m 2 m 0 7 r 8 m 10 m 3 m 1 m 3 m 84 m c1 m 4 m 10 m 0 m 4 m 0 m c0
m 4 m 2 m 0 2 r 40 m 0 2 r 1 m 0 2 r 40 m 4 m 0 m 82 m 0 m 88 m 3 m c0 m 4 m 1 m c0 m 0 20 r 8 m 0 m 10 m 0 m 84 m 40 m 20 m 4
m 90 m 0 m notbusy
02 wcmd 0 m 75 m 0 m \ 0x7500 
20 m 0 m 84 m 10 m 82 m 84 m 0 8 r 10 m 0 m 40 m 0 m 90 m 89 m 90 m 0 m 21 m 0 m 4 m 40 m 0 m 82 m 83 m 0 4 r 2 m 0 4 r 40 2 r
0 m 10 m 0 m 4 m c0 m 8 m 0 m 10 m 0 m 88 m 0 m 10 m 0 m 10 m 20 m a0 m 0 m a1 m 0 m 82 2 r c1 m 8 m 4 m 0 m 20 m 0 m 2 m a1 m
82 m 0 4 r 5 m 0 3 r c0 m 4 m 0 m 88 m 0 m 4 m 2 m 40 m 0 4 r 4 m 0 1d r 10 2 r 0 m a0 m 0 m 84 m 21 m 20 m 90 m 40 m 0 m 88 m
0 m 82 m a0 m 82 m 0 8 r 90 m 40 m 0 m 8 m 20 m 90 m c0 m 82 m 0 4 r 1 m 0 m 2 2 r 0 d r 80 3 r 0 3 r 80 m 0 3 r 80 m 0 m 10 m
0 m 3 m 0 m 10 m 85 m 90 m 0 3 r 80 m 0 m 80 m 2 m 0 2 r 41 m 9 2 r 82 m 2 m 0 m 2 m 0 m 80 m 0 3 r 80 2 r 0 2 r 9 m 3 2 r 40
m 2 m 0 m 40 m 0 20 r notbusy
02 wcmd 0 m 76 m 0 m \ 0x7600 
4 m 0 12 r 80 m 0 4 r 80 m 0 5 r 41 m 0 m 83 m 80 m 0 9 r 5 m 80 m 21 m 0 m 80 2 r 0 4 r 20 m 0 4 r 82 m 0 m 10 m 40 m 10 m 0
m 5 2 r 0 m 8 m 80 m 83 m 80 3 r 0 m 3 m 0 m 9 m 0 m 2 m 0 m 2 2 r 80 m 0 2 r 2 m 80 2 r 0 2 r 11 m 80 m 40 m 0 m 11 m 0 m 20
m 5 m 0 9 r 2 m 0 11 r 4 m 80 m 82 m 0 6 r 80 m c0 m 0 f r 40 m 80 3 r 0 4 r 40 m 20 m 5 m 3 m 0 9 r 4 m 0 m 2 m 10 m 90 m 8 m
4 m 0 9 r c1 m 10 m 90 m a0 m 83 m 82 m 90 m 0 m 4 m 0 m 82 2 r 2 m 40 m 8 m 0 2 r 90 m 0 4 r 1 2 r 8 m 0 m 88 m 3 m 4 2 r 82
m 0 2 r 40 m 0 4 r 1 m 0 1b r a0 m 1 m notbusy
02 wcmd 0 m 77 m 0 m \ 0x7700 
20 m 83 m 10 2 r 90 m 0 m 84 m 0 m 2 m 8 m 82 3 r 0 9 r 8 m 0 m 8 2 r 2 m c0 m 4 m 0 5 r 1 3 r 0 d r b m 0 m 41 m 6 m 0 4 r b
m 0 6 r d0 m 43 m 0 7 r b m 0 6 r d0 m 0 8 r b m 0 6 r d0 m 0 2 r 82 m 0 1f r b m 0 7 r b m 0 2 r a m 0 c r b m 0 2 r 6 m 0 3
r c8 m 43 m 0 c r 10 m ff m fb m 0 m 8 m f7 m ff m 0 4 r aa 2 r fb m aa m fa 2 r 30 m 3f m ff m 3c m aa m f0 m aa m 3a m aa 2
r ff 3 r bf m 0 8 r 3c m 34 m 3c m 3e m 20 m 0 m ef m ff m 0 20 r notbusy
02 wcmd 0 m 78 m 0 m \ 0x7800 
0 3 r ff m 80 m bf m a2 m ae m 0 m ff m 8a m aa m ba m aa m f0 2 r f1 m f5 m 0 a r ff 2 r 30 m 0 m 3f m ff m 0 12 r ff 2 r 0 2
r ff 2 r 0 4 r aa 2 r 8 m aa m a 2 r 30 m 3f m 0 m 3c m aa m f0 m aa 4 r 0 3 r 80 m 0 8 r 3c 4 r 0 2 r ff 2 r 0 22 r 80 m bf m
80 m bf m 0 m ff m 0 m ff m 82 m aa m be m aa m f0 2 r b0 m a0 m 0 9 r 70 m ff m f2 m 10 m 0 m bf m ff m 0 m 10 m 0 2 r 54 m
a9 m 14 m a8 m 0 8 r f m 1f m f m b m df m ff 3 r 0 4 r 3c 4 r 3f m 30 m 5f 2 r 3c 2 r 55 2 r bf m 1 m ff m 0 m 7c m 2c m 3c 2
r 0 8 r 75 m 55 3 r f 4 r 0 1c r notbusy
02 wcmd 0 m 79 m 0 m \ 0x7900 
0 6 r df m 8 m ff m 0 m 55 2 r fd m 1 m ff 2 r 0 2 r d7 m 14 m 55 2 r 0 8 r ff 3 r f8 m 3c m 7d m 3c m 28 m 10 m 4 m 0 m 80 m
1 m 0 m 20 m 8 m 0 8 r f 4 r 8 m 0 7 r 3c 4 r 3f m 30 m 50 2 r ff m 0 m f 2 r ff m 0 m ff m 0 m 3c 4 r 0 8 r 45 m 55 3 r 1f m
f m b m f m 0 22 r df m 8 m df m 8 m 55 4 r f7 m d7 m 4 m 14 m d5 m 15 m 55 2 r 0 9 r 7 m 0 2 r 3c m 7c m 3c m 2c m 0 13 r 8 m
0 7 r 8 m 0 3 r 1 m 10 m 61 m 20 m 5 m 0 m 41 m 0 m 8 m 0 3 r 8 m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 5 r 61 m 0 m 1 m 0 m
1 m 0 12 r notbusy
02 wcmd 0 m 7a m 0 m \ 0x7a00 
0 d r 8 m 0 7 r 8 m 0 f r 8 m 0 24 r ff 2 r 0 m e m aa 2 r 2a m ea m 0 8 r fd 2 r 1 2 r 3c m 28 m 3c m 7d m 0 8 r 55 m 3c m 55
2 r 0 m 10 m ff m bf m 0 3c r 40 m 90 m 9a m 0 1b r ff m f1 m 0 2 r aa 2 r 28 m eb m 0 8 r ff m fd m 0 m 1 m 3c m 38 m 3c m 3d
m 0 8 r 55 m 35 m 55 2 r 0 m 14 m ff m be m 0 c r notbusy
02 wcmd 0 m 7b m 0 m \ 0x7b00 
0 32 r f m f0 m f m f1 m 0 1c r f0 4 r 0 8 r ff m 0 m ff m 0 m ff 2 r fe m be m 0 8 r ff m 0 m ff m 0 m 3c 2 r bf m 3c m 0 5e
r f0 2 r 3c m 78 m 0 8 r ff m e m f1 m 0 3 r 4 m 14 m 0 8 r ff m 7 m f8 m 0 m 3c 2 r 10 m 3c m 0 8 r notbusy
02 wcmd 0 m 7c m 0 m \ 0x7c00 
0 33 r 20 m 0 4 r 4 m 0 9 r ff 82 r 0 m 12 m eb m 37 m 30 m 22 m 0 m a m 0 2 r 50 m 60 m 0 2 r 24 m 90 m 0 e r 20 m 0 m 84 m 0
19 r 88 m 0 m notbusy
02 wcmd 0 m 7d m 0 m \ 0x7d00 
0 16 r 10 m 0 b r c0 m 0 m c0 m 0 7 r 82 m 0 3 r 4 m 0 e r 4 m 0 m 80 m 0 m 4 m 0 m 80 m 0 24 r 9 m 0 2c r 3 m 0 16 r 8 m 0 3
r 80 m 0 5 r 11 m 0 8 r 1 m 0 m 4 m 0 m 1 m 0 m 4 m 0 26 r 1 m 0 11 r notbusy
02 wcmd 0 m 7e m 0 m \ 0x7e00 
0 m 20 m 0 17 r 2 m 0 9 r 20 m 0 11 r 4 m 1 m 0 m 1 m 0 a r 20 7 r 0 3 r 10 m 0 11 r 82 m 0 6 r 41 m 0 8 r 8 m 4 m 0 2 r 8 m 0
3 r 40 m 0 m 40 m 0 9 r 1 m 0 b r 4 m 0 2 r 41 m 4 m 0 11 r 1 m 0 11 r 1 m 4 m 0 m 4 m 0 a r 1 m 80 m 1 m 80 m 1 m 80 m 1 m 0
3 r 1 m 0 11 r 2 m 0 2 r 88 m 0 6 r 41 m 0 14 r notbusy
02 wcmd 0 m 7f m 0 m \ 0x7f00 
0 5 r 11 m 0 m 20 m 0 m 21 m 0 m 21 m 0 3 r 11 m 0 7 r 9 m 40 m 4 m 1 m 20 m 0 6 r c0 m 80 m 0 5 r 20 m 84 m 20 m 40 m 0 14 r
11 m 0 m 20 m a0 m 4 m 0 3 r 2 m 0 m 11 m 0 13 r 4 m 0 2 r 41 m 0 3 r 41 m 0 2 r 88 m 3 m 0 m 21 m 0 2 r 82 m 0 3 r 2 m 0 m 84
m 0 m a0 m 0 m 88 m 0 m c0 m 0 7 r 2 m 0 3 r c0 m 0 m 1 m 0 d r 82 m 0 m 4 m 0 m 82 m 20 m 0 3 r 4 m 0 4 r 20 m 0 5 r 1 m 0 m
1 m 40 m 0 a r 88 m 40 m 0 2 r 2 m 0 2 r 8 m 0 3 r 20 m 1 m 0 m 1 m 0 7 r 88 m 0 10 r 8 m 0 2 r 11 m c0 m 0 4 r 80 m 1 m 4 m 1
m 0 m 1 m 3 m 88 m 20 m 1 m 20 m 90 m 20 m 0 m 80 m 0 m 20 m 40 m 20 m 4 m 0 m 4 m 0 m notbusy
20 wcmd 0 m 80 m 0 m notbusy \ 0x8000
02 wcmd 0 m 80 m 0 m \ 0x8000 
41 m 80 m 0 2 r 1 m 0 m 88 m 80 m 0 4 r a0 m 0 7 r 20 m 0 m 20 m 80 m a0 m 80 m 0 m 80 m 82 m 0 m 84 m 0 4 r 80 m 0 m 80 m 0 m
80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 3 r 80 m 0 2 r 1 m 0 m 89 m 0 2 r 20 m 0 m 4 m 0 m 2 m 0 m 84 m 0 m 84 m a0 2 r 0 m a0 m 0 m
a0 m 0 m a0 m 0 3 r 9 m 0 3 r 11 m 0 3 r 2 m 0 2 r 8 m 0 11 r 40 m 4 m 20 m 1 m 20 m 0 m 20 m 0 2 r 1 m 4 m 85 m 0 m 1 m 0 m
20 m 0 m 1 m 40 m 1 m 91 m 0 m 80 m 0 m 4 m 20 m 0 2 r 4 m 0 2 r 20 m 0 2 r 41 m 82 m 0 m 84 m 8 m 0 m 8 m 0 m 21 m 0 4 r 20 m
0 m 4 m 0 m 4 m 0 6 r 4 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 8 m 20 m 0 2 r 41 m 20 m 0 m 84 m 4 m 0 m 4 m 0 2 r 1 m 0 m
91 m 0 3 r 5 m 0 m 5 m 0 m 21 m 0 m 5 m 3 m 5 m 21 2 r 0 3 r 88 m 0 3 r 40 m 3 m 0 11 r 8 m 5 m 0 8 r 88 m 41 m 0 7 r 20 m 0 2
r 4 m 0 3 r notbusy
02 wcmd 0 m 81 m 0 m \ 0x8100 
0 3 r 21 m 0 3 r 20 m 82 m 5 m c0 m 0 3 r 4 m 0 4 r 20 m 90 m 20 m 0 m 20 m 0 m 20 m 88 m 0 m 20 m 0 m 20 m 0 m 88 m 4 m 84 m
0 3 r 5 m 0 m 84 m 20 m 84 m 0 m 84 m 20 m 0 2 r a0 m 0 3 r 88 m 0 3 r 84 m 0 m c0 m 0 m 84 m 0 m 90 m 40 m 0 m 4 5 r 0 m 4 m
0 2 r 90 m 0 m 88 m 4 m 0 2 r a0 m 0 2 r 11 m 8 m 0 15 r 40 m 2 m 0 m 90 m 9 m 0 5 r 3 m 0 m 3 m 0 m 8 m 0 m 9 m 5 m 0 2 r 80
m 0 5 r 8 m 0 m 3 m 0 2 r 1 m 0 6 r 80 m 0 2 r 4 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 1 m 3 m 0 m 80 m 0 m 80 m 0 7 r 4 m 0 2 r 1 m 0
3 r 1 m 0 13 r 10 m 80 m 10 m 90 m 0 2 r 1 m 0 4 r 21 m 1 m 0 2 r 5 m 0 m 11 m 90 m 5 m 0 17 r 82 m 3 m 1 m 0 2 r 9 m 0 c r
notbusy
02 wcmd 0 m 82 m 0 m \ 0x8200 
0 3 r 2 m 1 m 0 2 r a1 m 40 m 3 m 1 m 0 m 82 m 80 m 1 m 0 m 4 m 0 m 82 m 21 m 4 m 20 m 4 m 0 m 20 m 0 m 1 m 0 2 r 20 m 0 2 r
90 m 0 3 r 21 m 0 2 r 80 m 0 2 r c0 m 0 m 84 m 0 m a0 m 0 m c0 m 0 a r 80 m 0 4 r 84 m 0 m 4 2 r 5 m 0 3 r 10 m 0 m 2 m 82 m 2
m 84 m 2 m 4 m 2 m 9 m 1 m 0 16 r 21 m 0 8 r 20 m 0 2 r 2 m 0 5 r 2 m 0 a r 4 m 82 m 40 m 20 m 0 2 r 4 m 0 2 r 20 m 4 m 0 m a1
m 0 3 r 80 m 1 m 80 m 0 3 r 4 m 0 2 r 1 m 0 6 r a0 2 r 0 m 4 m 0 c r 8 m 0 6 r 20 m 0 3 r a0 m 0 2 r 89 m 83 m a0 m 0 6 r 4 m
0 m 21 m 0 m 1 m 0 2 r 20 m 0 2 r 88 m 8 m 0 m 10 m 90 m 0 a r 8 m 0 e r 1 m 89 m 0 m 83 m 0 3 r 90 m 88 m 0 m 8 m notbusy
02 wcmd 0 m 83 m 0 m \ 0x8300 
0 m 90 m 10 2 r 2 m 40 m 0 m 82 m 0 m a0 m 2 2 r 40 m 82 m 0 m 20 m 0 m 10 3 r 40 m 4 m 90 m 40 m 0 m 82 2 r 10 m 20 m 2 m 20
m 4 m 0 m 40 m 82 m 8 m 0 2 r 3 m 0 m 20 m 0 5 r 40 m 4 m 0 m 2 m 0 m 2 m 10 2 r 90 m 4 m 0 m 90 m 0 m 90 m 40 2 r 90 m 88 m 0
m 10 m 0 m 10 m 20 2 r c0 2 r 8 m 2 m a0 m 82 m c0 3 r 88 m 5 m 21 m 40 2 r a0 m a1 m 40 m 10 m 20 m a0 m 84 m 82 m 8 2 r 0 2
r 82 m 0 2 r 3 m 0 m 1 m 0 10 r 8 m 2 m 8 m 10 m 20 m 41 m 0 m 8 m 0 3 r 80 m 0 5 r 80 m 0 6 r a0 m 0 7 r 80 2 r 0 3 r 80 3 r
40 m 80 m 0 m 80 m 0 m 80 2 r 0 2 r 20 m 10 2 r 40 m 20 m 0 m 3 m 0 2 r a0 m 80 m 0 m 80 m 0 m 80 m 0 2 r 20 m 80 m 0 9 r 80 m
0 4 r a0 m 9 m a1 m 8 m 20 m 83 m 0 m 10 m a0 m 5 m 83 m 3 m c0 m c1 m 0 m 2 m 85 m 90 m 20 2 r 88 m c1 m 0 m 8 m 0 m 41 m 0 m
41 m 0 m 83 m 0 m 3 m 0 10 r 2 m 0 m 3 m 0 m 8 m 0 m 8 m 3 m notbusy
02 wcmd 0 m 84 m 0 m \ 0x8400 
0 2 r 80 m 10 m 0 4 r 80 m 0 2 r 2 m 0 m 2 m 0 4 r 80 m 10 m 0 m a0 m 0 2 r 80 m 0 2 r 40 m 80 m c0 m 0 4 r 80 m 8 m 0 m 80 m
0 2 r 20 m 0 m 10 m 0 m 8 m 0 m 2 m 3 m 0 5 r 10 m 80 m c0 m 0 2 r 80 m 0 2 r 5 m 80 2 r 0 4 r 80 m 20 m 0 m 80 m 0 2 r 11 m 0
m 3 m 10 m 83 m 80 m 82 m 10 m 20 m 0 m 3 2 r a0 m 80 m 2 m 3 m 11 m 0 m 20 m 8 m 85 m 20 m 8 m 90 m 41 m 8 m 0 3 r 83 2 r 9 m
0 10 r 1 m 90 m 1 m 0 m 1 m 0 2 r 11 m 20 m 0 m 82 m 0 m 90 2 r 8 m 10 m 8 m 0 m 82 m 1 m a0 m 88 m 8 m 0 m 82 m 0 m 82 m 0 m
88 m 40 m 20 m 82 m 4 m 0 m 40 m 0 m 82 m 10 m 40 m 0 m 40 m 0 m 4 m 0 m 88 m 40 m 20 m 0 2 r 20 m 1 m 0 m 1 m 0 2 r 1 m 0 2 r
20 m 0 m 20 m 1 m 2 m 40 m 10 m 0 m 2 m 0 m 90 m 0 m 2 m 40 m 82 m 0 m 20 m 0 m 10 m 0 m 10 2 r 88 m 0 m 2 m 90 m c0 m 0 m 84
m 10 m 8 m 88 m 90 m 20 m 91 m 1 m 40 2 r 83 m a1 m 90 m 88 m 20 m 1 m 20 m 90 2 r 5 m 21 m 1 m 82 m 0 2 r 83 2 r 0 12 r 1 2 r
0 m notbusy
02 wcmd 0 m 85 m 0 m \ 0x8500 
1 m 0 3 r 2 m 10 m 0 m 8 m 0 m 90 m 8 m 20 m 2 m 8 m 0 m 82 m 0 m a0 m 90 m 10 m 40 m 82 m 0 m 2 m 8 2 r 82 2 r 8 m 4 m 0 m 40
m 0 m 2 2 r 10 m a0 m 40 m 0 m 4 m 0 m 4 m 10 2 r 0 m 1 3 r 0 m 1 m 0 4 r 20 2 r 0 m 2 m 0 m 20 m 2 2 r 90 m 2 m 0 m 90 m 0 m
4 m 2 2 r 10 2 r 0 m 10 m 0 m 10 m 2 2 r 88 m c0 m 1 m 88 m 0 m 84 m 83 m 90 m c0 m 21 m 1 m 8 m 2 m 21 m 82 m 83 m 20 m c0 m
1 m 21 m 1 m 40 m 21 m 91 m 0 4 r 1 m 0 m a0 2 r 0 11 r 2 m 8 2 r 2 m 8 m 0 m 10 m 80 2 r 0 m 80 m 0 2 r 80 m 0 8 r 80 2 r 0 8
r 80 m 0 4 r 2 m 80 m 0 3 r 80 m 0 m 80 m 85 m 80 m 0 m 10 m 8 2 r 41 m 8 m 0 m 20 m 0 m 2 m 0 3 r 80 m 0 2 r c0 m 80 m 0 m 80
m 0 3 r 80 3 r 0 m 80 m 0 3 r 80 3 r 0 m 8 m 10 m 3 m 2 m 82 m 2 m 8 m 80 m 10 m 3 2 r 83 m 5 2 r 2 m 0 m 3 m 20 2 r 5 m 88 m
10 2 r 0 4 r 41 m 0 13 r notbusy
02 wcmd 0 m 86 m 0 m \ 0x8600 
2 m 20 m 10 m 0 m 41 m 0 m 8 2 r 0 2 r 80 m c0 m 0 2 r 80 m 0 4 r 20 m 0 6 r 80 m c0 m 0 4 r 80 m 0 m 80 m a0 m 80 m 0 3 r 80
m 0 m 80 m 88 m 0 2 r 80 m 0 m 10 m 90 m 8 m 20 m 3 m 0 m 10 m 3 m 0 4 r 80 m 82 m 0 7 r 40 m 0 2 r 80 m 0 m 80 m 0 2 r 20 m 0
4 r 8 m 0 m 90 m 82 m 2 m 0 m 5 m 8 m 90 m a0 m a1 m c0 m 5 m 0 m 2 m 5 m 20 2 r a1 m 88 m 8 m 0 m 3 m 41 m 0 3 r 20 m 3 m 20
2 r 0 11 r 1 m 8 m 0 6 r 90 m 0 m 8 2 r 10 m 88 m 8 m 0 m 90 m 0 m a0 m 88 2 r 2 2 r 0 m 82 m 0 m 8 m 40 m 8 m 10 m 82 m 0 m 4
m 0 m 2 m 82 m 84 m 88 m 20 m 0 m 4 m 0 m 4 m 82 m 8 2 r 10 m 0 m 1 m c1 m 1 m 0 m 1 m 0 m 1 2 r 0 2 r 20 m 0 m 2 m 83 m 10 m
20 m 40 m 0 m 90 m 0 m 88 2 r 40 2 r 4 m 0 m 10 m 0 m 10 m 2 m 20 2 r 8 m 0 m c0 m 8 m 83 2 r 90 2 r c0 m 0 m 41 m 2 m 82 2 r
89 m 8 m 83 m 0 m 20 m a1 m 20 2 r 8 2 r 90 m 1 m 0 4 r 1 2 r 0 e r notbusy
02 wcmd 0 m 87 m 0 m \ 0x8700 
0 7 r d0 m 0 8 r b m 0 7 r b m 0 7 r b m 0 7 r b m 0 7 r b m 0 6 r d0 m 0 2 r 60 m 0 7 r b m 0 7 r b m 0 7 r b m 0 6 r d0 m b
m 0 m 42 m 0 4 r d0 m b m 0 m 84 m 0 4 r d0 m b m 0 2 r 6 m 0 3 r c8 m 43 m 0 1b r ff 2 r f9 m fd m 66 4 r f6 m ff m 90 m 0 m
bc m 3c m 2c m 3c m ff m ef m ff 2 r f0 4 r 7e m 42 m ff m 0 m 66 4 r ff 2 r 6 m 2 m ff m 10 m ff m 18 m 0 a r 3e m 3c 3 r 66
5 r 36 m 66 2 r bc m 2c m 3c 6 r ff m 0 m e7 m 24 m 66 m 7f m 66 3 r 72 m 66 m 72 m f0 m fc m f0 m c0 m f9 m 60 m f0 2 r 3c 2
r 6c m 3c m 6c m 66 m 6c 2 r 0 10 r notbusy
02 wcmd 0 m 88 m 0 m \ 0x8800 
0 10 r 6 m 2 m 0 2 r f7 m 66 m 4 m 66 m fe m ff m 80 m 0 m bd m 3c m 24 m 3c m 0 m 20 m 0 2 r e4 m f0 3 r fe m 2 m ff m 0 m 76
m 7e m 46 m 42 m f9 m fd m 0 2 r ef m 0 m e7 m 0 b r 38 m 3c 3 r 76 m 46 m 66 6 r 3c 4 r 6c m 66 m 3c 2 r ff m 0 m f7 m 4 m 66
m 40 m 66 5 r 72 m f0 m f8 m f0 m e0 m f1 m 70 m f0 2 r 3c 2 r 6c 2 r 66 4 r 0 m 10 m 0 2 r 54 m a9 m 14 m a8 m 0 7a r 10 m 4
m 0 m 80 m 1 m 0 m 20 m 8 m 0 4 r notbusy
02 wcmd 0 m 89 m 0 m \ 0x8900 
0 14 r 1 m 3 m ff 3 r 3f m ff m bf m 66 4 r 0 m 8 m ff m fe m f 2 r d m 4f m 0 m ff m 0 m ff 3 r 7f m 3f m 1c m 0 m ff 2 r 1 m
3 m ff 2 r 66 4 r 0 b r 2 m fd m ff m 66 m 6e m 66 2 r f 4 r 0 m f7 m 8 m ff 2 r 67 m ff 2 r 2 2 r fe 2 r f 2 r 7 m 1f m 3c 2
r 34 m 3d m 0 2 r ff 4 r 7e m fe m ef 2 r ff m ef m c m fc m 1c m 7c m 0 22 r fe m fc m 0 m 30 m 0 m 20 m 64 m 60 m 67 m 6f m
0 m 18 m ff m 7e m f 4 r 0 m fb m 4 m ff m 0 2 r 10 m 30 m 0 2 r e3 m ff m 0 2 r fe m fc m 42 m 62 m 7e m 6e m 0 c r ff 2 r 66
m 62 m 66 2 r f m b m f m 2f m 0 m ff m 0 m ff m 0 3 r 98 m 2 m 0 m fe m ff m f 2 r 6 m 9f m 34 m 3d m 34 m 3d m 0 m 64 m 9b m
ff m 0 2 r 18 m 8 m 20 2 r 0 m 20 m 3c 4 r 0 8 r notbusy
02 wcmd 0 m 8a m 0 m \ 0x8a00 
0 11 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 7 r 8 m 0 7 r 8 m 0
7 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 4 r 40 m 90 m 9a m 0 13 r ff m 0 m
ff m 0 3 r ff 2 r 0 28 r ff m fe m ff 2 r 0 m ff m 8 m fd m 0 1a r ff m 0 m 57 m 54 m aa 2 r eb m ea m ff m 30 m ff m 20 m 3c
2 r f0 m 3c 3 r 35 m 3c m aa 4 r 0 4 r notbusy
02 wcmd 0 m 8b m 0 m \ 0x8b00 
f m f0 m f m f1 m 0 10 r ef m 4 m ff m 0 2 r 20 m ff m f7 m 0 29 r 4 m 0 3 r ff m 0 m ff m 0 1a r ff m 0 m ff m 0 m aa 2 r 28
m 2a m cf m 0 m df m 0 m 3c 2 r 78 m 3c 3 r 35 2 r aa m 3c m aa m 3a m 0 18 r df m 8 m ff m 0 m f0 2 r f8 m f0 m 0 28 r fd m 8
m ff m 0 m 20 m 0 m ff 2 r 0 1a r ff m f7 m 0 m 4 m f0 4 r ff 2 r d7 m df m 0 m ff m 51 m ff m f m 1f m f m b m 0 m ff m a m
fa m notbusy
02 wcmd 0 m 8c m 0 m \ 0x8c00 
0 m 20 m 0 4 r 4 m 0 11 r ff m 0 m ff m 0 m f0 2 r d0 m f0 m 0 28 r ff m 0 m ff m 0 3 r df m ff m 0 1a r ff m d7 m 0 m 14 m 78
2 r f0 m 78 m 28 m 20 m 0 3 r ff m 0 m ae m f m 3f m f m 3 m 0 m ff m 2 m fe m 0 12 r 20 m 0 d r 84 m 0 f r 4 m 0 m 5 m 0 3 r
4 m 0 5 r 82 m 0 d r 84 m 0 9 r 20 m 0 m 40 m 0 3 r 85 m 0 3 r 20 m 0 m 1 m 0 3 r 84 m 0 3 r a0 m 0 15 r notbusy
02 wcmd 0 m 8d m 0 m \ 0x8d00 
0 36 r 4 m 0 1e r 3 m 0 4 r 40 m 0 3 r 4 m 0 3 r 41 m 0 m 4 m 0 14 r c0 m 0 31 r 21 m 0 17 r 8 m 0 2 r 1 m 0 m 20 m 0 m 20 m 0
m 20 m 0 e r 4 m 0 14 r 8 m 0 3 r 84 m 0 3 r 20 m 0 m 20 m 0 3 r 20 m 0 m notbusy
02 wcmd 0 m 8e m 0 m \ 0x8e00 
4 m 0 m 4 m 41 m 4 m 0 m 82 m 0 6 r 20 m 0 m 20 m 4 m 0 m 4 m 0 2 r a0 m 4 m 80 m 0 2 r 5 m 0 6 r 8 m 0 3 r 4 m 0 m 8 m 0 m 84
m 0 5 r 8 m 40 m 8 m 0 m 8 m 0 3 r 8 m 0 4 r 9 m 0 2 r 8 m 0 m 8 m 0 m 8 m 0 m 84 m 0 m 4 m 20 m 0 m 80 m 0 m 80 m 0 m 80 m 8
m 0 m 84 m 5 m 84 m 0 3 r 4 m 0 5 r 1 m 0 3 r 8 m 0 m 8 m 0 m 8 m 41 m 4 m 0 m 10 m 0 7 r 10 m 0 8 r 80 m 0 m 80 m 0 3 r 80 m
10 m 80 m 4 m 80 m 4 m 80 m 4 m 0 7 r 1 m 0 m 1 m 80 m 0 m 80 m 0 2 r 21 m 80 m 20 m 0 4 r 1 m 3 m 0 m 20 m 0 7 r 11 m 0 m 80
m 0 m 80 m 2 m 80 m 0 m 80 m 1 m 4 m c1 m 0 m 1 m 4 m 1 m 0 2 r 3 m 0 2 r 40 m 0 2 r 21 m 0 m 80 m 0 m 80 m 0 m 21 m 0 m 41 m
0 4 r c0 m 5 m 0 m 3 m 0 4 r 1 m 21 m 1 m 0 c r 40 m 0 m 40 m 90 m 9 m 0 2 r a0 m 0 9 r 1 m 0 m 1 m 0 3 r 4 m 0 2 r 2 m
notbusy
02 wcmd 0 m 8f m 0 m \ 0x8f00 
0 4 r 20 m 0 m 84 m 89 m c0 m 20 m 0 m 80 m 0 m 20 m 0 7 r 20 m 0 8 r 5 m 0 m 4 m 0 2 r 3 m 9 m 0 4 r 8 m 9 m 0 2 r 20 m 0 m
20 m 3 m 20 m 0 m 20 m 4 m 90 m 4 m 0 m 4 m 88 m 4 m 0 5 r 3 m 0 3 r 2 m 4 m 41 m 4 m 0 m a0 m 21 m 0 m 8 m 0 3 r 41 m 0 m 5 m
0 m 21 m 0 m 41 m 0 m 4 m 0 m 4 m 0 3 r 21 m c0 m 0 2 r 5 m 0 m 8 m 0 m 41 m 0 m 40 m 0 m 5 m 88 m 5 m 0 m 2 m 0 3 r 3 m 0 3 r
9 m 88 m 4 m a0 m 4 m 0 3 r 5 m 84 m 5 m 0 m 10 m 4 m 9 m c0 m c1 m 0 2 r 4 m 8 m 1 m 0 m 4 m 21 m 1 m 0 m 84 m 0 5 r 1 m 0 6
r 1 m 0 m 4 m 80 m 82 m 0 m 4 m 0 2 r 20 m 0 4 r 84 m 0 m 8 m 0 3 r 82 m 0 3 r 84 m 0 3 r 90 m 0 3 r 82 m 0 m 8 m 2 m 40 m 0 3
r 82 m 0 5 r 84 m 80 m 0 8 r 82 m 0 m 4 m 0 7 r 20 m 80 m 0 2 r 84 m 80 m 0 m 80 m 90 m 0 m 4 m 0 m a0 m 0 3 r 1 m 80 m 0 3 r
80 m 0 3 r 9 m 8 m 0 2 r 21 m 0 2 r notbusy
20 wcmd 0 m 90 m 0 m notbusy \ 0x9000
02 wcmd 0 m 90 m 0 m \ 0x9000 
0 m 20 m 85 m 0 m 4 3 r 0 3 r 82 m 0 m 40 m 0 m 84 m 80 m 0 10 r 4 m c0 2 r 20 m 3 m 0 m 80 m 8 m 0 m 1 m 41 m 0 m 9 m 8 m 0 2
r 40 m 0 6 r 2 m 21 m 90 m 0 m 88 m 0 7 r 2 m 0 b r 4 m 8 m 88 m 0 8 r c0 m 88 m 0 6 r 88 m 4 m 0 2 r 10 m 4 m 0 m 4 m 0 2 r
80 m 0 2 r 8 m 0 2 r 4 m 20 m 9 m 2 m 0 m 20 m 21 m 0 7 r 5 m 0 m 41 m 1 m 4 m 0 m 80 m 1 m 80 m 0 6 r 82 m 0 m 20 m 0 11 r 20
m 0 m 2 m 82 m 0 4 r 2 m 0 m 8 m 0 m 2 m 84 m 11 m 4 m 40 m 0 2 r c0 m 11 m 4 m 0 2 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 4 r 4
m 21 m 0 m 21 m 82 m 0 m 20 m 0 m 20 m 0 m 84 m 8 m 0 2 r 4 m 0 m c1 m 20 m 84 m 20 m c0 m 0 m 1 m 0 2 r 21 m 84 m 0 5 r 40 m
41 m 20 m 0 m 20 m 0 2 r 20 m 0 2 r 89 m 0 2 r 20 m 0 2 r 4 m 0 3 r 4 m 41 m 0 2 r 8 m 0 m notbusy
02 wcmd 0 m 91 m 0 m \ 0x9100 
84 m 0 m 40 m 0 m 4 m 0 m 8 m 0 m c0 m 2 m 40 m 0 m a0 m 0 m 10 m 0 m 90 m 91 m 4 m 0 m 4 m 20 m 8 m 20 m c0 m 20 m 84 m 4 m 0
9 r 1 m 0 8 r 11 m 0 2 r 8 m 5 m 0 m 91 m 0 m 2 2 r 0 2 r a0 m 90 m 11 m 1 m 0 m 1 m 9 m 89 m 0 m 89 m 0 4 r 80 m 88 m 0 2 r 2
m 84 m 80 m 0 m 80 m 0 2 r c0 m 0 2 r c1 m 0 m 4 m 3 m 0 m 1 m 3 m 0 m 4 m 0 2 r a0 m 21 m 84 m 0 2 r 21 m 0 3 r 80 m 0 m c1 m
0 m 3 m 1 m 3 m 0 m 4 m 88 m 11 m 1 m 0 m 84 m 80 m a0 m 0 2 r 85 m 2 m 40 m 0 m 3 m 88 m 11 m 8 m 9 m 8 m c1 m 20 m 9 m 90 m
4 m 20 m 21 m 88 m 0 m 90 m 5 m 88 m 11 m 4 m 21 m 0 2 r 1 m 0 m 1 m 0 m 1 m 41 m 0 c r 10 m 0 m 20 m 0 3 r 80 m 1 m 0 m 1 m 0
m 91 m 0 m 40 m 0 m 4 m 0 m 4 m 0 4 r 3 m 0 3 r 21 m 0 2 r 90 m 80 m 1 m 0 m 90 m 82 m 5 m 11 m 20 m 0 5 r 20 m 0 m 4 m 20 m 0
m 20 m 0 2 r 4 m 0 m 4 m 11 m 0 3 r 21 m 0 6 r 20 m 0 m 10 m 0 2 r 41 m 90 m 0 2 r 20 m 0 m 20 m 84 m 0 3 r 1 m 0 m 1 m 41 m
89 m 0 m notbusy
02 wcmd 0 m 92 m 0 m \ 0x9200 
0 m 20 m 0 3 r 2 m 4 m 0 m 10 m 0 m 84 m 91 m 84 m 11 m 10 m 80 m 8 m 21 m 0 m 3 m 88 m 3 m c0 m 3 m 0 6 r 8 m 0 4 r 20 m 0 8
r 3 m 1 m 0 3 r 20 m 4 m 0 m 4 m 0 m 4 m c0 m 40 m 0 m 83 m 0 m 80 m 0 m 3 m 0 3 r 40 m 0 6 r 20 m 4 m 2 m 0 m 20 m 84 m 0 m
80 m 0 5 r 80 m 0 2 r 1 m 0 m 1 m 0 2 r 80 m 0 m 80 m 0 b r 80 m 0 8 r 1 m 0 m 1 m 0 4 r 4 m 2 m 4 m 84 m 4 m 0 m 41 m 1 m 40
m 0 m 41 m 0 m 80 m 0 m 41 m a0 m 0 m 20 m 8 m 0 m 10 m 20 m 0 m 82 m 10 m 0 3 r 10 m 0 5 r 3 m 0 6 r 1 m 0 4 r 10 m 2 m 82 m
10 m 0 m 82 m 10 m 82 m 2 m 10 m 0 m 4 m 0 m 10 m 90 m 10 m 83 m 20 m 0 m 82 m 0 m 40 m 2 m 10 m 20 2 r 0 m 4 m 0 m 84 m 8 m
c0 m 41 m 88 m 0 m 82 m 0 m 82 m 10 2 r 0 4 r 2 m 0 2 r 1 m 88 m 2 m 0 m 4 m 1 m 40 m 2 2 r 90 2 r 0 m 4 m 0 m 84 m 40 m 10 m
0 3 r 1 m 0 m 1 m 84 m 1 m 0 m 1 m 2 2 r 0 m 4 m 0 m 10 m 20 2 r 4 2 r 0 m 82 m notbusy
02 wcmd 0 m 93 m 0 m \ 0x9300 
0 m 10 2 r 8 m 40 2 r c0 m 4 m 0 m 8 m 4 m a0 m c0 m 10 m 20 m 4 m 84 m 82 m 8 2 r 10 m 91 m 84 m 82 m c0 m c1 m 88 m 82 m 40
m 20 m 0 m 40 m 0 m 4 m 8 m 20 m 2 m a0 m 0 m 40 m 0 m 2 m 4 2 r 0 m 80 m 0 m 80 m 0 3 r 80 m 0 5 r 80 m 0 2 r 2 m 0 4 r 80 m
0 m 80 m 20 m 0 2 r 80 m 0 m 80 2 r 0 m 90 m 0 7 r 40 m 9 m 11 m 21 m 40 m 2 m 0 m 20 m 0 m 80 m 0 2 r 10 m 0 m 80 2 r 40 m 0
4 r 80 m 0 m 80 m 0 3 r 10 m 11 m 10 m a0 m 5 m 0 m 10 m 80 2 r 0 m 80 m 0 4 r a0 m 0 7 r 80 2 r 0 3 r 80 2 r 0 m 80 2 r 4 m
20 m a0 m 90 m 0 m 20 m 80 m 10 m 5 m 85 m 5 m 3 m 0 2 r 80 m 0 4 r 80 m 0 2 r 80 m 0 4 r 80 3 r 0 3 r 2 m 0 m 80 m 0 4 r 80 m
10 m 80 2 r 0 2 r 80 m 0 m 80 m 10 m 80 2 r 0 4 r 80 m 21 m 80 2 r 0 5 r 20 m 80 m 8 m 0 2 r 40 m 0 m 41 m 0 m 5 m 2 3 r 80 m
40 m 80 m 4 m 80 m a0 m 80 2 r 0 2 r 80 m 4 m 80 3 r 0 3 r 10 m 0 m 3 m 0 m 9 m 0 m 8 2 r 80 m 0 m 80 m 4 m 0 4 r notbusy
02 wcmd 0 m 94 m 0 m \ 0x9400 
80 m 0 2 r 2 m 0 m 80 m 0 4 r 80 m 41 m 0 m 8 m 80 m 0 m 11 m 0 m 10 m 3 m 4 m 0 m 20 m 10 2 r 0 m 85 m 3 m 88 m 80 m 40 m 41
m 0 3 r 10 m 80 m c0 m 0 5 r 40 m 80 m 0 m 80 m 0 m 2 m 0 m 82 m 1 m 10 2 r 88 m 0 m 90 m 0 m 82 m 1 m 10 m c0 m 88 m 2 m 8 m
0 m 10 m 1 m 40 m 10 m 82 m 0 m 20 m 0 m 10 m 0 m 8 m 84 m 40 2 r 2 m 0 m 82 m 0 m 40 m 5 m 10 m 0 2 r 40 m 0 2 r 1 2 r 0 m a0
m 8 m 0 m 82 m 0 m 2 3 r 4 m 40 m 0 m 2 m 0 m 2 m 40 m 8 m 2 m 0 2 r 1 m 90 m 1 m 0 4 r 10 m 2 m 0 m 10 m 0 m 88 2 r 20 m 0 m
4 m 0 m 4 m 1 m 8 m 40 m 8 m 0 m 40 m 0 m 40 m 0 m 88 2 r 82 m 0 m 10 m 0 m 21 m 1 m 88 m 4 m 10 2 r 91 m 20 m 2 m 1 m 85 m 2
m 9 m 21 m 90 m 0 m 40 m 1 m 4 2 r 40 m 0 m 90 m 0 m 40 m 0 m 2 m 90 m 4 m 0 m 88 m 2 m 0 m 82 m 0 m 82 m 10 2 r 88 m 40 m 0 m
10 2 r c0 m 10 2 r c0 m 20 m 0 m 2 m 0 m 82 m 2 m 10 m 4 2 r 0 m 40 m 4 m 2 m 10 m 40 m 10 m 40 m 0 m 82 m 4 m 82 m 10 2 r 0 2
r 1 2 r 0 3 r 1 m c0 m 2 m 40 m 2 m 0 m 40 m c1 m 10 m 40 2 r 0 m 40 m 4 m 2 m 40 m c0 m 0 3 r 1 m 0 2 r 90 m 0 2 r 1 m 88 m 2
m 0 m 10 m notbusy
02 wcmd 0 m 95 m 0 m \ 0x9500 
0 m 8 m 10 2 r 2 m 4 m 0 m 88 m 0 m 8 m 82 m 90 2 r 40 m 0 m 88 m 0 m 4 m 2 m a0 m 88 m 90 m 0 m 4 m 0 m 40 m c0 m 8 2 r 90 m
1 m 9 m 1 m c1 m 2 m 21 m 2 2 r 0 m 40 m 0 m 4 m 90 m 20 m 8 m 2 m 0 m 2 2 r 20 m 40 2 r 0 m 80 m 0 5 r 80 m 0 m 80 m 0 m 80 m
0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 3 r 80 3 r 0 m 80 2 r 0 m 84 m 0 2 r 80 m 0 7 r 40 m 3 2 r 41 m 5 m 20 2 r 80 2 r 0 m 80 m 0
2 r 82 m 80 m 0 3 r 80 m 0 2 r 4 m 0 4 r 10 m 11 m 3 m 8 2 r 0 m 10 m 0 m 80 m 0 3 r 80 m 0 2 r 80 m 0 d r 84 m 0 2 r 8 m 4 m
20 m 10 m 88 m 80 2 r 0 2 r 8 2 r 40 m 20 m 80 m 20 m 80 2 r 0 3 r 80 m 0 3 r 80 m 0 m 80 2 r 0 3 r 80 m 0 2 r c0 m 0 4 r 80 m
0 m 80 m 40 m 0 5 r 10 m 80 m c0 m 80 3 r 0 m 80 m 4 m 80 m a0 m 80 3 r 0 2 r 10 m 0 m c0 m 0 4 r 5 m 82 m 3 m 9 m 20 m 0 m 3
m 11 m 80 m 0 2 r 2 m 80 2 r 0 2 r 80 m 2 m 80 m a1 m 0 6 r 41 m 0 m 9 m 0 m 10 m 0 m 10 m 20 m notbusy
02 wcmd 0 m 96 m 0 m \ 0x9600 
0 3 r 20 m 0 m 80 m 0 3 r 10 m 80 m 84 m 0 6 r 80 m c0 m 0 2 r 80 m 0 m 3 m 20 m 84 m 20 m 8 m 0 m 20 m 0 m c0 m 20 m 8 m 21 m
40 m 0 2 r 4 m 0 m 3 m 80 m a0 m 0 2 r 80 m 0 3 r 80 m c0 m 0 2 r 80 m 0 m 10 m 0 m 10 m 2 m 82 2 r 40 m 0 m 40 m 0 m 10 m 4 m
c0 m 10 m 8 m 0 m 82 m 1 m 2 m 3 m 8 m 40 m 4 m 0 m 4 m 0 m 20 m 3 m 2 m 84 m 10 m 0 m 90 m 1 m 82 m 20 m 82 2 r 88 m 0 2 r c1
m 1 m 0 m 1 m 0 m 1 m 0 m 4 m 0 m 40 m 41 m 8 2 r 40 m 0 m 2 m 1 m 2 m 82 m 2 2 r 88 m 0 4 r 20 m 0 2 r 1 m 0 3 r 8 m 0 m 10 2
r 20 m c0 m 40 m 0 m 4 m 0 m 20 m c1 m 8 m 10 m 90 m 0 m 4 m 0 m 8 m 82 m a0 2 r 2 m 0 m 20 2 r 8 m 4 m 8 3 r 0 m 11 m 1 m 21
m 20 m c1 m c0 m 8 m 1 m 40 m 0 m 20 4 r 4 m 0 m 82 m 0 m 2 m 40 3 r 4 m 0 5 r b m 0 7 r b m 0 2 r 82 m 0 4 r b m 0 m 60 m 0 5
r b m 0 7 r b m 0 6 r d0 m 0 2 r 84 m 0 4 r d0 m b m 0 m 60 m 12 m 0 4 r b m 0 8 r d0 m notbusy
02 wcmd 0 m 97 m 0 m \ 0x9700 
0 8 r b m 0 2 r 6 m 0 4 r b m 0 m 41 m 0 5 r b m 0 6 r d0 m b m 0 m 88 m 12 m 0 3 r d0 m b m 0 2 r a m 0 4 r b m 0 7 r b m 0 3
r ac m 3c m ac m 3c 2 r 7d m 3c m 7c m ff m be m ff m bf 2 r af m ff 2 r aa 3 r ac m 0 2 r ff 2 r 0 m ff m 80 m fd m ff 2 r f7
m ff m aa m 3a m aa 2 r 3c m ac m 3c 2 r 0 8 r ff m f7 m ff 2 r aa m 3a m aa 2 r ff 3 r fd m d0 m f0 m f8 m f0 m 0 a r 3c m fd
m 3c 2 r 2c m 7c m 2c m 7c m aa 2 r a0 m af m 20 m 0 m f7 m ff m 0 2 r ff 4 r ea m ff m 1c m bc m 3c 2 r 8 m 3c m fd m 3c m 1c
m 3c m bc m 3c m fb 2 r ff m fb m fc m bc m 3c 2 r aa 2 r ab m af m 0 m 82 m ff m be m 0 m ff m 0 m ff m ac m 3c 4 r 28 m 3c m
2c m 0 m 14 m 0 m 10 m 80 m a0 m 0 2 r aa 4 r 0 m 20 m df m ff m 0 m ff m 0 m ff m 0 2 r 20 m 0 m 3a 2 r aa 2 r 3c m aa m 3c 2
r 0 b r 8 m aa 4 r 0 3 r 8 m f0 4 r 0 2 r notbusy
02 wcmd 0 m 98 m 0 m \ 0x9800 
0 8 r 3c m 8 m 3c 2 r 2c m 7c m 3c 2 r aa 2 r a8 m ab m 30 m 0 m f3 m ff m 0 m 70 m 8f m ff m 0 3 r 15 m c m fc m 3c 6 r 14 m
3c m be m 3c m 8 2 r 0 m 8 m c m 1c m 3c 2 r aa 2 r a8 m a0 m 0 m 2 m ff m fe m 30 m 3f m 20 m 7f m ff 2 r 8 m a m 55 m df m
55 m 10 m ff 2 r f5 m fd m 3c 2 r 2d m 3c m 3e m 34 m 3c 2 r 4f m f m e m f m 3e m 34 m 3c 2 r df m ff 5 r f5 m fd m 3e m 34 m
be m 14 m 0 8 r ff m 8 m f7 m 0 m 3c 4 r bf m 10 m ff m 0 m 55 4 r 0 a r ff m 0 m ff m e m bf 2 r ff m bf m 3f m 7f m ff 3 r 0
m f7 m 4 m f 2 r 1f m b m 75 m f5 m 45 m 5 m df m ff m df 2 r 7c m 2c m fc m c m fd m 7d m ff 2 r df 2 r 8 2 r 55 m 5d m 55 m
51 m 3f m 7f m 30 m 20 m ff 2 r 3 m 2 m 3c 2 r 35 m 3c m f7 m f5 m 0 2 r 55 4 r 0 2 r 5 m 1 m 3c 2 r f m 3c 5 r f 4 r 3c 4 r
10 m 0 3 r a m 2 m 0 2 r 3c 4 r 0 8 r ff m 0 m ff m 0 m 2d m 3c 3 r ff m 0 m ff m 0 m 5d m 55 m notbusy
02 wcmd 0 m 99 m 0 m \ 0x9900 
51 m 55 m 0 a r ff m 0 m f1 m 0 m 1 2 r 0 m 1 m 3 m 2 m 0 2 r ff m 0 m f5 m 5 m f 2 r 3f m 3 m 55 4 r 10 m 0 m 10 2 r 3c 4 r 1
m 41 m 0 2 r ff m df m 0 m 8 m 55 m 7d m 55 m 41 m ff 2 r 0 2 r fc m fd m 0 2 r 3c 2 r 55 m 3c m 0 3 r 8 m 0 7 r 8 m 0 7 r 8 m
0 7 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 3 r 61 m 0 m f m 0 m d m 0 5 r 8 m 0 7 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 7 r
8 m 0 7 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 5 r 8 m 0 7 r 8 m 0 2c r 3c 4 r ff 2 r ef m ff m 0 a r
notbusy
02 wcmd 0 m 9a m 0 m \ 0x9a00 
0 8 r ff 2 r 0 2 r fa m f0 m f8 m f0 m 0 18 r fc m ff m 0 2 r 3c m 30 m 3c m 30 m ff 2 r a m aa m 0 2 r ff 2 r 0 38 r 3d m 3c
m 38 m 3c m 0 3 r 10 m 0 12 r ff m cb m 34 m 0 m 50 m f0 m d0 m f0 m 0 18 r fc 2 r 0 2 r 3c m 38 m 3c m 38 m ff 2 r 0 3 r af m
ff 2 r 0 38 r ff 2 r 10 m 0 m aa m b2 m aa 2 r 0 6 r notbusy
02 wcmd 0 m 9b m 0 m \ 0x9b00 
0 c r ff m 0 m ff m 0 m 8f m ff 3 r 0 18 r f m 1f m f m 1f m f0 4 r f m 0 m f 2 r a2 m aa m a2 2 r 0 38 r ef m ff m 0 2 r aa 4
r 0 12 r f5 m 5 m fd m 1 m 0 m 70 m 0 1a r f m 3f m f m 3f m f0 2 r f3 m ff m f m 5 m f 2 r a2 m aa m a2 2 r 0 10 r 88 m 0 5 r
8 m 0 8 r 4 m 0 2 r 20 m 0 3 r 20 m 0 9 r 20 m 0 11 r notbusy
02 wcmd 0 m 9c m 0 m \ 0x9c00 
0 10 r 20 m 0 4 r 9 m 0 2 r 84 m 8 m 0 1b r 2 m 0 3 r 2 m 0 3 r 80 m 0 18 r 80 m 0 16 r 40 m 0 23 r 3 m 0 e r 41 m 8 m 0 e r 9
m 0 e r 2 m 0 19 r 80 m 0 10 r 84 m 0 15 r notbusy
02 wcmd 0 m 9d m 0 m \ 0x9d00 
0 13 r 2 m 1 m 0 5 r 1 m 0 f r 82 m 0 3 r 84 m 0 m 1 m 0 c r 80 m 0 m 20 m 0 m 82 2 r a0 m 0 13 r 8 m 0 3 r 10 m 0 7 r 8 m 0 5
r 8 m 0 d r 8 m 0 8 r 40 m 0 m 40 m 4 m 0 5 r 8 m 20 m 0 b r 4 m 0 2 r 8 m 0 2 r 4 m 0 e r 4 m 0 6 r 20 m 0 6 r 10 m 0 5 r 4 m
0 m 1 m 0 m 3 m 0 m 3 m 0 12 r 2 m 0 m 4 m 0 m 1 m 0 m 82 m 0 m a0 m 0 m c0 m 0 m a0 m 0 m a0 m 83 m 0 m 20 m 0 2 r 90 m 20 m
0 2 r c0 m 80 m 0 m 80 m a0 m 40 m 0 6 r 8 m 0 3 r notbusy
02 wcmd 0 m 9e m 0 m \ 0x9e00 
82 m 0 3 r 82 m 2 m 0 2 r 82 m 0 m 82 m 0 m 91 m 0 5 r 84 m 4 m 40 m 0 b r 1 m 0 5 r 84 m 0 9 r 20 m 80 m 84 m 80 m 20 m 2 m
88 m 91 m 88 m 0 3 r 4 m 0 m 4 m 0 5 r 82 2 r 84 m 0 13 r 80 m 0 m 80 m 0 m 8 m 84 m 11 m 0 2 r 82 m 0 m 84 m 0 m a0 m 21 m 20
m 0 m 1 m 0 m 88 m 0 m 91 m 0 2 r 9 m 20 m 0 m 20 m 0 8 r 8 m 0 2 r c0 m 0 2 r 3 m a0 m 3 m 2 m 0 6 r 4 m 0 3 r 41 m 0 m 5 m 4
m 0 4 r 5 m 0 3 r 21 m 0 m 3 m 0 m 20 m 0 4 r a0 m 2 m a0 m 0 3 r 88 m 41 m 0 m 3 m 82 m c1 m 20 m 5 m 20 m 85 m 4 m 3 m 4 m 5
m 0 m 4 m 0 m 85 m 0 m c0 m 90 m 41 m 0 2 r 20 m 3 2 r 5 m 0 5 r 21 m 0 13 r 40 m 0 2 r 2 m 40 m 0 3 r 20 m 0 2 r 2 m a0 m 0 5
r 20 m 0 m 8 m 0 m 10 m 0 3 r 88 m 0 m 82 m 0 m notbusy
02 wcmd 0 m 9f m 0 m \ 0x9f00 
0 3 r 80 m 0 m 80 m 0 2 r 82 m 0 m 4 m 0 m 4 m 0 m 82 m 0 m 84 m 0 m 40 m 0 5 r 82 m 0 4 r 80 m 0 2 r 82 m a0 m 82 m 0 m 82 m
80 m 0 m 80 m 0 m 80 m 82 m 0 5 r 82 m 0 m 82 m 0 m 20 m 0 3 r 84 m 0 m 82 m 0 m 20 m 80 m 0 m 80 m 88 m 0 m 20 m 9 m 0 m 82 m
0 3 r 80 m 4 m 80 m 0 11 r a0 m 11 m 0 5 r 11 m 40 m 11 m 82 m 11 m 0 2 r a0 m 0 m 82 m 21 m 4 m 0 7 r c0 m 0 d r 4 m 0 m 4 m
0 4 r 80 m 0 m 80 m 0 m 3 m 0 3 r 40 m 0 m 21 m 0 m 5 m 0 6 r 20 m 0 m 2 m 0 m 21 m 0 3 r 4 m 0 m 4 m 0 m 4 m 0 8 r 3 m 0 m 91
m 10 m 0 m 10 m 21 m 10 m 0 2 r 89 m 20 m 11 m 4 m 21 m 88 m 83 m c0 m 0 m 20 m 0 3 r 20 m 0 m 20 m 0 11 r 20 m 0 m 5 m 0 2 r
a0 m 0 m 1 m 80 m 0 m 80 m 1 m 0 m 1 m 41 m 0 m 83 m 0 2 r 4 m 0 3 r 1 m 0 2 r 41 m 4 m 0 m 5 m 40 m 88 m a0 m notbusy
20 wcmd 0 m a0 m 0 m notbusy \ 0xa000
02 wcmd 0 m a0 m 0 m \ 0xa000 
c0 m a0 m 0 m 80 m 1 m 20 m 0 4 r 20 m 21 m 0 m 2 m 0 m 20 m 0 m 20 m 4 m 0 2 r 20 m 0 5 r 4 m 40 m 41 m 0 2 r 84 m 0 6 r 20 m
0 2 r 1 m 41 m 0 2 r 2 m 0 3 r 90 m 0 3 r 82 m 0 m 82 m 0 m 4 m 80 m a0 m 21 m 20 m 0 2 r 80 m 21 m 0 m a0 m 20 m 82 m 4 m 8 m
0 4 r 80 m 0 13 r 1 m 0 m a0 m 0 3 r a0 m 20 m 4 m 0 m 4 m 20 m 0 m 20 m a0 m 21 m 20 m 0 2 r 89 m 0 m 11 m 0 m 4 m 10 m 21 m
0 m 80 m 0 m 84 m 40 m 2 m 21 m 0 m 21 m 0 m 20 m 4 m c1 m 0 4 r 80 m 0 4 r 1 m 8 m c1 m 80 m 0 2 r 1 m 0 m 10 m 0 4 r 3 m 0 3
r 3 m 0 m 3 m 0 m 41 m 0 m 3 m 1 m 0 2 r 20 m 10 m 0 m 8 m 0 m 8 m 0 4 r 21 m 84 m 0 m 84 m 0 2 r 80 m 4 m 9 m 4 m c0 m 0 m 40
m 20 m 84 m 2 m 4 m 89 m 20 m 1 m 4 m 88 m 0 2 r 5 m 2 m 5 m 0 m 3 m 0 3 r 3 m 0 m 3 m 0 3 r 9 m 0 3 r 3 m 0 2 r 3 m c0 m 20 m
0 m 41 m 8 m 10 m 2 m 0 m 40 m 4 m 40 m 0 2 r 21 m 0 m 4 2 r 0 m 20 2 r 4 m 0 m 4 4 r 0 m 20 m notbusy
02 wcmd 0 m a1 m 0 m \ 0xa100 
0 7 r 20 m 0 m 20 2 r 0 m 20 m 0 2 r a1 m 21 m 0 3 r 8 m 0 2 r 20 m 0 3 r 41 m 0 2 r 84 m 41 m 0 4 r 84 m 0 m 1 m 0 6 r 20 m 0
2 r 20 m 0 m 1 m 0 3 r 90 m 0 m 88 m 9 m 20 m 0 m 4 m 0 m 20 m 0 m c0 m 20 m 0 m 20 m 8 m 4 m 0 m 20 m 84 2 r 0 m 20 m 0 3 r 4
m 5 m 82 m 0 4 r 20 m 0 3 r c0 m 0 c r 1 m 0 2 r 80 m 1 m 0 a r 80 m 0 2 r 3 m 80 m 0 m 80 m 0 m 85 m 0 a r 91 m 0 2 r 80 m 0
m 80 m 0 2 r 4 m a0 m 0 6 r 1 m 0 2 r 40 m 82 m 0 a r 4 m 0 m 41 m 82 m 0 6 r 80 m 0 m 20 m 0 7 r 3 m 0 m 80 m 4 m 80 m 10 m 0
m 5 m 20 m 11 m 0 m 1 m 0 m 1 m 0 m 5 m 0 m 1 m 40 m 0 2 r 2 m 40 m 3 m 5 m 0 3 r 11 m 0 10 r 82 m 0 m 2 m 88 2 r 0 2 r 1 2 r
11 m 1 m 0 2 r 10 m a0 m 0 m 8 m 0 m 88 m 10 2 r c0 m 82 m notbusy
02 wcmd 0 m a2 m 0 m \ 0xa200 
4 m 90 m 0 m 82 2 r 10 m 11 m 82 m 0 m 4 m 0 m c0 2 r 20 m 0 m 1 m 0 m 1 m 3 m 0 3 r 10 2 r 0 m 4 m 0 m 90 m c0 m 20 m 0 a r
91 m 8 m 0 m 20 m 0 m 20 m 8 m 10 m 0 2 r 20 m 0 m 85 m 1 m 0 a r c0 m 40 m 0 m 8 m 2 m 4 m 9 m a1 m 40 m 3 m 1 m 84 m 9 m 84
m 8 m 2 m 20 m 21 m 0 m 3 m 0 m 90 m 20 m 90 m 0 a r 4 m 0 2 r 85 m 0 m 1 m 0 5 r 80 m 0 3 r 9 m 2 m 8 m 82 m 8 m 0 m 2 m 0 3
r 80 m 0 2 r 80 3 r 0 4 r 80 3 r 2 m 0 2 r 80 m 0 5 r 10 m 11 m 8 m 10 m 11 m 0 m 20 m 5 m 0 2 r 80 m 0 2 r 80 m 0 b r 10 m 80
m 0 5 r 80 m 0 m 40 m 4 2 r 82 m 5 m 0 m 3 m 0 8 r c0 m 9 m 20 m a0 m 20 m 82 m 11 m 2 m 80 m 90 m 41 m 20 m 90 m 89 m 0 m c0
m 0 m 11 m 0 m 83 m 0 3 r 40 m 0 9 r 41 m 80 m 41 m 0 m 83 m 0 m 3 m 0 3 r 3 m 0 4 r 10 m 0 m 2 m 0 m 8 m 0 m 4 m 8 m 0 3 r 11
m 0 m 80 m notbusy
02 wcmd 0 m a3 m 0 m \ 0xa300 
80 m 0 4 r 10 m 0 m 80 2 r 0 3 r 80 m 11 m 0 m 80 m 0 2 r 10 m 0 m 41 m 0 m 8 m 20 m 2 m 11 m 0 2 r 80 m 21 m 0 2 r 80 m 0 b r
80 m 0 m 80 m 21 m 80 2 r 0 2 r 40 m 0 m 41 m 0 m 4 m 20 m 4 m 3 m 0 8 r 40 m 0 m 20 m 21 m 89 m 80 m 82 m 41 m 90 m 0 m 89 m
3 m 88 m 4 m 10 m 41 m 20 m 0 m 80 m 10 m 0 m 80 m 0 m 80 m 0 8 r 41 m 0 m 80 m 0 2 r 83 2 r 10 m 0 9 r a0 m 1 m 0 m 1 m 0 m 1
2 r 2 m 0 m 4 m 0 m a0 m c0 m 10 m 0 m 82 m 0 m 90 m 1 m 4 m 10 m 8 m 0 m 82 m 0 m 10 m 0 m a0 m 40 m c0 m 0 m 1 m 90 m 0 2 r
1 m 0 3 r 10 m 0 m 10 m 0 m 90 2 r 4 m 0 b r 8 m 0 m 20 m 0 m 2 m c0 m 10 m 0 2 r 40 m 0 5 r 21 m 0 8 r 41 m a0 2 r 0 m 4 m 84
m 8 m 21 m 85 m 90 m 2 m 0 m 85 m 21 m 85 m 9 m 20 m 0 m 2 m 1 m a0 m 4 m 20 m a0 m 0 8 r 21 m 0 m 4 m 0 2 r 83 2 r 21 m 40 2
r 0 m 84 m 4 m 10 m a0 2 r 0 m 1 5 r 0 2 r 10 2 r notbusy
02 wcmd 0 m a4 m 0 m \ 0xa400 
0 m 4 m 0 m 8 m a0 3 r 82 m 0 m 88 m 0 m 4 m 2 m 10 m a0 m 82 m 0 m 90 m 0 m c0 m 10 m 2 m 0 m 1 3 r 0 4 r 88 m 2 m 0 m 82 m 0
m 90 m 10 m 20 m 0 a r 90 m 8 m 0 m 2 m 0 m 10 m c0 m 90 m 0 2 r 1 m 0 d r 40 2 r 1 m 5 m 8 m 4 m 20 m 11 m 40 m 83 m 1 m 40 m
20 m 3 m a0 3 r 8 m 0 m 2 m 1 m 20 2 r 91 m 0 c r 1 m 0 m 82 2 r 80 2 r 0 4 r 80 2 r 0 m 40 2 r 8 m 3 m 20 m 0 m 10 m 80 2 r 0
3 r 80 m 0 7 r 80 m 0 8 r 80 2 r 0 m 10 2 r 8 m 2 m 3 m 0 m 10 m 0 m 80 m 0 m 80 m 0 2 r 91 m 0 a r 2 m 0 m 80 m 0 m 80 m 0 m
80 2 r 0 2 r 40 m 10 m 8 m 41 m 9 m 0 m 10 m 0 8 r 80 m 11 m 2 m 83 m 10 m 90 m 5 m 82 m 80 m 90 m 40 m a0 m 21 m 88 m 0 m 40
2 r 0 m 8 m 80 m 21 m 0 2 r 10 m 0 c r 41 m 0 m 80 3 r 0 m 80 m 5 m 0 4 r 8 m 0 m 8 m 2 m 3 m 0 m notbusy
02 wcmd 0 m a5 m 0 m \ 0xa500 
2 2 r 80 m 0 m 80 m 82 m 0 5 r 11 m 0 m 40 m 0 m 80 m 0 2 r 80 m 0 2 r c0 m 0 m 80 2 r 0 m 20 m 80 m 8 m 0 m 2 m 0 m 10 2 r 80
m 0 m 80 m a0 m 0 e r 80 m 0 2 r 40 m 0 4 r 5 m 84 m 4 m 0 m 20 m 0 m 20 m 10 m 0 8 r 88 m 2 m 90 m 84 m 90 m 11 m 20 m 41 m
20 m 5 m 85 m 40 m 84 m 80 m 2 m 41 m 80 m 5 m 0 m 40 m 0 d r 20 m 0 m 5 m 41 m 3 m 5 m 0 m 40 m 0 m 88 m 0 m 10 m 20 m 88 m 0
m 1 m a0 m 1 3 r 0 3 r 8 m 0 m 4 m c1 m a0 2 r 40 m 0 m 82 m 0 m 4 m 88 2 r 40 2 r 0 m 4 m 0 m c0 m 2 m c0 m 8 m 10 m 0 2 r c0
m 1 m 0 5 r 8 m 0 m 82 2 r 20 2 r 90 m 0 b r 8 m 0 m 82 2 r 88 m 20 2 r 0 2 r c0 m 0 4 r 1 m 0 9 r 41 m 91 m 20 m c1 m 4 m 9 m
88 m 1 m 84 m 20 3 r 2 2 r 21 m 1 m 2 m 0 m c0 m 88 m 8 m 90 2 r 0 e r 1 m 0 6 r b m 0 5 r notbusy
02 wcmd 0 m a6 m 0 m \ 0xa600 
0 m d0 m 0 8 r b m 0 m 41 m 82 m 0 4 r b m 0 m 42 m 0 5 r b m 0 6 r d0 m 0 2 r 42 m 0 5 r b m 0 2 r 12 m 0 e r b m 0 2 r 6 m 0
3 r d0 m 0 2 r 88 m 0 c r d0 m b m 0 m 88 m 6 m 0 3 r d0 m b m 0 m 60 m 12 m 81 m 0 2 r d0 m b m 0 e r c8 m 43 m 0 3 r ff 2 r
cf m ff m 30 m f0 3 r 0 8 r 3c 4 r fc m c0 m ff m 0 m 6c m 66 3 r 6e m 62 m 6e m 62 m ff m 0 m ff m 0 m ff 2 r f3 m f7 m 0 8 r
ff 2 r bf m bd 2 r 3c m 3d m 3c m 0 a r f0 4 r ff 2 r e7 m f7 m 0 10 r 7f m 10 m 7e m 18 m f8 m f0 m e0 m f0 m ff m 90 m 6f m
0 m 36 m 3c 3 r ff m 18 m ff m 8 m ff m 0 m 3e m 38 m 0 14 r f0 2 r notbusy
02 wcmd 0 m a7 m 0 m \ 0xa700 
f0 2 r 0 8 r fc m bc m c m 2c m fe m 80 m ff m 0 m 6c 2 r 66 4 r 6e m 62 m ff m 62 m 9d m 0 m c m 8 m 0 a r 40 m 42 m 0 2 r 24
m 3c m 34 m 3c m 0 a r 3c m 78 m f0 2 r 18 m 8 m 0 12 r ff m 0 m ff m 0 m f8 2 r e0 2 r ff m 80 m 7f m 0 m 36 m 3c m 36 m 3c m
e7 m 0 m f7 m 0 m ff m 0 m ff m 0 a r 10 m 0 2 r 54 m a9 m 14 m a8 m 0 7a r 10 m 4 m 0 m 80 m 1 m 0 m 20 m 8 m f 2 r notbusy
02 wcmd 0 m a8 m 0 m \ 0xa800 
f 2 r ff 4 r 0 a r ff 2 r 1 m 7f m 3 m 3f m 3c 2 r bd m 3d m ef m e7 m ff 4 r 7c m ff m 0 m ff m 20 m ef m 0 8 r d m ff m 0 m
ff m 0 m 3 m ff m 3f m 0 a r f 4 r 30 m 20 m ff 2 r 0 10 r 3c 2 r 34 m 3d m f m 7 m f m 1f m 0 2 r ff 2 r 24 m 34 m bd m 3d m
bf 2 r ff m bf m 0 m ff m 0 m ff m 0 10 r f m 2f m f m 2f m 0 d r 64 m 9b m ff m 0 m ff m 0 m ff m 3c 2 r 24 m 34 m 0 2 r 10 m
18 m 0 3 r 83 m 20 m ef m 20 m ef m 0 9 r f2 m 0 m ff m 0 m 1 m ff m 7f m 0 a r f 2 r 2 m bf m 0 2 r cf m df m 0 10 r 3c 2 r
24 m bd m 7 2 r 1f 2 r 0 m 34 m cb m ff m 3c 4 r 2 2 r 0 m 2 m 0 m ff m 46 m 76 m 0 e r notbusy
02 wcmd 0 m a9 m 0 m \ 0xa900 
0 5 r 8 m 0 3 r 1 m 0 m 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 7 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 11 r 8 m 0 5
r 61 m 0 m 1 m 0 m 1 m 0 b r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m a m 80 m d m 0 c r 40 m 90 m 9a m
0 b r fd m ff m 1 m 0 m 2c m 7c m 2c m 7c m 0 18 r ff 2 r c1 m 0 m 70 m ff m 0 m ff m 0 1a r bf m ff m bf 2 r e0 m f4 m e0 m
f4 m 0 8 r fd 2 r 1 2 r 3c 4 r f 2 r 1f m b m 4 m ff m c m ff m 0 6 r ff 2 r 0 a r notbusy
02 wcmd 0 m aa m 0 m \ 0xaa00 
0 2 r f m f0 m f m f1 m 0 8 r 7d m ff m 41 m 0 m 2c m 7c m 3c 2 r 0 18 r 3e m ff m 0 3 r 8f m 0 m ff m 0 1a r 10 m 0 m 10 2 r
e0 m f4 m f0 2 r 0 8 r ff m fd m 0 m 1 m 3c m 78 m 3c m f0 m f 2 r 5f m a m 0 m fb m 0 m f3 m 0 6 r ff 2 r 0 18 r 7d m ff m 41
m 0 2 r 51 m ff 2 r 0 18 r 17 m 55 3 r f0 m f5 m f0 m f4 m 0 1a r f5 m d5 m 55 2 r f0 4 r 0 8 r ff m 57 m 0 m 54 m c m fc m 8
m fd m 55 m fd m 55 2 r 0 m ff m 0 m ff m 0 m eb m ff m 14 m 3c 4 r 0 6 r notbusy
02 wcmd 0 m ab m 0 m \ 0xab00 
0 3 r 20 m 0 4 r 4 m 0 9 r 7f m ff m 40 m 0 3 r ff m ae m 0 18 r 17 m 55 m 17 m 55 m f0 m a0 m f0 m e0 m 0 1a r 5 m 15 m 55 2
r e0 m c0 m f4 m fc m 0 8 r ff 2 r 0 3 r ff m 0 m ff m 55 m 1 m 55 2 r 0 m cb m 34 m ff m 0 m c3 m ff m 3c 5 r 0 14 r 88 m 0 2
r 5 m 40 m 0 m 20 m 0 3 r 2 m 0 m 2 m 0 m 2 m 0 m 2 m 0 m 2 m 0 6 r 10 m 0 3 r 5 m 0 m 20 m 0 c r 20 m 0 m 20 m 0 m 20 m 0 m
20 m 3 m 0 7 r 8 m 0 11 r 4 m 21 m 0 m 20 m 0 m 21 m 0 m 21 m 0 m 20 m 2 m 1 m 2 m 0 m 4 m 1 m 20 m 0 12 r notbusy
02 wcmd 0 m ac m 0 m \ 0xac00 
0 7 r 2 m 0 m 2 m 0 m 2 m 0 a r 20 m 0 20 r 82 m 0 a r 4 m 0 c r 3 m 0 10 r 4 m 0 3 r 4 m 0 m 4 m 0 m 80 m 0 m 20 m 0 3 r 20 m
1 m 0 2a r 1 m 0 8 r 8 m 0 26 r 20 m 0 3 r 20 m 0 3 r 4 m 0 1d r 90 m 0 m 84 m 0 c r 4 m notbusy
02 wcmd 0 m ad m 0 m \ 0xad00 
0 19 r 84 m 0 m 8 m 4 m 8 m 0 m 8 m 0 m 8 m 0 m 8 m 0 m 4 m 0 m 8 m 0 3 r 84 m 0 m 8 m 0 m 8 m 0 b r 4 m 0 m 4 m 0 m 82 m 0 m
4 m 0 m 4 m 0 m 8 m 0 m 4 m 0 4 r 80 m 8 m 0 m 4 m 80 m 0 7 r 9 m 0 4 r 8 m 0 6 r 11 m 0 2 r 8 m 11 m 0 5 r 8 m 4 m 0 2 r 5 m
4 m 0 4 r 3 m 0 4 r 4 m 0 3 r 1 m 0 5 r 2 m 0 b r 2 m 0 d r 21 m 0 2 r 4 2 r 1 m 0 4 r 11 m 0 2 r c0 m 0 2 r 21 m a0 m 20 m 0
m 21 m 1 m 0 m 9 2 r 0 m 2 m 0 m 8 m 0 3 r 9 m 0 3 r 11 m 0 5 r 11 m 0 2 r 1 m 0 3 r 1 m 0 4 r 20 m 83 m 20 m 1 m 0 m 84 m 0 3
r a0 m 0 9 r a0 m 0 m 82 m 0 m 4 m 0 3 r c0 m 0 m 20 2 r 0 2 r 10 m 0 2 r 4 m 40 m 0 m 20 m 0 m notbusy
02 wcmd 0 m ae m 0 m \ 0xae00 
84 2 r 82 m 80 m 40 m 0 m 90 m 0 5 r 82 m 0 m 8 m 0 m 10 m 0 6 r c0 m 0 3 r 10 m 0 7 r a0 m 0 m 2 m 80 m 0 m 4 m 0 4 r 2 m 0 6
r 11 m 1 m 0 2 r 4 m 0 m 4 m 0 m 11 m a0 m 0 4 r 21 m 0 m 8 m 0 5 r 3 m 0 2 r 2 m 9 m 0 m 20 m 0 m 2 m 0 m 20 m 0 3 r 21 m 1 m
4 m 1 m 4 m 0 m 5 m 0 6 r 4 m 0 4 r 3 m 0 m 3 m 0 m 3 m 90 m c1 m 0 m 21 m 0 m 41 m 0 m 80 m 1 m 9 m 0 2 r 84 m 21 m 4 m 40 m
0 m 80 m 0 2 r 5 m 0 m 4 m 0 2 r 8 m 0 m 8 m 0 3 r 8 m 0 9 r 1 m 0 m 1 m 0 3 r 8 m 20 3 r 0 2 r a0 m 20 m 3 m 40 m 0 8 r 8 m 0
5 r 82 m 0 5 r 8 m 0 4 r 80 m 0 5 r 80 m 20 m 0 m 84 m 80 m 5 m 0 m 20 m 0 2 r 4 m 0 m 41 m 0 m 4 m 0 m 9 m 0 3 r 9 m 82 m 2 m
40 m 0 m 84 m 0 4 r 20 m a0 m 0 5 r 82 m 0 m 82 m 9 m 0 2 r c0 m 0 2 r 83 m c0 m 20 m 40 m 2 m 0 m 5 m 0 m 3 m 0 m 2 m notbusy
02 wcmd 0 m af m 0 m \ 0xaf00 
88 m 0 2 r 80 m 0 m 2 m 0 m 90 m 0 m 11 m 0 10 r 4 m 0 m 4 m 0 m 41 m 0 m 3 m 1 m 10 m 1 m 8 m 0 2 r 1 m 4 m 0 7 r 3 m 0 5 r 3
m 0 7 r 8 m 0 m 10 m 0 m 8 m 4 m 8 m 0 4 r 4 m 80 m 0 2 r 4 m 20 m 0 m 80 m 0 m 10 m 1 m 0 3 r 1 m 0 1c r 9 m 0 2 r 20 m 9 m 0
m 40 m 8 m 0 9 r 4 m 0 3 r 20 m 10 m 0 12 r 20 m 0 m 20 m 0 m 40 m 0 m 20 m 0 m 3 m 0 5 r 2 m 0 2 r 1 m 0 m 4 m 0 m 4 m 2 m 20
2 r 4 m 0 2 r 3 m 4 m 0 2 r 20 m 0 m 20 m 8 m 0 m 1 m 20 2 r 0 m 20 m 0 2 r 5 m 8 m 0 3 r 20 m 0 2 r 2 m 0 m 4 m c0 m 0 6 r 5
m 0 7 r 20 m 0 c r 82 m 80 m 4 m 2 m 82 m 0 2 r 20 m 1 m 0 m 83 m 20 m 0 3 r 41 m notbusy
20 wcmd 0 m b0 m 0 m notbusy \ 0xb000
02 wcmd 0 m b0 m 0 m \ 0xb000 
0 2 r 40 m 0 m 88 m 41 m 0 m 20 m 10 m 0 3 r 1 m 4 m 0 11 r c1 m 0 m 1 m 0 3 r 1 m 0 3 r c0 m 0 m a0 m 0 m 2 m 0 2 r 4 m 0 m
80 m 0 m 80 m 2 m 20 m 1 m 80 m 0 2 r 88 m 91 m 2 m 20 m 1 m 0 m 1 m 0 2 r 4 m 1 m a1 m 0 m c1 m 0 2 r 88 m 8 m 0 3 r 89 m 10
m 0 3 r 3 m 0 6 r 11 m 0 7 r 21 m 1 m 5 m 4 m 21 m 0 a r 20 m 80 m a0 m 0 2 r 20 m c1 m 4 m c0 m 4 m 1 m 0 4 r 41 m 0 m 11 m
10 m 40 m 10 m 5 m 1 m 10 m 88 m 3 m 88 m 20 m 1 m 0 6 r 10 m 0 m 10 m 0 3 r 21 m 0 7 r 9 m 20 m 0 m 5 m 0 m 41 m 40 m 0 2 r
21 m 0 m 40 m 4 m 0 m a0 m 20 m 0 2 r 4 m 0 m 4 m 0 m a0 m 20 m 4 m 20 m 0 2 r 4 m 0 3 r 8 m 20 m 0 m 21 m 0 3 r 80 m 1 m 89 m
20 m 11 m 0 m 4 m 0 3 r 4 m 0 2 r 20 m 0 3 r 20 m 0 2 r 3 m 0 2 r 4 m 0 m 82 m 0 m 40 m 0 m 1 m 20 m 0 3 r 20 m 90 m 9 m 0 2 r
4 m 0 m 82 m 80 m 82 m 0 4 r 11 m 0 2 r 20 m 0 m notbusy
02 wcmd 0 m b1 m 0 m \ 0xb100 
0 2 r 20 m 0 m 82 m 0 m 82 m 41 m 84 m 0 2 r 20 m 1 m 9 m 0 3 r 80 m 0 4 r 8 m 0 f r 4 m 1 m 0 2 r 8 m 0 3 r 21 m 0 3 r 80 m 0
5 r 80 m 0 m 80 m 0 2 r 1 m 80 m 1 m 0 2 r 80 m 0 4 r 1 m 0 2 r 3 m 20 m 0 m 4 m 20 m 4 m 80 m 0 2 r 1 m 0 2 r 4 m 21 m 0 2 r
80 m 0 3 r 80 m 0 5 r 80 m 0 3 r 3 m 0 m 4 m 1 m 0 8 r 80 m 0 2 r 20 m 0 7 r a0 m 80 m 0 4 r 82 m 0 3 r c0 m 0 3 r 1 m 4 m 0 4
r 20 m 0 10 r 10 m 2 m 0 m 4 m 0 m 8 m 2 m 8 m 4 2 r 8 2 r 0 m 2 m 20 m 82 m 10 m 2 m 0 m 8 m 0 m 2 m c0 3 r 10 m 0 m 82 m 0 m
2 m c0 m 8 m 10 m 2 m 84 m 4 m 0 m 40 m c0 m 2 m 0 2 r 1 m 0 m 90 m 1 m 0 4 r 20 m 1 m 2 m 0 3 r 1 m 0 m 1 m 0 m 21 m 0 2 r 1
m 0 2 r 90 2 r 4 m 8 m 0 m 82 m 20 m 2 m 0 8 r 10 2 r 40 m 4 m 0 m a0 m c0 m 82 m 2 m 3 m notbusy
02 wcmd 0 m b2 m 0 m \ 0xb200 
0 m 88 m c0 m 88 m c0 m 83 m 0 8 r 41 m 40 m 1 m 20 m 82 m a1 m 20 m a1 m 0 10 r 80 m 0 2 r 80 m 0 m 80 3 r 0 2 r 80 m 0 4 r
80 m 0 3 r 80 m 0 4 r 80 2 r 0 4 r 80 2 r 3 m 0 4 r 80 m 0 m 80 m 8 m 9 m 10 m 21 m 5 m 8 m 0 m 40 m 0 m 2 m 20 m 10 m c0 m 3
m 0 m 3 m 10 m 8 m 40 m 4 m 2 m 41 m 0 m 20 m 0 2 r 40 m 0 2 r 80 m 0 m 80 m 0 m 80 m 0 8 r 80 2 r 0 4 r 80 3 r 90 m 11 m 20 m
85 m 11 m 0 m 2 m 0 8 r 90 m a0 m 20 m 5 2 r 20 m 0 m 40 m 0 10 r 80 m 0 m 80 m 10 m 0 m 80 3 r 0 3 r 10 m 80 2 r 0 5 r 41 m 0
m 80 m 0 4 r 80 m 2 m 80 2 r 0 5 r 4 m 80 3 r 0 m 11 m 0 m 41 m 0 m 5 m 20 m 8 m 40 m 10 m 80 m 10 m 0 m 3 m 0 m 10 m 3 m 10 m
0 m 20 m 0 m 4 m 0 m 20 2 r 0 5 r 20 m 80 2 r 0 d r 3 m 0 m 80 m notbusy
02 wcmd 0 m b3 m 0 m \ 0xb300 
0 2 r 10 m 0 m 83 m 41 m 9 m 8 2 r c1 m 0 8 r c0 m 0 m a0 m 3 m a0 m 40 3 r 0 10 r 8 m 0 m 82 m 0 m 88 m 10 m 8 m 4 m 90 m 0 m
4 m 1 m 82 m c0 m 10 m 0 m 2 m 0 m 2 m 1 m 4 m 10 m 2 m 0 m c0 m 0 m 10 m 1 m 2 m 10 m 88 m 0 m 10 m 0 m 2 m 0 m 8 m 82 2 r 0
2 r 88 m 0 2 r 1 m 0 m 1 m 40 m 1 m 2 m 1 m 0 4 r 1 m 0 m 90 m 0 4 r 1 2 r 0 2 r 82 m 0 m a0 m 1 m 8 m 40 2 r 0 9 r 2 m 0 m 40
m 1 m a0 m 10 m 2 m 10 m 11 m 90 m 5 m 0 m 88 m c1 m 83 m c1 m 0 8 r 40 2 r 21 m 1 m 85 m a0 m 8 m 21 m 0 10 r 10 m 8 m 0 m 20
m 0 m 8 m 4 m 8 m 10 m 88 m 0 m 8 m 0 m 2 m 10 2 r 82 m 2 m 0 m 82 m 0 m 8 m 10 m 2 m a0 m 2 m 0 m 82 m 0 m 2 m 10 m 8 m c0 m
2 m 0 m 82 m 0 m 4 m 10 m 8 m 0 2 r 1 2 r 91 m 1 m 0 5 r 1 m 0 5 r 1 m 0 2 r 5 m 1 m 0 m 1 m 0 2 r 82 2 r 0 m 8 m 0 m 4 m 20 m
90 m 0 8 r 88 m 40 m notbusy
02 wcmd 0 m b4 m 0 m \ 0xb400 
0 m 40 m 4 m 2 m 10 2 r 84 m 3 m 0 m 89 m 85 m 89 m 90 m 83 m 0 8 r 40 m 3 m 0 m 88 m 91 m a1 m 20 m a0 m 0 10 r 80 2 r 0 m 80
m 0 m 80 m 0 m 80 m 0 3 r 80 m 0 9 r 80 m 10 m 0 2 r 80 m 0 4 r 9 m 80 2 r 0 2 r 80 m 0 m 80 m 2 m 80 m 0 m 11 m 3 2 r 10 m 8
m 11 m 40 m 0 m 11 m 20 m 10 3 r 0 m 5 m 0 m 10 m 21 m 4 m 8 2 r 0 m 20 m 0 5 r 80 m 0 d r 80 m 0 5 r 80 m 0 m 90 m 3 2 r 8 2
r 4 m 2 m 0 8 r 80 m 82 m 21 m 5 m 2 m 20 m 3 m 5 m 0 10 r 80 m 3 m 0 m c0 m 80 3 r 0 2 r 11 m 80 m 82 m 0 7 r 85 m 0 4 r 80 m
0 m 80 m 85 m 0 5 r 5 m 80 m 85 m 0 m 80 m 0 2 r 8 m 80 m 10 m 0 m 8 m 0 m 11 2 r 10 m 0 m 3 m 2 m 10 m 0 m 3 m 9 m 10 m 84 m
4 m 0 m 8 m 0 m 20 m 10 m 0 3 r 4 m 80 m c0 m 0 a r notbusy
02 wcmd 0 m b5 m 0 m \ 0xb500 
0 3 r 9 m 0 m c0 m 0 2 r 80 m 0 m 88 m 80 m a0 m 40 m 8 m 0 m 2 2 r 0 8 r 20 m 85 m 20 m 2 m 5 m 0 m 2 m 20 m 0 10 r 4 m 0 m 4
m 10 m 8 3 r 0 m 4 m 0 m 8 m 21 m 2 2 r 10 m 0 m 2 m 0 m 4 m 82 m 2 m 82 m 40 m 0 m 4 m 0 m 82 2 r 2 2 r 10 m 0 m 2 m 0 m 20 m
2 m 88 m 2 2 r 0 m 1 m 40 m 1 m 0 m 1 m 0 3 r 1 m 20 m 0 4 r 1 m 0 m 1 m 40 m 0 2 r 1 m 0 m 1 2 r 0 2 r 82 m 0 m 20 m 8 m 20 2
r c0 m 0 9 r 4 m 0 m a0 m 20 m 2 m 10 m 2 m 0 m 5 m 40 m 4 m a0 m 89 m 4 m 83 m 1 m 0 8 r 91 m c0 m 41 m a1 2 r a0 m 89 m 1 m
0 14 r b m 0 7 r b m 0 2 r 82 m 0 4 r b m 0 m 84 m 0 5 r b m 0 m 42 m 82 m 0 4 r b m 0 m 82 m 0 4 r d0 m 0 7 r d0 m 0 7 r d0 m
0 a r b m 0 5 r notbusy
02 wcmd 0 m b6 m 0 m \ 0xb600 
0 a r b m 0 2 r a m 0 3 r d0 m b m 0 2 r 6 m 0 b r d0 m b m 0 m 60 m 0 11 r 70 m 0 m ff 2 r f0 3 r b2 m ea m fa m aa 2 r ff m
be m ff m bf m 3c 3 r 3a m c0 m fc m f0 2 r 80 2 r bf 2 r 3c 4 r 0 m ff m b m ff m 0 m eb m 14 m ff m 0 1a r aa 2 r a2 m ae m
0 2 r ff 2 r 0 8 r aa m 2a m aa m ea m 0 m c m ff m fc m 8a m aa m ba m aa m ff m fe m ff m be m 0 8 r 20 m 0 m 7f m ff m 3c 3
r 78 m 0 12 r 8f m ff m f0 m b2 m f0 m b2 m 2a m a m aa 2 r 0 m 14 m 0 m 10 m 3c 2 r 3a 2 r e0 m f4 m f0 2 r 80 m 0 m bf m ff
m 3c m aa m 3c m ac m 0 m ff m 0 m f4 m 0 m fb m 4 m ff m 0 1a r aa 2 r a0 m af m 0 m 34 m notbusy
02 wcmd 0 m b7 m 0 m \ 0xb700 
cb m ff m 0 8 r 2a 2 r ea 2 r 0 m 4 m ff m fe m a m aa m fa m aa m 0 m 4 m 0 m 14 m 0 8 r 28 m 0 m 7d m ff m 3c m 78 m 3c m 78
m 0 10 r ff m 8 m f7 m 0 m cf m c m 8f m d m ff 3 r f1 m 3f m 7f m 30 m 20 m ff m 4f m ff 4 r fc m fd m ff 2 r f5 m fd m ff m
0 m 4f m e m af m 5 m f 2 r 57 m 54 m 55 2 r 0 1a r 1e m 3c m 1e 2 r ff 2 r 0 a r ff m fe m ff m be m 5c m 3c 3 r ff 2 r f7 m
f5 m 75 2 r 55 m 75 m 0 8 r ff 3 r f1 m 4f 2 r e 2 r 0 10 r ff m a m f5 m 0 m f 4 r 0 2 r e m 0 m ff 2 r 0 2 r b0 m 0 5 r c m
8 m a m 2 m 0 2 r ff m 0 m ff m 0 m 8f m d m f 2 r 57 m 54 m 57 m 54 m 0 1a r 3c 2 r notbusy
02 wcmd 0 m b8 m 0 m \ 0xb800 
3c 2 r ff m cb m 34 m 0 9 r 1 m 0 m 41 m 0 m 5c 2 r 3c 2 r 0 2 r 4 m 5 m 45 2 r 55 m 45 m 0 a r e m 0 m f m 4f m f m e m 0 13
r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 3 r 61 m 0 m 1 m 0 m 1 m
0 7 r 8 m 0 f r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 b r 61 m 0 m 9 m 0 m 1 m 0 3a r 55 m 5f m 55 m 50 m ff m fe m ff m be m 55 4
r 0 2 r ff 2 r fc m bc m c m 1c m ff 2 r ae m ff m notbusy
02 wcmd 0 m b9 m 0 m \ 0xb900 
0 1a r ff m 0 m ff m 0 m f0 m f1 m f0 m f5 m 0 8 r 2f m f m af m f m 0 m 8 m ff m fd m 0 38 r 55 m 57 m 55 m 54 m 0 m 4 m 0 m
14 m 3c m 35 m 55 2 r 30 m 20 m 3f m 7f m 3c 4 r 0 2 r a2 m 0 1b r ff m e m f1 m 0 m f0 m b0 m f0 m a0 m 0 8 r 7 m f m 5 m f m
0 m c m ff m fc m 0 38 r ff m 0 m ff m 0 m f0 4 r 3e m 3c m 34 m 3c 5 r 55 4 r notbusy
02 wcmd 0 m ba m 0 m \ 0xba00 
ff 2 r fe m fc m 0 1a r df m 8 m 5f m a m ff 2 r f4 m ff m 0 8 r ff m f5 m 0 m 5 m ff m fe m ff m be m 0 38 r ff m e m f1 m 0
m f0 2 r b4 m 3c m be m 3c m 14 m 3c m ac 2 r 3c m ac m 7d m 75 m 41 m 45 m 0 2 r 40 m c0 m 0 1a r ff m 0 m ff m 0 4 r b m 0 8
r ff m fd m 0 m 1 m 0 m 2 m 0 m 82 m 0 10 r 20 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 10 r 8 m 0 f r 5 m
0 8 r notbusy
02 wcmd 0 m bb m 0 m \ 0xbb00 
0 6 r 4 m 88 m 0 8 r 4 m 0 16 r 4 m 0 7 r 4 m 0 28 r 20 m 0 d r 20 m 0 m 5 m 1 m 0 1e r 80 m 21 m 0 m 1 m 0 5f r 4 m 0 14 r
notbusy
02 wcmd 0 m bc m 0 m \ 0xbc00 
0 b r 80 m 0 2b r 41 m 0 24 r 5 m 84 m 0 5 r 84 m 0 m 8 m 0 7 r 9 m 0 17 r 8 m 0 4 r 10 m 0 2 r 20 m 0 19 r 88 m 0 5 r 10 m 0
37 r 9 m 0 9 r 10 m 0 5 r 9 m 0 9 r 21 m notbusy
02 wcmd 0 m bd m 0 m \ 0xbd00 
0 e r 5 m 90 m 0 8 r 20 m 0 5 r a0 m 0 11 r 8 m 0 m 2 m 0 5 r a0 m 0 3 r c0 m 0 m c0 m 0 m 82 m 0 12 r 88 m 0 3 r 88 m 2 m 0 2
r 2 m 0 7 r 4 m 0 3 r 4 m 0 m 84 m 0 7 r 9 m 0 4 r 5 m 0 2 r 84 m 0 2 r 5 m 0 4 r a0 m 0 m 82 m 11 m 0 m 11 m 84 m 0 7 r 8 m
88 m 11 m 0 14 r 2 m 0 m 2 m 0 8 r 10 m 11 m 90 m 5 m 0 m 40 m 0 3 r 21 m 0 19 r 82 m 0 m 82 m 0 m 82 m 0 m 82 m 0 m 82 m 0 m
82 m 0 m 82 m 0 m 82 m 0 m 82 m 0 m 82 m 4 m 82 m 0 m 82 m 2 m 8 m 0 m 82 m 0 m 82 m 0 m 82 m 0 m 82 m 0 m 82 m 0 m 82 m 0 m
82 m 0 m a0 m 0 3 r notbusy
02 wcmd 0 m be m 0 m \ 0xbe00 
0 m 2 m c0 m 21 m 0 3 r 9 m 0 3 r 5 m 0 5 r 8 m 1 m 20 m 0 5 r 9 m 0 1a r 8 m 0 2 r 2 m 0 3 r 2 m 0 m 2 m 0 m 9 m 0 1e r 40 m
0 2 r 4 m 0 2 r 41 m 0 10 r 8 m 0 7 r c0 m 3 m 0 2 r 88 m 0 m 90 m 8 m a0 m 0 2 r 11 m 0 2 r 84 m 0 m 84 m 0 6 r 8 m 21 m 0 4
r 11 m 0 m 20 m 0 c r 20 m 41 m 0 e r c0 m 0 m 90 m 0 3 r 90 m 0 m 90 m 0 m 40 m 0 m 40 m 0 6 r 10 m 0 b r a0 m 0 3 r 8 m 0 m
8 m 0 3 r 40 m 0 m 8 m 0 3 r 84 m 0 d r 1 m 0 m 8 m 0 3 r 8 m 0 m 8 m 0 m notbusy
02 wcmd 0 m bf m 0 m \ 0xbf00 
82 m 0 m 40 m 0 m 8 m 0 11 r 83 m 84 m 0 e r 84 m 0 17 r 84 m 0 m 8 m 0 1e r a0 m 0 2 r 40 m 0 2 r 4 m 0 2 r 40 m 4 m 0 e r 4
m a0 m 0 m 90 m 0 5 r 84 m 9 m 0 m 5 m c0 m 0 3 r 40 m 2 m 0 5 r 21 m 0 m 11 m 0 5 r 4 m 11 m 0 6 r 21 m 0 m 21 m 0 c r c0 m 0
7 r 10 m 21 m 10 m 8 m 90 m 0 4 r 5 m 84 m 21 m 0 m 11 m 90 m 5 m 0 2 r 90 m 5 m 84 m 0 18 r 8 m 0 m 8 m 0 m c0 m 0 b r 82 m 0
m 8 m 0 3 r 1 m 8 m a0 m 0 3 r notbusy
20 wcmd 0 m c0 m 0 m notbusy \ 0xc000
02 wcmd 0 m c0 m 0 m \ 0xc000 
40 m 0 3 r 8 m 0 m 8 m 0 m c0 m 0 m 88 m 21 m 0 6 r c0 m 0 5 r 40 m 8 m 5 m a0 m 0 6 r 90 m 0 f r 88 m 0 9 r 8 m 0 a r 9 m 0 3
r 20 m 0 9 r 2 m 0 9 r 2 m 11 m 2 m 0 m 2 m 40 m 0 3 r 40 m 0 13 r 4 m 8 m 0 m c0 m 0 5 r 84 m 0 e r 9 m 0 6 r 20 m 84 m 11 m
0 3 r 2 m 0 2 r 41 m 0 9 r 10 m 0 7 r 4 m 0 4 r 10 m 9 m 10 m 8 m 10 m 0 m 84 m 0 3 r c0 m 20 m 2 m 0 m 4 m 5 m 0 4 r 40 m 0
10 r 1 m 0 6 r 1 2 r 0 m 2 m 0 2 r 1 2 r 90 m 0 2 r c0 m 0 2 r c0 m 0 m 82 m 0 2 r c0 m 0 2 r 1 m 0 2 r notbusy
02 wcmd 0 m c1 m 0 m \ 0xc100 
1 m 0 6 r 1 2 r 0 m 2 m 0 2 r 1 m 0 m 90 m 0 2 r c0 m 0 2 r c0 m 0 m 82 m 0 2 r c0 m 0 2 r 1 m 0 44 r 41 m 0 4 r 41 m 0 m 10 m
41 m 0 m 80 m 0 2 r 3 m 2 m 0 2 r 5 m a0 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 2 r 3 m 0 2 r 41 m 0 4 r 41 m 0 m 10 m 41 m 0 m 80
m 0 2 r 3 m 8 m 0 2 r 5 m a0 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 2 r 3 m 0 46 r 5 m 0 7 r c0 m 0 3 r 3 m 0 m 40 m 0 m 2 m 80 m
0 m 80 m 3 m 0 5 r notbusy
02 wcmd 0 m c2 m 0 m \ 0xc200 
0 m 80 2 r 3 m 0 2 r 5 m 0 7 r c0 m 0 3 r 2 m 0 m 40 m 0 m 2 m 80 m 0 m 80 m 3 m 0 6 r 80 2 r 40 m 0 4c r 20 m 0 5 r 82 m 0 m
91 m 4 m 0 m 4 m 1 m 0 m 40 m 0 4 r c0 m 82 m 0 b r 20 m 0 3 r 1 m 0 m 82 m 0 m 91 m 4 m 0 m 4 m 1 m 0 m 40 m 0 4 r c0 m 82 m
0 51 r 41 m 20 m 0 m 2 m 0 6 r notbusy
02 wcmd 0 m c3 m 0 m \ 0xc300 
0 16 r 40 m 20 m 0 m 2 m 0 5d r 40 m 20 m 3 m 0 m 80 m 0 b r 41 m 0 f r 40 m 0 m 3 m 0 m 80 m 0 b r 41 m 0 46 r 80 m 5 m 0 m
83 m 0 3 r 20 m 80 m 0 m 82 m 0 4 r 41 m 0 2 r notbusy
02 wcmd 0 m c4 m 0 m \ 0xc400 
0 m 40 m 0 3 r 41 m 0 5 r 2 m 0 2 r 80 m 5 m 0 m 83 m 0 6 r a0 m 0 4 r 41 m 0 3 r 40 m 0 3 r 41 m 0 5 r 5 m 0 44 r 4 m 0 2 r
83 m 0 3 r 1 m 82 m 0 m 41 m 0 4 r 41 m 40 m 0 6 r 1 m 0 5 r 1 m 0 2 r 4 m 0 2 r 83 m 0 4 r c0 m 0 m 5 m 0 4 r 41 m 40 m 0 6 r
1 m 0 4e r 48 m 0 7 r 48 m 0 m notbusy
02 wcmd 0 m c5 m 0 m \ 0xc500 
81 m 12 m 0 m d0 m b m 0 m 48 m 0 7 r 48 m 42 m 0 6 r 48 m 0 7 r 48 m 0 m 81 m 12 m 0 m d0 m b m 0 m 48 m 0 7 r 48 m 42 m 0 42
r ff 82 r 0 m 18 m b9 m 17 m 30 m 22 m 0 m e m 0 m 17 m 50 m 60 m notbusy
02 wcmd 0 m c6 m 0 m \ 0xc600 
0 2 r 9 m 24 m 75 m 7b m 0 1c r de m ae m 75 m 7b m 0 1c r de m ae m 0 42 r 60 m c6 m 3 m 40 m 0 6 r 2 m 31 m e0 m 0 7 r c m
40 m 0 6 r 2 m c0 m 63 m 6 m 60 m c6 m 3 m 40 m 0 6 r 2 m 31 m e0 m 0 7 r c m 40 m 0 6 r 2 m c0 m 63 m 6 m 0 3a r notbusy
02 wcmd 0 m c7 m 0 m \ 0xc700 
0 8 r 20 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 m 88 m 0 m 40 m 0 3 r 20 m 0 4 r 20 m 0 2 r 20 m 0 m 20 m 0 8 r 8 m 88 m 0 f r 2 m 0
m 2 m 0 2 r 4 m 0 m 4 m 0 3 r 4 m 0 3 r 4 m 0 2 r 4 2 r 0 5 r 20 m 0 m 4 m 0 2 r 40 m 0 9 r 1 m 0 3 r 1 m 84 m 0 m 80 m 0 m 80
m 0 m 80 m 1 m 0 m 1 m 0 m 1 m 4 m 0 m 84 m 0 m 84 m 0 9 r 11 m 0 1b r 1 m 5 m 0 11 r 20 m 0 10 r 1 m 0 m 1 m 0 3 r 1 m 0 m 3
m 0 m 1 m 0 2 r 80 m 1 m 0 5 r 1 m 0 6 r 11 m 0 7 r 20 m 0 3 r 20 2 r 0 m 4 m 0 m 4 m 0 m 4 m 40 m 0 m 4 m 0 m 4 m 0 2 r 20 m
0 m 20 m 0 4 r notbusy
02 wcmd 0 m c8 m 0 m \ 0xc800 
0 d r 20 m 0 m 20 m 0 3 r 20 m 0 5 r 5 m 0 19 r 9 m 0 9 r 80 m 0 m 80 m 0 3 r 88 m 0 5 r 80 m 0 m 20 m 0 2 r 1 m 0 m 1 m 80 m
0 2 r 1 m 80 m 0 1f r 80 m 0 17 r 80 m 0 m 1 m 0 m 1 m 0 3 r 9 m 0 m 8 m 0 3 r 8 m 0 m 8 m 0 7 r 4 m 0 5 r 8 m 0 m 8 m 0 7 r
88 m 0 m 8 m 0 3 r 84 m 0 m 8 m 0 m 20 m 2 m 20 m 0 3 r 20 m 0 5 r 4 m 0 m 9 m 0 2 r 4 m 0 m 4 2 r 0 2 r 4 2 r 0 m 8 m 0 5 r 4
m 0 7 r 8 m 0 5 r 4 m 0 m 8 m 0 7 r 2 m 0 m 4 m 0 2 r 9 m 0 3 r notbusy
02 wcmd 0 m c9 m 0 m \ 0xc900 
0 7 r 90 m 0 7 r 8 m 0 m a1 m 0 m 41 m 0 m 91 m 0 m 8 m 0 2 r 90 m 0 2 r 20 m 0 m 20 m 0 m 85 m 4 m 0 6 r 20 m 0 m 20 m 1 m 21
m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 2 r 82 m 21 m 0 3 r 41 m 0 a r 90 m 3 m 0 3 r 8 m 0 c r 4 m 0 4 r a0 m 4 m 0 6 r 20 m 0 2 r 1
m 0 3 r 1 m 0 5 r 1 m 0 m 4 m 0 m 41 m 0 7 r 84 m 0 8 r 5 m 0 9 r 20 m 0 m 10 m 0 m 20 m 8 m 0 m 21 m 0 m 3 m 0 2 r 1 m 0 m 1
m 0 m 20 m 80 m 0 6 r 1 m 0 m 1 m 4 m 0 4 r 1 m 21 m 1 m 0 m 1 m 8 m 0 3 r 8 m 0 1b r 8 m 0 3 r 80 m 0 4 r 21 m 80 m 0 6 r 1 m
0 2 r 20 m 0 3 r 20 m 0 5 r 4 m 0 m 80 m 0 m 84 m 0 5 r notbusy
02 wcmd 0 m ca m 0 m \ 0xca00 
0 14 r 90 m 0 5 r 20 m 0 m c0 m 0 m a0 m 0 m 8 m 0 m 4 m 0 3 r 4 m 0 m c0 m 0 m 4 m 0 m 4 m 0 3 r 82 m 0 m 4 m 0 m 1 m 0 m 4 m
0 m 82 m 0 2 r 20 m 0 4 r 8 m 0 3 r 40 m 0 4 r 20 m 40 m 0 m 20 m 0 m 1 m 80 m 1 m 0 m 21 m 0 3 r 1 m 0 m 1 m 0 m 9 m 0 m 1 m
0 3 r 40 m 0 m c0 m 0 m a0 m 80 m 1 m 0 3 r 4 m 20 m 0 6 r a0 m 0 m 82 m 0 5 r 8 m 0 m 1 m 0 16 r 2 m 0 6 r 5 m 0 3 r 20 m 0 m
21 m 0 m 21 m a0 2 r 4 m 0 2 r 88 m 0 3 r 80 m 8 m 80 m 90 m 0 m 20 m 0 m 88 m 80 m 84 m 4 m 0 m a1 m 0 m 41 m 0 2 r 1 m 0 m
a0 m 0 3 r c0 m 0 m c0 m 0 3 r 82 m 3 m 1 m 0 m 82 m 80 m 4 m 20 3 r 4 m 20 m 0 3 r 20 m 84 m 20 m 84 m 20 m 0 m 20 m 8 m 3 m
0 m 21 m 0 4 r 20 m 4 m 0 3 r 3 m 1 m 8 m 84 m 2 m 40 m 3 m 0 3 r 3 m 90 m 2 m 0 m 2 m 0 3 r 40 2 r notbusy
02 wcmd 0 m cb m 0 m \ 0xcb00 
0 m 40 m 0 m 40 m 0 3 r 40 m 0 4 r 3 m 20 m 0 3 r 40 m 0 8 r 82 m 83 m a0 m 20 m c0 m 88 m 4 m 20 m 0 m 20 m 4 m 0 m 8 m 0 2 r
5 m c0 m 0 m c0 m 5 m c0 m 80 m a0 m 3 m 4 m 0 3 r a0 m 20 m 0 2 r a0 m 41 m 0 m 41 m 0 m 20 m a0 m 0 6 r 41 m 90 m 0 3 r 84 m
0 m c0 m 0 2 r 20 m 0 3 r 20 m 0 a r 82 m 8 m 0 2 r 90 m 0 7 r 84 m 0 8 r 11 m 82 m 10 m 82 m 85 m 0 m 80 m c0 m 0 m 4 m 3 m
85 m 2 m 0 m 20 m 0 m 20 m 0 3 r 20 m 0 13 r 20 m 8 m 1 m 0 m 20 m 80 m 1 m 0 m 1 m 88 m 0 3 r 8 m 0 6 r 20 m 0 2 r 80 m 0 4 r
1 m 41 m 0 3 r 8 m 0 2 r 9 m 0 4 r 3 m 0 m 3 m 0 m 8 m 88 m 0 m 88 m 0 m 88 m 0 3 r 1 m 0 3 r 1 m 0 23 r 4 m 0 m 20 m 0 2 r
notbusy
02 wcmd 0 m cc m 0 m \ 0xcc00 
80 m 0 m 40 m 1 m 11 m 1 m 0 m 1 m 5 m 0 2 r 1 m 0 10 r 8 m 21 m 82 m 0 m 82 m 3 m 0 m 8 m 90 m 0 m 1 m 0 3 r 20 m 0 m 4 m 3 m
0 2 r 4 m 0 m a0 m 0 m 82 m 21 m 82 m 0 m a0 m 20 m 0 m 5 m 8 m 0 2 r 11 m 0 m 80 m 0 m 41 m 0 m 21 m 0 4 r 10 m 0 m 1 m 0 2 r
80 m 1 m 0 m 1 m 0 m 8 m 91 m 8 m 84 m 83 m 9 m 1 m 5 m 0 2 r 20 m 0 m 20 m 0 3 r 40 m 2 m 0 m 20 m 0 m 20 m 0 5 r 80 m 85 m 0
m 8 m 9 m 1 m 80 m 0 m 80 m 1 m 0 m 1 m 0 m 10 m 11 m 4 m 0 3 r 20 m 0 m 41 m 2 m 0 m 11 m 0 3 r 20 m 0 m 20 m 0 3 r 5 m 0 7 r
40 m 0 3 r 40 m 0 2 r 3 m 0 m 3 m 0 4 r 4 2 r 0 2 r 4 m 8 m 0 m 80 m 8 m 0 m 8 m 80 m 0 m 10 m 0 6 r 1 m 0 3 r 90 m 0 2 r 3 m
20 m 0 3 r a0 m 5 m 0 2 r c0 m 0 m c0 m 4 m 84 m 3 m 20 m 4 m 0 m 4 m 0 m 9 m 20 m 0 m 20 m 4 m a0 m 4 m 84 m 0 2 r 5 m 0 4 r
a0 m 0 m 8 m 0 m 1 m 0 m 1 m 0 5 r 20 m 4 m 0 2 r 4 2 r 20 m 0 m 20 m 4 m 0 m 4 m 40 m 9 m 90 m notbusy
02 wcmd 0 m cd m 0 m \ 0xcd00 
84 m c0 m 0 m 4 3 r c0 m 91 m 0 2 r 4 m 0 m 2 m 1 m 20 2 r 8 m 0 f r 4 m 2 m 0 m 20 m 0 m c0 2 r 40 m 2 m 40 m 0 m 4 m 0 m 10
m 84 m 10 m 8 2 r 0 m 2 m 0 m 84 m 4 2 r 2 2 r 0 m 40 m 0 m 2 m 10 m 4 2 r 8 m 40 m 4 m 0 m 2 m 10 m 82 m 0 8 r 8 m 20 m 0 m 8
m 0 m 90 2 r 8 m c0 m 88 m 0 m 84 m 0 m a0 m 84 2 r 0 a r 40 m 20 m 0 m 84 m 0 m a0 m 4 m 40 2 r 2 m 20 2 r 0 m 84 m 10 2 r 11
m 40 m 4 2 r 41 m 1 m 84 m 85 m c0 m 10 2 r c0 m 0 m 2 m a1 2 r 40 2 r 0 m 8 m 0 m 2 m 40 m 4 m 0 10 r 80 m 0 7 r 80 2 r 0 m
80 m 0 m 80 m 0 2 r 80 2 r 0 3 r 80 4 r 0 5 r 80 4 r 0 m 80 m 0 m 80 m 0 m 80 m 0 8 r a0 m 0 2 r 80 m 0 3 r 80 2 r 0 11 r 80 m
0 5 r 80 m 0 m a0 m 80 m 0 5 r 80 m 40 m 83 m 85 m 91 m notbusy
02 wcmd 0 m ce m 0 m \ 0xce00 
84 m 20 m 0 m 4 m 80 m c1 m 80 m 20 2 r 80 m 91 m a1 m 80 2 r 0 m 80 m 0 m 80 m 0 m 80 m 0 10 r 80 m 0 2 r 10 m 0 4 r 80 m 0 m
80 m 5 m 80 m 82 m 0 2 r 80 m 0 m 80 m 2 m 80 m 0 m 80 2 r 0 3 r 40 m 80 3 r 0 m 80 m 0 m 80 m 10 m 80 2 r 0 c r 80 m 21 m 80
4 r 0 m 4 m 0 m 10 m 0 m 10 m 0 5 r 40 m 0 m 80 m 0 m 40 m 0 5 r 4 m 80 m 82 m 80 m 0 3 r 80 m 20 m 0 m a0 m 80 m 0 m 11 m 80
m 91 m 5 m 3 m 8 m 4 m 9 m 40 m 0 m 20 m 3 m 80 m 84 m a1 m 84 m 0 2 r 80 m 10 m 0 m 85 m 80 m 0 10 r 10 m 4 m 0 m 2 m 1 m 4 m
c0 m 20 m 0 m 8 m 0 m 82 m 0 m 10 m 2 m 84 m 40 m 8 m 0 m 82 m 0 m 10 m 88 m 4 m 8 m 40 m 0 m 2 m 0 m 84 m 2 m 4 m 40 m 8 m 0
m 4 m 0 m 2 2 r 88 m 0 9 r 20 m 0 m 82 m 0 m 8 3 r 4 m 90 m 0 m 84 m 1 m a0 m a1 m 84 m 0 6 r 4 m 0 m 1 m 0 m 20 m 90 m 0 m 84
m 1 m 8 m c1 m 4 m 0 m 90 m 0 m 10 m 0 m 84 m 40 m 82 m 0 m notbusy
02 wcmd 0 m cf m 0 m \ 0xcf00 
88 m 2 m 4 m 0 m 41 m 1 m 85 m 0 m 89 m c0 m 4 m 1 m 82 m 10 m a1 m a0 m 2 m 0 m 84 m 0 m c0 m 2 m 4 m 0 10 r 1 m 4 m 2 m 0 m
4 m 0 m 20 m 10 2 r 20 m 2 m 0 m 10 m 0 m 2 m 84 m 10 m 4 m 40 m 0 m 88 m 0 m 2 m 4 2 r 20 m 2 m 0 m 40 m 2 2 r 10 m 4 m 88 m
8 m 0 m 2 m 0 m 4 m 10 2 r 0 8 r 88 m 20 m 0 m 88 m 0 m 8 m c0 m 20 2 r 2 2 r 84 m 0 m 40 m 9 m 90 m 0 4 r a0 m 0 m 4 m 0 m 1
m 0 m 4 m 8 m 0 m 84 m 0 m a0 m 4 m 40 m 10 2 r 0 m 20 m 0 m 84 m 8 2 r 10 m 40 m 1 m 4 m 40 m 1 m c1 2 r c0 m 40 m 1 m 2 m 84
m 8 m 21 m 20 m a0 m 2 m 0 m 2 m 0 m 84 m 40 m 4 m 0 10 r 80 m 0 8 r 80 m 0 m 80 m 0 3 r 80 2 r 0 5 r 4 m 0 7 r 84 m 80 m 0 m
80 m 0 m 80 m 0 m 80 m 0 f r 80 2 r 0 2 r 80 2 r 0 2 r 80 m c0 m 0 3 r 5 m 0 3 r 80 m 0 m 10 m 0 m 80 m 0 5 r 80 m 0 m 80 2 r
0 2 r notbusy
20 wcmd 0 m d0 m 0 m notbusy \ 0xd000
02 wcmd 0 m d0 m 0 m \ 0xd000 
0 2 r a0 m 80 2 r 91 m 4 m 84 m 41 m 20 m 40 m 4 m 80 m 83 m 8 m 80 m c1 m 80 m 40 m 0 2 r 80 m 0 m 80 m 0 3 r 80 m 0 11 r 5 m
0 m 40 m 80 m 0 5 r 80 m c0 m 0 4 r 80 m 2 m 80 m 83 m 80 m 0 m 80 m 0 2 r 3 m 80 m a1 m 0 m 80 2 r 0 m 80 m 11 m 80 m c0 m 80
m 0 m 80 m 0 9 r 80 m 10 m 80 m a0 m 80 m 0 4 r 40 m 0 m 2 m 80 2 r 0 7 r 4 m 0 5 r 4 m 80 m 2 m 0 2 r 80 m 0 m 80 m 10 m 80 m
c0 m 0 2 r 80 m 0 m a0 m 84 m 20 m 2 m c0 m 80 m 4 2 r 20 m c0 m a1 m c0 m 0 2 r 83 m 9 m 80 m 0 2 r 84 m 0 2 r 80 m 0 11 r 2
m 0 m 4 m a0 m 40 m 88 m 10 m 0 m 2 m 0 m 10 m 4 m 2 2 r 84 m 0 m 8 m 1 m 20 m 82 m 84 m 40 m 4 m 0 m 2 m 0 m 8 m 40 m 2 m 84
m 4 m 0 m 8 m 0 m 20 2 r 2 m 40 m 2 m 0 9 r 8 m 1 m 8 m 9 m 40 m 88 2 r 0 m c0 m 1 m 84 m 21 m 2 m 40 m 84 m 0 6 r 1 m 0 4 r
90 m 0 m 20 m a1 m 40 2 r 4 m 0 m notbusy
02 wcmd 0 m d1 m 0 m \ 0xd100 
10 m 0 m 20 m 82 m 84 m 88 m 8 m 0 m 41 m c0 m 91 m 1 m 85 m 84 m 85 m 0 m 84 m 9 m 2 2 r 20 2 r 4 m 0 m 4 m 0 m c0 m 3 m 40 2
r 4 m 0 15 r b m 0 7 r b m 0 7 r b m 0 7 r b m 0 7 r b m 0 f r b m 0 2 r 12 m 0 3 r d0 m b m 0 m 50 m 0 6 r d0 m b m 0 7 r b m
0 2 r a m 0 4 r b m 0 6 r d0 m b m 0 m 50 m 0 4 r d0 m b m 0 m 50 m 0 5 r b m 0 13 r 7e m fe m ff 3 r 0 m ff m 38 m 66 4 r bc
2 r 2c 2 r ff m 19 m ff m 0 m 3e m 38 m 3e m 38 m 66 4 r 6e 2 r 66 m 6e m f2 m f3 m f0 2 r ff m 10 m ff m 18 m 0 8 r 3c 2 r f0
m b4 m f8 2 r f0 m f8 m f0 2 r fc m f8 m 3c m fd m 3c m 4 m 0 a r ff m 3f m c0 m 0 m notbusy
02 wcmd 0 m d2 m 0 m \ 0xd200 
3c 4 r 66 4 r 6e m 66 m 6e 2 r ff m 0 m ff m 0 m 6e 4 r 66 m 7f m 66 m 40 m fd m 4 m fc m c m ff 2 r f3 m f7 m ff m 0 m ff m 0
11 r 42 m 2 m 0 2 r ff m 0 m c7 m 0 m 7f m 66 m 40 m 66 m 3c m bc m 3c m 2c m e6 m 0 m ff m 0 m 3c 2 r 3e m 38 m 7f m 40 m 66
2 r 62 2 r 66 m 62 m b0 m 30 m f0 2 r ef m 0 m e7 m 0 9 r 3c 4 r e0 2 r f0 m e0 m f0 2 r c0 m e0 m 3c 4 r 0 a r ff m 7f m 80 m
0 m 6c m 66 m 3c 2 r f7 m 4 m 66 2 r 62 m 66 m 62 2 r ff m 3f m ff m 0 m 66 2 r 6e 2 r 66 4 r ff m 0 m ff m 0 m c m 8 m 0 2 r
bc m 2c m ff m 0 5b r notbusy
02 wcmd 0 m d3 m 0 m \ 0xd300 
0 32 r c m 0 6 r ff m 8 m ef m 0 2 r ff 2 r f8 m ff 3 r f 3 r 1e m ff 2 r 4f m ff m ef m ff m cf m ff 3 r 67 m ff m 1 m ff m 3
m ff m 3c 2 r bf m 3c m ef m cf m ff 2 r 0 8 r ff 2 r 7f m 3f m cf m df m ff 2 r ef m e7 m ff 2 r 66 4 r 0 a r 10 m 18 m ff 2
r 20 m bf m 3c 2 r 1c m 0 m 7c m ff m 66 m 6c m 66 2 r 0 2 r 42 m ff m 3c 3 r fc m 0 m 30 m cf m ff m 0 m ff m 8 m ef m 10 m
ff m 18 m ff m 3c 4 r 0 11 r ff m 9 m 6f m 2 m 6 m fe m f6 m 0 2 r 7 m 0 m f m 1e m f m 1e m 0 3 r b0 m 0 m 10 m 0 m 30 m 0 2
r 64 m 0 2 r fe m 0 m fc m 3c 2 r 20 m 3c m 0 2 r 10 m 30 m 0 a r 1 m 3 m c m 4 m 0 4 r 10 m 18 m 66 2 r 3c m 6c m 0 6 r
notbusy
02 wcmd 0 m d4 m 0 m \ 0xd400 
0 6 r ef m e7 m 3c 4 r 0 2 r ff 2 r 6c 2 r 66 2 r 0 2 r ff 2 r 3c m fc m 3c m fc m 0 m 10 m ef m ff m 0 m ff m 9 m 6f m 0 m ef
m 0 m e7 m 3c 2 r 2d m f m 0 13 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 7 r 8 m 0 f r 8 m 0 5 r 61 m 0 m e m 0 m d m 0 4 r 5 m
61 m a m e m 5 m d m 0 m a0 m 0 3 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 5 m 0 5 r 8 m 0 f r 1 m 10
m 0 45 r notbusy
02 wcmd 0 m d5 m 0 m \ 0xd500 
0 18 r 2f m af m 7 m 5 m aa 4 r ff 4 r 3c 4 r 0 16 r 80 m 0 5b r f 4 r b2 m aa m b2 2 r 0 2 r 3c m 28 m 3c 4 r 0 11 r 2 m 0 44
r notbusy
02 wcmd 0 m d6 m 0 m \ 0xd600 
0 1c r 55 2 r fd m 55 m aa 2 r 3a m aa m ff m c3 m 0 2 r ff 2 r f4 2 r 0 10 r 2 m 0 61 r 55 2 r 1 m 55 m 3a m aa m 3a m aa m
ff m d7 m 0 28 r 20 m 0 m 20 m 0 3 r 4 m 0 m 4 m 0 m 4 m 20 m 84 m 0 3 r 84 m 0 m 88 m 0 m 88 m 0 1b r notbusy
02 wcmd 0 m d7 m 0 m \ 0xd700 
0 4 r 82 m 9 m 0 12 r 4 m 0 m 4 m 0 m 2 m 0 m 2 m 0 7 r 84 m 0 2 r 89 m 88 m 89 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 4 m
0 m 4 m 0 5 r 3 m 0 1a r 80 m 0 m 80 m 0 m 80 m 1 m 0 28 r 3 m 0 2 r 3 m 0 10 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 a r 4 m 0 m
4 m 9 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 1 m 0 m 1 m 0 10 r ff 36 r notbusy
02 wcmd 0 m d8 m 0 m \ 0xd800 
ff 4c r 0 m 1a m f9 m 84 m 30 m 22 m 0 m 10 m 0 m 3 m 50 m 60 m 0 2 r 8 m e3 m 0 f r 10 m 0 5 r 88 m 0 m 8 m 0 17 r c0 m 0 7 r
8 m 0 21 r 8 m 0 1f r 82 m 0 9 r 5 m 0 m 5 m 0 3 r 5 m 4 m 21 m 8 m 0 m 4 m 20 m 4 m 3 m 4 3 r 0 3 r 4 m 0 2 r 5 m 0 5 r 3 m 0
m 41 m notbusy
02 wcmd 0 m d9 m 0 m \ 0xd900 
1 m 0 2 r 41 m 0 3 r 80 m 8 m 0 m 1 m 82 2 r 21 m 0 3 r 3 m 0 m 5 m 0 2 r 1 m 0 6 r 4 m 0 a r 1 m 0 3 r 1 m 21 m 1 m 41 m 0 9
r 80 m 0 3 r 85 m 0 m 80 m 0 2 r 4 m 0 m 1 m 0 m 1 m 0 19 r 21 m 0 7 r 80 m 0 3 r 80 m 1 m 80 m 8 m a1 m 1 m 80 m 0 2 r a0 m
80 m 0 b r 20 m 0 5 r 3 m 4 m 0 2 r 4 2 r 5 m 84 m 41 m 0 3 r 41 m 0 3 r 20 m 0 5 r 8 m 1 m 0 2 r 41 m 0 7 r 20 m 0 m 3 m 0 m
20 m 0 m 20 m 0 a r 20 m 3 m 0 m 3 m 20 m 8 m 20 m 0 2 r 80 m 0 m 4 m 0 m 4 m 0 a r c0 m 0 10 r 20 m 0 m 20 m 0 m 20 m 80 m 0
4 r 90 m 0 m a0 m 0 5 r 40 m 0 m 1 m 80 m 2 m 0 m a0 m 0 3 r notbusy
02 wcmd 0 m da m 0 m \ 0xda00 
4 m 0 m a0 m 0 m 4 m 0 3 r 4 m 0 m 82 m 0 m 40 m 0 m 40 m 0 m c0 m 80 m 0 4 r a0 m 0 3 r 4 m 0 m 82 m 80 m 8 m 0 m 4 m 0 5 r
40 m 0 m 40 m 0 m 40 m 80 m 0 2 r 82 m 0 m 82 m 0 2 r 80 m 1 m 0 m 2 m 0 m 4 m 0 m 3 m 0 3 r 2 m 0 m 82 m 0 m 88 m 80 m 0 22 r
80 m 0 m 80 m 0 m 80 m 4 m 0 e r 4 2 r 0 a r 80 m 0 3 r 80 m 0 8 r 20 m 0 8 r 80 m 0 2 r 4 m 0 2 r 80 m c0 m 0 6 r 41 m 0 2 r
4 m 0 5 r 20 m 0 m 4 m 2 m 0 m 80 m 0 m 80 m 0 m 4 m 0 8 r 20 m 0 d r 88 m 0 2 r 8 m 0 3 r 8 m 0 m 11 m 0 7 r 8 m 0 m 20 m 4 m
0 m 4 m 0 m 4 m 0 3 r 21 m 0 m 80 m 0 2 r c0 m 20 2 r 41 m 82 m 41 m 20 m 4 m 20 m 0 m 20 m 4 m notbusy
02 wcmd 0 m db m 0 m \ 0xdb00 
20 m 4 m 20 m 0 m 20 m 4 4 r 0 m 4 m 41 m 4 2 r 0 m a0 m 4 m 20 m 0 m 4 2 r 0 m 82 m 80 m a0 m c1 m 0 m 80 m 82 m 80 m 1 m 4 2
r 80 m 1 m 0 m a1 m 0 5 r 20 m 4 m 20 m 4 m 20 m 41 m 0 3 r 84 m 0 m 4 m 0 9 r 41 m 0 2 r 83 m 0 2 r 80 m 8 m 0 m c0 m 80 m 0
4 r 82 m 0 b r 8 m 0 d r 83 m 1 m 0 m 1 m 41 m 1 m 0 m 84 m 0 3 r 20 m 0 3 r 1 m 80 m 0 3 r 80 m 89 m 80 m 0 m 80 m 1 m 80 m 1
m 80 m 0 m 80 m 1 m 80 m 1 m 80 m 84 m 80 m 0 m 80 m 85 m 0 m 21 m 80 m 1 m 0 m 1 m 80 m 0 m 8 m 20 m 8 m 20 m 8 m 20 m 0 m 20
m 4 m 1 m 88 m 20 m 4 m 0 m 4 m 0 5 r 80 m 1 m 83 m 1 m 80 m 0 m 3 m 0 2 r 5 m 0 m 1 m 3 m 0 2 r c0 m 0 4 r 11 m c0 m 0 m 10 m
4 m 0 2 r 20 m 0 3 r 20 m 0 3 r 84 m 0 16 r 5 m 0 3 r 82 m 3 m 90 m 0 3 r 8 m 41 m 90 m 20 m 0 m 20 m 90 m 0 m 88 m 8 m 0 m 41
2 r 0 2 r 9 m notbusy
02 wcmd 0 m dc m 0 m \ 0xdc00 
40 m 4 m 2 m 0 m a0 m 0 2 r 4 m a0 m 0 m 20 m 41 m 0 m 4 m 20 m 4 m 0 3 r 4 m c0 m 4 m 8 m 20 m 0 m 4 m 0 2 r 82 m 4 m 0 2 r 8
m 4 m 0 2 r 83 m 0 m 9 m 4 m 20 m 9 m 0 2 r 20 m 4 m 0 m 4 m c0 m 0 3 r 40 m 4 m 40 m 0 m 40 m 20 m 40 m 0 m 90 m 11 m 0 m 11
m 90 m 0 m 88 m 41 m 88 m 0 3 r 40 m 0 3 r c0 m 0 4 r 9 m 0 3 r 4 m 0 m 9 m 0 m 9 m 0 m 40 m 0 19 r 1 m 0 m 1 m 0 6 r 20 m 0 a
r 1 m 0 2 r 80 m 0 2 r 1 m 80 m 1 m 0 3 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 5 r 84 m 0 4 r 20 m 0 m 4 m 1 m 80 m 0 3 r 80 m 1 m 0
7 r 1 m 0 2c r 8 m 0 m 41 m 0 2 r 8 m 0 m 2 m 5 m 0 3 r 1 2 r 89 m 0 3 r 90 m 2 m 0 m 40 m 0 m 8 m c0 m 10 m 5 m 2 m notbusy
02 wcmd 0 m dd m 0 m \ 0xdd00 
83 m 5 m 2 m c0 m 4 m 5 m 0 4 r 2 m 0 3 r 10 m 4 m 9 m 5 m 88 m 4 2 r 82 m c0 m 41 m 1 m 83 2 r 21 m 84 m 10 m c0 m 40 m 0 m
c0 m 0 m c0 m 8 m 90 3 r 0 m 5 m 89 m c1 m 84 m a0 m 0 3 r 1 m 0 m 1 m 88 m 0 2 r 1 m 0 4 r 4 m 0 6 r 40 m 0 4 r a0 m 40 m a0
m 40 m 0 m 8 m 90 m 4 m c0 m 8 m 0 m 4 m a0 m a1 m 82 m 83 m 1 3 r 0 m 4 m 1 m 0 m 1 m 0 11 r 2 m 41 m 3 m 2 m 11 m 0 m 4 m 0
5 r 80 m 0 m 80 m 2 2 r 3 2 r 5 m 3 m 80 m 3 m 0 m 9 m 11 m 5 m c0 m 2 m 0 m 5 m 80 m 5 m c0 2 r 40 m 11 m 80 m a0 m 0 m 2 m
41 m 82 m 4 m 2 m 0 m 83 m 80 m 0 5 r 80 m 0 2 r 41 m 40 m 3 m 2 m 4 m 0 m 4 m 0 3 r 40 m 5 m 8 m 5 m 3 m 0 m 20 m 0 m 5 m 40
2 r c0 m 5 m 0 m 9 m 0 9 r 80 m 0 3 r 80 m 0 m 80 m 83 m 85 m 21 2 r 5 m 20 m 0 m 20 m 11 m 40 m 41 m 40 2 r 20 m 0 m 11 m 0
10 r 2 m 0 m 5 m 0 m 11 m 0 m 4 m 90 m 80 m 0 2 r 2 m 80 m 0 m notbusy
02 wcmd 0 m de m 0 m \ 0xde00 
80 m 0 m 41 m 0 m 2 m 4 m 89 m c0 m 3 m 2 m 9 m 89 m 5 m 0 m 9 m 0 m 5 3 r 80 m 3 m 4 m c0 m 0 m a0 m 91 m 40 m 80 m 2 m 40 m
82 m 80 m 10 2 r 0 2 r 80 m 3 m 0 m 80 m 0 2 r 3 m 80 m c1 m 4 2 r 40 m 2 m 11 m 0 2 r 2 m 0 m 5 m 0 m 3 m 0 m 20 m 11 m 40 m
80 m 3 m 0 m 5 m 0 m 2 2 r 0 3 r 80 m 0 3 r 80 m 0 3 r 40 m 80 m 40 m 80 m 0 m 5 m 80 m a1 m 4 m 5 m c0 m 9 m 4 m 85 m 0 m 2 m
0 m a0 m 0 m 40 m 2 m 0 11 r a0 m 0 5 r 3 m 8 m 0 m 2 m 0 m 8 m c0 m 8 m 0 m 4 m 2 m 4 m 0 m 20 m 40 m 85 m 83 m 0 m 8 m 0 6 r
2 2 r 4 m 0 m 85 m 2 m 4 m 8 m 41 m 2 m c1 m 1 m 85 m 84 m 88 m 84 m 40 m 0 m 82 m 1 m a0 m c0 m 90 m 84 m 40 2 r 10 m 0 m 21
m 20 m 84 m 40 m 0 3 r 2 m 0 6 r 1 m 2 m 0 9 r 4 m 0 3 r 4 m c0 m 0 m 40 m 0 m 4 m a1 m 82 m 0 m 90 m 2 m 40 m 0 m a1 m 3 m 82
m 85 m 4 m 82 m c1 m 0 m 41 m 0 2 r 1 m 0 8 r 20 m 0 8 r 1 m 0 6 r 8 m 2 m notbusy
02 wcmd 0 m df m 0 m \ 0xdf00 
0 m 10 m 0 m 82 m 10 2 r 4 m 2 m 0 m 89 m 2 m 88 m 20 2 r 0 8 r 88 m 4 m 1 m 4 m 0 m 3 m 4 m 10 m a0 m 41 m 1 m 41 m 4 m 20 m
8 m 5 m 88 m 40 m 0 m a0 m 0 m 4 m 85 m 90 m 40 2 r 0 m a0 m 84 2 r 85 m c0 m 0 3 r 1 m 0 12 r 4 m 40 m 0 2 r 4 m c0 m 0 m 40
m 82 m 8 m c0 m 4 m c0 m c1 m 0 m 9 m c0 m a0 m c1 m c0 m 0 m 1 2 r 0 3 r 1 2 r 0 11 r 20 m 5 m 11 m 4 2 r 0 m 4 m 80 m 0 2 r
80 m 0 5 r 2 m 11 m 2 2 r 41 m 0 m 40 m 0 m 9 m 11 m 5 m 3 m 2 m 0 m 5 m 0 m 5 m 3 m 83 m 3 m 5 m 84 m a0 m 0 m 10 m 40 m c0 m
90 m 41 m 80 m 40 m 0 6 r 20 m 0 2 r 41 m 40 m 3 m 41 m c0 m 20 m 4 m 0 3 r 40 m 5 m 3 m 41 m 9 m 0 m 5 m 0 m 9 2 r 3 m 2 2 r
0 m 9 m 5 m 0 3 r 80 m 0 3 r 80 m 0 4 r 80 m 84 m 80 2 r 4 m 21 m 88 m 20 2 r 40 m 4 m 0 m 40 m 3 4 r 2 2 r 0 10 r 10 m 80 m
11 m 0 m 4 m 0 m notbusy
20 wcmd 0 m e0 m 0 m notbusy \ 0xe000
02 wcmd 0 m e0 m 0 m \ 0xe000 
4 2 r 80 m 0 m 80 m 5 m 80 m 0 3 r 2 m 91 m 2 m 84 m 11 m 0 m 3 m 2 m 10 m 80 m 5 m 9 m 2 m 0 m 3 m 11 m 85 m a0 m c0 m a1 m
20 m 0 m 84 2 r c0 2 r 40 m 89 m 2 m 0 m 20 m 10 m 0 3 r 4 m 0 4 r 40 m 9 m 5 m 9 m 84 m 0 m 4 m 11 m 0 2 r 40 m 9 m 3 m 5 m 3
m 0 m 20 m 11 2 r 40 m 21 m 0 m 5 m 0 m 20 m 9 m 0 m 2 m 80 m 2 m 0 6 r 80 m 41 m 80 3 r 0 m 85 m 2 m 20 m 82 m 84 m 80 m 20 m
41 m 40 m 0 m 20 m 40 m 3 m 80 m 20 m 2 m 0 11 r 2 m 0 6 r 4 m 0 m 10 m 40 m 8 m 88 m 10 m 0 m 2 m 40 m c1 2 r 20 2 r 4 m 1 2
r 2 m 0 4 r 1 m 0 m 8 m c1 m 5 m 4 4 r 90 m 4 m 2 m 5 m 84 m 21 m 20 m 41 m 0 m 4 m 0 m c0 m c1 m 90 m 88 m 40 m 0 m c0 m 40 m
c0 m a0 m 3 m a0 m 84 m 0 3 r 1 m c0 m 0 2 r 1 m 0 4 r 40 m 0 4 r 1 m 0 2 r 1 m 20 m 1 m 0 m 40 m 0 2 r 82 m 0 m 82 m a0 m 8 2
r 4 m 0 m 40 m a1 2 r 3 m 85 m 84 m 83 m 1 2 r c0 m 1 m a0 m 0 m 84 m 0 m 1 m 0 12 r notbusy
02 wcmd 0 m e1 m 0 m \ 0xe100 
0 m d0 m 0 2 r 60 m 0 5 r b m 0 6 r d0 m b m 0 m 41 m 0 4 r d0 m 0 7 r d0 m b m 0 m 42 m 0 4 r d0 m b m 0 m 60 m 0 5 r b m 0 m
88 m 21 m 0 3 r d0 m b m 0 8 r d0 m 0 7 r d0 m 0 8 r b m 0 7 r b m 0 2 r a m 0 3 r d0 m b m 0 m 60 m a m 0 3 r d0 m b m 0 m 50
m 0 19 r 28 m 2a m eb m ea m d3 m ff 3 r 0 m ff m 80 m bf m f4 m f0 m fc m f0 m 0 8 r 2a m 0 m ea m ff m 0 m c m f3 m ff m 0 m
10 m ef m ff m f0 4 r 20 m 0 m ef m ff m 0 m ff m 0 m ff m e0 m ff m 0 m ff m d0 m f0 m f8 m f0 m 0 13 r ff m 0 3 r ff m 0 4 r
ff 3 r fe m ff m fa m 0 m c1 m ff 2 r 3c 4 r 0 16 r notbusy
02 wcmd 0 m e2 m 0 m \ 0xe200 
0 a r aa 4 r 0 m 2c m 0 3 r ff m 82 m be m e0 m f0 m c0 m f0 m 0 a r ff 2 r 0 m 4 m fb m ff m 0 m 14 m eb m ff m e0 m c0 m f4
m fc m 28 m 0 m eb m ff m 10 m fb m 30 m f3 m 0 m 1f m 0 m ff m c0 m f0 m fc m f0 m 0 13 r ff m 0 3 r ff m 0 3 r 70 m 8f m ff
m 0 m 2 m 0 m a m 0 2 r ff m 3e m 3c m 78 m 3c m f0 m 0 20 r 3e m 34 m 3c 2 r ff 2 r 0 2 r 4f m e m f 2 r be m 3c m 14 m 3c m
0 8 r 3c m fd m 3c 2 r fd m 8 m ff m 0 m ff m 7c m ff 2 r 55 m 7d m 55 m 41 m ff m 4f m ff 3 r d7 m ff m df m cf m c m 8f m d
m 55 4 r 0 14 r ff m 0 3 r ff 5 r f1 m ff m b0 m 4f m 0 m ff m fe m 1 m 0 m f 2 r 3c m f m 0 4 r 7c m 0 m 7c m 0 b r notbusy
02 wcmd 0 m e3 m 0 m \ 0xe300 
0 e r be m 14 m 3c 2 r f5 m fd m 5 m 1 m cf m c m f 2 r bc m 3c m 1c m 3c m 0 8 r 3c m 8 m 3c 2 r fd m 8 m fd m 8 m 0 m 2c m 0
2 r 55 m 75 m 55 m 45 m 0 m e m 0 2 r 28 m 0 m 20 m 0 m f 4 r 4d m 55 m 4d 2 r 0 14 r ff m 0 6 r e m 0 2 r ff m 0 m ff m 0 m
ff m fc m 3 m 0 m f 2 r 2d m f m 0 4 r ff m 0 m ff m 0 12 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61
m 0 m 1 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 5 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 5 r 61 m 0 m 1
m 0 m 1 m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 2 r 15 m 0 m 2a m 8 m 5 m 40 m 0 m a8 m 0 3 r 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m
0 m 9 m 0 m 1 m 0 8 r notbusy
02 wcmd 0 m e4 m 0 m \ 0xe400 
0 a r ff 2 r 57 m ff m bf m ff m bf 2 r 0 8 r 3c m f m 3c 2 r 0 m c m f3 m ff 2 r be m 0 m 14 m ae m aa m ae 2 r 55 m df m 55
2 r f0 4 r 3c 2 r 35 m 3c m fc m 3c m bc m 3c m 0 8 r ff m 0 m ff m 34 m f0 4 r 0 2 r fc m bc m 3c 2 r 0 2 r ff 2 r 55 m 5c m
55 m 3c m f0 4 r 0 10 r 2d m f m 2d m f m 3c 4 r 5c 2 r 3c m 5c m f0 2 r e8 m f0 m 0 c r 80 m 0 3 r a8 m 0 3 r 80 m 0 m 80 2 r
0 8 r 3c m 1e m 3c 2 r 0 m 4 m fb m ff 2 r bf m 0 m 10 m a2 m aa m a2 2 r 55 m 10 m 55 2 r e8 m f0 m e8 2 r 3c 2 r 55 m 3c m c
m 3c m 1c m 3c m 0 8 r ff m 0 m cb m 0 m f0 2 r b2 m aa m 0 2 r c m 1c m 3c 2 r 28 m 20 m eb m ef m 55 4 r f0 m 3c m f0 m 78 m
0 10 r f 2 r 2d m f m 34 m 14 m 3e m be m 3c 4 r f0 2 r aa m f0 m 0 2 r notbusy
02 wcmd 0 m e5 m 0 m \ 0xe500 
0 9 r 4 m 0 4 r ff m 8 m f7 m 0 m ff m fc m ff m fd m 0 8 r 4d m f 3 r 1c m bc m 3c 2 r ff m 57 m ff 2 r fb m ff m f3 m ff 2 r
4f m ff 2 r f4 m f0 m fc m f0 m ff m fe m 0 m 4 m 3e 2 r 3c m 3e m 0 8 r ff m 28 m ff m 20 m 3c 4 r 0 2 r 3e m be m 3c 2 r 2 m
a m fe m fa m ff m 75 m 0 m 45 m f0 4 r 0 10 r 3c m 35 m 3c m 35 m fd m f5 m ff 3 r 0 m ff m 0 m 80 2 r fd 2 r 0 e r 40 m 0 m
ff m a m f5 m 0 2 r c m 0 m 8 m 0 8 r 4d 2 r f 2 r c m fc m 3c 2 r 0 m 54 m 0 3 r 4 m 0 m c m 0 m e m 0 2 r e0 m f0 m c0 m f0
m ff m be m 0 m 14 m 34 2 r 3c m 34 m 0 8 r d7 m 0 m df m 0 m 3c 2 r aa m ac m 0 2 r 34 m 14 m 3c 2 r 0 2 r ff 4 r 0 2 r f0 2
r b4 m 3c m 0 10 r 3c 3 r 35 m 0 2 r 2 m a m be m 14 m bf m 10 m 80 m 0 m notbusy
02 wcmd 0 m e6 m 0 m \ 0xe600 
fd m ff m 0 10 r 20 m 0 b r 20 m 0 m 20 m 0 m 20 m 0 3 r 20 m 0 9 r 88 m 0 m 20 m 0 6 r 10 m 0 4 r 20 m 0 m 20 m 0 m 20 m 0 3
r 20 m 0 d r 2 m 0 m 4 m 0 9 r 20 m 0 m 20 m 0 m 4 m 0 3 r 20 m 0 m 4 m 0 m 84 m 0 4 r 8 m 84 m 8 m 0 d r 5 m 0 m 8 m 0 3 r 80
m 0 5 r c0 m 0 m c0 m 0 m a0 m 0 m c0 m 0 6 r 4 m 0 17 r 5 m 0 23 r 20 m 0 d r 9 m 0 a r 8 m 0 m 8 m 0 e r notbusy
02 wcmd 0 m e7 m 0 m \ 0xe700 
0 5 r 1 m 0 3 r 8 m 0 5 r 5 m 0 m 11 m 0 m 9 m 0 m 9 m 0 7b r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 35 r c0 m 0 32 r notbusy
02 wcmd 0 m e8 m 0 m \ 0xe800 
0 13 r 2 m 0 m 4 m 0 m 10 m 0 m 20 m 0 33 r 41 m 0 13 r 41 m 0 4 r 82 m 0 2d r 10 m 0 m 40 m 0 2 r 84 m 0 m 80 m 0 9 r 84 m 0
4 r 21 m 0 8 r 10 m 0 6 r 3 m 0 5 r 41 m 0 m 21 m 0 d r 3 m a0 m 0 m c0 m 0 6 r 21 m 0 3 r 21 m 0 1b r 3 m 0 5 r notbusy
02 wcmd 0 m e9 m 0 m \ 0xe900 
0 6 r 21 m 0 7 r 3 m 0 3 r 8 m 0 m 8 m 0 m 80 m 0 m 80 m 0 2 r 3 m 0 m 10 m 0 e r a0 m 0 15 r c0 m 0 15 r 90 m 0 3 r 8 m 0 f r
40 m 0 3 r 8 m 0 m 4 m 0 d r 82 m 0 9 r a0 m 0 m 8 m 0 m c0 m 0 11 r ff 60 r notbusy
02 wcmd 0 m ea m 0 m \ 0xea00 
ff 22 r 0 m 19 m f1 m 5 m 30 m 22 m 0 m 11 m 0 m 8 m 50 m 60 m 0 2 r 3 m 8e m 0 1e r 82 m 0 43 r 8 m 0 m 82 m 0 5 r c0 m 0 7 r
8 m 0 5 r a0 m 0 m 8 m 0 5 r 8 m 0 5 r 21 m 0 2 r 84 m 0 6 r 21 m 84 m 0 5 r 8 m 0 m 10 m 21 m 0 a r a0 m 0 3 r c0 m 0 6 r 21
m 10 m 0 3 r 84 m 3 m 0 2 r 84 m 0 6 r 8 m c0 m 0 7 r c0 m 0 m c0 m 0 2 r notbusy
02 wcmd 0 m eb m 0 m \ 0xeb00 
0 d r c0 m 0 4 r 21 m 0 8 r c0 m 21 m 0 1f r 4 m 0 8 r 41 m 90 m 9 m 0 5 r 10 m 0 6 r 82 m 0 7 r 20 m 0 f r 88 m 0 m 90 m 0 2
r 40 m 0 3 r 40 m 0 16 r 20 m 0 9 r 2 m 0 m 2 m 0 m 8 m 0 b r 8 m 0 5 r 90 m 0 m c0 m 0 51 r notbusy
02 wcmd 0 m ec m 0 m \ 0xec00 
0 37 r 20 m 0 76 r c0 m 0 4 r 1 m 0 2 r 40 m 0 m 1 m 83 m 0 m 40 m 0 44 r notbusy
02 wcmd 0 m ed m 0 m \ 0xed00 
0 30 r 80 m 0 4 r 3 m 0 4 r 20 m 40 m 0 81 r 80 m 83 m 0 41 r notbusy
02 wcmd 0 m ee m 0 m \ 0xee00 
0 3f r 4 m 9 m 0 81 r c0 m 83 m 0 3c r notbusy
02 wcmd 0 m ef m 0 m \ 0xef00 
0 42 r 9 m 41 m 0 m 10 m 0 7b r 2 m 0 m 40 m 3 m 20 m 4 m 83 m 0 38 r notbusy
20 wcmd 0 m f0 m 0 m notbusy \ 0xf000
02 wcmd 0 m f0 m 0 m \ 0xf000 
0 43 r 1 m 0 2 r 84 m 1 m 0 m 5 m 0 73 r 12 m 0 2 r 20 m 0 m 48 m 0 5 r 40 m 0 3 r ff 34 r notbusy
02 wcmd 0 m f1 m 0 m \ 0xf100 
ff 4e r 0 m 2b m 4e m 93 m 30 m 22 m 0 m 11 m 0 m 16 m 50 m 60 m 0 3 r c3 m 0 78 r 1 m 2 m 0 m 8 m 0 26 r notbusy
02 wcmd 0 m f2 m 0 m \ 0xf200 
0 4a r 2 m 0 17 r ff 82 r 0 m 6 m 9c m 5f m 30 m 22 m 0 m 11 m 0 m 1d m 50 m 60 m 0 2 r 4 m 51 m 0 c r notbusy
02 wcmd 0 m f3 m 0 m \ 0xf300 
0 61 r 1 m 0 14 r ff 8a r notbusy
02 wcmd 0 m f4 m 0 m \ 0xf400 
ff 7a r 0 43 r 1 m 0 42 r notbusy
02 wcmd 0 m f5 m 0 m \ 0xf500 
0 3f r 82 m 0 3 r 2 m 0 7d r 4 m 0 2 r 1 m 0 3b r notbusy
02 wcmd 0 m f6 m 0 m \ 0xf600 
0 47 r 68 m 0 4 r 15 m 0 m 85 m 0 2a r 8 m 0 20 r 90 m 0 28 r 3 m 0 8 r 88 m 0 27 r 20 m 0 b r notbusy
02 wcmd 0 m f7 m 0 m \ 0xf700 
0 76 r 80 m 0 18 r 80 m 0 6 r 1 m 0 18 r 4 m 0 19 r 80 m 0 17 r 4 m 0 1e r notbusy
02 wcmd 0 m f8 m 0 m \ 0xf800 
0 11 r 8 m 0 6 r 20 m 0 10 r 8 m 0 7 r 1 m 0 7 r 84 m 0 11 r 8 m 0 17 r 1 m 0 4f r 8 m 0 19 r 4 m 0 32 r notbusy
02 wcmd 0 m f9 m 0 m \ 0xf900 
0 35 r 1 m 0 19 r 1 m 0 47 r 80 m 0 7 r 8 m 0 m 3 m 0 24 r 8 m 0 22 r 80 m 0 16 r notbusy
02 wcmd 0 m fa m 0 m \ 0xfa00 
10 m 0 18 r 4 m 0 1a r 10 m 0 13 r 10 m 0 5 r 5 m 0 11 r 5 m 0 a r 8 m 0 e r 8 m 0 7 r 90 m 0 10 r 8 m 0 17 r 21 m 0 a r 10 m
0 27 r 84 m 0 3 r 40 m 0 1d r notbusy
02 wcmd 0 m fb m 0 m \ 0xfb00 
0 97 r 2c m 3 m 72 m 30 m a1 m 0 m 2 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 33 m 64 m 0 8 r
30 m 22 m 1 2 r 0 m c m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m d m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m e m 33 m 64 m 0 8 r 30 m
22 m 1 2 r 0 m f m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m 10 m 33 m 64 m notbusy
02 wcmd 0 m fc m 0 m \ 0xfc00 
0 8 r 30 m 22 m 1 2 r 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m 15 m 33 m 64 m 0 8
r 30 m 22 m 1 2 r 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m 19 m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m 1a m 33 m 64 m 0 8 r
30 m 22 m 1 2 r 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m d m 33 m 64 m 0 8 r
30 m 22 m 1 m 4 m 0 m e m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m 10 m 33 m 64 m 0 8 r
30 m 22 m 1 m 4 m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m 13 m 33 m 64 m 0 8
r 30 m 22 m 1 m 4 m 0 m 14 m 33 m 64 m notbusy
02 wcmd 0 m fd m 0 m \ 0xfd00 
0 8 r 30 m 22 m 1 m 4 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 1 m 4 m 0 m 17 m 33 m 64
m 0 8 r 30 m 22 m 1 m 4 m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 1 m 7 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 1 m a m 0 m 17 m 33 m
64 m 0 8 r 30 m 22 m 1 m c m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 1 m e m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 1 m e m 0 m 16 m 33
m 64 m 0 8 r 30 m 22 m 1 m f m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m b m
33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m
10 m 33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m 11 m 33 m 64 m notbusy
02 wcmd 0 m fe m 0 m \ 0xfe00 
0 8 r 30 m 22 m 1 m 11 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 1 m 11 m 0 m 19 m 33 m
64 m 0 8 r 30 m 22 m 1 m 11 m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m a m 30 m a1 m 0 m 1 m 50 m 60 m 0 3 r c3 m 0 11 r
80 m 0 58 r 8 m 0 28 r 8 m 0 14 r notbusy
02 wcmd 0 m ff m 0 m \ 0xff00 
0 4 r 41 m 0 20 r 4 m 5 m 0 5 r 41 m 0 m 5 m 0 m 41 m 0 1b r 21 m 0 8 r 8 m 0 6 r ff 82 r 0 m 17 m f9 m 3e m 30 m 22 m 1 2 r 0
m 12 m 50 m 60 m 0 3 r 41 m 0 12 r notbusy
20 wcmd 1 m 0 m 0 m notbusy \ 0x10000
02 wcmd 1 m 0 m 0 m \ 0x10000 
0 2f r 2 m 0 41 r 1c m b m c8 m 30 m a1 m 0 m 2 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 33 m
64 m 0 8 r 30 m 22 m 1 m 11 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 1 2 r 0 m 14 m 30 m a1 m 0 m 1 m 50 m 60 m 0 3 r 82 m 0 e r
e0 m 7 m 0 6 r e0 m 7 m 0 16 r e0 m 7 m 0 18 r e0 m 7 m 0 4 r notbusy
02 wcmd 1 m 1 m 0 m \ 0x10100 
0 12 r e0 m 7 m 0 16 r e0 m 7 m 0 8 r ff 82 r 0 m 1d m fd m 53 m 30 m 22 m 1 2 r 0 m 16 m 50 m 60 m 0 3 r 82 m 0 8 r 2 m 10 m
0 2 r 80 m 1 m 0 2 r 2 m 10 m 0 2 r 80 m 1 m 0 12 r 2 m 10 m 0 2 r 80 m 1 m 0 c r notbusy
02 wcmd 1 m 2 m 0 m \ 0x10200 
0 8 r 2 m 10 m 0 2 r 80 m 1 m 0 12 r 2 m 10 m 0 2 r 80 m 1 m 0 12 r 2 m 10 m 0 2 r 80 m 1 m 0 a r ff 82 r 0 m 31 m 65 m e3 m
30 m 22 m 1 2 r 0 m 18 m 50 m 60 m 0 3 r 82 m 0 a r 40 m 48 m 12 m 2 m 0 4 r 40 m 48 m 12 m 2 m 0 10 r notbusy
02 wcmd 1 m 3 m 0 m \ 0x10300 
0 4 r 40 m 48 m 12 m 2 m 0 16 r 40 m 48 m 12 m 2 m 0 14 r 40 m 48 m 12 m 2 m 0 14 r 40 m 48 m 12 m 2 m 0 a r ff 82 r 0 m 1e m
cc m 66 m 30 m 22 m 1 2 r 0 m 1c m 50 m 60 m 0 2 r 13 m 4c m 0 9 r 80 m 0 4 r 1 m 0 2 r 80 m notbusy
02 wcmd 1 m 4 m 0 m \ 0x10400 
0 4 r 1 m 0 12 r 80 m 0 4 r 1 m 0 14 r 80 m 0 4 r 1 m 0 12 r 80 m 0 4 r 1 m 0 12 r 80 m 0 4 r 1 m 0 13 r 9 2 r 0 6 r 9 2 r 0
16 r 9 2 r 0 18 r 9 2 r 0 16 r 9 2 r 0 16 r 9 2 r 0 c r 90 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m notbusy
02 wcmd 1 m 5 m 0 m \ 0x10500 
4 m 0 3 r 40 m 0 7 r 4 m 0 m 40 m 0 m c0 m 0 m 2 m 0 m 2 m 0 m 4 m 0 m 2 m 0 3 r 2 m 0 m 90 m 0 f r 20 m 0 5 r 20 m 0 5 r 90 m
0 13 r 20 m 0 m 20 m 0 m 20 m 0 m 88 m 0 9 r c0 m 0 m 88 m 0 11 r 20 m 0 3 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m
0 m 80 m 0 b r 80 m 0 m 80 m 0 3 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 3 r 80 m 0 16 r 3 m 0 1a r 80 m 0 m 80 m 0 m 80 m 0 1f r
80 m 0 2 r 80 m 0 m 80 m 0 6 r notbusy
02 wcmd 1 m 6 m 0 m \ 0x10600 
0 e r 8 m 80 m 0 2 r 40 m 10 m 0 m 10 m 0 2 r 3 m 0 m 1 m 0 m 8 m 0 m 2 m 0 3 r 8 m 0 m 1 m 0 3 r 4 m 0 3 r 4 m 0 4 r 80 m 0 3
r 20 m 0 4 r 8 m 0 m 8 m 0 4 r 20 m 0 3 r 20 m 0 m 20 m 2 m 9 m 1 m 0 m 8 m 0 m 1 m 0 m 1 m 0 5 r 1 m 0 13 r c1 m 0 3 r c0 m 4
m 0 m 80 m 1 m 0 m 20 m 0 m 4 m 0 2 r 20 m 0 m 20 m 0 b r 8 m 0 8 r 80 m 40 m 0 m 90 m 80 m 1 m 0 m 1 m 0 2 r 84 m 0 m 2 m 0 m
80 m 0 m 80 m 0 m 10 m 0 m 80 m 0 m 8 m 82 m 0 2 r 80 m 0 3 r 80 m 0 2 r 90 m 0 m 20 m 0 3 r 1 m 0 4 r 80 m 0 m 80 m 0 4 r 85
m 20 m 82 m 0 m 1 m 0 m 1 m 80 m 0 m 2 m 0 m 80 m 0 m 8 m 0 m 4 m 0 5 r 4 m 0 a r 2 m 0 8 r 2 m 0 m 41 m 0 m 9 m 1 m 0 m 4 m
20 m 0 m 80 m 0 m 80 m 0 2 r 41 m 0 3 r 20 m notbusy
02 wcmd 1 m 7 m 0 m \ 0x10700 
0 3 r 21 m 0 m 2 m 0 3 r 20 m 0 m 11 m 0 7 r 8 m 0 m 2 m 0 m 3 m 0 m 80 m 0 1d r 21 m 0 m 3 m 0 3 r 11 m 0 5 r 2 m 20 m 8 m 0
m 21 m 0 m 9 m 0 9 r 5 m 0 m 8 m 0 m 4 m 0 m 20 m 0 3 r 40 m 0 9 r 9 m 0 3 r 3 m 0 5 r 11 m 0 m 4 m 0 3 r 5 m 0 m 5 m 0 m 3 m
0 5 r 1 m 0 9 r 1 m 0 f r 40 m 0 16 r 4 m 0 d r 21 m 0 3 r 20 m 0 m 80 m 0 m 41 m 0 12 r 1 m 0 3 r 1 m 0 15 r 1 m 0 8 r 4 m 0
m notbusy
02 wcmd 1 m 8 m 0 m \ 0x10800 
0 2 r 8 m 0 m 8 m 80 m 0 c r 82 m 0 m 82 m 0 m a0 m 0 4 r 80 m 0 2 r 8 m 0 2 r 5 m 0 8 r 8 m 0 m 8 m 0 5 r 10 m 0 4 r 80 m 0 3
r 80 m 8 m 80 m 0 8 r 8 m 0 m 21 m 0 5 r 4 m 0 m 84 m 0 m 90 m 0 m c0 m 0 3 r 1 m 4 m 1 m 0 m 8 m 0 3 r 8 m 4 m 82 m 4 m 82 m
4 m 8 m 4 2 r 0 m 4 m 0 m 4 m 0 m 4 2 r 0 m 40 m 0 2 r a0 m 10 m 0 m 10 m 0 2 r 20 m 0 m 84 m 0 m 21 m 4 m 80 m a0 m 0 5 r 20
m 0 5 r a0 m 0 b r 84 m 0 3 r 2 m 41 m 0 5 r 8 m 0 14 r 20 m 0 2 r 10 m 20 m 0 m 20 m 0 m 3 m 0 8 r 84 m 0 2 r a0 m 0 2 r 80 m
0 9 r 20 m 1 m 4 m 0 6 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 1 m 0 m 1 m 0 3 r 1 m 0 m 1 m 0 2 r 80 m
84 m 0 2 r notbusy
02 wcmd 1 m 9 m 0 m \ 0x10900 
a0 m 1 m 0 m 5 m 0 m 5 m 82 m 3 m 0 m 11 m 0 m 3 m 0 m 20 m 0 m 20 m 0 2 r 82 m 0 3 r 8 m 0 2 r 9 m 0 3 r 8 m 84 m 0 m 84 m 0
m 4 m 0 m 2 m 5 m 0 2 r 20 m 0 m 8 m 0 m 8 2 r 0 2 r 20 m 0 2 r 5 m 8 m 2 m 0 2 r c0 m 21 m 10 m 21 m 84 m 0 4 r 20 m 0 2 r 84
m 0 m 8 m 0 m 8 m 2 m 88 m 11 m 88 m 0 m 4 m 11 m 4 m 0 m 90 m 0 m 84 m 5 m 0 m 5 m 0 2 r 20 m 3 m 0 2 r 20 m 0 m 4 m 20 m 4 m
0 m 82 m 2 m 0 2 r c0 m 20 m 84 m 0 5 r c0 m 0 4 r 11 m 2 m 21 m 0 m 2 m 0 m 21 m c0 m 0 m 82 m 11 m 20 2 r 40 m 0 c r 1 m 0 m
1 m 0 12 r 80 m 0 m 80 m 0 2b r 80 m 0 d r 80 m 0 m 80 m 0 1d r notbusy
02 wcmd 1 m a m 0 m \ 0x10a00 
0 2 r 80 m 0 m 80 m 0 2 r 21 m 0 m 5 m 82 m 0 m c0 m 3 m 0 m 20 m 0 m 21 m 0 3 r 8 2 r 0 m 84 m 0 m 8 m 3 m 0 6 r 40 m 0 4 r 5
m 0 m 40 m 0 5 r 8 m 0 m 8 m 0 2 r 84 m 0 m c0 m 0 6 r 21 m 1 m 3 m 9 m 0 m 1 m 0 m 10 m 0 b r 90 m 0 m 89 m 0 m 8 m 0 5 r c0
m 0 6 r 20 m 0 m 20 m 0 m 80 m 20 2 r 0 2 r c0 m 0 m c0 m 21 m 8 m 21 m 1 m 0 m a0 m 80 m 85 m 0 m a0 m 80 m 0 m 21 m 0 5 r 5
m 82 m 0 2 r 90 m 82 m 0 m 82 m 21 m 0 4 r 8 m 0 4 r 1 m 0 6 r 80 m 0 2 r 90 m 0 8 r 80 m 0 5 r 8 m 1 m 0 2 r 8 m 0 11 r 4 m 0
m 4 m 0 m 4 m 0 b r 21 m 0 3 r 4 m 0 5 r 41 m 0 8 r 1 m 0 m 1 m 0 m 4 m 80 m 1 m 41 m 0 5 r 21 m 0 m 4 m 0 2 r 20 m 4 m 0 2 r
20 m 0 6 r notbusy
02 wcmd 1 m b m 0 m \ 0x10b00 
0 4 r 8 m 41 m 8 m 0 m 8 m 0 m 40 m 2 m 0 m 8 m 0 m 40 m 10 m 8 m 91 m 40 2 r 20 m 0 m 4 m 10 m 82 m 0 8 r 21 m c0 m 20 m 8 m
0 m 40 m 20 m 10 m 20 m c0 m 0 m 8 m 0 m 2 m 10 m 8 m c1 m c0 m 20 m 10 m 0 m 10 m c0 m 2 m 40 m a0 m 0 m 10 m 0 m 90 m 88 m
90 m 40 m 88 m 0 m 8 m 0 m 10 m c0 m 90 m 0 2 r 82 m 2 m 0 m 10 m 0 m 88 m 10 m 8 m 88 m 20 m 10 m 88 m 0 m 82 2 r 10 m 2 m c0
m 4 m a0 m 0 m 90 m 20 m 90 m 10 m 11 m 88 m 10 m 88 m 8 2 r 3 m 0 m 1 m 0 m 1 m 90 m 1 m 0 m 1 m 40 m 88 m 0 m 2 m 0 m 10 m 2
m 10 m 11 m c0 m 88 m 40 m 88 m 90 m 20 m 40 m 0 2 r 1 m 0 m 90 m 0 3 r 80 2 r 0 m 80 m 0 3 r 80 m 10 m 80 m 0 m 80 m 0 m 80 m
0 m 80 m 0 8 r 9 m 80 3 r 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 2 r 0 m a0 m 80 m 0 m 80 m 0 2 r 80 m 0 m a0 m 80 m 0 m
80 m 0 4 r 80 m 0 5 r 80 m 0 4 r 80 m 0 3 r 80 2 r 0 2 r 3 m 80 m 0 2 r a0 m 80 m c0 m 5 m 80 2 r 0 5 r 91 m 88 m 21 m 10 m 8
m c1 m 80 m 90 m 11 m 10 m 21 m 10 m 8 m 10 m 0 m 8 m 80 m 0 2 r 80 m 0 m 80 m 0 m 80 m 2 m 80 m notbusy
02 wcmd 1 m c m 0 m \ 0x10c00 
5 m 0 m 5 m 0 5 r 8 m 0 m 80 m 0 3 r 80 m 0 m 80 m 10 m 80 m 91 m 80 m 0 4 r 21 m 0 m 82 m 0 5 r 20 m 0 4 r 80 m 0 m 80 m 21 m
80 m 0 m 91 m 0 3 r 80 m 9 m 0 2 r 80 m 0 m 80 m 0 2 r 90 m 80 m 88 m 80 2 r 0 2 r 80 m 41 m 80 m a0 m 0 4 r 80 m 41 m 0 m 8 m
0 6 r 80 m 0 2 r 21 m 0 5 r 11 m 80 2 r 0 2 r 80 m 0 2 r 90 m 80 m a0 m 80 m 0 m 10 m 80 m 10 2 r c1 m 80 m 83 m 3 m 40 m 0 m
8 m 0 m 3 m 0 m 10 m 8 m 0 2 r 80 m 3 m 0 m 8 m 0 2 r 80 m 0 2 r 83 m 0 m a0 m 80 m 0 m 80 m 2 m 80 3 r 40 m 80 m 0 m 40 m 0 m
8 m 0 m 2 m 10 m 8 m 0 m 90 m 0 m 2 m 0 m 88 m 4 m 40 m 0 6 r 90 m 0 2 r 8 m 0 m 4 m 0 m 4 m 20 m 82 m 0 m 90 m 0 m 82 m 0 m
90 m 8 m c0 m 40 2 r 0 m 88 m 82 m 10 m 3 m c0 m 2 m 90 m 0 m 20 m 1 m a0 m 10 m 90 m 0 m 90 m 0 m 82 m 1 m 10 m 11 m 90 m 40
m 0 2 r 8 m 0 m 40 m 0 m 90 m 11 m 82 m 0 m 2 m 0 m 10 m 0 m 82 m 10 m 90 m 0 m 40 m 0 m 20 m 83 m 2 m c0 2 r 40 m 11 m 10 2 r
1 m 40 2 r 2 m 1 m 0 m 40 m 1 m 0 5 r 20 m 0 m 10 m 0 m 88 m 89 m notbusy
02 wcmd 1 m d m 0 m \ 0x10d00 
88 m 0 m 40 m 0 m 20 m 82 m 40 m c0 2 r 8 m 20 m 1 m 10 m 88 m 8 m 1 m c0 m 0 m 88 m 40 m 0 m 8 m 40 m 4 m 88 m 8 m 2 2 r 0 m
2 m 0 m 40 m c0 m 20 m 0 8 r 2 m 8 m 0 m 20 m 0 m 90 m 82 m c0 m 8 m 2 m 0 m 88 m 4 m 20 m 2 m c0 m 10 m 20 m 88 m 20 m 0 m 2
m 90 m c0 m 88 m 8 m 0 m 88 m 0 m 88 m 4 m 2 m 4 m 8 m 0 m 10 m 0 m 40 m c0 m 90 m 0 m 1 m 90 m 88 m 0 m 8 m 0 m 20 m a1 m 20
m 10 2 r 0 m 2 m 0 m 2 m 90 2 r 91 m 40 m 0 m 20 2 r 2 m c0 2 r 20 m 10 m 0 m 5 m 0 m 2 m 90 m 91 m 0 7 r 1 m 20 2 r 0 m 10 m
0 m 4 m 10 m 90 2 r 40 m 0 m 21 m 20 m 40 m c0 m c1 m 0 2 r 4 m 1 m 10 m 1 3 r 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0
3 r 80 2 r 0 9 r 80 2 r 0 4 r 80 4 r 0 m 80 2 r 0 m 80 2 r 20 m 80 m 0 m 80 m 0 2 r 9 m 80 m 0 6 r 80 3 r 0 5 r 80 m 0 2 r 1 m
0 6 r 88 m 0 3 r 10 m 80 m 41 m 0 3 r 20 m 80 m 0 3 r 80 3 r 0 m 10 m 11 m 83 m 3 m 83 m 10 2 r 0 m 20 m 3 2 r 10 2 r 0 m 8 m
0 2 r notbusy
02 wcmd 1 m e m 0 m \ 0x10e00 
0 m 82 m 0 m 82 m 80 m 9 m 40 m a0 m 0 m 10 m 0 m 10 m 80 m 88 m 0 m 9 m 0 m 11 m 80 m 8 2 r 41 m 80 m 5 m 80 m 8 m 80 m 0 m
80 m 0 2 r 2 m 0 m 10 m 80 3 r 0 9 r 80 m 10 m 80 m 20 m 80 2 r 0 2 r 80 m 0 m 80 m 0 5 r 80 m 8 m 80 3 r 2 m 0 3 r 2 m 0 m 90
m 0 m 80 m 0 3 r 8 m 80 m 82 m 0 5 r 1 m 0 4 r 80 2 r 0 3 r 2 m 0 m 2 m 80 m 0 3 r 80 m 20 m 80 m 0 m 80 m 20 m 0 2 r 10 m 80
m 10 m 8 m 83 m 0 m 2 2 r 8 m 0 m 3 m 0 m 10 m 0 m 8 2 r 80 m 0 m 80 m a0 m 80 2 r 0 2 r 80 m 40 m 80 3 r 20 m 80 2 r 0 3 r 80
m 0 4 r 40 m 0 m 8 m 40 2 r 88 m 8 m 0 m 10 m 0 m 2 2 r 40 m 4 2 r 0 m 90 m 0 m 20 m 0 m 90 m 0 3 r 8 m 1 m 4 m 20 m 4 m 40 m
20 m 0 m c0 m 0 m 88 m 40 m 20 m 8 m 40 m 0 m c0 m 1 m 82 m c0 m 10 m 89 m 2 m 40 m 90 m 0 m 88 m 3 m 20 m 82 m 20 m 0 m 8 m 0
m 2 m 20 m 90 m 88 m 20 m 0 2 r 1 m 88 m 0 m 40 m 88 m 2 m 84 m 82 m 0 m 10 m 0 m 88 2 r 2 m 20 2 r 0 m c0 m 1 m 20 m 10 m 4 m
21 m 82 m 40 m 10 m c0 m 90 m 2 2 r 40 m 2 m 0 2 r 20 m 0 4 r notbusy
02 wcmd 1 m f m 0 m \ 0x10f00 
1 2 r 8 m 0 m 10 2 r 2 m 4 m 88 m 0 m c0 m 0 m 20 m 8 m 10 m 21 m 4 m 10 m 0 3 r 10 m 0 m 10 m 0 6 r b m 0 7 r b m 0 2 r 12 m
0 c r 9 m 0 4 r 21 m 0 2 r 9 m 0 7 r 9 m 0 m 48 m 82 m 0 m 81 m 0 2 r b m 0 m 41 m 0 5 r b m 0 m 41 m 82 m 0 d r 90 m b m 0 7
r 9 m 0 2 r 42 m 0 3 r d0 m b m 0 m 60 m 0 4 r d0 m 0 7 r 90 m b m 0 6 r d0 m 9 m 0 2 r 42 m 0 m 21 m 0 m 90 m 9 m 0 3 r f0 m
f4 m f0 2 r ff m 4 m ff m 0 m ff m bf m 0 m 20 m ff 2 r fb m ff m 69 m 96 2 r 69 m 0 4 r b9 m 67 m 76 m 9b m 3c 2 r aa m 55 m
c3 m 3c m 96 2 r f m f0 m 55 m aa m 0 8 r ff 3 r fe m ff 4 r bc m 2c m 3c 2 r 6e m 62 m 66 2 r 0 2 r e7 m 24 m e4 2 r 72 2 r
ff m 3c m 66 2 r 72 m 66 m fd m 40 m ff m 0 9 r ff m 0 m ff m 20 m fd m ff 3 r 0 2 r notbusy
20 wcmd 1 m 10 m 0 m notbusy \ 0x11000
02 wcmd 1 m 10 m 0 m \ 0x11000 
0 6 r 3c m 7c m 3c m 1c m ff 2 r 4 m 0 11 r f0 m d0 m f0 2 r fb m 0 m ff m 0 m ff 2 r 0 2 r 4 m 0 3 r 96 m 69 2 r 96 m 0 4 r
99 m 66 m 7f m fb m c3 2 r 55 m aa m ff 8 r 0 8 r ff 3 r f6 m ff 2 r fe m fc m 3c 4 r 66 4 r 0 2 r e7 m 24 m e4 2 r 72 2 r c3
m 0 m 66 4 r ff m 0 m ff m 0 9 r ff m 0 m df m 0 m 40 m 0 b r 3c 4 r fb m ff m 0 3a r 43 m 10 m 20 m 0 2 r 88 m 11 m 6 m 0 22
r 43 m 10 m 20 m 0 2 r 88 m 11 m 6 m 0 6 r notbusy
02 wcmd 1 m 11 m 0 m \ 0x11100 
0 12 r 43 m 10 m 20 m 0 2 r 88 m 11 m 6 m 0 8 r 4 m 0 m ff 2 r 0 m ff m 20 m ff m 66 m 6c m 66 2 r 0 m f7 m 8 m ff m 0 8 r d7
m eb m cf m f3 m d7 2 r 57 m d7 m ff m aa m ff m 99 m 7f m e6 m c0 m 3f m 0 8 r 3e m ff 3 r 3f m ff m 7f m ff m 0 m 20 m ff 2
r 3c 2 r 1e m 3c m 0 4 r 18 2 r ff 4 r 3c 7 r 7c m 0 8 r f 2 r 2f m f m 3c 3 r 7c m 0 9 r 20 m ff m bf m 0 m 8 m ff m ef m 0 c
r 66 m 0 m 33 2 r 0 2 r fb m ff m 0 m ff m 0 m df m 66 4 r 0 m ff m 0 m ff m 0 8 r eb m d7 m cf m f3 m d7 3 r d5 m ff m 55 m
ff m 66 m 19 m 80 m 3f m c0 m 0 8 r 6 m ff 3 r 3c m ff m 7e m ff m 0 2 r ff m df m 3c 4 r 0 4 r c m 0 m f3 m ff m db m ff m 3c
m 38 m 3c m 3e m 3c 3 r 1c m 0 8 r f 2 r notbusy
02 wcmd 1 m 12 m 0 m \ 0x11200 
b m f m 3c 3 r 1c m 0 a r ff 2 r 0 2 r ff 2 r 0 c r 66 m 0 m 99 m ff m 0 3 r 8 m 0 7 r 8 m 0 d r 61 m 20 m 6 m 0 m 9d m 0 2 r
10 m 0 m 20 m 30 m 0 m 40 m 0 m 5 m 0 5 r 90 m 0 m 5 m 0 3 r 20 m 0 7 r 8 m 0 6 r 80 m 0 8 r 61 m 0 m a m 0 m d m 0 7 r 90 m 0
m 5 m 0 m 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 1 m 0 m 11 m 0 3 r 61 m 0 m e m 0 m 9 m 0 3 r 61 m 0 m 7 m 0 m 99 m 0 m 5 m 0 m
61 m 0 m 36 m 0 m d m 0 m 5 m 0 58 r notbusy
02 wcmd 1 m 13 m 0 m \ 0x11300 
0 2 r ff 3 r fb m f0 3 r b2 m ff 2 r fe m ff 2 r 7f m ff 2 r 0 4 r ff m f0 m f m 0 6 r 8 m ff 2 r 0 4 r 99 m 66 m c3 m 3c m 0
5c r 4 m 0 m f0 4 r 1 m 0 4 r 20 m 0 6 r ff m f0 m f m 0 7 r ff m f7 m 0 4 r 66 m 99 m 3c m c3 m 0 1c r ff 2 r 0 2c r bb 2 r
ee 2 r 0 6 r notbusy
02 wcmd 1 m 14 m 0 m \ 0x11400 
0 6 r ff m f7 m 0 m 4 m 3c 3 r 3e m ff m fe m 1 m 0 m ff 3 r fb m 0 34 r ff 2 r 0 2c r ee 2 r bb 2 r 0 c r ff 2 r 0 2 r 3c 3 r
34 m ff 2 r 0 5 r 10 m 0 18 r 20 m 0 13 r 4 m 0 m 40 m 0 m c0 m 0 7 r 4 m 0 3 r 88 m 0 b r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 b r
20 m 0 3 r 20 m 0 5 r 4 m 0 m 4 m 0 m notbusy
02 wcmd 1 m 15 m 0 m \ 0x11500 
4 m 0 b r 88 m 0 9 r 20 m 0 9 r 88 m 0 25 r c0 m 0 13 r 21 m 0 7 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 a r 3 m 0 a r 80 m 0 m 80
m 0 m 80 m 0 11 r 20 m 0 21 r 1 m 0 e r 10 m 0 m 10 m 0 m 20 m 1 m 20 m 0 b r 80 m 0 3 r 80 m 0 19 r 2 m 0 2 r 8 m 0 2 r 10 m
0 m 10 m 0 2 r notbusy
02 wcmd 1 m 16 m 0 m \ 0x11600 
0 m 80 m 0 m 80 m 1 m 88 m 0 11 r 80 m 0 m 80 m 1 m 80 m 1 m 80 m 0 10 r 4 2 r 20 m 0 m 4 m 80 m 4 m 80 m 0 2 r 2 m 0 e r 1 m
0 m 1 m 0 m 89 m 40 m 5 m 0 b r 20 m 0 3 r 20 m 0 m 8 m 0 7 r 88 m 0 3 r 88 m 0 e r 80 m 88 m 0 m 1 m 0 m 1 m 0 m 10 m 0 m 20
m 0 m 20 m 2 m 21 m 0 5 r 82 m 0 m 82 m 0 9 r 4 m 0 m 4 m 20 m 4 m 20 m 4 m 0 5 r 84 m 0 5 r 88 m 0 4 r 80 m 1 m 0 2 r 80 m 20
m 80 m 20 m 0 7 r 80 m 0 m 8 m 0 m 3 m 0 m 3 m 0 m 5 m 1 m 2 m 1 m 10 m 0 m 10 m 1 m 10 m 0 9 r 20 m 0 m 8 m 0 m 20 m 0 3 r 3
m 0 3 r 80 m 0 5 r 21 m 0 4 r 1 m 0 c r 21 m 0 2 r notbusy
02 wcmd 1 m 17 m 0 m \ 0x11700 
0 m 8 m 0 m 5 m 1 m 4 m 1 m 80 m 11 m 91 m 0 m 20 m 0 m 21 m 0 7 r 40 m 0 3 r 4 m 0 m 3 m 0 m 21 m 0 3 r 80 m 0 3 r 10 m 0 m 2
m 0 m 9 m 0 3 r 2 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 m 5 m 0 8 r 21 m 20 m 0 m 84 m 8 m 0 m 3 m 84 m 0 2 r 4 m 8 m 4 m a1 m 41 m
9 m 4 m 1 m 21 m 0 3 r 3 m 0 m 21 m 0 m 41 m 1 m 3 m a0 m 0 m 1 m 4 m 0 m 4 m 0 3 r 2 m 10 2 r 0 m 41 m 82 m 41 m 84 m 0 m 20
m 0 m 8 m 4 m 0 2 r a0 m 41 m 0 m 10 m 0 3 r 41 m 0 2 r a0 m 3 m 0 m 21 m 0 m 40 m 90 m 4 m 91 m 4 2 r 84 m 8 m 21 m a0 m 0 m
8 m 0 4 r 2 m 0 m 20 m a0 m 0 m 8 m 3 m 41 m 11 m 82 m 10 m 84 m 5 m 0 2 r 20 m 41 m a0 m 8 m 1 m 8 m a0 m 8 m 0 5 r 3 m 0 2 r
9 m 0 m 1 m 0 m 1 m 0 m 84 m 41 m 0 3 r c0 m 0 m 8 m 41 m 0 4 r c0 m 0 m 82 m 0 5 r c0 m 0 m 83 m 0 b r 8 m 0 m 4 m 0 m 4 m 0
m 4 m 0 m a0 m 0 2 r 8 m 0 4 r 82 m 0 m c0 m 80 m 8 m 0 m 8 m 0 5 r 84 m 0 6 r 10 m notbusy
02 wcmd 1 m 18 m 0 m \ 0x11800 
0 5 r 5 m 0 2 r 20 m a0 m 0 m 80 m 21 m a0 m 8 m 40 m 0 m 10 m 8 m 2 m 8 m 10 m 20 m 0 m 82 m 0 3 r 82 m 0 m 20 m 0 m 20 m 0 m
84 m 0 4 r 80 m 0 m 80 m 0 m 80 m 0 m 20 m 1 m 0 3 r 82 m 80 m 0 3 r 4 m 1 m 0 m a0 m 0 m c0 m 0 15 r 2 m c0 m 0 a r 10 m 0 m
80 m 0 m 80 m 0 m 80 m 0 c r 20 m 0 d r 3 m 0 m 1 m 0 7 r 88 m 80 m 5 m 0 m 4 m 90 m 5 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 1 m 80 m
0 7 r 80 m 0 m 80 m 0 6 r 4 m 0 m 4 m 0 m 4 m 0 m 1 m 4 m 0 4 r 20 m 21 m 0 2 r 1 m 4 m 0 9 r 4 m 0 m 4 m 0 3 r 8 m 0 m c0 m 0
m 8 m 0 m 1 m 41 m 4 m 20 m 4 m 20 m 0 3 r 10 m 82 m 0 m 8 m 0 c r 5 m 2 m 5 m 85 m 5 m 0 m 3 m 0 2 r 82 m 0 2 r 8 m 10 m 2 m
0 m 40 m 4 m 83 m 0 m 85 m 1 m 2 m notbusy
02 wcmd 1 m 19 m 0 m \ 0x11900 
0 3 r 8 m 4 m 0 4 r 3 m 0 3 r 20 m 0 m 8 m 1 m a0 m 0 2 r 8 m 0 m 40 m 0 3 r c0 m 0 m 20 m 0 m 2 m 4 m 20 m 0 2 r 20 m 40 m 20
m 0 m 20 m 40 m 0 2 r 80 m 10 m 80 m 1 m 0 m 4 m 84 m 40 m 0 7 r 40 m 0 5 r c0 m 0 2 r a0 m 0 m 8 m 80 m 0 m 80 m 8 m 0 5 r 88
m 3 m 0 m 4 m 2 m 83 m 1 m c1 m 1 m 0 2 r 21 m 0 m 41 m 0 7 r 41 m 0 3 r 9 m 0 4 r 8 3 r 0 m 8 m 10 m 88 m 40 m 88 m 40 m 4 m
5 m 4 m 0 2 r 80 m 20 m 5 m 20 m 4 m a0 m 0 2 r 4 m 90 m 4 m 90 m 21 m 90 m 40 m 0 3 r 10 m a0 m 3 m 8 m 2 m 40 2 r 0 m 21 m 0
m 21 m 0 m 21 m 0 m 21 m 0 m 82 2 r 2 m 82 m 91 m 8 m 40 m 83 m 5 2 r 0 m 1 m 9 m 0 2 r 4 m 0 m 4 m 20 m a0 m 80 m 4 m 40 m 4
m 21 m 0 m 41 m 2 m 21 m 4 m 0 m 84 m 8 m 0 2 r a0 m 0 m 84 m 0 3 r 21 m 0 m 21 m 0 m 21 m 0 2 r 8 m 0 5 r 4 m 21 m 0 3 r 21 m
8 m 20 m 0 m 21 m 0 6 r 4 m 0 c r 2 m 0 m 5 m 0 m 20 m 0 m 3 m 0 m 20 m 0 m 20 m 8 m 0 2 r 21 m notbusy
02 wcmd 1 m 1a m 0 m \ 0x11a00 
4 m 0 m 4 m 21 m 0 5 r 41 m 0 m 8 m 0 m 3 m 90 m 0 m 20 m 0 m 21 m 0 m 21 m c0 m 40 m 21 m 0 4 r 1 m 0 2 r 4 m 0 m 4 m 20 m 4
m 88 m 0 3 r 40 m 21 m 0 m 80 m 0 m 20 m 0 2 r 82 m 21 m 0 m 21 m 82 m 80 m 0 2 r 1 m 0 m 82 m 0 7 r 88 m 0 7 r 41 m 0 b r 80
m 0 6 r 1 m 0 8 r 80 m 0 10 r 1 m 0 3 r 1 m 0 m 1 m 0 4 r 80 m 0 m 80 m 0 6 r 8 m 0 3 r 84 m 0 2 r 80 m 0 m 84 m 0 m 90 m 21 m
0 6 r 40 m 0 2 r 1 m 0 m 1 m 80 m 1 m 0 7 r 20 m 0 m 1 m 0 7 r 4 m 0 2 r 4 m 0 d r 40 m 0 m a0 m 0 3 r 82 m 0 9 r 2 m 4 m 0 m
4 m 10 m 40 m 0 a r c0 m a0 m 20 m 2 m 0 m 10 m 82 m 10 m 0 8 r 40 m 10 m 0 m 2 m 0 m 10 m 8 m 10 m notbusy
02 wcmd 1 m 1b m 0 m \ 0x11b00 
2 m a0 2 r 10 m 0 m 20 m 82 m 8 m 0 3 r 2 m 0 3 r 8 m 0 m 10 m 0 m c0 m 0 m 90 m 0 2 r 90 2 r 20 m 90 m 20 m 2 m 8 m 10 2 r a0
m 0 m 1 m 0 2 r 8 m 0 2 r 1 m 90 m 2 m 0 m 10 m 91 m 9 m 8 2 r 0 2 r 1 2 r 2 m 0 2 r 1 m 40 m 10 m 0 m 40 m 0 m 8 m 0 2 r 8 2
r 0 m 10 m 0 m 9 m 2 2 r 80 m 0 5 r 80 m 0 9 r 91 m 0 2 r 80 m 0 m 80 m 0 a r 80 m 0 5 r 80 2 r 0 8 r 91 m 80 m 0 3 r 80 2 r 0
7 r 80 2 r 0 2 r 5 m 0 6 r 80 m 0 m 80 m 0 m 80 m 0 2 r 80 2 r 0 2 r 10 m 0 m 80 m 0 4 r 8 m 9 m 20 m 2 m 11 m 0 m 10 m 0 m c0
m 10 m 90 m 8 m 90 m 0 m 20 m 0 m 20 m 10 2 r 8 m 2 m 0 m 20 m 0 3 r 80 m 0 4 r 8 m 20 m 0 m a1 m 8 m 90 m 80 m 90 m 0 5 r 5 m
80 m 0 c r 4 m 0 2 r 80 m 0 b r 80 m 20 m 0 m 80 2 r 0 9 r 80 m 0 2 r 21 m notbusy
02 wcmd 1 m 1c m 0 m \ 0x11c00 
0 m 91 m 0 5 r 11 m 0 2 r 80 m 0 5 r 80 m 20 m 0 2 r 80 m 0 2 r 80 m 0 2 r 11 2 r 80 m 9 m 8 m 0 m 10 m 0 m 2 m 0 m 90 m 0 m
10 m 0 m 9 m 0 m 10 m 0 m 10 m 11 m 41 m 0 m 90 m 11 m 82 m c0 m 20 2 r 41 m 80 m 10 m 0 m 83 m 20 m 2 2 r 0 3 r 8 m 0 m 10 m
0 4 r 80 m 21 m 0 m 80 2 r 0 m 90 m 0 5 r c0 m 0 b r 4 m 84 m 0 2 r 90 m c0 m 0 8 r 88 m 0 m 10 m 0 m a0 m 10 m 8 m 0 9 r 10 m
0 m 10 m 0 m 2 m 10 m 40 m 0 m 4 m 0 m 2 m 0 m 90 2 r 8 m 0 3 r 20 m 0 m 20 m 0 m 82 m 20 m 10 m 0 2 r 40 m 0 2 r 1 2 r 90 m 1
m 3 m 0 m 10 m 0 m 2 m 0 m 82 m 0 m 1 m 90 m 0 2 r 1 m 0 m 1 m 0 m 88 m 2 m 11 m 0 m 2 m 84 m 8 3 r 2 m 91 m 0 m 2 m 0 m 2 m 0
m 88 m 0 m 88 m 1 m 0 m 10 m 2 m 0 m 8 m 0 m 10 m 0 m a0 m 8 m 2 m 0 2 r 90 m 0 m 40 m 4 m 40 m 0 m 90 m 0 8 r 1 m 4 m 0 m 1 m
82 m 91 m 2 2 r 0 8 r 10 2 r 0 m 2 m 0 m 10 m c0 m 10 m 0 8 r notbusy
02 wcmd 1 m 1d m 0 m \ 0x11d00 
10 2 r 0 m 2 m 0 m 40 m 2 m 10 m 2 m 10 m 0 m 88 m 0 m 20 3 r 0 2 r 40 m 10 m 0 3 r 84 m 88 m 20 m 40 m 0 3 r 90 2 r 88 m 1 m
10 m 11 m 0 m 2 m 0 m 91 m 10 m 82 m 0 3 r 1 3 r 0 m 1 m 8 m 3 m 0 m 20 m 0 m 5 m a0 m 4 m 0 m 1 m 0 2 r c1 m 1 m 0 2 r 40 m
88 m 0 m 10 m 2 2 r 88 2 r a0 m 10 m 1 m a0 m 0 m 8 m 10 m 20 m 0 3 r 80 m 0 c r 4 m 9 m 0 m 8 m 80 m 88 m 80 m a0 m 0 8 r 80
2 r 0 3 r 80 3 r 0 e r 82 m 80 m 0 m 80 m 0 9 r 80 m 0 3 r 80 m 8 m 0 m 80 m 0 3 r 80 3 r 11 m 0 m 10 m 0 m 2 m 0 m 10 m 80 m
a0 m 0 m 3 m 8 m 3 m 10 2 r 9 m 10 m 0 m 88 m 2 2 r 10 m 85 m 40 m a0 m 0 m 40 m 3 2 r 5 2 r 8 m 20 m 80 m 0 8 r 80 m 41 m 0 m
3 m 80 2 r 0 4 r 80 m 0 c r 80 m 11 m 80 m 11 m 80 3 r 0 9 r 80 m 0 2 r 20 m 80 2 r 0 6 r notbusy
02 wcmd 1 m 1e m 0 m \ 0x11e00 
0 7 r 90 m 80 2 r 0 5 r 9 m 0 7 r 40 m 80 m 0 3 r 80 m 0 m 41 m 0 m 11 m 8 m 0 2 r 11 2 r 0 m 80 m 0 m 9 m 0 3 r 10 m 8 m 0 m
10 m 0 m 10 m 0 m 20 m 11 m 10 m 2 m 82 m 20 m 83 m 80 m 2 m 8 m 41 m 0 m 3 m 88 m 5 m 80 m 3 m 8 m 80 m 40 m 0 m 8 m 0 m 80 m
0 2 r 80 m 10 m 80 m 8 m 80 2 r 0 5 r 2 m 0 m 4 m 0 a r c0 m 1 m 2 m 0 m 90 m 40 m 2 m 0 9 r 10 m 0 m 2 2 r 10 2 r 82 m 0 9 r
10 m 0 m 2 m 11 m 10 m 84 m 40 m 0 m 2 m 0 m 20 2 r a0 m 88 2 r 0 3 r 90 m 0 m 20 m a0 m 8 m 40 m 2 m 0 m 1 m 0 m 1 m 0 3 r 1
2 r 0 m 8 m 0 m 10 m 0 m 10 m 0 2 r 1 m 8 m 1 m 0 m 1 m 0 3 r 21 m 11 m 20 m a0 m 8 2 r 40 m 1 m 0 m a0 m 0 m 4 m 1 m 84 m 0 2
r 40 m 0 m 2 m 11 m 0 m 40 m 88 m 0 m 10 m 0 m 20 m 88 m 2 m 8 m 20 m 0 5 r 9 m 0 f r 9 m 0 f r b m 0 m 42 m 11 m notbusy
02 wcmd 1 m 1f m 0 m \ 0x11f00 
0 c r b m 0 7 r b m 0 e r 82 m 0 m 90 m 43 m 0 e r d0 m 0 7 r d0 m b m 0 6 r d0 m b m 0 7 r b m 0 6 r d0 m b m 0 m 42 m 0 5 r
3f 4 r 0 8 r 33 m cc m 0 m ff m 0 m 82 2 r eb m 0 8 r 3c 2 r ac m 3c m aa m a2 m aa m ae m 0 8 r 3c 2 r b4 m 3c m 0 m f7 m 8 m
ff m 3c m b4 m 3c 2 r f0 3 r f4 m 0 3 r 80 m 0 3 r 3c m 0 6 r ff m 0 m ff m 0 5 r aa m a2 m aa m ae m 0 8 r 3c 4 r 0 m ef m 10
m ff m 0 9 r ff m 14 m ff m aa 3 r ae m 3c 2 r 34 m 3e m f0 4 r 0 4 r af m 5f 3 r 0 8 r 33 m cc m ff m 0 2 r 82 2 r eb m 0 8 r
3c 4 r notbusy
20 wcmd 1 m 20 m 0 m notbusy \ 0x12000
02 wcmd 1 m 20 m 0 m \ 0x12000 
aa 4 r 0 8 r 3c 4 r 0 m ff m 0 m ff m 3c 4 r f0 3 r e0 m 0 7 r 3c m 0 7 r ff m 0 m ff m 0 4 r aa 4 r 0 8 r 3c 2 r 1c m bc m 0
m ff m 0 m ff m 0 9 r ff m 0 m ff m aa 3 r ae m 3c 4 r f0 m d0 m f0 m f8 m 0 4 r c3 2 r aa 2 r 0 a r 5 m 0 m f 2 r f0 2 r 0 8
r ff m ef m 0 m 4 m ff m 8 m f7 m 0 9 r 55 m 5c m 55 2 r ff 2 r 0 m 4 m ff m 0 m ff m 0 m bf m ff 3 r 0 2 r 73 2 r 43 2 r 5d m
c m ff 2 r c3 m 3c m 69 m 55 m 0 2 r ff 2 r 3c m 35 m 3c 2 r ff m fe m 0 m 4 m 0 8 r ff m f7 m 0 m 4 m df m 10 m ff m 0 5 r 3c
4 r ff m fa m 0 2 r ff 4 r fd m ff 4 r 0 m f7 m 4 m 0 4 r ff 4 r 0 a r 5 m 0 m f0 2 r f 2 r 0 8 r notbusy
02 wcmd 1 m 21 m 0 m \ 0x12100 
ff 2 r 0 2 r ff m 0 m ff m 0 9 r 55 4 r ff m fb m 0 2 r ff m 4 m fb m 0 m 10 m 0 5 r 70 2 r 40 2 r 5d m c m 5d m c m ff m 0 m
55 2 r 0 2 r ff 2 r 3c 4 r ff 2 r 0 a r ff 2 r 0 2 r ff m 0 m ff m 0 5 r 35 m 3c 3 r ff 2 r 0 2 r 8 2 r 0 2 r 1 m 0 3 r ff m 0
m ff m 0 8 r 8 m 0 8 r a5 m 61 m a m 6 m 5 m d m 0 m a0 m 0 b r 8 m 0 f r 8 m 0 7 r 8 m 0 f r 41 m 20 m 3c m 0 m 1 m 0 3 r 61
m 0 m 6 m 0 m 1d m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 5 r 8 m 0 5 r 61 m 0 m b
m 0 m d m 0 16 r ff m f3 m ff m fd m 0 4 r notbusy
02 wcmd 1 m 22 m 0 m \ 0x12200 
0 2e r eb m 14 m eb m ff 3 r 0 7 r 8 m ff m fb m 3c 2 r 3d m 3c 5 r f m 1e m f 2 r 0 m ff m 8 m fd m 7c m 3c m 2c m 3c m 20 m
0 m 7f m ff m 0 24 r ff m f3 m ff m fd m 0 32 r eb m 14 2 r 0 m ff 2 r 0 8 r ff 2 r 3c 2 r 38 m 3c 4 r b4 m f 4 r 0 m ff m 0 m
ff m 3c 4 r 0 2 r ff 2 r 0 28 r notbusy
02 wcmd 1 m 23 m 0 m \ 0x12300 
0 36 r aa m 55 m aa m 55 m 0 4 r 3c 2 r bc m 3c m ff m 0 m ef m 4 m ff 3 r fb m ff 2 r 8 m 0 m 3c 2 r ac m 3c m ff 2 r 0 2 r
3c 3 r 7c m 0 8 r 3c 4 r 0 52 r aa m 55 m aa m 55 m 0 4 r 3c 2 r 1c m 3c m ff m 0 m ff m 0 4 r 8 m f7 m ff m 0 2 r 3c 4 r fe m
ff m 4 m 0 m 3c 3 r 2c m 0 8 r 3d m 3c m 38 m 3c m 0 8 r c0 m 0 m c0 m 0 5 r 20 m 0 m 20 m 0 m 10 m 0 3 r notbusy
02 wcmd 1 m 24 m 0 m \ 0x12400 
0 1e r 4 m 0 b r 4 m 0 15 r 20 m 0 3 r 84 m 0 m 82 m 0 m 90 m 0 b r 4 m 0 11 r 40 m 0 9 r 10 m 0 21 r 10 m 0 3 r 5 m 0 3 r 20
m 0 m 20 m 0 5a r 21 m 0 8 r notbusy
02 wcmd 1 m 25 m 0 m \ 0x12500 
0 8a r 41 m 0 4 r a0 m 0 3 r 8 m 0 d r 10 m 0 13 r 10 m 0 b r 2 m 0 b r 90 m 0 24 r 5 m 0 2 r 8 m 0 2 r 20 m 0 7 r notbusy
02 wcmd 1 m 26 m 0 m \ 0x12600 
0 3 r 10 m 0 c r 2 m 0 7 r 84 m 0 m 8 m 0 b r 40 m 0 7 r 88 m 0 7 r c0 m 0 3 r 82 m 0 m 4 m 41 m 0 14 r 4 m 0 5 r 90 m 0 m 88
m 0 m 90 m 0 f r a0 m 0 e r 84 m 0 8 r 40 m 0 m 8 m 0 8 r 40 m 2 m 88 m 2 m 0 7 r 9 m 0 6 r c0 m 0 2 r 2 m 0 5 r 9 m 0 m 11 m
0 m 21 m 8 m 5 m 0 m 40 m 84 m 40 m 4 m 0 3 r c0 m 0 5 r c0 m 9 m 0 m 4 m 0 3 r 40 m 0 3 r 41 m 0 5 r 11 m 4 m 20 m 90 m 4 m
90 m 9 m 88 m 5 m 4 m 0 2 r 5 m 0 m 5 m 0 2 r 4 m 0 3 r c0 m 0 2 r 21 m 0 4 r 4 m 2 2 r 8 m 0 m 5 m 2 m 0 m 4 m 0 a r notbusy
02 wcmd 1 m 27 m 0 m \ 0x12700 
0 1d r 5 m 0 e r 84 m 0 6 r 20 m 0 36 r 90 m 0 4 r 4 m 0 2 r c0 m 5 m 0 4 r 40 m 2 m 0 5 r 84 m 0 7 r c0 m 0 15 r 4 m 0 1f r
90 m 0 7 r 90 m 0 3 r 88 m 0 9 r 2 m 0 2 r 4 m 0 6 r c0 m 4 m 0 m 41 m c0 m 0 3 r 90 m 0 e r 40 m 0 b r notbusy
02 wcmd 1 m 28 m 0 m \ 0x12800 
0 16 r 20 m 0 a r 20 m 0 13 r 20 m 84 m 0 13 r 20 m 0 11 r 8 m 0 13 r 8 m 0 3 r 8 m 0 d r 5 m 0 m 5 m 0 8 r 8 m 0 5 r 4 m 0 m
40 m 0 m 40 m 0 a r 8 m 0 d r 11 m 82 m 0 m 90 m 0 3 r 10 m 9 m 0 2 r 10 m 0 m 10 m 0 2 r 40 m 2 m 9 m 0 m 40 m 0 3 r 2 m 4 m
9 m 0 2 r 88 m 0 4 r 11 m 0 3 r 11 m 0 2 r 2 m 40 m 88 m 9 m 0 m 9 m 84 m 11 m 40 m 5 m 40 2 r 0 m 9 m 90 m 11 m 4 m 0 7 r 4 m
0 m 4 m 0 m 4 m 0 4 r 8 m 0 2 r 2 m 0 2 r notbusy
02 wcmd 1 m 29 m 0 m \ 0x12900 
0 d r 10 m 0 1f r 8 m 0 2 r 8 m 0 16 r 11 m 0 21 r 11 m 4 m 0 5 r 20 m 0 7 r 20 m 0 m c0 m 0 a r 88 m 0 1b r 82 m 41 m 0 13 r
4 m 20 m 0 m a0 m 0 b r 90 m 0 m c0 m 0 m c0 m 0 m c0 m 0 2 r 11 m 0 9 r 11 m 0 c r 4 m 20 m c0 m 0 m 4 m 20 m 10 m 0 6 r 4 m
0 m 20 m 0 b r notbusy
02 wcmd 1 m 2a m 0 m \ 0x12a00 
41 m 0 m 21 m 4 m ff 82 r 0 m 2e m 42 m 20 m 30 m 22 m 1 m 5 m 0 2 r 50 m 60 m 0 2 r 15 m 13 m 4 m 0 2 r 8 m 1 m 8 m 0 2 r 4 m
0 3 r 40 m 0 d r 10 m 0 m 10 m 0 a r 41 m 40 m 0 10 r 20 m 0 m 20 m 0 f r 5 m 0 10 r 1 m 0 3 r 4 m 0 8 r 20 m notbusy
02 wcmd 1 m 2b m 0 m \ 0x12b00 
0 m 10 m 0 m 5 m 0 3 r 4 m 0 10 r 80 m 0 3 r 2 m 0 m 10 m 0 m 80 m 0 3 r 80 m 0 3 r 41 m 0 d r 10 m 0 m 10 m 0 5 r 21 m 0 m 80
m 0 5 r 41 m 0 b r 9 m 0 6 r 3 m 0 12 r 40 m 0 7 r 4 m 0 c r 1 m 0 7 r 1 m 0 8 r 10 m 0 a r 80 m 0 3 r 40 m 0 6 r 40 m 0 2 r
40 m 0 m 40 m 0 2 r 2 2 r 1 m 0 m 1 m 0 m 1 m 0 m 20 m 0 m 2 m 0 m 2 m 0 m 2 m 0 m 2 m 0 m 2 m 0 2 r 40 m 2 m 80 m 0 m 2 m 1 m
0 m 1 m 0 m 1 m 10 m 9 m 4 m 0 9 r 2 m 1 m 0 m 2 m 0 m 8 m 0 m 1 m 0 m 1 m 0 m 1 m 0 3 r 1 m 0 15 r notbusy
02 wcmd 1 m 2c m 0 m \ 0x12c00 
0 1f r 10 m 0 3 r 1 m 0 4 r 41 m 0 m 80 m 0 m 9 m 1 m 41 m 1 m 0 2 r 80 m 1 m 2 m 0 m 2 m 0 m 2 m 0 m 80 m 0 m 80 m 0 m 80 m 2
m 80 m 2 m 80 m 0 m 80 m 0 2 r 1 m 80 m 2 m 0 m 1 m 2 m 0 m 2 m 8 2 r 0 m 8 m 1 m 0 a r 2 m 0 m 80 m 0 m 80 m 0 m 8 m 0 m 4 m
0 m 4 m 0 3 r 20 m 0 4 r 84 m 0 19 r 82 m 0 17 r 10 m 0 m 10 m 0 d r 21 m 0 m 11 m 0 5 r 4 m 0 3 r 80 m 0 3 r 40 m 0 m 21 m 84
m 0 2 r 40 m 0 6 r 84 m 0 m 88 m 0 m 84 m 4 m 40 m 0 a r 41 m 0 2 r 40 m 0 m 88 m 5 m 88 m 0 3 r 20 m 0 3 r 82 m 0 2 r 80 m 4
m 0 2 r 11 m 1 m 9 m a0 m 0 m 91 m 0 m 5 m 0 m notbusy
02 wcmd 1 m 2d m 0 m \ 0x12d00 
4 m 0 m 90 m 2 m 4 m 0 m 84 m 0 m a0 m 0 3 r 84 m 0 3 r 88 m 0 m 82 m 0 m 90 m 0 3 r 84 m 0 2 r 2 m 82 m 0 8 r 10 m 0 5 r 84 m
0 4 r 4 m 0 b r 3 m 0 4 r 40 m 0 3 r 1 m 0 6 r 41 m 0 5 r 40 m 0 4 r 1 m 0 13 r 40 m 0 9 r 40 m 80 m 0 3 r 4 m 0 m 11 m 0 m 4
m 0 m 84 m 0 m 80 m 88 m 0 2 r 80 m 0 d r 4 m 0 5 r 5 m 0 6 r 84 m a0 m 0 m a0 m 0 m 88 m 0 3 r c0 m 0 m 1 m 0 m c0 m 0 3 r 9
m 0 m 5 m 0 m 1 m 0 m 1 m 0 3 r c0 m 0 m 82 m 0 2 r 80 m 8 m 0 6 r 2 m 8 m 2 m c0 m 0 m 8 m 0 m 3 m 0 m 82 m 0 5 r c1 m 0 b r
88 m 0 b r 4 m 0 2 r 20 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 20 m 0 2 r notbusy
02 wcmd 1 m 2e m 0 m \ 0x12e00 
0 5 r 9 m 4 m 11 m 0 m 9 m 4 m 11 m c0 m 0 3 r 84 m 0 2 r 80 m 20 m 0 m a0 m 0 m 1 m 3 m 0 m 5 m 20 2 r 90 m 0 m 84 m 20 m 8 m
0 4 r 82 m 0 m a0 m 0 4 r 2 m 0 2 r 8 m 0 2 r 2 m 0 m 2 m 0 m 2 m 0 m 2 m 0 8 r 40 m 0 7 r 1 m 0 m 83 m 3 m 0 m 3 m 0 m c0 m 0
m 10 m 0 2 r 8 m 0 2 r 20 m 0 3 r 8 m 0 m 8 m 0 4 r 3 m 10 m 4 m 0 a r 80 m 8 m 0 m 1 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0
m 1 m 0 8 r 80 m 0 2 r 82 m 80 m 0 3 r 21 m a0 m 0 3 r 4 m 80 m 0 3 r 20 m 0 m 3 m 0 2 r 91 m 0 m 88 m 41 m 1 m 0 4 r c0 m 0 3
r 2 m 10 m 0 m 40 m 0 2 r 20 m 0 m 4 m 0 m 10 m 0 m 84 m 0 m 82 m 0 4 r 20 m 10 m 20 m 0 3 r 11 m c0 m 0 m 82 m 0 m 4 m 0 m 4
m 0 m a0 m 0 2 r 40 m 90 m 0 m 88 m 40 m 0 7 r 40 m 90 m 41 m 0 m 5 m 84 m 0 2 r 10 m 0 3 r 3 m c0 m 0 5 r 4 m 0 3 r 4 m 0 m 4
m c1 m 2 m 82 m 0 m 2 2 r 40 m 2 m 11 m notbusy
02 wcmd 1 m 2f m 0 m \ 0x12f00 
0 m 2 m 0 7 r 41 m 90 m 80 m 4 m 3 m 0 2 r c0 m 2 m 0 m 21 m 0 2 r 84 m 0 5 r 4 m 0 m 20 m 0 3 r c0 m 20 m 0 2 r 8 m 11 m 0 6
r 80 m 0 13 r 80 m 0 2 r 40 m 0 4 r 5 m 0 8 r 1 m 0 3 r 1 m 0 2 r 9 m 8 m 40 m 0 2 r 40 m 2 m 0 9 r 10 m 0 7 r 88 m 0 5 r 89 m
4 m 80 m 20 m 0 m 2 m 80 m 1 m 80 m 90 m 0 m 89 m 11 m 0 m 11 m 2 m 0 3 r 88 m 5 m 20 m 91 m 0 2 r 88 m 0 6 r 20 m 0 7 r 80 m
0 4 r 1 m 0 5 r 10 m 0 m 10 m 20 m 10 m 0 m 10 m 0 9 r 3 m 82 m 8 m 0 5 r 80 m 0 m a1 m 21 m 0 2 r 80 m 8 m 0 3 r a0 m 80 m 0
m 80 m c0 m 40 m 20 m 0 m a1 m 40 m c0 m 0 9 r 82 m 5 m 0 m 3 m 0 m 5 m 82 m 5 m 0 3 r 5 m 0 m 11 m 0 m 11 m 0 m 11 m 0 m 9 m
0 m 84 m 0 m 80 m 0 m 4 m 0 m 80 m 5 m 21 m notbusy
20 wcmd 1 m 30 m 0 m notbusy \ 0x13000
02 wcmd 1 m 30 m 0 m \ 0x13000 
c0 m 0 2 r 40 m 0 7 r 2 m 4 m 0 m 40 m 0 2 r 11 m 0 4 r 40 m 21 m 84 m 0 2 r 4 m 0 2 r 1 m 0 m 20 m 0 3 r 88 m 20 m 0 m 20 m 0
m 20 m 0 m 20 m 0 3 r 8 m 0 m 8 m 0 e r 41 m 0 4 r 40 m 0 m 40 m 82 m 0 2 r 40 m 0 5 r 40 m 4 m 40 m 0 m 1 m 0 2 r 40 m 1 m 10
m 0 6 r 10 m 0 6 r 3 m 0 b r 21 m 0 4 r 20 m 0 m 20 m 0 3 r 40 m 82 m 0 4 r 1 m 0 7 r 1 m 80 m 0 4 r 82 m 0 7 r 2 m 0 4 r 20 m
0 m 80 m 20 m 11 m 20 m 0 m 1 m 0 m 1 m 0 m 89 m 8 m 1 m 0 m c0 m 20 m 2 m 0 m c0 m 0 m 82 m 0 2 r a0 m 0 m 88 m 0 3 r 10 m 88
m 0 3 r 10 m 0 4 r 4 m 20 m 40 m 8 m 0 2 r 1 m 8 m 0 m 88 m 8 m 0 4 r 88 m 0 m 2 m 0 2 r c0 m 0 m 10 m c0 m a0 m 10 m 90 m 8 m
2 m 8 m 0 a r c0 2 r 2 m 10 m 0 m c0 m 8 m c0 m 20 m 2 m 88 m 8 m 0 m 82 m 10 2 r notbusy
02 wcmd 1 m 31 m 0 m \ 0x13100 
0 4 r 20 m 0 2 r 8 m 88 m 91 m 1 m 3 m 90 m 8 m 10 2 r 91 m 88 m 0 m 88 m 0 m 40 m 10 2 r 0 4 r a0 m 0 4 r 1 m 0 2 r 10 m 0 3
r 40 2 r 90 m 8 m 0 m 10 m 20 m 82 m 0 m 80 m 0 m 80 m 0 3 r 80 m 0 2 r 80 m 0 7 r 9 m 0 2 r 80 m 0 4 r 5 m 0 5 r 10 m 0 m 11
m 0 m 80 m 0 3 r 20 m 0 m 3 m 88 m 0 m 20 m 80 m 10 m 41 m 80 m 20 m 80 m 0 m 80 m 0 m 80 m 0 a r c0 m 80 3 r 0 2 r 80 m 0 6 r
80 m 0 4 r 10 m 0 4 r 80 m 0 m 8 2 r 91 m 0 m c0 m 0 m 10 m 40 m 0 4 r 80 3 r 0 2 r 2 m 0 m 20 m 0 3 r 10 2 r 11 m 10 m 5 m 3
m 0 m 3 m 20 m 0 6 r 80 m 0 3 r 10 m 0 4 r 9 m 0 m 8 m 0 3 r 3 m 0 3 r 80 2 r 0 m 11 m 0 m 80 m c0 m 0 m 10 m 80 m 10 m 8 m 3
m 0 4 r a1 m 0 m 8 m 0 2 r 8 m 0 m 8 m a1 m 0 2 r 10 m 0 m 88 m 0 m 83 m c0 m 88 m 85 m 88 m 80 m 0 a r 80 m 0 m 80 m c0 m 0 m
80 3 r 0 3 r 41 m notbusy
02 wcmd 1 m 32 m 0 m \ 0x13200 
80 m 0 m 80 2 r 0 7 r 80 m 0 3 r 8 m 80 m 0 m 80 m 0 m 80 m 0 2 r 9 m 80 m 0 b r 10 m 0 m 21 m 0 m 3 m 0 m 3 m 10 m 0 3 r 11 m
80 2 r 0 5 r 1 m 0 m 40 m 0 3 r 2 m 0 3 r 20 m 1 m 0 3 r 2 m 40 m 0 3 r c0 m 2 m 0 m 1 m 40 m 1 m 0 m 1 m 90 m 0 2 r 88 m 40 m
0 m 1 m 0 m 8 m 1 m 0 2 r 2 m 0 3 r 10 m 9 m 0 m 4 m 83 m 11 m c0 2 r 4 m 0 a r 8 m 0 m 8 m 83 m c0 3 r 2 2 r 0 m 20 m 1 m 84
m 88 m 10 m 8 m 0 3 r a0 m 0 3 r a0 m 90 m 0 m 88 m 1 m 10 m 88 m 2 m 0 m 10 m 0 m 88 m 0 m 10 m c0 m 20 m 0 9 r 1 m 90 m 0 6
r 40 m 0 m 88 m 0 m 40 2 r 8 m 0 m 20 m 0 3 r 4 m 0 m 4 m 0 5 r a0 m 0 6 r 1 m 10 m 11 m 0 m 1 2 r 0 3 r 8 2 r 0 m 11 m 1 m 0
2 r 41 m 88 m 20 m 0 m 1 m 0 2 r 1 m 0 m c1 m 0 2 r 8 m c0 m 9 m 0 m 4 m 88 m 11 m c0 2 r 0 9 r 1 m c0 m 8 m 0 m 8 m 4 m 84 m
c1 m c0 m notbusy
02 wcmd 1 m 33 m 0 m \ 0x13300 
10 2 r 0 m 10 3 r 88 m 10 m 1 m 0 2 r 85 m 84 m 0 m 1 2 r 88 m 90 m 1 m 2 m 91 m 4 m 11 2 r a0 m 88 m 0 m 88 m 0 m 88 m 20 m
c0 m 0 5 r 1 m 0 3 r 1 m 0 2 r 1 m 0 3 r 20 2 r 0 m 10 m 0 m 4 m 90 2 r 0 6 r 80 m 0 2 r 10 m 0 m 41 m 80 m 10 m 0 m 20 m 8 m
3 m 0 m 8 m 80 m 90 m 0 m 8 m 40 m 20 m 0 m 4 m 0 m 3 m 0 m 41 m 10 m 9 m 0 m 89 m 0 m 11 m 0 m 20 3 r 3 m 8 m c1 m 0 m 20 m 0
m 5 m 88 m 0 m 83 m 0 m a1 m a0 m 90 m 0 9 r 1 m 5 m 80 m 0 m 80 m 0 m 80 m 84 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 20 m 80 m 4 m
3 m 0 m 8 m 80 m 3 m 4 m 10 m 0 m 8 2 r c1 m 90 m 5 m 8 m 10 m 0 9 r 3 m 0 m 20 m 0 m 8 m 0 m 20 m 0 m 10 m 21 m 3 3 r 0 m 9 m
0 5 r 80 m 0 2 r 80 m 0 m 80 m 0 3 r 80 m 0 3 r 80 m 0 m 82 m 0 m 8 2 r 0 3 r 80 m 0 5 r 80 m 0 5 r 40 m 0 9 r 80 m 0 5 r 41 m
80 m 82 m 80 m 0 m 80 m 85 m 80 m 8 m 0 9 r 1 m 80 m 4 m 80 2 r notbusy
02 wcmd 1 m 34 m 0 m \ 0x13400 
0 m c0 m 0 m 80 2 r 0 m 80 m 89 m 80 m 0 5 r 80 m 2 m 0 5 r 4 m 80 m 8 m 80 m 0 4 r 20 m 0 m 21 m 0 m 80 2 r 0 9 r 10 m 89 m 9
m 10 m 3 m 0 m 40 m 3 m 0 3 r c0 m 0 4 r c0 m 0 m 4 m 0 m 84 m 0 m 88 m 0 m 40 m 88 m 2 m 0 m 4 m 0 m 40 m 0 m 8 m 0 2 r 2 m 0
2 r 2 m 0 2 r 2 m 0 2 r 20 m 90 m 20 m 0 5 r 20 m 8 m 0 3 r c0 m 0 m 8 m 0 m 10 m 90 m 1 m c0 2 r 8 m 20 m 8 m 40 m 8 m c0 m 0
9 r 1 m c0 m 0 m 40 m c0 2 r 40 m c0 m 2 m 40 m 0 m 10 5 r 0 3 r 10 m 0 2 r 84 m 0 2 r 8 m 0 m 82 m 90 m 40 m 10 2 r 0 m 88 m
0 m 88 2 r 20 m c0 m 8 m 0 9 r 1 m c0 m 0 2 r 1 m 0 2 r 1 m 20 m 0 m 10 m 2 m 90 2 r 40 m 0 2 r 21 m 0 2 r 9 m 0 7 r 9 m 0 a r
6 m 0 3 r 90 m 0 12 r 84 m 6 m 84 m 0 2 r d0 m 9 m 0 m 84 m 42 m 0 a r notbusy
02 wcmd 1 m 35 m 0 m \ 0x13500 
0 4 r 9 m 0 m 48 m 42 m 0 3 r c8 m b m 0 m 41 m 0 5 r b m 0 7 r b m 0 7 r b m 0 2 r a m 0 3 r d0 m 0 7 r d0 m 0 2 r 42 m 0 5 r
b m 0 3 r 5f 3 r af m 0 4 r 5f m af 2 r 5f m 0 4 r 3c 2 r c3 2 r 66 m 99 m 66 m 99 m 33 4 r ff m 0 2 r ff m f0 5 r f m f0 m f
m 3c 4 r ff 2 r 0 1c r ff 2 r bf m ff m 66 4 r 0 2 r ff m 0 3 r f0 2 r ff m 0 m fb m 20 m f0 4 r 66 m 36 m 66 2 r ff m fb m 4
m 0 11 r fd m ff m 4 m 0 m ff 3 r df m 5f 2 r af m 5f m 0 4 r 5f m af 2 r 5f m 0 4 r 3c 2 r c3 2 r 66 m 99 m 66 m 99 m 33 4 r
ff m 0 2 r ff m f 4 r f0 m f m f0 m f m c3 4 r 0 2 r ff 2 r 0 e r notbusy
02 wcmd 1 m 36 m 0 m \ 0x13600 
0 e r 20 m 0 m 76 m 66 m 46 m 66 m 0 2 r ff m 0 3 r f0 2 r ff m 0 m ff m 0 m f4 m d0 m f0 2 r 66 4 r ff 2 r 0 12 r ff 2 r 0 4
r 20 m 0 31 r 43 m 10 m 20 m 0 2 r 88 m 11 m 6 m 0 a r 43 m 10 m 20 m 0 2 r 88 m 11 m 6 m 0 38 r f 2 r 55 m 96 m 0 8 r ff 4 r
f0 2 r f 2 r 96 4 r f0 m f m f0 m f m 3c 4 r ff m 0 2 r ff m f 4 r ff m 0 2 r ff m 66 4 r 0 a r notbusy
02 wcmd 1 m 37 m 0 m \ 0x13700 
0 10 r ff 2 r fd m ff m f 4 r 3c 2 r 0 2 r ff 2 r 0 3 r ff m 2 m bf m 0 2 r ff 4 r df m ff 3 r f7 m ff m 0 11 r ff m 8 m fe m
0 2 r ff 2 r 5a m 99 m 55 m 96 m 0 8 r ff 4 r f0 2 r f 2 r 96 4 r f0 m f m f0 m f m c3 4 r ff m 0 2 r ff m f0 4 r ff m 0 2 r
ff m 99 4 r 0 1d r 2 m f 2 r b m 2f m 3c 2 r 0 7 r ff m 0 m ff m 0 m 4 m fb m ff m 0 2 r 4 m 0 4 r 8 m 0 11 r ff m 0 m ff m 0
m 4 m ff m f7 m 10 m 0 m 50 m 30 m 0 5 r 61 m 0 m 6 m 0 m d m 10 m 2 m 40 m 61 m 80 m 6 m 0 m 2d m 10 m 2 m 40 m 61 m 80 m 6 m
0 m 20 m 10 m 2 m 40 m 61 m 80 m 6 m 0 m 2d m 10 m 2 m 40 m 61 m 80 m 6 m 0 m 2d m 8 m 2 m 0 m 61 m 0 m 6 m 80 m 99 m notbusy
02 wcmd 1 m 38 m 0 m \ 0x13800 
0 m 5 m 0 f r 90 m 0 m 5 m 0 m 61 m 0 m e m 0 m d m 0 2 r 15 m 61 m 2a m e m 5 m 4d m 0 m a8 m 0 m 61 m 0 m e m 0 m d m 0 5 r
8 m 0 5 r 61 m 0 m 7 m 0 m 9 m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 c r 4d 4 r bf m ff m 3d m ff m 0 4 r ff 2 r f3 m f0 m 0
4 r 6f m 9f m af m 5f m 0 c r 3f 4 r 0 4 r f8 m ff 3 r 0 1e r aa 2 r a2 m ae m 0 5 r ff m 80 m fd m 0 c r 3c 2 r ac m 3c m ff
m 8 m ff m 0 2 r 80 m ff 2 r 0 10 r 4d 4 r bf m ff m 3d m ff m 0 4 r ff 2 r f3 m ff m 0 4 r 9f m 6f m af m 5f m 0 4 r 1 m 0 7
r 30 4 r 0 2 r notbusy
02 wcmd 1 m 39 m 0 m \ 0x13900 
0 2 r 28 m ff 3 r 0 1e r aa 4 r 0 5 r ff m 0 m ff m 0 c r 3c 4 r f7 m 0 m ff m 0 3 r ff m 7f m 0 14 r 70 2 r 7f 2 r 0 c r ff 2
r f6 m f5 m 0 8 r f m 7d m f m 7d m ac 4 r 0 4 r ff 4 r 0 22 r 4f m e m f 2 r 0 14 r 55 2 r 5d m 51 m ff 3 r fd m 0 14 r 20 2
r 2f 2 r 0 c r ff 2 r 6 m 5 m 0 8 r f m 28 m f m 28 m c 2 r notbusy
02 wcmd 1 m 3a m 0 m \ 0x13a00 
fc 2 r 0 4 r bc m ff 3 r 0 22 r f 4 r 0 14 r 55 4 r 0 3 r 80 m 0 1a r 40 m 0 m 40 m 0 m 40 m 0 5 r a0 m 0 7 r c0 m 0 m c0 m 20
m 2 m 8 m 0 m 9 m 0 6 r 20 m 0 m 20 m 0 8 r 2 m 0 m 80 m 0 b r 80 m 0 d r 2 m 0 2 r a0 m 0 9 r c0 m 0 3 r 1 m 0 3 r 2 m 0 4 r
20 m 0 m 20 m 0 2 r 2 m 0 30 r 1 m 0 2 r notbusy
02 wcmd 1 m 3b m 0 m \ 0x13b00 
0 b r a0 m 0 9 r 10 m 0 m 3 m 0 9 r 4 m 0 13 r c0 m 0 7 r 90 m 0 2 r 8 m 2 m 0 2 r 80 m 0 4 r 1 m 0 m 1 m 0 6 r 20 m 0 2 r c0
m 0 4 r 40 m 0 b r 1 m 20 m 0 3 r 20 m 0 b r 10 m 0 6 r 40 m 0 12 r 9 m 0 7 r 2 m 0 3 r 40 m 0 m 40 m 8 m 0 5 r 1 m 0 2 r 40 m
0 20 r 1 m 0 m 1 m 0 m 5 m 0 m 5 m 0 6 r 40 m 0 4 r 80 m 8 m 0 3 r 8 m 0 m 8 m 0 3 r 8 m 4 m 1 m 0 3 r 1 m 0 m 8 m 0 3 r 40 m
0 5 r 1 m 0 3 r 40 m 0 2 r notbusy
02 wcmd 1 m 3c m 0 m \ 0x13c00 
80 m 40 m 0 m 8 m 0 m 84 m 2 m 8 m 0 3 r 82 m 0 m 40 m 0 m 84 m 0 m 40 m 0 10 r 80 m 0 2 r 84 m 0 2 r 4 m 84 m 0 m 1 m 0 1d r
2 m 0 2 r 20 m 82 m 20 m 90 m a0 m 0 m a0 m 0 7 r 3 m 0 b r 1 m 8 m 0 2 r 84 m 5 m 0 m 2 m 0 m 80 m 0 m 21 m 91 m 41 m 0 3 r 4
m 0 m 2 m 0 m 2 m 0 m 11 m 0 m 4 m 0 m 20 m 0 m 20 m 0 m 11 m 0 2 r 1 m 0 2 r 11 m 0 2 r 88 m 0 m 1 m 0 2 r 80 m 0 m 9 m 0 m 4
m c0 m 0 m 84 m 80 m 0 2 r 41 m 0 m 1 m 0 m 40 m 21 m 1 m 0 3 r 20 m 0 m 1 m 8 m 20 m 0 2 r 88 m 0 3 r 21 m 0 3 r 2 m 20 m 0 2
r 4 m 0 m 20 m 0 2 r 90 m 0 m 88 m 21 m 0 m 11 m 0 2 r 84 m 0 4 r 3 m 0 2 r a0 m 0 m a0 m 21 m 90 m 0 7 r 84 m 0 5 r 8 m 0 m 2
m 0 m 9 m 0 m 4 m 0 5 r 5 m 2 2 r 20 m 0 m 88 m 4 m 8 m 2 m 0 m 41 m 0 m 2 m 0 m 3 m 1 m 40 m 0 m notbusy
02 wcmd 1 m 3d m 0 m \ 0x13d00 
0 2 r 41 m 1 m 40 m 91 m 0 2 r 5 m 0 m 8 m 0 m 3 m 0 5 r 2 m 4 m 0 m 10 m 0 7 r 2 m 0 2 r 20 m 0 m 20 m 0 3 r 4 m 0 3 r 80 m 0
m 4 m 0 m 80 m 0 2 r 4 m 0 m 8 m 0 m a0 m 0 m a0 m 0 m 2 m 40 m 4 m 0 2 r 5 m 1 m 0 2 r 21 m 0 m 5 m a0 m 21 m 4 m 0 3 r 4 m 0
4 r 40 m 84 m 5 m 0 m 21 m 88 m 5 m 82 m 40 m 84 m 3 m 84 m 3 m 82 m 10 m 0 6 r 2 m 0 m 2 m 0 3 r a0 m 0 m 5 m 4 m 2 m 0 2 r 1
m 8 m 0 2 r 1 m 80 m 0 4 r 2 m 0 m 40 m 2 m 0 2 r 85 m 20 m 4 m 20 m 5 m 20 m 4 m 0 m c0 m 9 m 90 m 0 m 10 m 0 8 r 11 m 10 2 r
c0 m 0 m 8 m 0 6 r 4 m 0 m 4 m 0 m 41 m 0 m 4 m 0 5 r c1 m 0 2 r 4 m 20 m 8 m 0 m 8 m 20 m 0 m 20 m 0 3 r 80 m 0 3 r 3 m 0 m
20 m 0 m 20 m 0 3 r 20 m 0 m 4 m 85 m 4 m 84 m 4 m 1 m 4 m 0 m 41 m 2 m 41 m 0 2 r 2 m 40 m 0 m 4 m 0 2 r c0 m 9 m 20 m 0 6 r
1 m 0 m 1 m 0 m 84 m 0 m 21 m 0 2 r 80 m 1 m 0 2 r 4 m 0 3 r 4 m 20 m 0 2 r 21 m 0 m 8 m 0 m notbusy
02 wcmd 1 m 3e m 0 m \ 0x13e00 
83 m 1 m 0 2 r 4 m 1 m 80 m 1 m 84 m 1 m 0 m a0 m 0 8 r 2 m 0 6 r 85 m 0 7 r 1 m 0 m 1 m 0 m 1 m 0 3 r 1 m 0 5 r 4 m 0 2 r 80
m 1 m 0 2 r 2 m 1 m 0 m 1 m 0 3 r 20 m 0 5 r 1 m 0 m 1 m 0 3 r 1 m 0 m 1 m 20 m 1 m 0 m 1 m 20 m 1 m 0 f r c0 m 0 m 21 m 0 2 r
20 m 21 m 40 m 0 7 r 90 m 0 2 r 2 m 0 2 r 40 m 9 m 0 m 21 m 0 m 21 m 2 m 0 2 r 4 m 90 m 21 m 0 2 r 10 m 80 m a0 m 0 m 8 m 40 m
0 m 20 2 r 80 m 82 m 2 m 0 m 5 m 0 m 80 m 10 m 0 m 82 m 0 m 8 m 40 m 0 e r 20 2 r 40 m 0 2 r 21 m 82 m 0 m 1 m 4 m 40 m 0 2 r
4 2 r 0 m 4 m 11 m 0 3 r 2 m 4 2 r 0 m 4 2 r 0 2 r 3 m 0 m 20 m 0 m 20 m 88 m 20 m 40 m 0 m 84 m 0 m 88 m 0 2 r 3 m 40 m 0 4 r
4 m 40 m 0 m a0 m 0 m 4 m 0 m c0 m 5 m 4 m 0 m 21 m 0 5 r 80 m 0 4 r a0 m 0 3 r 84 m 0 m 2 m 40 m 8 m 0 m 88 m 0 2 r 8 m 0 m
notbusy
02 wcmd 1 m 3f m 0 m \ 0x13f00 
8 m 0 m 40 m 0 m 9 m 0 2 r 82 m 0 m 20 m 0 m 20 m 85 m 4 m 0 m 4 m 80 m 4 m 5 m 40 m 0 2 r 40 m 20 m 3 m 90 m 0 m 20 2 r 40 m
0 e r 88 m 0 4 r a0 m 0 2 r 20 m a0 m 9 m c0 m 0 m 1 m 80 m 0 m c0 m a0 m 0 3 r 90 m a0 m 4 m 40 m 4 m c0 m 0 2 r 4 m 0 m 5 m
0 m 41 m 21 m c1 m 0 7 r 82 m 40 m 0 4 r 2 m 40 m 0 m 21 m 0 m 80 m 84 m 41 m 0 m 80 m 0 12 r 8 m 40 m 0 m 40 m 21 m 40 m 21 m
0 2 r 84 m 0 m 40 m 0 m 40 m 2 m 0 m 11 m 0 5 r 11 m 0 c r 10 m 0 m 82 m 2 m 0 2 r 84 m 4 m 0 7 r 21 m 40 m 0 m 40 m 80 m 8 m
0 2 r 4 m 0 m 4 m 88 m 21 m 5 m 11 m 0 3 r 91 m 0 m 21 m 0 m 3 m 4 m 20 m 84 m 0 m 4 m 20 m 84 m 0 2 r 20 m 82 m 41 m 82 m 20
m 0 4 r 84 m 0 m 84 m 0 3 r 90 m 0 4 r 21 m 0 2 r 4 m 20 m 8 m 0 m 41 m 0 m c0 m 0 15 r 80 m 0 m notbusy
20 wcmd 1 m 40 m 0 m notbusy \ 0x14000
02 wcmd 1 m 40 m 0 m \ 0x14000 
80 m 8 m 0 6 r 80 m 1 m 0 3 r 82 m 0 3 r 82 m 0 8 r 41 m 0 3 r 3 m 0 m 2 m 40 m 3 m 2 m 0 5 r 2 m 0 7 r 4 m 0 2 r 8 m 1 m 0 m
1 m 0 2 r a0 m 0 m 2 m 0 2 r 20 m 0 2 r 21 m 0 m 80 m 1 m 0 2 r 80 m 1 m 0 3 r 1 m 0 3 r 1 m 0 c r 2 m 0 3 r 2 m 0 m 80 m 1 m
0 2 r 4 m 0 2 r 40 m 0 m 1 m 0 2 r c0 m 1 m 0 2 r 20 m a0 m 1 m 2 2 r 20 m 2 m 90 m 0 m a0 m 0 m 2 m 0 m 2 m 0 m 8 m 0 m 1 m
a1 m 1 m 20 m 1 m 0 2 r 2 m a0 m 21 m 20 2 r 90 2 r 88 m 0 10 r a0 m 4 m 0 m a0 m 40 m 8 m 40 m 4 m 0 3 r 1 m 0 m 1 m 8 m 0 3
r c0 m 82 m 1 m 4 m 3 m 40 m 4 m 0 m 40 m 88 m 0 m 83 m 1 m 2 m 9 m 88 m c0 m 2 m 20 m 8 m 0 m 82 2 r 20 m 88 m 2 m 0 m 8 m 0
m 8 m 4 m c0 m 0 m 1 m 0 2 r 8 m 0 2 r 1 m 2 m 0 2 r 2 m 0 m 2 m 88 m 2 m c0 m 40 m 0 m 82 m 0 m 2 m 10 m 2 m 0 m 8 m 0 m 20 m
0 m 8 m 0 m 2 m 0 m 80 m 3 m 80 2 r 0 4 r 80 m notbusy
02 wcmd 1 m 41 m 0 m \ 0x14100 
0 3 r 80 m 0 3 r 40 m 90 m 20 m 0 m 40 m 0 m 9 m 80 2 r 41 m 0 15 r 88 m 0 m 21 m 0 4 r 80 m 0 2 r 11 m 10 m 9 m 8 m 84 m 2 m
0 m 9 m c0 m 2 m 41 m 89 m 8 m 9 m 0 m 8 m 80 m 41 m 0 m 83 m 8 m 2 m 11 m 5 m 89 m 80 m 0 m 80 m 0 m 80 2 r 0 2 r 80 m 0 4 r
80 m 0 2 r 8 m 20 m 10 m 88 m 9 m 0 m 8 m 80 m 0 3 r 8 m 0 2 r 80 3 r 0 m 80 m 0 m 80 2 r 0 m 2 m 0 3 r 8 m 0 m 4 m 20 m 80 m
0 3 r 80 m 8 m 0 4 r 90 m 20 m 88 m 0 m 8 m 0 m 10 m 0 m 85 m 0 m 2 m 0 m 3 m 0 4 r 3 m 80 m 0 m 80 2 r 0 b r 9 m 0 4 r c1 m 0
m 83 m 20 m 88 m 8 m 2 m 0 3 r 9 m 0 m a1 m 0 m 11 m 0 m 82 2 r 8 m 80 m 2 m 40 m 89 m 80 m 8 m 2 m 0 3 r 8 m 0 m 88 m 0 m 80
2 r 0 m 80 m 21 m 80 2 r 0 4 r 80 m 11 m 0 4 r 10 m 80 m 41 m 5 m 10 m 20 m 8 2 r 0 m 40 m 80 m 5 m 80 m 4 m 0 2 r 80 m 0 m 80
m 9 m 80 m 82 m 80 2 r 0 m 90 m 0 6 r 40 m 0 m 88 m 0 m a0 m 1 m notbusy
02 wcmd 1 m 42 m 0 m \ 0x14200 
10 m 20 m 90 m 0 m 10 m 1 m a0 m 90 m 9 m 0 m 20 m 0 m 10 m 0 m 11 m 0 m 11 m 0 m 10 m 0 m 8 m 1 m a0 m 0 m 82 m 4 m 0 d r 20
m 0 2 r 2 m 0 m 2 m 0 m a1 m 90 2 r 0 3 r 88 m 10 m 4 m 0 m a0 m 0 m c0 2 r 9 m c0 m 90 m 8 2 r 40 m 2 m 0 m 2 m 0 m 90 m 0 m
8 m 84 m 2 m 10 m 84 m 0 m 10 m 0 m 82 m 10 m 20 m 0 m 8 m 0 m 10 m 0 m 4 m 8 2 r 0 2 r c0 m 0 2 r 1 m 0 2 r 1 m 0 m 1 m 4 m 0
m 4 m 1 m 2 m 0 m 10 m 0 m 8 m 0 m 2 2 r 8 m 2 m 0 2 r 1 m 0 m 21 m 0 2 r 1 m 8 m 10 m 0 m 90 m 0 m 2 m 8 m 40 m 90 m 88 m 0 m
88 m 0 m 1 m 88 m 8 m 0 m 1 2 r 0 m a0 m 0 3 r 88 m 90 m 0 m 11 m 84 m 1 m 10 m 4 m 0 2 r 2 m 0 d r 90 m 40 m 0 m 20 m 4 m 8 m
c0 m 83 m 0 3 r 1 3 r 0 4 r 90 m 2 m 0 m 40 m 2 m 84 m 3 m 11 m 90 m 10 m 0 m 2 m 88 m 8 m 10 m 88 m 40 m 2 m 0 m 10 2 r 4 m 2
m 20 m 10 2 r 0 m 8 m 0 m 4 2 r c0 m 0 m 1 m 0 2 r 10 m 0 2 r 1 m c0 m 2 m 82 m 40 m 2 m 10 m 9 m 0 m 10 2 r 0 m 40 m 2 2 r 88
m 2 m 0 m 20 m 10 m 41 m 5 m 10 m 8 m 40 m 80 m 11 m notbusy
02 wcmd 1 m 43 m 0 m \ 0x14300 
0 m 11 m 0 m 9 m 0 m 11 m 0 m 8 m 0 m 8 m 0 m 8 m 9 m 80 m 0 m 8 m 40 m 41 m c1 m 5 m 0 m 5 m 0 m 4 m 0 m 8 m 0 m 8 m 0 m 83 m
0 2 r 80 m 0 e r 4 m 0 m c0 m 80 m 20 m 88 m 5 m 0 3 r 8 m 3 2 r 9 m 2 m 10 m 11 m 0 m 2 m 21 m 84 m 2 m 88 m 90 m 88 m 0 2 r
11 m 80 m 5 m 80 m 88 m 0 m 80 2 r 0 m 80 2 r 0 3 r 80 2 r 0 3 r 80 m 85 m 0 2 r 10 m 20 m 41 m 20 2 r 0 m 8 m 0 m 80 m 0 m 80
m 0 2 r 41 m 0 m 80 2 r 0 m 80 2 r 0 3 r 2 m a1 m 21 m 0 m 10 m 0 m 8 m 10 m 0 m 8 m 0 7 r 2 m 0 m 80 2 r 0 m 80 m 0 m 2 m 89
m 2 m 0 3 r 2 m 8 m 0 m 10 m 80 m 0 6 r 11 m 0 6 r 80 m 0 8 r 89 m 80 m 21 m 80 m a1 m 0 m 5 m 0 2 r 8 m 80 m 11 m 9 2 r 0 m
11 m 91 m 2 m 3 m 85 m 88 2 r 0 m a0 m 9 m 80 m 0 2 r c1 m 0 m 80 m 0 3 r 8 m 80 m a1 m 0 4 r 80 m 0 2 r 20 m 80 2 r 0 2 r a0
m 0 m a0 m 0 m 90 m 0 m 8 m 41 m 80 m 0 2 r 41 m 0 6 r 80 m 90 m 80 2 r 0 3 r 41 m 0 2 r 1 m 0 m notbusy
02 wcmd 1 m 44 m 0 m \ 0x14400 
1 2 r 20 m 0 m 8 m 10 m 0 m 90 m 2 m 0 m 90 m 8 m 10 2 r 84 m 20 m 10 m 0 m 1 m a0 m 1 m 90 m 0 m 20 m 1 2 r 0 m 1 m 4 m 90 m
0 m 10 m 20 m 0 9 r c0 m 0 m 82 m 0 m 82 m 0 m 20 m 0 m 10 m 40 m 2 m 41 m 84 m 83 m 20 m 0 4 r c0 m 0 m 91 m 0 m 10 m 0 m 90
m 82 m 4 m 3 m 10 m 4 m 90 m 5 m 0 m 8 m 0 m 8 m 2 2 r 84 m 88 m 0 m 20 m 0 m 8 m 10 m 20 m 4 m 40 m 0 m 4 m 0 m 4 m 8 m 84 m
c0 m 88 m 0 m c0 m 20 m 2 m 0 m 5 m 0 m 1 2 r 40 m 0 m 2 m 3 m 10 m 90 m c0 m 0 m 10 m 0 m 10 m 11 m 2 2 r 82 m 0 a r 81 m 0 2
r b m 0 4 r 81 m 0 2 r b m 0 c r 81 m 0 2 r b m 0 m 50 m 0 m 81 m 0 2 r d0 m 0 5 r 6 m 0 2 r 9 m 0 a r 82 m 0 5 r d0 m 43 m 1
m 42 m 81 m 0 3 r d0 m b m 0 m 42 m 0 4 r d0 m b m 0 7 r b m 0 m 42 m 0 5 r b m 0 2 r 6 m 0 3 r d0 m 0 2 r 42 m 12 m 0 3 r c8
m b m 0 m 41 m a m 0 4 r b m 0 m 60 m 0 3 r notbusy
02 wcmd 1 m 45 m 0 m \ 0x14500 
0 6 r 3c m ff 7 r fe m ff 3 r fc 2 r ff 2 r 0 8 r ff 8 r 0 8 r 66 m 99 m cc 2 r 0 8 r bc 3 r ff m 0 a r f0 2 r 0 m ff m 0 m 10
m ff 3 r f7 m ff 4 r 7f m ff m 3c 3 r 7c m 3c 3 r 3a m 0 2 r ff 2 r 0 m ff m 80 m bf m f0 m 0 m ff m 0 5 r 3c m c m 3c 2 r ff
m f7 m ff m f7 m 3c m 2c m 3c m 7c m ff 2 r ef m ff m 0 8 r 3c m ff 3 r fa m fe m ff 2 r fa m ff 3 r fc 2 r ff 2 r 0 8 r 3c m
ff m 3c m ff m f8 2 r ff 2 r 0 8 r ff 4 r 0 5 r 4 m 0 2 r a0 3 r ff m 0 a r aa 2 r 3c 2 r 0 2 r ff m ef m 0 3 r 8 m 0 3 r 80 m
3c 3 r 2c m 3c 4 r 0 m 20 m ff m 7f m 0 m ff m 0 m ff m f0 m 0 7 r 3c 4 r 0 4 r 3c 4 r 0 2 r notbusy
02 wcmd 1 m 46 m 0 m \ 0x14600 
0 m 10 m 0 8 r ff 2 r 7f m 3f m ff m 7f m ff m 5f m ff 2 r 7f m 5f m ff 4 r 0 4 r ff m 3d m ff m 5 m ff 7 r 1f m 0 10 r 7f m
43 m 3 2 r ff m fc m ff m fc m 0 6 r b7 m f7 m 0 2 r a 2 r ff m aa m f m 17 m f 2 r ff 2 r ef m ff 3 r fe m ff 3 r 8 m 0 m 1e
m 3c 3 r ff 2 r 0 2 r ff 2 r ef m ff m 0 8 r ff 8 r 75 m 55 m 45 m 55 m 3c m 3d m 3c m 38 m 0 8 r ff 2 r 5f m f m ff m 3f m ff
m f m ff 2 r 3f m f m ff m 1f m ff m 14 m 0 4 r 3d 2 r 5 2 r ff 2 r 3d m 5 m ff m 1f m ff m 1f m 0 10 r 7d m 41 m 0 2 r ff m
5c m ff m c m 0 6 r bf m ff m 0 2 r a 2 r 55 m 0 m f 4 r 10 m 0 5 r 4 m 0 m f7 m ff m 0 2 r 3c 4 r ff m fb m 4 m 0 m 10 m 0 b
r 10 m 0 m 10 m 0 3 r 5 m 0 m 55 2 r notbusy
02 wcmd 1 m 47 m 0 m \ 0x14700 
55 2 r 3c 4 r 0 m 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 26 m 0 m d m 0 3 r 61 m 0 m 26 m 0 m d m 0 3 r 61 m 0 m 6 m 0 m d m 0 3
r 61 m 0 m 26 m 5 m d m 0 3 r 61 m 0 m 6 m 80 m d m 0 2 r 10 m 0 2 r 30 m 0 5 r 61 m 0 m 6 m 0 m d m 0 5 r 61 m 0 m 1 m 0 m 1
m 0 m a8 m 0 m 61 m 30 m 9 m 0 m 1 m 0 3 r 61 m 0 m b m 0 m d m 0 5 r 8 m 0 7 r 8 m 0 4 r a0 m 61 m 0 m 1 m 0 m 1 m 0 3 r 61 m
0 m f m 0 m d m 0 5 r 8 m 0 5 r 2 m 0 2 r 3a m 0 m 3a m f m 0 4 r ff m fd m ff 2 r 0 4 r ff m f3 m ff m f3 m 0 3 r c3 m b2 m
30 m 82 m 0 6 r 3c m 0 m 3c m 0 14 r be m fe m ff 2 r 0 2 r ff 2 r 0 2 r 3c 2 r bc m 3c m fd m 8 m ff m 0 3 r ff 2 r 0 18 r df
m ff 3 r 3c 3 r 78 m 0 6 r notbusy
02 wcmd 1 m 48 m 0 m \ 0x14800 
0 e r 3a m 0 m 3a m f m 0 4 r ff 4 r 0 4 r ff m f3 m ff m f3 m 0 3 r c3 m 0 8 r a0 m bc m 0 m 3c m 0 15 r f0 m ff 2 r 0 2 r f7
m ff m 4 m 0 m 3c 2 r 1c m 3c m ff m 0 m ff m 0 2 r 20 m ff m f7 m 0 18 r 8 m 0 3 r 3c 4 r 0 10 r af m a7 m ff m a7 m 28 2 r
eb 2 r 0 c r ff 4 r 0 4 r a0 2 r a4 m a0 m 0 1c r 4 3 r ff m 0 2 r bf m ff m 10 m 0 m f0 m 78 m f0 2 r 75 m 45 m 55 2 r 3c 2 r
bc m 3c m 7c m 3c 3 r 0 14 r ff m ef m 10 m 0 2 r 10 m ff m bf m 0 2 r notbusy
02 wcmd 1 m 49 m 0 m \ 0x14900 
0 e r af m f7 m ff m f7 m 0 m 3c m c3 m ff m 0 c r f m ff 3 r 0 3 r 80 m a0 4 r 0 1f r ff m 0 2 r ff 2 r 0 2 r f0 4 r 55 4 r
3c 2 r 1c m 3c m 2c m 3c 3 r 0 14 r ff 2 r 0 4 r ff 2 r 0 10 r 40 m 0 15 r 10 m 0 2 r 4 m 0 6 r 20 m 0 4 r 80 m 0 m 80 m 0 5 r
11 m 0 7 r 80 m 0 5 r 2 m 0 d r 11 m 0 11 r 4 m 0 14 r notbusy
02 wcmd 1 m 4a m 0 m \ 0x14a00 
0 c r 2 m 0 m 2 m 0 3 r 5 m 0 1d r 20 m 0 m 41 m 0 4 r 8 m 0 m 8 m 0 8 r 41 m 0 4 r 10 m 0 9 r 20 m 0 m 1 m 0 m 82 m 40 m 0 8
r 40 m 0 3 r 82 m 0 m 2 m 0 2d r 40 m 0 3 r 4 m 0 7 r 8 m 0 1a r 10 m 0 2 r 20 m 0 m 80 m 8 m 82 m 1 m 2 m 0 5 r 4 m 0 m c0 m
0 m 80 m 40 m 84 m 40 m 8 m 0 2e r notbusy
02 wcmd 1 m 4b m 0 m \ 0x14b00 
0 1b r 2 m 0 15 r 10 m 0 9 r 10 m 80 m 0 2 r 1 m 0 m 20 m 80 m 3 m 20 m 1 m 0 3 r 82 m 0 m 1 m 0 m 21 m 0 m 10 m 80 m 41 m 80
m 1 m 0 6 r 2 m 0 8 r 4 m 0 2b r 90 m 0 12 r 40 m 0 5 r 88 m 0 m 20 m 0 4 r 40 m 0 4 r 88 m 0 m 20 m 0 m 84 m 4 m 0 m 40 m 1 m
40 m 88 m 0 3 r 84 m 0 m 88 m 0 2 r 80 m 90 m 0 m 88 m 20 m 40 m 0 m 20 2 r 40 m 80 m 0 3 r 20 m 0 8 r 2 m 0 5 r 20 m 0 f r 90
m 0 m 20 m 0 9 r notbusy
02 wcmd 1 m 4c m 0 m \ 0x14c00 
0 14 r 84 m 0 3 r 84 m 0 m 4 m 90 m 5 m 0 m 5 m 8 m 40 m a0 m 8 m 0 2 r 8 m 0 m 4 2 r 0 m 41 m a0 m 2 m 82 m 2 m 90 m 9 m 0 2
r 2 m 5 m 40 m 11 m 0 m 4 m 84 m 2 m 0 m 5 m a0 m 4 2 r 0 m 84 m 0 3 r 8 m 3 m a0 m 0 m 10 m 3 m 0 m 9 m 1 m 83 m 20 m 40 m 0
m 5 m 20 m 0 3 r 91 m 0 5 r 2 m 0 5 r 84 m 0 5 r 4 m 0 m 88 m 0 2 r 41 m 0 3 r 41 m 0 2 r 88 m 0 2 r 9 m 0 4 r 2 m 20 m 0 m 5
m 0 5 r 20 m 0 3 r 20 m 82 m 0 m 90 m 0 3 r 88 m 40 m 0 2 r 8 m 0 2 r 11 m 88 m 0 7 r 8 m 0 9 r 41 m 0 3 r 8 m 0 5 r 8 m 40 m
0 m 4 m 0 3 r 4 m 0 m 4 m 0 m 40 m 0 3 r 1 m 4 m 40 m 0 2 r 20 m c0 m a0 m 0 m 20 m 0 3 r 10 m 0 m 2 m 0 m 11 m 0 4 r 82 m 80
m 0 9 r 11 m 0 d r 9 m 0 m 9 m 0 5 r 2 m 0 4 r notbusy
02 wcmd 1 m 4d m 0 m \ 0x14d00 
0 8 r 84 m 0 5 r 90 m 0 6 r 41 m 0 6 r 2 m 0 2 r c0 m 0 m c0 m 0 5 r 84 m 0 11 r 8 m 0 3 r 10 m 8 m 0 m 40 m 84 m 0 3 r 10 m
20 m 0 m 4 m 0 3 r 40 m 21 m 10 m c1 m 21 m 84 m 0 m 89 m 0 m 1 m 0 7 r 10 m 0 2 r 4 m 0 9 r 21 m 0 2 r 88 m 11 m 0 9 r 4 2 r
0 m 20 m 0 e r 5 m 0 9 r 11 m 0 4 r 4 m 0 a r c0 m 0 4 r 2 m c0 m 0 d r 40 m 8 m 0 6 r 4 m 0 3 r 10 m 0 m a0 m 40 m 91 m 0 3 r
c0 m 0 2 r 2 m 90 m 0 m 83 m 2 m 0 2 r 9 m 0 4 r 80 m 0 e r 40 m 0 3 r 40 m 0 a r 8 m 0 6 r notbusy
02 wcmd 1 m 4e m 0 m \ 0x14e00 
0 17 r 11 m 0 a r 40 m 90 m 0 m 82 m 20 m 0 m 20 m a0 m 2 m 0 2 r 4 m 20 m 8 m 9 m 40 m 4 m 84 m 9 m a0 m 0 m a0 m 9 m 40 m 11
m 2 m 5 m 88 m 9 m 0 2 r 10 m 8 m c0 m 5 m 4 m 9 m 10 m 40 m 91 m 20 m 0 5 r 5 m 0 m 40 m 0 m 8 m 0 3 r 40 m 0 2 r 90 m 9 m 4
m 41 m 4 2 r 20 m 0 3 r 90 m 20 m 88 m 0 m 90 m 11 m 0 m 2 m 90 m 0 2 r 40 m 0 m 3 m 84 m 11 m 2 m 0 m c0 m 40 m 0 m 9 m 8 m
11 m 0 8 r 90 m 9 m 88 m 10 m 0 4 r 90 m 9 m 90 m 20 m 0 m 40 m 88 m 0 m 2 m 0 2 r 20 m 0 2 r 4 m 0 m c0 m 3 m 0 16 r 11 m 0 7
r 3 m 0 4 r 40 m 0 m 10 m 0 5 r 1 m 4 m 0 2 r 82 m 40 m 0 2 r 84 2 r 0 6 r 90 m 0 2 r 11 m 0 m 2 m 0 m 80 m 0 6 r 4 m 0 c r 4
m 0 7 r 8 m 0 2 r notbusy
02 wcmd 1 m 4f m 0 m \ 0x14f00 
0 1e r 2 m 0 m 90 m 0 6 r 10 m 0 m 10 m 0 3 r 10 m 0 7 r c0 m 0 7 r 8 m 0 3 r 2 m 0 2 r 10 m 2 m 5 m 0 2 r 20 m 0 2 r 2 2 r 0
m 20 m 0 m 3 m 0 2 r 41 m 11 m 0 2 r 11 m 88 m 0 5 r 90 m 40 m 0 2 r 20 m 11 m 0 7 r 4 m c0 m 0 m 20 m 0 m 82 m 0 6 r 4 m 0 4
r 90 m 0 m 20 m 0 6 r 4 m 0 m 20 m 0 2 r 4 m 20 m 0 m 5 m 4 m 0 a r 40 m 0 2 r 4 m 40 m 4 m 9 m 90 m 0 m 40 m 0 m 4 m 0 m 10 m
0 20 r c1 m 0 m c0 m 0 4 r 82 m 0 2 r c0 m 0 m 1 m 82 m 1 m 83 m 1 2 r c0 m 0 2 r 40 m 0 m 82 m 91 m 0 m c1 m 0 m 1 m 0 m 3 m
82 m 0 18 r notbusy
20 wcmd 1 m 50 m 0 m notbusy \ 0x15000
02 wcmd 1 m 50 m 0 m \ 0x15000 
0 4a r 88 m 41 m a1 m 10 m 0 3 r 80 m 0 m 41 m 80 m 41 2 r 80 m 41 m 83 m 41 m 40 m 85 m 21 m 0 m 80 m 0 m 80 m 41 m 0 m c1 m
21 m 41 2 r c1 m 80 m 0 63 r 80 m c1 2 r 0 m 41 m 0 m 3 m 80 2 r 41 2 r 0 m 41 m 83 m 41 m c1 2 r a1 m 83 m 0 m 41 m 80 m 41 m
80 m c1 m 80 m 41 m 0 2 r 80 m 41 m 0 14 r notbusy
02 wcmd 1 m 51 m 0 m \ 0x15100 
0 4f r c0 m 40 m 11 m 0 m 1 m 0 2 r 40 m c0 m 0 m 9 m 0 m 1 m 83 m 1 m c0 m c1 m 20 m 8 m 0 m 1 m 4 m 1 m 2 m c1 m 20 m 1 m 0
2 r 4 m 1 m 0 63 r 40 m 0 2 r c0 m 0 4 r 4 m 8 m 0 m c1 m 83 m 1 m 82 m 0 m 8 m 0 2 r c1 m 83 m c0 m 1 m 0 m 40 m 0 2 r c1 m
85 m 1 m 82 m 0 10 r notbusy
02 wcmd 1 m 52 m 0 m \ 0x15200 
0 53 r 80 m 0 m 41 m a0 m 41 m 2 m 0 2 r 80 m 0 m 21 m c1 m 83 m 10 m 80 m 0 m c1 m 0 2 r c1 m 83 m 80 m 3 m 0 m 80 m 0 m 41 m
c1 m 85 m 41 m 80 m 0 62 r 40 m c1 m 0 m 80 m c1 m 10 m 41 m 88 m 90 m c1 m 80 m c1 m 83 m c1 m 3 m c1 m 41 m 80 2 r 41 m 83 m
41 m 3 m 80 2 r c0 m 0 m 10 m 85 m 90 m 0 m 41 m 0 c r notbusy
02 wcmd 1 m 53 m 0 m \ 0x15300 
0 56 r 1 m c1 m 0 m 82 m 40 m c0 m 0 m c0 m 41 m 3 m 20 m 83 2 r 11 m 1 m c1 m 0 m c0 m 40 m 1 m 3 m 1 2 r c0 m 40 m c0 m 20 m
c1 m 85 m 41 m 0 m 1 m 0 62 r 81 m 12 m 0 4 r 48 m 42 m 81 m 12 m 0 m d0 m 0 2 r 48 m 42 m 88 m 12 m 0 4 r 48 m 42 m 88 m 12 m
0 4 r 48 m 42 m 0 8 r notbusy
02 wcmd 1 m 54 m 0 m \ 0x15400 
0 3a r ff 82 r 0 m 17 m 68 m a5 m 30 m 22 m 1 m 7 m 0 m 16 m 50 m 60 m 0 2 r 16 m 58 m 0 27 r 10 m 0 c r notbusy
02 wcmd 1 m 55 m 0 m \ 0x15500 
0 76 r 20 m 0 5a r 80 m 1 m 0 m 1 m 0 m 21 m 0 d r 8 m 5 m 0 8 r 5 m 0 2 r 11 m 1 m 0 m c0 m 0 2 r 3 m 84 m 4 m 0 m 41 m 0 4 r
notbusy
02 wcmd 1 m 56 m 0 m \ 0x15600 
0 4 r 20 m 0 2 r 9 m 0 m 80 m 0 3 r 41 m 0 b r 20 m 0 m 80 m 90 m 0 5 r 40 m 0 m 20 m 0 m 20 m 0 m 20 m 0 4 r 80 m 0 c r 8 m 0
5 r 1 m 0 m 88 m 0 m 84 m 0 m 20 m 41 m c0 m 0 a r 10 m 20 m 0 m 20 m 0 m 88 m 0 8 r 40 m 0 2 r 41 m 0 m 80 m 0 9 r 2 m 0 3 r
40 m a0 m 8 m 4 m 0 2 r 41 m 0 10 r 2 m 0 7 r 3 m 0 5 r 2 m 0 3 r 20 m 0 3 r 2 m 0 4 r 80 m 0 m 80 m 0 m 80 m 0 4 r 2 m 0 c r
80 m 0 5 r 20 m 0 11 r 21 m 0 5 r 40 m 0 4 r 10 m 8 m 0 3 r 8 2 r 0 2 r 88 m 0 m 8 2 r 0 2 r 90 m 40 m 1 m 0 m 1 m 4 m 0 m 40
m 0 m 80 m 0 2 r 2 m 0 3 r 4 m 0 m notbusy
02 wcmd 1 m 57 m 0 m \ 0x15700 
0 m 40 m 0 m 80 m 2 m 80 m 0 m c0 m 0 8 r 8 m 0 m 40 m 10 m 0 m 2 m 0 7 r 2 m 0 8 r 1 m 0 m 1 m 0 c r 8 m 0 20 r 88 m 0 2 r 10
m 0 2 r 80 m 0 2 r 82 m 0 m 83 m 80 m 0 2 r 4 m 80 m 0 2 r 2 m 0 m 8 m 80 m 2 m 0 m 82 m 0 m 1 m 40 m 84 m 40 m 0 2 r 1 m 0 m
40 m 0 2 r a0 m 0 3 r 80 m 0 2 r 1 m 10 m 2 m 80 m 2 m 0 m 3 m 41 m 10 m 0 m 82 m 0 2 r 5 m 0 m 80 m 0 m a0 m 82 m 0 11 r 84 m
20 m 0 m 10 m 4 m 0 b r 1 m 0 9 r 90 m 0 4 r 9 m 8 m 0 11 r 2 m 0 m 9 m 8 m 0 2 r 11 m 4 m 0 m 88 m 5 m 82 m 2 m 0 m 8 m 2 m 0
m 85 m 90 m 84 m 10 m 2 2 r 0 3 r 2 m 84 m 2 m 84 m 2 m 88 m 40 m 84 m 0 m 90 m 2 m 82 m 0 m notbusy
02 wcmd 1 m 58 m 0 m \ 0x15800 
84 m 40 2 r 0 2 r 41 m 0 m 5 m 84 m 0 5 r a0 m 0 m c0 m 20 m 0 2 r 10 m 80 m 40 2 r 0 2 r 20 m 0 m 40 m 0 m 82 m 0 m a0 m 0 m
40 m 11 m c0 m 0 m 20 m 0 m 20 m 0 2 r 80 m 4 m 11 m 90 m 3 m 4 m 20 m 4 m 21 m 40 m 2 m 88 m 0 m 91 m 8 m 84 m 0 m 4 m 2 m 84
m 0 m 4 m 11 m 8 m 90 m 0 2 r 20 m 11 m 88 m 0 m 82 m 80 m 1 m 82 m c0 m 80 m 85 m 0 m 84 m 0 2 r 11 m 0 3 r 21 m 0 b r a0 m 0
m a0 m 0 2 r 80 m a0 m 8 m 11 m 0 m 1 m 80 m 0 m 41 m 2 m 41 m 0 m 41 m 0 4 r 2 m 10 m 0 2 r 91 m 40 m 0 m 41 m a1 m 80 m 0 2
r 84 m 0 2 r 3 m 0 3 r 21 m 0 2 r 90 m 0 3 r 84 m 0 m 2 m 80 m 0 c r 90 m 0 7 r 20 m 80 m 0 3 r 80 m 91 m 80 m a0 m 80 m 1 m 9
m 0 m 10 m 1 m 0 2 r a1 m 2 m 0 2 r 80 m 0 m 80 m 11 m 0 7 r 20 m 4 m 20 m 0 m 20 m 4 m 0 2 r 20 m 0 m 20 m 0 4 r 84 m 3 m 1 m
21 m 9 m 10 m 0 m 10 m 0 m 80 m 0 2 r 8 m 0 2 r 3 m 0 2 r 1 m 41 m 82 m 10 m 84 m 80 m 89 m 0 m 84 m 0 m 2 m 0 m 4 m 0 m 84 m
0 2 r 2 m notbusy
02 wcmd 1 m 59 m 0 m \ 0x15900 
1 m 0 m 82 m 4 m 0 m 41 m 4 m 40 m 88 m 41 m 0 m 40 m 0 4 r 40 m 91 m 0 m 84 m 0 6 r 88 m 0 3 r 88 m 4 m 90 m 0 m a0 m 4 m 0 m
4 m 0 6 r 83 m 0 m 10 m 0 5 r 90 m 0 m a1 m 0 2 r 80 m 0 2 r c1 m 0 m 84 m 0 7 r 20 m 80 m 4 m 0 2 r 80 m a0 m 80 m 0 2 r 8 m
0 3 r 8 m 0 m 2 m 0 3 r a0 m 0 2 r 80 m 0 2 r 2 m 0 m 8 m 1 m 20 m 1 m 0 m 40 m 20 m 0 m a0 m 4 m 0 m 82 m 0 m 90 m 8 m 0 2 r
1 m 0 m 40 m 2 m 0 2 r 84 m 90 m 0 m 20 m 4 m 0 3 r 1 m 2 m 4 m 20 m 82 m 3 m 90 m c0 m 85 m 0 m c0 m 0 m a1 m 0 m 88 m 0 m 10
m 80 m 2 m 0 m 40 m 0 3 r 84 m 0 5 r 2 m 20 m 1 m 0 3 r 1 m 0 m 1 m 0 6 r 4 m 8 m 9 m 84 m 0 2 r 8 m 0 m 5 m 0 m 4 m a0 m 0 m
2 m 5 m 20 m 4 m 0 m 40 m 0 4 r 88 m 3 m 0 2 r 10 m 80 m 0 2 r 20 m 0 m 4 m 0 3 r 84 m 0 4 r 80 m 90 m 0 5 r 10 m 0 3 r 8 m 0
m 4 m 0 3 r 9 m 0 m 11 m 1 m 0 2 r 20 m 0 2 r 2 2 r 9 m 40 m 88 m 5 m 84 m 20 m 4 m 41 m 84 m 0 m 88 m 0 m notbusy
02 wcmd 1 m 5a m 0 m \ 0x15a00 
0 2 r 10 m 0 m 40 m 2 m 4 m 40 m c0 m 80 m 1 m 0 2 r 4 m 40 m 2 m 10 m 2 m 4 m 0 m 2 m 0 6 r 20 m 0 m 20 m 0 4 r 1 m 0 m 20 m
0 m 8 m 0 4 r 8 m 0 5 r 11 m 10 m 91 m 0 2 r 21 m 3 m 0 3 r 21 m 1 m 2 m 0 m 9 m 0 2 r 89 m 9 m 0 2 r a0 m 83 m 0 4 r 8 m 11 m
0 2 r 20 m 0 m 1 m 0 3 r 1 m 0 2 r 80 m 0 5 r 80 m 90 m 0 m 5 m 0 b r 8 m 0 3 r 9 m 90 m 0 2 r 88 m 0 m 5 m 0 3 r 4 m 0 2 r 90
m 0 3 r 4 m 21 m 2 m 9 m 1 m 0 2 r 11 m 20 m 4 m 0 m 40 m 0 m 20 m 0 m 9 m 0 3 r 80 m 0 3 r 11 m 0 m 3 m 0 m 2 m 0 m 8 m 0 3 r
20 m 0 m 80 m 0 m 20 m 4 m 0 m 88 m 41 m a0 m 0 6 r 80 m 20 m 0 2 r 4 m 0 5 r 40 m 2 m 0 4 r 4 m 0 4 r 20 m 0 2 r 5 m 88 m 9 m
0 3 r 80 m 0 m 4 m 0 3 r 4 m 0 2 r 20 m 0 5 r 10 m 0 m a0 m 0 3 r 21 m 0 m 21 m 20 m 10 m 0 m 11 m 0 m 21 m 0 m 21 m 0 m 4 m 0
2 r 20 m 8 m 0 m 10 m 0 m 41 m 88 m 0 m 10 m 0 m notbusy
02 wcmd 1 m 5b m 0 m \ 0x15b00 
82 m 0 2 r 8 m 88 m 0 m 10 m 4 m 88 m 0 m 90 m 41 m a0 m 0 m c0 m 4 m 84 m 9 m 84 m 0 4 r 8 m 0 m 3 m 20 m 4 m 0 m 80 m 0 2 r
4 m 0 m 84 m 0 5 r 1 m 3 m 20 m 0 m 20 m 0 m 40 m 21 m 4 m 20 m 4 m 0 m 4 m 0 m 84 m 0 2 r 20 m 0 m 20 2 r 0 2 r 21 m 40 m 80
m 90 m 80 m 20 m 0 7 r 84 m 0 m 1 m 0 3 r 20 m 0 m 21 m 0 3 r 20 m 0 m c0 m 0 m 20 m 0 4 r 40 m 0 3 r 11 m 0 4 r 8 m 4 m 0 m
85 m 0 2 r 4 m 0 2 r 84 m 0 m 10 m 0 3 r 82 m 0 m 1 m 0 3 r 82 m 21 m 0 m 9 m 0 m 4 m 20 m 0 m 90 m 0 m 4 m 11 m 4 m 20 m 0 2
r 10 m 21 m 0 6 r 2 m 0 2 r 8 m 0 m 20 m 82 m 11 m 2 m 0 a r 20 m 4 m 80 m 0 m 80 m 4 m 0 2 r 80 m a1 m 80 m 0 m 80 m 0 m 5 m
0 2 r 1 m 21 m 1 m 0 4 r 80 m 20 m 0 m 20 m 3 m 0 9 r 8 m 4 m 0 m 4 m 20 m 10 m 84 m 4 m 8 m 4 m 0 4 r 21 m 10 m 5 m 0 m 3 m 1
m 0 4 r 10 m 20 m 0 m c0 m 40 m 10 m 2 m 8 m 90 m a0 m 0 m 2 m 0 m 2 m 0 m 10 m 40 2 r 20 m 90 m 0 m 10 m 8 m 82 m notbusy
02 wcmd 1 m 5c m 0 m \ 0x15c00 
0 2 r a0 m 4 m 0 m 90 m 0 3 r 2 m 0 m 8 m 40 m 0 3 r 1 m c0 m 1 m 0 m 10 m a0 m 0 m 5 m 1 m 0 m 11 m 0 m 2 m 91 m 0 m 83 m c1
m 3 m 9 m 2 m 82 m 91 m 82 m 1 m 0 4 r 1 m 0 m 11 m 1 m 0 m 1 m c0 m 88 m 0 m 8 m 0 m 88 m 10 m 4 m 9 m 8 m 0 m 4 m 1 m 10 3 r
40 m 88 m 8 m 2 m 0 m 10 2 r 88 m c0 m 40 m 0 m 84 m 0 m 20 m 8 2 r a0 m 90 m 0 m 2 m 0 m 88 2 r 2 m 40 m 10 m 0 m 20 m 0 m 10
m 20 2 r c0 2 r 4 2 r 0 m c0 m 4 m 8 m a0 m 0 m 9 m 0 m c0 m 0 4 r 80 m 0 5 r 80 2 r 0 5 r 80 2 r 0 2 r 80 2 r 0 4 r 11 m 80 m
11 m 9 m 80 m 40 m 0 m 3 m 2 m 91 m 8 m 4 m 80 m 40 m 0 m 88 m 20 m 40 m 10 m 21 m 80 m 8 m 0 m 3 m a0 m 4 m 8 m a1 m 80 m 20
m 80 m 21 m 0 3 r 9 m 8 m 11 m 4 m 10 m 0 m 40 m 80 m 0 2 r 80 m 0 3 r 80 m 90 m 80 m 0 m 80 m 8 m 0 m 80 3 r 0 2 r 80 m 0 5 r
80 m 0 6 r a0 m 0 4 r 80 m 0 2 r 40 m 0 2 r 80 m 0 4 r c1 m 80 m 0 m 80 m 0 2 r 80 2 r 11 m 41 m 83 m 4 m 5 m 10 m 40 m 80 2 r
0 2 r 3 m 0 2 r 80 3 r 0 2 r 40 m notbusy
02 wcmd 1 m 5d m 0 m \ 0x15d00 
0 m 90 m 0 2 r 10 m 80 m 90 m 80 m 10 m 0 m 10 3 r 0 m c1 m 0 m 90 m 20 m 3 m 21 m 11 m 0 m 41 m 10 m 85 m 40 m 10 m 8 m 0 2 r
80 2 r 5 m 0 m 85 m 21 m 8 m 0 m 3 m 0 m 40 m 0 m 10 m 0 3 r 9 m 80 m 11 m 0 m 10 2 r 2 2 r 0 3 r 2 m 0 4 r 80 m 40 m c0 m 21
m 80 m 40 m 80 m 0 4 r 2 m 0 m 10 m 0 m 3 m 0 3 r 10 m 0 m 2 m 0 4 r 80 m 0 m 80 m 0 m 80 m 0 4 r 41 m 0 m 80 m 0 2 r 80 m 0 2
r 91 m 0 m c0 m 80 m 0 m 90 m 1 m 8 m 0 m 1 m 89 m 1 m 10 m 88 m 0 m 20 m 1 m 84 2 r 8 m 4 m 88 m 0 2 r 1 m 4 m a0 m 0 3 r 2 m
83 m 4 m 0 3 r c1 m 1 m 2 2 r 8 m 85 m 0 2 r c1 m 0 2 r 20 m 40 m 84 m 1 2 r c1 m 0 m 20 m 82 m c0 m 1 m 0 m 4 m 41 m 0 2 r 3
m 0 m 1 m 0 m 1 m 20 m 0 3 r 40 m 0 6 r 2 m 0 m 2 m 0 m 88 m 84 m 10 m 0 m 10 m 0 m 20 m 0 m 10 m 4 2 r 0 m 10 m 90 m 2 m 0 m
10 2 r 2 m 1 m 20 m 0 m a0 m 1 m 2 m 20 m 84 m 0 m 90 m 0 m 20 m 0 m 88 m 0 m 2 m 0 m 40 m 0 m c0 m 1 m a0 m 40 m 88 m 0 m 8 m
0 m 4 m 82 m 84 m c1 m c0 m 40 m c0 m 11 m 20 m 10 m a0 m 10 m a0 m a1 m 10 2 r 0 m 10 m 0 2 r 2 m 0 m notbusy
02 wcmd 1 m 5e m 0 m \ 0x15e00 
10 m 40 m 0 m 90 m 0 m 40 m 10 2 r 0 m 88 m 0 m 41 m 2 m 1 m 0 m 1 m 0 m 88 m 1 m 40 m 8 m 1 2 r 0 m 90 m 21 m 0 m 1 m 20 2 r
0 m 1 2 r 8 m 1 2 r 3 m 41 m 1 2 r 0 m 20 m 88 m 89 m 0 m 8 m 10 m 4 m 0 m 1 m 0 8 r 3 m 2 m 0 m 10 m 0 m 88 m 10 2 r 84 m 90
m 82 m 10 m 0 m 4 m 11 m c0 m 2 2 r 0 m 40 m 90 m 88 m c0 m 10 m 20 2 r 0 m 2 m 0 m 20 m a0 m 4 m 20 m 90 m 0 m 82 m 0 m 20 m
0 m 3 m a0 m 40 m 0 m 10 m 4 m 88 m c0 m 8 m 11 m 8 m 0 m 20 m 0 m 84 m c0 2 r 0 m 10 m 80 m c1 m 80 m 89 m 85 m 88 m 80 m 0 5
r 11 m 0 6 r 80 m 0 3 r 3 m 0 m 88 m 0 m 5 m 9 m 4 m 5 m 10 m 3 m 88 m 5 2 r 4 m 20 m 5 m 8 m 10 2 r 0 m 10 m 0 m 5 m 20 m 5 m
3 m 2 m a1 m 88 m 2 m 8 m 0 m 82 m a1 m 3 2 r 8 m 10 m 85 m 0 m 1 m 0 m 9 m 10 m 9 m 2 2 r 0 m 10 m 11 m 0 2 r 80 m 0 2 r 80 2
r 0 m 5 m 0 3 r 80 m 82 m 0 4 r 80 m 0 2 r 80 2 r 0 7 r 80 m 0 3 r 80 m 0 2 r 10 m 91 m 0 m 80 m 0 2 r 80 m 0 2 r 80 m 84 m 80
m 0 m 80 m 0 2 r 80 2 r 0 m 85 m 80 m 0 2 r 80 m 0 m 10 m 0 4 r notbusy
02 wcmd 1 m 5f m 0 m \ 0x15f00 
0 m 80 2 r 0 2 r 20 m 80 m 88 m 80 m 0 m 80 m 0 m 2 m 80 m 9 m 0 m 8 m 0 m 8 m 10 m a1 m 80 m 3 m 0 m 8 m 0 m 11 m 20 m 88 m
a1 m 21 m 0 m 10 m 21 m 9 m 10 2 r a0 m 5 m 8 m 20 m 0 m 3 m 0 2 r 2 m 0 m 21 m 0 m 80 m 0 m 8 m 0 m 1 m 9 m 0 m 2 m 0 m 4 m 0
m 10 m 21 m 0 3 r 40 m 80 m 0 4 r 9 m 0 m 2 m 80 m 0 3 r 41 m 0 m 8 m 11 m 10 m 0 m c0 m 0 4 r 5 m 0 5 r 20 m 0 m 90 m 0 m 80
m 0 5 r 2 m 0 4 r 80 m 4 m 80 2 r 0 m 20 m 80 m 0 m 90 m 8 m a0 m 0 m 20 m 8 2 r 0 m 88 m 0 m 90 m 20 m 88 m 84 m a0 m 0 m 88
m 0 m a0 m a1 m 10 m 88 m 82 m 0 m 10 m c0 m 0 m a0 m 1 m 0 m 5 m 0 m 5 m c0 m 0 2 r 1 m 0 m 10 m 0 m c1 2 r 90 m 0 m 41 m 1 m
0 3 r 40 m 20 m 1 m c0 m 0 m 1 m 0 2 r 85 m 0 m 41 m 0 m 84 m 0 m 1 m 0 m 1 m 0 m 88 m 0 6 r 88 m 0 m 88 m 91 m 4 m 88 m 90 m
0 m 4 m 0 m 10 2 r 40 m 84 m 2 m 0 m 11 m 0 m 91 m 90 m 89 m 88 m 4 m 0 m 84 m 0 m 2 m 20 m c0 m 8 m 40 m 0 4 r 82 m 0 m 40 2
r 0 m 4 m 0 m 10 m 11 m 20 2 r 40 m 0 m c0 m 0 m 4 m c0 2 r 83 m 8 m a0 m 0 3 r d0 m 0 2 r 60 m 0 m notbusy
20 wcmd 1 m 60 m 0 m notbusy \ 0x16000
02 wcmd 1 m 60 m 0 m \ 0x16000 
0 16 r 82 m 0 7 r 42 m 0 2 r 41 m 0 2 r b m 0 m 60 m 0 7 r 84 m 0 7 r 81 m 0 6 r d0 m 0 8 r b m 0 m 42 m 0 4 r c8 m b m 0 7 r
b m 0 2 r 82 m 0 4 r b m 0 3 r 60 m 0 2 r c8 m b m 0 7 r b m 0 m 41 m 0 5 r 9 m 0 m 48 m 42 m ff m fd m ff m f4 m 0 m 2 m 0 2
r f6 m f3 m ff m f m b4 4 r ff m 7c m ff m 60 m 0 4 r c3 2 r 3c 2 r cc 4 r c3 2 r 3c 2 r cc 4 r f 2 r ff m 0 m c3 m 3c m c3 m
3c m f m f0 m f m f0 m c3 m 3c m c3 m 3c m 0 5 r 9 m 0 c r f0 m e4 m f0 4 r e4 m f0 m e6 m 66 m 26 m 66 m ff m 0 m ff m 0 m 7f
m ff m 10 m 0 m ff 2 r ef m ff 3 r 0 2 r ff 2 r 0 2 r 3c 4 r ff m bf m 40 m 0 m 3e m 3c m 38 m 3c 5 r 0 8 r ff m 0 m ff m 0 m
notbusy
02 wcmd 1 m 61 m 0 m \ 0x16100 
0 4 r ff m f3 m ff m f m b4 4 r 7c 2 r 60 2 r 0 m 20 m 0 2 r c3 2 r 3c 2 r cc 4 r c3 2 r 3c 2 r cc 4 r f0 2 r ff m 0 m c3 m 3c
m c3 m 3c m f m f0 m f m f0 m c3 m 3c m c3 m 3c m 0 4 r 3 m 0 d r f0 8 r 66 4 r ff m 20 m df m 0 m ff 2 r 0 2 r 10 m 0 3 r fb
m ff m 20 m 0 m ef m ff m 20 m 0 m 3c 4 r ff 2 r 0 2 r 3c 4 r 7c m 3c m 1c m 3c m 0 82 r 43 m 10 m 20 m 0 2 r 88 m 11 m 6 m
notbusy
02 wcmd 1 m 62 m 0 m \ 0x16200 
0 m 40 m 0 a r c m 6f m fc m 6f m 0 4 r 3c m 7e m 3c m 7e m f m f0 m f m f0 m 69 4 r 0 m ff 2 r 0 m f m f0 m f m f0 m ff 2 r
33 2 r f m f0 m f m f0 m 33 4 r f 2 r f0 2 r ff m 66 m f9 2 r 9f 4 r 0 a r 3c 2 r 34 m 3d m 66 2 r 6c m 66 m 0 m ff m 2 m ff m
0 m 2 m ff 2 r 0 m 20 m ff m bf m 38 m 3c m 3e m 3c m 0 m ff m 2 m fe m 0 2 r ff 2 r 0 m f3 m 0 m ff 2 r fd m ff 5 r fe m 0 m
ff m 0 m ff m 0 8 r 24 m 64 m 0 2 r c 4 r 0 m 20 m 0 2 r c m 60 m fc m 60 m 0 3 r 20 m 0 m 66 m 0 m 66 m f m f0 m f m f0 m 69
4 r 0 m ff 2 r 0 m f m f0 m f m f0 m 0 2 r 33 2 r f m f0 m f m f0 m 33 4 r f 2 r f0 2 r ff m 66 m f9 2 r ff 4 r 0 a r 3c 4 r
66 4 r 0 m ff m 0 m fd m 0 2 r ff m fd m 0 2 r ff 2 r 3c 4 r 0 m ff m 0 m ff m 0 m 4 m ff m df m 0 m ff m 0 m ff m 0 3 r 2 m 0
3 r 2 m 0 m ff m 4 m df m 0 4 r notbusy
02 wcmd 1 m 63 m 0 m \ 0x16300 
0 5 r 61 m 0 m 7 m 0 m d m 0 m 1 m 0 5 r 10 m 0 4 r 40 m 0 2 r 10 m 0 2 r 40 m 61 m 80 m 6 m 0 m 2d m 10 m 2 m 40 m 61 m 80 m
6 m 0 m 2d m 10 m 2 m 48 m 61 m 84 m 26 m 0 m 2d m 10 m 2 m 40 m 61 m 80 m 6 m 0 m 2d m 0 m 2 m 0 m 61 m 0 m 6 m 0 m d m 0 m 1
m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 5 r 8 m 0 5 r 60 m 0 m f m 0 m c m 0 3 r 61 m 0 m e m 0 m d m 0 5 r 8 m 0 4 r 80 m 61 m 0 m e m
c0 m 9 m 0 5 r 8 m 0 9 r 90 m 0 m 5 m 0 6 r 4 m 0 11 r f m 3f m cf m ff m f0 m fc m ff 2 r 0 m 40 m 0 2 r ff 4 r 0 4 r 80 m 0
7 r ff m af m 41 m ff m 0 a r ff m 0 m ff m 0 m ff 2 r f7 m ff m 0 c r 3c 2 r 0 3 r 54 m ff 2 r 0 10 r ff 2 r 0 a r notbusy
02 wcmd 1 m 64 m 0 m \ 0x16400 
0 20 r fb 4 r f0 m fc m ff 2 r 14 m 40 m 14 m 0 m 7f m ff m 7f m 3f m 0 3 r c m 0 5 r 1 m 0 2 r ff m af m eb m ff m 0 7 r 40 m
0 2 r ef m 4 m ff m 0 3 r 20 m 0 d r 3c 2 r 0 3 r 54 m 0 m 54 m 0 10 r ff 2 r 0 16 r eb m ef m 69 m ef m 0 18 r 7f m 2a m 7f m
2a m af 2 r 30 m 3f m eb 2 r c0 m fc m 7f 2 r eb m aa m 7f m ff 3 r 0 4 r ff 2 r 3d m 5 m ba m aa m ff m aa m 0 2 r f 4 r ff m
ef m ff 2 r 0 c r f0 2 r 0 1e r notbusy
02 wcmd 1 m 65 m 0 m \ 0x16500 
0 10 r ff m ef m 7d m ef m 0 15 r 2 m 0 2 r 57 m 2 m 57 m 2 m a0 2 r 30 m 3f m eb 2 r c0 m fc m 7f 2 r ff m be m ff 4 r 0 2 r
ff m 0 m 3d m 5 m 3d m 5 m 30 m 0 m ff m 0 3 r 1e m f 3 r 0 m 20 m 0 e r f0 2 r 0 2a r 90 m 0 2 r 4 m 0 m 2 m 0 m 8 m 0 m 3 m
8 m 20 m 0 2 r 8 m 80 m 1 m 0 2 r 10 m 1 m 0 2 r 3 m 0 2 r 40 m 0 m 88 m 80 m 2 m 82 m 0 m 10 m 20 m 85 m 0 m 80 m c0 m 5 m 0
m 2 m 88 m 2 m 0 2 r 84 m 10 m 0 2 r c0 m 11 m 0 m 2 m 0 8 r 20 m 0 2 r 2 m 0 2 r 20 m 0 m 2 m 0 d r 20 m 2 m 0 3 r 20 m 4 m 0
2 r 3 m 4 m 0 m 4 m 0 9 r 20 m 2 m 88 m 0 5 r notbusy
02 wcmd 1 m 66 m 0 m \ 0x16600 
89 m 80 m 0 m 80 m 1 m 0 2 r 80 m 0 d r 3 m 0 4 r 80 m 1 m 0 m 2 m 90 m 2 2 r 0 2 r 1 m 2 m 0 4 r 90 m 0 m 90 m 0 m 10 m 0 m 2
m 5 m 1 m 80 m 4 m 0 m 4 m 0 3 r 1 m 0 5 r 1 m 0 2 r 41 m 0 2 r 1 m 0 6 r 21 m 0 4 r 3 m 0 b r 84 m 0 8 r 40 m 0 2 r 1 m 80 m
0 3 r 80 m 0 m 80 m 0 9 r 80 m 0 7 r 8 m 40 m 0 m 20 m 8 m 0 2 r 10 m 0 8 r 1 m 0 b r 1 m 0 2 r 40 m 0 2 r 84 m 0 m 4 m 0 m 4
m 80 m 0 3 r 4 m 0 m 11 m 0 4 r 20 m 4 m 20 m 4 m 9 m 82 m 0 3 r 9 m 0 3 r 8 m 0 2 r 40 m 0 3 r 1 m 20 m 0 9 r 2 m 0 3 r 10 m
0 3 r 9 m 88 m 0 4 r 2 m 0 7 r 11 m 0 3 r 80 m 0 m 2 m 0 2 r 2 m 0 d r notbusy
02 wcmd 1 m 67 m 0 m \ 0x16700 
0 d r 80 m 0 6 r 40 m 0 m 20 m 0 4 r 90 m 0 m 82 m 0 2 r 40 m 2 m 0 m 4 m 0 2 r 5 m 90 m 80 m 0 m 80 m 10 m 0 m 90 m 0 3 r 4 m
0 3 r 84 m 80 m 41 m 80 m 1 m a0 m 5 m 2 m c0 m 0 4 r 5 m a0 m 0 m c0 m 80 m 0 2 r 4 2 r 41 m 0 m 82 m 0 m 8 m 0 9 r 1 m 0 2 r
40 m 0 8 r 2 m 0 9 r 4 m 0 m 5 m 0 2 r 80 m 8 m 0 19 r 2 m 0 m 84 m 0 3 r 8 m 88 m 5 m 0 m 9 m 0 m 41 m c0 m 41 m 0 m 4 2 r 20
m 88 m 0 m 5 m 8 m 0 m 80 m 0 m a0 m 1 m 83 m 0 m 41 m a0 m 21 m 0 m 10 m 0 m 21 m 0 m 5 m 0 m 3 m 88 m 40 m 8 m 5 m 85 m 4 m
10 m 21 m a0 m 0 m 10 m 8 m 90 m 9 m 2 m 3 m 0 m 40 m 0 m 2 m 21 2 r 88 m 3 m 0 3 r 4 m 84 m 0 6 r 3 m 0 m 40 m 0 m 2 m 84 m
40 m 0 2 r 90 m 0 m 90 m 0 2 r 80 m 0 m 3 m 5 m 0 4 r 40 m 0 m 82 m 0 m 2 m 0 m 4 m 0 m 80 m 0 m 20 m 1 m 85 m 0 m 41 m
notbusy
02 wcmd 1 m 68 m 0 m \ 0x16800 
0 m 20 m 0 4 r 4 m 0 4 r 3 m 0 2 r 2 m 41 m 40 m 2 m 0 7 r 82 m 11 m 88 m 2 m 0 2 r a0 m 0 m a0 2 r a1 m 40 m 0 m 84 m a0 m 41
m 20 m 41 m 21 m 4 m 20 m 40 m 0 m 40 m a0 m 10 m 91 m 21 m 0 m 3 m 84 m 3 m 84 m 3 m 2 m c1 m a0 m 20 m 5 m 40 m a0 m 41 m 40
m 41 m 1 m 9 m 90 m 0 m 4 m 0 m 83 m 0 m 2 m 4 m a0 m 0 m 82 m 0 5 r 8 m 0 9 r 40 m 5 m 0 2 r a0 m 0 2 r 8 m a0 m 0 m 20 m 0 m
c0 m a0 m 82 m 0 2 r 3 m 0 2 r 3 m 5 m 0 m 8 m 84 m 40 m 20 m 3 m 89 m 4 m 20 m 0 3 r 1 m 0 m 84 m 0 2 r c0 m 0 m 3 m 0 2 r 82
m 0 2 r 80 m 90 m 88 m 0 2 r a0 m 0 2 r 3 m 0 m c0 m 0 2 r 2 m 0 m 41 m 0 m a1 m 10 m 0 m 1 m 80 m 40 m 0 m 41 m 82 m 5 m 80 m
5 m 0 m 11 m 0 m 4 m 10 m 82 m 10 m 40 m 0 m 10 m 41 m 0 m 10 m 9 m 0 m 20 m 11 m 83 m 40 2 r 0 2 r 2 m 0 5 r 41 m 0 8 r 20 m
0 m 8 m 0 3 r 4 m 9 m 0 3 r 9 m 2 m 0 5 r 85 m 20 m 82 m 4 m c1 m 20 m 82 m 20 m 0 2 r 4 m c1 m 0 2 r 20 m 0 3 r 5 m 0 m 88 m
0 m 88 m 0 m c0 m 0 3 r notbusy
02 wcmd 1 m 69 m 0 m \ 0x16900 
0 6 r 1 m 0 3 r 91 m 0 m 82 m 0 m 8 m 0 m a0 m 0 3 r 40 m 2 m 0 2 r 8 m 0 m 8 m 0 4 r 1 m 8 m 0 m 9 m 2 m 0 m c0 m 4 m 20 m 0
2 r 4 m 21 m 84 m 20 m 84 m 0 m 4 m 8 m 80 m a1 m 20 m 82 m 11 m 0 m 21 m 0 3 r 10 m 0 m 80 m 0 m 20 m 90 m 40 m 2 m 0 m a1 m
0 m 90 m 2 m 0 m 20 m 0 m 40 m 0 3 r 20 m 0 m 10 m 0 5 r 8 m 0 4 r 2 m 0 3 r a0 m 0 4 r 20 m 3 m 0 m 85 m 20 m 91 m 8 m 1 m 0
m 82 m 80 m 4 m 0 2 r 80 m 0 m 41 m 84 m c0 m 0 f r 20 m 0 3 r 20 m 0 3 r 8 m 0 5 r 80 m 1 m 0 9 r 8 m 0 2 r 40 2 r 0 m 8 m 4
m 20 m 2 m 0 m 5 m 3 m 2 2 r 84 m 5 m 1 m 4 m 2 m 41 m 10 m 40 m a0 m 4 m c0 m 0 m 40 m 0 m c0 m 80 m 0 m 9 m 20 m 2 m 82 m 40
m 0 m 40 m 82 m 0 m 82 m 0 2 r 9 m 0 5 r 2 m 0 m 20 m 0 m 8 m 0 5 r 4 m 0 8 r 8 m 40 m 0 m 21 m 8 m 0 m 20 m 0 m 4 m 0 m a1 m
3 m 8 m 20 m 84 m 4 m 0 m 20 m 0 m 8 m 41 m 2 m 0 3 r 11 m notbusy
02 wcmd 1 m 6a m 0 m \ 0x16a00 
40 m 9 m a0 m 0 3 r 1 m 41 m 1 m 0 m 1 m 80 m 1 m 2 m 0 2 r 82 m 0 8 r 2 m 21 m 0 m 20 m 0 m 82 m 80 m 2 m 84 m 8 m 0 2 r a0 m
3 m 0 m 21 m 0 m a0 m 5 m 0 2 r 84 m a0 m 40 m 0 2 r a0 m 8 m 4 2 r 84 m 40 m a0 m 40 m 4 m 9 m 82 m 0 m c0 m 0 m 8 m 3 m 40 m
82 m 11 m 3 m 20 m 40 m a0 m 8 m 88 m 9 m 90 m 8 m 84 m 20 m 90 m 3 m 0 2 r 2 m 5 m a1 m 0 m a0 m 11 m 0 m 8 m 90 m 21 m 0 4 r
90 m 5 m 4 m 0 m 4 m 0 2 r 20 m 0 m 11 m a0 m 80 m 2 m 80 m a0 m 20 m 0 m 10 m 1 m 0 m 89 m 11 m a0 m 0 m a0 m c0 m 85 m 5 m
88 m 40 m 4 m 9 m 0 2 r a0 m 0 2 r 4 m 0 m 4 m a0 m 4 m 20 m 4 m 0 m 20 m 0 8 r 90 m 0 m 1 m a0 m 0 m 80 m 0 2 r 4 m 82 m 8 m
0 7 r 21 m 0 4 r 4 m 8 2 r 88 m 8 m 3 m c0 m 21 m 3 m 88 m 84 m 8 m 40 m 8 m a0 m 0 m c0 m 10 m c0 m 0 m 40 m 3 m 0 m 41 m 3 m
21 m 0 m 3 m 8 m 10 m 40 m 10 m 0 m 90 m 0 2 r 8 m 0 2 r 21 m 8 m a1 m 0 m 4 m 0 10 r 83 m 0 m 4 m 80 m 4 m 0 m 20 m 0 m c0 m
20 m 82 m 41 m 0 m 20 2 r 4 m 0 m 4 m 40 m 8 m notbusy
02 wcmd 1 m 6b m 0 m \ 0x16b00 
88 m 5 m 88 m 0 m c0 m 20 m 0 m 20 m 8 m 41 m 40 m 20 m 0 4 r 20 m 9 m 88 m 0 4 r 3 m 0 m 9 m 90 m 0 m 40 m 5 m 0 m 8 m 20 m
41 m c0 m 0 m 3 m 0 2 r a0 m 20 m 0 2 r 8 m 0 6 r a0 m 82 m 80 m 20 m 80 m 0 m 40 m 0 m 8 m 20 m 9 m 10 m 0 m 2 m 11 m 10 m 0
m 82 m 2 m 0 m 91 m 0 m 9 m 10 3 r 5 m c0 m 80 m 0 2 r 10 m 40 m 3 m 20 m 0 m 91 m 0 3 r 82 m 20 m 0 m 82 m 10 m 90 m 0 3 r 88
m 0 2 r 9 m 0 3 r 9 m 0 2 r 4 m 20 m c0 m 88 m 20 m 80 m 0 m 80 m 0 2 r 1 m 4 m 0 2 r 1 m 0 m 1 m 0 m 1 m 80 m 0 6 r 1 m 8 m 1
m 5 m 0 m 10 m 1 m 0 2 r 10 m 0 m 80 m 0 m 10 m 0 9 r 80 m 0 3 r 80 m 0 m 41 m 0 2 r 1 3 r 10 m 0 3 r 10 m a0 m 0 m 8 3 r 10 m
c0 m 9 m 2 m 20 m 2 m 0 m c0 m 88 m 4 m a1 m 2 m 0 4 r 20 m 8 m 4 2 r 0 m 4 m 90 m 20 m 4 m 82 m 0 m 9 m 1 m 89 m 40 m 88 m 0
m 91 m 0 2 r 10 m 1 m 4 m 0 15 r 40 m 20 m c1 m 89 m 11 m 88 m 10 2 r c0 m 41 m 1 m 9 m 88 m 3 m a1 m 90 m notbusy
02 wcmd 1 m 6c m 0 m \ 0x16c00 
0 m c1 m 0 m 4 m 0 m 8 m 0 m 82 m 8 2 r 88 2 r 0 m 4 2 r 40 m 10 m 2 m 0 m 82 m 0 m c0 m a0 m 10 m 9 m c0 m 0 m 20 m 0 m 8 m
84 m 10 m 0 m 1 m 0 m 1 m 85 m 1 m 0 3 r 40 m 21 2 r 0 m 10 m 0 m 20 m 0 m 80 m 10 m 80 m 0 m 80 m 0 2 r 89 m 80 2 r 0 4 r 80
m 20 m 0 m 21 m 0 4 r 80 2 r 0 2 r 80 m 88 m 0 3 r 2 m 41 m 3 m 21 m 80 m 89 m 0 m 2 m 0 m 3 m 90 m 20 m 80 m 0 2 r 40 m 0 12
r 80 m 20 m 88 m 8 m c0 m 8 m 80 m 21 m 80 m 90 m 3 m a0 m 11 m 8 m 11 m 10 m 0 m 85 m 0 m 80 m 4 m 11 m 0 2 r 8 m 0 4 r 80 2
r 0 m 82 m 80 m 0 m 80 m 9 m 0 3 r 89 m 80 m 0 m 80 m 0 m 80 m 0 3 r 10 m 11 m 10 m c1 m 8 m 0 m 5 m 0 2 r 20 m 0 m 11 m 0 m
11 m 4 m 10 m 0 m 8 m 41 m 80 2 r 11 m 0 4 r 82 m 80 m 9 m 0 m 80 2 r 0 2 r 9 m 0 2 r 80 m 0 m c0 m 0 m 11 m 3 m 85 m 5 m c1 2
r 80 m 0 2 r 20 m 0 3 r 84 m 90 m 0 m 5 m 0 m 40 m 0 m a1 m 83 m 0 3 r 80 m 0 e r 20 m 0 m 41 m 3 m 91 m 8 m 82 m 2 m 82 m 11
m 84 m 9 m notbusy
02 wcmd 1 m 6d m 0 m \ 0x16d00 
5 m 85 m 11 m 10 m 80 m 0 2 r 41 m 0 m 8 m 0 m 80 m 0 3 r 4 m 80 3 r 0 m 80 m 2 m 0 m 3 m 80 m 5 m 0 2 r 80 m 0 m 80 m 2 m 0 m
80 2 r 0 m 41 m 0 m 10 m 0 m 5 m 9 m 11 m 40 m 0 2 r 1 m 0 5 r 3 m 0 m c0 m 1 m a0 m 10 m 2 m 0 4 r 40 m 2 m 89 m 0 m 82 m a0
m 0 m 88 m 0 m 90 m 0 m 4 m 0 m a0 m 2 2 r 0 m a0 m 83 m 9 m 89 m 4 m c0 m 4 m 0 m 20 m 84 m 82 m 4 m 9 m 82 m c0 m 0 m 2 m 0
m c1 m 91 m 0 3 r 4 m 0 e r 20 2 r 90 m 1 m 10 m 91 m 82 m 10 m 8 m 3 m 10 m 0 m 85 m 8 m 90 m 10 m 4 m 0 m 90 m 40 m a0 m 10
m 40 m 4 m 8 m 0 m 4 m 0 m 8 m 40 m 82 m 0 m 2 m 0 m c0 m 1 m 40 m c0 m 10 m a0 m 8 m 0 m 20 m 0 m c0 m 40 m 4 m 0 2 r a0 m 0
2 r 1 m 0 2 r 40 m 0 m 1 m 0 2 r a1 m 1 3 r 8 m a0 m 0 m 41 m 0 m 88 m 4 m 10 m 40 m 2 m 0 m 82 m 90 m 82 m 2 m c0 m 0 m 8 m 0
m c1 m 0 m 10 m 4 m a0 m 0 m 8 m 0 m 40 m 4 m 8 m 83 m 20 m 2 m 1 m 0 2 r 3 m 0 m 10 m 0 3 r 1 5 r 0 13 r 8 m 20 m 0 m 10 m 0
m 2 m 3 m 10 m notbusy
02 wcmd 1 m 6e m 0 m \ 0x16e00 
10 2 r 0 m 8 m 0 m 5 m a0 m 91 m 1 m 0 3 r 84 m 0 m 1 m 0 m 4 2 r 0 m 4 m 0 m 4 m 3 m 10 m 2 m 4 2 r a0 m 0 m 2 m 41 m 4 m c0
m 4 m 0 m 8 m 0 m 40 m 10 m c0 m 0 7 r 1 m 0 m 10 m 20 m 41 m 85 m 8 m 40 m 8 m 80 m 2 m 0 m 2 m 0 m 8 m 0 m 82 m 80 m 0 3 r
80 m 0 m 80 2 r 0 m 8 m 0 m 3 m 0 m 40 m 4 m 88 m 0 3 r 10 m 80 m 2 m 88 m 8 m 0 m 10 m 21 m 0 m 8 m 0 m 80 m 9 m 0 m 40 2 r
10 m 5 m 20 m 4 m 2 m 0 10 r 4 m 0 m 80 m 20 m 11 m a1 m 2 2 r 11 m 9 m 80 m 84 m 21 m 82 m 11 m 5 2 r 10 m 2 m 0 m 20 m 0 m 3
m 0 m 2 m 0 4 r 80 m 0 2 r 82 m 80 m 0 m 80 m 0 3 r 80 m 2 m 80 m 0 3 r 80 m 0 m 80 m 0 m 80 m 0 m 10 m 0 m 4 m 0 m 11 m 0 m
20 m 9 m 0 m 8 m 0 m 3 m 0 2 r 9 m 80 m 85 m 0 m 10 m 0 m 80 2 r 40 m 80 m 0 2 r 4 m 0 m 80 m 0 4 r 80 3 r 0 m 80 m 0 m c1 m
80 m 4 m 89 m 90 m 0 m 20 m 5 m 84 m 4 m 40 m 20 m 3 m 0 m 83 m 0 m 3 m 21 m 8 m 4 m 21 m c1 m 5 m 10 m 0 f r 5 m 0 2 r 8 m 91
m 8 m 9 m notbusy
02 wcmd 1 m 6f m 0 m \ 0x16f00 
a0 m 0 m 8 m 11 m 88 m 84 m a1 m 84 m 11 m 0 m 2 m 8 m 80 m 11 m 20 m 21 m 80 m 0 m 80 m 0 4 r 82 m 0 m 80 2 r 0 2 r 2 m 0 m
89 m 0 4 r 80 m 2 m 0 m 10 m 80 3 r 0 m 10 m 21 m 9 m 21 m 11 m 0 m 40 2 r 0 m 4 m 1 m 0 5 r 10 m c0 m 88 m 20 m 90 m 82 m 8 m
0 m c0 m 0 m 4 m 3 m 88 m 90 2 r 0 m 2 m 0 m 82 m a0 m 8 m 88 m 8 m 0 m 41 m c0 m 90 m a0 m 2 m c0 m 41 m 0 m 41 m 0 m 91 m 4
m 8 m 0 m 9 m 0 2 r 1 m 0 m 82 m 1 m c0 m 1 2 r 0 f r 1 m 0 2 r 5 m 11 m 3 m 88 m 84 m 2 m 3 m 0 m 10 m 2 m 4 m 8 m 90 m a0 m
41 m 1 m 2 m 0 m 90 m 40 m 84 m 82 m a0 m 0 m 82 m 0 m 88 m 4 m 82 m 84 m 2 m 0 m 2 m 1 m 40 m 20 m 10 m a0 m 40 m 0 m 8 m 0 m
c0 m 10 m 82 m 40 m 4 m 0 2 r 5 m 0 f r 81 m 0 2 r b m 0 m 60 m 0 5 r b m 0 e r d0 m 0 2 r 41 m a m 0 c r b m 0 2 r 41 m 0 e r
7 m 0 3 r notbusy
20 wcmd 1 m 70 m 0 m notbusy \ 0x17000
02 wcmd 1 m 70 m 0 m \ 0x17000 
0 3 r d0 m b m 0 m 42 m 0 4 r d0 m b m 0 m 60 m 0 4 r d0 m 43 m 0 7 r b m 0 6 r c8 m b m 0 7 r 9 m 0 6 r d0 m 0 3 r 81 m 0 8 r
ba m fa m ff 6 r 0 m ff m f0 2 r 82 m be m f3 2 r ff 2 r 3f m 3c m a8 m aa m ff 6 r bc m ff 3 r f7 m fc m f7 m 3c m 0 1e r aa
4 r 0 m 8 m ff 2 r 20 m ef m 0 m ff m aa 2 r 2a m ea m f0 4 r 0 4 r d0 m f0 m f8 m f0 m 20 m ff m 0 m ff m 0 m ff m 8 m fb m 0
m 10 m ff m fb m 7f m f4 m f0 m 2f m 99 m 66 m 69 2 r 0 10 r ba 2 r ff 2 r fc m ff m fe m ff m 3c 2 r aa 2 r 82 m be m 30 2 r
ff 2 r 3f m ff m 80 m aa m ff 2 r be 3 r fe m bc m ff m bc m ff m f7 m ff m f7 m 3f m 0 11 r 2 m 0 8 r notbusy
02 wcmd 1 m 71 m 0 m \ 0x17100 
0 4 r aa 3 r b2 m 0 2 r ff m f7 m 0 m ff m 0 m ff m aa 4 r be m ff 3 r 0 4 r f0 4 r 0 m df m 0 m ff m 0 m ff m 0 m ff m 0 2 r
ff 2 r 4f m f7 m f2 m f m 66 m 99 m 69 2 r 0 10 r ff 3 r 3d m ff 4 r 17 2 r ff m c3 m 55 m ff m 55 m ff m d7 2 r ff 2 r c0 m
a0 m c0 m 0 m 7f m 3f m 7d m 3c m ff 3 r 7f m 0 m 20 m 0 2 r 70 m 50 3 r 0 4 r fc m c m d7 2 r 0 12 r 4f m f 4 r 1f m f m b m
ff 2 r 0 2 r 7c m 2c m 3c 2 r fc 2 r ff m 0 m ff 2 r 3d m 5 m 3c m 2d m 3c 2 r ff m 0 m ff m 4 m 17 m 55 5 r 4d m 55 m c0 m cf
m 9f 2 r d7 m eb m d7 m e9 m 0 10 r ff 3 r 5 m ff 3 r 7f m 17 2 r 3c m 0 m 55 m 0 m 55 m 0 m d7 2 r ff 2 r 0 4 r 7f m 3f m 7d
m 3c m f0 3 r 70 m 0 4 r 70 m 50 3 r 0 4 r fc m c m 41 2 r 0 a r notbusy
02 wcmd 1 m 72 m 0 m \ 0x17200 
0 8 r e m f 7 r ef m ff m 4 m 0 m 3c 4 r fc 2 r ff m 0 m 3d m 5 m 3d m 5 m 3c 4 r ff m 0 m fb m 0 m 55 8 r cf m c0 m 90 2 r d6
m eb m d7 m eb m 0 9 r 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 26 m 0 m d m 0 2 r a0 m 0 m a m 8 m 0 m 90 m 0 m a0 m 0 m 61 m 0 m
6 m 0 m d m 0 3 r 61 m 0 m 5 m 0 m d m 0 2 r 80 m 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m e m 0 m d m 0 m 5 m 0 13 r 61 m 0 m 9 m
0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 2 r 5 m 61 m 34 m b m 5 m d m 0 m a0 m 0 3 r 8 m 0 5 r 61 m 0 m f m 0 m d m 0 4 r 20 m 0
2 r 90 m 0 3 r 61 m 0 m 5 m 0 m 1 m 0 2 r ff 2 r f0 m ff m 0 m 28 m 0 1a r ff m 55 m 1e 2 r ff 2 r f5 m ff m ae m 2c m ae m 4
m ff 2 r 7d 2 r 55 4 r 0 m 80 m 0 8 r notbusy
02 wcmd 1 m 73 m 0 m \ 0x17300 
0 c r 4f m f m e m f m f0 m e0 m f0 m f4 m ff 2 r 0 3 r ff m 0 m ff 2 r 0 m ff m 0 1d r df m 10 m ff m 0 m ff 2 r f7 m ff 5 r
0 m 68 m 0 m 40 m 0 5 r 40 m 0 f r ff m 30 m ff m aa m 0 m 1e 2 r ff 2 r f5 m ff m 2c 2 r 4 2 r ff 7 r 3f m 0 m 8f m 0 14 r f
4 r f0 4 r fe m ff m 4 m 0 2 r ff m 20 m f7 m ff m 0 m ff m 0 1d r ff m 0 m ff m 0 3 r 20 m 0 2 r 20 m 4 m 24 m aa m ff m a0 m
f5 m 0 4 r ff 2 r f3 2 r 0 14 r f m ff m 3c m aa m cb 2 r c3 m 0 5 r ff 2 r 7d m 3c m f8 m ff 3 r 0 2 r notbusy
02 wcmd 1 m 74 m 0 m \ 0x17400 
0 10 r 2d m f 3 r ff 2 r ef m ff 2 r fe m 1 m 0 m ff 2 r ef m ff m af 2 r 5 2 r 0 1c r 30 m 0 m f0 m 0 m 3c m bc m 3c 2 r 0 2
r 4 2 r 0 m 55 m a0 m f5 m 0 4 r f7 4 r 0 15 r f0 m 3c m aa m 8 2 r c3 m 0 5 r 7d m 3c m 7d m 3c m f8 m ff 3 r 0 12 r f 4 r 0
2 r 20 m 0 m ff 2 r 0 4 r 20 m 0 m aa 2 r 0 1e r 30 m 0 m f0 m 0 m 3c m 1c m 3c 2 r 0 2 r d6 m ce m 10 m 0 m e m 96 m 20 m b6
m 0 2 r c0 m 2a m 47 m 2b m 40 m eb m 5f m df m b m 22 m fc m 21 m 40 m b m 12 m 10 m 2 m 0 m 2 m c m 80 m 58 m 1 m 48 m 6 m 8
2 r 2 m 20 m 28 m 10 m 4 m 1 m 11 m 0 m a1 m d m 18 m 40 m 81 m 82 m 88 m notbusy
02 wcmd 1 m 75 m 0 m \ 0x17500 
5 m 1 m 0 13 r 1f m 17 m 18 m 44 m 0 4 r 8 m 0 m 6 m 0 2c r 10 m 0 4 r 20 m 40 m 10 m 0 2 r 40 m 8 m 0 4 r 4 m 0 d r 20 m 4 m
40 m 41 m 0 3 r 4 m 0 4 r 20 m 0 m 84 m 0 m 40 m 8 m 0 m 4 m 0 m 40 m 0 m 41 m 0 m 4 m 0 m 11 m 40 m 0 m 40 m 0 9 r 4 m 80 m 0
5 r 11 m 0 2 r 20 m 5 m 0 7 r 80 m 0 8 r 4 m 0 m 4 2 r 0 5 r 80 m 0 3 r 80 m 20 m 0 3 r 84 m 0 5 r 1 m 0 m 1 m 0 3 r 4 m 0 m
40 m 0 4 r 1 m 0 4 r 40 m 0 m 5 m 0 5 r 5 m 0 d r 9 m 0 4 r c0 m 0 3 r 90 m 0 2 r 41 m 0 5 r notbusy
02 wcmd 1 m 76 m 0 m \ 0x17600 
0 m 1 m 0 m 4 m 0 7 r 90 m 0 3 r 3 m 10 m 0 4 r 4 m 0 11 r 10 m 0 b r 1 m 0 5 r 2 m 0 3 r 2 m 0 a r 4 m 0 m 4 m 0 7 r 3 m 0 2
r 4 m 1 m 2 m 10 m 0 6 r 3 m 0 3 r 21 m 0 3 r 3 m 8 m 0 2 r 3 m 0 m 10 m 8 m 0 7 r 40 m 0 m 2 m 90 m 0 m 10 m 0 m 20 m 0 m a1
m 0 6 r 1 m 0 7 r 40 m 0 6 r 11 m 0 7 r 20 m 0 3 r 4 m 0 5 r 10 m 0 3 r 5 m 0 m 80 m 0 5 r 90 m 0 3 r 88 m 0 m 80 m 0 m 80 m 0
m 40 m 0 2 r 8 m 80 m 0 12 r 8 m 0 3 r 8 m 1 m 0 4 r 10 m 0 m 40 m 82 m 0 7 r 4 m 80 m 0 5 r 80 m 0 2 r 8 m 0 3 r 90 m 82 m 0
m 80 m 41 m 0 m 85 m 40 m 82 m notbusy
02 wcmd 1 m 77 m 0 m \ 0x17700 
0 m 2 m 0 3 r 4 m 0 m 8 2 r 84 m 0 m 8 m 0 4 r c0 m 0 4 r 84 m 0 4 r 2 m 8 m 0 7 r 8 m 0 3 r 82 m 0 m 9 2 r 0 2 r 4 m 0 m 20 m
0 5 r 5 m 0 m 90 m 0 m 4 m 0 m 4 m 0 m 10 m 0 m 1 m 0 2 r 80 m 2 m 0 m 82 m 0 3 r 8 m 0 9 r 4 m 0 m 20 m 0 m 20 m 1 m 0 m 20 m
80 m 10 m 0 2 r 2 m 0 m 5 m 0 m 21 m 0 m 10 m 0 m 2 m 0 m 40 m 0 m 3 m 0 3 r 40 m 0 m 40 m 1 m 21 m 0 2 r 40 m 0 m 40 m 10 2 r
4 m 0 4 r a0 m 0 m c0 m 5 m 0 m 21 m 82 m 2 m 0 m 10 m 0 m 4 m 2 m 0 m 88 m 9 m 0 2 r 88 m 2 m 0 3 r 5 m 20 m 4 m 0 m 8 m 20 m
4 m 90 m 8 m 0 3 r 2 m 0 3 r 8 m 0 3 r 5 m 0 m 2 m 0 2 r a0 m 0 m 1 m 0 2 r 40 m 0 3 r 80 m 0 2 r 20 m 0 2 r 21 m 2 m 0 2 r 20
m 0 m 2 m 0 3 r 3 m 0 m 9 m 0 m 3 m 0 m 8 m 0 m 20 m 0 5 r 1 m 0 m 1 m 40 m 82 m 0 m 10 m 0 2 r 20 m 82 m 0 3 r c0 m 9 m 82 m
0 m 8 m 0 m 82 m 41 m 0 2 r 8 m 0 2 r 21 m 0 m 8 m 90 m 11 m 0 m 40 m 0 m 11 m 91 m 0 4 r notbusy
02 wcmd 1 m 78 m 0 m \ 0x17800 
9 m 88 m 0 m 84 m 41 m 0 6 r 1 m 9 m 10 m 0 m 82 m 20 m 0 2 r 88 m 0 4 r 9 m 8 m 80 m 0 3 r a0 m 0 5 r 3 m 0 2 r 2 m 0 2 r 10
m 0 m 41 m 84 m 0 m 83 m 0 4 r 8 m 84 m 0 5 r 10 m 0 m 4 m 0 4 r 80 m 0 a r a0 m 0 5 r c1 m 0 m 8 m 0 m 8 2 r 41 m 0 m 10 m 1
m 8 m 0 2 r 10 m 41 m 0 m 21 m 0 m 21 m a0 m 10 m 82 m 0 m 40 m 11 m 10 m 21 m 40 m 8 m 84 m 11 m 2 m 0 m 40 m 11 m 0 m 21 m 8
m 9 m 82 m 2 m a0 m 10 m 82 m 11 m 0 m 40 m 0 2 r 20 m 4 2 r 10 m 82 m 83 m 0 m 80 m 0 2 r 20 m 2 m 0 m 9 m 0 2 r c0 m 21 m 8
m 80 m 0 3 r 80 m 0 2 r 4 m 82 2 r 0 m a0 m 8 2 r 11 m 0 2 r 82 m 10 m 90 m 2 m c0 m 0 m 84 m 2 m 84 m 2 m 0 2 r 8 m 0 m 84 m
0 m 1 m 5 m 82 m 0 3 r 20 m 0 m 20 m 0 m c0 m 0 5 r c0 m 80 m 0 6 r 40 m 0 5 r 4 m 0 m 4 m 0 m 9 m 0 2 r a1 m 8 m 0 m 20 m 4 m
0 m 84 m 0 m 82 m 0 m 82 m 20 m a0 m 0 2 r 20 m 88 m 20 m 4 m 0 2 r 3 m 0 m c0 m 0 m 9 m 0 3 r 85 m 90 m 11 m 10 m 0 m 1 m
notbusy
02 wcmd 1 m 79 m 0 m \ 0x17900 
3 m 84 m 0 m 1 m 9 m 90 m 0 m 88 m 0 m 4 m 5 m 2 m 0 m 40 m 21 m 0 m 20 m 21 m 0 m 90 m 0 m c0 m 21 m 0 m 4 m 10 m 0 2 r 8 m
20 m 0 m 8 m 0 m 20 m 0 m 82 m 0 3 r 90 m 0 6 r 41 m 0 a r 84 m 4 m 0 5 r 80 m 0 m 80 m 0 8 r 10 m 0 4 r 2 m 0 m 2 m 0 3 r 40
m 0 m 91 m 0 m 80 m 0 2 r 2 m 0 m 9 m 0 m 2 2 r 20 m 10 m 11 m 2 m 40 m 0 3 r 9 m 0 m 3 m 40 m 9 m 0 2 r 90 m 9 m 0 3 r 3 m a0
m 41 m 0 m 20 m 4 m 40 m 84 m 0 m 84 m 80 m 0 2 r a0 m 40 m 82 m 0 2 r 40 m c0 m 0 m 8 m 11 m 20 m 0 m 82 m 0 m a0 m 20 m 0 2
r 40 m 0 2 r 2 m 0 m 20 m 0 2 r 1 m 2 m 20 2 r 0 m 4 m 0 m 21 m 0 4 r 8 m 40 m 4 m 0 5 r 82 m 0 3 r 90 m 0 m c0 m 0 m 8 m 11 m
82 m 8 m 20 m 0 m 20 m 2 m 8 m 4 m 0 3 r 3 m 0 m 21 m 0 m 20 m 0 m 2 m 0 m 3 m 0 2 r 82 m 0 m 82 m 11 m 0 m 20 m 0 3 r 20 m a0
m 20 m 0 m 10 m 0 m c0 m 0 m 88 m 20 m 3 m 0 2 r 2 m 0 m 41 m c0 m 40 m 4 m 0 m c0 m 0 3 r 2 m 0 m 2 m 0 2 r 40 m 90 m 0 2 r
11 m a0 m 20 m 84 m notbusy
02 wcmd 1 m 7a m 0 m \ 0x17a00 
10 m 0 2 r 40 m 0 m 8 m 0 m 40 m 5 m 0 m 11 m 90 m 41 m 90 m 5 m 0 5 r 5 m 0 4 r 8 m 40 m 0 m 5 m 0 3 r 20 m 0 m 80 m 1 m 0 m
1 m 0 2 r 40 m c0 m 9 m c0 m 0 m 20 m 0 m 88 m 0 m c0 m 0 2 r 41 m 0 m 21 m 2 m 3 m 0 m 3 m 0 4 r a0 m 80 m 0 m 80 m 4 m 80 m
8 m 20 m 0 11 r 9 m 1 m 0 3 r 1 m 5 m 3 m 0 m 8 m 0 3 r 4 m 20 m 5 m 0 m 3 m 0 m 10 m 0 m 8 m 0 m 8 m c0 m 11 m 0 2 r 20 m 8 m
0 2 r c0 m 0 m 88 m 0 m 88 m 0 3 r 8 m 2 m 20 m 3 m 90 m 2 m 8 m 0 2 r 2 m 88 m 0 m 20 m 0 m 40 m 5 m 90 m 0 2 r 21 m 20 m 21
m 40 m 4 m 0 m 8 m 0 4 r 82 m 0 3 r c0 m 0 6 r 20 m 0 m 5 m 4 m 0 3 r 90 m 0 2 r 3 m 10 m 0 7 r 84 m 0 m 2 m 5 m 10 m 0 3 r c0
m 9 m 8 2 r 0 m 5 m 0 3 r 3 m 0 2 r 8 m 90 m 0 6 r a0 m 0 9 r 9 m 0 m 20 m c0 m 20 m 4 m 11 m c0 m 9 m 0 3 r 11 m 0 m 40 m a0
m 0 2 r 11 m 2 m 11 m 0 m 40 m 0 2 r 2 m 11 m 84 m 9 m c0 m notbusy
02 wcmd 1 m 7b m 0 m \ 0x17b00 
10 m c0 m 0 m c0 m 11 m c0 m 10 m 0 m 20 m 0 m 3 m 0 m 20 m 82 m 3 m 88 m 21 m 0 m 9 m 0 m 3 m 8 m 10 m 0 m 3 m 10 m 0 m 2 m 0
m 90 m 0 m 82 m 4 m 84 m 0 3 r 4 m 0 m c0 m 20 m 0 m 21 m 5 m 11 m 0 3 r 9 m 0 2 r 20 m 0 5 r 84 m 0 6 r 80 m 0 11 r 85 m 3 m
0 6 r 21 m 0 3 r 40 m 0 m 11 m 0 m 21 m 0 m 8 m a0 m 0 m a0 m c0 m 88 m 10 2 r 0 10 r 41 m 4 m 88 m 10 m 0 m 82 m c0 m 8 m 5 m
20 m 90 m 2 m 4 m 88 m c0 m 88 m 2 m 40 m c0 m 4 m 0 m 20 m 2 m 82 m 0 2 r 41 m 0 m 83 m 1 m 84 m 0 m 10 m 4 m 0 m 2 m 90 m 82
m 0 m 82 m 0 2 r 11 m 88 m 91 m 20 m 88 m 8 m 88 m 91 m 0 8 r 20 m 10 m 0 2 r 20 3 r 82 m 0 m a0 m 0 m 90 m 0 m 2 m 8 m 10 m
90 m a0 m 83 m 0 m 11 m 2 2 r 90 m 0 2 r a0 m 0 m 90 m 0 2 r 1 m 0 8 r 90 2 r 0 m 82 m 0 m a0 m 2 m 8 m 11 m 80 m 21 m 0 15 r
89 m 80 m notbusy
02 wcmd 1 m 7c m 0 m \ 0x17c00 
0 3 r 80 m 0 2 r 40 m 0 m 21 m 0 m 80 m 0 m 80 m 0 m 80 2 r 9 m 80 m 0 3 r 80 m 0 m 3 m 21 m 20 m 82 m 10 m 80 m 8 m 0 m 80 m
20 m 80 m 0 6 r 91 m 4 m 83 m 41 m 4 m 2 m 0 m 8 m 0 a r 11 m 0 5 r 8 m 80 m 0 m 80 m 0 3 r 80 m 0 m 83 m 2 m 41 m 88 2 r 80 m
8 m 20 m 41 m a1 m 11 m 0 m 20 m 0 m 21 m 0 f r 80 m 2 m 0 m 41 m 90 m 11 m 10 m 2 m 0 14 r 21 m 80 m 5 m 0 2 r 4 m 0 m 8 m 10
m 3 m 80 m 88 m 0 m 90 m 0 m 20 2 r 40 m a0 m 10 m 0 m 20 m 0 m 3 m 0 m a0 m 0 m 90 m 0 m 5 m 0 m 82 m 0 m 83 m 40 m 5 m 0 3 r
10 m 0 m 40 m 8 2 r 88 m 2 m 83 m 0 13 r 2 m 80 3 r 0 m 2 m 0 m c0 m 10 m 91 m 10 m 83 m 5 m 90 m 0 m 85 m 3 m 5 m 3 m 89 m 90
m 0 b r 2 m 80 m 0 m 80 m 0 m 90 m 0 m 10 m 2 m 0 2 r 1 m 2 m 0 e r notbusy
02 wcmd 1 m 7d m 0 m \ 0x17d00 
0 2 r 2 m 0 m 90 m 0 m 8 2 r 40 m 0 m 40 m 0 m 2 m 0 m 1 m 84 m c0 m 2 m a1 m 0 m 88 m 0 m 10 m c1 m 83 m 0 m 9 m c0 m c1 m 0
m 83 m 0 m c1 m a0 m 8 m 0 m 40 m 0 m a0 m 0 m c0 m 0 3 r 91 m 90 m 89 m 1 m 8 m 40 m 90 m 91 m 0 8 r 10 m 0 9 r 2 m 0 m a0 m
88 m 8 m 0 m 89 m a0 m 2 m 0 m a0 m 40 m 3 m 0 m 10 m 20 m 10 m 0 m 9 m a1 m c1 m a0 m 0 8 r 90 m 0 m 82 m 1 m 2 m 88 m 10 m 0
m 2 m 20 m 8 m 88 m 8 m 89 m a0 m 10 m 0 10 r 40 m 8 m 0 m 82 m 10 m c0 m 4 m a0 m 0 m 10 m 0 m a0 m 0 m 41 m a1 m 8 m 10 m 2
m 0 m a1 m 2 m 84 m 1 m a1 m 0 m 20 m 0 m 2 m 20 m 89 m 0 m 2 m 0 m a0 m 0 m 2 m 4 m 3 m 0 m 20 m 0 2 r 90 m 89 m 0 m 8 m 91 m
90 m 3 m 91 m 0 8 r 90 m 8 m 0 m a0 m 0 m 85 m c1 m 40 m 90 m 0 2 r 88 m 0 m 2 m 10 m 2 m 40 m 2 m 0 m 90 m 4 m 41 m a0 m 82 m
0 m 1 m 0 2 r 1 m 0 2 r 1 m 0 8 r 40 m 2 m 0 m 82 m 0 m a0 m 10 2 r 9 m 90 m 80 3 r 8 m 80 m 2 m 0 a r notbusy
02 wcmd 1 m 7e m 0 m \ 0x17e00 
0 6 r 80 2 r 0 m 80 m 0 2 r 10 m 80 m 0 m 3 m 0 m 85 m 0 m 21 2 r 91 m 80 m a0 m 0 m 88 m 80 m 88 m 20 m 85 m 0 m 9 m 5 m a1 m
3 m 21 m 0 m 88 m 0 m 41 m 0 m 91 m 80 m a1 m 0 m 10 m 0 3 r 10 m 21 m 8 m 88 m 2 m 91 m 20 m 0 b r 85 m 0 m 88 m a1 m 20 m 0
6 r 80 m 0 m 80 m 91 m 2 m 9 m 90 m a0 m 80 m 85 m 0 m 20 m 40 m 5 2 r 0 m 10 2 r 0 9 r 80 m 0 4 r 5 m 0 2 r 85 m 0 m 21 m 0 3
r 4 m 0 11 r 8 m 80 2 r 0 m 80 m 0 3 r 80 m 0 m 9 m 80 m 0 m 80 m 2 m 0 m c0 m 80 m 10 m 0 m a1 m 80 m 8 m 0 m a1 m 40 m 0 3 r
5 m 11 m 0 3 r 80 m 0 3 r 40 m 0 2 r 20 m 91 m 8 m 84 m 2 m 0 m 10 2 r 0 10 r 80 m 0 m 80 m 0 3 r 80 m 0 m 11 m a0 m 11 m 5 m
11 m 0 m 8 m 2 m 41 m 20 m 21 m 10 m 83 m 80 m 40 m 0 c r 3 m 0 4 r 84 m 10 m 20 m 0 m 8 2 r 88 m 0 7 r notbusy
02 wcmd 1 m 7f m 0 m \ 0x17f00 
0 a r 20 m 0 m a0 m 2 m a0 m 40 m 90 m 0 m 4 2 r 8 m 1 m 82 m 40 m 8 m 0 m 84 m 41 m 20 m 9 m 90 m 83 m 8 m 1 m 0 m 41 m 0 3 r
40 m 0 5 r a0 m 0 m 8 m 0 4 r 91 m 41 m 8 m 82 m 90 m 20 m 88 m 0 c r 20 m 0 m 88 m 0 2 r c0 m 0 m 8 m 0 m 88 2 r 8 m 0 m 88 m
10 m 90 m 20 m 40 m 2 m 91 m 0 m 11 m 20 2 r 41 m 5 m 84 m 90 m 0 9 r 88 m 0 m a0 m a1 m 40 m 88 m 10 m 0 5 r b m 4 m 0 21 r
21 m 0 7 r 82 m 0 15 r d0 m b m 0 12 r 82 m 0 m 41 m 0 2 r b m 0 6 r d0 m 0 18 r b m 0 3 r ff m cf m ff m cf m 0 m c m 0 4 r
notbusy
20 wcmd 1 m 80 m 0 m notbusy \ 0x18000
02 wcmd 1 m 80 m 0 m \ 0x18000 
0 e r f9 4 r fe m f6 m 7e m 66 m 0 m 18 m 0 2 r 81 m 6 m 0 6 r 66 4 r 0 4 r fc m cf m fc m ff m 0 4 r ff m fe m ff m f6 m 0 2
r f7 m ff m 4 m 0 m ff m 0 m ef m 20 m 0 c r 6 m 1e m 0 2 r fe m 20 m 65 m 56 m 0 2 r ff m 0 m 8 m 0 7 r ff m 30 m 76 m 30 m 0
c r f3 m f0 m 30 m f0 m 3c 2 r fd m 3c m f0 m ff 3 r 0 m 99 m 0 12 r f9 3 r 78 m fc m f0 m 3c m 0 2 r 18 m 30 m 0 2 r 6 m 0 2
r 10 m 1c m 0 m c m ff 3 r fc m 0 4 r ff m cf m ff 2 r 0 4 r ff m fe m ff m f6 m 0 2 r ff 2 r 0 2 r ff m 0 m ff m 0 11 r f6 m
0 m 69 m 66 m 0 2 r f m 0 6 r 10 m 0 2 r 76 m 30 m 76 m 30 m 0 c r f1 m f0 m 70 m f0 m 3c 2 r 4 m 3c m ff 6 r notbusy
02 wcmd 1 m 81 m 0 m \ 0x18100 
ff 7c r 0 m 4 m 40 m 87 m 30 m 22 m 1 m a m 0 m 18 m 50 m 60 m 0 2 r f m 7d m 0 m d0 m 0 m 10 m ff 4 r 0 10 r 7f m ff 3 r 0 4
r fd 2 r ff m cf m f 2 r 3c 2 r 0 m c3 m 3 m c3 m ff 4 r 0 6 r 3c 2 r 0 m f m 3c m 3f m cf 4 r 0 3 r ff m 2 m fe m ff m f7 m
ff 2 r 0 8 r 7f 2 r ff 6 r 0 m ff 2 r 0 m ff m 0 m f0 m f m 2c 2 r ff 2 r 0 m ff m 1 m ff m 0 4 r ff 4 r 0 2 r notbusy
02 wcmd 1 m 82 m 0 m \ 0x18200 
0 6 r fe 2 r ff m fe m 0 m ff m 0 m ff m 0 m c0 m 0 2 r 3f 4 r 0 10 r 7f 2 r ff 2 r 0 2 r 3 m 1 m fd 2 r ff m cf m 0 5 r c3 m
0 m c3 m 7f m ff 3 r 0 4 r f m 0 m f 2 r 0 m f m 3c m 3f m 4e m cf 3 r 0 3 r ff m 0 m ff m 0 m 4 m 0 a r ff 4 r e7 4 r d m f2
2 r d m 0 m ff m f m f0 m 2c 4 r 0 2 r 1 2 r 0 4 r 76 m 7e m 30 m 3c m 0 8 r 8 2 r 0 m 8 m 0 m b9 m 46 m ff m 5 m 71 m a m e m
5 m d m 0 m a1 m 0 15 r 10 m 0 m 1 m 80 m 61 m 0 m 6 m 0 m d m 0 m 5 m 0 m 61 m 0 m 6 m 0 m 1d m 0 3 r 61 m 0 m 6 m 0 m d m 0
m 5 m 0 m 61 m 0 m 6 m 0 m d m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 b r 61 m 0 m 6 m 0 m d m 0 2 r 10 m 0 2 r 20 m 0 5 r 61 m 0 m 1 m
0 m 1 m 0 3 r 61 m 0 m 6 m 0 m d m notbusy
02 wcmd 1 m 83 m 0 m \ 0x18300 
0 m 5 m 0 b r 8 m 0 8 r ff m 3c m ff 2 r 0 1d r 45 m ba m ff m 0 4 r f0 m 0 m c0 m 0 m 7d m 3c m 7d m 3c m ff 2 r aa 2 r 0 4 r
fe m ff m 3c 2 r 0 2 r ff 2 r ef m ff m df m ff 3 r 0 c r ff m 5f m aa m ff m 0 8 r 55 2 r 4d 2 r 40 m fe m c0 m fc m 0 m ff m
8 m 0 19 r ff m d7 m ff 2 r 0 1d r cf m 30 m ff m 0 4 r ff m 0 m ff m 0 m 7d m 3c m 7d m 3c m fc m ff m aa 2 r 0 4 r f2 m ff m
3c 2 r 0 2 r 10 m 0 5 r 20 m 0 d r ff m 5f m ff 2 r 0 8 r 55 3 r 4d m 0 m ff m 0 m ff m 0 2 r notbusy
02 wcmd 1 m 84 m 0 m \ 0x18400 
8 m 0 3 r 20 2 r 0 15 r a0 m aa 2 r 0 1c r f5 4 r 0 4 r fd m bf m ff 4 r bf m 3f m 30 2 r ba m ff m 0 4 r fa m ff m fe m ff m
0 2 r 75 m 55 m 45 m 55 m ff m f7 m ff 2 r 0 18 r ff 2 r 0 2 r f0 4 r ff m d m ff m 5 m 0 2 r f0 2 r 0 14 r 28 m a8 m aa 2 r 0
1c r b4 m f5 3 r 0 4 r ff 4 r bf m 3f m bf m 3f m 30 3 r ff m 0 4 r fa m ff m fe m ff m 0 2 r 55 4 r 0 m 20 m 0 1a r f5 m fd m
5 m 1 m f0 2 r notbusy
02 wcmd 1 m 85 m 0 m \ 0x18500 
aa m e8 m d 2 r 5 2 r 0 m 3c m f0 m fc m 0 10 r 4 m 0 3 r 1 m 0 4 r 4 m 1 m 0 m 1 m 90 m 0 m 85 m 0 2 r 40 m 10 m 0 m 80 m 40
m 4 m 1 m 0 2 r 4 m 5 m 80 m 4 m a0 m c0 m 0 4 r 3 m 0 3 r 9 m 0 m 8 m 0 m 20 m 88 m 0 m 40 m 0 m c0 m 3 m c0 m 0 m 4 3 r 20 m
0 m c0 m 20 m 0 m 88 m 2 m 0 4 r 41 m 0 m 84 m 2 m 0 8 r 20 m 0 m 20 m 80 m 0 3 r 40 m 4 m 3 m 0 m 3 m 0 8 r 20 m 0 6 r 2 m 0
m 20 m 0 4 r 20 m 0 13 r 40 m 8 m 0 2 r 41 m 0 m 8 m 0 m 40 m 3 m 0 m 10 m 0 3 r 1 m 0 m 10 m 80 m 1 m 2 m 0 2 r 1 m 8 m 20 m
80 m 21 m 0 6 r 2 m 0 3 r 21 m 0 2 r 1 m 0 7 r c0 m 20 m 40 m 0 m 1 m 0 m 20 m 0 m 40 m 0 m 5 m 0 m 3 m 0 2 r 20 m 0 m 40 m 0
c r 20 m 0 4 r 20 m 0 3 r 21 m 0 3 r 20 m 0 3 r notbusy
02 wcmd 1 m 86 m 0 m \ 0x18600 
0 9 r 1 m 0 14 r 1 m 0 m 1 m 0 m 1 m 5 m 0 m 80 m 0 2 r 90 m 0 m a0 m 4 m 1 m 0 m 4 m 80 m 0 2 r 40 m 0 m 40 m 80 m 90 m 0 m
21 m 0 m 4 m 80 m 20 m 0 3 r 84 m 0 2 r 11 m 0 3 r 4 m 0 m 80 m 0 3 r 80 m 0 m 80 m 0 m 4 m 1 m 80 m 90 m 82 m 0 2 r 4 m 0 12
r 10 m 0 7 r 20 m 0 m 11 m 0 3 r 20 m 0 3 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 4 m 0 2 r 80 m 0 4 r 4 m 0 2 r 20 m 0 b r 10 m 0 4
r 2 m 0 m 40 m 84 m 8 m 0 2 r 10 m 0 3 r 8 m 0 2 r 8 2 r 9 m 2 m 0 2 r 80 m 0 m 88 m 10 m 0 m c0 m a0 m 0 m a0 m 20 m 80 m 82
m 20 m 0 m 9 m 0 2 r 84 m 0 m 8 m 0 m 8 m 0 m 20 m 0 2 r 11 m 20 m 0 m 4 m 0 m 10 m 40 m 4 m 0 m 5 m 0 2 r 80 m 8 m 0 m 8 m 0
m 8 m 0 3 r 8 m 0 m 8 m 0 3 r 8 m 40 m 8 3 r 40 m 0 2 r 90 m 0 3 r 83 m 0 m 4 m 0 3 r 3 m 0 m 2 m 0 m 20 m notbusy
02 wcmd 1 m 87 m 0 m \ 0x18700 
0 m 20 m 0 m 20 m 0 m 20 m 80 m 0 m 11 m 2 m 0 m 8 m 0 m 4 m 80 m 8 m 0 m 1 m 0 7 r 4 m 0 m c0 m 0 5 r 8 m 2 m 0 5 r 2 m 10 m
c0 m 8 m 40 m 4 m c0 m 11 m 20 m 0 m 20 m 3 m 0 m 9 m 4 m 10 m 40 m a1 m 84 m 3 2 r 88 m 2 m 5 m 21 m 82 m 40 m 8 m 40 m 9 m
21 m 83 m 90 m 21 m 40 m 2 m 0 m 5 m 0 m 2 m a0 m 8 m 0 2 r c0 m 5 m 10 m 2 m 0 m 21 m 0 m 8 m 1 m 0 m c0 m 0 m 5 m a1 m 0 2 r
40 m a1 m 0 m 41 m 20 m 21 m 20 m 21 m 0 3 r 40 m 88 m 5 m 0 m 21 m 0 m 3 m a0 m 9 m 0 m 41 m 40 m 8 m 0 m 40 m 0 m 80 m 84 m
40 2 r 2 m 20 m 0 5 r 1 m 0 2 r 20 m 0 4 r 88 m 0 4 r 5 m 0 7 r 10 m 0 4 r 80 m 90 m 0 m 82 m 0 m 2 m 0 m 3 m 0 m 82 m 0 m 2 m
0 m 2 m 0 m 2 m 8 m 82 m 3 m 8 m 0 2 r 80 m 2 m 9 m 0 m 20 m 40 m 11 m 40 m 84 m 4 m 3 m 84 m 89 m 8 m 40 m 2 m 0 m 2 m 5 m a0
m 4 m 0 m 41 m 1 m 41 m 0 3 r 2 m 20 m 0 m 9 m 8 m 0 2 r 82 m 4 m 40 m 0 2 r 84 m 2 m 0 3 r 4 m 0 2 r 80 m 20 m 80 m 20 m 3 m
88 m 0 2 r 3 m 90 m 2 m a0 m 0 2 r 8 m 0 m 3 m 40 m 0 m 8 m 0 2 r notbusy
02 wcmd 1 m 88 m 0 m \ 0x18800 
40 m 20 m 8 m 0 2 r 2 m 5 m 0 m 5 m 0 m 3 m 0 m 4 m 0 2 r 83 m 0 m a0 m 0 m 90 m 0 m 8 m 0 m 8 m 0 3 r a0 m 10 m 20 m 0 m 8 m
0 6 r 8 m 0 m a0 m 0 m 90 m 0 m 40 m 8 m 82 m 0 2 r 9 2 r 0 m 40 m 2 m a0 m 10 m 4 m 80 m c0 m 9 2 r 0 m c0 m 0 m 8 m 4 2 r 2
m 83 m 20 m 0 m 9 m 10 m 5 m 0 m 82 m 0 4 r 10 m 5 m 0 m 5 m 8 m 11 m 0 4 r 4 m 0 m c0 m 20 m 84 m 0 3 r 84 m 80 m a0 m 20 m 0
2 r 20 m 0 m a0 m 0 m 84 m 80 m 11 m 0 2 r 4 m 0 m 9 m 0 m 4 m 0 m 4 m 0 3 r 4 m 8 m 0 5 r a0 m 2 m 0 5 r 20 m 0 5 r 80 m 0 c
r 90 m 0 3 r 4 m 0 3 r 90 m 80 m 0 m 80 m 4 m 20 m 0 m 84 m 9 m 84 m 89 m a1 m 8 m 82 m 0 2 r 88 m c0 m 0 m a0 m 11 m 1 m 0 m
4 m 9 m 0 m c0 m a0 m 21 m 82 m 89 m c1 m 80 m 8 m 20 m 9 m 10 m 82 m 40 m 0 m 10 m 3 2 r 0 m 10 m 88 m 11 m 0 m 3 m 0 m 89 m
84 m 11 m c0 m 11 m 2 m 80 m 8 m 21 m a0 m 0 2 r 9 m a0 m 2 m 20 m 0 m 3 m 0 2 r 85 m 0 3 r 40 m 4 m 20 m 0 2 r a0 m 0 5 r 88
m 3 m 84 m 0 3 r c0 m notbusy
02 wcmd 1 m 89 m 0 m \ 0x18900 
3 m 90 m 8 2 r 0 7 r 1 m 10 m 0 m 8 m 0 2 r 20 m 0 2 r 41 m a0 m 0 5 r 84 m 0 6 r 80 m 0 m 11 m 0 2 r 20 m 0 m 20 m 88 m 3 m 4
m 0 m 90 m c0 m 84 m 8 2 r 84 m 40 m 11 m c0 m 0 m 40 m 21 m 2 m 3 m 88 m 5 m 82 m 89 m 1 m 11 m 0 m 40 m 0 m 20 m 82 m 4 m 84
m 40 m 2 m 0 3 r 82 m a0 m 11 m 21 m a0 m 0 m 2 m 82 2 r 0 2 r 40 m 0 m 21 m a0 m 11 m 40 m 0 m 41 m 21 m 88 m 11 m c0 m 0 m 4
m 80 m 0 3 r 1 m 0 m 20 m 0 m 40 m 0 m 10 m 82 m 4 m 0 m 3 m 0 3 r 21 m 0 m 21 m 0 7 r 2 m 0 4 r 20 m 0 2 r 8 m 0 4 r 40 m 0 m
a0 m 0 4 r 11 m 0 b r 40 m 0 2 r 4 m 20 m 4 m 0 m 4 m 0 2 r 88 m 0 3 r 10 m 5 m a0 m 2 2 r 0 7 r 40 m 0 3 r 4 m 40 m 90 m 5 m
84 m 21 m 0 2 r a0 m 0 m 10 m 4 m 90 m 0 2 r 5 m 2 m 40 m a0 m 9 m 82 m 3 m 2 m 5 m 4 m 11 m 90 m 21 m 0 m 3 m 0 m 5 m 0 m 2 m
a0 m 5 m 0 m 3 m 0 m 85 m 20 m 0 m 90 m 0 2 r 21 m 88 m 41 m 88 m 20 m 0 m 40 m 84 m 40 m 4 m 0 7 r 4 m notbusy
02 wcmd 1 m 8a m 0 m \ 0x18a00 
0 4 r 10 m 2 m 0 m 4 m 0 2 r 10 m 4 m 20 m 84 m 5 m 88 m 9 m 4 m 83 m 0 m 21 m c0 m 0 2 r 3 m 0 m 41 m 0 m 8 m 0 7 r 8 2 r 0 2
r 80 m 85 m 80 m 4 m c0 m 2 m 0 2 r 8 m 9 m 82 m 8 m 82 m 21 m c0 m 5 m 0 m 5 m 0 m 21 m 0 2 r 10 m 4 m c0 m 10 m 8 m 40 2 r
21 m 84 m 0 2 r 10 m 0 m 5 m 88 m 85 m 8 m 2 m 90 m 20 2 r 41 m 84 m 10 m 4 2 r 90 m 41 m 83 m 40 2 r 2 m 90 m 0 m 8 2 r 40 m
8 m 4 m 10 m 4 m 5 m 82 m 40 m 0 m 10 m a0 m 41 m 0 3 r 3 m 0 m 4 m 0 m 5 m 0 m 3 m 0 2 r 20 m 0 2 r 8 m 0 m 21 m 0 2 r 8 m 0
2 r 20 m 0 m 80 m 0 m 21 m 0 4 r 10 m 80 m 0 4 r 10 m 0 2 r 2 m 0 m 11 m 0 3 r 9 m 0 b r 20 m 0 m 8 m 0 4 r 11 m 0 m 80 m 0 m
11 m 2 m 20 m 2 m 9 m 82 m 0 m 10 m 21 m 10 2 r 4 m 0 m 9 m 0 m a0 m 80 m 9 m 83 m 8 m 0 m 90 m 0 2 r 11 m 0 m 41 m 4 m 0 m 1
m 5 m 4 m 11 m 0 m 5 m c0 m 80 m 82 m 40 m 0 m 4 m 0 m 3 m 5 m 11 m 88 m 40 m 0 m 91 m 0 m 91 m 20 m a1 m 0 2 r 82 m 0 m 82 m
8 m 20 m 0 2 r 8 m 0 2 r 83 m 3 m 88 m 40 m 20 m 9 m 2 m 20 m 10 m 41 m 0 m notbusy
02 wcmd 1 m 8b m 0 m \ 0x18b00 
3 m a0 m 10 m 0 m 3 m 0 2 r 1 m 0 m 20 m 0 7 r 20 m 0 5 r 82 m 0 m 2 m 0 3 r a0 m 21 m 0 8 r 82 m 0 3 r 5 m 0 m 88 m 40 m 0 2
r 2 m 11 m a1 m 10 m 1 m c0 m 9 m 82 m 10 m 2 m a0 m 9 m 2 2 r 82 m 20 m 2 m c0 m 88 m 0 m 1 m 84 m a0 m 84 m 0 m a1 m 21 2 r
10 m 82 m 88 m 2 m 5 m 0 2 r 82 m 0 m 2 m 1 m 0 3 r c0 m 90 2 r 0 m c0 m 0 m 88 m c0 m a0 m 88 m 0 m c0 m a0 m 90 m a0 m 90 2
r 89 m 0 m 84 m 82 2 r c0 m 0 6 r 3 m 0 c r c0 m 0 m 90 m 0 5 r c0 m 0 m 90 m 0 5 r c0 m 0 m 90 m 20 m 0 4 r c0 m 0 m 90 m 0 c
r c1 m 88 m 0 m a0 m 0 m 90 m 10 m 8 m c0 m 82 m 21 m 8 m 0 m 4 m 80 m 82 m 0 m 82 m a1 m 11 m 80 m 83 m 0 m a0 m 80 m 3 m 10
m 21 m 82 m 20 m 0 m 8 m 9 m 3 m 82 m 20 m 0 m 88 m 0 m 8 m 0 2 r 8 m 2 m 80 m 2 m 0 3 r 80 2 r 0 5 r 80 m 0 3 r 21 m 0 4 r 10
m 21 m 20 m 80 m 3 m 80 m 20 m 0 3 r 11 m 10 m 11 m 40 m 2 m 0 m 3 m 0 2 r notbusy
02 wcmd 1 m 8c m 0 m \ 0x18c00 
0 7 r 80 m 0 m 80 m 0 5 r 80 m 0 m 80 m 0 5 r 80 m 3 m 80 m 0 5 r 80 m 0 m 80 m 0 c r a0 m 0 5 r 80 m 0 m 88 m 0 m 84 m 10 m 4
m 40 m 9 m a1 m 40 m 0 m 85 m 41 m 91 m 80 m a1 m 80 m 8 m 10 m 0 m 41 m 0 m 88 m 90 m 3 m 41 m 80 m c0 m 41 m 20 m 40 m 10 m
88 m 5 m 0 m 8 m 0 m 40 m 0 m 10 m 3 m a0 m 0 m 89 m 90 m 20 m 90 m 8 m 88 m 0 m 3 m 20 m 10 m 11 m 9 m 8 m 0 m 8 m 41 m 5 m 0
m 3 m 5 m 82 m 0 3 r 2 m 0 m 20 m 0 m 2 m 0 m 3 m 2 m 0 c r 80 m 0 m 80 2 r 0 6 r 80 m 0 m 9 m 0 m 20 m 0 m 2 m 0 m c1 m 0 5 r
80 m 0 m 80 2 r 0 b r 10 m 80 2 r 0 2 r 9 m 0 m 41 m 1 m 10 m 4 m 83 m a1 m 91 m 0 m 82 m 1 m a0 2 r 11 m 4 m 0 m 1 m 0 m 1 m
a0 m c0 m 8 m 20 m 8 2 r 9 m 1 m 11 m 85 m 0 m 83 m 0 m 8 m 1 m 0 m 1 m 0 m 1 2 r 40 m 20 m 5 m c1 m 88 m a1 m 21 m 11 m 2 m 0
m c0 m 82 m 2 m a0 m 90 m 0 m 90 m 2 m 0 2 r c0 m 88 m 82 m 10 m 0 3 r 2 m 1 m 0 3 r notbusy
02 wcmd 1 m 8d m 0 m \ 0x18d00 
0 e r 84 m 0 m c0 m 90 m 88 m 0 5 r c0 m 0 7 r c1 m 0 5 r 84 m 0 m c0 m 90 m 0 8 r 2 m 0 m a0 m 1 m 40 2 r 8 m 0 m 20 m 8 m 1
m 2 m 0 m 10 2 r c1 m 0 m 10 m 0 m 3 m 0 m 11 m a0 m 11 m 10 m 20 m 41 m a0 m 11 m c1 m 0 m a0 m 90 m 2 m 1 m 91 m 84 m c1 m 1
m c0 m 0 5 r 1 m 0 m 1 m 40 m 90 m 0 m 90 m c0 m 10 m 9 m 1 m 0 m 8 m 20 m 3 m 10 m 2 m 0 m 40 m 8 m 89 m 8 m 0 m a0 m 5 m 10
m 3 m 0 3 r 1 3 r 0 3 r 1 m 0 d r 90 m 0 m c0 m 0 5 r 90 m 0 m c0 m 0 5 r 90 m 0 m c0 m 0 5 r 90 m 0 m c0 m 0 8 r a0 2 r 0 m
a0 m 0 m 20 m 10 m 2 m 0 m 4 m 41 m 9 m 3 m 2 m 0 m a0 m 0 m 83 m 21 m 83 m 10 m 8 m 11 m 2 m 80 m 3 m 90 m a0 m 90 m 21 m 11
m 90 m 0 m 41 m 21 m a0 2 r 21 m 4 m 91 m 0 m 3 m 8 m 4 m 9 m 40 m 0 m 8 m 3 m 91 m 0 m 10 m 80 m 5 m 9 m 41 m 0 m a0 m 80 m
11 m 0 m 8 m 9 m 80 m 0 m 10 m 80 m 41 m 89 m 8 m 0 m 90 m 0 3 r 40 m notbusy
02 wcmd 1 m 8e m 0 m \ 0x18e00 
40 m 8 2 r 3 m 0 m 10 m 0 d r 80 m 0 m 80 m 0 5 r 80 m 0 m 80 m 0 m 20 m 0 m 20 m 0 m c1 m 0 m 85 m 0 5 r 80 m 0 m 80 m 0 e r
10 m 0 m 41 m 80 m 0 2 r 9 m 0 m 8 m 4 m 11 m 2 m 8 m 0 m 10 m 0 m 9 m 2 m 10 m 2 m a1 2 r 8 m 0 m 40 m 2 m 88 m 21 m 8 m 82 m
c1 m 0 2 r 5 m 2 m 0 m 20 m 0 m 20 m 0 m 5 m 82 m 5 2 r a0 2 r 40 m 0 m 5 m 10 m 0 m 8 m 0 m 84 m 80 m 0 m 80 m 8 m 2 m c0 m
20 2 r 40 m 80 m 8 m 9 m 0 2 r 4 m 0 m 40 m 0 m 3 m 0 m 10 m 5 m 0 8 r 80 m 0 7 r 80 m 11 m 80 m 0 5 r 80 m 9 m 0 3 r 80 m 0 m
20 m 80 m 11 m 80 m 0 f r 80 m a0 m 0 4 r 3 m a0 m 88 m 82 m 20 m 4 m 3 m 0 m 10 m a1 2 r 4 m 88 m 82 m a0 m 0 m a1 m 0 m 88 m
11 m c0 m 0 m 82 m 0 m 11 m 91 2 r 90 m 4 m 90 2 r 0 m 1 m 90 m 0 5 r 8 m 89 m 82 m 10 m 83 m a0 m 90 m 8 m 0 m 8 m 1 m 10 m
40 m 4 m 2 2 r 0 m 5 m a1 m 4 m 9 m 1 m 40 m 85 m 0 m notbusy
02 wcmd 1 m 8f m 0 m \ 0x18f00 
0 2 r 1 m 88 m 0 4 r 1 m 0 9 r 90 m 0 7 r c0 m 1 m 20 m 0 5 r c0 m 9 m 0 3 r 8 2 r 0 m c0 m 1 m 20 m 0 d r a0 m 0 m 10 m 83 m
8 m 20 m 10 m 0 7 r 88 m 0 7 r 42 m 0 4 r 88 m 0 2 r 42 m 81 m 60 m 0 2 r d0 m b m 0 m 42 m 0 a r 81 m 0 2 r b m 0 m 60 m 11 m
0 3 r d0 m b m 0 m 82 m 0 5 r b m 0 8 r d0 m 0 10 r b m 0 7 r b m 0 7 r b m 0 7 r b m 0 f r b m 0 m 42 m 0 m ff 2 r fd m ff m
20 m 0 m 10 m 0 m 28 m aa m f8 m fa m 0 4 r 30 m 3f m 30 m 3f m a0 m be m f5 m be m ff 2 r 5f m ff 2 r f0 m 3c m aa m 0 a r 82
2 r 30 m 3f m 30 m 3f m 78 2 r aa m ff m 8a m aa m ba m aa m 0 m 28 m 55 m 7d m notbusy
20 wcmd 1 m 90 m 0 m notbusy \ 0x19000
02 wcmd 1 m 90 m 0 m \ 0x19000 
28 2 r 7d 2 r 0 14 r ff 2 r 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 2 r 3c 2 r 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 8 r ff 2 r 7c m
ff m 0 m ff m 0 m ff m f7 m ff 3 r 0 5 r 82 m f0 m f2 m 0 2 r 80 m 0 m a 2 r fa 2 r a0 m 14 m f5 m 14 m ff m c3 m 5f m ff m 0
m f0 m 3c m aa m 0 8 r 30 2 r 82 m be m 30 m 3f m 30 m 3f m 78 2 r 0 m 55 m aa 4 r 0 m 28 m 55 m 7d m 0 m ff m 0 m ff m 0 14 r
ff 2 r 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 2 r 3c 2 r 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 b r 83 m a0 m af m 20 m ef m 20 2 r 28
2 r f5 m 5 m 3f 2 r ff 3 r 3d m ff 6 r f 2 r ff m 55 m 0 m 55 m 0 4 r c0 m eb m c0 m eb m 0 a r f 2 r 3f m 1f m 3c m 14 m 0 2
r 30 2 r f 4 r notbusy
02 wcmd 1 m 91 m 0 m \ 0x19100 
2d 2 r 7d 3 r 41 m ff 2 r 0 12 r ff m 0 3 r ff m 0 3 r ff m 0 3 r 3c 2 r 0 2 r ff m 0 3 r ff 2 r 0 2 r ff m 0 4 r ff 3 r 0 8 r
af m f m 5 m f m fd m ff m fd 2 r aa 4 r f5 m 5 m 30 2 r ff 3 r 3d m 7f m 7d m 2a m 28 m f0 2 r 0 2 r ff m 55 m 0 m 55 m 0 m
30 m 0 2 r fc m eb m fc m eb m 0 9 r 14 m f 4 r 0 4 r 30 2 r 17 m f 3 r 2d 2 r 28 2 r 7d m 41 m 0 14 r ff m 0 3 r ff m 0 3 r
ff m 0 3 r 3c 2 r 0 2 r ff m 0 7 r ff m 0 4 r ff 3 r 0 8 r 8f m f m d m f m 8 m 0 m 8 2 r 0 m 61 m 0 m 6 m 0 m 9d m 0 3 r 61 m
0 m 6 m 0 m d m 0 2 r 80 m 61 m 0 m 86 m 20 m d m 0 m 1 m 80 m 61 m 0 m c m 80 m 99 m 0 m a1 m 0 m 61 m 0 m 6 m 0 m d m 0 2 r
5 m 61 m 34 m 2e m 5 m d m 0 m a0 m 0 m 61 m 30 m f m notbusy
02 wcmd 1 m 92 m 0 m \ 0x19200 
0 m d m 0 3 r 61 m 0 m e m 0 m d m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 a r 3 m 2 m 3 m 0 m c m 0 m 92 m c0 m 3 m 82 m 3 m 0 m c m 0 m
92 m c0 m 3 m e3 m 3 m 6 m c m d m 92 m c0 m 3 m 82 m 3 m 0 m c m 0 m 82 m c0 m 0 b r 8 m 0 4 r 3f 2 r fc 2 r 50 2 r fa 2 r cf
m ff 3 r 0 m 3c m 0 m 3c m f0 2 r 3f m 30 m a 2 r 0 2 r ff 4 r f8 m ff 3 r 3c 3 r 0 m 2c m 2f m ff 2 r 0 3 r 4 m 0 m 3c m 3f 2
r 0 4 r cf m d7 m cf m d7 m ff 2 r fb m ff m 0 m 3c m 0 m 3c m 0 2 r ff m 0 m ff m 0 m ff 3 r bf m 0 1c r 4 2 r 0 m 82 m 0 18
r 30 2 r c 2 r 14 m be m 14 m be m cf m ff 3 r 0 m 3c m 10 m 3c m 0 2 r 3f m 30 m 8a m a m 0 2 r ff 3 r 5f m 28 m ff 3 r 3c m
4 m 3c m 4 m 20 2 r ff 2 r 0 5 r 3c m 3f 2 r notbusy
02 wcmd 1 m 93 m 0 m \ 0x19300 
0 4 r cf m d7 m cf m d7 m ff 2 r fb m ff m 20 m 3c m 0 m 3c m 0 2 r ff m 4 m fb m 0 4 r 10 m 0 1f r 82 m 0 18 r ff 3 r fe m 0
2 r 2 m 0 m ff 2 r bf m ff m f0 2 r ff 2 r 40 2 r f m 0 m 69 2 r ff 5 r 7f m ff 4 r 5f m 55 m 5f m 55 m 0 2 r 4 m 0 e r a0 m 0
2 r 3f m f m 30 m f m f8 m f0 m f8 m fc m 0 2 r df m ff m 10 m 0 m aa 2 r b2 m aa m 0 1c r f0 m ff m 8 2 r 0 18 r ff 4 r 0 m
28 m 2 m 28 m 7f m ff 3 r 3c m be m ff 2 r 0 2 r f m 0 m 69 2 r ff 3 r 7f m ff m 7f m f8 m ff 3 r f m 0 m f m 0 9 r notbusy
02 wcmd 1 m 94 m 0 m \ 0x19400 
0 2 r 80 m 0 6 r a0 m 0 2 r 3f m 0 m 30 m 0 m 28 m 0 m 28 m 3c m 0 2 r ff 2 r 0 2 r aa 4 r 0 1d r f m 8 2 r 0 1c r 2 m 11 m 20
m 80 m 20 m 4 m 0 m 4 m 40 m 20 m 41 m 40 m 2 m 0 m c1 m 80 m 84 m 5 m 8 m 80 m 0 m 2 m 0 m 2 m 88 m 0 8 r 41 m 0 m 4 m 0 2 r
85 m 4 m 0 m 4 m 0 m 4 m 0 m 10 m 0 2 r 20 m 41 m 0 2 r 88 m c0 m 0 m 80 m 4 m c0 m 0 5 r 20 m 1 m 2 m 0 m 2 m 0 m 82 m 0 5 r
80 m 0 e r 20 m 5 m 0 m 8 m 0 9 r 2 m 0 5 r 4 m 0 2 r 84 m 0 3 r 40 m 0 2 r 80 m 0 m 80 m 20 m 0 7 r a1 m 0 2 r 20 m 80 m 1 m
0 2 r 80 m 0 m 40 m 5 m 8 m 0 m 8 m 20 2 r 0 m 89 m 20 m 0 m 8 m 0 m 1 m 21 m 0 m 4 m 0 5 r 11 m 8 m 0 m 1 m notbusy
02 wcmd 1 m 95 m 0 m \ 0x19500 
0 2 r 40 m 1 m 41 m 1 m 20 m 0 2 r 41 m 0 7 r 11 m 0 m 10 m 0 m 11 m 0 3 r 3 m 0 m 1 m 8 m 1 m 0 m a1 m 0 m 21 m 0 5 r 2 m 4 m
0 1a r 1 m 0 f r 20 m 0 m 20 m 0 6 r 4 m 0 3 r 4 2 r 0 5 r 5 m 0 3 r 80 m 4 m 0 4 r 8 m 0 m 20 m 0 m 40 m 0 2 r 20 2 r 0 m 80
m 40 m c1 m 0 m 80 m 2 m 0 m 88 m 80 m 0 m a0 m 0 5 r 40 m 0 4 r 90 m 0 2 r 80 m 41 m 0 2 r 4 m 1 m 0 4 r 80 m 8 m 0 2 r 80 m
0 m a0 m 0 m 20 m 0 m 20 m 4 m 0 m 4 m 2 m 0 4 r 20 m 0 8 r 5 m 0 5 r 9 m 0 1c r 2 m 0 m 80 m 0 3 r 80 m 9 m 3 m 8 m 0 2 r 2 m
10 m 0 3 r 8 m 9 m 0 m 2 m 82 m 4 m 0 2 r 1 m 0 3 r 84 m 0 m 5 m 0 m 4 m 85 m 4 m notbusy
02 wcmd 1 m 96 m 0 m \ 0x19600 
0 m 4 m 0 m 88 m 3 m 10 m 0 m 11 m 0 m c0 m 0 m 84 m 41 m c0 m 0 m 88 m 0 2 r 3 m c0 m 5 m 20 m 82 m 0 3 r 20 m 40 m 0 3 r 2 m
85 m 0 2 r 20 m 4 m 2 m 0 m 89 m 0 m 85 m 80 m 0 m 80 m 5 m 0 m 82 m 0 2 r 80 m 8 m 4 m 0 8 r 88 m 0 3 r 82 m 0 m 82 m 0 3 r 2
m 0 m 2 m 0 9 r 8 m 0 9 r 88 m 40 m 0 5 r 90 m 0 2 r 80 m 0 m 9 m 0 m 9 m 88 m 21 m 8 m 2 m 4 m 82 m 1 m 20 m 0 m a0 m 0 m 21
m 88 m 0 m 88 m 40 m 82 m 2 m 0 2 r 82 m 20 m 84 m 5 m 2 m 9 m 40 m 4 m 88 m 40 m 9 m c1 m c0 m 41 m 84 m 8 m 0 m 10 m 0 m 2 m
40 m 20 2 r a0 m 88 m 84 m 85 m 40 m 4 m 8 m 0 3 r 2 m 0 2 r c0 m 20 m 0 m 82 m 88 m 80 m 0 m 21 m 20 m 0 2 r 2 m 0 m 10 m c0
m 0 2 r 21 m 0 m 21 m 10 m 0 2 r 10 m 0 2 r 82 m 0 2 r 11 m 0 m 11 m 88 m 9 m 20 m 2 m 0 3 r 9 m c0 m 9 m 0 m 20 m 0 a r 1 m 0
5 r 89 m a0 m 0 3 r 88 m 11 m 90 m 2 m 4 m 9 m c0 m 9 m 90 m 40 m a0 m 85 m 9 m 41 m 10 m 8 m 89 m 4 m 10 m 8 m 90 m 20 m 0 m
3 m 88 m 40 m 2 m notbusy
02 wcmd 1 m 97 m 0 m \ 0x19700 
5 m 2 m 0 m 4 m 5 m a0 m a1 m 8 m a1 m 1 m 21 m 8 2 r 2 m 9 m 8 m 3 m 40 m 8 m 20 m 5 m 9 m 3 m c0 m 4 m 21 m 0 m 21 m 8 m c0
m 0 m 10 m 0 7 r 3 m 0 m 40 m 0 m 20 m 0 m 88 m 80 m 0 7 r 40 m 0 3 r 5 m 0 m 5 m 10 m 5 m 0 2 r 40 m 21 m 82 m 0 m 8 m 0 m 82
m 0 m 9 m 0 7 r 1 m 0 4 r 21 m 0 m 21 m 0 3 r 4 m 0 5 r 82 m 80 m 4 m 80 m a0 m 80 m 4 m 40 2 r 0 3 r c1 m 0 m 8 m 0 m 41 m 80
m 82 m 0 3 r 8 2 r 82 m 8 m 84 m 0 m 40 m 80 m 0 2 r 84 m 0 m 82 m 9 m 8 m 4 m 82 m 0 m 8 m 80 m 11 m 0 2 r 20 m a0 m 0 m 82 m
0 m 90 m 10 m a0 m 41 m 8 m 0 m a1 m 0 m 1 m 80 m 2 m 82 m a0 m 0 3 r 4 m 0 5 r 1 m 0 7 r 4 m 0 m 1 m 11 m 0 4 r 1 m 0 m 10 m
0 3 r c0 m 0 3 r 4 m 0 7 r 4 m 0 m 4 m 0 5 r a0 m 0 7 r 4 m 0 7 r 9 m 4 m 80 m 4 m 0 m 4 m c0 m 0 m 4 2 r 0 2 r 8 m 0 m 40 m 0
m 10 m 20 m 0 m 8 m 40 m 82 m 3 m 0 m 40 m 0 m 9 m 90 m notbusy
02 wcmd 1 m 98 m 0 m \ 0x19800 
a0 m 20 m 40 m 0 m 5 m 0 m 20 m 88 m 9 m 0 m 40 m 84 m 3 m 20 m 2 m c0 m 0 m 1 m 8 m c0 m 5 m 88 m 9 m 89 m 40 m 88 m 0 m c0 m
4 m 90 m 4 m 20 m 8 m 11 m 0 4 r 89 m 0 m 3 m 0 m 41 m 0 m 2 m 0 2 r 8 m 0 4 r 4 m 0 m 20 m 0 m 5 m 0 3 r 20 m 4 m 41 m 2 m 0
m a0 m 0 4 r 80 m 90 m 0 m c0 m 0 4 r 80 m 0 m 80 m 0 2 r 90 m 0 a r 80 m 0 7 r 2 m 3 m 0 m 80 m c0 m 21 m 41 m 10 m 0 m 11 m
4 m 0 m 40 m 0 m 8 m 41 m 0 m 40 m 84 m 9 m 40 m c0 m 82 m a1 m 9 m 8 m 0 m 20 m 82 m 10 m 8 2 r 20 m 3 m 90 m 9 m 40 m 0 m 40
m 80 m 0 2 r 40 2 r 0 m 3 m 40 m 20 m 8 m 3 m 82 m 3 m 84 m 40 m 9 m 3 m 88 m 4 m 82 m 0 m 84 m 4 m 10 m 20 m 0 m 1 m 82 m 3 m
82 m 10 m 0 2 r c0 m 20 m 40 m 0 m 1 m 80 m 5 m 0 2 r 20 m 0 m 41 m 20 m 0 m 8 m 0 m c0 m 0 3 r c0 m 2 m 0 2 r 90 m 2 2 r 0 m
4 m 0 m 4 m 3 m 84 m 0 3 r 1 m 4 m 0 m 20 m 0 m 8 m 0 5 r 41 m 0 m 41 m 0 4 r 4 m 0 m 4 m 0 m 20 m 2 m 0 m 20 m 0 m 88 m 40 m
0 3 r 9 m 0 m 91 m 90 m a0 2 r 11 m 0 m 9 m 82 m 0 m 2 m 9 m 2 m notbusy
02 wcmd 1 m 99 m 0 m \ 0x19900 
2 m 10 m 9 m 11 m 4 m 20 m 40 m 10 m 5 m 8 m 0 m 4 m 41 m 40 m 8 m 2 m 40 m 8 m 3 m 20 m 5 m 2 m 88 m 3 m 0 2 r 21 m c0 m 20 m
a1 m c0 m 0 m 3 m 21 m 0 m 10 m 5 m 83 m 10 m 2 m 0 5 r 5 m 40 m 8 m 11 m 1 m 80 m 0 m 4 m 2 m 4 m 0 m 10 m 0 2 r 84 m 80 m 0
2 r 10 m 0 a r 2 m 0 m 80 m 90 m 80 m 0 5 r 4 m 0 m 40 m 1 m 0 a r 3 m 0 m 3 m c0 m 80 m 0 m 80 m 0 m 88 m 8 m 0 m 8 m 0 m 8 m
82 m 0 m 89 m 0 m 88 m 8 m 40 m 8 m 82 m 21 m 1 m 0 2 r 84 m 20 m 21 m 2 m 0 m c0 m 80 m 84 m 21 m 4 m 21 m 10 m 4 m a0 m 21 m
a0 m 9 m c0 m 21 m 84 m 8 m 0 m 21 m 90 m 0 m 90 m 10 m 0 m c1 m 88 m 21 m 82 m 41 m 82 m 0 m 4 m 0 m c0 m 0 m c1 m 20 m 8 m 9
m 3 m c0 m 0 2 r c0 m c1 m 40 m 8 m 40 m 0 2 r 20 m 0 m 10 m 0 3 r 9 m 0 m 80 m 0 m 84 m 0 m 80 m 1 m 4 m 0 m 89 m 8 m 11 m 0
m 5 m 0 4 r c0 m 80 m 10 m c1 2 r 0 m 5 m 0 m 82 m 20 m 0 2 r 4 m 0 m 4 m 0 8 r 11 m 0 2 r 88 m 0 3 r 4 m 0 4 r 10 m 0 3 r a0
m 20 m 2 m 0 m 10 m 3 m 0 m 21 m 8 m 10 m 0 2 r 2 m notbusy
02 wcmd 1 m 9a m 0 m \ 0x19a00 
0 m 88 m 3 m 0 m 20 m 2 m 0 m 82 m 40 m 0 2 r 84 m 0 m 4 m 20 m 4 m 0 2 r 5 m 4 m 11 m c0 m 2 m 0 m 20 m 1 m 20 m 4 m 0 2 r 11
m 2 m 41 m a0 m 40 m 4 m 0 m 82 m 40 m 1 m 11 m 0 m 40 m 11 m 0 3 r 20 m 3 m 0 2 r 10 m 3 m 88 m 0 2 r 8 2 r 40 m 0 m 20 2 r 3
m 4 m 0 m 4 m 20 m 0 2 r 4 m 0 6 r 20 m 2 m 0 m 20 m 80 m 20 m 4 m 0 m 4 m 0 2 r 1 m 0 2 r 80 m 0 m 80 m 0 f r 80 m 0 m a1 m 8
m 0 m 4 m 10 m 84 m c0 m a0 m 0 3 r a0 m 40 m 10 m 90 m 11 m c1 m 5 m 2 m 4 m 82 m 9 m 88 m 8 m 10 m 11 m 1 m 9 m 8 m 89 m 10
m 85 m 11 m 8 m 1 m 90 m 20 m a0 m 8 m 3 m 20 m c0 m 11 m 5 m 8 m 90 m 20 m 21 m 0 m 10 m a0 m 88 m 20 m a0 m 82 m 2 m 9 m c0
m a1 m 20 m 2 m 88 2 r c0 m 0 2 r c0 m 4 m 0 m 10 m c0 m 88 m 0 m 10 m a0 m 8 m 84 m 83 m 20 m c1 m 90 m 82 m 0 4 r 11 m 0 b r
40 m 10 m 0 m 4 m 20 m 90 m 91 m 10 m 40 m 2 2 r 89 m 40 m c1 m 82 m 11 m 0 8 r c0 2 r 0 m 10 m 0 m c0 m 10 2 r 90 m 4 m 9 m
a1 m 80 m 9 m 80 m 0 m 40 m 41 m 9 m 11 m 80 m 2 m 0 m a0 m notbusy
02 wcmd 1 m 9b m 0 m \ 0x19b00 
c0 m 10 2 r a1 m 80 m 10 m 0 m 84 m 80 m 9 m 20 m c0 m 80 m 90 m 0 m 21 m 2 m a0 m 3 m 10 m 41 m 88 m 80 m 82 m 10 m 0 m 88 m
40 m 0 3 r 8 m 0 m 80 m 0 3 r 80 m 9 m 0 m 89 m 80 m 83 m 80 m 88 m 0 5 r 80 m 40 m 3 m 83 m 0 m 40 m 0 m 2 m 0 m 83 m 5 m c0
m 0 m 8 m 0 m 83 m 0 m 2 m 11 m 2 m 41 m 10 m 0 m 10 m 0 8 r 90 m 80 m 11 m 0 3 r 11 m 0 m 80 m 85 2 r 2 m 0 m 10 m 80 m 21 m
0 8 r 80 m 0 6 r 80 m 0 m 3 m 80 m 3 m 80 m 20 m 0 m 80 m 40 m 0 m 21 m 2 m 9 m a0 m 84 m 0 m 3 m 0 m 8 m 91 m 0 m 80 m c1 m
41 m 3 m 80 m a0 m 8 m 20 m 3 m 0 m 10 m 20 2 r 10 m 41 m 8 m 85 m 2 m 10 m 88 m 11 m 90 m 85 m 20 m 83 2 r 0 m c0 m 0 m a0 m
41 m 5 m 9 m 90 m 0 m 2 m 8 m a0 m 0 m 83 m 84 m 8 m a0 m 0 2 r c1 m 80 m 40 m 41 m 85 m 5 2 r a1 m 40 m 0 m 21 m 4 m 82 m 80
m 9 m 8 m 20 m 80 m 9 m 0 m 2 m 10 2 r 11 m 0 a r 80 m 3 m 0 m 4 m 80 3 r 0 m 80 m 4 m 0 m 8 m 0 a r 80 m 0 2 r 10 m 80 3 r 0
m 84 m 0 m 2 m 1 m a0 m 82 m a0 m 90 m 1 m 10 m 89 m 40 m notbusy
02 wcmd 1 m 9c m 0 m \ 0x19c00 
a0 m 10 m 5 m 0 m 2 m 90 m 1 m 8 m 0 m a0 m 5 m c1 m 8 m 40 m 2 m 88 m 82 2 r 84 m 21 m 20 m 3 m 10 m 41 m 8 2 r 1 m 10 m 3 m
8 m 20 m 8 m a1 m 11 m 2 2 r 40 m 0 m 9 m 1 m 82 m 8 m 83 m 0 m 21 m 85 m 84 m 0 m 5 m a1 m c0 m 89 m 0 2 r 2 m 8 m 1 2 r 3 m
88 m 90 m a1 m 83 m 4 m 85 m 1 m 9 m 84 m c0 m 4 m 0 m 40 m 0 3 r 1 2 r 0 9 r 2 m 0 m 20 m 1 m 4 2 r 10 2 r 84 m 0 m 10 m 0 m
88 m 89 m c0 m 0 9 r 8 m 0 m 10 m 0 m 8 3 r 0 m 40 m 88 m 2 m 84 m 5 m 90 m 9 m 4 2 r 2 m 1 m 0 2 r 89 m 10 m 5 m c0 m 5 m 0 m
9 m 8 m 10 m 88 m 8 m c0 m 82 m 0 m a0 m 11 m 4 m 90 m a0 m 2 m 9 m 40 m 2 m 11 m 21 m c0 m a0 m 2 m 3 m 2 m c0 m 8 m 5 m 10 m
11 m 40 m 82 m 0 m c1 m 0 m 91 m 82 m a0 m 90 m 9 m 8 m 11 m 0 m 10 m 0 m 11 m 0 2 r c0 m 20 m 0 m a0 m 85 m 2 m 9 m 88 m c0 2
r 0 m 84 m 4 m c1 m 88 m 5 m 0 m 1 2 r 0 d r 88 m 41 m 0 m 88 m 90 m 11 m c0 m 11 m 10 m 89 m 1 m 8 m 5 m 10 m 8 m 10 m 0 8 r
c0 m 10 m 0 m 10 m 0 m c0 m 8 2 r 80 m 11 m 8 3 r 3 m 8 m 89 m notbusy
02 wcmd 1 m 9d m 0 m \ 0x19d00 
80 m 90 m 3 3 r 8 m 11 m 40 m 88 m 9 m 2 m 40 m c1 m 20 m 0 m a0 m 84 m 20 m 21 m 90 m 85 m 5 2 r 88 m 80 m 5 m a1 m 82 m c0 m
21 m a0 m 89 2 r 90 m 0 m 4 m 0 m 90 m 8 m 2 m 0 3 r 20 m 0 m 8 m 80 m 82 m 0 m 40 m 80 m 82 m 0 2 r 40 m 10 m 0 2 r 80 m 40 m
5 2 r c0 m 82 m 20 m c0 m 0 m 5 m 0 m 3 m 80 m 10 m 0 m 20 m 0 m 10 2 r 2 m 41 m 8 m 10 m 20 m 0 9 r 82 m 0 m 20 m 0 m 88 m 0
m c1 m 0 m 10 m 20 2 r 82 m 3 m 80 m 85 m 0 8 r 80 m 0 2 r 80 m 0 2 r 80 3 r 0 7 r a0 m 80 m 8 m 4 m 10 m 0 m c0 m 2 m 89 m 9
m 2 m 40 m 84 m 0 m 40 m 10 m 0 m c0 m 8 m 0 m 8 m 0 m 10 m 40 m 21 m 40 m 82 m 80 m 8 m 0 m a0 m 2 m c0 m 2 m 20 m 83 m 82 m
0 m 3 m 40 m 80 m 20 m 80 m 20 m 0 3 r 3 m c1 m 0 m 90 m 2 m 8 m 80 m 2 m 9 m 0 2 r 82 m c0 m a1 m a0 m 4 m 80 m 40 m 8 m 41 m
40 m c0 m 91 m 40 m 0 m 8 m 20 m 8 2 r 10 m 8 m 10 m 0 m 10 m 3 m 0 8 r 80 m 0 2 r 3 m 0 7 r 41 m 0 d r 4 m 80 m c0 m 0 2 r 80
m 0 m 4 m 0 m 10 m 88 m notbusy
02 wcmd 1 m 9e m 0 m \ 0x19e00 
8 m 4 2 r 0 m 4 m c0 m 41 m 91 m 85 m c0 m 82 m 0 m 5 m 21 m 4 m 0 m 4 m 8 m 85 m 1 m 90 m 9 m 89 m a0 m 89 m 88 m 3 m 10 m 21
m 5 m 4 2 r 91 m 0 m 8 m 0 m 4 m 89 m 40 m c0 m 41 m 20 m 90 m 0 m c0 m 10 m 20 m 82 m 10 m a0 m 82 m 1 m c1 m c0 m 4 m 90 m
88 m 2 m 3 m 0 3 r 4 m 40 m a0 m a1 m 21 m 8 m 0 m 1 m 90 m 85 m 20 2 r c0 m 4 m 82 m 1 2 r 89 m 0 m 1 m 0 2 r 1 2 r 0 8 r 8 m
0 m 90 2 r 10 2 r 88 m 0 m 88 m 0 m 8 2 r 10 2 r 40 m 0 9 r a0 m 0 m 20 m 9 m c0 2 r 8 m 0 2 r a m 0 m 88 m b m 0 2 r a m 0 3
r d0 m 0 2 r 84 m 0 5 r b m 4 m 41 m 6 m 0 4 r 41 m 0 m 50 m 0 4 r d0 m 0 2 r 41 m a m 0 3 r 88 m b m 0 m 41 m 0 7 r 60 m 0 4
r d0 m b m 0 9 r b m 0 m 60 m 0 m 50 m 0 2 r d0 m b m 0 6 r d0 m 0 3 r 21 m 0 c r b m 0 7 r b m 0 f r b m 0 m 42 m 0 m notbusy
02 wcmd 1 m 9f m 0 m \ 0x19f00 
ff m fe m f6 m fe m ff 4 r 66 m 3c m f0 m ff m c3 m ff 4 r f4 3 r 2 m 0 3 r 7 m 6 2 r e m 67 m 66 m 67 m e7 m 7e m 3c 3 r 66 3
r 76 m 7e m 42 m 3c m 0 5 r 24 2 r 3 m 3f m 3 m f3 m 3 m f3 m 7e m 18 m ff m f m ff 2 r 8 m 0 3 r ff m 66 m 0 m 66 m 7e m 18 m
f0 2 r 7f m ff m 10 m 0 m ff 2 r ef m ff m 0 10 r 3c 4 r ff 3 r d3 m 3c m fc m 3c m bc m ff 2 r f2 m ff m 0 8 r ff m 10 m ef m
0 m f7 m ff 3 r 66 4 r ff m fe m ff m f6 m 66 m 3c m f0 m 0 m ff 5 r 24 3 r 0 4 r 6 4 r 66 2 r e7 2 r 6e m c 3 r 0 4 r 3c m 0
m fc m c0 m 10 m 0 5 r 3 m 3f m 0 2 r ff 2 r 7e m 18 m ff m f m ff 2 r 0 4 r f0 m 66 m f0 m 66 m 7e m 18 m f0 2 r ff 2 r 0 4 r
20 m 0 11 r 7f m 3c m 10 m 3c m 0 m 2c m 0 2 r 3c m c m 3c m 2c m d m 0 b r ff m 0 m ff m 0 m notbusy
20 wcmd 1 m a0 m 0 m notbusy \ 0x1a000
02 wcmd 1 m a0 m 0 m \ 0x1a000 
10 m 0 3 r ff 82 r 0 m e m 3a m c2 m 30 m 22 m 1 m c m 0 m 18 m 50 m 60 m 0 2 r e m fb m 6f m ff m 7f m ff m 6f m ff m 7f m ff
m f m 66 m f m 66 m 9 m 69 m f m 6f m 0 6 r c3 2 r ff m 0 m db m 0 m ff 9 r fd m ff m fd m ff m bd m ff m bd m 0 m 24 m f m 2f
m 3e 2 r bf 2 r 0 m ff m 3c 2 r ff 2 r 3c m ff m f 4 r 0 4 r 10 m 0 m 99 m bd m ff m bd m 62 m 66 m 6e m 66 m 3c 4 r 0 10 r fe
m f6 m ff 2 r f m 2d m f 2 r notbusy
02 wcmd 1 m a1 m 0 m \ 0x1a100 
0 2 r ff 2 r 2d m 3c m 2d 2 r 0 8 r 3c 6 r 36 m 3c m 6f 2 r 7f 2 r 66 m ff m 7e m ff 2 r 3c m ff m 3c m 0 m 60 m 6 m 66 m 0 m
8 m 0 6 r fb m 0 m fb m 0 m ff 2 r f3 m f6 m f m 6f m 3f 2 r ff m fd m ff m fd m fb 2 r e3 2 r 0 2 r f 2 r ff m e7 m ff m e7 m
f 2 r 66 2 r f0 2 r 3c m 0 m e m f m 8f m f m 0 2 r 30 4 r 0 m 24 m 66 m 24 m 66 4 r 3c 2 r 38 m 3e m 0 10 r 2 m 6 m 0 2 r 2d
2 r f 2 r 24 m 4 m e7 m f7 m 3c 4 r 0 8 r 3c m 38 m 3c m 3e m 3c 4 r 80 m 61 m 0 m a6 m 20 m d m 0 3 r 61 m 30 m 2 m 0 m d m 0
2 r 5 m 69 m a m e m 5 m d m 0 m a0 m 85 m 61 m a m 46 m 15 m 1d m 0 m a0 m 0 m 61 m 30 m 7 m 0 m d m 20 m 0 m 5 m 61 m a m 8e
m 25 m d m 4 m a1 m a0 m 61 m 0 m 6 m 0 m d m 0 2 r a0 m 61 m 50 m f m 0 m 1d m 20 m 1 m 0 3 r 61 m 40 m e m 0 m d m 0 3 r 61
m 0 m e m 80 m 5 m 0 3 r 61 m 0 m 1 m 0 m 1 m 0 b r 61 m 0 m e m notbusy
02 wcmd 1 m a2 m 0 m \ 0x1a200 
0 m d m 0 3 r 61 m 0 m e m 0 m d m 0 d r 8 m 0 c r 3d m 3c m 5 m 0 3 r fa 2 r 5f m 7d m 55 2 r 38 3 r ff 2 r cf m ff m cf m ff
4 r 0 2 r 80 m 0 m 40 m 0 3 r 8 m 0 3 r 3a m f m 3a m ff m 0 4 r 5f m ff 3 r 7d m 41 m f 2 r 3f 2 r 14 2 r 0 2 r 55 m 7f m 0 m
3f m 0 4 r ff m 7f m ff m 3f m 0 4 r 55 2 r 7d m 75 m fc m 3c m bc m 3c m 0 c r 5f m eb m f m ff m 0 6 r 10 m 0 16 r 2 m 0 2 r
3d m 3c m 5 m 0 3 r f0 m fc m f m 3c m 0 2 r 10 3 r ff m fa m ff m fa m ff m fe m ff 3 r 0 8 r 8 m 0 3 r 3a m 0 m 3a m f0 m 0
4 r 5f m ff 3 r 7d m 41 m 7d m 41 m 3f 2 r d7 2 r 0 2 r 55 m 5f m 0 m f m 0 3 r 40 m ff m 5f m ff m f m 1 m 0 3 r 55 2 r 41 m
45 m c m 3c m 1c m 3c m 0 8 r notbusy
02 wcmd 1 m a3 m 0 m \ 0x1a300 
0 4 r 5f m eb m ff 2 r 0 6 r 10 m 3 m 0 10 r f5 2 r ff 2 r 0 8 r aa m fa m aa m fe m bf m 1f m be m 14 m 2 2 r 0 2 r f5 4 r c2
m f2 m c2 m f2 m cf m af m f0 m ff m f3 m df m f3 m 1f m ff m 3c m ff m 3c m 0 m a0 m 3c m bc m 0 c r c0 2 r fc 2 r 0 6 r a8 m
aa 3 r 3f m ff 7 r 55 4 r 0 2 r ff 2 r 0 10 r ff m 7f m ff m 3f m 0 14 r ff 2 r aa m ff m 0 7 r 10 m 0 m f0 m 0 m fc m f 2 r 0
4 r a 2 r f5 3 r 35 m 2 m 32 m 2 m 32 m cf m af m ff 3 r df m ff m 1f m ff m 3c m ff m 3c m 0 2 r 3c 2 r 0 7 r 43 m 0 4 r 28 m
eb m 28 m eb m 0 4 r 1 m 0 m 28 m 2a m aa 2 r 3f m ff 3 r fe m fc m fe m ff m df m 55 m 10 m 55 m 0 m a2 m ff m ae m 0 4 r
notbusy
02 wcmd 1 m a4 m 0 m \ 0x1a400 
0 c r ff m 3f m ff m 3f m 0 14 r 1 m 3 m 1 m 0 2 r c0 m 0 m 10 m 0 m 9 m 82 m 0 4 r 4 m 2 m 0 3 r 4 m c1 m c0 m 3 m 84 m 20 m
1 m 0 2 r 3 m 84 m 4 m 0 m 5 m 0 2 r 1 m 0 m c0 m 80 m 1 m 4 2 r 84 m 5 m 8 m a1 m 4 m 0 2 r 84 m 0 m 40 m 0 m c1 m 0 m 40 m 5
m 0 5 r 11 m 0 2 r 1 m 2 m 88 m 2 m 4 m 0 m 1 m 4 m 0 2 r c0 m 41 m 1 m 0 2 r 84 m 0 3 r 8 m 0 7 r 5 m 0 m 21 m 0 6 r 40 m 5 m
40 m 0 m 88 m 83 m 40 m 0 2 r 20 m 0 a r 40 m 0 2 r 8 m 0 4 r 8 m 0 m 2 m 0 2 r 11 m 0 m 1 m 0 5 r 8 m 0 2 r a0 m 0 m 40 m 0 m
20 m 2 m 41 m 0 m 21 m 1 m 8 m 0 4 r a0 m 4 m 0 3 r 8 m 0 2 r 40 2 r 1 m 0 m 11 m 40 m 0 m 10 m 1 m 0 2 r 4 m 0 m c1 m 0 m 20
m 0 m 91 m 0 3 r 5 m 0 4 r 3 m 40 m 1 m 0 m 1 m 0 2 r 40 m 0 5 r 4 2 r 9 m 4 m 0 2 r 20 m c0 m 20 m 0 2 r a0 m notbusy
02 wcmd 1 m a5 m 0 m \ 0x1a500 
0 e r 9 m 0 2 r 20 m 0 3 r 1 m 0 17 r 83 m 1 m 0 2 r 8 m 0 2 r 1 m 0 2 r 8 m 88 m 0 2 r 8 m 0 3 r 8 m 0 m 3 m 0 2 r 84 m 0 9 r
8 m 40 m 0 2 r 1 m 4 m 85 m 84 m 11 m 4 m 40 m 0 m 1 m 4 m 89 m 0 2 r 4 m 0 2 r 2 m 0 4 r 2 m 0 2 r 2 m 0 m 2 m 0 2 r 80 m 1 m
2 m 4 m 0 m 4 m 0 m 1 m a0 m 0 3 r 5 m 0 3 r 80 m 0 3 r 80 m 0 m 5 m 1 m 0 m 1 m 4 m 0 b r 80 m 0 3 r 80 m 0 3 r 8 m 0 d r 90
m 0 3 r 40 m 8 m 0 m 4 m 84 m 4 m 8 m 4 m 0 m 3 m 0 7 r 2 m 0 2 r 4 m 0 m 84 m 0 3 r 84 m 0 m 4 m 2 m 8 m 0 3 r 84 m 0 m 84 m
20 m 85 m 20 m 5 m a0 m 83 m 80 m 0 m 40 2 r 10 m 0 2 r c1 m 0 2 r 80 m 0 2 r 8 m 0 m 1 m 0 2 r 80 m 90 m 85 m 10 m 0 m 2 2 r
9 m 85 m 10 m 80 m 8 m 4 m 5 m 0 m 8 m 0 m 84 m 9 m 0 m notbusy
02 wcmd 1 m a6 m 0 m \ 0x1a600 
0 m 10 m 5 m 0 2 r 10 m 0 m 4 m 40 m 8 m 40 m 0 8 r 4 m 0 m 8 m 0 m 20 m 0 3 r 20 m 0 3 r 90 m 0 5 r 8 m 0 3 r 8 m 0 3 r 10 m
40 m 8 m 40 m 3 m 0 m 40 m 0 m 9 m 88 m 0 m 40 m 0 m 5 m 80 m 20 m 0 2 r 21 m 90 m 10 m 84 m 11 m 88 m 10 m 0 2 r 90 m 8 m 40
m 21 m 90 m 3 m 82 m 21 m a0 m 0 m 4 m 41 m 89 m 8 m 21 m 88 m 0 2 r 91 m 41 m 90 m 8 m a1 m 41 m 2 m 40 m 8 m 21 m 8 m 2 m 82
m 2 m c0 m 0 5 r 88 m 0 5 r c0 m 21 m 4 m 8 m 4 m 0 2 r 21 m 0 m 41 m c0 m 0 m 84 m 0 3 r 4 m 2 m 0 m 11 m c0 m 3 m 0 m 2 m 90
m 85 m 0 m 21 m c0 m 82 m a0 m 4 m 0 m c0 m a0 m 0 2 r 8 m 0 m 8 m 0 3 r 8 m 0 3 r 8 m 0 8 r 90 m 0 2 r c1 m 21 m 82 m 9 m 82
m 0 m a0 m 9 m 40 2 r 84 m c1 m 0 m c0 m 10 m 3 m 2 m 41 m 84 m 3 m 5 m 20 m 84 m 9 m a0 m 10 m 84 m 5 m 88 m 20 m 4 m 21 m a0
m 0 m 82 m 41 m 8 m 85 m 8 m 20 m 82 m c0 m 2 m 5 m 88 m 40 m 84 m 8 m 84 m 40 m 0 m c1 m 8 m 0 m a0 m 41 m 9 m 0 m 11 m 0 m
84 m 41 m 90 m 0 5 r 4 m 9 m 88 m 0 m 8 m a0 m 8 m 83 m 0 2 r 88 m 11 m a0 m notbusy
02 wcmd 1 m a7 m 0 m \ 0x1a700 
5 m 0 m 5 m 0 m 5 m 0 m 80 m 40 m 0 m 8 m 3 m c0 m 41 m a1 m 21 m 2 m 0 2 r 3 m 4 m 0 m 1 m 0 m 4 m 0 3 r 84 m 0 m 8 m 0 3 r 4
m 0 3 r 84 m 0 8 r 11 m 0 m a0 m 41 m 0 m 20 m 9 m 11 m 9 m 10 m 0 m 20 m 0 3 r 20 m 0 2 r 10 m 0 m 4 m 41 m 40 m 4 m 0 m 11 m
0 m 10 m 90 m 9 m a0 m 0 2 r 84 m 20 m 82 m 0 m 41 m 2 m 84 m 2 m 80 m 40 m 10 m 3 m 11 m 84 m 9 m 1 m 41 m 4 m 41 m 10 m 0 m
a0 m 40 m a1 m 8 m 1 m 40 m 91 m 0 m 41 m 85 m a0 m 40 m 0 3 r 2 m c0 m 0 2 r 9 m 8 m 0 m 88 2 r 40 m 0 m 8 m 21 m 8 m 0 3 r
82 m 0 3 r 84 m 2 m 8 m 0 m 2 m 20 m 0 2 r 82 m 0 5 r c0 m 0 7 r a0 m 0 7 r 82 m 0 m 84 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m
4 m 8 m 0 m 1 m 4 m 0 m 84 m 1 m 0 m 1 m 0 m c0 m 11 m 0 2 r 88 m 8 m 0 m 2 m 82 m 80 m 0 m 21 m 0 2 r 90 m 9 m 90 m 0 3 r 2 m
0 m 21 m 0 m a0 m 20 2 r 0 m 2 m 0 m 91 m 82 m 0 m 10 m 0 m 40 m 0 m 4 m 0 3 r 11 m 1 m 20 m 83 m 40 m 91 m 2 m 0 m 40 m 2 m 0
m 1 m 0 2 r 3 m 84 m 10 m 0 m 41 m 0 3 r 21 m 4 m 10 m 0 m notbusy
02 wcmd 1 m a8 m 0 m \ 0x1a800 
0 e r 80 m 0 3 r 21 m 10 m 5 m 0 3 r 10 m 0 m 41 m 0 3 r 10 m 0 9 r 3 m 0 m 41 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 3 r 20 m 0
m c0 m 0 m 8 m 0 m 84 m 9 m 82 m 4 m 40 m 0 m 1 m 3 m 0 2 r 84 m 11 m 2 m 10 m a0 m 0 m 20 m 40 m 0 2 r 84 m 0 m 10 m 5 m 0 m
8 2 r 9 m 0 m 3 m 0 m 8 m 1 m 40 m 8 m 10 m 83 m 4 m 41 m 8 m 2 m 41 m 2 m 5 m 0 m 82 m 2 m 21 m 20 m 4 m 2 m 4 m 82 m 40 3 r
0 m 1 m 0 6 r 2 m 8 m 0 2 r 20 m 0 3 r 83 m 0 m 91 m 3 m 83 m 21 m 85 m 0 m 83 m 3 m 84 m 0 2 r 3 m 82 m 21 m 40 m 82 m 1 m 82
m 8 m 80 m 9 m 11 m 0 m 40 m c0 m 0 m 8 m 10 m 0 m 8 m 0 2 r 90 m 0 7 r 20 m 0 3 r 4 m 2 m c0 m 0 2 r 82 m 41 m a0 m 0 m a0 m
88 m 8 m 20 m 88 m 40 m 88 m 40 m 4 m 2 2 r 21 m 82 m 9 m 4 m 5 m 84 m 3 m 90 m 9 m 0 m 41 m 82 m 5 m 88 m 10 m 84 m 11 m 40 m
80 m 10 2 r a0 m 41 m 8 m 10 m 83 m 3 m 85 m 10 m 91 m 40 2 r 80 m 8 m c0 m 0 m 41 m 2 m 88 m a0 m 9 m 3 m 10 m 1 m 3 m 0 m 88
m 90 m 0 3 r 84 m 0 2 r 21 m 10 m 80 m 9 m notbusy
02 wcmd 1 m a9 m 0 m \ 0x1a900 
5 m 4 m 88 m 0 m 5 m 82 m 4 m a0 m 20 m 0 m 20 m a0 m 20 m a0 m 20 m 0 7 r c1 m 3 m 20 m 4 m 20 m 4 m 20 m 84 m 0 m 8 m 0 2 r
3 m 10 m 0 m 8 m 3 m 8 m 0 c r 80 m 0 3 r 82 m 80 m 0 2 r 8 m 0 m c0 m 8 m 4 m 21 m 0 m 41 m 1 m 0 m 20 m 0 m 20 m 0 2 r 21 m
82 m 41 m 40 m 0 m c0 m 3 m 20 4 r 4 m 20 m 8 m 41 m 0 m 20 2 r 0 m 40 m a1 m 10 m 0 m 82 m 0 m 20 m 4 m 20 m 4 2 r 3 m 2 m 9
m 0 m 41 m 8 m 82 m 40 m 3 m 40 m 88 m 2 m 4 m 0 m 20 m 0 2 r 10 m 80 m 2 m 11 m 0 m 82 m 0 2 r 20 m 40 m 0 2 r 20 m 11 m 20 m
21 m 0 m 4 m 0 m 4 m 0 m 4 m 8 m 4 m 40 m 20 m 0 m 20 m c0 m 9 m 40 m 0 m 20 m 0 3 r c0 m 0 2 r 8 m 0 5 r 8 m 0 3 r 8 m 0 m 8
m 0 m 8 m 0 2 r 4 m 0 m 4 m 0 2 r 21 m 4 m 0 2 r 20 m 0 5 r 4 m 80 m 8 m 20 m 8 m 4 m 8 m 0 2 r 4 m 2 m 0 m 8 m 0 m 40 m 2 m 0
4 r c1 m 0 m 1 m 0 m 1 m 80 m 0 m 2 m 1 m 9 m 0 m 4 m 2 m 80 m a0 m 11 m a0 m 91 m 0 m c0 m 4 m 3 m 90 m 80 m 40 m 8 m 0 m 3 m
2 m 0 3 r 2 m 91 m 1 m 8 m 0 4 r 40 m 80 m 0 m notbusy
02 wcmd 1 m aa m 0 m \ 0x1aa00 
0 m 41 m 0 2 r 80 m 0 3 r 91 m a0 m 80 m 0 2 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 3 r 2 m 0 m 20 m 2 m 40 m 0 8 r 3 m 0 7 r 41 m 0
3 r 3 m 0 2 r 20 m 80 m 0 m 80 m 0 3 r 80 m 0 m 40 m 0 m 40 m 20 m 0 m 10 m 90 m 0 m 8 m 88 m 90 2 r 4 m 88 m 0 m 90 m 10 m 0
m 3 m 10 2 r 0 m 82 m 2 2 r c0 m 0 m 40 m 0 m a0 m 4 2 r 82 m 0 m 1 m 2 m 4 m 0 m 8 m 2 m c0 m 83 m 84 m 41 m 91 m 20 m 84 m 8
m 0 m c1 m a0 m 0 m 84 m 10 m 0 3 r c1 m 1 2 r 88 m 0 2 r 1 m 0 3 r c1 m 0 2 r 84 m 1 m 0 m 1 m 2 m 90 m 8 m 84 m 10 m 90 m 82
2 r 10 m 0 m 1 2 r 88 m 1 m c0 m 0 m 10 2 r 0 m 84 m 0 m 2 m 40 m 8 m 0 2 r 1 m 0 m 8 m 0 13 r 10 2 r 0 m 10 m 0 m 2 m c0 m 10
m 0 2 r 80 m 0 2 r 80 m 0 4 r 88 m 0 m 80 2 r 0 m 80 m 10 m 0 m 3 m 80 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 m 80 m 0 m 80 m 0 2
r 21 m 85 m 80 m 0 m 80 m 2 m 80 m 41 m 0 m c0 m 83 m 9 m 0 m 11 m 0 m c1 m 85 m 3 m 80 m a0 m 0 m 9 m 0 m 88 m 40 m 10 m 80 m
2 m 0 m 10 m 0 2 r notbusy
02 wcmd 1 m ab m 0 m \ 0x1ab00 
5 m c0 m 21 m 20 m 80 m 2 m 0 m 40 m 0 m 9 m 91 m 41 m 11 m 40 m 0 m 11 m 0 m 5 m 3 m 8 m 9 m 5 m 80 m 11 m 10 m 0 m 11 m 0 2
r 80 m 0 m 80 m 0 m 5 m 41 m 10 m 83 m 10 m 0 m 11 m 0 16 r 80 2 r 0 3 r 90 m 0 m 9 m 0 2 r 82 m 0 m 20 m 40 m 9 m 40 m 84 m
80 m 82 m 0 m a0 m 0 m 82 m 0 m a1 m 0 2 r 10 m 0 3 r 2 m 0 2 r 40 m 80 m 2 m 0 m 80 m 0 m 5 m 82 m 9 m 83 m 2 m 40 m 9 m 91 m
41 m 4 m 11 m 0 m 5 m 0 m 3 m 0 m 88 m c0 m 40 m 0 m 10 m 0 m 40 m 0 m 90 m 10 m 0 2 r 20 m 0 m 5 m 0 m 40 m 0 m c0 m 9 m 41 m
80 m 11 m 20 m 9 m 90 m 11 2 r c1 m 80 m 9 m 0 m 5 2 r 8 m 2 m 82 m 0 m c0 m 21 m 85 m 0 m 20 m 0 m 11 m 0 m 10 m 0 m 10 m 0 m
4 2 r 0 3 r 80 m 0 c r 80 m 0 2 r 41 m 0 m 80 m 0 2 r 90 m 0 m c0 m 9 m 10 m 21 m 8 m 20 m 89 m 0 m 91 m 11 m 90 m 11 m 82 m
10 m 8 m 0 m 20 m 0 m 21 m 0 m 5 m 40 m c0 m 1 m a0 m 88 m 4 m 1 m a0 m c0 m 2 m 10 m 11 m 88 m 20 m 0 m 20 m c1 m 0 m 90 m 1
m 0 2 r 11 m 1 m 0 2 r a0 m 0 2 r 1 m 0 m c1 m 89 m 1 m 40 m 1 m 0 3 r notbusy
02 wcmd 1 m ac m 0 m \ 0x1ac00 
c1 m 3 m 0 2 r 1 m 2 m 0 2 r 10 m 0 m c0 m 40 m 0 m c0 m 82 m 1 m 2 2 r 82 m 0 m 8 m 2 m 4 m 0 m 5 m 0 m a1 m 83 m 2 m 0 m 11
m 0 m a1 m 0 m 88 2 r 0 m 82 m 0 9 r 8 m 0 3 r 10 m 0 8 r 10 m 0 m 4 m 1 m 8 m 10 m 88 m 0 m 8 m 10 m 0 m 88 m 40 m 10 m 1 m
40 m 8 m 88 m 0 m 89 m c0 2 r 4 m 2 2 r 10 m 0 m 89 m 0 m a0 m 90 m 83 m 20 m 90 m 0 m 2 m 10 m 83 m 90 m 8 m 0 m 91 m 0 m 85
m 9 m 85 m 4 m a1 m 4 m 1 m 41 m 91 m 88 m 4 3 r 0 2 r 1 m 0 m 1 m 11 m 1 m c0 m 0 3 r 89 2 r 0 m 3 m c1 m 0 2 r 4 m 1 2 r 0 2
r 8 m 0 m c1 m 0 m 91 m 0 m 4 m 0 m 84 m 5 m 0 2 r 21 m 1 m 20 m 89 m 20 m 0 m 90 m 40 m 5 m 0 m 2 m 40 m 41 m 40 m 8 m 0 2 r
1 m 0 9 r 8 m 0 b r 4 2 r 0 m 88 m 0 m 2 m 8 2 r 9 m 0 2 r 80 3 r 9 m 0 m 3 m 5 m 0 m 8 m 80 m 2 m 80 3 r 2 m 0 m 83 m 0 m 3 m
20 2 r 9 m 5 m 0 m 80 2 r 85 m 4 m 89 m 2 m 20 m 0 m 40 m 85 m 21 m 4 m 88 m 80 m 20 m a0 m 11 m 90 m 80 m 21 m 80 m 5 m 0 m
10 3 r a0 m 41 m 82 m 0 m 41 m notbusy
02 wcmd 1 m ad m 0 m \ 0x1ad00 
3 m 10 m 5 m 2 m 84 m 90 m 0 3 r 20 m 10 m 5 m 41 m c0 m 0 m 90 m 0 m 20 m 2 m 82 m 41 m 11 m 4 m 9 m 0 m 10 m 40 m 9 m 8 m 41
m 0 m 5 m 80 m 10 m 0 m 80 2 r 88 m 0 m a0 m 0 m 10 m 40 m 10 m 9 m 4 m 0 m 5 m 9 m 0 3 r 80 m 0 11 r 80 3 r 8 m 80 m 41 m 0 m
80 2 r 0 2 r 80 m 0 m 40 m 0 3 r 8 m 0 m 80 m 0 m 80 m 0 3 r 10 m 0 3 r 9 m 0 4 r 40 m 0 m c0 m 10 m 2 m 0 m 11 m 0 m 41 m 40
m 11 m 0 m 41 m 0 m 20 m 3 m c1 m 2 m 4 m 40 m 3 m 80 m 4 m 20 m 90 m 85 m 9 m 5 m 3 m 0 m 90 m 3 m 0 2 r c1 m 3 m 21 m 2 m 20
m 0 m 2 m 3 m 40 m 11 m 10 m a0 m 41 m 0 m 8 2 r 41 m 40 m 9 m 4 m 40 m 0 m 2 2 r 0 m 10 m 0 m 80 m 0 2 r 80 m 10 2 r 0 m 10 m
0 m 40 m 0 m 11 2 r 0 m 3 m 0 m 21 m 0 d r 11 m 0 m c0 m 0 2 r 80 m 0 m c0 m 1 m 88 m 89 m 88 m 84 m 2 m 0 m 88 m c0 m 88 2 r
0 m 90 m 82 m 1 m 0 m 8 m 0 m a0 m 0 m c0 m 0 m 1 m 0 3 r 9 m 0 m 88 m 0 2 r 1 m 0 m 82 m 20 m c1 m 90 m 2 m 0 m 5 m 88 m 5 m
88 m a0 m 0 m 83 m 0 m c1 m 5 m 88 m 0 m 1 m 8 m notbusy
02 wcmd 1 m ae m 0 m \ 0x1ae00 
1 2 r c1 m c0 m 0 3 r 10 m 90 m 1 m 0 2 r c1 m 82 m 0 m 1 m 8 m 0 2 r 1 m 84 m 20 m 0 m 83 m 82 m 0 m 83 m 1 m 0 m a1 m 0 m 3
m 1 m 20 m 0 2 r 10 m 1 m 0 m a0 m 0 m 20 m 8 m 1 m 0 m a0 m 0 2 r 1 m 0 13 r 4 m 0 m 90 m 20 m 2 2 r 8 m 0 5 r b m 0 m 82 m 0
2 r 11 m 0 2 r b m 0 m 41 m 11 m 0 c r 41 m 0 7 r b m 0 2 r a m 0 3 r d0 m 0 2 r 50 m 0 m 81 m 0 2 r d0 m 0 3 r 42 m 81 m 0 2
r d0 m 0 2 r 88 m 0 e r d0 m b m 0 m 82 m 0 4 r d0 m b m 0 2 r 6 m 0 b r d0 m 0 2 r 50 m 0 5 r b m 0 f r b m 0 m 41 m 12 m 0 m
10 m 0 2 r 80 m 0 m 80 m ff m 3c m ff m aa m 0 m 8 m c8 m b m cb m 0 4 r f8 m f0 m ff m f0 m 0 8 r ff m fc m ff m fc m 0 m 50
m 55 2 r 0 6 r f0 2 r 0 2 r notbusy
02 wcmd 1 m af m 0 m \ 0x1af00 
0 m ff m 0 3 r ff m 0 2 r 3c 2 r 0 2 r f0 2 r 0 4 r f0 2 r 0 3 r ff m 38 2 r fb 2 r e8 4 r 0 5 r 2 m 0 m c2 m ff 8 r 0 18 r 20
m ef m 0 m ff m f0 m f1 m f0 m f3 m 0 3 r 10 m 80 m 0 m 80 m 0 m 3c m 0 m aa m 0 m 8 m c8 m b m cb m 0 4 r f0 2 r ff m f0 m 0
4 r 20 m 0 3 r ff m fc m ff m fc m 0 m 14 m 55 2 r 1 m 0 4 r aa m f0 m fa m 0 3 r ff m 0 3 r ff m 0 2 r 3c 2 r 0 2 r f0 2 r 0
4 r f0 2 r 0 3 r ff m 8 2 r cb 2 r 0 m ff m 0 m ff m 0 8 r ff 2 r 3c 2 r ff 2 r 8f m df m 0 18 r a0 m af m 0 m ff m f0 m b0 m
f0 m 30 m ff 4 r 0 5 r f m 0 m f m 30 m a m 30 m 0 m d7 m ff m d7 m ff m 3c m a m 3c m 0 m ff m 7f m ff m 3f m ff m c3 m ff m
c3 m be m ff m be m ff m 28 2 r 0 6 r 55 2 r notbusy
20 wcmd 1 m b0 m 0 m notbusy \ 0x1b000
02 wcmd 1 m b0 m 0 m \ 0x1b000 
55 2 r f 2 r 0 2 r ff 2 r 0 2 r 55 2 r 0 2 r ff 2 r 0 4 r ff 2 r 0 3 r ff 3 r d7 m 14 m cf m c m f m 0 m 55 2 r 0 4 r df m ff
m 8 m 0 m ff 4 r 20 m e0 m 0 1a r ff m 0 m ff m 0 m 5c m 3c m 5c 2 r ff m f0 m ff m f0 m 0 3 r 80 m 28 m 0 3 r 30 m 0 m 30 m 0
m ff 4 r 3c m 0 m 3c m 0 m 7f 2 r 3f 2 r ff m a0 m ff m af m be m ff m be m ff m 0 3 r c m 40 2 r 1 m 0 m 55 4 r f 2 r 0 6 r
55 2 r 0 d r ff 3 r d7 m 14 m cf m c m f m 0 m 55 2 r 0 4 r ff 2 r 0 2 r ff 2 r df m ff m 0 1c r fe m 4 m fc m c m 3c 4 r a5 m
10 m 4a m 8 m 5 m 0 m 4 m a1 m 85 m 61 m 4a m 2e m 5 m 1d m 0 m a0 m 0 m 61 m 0 m 6 m 0 m 1d m 0 m 1 m 5 m 61 m a m 46 m 15 m
d m 0 m a1 m 5 m 69 m 4a m e m 5 m d m 1 m a0 m 0 m 61 m notbusy
02 wcmd 1 m b1 m 0 m \ 0x1b100 
0 m 3 m 0 m 15 m 10 m 2 m 40 m e3 m 80 m 6 m 80 m 2d m b2 m 2 m 40 m e3 m 80 m 0 m 80 m 21 m 92 m 2 m 0 2 r 40 m e3 m 80 m 6 m
0 m 2d m 82 m 2 m 0 m 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 6 m 0 m d m 0 m 1 m 0 m 61 m 0 m 1 m 0 m
1 m 0 2 r 5 m 0 m a m 8 m 5 m 0 2 r a0 m 0 b r 8 m 0 10 r ac 4 r 0 5 r ff m ac m ff m 0 4 r ff m c3 m ff 3 r 7f m ff m 7d m ff
2 r 3c 2 r d3 m 13 m 70 2 r b2 4 r ff m 55 m 1e 2 r ff 4 r 7d m 55 m 3c m 0 m ba m ff m 30 m ff m 0 6 r 32 m 3e m f2 m fe m ff
2 r 0 2 r 1c m 3c m bc m 3c m 17 m 55 m 17 m 55 m 0 m c0 m 3f m ff m 0 4 r ff 4 r 55 m f m 55 2 r 4 m c m ff 2 r 0 25 r f0 m 0
m f0 m 0 6 r ac 2 r 0 4 r ff m c3 m ff 3 r 5f m ff m 55 m a0 m ff m notbusy
02 wcmd 1 m b2 m 0 m \ 0x1b200 
3c 2 r d0 m 10 m 40 2 r b2 4 r aa m 0 m 1e 2 r f5 m ff 3 r 7f m 5f m 3f m f m ba 2 r 30 2 r 0 3 r 3 m 0 m 2 2 r e m c2 m ce m
d7 m df m 14 m 10 m c m 3c m fc m 3c m 55 2 r 17 m 55 m 0 m 40 m bf m ff m 0 6 r ff m 3c m 55 m 17 m 55 2 r 0 2 r fb m f3 m 0
24 r 32 m f2 m 3e m fe m 0 4 r f0 2 r f4 m f0 m 0 8 r ff m 3c m ff m 3c m fc 2 r ff 2 r 3f m 30 m f5 2 r ff m aa m 3c m f0 m
5f 2 r 3f m 30 m a 2 r fa 2 r ff m 4f 3 r be m fe m 3c m fc m 0 2 r ff m 7f m bf m 3f m e m 3e m ce m fe m 4f m f m e m f m d5
m ff 4 r f7 m 0 m 4 m 7c 2 r 3c m 7c m 0 7 r 2 m df m ff m 10 m 0 m 7c m 3c m fc m 3c m 0 24 r 2 m c2 m e m ce m 0 6 r 4 m 0 9
r ff 2 r notbusy
02 wcmd 1 m b3 m 0 m \ 0x1b300 
ff 2 r fc 2 r ff 2 r 3f m 30 m 5 2 r 0 m aa m 3c m f0 m 50 2 r 3f m 30 2 r 3f m 30 m 3f m ff m 41 3 r aa m fa m 0 m f0 m 0 2 r
7f 2 r 3f 2 r 2 m 32 m c2 m f2 m 4f 2 r e 2 r 0 m 2a m 0 2 r ff m d7 m 0 m 14 m 2c 2 r 3c m 2c m 0 7 r 2 m 5f m ff m 50 m 0 m
2c m 3c m c m 3c m 0 1c r 20 m 0 4 r 5 m 88 m 10 m 20 m 0 m 20 m 3 m 4 m 0 3 r 84 m 0 2 r 8 m 0 2 r a0 m 3 m 0 2 r 2 m 88 m 0
m 9 m 4 m 0 2 r 3 m 0 7 r 3 m 20 m 5 m 90 m 0 m 88 m 0 m 20 m 8 m 0 5 r 3 m 0 2 r 89 m 83 m 0 2 r 4 m 9 m 0 2 r 84 m 0 m 4 m 0
m 88 m 0 m 4 m 0 2 r 10 m 20 m 0 b r 88 m 0 m 88 m 0 2 r 8 m 20 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m c0 m 0 m 20 m 8 m
0 8 r c0 m 0 m 88 m 0 m 40 m 0 2 r 4 m 0 e r 4 m 0 b r 5 m 0 3 r notbusy
02 wcmd 1 m b4 m 0 m \ 0x1b400 
0 m 21 m 0 2 r 40 m 0 b r 20 m 0 8 r 82 m 0 6 r 8 m 20 m 0 m 3 m 0 8 r 5 m 0 4 r 20 m 0 11 r 1 m 0 6 r 5 m 0 6 r 20 m 0 11 r 1
m 0 9 r 8 m 0 3 r 8 m 0 11 r 20 m 0 13 r 5 m 0 5 r 9 m 0 3 r 41 m 1 m 0 12 r 20 m 0 f r a0 m 0 f r 8 m 0 f r 20 m 0 3 r 88 m 0
3 r 10 m 0 3 r 84 m 0 m 8 m 0 5 r 4 m 0 m 8 m 0 3 r 40 m notbusy
02 wcmd 1 m b5 m 0 m \ 0x1b500 
0 m 8 m 0 m 88 m 0 m 9 m 0 5 r 82 m 0 m 40 m 0 m 40 m 0 m 8 m 0 m 10 m 0 m 8 m 0 5 r 88 m 0 m a0 m 0 3 r 8 m 0 m 84 m 4 m 40 m
0 2 r 40 m 0 4 r 84 m 0 2 r 5 m 0 2 r 84 m 0 3 r 84 m 0 m c0 m 20 m 0 2 r 8 m 0 m 88 m 0 3 r 8 m 0 3 r 11 m 0 5 r 82 m 5 m 0 2
r 82 m 0 m 90 m 0 9 r 8 m 0 m 8 m 0 3 r 82 m 0 3 r 9 m 90 m 21 m 0 m 21 m c0 m 21 m 90 m 21 m 2 m 0 2 r 8 m 0 m 9 m 8 2 r 0 m
21 m 20 m 41 m c0 m 21 m a0 m 21 m 88 m 41 m 88 m 3 m 8 2 r 5 m c1 m 20 m 21 m 82 m 0 m c0 m 8 m 82 m 21 m 2 m 0 m 2 m 3 m 82
m 0 m 2 m 0 m 2 m 41 m 0 2 r a0 m 8 m 10 m 11 m 0 2 r c0 m 2 m 82 m 21 m 2 m 88 m 0 5 r 2 m c0 m 21 m 0 2 r 20 m 0 4 r 21 m 82
m 0 m 8 m 0 3 r c0 m 5 m 90 m 0 4 r 40 m 0 m 40 m 0 m 8 m 0 c r 20 m 0 2 r 8 m 0 f r 8 m 9 m 82 m 0 m 82 m 0 5 r 4 m 41 m 88 m
20 m a0 m 40 m 8 m 3 m 90 m 0 m 82 m 41 m 0 m notbusy
02 wcmd 1 m b6 m 0 m \ 0x1b600 
0 m 84 m 0 m 4 m 0 m a0 m 9 m 88 2 r 4 m 0 m 82 m 0 2 r 41 m a0 m 0 3 r 84 m 0 m 84 m 8 m 0 m 3 m 0 6 r 84 m 0 m 8 m 0 2 r 8 m
88 m 0 m 40 m 5 m 10 m 0 2 r 10 m 82 m 3 m 0 m 10 m 2 m 0 m 84 m 5 m 0 m 5 m 8 m 5 m 0 m 8 m a0 m 41 m 0 2 r 10 m 0 2 r 21 m 8
m 9 m 0 6 r a0 m 0 m 82 m 0 7 r 2 m 0 m 2 m 0 2 r 21 m 0 2 r 82 m 0 3 r 8 m 0 9 r 9 m 88 m 0 m 88 m 0 6 r 9 m 0 8 r 84 m 0 3 r
90 m 0 m 4 m 0 3 r 4 m 11 m 8 m 40 m a0 m 9 m 40 m 0 2 r 9 m 0 4 r c0 m 0 m c0 m 0 m 82 m 0 m c0 m 0 m 4 m 0 m 90 m 0 2 r 9 m
4 m 10 m 0 m 9 m 88 m 4 m 8 m 80 m 0 2 r 82 m 0 m c0 m 0 m 82 m 0 m 4 m 0 m 4 m 0 m 40 m 0 m 82 m 0 3 r 82 m 0 m 82 m 20 m 82
m 0 m 84 m 0 m 88 m 0 m 82 m 0 m 82 m 0 2 r 4 m 82 m 0 m 82 m 0 m 82 m 0 3 r 40 m 0 m a0 m 0 3 r 40 m 0 m 82 m 3 m 82 m 0 m 82
m 0 m c0 m 0 m 82 m 0 m 8 m 0 m 8 m 2 m 82 m 8 m 0 2 r 2 m c0 m 41 m 8 m 0 2 r 4 m 20 m 0 m 82 m 40 m 0 m 40 m 90 m 0 2 r
notbusy
02 wcmd 1 m b7 m 0 m \ 0x1b700 
9 m 10 m 41 m 0 3 r 2 2 r 40 m 0 2 r 90 m 40 m 0 5 r 41 m 0 m 2 m 20 m 21 m 88 m 0 m 88 m 11 m 0 4 r 90 m 3 m 4 m 40 m 0 4 r 2
m 21 m 10 m 11 m 0 m 40 m 8 m 0 4 r 40 m 0 3 r 9 m 0 4 r 88 m 40 m 10 m 0 4 r 41 m 0 5 r 10 m 0 6 r a1 m 8 m 0 5 r 21 m 20 m 0
6 r 8 m 0 m 5 m 0 6 r 84 m 0 9 r 2 m 0 2 r c0 m 0 2 r 10 m 0 m 3 m 82 m 21 m 0 2 r 82 m 5 m 0 m 41 m 0 m 40 m 0 m 5 m 0 m 40 m
0 m 3 m 0 4 r 5 m 88 m 0 m 9 m 0 2 r 8 m 0 m 82 m 2 m 0 2 r 8 2 r 0 2 r 8 m 41 m 10 m 8 m 0 m 21 m c0 m 0 7 r a0 m 3 m 9 m 40
m 0 5 r 5 m 0 2 r a0 m 0 m 88 m 0 m 90 m 0 m c0 m 0 m 84 m 21 m 0 4 r c0 m 3 m 0 5 r 40 m 0 m 2 m 0 8 r 8 m 0 m 82 m 0 3 r 84
m 0 2 r 21 m 0 f r 10 m 2 m 0 m 20 m 88 m 20 m 2 2 r c0 m 40 m 10 m 40 m 4 m 40 m 4 m notbusy
02 wcmd 1 m b8 m 0 m \ 0x1b800 
3 m 10 m 9 m 0 m 21 m 0 m 41 m 2 m 0 3 r 4 m 0 m 10 m 21 m 2 m 88 m 20 m 0 m 88 m 0 m 84 m 41 m 84 m 11 m 0 m 3 m 40 m 0 m 88
m 21 m 2 m 8 3 r 0 m 21 m 0 2 r 88 m 0 m 10 m 11 m 0 2 r 88 m 5 m 2 m a0 m 8 m 0 2 r 9 m 0 m 8 m 0 m 9 m 0 m 11 m 2 m 0 m 8 m
21 m 0 3 r 8 m a0 m 0 4 r 8 m 88 m 11 m 88 m 3 m 0 5 r 8 2 r 0 4 r 10 m 0 m 21 m 0 2 r 90 m 0 10 r 20 m 0 2 r 2 m 0 m 9 m 0 7
r 5 m 2 m 0 m 90 m 21 m 0 2 r 8 m 21 m 0 4 r 90 m 8 m 88 m 41 m 2 m 40 m 0 m 41 m 0 m 5 m 1 m a0 m 88 m 0 3 r 4 m 3 m 0 2 r a0
m 0 m c0 m 21 m 40 m 4 m 0 3 r 3 m 90 m 9 m 88 m 41 m 0 m 3 m 0 m 20 m 0 3 r 5 m 2 m 40 m 0 2 r 40 m 0 m 88 m 0 m 40 m 8 m 10
m 0 m 82 m 0 m 4 m 21 m 0 2 r 8 m 11 m 0 7 r 3 m 0 2 r c0 m 0 2 r 9 m 8 m 0 3 r a0 m 0 m 8 m 0 m 82 m 0 m 8 m 0 m 8 m 0 m c0 m
0 9 r 90 m 0 m 10 m 0 m 82 m 0 4 r 8 m 0 4 r 8 m 0 m 20 m 8 m 0 m 2 m notbusy
02 wcmd 1 m b9 m 0 m \ 0x1b900 
0 3 r 8 3 r 0 2 r 3 m 84 m 41 m 0 m 9 m 84 m 20 m 0 2 r c0 m 0 m 90 m 4 m 11 m 0 m 10 m 20 m 88 m 41 m 4 m 0 2 r 9 m 0 5 r 8 m
0 3 r 40 m 0 m 20 m 0 5 r 3 m 0 2 r 2 m 40 m 10 m 0 6 r 41 m 0 2 r 90 m 0 m 2 m 0 4 r 21 m 90 m 0 7 r 20 m 3 m 0 5 r 80 m 8 2
r 0 d r 2 m 0 2 r 90 m 0 m 88 m 0 b r 8 m 1 m 0 6 r 1 2 r 0 6 r 88 m 0 2 r c0 m 0 2 r c0 m 0 m 82 m 0 2 r c0 m 0 2 r 1 m 0 2 r
1 m 0 6 r 1 2 r 0 6 r 4 m 0 2 r c0 m 0 2 r c0 m 0 m 82 m 0 2 r c0 m 0 2 r 1 m 0 4 r 1 m 0 6 r 1 2 r 0 5 r 1 m 88 m 0 2 r c1 m
0 2 r c0 m 0 m 82 m 0 2 r c0 m 0 2 r 1 m 0 2 r 1 m 0 6 r 1 2 r 0 6 r 90 m 0 2 r c0 m 0 2 r c0 m 0 m 82 m 0 2 r c0 m 0 2 r 1 m
0 2 r 41 m 0 4 r 41 m notbusy
02 wcmd 1 m ba m 0 m \ 0x1ba00 
0 m 8 m 41 m 0 4 r 9 m 11 m 0 m 9 m 5 m 84 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 2 r 3 m 0 2 r 41 m 0 4 r 41 m 0 m 8 m 41 m 0 4 r
9 m 11 m 0 m 40 m 9 m c0 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 2 r 3 m 0 4 r 41 m 0 4 r 41 m 0 m 10 m 41 m 0 4 r 5 m 41 m 0 2 r 5
m 82 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 2 r 3 m 0 2 r 41 m 0 4 r 41 m 0 m 10 m 41 m 0 4 r 5 2 r 0 2 r 5 m 88 m 0 2 r 80 m 0 m
80 m 0 2 r 80 m 0 2 r 3 m 0 4 r 9 m 0 7 r 88 m 0 3 r 2 m 0 m 3 m 0 m 91 m 0 2 r 80 m 3 m 0 6 r 80 2 r 5 m 0 2 r 8 m 0 7 r c1 m
0 2 r 10 m 2 m 0 m 83 m 0 m 83 m 0 3 r 3 m 80 m 0 5 r 80 2 r 3 m 0 4 r 8 m 0 7 r 82 m 0 3 r 2 m 0 m 40 m 0 m 3 m 80 m 0 m 80 m
3 m 0 6 r 80 2 r 40 m 0 2 r 5 m 0 7 r c0 m 0 3 r 8 m 0 m 40 m 0 m 2 m 80 m 0 m 80 m 3 m 0 6 r 80 2 r 2 m 0 2 r notbusy
02 wcmd 1 m bb m 0 m \ 0x1bb00 
0 8 r 21 m 0 5 r 2 m 0 m 20 m 2 m 0 m 84 m 1 m 84 m 2 m 0 4 r c0 m 82 m 0 3 r 1 m 0 7 r 20 m 0 5 r 4 m 0 m 21 m 4 m 0 m c0 m 1
m 8 m 90 m 0 4 r c0 m 82 m 0 5 r 1 m 0 7 r 21 m 0 5 r 82 m 0 m 90 m 4 m 0 m 84 m 1 m 40 m 90 m 0 4 r c0 m 82 m 1 m 0 a r 20 m
0 3 r 1 m 0 m 20 m 0 m 91 m 4 m 0 m 4 m 1 m 0 m 40 m 0 4 r c0 m 82 m 1 m 0 d r 1 m 90 m 20 m 0 m 20 m 0 2 r c0 m 0 m 1 m 0 16
r 1 m 83 m 20 m 0 m 90 m 0 2 r c0 m 0 1b r 2 m 8 m 0 m 40 m 0 2 r 2 m 0 19 r 83 m 21 m 0 m 2 m 0 c r notbusy
02 wcmd 1 m bc m 0 m \ 0x1bc00 
0 f r 40 m 0 m 11 m 0 6 r 41 m 0 6 r 41 m 0 f r 40 m 88 m 9 m 0 d r 41 m 0 11 r 40 m 80 m 91 m 0 m 80 m 0 2 r 80 m 0 8 r 41 m
0 f r 40 m 20 m 8 m 0 m 80 m 0 b r 41 m 0 4 r 80 m 0 2 r 91 m 0 5 r 4 m 3 m 0 4 r c1 m 80 m 0 2 r 2 m 0 3 r 41 m 0 m 4 m 0 3 r
3 m 0 m 8 m 80 m 0 2 r c1 m 0 3 r 8 m 0 m 21 m 5 m 0 4 r c1 m 0 3 r 2 m 0 3 r 41 m 0 5 r 10 m 0 3 r 8 m 80 m 0 2 r 8 m 0 3 r 5
m 80 m 0 m 10 m 0 4 r 41 m 0 3 r 9 m 0 3 r 41 m 0 5 r 40 m 0 2 r 80 m 5 m 0 m 83 m 0 3 r 10 m 80 m 0 m 41 m 0 4 r 41 m 0 3 r 3
m 0 3 r 41 m notbusy
02 wcmd 1 m bd m 0 m \ 0x1bd00 
0 5 r 5 m 0 2 r 8 m 0 2 r 10 m 0 4 r c0 m 0 m 89 m 0 4 r 41 m 82 m 0 6 r 1 m 0 5 r 1 m 0 m 1 m 20 m 0 2 r 40 m 0 3 r 1 m c0 m
0 m 89 m 0 4 r 41 m a0 m 0 6 r 1 m 0 5 r 1 m 0 3 r 1 m 20 m 0 2 r 89 m 0 4 r 20 m 0 m 83 m 0 4 r 41 m 40 m 0 6 r 1 m 0 5 r 1 m
0 2 r 4 m 0 2 r 83 m 0 3 r 1 m 82 m 0 m 82 m 0 4 r 41 m 40 m 0 6 r 1 m 0 c r 48 m 0 7 r 48 m 0 m 81 m 12 m 0 m d0 m b m 0 m 48
m 82 m 0 6 r 48 m 42 m 0 6 r 48 m 0 7 r 48 m 0 m 81 m 12 m 0 m d0 m b m 0 m 48 m 0 7 r 48 m 42 m 0 8 r 48 m 0 7 r 48 m 82 m 81
m 12 m 0 m d0 m b m 0 m 48 m 0 7 r 48 m 42 m 0 6 r 48 m 0 7 r 48 m 0 m 81 m 12 m 0 m d0 m b m 0 m notbusy
02 wcmd 1 m be m 0 m \ 0x1be00 
48 m 0 7 r 48 m 42 m ff 82 r 0 m e m e6 m ac m 30 m 22 m 1 m e m 0 m 17 m 50 m 60 m 0 2 r 6 m 9a m 75 m 7b m 0 1c r de m ae m
75 m 7b m 0 1c r de m ae m 0 2 r 75 m 7b m 0 1c r de m ae m 75 m 7b m notbusy
02 wcmd 1 m bf m 0 m \ 0x1bf00 
0 1c r de m ae m 60 m c6 m 3 m 40 m 0 6 r 2 m 31 m e0 m 0 7 r c m 40 m 0 6 r 2 m c0 m 63 m 6 m 60 m c6 m 3 m 40 m 0 6 r 2 m 31
m e0 m 0 7 r c m 40 m 0 6 r 2 m c0 m 63 m 6 m 0 2 r 60 m c6 m 3 m 40 m 0 6 r 2 m 31 m e0 m 0 7 r c m 40 m 0 6 r 2 m c0 m 63 m
6 m 60 m c6 m 3 m 40 m 0 6 r 2 m 31 m e0 m 0 7 r c m 40 m 0 6 r 2 m c0 m 63 m 6 m 1 m 80 m 1 m 0 3 r 84 m 0 2 r 10 m 1 m 8 m
82 m 0 m 9 m 0 3 r 82 m 80 m 83 m 0 m 4 m 5 m 4 m 2 m 4 m 80 m 1 m 0 m 20 m 84 2 r 0 2 r 8 m 88 m 80 m 4 m 0 2 r 88 m 1 m 0 m
20 m 0 m 84 m 2 m 84 m 5 m 1 m 0 3 r 2 m 0 m 20 m 0 m 20 m 0 3 r 20 m 2 m 0 2 r 88 m 80 m 0 m 8 m 88 m a0 m 84 m 80 m 8 m 20 m
0 2 r 20 m 10 m 0 m 10 m 88 m 0 6 r 8 m 20 m 80 m 20 m 80 m 0 m 8 m notbusy
20 wcmd 1 m c0 m 0 m notbusy \ 0x1c000
02 wcmd 1 m c0 m 0 m \ 0x1c000 
0 m 10 m c0 m 0 3 r 20 m 0 m 90 m 20 m 88 m 80 m 0 m 20 m 40 m 0 m 4 m 20 2 r 0 m 88 m 0 4 r 5 m 20 m 0 m 20 m 0 5 r 8 m 40 m
8 m 0 7 r 8 m 0 3 r 88 m 0 4 r 10 m 40 m 0 4 r 1 m 0 m 20 m 40 m 0 2 r 10 m 0 2 r 2 m 0 2 r 10 m 0 3 r 10 m 8 m 0 4 r 1 m 5 m
0 m 2 m a0 m 0 6 r 5 m 0 4 r 1 m 0 m 3 m 0 m 10 m 0 3 r 3 m 0 m 10 m 80 m 1 m 0 3 r 1 m 0 6 r 5 m 0 m 9 m 0 2 r 10 m 5 m 10 m
0 3 r 1 m 0 7 r 1 m 20 2 r 0 m 1 m 0 3 r 1 m 0 7 r 84 m 5 m 0 c r 4 m 0 f r 20 m 0 8 r 1 m 40 m 0 3 r 41 m 0 m 41 m 0 5 r 88 m
0 m 21 m 0 5 r 80 m 0 2 r 1 m 0 4 r 11 m 0 m 10 m 0 7 r 80 m 0 m 8 m 0 m 82 m 0 m 88 m 0 m 80 m 1 m 0 d r notbusy
02 wcmd 1 m c1 m 0 m \ 0x1c100 
0 b r 40 m 0 7 r 8 m 0 9 r 88 m 0 9 r 8 m 0 3 r 8 m 0 m 8 m 0 m 84 m 0 4 r 20 m 0 6 r 1 m 0 m 10 m 0 m 40 m 0 m 10 m 0 m 10 m
40 m 0 m 11 m 84 m 0 m 10 m 0 m 8 m 0 m 90 m 0 m 84 m 0 m 10 m 0 2 r 20 m 10 m 0 3 r 40 m 0 2 r 2 m 8 m 0 7 r 84 m 0 3 r 10 m
0 m 40 m 4 m 84 m 0 m 21 m 0 m 10 m 0 m 10 m 8 m 0 2 r 4 m 0 5 r 84 m 0 m 4 m 0 6 r 20 m 0 4 r 10 m 0 m 82 m 0 m 8 m 0 m 8 m 0
2 r 20 m 40 m 0 m 8 m 0 6 r 9 m 4 m 0 5 r 8 m 0 m 8 m 0 2 r 20 m 10 m 8 2 r 20 m 21 m 2 m 0 m 91 m 85 m 88 m 83 m 8 m 0 2 r 5
m 0 m 5 m 84 m 0 m 8 m 20 m 10 m 5 m 0 2 r 40 m 80 m 4 m 8 m 40 m 0 2 r 9 m 0 m 80 m 0 m 90 m 0 m 3 m 0 4 r a0 m 0 2 r 40 m c0
m 80 m 0 m 85 m 0 m 10 m 0 m 21 m 0 3 r 21 m 0 4 r 4 m 3 m 4 m 0 m a0 m 5 m 91 m 8 m 0 m 2 m 40 m 80 m 0 m 82 m 1 m 8 m 0 5 r
5 m notbusy
02 wcmd 1 m c2 m 0 m \ 0x1c200 
0 m 41 m 0 7 r 8 m 0 5 r 20 m 0 m 8 m 0 5 r 80 m 0 3 r 20 m 40 m a0 m 20 m 0 2 r 5 m 0 m 20 m 0 2 r c0 m 20 m 0 m 5 m 0 m a0 m
0 2 r 80 m 0 m 2 m 0 m 21 m 8 2 r 40 m 0 m 10 m 80 m 0 4 r 82 m 0 2 r 80 m a1 m 80 m 84 m 0 2 r 80 m 20 m 80 m 0 m 80 m 0 2 r
10 m 0 m 2 2 r 10 m 0 5 r 88 m 0 m 8 m 0 m 1 m 0 m 40 m 20 2 r 3 m c0 m 0 7 r 84 m 0 2 r 85 m 0 m 85 m 8 m 5 m 82 m 8 m 84 m 0
3 r 40 m 0 m 20 m 8 m 2 m 0 14 r 41 m 3 m 20 m 0 m 21 m 0 4 r 20 m 0 2 r 3 m a1 m 80 m 3 m 80 m 0 4 r 1 m 0 3 r 1 m 0 2 r 20 m
0 m 20 m 0 3 r 1 m 0 3 r 40 m 0 3 r 88 m 0 m 82 m 80 m 0 2 r 90 m 0 3 r 10 m 80 m 0 m 80 m a0 m 0 m 4 m 0 m a0 m 0 m a0 m 0 m
40 m 0 m 8 m 2 m c0 m 0 m a0 m 0 m 20 m 0 3 r 8 m 0 m 8 m 0 m 8 m 0 m 8 m 0 m 90 m 0 3 r a0 m 0 m 20 m 0 3 r 8 m 0 m a0 m 0 m
a0 m 0 m a0 m 0 5 r 82 m 0 m 8 m 80 m 8 m 0 m notbusy
02 wcmd 1 m c3 m 0 m \ 0x1c300 
4 m 0 m 82 m 0 m 20 m 0 m c0 m 0 m 20 m 0 5 r a0 m 0 m 82 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 1 m 0 m 41 m 0
m a1 m 0 m 83 m 0 3 r 84 m 80 m a0 m 0 m 4 m 0 5 r 20 m 0 m 8 m 4 m 0 8 r 40 m 20 m 11 m 0 2 r 4 m 0 m 8 m 89 m 2 m 0 m 40 m 4
m 90 m 0 m 88 m 0 3 r 2 m 80 m 0 2 r 21 m 0 m 84 m 0 2 r 11 m 88 m 0 m 84 m 83 m 0 m 3 m 0 m 80 m 0 m 3 m 0 2 r 4 m 0 5 r 4 m
0 2 r 20 m 90 m 41 m c0 m 8 m a0 m 41 m a0 m 0 5 r 8 m 0 m 20 m 0 m 90 m 0 4 r 4 m c0 m 0 m 90 m 0 6 r 8 m 0 3 r 83 m 0 m 3 m
0 m 80 m 0 m 80 m 0 m c1 m 0 m 80 m 0 m 4 m 0 m c0 m 0 m 4 m 0 m 4 m 0 2 r 82 m 0 m 20 m 21 m 0 m 80 m 82 m 0 2 r 20 m 0 3 r 9
m 80 m 0 m 40 m 0 2 r c0 m 11 m 8 m 2 m 0 m 41 m 0 m 20 m 0 2 r 91 m 11 2 r 20 m 1 m 0 2 r 10 m 1 m 10 m 0 2 r a0 m 0 4 r 11 m
0 4 r 40 m 0 2 r 5 m 0 m 80 m 0 2 r 4 m 0 2 r 83 m 82 m 0 m c0 m 0 m a0 m 3 m 0 3 r 1 m 82 m 0 2 r 85 m 0 3 r 80 m 0 m 82 m 40
m a0 m 1 m 9 m notbusy
02 wcmd 1 m c4 m 0 m \ 0x1c400 
0 m 82 m 0 2 r 82 m 0 m 82 m 0 m 82 m 0 5 r c0 m 0 m 82 m 0 m a0 m 0 m c0 m 0 3 r 82 m 0 3 r a0 m 0 3 r a0 m 0 3 r 4 m 0 2 r 4
m 82 m 21 m 4 m 0 2 r 11 m 0 5 r 8 m 0 3 r 8 m 40 m 10 m 0 m 10 m 0 m 84 m 2 m 88 m 0 m 8 m 21 m 0 2 r 1 m 0 2 r 40 m 10 m 90
m 1 m 40 m 0 3 r 40 m 84 m 0 m a0 m 0 m 8 m 0 3 r a0 m 0 m 8 m 0 m 8 m 80 m 84 m 0 m 10 m 0 m 10 m 0 2 r 80 m 0 m 21 m 20 m 0
5 r a0 m 21 m 0 5 r 21 m 40 m 3 m 0 m 8 m 10 m 0 m 40 m 0 m 11 m 2 m 0 m 8 m 10 m 3 m 84 m 0 5 r a0 m 0 6 r 21 m 0 5 r 8 m 0 3
r 8 m 88 m 0 2 r 10 m 0 2 r 88 m 8 m 0 m 80 m 0 2 r 1 m 0 2 r 80 m 0 7 r 88 m 11 m 0 m 8 m 0 2 r 20 m 10 m 20 m 11 m 0 m 41 m
40 m 9 m 0 2 r 2 m 0 2 r 8 m 20 m 0 m 2 m 0 m 88 m 11 m 20 m 4 m 40 2 r 20 m 9 m a0 m 8 m 20 m 40 m 0 m 8 3 r 20 m 21 m 0 m 4
m 90 m 0 m 40 m 84 m 0 m 4 2 r 20 m 8 2 r 2 m 21 m 20 m 11 m 4 m 40 m 4 m 9 m 4 m 0 3 r a0 m 0 m 90 m 0 3 r a0 m 2 m 0 m 4 m
notbusy
02 wcmd 1 m c5 m 0 m \ 0x1c500 
0 m 10 m 0 m 4 m 0 m 21 m 0 6 r 8 m 0 m 4 m 11 m 20 m 0 2 r 8 m 0 2 r 82 m 0 m 82 m 20 m 82 m 0 m 4 m 9 m 0 m 3 m 0 2 r 90 m 9
m 0 m 41 m 0 2 r 88 m 0 m 88 m 0 m 82 m 0 m 88 m 11 m 1 m 0 m 4 m 0 2 r 20 m 0 a r 2 m 0 m 2 m 0 4 r 82 m 0 m 4 m 11 m 40 m 20
m 0 3 r 20 m 40 m 11 m 40 m 21 m 4 m 21 m 0 m 9 m 88 m 0 2 r 8 m 20 m 0 5 r 2 m 3 m 2 m 20 m 0 2 r c0 m 8 m 2 m 0 m 4 m 0 2 r
3 m 0 9 r 21 m 20 m 0 3 r 1 m 0 6 r 21 m 0 d r 4 m 0 9 r 88 m 0 5 r 4 m 20 m 40 m 0 5 r 21 m 0 m 40 m 0 m 41 m 0 m 4 m 0 m 80
m 0 2 r 1 m 2 m 10 m 1 m 2 m 10 2 r 82 m 4 m 1 m 2 m 0 m 88 m 0 m 88 m 0 m 4 m a0 m 40 m 2 m 8 m 2 m 84 m 0 m 88 m 1 2 r 0 m 1
m a0 m 0 2 r 1 m 8 m 10 m a0 m 89 m 2 m 83 m c0 m 10 m 2 m a0 m 5 m 4 m 82 2 r 88 m 84 m a0 m 4 m 8 m 90 m 0 m 4 m 82 m 2 m 0
4 r 84 m 0 8 r 1 m 4 m 0 m notbusy
02 wcmd 1 m c6 m 0 m \ 0x1c600 
0 2 r c0 m 88 m 82 m 10 m 0 m 84 m 82 m 2 m 0 8 r c1 m a0 m 0 m 20 m 0 m 88 m 0 m 20 m 8 m 0 5 r 8 m 0 m 40 m 82 m 40 2 r 0 m
10 m 82 m 2 m 11 m 2 m a1 m 2 m 85 m 2 m 40 m 10 m c0 m 8 m 0 m 40 m 0 m 8 m c0 m 4 m 0 2 r 20 m 0 m 80 m 0 2 r 80 m 10 m 80 m
0 3 r 80 m 0 m 80 2 r 0 m 10 m 80 m 89 m 0 3 r 40 m 3 m 21 m 4 m 0 m 5 m 0 m 4 m 0 m 5 m 10 m 8 m 0 m 88 m 0 m 3 m 80 2 r c1 m
0 2 r 80 m 0 2 r 80 3 r 0 2 r 80 2 r 0 2 r 40 m 0 m 5 m 0 m 5 m 0 5 r 20 m 3 m 10 m 80 m 20 m 0 m 9 m 0 6 r 80 2 r 0 8 r 89 m
80 m 0 m 80 m 0 4 r 80 m 0 5 r 80 m 0 7 r 80 m 0 m c1 m 0 m a1 m 0 m c0 m 80 m 0 m 80 m 40 m 80 m 0 3 r 80 4 r 0 2 r 9 m 80 m
0 3 r 80 m 0 m 80 m 21 m 80 2 r 0 2 r 10 m 0 m 40 m 9 m 85 m 0 m 88 m 0 m 90 m 80 m 9 m 11 m 85 m 2 m c1 m 20 m 85 m 0 m a0 m
0 m 85 m 0 m 82 m 0 3 r 9 m 4 m c0 m 0 3 r 80 m 0 4 r 80 m 0 c r 90 m 0 m notbusy
02 wcmd 1 m c7 m 0 m \ 0x1c700 
a1 m 80 m 10 m 0 m 40 2 r 0 2 r 80 m 41 m 0 m 40 m 0 a r 80 m 0 m 80 m 10 m 0 m 21 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m
0 3 r 80 m 11 m 80 2 r 0 2 r 3 m 0 m 2 m 10 m 90 m 0 m 3 m 80 2 r 0 2 r 40 m 80 3 r 0 m 88 m 0 3 r 8 m 4 m 0 2 r 10 m 0 m 10 m
0 m a0 m 10 2 r 0 m 10 m 0 m a1 m 40 m a0 m 84 m 83 m 82 m 4 m 40 2 r 2 m 88 m 89 m 5 m 40 m 8 m 0 m 11 m 0 m 4 m 0 m 9 m 0 3
r 10 m 0 m a0 m 82 m 0 2 r a0 m 0 m a0 m 0 m 84 m 8 m 2 m 0 b r 3 m 0 m 11 m 8 m 84 m 0 m 82 m 4 m 10 m 0 m 4 m 1 m 84 m 85 m
82 m 0 9 r 2 m 0 m 40 m 1 m 40 m 1 m 8 m 0 m 8 m 0 m 4 m 0 m 84 m 0 m 8 m 40 m 2 m 0 m 10 m 0 m 82 2 r 88 m 0 m 2 m 0 m 2 m 0
m 40 2 r 3 m 90 m 8 m 0 m c0 m 1 m 2 m 40 m 8 m 2 m 4 m 11 m 0 4 r a1 m 11 m 20 m 10 m 0 m 10 m 0 2 r a0 m 0 m c1 m c0 m 0 m
a0 m 82 m 4 m c0 m 90 m 1 2 r 0 2 r 8 m 0 m 1 2 r 0 m a0 m 1 m 4 m 1 m 85 m 82 m a0 m 10 m 40 m 0 m 82 m a0 2 r 4 m a1 m 8 m
a0 m 0 m 10 m 0 m 2 m 88 m 40 m 0 m 1 m 0 2 r 1 m 0 2 r 1 m notbusy
02 wcmd 1 m c8 m 0 m \ 0x1c800 
0 3 r 1 2 r 0 m 2 m 0 3 r 4 m 88 m 0 m 20 m 0 m 2 2 r 10 m 0 8 r 90 m 10 m 0 m 20 m 0 m 40 m 4 m c0 m 0 m 2 m 0 m 4 m 0 m 84 m
0 m 2 m c0 m 10 m 0 m 2 m 0 m 2 m 4 2 r 8 m 2 m 0 m 20 m 90 m 10 m 3 m 2 m c0 m 8 m 0 m 2 m 0 m 40 m 8 2 r 0 m 88 m 0 m 3 m 0
2 r a1 m 8 m 0 6 r 80 m 0 m a0 m 3 m 0 m a0 m 0 2 r 89 m 20 m 4 m 9 m 0 m 10 m c1 m 10 m 40 2 r 0 m 4 m 20 m 9 m 5 m 40 m 83 m
80 m 0 m 5 m 0 m c1 m 80 m 82 m 90 m 20 m 80 m 0 8 r 21 m 8 m 40 m 2 m 40 m 0 m 40 m 0 2 r 9 m 4 m 8 m 5 m 0 m 3 m 11 m 5 m 80
m 0 4 r 80 m c0 m 0 c r 80 m 0 3 r 80 m 0 3 r 80 m 0 m 80 m 40 m 80 3 r 0 m 80 m 0 4 r 80 m 2 m 0 m 90 m 80 m 20 m 11 m 10 m 0
m 80 m 0 m 80 m 0 2 r 82 m 80 m 0 m 9 m 0 m 80 2 r 0 4 r 10 m 0 m 80 m 0 4 r 80 m 89 m 80 2 r 0 2 r 80 m 9 m 21 m 9 m 83 m 2 m
10 m 0 m 10 m 40 m 0 m 5 m 0 m 84 m 0 m 80 m 0 m 5 m 80 m 0 m 80 m 0 3 r 80 m 0 2 r 4 m 80 m 0 m 80 m 0 7 r notbusy
02 wcmd 1 m c9 m 0 m \ 0x1c900 
0 6 r 10 m 21 2 r 82 m 8 m 80 m c0 m 20 m 0 2 r 80 m 0 m 80 2 r 0 b r 3 m 80 m 0 6 r 2 m 0 m 41 m 0 m 80 m 0 4 r 80 m a0 m 80
2 r 0 3 r 89 m 80 m 40 m 0 m 80 m 2 m 10 m 80 m 0 m 80 m 85 m 80 m 0 m 80 m 0 m 4 m 0 m a0 m 20 m 84 m 88 m 4 m 0 m 88 m 1 m
c0 m 20 m 0 m 88 m 2 m 0 m 10 m 8 m 82 m 20 m c0 m 88 m 10 m 0 m c1 m 1 m 3 m 1 m 10 m a0 m 4 m 0 2 r 84 m 0 m a1 m 0 m 40 m 0
2 r 4 m 90 m 88 m 0 m 40 m 2 m 4 m 0 3 r a0 m 10 m 4 m 88 m 2 m 0 b r 41 m 21 m 90 m 11 m 82 m 84 m a0 m 0 m 88 m 0 m 82 m a0
m 2 2 r 88 m 0 b r 8 m 0 m 10 m a0 m 0 3 r 1 m 0 m 3 m 0 m 40 m 0 2 r 2 m 0 m 2 m 3 m 2 m 4 2 r 0 m 2 m 40 m 20 m 3 m 40 2 r 2
m 0 m 8 m 0 m 2 m 82 m 10 m 40 m 8 m 0 15 r 41 m 0 m 42 m a m 0 4 r b m 0 11 r 84 m 0 2 r 81 m 0 2 r b m 0 3 r notbusy
02 wcmd 1 m ca m 0 m \ 0x1ca00 
0 e r b m 0 4 r 11 m 0 2 r b m 0 m 41 m 0 f r 60 m 0 5 r b m 0 m 42 m 0 5 r b m 0 m 60 m 0 4 r d0 m b m 0 m 84 m 0 5 r b m 0 2
r 41 m ff m fe m ff m f2 m ff 5 r 0 m 3c 2 r fc 4 r f9 m 60 m f9 m 60 m cf m 18 m cf m db m 3 m 0 m 9 m 0 9 r ff 4 r 0 3 r 10
m 78 2 r ff m 99 m ff m 1 m ff m 1 m ff m 6e m ff m c m 0 a r f3 3 r 30 m 0 4 r f4 2 r ff m f4 m ff m e3 3 r 0 8 r ff 4 r 66 m
f0 m 3c m 0 5 r 7f m ff m 10 m 0 m f0 4 r e6 m 26 m e7 m 24 m e6 m e7 m 66 4 r 7e m 42 m e4 m 66 3 r ff m 0 m ff m 38 m ff m 0
m ff m 0 m ff 2 r 7e 2 r 66 2 r 0 2 r fc 4 r 7e 2 r 18 2 r cf m 18 m cf m db m 0 2 r 9 m 0 9 r ff 2 r e6 m 66 m 20 2 r 0 m 10
m 78 2 r 66 m 0 m ff m 1 m ff m 1 m notbusy
02 wcmd 1 m cb m 0 m \ 0x1cb00 
6e 2 r c 2 r 0 a r f3 3 r 30 m 0 4 r 24 2 r ff m 24 m ff m 60 3 r 0 8 r f0 m ff m f0 m ff m 66 m f0 m 3c m 0 5 r 7f 2 r 10 2 r
f6 m f2 m 90 m b0 m 66 4 r 26 m 24 m 66 4 r 6e m 62 m e4 2 r 66 2 r ff m 0 m c7 m 0 m ff 82 r 0 m 7 m 2c m 85 m 30 m 22 m 1 m
f m 0 m 18 m 50 m 60 m 0 2 r a m 28 m 0 m 7e m 0 m 7f m 0 4 r c 4 r 0 4 r 6f m 30 m 6f m 3f m 2 m 0 7 r 3f m ff 3 r notbusy
02 wcmd 1 m cc m 0 m \ 0x1cc00 
ff m df m ff 2 r c 4 r 0 2 r f 2 r ff m f m ff m f m 0 3 r 1 m 3c m bd m 3f m bf m 0 12 r ff 2 r 6 m 3e m f m 6f m cf m ef m 0
9 r 30 m 0 2 r f 4 r 0 4 r fe 2 r ff m fe m 0 m 3 m ff m 3f m ff m 3f m ff m bf m f 3 r 1e m 0 m fd m 2 m ff m 0 m ff m 8 m ef
2 r e7 m ff 2 r 0 m 66 m 0 m 67 m ff m 42 m ff m 42 m 6e m c 3 r 80 m 0 3 r 60 m 30 m 60 m 3f m 0 8 r 3f m ff m 3f m ff 2 r df
m ff 2 r c 3 r 9d m 20 m 0 m 2f m f m ff 4 r 0 5 r 99 m f m 9f m 0 f r 2 m 0 2 r 6 m 3e m 6 m 3e m 0 m 66 m c3 m e7 m 0 8 r 8
4 r 0 m 3c m ff m 3c m 0 4 r 2 2 r 0 m 2 m 0 m 1 m ff m 7f m 0 m 30 m 0 m 20 m f 2 r 1e 2 r 0 m fc m 3 m ff m 0 m ff m 9 m 6f
m 20 m 24 m 0 3 r 61 m 0 m 6 m 0 m 1d m 0 2 r 80 m 0 6 r 1 m 5 m 61 m a m 46 m 15 m d m 0 m a0 m 85 m 71 m a m e m notbusy
02 wcmd 1 m cd m 0 m \ 0x1cd00 
5 m d m 4 m a1 m 0 m 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 6 m 0 m d m 0 m 1 m 0 2 r 40 m 20 m 0 m 10 m 0 m 1 m 0 m 61 m 0 m 6 m
0 m d m 0 4 r 5 m 69 m a m e m 5 m d m 4 m a1 m 80 m 0 2 r 20 m 0 m 10 m 0 m 1 m 0 d r 90 m 0 5 r 8 m 0 7 r 8 m 0 5 r 61 m 0 m
f m 0 m 1 m 0 5 r 8 m 0 8 r 30 2 r be 2 r 0 c r a0 2 r 3f 2 r bf 2 r ff m bf m 28 m 0 m a0 m 0 d r df m be m ff m bf m 0 c r
ac 2 r 0 m ff m 0 2 r 3f m 3c m f m 0 2 r f0 m ff m f0 m 0 28 r 3c 4 r 0 m ff m 0 m ff m 0 c r 30 2 r 82 2 r 0 c r a0 2 r 30 2
r notbusy
02 wcmd 1 m ce m 0 m \ 0x1ce00 
bf m ff 3 r 0 m 14 m 0 m 50 m 0 4 r 1 m 0 m 1 m 0 5 r df m ff 2 r bf m 0 c r ac 2 r 0 m ff m 0 2 r f m 0 m f m 0 m 3c m aa m
3c m aa m 0 28 r 3c 4 r 8 m fb m 28 m eb m 0 1c r ff 2 r fc m ff 2 r fc m ff m c m aa m f0 m 3c m f0 m 0 c r ff m f0 m ff m f0
m 0 8 r ff 2 r 5f m 50 m 0 7 r c m 50 m 0 m f0 4 r 0 2c r fc m bc m 3c 2 r 0 1c r notbusy
02 wcmd 1 m cf m 0 m \ 0x1cf00 
ff 2 r 7f m ff m 0 m fc m 0 m c m aa m f0 m 3c m f0 m 0 m 10 m 20 m 0 3 r 8c m 0 6 r f0 m 0 m f0 m 0 a r 5f m 50 m 0 7 r c m
50 m 0 3 r 14 m be m 0 2c r c m 1c m 3c 2 r 0 e r 84 m 0 2 r c0 m 2 m 40 m 4 m 0 m 20 2 r 0 m 80 m 3 m 0 2 r a0 m 0 m 90 m 88
m 80 m 88 m 0 m 88 m 80 m 0 5 r 10 m 0 2 r 21 m 2 m 0 8 r 1 m 0 2 r 80 m 1 m 0 m 3 m a0 m 84 m 20 m 0 3 r 89 m 84 m 10 m 0 8 r
20 m 0 4 r 80 m 84 m 10 m 0 m 10 m 0 16 r 20 m 0 m 1 m 80 m 8 m 90 m 84 m 40 m 0 1b r 21 m 80 m 1 m 80 m 0 2 r 1 m notbusy
20 wcmd 1 m d0 m 0 m notbusy \ 0x1d000
02 wcmd 1 m d0 m 0 m \ 0x1d000 
0 m 10 m 40 m 0 2 r 3 m 0 m 21 m 0 m 10 m 0 m 84 m 0 m 10 m 0 2 r 3 m 0 2 r a0 m 0 2 r 8 m 1 m 0 3 r 20 m 0 4 r 4 m 0 2 r 20 m
4 m 0 m 4 m 20 m 0 m a0 m 0 3 r 10 m 0 m 82 m 0 m 3 m 0 8 r 5 m 0 2 r 40 m 0 m 1 m 0 m 11 m 0 4 r 2 m 0 13 r 8 m 20 m 80 m 21
m 20 m 1 m 0 1d r 80 m 0 43 r 80 m 0 1d r 80 m 0 3 r 80 m 0 1b r 40 m notbusy
02 wcmd 1 m d1 m 0 m \ 0x1d100 
0 3 r 88 m 0 17 r 88 m 0 f r c0 m 0 3 r 40 m 0 b r 84 m 0 3 r 88 m 0 3 r 2 m 0 m 10 m 0 m 88 m 0 5 r 8 m 0 7 r c0 m 0 b r 40 m
0 3 r 10 m 0 m c0 m 0 3 r 8 m 0 m 8 m 0 10 r 4 m 80 m 5 m 20 m 5 m 80 m 5 m 0 2 r 80 m 0 m 80 m 0 m 80 m 1 m 0 3 r 8 m 10 m 0
5 r 5 m 0 5 r 21 m 0 m 3 m 0 m 3 m 0 m 8 m 0 m 21 m 0 m 8 m 0 3 r 11 m 0 m 85 m 0 7 r 8 m 0 d r 8 m 0 9 r 8 m 0 3 r 5 m 0 12 r
4 m 80 m 0 m 10 m 0 2 r 82 m 0 2 r 8 m 0 m 21 m 0 m 80 m 0 3 r 80 m 0 2 r 20 m 84 m 0 5 r 84 m notbusy
02 wcmd 1 m d2 m 0 m \ 0x1d200 
80 m 20 m 84 m a1 m 84 m 40 m 84 m 10 m 0 m 20 m 0 m 20 m 0 m 20 m 40 m a0 m 0 m a0 m 80 m 1 m 0 3 r c0 m 0 3 r 82 m 0 m 8 m 0
m a0 m 0 m 10 m 0 3 r 10 m 0 3 r 82 m 0 5 r 2 m 8 m 0 m 8 m a0 m 8 m 0 5 r 41 m 0 m 41 m 0 8 r 88 m 0 3 r 8 m 0 m 8 m 0 3 r 8
2 r 84 m 3 m 0 8 r 82 m 0 3 r a0 m 0 6 r 88 m 10 m 0 4 r 3 m c0 m 0 5 r 4 m 21 m 88 m 21 m 4 m 21 m 84 m 0 2 r 2 m 0 3 r 2 m 0
m 4 m 0 m 4 m 0 m 4 m 0 m 40 m 0 5 r c0 m 0 m 88 m 0 m 88 m 0 3 r 88 m 0 m 88 m 40 m 0 a r 8 m 0 m 90 m 0 m 88 m 0 3 r 9 m 0 3
r 90 m 0 3 r 2 m 0 3 r 40 m 0 b r 40 m 0 11 r 90 m 0 m c0 m 0 m 40 m 0 3 r 4 m 0 d r 4 m 0 9 r a0 m 0 m c0 m 0 7 r notbusy
02 wcmd 1 m d3 m 0 m \ 0x1d300 
4 m 0 3 r 80 m 0 m 80 m 0 m 80 m 0 10 r 90 m 0 5 r 40 m 0 a r 8 m 0 3 r 4 m 0 b r 3 m 0 6 r 40 m 0 9 r 40 m 0 m 40 m 0 20 r 80
m 0 4 r 88 m 0 m 20 m 0 10 r 1 m 0 m 1 m 80 m 83 m 80 m 5 m a0 m 0 5 r 2 m 0 m 8 m 0 3 r 41 m 82 m 0 8 r 8 m 0 2 r 82 m 5 m 0
2 r 82 m 0 m 82 m 0 2 r 20 m 0 5 r 8 m 0 m 41 m 82 m 5 m a0 m 0 2 r 41 m 0 8 r 82 m 5 m 0 e r a0 m 0 d r 88 m 0 4 r 80 m 0 m
80 m 0 3 r 8 m 0 6 r 4 m 5 m 20 m 21 m 1 m 0 m 20 m 0 m 20 m 0 m notbusy
02 wcmd 1 m d4 m 0 m \ 0x1d400 
0 m 82 m 0 m 84 m 0 3 r 8 m 2 m 0 m 2 m 20 m 2 m 20 m 84 m 41 m 0 m 84 m 0 2 r 8 m 1 m 0 m 84 m 0 5 r a0 m 21 m 0 6 r 8 m 0 m
a0 m 21 m 84 m 0 4 r 21 m 8 m 9 2 r 0 5 r 84 m 0 a r 41 m 0 m 3 m 0 2 r c0 m 5 m c0 m 0 m 84 m 0 m 8 m 0 3 r 10 m 0 8 r 8 m 0
5 r 8 m 10 m 0 9 r 10 m 0 m 10 m 0 3 r 84 m 0 6 r 80 m 0 m 80 m 0 m 20 m 0 m 80 m 0 m 80 m 0 9 r 20 m 41 m 0 m 20 m 40 m 0 2 r
10 m 0 6 r 4 m 80 m 82 m 11 m 82 m 8 m 0 m 4 m 0 m 40 m 88 m 2 m 0 3 r 21 m 2 m 21 m 88 m 8 m 0 6 r a0 m 11 m 0 2 r 4 m 0 m 2
m 0 2 r 4 m 0 m 41 m 0 3 r 41 m 0 3 r 9 m 0 m 40 m 88 m 21 m 0 8 r 4 m 2 m 0 m 20 m 0 m 4 m 0 m 8 m 0 2 r 4 m 0 6 r 21 m a0 m
3 m 0 2 r 90 m 0 9 r 40 m 0 3 r 4 m 0 m 4 m 0 m 4 m 5 m 90 m 5 m 40 m 80 m notbusy
02 wcmd 1 m d5 m 0 m \ 0x1d500 
0 m 21 m 0 m 4 m 0 b r 1 m 0 a r 80 m 2 m 0 11 r 40 m 0 a r 80 m 0 1c r 1 m 0 22 r 80 m 0 m 80 m 0 m 80 m 0 4 r 4 m 0 13 r 10
m 0 2 r 1 m 0 m 4 m 0 3 r 88 m 8 m 0 m 82 m 0 2 r 2 m 8 m c1 m a0 m 0 m 88 m 82 m c0 m a0 m 2 m 0 8 r 40 2 r 0 m 2 2 r c0 m 0
m 10 m a1 m 8 m 0 m 20 m 0 m 40 m 90 m 40 m 0 2a r 82 2 r 0 m a0 m 0 m 90 m c0 m 82 m 4 2 r 0 m 2 m 0 m 10 m 4 2 r notbusy
02 wcmd 1 m d6 m 0 m \ 0x1d600 
0 2 r 83 m 1 m 85 m 0 15 r 40 m 0 m 80 m 0 4 r 80 m 0 5 r 80 m a1 m 0 m 3 m 0 d r 80 2 r 0 m 80 2 r 0 2 r 80 m 82 m 80 m 0 m
80 m 0 3b r 80 m 0 m 80 m 0 m 2 2 r 8 m 84 m 11 m 0 m 9 m 0 a r 80 m 0 5 r 88 m 80 m 9 m 8 m 9 m 80 m 0 m c1 m 0 3 r 20 m 0 m
80 m 0 2 r 90 m 0 m 83 m 0 m c0 m 0 m 10 m 0 c r 41 m 80 m 2 m 0 4 r 80 m 3 m 80 m 0 m 80 m 0 b r 90 m 0 m 9 m 0 m 80 m 0 m 40
m 0 1b r 80 m 10 m 0 4 r 80 m 0 2 r 2 m notbusy
02 wcmd 1 m d7 m 0 m \ 0x1d700 
80 3 r 0 m 41 m 80 m 2 m 0 m 3 m 8 m 9 m 11 m 0 a r 10 m a0 m 0 3 r 4 m a1 m 10 m 0 m 41 m 0 m 8 m 0 m 11 m 82 m 0 m c0 m 1 m
88 m 8 m c0 m 0 m 11 m 0 m 20 m 0 m a0 m 10 m 41 m 0 b r 10 m 0 m 10 m 1 m 84 m 0 m 82 m 0 m 82 m 1 m 8 m 40 m 4 m 82 m 0 a r
89 m 0 m 40 m 0 m 4 m 0 m 82 m 0 19 r 2 m 0 m 10 m 1 m 88 m 40 m 20 m 0 m 8 m 0 m 4 m 0 m 10 2 r 8 m 0 2 r 40 m 0 2 r 1 2 r 0
m 82 m 0 8 r 1 m 0 3 r 82 m 88 m 0 3 r 1 m 0 m 1 m 84 m 0 3 r 90 m c0 m 0 m 88 m 0 m a0 m 10 m 84 m 4 m 2 m 0 m 10 m 0 m 5 m
a0 m 5 m 0 8 r 4 m 88 m 0 m 89 m 0 m 10 m 0 m c0 m 10 m a0 m 0 m a0 m 0 m 84 m 82 m a0 m 0 b r 82 m 0 m 82 m 0 m a0 m 0 1a r
20 m 2 m 0 m 40 m 0 m 88 m a0 2 r notbusy
02 wcmd 1 m d8 m 0 m \ 0x1d800 
88 m 40 m 0 m 10 m 8 m 82 m 8 2 r 0 2 r 1 2 r 82 m 1 m 0 a r 20 m 0 7 r 5 m 3 m 0 m 20 m 80 m 4 m 40 m 4 m 0 3 r 80 m 0 2 r 80
m 0 2 r 5 m 0 m 5 m 0 m 21 m 0 m 3 m 0 b r 20 m 0 m 83 m 0 2 r 80 m 0 2 r 80 m 0 2 r 4 m 80 m 0 b r 20 m 0 3 r 9 m 0 m 4 m 0
19 r 80 m 0 4 r 80 2 r 0 m 80 m 0 m 80 2 r 0 m 89 m 80 m 0 m 2 2 r 8 m 41 m 8 m 0 m 9 m 0 d r 4 m 0 2 r 84 m 8 m 21 m 0 m 9 m
0 2 r 20 m 0 2 r 80 2 r 0 7 r c0 m 0 3 r 10 m 0 8 r 80 m 0 2 r 9 m 0 4 r 80 m 0 4 r 80 m 0 d r 4 m 0 m 80 m 0 m 80 m 0 m 4 m 0
19 r 5 m 80 m 0 m notbusy
02 wcmd 1 m d9 m 0 m \ 0x1d900 
0 m 80 m 0 3 r 20 m 80 m a1 m 0 4 r 2 m 82 m 2 m 0 m 20 m 0 m 9 m 11 m 0 a r 88 m 0 5 r 2 m 3 m 88 m 4 m 88 m c0 m 10 m 1 m 82
m 0 m a0 2 r 40 2 r c0 m 0 m 2 m 0 m a0 2 r 4 m 84 m 4 m 0 9 r 8 m 0 m 10 2 r 90 m 82 m 4 m 0 m 4 m 0 m 82 m 84 m 20 m 84 m 4
m 0 c r 2 m 0 m 2 m 0 m 40 m 0 1a r 82 m 0 m 88 m a0 m 40 m 4 m c0 m 0 m 4 m 1 m 82 m c0 m 82 2 r 88 m 0 2 r 41 m 1 m 0 m 1 m
0 f r b m 0 7 r b m 0 2 r a m 0 e r 50 m 0 d r b m 0 35 r notbusy
02 wcmd 1 m da m 0 m \ 0x1da00 
0 m 81 m 0 2 r b m 0 7 r b m 0 m 41 m 0 4 r d0 m 0 d r ff m 0 3 r ff m 0 a r a0 m a2 m a8 m aa m fa m fe m ff 2 r 7f 2 r 3f m
ff 2 r 3f m ff 2 r 0 9 r f0 m ff m f0 2 r 14 m f0 m be m 80 m 82 m 80 m 0 m f8 m fb 3 r 0 e r 30 m 3f m 30 m 3f m 0 18 r fc m
3c m fe m be m fc m fe m f0 m fa m 7d m 7f m ff 2 r 7c 2 r 3c m 7c m 0 11 r ff m 0 3 r ff m 0 3 r 78 m ff 2 r 0 4 r a0 2 r a8
2 r fa m fe m fa m fe m 7f 2 r 3f m ff 2 r 2f m ff 2 r 0 9 r 3c m ff m 3c m f0 m 14 m f0 m be m 0 4 r f8 2 r fb 2 r 0 e r 30 m
3f m 30 m 3f m 0 14 r notbusy
02 wcmd 1 m db m 0 m \ 0x1db00 
0 4 r f0 m 0 m fa m aa m 3c m be m 0 m aa m 28 m 20 m 0 2 r 2c 2 r 3c m 2c m 0 12 r 3c 2 r 0 2 r f 2 r 0 4 r ff 4 r 0 3 r 41 m
ff 2 r 0 2 r b3 m b7 m f3 m f7 m 80 3 r fd m 0 8 r 3f m 3 m 3f 2 r 5f 2 r a 2 r 0 16 r af m 5 m 7d 2 r 0 18 r bf m be m af m
aa m ff 5 r 0 m ff m e m 5c m 3c m 5c m 3c m 0 12 r 3c 2 r 0 2 r f 2 r 0 4 r 7d 4 r 0 4 r 5c m c m 0 2 r bb m bf m fb m ff m
fd 2 r 80 m fd m 0 8 r 3f m 3 3 r 5f m a m 5f m a m 2 m 8 m 2 m 0 2 r 8 m 0 10 r af m 5 m 28 2 r 0 10 r notbusy
02 wcmd 1 m dc m 0 m \ 0x1dc00 
0 8 r 3f m 3c m f m 0 m ff 2 r 1 m c3 m ff m 0 m f1 m 0 m 3c 2 r 5c m 3c m 0 10 r 15 m 0 m 2a m 0 m 5 m 40 m 0 m a8 m 5 m 61 m
a m 6 m 5 m d m 0 m a0 m 0 7 r 1 m 0 m 61 m 0 m 6 m 0 m d m 0 b r 61 m 0 m e m 0 m d m 0 15 r 61 m 0 m 6 m 0 m 1d m 0 m 1 m 0
18 r 80 m 0 2 r 20 m 0 3 r 1 m 0 3 r 8 m 0 5 r 61 m 0 m 1 m 0 m 1 m 0 12 r ff m 55 m f m 55 m 61 m e3 m 75 m f7 m 0 c r 8 m c8
m 0 m c0 m 0 c r a m fa m a m fa m 0 16 r ff m 3c m ff 2 r 0 c r notbusy
02 wcmd 1 m dd m 0 m \ 0x1dd00 
0 1c r f m bf m f 2 r aa 4 r 0 10 r f0 m 55 m 0 m 55 m 20 m a2 m 34 m b6 m 0 d r c0 m 0 m c0 m 0 c r a m fa m a m fa m 0 16 r
ff m 3c m ff 2 r 0 28 r f m 1 m f 2 r a2 m ae m 82 m be m 0 14 r f5 m 3c m f5 m 3c m 0 c r 30 m a m 3f m a m 0 26 r df 2 r be
2 r 0 8 r notbusy
02 wcmd 1 m de m 0 m \ 0x1de00 
0 20 r df m 5f m ff 2 r bf m ff m af m ff m 0 14 r a0 m 3c m a0 m 3c m 0 c r 30 m a m 3f m a m 0 26 r df 2 r ff 2 r 0 28 r 8 m
a m 0 2 r 80 m 0 m a0 m 0 m 20 m 0 b r 84 m 0 8 r 8 m 0 m 2 m 0 m 8 m 0 m 10 m 2 m 0 m 4 m 0 m 20 m 0 b r 20 m 0 2 r 8 m 2 m 0
4 r 10 m 0 c r 20 m 0 m 2 m 0 3 r 4 m 0 m 2 m 0 m 2 m 0 m 20 m 0 3 r 20 m 0 3 r notbusy
02 wcmd 1 m df m 0 m \ 0x1df00 
4 m 0 a r 8 m 20 m 0 6 r 10 m 0 4 r 20 m 0 m 4 m 0 m 20 m 0 3 r 20 m 0 22 r 1 m 0 17 r 1 m 0 11 r 1 m 0 1c r 4 m 0 2 r 1 m 0
1c r 4 m 0 3 r ff 52 r notbusy
20 wcmd 1 m e0 m 0 m notbusy \ 0x1e000
02 wcmd 1 m e0 m 0 m \ 0x1e000 
ff 30 r 0 m 2d m 81 m c1 m 30 m 22 m 1 m 11 m 0 m 3 m 50 m 60 m 0 2 r 2 m 49 m 0 1b r 10 m 0 b r 40 m 0 5 r 40 m 0 7 r 10 m 0
m 10 m 0 m 10 m 0 1d r 10 m 0 4a r 82 m 0 7 r 20 m 0 13 r a0 m 0 m notbusy
02 wcmd 1 m e1 m 0 m \ 0x1e100 
0 9 r 41 m a0 m 80 m 0 2 r 82 m 0 12 r 10 m 0 27 r 10 m 0 m 8 m 0 d r c0 m 0 9 r 84 m 0 8 r 80 m 0 2 r 10 m 0 3 r 82 m 0 6 r
21 m 0 2 r 82 m 0 m c0 m 0 2 r 8 m 0 3 r 3 m 0 6 r 8 m 0 18 r 3 m 0 5 r 8 m 0 29 r 2 m 0 3 r a0 m 0 m 10 m 0 f r 20 m 0 9 r 4
m 0 5 r 40 m 0 3 r notbusy
02 wcmd 1 m e2 m 0 m \ 0x1e200 
40 m 0 7 r 2 m 0 f r 82 m 0 45 r 80 m 0 a0 r 8 m notbusy
02 wcmd 1 m e3 m 0 m \ 0x1e300 
0 13 r 41 m 0 41 r 84 m 0 3 r 8 m 0 m 10 m 0 3 r 10 m 0 m 10 m 0 m 8 m 0 3 r c0 m 0 m 10 m 40 m 0 5 r 3 m 84 m 3 m 0 c r 84 m
21 m a0 m 3 m 0 5 r 8 m 0 12 r a0 m 21 m 0 13 r 8 m 0 5 r 8 m 0 m 8 m 0 2 r c0 m 0 m c0 m 0 m 10 m 0 m 10 m 0 3 r 10 m 0 5 r
10 m 0 m c0 m 0 c r 4 m 0 4 r 11 m 0 15 r 5 m 0 4 r 2 m 10 m 4 m 40 m 0 2 r notbusy
02 wcmd 1 m e4 m 0 m \ 0x1e400 
0 2 r 2 m 0 6 r 40 m 0 2 r 4 m 0 9 r 40 m 0 35 r 88 m 0 3 r ff 82 r 0 m 17 m 9 m 99 m 30 m 22 m 1 m 11 m 0 m e m 50 m 60 m 0 3
r c3 m 0 1e r notbusy
02 wcmd 1 m e5 m 0 m \ 0x1e500 
0 f r 40 m 0 1b r 40 m 0 65 r 1 m 0 54 r ff 1a r notbusy
02 wcmd 1 m e6 m 0 m \ 0x1e600 
ff 68 r 0 m 3 m 49 m f3 m 30 m 22 m 1 m 11 m 0 m 14 m 50 m 60 m 0 3 r 82 m 0 29 r 11 m 0 4 r d0 m 0 53 r ff 6 r notbusy
02 wcmd 1 m e7 m 0 m \ 0x1e700 
ff 7c r 0 m 4 m be m a0 m 30 m 22 m 1 m 11 m 0 m 16 m 50 m 60 m 0 2 r 1 m 4 m 0 29 r 10 m 0 m e1 m 80 m 0 47 r notbusy
02 wcmd 1 m e8 m 0 m \ 0x1e800 
0 1e r 2 m 0 6 r 40 m 0 10 r 2 m 0 19 r 2 m 0 17 r 2 m 0 51 r 40 m 8 m 0 18 r c m 0 2b r notbusy
02 wcmd 1 m e9 m 0 m \ 0x1e900 
0 12 r ff 82 r 0 m 36 m 93 m 46 m 30 m 22 m 1 m 11 m 0 m 1b m 50 m 60 m 0 2 r 2 m 8a m 0 48 r 80 m 0 13 r notbusy
02 wcmd 1 m ea m 0 m \ 0x1ea00 
0 4f r 80 m 0 19 r 2 m 0 51 r 9 m 0 16 r 1 2 r 0 19 r 1 m 10 m 0 11 r notbusy
02 wcmd 1 m eb m 0 m \ 0x1eb00 
0 5 r 1 m 0 24 r ff d6 r notbusy
02 wcmd 1 m ec m 0 m \ 0x1ec00 
ff 2e r 0 43 r 1 m 0 2 r 2 m 0 7e r 82 m 0 3 r 2 m 0 8 r notbusy
02 wcmd 1 m ed m 0 m \ 0x1ed00 
0 74 r 1 m 0 3 r 1 m 0 43 r a4 m 0 30 r a0 m 3 m 0 11 r notbusy
02 wcmd 1 m ee m 0 m \ 0x1ee00 
0 a r b m 0 m 2 m 0 6a r 2 m 0 41 r d m f8 m 77 m 30 m a1 m 0 m 2 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m
0 m 20 m 0 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 1 m 30 m a1 m 0 m 1 m 50 m 60 m
0 3 r 41 m 0 6 r notbusy
02 wcmd 1 m ef m 0 m \ 0x1ef00 
0 7d r 1 m 44 m f4 m 30 m a1 m 0 m 2 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 33 m 64 m 0 8 r
30 m 22 m 2 m 1 m 0 m 4 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 5 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m c m 33 m 64 m 0 8 r
30 m 22 m 2 m 1 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m e m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m f m 33 m 64 m 0 8 r
30 m 22 m notbusy
20 wcmd 1 m f0 m 0 m notbusy \ 0x1f000
02 wcmd 1 m f0 m 0 m \ 0x1f000 
2 m 1 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22
m 2 m 1 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 19 m 33 m 64 m 0 8 r 30 m
22 m 2 m 1 m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 2 2 r 0 m 17 m 33 m 64 m 0 8 r 30 m
22 m 2 m 4 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m e m 33 m 64 m 0 8 r 30 m
22 m 2 m 4 m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m 11 m 33 m 64 m 0 8 r 30
m 22 m 2 m 4 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m notbusy
02 wcmd 1 m f1 m 0 m \ 0x1f100 
2 m 4 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22
m 2 m 4 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m 4 m 0 m 18 m 33 m 64 m 0 8 r 30 m
22 m 2 m 5 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m 6 m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 2 m 6 m 0 m 1b m 33 m 64 m 0 8 r 30
m 22 m 2 m 6 m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m 2 m 6 m 0 m 1d m 33 m 64 m 0 8 r 30 m 22 m 2 m 7 m 0 m c m 33 m 64 m 0 8 r
30 m 22 m 2 m 7 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 2 m 7 m 0 m e m 33 m 64 m 0 8 r 30 m 22 m 2 m 7 m 0 m f m 33 m 64 m 0 8 r
30 m 22 m 2 m 7 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m notbusy
02 wcmd 1 m f2 m 0 m \ 0x1f200 
2 m 7 m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 2 m 7 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 2 m 7 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22
m 2 m 7 m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 2 m 7 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 2 m 7 m 0 m 16 m 33 m 64 m 0 8 r 30 m
22 m 2 m 7 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m 8 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m a m 0 m 17 m 33 m 64 m 0 8 r 30
m 22 m 2 m c m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m e m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 2 m e m 0 m 16 m 33 m 64 m 0 8 r
30 m 22 m 2 m f m 0 m b m 33 m 64 m 0 8 r 30 m 22 m 2 m f m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m f m 0 m 1b m 33 m 64 m 0 8
r 30 m 22 m 2 m f m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m notbusy
02 wcmd 1 m f3 m 0 m \ 0x1f300 
2 m f m 0 m 1d m 33 m 64 m 0 8 r 30 m 22 m 2 m f m 0 m 1e m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 2 m 33 m 64 m 0 8 r 30 m 22
m 2 m 10 m 0 m 4 m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m b m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m c m 33 m 64 m 0 8 r 30 m
22 m 2 m 10 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m e m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m f m 33 m 64 m 0 8 r 30
m 22 m 2 m 10 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 12 m 33 m 64 m 0 8
r 30 m 22 m 2 m 10 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 15 m 33 m 64
m 0 8 r 30 m 22 m 2 m 10 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m notbusy
02 wcmd 1 m f4 m 0 m \ 0x1f400 
2 m 10 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 19 m 33 m 64 m 0 8 r 30 m
22 m 2 m 10 m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 2 m 10 m 0 m 1c m 33 m 64 m 0 8 r
30 m 22 m 2 m 10 m 0 m 1d m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 1 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 2 m 33 m 64 m 0
8 r 30 m 22 m 2 m 11 m 0 m 5 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 7 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 8 m 33 m 64 m
0 8 r 30 m 22 m 2 m 11 m 0 m 9 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m a m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m b m 33 m 64
m 0 8 r 30 m 22 m 2 m 11 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m notbusy
02 wcmd 1 m f5 m 0 m \ 0x1f500 
2 m 11 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m e m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m f m 33 m 64 m 0 8 r 30 m 22
m 2 m 11 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 12 m 33 m 64 m 0 8 r 30
m 22 m 2 m 11 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 15 m 33 m 64 m 0 8
r 30 m 22 m 2 m 11 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 18 m 33 m 64
m 0 8 r 30 m 22 m 2 m 11 m 0 m 19 m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 1b m 33
m 64 m 0 8 r 30 m 22 m 2 m 11 m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m notbusy
02 wcmd 1 m f6 m 0 m \ 0x1f600 
2 m 11 m 0 m 1d m 33 m 64 m 0 8 r 30 m 22 m 2 m 1 m 0 m 2 m 30 m a1 m 0 m 1 m 50 m 60 m 0 3 r c3 m 0 42 r 1 m 0 46 r 8 m 0 1f
r 8 m 0 1a r 20 m 0 6 r 2 m 0 16 r notbusy
02 wcmd 1 m f7 m 0 m \ 0x1f700 
0 22 r ff 82 r 0 m 2a m df m a m 30 m 22 m 2 m 1 m 0 m 6 m 50 m 60 m 0 2 r 1 m c7 m 0 4c r notbusy
02 wcmd 1 m f8 m 0 m \ 0x1f800 
0 7 r 80 m 0 6d r 82 m 0 13 r 4 m 0 46 r 8 m 0 2e r 3 m notbusy
02 wcmd 1 m f9 m 0 m \ 0x1f900 
0 5 r 3 m 0 5 r 8 m 0 81 r 1 m 0 54 r c0 m 0 1d r notbusy
02 wcmd 1 m fa m 0 m \ 0x1fa00 
0 6c r 21 m 0 13 r 5 m 0 5 r 5 m 0 3 r 5 m 0 1e r 8 m 0 11 r 82 m 0 4 r ff 40 r notbusy
02 wcmd 1 m fb m 0 m \ 0x1fb00 
ff 42 r 0 m 7 m b7 m d0 m 30 m 22 m 2 m 1 m 0 m 14 m 50 m 60 m 0 3 r 82 m 0 48 r e0 m 0 f r e0 m 7 m 0 28 r ff 2c r notbusy
02 wcmd 1 m fc m 0 m \ 0x1fc00 
ff 56 r 0 m a m c7 m db m 30 m 22 m 2 m 1 m 0 m 16 m 50 m 60 m 0 3 r 82 m 0 43 r 10 m 0 2 r 80 m 0 b r 2 m 10 m 0 2 r 80 m 1 m
0 2a r ff 18 r notbusy
02 wcmd 1 m fd m 0 m \ 0x1fd00 
ff 6a r 0 m 28 m 1 m 7b m 30 m 22 m 2 m 1 m 0 m 18 m 50 m 60 m 0 3 r 82 m 0 44 r 40 m 48 m 0 e r 40 m 48 m 12 m 2 m 0 2a r ff
4 r notbusy
02 wcmd 1 m fe m 0 m \ 0x1fe00 
ff 7e r 0 m 39 m 7c m 89 m 30 m 22 m 2 m 1 m 0 m 1c m 50 m 60 m 0 2 r 6 m 9a m 0 43 r 80 m 0 f r 80 m 0 4 r 1 m 0 19 r notbusy
02 wcmd 1 m ff m 0 m \ 0x1ff00 
0 54 r 1 2 r 0 e r 9 2 r 0 5e r 4 m 0 27 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 5 r 40 m 0 m 40 m 0 5 r notbusy
20 wcmd 2 m 0 m 0 m notbusy \ 0x20000
02 wcmd 2 m 0 m 0 m \ 0x20000 
0 8 r c0 m 0 3d r 80 m 0 e r 3 m 0 18 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 5 r 80 m 0 m 80 m 0 4d r 1 m 0 3 r 11 m 0 m 1 m 0 m
41 m 0 m 1 m 0 6 r 4 m 0 4 r 8 m 10 m 8 m 10 m 1 m 10 m 0 m 10 m 0 15 r 2 m 0 m 20 m notbusy
02 wcmd 2 m 1 m 0 m \ 0x20100 
0 b r 40 m 0 m 4 m 0 m 2 m 0 m 20 m 0 m 20 m 0 1f r 4 m 0 18 r 4 m 0 3 r a0 m 0 m 20 m 0 m a0 m 0 m 20 m 0 6 r 1 m 0 4 r 80 m
1 m 80 m 1 m 8 m 1 m 0 m 1 m 0 5 r 90 m 0 6 r 40 m 0 6 r 84 m 0 3 r 1 m 0 5 r 2 m 0 m 8 m 0 3 r 1 m 0 m 1 m 0 m 1 m 0 m 85 m 0
m 1 m 0 3b r 21 m 1 m 5 m 0 m 21 m 0 m 21 m 1 m 0 4 r 21 m 1 m 8 m 0 m 5 m 0 m 4 m 0 m 3 m 0 m 21 m 0 m 8 m 0 m 21 m 0 m 5 m 0
3 r 3 m 0 m 3 m 0 3 r 21 m 0 3 r 4 m 0 m 20 m 0 m 21 m notbusy
02 wcmd 2 m 2 m 0 m \ 0x20200 
0 3 r 3 m 0 3 r 21 m 0 m 5 m 0 m 11 m 0 m 5 m 0 m 5 m 0 m 4 m 0 m 3 m 0 m 21 m 0 m 8 m 0 3 r 20 m 0 38 r 10 m 0 5 r 20 m 0 5 r
20 m 0 4 r 1 m 0 17 r 1 m 0 m 1 m 0 13 r 1 m 0 9 r 1 m 0 28 r 4 m 0 3 r 90 m 0 3 r c0 m 80 m c0 m 0 m c0 m 0 3 r 10 m 8 m 40 m
0 m c0 m 0 m c0 m 0 7 r 1 m 80 m 0 2 r a0 m 0 3 r c0 m 0 2 r 21 m 0 m 80 m 4 m 20 m 4 m 80 m 4 m 0 2 r 80 m 0 6 r notbusy
02 wcmd 2 m 3 m 0 m \ 0x20300 
4 m 0 m 1 m 80 m 40 m 80 m 5 m 0 m c0 m 0 3 r c0 m 0 3 r 82 m 0 3 r c1 m 0 5 r 4 m 0 3 r 4 m 0 29 r 80 m 0 8 r 4 m 0 6 r 80 m
1 m 80 m 0 6 r 3 m 41 m 0 2 r 84 m 4 2 r 41 m 0 6 r 8 m 0 3 r 20 m 80 m 1 m 80 m 20 m 80 m 0 2 r 4 m 0 6 r 80 m 8 m 4 m 20 m
80 m 20 m c0 m 82 m 0 7 r 84 m 0 m a0 m 0 2 r 20 m 84 m 0 4 r 80 m 0 3 r 80 m 0 29 r 4 m 0 m 4 m 0 m 4 m 3 m 4 m 0 m 4 m 40 m
2 m 4 m 0 m 4 3 r 20 m 21 m 20 m 3 m 8 m 21 m 8 m 0 3 r c0 m 21 m 0 m 11 m a0 m 20 m 4 m 0 2 r 41 m 0 3 r 8 m 82 m 0 m 4 m 0 m
8 m 0 4 r 20 m 88 m 8 m 0 m 4 m notbusy
02 wcmd 2 m 4 m 0 m \ 0x20400 
0 m 4 m c0 m 5 m 0 2 r 40 m 8 m 0 m 20 m 4 m 5 m 0 m 21 m 0 m 21 m 84 m 20 m 4 m 21 m 0 3 r 3 m c0 m 0 3 r 4 m 5 m 8 m 0 2 r
20 m 8 m 0 29 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 2 r 1 m 0 m 1 m 80 m 1 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 8 r 1 m
80 m 0 9 r 80 m 0 6 r 1 m 0 3 r 1 m 0 m 1 m 0 4 r 80 m 0 15 r 80 m 0 4 r 1 m 0 2e r 4 m 0 8 r 8 m 0 m 3 m 83 m 0 2 r 80 m 41 m
80 m 1 m 0 3 r 4 2 r c1 m 3 m c0 m 9 m c0 m 9 m 0 m 9 m 0 m 21 m 82 m 8 m 1 m 8 m 0 8 r notbusy
02 wcmd 2 m 5 m 0 m \ 0x20500 
0 m 8 m 0 5 r 3 m 0 4 r 1 m 83 m 1 m 3 m 0 m 21 m 0 2 r 84 m 3 m 0 m 8 m 0 4 r c1 m 21 m 82 m 10 m 8 2 r 0 m 21 m 8 m 91 m 0
2e r 80 m 0 b r 20 m 0 2 r 4 m a0 m 2 m 20 m 0 3 r 80 m 1 m 4 m 0 7 r 3 m 0 3 r 8 m 0 15 r 40 m 20 m 40 m 0 4 r 90 m 0 8 r 20
m 0 2 r 1 m 0 5 r 20 m 0 2a r 40 m 10 m 0 m 40 m 0 m 10 2 r 90 m 11 m 91 2 r 85 m 2 m 90 m 10 2 r 21 m 1 m 0 2 r 88 m 1 m a0 m
0 3 r 41 m 8 m 91 m 8 m 9 m 2 2 r 8 m 10 m 88 m 0 m 10 m 0 m a0 m 20 m 4 m 8 m 40 m 0 m 10 m notbusy
02 wcmd 2 m 6 m 0 m \ 0x20600 
0 m 84 m 10 m 8 m 11 m 40 m 91 m 10 m 8 m 88 m 8 m 10 3 r 1 m 40 m 8 m 85 m 2 m 91 m 0 10 r 90 2 r 0 m 2 m 0 m 90 m 8 m 10 m 0
28 r 80 2 r 0 m 80 m 0 2 r 11 m 0 m 91 m 8 m 83 m 88 m 90 m 2 m 80 m 83 m 11 m 8 m 21 2 r 0 m 8 m 80 m 9 m 0 2 r 91 m 85 m 83
m 8 m c1 m 9 m 0 m 89 m 0 5 r 80 m 0 m 80 3 r 0 m 80 m 0 m 80 m 0 m 80 m 91 m c0 m 83 m 91 m 9 m 8 m 80 m 89 m 91 m 80 m 8 m 0
m 80 m 88 m 0 m 21 m 0 a r 3 m 0 8 r 80 m 0 2 r 80 2 r 0 2a r 80 m 2 m 80 m 91 m 0 2 r 10 m 80 m 8 2 r 85 m 80 m 2 m 83 m 11 m
84 m 3 m 0 m 91 m 40 m 41 m 80 m 0 2 r 11 m 0 m 8 2 r 89 m 91 m 89 m 83 m 0 3 r 5 m 0 4 r notbusy
02 wcmd 2 m 7 m 0 m \ 0x20700 
0 2 r 80 m 2 m 80 m 90 m 80 m 0 m 2 m 80 m 91 m 21 m 8 m 88 m 90 m 83 m 82 m 0 m 90 m 21 m 90 m 0 m 21 m 2 m 0 8 r 20 m 0 m 10
m 0 m 85 m 0 m a1 m 0 3 r 80 m 3 m 80 m 0 m 80 m 0 29 r 2 m 0 m 10 m 0 m 10 2 r 2 m 0 m 91 m 2 m 89 m 1 m 10 m 40 m 2 m 91 m
21 m 90 m 11 m 0 m 91 m 0 m 11 m c0 m 0 2 r 2 m 40 m 8 m 0 m 8 m 41 m 8 m 91 m 0 2 r 40 m 0 m 10 m 20 m 10 m 0 m 90 m 0 m 10 m
0 m 4 m 2 m 8 2 r 10 m 40 m 10 m 0 m 8 m c0 m 9 m 91 m 10 m 90 m 10 m 0 m 84 m 90 m 41 m 20 m 0 8 r 20 m 0 m 1 m 0 m 90 m 0 m
c1 m 0 m 90 m 0 m 8 m 0 m 4 m 40 m 4 m 0 29 r c0 m 40 m 0 m 10 m 2 m 8 2 r 10 m 88 m 89 m 0 m 89 m 90 m 10 m 11 m 10 m 0 m 11
m 8 m 20 m 9 m 11 m 0 m 90 m 0 2 r 40 m 8 m 0 m 40 m 10 m 8 m 11 m 8 m 40 m 2 m 0 m 20 m notbusy
02 wcmd 2 m 8 m 0 m \ 0x20800 
0 m 2 m 88 m a0 m 8 m 10 m 0 m 8 m 0 m 8 m 2 m 8 m 20 m 10 m 90 m 9 m 91 m 2 m 10 2 r 8 2 r 0 m 40 2 r 2 m 10 2 r 0 9 r 1 m 0
6 r 2 2 r 0 m 8 m 0 m 40 m 10 m 20 m 0 28 r 80 2 r 0 3 r 80 3 r 0 m 8 m 20 m 8 m c1 m 2 m 91 m 83 m 0 m 8 m 90 4 r 20 m 88 m 0
2 r 80 m 8 m 21 m c1 m 10 m c0 m 91 m 89 m 0 m 80 m 0 3 r 80 m 10 m 80 3 r 0 4 r 80 3 r 91 m a1 m 3 m 85 m 40 m 91 m 89 m 80 m
82 m 0 m a1 m 0 m 90 m 91 m 90 m 0 9 r 8 m 0 m 8 m 0 m 40 m 0 m 20 m 0 m 80 m 0 m 80 m 0 m 80 m 82 m 0 29 r 80 m 0 2 r 2 m 80
2 r 0 2 r 8 m 91 m 8 m 82 m 2 m 80 m 3 2 r 0 m a1 m 0 m 91 m 9 m 0 m 8 2 r 0 2 r 8 m 11 m 88 m 89 m 90 m 0 m 89 m 10 m notbusy
02 wcmd 2 m 9 m 0 m \ 0x20900 
0 m 8 m 0 m 80 4 r 0 m 80 m 0 m 80 m 82 m 0 2 r 80 m 0 m 91 2 r 3 m 82 m a0 m 0 m 9 m 11 m a1 m 8 m a0 m 82 m 21 m 80 m 88 m
10 m 0 f r 40 m 80 m 2 m 80 m 82 m 80 2 r 0 2a r 40 m 0 m 10 2 r 8 2 r 88 m 0 m 3 m 41 m 89 m 82 m 2 m 10 m 88 m 0 2 r 41 m 0
m 41 m 0 m 88 m 1 2 r 0 2 r 10 m 41 2 r 82 m 8 m 10 m 8 m 1 m 0 m 1 m 88 m 82 m 4 m 40 m 88 m 0 m 10 m 0 m 10 2 r 8 3 r 0 m 10
m 41 m 9 m 82 m 84 m 8 m 88 m 0 m 9 m 1 m 2 m 10 m 21 m 84 m 10 m 1 m 0 9 r 20 m 0 m 8 m 0 4 r 10 m 0 m 10 m 20 m 40 m 84 m 40
m 0 2d r b m 0 m 42 m 0 4 r d0 m b m 0 6 r 90 m 0 3 r 81 m 0 5 r d0 m notbusy
02 wcmd 2 m a m 0 m \ 0x20a00 
b m 0 2 r 81 m 0 c r b m 0 6 r d0 m b m 0 2 r 82 m 0 4 r b m 0 b r 41 m 0 2 r 90 m 0 8 r b m 0 2b r 3c m 7c m 3c 2 r ff 2 r 4
m 0 m 3c 4 r 7f m 40 m ff m 0 5 r 4 m 0 2 r 2 m 0 2 r 66 m 76 m 66 m 46 m 6e m 66 3 r e6 m ff m e6 m ff m 33 m cc m 33 m cc m
7f m ff 5 r fb m ff m fd m ff 3 r 66 2 r 76 m 46 m 66 4 r f7 m ff 3 r 0 10 r 7f m 10 m ff m 0 m ff 2 r fb m ff m 0 28 r 3c m
1c m 3c 2 r fb m ff m 0 2 r 6c m 3c 3 r ff m 0 m ff m 0 5 r 1c m 0 2 r 83 m 0 2 r notbusy
02 wcmd 2 m b m 0 m \ 0x20b00 
66 4 r 62 m 66 3 r e6 m 66 m e6 m 66 m aa m 55 m 33 m cc m 40 m 0 5 r 20 m 0 m 4 m 0 3 r 66 4 r 76 m 46 m 66 2 r 10 m 0 13 r
ff m 0 m ff m 0 m 4 m 0 3 r ff 82 r 0 m 31 m 1f m cd m 30 m 22 m 2 2 r 0 m 18 m 50 m 60 m 0 2 r c m b2 m 0 29 r 20 m ff m bf m
f 2 r notbusy
02 wcmd 2 m c m 0 m \ 0x20c00 
f m 1e m f 4 r 0 m ff m 20 m ef m 0 4 r 4c m 31 m 23 m c8 m 0 4 r ff 2 r 66 4 r 11 m b m e m 44 m 99 m f9 m 90 m f9 m 0 m 2 m
ff m fe m 38 m 3e m 3c 2 r ff 3 r fe m ff 3 r fe m 38 m 3e m 3c 2 r f m d m f m 4f m 0 c r 5a 2 r 66 m 99 m 66 3 r 27 m ff m
df m ff 2 r 0 2a r ff 2 r f 6 r b m 2f m 0 m ff m 0 m ff m 0 4 r 23 m c8 m 4c m 31 m 0 3 r 4 m ff m df m 66 3 r 6c m 0 m 2 m 8
m 0 m f9 m 99 m f9 m 90 m 0 2 r ff 2 r 3c 4 r 0 3 r 8 m 0 3 r 8 m 3c 4 r f 4 r 0 c r 5a 2 r 66 m 99 m 66 4 r 0 3 r 20 m 0 2a r
notbusy
02 wcmd 2 m d m 0 m \ 0x20d00 
0 m 8 m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 3 r 61 m 0 m 6 m 0 m d m 0 5 r 61 m 0 m 9 m 0 m 1 m 0 4 r 40 m 0 8 r 8 m 0 5 r 61 m 0 m 9
m 0 m 1 m 0 3 r 61 m 0 m e m 0 m d m 0 b r 61 m 0 m 6 m c0 m 5 m 0 m 5 m 0 3 r 8 m 0 34 r ff 2 r f7 m ff 4 r bf m 66 4 r ff m
69 m fe m 69 m 0 2 r 75 m 55 3 r 0 m ff m 8 m ff m 0 10 r f m 1f m f 2 r 0 m ff m 8 m ff m ba m e3 m 2a m 83 m 34 m 50 m a m
2c m 0 c r c3 m 33 m 3c m 33 m 0 2e r notbusy
02 wcmd 2 m e m 0 m \ 0x20e00 
0 c r 4 m 0 4 r 80 m 66 4 r ff m 69 m df m 69 m 0 2 r 45 m 55 3 r 0 m ff m 0 m f7 m 0 10 r f m b m f 2 r 0 m ff m 0 m f7 m 2a
m 83 m ba m e3 m 8 m 0 2 r 10 m 0 c r 3c m cc m c3 m cc m 0 38 r ff 2 r fe m ff 3 r f7 m ff m f4 m f0 m f m 2f m 99 m 66 m aa
2 r 0 2 r ff 2 r 0 2 r ff 3 r bf m 0 10 r ff 2 r 0 3 r 10 m ff 2 r 3f 4 r ea m fe m ea 2 r 0 c r f3 m 3 m a3 2 r 0 2a r
notbusy
02 wcmd 2 m f m 0 m \ 0x20f00 
0 10 r 4 m 0 4 r 8 m 4f m ef m f7 m f2 m 66 m 99 m 55 2 r 0 2 r f7 m ff m 4 m 0 4 r 10 m 0 10 r f7 m ff m 4 m 0 3 r ff m ef m
3f 4 r ea m fe m ea 2 r 0 c r c m fc m 5c 2 r 0 8 r 20 m 0 4 r 2 m 0 2 r 20 m 0 9 r 20 m 0 m 20 m 0 3 r 20 m 0 7 r 20 m 0 17 r
20 m 0 9 r 20 m 0 3 r 40 m 0 9 r 8 m 0 f r c0 m 0 m 20 m 0 3 r 20 m 0 5 r 4 m 0 3 r 4 m 0 7 r 40 m 0 5 r 84 m 0 21 r notbusy
20 wcmd 2 m 10 m 0 m notbusy \ 0x21000
02 wcmd 2 m 10 m 0 m \ 0x21000 
0 32 r 80 m 0 1b r 80 m 0 3 r 80 m 0 7 r 80 m 0 3b r 20 m 0 a r 3 m 0 10 r 89 m 0 1b r 3 m 80 m 1 m 80 m 0 1b r 4 m 0 8 r 20 m
0 2 r 8 m 0 m 8 m 0 m 8 m 0 2 r notbusy
02 wcmd 2 m 11 m 0 m \ 0x21100 
0 d r 8 m 0 b r 8 m 0 m 8 m 0 m 8 m 0 11 r 84 m 0 4 r 8 m 0 6 r 8 m 0 m 8 m 0 m 8 m 0 10 r 84 m 40 m 2 m 40 m 0 7 r 4 m 0 m 4
m 0 m 8 m 0 7 r 88 m 0 7 r 8 m 0 3b r 3 m 0 5 r 5 m 0 m 41 m 0 m 8 m 0 m 41 m 0 m c0 m 0 3 r 21 m 0 3 r 40 m 0 m 21 m 0 3 r 21
m 0 m 21 m 0 3 r 3 m 0 m 3 m 0 3 r 20 m 0 2 r 1 m 90 m 1 m c0 m 0 m 40 m 0 m 5 m 0 m 5 m 0 3 r 21 m 0 1c r notbusy
02 wcmd 2 m 12 m 0 m \ 0x21200 
0 14 r 2 m 0 5 r 20 m 0 2 r 88 m 0 m 84 m 41 m 0 4 r c0 m 0 m a0 m 0 5 r 82 m 21 m a0 m 41 m 4 m 21 m 0 2 r 84 m 0 3 r 2 m 0 m
41 m 0 m 82 m 0 m a0 m 0 m a0 m 41 m 82 m 0 3 r c0 m 20 m c0 m 5 m 8 m 0 4 r 40 m 0 3 r 41 3 r 40 m 4 m 21 m 40 m 21 m 0 m 1 m
0 4 r 3 m 0 40 r 2 m 0 m 3 m 8 m 9 m 90 m 0 m 9 m 10 m 0 b r 21 m 0 m 8 m 40 m 89 m 0 m 10 m 4 m 3 m 0 m 21 m 0 4 r 8 m 0 8 r
21 m 0 m 9 m 90 m 0 m 88 m 2 m c0 m 10 m 40 m 20 m 4 m a0 m 9 m 80 m 0 m 80 m 0 2 r 82 m 2 m 1 m 0 2 r 41 m 0 m 21 m 8 m 0 m 9
m 85 m 0 12 r notbusy
02 wcmd 2 m 13 m 0 m \ 0x21300 
0 20 r 8 m 0 m 8 m 0 2 r 1 m 0 2 r 80 m 0 3 r c0 m 1 m 0 m 2 m 0 9 r a0 m 0 3 r 10 m 0 m 1 m 0 17 r 1 m 0 m 1 m 0 m 1 m 80 m 3
m 4 m 10 m 0 m 10 m 0 3 r 1 m 8 m 0 5 r 80 m 0 m 40 m 10 m 0 28 r 8 m 0 14 r 2 m 40 m 4 m 0 4 r a0 m 21 m 0 3 r 5 m a0 m 0 6 r
10 m 0 d r 21 m 0 m 21 m 0 2 r 40 m 0 m 8 m 0 3 r 2 m 40 m 4 m 10 m 2 2 r 4 m 0 m c0 m 0 3 r c0 m 0 2 r 10 m 0 3 r 2 m 82 m 21
m 82 m 11 m 0 e r notbusy
02 wcmd 2 m 14 m 0 m \ 0x21400 
0 1b r c0 m 0 2 r 20 m 0 4 r 84 m 11 m 88 m 0 m 2 m 20 m 0 2 r 2 m 20 m a0 m 0 3 r 84 m 0 4 r 21 m 0 2 r c0 m 0 3 r 8 m 0 m 8
m 0 m 4 m 20 m 1 m 0 6 r 11 m 0 2 r c0 m 0 2 r 3 m 0 m 5 m c0 m 0 2 r 20 m 84 m a0 2 r 40 m 82 m 80 m 1 m 80 m 1 m 80 m 0 m a1
m 0 m 10 m 0 2 r 4 m 0 m 8 m 40 m 1 m 0 2 r 3 m 1 m 0 2 r 8 m 0 3a r 21 m 90 m 80 m 0 m 41 m 8 m 0 3 r 90 m 0 m a0 m 0 4 r 5 m
0 6 r 1 m 21 m 0 m 41 m 0 3 r 21 m 0 a r 82 m 0 5 r 8 m 0 2 r 5 m 2 m 20 m 0 2 r 2 m 20 m c0 m 5 m c0 m 9 m 0 5 r 2 m 0 m a1 m
41 m 10 m 89 m 80 m 0 a r notbusy
02 wcmd 2 m 15 m 0 m \ 0x21500 
0 31 r 10 m 0 2 r 80 m 0 11 r 2 m 0 17 r 80 m 0 2 r 82 m 80 m 1 m 0 2 r 80 m 1 m 0 5 r 8 m 0 3 r 1 m 0 m 2 m 8 m 85 m 2 2 r 0
38 r 1 m 40 m 0 m 10 m 90 m 88 m 0 m c0 m 0 a r 2 2 r 40 m 20 m 0 m 40 m 82 m 2 m 0 10 r 8 m 0 3 r 84 m 0 m 4 m 0 m 5 m c0 m 0
m 40 m 0 m c0 m 90 2 r 10 m c0 m 0 m 10 m 20 m 88 m 8 m 10 m 11 m 5 m a0 m 2 m 84 m 3 m a0 m 3 m 0 6 r notbusy
02 wcmd 2 m 16 m 0 m \ 0x21600 
0 2c r 11 m 0 5 r 21 m 80 m 21 m 80 m 0 e r 82 m 80 m 0 m 80 m 0 2 r 80 m 0 11 r 80 m 0 m 9 m 0 m 80 m 0 3 r 9 m 80 m 9 m 80 m
0 5 r 80 m 0 m 80 m 0 4 r 90 m 10 m a1 m 2 m 80 m 2 m 80 m 83 m 0 3b r 10 m 80 m 10 m 0 f r 3 m 80 m 0 1b r 11 m 0 m 9 m 0 m
a0 m 10 m 82 m 0 m 83 m 0 m 89 m 41 m 89 m c0 m 10 m 0 2 r 80 m 83 m a1 m 40 m 80 2 r 21 m 0 2 r notbusy
02 wcmd 2 m 17 m 0 m \ 0x21700 
0 36 r 2 m 0 m a0 m 0 m a0 m 0 m a0 m 0 b r a0 m 0 m 10 m 11 m 8 m 40 2 r 82 m 0 12 r 8 m 0 m 88 m 0 m 8 2 r 40 m 0 2 r 10 m
40 m 1 m c1 m 4 m 2 m 0 m 10 m 0 m 2 m c0 m 10 m 0 2 r c0 m 2 m 4 m 40 m 84 m 8 m 3 m 0 35 r 1 m 0 2 r c0 m 1 m 0 m 2 m 0 m 10
m 3 m 1 m 0 a r 82 m 2 m 0 m 88 m 0 m 8 m 83 m 82 m 0 11 r 3 m 0 m a0 m 0 m a0 m 0 m 10 m 90 2 r 0 m 82 m 40 m 90 m 89 m c1 m
0 m 40 m 0 m 8 m 10 m 82 m 0 m 88 m 90 2 r 0 m 82 m a0 m 10 m notbusy
02 wcmd 2 m 18 m 0 m \ 0x21800 
3 m a0 m 0 31 r 2 m 0 m 10 m 0 m 8 m 0 m 11 m 80 m 8 m 0 m 8 m 0 m 90 m 21 m 8 m 0 d r 80 m 0 2 r 9 m 80 m 0 11 r 8 m 0 m 2 m
0 m 2 m 0 m 89 m 85 m 91 m 0 m 90 m 80 m 10 m 89 m 82 m 0 m a0 m 0 m 85 m 80 m 83 m 0 m 85 m 0 m 4 m 0 m c1 m 80 m 3 m 9 m 82
m 0 3a r 80 m 0 10 r 2 m 80 m c0 m 80 m 0 1c r 2 m 0 m 80 m 0 m 11 m 80 m 0 m 80 3 r a1 m 0 m 80 2 r 40 m 5 m 0 m notbusy
02 wcmd 2 m 19 m 0 m \ 0x21900 
8 m 80 m 90 m 80 m 21 m 0 39 r a0 m 0 m a0 2 r 0 m c0 m 8 m 0 b r 2 m 1 m 4 m 82 m 40 m 2 2 r 0 14 r 8 m 0 7 r 88 2 r 1 m 84 m
0 m 40 m c0 m 8 m 9 m 8 2 r 88 m 0 m 4 m 0 m 3 m 8 m 2 m 8 m 3 m 0 3f r 84 m 0 2f r 9 m 0 9 r notbusy
02 wcmd 2 m 1a m 0 m \ 0x21a00 
60 m 81 m 0 6 r 84 m 0 39 r c3 m 3c 2 r c3 m 0 m f0 m 0 m f0 m 0 a r 20 m a8 m 20 m b8 m 4 m fe m 20 m 7f m 0 14 r f m eb 2 r
ff m cc 4 r aa 2 r 0 m c0 m a0 m 50 m c0 m fc m 54 m 15 m 40 m 1 m 0 m 20 m 38 m b8 m 96 m 69 m 96 m 69 m 0 38 r 3c m c3 2 r
3c m 0 m f0 m 0 m f0 m 0 d r 20 m 0 m 9c m 0 m 39 m 0 14 r ff m 2b 2 r f m cc 4 r aa 2 r 0 2 r 5f m af m notbusy
02 wcmd 2 m 1b m 0 m \ 0x21b00 
3f m 3 m 1 m 40 m 15 m 50 m 0 2 r 20 2 r 96 m 69 m 99 m 66 m 0 38 r c3 m 3c 2 r c3 m ff m 0 m 7f m 0 b r 5f m 5 m 1d m 5 m ff
2 r 7f 2 r 0 17 r a0 m 14 m 0 m f 2 r aa m 55 m 3c 2 r 30 m 3 m c m c0 m 99 m 66 2 r 99 m 7f m 55 m 15 m 0 m a m a0 m af m fa
m 0 38 r c9 m 36 2 r c9 m 7f m 0 m 1d m 0 b r 1d m 5 m 4 2 r ff 2 r 5d m 55 m 0 17 r a0 m 7d m 14 m f 2 r aa m 55 m notbusy
02 wcmd 2 m 1c m 0 m \ 0x21c00 
3c 2 r 30 m 3 m c m c0 m 66 m 99 2 r 66 m 1d m 15 m 4 m 0 m aa 2 r af m fa m 0 31 r 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 6 m 0
m d m 0 e r 30 m 0 4 r 1 m 0 11 r 61 m 0 m 6 m 0 m d m 0 2 r 85 m 61 m 2a m 6 m 5 m 4d m 0 m a8 m 0 m 61 m 50 m 6 m 0 m 1d m 0
3 r 61 m 30 m 6 m 0 m d m 0 36 r 3c m f m 3c m 0 5 r ff 2 r 79 m ea m 0 26 r 99 m 66 2 r 99 m 0 2 r notbusy
02 wcmd 2 m 1d m 0 m \ 0x21d00 
0 2 r fc m c0 3 r 0 4 r 66 m 99 2 r 66 m f0 m f 2 r f0 m b0 m f0 3 r 0 34 r 3c m f0 m 3c m ff m 0 4 r cf m 3f m 49 m 2a m 0 26
r 66 m 99 2 r 66 m 0 4 r c0 m fc 3 r 0 4 r 66 m 99 2 r 66 m d8 m 27 2 r d8 m 20 m b0 2 r f0 m 0 68 r notbusy
02 wcmd 2 m 1e m 0 m \ 0x21e00 
0 6 r cc m 33 m f m f0 m 0 4 r 99 m 66 2 r 99 m 33 m cc 2 r 33 m 0 m f0 m 0 m f0 m 0 6e r cc m 33 m f m f0 m 0 4 r 66 m 99 2 r
66 m 33 m cc 2 r 33 m 0 m f0 m 0 m f0 m 0 c r 20 m 0 1e r 2 m 20 m 0 16 r 3 m 0 6 r 4 m 0 m 4 m 0 m 4 m 0 15 r notbusy
02 wcmd 2 m 1f m 0 m \ 0x21f00 
0 a r 4 m 0 m 40 m 0 m 40 m 0 5d r 20 m 0 6f r 84 m 0 23 r notbusy
20 wcmd 2 m 20 m 0 m notbusy \ 0x22000
02 wcmd 2 m 20 m 0 m \ 0x22000 
0 31 r 8 m 0 1f r 2 m 0 c r 5 m 0 18 r c0 m 0 m 10 m 0 12 r 20 m 0 59 r a0 m 0 m 20 m 0 11 r 82 m 4 m 40 m 0 3 r notbusy
02 wcmd 2 m 21 m 0 m \ 0x22100 
0 2 r 88 m 0 m 82 m 0 9 r 20 m 0 b r 20 m 0 3e r 10 m 0 3 r 82 m 0 3 r 10 m 0 m 84 m 0 5 r c0 m 0 m 90 m 0 m c0 m 0 b r 84 m 0
3 r 10 m 40 m 0 c r 84 m 9 m 0 3 r 8 m 10 m 0 m 10 m 3 m 0 4 r a0 m 0 m 2 m 0 m 2 m 0 m 84 m 0 5 r 2 m 0 3d r 2 m 0 a r 4 m 0
9 r 20 m 0 7 r notbusy
02 wcmd 2 m 22 m 0 m \ 0x22200 
0 6 r 4 m 0 5f r 9 m 0 10 r 20 m 0 m 20 m 0 1b r c0 m 0 m 90 m 3 m 0 a r 90 m 0 5 r 90 m 0 3f r 10 m 0 16 r notbusy
02 wcmd 2 m 23 m 0 m \ 0x22300 
0 15 r 41 m 0 4b r 8 m 0 m 8 m 0 m 90 m 0 m 10 m 9 m 10 m 0 3 r 10 m 0 19 r 10 m 0 b r 88 m 0 m 10 m 0 4 r 8 m 0 m 8 m 0 2 r
84 m 0 7 r 2 m 0 5 r 8 m 20 m 0 39 r 20 m 0 e r 21 m 0 8 r notbusy
02 wcmd 2 m 24 m 0 m \ 0x22400 
0 b r 3 m 0 11 r 11 m 0 b r 2 m 0 7 r 2 m 0 37 r 82 m 0 m 10 m 0 m 10 m 9 m 10 m 0 9 r c0 m 0 m 2 m 0 m 20 m 0 2 r 11 m 20 m 4
m 0 7 r 5 m 0 c r 10 m 0 m c0 m 0 m 10 m 0 4 r 8 m 0 9 r 40 m c0 m 9 m 0 m 11 m 0 m 11 m 90 m 9 m a0 m ff 4c r notbusy
02 wcmd 2 m 25 m 0 m \ 0x22500 
ff 36 r 0 m 15 m da m 3e m 30 m 22 m 2 m 5 m 0 2 r 50 m 60 m 0 2 r 6 m 18 m 0 4 r 88 m 0 12 r 4 m 0 1c r 1 m 0 4 r 5 m 0 8 r 4
m 0 1b r 4 m 0 3 r 1 m 0 6 r 4 m 0 8 r 88 m 0 8 r 10 m 0 m 10 m 0 38 r 2 m 0 3 r notbusy
02 wcmd 2 m 26 m 0 m \ 0x22600 
0 9 r 1 m 80 m 0 6 r 4 m 0 18 r 8 m 0 18 r 1 m 0 m 1 m 0 14 r 9 m 0 m 1 m 10 m 1 m 0 m 1 m 0 9 r 4 m 0 3 r 20 m 0 1e r 20 m 0
m 10 m 0 3d r 8 m 0 e r 88 m 0 m 2 m 1 m 4 m 0 m 4 m 0 a r 84 m 0 11 r 90 m notbusy
02 wcmd 2 m 27 m 0 m \ 0x22700 
0 f r 1 m 0 m 1 m 0 1f r 8 m 0 b r 88 m 0 13 r 21 m 0 7 r 3 m 0 7 r 8 m 0 1d r 10 m 0 a r 40 m 0 m 8 m 0 3 r 4 m 0 2 r 5 m 0 2
r 8 m 0 2 r 21 m 0 4 r 9 m 10 m 0 9 r 2 m 0 8 r 4 m 0 m 4 m 0 m 4 m 0 d r 8 m 21 m 8 m 0 4 r 80 m 1 m 80 m 1 m 10 m 0 30 r
notbusy
02 wcmd 2 m 28 m 0 m \ 0x22800 
0 m 1 m 0 a r 80 m 0 m 80 m 0 3 r 80 m 0 5 r 80 m 0 2 r a0 m 0 4 r 82 m 1 m 0 12 r 80 m 0 m 80 m 0 m 80 m 0 8 r a0 m 0 4 r 80
m 0 m 80 m 0 4 r 40 m 8 m 10 m 8 m 85 m 8 m 0 m 8 m 0 m 8 m 0 m 8 m 0 19 r 4 m 0 3 r 8 m 0 b r 82 m 0 5 r 20 m 0 2 r 80 m 0 3
r 80 m 20 m 80 m 0 22 r 8 m 0 7 r 20 m 0 m 90 m 0 9 r 40 m 0 5 r 82 m 0 6 r 8 m 0 2a r notbusy
02 wcmd 2 m 29 m 0 m \ 0x22900 
0 d r 2 m 0 m 90 m 0 m 2 m 0 m 2 m 0 m 2 m 3 m 82 m 0 5 r 84 m 0 5 r 88 m 0 e r 10 m 0 2b r 40 m 0 8 r 10 m 0 26 r 1 m 5 m 0 2
r 84 m 0 m 41 m 0 4 r 20 m 1 m 0 c r 8 m 0 12 r 1 m 0 2 r 20 m 0 9 r 41 m 82 m 0 m a0 m 0 2 r 21 m 8 m 0 4 r 40 m 8 m 0 2 r 5
m 0 11 r 1 m 0 16 r notbusy
02 wcmd 2 m 2a m 0 m \ 0x22a00 
0 10 r 8 m 0 5 r c0 m 0 4 r 1 m 2 m 0 17 r 20 m 0 7 r 4 m 0 2 r a1 m 0 10 r 80 m 0 4 r 1 m 0 34 r 88 m 80 m 0 5 r 80 m 0 m 4 m
88 m 4 m 1 m 0 m 1 m 11 m 0 3 r 5 m 0 m 5 m 40 m 0 2 r 5 m 0 m 4 m 0 m 4 m 0 m 10 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 9 m 0 14 r 20
m 0 m 20 m 5 m 0 m 21 m 0 2 r a0 m 0 2 r 4 m 0 2 r 4 4 r 0 m 41 m c0 m 0 25 r notbusy
02 wcmd 2 m 2b m 0 m \ 0x22b00 
0 9 r 10 m 0 3 r 2 m 0 5 r 10 m 0 4 r 2 m 0 m 40 m 0 6 r 8 m 0 9 r 1 m 0 42 r 11 m 40 m 0 m 8 m 0 m 40 m 90 m 2 m 0 23 r 1 m
40 m 1 m 0 4 r c0 m 0 2 r 4 m 0 m 8 m a0 m 8 m c0 m 84 m 8 m 84 m 0 m a0 m 84 m 82 m 0 10 r c0 m 88 m 0 m 20 m 0 m 88 m 90 2 r
0 8 r 10 m 40 m 0 m 8 m 0 m a0 m 10 m 2 m 41 m a0 m 10 m 4 m 0 m 8 m c0 m 8 m 0 10 r 21 m 0 5 r 80 2 r 0 8 r notbusy
02 wcmd 2 m 2c m 0 m \ 0x22c00 
0 11 r 9 m 0 m 9 m 0 m 11 m 0 m 9 4 r 21 m 80 m 5 m 0 m 2 m 0 2 r 80 m 0 2 r 80 m 0 m 80 4 r 0 m 80 m 0 4 r 80 m 0 10 r 11 m 0
2 r 80 m 0 m 80 3 r 0 8 r 80 2 r 0 m 80 m 0 2 r 80 m 0 m a0 m 0 m 80 2 r 0 m 80 m 0 m 80 m 0 13 r 10 m 80 m 0 m 80 2 r 0 18 r
80 m 0 m 80 m 8 m 80 m 0 m 80 m 0 m 9 m 0 m 21 m 20 m 5 m 0 m 21 m 80 m 0 2 r 80 m 0 2 r 40 m 0 m 80 2 r 0 m 80 m 0 2 r 9 m 80
m 0 16 r 4 m 80 4 r 0 8 r 80 m 0 2 r 11 m 80 m 5 m 80 m 0 4 r 21 m 0 m 89 m 0 12 r 10 m 0 m 10 m 1 m 84 m 20 m c0 m 90 m 0 4 r
notbusy
02 wcmd 2 m 2d m 0 m \ 0x22d00 
0 14 r 8 m 0 m 8 m 0 m 10 m 40 m 8 m 0 3 r 21 m 0 m 21 m 0 m 1 m 88 m 0 2 r 8 m 0 2 r 1 m 4 m a0 m c0 m 0 m a0 m 0 m a0 m 0 m
8 m a0 m 40 m 0 13 r 88 m 0 m 84 m 8 2 r 90 m 0 8 r a0 m 0 m c0 m 0 m 8 m a0 m 40 m 0 m 40 m 0 m a0 3 r 82 m 84 m 0 11 r 20 m
0 4 r 90 2 r 0 1d r 1 m 0 4 r 1 4 r 0 5 r 2 m 91 m 0 m 4 m 0 m 20 m 40 m 9 m 8 m 84 m 0 m 88 m 0 m 4 m 82 m c0 m 0 10 r c0 m
88 m 0 m 4 m 0 m 88 m 84 m 82 m 0 8 r 8 m 10 m 0 m 8 m 0 m 4 m 2 m a0 m 8 m 10 m 0 m 2 m 0 m 82 m a0 2 r 0 15 r 80 m 0 2 r
notbusy
02 wcmd 2 m 2e m 0 m \ 0x22e00 
0 1a r 2 m 0 m 10 m 0 4 r 4 m 20 m 4 m 40 m 41 m 0 m 9 m 0 2 r 80 m 88 m 0 m 80 m 0 3 r c0 m 80 m 0 2 r 80 m 0 m 80 2 r 0 18 r
80 m 0 8 r 80 2 r 0 m 80 m 0 2 r 80 4 r 0 m 80 m 0 m 80 3 r 0 13 r 90 m 0 m 80 2 r 0 19 r 80 m 0 7 r c1 m 5 m 84 m 80 m 10 m 0
m 89 m 2 m 0 3 r 11 m 80 2 r 0 4 r 80 m 4 m 0 m 40 m 80 m 0 m 80 m 0 12 r 11 m 0 m 4 m 0 c r 80 m 0 m 80 m 89 m 80 m 0 m 80 m
0 3 r 80 m 84 m 80 m 0 13 r 40 m 0 m 88 2 r notbusy
02 wcmd 2 m 2f m 0 m \ 0x22f00 
40 m 90 m 88 m 0 19 r c0 m 0 m 8 m 2 m 8 m 88 2 r 0 m c1 m a0 m 11 m 10 m 0 m 20 m 8 m 0 3 r 20 m 0 m a0 m 8 m 90 m 4 m 20 m 0
m 8 m 1 m 84 m 21 m 40 m 84 m 82 m 0 11 r 84 m 0 m 84 m 5 m c0 m 0 m c0 m 0 9 r 8 m 0 m 4 m a0 m 4 m 88 m 82 m 0 m c0 m 0 m 88
m 9 m 8 m a0 m 88 m 0 12 r 41 m 0 2 r b m 0 2e r 81 m 0 2 r 9 m 0 m 60 m 0 7 r 50 m 0 12 r 81 m 0 2 r 9 m 0 2b r notbusy
20 wcmd 2 m 30 m 0 m notbusy \ 0x23000
02 wcmd 2 m 30 m 0 m \ 0x23000 
0 2 r 40 m 0 m ff m 66 m ff m 66 m 0 18 r 9f 2 r 66 m 3c m 0 4 r c3 m 3c m c3 2 r 0 6 r 24 m c m e7 m cf m 4 m 6e m 98 m fd m
69 m c3 m aa m 0 m 69 m 55 m f m cc m 0 10 r 99 2 r f m c3 m 9a 2 r 59 m 9a m 0 8 r 28 m 27 m b1 m 41 m 24 m 4d m db m b2 m 40
m 1 m 40 m 1 m f4 m d0 m f1 m 70 m 0 14 r 66 m ff m 66 m ff m 0 18 r ff 2 r 66 m 3c m 0 4 r c3 m 3c 3 r 0 6 r db m f3 m 18 m
30 m 2 m 67 m 91 m fb m 0 m aa m 3c m 96 m f m cc m 96 m aa m 0 10 r 66 2 r f0 m 3c m 6a 2 r 56 m 6a m 0 8 r 41 m 4e m d8 m 28
m 81 m 17 m 7e m e8 m 0 2 r 60 m 9 m b0 m 40 m e0 m 10 m ff c r notbusy
02 wcmd 2 m 31 m 0 m \ 0x23100 
ff 76 r 0 m 26 m 33 m 49 m 30 m 22 m 2 m 5 m 0 m 18 m 50 m 60 m 0 2 r 8 m a2 m 0 10 r ff 3 r fb m 42 2 r c3 m 0 1d r aa m 55 2
r aa m 0 a r 96 m cc m 96 m cc m 66 m 99 m a5 2 r 9a m c m 59 m 30 m eb m 82 m db m 42 m 0 10 r 17 2 r 71 2 r 69 m 96 2 r 69 m
0 8 r a9 m 59 m c m 3 m 99 m c3 m 99 m c3 m notbusy
02 wcmd 2 m 32 m 0 m \ 0x23200 
12 m 69 2 r 12 m ff 4 r 0 10 r ff 4 r 1 m 42 m 43 m 0 1d r 55 m aa 2 r 55 m 0 4 r 90 m 0 m 90 m 0 3 r 69 m 33 m 69 m 33 m 99 m
66 m a5 2 r c0 m 56 m 3 m 6a m db m 42 m db m 42 m 0 10 r f m f0 m f m f0 m 69 m 96 2 r 69 m 0 8 r c0 m 30 m 65 m 6a m 93 m c9
m 99 m c3 m 69 m 12 2 r 69 m 2f 2 r 6f m 7f m 0 12 r 40 m 28 m 0 3 r 8 m 0 18 r a0 m 61 m 0 m 6 m 0 m d m 0 2 r a0 m 61 m 0 m
6 m 0 m d m 0 5 r 61 m 0 m 36 m 0 m d m 0 m 5 m 0 2 r 40 m 0 4 r 1 m 0 10 r 80 m 0 2 r 30 m 0 10 r notbusy
02 wcmd 2 m 33 m 0 m \ 0x23300 
0 b r 1 m 0 38 r 30 m 3 m c m c0 m 99 m 66 2 r 99 m 0 6 r 3c 2 r ff 2 r 0 70 r 30 m 3 m c m c0 m 66 m 99 2 r 66 m 0 6 r 3c 2 r
ff 2 r 0 28 r notbusy
02 wcmd 2 m 34 m 0 m \ 0x23400 
0 40 r 99 m 66 2 r 99 m 0 4 r 15 m 3d m 38 m 10 m aa m 15 m 0 74 r 66 m 99 2 r 66 m 0 4 r ea m c2 m c7 m ef m 99 2 r 0 30 r
notbusy
02 wcmd 2 m 35 m 0 m \ 0x23500 
0 19 r 4 m c0 m 4 m 0 30 r 2 m 0 11 r 2 m 0 m 2 m 0 d r 20 m 0 b r 84 m 0 13 r 88 m 0 m 88 m 0 m 8 m 0 8 r 1 m 0 m 1 m 0 39 r
3 m 0 1e r 10 m 0 m 10 m 0 4 r 84 m 0 2 r notbusy
02 wcmd 2 m 36 m 0 m \ 0x23600 
0 5 r 8 m 0 e r 80 m 0 46 r 4 m 0 4 r 88 m 0 33 r 1 m 0 2 r 3 m 0 2c r 21 m 0 18 r 1 m 0 22 r notbusy
02 wcmd 2 m 37 m 0 m \ 0x23700 
0 16 r 8 m 0 8 r 4 m 0 2e r 1 m 0 m 1 m 0 m 1 m 0 4 r 40 m 0 9 r 5 m 0 11 r 2 m 90 m 0 1e r 8 m 0 d r 1 m 0 4 r 3 m 0 3 r 41 m
0 a r 20 m 0 m 82 m 0 m 40 m 0 16 r 4 m 0 m 4 m 0 m 4 m 0 3 r 21 m 0 m 41 m 0 5 r 3 m 0 3 r 21 m c0 m 0 1a r notbusy
02 wcmd 2 m 38 m 0 m \ 0x23800 
0 m 84 m 0 16 r 3 m 0 m 3 m 0 2b r 8 m 0 m 8 m 0 7 r 8 m 0 3 r 4 m 0 m 82 m 0 c r 20 m 0 m 20 m 0 m 20 m 0 m a0 m 0 m 2 m 0 1e
r 8 m 0 m 8 m 0 13 r 8 m 0 29 r 80 m 0 7 r 80 m 0 3 r 80 m 0 c r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m 5 m 0 14 r notbusy
02 wcmd 2 m 39 m 0 m \ 0x23900 
0 1c r 8 m 0 5 r 80 m a0 m 0 6 r 10 m 0 20 r 11 m 0 a r 1 m 20 m 0 2 r 4 m 80 m 20 m 0 4 r 5 m 0 3 r 2 m 0 4 r 20 m 0 38 r 20
m 0 12 r 5 m 0 3 r 5 m 90 m 0 1b r 40 m 4 m 1 m 0 2 r 80 m 20 m 0 d r 84 m 83 m 0 13 r notbusy
02 wcmd 2 m 3a m 0 m \ 0x23a00 
0 b r 8 m 0 3 r 8 m 0 f r 10 m 0 m 8 m 0 38 r 4 m 21 m 0 5 r 41 m 20 m 9 m 2 m 9 m 0 m 41 m 0 7 r 11 m 0 3 r 2 m 0 m 40 m 0 m
20 m 0 1b r 8 m 0 e r 4 m 0 39 r 80 m 0 23 r notbusy
02 wcmd 2 m 3b m 0 m \ 0x23b00 
0 2c r 1 m 0 3 r 1 m 0 2b r c0 m 88 m 0 m 40 m 0 m 88 m 4 m 90 m 0 42 r 10 m 88 m 0 m 88 m 0 m a0 m 88 m 20 m 10 m 0 3 r 8 m 0
2b r 80 m 0 2 r 80 m 0 3 r 80 m 0 e r 2 m 0 b r notbusy
02 wcmd 2 m 3c m 0 m \ 0x23c00 
0 2d r 80 m 0 7 r 41 m 0 2c r 80 m 9 m 80 m 9 m 80 2 r 0 b r 9 m 0 m 80 m 0 m 9 m 0 m 80 m 0 30 r 80 m 0 m 80 m 0 2 r 21 m 0
34 r 82 m 0 m 8 m c1 m 8 m 90 m 0 d r c0 m 0 3 r 2 m 0 4 r notbusy
02 wcmd 2 m 3d m 0 m \ 0x23d00 
0 2c r 10 m 0 m 40 m 0 m 2 m 1 m 4 m 0 3 r 88 m 0 2d r c0 m 88 m 0 m 4 m 90 m 88 m 82 m 10 m 0 c r 4 m 0 m 20 m 0 33 r 90 m 10
m 0 m 10 m 0 m 10 3 r 0 6 r 20 m 0 2d r 80 m 0 m 80 2 r 0 a r 20 m 0 m 80 m 0 m 80 m 0 m 40 m 0 m notbusy
02 wcmd 2 m 3e m 0 m \ 0x23e00 
3 m 0 32 r 80 m 0 2 r 80 m 0 2b r 80 m 0 m 80 m 0 4 r 9 m 0 m 41 m 0 11 r 11 m 0 64 r 10 m 0 m 8 m 0 m 10 m 0 m c0 m 0 m 4 m 0
m 4 m 0 m 4 m 88 m 40 m 0 e r 1 m notbusy
02 wcmd 2 m 3f m 0 m \ 0x23f00 
0 37 r 4 m 0 7 r d0 m 0 2d r 81 m 0 2 r 9 m 0 m 88 m 0 e r d0 m 41 m 0 m 81 m 0 61 r cc m f m 33 m f0 m 0 4 r ac m af m 53 m
50 m 96 2 r 9c m 93 m 0 a r notbusy
20 wcmd 2 m 40 m 0 m notbusy \ 0x24000
02 wcmd 2 m 40 m 0 m \ 0x24000 
0 68 r cc m f m 33 m f0 m 0 4 r ac m a0 m 53 m 5f m 3c m c3 m 36 m c6 m 0 49 r 40 m 0 30 r f0 m f m aa m 55 m f0 m f 2 r f0 m
0 6 r notbusy
02 wcmd 2 m 41 m 0 m \ 0x24100 
0 3c r 7f m f m 7d m 0 m 7f m 3f m 7d m 3c m 0 30 r c3 m 3c m aa m 55 m f m f0 2 r f m 0 42 r 2f m f m 28 m 0 m 7f m 3f m 7d m
3c m 0 m 61 m 0 m 7 m 0 m d m 0 2a r 80 m 0 2 r 30 m 0 6 r notbusy
02 wcmd 2 m 42 m 0 m \ 0x24200 
0 8 r 5 m 65 m a m 47 m 15 m d m 0 m a0 m 0 38 r ff 82 r 0 m 2d m f8 m 61 m 30 m 22 m 2 m 7 m 0 2 r 50 m 60 m 0 2 r 3 m 4d m 0
b r 4 m 0 1a r notbusy
02 wcmd 2 m 43 m 0 m \ 0x24300 
0 m 3 m 0 31 r 4 m 0 10 r 2 m 0 e r 4 m 0 6 r a0 m 0 6 r 8 m 0 48 r 2 m 0 36 r 10 m 0 1e r notbusy
02 wcmd 2 m 44 m 0 m \ 0x24400 
0 77 r 8 m 0 5 r 8 m 0 2 r 4 m 0 4 r 4 m 0 11 r 82 m 0 5 r 82 m 0 1b r 8 m 0 1f r 10 m 0 10 r 8 m 0 9 r a0 m 0 b r notbusy
02 wcmd 2 m 45 m 0 m \ 0x24500 
0 m 40 m 0 12 r 40 m 0 m 84 m 0 m c0 m 0 3e r 40 m 0 14 r 21 m 0 3 r 8 m 0 24 r 10 m 0 6 r 11 m 0 6 r c0 m 0 1f r 40 m 0 18 r
2 m 0 m 2 m 0 m 2 m 0 m 2 m 0 m 11 m 4 m 0 1a r notbusy
02 wcmd 2 m 46 m 0 m \ 0x24600 
0 4b r 21 m 0 m 8 m 0 3a r 4 m 0 11 r 2 m 0 46 r c0 m 0 1e r notbusy
02 wcmd 2 m 47 m 0 m \ 0x24700 
0 12 r a0 m 0 57 r 4 m 0 6 r 8 m 11 m 84 m 0 c r 8 m 0 19 r 9 m 0 4 r 10 m 0 3 r 8 m 0 21 r 90 m 0 21 r 40 m 0 m 8 m 0 m 4 m 9
m 0 m 10 m 0 9 r 8 m 0 4 r 21 m 0 2 r notbusy
02 wcmd 2 m 48 m 0 m \ 0x24800 
0 e r 10 m 0 84 r 20 m 0 m 20 m 0 m 20 m 0 2e r 5 m 0 2b r ff e r notbusy
02 wcmd 2 m 49 m 0 m \ 0x24900 
ff 74 r 0 m 30 m bf m 57 m 30 m 22 m 2 m 8 m 0 2 r 50 m 60 m 0 2 r 6 m 18 m 0 16 r 40 m 0 14 r 3 m 0 2 r 40 m 80 m 0 13 r 4 m
0 2 r a0 m 0 6 r 2 m 0 2 r 20 m 0 9 r 88 m 0 b r 8 m 0 15 r notbusy
02 wcmd 2 m 4a m 0 m \ 0x24a00 
0 31 r 84 m 0 3 r 4 m 0 11 r 3 m 0 m 1 m 0 22 r 80 m 0 43 r 1 m 0 4 r 4 m 0 m 4 m 0 1c r 1 m 0 17 r 8 m 0 3 r 8 m 0 7 r 40 m 0
7 r notbusy
02 wcmd 2 m 4b m 0 m \ 0x24b00 
0 4 r 8 m 0 3 r 88 m 0 28 r 82 m 2 m 0 4 r 1 m 0 m 1 m 0 1c r 4 m 0 4 r 8 m 0 12 r 80 m 0 3 r 80 m 0 7 r 80 m 8 m 0 a r 80 m 0
2 r 8 m 0 2e r 1 m 0 e r 2 m 0 12 r 1 m 0 10 r 40 m 0 13 r 21 m notbusy
02 wcmd 2 m 4c m 0 m \ 0x24c00 
0 m 2 m 0 m 40 m 0 m 21 m 0 m 8 m 0 3 r 9 m 0 2e r 20 m 0 2 r 88 m 0 f r 88 m 0 7 r 84 m 0 6 r 4 m 0 2d r 5 m 0 m 40 m 0 39 r
a0 m 0 3 r 40 m 2 2 r 40 m 0 5 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 21 m 20 m 0 m 3 m 0 2 r 9 m 0 e r 8 m 0 6 r 8 m 21 m 0 2 r 1
m 0 3 r 9 m 0 m notbusy
02 wcmd 2 m 4d m 0 m \ 0x24d00 
8 m 10 m 0 3 r 8 m 82 m 0 2 r 8 m 0 3 r 41 m 8 m 21 m 0 m 21 m 0 10 r 8 m 0 18 r 2 m 0 5 r 8 m 0 d r 40 m 0 5 r 1 m 0 m 1 m 0
m 1 m 0 m 1 m 20 m 1 m 3 m 0 m 3 m 0 m 4 m 0 4 r 88 m 0 4 r 3 m 0 5 r 3 m 0 9 r 2 m 0 2 r 8 m 88 m 10 2 r 1 m 0 c r 80 m 0 2 r
82 m 0 26 r 84 m 0 2 r 40 m 0 2 r 1 m 2 m 0 25 r 20 m 0 8 r 20 m 0 3 r 40 m 0 m 90 m 0 3 r 4 m 0 m 88 m 0 2 r 8 m notbusy
02 wcmd 2 m 4e m 0 m \ 0x24e00 
0 3 r 3 m 0 m 2 m 0 3 r 2 m 0 3 r 40 m 0 4 r 2 m 0 m 10 m 0 8 r 8 m 0 21 r 1 m 0 2 r 4 m 0 4 r 10 m 0 2e r 40 m 0 1d r 3 m 0 2
r 90 m 0 20 r 88 m 0 3 r 88 m 0 m 88 m 80 m 1 m 2 m 0 3 r 20 m 10 m 80 m 0 5 r 5 m 8 m 0 5 r 1 m c0 m 0 a r 83 m 0 3 r 1 m 0 m
1 m 21 m 1 m 0 14 r 8 m 0 2 r notbusy
02 wcmd 2 m 4f m 0 m \ 0x24f00 
0 7 r 21 m 0 5 r 21 m 0 m 8 m 0 m 21 m 8 m 0 5 r 82 m 0 24 r 82 m 0 3 r 4 m 2 m 0 4 r 1 m 0 m 20 m 0 b r 20 m 8 m 10 m 21 m 0
9 r 8 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 c r 84 m 0 5 r 82 m 0 m 82 m 0 1b r 10 m 0 20 r 1 m 0 m 21 m 0 m 90 m 1 m 0 2 r c0 m 4
m 90 m 88 m 0 m 4 3 r 0 32 r 3 m 10 m notbusy
20 wcmd 2 m 50 m 0 m notbusy \ 0x25000
02 wcmd 2 m 50 m 0 m \ 0x25000 
0 m 20 m 0 m 88 m 2 m 88 m c0 m 0 m 1 m 0 m 90 m 0 m 4 m 0 9 r 90 m a0 m 0 m 8 m 0 m 8 m 0 m 88 m 0 20 r 11 m 0 m 83 m 0 m 90
m 8 m 0 m 20 m 80 3 r 0 m 8 m 80 3 r 0 16 r 8 m 0 7 r 10 m 0 13 r a1 m 0 2 r 80 m 0 4 r 80 m 0 m 10 m 0 e r 80 m 0 m 80 m 0 28
r 11 m 0 m 20 m 3 m 80 m 0 4 r 9 m 80 m 0 14 r 10 m 0 2 r 80 m 0 4 r 4 m 0 3 r 40 m 0 m 80 m 0 e r notbusy
02 wcmd 2 m 51 m 0 m \ 0x25100 
0 2 r 80 m 0 m 80 m 8 m 0 4 r 90 m 0 m 3 m 0 m 10 m 0 m 90 m 0 b r 80 m 20 m 0 m 80 3 r 0 27 r 21 m 88 m 0 3 r 2 m 0 m 82 m 0
13 r 88 m 1 m 84 m 88 m 8 m 0 m 84 m 88 m 0 m 1 m 0 m 40 m 0 3 r 4 m 0 10 r 88 m 0 m 10 m 1 m 2 m 90 m 0 2 r 11 m 0 m 2 m 0 m
89 m 0 m 8 m 0 9 r 10 m 0 m 82 m 0 m 88 m a0 m 8 m 10 m 0 21 r 1 m 90 m 0 m c1 m 0 2 r 1 m 40 m 4 m 0 m 40 m 90 m 4 m 88 m c0
m 0 16 r 10 m 0 3 r 1 m 0 m 40 m 0 m 40 m 0 d r notbusy
02 wcmd 2 m 52 m 0 m \ 0x25200 
0 6 r c0 m 0 2 r 90 m 0 5 r 88 m 0 m 10 m 0 m 9 m 1 m c1 m 0 8 r 4 m 10 m 0 m 2 m 0 m 2 m 82 m a0 m 0 21 r 40 m 91 m 41 m 10 m
9 m 0 m 40 m 80 2 r 0 m 80 3 r 20 m 80 m 0 12 r 10 m 0 7 r 4 m 0 5 r 5 m 0 11 r 80 m 0 8 r 8 m 0 m 3 m 0 m a1 m 21 m 88 m 0 e
r 80 2 r 0 21 r 89 m 11 m 0 m 20 m 0 m 11 m 10 m 0 m 2 m 0 m 10 m 0 17 r 4 m 0 m 88 m 0 7 r 41 m 0 a r notbusy
02 wcmd 2 m 53 m 0 m \ 0x25300 
0 b r 10 m 80 m 0 m 80 m 0 m 80 m 0 2 r 80 m 0 m 80 m 0 m 80 m 0 m 8 m 0 b r 4 m 80 m 0 24 r 20 m 0 5 r 1 m 0 m 1 m 0 m 20 m 0
17 r 1 m 0 m 21 m 0 m 84 m 0 5 r 1 m 0 14 r 2 m 0 m 20 m 88 m 8 m 10 m a0 m 0 2 r 10 m 0 m 8 m 0 m 2 m 0 m 1 m 0 8 r 88 m 0 2
r 10 m 8 m 88 m 10 m 0 21 r 81 m 0 2 r d0 m 0 5 r 81 m 0 m d0 m b m 0 m 60 m 0 16 r d0 m b m 4 m 0 5 r d0 m b m 0 m 41 m 0 3 r
notbusy
02 wcmd 2 m 54 m 0 m \ 0x25400 
0 14 r 60 m 0 7 r 84 m 0 3d r f6 2 r ff 2 r 0 32 r ff 4 r f0 4 r 0 4 r 66 2 r ff m 0 9 r ff 6 r fe m f6 m 0 2c r f6 m 77 m ff
m fc m 0 20 r notbusy
02 wcmd 2 m 55 m 0 m \ 0x25500 
0 12 r ff 3 r df m 66 4 r 0 4 r 3c 2 r f0 2 r 0 8 r fe 2 r 7e 2 r ff 2 r fe m f6 m ff 82 r 0 m b m 11 m f5 m 30 m 22 m 2 m 8 m
0 m 18 m 50 m 60 m 0 2 r f m be m 0 28 r ff m 66 m ff m 66 m 0 m e7 m 18 m ff m 0 c r notbusy
02 wcmd 2 m 56 m 0 m \ 0x25600 
0 a r 4e m c3 m 4e m ff m 0 18 r 30 3 r 0 m 66 m 0 m 66 m 0 5 r 3c m ff m 4e 2 r 0 8 r 27 m e7 3 r 0 2 r 1 2 r 0 28 r 7f m 66
m ff m 66 m 0 m e7 m 18 m ff m 0 16 r 4e m 0 m 4e m 3c m 0 18 r f0 4 r 3c m f m 3c m f m 0 5 r c3 m 4e 2 r 0 8 r 27 2 r e7 2 r
0 2 r 99 m 0 22 r 61 m 0 m 1 m 80 m 1 m 0 3 r 61 m 0 m 2f m 0 m 9d m 0 a r notbusy
02 wcmd 2 m 57 m 0 m \ 0x25700 
0 a r 5 m 69 m a m f m 5 m d m 4 m a0 m 5 m 6d m a m f m 5 m d m 0 m a0 m 0 15 r 10 m 0 3 r 61 m 0 m 6 m 0 m 9d m 0 32 r fc m
3c m fc m 3c m 0 4a r 38 m fb m 0 m c3 m 0 30 r c m 3c m c m 3c m a8 m aa 3 r 0 c r notbusy
02 wcmd 2 m 58 m 0 m \ 0x25800 
0 3a r 10 m d3 m 0 m c3 m 0 30 r bf 4 r aa m ff m aa 2 r 0 46 r be m 50 m be m fa m 0 30 r 1 4 r aa m 0 m aa 2 r 0 8 r notbusy
02 wcmd 2 m 59 m 0 m \ 0x25900 
0 3e r 14 m 50 m 14 m fa m 0 10 r c0 m 0 m c0 m 0 3 r 88 m 0 m 20 m 0 5 r 20 m 0 c r 2 m 0 12 r 20 m 4 m 0 5 r 5 m 0 4 r 40 m
0 15 r 20 m 0 m 88 m 0 9 r 20 m 0 7 r 88 m 0 m 8 m 0 2 r 4 m 0 5 r 3 m 0 22 r 9 m 0 a r 1 m 0 10 r notbusy
02 wcmd 2 m 5a m 0 m \ 0x25a00 
0 15 r 3 m 0 24 r 80 m 0 2 r 1 m 0 8 r 20 m 0 27 r 84 m 0 d r 4 m 0 e r 9 m 0 18 r 20 m 0 m 20 m 0 11 r 1 m 0 2 r 80 m 0 m 20
m 1 m 84 m 0 11 r 4 m 0 25 r 8 m 0 6 r 80 m 0 m notbusy
02 wcmd 2 m 5b m 0 m \ 0x25b00 
0 17 r 84 m 0 b r 84 m 0 2 r 80 m 0 m 80 m 0 8 r 2 m 0 m 82 m 0 6 r 20 m 0 2 r 20 m 0 m 1 m 8 m 21 m 0 8 r 20 m 0 8 r 8 m 0 5
r 90 m 0 29 r 3 m 0 3 r 2 m 0 4 r c0 m 0 14 r 40 m 0 m 8 m 0 m 10 m 0 5 r 40 m 0 5 r 2 m 0 3 r 5 m 0 5 r 8 m 0 5 r 20 m 0 9 r
5 m 0 m 11 m 1 m 21 m 0 3 r 9 m 0 m 21 m 0 m 21 m 0 2 r 2 m 11 m 0 1e r 5 m 0 5 r notbusy
02 wcmd 2 m 5c m 0 m \ 0x25c00 
41 m 0 m 5 m 0 4 r 2 m 0 3 r 84 m 0 3 r 2 m 0 m c0 m 0 f r 8 m 0 5 r a1 m 0 3 r 84 m 0 5 r 88 m 0 d r 82 m 0 3 r 1 m 0 m 8 m 0
m 8 m 0 3 r 84 m 0 4 r 40 m 8 m 0 m 84 m 0 m 8 m 40 m 0 2 r a0 m 0 2 r 5 m 2 m 8 m 0 d r 8 m 0 11 r 2 m 0 f r 4 m 0 m 1 m 0 f
r 82 m 0 4 r 9 m 0 2 r 1 m 80 m 0 5 r 80 m 0 2 r 40 m 0 m 40 m 0 2 r 5 m 0 m 5 m 0 6 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 80 m 0 2 r
a0 m 0 5 r 8 m 0 5 r 40 m 0 2 r 11 m 8 m 0 15 r 2 m 0 d r 41 m 0 m notbusy
02 wcmd 2 m 5d m 0 m \ 0x25d00 
0 m 40 m 0 e r 3 m 0 m 40 m 0 5 r 41 m 0 3 r 11 m 0 5 r 3 m 0 7 r 20 m 10 m 0 5 r 20 m 0 9 r 84 m 0 m 84 m 0 4 r 4 m 0 m 4 m 0
m 4 m 0 m 4 m 20 m 0 m 8 m 0 14 r 5 m 0 11 r 82 m 0 d r 84 m 0 m 8 m 0 5 r 8 m 0 m 8 m 0 3 r c0 m 0 m 84 m 0 3 r c0 m 0 4 r 8
m 0 9 r 2 m 0 6 r 90 m 0 1d r 1 m 0 3 r 90 m 5 m 0 m 21 m 0 3 r 8 m 0 m 3 m 0 5 r 3 m 40 m 0 m 82 m 0 2 r 3 m 0 m 21 m 0 1c r
notbusy
02 wcmd 2 m 5e m 0 m \ 0x25e00 
0 6 r 8 m 0 4 r 84 m 0 m 8 m 0 3 r 90 m 21 m 0 a r 8 m 0 b r 8 m 0 m a0 m 2 m 8 m 0 7 r a0 m 0 9 r 8 m 0 6 r 9 m a0 m 20 m a0
m 20 m 88 m 0 m a0 m 9 m a0 m 40 m 84 m 0 m 8 2 r 0 a r 84 m 0 m 10 m 0 m 2 m 11 m 90 m 0 25 r 40 m 84 m 41 m 0 7 r 20 m 0 m
20 m 0 3 r 21 m 0 m 21 m 0 m 21 m 0 12 r 1 m 0 6 r 2 m 0 3 r 21 m 0 m 2 m 0 7 r 8 m 0 m 20 3 r 0 5 r 3 m 0 m 3 m 0 m 5 m 0 m
21 m 0 m 21 m 0 m 10 m 0 m 21 m 0 m 21 m 0 5 r 8 m 0 13 r 40 m 0 6 r notbusy
02 wcmd 2 m 5f m 0 m \ 0x25f00 
0 5 r 84 m 0 11 r 1 m 0 14 r 5 m 0 7 r 20 m 0 f r 5 m 0 2 r 90 m 0 3 r 1 m 80 m 1 m 0 15 r 82 m 0 5 r a0 m 0 19 r 1 m 0 e r c0
2 r 90 m 0 2 r 8 m a0 2 r 0 7 r 1 m 0 2 r a0 m 0 2 r 1 m 0 m c1 m 0 a r 1 m 0 17 r a0 m 0 m 4 m 2 m 1 m 10 m c0 m 8 m 0 b r 1
m 0 3 r 1 m 0 1c r notbusy
20 wcmd 2 m 60 m 0 m notbusy \ 0x26000
02 wcmd 2 m 60 m 0 m \ 0x26000 
0 5 r 2 m 0 m 10 m 0 m 2 m 0 m 3 m 0 8 r 80 m 0 m 80 m 0 2 r 80 m 0 3 r 9 m 0 5 r 8 m 0 5 r 40 m 0 m 3 m 0 a r 20 m 0 17 r 80
m 0 3 r 4 m 80 3 r 0 9 r 2 m 0 m 3 m 0 m 2 m 0 m 8 m 0 21 r 80 m 0 5 r 8 m 0 6 r 80 m 0 10 r 3 m 0 m 3 m 0 5 r 3 m 0 b r 8 m 0
m 91 m 0 m 84 m 0 m 80 m 0 11 r 2 m 0 m 80 m 0 m 40 m 80 2 r 0 f r 3 m 0 18 r notbusy
02 wcmd 2 m 61 m 0 m \ 0x26100 
0 9 r c0 m 0 5 r 1 m 0 2 r c0 m 0 3 r 90 m 0 5 r 20 m 0 m a0 m 0 10 r 1 m 0 b r 1 m 0 m 21 m 0 m 2 m 0 m c0 m 0 10 r 2 m 1 m
84 m 10 m c0 m 2 m 10 m 82 m 0 9 r 82 m 0 5 r 82 m 0 22 r 1 m 0 11 r 90 m 20 m 90 m 8 m 0 4 r 1 m 0 a r c0 m 0 c r 10 m 0 m 40
m 0 13 r c1 m 10 m 40 m a0 m c0 m 4 m 1 m 88 m 0 a r 1 m 0 m 1 m 0 17 r notbusy
02 wcmd 2 m 62 m 0 m \ 0x26200 
0 e r 3 m 0 m 41 m 0 m 10 m 0 d r 80 m 0 2 r 80 m 0 2 r 3 m 0 m 5 m 0 m 10 m 0 13 r 9 m 0 3 r 80 m 0 m 9 m 0 11 r 90 m 0 2 r
80 m 0 2 r 2 m 0 b r 10 m 0 m 5 m 0 m 8 m 0 21 r 21 m 2 m 8 m 0 m 40 m 0 m 9 m 0 2 r 4 m 0 m 80 m 0 5 r 9 m 0 m 90 m 0 m 80 m
0 2 r 21 m 0 m 8 m 0 m 8 m 0 m 8 m 0 13 r 80 m 20 m 0 2 r 80 m 0 13 r 80 m 0 m 80 m 89 m 80 m 0 m 80 m 0 9 r 21 m 0 m 2 m 0 m
2 m 0 m 4 m 0 11 r notbusy
02 wcmd 2 m 63 m 0 m \ 0x26300 
0 10 r 1 m 0 m 1 m 0 8 r 2 m 0 m c0 m 0 5 r 40 m 0 m 2 m 0 2 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 4 r a0 m 0 e r 90 m 1 m 88 m 0 m
90 m 0 m 88 m 0 11 r 8 m 0 m 10 m 9 m 8 m 88 m 8 m 0 9 r 1 m 0 3 r 1 m 0 29 r 42 m 0 2 r 81 m 0 2 r b m 0 4 r 81 m 0 2 r b m 0
m 82 m 0 f r 48 m 0 e r 88 m 41 m 0 2 r a m 0 13 r d0 m b m 0 m 42 m 81 m 0 1c r notbusy
02 wcmd 2 m 64 m 0 m \ 0x26400 
0 28 r aa m 0 m aa m ff m 0 1a r 3c m e8 m ff m e8 m 0 14 r ff m ef m ff m 6d m 0 m 4d m 0 48 r ff 2 r 0 1b r e8 m c3 m e8 m 0
14 r ff m ef m ff m 6d m 0 m 41 m 0 1a r notbusy
02 wcmd 2 m 65 m 0 m \ 0x26500 
0 24 r 5f 2 r a 2 r 2f 2 r 7 2 r ff m 55 m ff 2 r 0 32 r 3f m ff m 3f m ff m af 2 r 7d m 28 m 0 3c r ff 2 r 0 2 r 2f 2 r 7 2 r
0 m 55 m 0 34 r ff 4 r 5 2 r 7d m 28 m 0 14 r notbusy
02 wcmd 2 m 66 m 0 m \ 0x26600 
0 1d r 61 m 0 m 6 m 0 m d m 0 5 r 20 m 0 2 r 1 m 0 4 r 28 m 0 5 r 61 m 0 m 6 m 0 m d m 0 14 r 5 m 61 m a m c6 m 35 m d m 0 m
a0 m 0 10 r 5 m 61 m a m 7 m 5 m d m 0 m a1 m 0 9 r 61 m 0 m 6 m 0 m d m 0 7 r 85 m 3 m 2 m 0 18 r 55 m 5f m 0 m a m 0 14 r ff
2 r cf m 0 42 r 14 m 0 4 r notbusy
02 wcmd 2 m 67 m 0 m \ 0x26700 
0 20 r 7d m 55 m 28 m 0 15 r ff 2 r c m 0 41 r 3 m c m 0 24 r cf m d7 m c m 14 m 0 14 r 55 2 r 41 2 r 0 3e r ff 2 r bf m ff m
notbusy
02 wcmd 2 m 68 m 0 m \ 0x26800 
0 24 r c3 m d7 m 0 m 14 m 0 14 r 14 2 r 0 40 r ff 4 r 0 22 r 80 m 0 m 10 m 1 m 0 4 r 1 m 43 m 0 m 1 m 48 m b8 m 2 m 0 m c9 m
c0 m 0 m 2 m 0 m 8 m 8a m 10 m 18 m 83 m 10 m 74 m 41 m f3 m 60 m c0 m d2 m 0 15 r 10 m 0 25 r notbusy
02 wcmd 2 m 69 m 0 m \ 0x26900 
0 10 r 4 m 0 m 4 m 0 3 r 88 m 0 7 r 20 m 0 8 r 80 m 0 16 r 20 m 0 7 r 88 m 0 b r 84 m 0 15 r 20 m 0 m 8 m 0 4 r 80 m 40 m 80 m
10 m 0 c r 20 m 0 10 r 20 m 0 7 r 20 m 0 10 r 20 m 0 6 r 21 m 0 22 r 3 m 0 18 r 80 m 0 4 r 4 m a1 m 4 m 0 c r notbusy
02 wcmd 2 m 6a m 0 m \ 0x26a00 
0 m 1 m 5 m 0 e r 4 m 0 26 r 1 m 0 9 r 1 m 0 a r 8 m 0 c r 84 m 0 2 r 80 m 0 d r 80 m 0 2 r 88 m 82 m 0 m c0 m 20 m 8 m 20 m
80 m 0 m 84 m 0 m 80 m 0 3 r 84 m 0 3 r 84 m 1 m a1 m 82 m 0 2 r 4 m 0 m 80 m 0 m 20 m 0 3 r 4 m 0 7 r 8 m 0 14 r 40 m 0 2 r
a0 m 0 2 r 8 m 0 2 r 8 m 0 m 84 m 0 2 r 40 m 0 m 5 m 0 7 r 40 m 0 10 r 8 m 0 3 r 8 m 0 3 r 84 m 0 m 2 m 0 3 r 8 m 0 5 r 84 m 0
3 r 2 m 0 3 r 11 m 0 m 3 m 80 m 1 m 80 m 4 m 0 m 21 m 0 m 4 m 0 3 r 3 m notbusy
02 wcmd 2 m 6b m 0 m \ 0x26b00 
0 3 r 20 m 4 m 20 m 10 m 0 2 r 1 m 0 m 20 m 0 m 1 m 0 2 r 20 m 0 6 r 4 m 0 16 r 1 m 0 15 r 20 m 0 4 r 8 m 0 8 r 1 m 0 8 r 21 m
0 2 r 2 m 0 8 r 2 m 0 m 3 m 0 m 5 m 0 m 21 m 0 m 21 m 0 m 2 m 0 5 r 80 m 40 m 0 2 r 3 m 0 m 20 m 0 m 20 m 0 m 40 m 0 m 20 m a0
m 40 m 0 m 40 m 0 m 2 m 0 m 20 m 0 m 21 m 0 m 20 m 0 3 r 9 m 0 2 r 40 m 0 19 r 4 m 0 7 r 40 m 0 2 r 8 m 0 2 r 21 m 0 m 20 m 8
m 0 b r 84 m 0 m 8 m 0 4 r 20 m 8 m 0 3 r 2 m 0 14 r 40 m 84 m 0 9 r 40 m 0 3 r 82 m 0 m 1 m notbusy
02 wcmd 2 m 6c m 0 m \ 0x26c00 
0 m 1 m 0 3 r a1 m 0 7 r 1 m 0 3 r 85 m 2 m 0 3 r 20 m 0 m 80 m 0 m 40 m 0 17 r 8 m 0 m c0 m 41 m 0 2 r c0 m 0 3 r a0 m 0 3 r
a0 m 0 m 8 m 0 5 r 82 m 0 3 r 82 m 0 7 r 5 m 0 9 r 40 m 4 m 0 m 4 m a0 m 4 m 0 m 4 m 82 m 0 5 r 8 m 0 m 82 m 5 m 0 m 41 m 0 2
r 1 m 5 m 0 5 r 40 m 83 m 0 6 r a0 m 0 m 85 m 0 m 80 m 0 m 80 m 1 m 80 m 1 m a0 m 0 3 r 80 m 0 m 80 m 0 m 88 m 0 3 r 10 m 1 m
0 2 r 10 m 0 1e r 9 m 0 19 r 20 m 0 a r 88 m 0 5 r a0 m 0 5 r 8 m 0 3 r a0 m 0 m a0 m 0 m a0 m 4 m 0 2 r a0 m 0 m 82 m 0 m 85
m 20 m 0 m notbusy
02 wcmd 2 m 6d m 0 m \ 0x26d00 
0 m a0 m 0 3 r 5 m 0 m 20 m 21 m 4 m 0 m 4 3 r 20 m 21 2 r 0 m 21 m 4 m 21 m 4 m 21 m 4 m 9 m 82 m 9 m 0 m 8 m 0 m 10 m 1 m 0
12 r 8 m 0 3 r 4 m 0 5 r 8 m 0 3 r 8 m 0 4 r 8 m 82 m 0 8 r 4 m 0 11 r 2 m 0 4 r a0 m 0 3 r 82 m 0 7 r 2 m 0 m 4 m 0 2 r 21 m
c0 m 0 2 r 21 m 2 m 0 4 r 8 m 0 m 3 m 0 5 r 11 m 2 m 11 m 0 3 r 20 m 0 m 20 m 0 c r 2 m 0 2 r 2 m 0 16 r 80 m 0 6 r 10 m 0 m
10 m 0 c r 3 m 0 4 r a0 m 0 3 r 2 m 0 m 40 m 0 9 r 2 m 0 m 84 m 0 5 r c0 m 0 m 84 m 0 3 r 8 m 0 4 r 80 m 0 2 r 84 m 0 6 r
notbusy
02 wcmd 2 m 6e m 0 m \ 0x26e00 
0 5 r c0 m 0 4 r 20 m 2 m 0 5 r 1 m 40 m 1 m 40 m 82 m 0 d r c0 m 0 18 r 40 m 0 3 r c0 m 0 3 r a0 m 0 m 8 m 0 8 r 8 m 0 4 r 82
m 0 a r 8 m 83 m 0 m 1 m 0 a r 40 2 r 4 m c0 m 0 2 r 8 m 0 3 r 21 m 0 2 r 82 m 0 4 r 21 m 10 m 20 m 0 m 40 m 0 m 41 m 9 m 0 m
10 m 3 m 0 m 85 m 1 m 0 m 40 m 85 m 41 m 5 m 40 m 20 m 40 m 5 m 0 m 21 m 0 m 20 m 0 2 r 8 m 20 m 8 m 0 4 r 3 m 0 3d r 2 m 20 m
0 m 20 m 0 4 r c0 m 0 m 8 m 0 m 84 m 0 m 8 m 11 m 0 m 20 m 8 m 0 m 8 m 0 3 r c0 m 0 m 8 m 0 4 r notbusy
02 wcmd 2 m 6f m 0 m \ 0x26f00 
0 3 r a0 m 0 m 1 m 0 2 r 40 m 0 4 r 20 m 4 m 82 m 0 m 20 m 4 m 0 2 r 1 m 3 m 0 4 r 1 m 0 2 r 41 m 1 m 0 6 r 20 m 0 1c r 90 m 0
m 2 m 0 5 r 90 m 88 m 4 m 0 5 r 90 m 2 m 40 m 0 5 r 90 m 0 m 40 m 0 5 r 90 m 0 m 40 m 0 6 r 1 m 90 m 8 m 4 m 0 2 r 1 m 0 2 r
90 m 0 4 r 1 m 0 2 r 4 m 40 m 0 4 r 1 m 11 m 0 m 84 m 0 4 r c1 m 0 m 90 m 8 m 0 4 r c0 m 0 m 90 m 1 m 0 b r 9 m 0 m 21 m 0 m
90 m 0 m 4 m 0 1c r 80 m 0 m 80 m 0 4 r 11 m 80 m 0 m 80 m 0 4 r 20 m 80 2 r 0 3 r 40 m 0 2 r 80 m 0 4 r 5 m 0 2 r 80 m 2 m 0
5 r 40 m 0 m 41 m 80 m 0 m 80 m 0 2 r 2 m 0 2 r 80 m 0 4 r 2 m 0 m 10 m 80 m notbusy
20 wcmd 2 m 70 m 0 m notbusy \ 0x27000
02 wcmd 2 m 70 m 0 m \ 0x27000 
80 m 0 4 r 41 m 88 m 11 m 80 m 20 m 0 m 10 m 40 m 91 m 11 m 85 m 80 m 9 m 0 2 r 5 m 80 m 0 m 80 m 8 m 0 7 r 9 m 0 3 r 89 m 0 m
a1 m 0 3 r 80 m 0 16 r 40 m 0 4 r 80 2 r 0 3 r 80 m 11 m 0 m 89 m 80 m 20 m 0 m 21 m 80 m 0 2 r 80 2 r 0 3 r 80 m 0 2 r 80 2 r
0 2 r 80 2 r 0 m 2 m 80 2 r 0 m 4 m 80 2 r 0 2 r 2 m 0 m 82 m 80 m 2 m 0 m a0 m 80 m 0 2 r 80 2 r 0 2 r 80 2 r 10 m 0 m 20 m
80 m 5 m 0 m 82 m 80 m 2 m 0 m 88 m 20 m 2 m 84 m 2 m 88 m 0 m 9 m 80 m 0 2 r 4 m 80 2 r 0 m 2 m 80 m 0 2 r 2 m 80 2 r 0 m 5 m
0 3 r 5 m 0 2 r 8 m 0 m 4 m 0 m 4 m 0 m a1 m 10 m 0 15 r 1 m 0 4 r 82 m 90 m 0 3 r 90 m 0 2 r 82 m 90 m 0 2 r 1 m 90 m 0 2 r
82 m 90 m 0 3 r 90 m 0 2 r 82 m 90 m 0 2 r c0 m 90 m 0 m 1 m 82 m 90 m 0 m 1 m c0 m 90 m 0 4 r 82 m 90 m 0 2 r c0 m 90 m 0 2 r
82 m 90 m 0 2 r c0 m 90 m notbusy
02 wcmd 2 m 71 m 0 m \ 0x27100 
1 m 0 2 r 90 m 1 m 0 m c0 m a0 m 90 m 2 m 9 m 0 m 90 m 83 m 90 m 89 m 0 2 r 82 m 0 2 r 1 m c0 m 90 m 0 m 1 m 82 m 0 2 r 1 m c0
m 90 m 0 3 r 84 m 0 3 r 84 m 11 m 0 m 21 m 0 m 9 m 0 m 83 m 0 19 r 1 m 0 2 r 2 m 90 2 r 0 2 r 1 m 0 2 r 40 m 90 m 4 m 0 2 r 1
m 0 2 r 40 m 90 m 40 m 0 7 r 90 m 0 m c0 m 0 2 r 84 m 40 m 90 m 40 m 0 4 r 1 m 0 4 r 91 m 0 m c0 m 2 m 0 4 r 90 m 0 m c0 m 1 m
0 2 r 4 m 90 2 r 2 m 1 m 0 m 1 m 0 3 r 1 2 r 0 3 r 3 m 0 2 r 90 m 1 m c0 m 0 2 r 82 m 0 2 r 90 m 1 m c0 m 0 2 r 4 m 0 m 88 m 0
4 r 90 m 0 m 40 m 2 m 41 m 0 m c0 m 0 18 r 11 m 0 2 r 80 3 r 0 2 r 11 m 2 m 0 m 80 2 r 90 m 0 m 10 m 11 m 40 m 0 m 85 m 80 m 3
m 0 m 20 m 0 5 r 80 m 0 m 80 m 0 3 r 80 2 r 0 m 9 m 0 3 r 11 m 2 m 0 m 10 m 0 m a1 m 0 m 82 m 80 m 0 3 r notbusy
02 wcmd 2 m 72 m 0 m \ 0x27200 
0 m 80 m 0 m 80 m 11 2 r 0 m 91 m 80 m 88 m 80 m 8 m 0 m 20 2 r 21 m 3 m 21 m 40 m 3 m 0 m 2 m 11 m 9 m 41 m 82 m 8 m 89 m 0 5
r 80 m 2 m 80 m 10 m 0 m 80 m 0 3 r 5 m 0 2 r 10 m 0 m 91 m 0 m 85 m 10 m 82 m 0 18 r 80 m 2 m 80 2 r 0 4 r 80 m 85 m 0 2 r 80
2 r 0 2 r 80 m 5 m 0 6 r 80 m 11 m 80 m 0 5 r 80 m 11 m 80 m 0 7 r 80 m 0 3 r 80 m 0 2 r 20 m 80 m 11 m 80 m 0 5 r 80 m 5 m 80
m 0 4 r 10 m c1 m 21 m 3 m 80 m 5 m 80 m 11 m 8 m 80 m 11 m 0 6 r 80 m 11 m 80 m 0 d r 8 m a0 m 8 m 2 m 8 m 80 m 0 m 9 m 0 18
r 90 m 1 m 2 2 r 0 4 r 90 m 2 m 0 2 r 4 2 r 0 2 r 90 m 0 m 40 2 r 0 4 r c0 m 1 m 20 m 0 5 r c0 m 1 m 20 m 0 7 r 90 m 88 m 0 2
r 4 m 0 3 r notbusy
02 wcmd 2 m 73 m 0 m \ 0x27300 
c0 m 1 m 20 m 0 5 r 90 2 r 4 m 0 2 r 88 m 0 2 r c1 m 9 m 0 m 10 2 r 8 m 3 m 1 m 90 m 0 7 r c0 m 1 m 20 m 0 d r 1 m c0 m 1 m 10
m 1 m 82 m 0 13 r 11 m 0 2 r b m 0 4 r 81 m 0 2 r b m 0 4 r 81 m 0 2 r b m 0 4 r 81 m 0 2 r b m 0 4 r 41 m 0 2 r b m 0 4 r 41
m 2 m d0 m b m 0 6 r 41 m 0 2 r b m 0 m 41 m 0 2 r 41 m 0 2 r b m 0 4 r 81 m 0 2 r b m 0 6 r d0 m 0 5 r 41 m 0 m 88 m 81 m 0 4
r 41 m 0 m d0 m 81 m 0 5 r 2 m d0 m 41 m 0 9 r 42 m 0 19 r ff m 0 2 r ff m f0 m f m f0 m f m f0 2 r f 2 r f0 m f m f0 m f m ff
m 0 2 r ff m f0 m f m f0 m f m ff m 0 3 r ff m 0 3 r ff m 0 3 r f m f0 m f m f0 m 0 2 r f 2 r f0 2 r notbusy
02 wcmd 2 m 74 m 0 m \ 0x27400 
ff m 0 3 r ff m 0 3 r ff m 0 4 r ff 2 r 0 m f0 m f m f0 m f m 8 2 r 4 2 r 0 4 r ff 2 r 0 2 r ff m 0 3 r ff m 0 3 r ff m 0 f r
ff m f0 m 3c m 66 m 0 18 r ff m 0 2 r ff m f0 m f m f0 m f m f0 2 r f 2 r f0 m f m f0 m f m ff m 0 2 r ff m f0 m f m f0 m f m
ff m 0 3 r ff m 0 3 r ff m 0 3 r f m f0 m f m f0 m 0 2 r f 2 r f0 2 r ff m 0 3 r ff m 0 3 r ff m 0 4 r ff 2 r 0 m f0 m f m f0
m f m 0 8 r ff 2 r 0 2 r ff m 0 3 r ff m 0 3 r ff m 0 10 r f0 m 3c m 66 m ff 42 r notbusy
02 wcmd 2 m 75 m 0 m \ 0x27500 
ff 40 r 0 m 16 m ea m ad m 30 m 22 m 2 m a m 0 m 18 m 50 m 60 m 0 2 r f m 7d m 0 14 r ff 4 r f0 m f m f0 m f m 96 4 r f0 m f m
f0 m f 5 r f0 m f m f0 m f m 96 4 r f0 m f m f0 m f m 0 2 r f 2 r f0 m f m f0 m f m ff 2 r f0 2 r 0 2 r f m f0 m f m f0 m ff 2
r f0 2 r 0 m ff m 0 m ff m 0 2 r f 2 r 99 m 66 m 99 m 66 m ff 2 r 0 6 r 24 2 r bd 2 r 0 3 r ff m 0 2 r f 2 r 0 3 r ff 3 r f0 2
r 0 c r 40 m 0 m 40 m 18 m 0 14 r ff 4 r f0 m f m f0 m f m 96 4 r f0 m f m f0 m f m f0 5 r f m f0 m f m 96 2 r notbusy
02 wcmd 2 m 76 m 0 m \ 0x27600 
96 2 r f0 m f m f0 m f m 0 2 r f 2 r f0 m f m f0 m f m ff 2 r f0 2 r 0 2 r f m f0 m f m f0 m ff 2 r f0 2 r ff m 0 m ff m 0 3 r
f 2 r 99 m 66 m 99 m 66 m ff 4 r 0 4 r 9 m 6f m 9 m 6f m 0 3 r ff m 0 2 r f 2 r 0 3 r ff 3 r f0 2 r 0 f r 18 m 0 13 r 20 m 0 2
r 10 m c0 m 3 m 0 m 3 m 20 m c m 0 m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 80
m 3 m 20 m c m 0 m 92 m c0 m 3 m e5 m 3 m 27 m c m d m 12 m c0 m 0 2 r 3 m 61 m 3 m 26 m c m d m 92 m c0 m 3 m 80 m 3 m 20 m c
m 0 m 92 m c0 m 3 m 61 m 3 m 26 m c m d m 2 m c0 m a0 m 61 m 0 m 6 m 0 m d m 0 m 1 m 3 m 63 m 3 m a6 m 2c m d m 92 m c0 m 3 m
e7 m 3 m 27 m c m f m a2 m c0 m 5 m 61 m a m 47 m 15 m f m 20 m a0 m 0 m 61 m 0 m 6 m 0 m 9d m 0 26 r aa 4 r 0 2 r notbusy
02 wcmd 2 m 77 m 0 m \ 0x27700 
0 4 r ff m 0 17 r b0 m ff m f0 m ff m 0 c r 30 2 r 3f m 3a m f0 m 3c m 14 2 r 3a m fa m ff 2 r 0 4 r 50 2 r fa 2 r 0 12 r f m
0 2 r f0 m 80 m f0 m 0 24 r aa m 28 m aa 2 r 0 6 r fe m 0 17 r 80 m ff m f0 m ff m 0 c r 30 m 0 m 3f m a m f0 m 0 m 14 2 r a m
fa m a m fa m 0 4 r 14 m be m 14 m be m 0 15 r f0 m 0 m f0 m 0 24 r 3 m c3 m notbusy
02 wcmd 2 m 78 m 0 m \ 0x27800 
3f m ff m 0 1f r 38 m 0 m fb m 0 c r aa m ff m fb 2 r 0 m 30 m 0 m 10 m 0 m a0 m 3c m bc m 5f m 50 m 5f m 50 m 0 18 r af 2 r
ff 2 r 0 25 r c0 m 3c m fc m 0 1f r 8 m 0 m cb m 0 c r aa m ff m aa 2 r 0 m 30 m 0 4 r 3c 2 r ff m f0 m f m 0 19 r a0 m ac m
ff 2 r 0 6 r 4 m 0 m 20 m 0 m 88 m 0 3 r 88 m 0 7 r 20 m 0 b r notbusy
02 wcmd 2 m 79 m 0 m \ 0x27900 
0 6 r 20 m 0 m 1 m 0 3 r 20 m 0 10 r 10 m 0 a r 20 m 0 5 r 20 m 0 6 r 10 m 0 9 r 8 m c0 m 0 7 r 20 m 0 7 r 4 m 0 7 r 1 m 0 3 r
c0 m 0 2 r 80 m 0 2a r 8 m 0 14 r 1 m 0 m 2 m 0 38 r 8 m 0 4 r 90 m 0 m 10 m 0 1e r notbusy
02 wcmd 2 m 7a m 0 m \ 0x27a00 
0 8 r 84 m 0 m 1 m 80 m 0 3 r 80 m 0 m 80 m 0 19 r 80 m 0 m 9 m 0 4 r 1 m 0 e r 9 m 0 9 r 80 m 0 3 r 2 m 0 10 r 4 m 0 m 84 m 0
6 r 8 m 0 9 r 84 m 0 15 r 8 m 0 2 r 2 m 40 m 0 3 r 10 m 41 m 10 m 0 17 r 88 m 0 m 40 m 0 6 r 40 m 0 2 r 4 m 0 5 r 10 m 0 m 4 m
0 m 2 m 0 m 90 m 0 5 r 8 m 0 m 2 m 0 m 40 m 0 3 r 1 m 0 4 r 5 m 0 4 r 4 m 0 m a0 m 5 m 0 m 5 m 0 m 85 m 0 2 r 4 m 0 9 r 8 m 0
3 r 8 m 0 c r notbusy
02 wcmd 2 m 7b m 0 m \ 0x27b00 
0 5 r 5 m 0 17 r 21 m 0 m 2 m 0 m 8 m 0 m 85 m 1 m 21 m 0 9 r c0 m 0 2 r 1 m 80 m 0 3 r 3 m 0 m 3 m 0 m 41 m 0 3 r 10 m 0 m 5
m 0 m 3 m 0 m 2 m 0 5 r 41 m 0 m 41 m 0 m 8 m 0 m 10 m 20 m 8 m 0 m 41 m 0 3 r 41 m 0 5 r 40 m 88 m 21 m 0 m 21 m 0 m 8 m 0 1e
r 41 m 0 5 r 3 m 0 3 r 8 m 0 6 r a0 m 0 m a0 m 0 3 r 84 m 0 9 r 2 m 40 m 0 3 r 20 m 0 6 r 2 m 0 2 r 4 m 40 m 0 6 r 20 m 0 m 9
m 8 m 0 m 1 m 0 m a0 m 0 5 r c0 m 0 5 r 2 m 0 7 r a0 m 0 m 84 m 0 2 r 2 m 0 4 r 88 m 0 m 40 m 0 2 r 11 m 0 2 r 82 m 0 a r 8 m
0 7 r 8 m 0 3 r notbusy
02 wcmd 2 m 7c m 0 m \ 0x27c00 
0 2 r 8 m 0 m 82 m 0 3 r 8 m 0 9 r 8 m 0 m 8 m 0 b r 8 m 0 5 r 40 m 0 a r 8 m 1 m 0 m 1 m 80 m 0 m a0 m 0 5 r 3 m 0 m 40 m 0 m
41 m 0 m 10 m 4 m 0 6 r 88 m c0 m 0 d r 8 m 0 5 r 40 m 0 m 4 m 0 m 4 m 0 2 r 20 m 0 2 r 1 m 0 f r 8 m 0 16 r 10 m 0 2 r 80 m 0
f r 3 m 0 3 r 80 m 0 b r 8 m 0 m 4 m 20 m 0 m 11 m 3 m 90 m 0 m 82 m 0 m c0 m 0 m 1 m 0 3 r a1 m 80 m 4 m 0 m 82 m 0 m 90 m 0
m 20 m 9 m 84 m 0 4 r 40 m a0 m 0 9 r 8 m 0 6 r 80 m 0 2 r 1 m 11 m 0 m 4 m 10 m 0 f r 8 m 0 2 r notbusy
02 wcmd 2 m 7d m 0 m \ 0x27d00 
0 4 r 8 m 0 1b r 2 m 0 4 r 8 m 4 m 8 m 0 2 r 4 m 0 4 r 3 m 0 m 40 m 0 4 r 20 m 21 m 0 m 41 m 0 m 21 m 0 3 r 3 m 0 m 41 m 0 3 r
41 m 1 m 0 2 r 41 m 5 m 0 m 1 m 0 m 1 m 41 m 0 m 5 m 0 7 r 3 m 0 7 r 40 m 0 3 r 40 m 90 m 21 m 88 m 0 4 r 8 m 0 m 8 m 0 27 r 8
m 0 10 r 80 m 0 3 r 80 m 0 8 r 2 m 0 3 r 8 m 0 8 r 9 m 4 m 0 4 r 8 m 84 m 0 m 40 m 84 m a0 m 4 m 88 m 4 m 88 m 0 m a0 m 0 6 r
3 m 0 5 r 20 m 82 m 0 m 82 m 0 5 r 2 m 0 2 r 20 m 88 m 0 m 2 m 3 m 84 m 0 m 3 m 0 c r notbusy
02 wcmd 2 m 7e m 0 m \ 0x27e00 
0 19 r 21 m 0 9 r 8 m 0 m 3 m 0 m 5 m 0 4 r 4 m 40 m 0 m 8 m 4 m 0 4 r 2 m 0 m 8 m 0 m 3 m 83 m 0 2 r 4 m 0 m 84 m 0 m 84 m 1
m 4 m 0 m 3 m 0 m 21 m 0 m 21 m 0 m 8 m 0 m 80 m 0 2 r 1 m 0 2 r 2 m 0 m 41 m 0 m 5 m 0 3 r 5 m 0 m 9 m 0 m 41 m 0 2 r 1 m 41
m 0 7 r 8 m 0 2 r 2 m 0 3f r 80 m 1 m 0 2 r 80 m 0 3 r 9 m a0 m 9 m 82 m 20 m 0 m 8 m 0 2 r 1 m 0 m 11 m 0 m 21 m 4 m 1 m 0 m
c0 m 9 m 0 3 r 20 m 0 2 r 20 m 0 2 r 4 m 0 4 r 90 m 0 3 r 88 m 0 m 2 m 0 m 88 m 0 m a0 m 0 m 88 m 8 2 r 0 4 r 11 m 0 4 r 8 m
80 m 82 m 0 3 r c0 m 0 a r notbusy
02 wcmd 2 m 7f m 0 m \ 0x27f00 
0 1e r 8 m 2 m 0 m 2 m 0 m 88 m 40 m 10 m 0 13 r a0 m 0 m 2 m 10 m a0 m 10 3 r 88 m 0 m 90 m 40 m 88 m c0 m 90 m 0 10 r c0 m
88 m 0 3 r 10 m 0 m a0 m 0 m 1 m 10 m 1 m 0 d r 20 m 0 m 10 m 0 m 2 m 8 m 20 m 0 3a r 11 m 0 8 r 80 m 11 m 0 m 80 4 r 8 m 0 m
21 m 0 16 r 80 m 0 3 r 80 m 0 3 r 20 m 0 m 40 m 0 m 10 m 0 d r 80 m 0 2 r 80 m 0 7 r notbusy
20 wcmd 2 m 80 m 0 m notbusy \ 0x28000
02 wcmd 2 m 80 m 0 m \ 0x28000 
0 25 r 11 m 80 m 0 b r 90 m 0 m 80 m 0 m 9 m 0 m c1 m 80 m 0 4 r 80 m 20 m 80 3 r 0 m 80 m 20 m 0 m 80 2 r 3 m 0 m 80 m 0 4 r
80 m 0 m 80 m 0 4 r 80 m 0 3 r 80 m 0 c r 80 m 0 2 r 10 m 0 8 r 80 m 0 m 80 m 41 m 80 m 88 m 0 2a r 40 m 0 m 90 m 0 m a0 m 10
m 20 m 0 9 r 2 m 0 m 8 m 4 m 10 m 0 m c1 m c0 m 0 2 r 2 m 0 m 2 m 0 m 10 m 8 m 4 m 0 m 8 m 1 m 0 m 8 m a0 m 0 m 4 m 8 m c0 m 0
m 4 m 0 m 10 m 0 m c0 m 0 4 r 8 m 0 3 r 8 m 0 8 r 90 m 0 m 90 m 0 m 82 m 0 m 10 m 1 m 0 8 r 10 m 0 m 8 m 82 m a0 m 3 m 88 m 82
m 0 2 r notbusy
02 wcmd 2 m 81 m 0 m \ 0x28100 
0 26 r 8 m 20 m 0 m 8 m 0 m 90 m 0 m c0 m 0 9 r 1 m 0 2 r 40 m 1 m 0 4 r 20 m 90 m 0 m 9 m 10 m 5 m c0 m 8 m 4 m 90 m 10 m 11
m 8 m c0 m 10 m 5 m 0 c r 2 m 0 3 r 8 2 r 0 m 10 m 0 m 90 m c0 m 4 m 0 10 r 9 m 90 m 0 m 4 m 82 m 10 2 r 4 m 0 28 r 80 m 0 6 r
80 m 0 8 r 9 2 r 0 m 40 m 80 m 40 m 0 m 4 m 0 3 r 10 m 0 m 90 m 80 m 40 m 0 m 80 m 2 m 10 m 0 m 88 m 80 m 2 m 90 m a0 m 0 8 r
10 m 0 7 r 80 2 r 0 8 r 2 m 0 d r 2 m 0 5 r notbusy
02 wcmd 2 m 82 m 0 m \ 0x28200 
0 2b r 40 m 80 3 r 0 c r 20 m 0 m 80 m 0 3 r 2 m 0 2 r 80 m 0 m 80 2 r 0 m 80 m 0 22 r 21 m 2 m 40 m 80 m 8 m 80 m 40 m 0 a r
4 m 80 m c1 m 0 m 80 m 0 2a r 10 m 0 m 8 m 20 m 8 m 40 m 88 m 0 a r 89 m 0 m 10 m 0 m 10 m 0 4 r 8 m 0 m 40 m 4 2 r 2 m 0 5 r
4 m 0 m 20 m 0 5 r 4 m 0 m c0 m 0 12 r 1 m 0 m 1 m 10 m 1 m 40 m 0 a r 88 m 1 m notbusy
02 wcmd 2 m 83 m 0 m \ 0x28300 
a0 m 11 m 10 m 40 m 4 m 0 3d r 41 m 0 2 r a m 0 d r 88 m 41 m 0 f r 41 m 0 1f r b m 0 m 42 m 0 29 r 28 m f0 m c3 m f0 m 0 m 1
m 0 m a0 m 0 12 r a0 m ff m af m ff m 0 m 3c m 0 m 3c m 0 4 r 3c m a0 m 3c m af m 0 15 r ff m 0 m fe m 0 e r notbusy
02 wcmd 2 m 84 m 0 m \ 0x28400 
0 32 r 28 m f0 m 0 m f0 m 0 3 r a0 m 0 12 r a0 m f m af m f m f0 m 0 m f0 m ff m 0 5 r a0 m 0 m af m 0 15 r ff m 0 m fe m 0 10
r 4 m 34 m 4 2 r 0 3 r 3 m 0 28 r 3f 3 r f m 54 m 55 3 r 0 e r 8 m 0 3 r 2f m ff m 2f m 28 m 7d m cf m 41 m cf m af 2 r 5 2 r
aa m 82 m aa 2 r 0 4 r 80 2 r ff m bf m 0 8 r 5f 2 r a 2 r 0 8 r b0 m 0 5 r notbusy
02 wcmd 2 m 85 m 0 m \ 0x28500 
0 6 r 3f m 3d m f m 5 m ff m 3c m ff m 0 29 r 3c 3 r 0 m 55 4 r 0 c r 8 m 0 5 r f m ff m f m 0 m 7d m c m 41 m c m be m 14 m
be m 14 m aa m 82 3 r 0 4 r 80 2 r df m 9f m 0 8 r 7d 2 r 28 2 r 0 8 r 10 m 0 b r 3c 2 r 0 2 r ff m 3f m ff m 1f m 0 2d r 90 m
0 a r 5 m 61 m a m 46 m 15 m d m 0 m a5 m 0 3 r 61 m 40 m 6 m 0 m d m 0 2 r 5 m 61 m a m c6 m 35 m d m 0 m a1 m 0 7 r 5 2 r 0
m a m 40 m 15 m 0 2 r a0 m 0 2 r 40 m 0 2 r 10 m 0 3 r 61 m 0 m 6 m 0 m d m notbusy
02 wcmd 2 m 86 m 0 m \ 0x28600 
0 a r 5 m 0 m a m 8 m 5 m 0 2 r a1 m 0 3d r f0 m 3c 2 r 0 6 r a0 m f5 m a0 m f5 m 0 4 r f5 m 0 m f5 2 r 0 18 r ff 2 r f m 3c m
0 51 r ff m 3c 2 r 0 6 r 7d 4 r 0 4 r c1 m 0 m c1 2 r 0 18 r ff 2 r notbusy
02 wcmd 2 m 87 m 0 m \ 0x28700 
0 52 r 28 m 3c m aa m 0 2b r 55 m f m 0 53 r 3c m 0 2a r notbusy
02 wcmd 2 m 88 m 0 m \ 0x28800 
0 2 r 55 m f m 0 1c r 84 m 0 3 r c0 m 0 3 r 20 m 0 7 r 84 m 0 f r 4 m 0 7 r 20 m 0 7 r 20 m 0 7 r 4 m 0 9 r 20 2 r 0 2 r 1 m 0
3 r 20 m 0 2 r 80 m 0 m 40 m 0 2 r 40 m 0 5 r 82 m 0 2 r 9 m 0 6 r 2 m 0 2 r 8 m 0 4 r 8 m 0 m 1 m 0 3 r 10 m 0 m 88 m 8 m 41
m 0 m 1 m 5 m 0 m 21 m 40 m 0 7 r 20 m 0 3a r 3 m 0 7 r 1 m 0 2 r 8 m 4 m 0 5 r 20 m 11 m 1 m 0 e r notbusy
02 wcmd 2 m 89 m 0 m \ 0x28900 
0 m c0 m 0 a r 83 m 0 m 10 m 0 3 r 80 m 0 m 41 m 1 m c0 m 0 m 40 m 0 3 r 82 m 0 4f r 8 m 0 4 r 4 m 0 13 r 41 m 0 m 41 m 0 3 r
80 m 0 2 r c0 m 0 4 r 8 m 0 4 r 1 m 0 3 r 40 m 88 m 0 m 8 m 0 19 r 84 m 0 7 r 8 m 0 7 r 8 m 0 2 r 4 m 0 9 r 4 m 0 c r 84 m 0 7
r 10 m 0 7 r 83 m 0 m 82 m 0 m 8 m 0 8 r notbusy
02 wcmd 2 m 8a m 0 m \ 0x28a00 
0 m 84 m 0 4 r 41 m 0 2 r 8 m 0 m 10 m 0 m 2 m 0 7 r 1 m 0 m 10 m 0 2 r 40 m 0 2 r 82 m 80 m 4 m 9 m 0 1f r 8 m 0 a r 10 m 0 6
r 4 m 0 2 r 8 m 0 b r 8 m 0 3 r 80 m 0 2 r 82 m 0 m 1 m 80 m 0 3 r 3 m 0 3 r 11 m 0 m 40 m 4 m 89 m 0 m 21 m 10 m 80 m 0 2 r
20 m 10 m 0 2 r 40 m 2 m 0 m 2 m 0 3 r a1 m 0 3 r 10 m 0 4 r 84 m 5 m 2 m 0 4 r 9 m 1 m 0 2 r 4 m 0 m 4 m 20 m 9 m 40 m 41 m 0
m 8 m 0 m 82 m 0 1c r 5 m 0 5 r 8 m 0 9 r 80 m 8 m 0 m 82 m 0 m 8 m 0 2 r 41 m 0 m 41 m 0 4 r a0 m 0 3 r 10 m 0 m a0 m 0 m a0
m 40 m 10 m 0 m 84 m 0 m 8 m 0 m 84 m 0 m c0 m 0 m a1 m 0 m 20 m 0 2 r 80 m 20 m 3 m a0 m notbusy
02 wcmd 2 m 8b m 0 m \ 0x28b00 
0 5 r 1 m 0 m 11 m 0 3 r 8 m 0 5 r a0 m 0 m 2 m 0 2 r 3 m 2 m 0 m 88 m 41 m 88 m 20 m 0 m 9 m 1 m 0 m 1 m 0 2 r c0 m 82 m 0 e
r 82 m 0 11 r a0 m 0 m a0 m 0 m a0 m 0 m a0 m 0 d r 4 m 0 m 4 m 0 d r 91 m 0 5 r 11 m 0 5 r 2 m 0 3 r 1 m 80 m 40 m 80 m 9 m
80 m 0 6 r 82 m 0 m 88 m 0 m 2 m 80 m c0 m 0 m 8 m 0 3 r 88 m 0 3 r 40 m 0 m 82 m 0 m 1 m 0 3 r 8 m 80 m 40 m 0 m 82 m 0 m 4 m
0 m c0 m 80 m 0 36 r 80 m 0 d r 4 m 0 5 r 2 m 8 m 0 2 r 9 m 88 m c0 m 0 3 r 8 m 4 m 0 m 4 m notbusy
02 wcmd 2 m 8c m 0 m \ 0x28c00 
10 m 4 m 0 m c0 m 0 m 88 m 0 3 r 84 m 0 3 r 2 m 0 m 10 m 0 2 r 40 m 90 m 0 4 r 2 m 82 m 0 2 r 20 m 0 4 r 4 m 80 m 0 4 r 20 m 0
m 4 m 0 9 r 8 m 0 28 r 4 m 0 m 4 m 0 4 r 3 m 0 7 r 3 m 1 m 0 4 r 20 m 0 m 8 m 1 m 41 m 0 m 90 m 1 m 0 m 1 m 89 m 0 m 3 m 0 3 r
10 m 1 m 10 m 0 m 2 m 0 m 5 m 0 2 r 8 m 5 m 0 7 r 4 m 20 m 0 m 2 m 0 2 r 8 2 r 0 m 2 m 0 m 82 m 5 m 20 m 2 m 0 m 3 m 88 m 4 m
2 m 80 m 2 m 4 m 90 m 0 29 r 21 m 2 m 8 m 0 4 r a0 m 0 2 r 80 m 0 m 80 m 0 6 r a0 m 0 6 r 4 m 0 4 r 1 m 3 m 0 m 4 m 0 2 r 20 m
4 m 88 m 8 m 20 m 0 2 r notbusy
02 wcmd 2 m 8d m 0 m \ 0x28d00 
20 m 0 2 r 1 m 40 m 0 2 r a0 m 0 5 r c0 m 0 2 r 5 m 0 5 r 11 m 0 3 r 21 m 0 m 21 m 90 m 0 m 8 m 0 2 r 80 m 0 2 r 10 m 0 m 4 m
0 m 10 m 0 m 4 m 40 m 10 m 0 18 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 84 m 0 2 r 21 m 0 22 r 1 m 0 6 r 21 m 0 3 r 11 m 0 m 10 m 1
m 91 m 0 m 20 m 1 m 0 2 r 21 m 0 m 8 m 0 m 10 m 0 5 r 11 m 82 m 0 m 82 m 5 m 0 m 21 m 0 m 11 m 0 2 r 20 m 4 m 0 m 4 m 0 m 3 m
1 m 8 m 20 m 5 m 40 m 41 m 88 m 21 m 8 m 0 m 4 m a1 m 0 18 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 27 r 4 m 0 9 r notbusy
02 wcmd 2 m 8e m 0 m \ 0x28e00 
0 2 r 20 m 0 m 40 m 10 m 0 m 1 m 2 m 0 5 r 20 m 8 m 0 13 r 1 m 0 2 r 20 m 0 m 21 m 0 m 80 m 0 2 r 40 m 0 m 20 m 0 m 10 m 0 42
r 4 m 0 3 r 4 m 0 m 4 m 0 2 r c0 m 0 m 88 m 0 m 10 m c0 m 10 m c0 2 r 10 m 4 m 83 m 0 2 r 10 m 0 2 r 1 m 0 m 8 m 0 4 r 1 m 0 6
r 8 m 10 m 0 m 10 m 0 m 3 m 10 m 2 m 1 m 0 m 20 m 0 5 r 88 m 0 4 r 3 m 40 m 5 m 0 42 r 11 m 0 m 4 m 0 6 r 80 m notbusy
02 wcmd 2 m 8f m 0 m \ 0x28f00 
0 3 r 80 m 0 2 r 80 2 r 0 2 r 20 m 0 2 r 80 m 0 2 r 40 m 0 6 r 41 m 0 m 9 m 0 3 r 9 m 91 m 88 m 0 m 88 m 0 m 5 m 80 m 40 m 11
m 0 m 80 m 0 m 40 m 0 2 r 3 m 0 m 11 m 0 m 8 m 0 m 8 m 0 m 21 m 0 42 r 88 m 0 m 11 2 r 41 m 0 m 11 m 0 3 r 80 m 0 m 80 m 0 3 r
82 m 20 m c0 m 0 m 40 m 9 m 80 m 11 m 0 9 r 80 m 0 5 r 8 m 80 m 0 2 r 21 m 80 3 r 40 m 0 m 40 m 20 m 0 2 r 10 m 0 2 r 84 m 89
m 10 2 r 90 m 9 m 21 m 4 m 0 1b r 8 m 0 3 r 40 m 0 13 r 40 m 0 3 r 40 m 0 a r 89 m 0 m a1 m 84 m c0 m 2 m notbusy
20 wcmd 2 m 90 m 0 m notbusy \ 0x29000
02 wcmd 2 m 90 m 0 m \ 0x29000 
5 m 84 m 90 m 0 m 8 m 20 m 10 m 0 2 r 20 m 10 m 1 m 8 m 84 m 89 m 0 m 82 m 84 m 0 9 r 8 m 0 5 r 1 m a0 m c0 m 90 m 0 m a0 m 8
2 r 85 m 0 m 1 2 r 0 2 r 1 m 0 2 r a0 m 2 m c1 m 0 m a1 m 0 m 9 m 0 19 r 1 m 0 3 r 4 m 0 17 r 40 m 0 d r 1 m 89 m 0 m 88 m 84
m c1 m 0 m 9 m 10 m 4 m 0 m 10 m 20 m a0 m 10 m 88 m 10 m 9 m 84 m 9 m 8 m 5 m 1 m c0 m 0 a r 1 m 0 5 r c0 m 4 m 0 m 40 m 10 m
a0 m 2 m 82 m 0 m 1 m c0 m 0 6 r 3 m 8 m 2 2 r 10 2 r 84 m 0 18 r 4 m 0 17 r 40 m 0 11 r 4 m 20 m notbusy
02 wcmd 2 m 91 m 0 m \ 0x29100 
0 m 11 m 0 m 21 m 0 m a0 2 r 0 2 r 80 m 0 3 r 80 m 84 m 82 m 0 m c0 m 80 m 21 m 4 m 84 m 0 m 11 m 0 m 9 m 0 3 r 9 m 0 2 r 40 m
0 5 r 80 m 0 2 r 80 m 41 m 0 m 80 m 0 2 r 9 m 80 m 0 3 r 8 m 0 2 r 90 m 91 m 0 m 2 m 3 m 5 m 2 m 0 1b r 9 m 0 27 r 80 2 r 0 2
r 80 m 0 m 4 m 0 3 r 80 m 0 4 r 41 m 11 m 4 m 90 m 41 m 0 2 r 8 m 0 8 r 21 m 0 m 40 m 0 m 9 m 0 m 20 m 0 m a1 m 2 m 90 m c0 m
10 m 0 m 3 m 0 2 r 9 m 0 2 r 9 m 0 3 r 21 m 91 m 84 2 r 40 m 0 m 3 m 10 m 0 40 r notbusy
02 wcmd 2 m 92 m 0 m \ 0x29200 
0 2 r 82 m 90 m 8 m a0 m 2 m 10 m 88 m 0 4 r a0 m 0 m 90 m 0 2 r 1 m 0 2 r 10 m 0 m 2 m 0 m 1 m 0 8 r 1 m 0 3 r 1 m 0 3 r 11 m
1 m 8 m a1 m 3 m 88 m 3 m 0 5 r 1 m 0 3 r 9 m 40 m 21 m a0 m 3 m 88 m 5 m 0 1d r b m 0 17 r 41 m 0 11 r 41 m 0 7 r 41 m 0 6 r
d0 m b m 4 m 41 m 0 17 r 42 m 0 m 81 m 0 2 r d0 m 0 2 r 82 m 0 4 r 88 m 0 40 r notbusy
02 wcmd 2 m 93 m 0 m \ 0x29300 
0 6 r 6 m 0 3 r f0 m ff m f0 m 0 5 r ff m 3f m c3 m 3 m 0 4 r 3c m 0 m 60 m 0 13 r 1 m 0 m f6 m 76 m f0 m 30 m 0 8 r ff m f3 m
ff m cf m fc m 3c m 7c m 3c m 0 42 r 26 m 0 m 20 m 0 m 3c m 66 m 3c m 66 m 0 4 r fc m 3c m c0 m 0 5 r 3c m 0 m 60 m 0 15 r 66
2 r 0 a r ff m f3 m ff 2 r f0 m 0 m 60 m 0 m ff 38 r notbusy
02 wcmd 2 m 94 m 0 m \ 0x29400 
ff 4a r 0 m 3b m 8a m e3 m 30 m 22 m 2 m c m 0 m 18 m 50 m 60 m 0 2 r e m fb m 0 46 r 3c m ff m 66 m f m 36 2 r f m ff m f6 m
36 m f6 m 36 m 0 6 r 4 m 0 11 r 8 m 0 m 8 m 0 m 3c m 66 m 3f m 6f m 0 8 r f7 4 r 0 m 9 m 0 26 r notbusy
02 wcmd 2 m 95 m 0 m \ 0x29500 
0 22 r 3c m 0 m 66 m f m 36 2 r 0 m f0 m 6 m 36 m 6 m 36 m 0 m 3c 2 r 0 17 r 40 m 0 3 r f 2 r 0 8 r f7 4 r 3 2 r 0 1a r 5 m 8
m a m 8 m 5 m 0 2 r a0 m 0 10 r 5 m 0 m a m 40 m 15 m 0 2 r a0 m 0 a r 5 m 61 m a m 46 m 15 m 1d m 0 m a0 m 5 m 0 m 5a m 40 m
15 m 10 m 0 m a0 m 5 m 61 m 5a m f m 5 m 9f m 24 m a1 m 0 m 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 6 m
0 m d m 0 5 r 7 m 80 m c m 0 3 r 61 m 0 m 86 m 20 m d m 0 22 r notbusy
02 wcmd 2 m 96 m 0 m \ 0x29600 
0 26 r a8 m ad m f8 m fd m 0 8 r f m 0 3 r 8 m ff m a8 m ff m 0 4 r af 2 r fc 2 r 54 2 r fc 2 r 0 4 r df m 9e m 5d m 1c m 0 6
r f 2 r 3c 2 r 0 2 r 7f 2 r 57 2 r 0 m 3c m 0 48 r 8 m d m 58 m 5d m 0 a r f0 m 0 m 8 m ff m a8 m ff m 0 4 r af 2 r c 2 r 0 m
54 m 0 m fc m 0 4 r cb m 8a m 49 m 8 m 0 6 r f 2 r 3c 2 r 0 2 r ff m c m ff m c m 0 m 3c m 0 1e r notbusy
02 wcmd 2 m 97 m 0 m \ 0x29700 
0 2a r 51 m d3 m 79 m fb m 0 c r 28 m a0 m 28 m a0 m 0 9 r 82 m 28 m 0 5 r 3c 4 r 0 6 r 3c 2 r f0 2 r 0 4 r 20 m 0 3 r 80 2 r
0 46 r 10 m 92 m 38 m ba m 0 c r 28 m a0 m 28 m a0 m 0 9 r 82 m 28 m 0 5 r ff m f0 m f m 0 7 r 3c 2 r f0 2 r 0 8 r 50 m 0 m 20
m 0 3 r 20 m 0 3 r 88 m 0 3 r 20 m 0 m 8 m 0 m 20 m 0 7 r notbusy
02 wcmd 2 m 98 m 0 m \ 0x29800 
0 4 r 20 m 0 m 88 m 0 m 20 m 0 3 r 20 m 0 m 2 m 0 5 r 20 m 0 m 20 m 0 m 20 m 0 b r 20 m 0 m 4 m 0 3 r 20 m 9 m 0 2 r 20 m 0 m
20 m 0 7 r 20 m 0 m 20 m 5 m 0 5 r 88 m 0 6 r 20 m 0 2 r 3 m 0 2 r 20 m 0 m c0 m 0 2 r 5 m 0 6 r 20 m 0 3 r 40 m 0 19 r 80 m 0
32 r 2 m 0 17 r 2 m 0 1c r 80 m 0 9 r 9 m 0 15 r notbusy
02 wcmd 2 m 99 m 0 m \ 0x29900 
0 d r 5 m 0 57 r 80 m 0 m 4 m 0 1e r 2 m 0 18 r 8 m 0 21 r 84 m 0 17 r 84 m 0 m 8 m 0 9 r 84 m 0 m 4 m 0 18 r notbusy
02 wcmd 2 m 9a m 0 m \ 0x29a00 
0 m 8 m 0 16 r 8 m 0 3 r 82 m 0 4 r 21 m 0 10 r 1 m 41 m 1 m 0 m 1 m 0 m 1 m 0 m 20 m 0 8 r 5 m 8 m 5 m 0 5 r 2 m 1 m 0 3 r 8
m 0 2 r 8 m 0 7 r 8 m 0 m 3 m 0 3 r 40 m 0 3 r 80 m 0 3 r 41 m 0 m 21 m 90 m 0 3 r 90 m 8 m 0 m a0 m 41 m 0 15 r 8 m 0 18 r 8
m 0 10 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 80 m 0 9 r 80 m 0 2 r 40 m 0 m 40 m 0 m 5 m 8 m a0 m 8 m 0 m 80 m 0 m 41 m 8 m 0 4 r
8 m 0 7 r 8 m c0 m 0 3 r 40 m 0 m a0 m 0 3 r a0 m 0 2 r 11 m 10 m 0 e r notbusy
02 wcmd 2 m 9b m 0 m \ 0x29b00 
c0 m 0 m 4 m 0 d r 82 m 0 1b r 4 m 0 5 r 8 m 0 5 r 90 m 0 5 r 82 m 0 17 r 8 m 0 6 r 41 m 0 m 8 m 0 4 r 10 m 0 m 82 m 21 m 0 3
r 9 m 40 m 0 3 r 20 m 0 m c0 m 0 2 r 11 m 0 7b r 8 m 0 m 2 m 0 m 90 m 0 4 r c0 m 0 m c0 m 0 m a0 m 0 m notbusy
02 wcmd 2 m 9c m 0 m \ 0x29c00 
0 39 r 2 m 0 a r 20 m 0 m 20 m 0 2 r 80 m 0 6 r 1 m 0 3 r 10 2 r 0 5 r 41 m 0 c r 2 m 0 2 r 21 m 0 3 r 80 m a0 m 0 m 20 m 41 m
0 m 41 m 2 m 41 m 8 m 0 3a r 10 m 0 9 r 84 m 0 m 84 m 0 m c0 m 0 3 r 8 m 80 m 0 m 88 m 10 m 3 m 4 m 0 m c0 m 0 3 r 8 3 r 0 9 r
8 m 0 5 r a0 m 20 m 0 3 r 2 m 0 2 r a0 m 0 2 r 11 m 0 2 r 10 m 11 m 2 m 9 m 0 m 20 m 2 m 0 2 r 21 m 84 m 0 4 r notbusy
02 wcmd 2 m 9d m 0 m \ 0x29d00 
0 2 r c0 m 0 44 r 21 m 40 m 4 m 2 m 0 m 2 m 0 m 90 m 0 3 r 90 m 0 4 r 21 m 0 m 9 m 0 m 41 m 0 m 20 m 0 m 8 m 0 c r 8 m 0 7 r
84 m 0 m 88 m 21 m 40 m 8 m 0 m 41 m 0 m 8 m 0 4d r 8 m 0 19 r 8 m 0 5 r 8 m 0 6 r 11 m 0 2 r 10 m 0 6 r 9 m 0 3 r notbusy
02 wcmd 2 m 9e m 0 m \ 0x29e00 
0 52 r c0 m a0 m 1 m 20 m 84 2 r a0 m 4 m 0 m 4 m 0 3 r 88 m 0 m 20 m 0 12 r 1 m 0 m 2 m 0 m 10 m 0 11 r 40 m 0 49 r 83 m 80 m
8 m 80 2 r 0 2 r 80 m 0 m c0 m 0 m 8 m 0 m 80 m 0 m 2 m 0 12 r 8 m 0 m 80 m 0 m 80 m 0 5 r notbusy
02 wcmd 2 m 9f m 0 m \ 0x29f00 
0 c r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 3c r 8 m 0 3 r 5 m 0 2 r 90 m 0 m 4 m 0 m 4 m 80 m 20 m 80 2 r 0 2 r 2 m 80 m 0 13 r 9
m 0 m 89 m 0 m 82 m 20 m 10 m 0 11 r 2 m 0 m 2 m 0 m 40 m 0 m 4 m 0 36 r 88 m 0 3 r 10 m 0 m 1 m 0 3 r 1 m 0 m 4 m 88 m 0 m 4
m 0 m 83 m 4 m a1 m 10 m 8 m 0 m 8 m 1 m 10 m 20 m 0 12 r 10 m 0 m 40 m 0 m 8 m 1 m 5 m 0 m notbusy
20 wcmd 2 m a0 m 0 m notbusy \ 0x2a000
02 wcmd 2 m a0 m 0 m \ 0x2a000 
0 4e r 84 m 0 5 r 4 m 0 5 r 4 m a1 m 0 m 84 m 0 m 41 m 4 m 85 m 20 m 0 5 r 83 m 0 12 r 82 m 0 m 10 m 0 m a1 m 0 m 10 m 0 4a r
2 m 0 d r 4 m 0 2 r 4 m 0 m 4 m 0 m a1 m 0 m 4 m 0 4 r 41 m 0 m 4 m 0 12 r 10 m 0 m 90 m notbusy
02 wcmd 2 m a1 m 0 m \ 0x2a100 
0 m 5 m 2 m 89 m 0 11 r 40 m 0 m 80 m 0 m 80 m 0 37 r 2 m 0 c r 80 m 40 m 0 m 80 m 0 2 r 80 m 2 m 0 m 9 m 0 m 80 2 r 0 16 r 80
m 0 m 80 m 0 m 10 m 0 13 r 2 m 0 m 40 m 0 44 r 2 m 82 m a0 m 4 m c0 m 88 m 8 m 1 m 0 2 r 4 m 82 m 4 m 8 m c0 m 0 11 r notbusy
02 wcmd 2 m a2 m 0 m \ 0x2a200 
0 3 r 10 m 0 m 10 m 0 50 r b m 0 6 r 88 m 0 a r 42 m 0 1c r d0 m 0 5e r c m 8 m 3c m 28 m f0 2 r 0 m f0 m 0 m 2c m 0 m 2c m 0
10 r notbusy
02 wcmd 2 m a3 m 0 m \ 0x2a300 
0 8 r ff m c0 m ff m fc m 0 5a r c m 8 m 3c m 28 m e0 2 r 0 m e0 m 0 m af m 0 m af m 0 18 r c3 m c0 m c3 m fc m 0 5a r fe 2 r
0 2 r 3c m 30 m 1c 2 r c 2 r f 2 r f1 m c1 m f1 m c1 m 0 8 r notbusy
02 wcmd 2 m a4 m 0 m \ 0x2a400 
0 c r fc m c m 5f 2 r 0 14 r 55 3 r 15 m 0 42 r ff m af m 0 2 r c m 0 m 1c 2 r 8 2 r a 2 r 31 m 1 m 31 m 1 m 0 14 r fc m c m
50 2 r 0 4a r 5 m 8 m a m 8 m 5 m 0 m 4 m a0 m 0 m 61 m 0 m 86 m 20 m d m 0 3 r 61 m 0 m 6 m 0 m 1d m 0 2 r 80 m 61 m 0 m 6 m
0 m d m 0 6 r notbusy
02 wcmd 2 m a5 m 0 m \ 0x2a500 
0 d r 61 m 0 m 6 m 0 m 9 m 0 m 1 m 0 5e r eb 2 r e3 2 r 0 7e r c3 m ff m c3 m ff m 0 8 r notbusy
02 wcmd 2 m a6 m 0 m \ 0x2a600 
0 16 r 8 m 0 5f r a0 m af m 30 m 3f m 0 m ff m 0 1a r 40 m c2 m 54 m d6 m 0 5e r a0 2 r 30 2 r 3c m 0 m 3c m 0 m notbusy
02 wcmd 2 m a7 m 0 m \ 0x2a700 
0 18 r 40 m c2 m 54 m d6 m 0 20 r 20 m 0 3 r 20 m 0 m 20 m 0 1d r 20 m 0 m 20 m 0 7 r 2 m 0 7 r 88 m 0 e r 8 m 20 m 0 m 4 m 80
m 0 4 r 20 m 0 7 r 20 m 0 m 88 m 0 a r 3 m 0 2 r 20 m 0 m 5 m 85 m 0 38 r 20 m 0 8 r 2 m 0 6 r 4 m 0 11 r notbusy
02 wcmd 2 m a8 m 0 m \ 0x2a800 
0 6 r 80 m 8 m 0 1e r 88 m 8 m 0 71 r 5 m 0 f r 4 m 0 56 r notbusy
02 wcmd 2 m a9 m 0 m \ 0x2a900 
0 f r 8 m 0 7 r 8 m 0 m 8 m 0 3 r 88 m 0 m 8 m 4 m 8 m 0 3 r 8 m 0 m 8 m 0 3 r 8 m 0 1a r 8 m 0 40 r 21 m 0 2 r 20 m 21 m 9 m
21 m 0 m 21 m 0 m 21 m 0 m 21 m 0 m 21 m 84 m 21 m 84 m 21 m 0 m 21 m 0 m 3 m 0 m 21 m 0 m 21 m 0 m 21 m 0 m 21 m a0 m 9 m 20
m 21 m 0 m 21 m 8 m 5 m 0 4f r 8 m 0 2 r notbusy
02 wcmd 2 m aa m 0 m \ 0x2aa00 
5 m 0 3 r 5 m 0 m 5 m 2 m 0 6 r a0 m 0 a r 82 m 0 4 r 3 m 10 m 0 7 r 10 m 0 m c0 m 2 m 82 m 2 m 0 m 5 m 40 m 0 3c r 4 m 0 23 r
8 m 0 5 r c0 m 0 15 r 90 m 0 3 r 8 m 0 4f r notbusy
02 wcmd 2 m ab m 0 m \ 0x2ab00 
0 12 r 80 m 0 4 r 10 m 0 9 r 10 m 0 8 r 9 m 0 7 r 8 m 0 4d r 90 m 8 m 0 7 r 8 m 0 m 3 m 0 3 r 3 m 90 m 21 m 0 2 r 8 2 r 0 7 r
8 m 0 2 r 2 m 8 m 0 7 r 8 m 0 m 41 m 0 m 5 m 0 m 3 m 0 4 r 8 m 88 m 0 43 r 10 m 0 m 8 m 0 4 r notbusy
02 wcmd 2 m ac m 0 m \ 0x2ac00 
0 d r 10 m 0 m 10 m 0 1b r c0 m 3 m 84 m 0 m 10 m 0 3 r 40 m 0 m 8 2 r 4 m 0 4d r 8 m 0 5 r 8 m 0 3 r 8 m 0 3 r 8 m 0 11 r 8 m
0 4 r 90 m 41 m 0 3 r 8 m 88 m 0 2 r 8 m 0 3 r 10 m 0 m 20 m 0 46 r notbusy
02 wcmd 2 m ad m 0 m \ 0x2ad00 
0 14 r 2 m 0 4 r 40 m 0 m 40 m 0 6 r 9 m 0 7 r 2 m 0 10 r 1 m 0 42 r 1 m 0 6 r 1 2 r 0 6 r 88 m 0 2 r c0 m 0 2 r c0 m 0 m 82 m
0 2 r c0 m 0 2 r 1 m 0 2 r 1 m 0 6 r 1 2 r 0 6 r 88 m 0 2 r c0 m 0 2 r c0 m 0 m 82 m 0 2 r c0 m 0 2 r 1 m 0 44 r notbusy
02 wcmd 2 m ae m 0 m \ 0x2ae00 
41 m 0 4 r 41 m 0 m 8 m 41 m 0 4 r 9 m 11 m 0 m 9 m 10 m 82 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 2 r 3 m 0 2 r 41 m 0 4 r 41 m 0
m 8 m 41 m 0 4 r 9 m 11 m 0 m 9 m 3 m 82 m 0 2 r 80 m 0 m 80 m 0 2 r 80 m 0 2 r 3 m 0 46 r 9 m 0 7 r 82 m 0 3 r 10 m 0 m 2 m 0
m 91 m 0 2 r 80 m 3 m 0 6 r 80 2 r 10 m 0 2 r 9 m 0 7 r 82 m 0 3 r 10 m 0 m 11 m 0 m 91 m 0 2 r 80 m 3 m 0 6 r 80 2 r 8 m 0 3e
r notbusy
02 wcmd 2 m af m 0 m \ 0x2af00 
0 e r 20 m 0 5 r 90 m 0 m 20 m 2 m 0 m 10 m 1 m 0 m 2 m 0 4 r c0 m 82 m 0 b r 20 m 0 5 r 2 m 0 m 20 m 2 m 0 m 10 m 1 m 0 m 2 m
0 4 r c0 m 82 m 1 m 0 4f r 1 m 2 m 20 m 0 m 10 m 0 2 r 88 m 0 18 r 1 m 90 m 21 m 0 m 10 m 0 2 r 88 m 0 45 r notbusy
20 wcmd 2 m b0 m 0 m notbusy \ 0x2b000
02 wcmd 2 m b0 m 0 m \ 0x2b000 
0 15 r 40 m 80 m 11 m 0 d r 41 m 0 f r 40 m 0 m 3 m 0 d r 41 m 0 46 r 80 m 0 2 r 91 m 0 3 r 9 m 0 2 r 41 m 0 4 r 41 m 80 m 0 2
r 2 m 0 3 r 41 m 0 5 r 3 m 0 2 r 80 m 0 2 r 91 m 0 3 r 9 m 0 m 2 m 41 m 0 4 r 41 m 80 m 0 2 r 2 m 0 3 r 41 m 0 5 r 5 m 0 36 r
notbusy
02 wcmd 2 m b1 m 0 m \ 0x2b100 
0 e r 8 m 0 2 r 10 m 0 4 r 10 m 0 m 2 m 0 4 r 89 m 40 m 0 6 r 1 m 0 8 r 8 m 0 2 r 10 m 0 4 r 10 m 0 m 2 m 0 4 r 89 m 40 m 0 6
r 1 m 0 4e r 48 m 0 7 r 48 m 0 m 81 m 12 m 0 m d0 m b m 0 m 48 m 0 7 r 48 m 42 m 0 6 r 48 m 0 7 r 48 m 0 m 81 m 12 m 0 m d0 m
b m 0 m 48 m 0 7 r 48 m 42 m ff 32 r notbusy
02 wcmd 2 m b2 m 0 m \ 0x2b200 
ff 50 r 0 m 30 m 11 m 8c m 30 m 22 m 2 m e m 0 m 17 m 50 m 60 m 0 2 r 3 m 8e m 0 42 r 75 m 7b m 0 1c r de m ae m 75 m 7b m 0
1c r de m ae m 0 1e r notbusy
02 wcmd 2 m b3 m 0 m \ 0x2b300 
0 24 r 60 m c6 m 3 m 40 m 0 6 r 2 m 31 m e0 m 0 7 r c m 40 m 0 6 r 2 m c0 m 63 m 6 m 60 m c6 m 3 m 40 m 0 6 r 2 m 31 m e0 m 0
7 r c m 40 m 0 6 r 2 m c0 m 63 m 6 m 0 e r 20 m 0 f r 20 m 0 7 r 2 m 0 m 4 m 0 5 r 20 m 0 19 r 20 m 0 3 r 1 m 0 3 r 20 m 0 c r
80 m 0 2 r c0 m 0 6 r 4 m 20 m 4 m 0 6 r 20 m 0 c r 40 m 0 m 9 m 20 m 10 m 0 1a r notbusy
02 wcmd 2 m b4 m 0 m \ 0x2b400 
0 27 r 2 m 0 a r 20 m 0 10 r 10 m 0 2 r 21 m 0 6 r 9 m 0 m 1 m 0 13 r 1 m 0 51 r 3 m 0 11 r 3 m 0 7 r 4 m 0 b r 80 m 0 d r 80
m 0 11 r 10 m 0 4 r notbusy
02 wcmd 2 m b5 m 0 m \ 0x2b500 
0 11 r 8 m 0 21 r 8 m 0 19 r 8 m 0 5 r 8 m 0 m 10 m 0 m 4 m 0 5 r 20 m 0 m 84 m 0 m 10 m 0 m 8 m 0 m 10 m 0 m 8 m 2 m 0 2 r 10
m 0 7 r 8 m 0 42 r 1 m 0 3 r 1 m 0 m 1 m 0 b r 90 m 5 m 0 2 r 84 m 0 m 1 m 0 m 1 m 80 m 0 m 21 m 0 m 21 m 0 m 21 m 0 9 r 20 m
0 m 20 m 0 m 20 m 0 m 5 m 0 m 5 m 0 m 8 m 0 14 r notbusy
02 wcmd 2 m b6 m 0 m \ 0x2b600 
0 36 r 2 m 0 m 20 m 0 3 r 20 m 0 m 20 m 0 4 r 82 m 0 m 8 m 0 m 88 m 0 m a0 m 0 5 r 8 m 20 m 0 m 20 m 4 m 0 m 84 m 2 m 0 c r 83
m 0 m 11 m 20 m 1 m 0 m 84 m 0 44 r 8 m 0 11 r 82 m 0 m a0 m 0 d r 82 m 0 2 r 80 m 0 c r 82 m 0 1f r notbusy
02 wcmd 2 m b7 m 0 m \ 0x2b700 
0 55 r 20 m 0 a r 11 m 0 11 r 2 m 0 42 r 2 m 0 19 r 8 m 0 b r 20 m 4 m 0 12 r 10 m 0 4 r 82 m 0 b r notbusy
02 wcmd 2 m b8 m 0 m \ 0x2b800 
0 39 r 8 m 0 7 r 8 m 0 m 8 m 0 7 r 8 m 0 2 r 11 m 8 m 0 3 r 8 m 0 5 r 8 m 0 3 r 1 m 80 m 0 2 r 10 m 0 2 r 2 m 0 6 r a0 m 0 3 r
8 m 0 m 8 m 0 m a0 m 0 3 r 84 m 0 4a r 8 m 0 8 r 8 m 0 3 r 21 m 0 m 21 m 0 b r 21 m 0 4 r 20 m 8 m 0 m 21 m 0 m 21 m 0 6 r 20
m 0 6 r 41 m 0 2 r 40 m 0 m ff 6 r notbusy
02 wcmd 2 m b9 m 0 m \ 0x2b900 
ff 7c r 0 m 1d m b0 m cd m 30 m 22 m 2 m f m 0 m c m 50 m 60 m 0 2 r 3 m c m 0 5b r a0 m 0 m 4 m 0 m 88 m 8 m a0 m 0 2 r 90 m
0 f r notbusy
02 wcmd 2 m ba m 0 m \ 0x2ba00 
0 69 r 80 m 0 6 r 11 m 0 m 80 m 0 68 r 9 m 0 3 r 9 m 0 d r 10 m 0 m 80 m 0 3 r 8 m 0 m 80 m 0 m 41 m 0 8 r notbusy
02 wcmd 2 m bb m 0 m \ 0x2bb00 
0 5 r 80 m 0 8 r 80 m 0 62 r a0 m 0 3 r 1 m 0 m 8 m 0 3 r 84 m 0 b r 8 m 0 3 r 10 m 2 m 0 m 10 m 0 m 4 m 0 m 84 m 0 4d r 2 m 0
d r c0 m 0 4 r 10 m c0 m 10 m 0 2 r c0 m 0 m 4 m 0 5 r notbusy
02 wcmd 2 m bc m 0 m \ 0x2bc00 
2 m 0 9 r 2 m 0 5b r 9 m 0 f r 40 m 0 m 9 m 0 m 80 m 0 3 r 41 m 0 3 r 80 m 0 5 r 5 m 0 6b r 80 m 0 8 r 20 m 0 2 r notbusy
02 wcmd 2 m bd m 0 m \ 0x2bd00 
0 b r 4 m 0 m 21 m 0 66 r 88 m 0 m 82 m 0 m 10 m 0 m 40 m 0 4 r 1 m 0 d r 1 m 0 9 r 88 m 0 m 2 m 0 4f r 88 m 0 16 r notbusy
02 wcmd 2 m be m 0 m \ 0x2be00 
0 m 88 m b m 4 m 82 m 0 d r b m 0 65 r 30 2 r 66 2 r ff 2 r 0 m ff m 0 7c r f m 0 m ff m 0 m notbusy
02 wcmd 2 m bf m 0 m \ 0x2bf00 
0 22 r ff 82 r 0 m 32 m f3 m c5 m 30 m 22 m 2 m f m 0 m 18 m 50 m 60 m 0 2 r 1 m 4 m 0 4c r notbusy
20 wcmd 2 m c0 m 0 m notbusy \ 0x2c000
02 wcmd 2 m c0 m 0 m \ 0x2c000 
0 e r 42 m ff m 4f m ff m 0 20 r f m ff m 66 m 3c m 0 5a r 42 2 r 4f 2 r 0 20 r f m 0 m 66 m 3c m 0 48 r notbusy
02 wcmd 2 m c1 m 0 m \ 0x2c100 
0 3 r 61 m 0 m 86 m 20 m d m 0 12 r 5 m 71 m a m 8e m 25 m d m 0 m a0 m 0 8 r 5 m 0 m a m 8 m 5 m 0 m 4 m a0 m 0 7 r 1 m ff 82
r 0 m 36 m 52 m 6a m 30 m 22 m 2 m 10 m 0 2 r 50 m 60 m 0 3 r c3 m 0 2 r 20 m 0 13 r 20 m 0 b r 20 m 0 11 r notbusy
02 wcmd 2 m c2 m 0 m \ 0x2c200 
0 2 r 20 m 0 39 r 2 m 0 5 r 84 m 0 4 r 10 m 0 59 r a0 m 0 2e r ff 30 r notbusy
02 wcmd 2 m c3 m 0 m \ 0x2c300 
ff 52 r 0 m 13 m 4b m cf m 30 m 22 m 2 m 10 m 0 m 3 m 50 m 60 m 0 3 r 82 m 0 d r 8 m 0 m 8 m 0 f r 8 m 0 d r 8 m 0 m 8 m 0 f r
8 m 0 f r 40 m 0 m 8 m 0 f r 8 m 0 f r 10 m 0 9 r 10 m 0 m 84 m 0 3 r 88 m ff 1c r notbusy
02 wcmd 2 m c4 m 0 m \ 0x2c400 
ff 66 r 0 m 1c m 2b m 13 m 30 m 22 m 2 m 10 m 0 m 5 m 50 m 60 m 0 2 r 1 m c7 m 0 55 r 84 m 0 2 r 8 m 0 a r 82 m 0 3 r 82 m 0 m
84 m 0 15 r 10 m 0 a r notbusy
02 wcmd 2 m c5 m 0 m \ 0x2c500 
0 3c r 8 m 0 39 r 2 m 0 5d r 41 m 0 2b r notbusy
02 wcmd 2 m c6 m 0 m \ 0x2c600 
0 50 r 82 m 0 18 r 8 m 0 3 r 10 m 0 63 r 84 m 0 5 r 84 m 0 m c0 m 0 m 8 m 0 3 r 8 m 0 1d r 2 m 0 2 r notbusy
02 wcmd 2 m c7 m 0 m \ 0x2c700 
0 5b r 8 m 0 m 8 m 0 3 r 10 m 0 f r 8 m 0 10 r ff 7e r notbusy
02 wcmd 2 m c8 m 0 m \ 0x2c800 
ff 4 r 0 m b m bf m d5 m 30 m 22 m 2 m 11 m 0 2 r 50 m 60 m 0 3 r 82 m 0 e r 20 m 0 1f r 20 m 0 28 r 10 m 0 a r 84 m 0 14 r 10
m 0 5 r 8 m 0 4 r ff 6a r notbusy
02 wcmd 2 m c9 m 0 m \ 0x2c900 
ff 18 r 0 m 8 m 13 m 3 m 30 m 22 m 2 m 11 m 0 m 3 m 50 m 60 m 0 3 r c3 m 0 d r 8 m 0 d r 8 m 0 11 r 8 m 0 d r 10 m 0 13 r 10 m
0 88 r notbusy
02 wcmd 2 m ca m 0 m \ 0x2ca00 
0 a r 82 m 0 21 r ff 82 r 0 m 3f m 72 m c5 m 30 m 22 m 2 m 11 m 0 m 6 m 50 m 60 m 0 3 r 82 m 0 42 r notbusy
02 wcmd 2 m cb m 0 m \ 0x2cb00 
0 e r 8 m 0 31 r ff 82 r 0 m 17 m d5 m 8f m 30 m 22 m 3 m 0 3 r 50 m 60 m 0 2 r 1 m 4 m 0 2e r notbusy
02 wcmd 2 m cc m 0 m \ 0x2cc00 
0 15 r 1 m 0 81 r 2 m 0 3 r 2 m 0 64 r notbusy
02 wcmd 2 m cd m 0 m \ 0x2cd00 
0 18 r 1 m 0 3 r 1 m 0 be r 31 m 89 m 32 m 30 m a1 m 0 m 2 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20
m 0 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m notbusy
02 wcmd 2 m ce m 0 m \ 0x2ce00 
0 m 5 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m 6 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m 9 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m
0 m b m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m
0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1
m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m 19 m 33 m 64 m 0 8 r 30 m 22 m 3 m 1 m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 3 m
2 m 0 m 4 m 33 m 64 m 0 8 r 30 m 22 m 3 m 2 m 0 m 5 m 33 m 64 m 0 8 r 30 m 22 m 3 m 2 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m
2 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 m 2 m notbusy
02 wcmd 2 m cf m 0 m \ 0x2cf00 
0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m 2 m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 3 m 2 m 0 m 19 m 33 m 64 m 0 8 r 30 m 22 m 3 m 2
m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 3 m 2 m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m 3 m 2 m 0 m 1e m 33 m 64 m 0 8 r 30 m 22 m 3 2
r 0 m f m 33 m 64 m 0 8 r 30 m 22 m 3 2 r 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 3 2 r 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 3 2 r 0
m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 2 r 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 2 r 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 2 r 0 m
18 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 1 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 3 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m
6 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m notbusy
20 wcmd 2 m d0 m 0 m notbusy \ 0x2d000
02 wcmd 2 m d0 m 0 m \ 0x2d000 
0 m c m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m e m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m
0 m f m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4
m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 3 m
4 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 m 4 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3
m 4 m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 3 m 6 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m 0 m c m 33 m 64 m 0 8 r 30 m 22 m
3 m 7 m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m notbusy
02 wcmd 2 m d1 m 0 m \ 0x2d100 
0 m e m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m
0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 3 m 7
m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m 7 m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 m
7 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m 8 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m 9 m 0 m 1e m 33 m 64 m 0 8 r 30 m 22 m 3
m a m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m 3 m a m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m a m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m
3 m a m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m 3 m a m notbusy
02 wcmd 2 m d2 m 0 m \ 0x2d200 
0 m 1d m 33 m 64 m 0 8 r 30 m 22 m 3 m a m 0 m 1e m 33 m 64 m 0 8 r 30 m 22 m 3 m c m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m d
m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m 3 m d m 0 m 3 m 33 m 64 m 0 8 r 30 m 22 m 3 m d m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 3 m d
m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 3 m 33 m 64 m 0 8 r 30 m 22 m 3 m e
m 0 m 4 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 5 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 6 m 33 m 64 m 0 8 r 30 m 22 m 3 m e
m 0 m 7 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 8 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 9 m 33 m 64 m 0 8 r 30 m 22 m 3 m e
m 0 m a m 33 m 64 m 0 8 r 30 m 22 m 3 m e m notbusy
02 wcmd 2 m d3 m 0 m \ 0x2d300 
0 m b m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m c m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 3 m e m
0 m e m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m
0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 3 m e
m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 m
e m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m e m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m 3
m f m 0 m 3 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m notbusy
02 wcmd 2 m d4 m 0 m \ 0x2d400 
0 m 4 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 5 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 8 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m
0 m 9 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m a m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m b m 33 m 64 m 0 8 r 30 m 22 m 3 m f m
0 m c m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m d m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m e m 33 m 64 m 0 8 r 30 m 22 m 3 m f m
0 m f m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 10 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 11 m 33 m 64 m 0 8 r 30 m 22 m 3 m f
m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 13 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 14 m 33 m 64 m 0 8 r 30 m 22 m 3 m
f m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m notbusy
02 wcmd 2 m d5 m 0 m \ 0x2d500 
0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 3 m f
m 0 m 19 m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 1a m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 3 m
f m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 1d m 33 m 64 m 0 8 r 30 m 22 m 3 m f m 0 m 1e m 33 m 64 m 0 8 r 30 m 22 m 3
m 10 m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m 0 m 3 m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m 0 m 9 m 33 m 64 m 0 8 r 30 m 22 m
3 m 10 m 0 m f m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m 0 m 12 m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m 0 m 13 m 33 m 64 m 0 8 r 30 m
22 m 3 m 10 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m notbusy
02 wcmd 2 m d6 m 0 m \ 0x2d600 
0 m 16 m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m 0 m 17 m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m 0 m 18 m 33 m 64 m 0 8 r 30 m 22 m 3 m
10 m 0 m 1b m 33 m 64 m 0 8 r 30 m 22 m 3 m 10 m 0 m 1c m 33 m 64 m 0 8 r 30 m 22 m 3 m 11 m 0 m 2 m 33 m 64 m 0 8 r 30 m 22 m
3 m 11 m 0 m 7 m 33 m 64 m 0 8 r 30 m 22 m 3 m 11 m 0 m 9 m 33 m 64 m 0 8 r 30 m 22 m 3 m 11 m 0 m 13 m 33 m 64 m 0 8 r 30 m
22 m 3 m 11 m 0 m 15 m 33 m 64 m 0 8 r 30 m 22 m 3 m 11 m 0 m 19 m 33 m 64 m 0 8 r 30 m 22 m 3 m 11 m 0 m 1a m 33 m 64 m 0 8 r
30 m 22 m 3 m 1 m 0 2 r 30 m a1 m 0 m 1 m 50 m 60 m 0 2 r 1 m 86 m 0 34 r notbusy
02 wcmd 2 m d7 m 0 m \ 0x2d700 
0 d r 3 m 0 18 r 10 m 0 1f r 20 m 0 61 r 80 m 0 35 r 40 m 0 19 r 1 m 0 7 r notbusy
02 wcmd 2 m d8 m 0 m \ 0x2d800 
0 2a r 1 m 0 35 r 80 m 0 19 r 20 m 0 31 r 20 m 0 53 r notbusy
02 wcmd 2 m d9 m 0 m \ 0x2d900 
0 25 r 3 m 0 6 r 90 m 0 8 r 4 m 0 5 r 3 m 0 m 8 m 0 d r 40 m 0 a r ff 82 r 0 m 31 m f5 m d0 m 30 m 22 m 3 m 1 m 0 m 7 m 50 m
60 m 0 3 r c3 m 0 18 r notbusy
02 wcmd 2 m da m 0 m \ 0x2da00 
0 47 r 84 m 0 79 r 40 m 0 15 r 3 m 0 5 r 20 m 0 e r ff 14 r notbusy
02 wcmd 2 m db m 0 m \ 0x2db00 
ff 6e r 0 m 6 m b8 m a0 m 30 m 22 m 3 m 1 m 0 m a m 50 m 60 m 0 3 r 82 m 0 51 r 5 m 0 7 r 21 m 0 d r 21 m 0 1a r notbusy
02 wcmd 2 m dc m 0 m \ 0x2dc00 
ff 82 r 0 m 24 m 1 m 27 m 30 m 22 m 3 m 1 m 0 m e m 50 m 60 m 0 3 r c3 m 0 49 r 9 m 0 f r 2 m 0 14 r notbusy
02 wcmd 2 m dd m 0 m \ 0x2dd00 
0 56 r 2 m 0 f r 2 m 0 2f r ff 6a r notbusy
02 wcmd 2 m de m 0 m \ 0x2de00 
ff 18 r 0 m 3a m bb m 2a m 30 m 22 m 3 m 1 m 0 m 12 m 50 m 60 m 0 3 r 82 m 0 41 r 2 m 0 40 r ff 56 r notbusy
02 wcmd 2 m df m 0 m \ 0x2df00 
ff 2c r 0 m 3e m e7 m 14 m 30 m 22 m 3 m 1 m 0 m 14 m 50 m 60 m 0 3 r 82 m 0 2e r e0 m 0 31 r e0 m 7 m 0 20 r ff 42 r notbusy
20 wcmd 2 m e0 m 0 m notbusy \ 0x2e000
02 wcmd 2 m e0 m 0 m \ 0x2e000 
ff 40 r 0 m 22 m 43 m a0 m 30 m 22 m 3 m 1 m 0 m 16 m 50 m 60 m 0 2 r 1 m 4 m 0 29 r 10 m 0 2 r 80 m 0 2d r 2 m 10 m 0 2 r 80
m 1 m 0 31 r 40 m 0 1e r notbusy
02 wcmd 2 m e1 m 0 m \ 0x2e100 
0 7e r 40 m 48 m 0 30 r 40 m 48 m 12 m 2 m 0 22 r ff 2a r notbusy
02 wcmd 2 m e2 m 0 m \ 0x2e200 
ff 58 r 0 m 39 m 92 m cd m 30 m 22 m 3 m 1 m 0 m 1b m 50 m 60 m 0 2 r 2 m 8 m 0 45 r 4 m 0 2 r 80 m 0 c r 4 m 0 2 r 80 m 0 3f
r notbusy
02 wcmd 2 m e3 m 0 m \ 0x2e300 
0 13 r 80 m 0 19 r 2 m 0 4 r 40 m 0 a r 2 m 0 4 r 40 m 0 2 r 80 m 0 4 r 1 m 0 2c r 8 m 0 1e r 1 2 r 0 1a r 90 m 0 f r 90 m 0 5
r 9 2 r 0 2a r 10 m 0 b r notbusy
02 wcmd 2 m e4 m 0 m \ 0x2e400 
0 14 r 20 m 0 21 r 20 m 0 3f r 80 m 0 3a r 2 m 0 46 r 11 m 0 7 r notbusy
02 wcmd 2 m e5 m 0 m \ 0x2e500 
10 m 0 43 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 2f r c0 m 0 7 r 80 m 0 43 r 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 24 r 8 m 0 4 r ff a r
notbusy
02 wcmd 2 m e6 m 0 m \ 0x2e600 
ff 78 r 0 m 9 m 61 m 7a m 30 m 22 m 3 m 2 m 0 m 6 m 50 m 60 m 0 2 r 4 m 10 m 0 53 r 80 m 0 24 r notbusy
02 wcmd 2 m e7 m 0 m \ 0x2e700 
0 5d r 20 m 0 6f r 2 m 0 15 r 20 m 0 m 80 m 0 7 r 2 m 0 12 r notbusy
02 wcmd 2 m e8 m 0 m \ 0x2e800 
0 65 r 1 m 0 m 20 m 0 85 r 8 m 0 12 r notbusy
02 wcmd 2 m e9 m 0 m \ 0x2e900 
0 7a r 8 m 0 6d r 90 m 0 17 r notbusy
02 wcmd 2 m ea m 0 m \ 0x2ea00 
0 68 r 11 m 0 m 80 m 0 80 r 8 m 0 m 80 m 0 m 41 m 0 10 r notbusy
02 wcmd 2 m eb m 0 m \ 0x2eb00 
0 6d r 1 m 0 m 8 m 0 3 r 8 m 0 7c r c0 m 0 m 4 m 0 m 1 m 0 b r notbusy
02 wcmd 2 m ec m 0 m \ 0x2ec00 
0 70 r 11 m 0 m 80 m 0 3 r 4 m 0 7e r 10 m 0 a r notbusy
02 wcmd 2 m ed m 0 m \ 0x2ed00 
0 77 r 1 m 0 81 r 88 m b m 4 m 82 m 0 3 r notbusy
02 wcmd 2 m ee m 0 m \ 0x2ee00 
0 26 r ff 82 r 0 m 8 m a2 m 74 m 30 m 22 m 3 m 2 m 0 m 1a m 50 m 60 m 0 3 r 82 m 0 3 r 9 m 0 7 r 1 m 0 3c r notbusy
02 wcmd 2 m ef m 0 m \ 0x2ef00 
0 a r 5 m 71 m a m 8e m 25 m d m 4 m a0 m 0 28 r ff 82 r 0 m 3 m d9 m 11 m 30 m 22 m 3 m 2 m 0 m 1d m 50 m 60 m 0 3 r 82 m 2 m
0 6 r 40 m 2 m 0 2b r notbusy
20 wcmd 2 m f0 m 0 m notbusy \ 0x2f000
02 wcmd 2 m f0 m 0 m \ 0x2f000 
0 4e r ff 82 r 0 m c m 9d m c6 m 30 m 22 m 3 2 r 0 2 r 50 m 60 m 0 2 r 4 m 10 m 0 20 r notbusy
02 wcmd 2 m f1 m 0 m \ 0x2f100 
0 10 r 20 m 0 m 20 m 0 m 20 m 0 3 r 4 m 0 9 r 40 m 0 f r 20 m 0 m 20 m 0 m 20 m 0 3 r 20 m 0 7 r 20 m 0 4 r 8 m 0 2 r 4 m 0 7
r 20 m 0 m 20 m 0 m 20 m 0 3 r 20 m 0 37 r 80 m 0 m 80 m 0 m 80 m 0 c r 1 m 0 25 r 1 m 0 28 r 11 m 0 d r notbusy
02 wcmd 2 m f2 m 0 m \ 0x2f200 
0 1a r 20 m 0 20 r 11 m 0 38 r c0 m 0 27 r 80 m 0 32 r 84 m 0 b r 8 m 0 m 8 m 0 m 8 m 0 20 r notbusy
02 wcmd 2 m f3 m 0 m \ 0x2f300 
0 19 r 4 m 0 3 r 4 m 0 f r 21 m 0 3 r 8 m 0 m 3 m 0 9 r 8 m 0 m 8 m 0 a r 40 m 0 16 r 21 m 0 39 r 1 m 0 3 r 1 m 0 2c r 80 m 0
6 r 8 m 0 2c r notbusy
02 wcmd 2 m f4 m 0 m \ 0x2f400 
0 d r 21 m 0 3 r 21 m 0 d r 80 m 0 3 r 80 m 0 2f r 9 m 0 4d r 4 m 0 3 r 4 m 0 5a r notbusy
02 wcmd 2 m f5 m 0 m \ 0x2f500 
0 49 r 8 m 0 f r 4 m 0 63 r c0 m 0 8 r 20 m 0 39 r notbusy
02 wcmd 2 m f6 m 0 m \ 0x2f600 
0 2d r 21 m 0 3 r 5 m 0 9 r 21 m 0 18 r 1 m 0 81 r 40 m 0 29 r notbusy
02 wcmd 2 m f7 m 0 m \ 0x2f700 
0 56 r 8 m 0 4 r 1 m 0 m 1 m 0 m 1 m 0 76 r 11 m 0 6 r 41 m 0 m 8 m 0 m 8 m 0 m 20 m 0 1c r notbusy
02 wcmd 2 m f8 m 0 m \ 0x2f800 
0 2d r 9 m 0 3 r 9 m 0 4c r ff 82 r notbusy
02 wcmd 2 m f9 m 0 m \ 0x2f900 
0 m e m c0 m 55 m 30 m 22 m 3 2 r 0 m 10 m 50 m 60 m 0 3 r c3 m 0 32 r 2 m 0 28 r 1 m 0 m 1 m 0 3 r 1 m 0 2 r 1 m 0 m 1 m 0 51
r 2 m 0 24 r 10 m 0 m 10 m 0 m 20 m 0 m 10 m 0 2 r 3 m 0 m 20 m 0 m 10 m 0 5 r notbusy
02 wcmd 2 m fa m 0 m \ 0x2fa00 
0 14 r ff 82 r 0 m 39 m b0 m 69 m 30 m 22 m 3 2 r 0 m 14 m 50 m 60 m 0 3 r 82 m 0 33 r d0 m 0 26 r notbusy
02 wcmd 2 m fb m 0 m \ 0x2fb00 
0 28 r ff 82 r 0 m 19 m 5a m a0 m 30 m 22 m 3 2 r 0 m 19 m 50 m 60 m 0 2 r 1 m c7 m 0 31 r 61 m 0 m 6 m 0 m d m 0 10 r notbusy
02 wcmd 2 m fc m 0 m \ 0x2fc00 
0 15 r 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 6 m 0 m d m 0 25 r 9 m 0 52 r 3c 4 r 0 62 r notbusy
02 wcmd 2 m fd m 0 m \ 0x2fd00 
0 1c r 3c 3 r 1c m 0 82 r be m 14 m 5f 2 r 0 24 r 2 m 0 6 r 40 m 0 2e r notbusy
02 wcmd 2 m fe m 0 m \ 0x2fe00 
0 24 r be m 14 m a 2 r 0 32 r 4 m 0 1f r 20 m 0 37 r 40 m 0 13 r ff 3a r notbusy
02 wcmd 2 m ff m 0 m \ 0x2ff00 
ff 48 r 0 m 1b m 91 m ea m 30 m 22 m 3 m 4 m 0 m 2 m 50 m 60 m 0 3 r 82 m 0 16 r 4 m 0 17 r 90 m 0 26 r 2 m 0 2c r ff 26 r
notbusy
20 wcmd 3 m 0 m 0 m notbusy \ 0x30000
02 wcmd 3 m 0 m 0 m \ 0x30000 
ff 5c r 0 m 28 m 75 m 4b m 30 m 22 m 3 m 4 m 0 m 4 m 50 m 60 m 0 3 r c3 m 0 58 r 90 m 0 1e r 40 m 0 m 40 m 0 1a r notbusy
02 wcmd 3 m 1 m 0 m \ 0x30100 
0 44 r 4 m 0 4 r 20 m 0 4 r 21 m 0 10 r 8 m 0 10 r ff 82 r 0 m 20 m ca m 38 m 30 m 22 m 3 m 4 m 0 m 7 m 50 m 60 m 0 2 r
notbusy
02 wcmd 3 m 2 m 0 m \ 0x30200 
1 m 86 m 0 2b r c0 m 0 32 r 11 m 0 3 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 10 m 0 56 r 40 m 0 22 r 2 m 0 19 r notbusy
02 wcmd 3 m 3 m 0 m \ 0x30300 
0 60 r 40 m 0 3 r 11 m 0 m 20 m 0 6 r a0 m 0 m a0 m 0 70 r 8 m 0 1f r notbusy
02 wcmd 3 m 4 m 0 m \ 0x30400 
0 3b r 82 m 0 1e r 5 m 0 17 r 5 m 0 7 r 41 m 8 m 0 10 r ff 74 r notbusy
02 wcmd 3 m 5 m 0 m \ 0x30500 
ff e r 0 m 2c m 9f m a m 30 m 22 m 3 m 5 m 0 2 r 50 m 60 m 0 2 r d m b6 m 0 1e r 4 m 0 19 r 4 m 0 5 r 20 m 0 23 r 10 m 0 m 10
m 0 m 10 m 0 m 10 m 0 a r 80 m 0 3e r 40 m 0 7 r 80 m 0 8 r 3 m 0 1e r notbusy
02 wcmd 3 m 6 m 0 m \ 0x30600 
0 13 r 8 m 0 1c r 10 m 0 11 r 82 m 0 m 90 m 0 m 82 m 0 22 r 20 m 4 m 0 1d r 82 m 0 m 1 m 0 m 84 m 0 m 84 m 0 m 84 m 0 m 40 m 0
5 r 4 3 r 0 3 r a0 m 0 13 r 82 m 0 2c r 84 m 0 7 r 8 m 0 3 r 1 m 80 m 0 11 r 20 m 0 m notbusy
02 wcmd 3 m 7 m 0 m \ 0x30700 
0 m 8 m 0 5 r 8 m 0 4 r 4 m 0 7 r 85 m 0 5 r 80 m 1 m 80 m 82 m 0 3 r 4 m 0 27 r 5 m 0 17 r 8 m 0 3 r 20 m 0 3 r 2 m 0 3 r 10
m 1 m 0 2 r 21 m 0 m 5 m 0 5 r 20 m 0 3 r 9 m 4 m 0 2 r 21 m 0 m 20 3 r 1 m 0 6 r 80 m 0 m 2 m 20 m 2 m 0 m 5 m 0 53 r 1 m 0 8
r 40 m 0 a r 1 m 0 4 r notbusy
02 wcmd 3 m 8 m 0 m \ 0x30800 
80 m 0 4 r 1 m 0 m 1 m 4 m 0 6 r 20 m 0 22 r 1 m 0 6 r 2 m 0 26 r 8 m 0 11 r 82 m 0 5 r 40 m 0 8 r 80 m 0 8 r 8 m 0 m a0 m 0 4
r 80 m 0 2 r 88 m 20 m 0 m 20 m 0 3 r 80 m 0 m 20 m 0 2 r c0 m 0 13 r 10 m 0 6 r 1 m 0 26 r 80 m 0 17 r 80 m 0 5 r notbusy
02 wcmd 3 m 9 m 0 m \ 0x30900 
0 3 r 20 m 0 d r 84 m 0 m 2 m 0 3 r 1 m 0 m 1 m 0 3 r 20 m 0 m 1 m 0 9 r a0 m 0 17 r 21 m 0 7 r 3 m 0 5 r 8 m 0 12 r 40 m 0 3
r 4 m 21 m 0 m 3 m 20 2 r 0 5 r 2 m 4 m 3 m 0 2 r c0 m 0 2 r 3 m 4 m 0 m c0 m 21 m 40 m 0 4 r 11 m c0 m 2 m 0 m 2 m 4 m 3 m 4
m 0 m 90 m 2 m 90 m 0 m a0 m 11 m 0 3 r 20 m 0 m 2 m 0 m 2 m 4 m 11 m 88 m 9 m 82 m 0 4 r 11 m 0 3 r 4 m 0 3c r 80 m 0 3 r 80
m 0 4 r 1 m 0 6 r 80 m 0 7 r 80 m 0 3 r notbusy
02 wcmd 3 m a m 0 m \ 0x30a00 
80 m 0 6 r 1 m 0 m 8 m 0 2 r 80 m 0 2 r 89 m 0 7 r 1 m 0 4 r 80 m 0 28 r 5 m 0 m 3 m 0 5 r 8 m 0 f r 21 m 0 d r 21 m 0 2 r 1 m
0 5 r 4 m 21 m 0 m 80 m 0 m 2 m 0 3 r 20 m 0 m 85 m 0 m 80 m 0 m 80 m 0 2 r c0 m 5 m 0 3 r 2 m 8 m 21 m 0 m 21 m 0 4 r 84 m 0
4 r 9 m 84 m 0 2 r 3 m 0 m 5 m 85 m 0 m a0 m 0 4 r 5 m 0 3 r 2 m 0 3 r 21 m 0 40 r 4 m 0 5 r 80 m 0 2 r 20 m 0 m 1 m 0 2 r 21
m 1 m notbusy
02 wcmd 3 m b m 0 m \ 0x30b00 
0 m 20 m 0 m 20 m 0 m 20 m 0 7 r 1 m 0 14 r 4 m 0 a r 1 m 0 3a r c0 m 0 5 r 10 m 8 m 2 m 0 4 r 10 m 0 4 r 10 m 0 m 40 m 10 m 2
2 r 0 3 r 10 2 r 2 m 0 3 r 88 m 10 m 90 m 88 m 82 m 0 m 88 m 10 2 r 11 m 4 m 10 m 0 3 r 10 m 88 m 90 m 91 m 0 m 11 m 0 m 20 m
10 m 4 m 1 m 10 m 82 m 90 m 2 m 4 m 20 2 r 11 m 90 2 r 4 m 88 2 r 0 40 r 80 3 r 0 4 r 80 m 0 2 r 9 m 0 m 10 m 0 m 80 2 r
notbusy
02 wcmd 3 m c m 0 m \ 0x30c00 
80 2 r 0 2 r 10 m 80 m 0 m 80 m 0 2 r 11 m 0 m 10 m 80 m 0 m 80 m 0 4 r c1 m 80 m 0 4 r 85 m 9 m 80 m 90 m 0 m 83 m 0 m 20 m
85 m 80 m 8 m 0 3 r 89 m 80 m 0 2 r 11 m 80 m 0 m 80 m 0 19 r 11 m 0 20 r 82 m 0 m 8 m 0 m 11 m 0 m 83 m 0 4 r 88 m 0 m 82 m
80 2 r 0 2 r 10 m 0 m 3 m 80 m 83 m 80 m 90 m 0 m 11 m 0 m 82 m 11 m 10 m 0 m 88 m 80 m 89 m 0 m 11 m 83 m 88 m 0 m 88 m 0 m 2
m 0 m 82 2 r 11 m 82 m 8 m 80 m 90 m 0 m 10 m a1 m 91 m 0 m a0 m 80 m 0 3 r 11 m 0 m 80 2 r 0 3 r 8 m 83 m 2 m 0 m c1 m 0 39 r
8 m 0 m 11 m 0 m c0 m 0 m 11 m 0 4 r c1 m 0 m 10 m 90 m 82 m 0 4 r notbusy
02 wcmd 3 m d m 0 m \ 0x30d00 
0 m c0 m 11 m 10 m 90 m 8 m 0 2 r 10 m 90 m 0 2 r 91 m 10 m 8 m 0 m 11 m 20 m 11 m 0 m 91 m 40 m 10 m 0 m 4 m 2 m 0 m 82 m 1 m
a0 m 9 m 0 m 91 m c0 m 10 m 0 m 90 m 2 m 10 m 0 m 90 m 20 2 r 40 m 90 m 20 m 40 m 0 m 91 m 84 m 0 m 90 m 91 m 8 m 0 16 r 10 m
0 29 r 90 2 r 0 2 r 88 m 10 m 0 4 r 1 m 0 2 r 11 m 20 m 90 m 2 m 0 m 1 m 10 m 0 m 2 m 82 m 91 m 2 m 1 m 9 m 2 m 0 m 1 m 20 m
90 m 2 m 10 m 1 m 0 2 r 5 m 40 m 91 m 2 m 1 m 20 m 4 m 0 2 r 82 m 0 m 10 3 r 1 m 0 m 1 m a0 m 90 m 2 m 1 m 2 2 r 0 m 82 m 88 m
90 m 8 m 4 m 0 40 r 80 2 r 0 3 r 80 m 0 2 r notbusy
02 wcmd 3 m e m 0 m \ 0x30e00 
0 m 2 m 8 m 3 m 0 m 90 m 0 m 82 m 80 m 8 m 41 m 82 m 0 m 82 m 80 m 88 m 80 m 8 m 85 m 89 m 0 m 8 m 0 m c1 m 0 m 2 m 5 m 11 m 0
m 90 m 0 m 88 m 80 m 8 m 3 m 80 m 11 m 0 m 11 m 0 2 r 80 m 88 m 2 m 0 m 2 m 0 m 90 m 80 m 2 m 88 m a0 m 0 m a0 m 0 m 85 m 8 m
88 m 0 39 r 8 m 0 m 80 m 0 3 r 10 m 0 m 11 m 0 m 80 m 0 m 80 m 0 5 r 11 m 80 m 0 m 80 2 r 0 m 8 m 80 m 0 m 80 m 88 m 0 3 r 88
m 80 m 11 m 0 5 r 82 m 80 m 90 m 80 m 0 2 r 80 m 0 m 10 m 80 m a1 m 0 m a1 m 0 m 80 2 r 10 m 0 m 11 m 0 2 r 80 2 r 0 3 r 91 m
80 m 0 m 80 m 0 2 r 40 m 0 39 r 3 m 0 m 20 m 0 m 2 m 0 2 r 10 m 1 m 10 m 20 m notbusy
02 wcmd 3 m f m 0 m \ 0x30f00 
0 m 10 2 r 0 4 r 3 m 20 m 0 m 2 2 r 0 2 r 90 m 10 m 2 m 3 m 0 3 r 9 m 90 m 11 m 0 m 88 m 0 m 88 m 10 2 r 90 m 91 m 20 m 0 m 88
m 8 m 90 m 1 m 90 m 91 m 0 m 2 m 0 m 10 2 r 0 m 10 m 1 m 20 m 90 m 40 m 10 m 88 m 0 m 82 m c1 m 20 m 0 m 4 m 0 m 8 m 0 11 r 48
m 0 5 r 42 m b m 0 29 r 11 m 0 2 r b m 0 m 42 m 0 4 r 42 m 0 2 r b m 0 m 41 m 0 2 r 42 m 0 2 r b m 0 m 50 m 0 2 r 42 m 0 2 r b
m 0 4 r 11 m 0 2 r b m 0 m 42 m 0 2 r 42 m 0 2 r b m 0 m 81 m 0 2 r 42 m 0 2 r b m 0 4 r 42 m 0 m 42 m b m 0 m 60 m 0 41 r
notbusy
20 wcmd 3 m 10 m 0 m notbusy \ 0x31000
02 wcmd 3 m 10 m 0 m \ 0x31000 
ff 4 r 0 m a5 m 0 m a5 m 0 2 r 90 m 9 m 90 m 9 m f m 0 m f m 0 5 r c0 m 3 m c0 m 3 m c3 2 r 0 4 r 3c m c3 m ef m ff m 0 2 r 9
m 90 m 9 m 90 m 0 2 r c3 2 r 0 2 r a5 2 r f0 4 r 99 m 0 m 99 m 0 2 r bf m 0 m ff m fb m 0 m ff m 0 11 r 42 m 90 m 6 m 0 2 r 1
m 20 m 4 m 0 28 r db m ff 3 r 0 m a5 m 0 m a5 m 0 2 r 90 m 9 m 90 m 9 m 0 m f m 0 m f m ff m 0 2 r ff m c0 m 3 m c0 m 3 m 0 2
r c3 2 r 0 2 r 3c m c3 m ff 2 r 0 2 r 9 m 90 m 9 m 90 m c3 2 r 0 4 r a5 2 r d0 m f0 3 r 0 m 99 m 0 m 99 m 0 m ff m 0 m ff 2 r
0 m ff m 0 13 r 20 m 48 m 10 m 2 m 0 26 r notbusy
02 wcmd 3 m 11 m 0 m \ 0x31100 
0 82 r ff 2 r fb m ff m 0 2 r c3 2 r 0 6 r a0 4 r 0 2 r ff m 0 m 96 m 0 m 96 m 0 m 90 2 r 60 2 r 0 m ff m 0 m f7 m 0 2 r fb m
ff m 99 m 66 m 0 2 r c0 4 r ff m 0 m f7 m 0 m ff m fd m 0 2 r 66 4 r 0 2 r ff m fd m 0 m ff m 0 m f7 m 30 2 r c0 2 r 0 38 r
notbusy
02 wcmd 3 m 12 m 0 m \ 0x31200 
0 8 r c3 2 r 0 2 r 99 2 r 66 2 r 0 2 r a0 4 r ff m 0 3 r 96 m 0 m 96 m 0 m 90 2 r 60 2 r 0 m ff m 0 m ff m 0 2 r ff 2 r 99 m
66 m 0 2 r 3 4 r ff m 0 m ff m 0 m ff 2 r 0 2 r 66 3 r 62 m 0 2 r ff 2 r 0 m ff m 0 m ff m 30 2 r c0 2 r 0 12 r 8 m 19 m 10 m
0 24 r 61 m 0 m 6 m 0 m d m 0 2 r 3 m 0 2 r 20 m c m 0 m 10 m c0 m 0 2 r 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m 3 m 26 m
c m d m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m
3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m 3 m a6 m 2c m 5 m 0 m c0 m 0 16 r 80 m 2 m 0 1c r notbusy
02 wcmd 3 m 13 m 0 m \ 0x31300 
0 1a r aa m 8a m aa 2 r 0 4 r f0 2 r d0 m f0 m 0 5 r df m 0 m ff m 0 4 r ff 3 r 7f m 0 c r aa m 0 m aa m ff m 0 4 r ff m df m
ff 2 r 0 12 r 2 m 0 3 r 1 m 0 37 r aa 4 r 0 4 r f0 4 r 0 5 r ff m 0 m ff m 0 14 r 3c m f0 m 3c m f0 m 0 18 r 2 m 0 6 r 40 m 0
18 r notbusy
02 wcmd 3 m 14 m 0 m \ 0x31400 
0 c r 3c m 1c m 3c 2 r 0 e r ff 3 r ef m 0 4 r 3c m 1c m 3c 2 r 0 4 r f0 3 r e0 m 0 4 r ff 3 r 7f m f 2 r b m f m ff 3 r ef m
0 c r fa 2 r ff 2 r 0 3c r 3c 4 r 0 16 r 3c 4 r 0 4 r f0 4 r 0 8 r f 4 r 0 10 r 50 2 r aa m 55 m 0 2c r notbusy
02 wcmd 3 m 15 m 0 m \ 0x31500 
0 2d r 8 m 0 8 r 1 m 0 3 r 1 m 0 12 r 2 m 0 51 r 2 m 0 18 r 40 m 0 3 r 10 m 0 12 r 1 m 0 1e r 2 m 0 m 84 m 0 f r notbusy
02 wcmd 3 m 16 m 0 m \ 0x31600 
0 27 r 80 m 0 12 r 41 m 0 3 r 10 m 0 2 r 80 m 0 67 r 2 m 0 d r 84 m 0 4 r c0 m 0 3 r 80 m 0 2 r 4 m 0 f r 90 m 0 2c r notbusy
02 wcmd 3 m 17 m 0 m \ 0x31700 
0 32 r 1 m 0 4 r 21 m 0 6 r 41 m 82 m 0 4 r 1 m 4 m 0 m 21 m 0 m 3 m 0 m 9 m 1 m 0 6 r 20 m 0 m 20 m 0 m 4 m 0 25 r 84 m 0 21
r 82 m 0 2 r 40 m 0 2 r 8 m 0 3 r 88 m 0 m 10 m 0 3 r 84 m 0 m a0 m 0 2 r 40 m 84 m 0 3 r 82 m 0 m a0 m 0 4 r c0 m 3 m 0 4 r
20 m a1 m 0 2 r 5 m 82 m 41 m 0 m 40 m 0 m 3 m 0 m 9 m 0 4 r 4 m 0 m 4 m 0 3 r 88 m 0 3 r c0 m 0 5 r 90 m 0 7 r 40 m 0 10 r
notbusy
02 wcmd 3 m 18 m 0 m \ 0x31800 
0 21 r 3 m 0 3 r 3 m 0 1c r 40 m 0 5 r 1 m 0 19 r 10 m 0 54 r 84 m 0 c r 80 m 0 5 r 20 m 0 35 r notbusy
02 wcmd 3 m 19 m 0 m \ 0x31900 
0 11 r 8 m 0 19 r 80 m 0 3 r 3 m 0 m 3 m 0 3 r 85 m 0 m 21 m 0 3 r 80 m 0 m 8 m 0 m 3 m 0 6 r 41 m 0 5 r 20 m 84 m 0 m 21 m 0
m 40 m c0 m 0 2 r 40 m 0 m 11 m 0 5 r 4 m 0 m 4 m 0 41 r 8 m 0 7 r 82 m 0 3 r 2 m 0 2 r 40 m 0 2 r 84 m 0 3 r 2 m 11 m a0 m 0
3 r 10 m 0 m 8 m 0 m 82 m 21 m a0 m 0 m a0 m 0 m 84 m c0 m 84 m 0 3 r c0 m 80 m 5 m 21 m 0 2 r 82 m 0 2 r 11 m 0 m 3 m 90 m 9
m 0 2 r 2 m 0 m 20 m 4 2 r 40 m a0 m 0 3 r 4 m 0 f r 80 m 0 8 r notbusy
02 wcmd 3 m 1a m 0 m \ 0x31a00 
0 f r 3 m 0 25 r 10 m 0 6 r 8 m 40 m 0 3 r a1 m 0 m 21 m 0 m 21 m 0 m 21 m 0 2 r 40 m 0 6 r 4 m 0 m 21 m 0 9 r 3 m 0 1b r 8 m
0 44 r 80 m 1 m 0 3 r 2 m 0 8 r 80 m 0 6 r 1 m 0 13 r c0 m 0 18 r notbusy
02 wcmd 3 m 1b m 0 m \ 0x31b00 
0 30 r 10 m 0 9 r 40 m 0 3 r 2 m 8 m 0 m 90 m 8 m 40 m c0 m 2 m 0 9 r 1 m 0 2 r 10 m 0 2 r 1 m 0 2 r 1 m 0 m 88 m 0 5 r a0 m 0
m 82 m 0 4d r 9 m 0 m 80 m 0 5 r 8 m 0 m 11 m 0 m 80 m 0 3 r 2 m 80 m 21 m 0 m 80 2 r 0 b r 41 m 0 m 11 m 82 m 11 m 0 m 8 m 0
2 r 41 m 0 7 r 3 m 0 m 80 m 0 1b r notbusy
02 wcmd 3 m 1c m 0 m \ 0x31c00 
0 3e r 8 m 0 3 r 89 m 0 m 10 m 0 m 89 m 0 m 4 m 0 e r 4 m 0 68 r 1 m 0 3 r 8 m 0 m 91 m 0 m 40 m 0 m a0 m 0 35 r notbusy
02 wcmd 3 m 1d m 0 m \ 0x31d00 
0 37 r 1 m 0 b r 1 m 0 2 r c0 m 8 m 0 m 90 m c0 m 8 m c0 m 2 m 0 9 r 1 3 r 0 2 r 1 m 0 5a r 11 m 0 m 20 m 0 m 11 m 0 m 8 m 0 3
r 2 m 0 m 11 m 0 m 40 m 0 m 9 m 0 m 89 m 0 m 41 m 0 m c1 m 80 m 2 m 0 9 r 21 m 3 2 r 11 m 10 m 11 m 2 m 0 m 11 m 0 m 9 m 0 m 3
m 0 m 4 m 0 m 40 m 0 m 11 m 0 m 41 m 0 m 8 m 0 10 r notbusy
02 wcmd 3 m 1e m 0 m \ 0x31e00 
0 4b r 10 m 0 m 80 m 0 m 80 m 0 m 2 m 0 19 r 10 m 0 61 r 3 m 0 m 10 m 0 m 8 m 0 1b r 1 m 0 12 r notbusy
02 wcmd 3 m 1f m 0 m \ 0x31f00 
0 55 r 12 m 0 8 r 82 m 0 2 r d0 m 0 a r 60 m 0 67 r ff 3 r f7 m 0 28 r notbusy
20 wcmd 3 m 20 m 0 m notbusy \ 0x32000
02 wcmd 3 m 20 m 0 m \ 0x32000 
0 8 r ff 82 r 0 m 2e m da m ec m 30 m 22 m 3 m 6 m 0 m 17 m 50 m 60 m 0 2 r 5 m 14 m 0 4a r ff m fb m ff 2 r ef m ff m 0 16 r
notbusy
02 wcmd 3 m 21 m 0 m \ 0x32100 
0 6a r ff 2 r 0 6b r 61 m 0 m 6 m 0 m d m 0 5 r 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 6 m 0 m d m 0 m 1 m 0 9 r 61 m 0 m 7 m 80
m 9 m 20 m 0 m notbusy
02 wcmd 3 m 22 m 0 m \ 0x32200 
0 m 61 m 0 m 6 m 0 m d m 0 3 r 61 m 0 m 6 m 0 m d m 0 15 r 1 m 0 38 r f0 3 r e0 m 0 7 r ff m 0 m ff m 0 4 r f0 2 r d0 m f0 m 0
c r ff m d8 m 0 8 r ff m 7f m 0 4 r aa m 8a m aa 2 r 0 4c r f0 4 r 0 7 r ff m 0 m df m 0 4 r f0 4 r 0 c r notbusy
02 wcmd 3 m 23 m 0 m \ 0x32300 
ff m d8 m 0 8 r ff 2 r 0 4 r aa 4 r 0 56 r ff m 0 m ff m 0 7 r ff m f7 m 0 8 r 3c m 0 27 r 2 m 0 45 r ff m 0 m ff m 0 7 r ff 2
r 0 8 r notbusy
02 wcmd 3 m 24 m 0 m \ 0x32400 
0 2 r 40 m 0 5b r 2 m 0 21 r 20 m 0 11 r 40 m 0 m 40 m 0 m 40 m 0 7 r 40 m 0 2b r 40 m 0 35 r notbusy
02 wcmd 3 m 25 m 0 m \ 0x32500 
0 3a r 2 m 0 71 r 4 m 0 1f r 4 m 0 33 r notbusy
02 wcmd 3 m 26 m 0 m \ 0x32600 
0 15 r 10 m 0 62 r 84 m 0 m 20 m 0 21 r 40 m 0 7 r 88 m 0 2 r 11 m 40 m 0 m 84 m 0 55 r notbusy
02 wcmd 3 m 27 m 0 m \ 0x32700 
0 e r 2 m 0 a r a0 m 0 f r 84 m 0 8 r 21 m 0 2 r 11 m 0 d r 4 m 0 bc r notbusy
02 wcmd 3 m 28 m 0 m \ 0x32800 
0 1e r 40 m 0 m 4 m 0 80 r 40 m 0 5b r 84 m 0 m c0 m notbusy
02 wcmd 3 m 29 m 0 m \ 0x32900 
0 m 8 m 0 2 r 20 m 0 10 r 82 m 0 d r 4 m 40 m 0 e r 8 m 0 53 r 11 m 0 2c r 8 m 0 6 r 8 m 0 37 r 10 m 0 c r notbusy
02 wcmd 3 m 2a m 0 m \ 0x32a00 
0 29 r 4 m 0 m 4 m 0 4 r 20 m 0 3 r 9 m 0 2 r 20 m 0 8 r ff 82 r 0 m a m 4a m 34 m 30 m 22 m 3 m 8 m 0 2 r 50 m 60 m 0 2 r 6 m
18 m 0 10 r 10 m 0 1d r notbusy
02 wcmd 3 m 2b m 0 m \ 0x32b00 
0 2 r 20 m 0 21 r 20 m 0 1f r 20 m 0 2 r 40 m 0 3 r 20 m 0 49 r 2 m 0 13 r 8 m 0 5 r 2 m 0 e r 41 m 0 a r 1 m 0 2 r 41 m 1 m 0
16 r 10 m 0 1b r notbusy
02 wcmd 3 m 2c m 0 m \ 0x32c00 
0 4a r 1 m 80 m 0 1a r 80 m 0 62 r 90 m 5 m 0 m 2 m 20 m 0 32 r notbusy
02 wcmd 3 m 2d m 0 m \ 0x32d00 
0 16 r 40 m 0 m 1 m 0 3 r 20 m 0 12 r 8 m 0 1c r 40 m 0 m 4 m 0 5 r 10 m 0 43 r 80 m 0 m 40 m 0 12 r 8 m 0 20 r 40 m 0 m 80 m
0 2f r notbusy
02 wcmd 3 m 2e m 0 m \ 0x32e00 
0 d r 40 m 0 45 r 20 m 0 m 80 m 0 m 20 m 0 f r 4 m 0 e r 2 m 0 5e r 1 m 0 m 10 m 0 m 1 m 0 26 r notbusy
02 wcmd 3 m 2f m 0 m \ 0x32f00 
0 27 r 21 m 0 3 r 5 m 0 26 r 40 m 0 m 1 m 0 m 2 m 0 m 1 m 0 7d r 8 m 0 m 80 m 0 m 8 m 0 25 r notbusy
20 wcmd 3 m 30 m 0 m notbusy \ 0x33000
02 wcmd 3 m 30 m 0 m \ 0x33000 
0 2b r 21 m 0 b r 8 m 0 18 r 4 m 0 5 r 40 m 0 3 r 1 m 80 m 1 m 0 75 r 5 m 20 m 0 m 90 m 0 m 90 m 40 m 2 m 21 m 90 m 4 m 20 m 8
m 0 m 21 m 0 1f r notbusy
02 wcmd 3 m 31 m 0 m \ 0x33100 
0 26 r 84 m 0 35 r c0 m 88 m 90 2 r 0 m 2 m 82 m 90 m 0 42 r 11 m 0 37 r a0 m 80 3 r 0 m 80 3 r 0 1a r notbusy
02 wcmd 3 m 32 m 0 m \ 0x33200 
0 26 r 40 m 0 m 11 m 0 m 4 m 0 m 11 m 0 33 r 80 m 0 m 80 m 11 m 80 4 r 0 40 r 1 m 0 3 r 1 m 0 35 r 88 m 0 m 82 m 1 m 2 m 40 m
c0 m 90 m 0 16 r notbusy
02 wcmd 3 m 33 m 0 m \ 0x33300 
0 2b r 1 m 0 3 r 1 m 0 34 r 90 m 82 m 0 m 88 m 0 m 88 m 2 m 4 m 0 41 r 4 m 0 m 9 m 0 m 8 m 0 m 10 m 0 35 r 80 m 0 2 r 80 2 r 0
12 r notbusy
02 wcmd 3 m 34 m 0 m \ 0x33400 
0 35 r 10 m 0 32 r 80 m 0 2 r a0 m 0 2 r 80 m 0 42 r 84 m 0 38 r 4 m 0 m 90 m 88 m a0 m 88 m 4 m 0 f r notbusy
02 wcmd 3 m 35 m 0 m \ 0x33500 
0 6d r a m 0 2 r b m 5 m 88 m 0 7b r f0 m d0 m f0 2 r 83 m c3 3 r 0 a r notbusy
02 wcmd 3 m 36 m 0 m \ 0x33600 
0 70 r f0 4 r c3 m c1 m c3 2 r 0 8 r ff 80 r notbusy
02 wcmd 3 m 37 m 0 m \ 0x33700 
ff 2 r 0 m 6 m de m a m 30 m 22 m 3 m 8 m 0 m 18 m 50 m 60 m 0 2 r 9 m a6 m 0 72 r f0 2 r 20 m d0 m eb m 0 m f3 m 0 75 r
notbusy
02 wcmd 3 m 38 m 0 m \ 0x33800 
0 6 r f0 2 r 0 m f0 m e7 m 0 m cf m 0 14 r 1 m 0 2d r 61 m 0 m 6 m 0 m d m 0 35 r 8 m 0 m 28 m 0 m 10 m 0 m 8 m 0 45 r ff m 0
m ff m 0 28 r notbusy
02 wcmd 3 m 39 m 0 m \ 0x33900 
0 57 r ff m 0 m df m 0 4a r 2 m 0 33 r 3c 3 r 34 m 0 24 r notbusy
02 wcmd 3 m 3a m 0 m \ 0x33a00 
0 5a r 3c 4 r 0 42 r 82 m 0 1f r 20 m 0 d r 4 m 0 7 r c0 m 0 b r 20 m 0 d r 20 m 0 7 r 20 m 0 m 1 m 0 m 1 m 0 m 1 m 0 m
notbusy
02 wcmd 3 m 3b m 0 m \ 0x33b00 
0 m 80 m 20 m 80 m 0 m 80 m 0 4 r 2 m 40 m 0 4 r 20 m 0 8 r 4 m 0 18 r 10 m 0 30 r 2 m 0 17 r 8 m 4 m 0 m 4 m 0 m 4 m 0 2 r 20
m 0 m 2 m 0 m 20 m 9 m a0 m 0 3 r 1 m 0 6 r 9 m 0 6 r 1 m 0 64 r notbusy
02 wcmd 3 m 3c m 0 m \ 0x33c00 
0 a r 2 m 0 7 r 2 m 0 9 r 1 m 80 m 0 16 r 2 m 0 5a r 82 m 0 2 r 2 m 0 b r 20 m 10 m 0 60 r notbusy
02 wcmd 3 m 3d m 0 m \ 0x33d00 
0 7 r 3 m 0 2 r 1 m 0 7 r 20 m 0 m 2 m 0 b r 84 m 0 52 r 8 m 0 18 r 4 m 0 7 r 20 m 0 m 80 m 0 m 11 m 0 m 41 m 0 32 r 40 m 0 m
40 m 0 m 40 m 0 24 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 m notbusy
02 wcmd 3 m 3e m 0 m \ 0x33e00 
4 m 0 m 4 m 0 m 4 m 0 9 r a0 m 0 15 r 8 m 0 17 r 20 m 0 f r 40 m 0 2b r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 m
80 m 0 m 80 m 0 1a r 88 m 0 3 r 40 m 0 m 40 m 0 58 r notbusy
02 wcmd 3 m 3f m 0 m \ 0x33f00 
0 4 r 4 m 0 5 r 82 m 3 m 82 m 0 3 r 82 m 0 m 82 m 0 2 r 5 m 0 3 r 2 m 20 m 0 8 r 3 m 0 m 10 m 0 2 r 1 m 80 m 0 7 r 8 m 0 3f r
84 m 0 14 r 80 m 0 14 r 1 m 0 a r 9 m 0 3 r 20 m 4 m 0 1f r 5 m 0 7 r 2 m 0 29 r 40 m 0 2 r notbusy
20 wcmd 3 m 40 m 0 m notbusy \ 0x34000
02 wcmd 3 m 40 m 0 m \ 0x34000 
0 9 r 3 m 0 4 r c0 m 0 3 r 82 m 3 m 0 d r 3 m 0 m 3 m 0 m 9 m 0 m 9 m 0 3 r 11 m 0 5 r 40 m 0 5f r 82 m 0 12 r 11 m c0 m 2 m 0
59 r notbusy
02 wcmd 3 m 41 m 0 m \ 0x34100 
0 3 r c0 m 0 m 90 m 0 5 r c0 m 0 m 90 m 0 5 r c0 m 10 m 90 m 0 5 r c0 m 0 m 91 m 40 m 0 3 r 10 m 0 5 r c0 m 0 3 r 1 m 0 58 r
80 m 0 m 80 m 0 5 r 80 m 0 m 80 m 0 5 r 80 3 r 0 5 r 83 m 40 m 83 m 0 m 5 m 0 m 3 m 0 6 r 80 m 0 3 r 20 m 0 m 20 m 0 12 r 2 m
0 7 r 9 m 0 34 r notbusy
02 wcmd 3 m 42 m 0 m \ 0x34200 
0 a r 80 m 0 m 80 2 r 0 4 r 80 m 0 m 80 2 r 0 4 r 80 m 0 m 80 2 r 0 4 r 80 m 0 m 80 2 r 0 4 r 80 m 0 13 r 84 m 0 6 r 1 m 0 46
r 84 m 0 m c0 m 90 m 0 4 r 84 m 0 m c0 m 90 m 0 4 r 84 m 0 m c0 m 90 m 0 4 r 84 m 0 m c0 m 90 m 10 m 0 m c0 m 0 m 8 m 0 m 88 m
0 m a0 m 0 m 90 m 0 m c0 m 0 m a0 m 0 49 r notbusy
02 wcmd 3 m 43 m 0 m \ 0x34300 
0 e r 2 m 90 m 0 m c0 m 0 4 r 8 m 90 m 0 m c0 m 0 4 r 10 m 90 m 0 m c0 m 0 4 r 1 m 90 m 0 m c0 m 0 m 8 m 0 m c0 m 0 m a0 m 0 m
c0 m 0 7 r 1 m 0 57 r 80 m 0 m 80 m 0 4 r 80 2 r 0 m 80 m 0 4 r 80 2 r 0 m 80 m 0 m 40 m 3 m 21 m 11 m 89 m 0 m c0 m 0 m 80 m
0 9 r 20 m 0 3 r 11 m 0 44 r notbusy
02 wcmd 3 m 44 m 0 m \ 0x34400 
0 e r 80 m 0 2 r 9 m 0 4 r 80 m 11 m 80 m 11 m 0 4 r 80 m 11 m 80 m 41 m 0 4 r 80 m 21 m 0 m 10 m 0 2 r 80 m 0 e r 80 m 0 54 r
90 m 0 7 r c0 m 1 m 20 m 0 5 r c0 m 1 m 20 m 1 m 0 4 r c0 m 1 m 0 m 1 m 0 2 r 8 m 0 4 r c0 m 0 m c0 m 0 5 r a0 m 0 m 2 m 0 42
r notbusy
02 wcmd 3 m 45 m 0 m \ 0x34500 
0 13 r 21 m 0 2 r b m 0 4 r 21 m 0 2 r b m 0 4 r 21 m 0 2 r b m 0 m 82 m 0 2 r 42 m 0 2 r b m 0 a r 82 m 48 m 0 2 r d0 m 0 58
r ff 2 r 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 2 r 3c 2 r 0 3 r ff m 0 6 r ff 2 r 0 44 r notbusy
02 wcmd 3 m 46 m 0 m \ 0x34600 
0 18 r ff 2 r 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 2 r 3c 2 r 0 3 r ff m 0 6 r ff m df m 0 5a r ff m 0 3 r
ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 4 r ff 3 r 0 4 r ff 2 r fb m ff m 0 4 r ef m 0 m ff m 0 39 r
notbusy
02 wcmd 3 m 47 m 0 m \ 0x34700 
0 1a r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 3 r ff m 0 4 r ff 3 r 0 c r ff m 0 m ff m 0 53 r 3 m 2 m
3 m 38 m c m 0 m 92 m c0 m 3 m 82 m 3 m 38 m c m 0 m 92 m c0 m 3 m 82 m 3 m 38 m c m 0 m 92 m c0 m 3 m e3 m 3 m 3e m c m d m
82 m c0 m 0 5 r 10 m 0 m 1 m 0 m 61 m 0 m 7 m 80 m 9 m 20 m 0 d r 90 m 0 7 r 10 m 0 1f r notbusy
02 wcmd 3 m 48 m 0 m \ 0x34800 
0 3a r ff 2 r f7 m ff m 0 c r f 2 r 0 d r 4 m 0 2 r 80 m 0 7 r 80 m 0 57 r ff 4 r 0 c r f 4 r 0 9 r 2 m 0 4 r 40 m 0 2 r 2 m 0
1e r notbusy
02 wcmd 3 m 49 m 0 m \ 0x34900 
0 3a r fb m ff 3 r 0 7e r ff 4 r 0 1c r ff 24 r notbusy
02 wcmd 3 m 4a m 0 m \ 0x34a00 
ff 5e r 0 m 36 m 65 m 25 m 30 m 22 m 3 m a m 0 2 r 50 m 60 m 0 3 r c3 m 0 e r 2 m 0 m 2 m 0 5 r 84 m 0 f r 84 m 0 7 r 82 m 0 7
r 20 m 0 11 r 20 m 0 7 r 20 m 0 7 r 20 m 0 f r 20 m 0 m 1 m 0 4 r 80 m 4 m 80 m 0 2 r 82 m 0 3 r 82 m 0 5 r 88 m 0 13 r
notbusy
02 wcmd 3 m 4b m 0 m \ 0x34b00 
0 31 r 2 m 0 28 r 8 m 0 4 r 10 m 80 m 10 m 0 10 r ff 82 r 0 m 5 m b1 m 32 m 30 m 22 m 3 m a m 0 m 3 m 50 m 60 m notbusy
02 wcmd 3 m 4c m 0 m \ 0x34c00 
0 2 r 5 m 55 m 0 6b r 84 m 0 4 r 20 m 0 5c r 11 m 0 20 r 1 m 0 m 1 m 0 m 9 m 80 m 20 m 0 7 r notbusy
02 wcmd 3 m 4d m 0 m \ 0x34d00 
0 m 8 m 0 5 r 8 m 0 2e r 8 m 0 3d r 2 m 0 m 8 m 0 m 82 m 20 m 0 8 r 4 m 0 m 10 m 0 34 r 4 m 0 2a r 2 m 0 3 r 2 m 0 f r 90 m 0
2 r 80 m 0 4 r notbusy
02 wcmd 3 m 4e m 0 m \ 0x34e00 
0 2 r 8 m 0 39 r 8 m 0 8 r a0 m 0 11 r 8 m 0 20 r 11 m 0 4 r 20 m 0 73 r 8 m 0 4 r 90 m 0 6 r 89 m 0 2 r notbusy
02 wcmd 3 m 4f m 0 m \ 0x34f00 
0 74 r 21 m 0 a r 10 m 0 m 2 m 20 m 0 6b r 88 m 0 11 r notbusy
20 wcmd 3 m 50 m 0 m notbusy \ 0x35000
02 wcmd 3 m 50 m 0 m \ 0x35000 
0 7 r 4 m 0 57 r 8 m 0 11 r 82 m 0 4 r 5 m 0 6 r 82 m 0 11 r 8 m 0 70 r notbusy
02 wcmd 3 m 51 m 0 m \ 0x35100 
10 m 40 m 0 m a0 m 0 m 84 m 2 m 90 m 0 7a r 40 m 0 4 r 80 m 0 m 80 m 0 76 r notbusy
02 wcmd 3 m 52 m 0 m \ 0x35200 
0 7 r 21 m 80 2 r 0 m 80 m 0 7a r 40 m 0 m a0 m 0 m 2 2 r 0 m c0 m 0 72 r notbusy
02 wcmd 3 m 53 m 0 m \ 0x35300 
0 8 r 4 m 0 2 r 88 m 0 m 40 m 4 m c0 m 0 7d r 80 m 0 2 r 10 m 0 6f r notbusy
02 wcmd 3 m 54 m 0 m \ 0x35400 
0 d r 2 m 80 2 r 0 m 80 m 0 7c r a0 m 0 m 8 2 r 4 m 84 m 10 m 0 6b r notbusy
02 wcmd 3 m 55 m 0 m \ 0x35500 
0 11 r 81 m 0 2 r b m 4 m 0 m 21 m 0 7a r b0 m f0 3 r ff 2 r f6 m f0 m 0 66 r notbusy
02 wcmd 3 m 56 m 0 m \ 0x35600 
0 14 r f0 4 r ff 2 r f0 2 r 0 10 r ff 82 r 0 m 28 m 44 m b2 m 30 m 22 m 3 m a m 0 m 18 m 50 m 60 m 0 2 r 1 m 4 m 0 42 r
notbusy
02 wcmd 3 m 57 m 0 m \ 0x35700 
0 28 r 66 3 r 46 m 0 7e r 66 4 r 0 m 4 m 0 m 4 m 0 4e r notbusy
02 wcmd 3 m 58 m 0 m \ 0x35800 
0 2e r 40 m 20 m 0 3 r a1 m 0 10 r ff 82 r 0 m b m aa m c m 30 m 22 m 3 m b m 0 2 r 50 m 60 m 0 2 r d m b6 m 0 e r 2 m 0 f r 4
m 0 b r notbusy
02 wcmd 3 m 59 m 0 m \ 0x35900 
0 4 r 20 m 0 m 4 m 0 d r 20 m 0 11 r 20 m 0 f r 20 m 0 9 r 40 m 0 m 4 m 0 3 r 20 m 0 3 r 84 m 0 3 r 88 m 0 m 88 m 0 5 r a0 m 0
31 r 80 m 0 10 r 3 m 0 2a r 80 m 0 3b r notbusy
02 wcmd 3 m 5a m 0 m \ 0x35a00 
0 59 r 5 m 0 m 80 m 0 5b r 84 m 0 5 r 8 m 0 1e r 2 m 4 m 0 22 r notbusy
02 wcmd 3 m 5b m 0 m \ 0x35b00 
0 21 r 41 m 0 m 3 m 0 5 r 5 m 0 7 r 11 m 0 m 3 m 0 4 r 1 m 21 m 0 5 r 11 m 0 m 3 m 0 7 r 3 m 0 7 r 3 m 0 5 r 5 m 0 m 5 m 0 3 r
9 m 0 5c r 4 m 0 16 r 8 m 0 7 r 20 m 0 26 r notbusy
02 wcmd 3 m 5c m 0 m \ 0x35c00 
0 13 r 80 m 0 4 r 1 m 0 m 40 m 0 d r 1 m 0 m 1 m 0 m 82 m 0 7 r 1 m 0 5 r 1 m 0 m 82 m 0 m 1 m 0 b r a0 m 0 m 82 m 0 3 r 4 m 0
m a0 m 0 b r 4 m 0 3 r 9 m 82 m 0 20 r 20 m 0 m 20 m 0 m 20 m 0 c r 20 m 0 4 r 4 m 0 m 40 m 8 m 0 5 r 8 m 0 6 r 4 m 0 m 4 m 0
m 3 m 0 6 r a0 m 4 m 0 5 r 4 m 0 3 r 4 m 0 4 r 8 m 0 7 r a0 m 0 m 82 m 41 m 0 m 80 m 0 6 r 84 m 0 a r 20 m 5 m 0 1a r notbusy
02 wcmd 3 m 5d m 0 m \ 0x35d00 
0 16 r 4 m 0 3 r 4 m 0 4 r 2 m 0 m 11 m 0 2 r c0 m 0 6 r 21 m c0 m 0 3 r 83 m 5 m c0 m 0 5 r 8 m 3 m 0 3 r 2 m 0 m 2 m 82 m 21
m 0 4 r c0 m 8 m 0 m 21 m 0 2 r c0 m 2 m 0 m 2 m 0 m 3 m 0 3 r 20 m 4 m 85 m 20 m 3 m 0 m 3 m c0 m 0 m a0 m 3 m 0 m 2 m 0 m 2
m 0 m 21 m 0 m 4 m 0 30 r 80 m 0 3 r 80 m 0 15 r 4 m 0 c r 1 m 0 m 1 m 0 d r 1 m 0 m c1 m 0 5 r 1 m 80 m 2 m 0 9 r 1 m 0 m 1 m
0 3 r 1 m 0 16 r notbusy
02 wcmd 3 m 5e m 0 m \ 0x35e00 
0 21 r 2 m 0 m 82 m 0 3 r 82 m 1 m 2 m 0 3 r c1 m 1 m 3 m 0 4 r 82 m 80 m 4 m 0 m 1 m 0 m 1 m 0 2 r 21 m 0 2 r 1 m 0 6 r 5 m 0
m 80 m 41 m 8 m 4 m 3 m 0 m 5 m 1 m 8 m c1 m 9 m 0 m 3 m 0 m 5 m 40 m 0 m 84 m 0 4 r 5 m 0 m 3 m 0 m 5 m 0 3 r 11 m 1 m 80 m 0
m 2 m 0 37 r 1 m 40 m 20 m 0 3 r 21 m 4 m 9 m 0 3 r 20 m 4 m 0 5 r 3 m 20 m 80 m 0 m 4 m 0 m 4 m 0 5 r 4 m 0 m 41 m 0 m 3 m 0
4 r 20 m 84 m 8 m 80 m 0 3 r 4 m 0 m 4 m 0 5 r 80 m 0 7 r 21 m 0 2 r 84 m 0 3 r 90 m 40 m 2 m 0 m 1 m 0 12 r notbusy
02 wcmd 3 m 5f m 0 m \ 0x35f00 
0 1f r 4 m 0 m 2 m 40 m 0 5 r 90 2 r 82 m 0 m 2 2 r 0 2 r c0 m 0 2 r 90 m 0 m 10 m 0 3 r 40 m 90 m 10 m 0 m 10 m 0 m 82 m 4 2
r 0 m 90 m 10 2 r 8 m 88 m 0 m 8 m 1 m 90 2 r 0 m 2 2 r 0 m 2 m 0 m 90 2 r 10 m 0 m 2 m 10 m 0 2 r 90 m 10 m 0 2 r 8 m 0 a r 1
2 r 88 m 0 31 r 9 m 0 m 4 m 0 m 10 m 0 m 80 m 0 m 9 m 0 3 r 90 m 80 2 r 0 m 80 2 r 0 2 r 80 m 0 2 r 80 m 0 m 80 m 0 4 r 80 m 0
2 r 80 m 0 m 80 m 91 m 80 m 5 m 80 m 0 m 80 2 r 0 m 40 m 80 m 41 m 80 m 0 2 r 80 2 r 11 m 0 m 10 m 80 m 0 m 80 m 0 m 80 m c0 m
0 m 11 m 80 2 r 0 2 r 80 m 0 9 r 40 m 3 2 r 0 m 40 m 0 m 8 m 0 e r notbusy
20 wcmd 3 m 60 m 0 m notbusy \ 0x36000
02 wcmd 3 m 60 m 0 m \ 0x36000 
0 25 r 90 m 0 2 r 80 2 r 2 m 0 m 10 m 80 m 10 m 0 m 91 m 0 7 r 80 3 r 0 4 r 83 m 80 m 40 m 80 m 0 m 82 m 0 m 11 m 90 m 11 m 80
m 83 m 0 4 r 10 m 80 3 r 0 m 9 m 0 m 11 m 82 m 90 m 80 m 83 m 0 m 8 m 0 m 91 m 3 m 41 m 0 m a0 m 80 m 0 8 r 10 m 0 m 10 m 0 m
10 m 40 m 21 m 88 m 0 30 r 88 m 0 2 r 84 m 0 2 r 90 m 10 m 1 m 0 2 r 84 m 0 2 r 90 2 r 0 5 r 88 m 2 m 10 m 90 m 88 m 40 m 0 m
10 3 r 1 m 90 m 88 m 2 m 0 m 3 m 20 m 0 m 10 m 90 m 10 2 r 0 m 2 m 88 m 40 2 r 90 m 88 m 90 m 0 m 3 m 20 m 11 m 10 m 90 m 88 m
3 m 0 m 2 2 r 0 2 r 90 m c0 m 0 8 r 1 m 40 m 0 3 r 1 2 r 3 m 0 a r notbusy
02 wcmd 3 m 61 m 0 m \ 0x36100 
0 26 r 90 2 r 0 m 2 m 8 m 91 m 0 m 1 m 3 m 1 m 0 m 8 m 82 m 90 m 0 m 1 m 0 2 r c0 m 0 2 r 10 2 r 90 m 0 2 r 3 m 8 m 0 2 r 90 2
r 2 2 r 11 m 10 m 0 m 10 m 90 2 r 10 m 88 m 0 m 9 m 0 m 1 m 82 m 91 m 0 m 1 m 91 m 11 m 0 m 2 m 40 m 90 m 88 m 1 m 3 m 2 m 0 2
r 10 m 0 2 r 8 m 0 a r 1 m 0 35 r 80 m 89 m 0 m 11 m 80 m 88 m 0 m 8 m 10 m 2 m 0 m 90 m 80 m 91 m 0 m 8 m 0 2 r 82 m 0 2 r 80
m 0 m 80 m 0 2 r 8 m 80 m 0 3 r 80 m 2 m 80 m 88 m 11 m 0 m 91 m 0 m 83 m 0 m 10 m 11 m 90 m 0 m 10 m 80 m c0 m 10 2 r 40 m 90
m 0 m 91 m 80 m 83 m 0 m 20 m 88 m c0 m 0 m 21 m 80 m 2 m 0 m a0 m 0 9 r 40 m 41 m 3 m 2 2 r 40 m 0 7 r notbusy
02 wcmd 3 m 62 m 0 m \ 0x36200 
0 2a r 80 m 2 m 80 m 0 5 r 80 m 89 m 80 m 88 m 80 2 r 0 m 8 m 0 2 r 80 m 4 m 80 2 r 0 4 r 80 m 11 m 80 m 0 2 r 80 m 0 2 r 80 m
91 m 80 m 0 m 80 m 0 2 r 8 m 0 m 10 m 80 m 88 m 80 3 r 0 m 80 m 10 m 0 2 r 80 2 r 0 m 10 m 80 m 85 m 0 4 r 80 m 10 m 0 8 r 3 m
0 m 3 m 0 m 2 m 0 m 11 m 8 m 0 30 r 8 m 0 m 10 m 2 m 88 m 0 m 88 m 0 m 90 m 2 m 8 m 9 m 2 2 r 0 m 1 m 0 2 r 90 m 0 m 2 m 10 m
0 4 r 8 m 1 m 20 m 88 m 0 m 84 m 0 2 r 90 m 10 m 20 m 0 m 2 m 0 m 88 m 1 m 2 m 0 m 10 m 11 m 84 m 40 m 8 m 0 m 90 m 3 m 90 2 r
2 2 r 90 m 1 m 90 2 r 0 4 r 8 m 0 a r 2 m 0 4 r 1 2 r 0 2 r notbusy
02 wcmd 3 m 63 m 0 m \ 0x36300 
0 2f r 81 m 0 2 r b m 0 4 r 81 m 0 2 r b m 0 6 r 81 m 0 2 r b m 0 m 60 m 0 2 r 11 m 0 2 r b m 0 4 r 42 m 0 2 r b m 0 4 r 42 m
0 2 r b m 0 m 42 m 0 2 r 42 m 0 2 r b m 0 4 r 42 m 0 2 r b m 0 2 r 12 m 0 8 r 82 m 0 2 r d0 m 0 2 r 41 m 0 31 r ff m cf m ff 2
r 3 m c m 3 m c m f m 0 m f0 m 0 2 r f m 0 m f m 0 2 r 55 m 0 2 r 55 m 5 m a m 5 m a m 0 m ff m 0 2 r c3 m 0 2 r c3 m 0 2 r ff
m f7 m 0 m ff m 0 m ef m 3c 3 r 2c m c3 m 0 m c3 m 0 3 r ff m f7 m 3 m c0 m 3 m c0 m c3 2 r 0 2 r 69 2 r 0 10 r notbusy
02 wcmd 3 m 64 m 0 m \ 0x36400 
0 32 r ff 4 r 3 m c m 3 m c m f m 0 m f0 m 0 m f m 0 m f m 0 3 r 55 m 0 2 r 55 m 5 m a m 5 m a m ff m 0 3 r c3 m 0 2 r c3 m 0
2 r ff 2 r 0 m ff m 0 m ff m 3c 4 r 0 m c3 m 0 m c3 m 0 2 r ff 2 r 3 m c0 m 3 m c0 m 0 2 r c3 2 r 69 2 r 0 43 r ff m 0 2 r 28
2 r 82 2 r 0 4 r aa 2 r 0 4 r f0 m 0 m f0 m 0 m aa m 0 2 r aa m 3c 2 r 38 m 3c m fe m ff m 0 2 r ff m 0 m fb m 0 m 30 2 r c0 2
r 0 2 r c3 m 3c m 0 2 r ff m fb m fe m 0 m ff m 0 m ff 2 r 0 2 r c3 m 0 m c3 m 0 m 3 2 r c0 2 r 0 a r notbusy
02 wcmd 3 m 65 m 0 m \ 0x36500 
0 39 r ff m 28 2 r 82 2 r 3c m c3 m 3c m c3 m 0 2 r aa 2 r 0 3 r f0 m 0 m f0 m aa m 0 2 r aa m 3c 4 r ff 2 r 0 2 r ff m 0 m ff
m 0 m 30 2 r c0 2 r 0 2 r c3 m 3c m 0 2 r ff 3 r 0 m ff m 0 m fb m ff m 0 3 r c3 m 0 m c3 m 3 2 r c0 2 r 0 40 r 3 m 61 m 0 m
26 m c m d m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 0 2 r 3 m 0 m 3 m 20 m c m 0 m 10 m c0 m 3 m 0 m 3 m 20 m c m 0 m
10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m 3 m 26 m c m d m 10 m c0 m 3 m 61 m
3 m 26 m c m d m 0 m c0 m 0 6 r notbusy
02 wcmd 3 m 66 m 0 m \ 0x36600 
0 3 r 61 m 0 m 6 m 80 m d m 20 m 0 35 r aa 3 r 2a m 0 4 r aa 3 r 2a m 0 16 r ff 2 r df m ff m 0 5 r 3c m ff m 3c m 0 6 r df m
ff m 0 4 r f0 3 r 70 m 0 8 r f7 m ff m 0 3 r 80 m 0 m 80 m 0 34 r aa 4 r 0 4 r aa 4 r 0 1e r f0 m aa m f0 m aa m 0 6 r ff 2 r
0 4 r f0 4 r 0 2 r notbusy
02 wcmd 3 m 67 m 0 m \ 0x36700 
0 6 r ff 2 r 0 42 r ff 3 r 7f m 0 16 r f0 m d0 m f0 2 r 0 c r f0 m d0 m f0 2 r 0 4 r ff 2 r df m ff m 0 8 r f 2 r b m f m 3c m
bc m ff 2 r 0 56 r f0 4 r 0 c r f0 4 r 0 6 r notbusy
02 wcmd 3 m 68 m 0 m \ 0x36800 
0 a r f 4 r 3c 2 r ff 2 r 0 e r 2 m 80 m 0 16 r 40 m 0 m 84 m 0 m 84 m 0 m 84 m 0 m 20 m 0 9 r 4 m 0 m 4 m 0 m 4 m 0 m 4 m 0 9
r 20 m 0 3 r 20 m 0 m 20 m 0 m 20 m 0 17 r 20 m 0 7 r 20 m 0 f r 4 m 0 10 r 2 m 0 28 r 80 m 0 m 80 m 0 m 80 m 0 m 80 m 0 2 r 2
m 0 19 r 8 m 0 10 r notbusy
02 wcmd 3 m 69 m 0 m \ 0x36900 
20 m 0 23 r 1 m 0 1f r 82 m 0 1d r 20 m 0 m 20 m 0 41 r 10 m 0 3b r 20 m 0 1d r notbusy
02 wcmd 3 m 6a m 0 m \ 0x36a00 
0 4 r 20 m 0 m 20 m 0 c r 8 m 0 51 r 21 m 0 3 r 80 m 0 3 r 21 m 0 m 3 m 0 m 21 m 0 m 41 m 0 m 3 m 0 3 r 80 m 0 3 r 2 m 0 3 r 2
m 1 m 80 m 0 b r 5 m 0 3 r 41 m 0 41 r a0 m 0 9 r a0 m 0 m 82 m 0 9 r 10 m 0 3 r a0 m 0 7 r 82 m 0 m 82 m 0 m 2 m 0 m 84 m 0 m
2 m notbusy
02 wcmd 3 m 6b m 0 m \ 0x36b00 
0 4 r 4 m 20 m 0 m 82 m 0 d r c0 m 0 38 r a0 m 0 m a0 m 0 m a0 m 0 m a0 m 0 b r 8 m 0 c r 80 m 0 2 r 40 m 0 15 r 1 m 0 17 r 4
m 0 43 r 80 m 0 c r 2 m 0 10 r notbusy
02 wcmd 3 m 6c m 0 m \ 0x36c00 
0 8 r 4 m 0 9 r 9 m 0 m 40 m 0 47 r 1 m 0 m 1 m 80 m 1 m 0 2 r 1 m 0 m 21 m 0 3 r 21 m 0 m 3 m 0 m 3 m 1 m 80 m 0 m 5 m 0 m 80
m 0 m 21 m 1 m 0 2 r 21 m 0 m 41 m a0 m 8 m 0 m 80 m 0 m 80 m 0 m 80 m 1 m 2 m 0 3 r 2 m 1 m a0 m 0 f r 41 m 0 31 r c0 m 0 7 r
c0 m 0 5 r c0 m 0 m a0 m 8 m 0 m 2 m 10 m 8 m 0 6 r 88 m 0 3 r 84 m 0 2 r 8 m 2 m 0 m 84 m 0 m 2 m 3 m a0 m 2 m 84 m 0 4 r 8 m
0 m notbusy
02 wcmd 3 m 6d m 0 m \ 0x36d00 
8 m 40 m 8 m 10 m 8 m 2 m 8 m 2 m 20 m 0 3 r 4 m 41 m 0 3 r 84 m 0 2 r 21 m 0 a r 2 m 0 4 r 11 m 88 m 0 28 r 40 m 0 m 40 m 0 m
40 m 0 m 20 m 0 13 r 90 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 7 r 10 m 40 m 21 m 0 3 r 21 m 0 m 5 m 0 m 11 m 0 m 10 m 0 3 r 5 m
0 3 r 2 m 0 2 r 4 m 20 m 0 3 r 41 m 0 7 r 9 m 0 7 r 9 m 0 47 r 1 m 0 m 1 m 0 m 1 m 0 m 1 m 0 7 r 1 m 0 6 r notbusy
02 wcmd 3 m 6e m 0 m \ 0x36e00 
0 5 r 1 m 0 a r 80 m 1 m 0 14 r 9 m 0 m 9 m 0 39 r c0 m 2 m 0 m 10 m 0 m 10 m c0 m 82 m 0 a r 8 m 2 m c0 m a0 2 r 10 m a0 2 r
0 8 r 4 m 82 m 0 m 10 m a0 m 10 m c0 m a0 m 0 m 4 m 0 m 10 m 0 m a0 m 0 m 90 m 0 53 r 80 m 0 m 80 m 0 c r 80 m 0 m 11 m 0 2 r
80 m 0 4 r notbusy
02 wcmd 3 m 6f m 0 m \ 0x36f00 
0 6 r 80 m 0 m 11 m 80 m 0 m 80 m 0 9 r 80 m 0 52 r 80 m c0 m 80 2 r 0 m 80 m 0 5 r 2 m 0 4 r 5 m 0 m 2 m 0 m 91 m 0 m 20 m 3
m 80 m 0 5 r 80 m 0 m 85 m 0 m 3 m 0 m 91 m 0 m 89 m 0 4 r 10 m 0 m 80 3 r 0 50 r 4 m 0 m 10 m 9 m 10 2 r a0 m 8 m 0 5 r 40 m
0 m c0 m 0 m 40 m 2 3 r 0 m 8 m 0 m notbusy
20 wcmd 3 m 70 m 0 m notbusy \ 0x37000
02 wcmd 3 m 70 m 0 m \ 0x37000 
83 m 1 m 8 m 0 m a0 m 0 m a0 m 0 m 8 m 0 m 4 m 0 m c1 m 0 m 10 m 0 m 8 m 82 m 4 m 0 m 10 m 0 2 r 84 m 90 2 r 0 50 r c0 m 10 m
0 m 10 m 8 m 40 m a0 2 r 0 6 r 40 m 0 3 r 10 2 r 0 m 40 m 82 m 8 m 10 m 9 m 0 8 r c0 m c1 m 0 m 10 m 0 m 10 2 r 9 m 40 m 0 5 r
2 m 0 51 r 9 m 80 m 0 m 80 3 r 0 4 r 40 m 0 5 r 4 m 0 m 80 m 82 m notbusy
02 wcmd 3 m 71 m 0 m \ 0x37100 
0 m a1 m 0 m 89 m 80 m a0 m 0 9 r 40 m 0 m 91 m 0 m 10 m 80 m a0 m 0 59 r 2 m 0 3 r 80 2 r 0 5 r 80 m 2 m 0 4 r 2 m 89 m 21 m
80 m 20 m 0 m 11 2 r 0 m 2 m 0 m 80 m 0 7 r 80 m 0 3 r 11 m 0 m 20 m 80 m 2 m 80 m 0 53 r 2 m 0 m a0 m c0 m a0 m 40 m 10 m 0 3
r 82 m 0 m 82 m 0 m 2 m 0 m notbusy
02 wcmd 3 m 72 m 0 m \ 0x37200 
2 m 0 2 r 10 m 0 m 10 m 1 m a0 m 0 5 r 20 m 0 m 2 m 0 3 r c0 m 0 m 8 m 0 m 10 m 0 2 r 4 m 1 m 20 m 10 m 2 m 10 m 2 m 0 55 r 41
m 0 9 r b m 0 1c r 42 m 0 2 r b m 4 m 0 52 r fb m 0 m ff m 0 m ff 2 r df m ff m 0 2 r 66 2 r notbusy
02 wcmd 3 m 73 m 0 m \ 0x37300 
46 m 66 m 0 8 r f0 4 r 0 c r ef m ff 3 r fb m 0 m ff m 0 55 r ff m 0 m ff m 0 7 r 66 4 r 0 8 r d0 m f0 3 r 0 10 r ff m 0 m ff
m 0 1d r ff 40 r notbusy
02 wcmd 3 m 74 m 0 m \ 0x37400 
ff 42 r 0 m 27 m f0 m 21 m 30 m 22 m 3 m c m 0 m 18 m 50 m 60 m 0 2 r 2 m 8a m 0 38 r 3c 3 r 34 m 66 m 62 m 66 2 r 0 b r ff m
0 m fd m 0 2 r ff 2 r 0 4 r f 2 r b m f m 0 2 r ff m fd m 66 3 r 64 m f 4 r 83 2 r c1 2 r 0 44 r notbusy
02 wcmd 3 m 75 m 0 m \ 0x37500 
0 c r 3c 4 r 66 4 r 0 b r ff m 0 m ff m 0 2 r ff m fb m 0 4 r f 4 r 0 2 r ff 2 r 66 4 r f 3 r b m 81 2 r c3 2 r 0 23 r 9 m 0
2c r 85 m 0 m a m 40 m 15 m 0 2 r a0 m 0 2 r 5 m 18 m a m 8 m 5 m 0 2 r a0 m 0 m 61 m 0 m 6 m 0 m d m 0 9 r 1 m 0 m 61 m 0 m 6
m 0 m d m 0 m 1 m 0 2 r 40 m 28 m 0 44 r notbusy
02 wcmd 3 m 76 m 0 m \ 0x37600 
0 22 r ef m ff 3 r aa m 8a m aa 2 r 0 c r aa m 8a m aa 2 r 0 6e r aa 4 r 0 c r aa 4 r 0 28 r 2 m 0 6 r 40 m 0 14 r notbusy
02 wcmd 3 m 77 m 0 m \ 0x37700 
0 2a r 3c m 1c m 3c 2 r 0 c r f0 3 r 70 m 0 6e r 3c 4 r 0 c r f0 4 r 0 2f r 80 m 0 10 r notbusy
02 wcmd 3 m 78 m 0 m \ 0x37800 
10 m 0 21 r 20 m 0 f r 10 m 0 f r 20 m 0 3 r 2 m 0 7 r 2 m 0 3 r 20 m 0 7 r 4 m 0 3 r 40 m 0 12 r 8 m 0 31 r 2 m 0 18 r 10 m 0
1f r 80 m 0 7 r ff 1c r notbusy
02 wcmd 3 m 79 m 0 m \ 0x37900 
ff 66 r 0 m 3 m 7 m 0 m 30 m 22 m 3 m d m 0 m 4 m 50 m 60 m 0 2 r 6 m 18 m 0 7b r 20 m 0 m 10 m 0 2 r 82 m 0 9 r notbusy
02 wcmd 3 m 7a m 0 m \ 0x37a00 
0 5f r 84 m 0 3 r a0 m 0 m a0 m 0 m 10 m 0 b r 1 m 0 m 1 m 0 74 r 40 m 0 9 r 2 m 0 m 40 m 0 9 r notbusy
02 wcmd 3 m 7b m 0 m \ 0x37b00 
0 76 r 80 m 0 81 r 4 m 80 m 0 2 r 4 m 20 m 82 m 80 m notbusy
02 wcmd 3 m 7c m 0 m \ 0x37c00 
0 47 r c0 m 0 32 r 80 m 20 m 0 2 r 80 m 1 m 0 m 40 m 0 6f r 10 m 0 e r notbusy
02 wcmd 3 m 7d m 0 m \ 0x37d00 
0 2 r 4 m 0 81 r 80 m 0 7b r notbusy
02 wcmd 3 m 7e m 0 m \ 0x37e00 
89 m 10 m 0 m 82 m 0 m 40 m 90 m 40 m 0 7a r 89 m 80 m 0 3 r 80 2 r 0 77 r notbusy
02 wcmd 3 m 7f m 0 m \ 0x37f00 
0 7 r 21 m 80 2 r 0 m 80 m 0 7e r 84 3 r 90 m 0 72 r notbusy
20 wcmd 3 m 80 m 0 m notbusy \ 0x38000
02 wcmd 3 m 80 m 0 m \ 0x38000 
0 8 r 90 m 82 m 0 m a0 m 0 m 90 m c0 2 r 0 7a r 80 m 0 2 r 80 m 0 m 80 3 r 0 6e r notbusy
02 wcmd 3 m 81 m 0 m \ 0x38100 
0 c r 80 m 0 m 80 m a0 m 80 m 0 7d r 90 m 0 m a0 m a1 m 90 m 0 m 84 m 0 6b r notbusy
02 wcmd 3 m 82 m 0 m \ 0x38200 
0 11 r a m 0 2 r b m 80 m 0 m 41 m 0 7a r c3 m 80 m c3 m 43 m 83 m 43 m c3 m 3 m 0 66 r notbusy
02 wcmd 3 m 83 m 0 m \ 0x38300 
0 14 r c3 m 0 m c3 2 r 83 2 r 3 m c3 m 0 7b r fb m 0 m ff m 0 2 r aa m ff m 0 62 r notbusy
02 wcmd 3 m 84 m 0 m \ 0x38400 
0 19 r df m 0 m ff m 0 2 r aa m ff m 0 7b r 10 m 40 m 28 m 0 m 40 m 5 m 0 c r 1 m 0 52 r notbusy
02 wcmd 3 m 85 m 0 m \ 0x38500 
0 24 r ff 82 r 0 m 16 m 8d m 75 m 30 m 22 m 3 m d m 0 m 1d m 50 m 60 m 0 2 r 1 m 4 m 0 8 r 2 m 0 41 r notbusy
02 wcmd 3 m 86 m 0 m \ 0x38600 
0 56 r 4 m 0 1f r 20 m 0 1b r 4 m 0 5 r 20 m 0 19 r 20 m 0 m 4 m 0 m 4 m 0 m 20 m 0 17 r 40 m 0 2f r notbusy
02 wcmd 3 m 87 m 0 m \ 0x38700 
0 33 r 20 m 0 8 r ff 82 r 0 m 31 m 4b m 41 m 30 m 22 m 3 m f m 0 2 r 50 m 60 m 0 3 r c3 m 0 2e r 40 m 0 3 r notbusy
02 wcmd 3 m 88 m 0 m \ 0x38800 
0 1e r 40 m 0 f r 88 m 0 f r 20 m 0 f r 20 m 0 6f r 41 m 0 a r 84 m 0 8 r ff 2e r notbusy
02 wcmd 3 m 89 m 0 m \ 0x38900 
ff 54 r 0 m 1d m 21 m 17 m 30 m 22 m 3 m f m 0 m 6 m 50 m 60 m 0 3 r c3 m 0 50 r 8 m 0 4b r notbusy
02 wcmd 3 m 8a m 0 m \ 0x38a00 
0 59 r 8 m 0 e r ff 82 r 0 m 23 m 9d m 79 m 30 m 22 m 3 m 10 m 0 2 r 50 m 60 m 0 3 r c3 m 0 6 r notbusy
02 wcmd 3 m 8b m 0 m \ 0x38b00 
1 m 0 27 r 2 m 0 35 r 20 m 0 13 r 88 m 0 f r 40 m 0 3a r 2 m 0 22 r 80 m 0 1d r ff 2 r notbusy
02 wcmd 3 m 8c m 0 m \ 0x38c00 
ff 80 r 0 m 3b m 3a m bb m 30 m 22 m 3 m 10 m 0 m 4 m 50 m 60 m 0 2 r 1 m 86 m 0 66 r 1 m 0 9 r notbusy
02 wcmd 3 m 8d m 0 m \ 0x38d00 
0 11 r 8 m 0 66 r 20 m 0 6b r 8 m 0 3 r a0 m 0 m a0 m 80 m 0 b r 80 m 0 3 r 80 m 20 m 0 3 r notbusy
02 wcmd 3 m 8e m 0 m \ 0x38e00 
0 44 r 2 m 40 m 0 1c r 2 m 0 a r 10 m 0 b r 2 m 0 3 r 8 m 80 m 0 81 r notbusy
02 wcmd 3 m 8f m 0 m \ 0x38f00 
0 3 r 41 m 0 5 r 21 m 0 10 r ff 82 r 0 m 2d m 20 m 87 m 30 m 22 m 3 m 10 m 0 m a m 50 m 60 m 0 2 r 1 m 86 m 0 15 r 80 m 0 36 r
2 m 0 m 2 m 80 m 0 4 r notbusy
20 wcmd 3 m 90 m 0 m notbusy \ 0x39000
02 wcmd 3 m 90 m 0 m \ 0x39000 
0 c r 82 m 0 e r 8 m 0 m 8 m 0 25 r 10 m 0 36 r 2 m 0 2 r 10 m 0 82 r notbusy
02 wcmd 3 m 91 m 0 m \ 0x39100 
0 13 r 1 m 0 81 r 41 m 0 m 11 m 9 m 11 m 0 m 9 m 0 64 r notbusy
02 wcmd 3 m 92 m 0 m \ 0x39200 
0 1b r 40 m 0 1a r ff 82 r 0 m c m 79 m b5 m 30 m 22 m 3 m 10 m 0 m 10 m 50 m 60 m 0 3 r c3 m 0 38 r notbusy
02 wcmd 3 m 93 m 0 m \ 0x39300 
0 2c r 40 m 0 81 r 10 m 0 m 10 m 0 m 5 m 0 19 r ff 34 r notbusy
02 wcmd 3 m 94 m 0 m \ 0x39400 
ff 4e r 0 m 37 m 5a m b6 m 30 m 22 m 3 m 10 m 0 m 14 m 50 m 60 m 0 3 r 82 m 0 65 r d0 m 0 1c r ff 20 r notbusy
02 wcmd 3 m 95 m 0 m \ 0x39500 
ff 62 r 0 m 11 m 50 m fe m 30 m 22 m 3 m 10 m 0 m 19 m 50 m 60 m 0 3 r c3 m 0 63 r 61 m 0 m 7 m 0 m d m 0 1d r 8 m 0 8 r
notbusy
02 wcmd 3 m 96 m 0 m \ 0x39600 
0 76 r ff 82 r 0 m 38 m bf m 96 m 30 m 22 m 3 m 10 m notbusy
02 wcmd 3 m 97 m 0 m \ 0x39700 
0 m 1d m 50 m 60 m 0 2 r 1 m 4 m 0 7 r 40 m 0 5a r 2 m 0 m 8 m 0 3b r 1 m 80 m 0 1e r 1 m 0 11 r 10 m 80 m 0 7 r 80 m 0 16 r
20 m 0 5 r notbusy
02 wcmd 3 m 98 m 0 m \ 0x39800 
0 2a r 40 m 8 m 0 1e r 10 m 0 2 r 3 m 0 e r 80 m 2 m 0 7 r 2 m 0 28 r ff 72 r notbusy
02 wcmd 3 m 99 m 0 m \ 0x39900 
ff 10 r 0 m 37 m d9 m 8c m 30 m 22 m 3 m 11 m 0 m 3 m 50 m 60 m 0 2 r 1 m 45 m 0 4b r 84 m 0 5f r 8 m 0 2f r 3 m 0 m 41 m 0 2
r notbusy
02 wcmd 3 m 9a m 0 m \ 0x39a00 
0 1f r 8 m 0 71 r a0 m 0 m 8 m 0 48 r 40 m 0 23 r notbusy
02 wcmd 3 m 9b m 0 m \ 0x39b00 
0 28 r ff 82 r 0 m 1c m 57 m 37 m 30 m 22 m 3 m 11 m 0 m 8 m 50 m 60 m 0 3 r 82 m 0 46 r notbusy
02 wcmd 3 m 9c m 0 m \ 0x39c00 
0 9 r 41 m 0 f r 41 m 0 22 r ff 82 r 0 m 3d m b8 m 44 m 30 m 22 m 3 m 11 m 0 m a m 50 m 60 m 0 2 r 2 m 8a m 0 27 r 41 m 0 a r
notbusy
02 wcmd 3 m 9d m 0 m \ 0x39d00 
0 16 r 82 m 0 16 r 41 m 0 6c r 11 m 0 65 r notbusy
02 wcmd 3 m 9e m 0 m \ 0x39e00 
0 23 r 1 m 0 2 r 82 m 0 4 r 1 m 0 47 r 9 m 0 31 r 8 m 0 7 r 3 m 0 52 r notbusy
02 wcmd 3 m 9f m 0 m \ 0x39f00 
0 20 r 82 m 0 6 r 4 m 0 48 r c0 m 0 31 r 10 m 0 7 r c0 m 0 55 r notbusy
20 wcmd 3 m a0 m 0 m notbusy \ 0x3a000
02 wcmd 3 m a0 m 0 m \ 0x3a000 
0 2a r 4 m 0 4d r 41 m 0 31 r 41 m 0 m 80 m 0 5 r 9 m 0 44 r 2 m 0 8 r notbusy
02 wcmd 3 m a1 m 0 m \ 0x3a100 
0 1f r 2 m 0 9 r 2 m 0 36 r ff 82 r 0 m 26 m 8e m 63 m 30 m 22 m 3 m 11 m 0 m 14 m 50 m 60 m 0 3 r 82 m 0 e r notbusy
02 wcmd 3 m a2 m 0 m \ 0x3a200 
0 11 r b m 0 30 r d0 m b m 0 7 r b m 0 28 r ff 82 r 0 m 31 m 21 m 65 m 30 m 22 m 3 m 11 m 0 m 16 m notbusy
02 wcmd 3 m a3 m 0 m \ 0x3a300 
50 m 60 m 0 2 r 1 m 4 m 0 4 r f6 m b8 m f6 m b8 m 0 15 r c1 m 0 2d r 10 m 0 3 r c1 m 0 m c0 m 0 5 r c1 m 0 42 r 2 m 0 6 r 40 m
0 18 r 2 m 0 11 r 2 m 0 6 r 40 m 0 7 r 40 m 0 1e r notbusy
02 wcmd 3 m a4 m 0 m \ 0x3a400 
0 26 r 10 m 4 m 0 2e r 20 m 8 m 10 m 4 m 0 6 r 10 m 4 m 0 2a r ff 74 r notbusy
02 wcmd 3 m a5 m 0 m \ 0x3a500 
ff e r 0 m e m 73 m 71 m 30 m 22 m 3 m 11 m 0 m 1b m 50 m 60 m 0 2 r 97 m 6 m 0 1b r 4 m 0 m 38 m 0 2f r 4 m 0 m 38 m 80 m 32
m 0 3 r 4 m 0 m 38 m 0 48 r 40 m 0 2c r 2 m 0 4 r 40 m 0 7 r 40 m 0 7 r notbusy
02 wcmd 3 m a6 m 0 m \ 0x3a600 
0 3d r 89 m 80 m 0 1e r 1 m 0 11 r 99 m 90 m 0 6 r 88 m 80 m 0 2b r ff 5c r notbusy
02 wcmd 3 m a7 m 0 m \ 0x3a700 
ff a8 r 0 58 r notbusy
02 wcmd 3 m a8 m 0 m \ 0x3a800 
0 100 r notbusy
02 wcmd 3 m a9 m 0 m \ 0x3a900 
0 100 r notbusy
02 wcmd 3 m aa m 0 m \ 0x3aa00 
0 100 r notbusy
02 wcmd 3 m ab m 0 m \ 0x3ab00 
0 100 r notbusy
02 wcmd 3 m ac m 0 m \ 0x3ac00 
0 100 r notbusy
02 wcmd 3 m ad m 0 m \ 0x3ad00 
0 100 r notbusy
02 wcmd 3 m ae m 0 m \ 0x3ae00 
0 100 r notbusy
02 wcmd 3 m af m 0 m \ 0x3af00 
0 100 r notbusy
20 wcmd 3 m b0 m 0 m notbusy \ 0x3b000
02 wcmd 3 m b0 m 0 m \ 0x3b000 
0 100 r notbusy
02 wcmd 3 m b1 m 0 m \ 0x3b100 
0 100 r notbusy
02 wcmd 3 m b2 m 0 m \ 0x3b200 
0 100 r notbusy
02 wcmd 3 m b3 m 0 m \ 0x3b300 
0 100 r notbusy
02 wcmd 3 m b4 m 0 m \ 0x3b400 
0 100 r notbusy
02 wcmd 3 m b5 m 0 m \ 0x3b500 
0 100 r notbusy
02 wcmd 3 m b6 m 0 m \ 0x3b600 
0 100 r notbusy
02 wcmd 3 m b7 m 0 m \ 0x3b700 
0 100 r notbusy
02 wcmd 3 m b8 m 0 m \ 0x3b800 
0 100 r notbusy
02 wcmd 3 m b9 m 0 m \ 0x3b900 
0 100 r notbusy
02 wcmd 3 m ba m 0 m \ 0x3ba00 
0 100 r notbusy
02 wcmd 3 m bb m 0 m \ 0x3bb00 
0 100 r notbusy
02 wcmd 3 m bc m 0 m \ 0x3bc00 
0 100 r notbusy
02 wcmd 3 m bd m 0 m \ 0x3bd00 
0 100 r notbusy
02 wcmd 3 m be m 0 m \ 0x3be00 
0 100 r notbusy
02 wcmd 3 m bf m 0 m \ 0x3bf00 
0 100 r notbusy
20 wcmd 3 m c0 m 0 m notbusy \ 0x3c000
02 wcmd 3 m c0 m 0 m \ 0x3c000 
0 100 r notbusy
02 wcmd 3 m c1 m 0 m \ 0x3c100 
0 100 r notbusy
02 wcmd 3 m c2 m 0 m \ 0x3c200 
0 100 r notbusy
02 wcmd 3 m c3 m 0 m \ 0x3c300 
0 100 r notbusy
02 wcmd 3 m c4 m 0 m \ 0x3c400 
0 100 r notbusy
02 wcmd 3 m c5 m 0 m \ 0x3c500 
0 100 r notbusy
02 wcmd 3 m c6 m 0 m \ 0x3c600 
0 100 r notbusy
02 wcmd 3 m c7 m 0 m \ 0x3c700 
0 100 r notbusy
02 wcmd 3 m c8 m 0 m \ 0x3c800 
0 100 r notbusy
02 wcmd 3 m c9 m 0 m \ 0x3c900 
0 100 r notbusy
02 wcmd 3 m ca m 0 m \ 0x3ca00 
0 100 r notbusy
02 wcmd 3 m cb m 0 m \ 0x3cb00 
0 100 r notbusy
02 wcmd 3 m cc m 0 m \ 0x3cc00 
0 100 r notbusy
02 wcmd 3 m cd m 0 m \ 0x3cd00 
0 100 r notbusy
02 wcmd 3 m ce m 0 m \ 0x3ce00 
0 100 r notbusy
02 wcmd 3 m cf m 0 m \ 0x3cf00 
0 100 r notbusy
20 wcmd 3 m d0 m 0 m notbusy \ 0x3d000
02 wcmd 3 m d0 m 0 m \ 0x3d000 
0 100 r notbusy
02 wcmd 3 m d1 m 0 m \ 0x3d100 
0 100 r notbusy
02 wcmd 3 m d2 m 0 m \ 0x3d200 
0 100 r notbusy
02 wcmd 3 m d3 m 0 m \ 0x3d300 
0 100 r notbusy
02 wcmd 3 m d4 m 0 m \ 0x3d400 
0 100 r notbusy
02 wcmd 3 m d5 m 0 m \ 0x3d500 
0 100 r notbusy
02 wcmd 3 m d6 m 0 m \ 0x3d600 
0 100 r notbusy
02 wcmd 3 m d7 m 0 m \ 0x3d700 
0 100 r notbusy
02 wcmd 3 m d8 m 0 m \ 0x3d800 
0 100 r notbusy
02 wcmd 3 m d9 m 0 m \ 0x3d900 
0 100 r notbusy
02 wcmd 3 m da m 0 m \ 0x3da00 
0 100 r notbusy
02 wcmd 3 m db m 0 m \ 0x3db00 
0 100 r notbusy
02 wcmd 3 m dc m 0 m \ 0x3dc00 
0 100 r notbusy
02 wcmd 3 m dd m 0 m \ 0x3dd00 
0 100 r notbusy
02 wcmd 3 m de m 0 m \ 0x3de00 
0 92 r 6 m 1 m 40 m 11 m 51 m 80 m 60 m 6 m 14 m 8 m 5 m 8 m 5 m 1 m 8 m 4 m 14 2 r 20 m 14 m 41 2 r 91 m 5 m 68 m 45 m 85 m 2
m 18 m 41 m 9 m 52 m 10 m 68 m 59 m 55 m 8 m 65 m 81 m 0 m 61 m 41 m 0 m 45 m 55 m 5 m 19 m 45 m 54 m 61 m 51 m 4 m 14 m 50 m
10 m 55 m 4 m 14 m 41 m 40 m 50 m 54 m 5 m 15 m 1 m 45 m 5 m 51 m 14 m 44 2 r 15 m 22 m 61 m 85 m 55 m 91 m 65 m 40 m 51 2 r
11 m 45 m 1 m 40 m 10 m 55 m 4 m 50 2 r 5 m 50 m 40 m 0 m 1 m 55 m 40 m 15 m 45 m 11 2 r 40 m 44 m 1 m 4 m 44 m 0 m 51 m 0 m
10 m notbusy
02 wcmd 3 m df m 0 m \ 0x3df00 
0 m 40 m 11 m 51 m d0 m 55 m 16 m 15 m 11 m 48 m 50 m 11 m 55 m 4 m 9 m 55 m 5 m 55 m 45 m 55 m 11 m 45 m 54 m 55 2 r 1 m 45 m
1 m 5 m 40 m 11 m 4 m 66 m 51 m 11 m 15 m 41 m 15 m 50 m 55 m 54 m 55 2 r 15 2 r 44 m 45 m 51 m 55 m 50 m 66 m 55 m 11 m 95 m
85 m 55 m 51 m 59 m 50 m 15 m 51 m 5 m 51 m 45 m 41 m 51 m 55 m 4 m 65 m 42 m 15 m 44 m 41 m 16 m 51 m 66 m 54 m 65 m 99 m 14
m 16 m 41 m 54 m 51 m 56 m 54 m 15 m 55 m 15 m 14 m 41 m 15 m 41 m 55 m 50 m 55 m 54 m 15 m 4 m 45 m 54 m 41 m 15 m 54 m 55 m
0 m 5 m 40 m 48 m 85 m 42 m 45 m 40 m 89 m 91 m 15 m 51 m 44 m 51 m 11 m 91 m 54 m 59 2 r 15 m 59 m 45 m 6 m 51 m 59 m 64 m 95
m 9 m 2 m 50 m 4 m 25 m 10 m 74 m 54 m 15 m 44 m 15 m 11 m 45 m 51 2 r 94 m 60 m 99 m 56 m 25 m 54 m 0 m 59 m 51 m a m 64 m 1
m 2 m 25 m 95 m 49 m 51 m 90 m 66 m 54 m 51 m 85 m 11 m 65 m c0 m 35 m 40 m 85 m 94 m 25 m 51 m 10 m 91 m 5 m 16 m 51 m 50 2 r
9 m 50 m 16 m 51 m 49 m 54 m 11 m 56 m 44 m 66 m 56 m 35 m 10 m 89 m d5 m 1 m 89 m 64 m 56 m 50 m 11 m 98 m 49 m 67 m 11 m 55
m 14 m 49 m 91 m 5 m 54 m 40 m 45 m 50 m 59 m d4 m 56 m 54 m 15 m 54 m 4 m 15 m 50 m 27 m 14 m a m 55 m 4 3 r 14 m 41 m 51 m
10 m 45 m 44 m 10 m 45 m 5 m 45 m 41 m 51 m 10 m 41 m 4 m 5 m 11 m 5 m 15 m 10 m 45 m notbusy
20 wcmd 3 m e0 m 0 m notbusy \ 0x3e000
02 wcmd 3 m e0 m 0 m \ 0x3e000 
10 m 55 m 15 m 0 m 55 m 0 m c4 m 31 m 50 m c4 m 40 m 51 m 10 m 51 m 40 m 26 m 51 m 50 m 54 m 55 2 r 19 m a1 m 45 m 59 m 61 m
95 m 58 m 64 m 55 m 19 m 56 m 46 m 21 m 80 m 86 m 20 m 5 m 45 m 15 m 51 m 47 m 1d m 40 m 55 m 10 m 45 m 55 m 14 m 50 m 85 m 14
m 50 m 12 m 48 m 45 m 0 m 1 m 55 m 85 m 96 m 11 m 95 m 44 m 54 m 46 m 25 m 86 m 6 m 91 2 r 19 m 90 m 45 m 85 m 15 m 55 m 46 m
54 m 60 m 51 m 64 m 54 2 r 9 m 66 m 4 m 55 m 12 m 55 m 94 m 55 m 59 m 5 m 55 m 85 m 51 m 40 m 1 m 68 m 56 2 r 4 m 55 m 9 m 44
m 51 m 6 m 54 2 r 55 m 18 m 15 m 5 m 45 m 0 m 15 m 44 m 15 2 r 14 m 25 m 5 m 55 m 11 m 55 m 40 m 94 m 5 m 15 m 41 m 40 m 55 m
50 m 55 m 44 m 51 m 50 m 10 m 51 m 41 m 55 m 41 m 15 m 10 m 45 m 51 m 5 m 15 m 4 m 45 m 51 m 4 m 40 m 59 m 64 m 15 m 40 m 45 m
1 m 90 m 15 m 54 m 45 2 r 15 m 14 m 5 m 41 m 11 m 45 m 54 m 44 m 16 m 15 m 55 m 45 m 55 m 91 m 11 m 44 m 54 m 55 m 15 m 55 m
45 m 11 m 40 m 55 m 4 m 55 m 9 m 14 m 55 m 4 m 45 m 11 m 55 m 50 m 55 2 r 11 2 r 45 m 55 m 51 m 54 3 r 51 m 14 m 5 m 44 m 1 m
51 m 45 m 40 m 50 m 14 m 0 m 6 m 0 2 r 2 m 50 m 0 m 6 m 51 m 14 2 r 1 m 55 m 81 m 84 m 50 m 55 m 81 m 25 m 95 m 41 m 56 m 50 m
45 m 40 m 15 m 50 m 15 m 55 m 5 m 55 m 50 m 18 m 40 m 21 m 4 m 1 m notbusy
02 wcmd 3 m e1 m 0 m \ 0x3e100 
50 m 5 m 6 m 50 m 51 m 50 m 45 m 15 2 r 55 m 45 m 85 m 51 m 55 m 50 m 51 m 1 m 10 m 40 m 46 m 0 m 51 m 19 m 14 m 51 2 r 15 2 r
85 m 41 m c1 m 11 m 40 m 45 m 55 m 15 m 44 m 45 m 14 m 50 m 54 m 24 m 1 m 55 m 5 m 6 m 9 m 45 m 51 m 55 m 44 m 1 m 90 m 0 9 r
4 m 0 m 4 m 45 m 61 m 15 m 54 m 44 m 61 m 16 m 59 m 85 m 55 m 11 m 95 m 44 m 1 m 51 m 14 m 19 m 46 m 51 m 41 m 55 m 50 m 54 m
15 m 14 m 19 m 45 m 55 m 12 m 11 m 54 m 99 m 5 m 11 m 65 m 44 m 14 m 52 m 56 m 54 m 15 m 51 m 15 m 51 m 41 m 61 m 40 m 58 2 r
0 m 64 m 15 m 95 m 5 m 95 m 50 m 5d m 84 m 59 2 r 5 m 55 m 44 m 45 m 1 m 56 m 58 m 5a m 55 m 11 m 55 m 45 m 5a m 52 m 45 m 94
m 54 m 55 m 5 m 4 m 45 m 41 m 51 2 r 54 m 15 m 55 m 15 m 19 m 45 m 55 m 51 m 14 m 44 m 55 m 15 2 r 50 m 1 m 55 m 50 m 54 m 44
m 54 m 45 m 15 m 55 m 5 m 55 m 11 m 54 m 60 m 85 m 41 m 5 m 51 m 45 m 14 m 51 m 14 m 54 2 r 45 m 15 m 14 m 40 m 54 m 41 m 44 m
50 m 44 m 54 m 11 m 5 2 r 54 m 11 m 5 m 54 m 5 m 55 m 15 m 95 m 44 m 50 m 10 m 15 m 58 m 55 m 51 m 15 2 r 6 m 55 m 10 m 54 m
14 m 45 m 41 m 11 m 44 m 4 m 54 m 61 m 15 m 14 m 45 m 46 m 15 m 45 m 41 m 50 m 11 m 55 m 4 m 90 m 5 m 11 m 40 m 4 m 51 m 10 m
50 m 64 m 15 m 6 m 21 m 41 m 86 m 14 m 10 m notbusy
02 wcmd 3 m e2 m 0 m \ 0x3e200 
55 m 40 m 5 m 14 2 r 21 m 45 m 69 m 81 m 65 m 64 m 15 m 65 m 4 m 40 m 41 m 55 m 0 m 15 m 40 m 50 m 85 m 14 m 15 m 8 m 50 m 41
m 51 m 40 m 50 m 99 m 15 m 42 m 5 m 46 m 51 m 50 m 20 m 21 m 55 m 15 m 54 m 5 m 2 m 10 m 85 m 54 m 15 m 50 m 15 m 40 m 85 m 40
m 91 m 40 m 84 m 40 m 95 m 0 m 85 m 49 m 55 m 51 m 45 m 0 m 14 m 15 m 5 2 r 46 m 14 m 11 m 15 m 40 m 91 m 50 m 5 m 44 2 r 54 m
10 m 54 m 14 m 65 m 54 m 25 m 99 m 82 m 66 m 61 m 54 m 50 m 41 m 55 m 15 m 55 m 45 m 55 m 40 m 15 m 14 m 41 m 45 m 15 m 55 m
45 m 56 m 50 m 55 m 5c m 50 m 54 m 15 m 6 m 5 m 41 m 80 m 45 m 94 m 19 m 55 m 15 m 45 m 1 m 85 m 0 m 55 m 50 m 55 m 65 m 14 m
41 m 45 m 66 m 82 m 65 m 50 m 5 m 45 m 3f m f0 m 0 m 3 m f0 m 0 m f0 m 0 m 3c m 0 m f m 0 m 3 m c0 m 0 m f0 m 0 m 3c m 0 m f m
0 m 3 m c0 m 0 m f0 m 0 m 3c m 0 m f m 0 m 3 m c0 m 0 m f0 m 0 m 3c m 0 m f m 6 m 8b m c0 m 0 m 80 m 36 m 2d m 16 m 9c m 43 m
88 m b0 m 8 m 0 m 1b m cb m 2a m 42 m 8e m ab m 41 m 81 m a4 m b9 m 94 m 2c m 1a m 80 m 9e m 91 m df m 7c m 11 m b m 3a m dd m
4 m 38 m 21 m c m 64 m 88 m c6 m 32 m 3 m 43 m f8 m a2 m f0 m 20 m 0 m c3 m 0 m 30 m 3 m c8 m 82 m 0 2 r 3 m c8 m 22 m 30 m 0
m 3 m c3 m 22 m 0 m c0 m 3 m 0 m f0 m 3 m c4 m 0 m 45 m 0 m 3d m 0 m notbusy
02 wcmd 3 m e3 m 0 m \ 0x3e300 
4 m 50 m 3 m d0 m 0 m 50 m 0 m 3d m 0 m f m 0 4 r ff m f0 m 51 m 95 m 5 m 46 m 45 m 15 m 51 m 15 m 14 m 54 2 r 1 m 99 m 45 2 r
51 m 50 m 98 m 65 m 91 m 16 m 56 m 46 m 54 m 21 m 42 m 58 m 6a m 55 m 5 m 56 m 44 m 9 m 91 m 55 m 50 m 51 m 55 m 15 m 41 m 4d
m 69 m 11 m 55 m 14 m 55 2 r 19 m a1 m a m 54 m 11 m 45 m 54 m 55 m 15 m 5 m 95 m 45 m 55 m 41 m 46 m 50 m 65 m 54 m 1a m 0 m
89 m 56 m 51 m 58 m 64 m 55 m 4 m 16 m 55 m 85 m 14 m 41 m 42 m 54 m 99 m 59 m 15 m 65 m 85 m 51 m 41 2 r 58 m 54 m 11 m 14 m
41 m 5 m 46 m 41 m 51 m 50 m 54 m 64 m 10 m 61 m 4 m 16 m 11 m 99 m 44 m 45 m 9 m 1 m 14 m 0 m 19 m 51 m 65 m 84 m 24 m 50 m
10 m 45 m 9 m 59 m 12 m 14 m 44 m 51 m 56 m 21 m 15 m 4 m 15 m 51 2 r 14 m 15 m 5 m 16 m 56 m 80 m 51 2 r a8 m 54 m 45 m 55 m
15 m 50 m 45 m 95 m 60 m 55 m 4 m 19 m 56 m 29 m 55 m 4 m 55 m 51 m 4 m 40 2 r 95 m 25 m 14 m 41 2 r 51 m 14 2 r 41 m 59 m 11
m 55 m 41 m 56 m 50 m 44 m 14 m 5a m 69 m 18 m 55 m 5 m 99 m 52 m 45 m 54 m 14 m 55 m 15 m 55 m 48 m 55 m 1 m 44 m 64 m 59 m
64 m 14 m 51 m 4 m 59 m 10 m 51 m 50 m 51 m 42 m 4 m 50 m 84 m 15 m 51 m 1 m 84 m 9 m 99 m 19 m 91 m 46 m 59 m 91 2 r 40 m 96
m 59 m 3 m 5d m 49 m 98 m 52 m 66 m 64 m 65 m 9 m 19 m 99 m 89 m 96 m notbusy
02 wcmd 3 m e4 m 0 m \ 0x3e400 
61 m 16 m 64 m 66 m 45 m 26 m 66 m 49 m 99 m 92 m 66 m 64 m 41 m 99 m 29 m a5 m 4 m 55 m 52 m 46 m 44 m 54 m 45 m 19 m 95 m 5
m 59 m d1 m 51 m 40 m 95 m 59 m 5 m 56 m 45 m 5a m 51 m 59 m 58 m 95 m 16 m 1a m 59 m 41 m 55 m 50 m 51 m 54 m 42 m 65 m 5 m
91 m 80 m 21 m 10 m 82 m 10 m 19 2 r 21 m 18 m 44 m 61 m 11 m 55 m 54 m 99 m 5 m 1a m 56 m 45 m 59 m 91 m 55 m 94 m 45 m 15 m
16 m 96 m 85 m 56 m 61 m 55 m 64 m 45 2 r 0 2 r 4f m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m
ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m
ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m
ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m
ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m
ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m
ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff m notbusy
02 wcmd 3 m e5 m 0 m \ 0x3e500 
ff m 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m notbusy
02 wcmd 3 m e6 m 0 m \ 0x3e600 
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m notbusy
02 wcmd 3 m e7 m 0 m \ 0x3e700 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 0 25 r 1 m 40 m 11 m 71 m 0 m c0 2 r b0 m 3 m 5 m 0 m 8 m c1 m 0 m 8 m 0 m 30
m 3 m 0 m 82 m 80 m 12 m 3 m 0 m 4c m 2 m 0 2 r 80 m 1 m 0 6 r 80 m 0 m 30 m 1 m 40 m 30 m 42 m 5 2 r 1 m c8 m 10 m 40 m 3 m
c0 m 0 m 10 m 1c m 0 m 4 m 0 2 r 8 m 0 m 4 m 0 m 1 m 0 m f m a m 3 m 0 m 8 m 0 m 1a m 0 2 r notbusy
02 wcmd 3 m e8 m 0 m \ 0x3e800 
9 2 r 0 m 5 m 0 m 1 m 40 m 1 2 r 0 3 r 10 m 0 m 90 m 3c m 22 m 10 m 0 m 2 m a2 m 35 m 40 m 11 m 34 m 0 m d9 m 0 m 51 m 60 m 84
m 14 m 78 m c9 m c m 3 m c 2 r 0 m 10 m c0 m 0 5 r 20 m 0 m 19 m c0 m 0 m 23 m a m 1e m 2 m 0 m 11 m 4f m 80 m c0 m 14 m 0 m 1
m 3 m 1 m 0 m 1d m 0 m 8 m 29 m 9 m 8 m 3 m 49 m 10 m 80 m 4 m 80 m 0 m e m 1e m 4f m 52 m 0 3 r cc m 8 m 0 m 10 m 4 2 r 0 3 r
2 m 1 m 0 m 80 m 0 3 r 38 m 40 m 6 m 10 m 0 3 r 20 m 0 3 r cc m 0 m 7 m 70 m 0 3 r 40 m 0 2 r 88 m 10 m 35 m 0 2 r 81 m 1 m c4
m 8 2 r 1c m 40 m 2 m 0 2 r 20 m 80 m 0 m 4 m 0 m 1 m 0 m 1 m 10 m 71 m 10 m 0 m 34 m 8 m 0 m c1 m 0 2 r 3 m d0 m 4 2 r 20 m
c3 m 0 m 40 m c0 m 0 m 4 m 1c m 44 m 10 m d m 1 m 0 2 r 48 m 6c m 10 m 1 m 2 m 0 m 1 m 84 m 0 2 r 10 m 0 2 r 4 m 79 m 4 m 10 m
2 m 40 m c m 90 2 r 0 m 4 m c2 m 80 m 1 m c0 m 0 2 r 9 m 0 m 71 m 9 m 0 4 r 1 m 44 m 8 m 2 m 45 m a0 m d3 m 8 m 10 m 83 m 58 m
0 m ad m 41 m 2 m 0 2 r 80 m 0 m c0 m 5 m 18 m 80 m 93 m 81 m 0 2 r 52 m 7e m 39 m 1 m 41 m 22 m 30 m 40 2 r 4 2 r 1c m 81 m a
m 2 m 1 m 48 m notbusy
02 wcmd 3 m e9 m 0 m \ 0x3e900 
8c m 0 m aa m a m aa m 6 m 0 m 2 m 12 m 3c m 80 m f1 m 28 2 r 6 m 82 m 21 m b8 m 8 m 6 m 20 m 3e m 49 m 81 m 24 m a0 m 69 m 38
m b9 m e4 m 0 m b1 m 8d m 81 m 82 m 7 m 80 m c2 m 83 m e m e1 m 88 m 82 m 0 m c8 m 80 m 22 m a m 8 m 20 m 6 m 0 m 70 m 4 m 0 2
r 6 m 10 m 0 m 84 m 10 m 20 m 2 m 8 m 41 m 94 m 0 m 44 m 4 m 45 m 11 m 14 m 44 m 40 m 14 m c m 78 m 47 m 45 m 50 m c0 m 80 m
51 m 0 2 r 8 m 40 m 51 m 41 m 10 m 0 m 10 m 54 m 5 m 80 m 0 2 r 40 m 0 m 10 m 2 m 10 m 0 m 10 m 4 m 5 m 0 m 40 m 4 m 10 m 1e m
20 2 r 4 m 91 m 40 m 5 m 40 m 0 m d2 m 0 m 40 2 r 51 m c0 m 0 2 r 94 m 1 m a m 20 m 1 m 12 m 30 m f4 m 0 m c0 m 30 2 r 24 m 41
m 10 m a2 m c3 m 0 m 2b m 17 m 2 m c5 m 5 m 1 m c3 m 56 m 70 m c5 m 0 m 13 m 4b m c0 m 50 m 10 m 12 m c m 97 m 30 m 2a m c m 3
m 1 m 10 m a0 m c m 50 m 63 m 1d m 1c m 45 m 94 m 0 m 50 m 1c m 71 m 45 m 14 m 50 m c0 m 71 m 41 m c7 m 70 m 52 m 43 m 12 m d
m 83 m 31 m 13 m 10 m 50 m 14 m 1 m 10 m 27 m 1 m 70 m 50 m 55 m 4 m 7 m 18 m 24 m 80 m 48 m 1a m 1 m 1c m 50 m 25 m 10 m 9 m
48 m 4 m fc m 10 m c1 m d8 m dc m c1 m 33 m 4 m 7 m 30 m 40 m 4 m 40 m 96 m 48 m 13 m dc m 42 m 1 m 2 m 45 m 20 m 4a m 48 m 1e
m d8 m 48 m 86 m 0 m 44 m 4 m 41 m 82 m 0 m notbusy
02 wcmd 3 m ea m 0 m \ 0x3ea00 
0 4 r 40 m 0 2 r 60 m 38 m 28 m c1 m 89 m 2 m 20 m 40 m 4 m 0 m 5 m 11 m 0 m a4 m 50 m 20 m 80 m 59 m 80 m 20 m 41 m 9 m 6a m
a0 m 20 m 40 m 81 m 23 m a m 3 m 7 m 24 m 12 m 29 m 0 m 1 m 2 m 25 m 54 m 0 m 25 m 41 m 22 m 48 m 3 m c8 m 31 m b1 m 80 m 31 m
90 m 80 m 90 m 91 m c0 m 15 m 4 m 81 m 4 m 1 m 83 m 0 m 1 m a0 m 20 m 60 m 1 m 6 m 60 m 94 m 4 m c6 m 45 m d m 0 2 r 21 m 1 m
f3 m 80 m 0 m 30 m 0 b r 2 m 24 m 0 m 6 m 18 m c m 0 m 12 m 48 m 89 m 15 m 0 m 91 m 40 m 18 m 59 m 10 m 2 m 80 m 41 m f1 m 27
m 0 m 70 m 1 m c m 40 m 44 m 10 2 r 30 m 0 m 10 m a5 m 18 m 75 m 47 m 2 m 60 m 54 m 44 m 94 m 89 m 10 m 18 m 8 m 1 m 2 m 0 2 r
55 m 1d m 10 m 14 m 46 m 5 m 42 m 1c m 20 m 51 m 5d m 24 m 5 m 82 m d m 41 m 4 m 10 2 r 1 m 9 m 81 m 45 m 10 m 40 m 66 m 4 m
92 m 60 m 3c m 52 m 45 m 29 m 40 m 48 m 54 m 98 m 9 m c m 41 m 8 m 14 m 10 m 99 m a0 m 20 m 41 m 6 m 8d m 9 m 51 m 10 m 1 m 20
m 44 m 21 m 20 m 44 m 81 m a0 m 81 m a2 m 0 m 7 m 90 m 6 m 9 m 0 m 82 m 20 m 88 m 78 m a2 m 24 m 0 m 88 m c6 m 12 m 20 m a0 m
64 m 10 m e9 m 3c m 6a m cd m 99 m b2 m 50 m 40 m 4b m 67 m 10 m 17 m 44 m 41 2 r 4 2 r 41 m 51 m 5 m 85 m 82 m 45 m 40 m
notbusy
02 wcmd 3 m eb m 0 m \ 0x3eb00 
15 m 14 m 41 m 55 m 19 m 9 m 1 m 26 m 11 m 91 m f4 m 92 m 61 m 14 m 24 m c9 m 44 m a3 m c7 m 44 m b5 m 4 m 2 m 55 m 8a m 1d m
d0 m 68 m 4c m 18 m 84 m 0 m 20 m 8c m 6 m 31 m 72 m 20 m 87 m 22 2 r c3 m 84 m 41 m 3 m 4d m 40 m d9 m 4d m 1c m 39 m c m d4
m e2 m f5 m 38 m 8b m 8 m 22 m 4f m c0 m bb m f3 m 70 m a0 m 2a m 33 m 5 m 2c m 9 m 20 m 51 m 48 m e0 m e1 m 8 m d m 12 m 44 m
9e m 13 m 80 m d0 m 11 m 49 m 31 m 23 m 85 m 23 m a1 m 23 m 88 m 23 m 94 m 23 m 80 m 49 m 94 m 43 m c5 m 8c m 16 m f1 m 35 m
b7 m c4 m 16 m f3 m 1 m 2c m f0 m db m 0 m 23 m 40 m b2 m f0 2 r a0 m c4 m 16 m f m 32 m 8 m cc m c1 m c m 58 m 9 m 8 m 11 m 3
m c0 m 2f m 2 m bc m 2c m 6f m c9 m f m 53 m 44 m f8 m f2 m 6f m 9c m db m d2 m 10 m bc m 5 m ef m 2 m 31 m 38 m f1 m 18 m 31
m c4 m 8f m 0 m b0 m 51 m f8 m 33 m c3 m b m 6c m c4 m c m 0 m 41 m ec m 2 m 31 m 3f m f0 m 40 m 3 m f0 m 0 m f0 m 0 m 3c m 0
m f m 0 m 7 m c1 m 0 m f0 m 0 m 3c m 10 m f m 0 m 3 m c0 m 0 m f0 m 0 m 3c m 0 m f m 0 m 3 m c0 m 0 m f0 m 0 m 3c m 0 m f m a
m c3 2 r c1 m 8c m 8b m f6 m e m 7f m f m 58 m 83 m d5 m c4 m b3 m 3 m 25 m a3 m 2 m cf m a0 m f3 m fc m b7 m 82 m 32 m 98 m
47 m cc m b1 m 1 m c m d3 2 r 38 m 1b m 4f m a1 m c0 m 69 m e0 m 12 m 23 m notbusy
02 wcmd 3 m ec m 0 m \ 0x3ec00 
39 m 60 m 3 m d8 m c3 m f0 m 0 2 r d3 m a m c0 m 43 m e3 m 10 m 1 m 0 m 3 m e3 m c m 31 m 4 m 3 m e3 m 8c m 0 m c4 m 3 m 0 m
f0 m 3 m e0 m 0 m 43 m 0 m 3c m 10 m 4 m 30 m 3 m c1 m 0 m 90 m 0 m 3c m 10 m f m 0 2 r 3d m 3 m ff m f0 m 5c m 15 m 4 m 33 m
4 m 24 m 0 2 r 18 m 30 m 90 m d m 10 m cf m c6 m 42 m 40 m 10 m 4f m 31 m 14 m d4 m c4 m d0 m 1 m 4 m 10 m 44 m d2 m 6 m 50 m
7 m 1 m 0 m 4c m f0 m c1 m b5 m 0 2 r b m c3 m 3 m 3d m 4 m 6d m 44 m 10 m 0 2 r c0 m 13 m 6 m 30 m 43 m 13 m 5 m 1f m c6 m ff
m 0 m 4 m c0 m f m 10 2 r 73 m 1 m 64 m 41 m 80 m 44 m 1c m 10 m 4 m 1 m f m 0 m 3 m 8c m fc m 33 m f3 m 1a m 41 m 4 m 50 m 1
m 41 m 48 m 14 m 50 m 10 m 81 m 0 m 40 m 41 m 1f m 40 m 4 2 r 20 m 0 m 8 m 50 m 1 m 11 m 0 m 2 m 11 m 4 m 8 m c m 10 m 51 m 41
m 4 m 40 m 0 2 r c m 0 m 10 m 30 m 38 m 4 m 1 m 84 m 2 m c2 m 8 m 0 2 r 2 m d0 m 12 m 0 m 4 m 44 m 0 m 41 m 91 m 0 m 8 m 6 m
44 m 10 m 20 m 40 m 0 2 r c2 m 40 m 0 2 r 1 m 2 m 40 m 64 m 10 m 50 2 r 14 m 50 m 9 m 40 m 82 m 50 m 10 m 25 m 0 m 10 2 r 0 m
45 m 41 m 84 m 10 m b m 40 m 0 3 r 1c m 40 m 0 m 40 m 6 m 14 m 11 m 4 m 0 m 10 m 4 m b9 m 42 m 50 m 10 2 r 40 m 0 m c4 m 4 m
20 m notbusy
02 wcmd 3 m ed m 0 m \ 0x3ed00 
30 m 24 m 0 m 5c m 90 m f m 24 m 1 2 r 10 m d0 m 48 m 40 m 10 2 r c m 80 m 10 m 1 m 3 m 10 m 4 m 10 m 11 m 14 m 40 m 0 4 r 2 m
40 m 0 m 8 m 0 3 r 40 m 0 m 40 m c m 0 7 r 50 m 0 m 7 m 1 m c0 m 63 m 10 m 4 m 90 m c1 m 1 m 1d m 3f m 3 m 81 m c1 m f1 m 50 m
24 m 10 m 6 m f4 m cd m f0 m c1 m 10 m 40 m 24 m 8 m 10 m c1 2 r bf m c1 m 1 m b0 m 90 m 6e m 11 m 5 m 0 m 61 m 42 m 6 m 8 m
81 m 82 m 1 m 84 m 46 m 1 m 80 m 61 m 4 m 32 m 84 m 10 m f8 m 5 m d1 m 0 m 71 m 34 m 20 m 5b m 4 2 r 5 m 74 m 43 m 1c m 4c m
16 2 r 0 2 r f m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff m
notbusy
02 wcmd 3 m ee m 0 m \ 0x3ee00 
ff m 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff
2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m notbusy
02 wcmd 3 m ef m 0 m \ 0x3ef00 
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m notbusy
20 wcmd 3 m f0 m 0 m notbusy \ 0x3f000
02 wcmd 3 m f0 m 0 m \ 0x3f000 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 0 4a r notbusy
02 wcmd 3 m f1 m 0 m \ 0x3f100 
0 100 r notbusy
02 wcmd 3 m f2 m 0 m \ 0x3f200 
0 100 r notbusy
02 wcmd 3 m f3 m 0 m \ 0x3f300 
0 100 r notbusy
02 wcmd 3 m f4 m 0 m \ 0x3f400 
0 100 r notbusy
02 wcmd 3 m f5 m 0 m \ 0x3f500 
0 100 r notbusy
02 wcmd 3 m f6 m 0 m \ 0x3f600 
0 100 r notbusy
02 wcmd 3 m f7 m 0 m \ 0x3f700 
0 100 r notbusy
02 wcmd 3 m f8 m 0 m \ 0x3f800 
0 100 r notbusy
02 wcmd 3 m f9 m 0 m \ 0x3f900 
0 100 r notbusy
02 wcmd 3 m fa m 0 m \ 0x3fa00 
0 100 r notbusy
02 wcmd 3 m fb m 0 m \ 0x3fb00 
0 100 r notbusy
02 wcmd 3 m fc m 0 m \ 0x3fc00 
0 100 r notbusy
02 wcmd 3 m fd m 0 m \ 0x3fd00 
0 100 r notbusy
02 wcmd 3 m fe m 0 m \ 0x3fe00 
0 100 r notbusy
02 wcmd 3 m ff m 0 m \ 0x3ff00 
0 100 r notbusy
20 wcmd 4 m 0 m 0 m notbusy \ 0x40000
02 wcmd 4 m 0 m 0 m \ 0x40000 
0 100 r notbusy
02 wcmd 4 m 1 m 0 m \ 0x40100 
0 100 r notbusy
02 wcmd 4 m 2 m 0 m \ 0x40200 
0 100 r notbusy
02 wcmd 4 m 3 m 0 m \ 0x40300 
0 100 r notbusy
02 wcmd 4 m 4 m 0 m \ 0x40400 
0 100 r notbusy
02 wcmd 4 m 5 m 0 m \ 0x40500 
0 100 r notbusy
02 wcmd 4 m 6 m 0 m \ 0x40600 
0 100 r notbusy
02 wcmd 4 m 7 m 0 m \ 0x40700 
0 100 r notbusy
02 wcmd 4 m 8 m 0 m \ 0x40800 
0 100 r notbusy
02 wcmd 4 m 9 m 0 m \ 0x40900 
0 100 r notbusy
02 wcmd 4 m a m 0 m \ 0x40a00 
0 100 r notbusy
02 wcmd 4 m b m 0 m \ 0x40b00 
0 100 r notbusy
02 wcmd 4 m c m 0 m \ 0x40c00 
0 100 r notbusy
02 wcmd 4 m d m 0 m \ 0x40d00 
0 100 r notbusy
02 wcmd 4 m e m 0 m \ 0x40e00 
0 100 r notbusy
02 wcmd 4 m f m 0 m \ 0x40f00 
0 100 r notbusy
20 wcmd 4 m 10 m 0 m notbusy \ 0x41000
02 wcmd 4 m 10 m 0 m \ 0x41000 
0 100 r notbusy
02 wcmd 4 m 11 m 0 m \ 0x41100 
0 100 r notbusy
02 wcmd 4 m 12 m 0 m \ 0x41200 
0 100 r notbusy
02 wcmd 4 m 13 m 0 m \ 0x41300 
0 100 r notbusy
02 wcmd 4 m 14 m 0 m \ 0x41400 
0 100 r notbusy
02 wcmd 4 m 15 m 0 m \ 0x41500 
0 6b r 82 m 0 m a m 80 m 31 m 8 m 30 m a2 m 23 m 30 m c3 m 11 m 0 m a3 m 10 m cc m 87 m c m c2 m e m d m 0 m 60 m 40 m 21 m 16
m 30 m 93 m 8c m 2a m c2 m 86 m 80 m 1 m c4 m c m 4 m b m ca m 33 m 2b m c4 m 21 m 2e m 2c m c3 m 85 m a0 m 1 m 9f m 14 m d6 m
c9 m 23 m a m 8 m 4 m 70 m e1 m 5c m ac m b4 m 2a m 36 m 88 m 15 m 60 m 43 m 34 m a2 m c6 m 33 m 0 m 4 2 r c1 m a m 3c m 4e m
88 m 19 m 6c m ca m 8 m a0 m 7c m 44 m cc m 62 m 37 m 8c m 41 m 20 m c3 m fb m b0 m ae m ee m 3b m ea m ce m fa m e2 m fe m f8
m ae m 9a m 2b m aa m ce m ab m a2 m 80 m c8 m 95 m 90 m 18 m 85 m 86 m 80 m 62 m 6f m 10 m b1 m 14 m 30 m 2a m 1 m 49 m 82 m
0 m 54 m 1c m 4e m 16 m 78 m 88 m 67 m 2 m 4c m 48 m 0 m 4c m 18 m 91 m 8 m 4 m 82 m 49 m notbusy
02 wcmd 4 m 16 m 0 m \ 0x41600 
a4 m 5e m a5 m 11 m 81 m a m 11 m 42 m 45 m 58 m 10 m 55 m 0 m 50 m 80 m 53 m 71 m 83 m f8 m 81 m 19 m 18 m 48 m 5 m 2a m 0 m
a8 m 40 m a m 2d m 24 m 1 m 41 m 40 m 10 m b m 70 m 30 m a9 m 28 m c2 m 4d m 44 m 62 m 32 m 60 m b7 m 44 m 16 m a0 m 0 m d m
41 m a7 m 80 m 87 m 46 m 38 m 81 m 1 m 67 m 70 m 9c m 50 m 45 m 0 m 37 m e3 m 7 m 6e m 1 m ae m 10 m bc m 48 m 14 m 65 m 3 m b
m 80 m ca m b8 m 62 m 6f m 11 m 4 m 88 m 61 m 31 m cc m dc m 68 m 76 m 4 m e3 m 40 m 4e m 82 m 2 m b8 m 16 m 61 m 15 m ce m 4f
m 8c m 83 m 6f m c8 m 47 m e0 m 1e m a1 m c3 m 40 2 r 78 m 20 m 3d m 2c m 14 m 7a m 85 m 4c m 73 m 1 m 2c m 18 m bc m 8 m 34 m
2 m 83 m 63 m 30 m 74 m 8a m 84 m 2 m 28 m c8 m 1 m a2 m 85 m 48 m f2 m 8a m 21 m 1e m 7 m e3 m d1 m a1 m 70 m 11 m 1d m 23 m
87 m 86 m 78 m 20 m 36 m 10 m e m e1 m c m 0 m 45 m c9 m e1 m 11 m d0 m 77 m 4f m 1 m 48 m 80 m 35 m 22 m 7e m 68 m 41 m 51 m
15 m 53 m 40 m 6e m b1 m d9 m e8 m b8 m a8 m 2 m 32 m 0 m 40 m 2 m c8 m 4 m 3b m 23 m 0 m 38 m c2 m 12 m 2 m 88 m c4 m c m 23
m 3c m c m cc m 5c m 12 m 7c m 4c m 18 m 88 m 30 m 78 m c6 m 70 m a2 m 86 m 40 m 33 m 88 m d m 17 m 80 m 4b m e0 m 61 m 7c m
c8 m 91 m 19 m 0 m 44 m 9a m c0 m 81 m 80 m 23 m 6e m 1 m d0 m 6 m d1 m b3 m 16 m c4 m a0 m 11 m 2a m notbusy
02 wcmd 4 m 17 m 0 m \ 0x41700 
84 m 3 m e2 m 22 m b8 m c m 89 m 5f m f m 8b 2 r a4 m 2 m 42 m 78 m e7 m 41 m 5 m 0 m 86 m 28 m 90 m 5 m 34 m a0 m 28 m a m 40
m c3 m 80 m 11 m b5 m 4 m 64 m 21 m 13 m 56 m 80 m 6a m 2 m 0 m 4 m 56 m a3 m c m 6 m 2 m ac m c0 m 98 m e8 m 50 m 34 m 5 m 53
m 49 m 3f m 13 m 1b m e8 m 6b m db m 21 m 5e m 3 m c7 m 80 m 11 m 10 m a2 m 26 m 18 m c8 m 44 m e8 m 2 m a m 10 m 85 m e8 m 33
m a m 3 m 8b m a2 m 8d m c0 m 6b m 22 m 15 m cc m c0 m 29 m 41 m 56 m bc m 8b m e1 m 1 m cc m 8b m 4e m b0 m 76 m c0 m 21 m 64
m 20 m b6 m c6 m 31 m 70 m a7 m 10 m d1 m 4b m 2b m c8 m 4a m 7 m 1 m ea m 2c m 66 m b8 m 1a m a2 m a m 1 m b1 m 73 m 6c m 61
m 4 m 16 m 6a m 84 m 5 m 1 m 8c m d8 m dd m 8a m 24 m 76 m 8e m 88 m 62 m a8 m 54 m b8 m a0 m 23 m 3b m ce m 0 m 22 m a6 m 98
m 41 m 36 m a m 84 m 9 m aa m 61 m 3 m 9c m a4 m 42 m 28 m 15 m 2 m 5 m 63 m 3b m 14 m 49 m 59 m 0 2 r c0 m 0 m 2 m 4c m 0 m
c3 m 88 m 23 m fe m c m dc m 20 m 9a m 80 m b3 m 8 m d m c m cc m 43 m 21 m 3d m 70 m 9c m cc m a m 28 m 86 m 5d m 72 m 82 m 8
m 48 m 98 m 1 m ac m c8 m 0 m 83 m 9c m 68 m 28 m 45 m 1d m 43 m 87 m 1a m 30 m 2e m 1c m aa m 39 m 1 m 4d m 46 m 81 m 62 m f1
m cc m 8b m 84 m 38 m c7 m 4a m a m 20 m 4a m 10 m 20 m 56 m 26 m 22 m 8c m c2 m 12 m notbusy
02 wcmd 4 m 18 m 0 m \ 0x41800 
a1 m c m 21 m a9 m 28 m e6 m 81 m 14 m d1 m aa m 0 2 r cb m 0 9 r 23 m 0 m d m 43 m 60 m 1 m 44 m 22 m a m e m 3f m 86 m a8 m
c3 m ba m 10 m 9d m 4c m 23 m f6 m 0 m 3f m a3 m af m 80 m e2 m bd m 23 m 6c m ca m 8c m e0 m c0 m c m 56 m 37 m 1f m 29 m 4c
m 83 m 92 m 48 m 10 m ba m 37 m 20 m 1a m 46 m 84 m b1 m a1 m a4 m 1a m 31 m d m d8 m c1 m 10 m 12 m 6e m 98 m d0 m 2c m d m
50 m c6 m 3c m 0 m ec m 10 m b1 m a4 m e m 41 m 4 m b1 m 22 m 5f m f0 m 50 m 92 m 28 m 53 m 85 m 89 m d0 m 3c m 94 m a4 m 5 m
38 m 1 m b m a1 m b2 m 45 m 50 m e8 m 0 m 1a m b3 m e m 7d m 42 m e0 m 24 m 16 m 34 m f m 69 m 40 m 51 m 50 m 53 m c8 m 14 m
28 m 10 2 r c1 m 2 m 40 m d1 m 40 2 r 31 m 11 2 r 6 m 72 m 0 m 55 m c m 31 m 12 m 3c m eb m ca m a0 m 60 m 62 m 7c m 9e m ab m
2a m ce m 2 m b3 m 11 m da m a0 m 34 m 18 m 10 m b2 m 89 m 28 m 80 m a1 m 48 m 2a m 20 m 10 m f3 m c0 m 34 m f1 m 4e m a8 m 13
m 5f m 11 m 60 m 4 m 4c m 82 m 8 m 50 m 8 m fa m 1a m 3e m c0 m 11 m 2 m 84 m 8 m ec m 80 m 11 m 30 m 8 m 10 m e1 m 21 m 1c m
c2 m 12 m 33 m ea m 2 m c1 m 33 m 1c m 88 m 24 m 8c m 12 m c0 m 8 m 8b m 2 m a2 m c4 m c8 m 3c m 33 m f m c7 m 40 m 22 m e m
10 m 8b m a2 m 22 m 34 m c4 m 3 m 21 m 14 m a0 m 85 m 54 m notbusy
02 wcmd 4 m 19 m 0 m \ 0x41900 
10 m 42 m c0 m 39 m 2 m c1 m 4 m 45 m 7 m 4 m 32 m 4 m 2 m 40 m 12 m 84 m 22 m c1 m 32 m 11 m 9 m 51 m 2 m 2c m 38 m 32 m a0 m
c m c7 m 4c m b0 m 21 m ae m 14 m fa m 8a m 2b m 33 m ce m e0 m 81 m ba m 80 m 5f m b1 m 28 m 17 m c m 88 m 40 m 33 m cc m a5
m 54 m 4 m 36 m c0 m da m 92 m 6a m 80 m 2a m ec m 2a m fa m c9 m ae m a1 m 9a m 6c m 8e m 23 m 3c m fc m 8a m f m 31 m 16 m c
m 43 m f8 m 20 m b8 m 8b m 28 m 23 m fb m 84 m 77 m de m 2a m 21 m cd m 88 m 20 m 8 m d4 m 1d m 0 m 2c m c0 m 0 m 3b m 70 m d
m d0 m 3 m b4 m 0 m ed m 0 m 3f m 43 m e m d0 m 3 m f4 m 0 m fd m 8 m 33 m 41 m c m d0 m 43 m 34 m 0 m fd m 8 m 3f m 40 m d m
d0 m 3 m 34 m 0 m fd m e m c3 m 80 m 2 m 24 m 80 m 3a m 2f m f4 m 8 m c2 m d1 m f8 m 80 m 20 m cf m 10 m 3e m a m 7 m c3 m dc
m c8 m 15 m 48 m 3b m 24 m 40 m 7c m 70 m f3 m 40 m 12 m 6 m f m 91 m 49 m d7 m 62 m 7d m b8 m 22 m 31 m 1 2 r 43 m 15 m 32 m
c0 m 0 m 3 m c2 m 0 2 r 7 m 4 m c3 m c2 m 0 m 7 m 0 m 3 m 2 m 8 m 7 m 0 m 33 m 30 m c8 m 7 m 0 m c0 m c3 m 8 m 3 m aa m 1c m
31 m c0 m 3a m a1 m cf m 1c m 0 m a m 1c m 36 m c0 m c m 0 2 r fc m 70 m ec m c0 m 48 m e4 m 2e m 33 m 82 m a8 m 32 m e0 m 54
m a8 m 1 m a m ae m 8b m ba m 82 m 80 m 30 m ef m 6e m 2d m ec m c5 m b2 m notbusy
02 wcmd 4 m 1a m 0 m \ 0x41a00 
2 m 18 m a0 m c4 m ba m 29 m d0 m 88 m 83 m 2 m dc m 18 m ce m 65 m 3e m 17 m 80 m 82 m a3 m 9 m a0 m 99 m 6d m 32 m 4 m 40 m
9b m 92 m 29 m 0 m e6 m 74 m 7 m 0 m c9 m ae m 90 m 38 m 0 m 6 m a0 m 31 m cc m 1 m 18 m 22 m 67 m c8 m f8 m 12 m 25 m a9 m 4b
m e3 m 33 m 18 m 88 m e2 m 22 m 25 m 5b m 2 m 88 m 22 m 14 m a4 m a2 m 2 m f m 3c m 80 m 4c m 40 m ea m 80 m 35 m f5 m 0 m 8 m
80 m 88 m f0 m 20 m bc m ac m 60 m 6 m 33 m 0 m a0 m 83 m 82 m 4 m 83 m 7 m 3 m 60 m c0 m c1 m 81 m a0 m 28 m e m 6c m e m ec
m 80 m 9e m d3 m 6e m ec 2 r 6e m 18 m 2c m c m 4a m 43 m 3 m b0 m 39 m 2 m 3e m c5 m d m 3b m 43 m ec m 28 m d3 m b4 m 2 m ac
m 82 m 94 m b0 m 9b m 4 m 27 m fe m 18 m cc m 8a m c m 0 m 21 m 70 m 20 m 5 m 3d m b m ca m 44 m b3 m ac m c0 m 1c m 76 m 11 m
b8 m 83 m 32 m f0 m 9 m 10 m a0 m 17 m 3a m 4e m 8a m a8 m d2 m 13 m 88 m 51 m 4f m 2 m 88 m c9 m 72 m a3 m 80 m 94 m ae m 21
m 2b m 8d m 0 m 50 m 42 m 10 m bc m a0 m 62 m 15 m 2e m 4 m 56 m 10 m 2b m 38 m 30 m c3 m 2e m cb m 3 m 33 m 80 m cc 2 r c4 m
33 3 r 3 m 8c m c0 m cc 2 r e m 7a m c m ce m c3 m 33 m b1 m cc 2 r 2b m 3b m 2 m a m 80 m 93 m b1 m d5 m 30 m e2 m 11 m 2e m
23 m c6 m c m e0 m bb m 34 m 57 m b0 m 39 m 64 m 9 m d0 m 81 m b0 m 70 m 17 m notbusy
02 wcmd 4 m 1b m 0 m \ 0x41b00 
5a m 30 m 81 m a m 6b m a2 m 6 m 50 m 2c m c m 1 m 71 m 40 m 58 m c2 m 6 m 84 m c4 m 84 m 2c m cf m 1 m 18 m 0 m 92 m a8 m 0 m
40 m 31 m 2e m 5 m c0 m a2 m b2 m bc m 30 m 27 m 2c m 6c m 4e m 70 m 23 m ac 2 r 29 2 r 0 2 r f m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r
3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m notbusy
02 wcmd 4 m 1c m 0 m \ 0x41c00 
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m notbusy
02 wcmd 4 m 1d m 0 m \ 0x41d00 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m notbusy
02 wcmd 4 m 1e m 0 m \ 0x41e00 
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 0 24 r 8 m
1 m 80 m 5 m 42 m 0 m 80 m 8 m 50 m 0 m 8 m 0 m 18 m 10 m 40 m 18 m 60 2 r 0 m 65 m 1 m 20 2 r 80 m 40 m 29 m 15 m 24 m 51 m
44 m d1 m 40 m 4d m 40 m 80 m 52 m 22 m 0 m 5 m 4d m 1 m 5 m 40 m 8 m 85 m 14 m 21 m 40 m 11 m 80 m 5 m 18 m 61 m 46 m 11 m 85
m 4 m ab m 10 m 82 m 84 m 94 m 80 m 5 m 2a m 4 m f0 m c0 m eb m 30 m 3 m c1 m 33 m 0 3 r c0 m 5 m 30 m 85 m 42 m 0 m 14 m 5 m
13 m 10 m 94 m 48 m 44 m 91 m 29 m 44 m 80 m 23 m 81 m 51 m 40 m 55 m 40 m 4 m 15 m 1 m 5 m 10 m 1 m 4 m 11 m 51 m 4 m 1 m 0 m
4 m 1 m 4a m notbusy
02 wcmd 4 m 1f m 0 m \ 0x41f00 
c0 m 0 m 82 m 4 m 2a m 49 m 44 m 80 m 15 m 18 m 62 m 0 m 18 m 15 m 0 2 r 1 m 28 m 0 m 88 m 5 m 38 m 14 m 80 m c0 m 33 m 0 m fc
m 0 2 r 34 m e0 m 0 m 20 m 3 m 8 m 80 m c m c0 m 0 2 r 5 m 8 m 0 m 80 m 4 m 1 m 20 m 24 m 8 m 0 m 38 m 0 2 r 4 m 50 m 4 m 10 m
8 m c0 m a6 m 33 m 94 m 70 m 25 m 32 m 10 m 26 m a m 0 3 r 8 m 0 m 4 m 14 m e1 m 8 m 83 m 10 m 21 m c8 m af m 0 2 r 51 m 8c m
cc m 30 m 21 m 48 m 3 2 r 14 m b3 m 0 m 3 m 0 m cc m 0 2 r 4f m 0 m 83 m 8b m 95 m 2 m 55 m 0 m 4 m 82 m 20 m 0 m 80 m 82 m 0
m 45 m 14 m c4 m 2 m 0 m 8 m 4 m 41 m a0 m 84 m 14 m 94 m 88 m 34 m 22 m c3 m 4e m 1 m 0 m 54 m 81 m 3 m 0 m 75 m 5 m 4e m 30
m a5 m 44 m 89 m 12 m 25 m 50 m 4 m 0 2 r 44 m 60 m 1a m 18 m 20 m 95 m 48 m 9 m 81 m 82 m 80 m 3c m 94 m c m 30 m 2 m 68 m f0
m bc m ac m 49 m 4e m 1 m 24 m c4 m 22 m 51 m 43 m 4 m 11 m 41 m 12 m 5 m 9 m 50 m 0 m 2 m 10 m 62 m 82 m 0 m 45 m 49 m 14 m
92 m 9 m 20 m 46 m 12 m a m 1 m 8 m 74 m 50 m 0 m 40 m 18 m 84 m 20 m 2 m 3 m 80 m 1 m 1d m 14 m 2 m 0 3 r 81 m 88 m 21 m 64 m
54 m 44 m 54 m 28 m 18 m 8 m a2 m 81 m 4a m 48 m 95 m 29 m 23 m 94 m 89 m 39 m 31 m 4e m 4c m 8e m 39 m 14 m 20 m c4 m 24 m 20
m 94 m 24 m 94 m 24 m 11 m notbusy
20 wcmd 4 m 20 m 0 m notbusy \ 0x42000
02 wcmd 4 m 20 m 0 m \ 0x42000 
94 m 5 m 1 m 41 m 45 m 10 m 11 m 46 m 6 m 9 m 42 m 84 m 50 m 6 m 10 m 80 m 0 m 13 m 2 m 4 m 12 m 30 m 6c m cc m 2 m 18 m 0 m
40 m 84 m 49 m 11 m 24 m 48 m 60 m 2b m 35 m 4a m 83 m 92 m 21 m 54 m 64 m b1 m 4 m 1 m 45 m c9 m a3 m a2 m 96 m 88 m 70 m fe
m 3f m 0 m 41 m 14 m c0 2 r b0 m 52 m b2 m 1 m 2 m 41 m 0 m 10 m 0 3 r 80 m 3 m 0 m 40 m 30 m 1 m 0 2 r 1 m 53 m 14 m 22 m 41
m 54 m 60 m 0 m 40 m 34 m 8 m 0 2 r 87 m 5 m 21 m 35 m 54 m 14 m 44 m 3a m 4 m 8a m 69 m 40 m 20 m 14 m 50 m a4 m 10 m 2b m 40
m d4 m 71 m 5 m 18 m 60 m 54 m 11 m c5 m b m ba m 50 m 8 2 r 1 m 28 m 0 m 4a m 43 m 8b m c3 m c m 14 m 85 m 53 m 0 m e m 8f m
e m 3 m 3e m 0 m 8 m 0 m 3 m 3e m 4c m 8 m 0 m 40 m 1c m f0 m c0 m 15 m 47 m 5 m 24 m 32 m c5 m d4 m d3 m d4 m f m 52 m c5 m
3f m 73 m 13 m c4 m c3 m 30 m e m 30 m c3 m 0 2 r e m 60 m 6 m 0 2 r 2 m 84 m 2 m e1 m 54 m 60 m 54 m 53 m 11 m ba m 45 m 28 m
c0 m 80 m f4 m c m 3 m 5 m 4a m c8 m c3 m c0 m 3 m 0 m e0 m 0 m 10 m c0 m 0 m c m 0 m 15 m 0 m 40 m 4 m 0 m 9 m 0 2 r 1 m 40 m
0 m 49 m 46 m 11 m 0 m f m 30 m 11 2 r 48 m c m a m c m 3 m a m 1c m f3 m 9f m 50 m c3 m 30 m 1c m 0 m c3 m 5 m 10 m 60 m 0 m
80 m 2c m 18 m c4 m 4 m 60 m 2 m notbusy
02 wcmd 4 m 21 m 0 m \ 0x42100 
c8 m c4 m 14 m 6c m c m fc m c m 3f m c0 m c m 18 m c5 m 13 m c m cb m 4 m c m d0 m d6 m f0 m c1 m 4e m 14 m e1 m 89 m e m 10
m 35 m c m 8 m 0 2 r d m 44 m 20 m 1 m 51 m c4 m 10 m cc m 14 m 44 m 0 m d0 m 41 m 55 m 28 m 2 m 89 m 0 9 r 2 m 0 m a m ac m
40 m 21 m c4 m 10 m 85 m 4 m 1d m 2 m 14 m 21 m 15 m 18 m 48 m 8 m 11 m 1 m 8 m c5 m 51 m 45 m 48 m 52 m 80 m 12 m 2c m 41 m
7d m 50 m 4e m 1c m 0 m 34 m c m 2c m 4 m ef m 40 m cc m 20 m 3c m 63 m 12 m 80 m 1 m 5b m 0 m 56 m 54 m 55 m 90 m 4 m 14 m 40
m 23 m 21 m bd m 10 m 30 m fc m 1f m 2f m 2 m d4 m b0 m 40 m 30 m 0 m 58 m 35 m b m c m 0 m 10 m 2c m 50 m e m 41 m 14 m cd m
4e m 39 m 0 m cb m f0 m 90 m b0 m 14 m 60 m cb m 33 m 90 m c0 m 3c m 54 m a3 m 35 m 52 m cf m 37 m 31 m 53 m b0 m 3e m f0 m 3b
m 2f m c m f m 0 m f m 88 m 15 m 3b m 14 m b4 m b m 4c m 33 m d m 50 m 49 m 0 m c m 4d m 40 m c m 92 m 11 m 40 m 29 m 52 m 14
m 85 m 45 m 53 m 10 m fc m 10 m c5 m 55 m 5 m 75 m d m 53 m c0 m c1 m 50 m c0 m d4 m 2c m 9e m 86 m d4 m 21 m 51 m b0 m c5 m
1f m 2f m 11 m 2 m a7 m 52 m f1 m 54 m 2a m 75 m 3f m 31 m 45 m 4b m d0 m 24 m dc m d m 55 m 35 m 3f m c0 m 80 m 1 m 41 m 4 m
54 m 10 m 5 m 2 m 40 m 51 m 0 m c5 m 10 m 5c m 51 m notbusy
02 wcmd 4 m 22 m 0 m \ 0x42200 
11 m 5 m 0 m 3 m 10 m c0 2 r 53 m c3 m 5 m 4b m c5 m 45 m 33 m 51 m 4c m 4d m 4 m 13 m d5 m 40 m 42 m 91 m 15 m 4 m 43 m 11 m
1d m 8 m 45 m 18 m c1 m 44 m 94 m a5 m 55 m 15 m 51 m c4 m 9a m 52 m 95 m 54 m 55 m 49 m 15 m 22 m c5 m 32 m d1 m 3a m d4 m 3a
m d5 m 3a m 15 m 41 m 55 m 41 m 54 m 38 m 50 m 54 m 14 m 21 m e m 11 m 83 m 55 m 10 m c5 m 44 m 15 m 18 m c5 m 52 m 32 m 20 m
48 m 5 m 12 2 r 3 m f m 89 m 90 m 94 m 48 m 5 m 55 m 14 m 98 m 82 m 63 m 13 m 8c m 14 m 4 m d4 m 3 m 54 m 43 m 3f m 32 m c3 m
bc m 45 m 50 m 14 m 68 m 45 m 26 m 12 m b3 m 34 m fd m 54 m 14 m 54 m 8e m 14 m d1 m 55 m 4c m 99 m a4 m 15 m 36 m 4f m c m 10
m 3 m 40 m 24 m cc m c m c0 m 0 m 7 m 32 m 2 m c0 m 0 m 70 m 0 m 1c m 0 m 7 m 1 m 0 m c0 m 0 m 30 m 0 m c 2 r 7 m 0 m 1 m c0 2
r 70 m 0 m c m 0 m 3 m 0 m 1 m c0 m 0 m 70 m 0 m 1c m c m 43 m 0 m 21 m c8 m 54 m 31 m 8 m 2 m 4 m 6f m 60 m 3 m 38 m 44 m f8
m b m cc m 3 m cc m 92 m c2 m e0 m 20 m af m 21 m 1e m 42 m cc m b0 m d7 m 20 m b1 m 8c m 1b m a0 m c m f m d2 m 3f m 5c m 90
m 48 m a m bc m 43 m 40 m 23 m d0 m 0 m 3 m c2 m 0 m 70 m 3 m 1 m 0 m c3 m 0 m 3 m 9 m 4 m 3 m c m 3 m 0 m 14 m 30 m cc m 3 m
0 m d0 m cf m 0 2 r 15 m c m f3 m c0 m 1 m 50 m f m 30 m notbusy
02 wcmd 4 m 23 m 0 m \ 0x42300 
1 m 50 m c m 31 m c0 m 2c m 1 m 0 2 r 20 m cc m c0 m 4e m 84 m 15 m 38 m 0 m 14 m 90 m 52 m 8 m c1 m 48 m 7 m fc m 2 m 1 m 41
m 44 m 30 m f6 m 80 m 3c m 7d m 40 m 51 m 1 m 2c m 30 m 0 m 51 m 14 m f4 m 4 m 83 m 30 m c m 54 m 35 m 1e m 15 m 34 m a m c0 m
53 m 10 m 80 m 47 m 80 m 2 m f m 80 m f2 m 93 m e4 m ec m cc m fe m 34 m 4 2 r 44 m 32 m e0 m 7c m 85 m 50 m 0 m a m 2 m ec m
1 m 17 m cc m 54 m cf m 30 m 5c m 3 m 53 m b3 m 4 2 r d0 m 14 m 12 m 0 m d m 42 m c1 m 1b m 18 m 51 m f5 m 31 m 13 m 9 m 56 m
93 m 15 m 48 m 85 m 59 m c m b4 m 83 m f4 m 43 m 33 m 50 m 40 m f0 m 1 m 43 m 40 m 32 m 43 m cb m 14 m c8 m 41 m 5 m 84 m 2 m
72 m 10 m 51 m ac m b9 m 0 m 5 m 40 m 42 m aa m a2 m 85 m 40 2 r aa m 3e m 0 m b m 3d m 30 m 1 m 0 m f4 m fc m 14 m f m a m 2a
m 81 m 40 m 38 m a2 m a8 m 1 m 40 m c m 43 m 0 m 4d m 10 m 14 m 55 m 14 m 61 m 41 m 21 m 31 m 52 m 4 m 24 m 34 m 14 m 25 m 45
m 18 m 1 m 54 m ac m 9c m 74 m 12 m 54 m c7 m 30 m 10 m e4 m 6c m 50 m 83 m 6 m 81 m 8d m 44 m 21 m 1a m 88 m 82 m 4 m 9 m 46
m 87 m 7c m 51 m 4a m bc m 55 m 24 m 15 m 4b m 3 m f0 m c1 m 32 m d4 m f1 m 31 m 3 m 35 m c m 83 m 20 m 35 m 3c m 30 m c3 m d
m c7 m 3 m 31 m 40 m cc 2 r c0 m 73 m 33 2 r 3 m 8c m c0 m 6c m cc m f m notbusy
02 wcmd 4 m 24 m 0 m \ 0x42400 
15 m e m cd m c3 m f3 m b0 m cc 2 r 23 m 3b m 3 m 5 m 4e m 49 m 0 m 60 m 38 m 50 m a8 m 3f m 0 m 48 m f0 2 r 34 m 8 m e9 m 0 m
24 m f8 m c0 m 40 m 32 m 0 2 r 29 m cd m 0 m c2 m cd m 11 m 1 m bd m 3c m 38 m 2c m 8 m 10 m 0 m 44 m e0 m 4 m 40 m 24 m 20 m
14 m 2d m 1 m 84 m 60 m 0 m 14 m 20 m 73 m 0 m 4f m 8a m 40 m c3 m 10 2 r 1b m 51 m 0 m 40 m 2 m 90 m 31 m c4 m 4 m d4 2 r 0 2
r 8f m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff
m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff
m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff
m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff
m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff
m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff
m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m notbusy
02 wcmd 4 m 25 m 0 m \ 0x42500 
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m notbusy
02 wcmd 4 m 26 m 0 m \ 0x42600 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m notbusy
02 wcmd 4 m 27 m 0 m \ 0x42700 
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 0 24 r 1c m 83 m c3 m 44 m 53 m 33 m cc m c m d5 m 3 m 3c m c3 m c m 10 m 23 m 2c m 70 m f3 m
2c m f3 m d m 6c m 30 m 90 m 0 m 7c m 21 m 30 m 1 m c0 2 r 10 m c8 m 38 m 4 m d3 m 22 m 20 m cb m 88 m 12 m 4a m 84 m 6f m d4
m 11 m f0 m c m 72 m c0 m 44 m 5c m 32 m 53 m 17 m cd m 45 m bf m 0 m c2 m c0 m c1 m 70 m 17 m 5f m 48 m 7f m 10 m bd m 10 m
43 m 0 m 3b m 24 m c m 0 m c0 m f m notbusy
02 wcmd 4 m 28 m 0 m \ 0x42800 
6c m c3 m d3 m 18 m d9 m 4 m 48 m 40 m d5 m ac m 42 m e1 m 3d m d8 m c0 m 8 m c1 m 10 m 80 m e2 m c m 10 m 5e m 80 m 64 m 53 m
28 m 10 m 1 m 11 m 0 m c0 m 3 m 0 m c1 m d7 m cc m 5c m 3 m 0 m b8 m 81 m 5b m b1 m 30 m 5c m 13 m 30 m 3c m 57 m 40 m 4 m 83
m 7c m c0 m df m 5 m 2b m 1 m 88 m 33 m 1 m 40 m a8 m 0 2 r c m f0 m 8 m bc m 41 m d4 m 50 m c9 m 9a m 0 m 80 m f m 6f m 11 m
ca m a4 m 20 m 3c m 38 m cc m 0 m ce m 23 m 41 m 5c m 0 m 8 m 25 m d3 m 7 m ce m c1 m dd m 90 m 3d m 5c m 30 m 3c m 0 3 r a m
2c m 0 m 60 m 3d m 70 m 1 m 0 m 11 m 30 m dc m bc m cd m d m e6 m c3 m 5c m 30 m 7d m d0 m 5f m 0 m 1d m d m 40 m 11 m 30 m bc
m 0 m c m 8 m 3f m c0 m c7 m 53 m 42 m 93 m 84 m 38 m 43 m 20 m 17 m c8 m f7 m c0 m b4 m c0 m 1 m d m 33 m 8 m 41 m c1 m f0 m
4b m d0 m 3d m b5 m c m f1 m 4b m cf m c0 m 3 m cc m e m 33 m 7 m 4e m 41 m e3 m 53 m 36 m 6c m 42 m 43 m 6 m 79 m c3 m 0 2 r
fc m 80 m 51 m 34 m 10 m 1f m cf m c2 m 33 m c0 m dc m c m 19 m 8 m 30 m 3 m 3f m 33 m e8 m 28 m c m 9f m 10 m 34 m 9 m f0 m
92 m 59 m 2c m 12 m d8 m 30 m 33 m 44 m 57 m f0 m 53 m d0 m b3 m cf m 1b m c5 m 40 m d5 m 43 m 3c m 30 m c7 m d0 m 13 m 1 m f
m 53 m 30 m 80 2 r 1b m c3 m 30 m c6 m c7 m e3 m 13 m dc m fc m 3 m 33 m f m notbusy
02 wcmd 4 m 29 m 0 m \ 0x42900 
f0 m 84 m 95 m 53 m 63 m 3c m f2 m 25 m 1f m 3e m c m 73 m c2 m 13 m 8 m d8 m 6d m 30 m cd m 4f m f m 21 m d3 m 8 m c7 m 2d m
5 m 3c m 81 m 34 m b1 m c5 m b0 m cc m f8 m 0 m d5 m 44 m f2 m 13 m 5c m 0 m 44 m 9b m 1e m 38 m 83 2 r 0 m 1a m 74 2 r 43 m
1f m 3 m c0 m 5e m d0 m 3b m 44 m 13 m cd m 0 m c0 m c4 m 4d m 71 m 25 m 60 m 1 m 30 m 21 m 9f m 83 m 1 m 31 m de m 74 m 4c m
4d m 4 m 95 m 89 m 53 m b0 m 88 m b0 m d1 m 2e m d m 10 m c0 m a2 m c0 m 0 m c4 m 45 m f0 m 4 m d0 m 43 m c m a0 m ac m 80 m 4
m 20 m 37 m 1 m 2 m e7 m 22 m 38 m 30 m 17 m 96 m 2b m 0 m 8d m 36 m 30 m 54 m 94 m f7 m 8 m 3f m f0 m 8b m 35 m 40 m c m 38 m
23 m c3 m 2c m 3d m 43 m 3d m d0 m e2 m 28 m 7 m d1 m 8 m b5 m c2 m dd m 80 m 8e m 4c m f2 m 55 m 7 m 94 m 4c m 4f m 41 m 67 m
c8 m 3c m d m 3f m 7 m 45 m dc m 23 m fd m 50 m 6c m 7b m 4 m c3 m 4f m ef m 70 m b3 m cc m e m ac m 20 m b3 m 4b m 3e m a0 m
38 m 28 m 2c m c4 m 30 m 6d m cc m 9e m 22 m c0 m b4 m c1 m 6d m 5 m f7 m 7 m 43 m a2 m 2c m 14 m 22 m ec m 1 m d5 m 8e m 6f m
11 m cb m c m 3 m f5 m 3e m 8f m cd m 8b m a1 m 22 m 5c m e m 42 m 11 m c7 m 43 m 6f m b1 m 55 m 8c m eb m 8d m 37 m db m 84 m
56 m 13 m b9 m f0 m 70 m 73 m 3d m 4c m 8b m 23 m 11 m c0 m 68 m 50 m 4b m 0 m d m 0 2 r 2 m notbusy
02 wcmd 4 m 2a m 0 m \ 0x42a00 
48 m 0 m f m cb m 37 m f4 m f m dc m 12 m ef m 98 m 4c m 3 m 1d m a3 m 3 m e8 m b3 m c4 m 80 m 57 m cc m 5 m dc m c5 m 79 m c0
m 83 m 4 m 4c m d8 m 3 m 90 m 4d m c8 m c2 m b8 m 14 m dd m b7 m 3d m 2e m 46 m e m e2 m 4c m cc m 97 m 51 m 6 m c4 m c0 m c m
f1 m 98 m 74 m c0 m 17 m d m 31 m 4c m 27 m 12 m ef m 64 m 4e m d1 m 1 m aa m 81 m ff m b3 m a6 m 40 m 13 m 55 m 19 m d2 m 80
m 7 m d0 m 6c m ac m 3 m 81 m 0 b r d m 3d m 1 m ba m 68 m 53 m c4 m 24 m 19 m cf m 7d m b1 m 3 m 4c m 8 m 2f m b m c1 m c m
e4 m 91 m f1 m 78 m 74 m b8 m 6 m 2d m 0 m 2d m 20 m b m 5c m 75 m b4 m e m 35 m c8 m bf m 30 m 34 m cc m 3d m b3 m 35 m c5 m
42 m 1 m 60 m 88 2 r a2 m e2 m 33 m 4 m d m 4f m c1 m 3c m 6c m be m 3f m 1c m ee m 80 m 85 m 3 m 10 m 74 m 40 m a3 m 3c m dc
m c3 m 40 m a3 m 2a m dc m cf m 34 m 11 m d m 2 m 4d m 31 m 1e m 44 m cd m fe m d m b0 m c8 m 58 m c3 m bc m d8 m 7d m b4 m f
m 19 m 43 m 74 m 22 m 14 m d0 m c2 m 37 m 24 m 74 m 42 m f3 m 12 m f3 m 48 m 31 m 50 m 39 m 4b m 44 m 53 m 60 m db m 14 m 55 m
7c m 18 m 5b m 40 m 70 m e3 m d7 m 94 m 4f m 54 m 1 m c0 m 7 m 5a m 72 m 79 m b4 m d1 m d5 m 0 m a4 m 49 m d7 m f1 m f0 m 8 m
df m c m 2e m 9d m 41 m 95 m f0 m 54 m b0 m 5 m 5c m notbusy
02 wcmd 4 m 2b m 0 m \ 0x42b00 
2b m 41 m c8 m f3 m 72 m b7 m e0 m 7e m 34 m 8 m 2d m c1 m 5c m 20 m 94 m 78 m 7 m c8 m f m 69 m 1 m ec m c1 m dc m 8c m 51 m
88 m 8 m 53 m 43 m 85 m c3 m cc m 5c m c m c4 m 7 m c5 m 4d m a m a3 m 8f m cc m ce m c4 m a m 19 m c5 m 78 m 50 m fa m 10 m
1e m 31 m 6 m 9a m 40 m 58 m 11 m 87 m 50 m d1 m 91 m 9 m 24 m 4d m 5c m c3 m 48 m 94 m 81 m 73 m 13 m de m 7 m 2a m 62 m 10 m
3c m 33 m 69 m 3d m 86 m 4d m 9a m 41 m a2 m b0 m aa m bf m 3e m ef m 41 m 3f m 71 m 5 m f8 m 15 m 57 m 5 m 82 m 40 m 16 m 1 m
43 m 94 m da m 90 m 35 m 4f m c1 m 65 m e0 m 4 m 54 m 91 m d9 m 7 m 5 m 46 m 2 m 53 m 4f m 50 m 41 m 73 m 31 m 40 m c5 m 20 m
40 m 69 m c m b7 m 31 m 10 m 7 m 4f m a6 m a3 m 70 m 7c m 11 m 33 m 15 m a9 m 43 m 6a m 42 m c7 m 20 m 4 m a m 17 m 45 m c6 m
15 m 10 m 11 m 30 m 22 m b3 m 13 m 80 2 r 4c m 20 m 6 m b8 m 43 m 38 m 1c m c0 m 0 m 43 m b0 m 11 m e0 m 4 m b8 m 1 m 3e m 0 m
4f m 80 m 13 m e0 m 44 m 38 m 1 m 1e m c m 43 m 82 m 11 m e0 m 4 m b8 m 1 m 3e m 8 m 4b m 80 m 10 m e0 m 44 m f8 m 1 m e 2 r
83 m 3 m fd m 0 m 57 m 2f m 20 m 5b m c1 m 50 m 20 m 27 m 4 m 57 m 8f m 23 m c5 m c2 m e7 m 60 m 76 m 54 m 66 m 17 m 8 m 9e m
cd m 34 m a1 m 30 m cc m 88 m d8 m 28 m 45 m 4b m be m b0 m b1 m 6c m c6 m 41 m 25 m 4d m 3 m 76 m notbusy
02 wcmd 4 m 2c m 0 m \ 0x42c00 
a3 m e0 m 0 m 43 m c3 m 10 m f0 m 7 m 87 m 0 m c3 m 0 m 7 m 8f m 1c m 3 m c m 7 m 82 m 3c m 30 m cc m 7 m 10 m c0 m cb m f8 m
0 m 21 m 34 m bc m 80 m 12 m 13 m 87 m cc m 3 m 40 m 34 m 3a m 80 m f m 2 m 0 2 r c1 m dc m c0 m 5f m 35 m 10 m 6f m cd m 9 m
41 m 5 m 98 m 97 m 17 m 16 m 3d m c3 m 4c m a0 m ae m 30 m fa m f7 m 3d m bc m 8d m 96 m 82 m 9c m 70 m 0 m 9c m 3 m 2c m 45 m
a3 m 31 m 38 m b4 m f4 m d2 m 1b m ae m c4 m e3 m d2 m 24 m 0 m 34 m 93 m 3 m 87 m 81 m c5 m 93 m e3 m a8 m 11 m 42 m 24 m 39
m 43 m 5b m 43 m 2c m 38 m 8f m 75 m 0 m 3 m 2 m 6c m d0 m cd m cc m 1 m 4e m 1d m a7 m 4e m b5 m f2 m 14 m dc m 53 m 57 m e m
e4 m 9 m 5b m c1 m 5b m 4 m 56 m c1 m 34 m 2c m c m 34 m b3 m 7e m 24 m e3 m 5b m 10 m ec m 7 m 70 m 2 m 73 m 10 m 81 m d3 m e
m 5 m 7 m 71 m 40 m d7 m 0 m c7 m 5f m 13 m f1 m 5 m e7 m c1 m 47 m fc m f8 m d0 m 4 m b2 m 48 m 76 m 41 m 14 m b0 m b1 m d6 m
1c m d0 m 85 m 30 m c0 m 22 m c4 m e3 m 91 m 7 m 2d m 84 m 19 m 0 m 72 m 44 m 41 m 90 m 9 m 72 m 4e m 31 m 41 m 2 m 8 m 3c m
85 m 8 m f8 m 2 m 64 m 81 m 26 m 94 m 52 m 42 m 1 m ec m 8 m c8 m 43 m 25 m fc m c8 m 5 m 12 m 5 m 45 m 11 m 0 m e3 m 28 m b4
m e1 m 32 m bc m f m 3a m a2 m 4c m 20 m 30 m c3 m 15 m db m 8c m 19 m 70 m 17 m f0 m e0 m notbusy
02 wcmd 4 m 2d m 0 m \ 0x42d00 
a0 m 20 m 26 m 5 m a7 m b2 m 73 m a4 m a0 m 14 m 32 m 40 m 49 m 32 m 40 m 2 m 70 m 20 m 82 m 9 m 86 m 2 m 21 m d0 m 88 2 r 84
m e2 m 22 2 r e m 8 m 81 m 78 m 88 m 8 m 5d m 8 m 88 m 82 m 22 m 23 m 88 2 r 7a m e2 m 3 m d m ce m 3e m 42 m 2e m 3c m 54 m
cf m 3d m 4f m 42 m 20 m e3 m ec m 60 m a8 m 41 m 23 m 18 m c m 90 m 72 m 41 m 80 m 28 m d9 m 0 m 52 m 8 m de m 50 m f4 m cc m
36 m 28 m f m 87 m 80 m 70 m f0 m 6 m c0 m 74 m f8 m 38 m fa m 4 m f8 m b1 m 74 m 50 m 30 m ee m 2 m 96 m 8a m 40 m 12 m d7 m
10 m 1f m 8d m 10 2 r 80 m 90 m 1 m b5 m c4 m c3 m d3 m 0 2 r cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc
m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc
m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc
m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc
m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc
m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m notbusy
02 wcmd 4 m 2e m 0 m \ 0x42e00 
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m notbusy
02 wcmd 4 m 2f m 0 m \ 0x42f00 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m notbusy
20 wcmd 4 m 30 m 0 m notbusy \ 0x43000
02 wcmd 4 m 30 m 0 m \ 0x43000 
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 0 24 r 8 m 12 m 84 m 20 m e3 m 0 2 r 8 m cc m 2 m b
m 0 m 1 m 81 m 0 2 r 11 m 34 m 2 m 11 m 41 m c1 m 3 m d m 0 m 44 m 1 m 0 2 r 43 m 1 m 70 m 20 m 0 m 20 m 0 2 r 3 m 0 m a0 m 81
m 50 m notbusy
02 wcmd 4 m 31 m 0 m \ 0x43100 
24 m 93 m 15 m 4 m 41 m d m 49 m 81 m 53 m 54 2 r c4 m 1d m 52 m 86 m 40 m 0 m d m 50 m e m 46 m 1a m 90 m 49 m 4f m 11 m 40 2
r d m 20 m 4 m c7 m c m ce m 31 m 81 m d0 m 60 m 69 m 15 m 40 m 83 m a0 m 40 m 17 m 80 m 8 m 2a m 0 m a8 m 0 m 20 m 10 m 11 m
40 m 0 m 23 m 13 m c5 m 8c m f m 10 m 17 m d4 m 44 m 12 m 0 m 30 m 0 m c0 m 33 m bb m c0 m 50 m 42 m d m d5 m 8 m 8c m 1 m 34
m f0 m d1 m b4 m 39 m 9 m 4b m 65 m 1 m 33 m d4 m 0 m 65 m 10 m 8 m c1 m c0 m f3 m 4 m d4 m c0 m 68 m 9 m d9 m 81 m d m 61 m
e5 m 54 m c5 m 5a m 13 m af m f m 43 m 41 m 5a m a0 m c0 m 1d m 1b 2 r d m 6 m 61 m 62 m a8 m a7 m 49 m 24 m c0 m 4 m 8 m 1 m
65 m 18 m 21 m c2 m 20 m 2a m 9 m 2c m 12 m d0 m 20 m 3 m 44 m 26 m 32 m 8 m 96 m 21 m 42 m 14 m 91 m ee m 15 m 9 m 0 m 81 m
e1 m 45 m f4 m 4c m 5e m 1f m 42 m b m 52 m 1 m b2 m d4 m 40 m 24 m 0 m 9 m a m 8d m e2 m 1d m ec m 8 m 88 m d m 53 m c2 m d m
f0 m b1 m 98 m 39 m 79 m 37 m 8 2 r 82 m 1 m 4b m 24 m 81 m b9 m 2c m 12 m e m c1 m 33 m 4 m 54 m d7 m e m 27 m 8f m 45 m 78 m
50 m 9b m f0 m 8b m f2 m 25 m 17 m c m 40 m 3 m c8 m 24 m bf m bc m 20 m a5 m cb m dc m 83 m 2 m 10 m 3c m 85 m 1f m b1 m f m
c0 m f0 m b0 m bc m c4 m 5c m 23 m 11 m c4 m 12 m b2 m 50 m 40 m 30 m 13 m 22 m notbusy
02 wcmd 4 m 32 m 0 m \ 0x43200 
79 m 9 m b8 m 1 m 52 m f0 m 22 m 12 m 10 m 3 m b m d4 m 33 m b m 20 m c m 3c m 3 m 20 m 8 m cf m 31 m 10 m 0 m 7c m 90 m d m
e0 m c m 7 m 80 m 33 m cc m 62 m f5 m 2f m f9 m 5 m 11 m 41 m ff m 30 m 48 m 1c m 14 m 98 m 86 m 41 m b2 m 5 m 34 m 88 m 9c m
5 m 6 m 4c m 56 m 12 m 94 m 34 m 7 m 58 m 7 m b1 m 4c m 80 m 92 m 47 m 90 m 41 m 82 m a m 80 m 8b m ca m d3 m 3b m c8 m e3 m
7a m 18 m b3 m 4e m 0 m 31 m 54 m 2c m 43 m 1f m 10 m 0 m c4 m 52 m 20 m b3 m 48 m c4 m d1 m 21 m 5c m c4 m 45 m 11 m 14 m 44
2 r 54 m 12 m 9 m 4b m 79 m 90 m 8c m cc m 51 m b m 1c m 7f m 83 m 55 m 51 m 12 m 8 m 93 m 54 m 5 m 88 m 80 m 0 m 43 m 18 m 10
m 37 m 10 m 4 m 22 m c m 1b m 1 m 80 m 18 m 20 m af m 30 m 79 m c m d6 m c0 m 8 m c4 m c m 2b m b m 82 m 8c m 15 m 0 m 74 m 94
m db m 4a m 3f m f4 m 81 m 61 m 40 m 88 m 0 m 80 m 20 m 0 m 39 m 88 m 10 m 53 m 41 m 40 m 8d m 15 m 30 m 45 m 1 m cd m 41 m 45
m d0 m 40 m 12 m 1d m 7 m 83 m 67 m 1 m 53 m a4 m 96 m 91 m 3f m 24 m c9 m 12 m 10 m f1 m 4c m 51 m 59 m 9 m c4 m 40 m d0 m 40
m c0 m 8 m 21 m 4d m 34 m c0 m 4 m 21 m 40 m 84 m 24 m 3 m 7 m 19 m 68 m cf m ad m 22 m 8f m 84 m 3c m 4 m 30 m 12 m 5 m 20 m
c1 m 74 m 14 m 2 m c m 39 m d5 m d m 9f m 21 m 8 m f0 m bf m 15 m d m 6c m d m dc m 70 m notbusy
02 wcmd 4 m 33 m 0 m \ 0x43300 
1a m fc m 8b m f2 m 2f m 37 m 7 m f0 m c1 m 55 m 0 m df m 6d m 13 m ec m c7 m 54 m 13 m 47 m 38 m c m 40 m 6 m dc m 40 m 8f m
90 m 45 m c4 m a1 m 0 6 r a0 m 0 6 r 2 m 0 2 r f0 m 61 m 30 m 1 m 18 m 40 m c0 m 0 m 4 m c m 10 m 3 m 5 m 58 m 0 m 70 m c1 m 0
m 14 m 1 m 46 m 13 m 52 m 49 m 44 m 90 m b1 m 10 m cb m 4b m 31 m 1 m 41 m 0 m 11 m 0 m 70 m 53 m d2 m 15 m 37 m cc m 25 m 1 m
3b m 4 m 0 m d4 m 15 m 43 m 84 m 21 m 1 m 40 m a4 m 21 m d1 m 11 m 50 m c5 m 85 m 70 m 4e m 84 m a7 m 11 m a m 9c m 0 m 11 m
91 m 43 m e0 m 0 m bb m 0 9 r e m 0 m 1 m d1 m c3 m c5 m 94 m f m 3 m 1e m 37 m 8e m 61 m c3 m 94 m 70 m d4 m 15 m 2f m 10 m 0
m 11 m 90 m 17 m ec m 6f m 5 m 27 m 64 m 3 m e9 m 10 m 1c m d8 m 11 m 90 m 14 m 81 m 42 m cd m 30 m 10 m 44 m 80 m 48 m 17 m
19 m 48 m 0 m 42 m 0 3 r c m 11 m 17 m 4 2 r 42 m c m 20 m 41 m d m 20 m 0 m 82 m 4 m 1 m 10 m 0 m 40 m 1 m 38 m c0 m 41 m 40
2 r 61 m 4 m de m 30 m 37 m 1e m 0 m 68 m 10 m 8 m 4 m 8c m 3d m 17 m 41 m c8 m 44 m 10 m 9d m e0 m 36 m 40 m d m 65 m 88 m 40
m 0 m dd m 20 m 48 m 21 m 20 m 48 m c1 m f0 m c1 m f2 m 40 m 4 m d0 m b m cd m cc m c3 m 20 m c8 m 4c m 3f m 34 m notbusy
02 wcmd 4 m 34 m 0 m \ 0x43400 
0 m c8 m 87 m 23 m 30 m f0 m b8 m e0 m 8e m 37 m 9d m 45 m 5e m 43 m 80 m 6c m 8d m 56 m f m 24 m 88 m 5a m 3 m 83 m f8 m 11 m
90 m 1 m f1 m ce m a8 m c0 m a3 m 0 m 8a m 32 m 2c m 47 m 7 m 37 m f2 m c6 m 70 m 33 m 7f m 0 m 37 m 9 m ac m c1 m 3e m f8 m e
m 6 m 1 m 7f m 44 m 11 m 10 m 90 m 48 m 17 m 4 m 0 m c0 m 0 2 r 1 2 r c0 m 0 m 5c m 1c m 0 m 45 m 0 2 r 1 m 0 m c m 0 m 10 m
20 m c0 m 1c m 80 m 4 m 20 m 70 m 7 m 1c m 0 m 80 m 14 m 20 m 4b m 10 m c5 m 0 m 3b m 90 m 7 m 90 m 2 m e4 m 10 m 11 m 71 m 2c
m f9 m 4e m 51 m 0 m 4c m cc m 16 m e5 m 3f m 90 m 43 m 90 m 73 m 94 m 44 m 90 m 47 m 10 m 84 m c9 m 73 m e0 m 5 m 80 m 16 m 1
m 25 m 84 m 40 m 16 m 10 m 30 m e4 m d3 m a9 m 6 m e1 m 0 m 7e m 40 m 44 m 9c m 1 m d6 m 0 m 1 m 4 m 0 m 2 m c4 m 58 m 49 m 71
m 16 m c1 m f m 4 m 42 m 11 m 3c m 71 m 14 2 r 55 m 4c m 47 m 40 m 34 m c m 7c m f m 17 m d4 m 4 m b1 m 3 m 10 m 14 m 51 m 57
m 1 2 r c5 m 6 m c0 m 5e m 9c m 0 m 40 m 32 m b0 m 0 m 44 m 0 m 84 m 38 m 3 m 26 m 3f m f0 m 80 m 3 m f0 m 0 m f0 m 0 m 3c m 0
m f m 0 m 7 m c2 m 0 m f0 m 40 m 3c m 10 m f m 8 m 3 m c0 m 0 m f0 m 80 m 3c m 0 m f m 0 m 3 m c0 m 0 m f0 m 0 m 3c m 0 m f m
c m 3 m c3 m 2a m f0 m 55 m bd m 2f m ae m c3 m e4 m notbusy
02 wcmd 4 m 35 m 0 m \ 0x43500 
c0 m cb m 78 m 55 m e1 m 28 m a1 m 48 m 5a m 1 m f3 m d8 m 9a m e m 3b m 22 m 89 m b0 m 42 m 87 m 2c m fc m 1 m 4 m 9 m ce m
f5 m b0 m 4e m 94 m 8c m 64 m 3 m c0 m 3 m e8 m f2 m f0 m 0 m 22 m f2 m c m 28 m 83 m f0 m 20 m 0 2 r 3 m f0 m 10 m 30 m 0 m 3
m f3 m d0 m 0 m c0 m 3 m 0 m fc m 3 m c0 m 0 m 4c m 4 m 3c m 60 m 4 m c0 m 87 m ca m 0 m 50 m 4 m 3d m 60 m 2f m 0 2 r 2a m 20
m ff m f0 m 5c m d5 m 7 m 30 m 45 m 37 m c1 m 33 m 10 m 44 m 6c m 0 2 r 44 m 7 m 73 m 70 m 0 m 1 2 r 0 2 r 4 m c4 m 1 m c0 m 0
m c m c7 m 3 m 0 m 4b m 0 m 31 m 1c m 50 m 70 m c0 m 2d m 0 m c m 40 m 13 m 11 m 8 m 30 m 11 m 0 m 3 m 0 m 44 m 1 m c3 m 44 m
0 3 r 14 m 43 m 0 m 40 m c m 30 m 6 m b1 m 0 m a4 m 0 2 r 50 m c0 m 0 m 1f m 5c m 4 m 1 m 4 m 11 m 0 m 20 m 50 m 41 2 r c m 44
m a m 88 m d2 m 20 m 38 m a2 m 22 m 4 m 62 m 1 m 5e m 90 m 67 m 18 m 15 m e9 m 18 m 20 m 86 m 4 m 30 m 0 m 4c m 4d m 81 m 35 m
36 m b m 1 m 0 m 4 m 0 m 4 m 7d m 3d m 43 m c1 m 41 m 40 m 3 m 10 m 34 m d0 m 1 m 6d m c7 m 55 m 51 m 41 m 4c m d m d5 m 10 m
50 m d m 74 m c0 m 0 m b4 m d3 m 11 m 7 m dd m 45 m 15 m 40 m fd m 14 m 51 m 54 m 0 m ed m e m 35 m 42 m 14 m 8 m 45 m 7 2 r a
m c1 m ca m 82 m 1c m a8 m a m notbusy
02 wcmd 4 m 36 m 0 m \ 0x43600 
2 m 18 m 51 m 48 m c0 m 42 m 87 m c m 20 m 82 m 22 m 9b m 1 m 11 m 10 m e3 m 0 m 9 m 25 m 4 m 11 m 0 m 57 m 41 m d2 m 98 m 10
m 40 m 3c m 34 m 8a m 11 m 1 m 54 m 88 m 45 m 50 m 1 m 56 m d m a1 m 93 m 90 m 44 m 60 m 0 m 12 m 29 m 48 m 12 m 2 m 22 m d8 m
28 m a2 m 29 m a6 m 82 m 20 m c0 m 88 2 r 8c m a2 m 22 m 26 m 2 m 38 m 82 m 88 2 r 89 m ce m 3a m 8a m 8e m a2 m a0 m a9 m b8
m ae m 22 m 1 2 r 8f m 30 m 40 m 34 m 20 m 3b m 31 m c m 15 m 1 m 52 m d1 m 12 m 70 m 0 m 40 m 33 m 50 m 41 m 10 m 30 m 40 m
64 m 0 m c0 m 1 m 64 m 4c m c0 m 13 m 3c m dc m 3c m 84 m 1 2 r 0 m c2 m c0 m c m 30 m 3 m 0 m 13 m 0 m cc m 13 m 2 m 38 m 60
m 0 m 11 m 0 m 47 m 0 m 22 m 11 m 8 m 0 m 83 m c m 10 2 r 0 m 8 m 80 m 42 m 0 m c3 2 r 0 2 r f m ff m f3 m ff m fc m ff 2 r 3f
m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f
m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f
m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f
m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m notbusy
02 wcmd 4 m 37 m 0 m \ 0x43700 
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m
ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m notbusy
02 wcmd 4 m 38 m 0 m \ 0x43800 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m notbusy
02 wcmd 4 m 39 m 0 m \ 0x43900 
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 0 2a r
notbusy
02 wcmd 4 m 3a m 0 m \ 0x43a00 
0 100 r notbusy
02 wcmd 4 m 3b m 0 m \ 0x43b00 
0 100 r notbusy
02 wcmd 4 m 3c m 0 m \ 0x43c00 
0 100 r notbusy
02 wcmd 4 m 3d m 0 m \ 0x43d00 
0 100 r notbusy
02 wcmd 4 m 3e m 0 m \ 0x43e00 
0 100 r notbusy
02 wcmd 4 m 3f m 0 m \ 0x43f00 
0 100 r notbusy
20 wcmd 4 m 40 m 0 m notbusy \ 0x44000
02 wcmd 4 m 40 m 0 m \ 0x44000 
0 100 r notbusy
02 wcmd 4 m 41 m 0 m \ 0x44100 
0 100 r notbusy
02 wcmd 4 m 42 m 0 m \ 0x44200 
0 100 r notbusy
02 wcmd 4 m 43 m 0 m \ 0x44300 
0 100 r notbusy
02 wcmd 4 m 44 m 0 m \ 0x44400 
0 100 r notbusy
02 wcmd 4 m 45 m 0 m \ 0x44500 
0 100 r notbusy
02 wcmd 4 m 46 m 0 m \ 0x44600 
0 100 r notbusy
02 wcmd 4 m 47 m 0 m \ 0x44700 
0 100 r notbusy
02 wcmd 4 m 48 m 0 m \ 0x44800 
0 100 r notbusy
02 wcmd 4 m 49 m 0 m \ 0x44900 
0 100 r notbusy
02 wcmd 4 m 4a m 0 m \ 0x44a00 
0 100 r notbusy
02 wcmd 4 m 4b m 0 m \ 0x44b00 
0 100 r notbusy
02 wcmd 4 m 4c m 0 m \ 0x44c00 
0 100 r notbusy
02 wcmd 4 m 4d m 0 m \ 0x44d00 
0 100 r notbusy
02 wcmd 4 m 4e m 0 m \ 0x44e00 
0 100 r notbusy
02 wcmd 4 m 4f m 0 m \ 0x44f00 
0 100 r notbusy
20 wcmd 4 m 50 m 0 m notbusy \ 0x45000
02 wcmd 4 m 50 m 0 m \ 0x45000 
0 100 r notbusy
02 wcmd 4 m 51 m 0 m \ 0x45100 
0 100 r notbusy
02 wcmd 4 m 52 m 0 m \ 0x45200 
0 100 r notbusy
02 wcmd 4 m 53 m 0 m \ 0x45300 
0 100 r notbusy
02 wcmd 4 m 54 m 0 m \ 0x45400 
0 100 r notbusy
02 wcmd 4 m 55 m 0 m \ 0x45500 
0 100 r notbusy
02 wcmd 4 m 56 m 0 m \ 0x45600 
0 100 r notbusy
02 wcmd 4 m 57 m 0 m \ 0x45700 
0 100 r notbusy
02 wcmd 4 m 58 m 0 m \ 0x45800 
0 100 r notbusy
02 wcmd 4 m 59 m 0 m \ 0x45900 
0 100 r notbusy
02 wcmd 4 m 5a m 0 m \ 0x45a00 
0 100 r notbusy
02 wcmd 4 m 5b m 0 m \ 0x45b00 
0 100 r notbusy
02 wcmd 4 m 5c m 0 m \ 0x45c00 
0 100 r notbusy
02 wcmd 4 m 5d m 0 m \ 0x45d00 
0 100 r notbusy
02 wcmd 4 m 5e m 0 m \ 0x45e00 
0 8a r d m e0 m 4a m 45 m 63 m 18 m d4 m 8e m 16 m 10 m c3 m 80 m 8c m 62 m a2 m 8c m bd m 32 m 2 m bf m cd m 4 m 33 m 2c m 8
m 0 m 11 m 8 m 94 m 4a m a3 m 10 m 2a m 98 m 31 m 34 m 10 m e7 m cc m 32 m f0 m cd m 28 m 61 m 33 m 18 m 3 m 44 m fc m 0 m c2
m 0 m 93 m 48 m 2 m fc m 40 m 84 m 40 m 5a m 50 m 5d m 93 m 37 m 61 m c7 m b5 m 73 m 8d m c4 m 18 m 45 m 3f m cf m 47 m c4 m
f0 m 1b m 44 m e m e8 m 19 m 94 m 85 m 7 m 60 m 1 m 20 m 33 m 1c m 0 m d9 m 0 m 2c m 23 m 12 m 0 m 1d m c8 m 2c m 18 m c1 m 13
m 92 m c3 m cc m 3d m 80 m c m 3 m 40 m c m 0 m d3 m 80 m 11 m d2 m 1b m notbusy
02 wcmd 4 m 5f m 0 m \ 0x45f00 
39 m c1 m 40 m f3 m 6b m e0 m a4 m d3 m 20 m 5c m cd m 3c m e2 m ef m 50 m e4 m 3 m 2f m 74 m 8e m 36 m c0 m b3 m ac m dc m 4b
m 17 m 80 m ca m 7 m f1 m 7c m f4 m 5b m f9 m d m 8d m c5 m a1 m 13 m 30 m 0 m ed m 45 m 33 m df m c m 1f m 32 m ff m f0 m f1
m 11 m d m 58 m c4 m 24 m 30 m f1 m c m 2a m 44 m 27 m e0 m 41 m 4d m 3 m c9 m 70 m cf m e1 m 1b m 32 m 46 m 44 m 53 m d2 m fc
m 5c m 77 m 1b m 10 m c m dd m 61 m da m 58 m d7 m 46 m 26 m 33 m 4d m 77 m 63 m 5f m 50 m 1 m 23 m 11 m 5a m 8 m 9b m a2 m 5b
m 40 m 50 m 9c m 24 m 7b m ca m 1 m 0 m 15 m 74 m 7b m 7a m 1d m c3 m 85 m 12 m d1 m 81 m 6c m 31 m a3 m 2e m 76 m 82 m df m
23 m c0 m c m da m 48 m 15 m ba m 48 m 4 m c1 m bb m 20 m 3 m 72 m 21 m 56 m 49 m 34 m 41 m db m 44 m c4 m 40 m 4 m 26 m 81 m
75 m 91 m e0 m 34 m 30 m 0 m 37 2 r 7 m c1 2 r 84 m 8c m cd m 14 m 17 m 3a m c0 m 40 m 51 m de m 28 m a1 m 97 m 22 m 1f m 43 m
5f m 41 m f0 m 40 m 62 m c4 m 38 m e4 m 3 m 65 m 70 m 1b m 20 m f0 m f m 4 m 36 m 49 m d m 30 m 81 m 90 m 41 m b5 m 1d m 70 m
c5 m 15 m c3 m 4b m 70 m 30 m 54 m 15 m 54 m 8b m b7 m d0 m d m 38 m 9a m 57 m 23 m a2 m 8d m 6 m d1 m e0 m 28 m c7 m 8c m 34
m c0 m e m cf m e1 m a3 m a0 m d3 m 40 m c m 32 m 88 m 97 m 0 m 68 m b0 m f m b7 m 29 m 45 m 87 m 6b m f0 m notbusy
20 wcmd 4 m 60 m 0 m notbusy \ 0x46000
02 wcmd 4 m 60 m 0 m \ 0x46000 
5b m 48 m 66 m 10 m 12 m de m 4 m ab m a0 m 7b m a4 m 83 m 9d m 17 m 0 m 4f m d9 m 40 m b5 m 40 m f1 m 77 m 38 m 5f m c7 m 89
m 12 m 85 m ac m e1 m f5 m 35 m 77 m 43 m 73 m 21 m cc m 48 m df m 99 m 36 m 0 2 r f1 m 40 m b4 m 90 m b5 m 9a m 31 m 1c m 86
m 38 m d3 m 5 m 38 m 78 m 34 m e m a2 m 3 m 38 m 51 m 1d m 3c m 58 m 8d m 17 2 r 82 m 4e m 3 m c3 m d0 m 6c m 58 m 13 m 46 m 5
m 48 m 0 m fc m 3c m 4b m f8 m 35 m 5f m 8c m d1 m 23 m 80 m bc m 7a m 18 m 23 m 5f m 88 m 0 m 83 m e0 m f4 m 79 m 33 m 15 m
4e m 44 m 50 m 73 m 30 m 70 m 84 m 16 m 2a m 42 m 40 m fc m 53 m c5 m b8 m 16 m d3 m 15 m b0 m 0 m 37 m 43 m 5f m c8 m c2 m 1
m 21 m b0 m cc m 41 m d3 m 85 m 20 m c2 m a7 m 3f m 5 m 49 m 82 m 93 m b8 m c8 m dd m de m 6 m 92 m 4b m 4c m a0 m 3f m a0 m
cf m c4 m 3f m 92 m ce m ef m d2 m 53 m 70 m 68 m 15 m 1f m 4f m c6 m c5 m 32 m e0 m 7c m 56 m cf m 34 m 95 m 4f m b0 m a1 m
94 m b4 m 7c m 32 m 3e m c m 9 m a0 m f3 m fb m d4 m 41 m 14 m 1 m 60 m d m 3f m 71 m 3 m d4 m d6 m 8b m 3d m 15 m 3 m 85 m 30
m 3c m 88 m 49 m 9c m 0 m 2 m 0 3 r 78 m 0 m 80 m 30 m 32 m 4f m 8c m 20 m 1 m 4e m 48 m d0 m 10 m 3e m 44 m 8 m 54 m 72 m 25
m f8 m ec m 3a m 23 m 3b m 8b m 98 m 62 m f2 m 80 m a m 8d m d m fa m 8c m b0 m b2 m 53 m 74 m 4c m 81 m notbusy
02 wcmd 4 m 61 m 0 m \ 0x46100 
12 m d3 m cb m 5f m 30 m 5d m 1c m f1 m 24 m 32 m 91 m 46 m a5 m b0 m 1 m c8 m ba m ac m 3a m 84 m d m cf m 0 m 53 m 0 m 20 m
57 m 27 m 37 m 49 m 0 m 12 m 1a m 4c m bd m fe m 4 m 5 m 1 m c8 m 90 m 57 m 50 m 0 m 98 m 0 9 r 2b m 0 m 5 m 72 m 60 m c3 m c
m 69 m 5 m 2 m c0 m 5 m f9 m 40 m be m f0 m 91 m 48 m 1a m 41 m c1 m 30 m 51 m 98 m 58 m bc m 1d m 18 m 5d m 8f m e2 m b0 m e8
m 20 m 67 m ca m 1d m 3e m 83 m 0 m 90 m ce m 30 m ce m 1f m 5 m 10 m 43 m be m 20 m eb m e8 m 80 m 6 m 2 m 7 m 2 m b0 m 30 m
fe m c m 34 m bc m 21 2 r 87 m 44 m 30 m 38 m 70 m e0 m fc m e m 5b m c m e0 m 32 m 44 m f0 m 51 m 96 m 15 m 91 m 8e m c6 m a1
m 81 m f8 m 65 m 6 m f m 1 m 0 m f1 m 63 m 85 m 44 m e1 m 6 m 18 m 46 m 4b m 8f m 50 m 9a m 34 m 1c m d8 m 14 m 95 m c m 5f m
60 m 5f m 90 m 5d m bb m 14 m 5c m 45 m 9e m 93 m 65 m d8 m 26 m 41 m 25 m a5 m 44 m 9c m 20 m f9 m 44 m c1 m 49 m 2f m 2c m
c2 m 85 m 43 m 76 m a4 m 20 m a1 m 3f m a5 m 49 m 2a m 1 m f m f0 m 20 m ce m 20 m 3 m 4c m 95 m 80 m 5a m 8c m d5 m a3 m 1c m
b9 m 47 m 31 m 21 m cb m 9c m 40 m 10 m 35 m 60 m ca m 73 m 90 m 97 m b8 m 93 m 2d m 19 m 28 m e m 25 m 32 m c2 m 1c m 82 m 20
m 7 m 20 m 3 m 72 m 42 m 4 m 44 m 20 m 46 m 2 m 4 m 3 m 81 m notbusy
02 wcmd 4 m 62 m 0 m \ 0x46200 
0 m 40 m dc m a5 m e6 m 15 m ca m b m 87 m 40 m 1 m d0 m 19 m 20 m 6 m 7f m c4 m 49 m 42 m 33 m 68 m cb m 22 m 39 m e4 m d m
a0 m 33 m 40 m 60 m 4c m 3c m 39 m d8 m 6 m 84 m 51 m 17 m 9c m db m 68 m d m 61 m d m 21 m b1 m 41 m 18 m 21 m af m 1 m 13 m
48 m b7 m 52 m d8 m 84 m 20 m ac m 9 m 17 m 8c m 60 m 42 m 5d m 8 m 31 m 68 m 14 m a2 m 0 m ca m a3 m 10 m 4 m 8 m 64 m 1f m
13 m 4c m 44 m 62 m 4f m 80 m c m 3c m 1b m 4c m 89 m 10 m 30 m 4 m 30 m ea m 99 m 30 m b5 m 8f m 1c m 12 m d0 m 3c m c2 m dc
m 2 m be m b m cf m 70 m 1b m 5c m 5f m 81 m 2c m a0 m 83 m c4 m 22 m 85 m 48 m ff m f2 m 1c m f m cd m c4 m 30 m d m dc m f1
m e8 m 2c m d0 m 0 m 3 m b3 m 0 m e0 m 0 m 38 m 0 m e m 0 m 3 m 82 m 0 m e0 m 0 m 38 m 0 m e m 8 m 3 m 81 m 0 m e0 m 0 m 38 m
0 m e m 0 m 3 m 80 m 0 m e0 m 40 m 38 m 10 m e m f m 3 m 80 m 1 m f8 m 95 m 26 m c m e8 m 85 m 6c m 12 m 1c m 98 m 95 m fe m
11 m 7a m 84 m 79 m d1 m 43 m a8 m 5a m eb m 22 2 r 86 m 7e m 92 m 71 m 88 m a2 m 70 m 0 m 1d m 9 m 73 m 43 m 30 m 10 m 4 m 88
m 14 m 53 m 43 m ee m f3 m e0 m 0 m c3 m c1 m 31 m e0 m 3 m c1 m 82 m c0 m 0 m 3 m c1 m 6 m 0 2 r 3 m c3 m 6 m 30 m c0 m 3 m 0
m f0 m c3 m 0 m 52 m 6 m 30 m 32 m 40 m 0 m 63 m 83 m 2c m 43 m 10 m 30 m 3c m notbusy
02 wcmd 4 m 63 m 0 m \ 0x46300 
48 m c m 31 m 0 m c0 m e2 m ec m d0 m 98 m 29 m d m a2 m 80 m 32 m 40 m d5 m 64 m f0 m 46 m 2b m 32 m 82 m e7 m 3 m 8 m c m 3f
m e1 m 33 m f0 m cb m 54 m 10 m cd m b0 m 80 m 57 m 9 m d9 m c4 m 88 m c3 m ad m 24 m 8e m 6e m 4 m a2 m 45 m 42 m 53 m 4d m
d0 m 9b m ba m 21 m 2c m 80 m 5e m e1 m 39 m 98 m e7 m b5 m 1a m 3 m c9 m be m d0 m dc m c4 m 8b m 7e m 20 m 73 m 4e m 9d m 32
m 6e m 3c m d m 10 m 1b m f6 m 8b m 42 m 33 m 49 m 80 m 26 m 22 m 25 m 8e m 9 m 58 m 21 m a8 m f0 m 5a m 31 m b m 97 m 41 m 32
m 50 m b9 m dc m 23 m 5 m 0 m 22 m 0 m ce m a1 m fc m f8 m 98 m 3c m 2a m 22 m 82 m b9 m 73 m c7 m 5c m d6 m 3 m 13 m 5d m 81
m d1 m 70 m 90 m 2c m a m 78 m 12 m 1a m 88 m 1e m e3 m a2 m 18 m 1a m e m 1c m 38 m b m 4e m 62 m 0 m 68 m 9 m 7b m 21 m 99 m
e m 3b m 90 m 18 m 0 m e7 m b8 m 5 m 59 m 1 m 97 m e3 m 90 m 80 m cb m a1 m 27 m f m c5 m 1 m 23 m 10 m c m e4 m 68 m 26 m 2b
m 86 m 68 m e3 m dc m 0 m c m 6 m 33 m f5 m c m 3 m a1 m 29 m a4 m 30 m 4 m 1c m 87 m 82 m 54 m 21 2 r 0 m ef m a3 m 14 m c8 m
41 m 30 2 r d0 m dc m 13 m 4a m 3c m c0 m 80 m 4 m 1 m 40 m 2c m 82 m cd m 2c m 83 m 42 m ec m 30 m d m 20 m 10 m 41 m 26 m 49
m 1 m 10 m c0 m 44 2 r 45 m 91 m 11 m 15 m 5 m 74 m 42 m 84 m 44 m 5 m 4d m 5 m 45 m 41 m notbusy
02 wcmd 4 m 64 m 0 m \ 0x46400 
51 m 53 m 54 2 r cd m 95 m 1 m 4 m 1 m 9b m e2 m 29 m 40 m 5a m 3a m 3f m e m c m a0 m f0 m 82 m c m 18 m e1 m 39 m 48 m 49 m
e0 m c2 m e1 m 90 m 98 m e4 m 20 m 32 m 42 m 6b m f2 m a m 50 m 64 m 11 m a m 8e m 41 m 8a m 0 m a m 68 m 85 m 89 m 6 m 80 m
86 m 22 m 3 m de m c4 m 71 m 22 m 20 m 3c m 8a m 0 m b3 m c m 8 m 60 m 24 m 38 2 r b m 80 m 20 m c3 m 10 m 39 2 r 0 2 r f m ff
m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff
m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff
m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff
m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff
m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff
m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff
m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m notbusy
02 wcmd 4 m 65 m 0 m \ 0x46500 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m notbusy
02 wcmd 4 m 66 m 0 m \ 0x46600 
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m notbusy
02 wcmd 4 m 67 m 0 m \ 0x46700 
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 0 24 r 8 m 30 m c m 23 m a2 m c m 80 m c8 m a8 m 3 m ca m 0 m ca m c3 m 0 m c8 m 2a m 28 m 3 m 2a m 83 m 82 m 32 m
a m a0 m 8a m 63 m 1 m 80 m 82 m 2 m b0 m 20 m 0 m 32 m a m 2 m 8a m 0 m e0 m 82 m 80 m 20 m 8a m ab m f m 22 m 8a m bc m 82 m
a2 m 88 m 28 m b0 m 3c m af m cf m 2a m 83 m 8 m a0 m 3f m a m 2f m c0 m 8a m a m 22 m 28 m a8 m 88 m 2b m 0 m ca m a m ba m
22 m 8f m 80 m a2 m e3 m a m notbusy
02 wcmd 4 m 68 m 0 m \ 0x46800 
f m 3 m 80 m 0 m 2b m 0 m b0 m 2c m 22 m e0 m 0 m 2 m a2 m ea m a0 m ae m fb m 2e m ae m cf m bb m f3 m fb m b8 m ea m aa m 3a
m ae m 8a m ba m a3 m f2 m f0 m 2 m ac m 2e m 20 m 0 m e0 m 82 m ab m 8c m 2 m aa m a m 2a m 8a m aa m 22 m 8a m a8 m 80 m aa
m 8 m 8a m 2 m a m c0 m 2e m 0 m 88 m aa m b m 2a m 82 m 2b m b0 m 82 m 28 m a2 m 20 m 2a m aa m 8a m ca m 82 m a0 m 0 m 88 m
aa m 2a 2 r b m 8 m 80 m a0 m 8 m 8e m ea m 8 m 82 m 0 m 80 2 r 2a m 8 m ca m c0 m a m a2 m 80 m 28 m e2 m 80 m 88 m 8a m 2 m
2f m 2c m 88 m 3a m b2 m cc m 28 m 0 m a8 m 22 m 28 m 82 m 2 m a2 m 82 m a0 m 88 m ba m 2a m 8 m a m a2 m 82 m 22 m ac m b2 m
30 m 0 m c m c0 m b m c0 m ab m c0 m 3 m 13 m b m a0 m 8c m a0 m a3 m 2 m ac m 2 m 80 m 28 m b2 m f m c m 82 m 30 m 8 m 3a m 2
m 0 m 8 2 r 0 m 20 m 88 m a8 m a0 m 8c m 22 m 0 m a m b2 m 80 m 0 2 r 30 m c m a m a8 m 0 m a3 m b1 m 0 m 4 m c0 2 r b m a m
82 m a0 m 0 m 8c m a0 m cb m a m 2a m 9a m c m 28 m 0 m 23 m 0 m 2 m a2 m 20 m 82 m b m 2c m a2 m a0 m 80 m a m f0 m c m ae m
82 m ec m 2 m ac m 8c m c m a0 m 20 2 r 0 m aa m 2 m 0 m cc m 0 m 2c m 22 m 20 m 0 m 2 m 22 m 2e m ac m 80 m 20 m a m aa m 8 m
8a m a0 m 0 m b8 m ac m a8 m 2a m a8 m c m 22 m 80 m notbusy
02 wcmd 4 m 69 m 0 m \ 0x46900 
2 m 28 m 0 m aa m 8 m c8 m ce m 30 m a2 m a3 m 20 m ca m cc m 28 m ca m a m 8b m c3 m e2 m 20 m b2 m c8 m b m 23 m a m 2e m 20
m 8a m 20 m a2 m 2e m c m ae m 0 m 8c m 23 m a0 m 8c m 82 m a2 m 20 m a3 m 88 m 0 m e3 m a2 m 0 m a m 2a m 0 m 2 m 82 m 80 m 3
m 22 m 30 m 8c m 82 m 22 m 28 m 80 m 8 m 0 m 20 m 8 m c m a0 m b m e2 m b m 8 m a0 m bf m 20 4 r a0 m 0 m a m 30 m 0 2 r 28 m
0 2 r 8b m 8 m 0 m a2 m 38 m a0 m e8 m a0 m 8 m 2c m 8 m 2a m 2 m 82 m 28 m a3 m 2a m 20 m aa m 8 m 8a m 80 m aa m 88 m 80 m
ac m 0 m 8 m 80 m fa m 20 m 8b m 28 m 80 m a2 m a m 2a m 0 m 82 m c0 m 80 m 0 m 80 m 20 m 8 m a2 m 80 m 20 m a1 m c m 80 m e4
m 81 m 2 m 20 m 0 m e m 0 m a m c8 m 20 m 2f m 28 m e m c8 m 0 m 32 m 82 m f0 m 3 m ca m 2a m 32 m c m a0 m 0 m a2 m 88 m 2 m
ac m 20 m e2 m 0 m 80 3 r 20 m 88 m 0 2 r 80 m c0 m 88 m 2 m 3 m 80 m 2 m a m 2a m b0 m 8e m c0 m 0 2 r 38 m 20 m a m 0 m 28 m
a m c0 m 80 m 20 m 28 m c m 8 m 20 m 8a m 8 m a m 0 m 32 m 20 m 22 m a m 8 2 r 2 m a2 m 20 m af m 8 m ba m 0 m 2c m 80 m a m
c8 m 82 m 22 m 0 m 82 m 8 m 2 m a2 m 2 m 28 m 22 m 2 m 20 m a m 8 m 2a m 8 m 0 m 92 m 20 m a m d0 m 4 m 2 m 0 m 9 m 0 2 r 1 m
4 m 0 m 49 m a6 m notbusy
02 wcmd 4 m 6a m 0 m \ 0x46a00 
29 m 0 m c0 m 2 m 0 m 20 m b4 m 80 m 26 m 0 2 r 6 m 80 m 1 m a0 m 8 m 0 m 2 2 r 2e m 40 m 20 m 81 m 0 m 90 m 3 m 42 m 12 m 22
m 4e m 40 m f0 m 28 m 20 m f m 62 m 20 m 0 m 80 m 20 m 0 3 r 22 m 90 m 24 2 r 80 m 24 m 20 m 0 m 80 m 3 m a6 m 2f m 60 m 2 m
d0 m 0 m 82 m d0 m d8 m 82 m 2 m 20 m 8a m 60 m 20 m bd m 8 m 92 m 20 m a m 40 m 0 m 20 m 0 m 6e m 58 m 2 m 54 m 0 9 r d m 0 2
r 20 m 2 m 60 m 0 m 9 m 83 m 0 2 r 8 m aa m 60 m 2a m 98 m 40 m 8 m 3d m 3 m 88 m 3 m a3 m ea m f4 m a9 m 0 m 39 m 0 m c0 m 0
m 20 m 26 m 0 m 2 m 20 m 8 m b0 m e m 62 m 20 m 0 2 r 80 m 8 m 38 m 80 m 0 2 r 20 m 0 2 r 55 m 95 m 0 m b m 40 m 0 2 r c m 20
m 0 m 4 m 20 m 0 m 2 m a m 40 m 20 m 0 m 80 m 0 m 8 m 80 m 0 m 80 m 0 m 20 m 0 m 82 m 20 m 3b m 42 m 0 m 88 m 0 m 8 m 0 m 88 2
r 2a m 60 m 0 m 80 m 20 m 88 m a0 m 2a m 60 m a m b9 m 8 m 0 2 r ad m 80 m 0 m 20 m 0 2 r 80 m a0 m 80 m a0 m 0 2 r 50 m 1 m 8
m 0 m 2 m 0 m 80 m 4 m 10 m 20 m 0 m 80 m 2 m 0 m a2 m 20 m 14 m 98 m 5 m 2a m 4a m 86 m a5 m 21 m 40 m 0 m 41 m aa m 0 m a m
c0 m ed m 1 m 0 3 r 3 m 0 2 r 80 m 3a m 60 m e9 m 0 m e m 90 m 8 m 9 2 r 80 m notbusy
02 wcmd 4 m 6b m 0 m \ 0x46b00 
10 m 82 m ac m 18 m 1 m 0 m 21 m c m 4 m 2 m ce m 40 m 74 m 2b m 2 m d5 m 9 m 80 2 r a4 m 8 m 2b m 40 m 1 m 12 m 40 m 11 m 0 2
r 50 m 40 m 85 m 2d m 2 m 82 m 0 4 r 88 m 0 2 r f4 m 0 m f m d1 m 2 m f4 m b4 m b m 2d m 0 m c0 m 44 m 30 m f m 90 m e4 m 0 m
2 m d0 m 0 m 58 m 0 m 16 m 10 m 11 m 10 m 14 m 5 m 81 m 61 m 10 m 41 m 40 m 0 m 16 m 0 m 58 m 44 m 58 m 40 m 58 m 40 m 58 m 45
m 18 m 41 m 4 m 10 2 r a m 60 m 29 m 0 m 2a m 40 m 0 m 29 m 0 m 2e m 90 m 3 m a4 m b m da m 0 m ad m 0 2 r e0 m e m e9 m 0 6 r
a4 m d m 10 m 0 4 r 21 m 0 2 r 90 m 2b m 20 m ba m 80 m 0 2 r 20 m c m b4 m 29 m 3b m 40 m f m 90 m 1 m a0 m c m 2 m aa m 0 m
a m 40 m b m 40 m ba m a4 m 0 2 r 2a m 90 m 0 m 80 m 0 m 88 m 28 m 2 2 r 3f m f0 m 80 m b m f0 m 2 m f0 m 0 m bc m 0 m 2f m 0
m b m c0 m 2 m f0 m 0 m bc m 0 m 2f m 0 m b m c0 m 2 m f0 m 0 m bc m 0 m 2f m 0 m b m c0 m 2 m f0 m 0 m bc m 0 m 2f m f m 43 m
c3 m 4 2 r 53 m 7 m 1a m ef m 4f m 4 m c3 m 75 m 0 m 42 m a2 m 3e m 19 m 2 m b4 m 62 m 7c m a8 m a m 4d m 10 m b4 m 3 m 99 m
52 m f m a0 m 92 m 94 m 1a m 56 m 83 m 94 m c2 m 2a m 98 m 19 m 4 m 35 m 14 m 3 m ec m 73 m f1 m 0 m 20 m notbusy
02 wcmd 4 m 6c m 0 m \ 0x46c00 
e1 m 4 m 60 m 83 m d9 m 20 m 0 2 r 3 m d9 m 24 m 30 m 0 m 3 m d3 m 64 m 0 m c0 m 3 m 0 m f8 m 3 m c4 m 0 m 6e m 0 m 3c m 0 m 6
m e0 m 3 m c0 m 0 m 1a m 0 m 3c m 0 m f m 0 2 r 28 m 1 m ff m f0 m 6 m 30 m b m d9 m 80 m 28 m 0 m bc m c0 m 0 m 1 m 20 m 0 2
r e m a2 m a9 m 0 2 r 3 m 0 3 r aa m 42 m a0 m 8 2 r aa m 32 m 4 m 8e m 90 m 2 m 1 m 0 m c m 80 m 3e m e5 m 48 m 0 m 20 m 40 m
c8 m 20 2 r 0 m 4 m c0 m 9 m c0 m 32 m 0 2 r c0 m 30 m 0 m 2 m 0 m 92 m 10 m c m 42 m fe m 0 m e8 m 0 2 r 20 m 83 m 0 m 2b m
83 m 10 m 4 m 0 m 2e m 90 m e0 m 0 3 r 8 2 r 3 m aa m 32 m a0 m 0 m ea m 3 m 0 m a0 m 9 m 12 m 30 m 2a m e8 m 91 m 23 m 28 m
a3 m 8a m 4 m 20 m 0 m 48 m 4a m 80 m 21 m 2a m e m 1 m e0 m 4 m 0 m 4 m 19 2 r 71 m 81 m 41 m c0 m 2a m b0 m 8c m a0 m 2 m ba
m 8a m 55 m 51 m 42 m b8 m 3a m 95 m 10 m 20 m 9 m c m 80 m 0 m e8 m 32 m 12 m 3b m a9 m 5 m 15 m 40 m ba m 94 m 51 m 54 m 3 m
fa m 83 m 21 m 83 m 84 m e4 m a9 m bb m b m a7 m 82 m e5 m 41 m 2e m 54 m e5 m 1 m 1c m 1e m 8c m 80 m 83 m 4a m a0 m 90 m 41
m 13 m 6b m 81 m 12 m 10 m 32 m 0 m 3a m 91 m 4 m 1 m 8 m ab m 82 m e9 m 64 m 0 2 r 20 m aa m 43 m 0 m a2 m aa m 54 m aa m a0
m a m a9 m e m notbusy
02 wcmd 4 m 6d m 0 m \ 0x46d00 
50 m 42 m e2 m 88 m 90 m 3 m 1 m 1e m 84 m 1 m 2 m 12 m e4 m 18 m 61 m 25 m 65 m 89 m 98 m f2 m 66 m 64 m 67 m 99 m 19 m 99 m
81 m d6 m 63 m a6 m 64 m 87 m 4a m 7 m 47 m 41 m d1 m d0 m 76 m 74 m a5 m 1d m 0 m f m 83 m 20 m 80 m 30 m e8 m be m 90 m 0 3
r 2 m c0 m 2 m a0 m 0 m 80 m 32 m 0 4 r 80 m 0 2 r c0 m 0 2 r c m 80 m 22 m 8c m 80 m e4 m 83 m 10 m c m 0 m 22 m a2 m 2 m 28
m a1 m a0 m 2 m a8 m 8a m 83 m a0 m 61 m b8 m 3 m 84 m 0 2 r 40 m 22 m 20 m 41 m 4 m a8 m c8 m 20 2 r 4 m 8 m 80 m 10 m 40 m
32 2 r 0 2 r 8f m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2
r 3f m ff m cf m ff m f3 m ff m fc m notbusy
02 wcmd 4 m 6e m 0 m \ 0x46e00 
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m
ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m notbusy
02 wcmd 4 m 6f m 0 m \ 0x46f00 
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m
cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m notbusy
20 wcmd 4 m 70 m 0 m notbusy \ 0x47000
02 wcmd 4 m 70 m 0 m \ 0x47000 
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 3f m ff m cf m ff m f3 m ff m
fc m ff 2 r 3f m ff m cf m ff m f3 m ff m fc m ff 2 r 0 52 r notbusy
02 wcmd 4 m 71 m 0 m \ 0x47100 
0 100 r notbusy
02 wcmd 4 m 72 m 0 m \ 0x47200 
0 100 r notbusy
02 wcmd 4 m 73 m 0 m \ 0x47300 
0 100 r notbusy
02 wcmd 4 m 74 m 0 m \ 0x47400 
0 100 r notbusy
02 wcmd 4 m 75 m 0 m \ 0x47500 
0 100 r notbusy
02 wcmd 4 m 76 m 0 m \ 0x47600 
0 100 r notbusy
02 wcmd 4 m 77 m 0 m \ 0x47700 
0 100 r notbusy
02 wcmd 4 m 78 m 0 m \ 0x47800 
0 100 r notbusy
02 wcmd 4 m 79 m 0 m \ 0x47900 
0 100 r notbusy
02 wcmd 4 m 7a m 0 m \ 0x47a00 
0 100 r notbusy
02 wcmd 4 m 7b m 0 m \ 0x47b00 
0 100 r notbusy
02 wcmd 4 m 7c m 0 m \ 0x47c00 
0 100 r notbusy
02 wcmd 4 m 7d m 0 m \ 0x47d00 
0 100 r notbusy
02 wcmd 4 m 7e m 0 m \ 0x47e00 
0 100 r notbusy
02 wcmd 4 m 7f m 0 m \ 0x47f00 
0 100 r notbusy
20 wcmd 4 m 80 m 0 m notbusy \ 0x48000
02 wcmd 4 m 80 m 0 m \ 0x48000 
0 100 r notbusy
02 wcmd 4 m 81 m 0 m \ 0x48100 
0 100 r notbusy
02 wcmd 4 m 82 m 0 m \ 0x48200 
0 100 r notbusy
02 wcmd 4 m 83 m 0 m \ 0x48300 
0 100 r notbusy
02 wcmd 4 m 84 m 0 m \ 0x48400 
0 100 r notbusy
02 wcmd 4 m 85 m 0 m \ 0x48500 
0 100 r notbusy
02 wcmd 4 m 86 m 0 m \ 0x48600 
0 100 r notbusy
02 wcmd 4 m 87 m 0 m \ 0x48700 
0 100 r notbusy
02 wcmd 4 m 88 m 0 m \ 0x48800 
0 100 r notbusy
02 wcmd 4 m 89 m 0 m \ 0x48900 
0 100 r notbusy
02 wcmd 4 m 8a m 0 m \ 0x48a00 
0 100 r notbusy
02 wcmd 4 m 8b m 0 m \ 0x48b00 
0 100 r notbusy
02 wcmd 4 m 8c m 0 m \ 0x48c00 
0 100 r notbusy
02 wcmd 4 m 8d m 0 m \ 0x48d00 
0 100 r notbusy
02 wcmd 4 m 8e m 0 m \ 0x48e00 
0 100 r notbusy
02 wcmd 4 m 8f m 0 m \ 0x48f00 
0 100 r notbusy
20 wcmd 4 m 90 m 0 m notbusy \ 0x49000
02 wcmd 4 m 90 m 0 m \ 0x49000 
0 100 r notbusy
02 wcmd 4 m 91 m 0 m \ 0x49100 
0 100 r notbusy
02 wcmd 4 m 92 m 0 m \ 0x49200 
0 100 r notbusy
02 wcmd 4 m 93 m 0 m \ 0x49300 
0 100 r notbusy
02 wcmd 4 m 94 m 0 m \ 0x49400 
0 100 r notbusy
02 wcmd 4 m 95 m 0 m \ 0x49500 
0 100 r notbusy
02 wcmd 4 m 96 m 0 m \ 0x49600 
0 100 r notbusy
02 wcmd 4 m 97 m 0 m \ 0x49700 
0 100 r notbusy
02 wcmd 4 m 98 m 0 m \ 0x49800 
0 100 r notbusy
02 wcmd 4 m 99 m 0 m \ 0x49900 
0 100 r notbusy
02 wcmd 4 m 9a m 0 m \ 0x49a00 
0 100 r notbusy
02 wcmd 4 m 9b m 0 m \ 0x49b00 
0 100 r notbusy
02 wcmd 4 m 9c m 0 m \ 0x49c00 
0 100 r notbusy
02 wcmd 4 m 9d m 0 m \ 0x49d00 
0 100 r notbusy
02 wcmd 4 m 9e m 0 m \ 0x49e00 
0 100 r notbusy
02 wcmd 4 m 9f m 0 m \ 0x49f00 
0 100 r notbusy
20 wcmd 4 m a0 m 0 m notbusy \ 0x4a000
02 wcmd 4 m a0 m 0 m \ 0x4a000 
0 100 r notbusy
02 wcmd 4 m a1 m 0 m \ 0x4a100 
0 100 r notbusy
02 wcmd 4 m a2 m 0 m \ 0x4a200 
0 100 r notbusy
02 wcmd 4 m a3 m 0 m \ 0x4a300 
0 100 r notbusy
02 wcmd 4 m a4 m 0 m \ 0x4a400 
0 100 r notbusy
02 wcmd 4 m a5 m 0 m \ 0x4a500 
0 100 r notbusy
02 wcmd 4 m a6 m 0 m \ 0x4a600 
0 100 r notbusy
02 wcmd 4 m a7 m 0 m \ 0x4a700 
0 100 r notbusy
02 wcmd 4 m a8 m 0 m \ 0x4a800 
0 100 r notbusy
02 wcmd 4 m a9 m 0 m \ 0x4a900 
0 100 r notbusy
02 wcmd 4 m aa m 0 m \ 0x4aa00 
0 100 r notbusy
02 wcmd 4 m ab m 0 m \ 0x4ab00 
0 100 r notbusy
02 wcmd 4 m ac m 0 m \ 0x4ac00 
0 100 r notbusy
02 wcmd 4 m ad m 0 m \ 0x4ad00 
0 100 r notbusy
02 wcmd 4 m ae m 0 m \ 0x4ae00 
0 100 r notbusy
02 wcmd 4 m af m 0 m \ 0x4af00 
0 100 r notbusy
20 wcmd 4 m b0 m 0 m notbusy \ 0x4b000
02 wcmd 4 m b0 m 0 m \ 0x4b000 
0 100 r notbusy
02 wcmd 4 m b1 m 0 m \ 0x4b100 
0 100 r notbusy
02 wcmd 4 m b2 m 0 m \ 0x4b200 
0 100 r notbusy
02 wcmd 4 m b3 m 0 m \ 0x4b300 
0 100 r notbusy
02 wcmd 4 m b4 m 0 m \ 0x4b400 
0 100 r notbusy
02 wcmd 4 m b5 m 0 m \ 0x4b500 
0 100 r notbusy
02 wcmd 4 m b6 m 0 m \ 0x4b600 
0 100 r notbusy
02 wcmd 4 m b7 m 0 m \ 0x4b700 
0 100 r notbusy
02 wcmd 4 m b8 m 0 m \ 0x4b800 
0 100 r notbusy
02 wcmd 4 m b9 m 0 m \ 0x4b900 
0 100 r notbusy
02 wcmd 4 m ba m 0 m \ 0x4ba00 
0 100 r notbusy
02 wcmd 4 m bb m 0 m \ 0x4bb00 
0 100 r notbusy
02 wcmd 4 m bc m 0 m \ 0x4bc00 
0 100 r notbusy
02 wcmd 4 m bd m 0 m \ 0x4bd00 
0 100 r notbusy
02 wcmd 4 m be m 0 m \ 0x4be00 
0 100 r notbusy
02 wcmd 4 m bf m 0 m \ 0x4bf00 
0 100 r notbusy
20 wcmd 4 m c0 m 0 m notbusy \ 0x4c000
02 wcmd 4 m c0 m 0 m \ 0x4c000 
0 100 r notbusy
02 wcmd 4 m c1 m 0 m \ 0x4c100 
0 100 r notbusy
02 wcmd 4 m c2 m 0 m \ 0x4c200 
0 100 r notbusy
02 wcmd 4 m c3 m 0 m \ 0x4c300 
0 100 r notbusy
02 wcmd 4 m c4 m 0 m \ 0x4c400 
0 100 r notbusy
02 wcmd 4 m c5 m 0 m \ 0x4c500 
0 100 r notbusy
02 wcmd 4 m c6 m 0 m \ 0x4c600 
0 100 r notbusy
02 wcmd 4 m c7 m 0 m \ 0x4c700 
0 100 r notbusy
02 wcmd 4 m c8 m 0 m \ 0x4c800 
0 100 r notbusy
02 wcmd 4 m c9 m 0 m \ 0x4c900 
0 100 r notbusy
02 wcmd 4 m ca m 0 m \ 0x4ca00 
0 100 r notbusy
02 wcmd 4 m cb m 0 m \ 0x4cb00 
0 100 r notbusy
02 wcmd 4 m cc m 0 m \ 0x4cc00 
0 28 r 80 m 1 m 0 3 r 11 m 0 m 1 m 0 18 r 7 m 1 m 0 3 r 24 m 0 m b m 80 m 1 m 0 3 r 11 m 0 m 1 m 0 30 r 80 m 1 m 9 m 44 m 0 m
24 m 0 m b m 0 m 1 m 0 m 44 m 0 m 24 m 0 m b m 0 20 r 80 m 1 m 9 m 44 m 0 m 24 m 0 m b m 0 m 1 m 0 m 44 m 0 m 24 m 0 m b m 0 m
80 m 0 4 r 8 m 0 5 r 41 m 0 5 r 4 m 0 5 r 20 m 0 5 r 3 m 80 m 0 4 r 28 m 80 m 0 12 r notbusy
02 wcmd 4 m cd m 0 m \ 0x4cd00 
0 8 r 80 m 1 m 9 m 44 m 0 m 24 m 0 m b m 0 m 1 m 0 m 44 m 0 m 24 m 0 m b m 0 30 r 80 m 1 m 9 m 44 m 0 m 24 m 0 m b m 0 m 1 m 0
m 44 m 0 m 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 80 m 1 m 0 3 r 11 m 0 m 1 m 7 m 1 m 0 3 r 24 m 0
m b m 0 10 r 80 m 1 m 0 3 r 11 m 0 m 1 m 7 m 1 m 0 3 r 24 m 0 m b m 0 18 r 80 m 1 m 0 3 r 11 m 0 m 1 m 0 38 r 7 m 1 m 0 3 r 24
m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m notbusy
02 wcmd 4 m ce m 0 m \ 0x4ce00 
7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m
0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0
3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7
m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 0 70 r 7 m 1 m 0 3 r 24 m 0 m b m notbusy
02 wcmd 4 m cf m 0 m \ 0x4cf00 
7 m 1 m 0 3 r 24 m 0 m b m 0 18 r 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 80 m 1 m 0
3 r 11 m 0 m 1 m 80 m 1 m 0 3 r 11 m 0 m 1 m 0 10 r 80 m 1 m 0 3 r 11 m 0 m 1 m 80 m 1 m 0 3 r 11 m 0 m 1 m 0 18 r 7 m 1 m 0 3
r 24 m 0 m b m 0 10 r 7 m 1 m 0 3 r 24 m 0 m b m 0 8 r 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 0 8 r 7 m 1 m 0 3
r 24 m 0 m b m 0 10 r 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 0 10 r 7 m 3 m 0 3 r 24 m 0 m b m notbusy
20 wcmd 4 m d0 m 0 m notbusy \ 0x4d000
02 wcmd 4 m d0 m 0 m \ 0x4d000 
87 m 1 m 0 3 r 11 m 0 m 1 m 0 8 r 7 m 1 m 0 3 r 24 m 0 m b m 0 28 r 7 m 3 m 0 3 r 24 m 0 m b m 80 m 1 m 0 3 r 11 m 0 m 1 m 80
m 1 m 0 3 r 11 m 0 m 1 m 0 8 r 80 m 1 m 0 3 r 11 m 0 m 1 m 0 60 r 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 0 18 r
7 m 1 m 0 3 r 24 m 0 m b m 0 8 r notbusy
02 wcmd 4 m d1 m 0 m \ 0x4d100 
0 18 r 7 m 1 m 0 3 r 24 m 0 m b m 0 28 r 87 m 3 m 0 3 r 11 m 0 m 1 m 7 m 0 4 r 24 m 0 m b m 0 18 r 7 m 0 4 r 24 m 0 m b m 0 10
r 87 m 3 m 0 3 r 11 m 0 m 1 m 87 m 3 m 0 3 r 11 m 0 m 1 m 87 m 3 m 0 3 r 11 m 0 m 1 m 0 60 r notbusy
02 wcmd 4 m d2 m 0 m \ 0x4d200 
0 68 r 7 m 1 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 0 8 r 7 m 3 m 0 3 r 24 m 0 m b m 7 m 1 m 0 3 r 24 m 0 m b m 80 m
1 m 0 3 r 11 m 0 m 1 m 0 8 r 7 m 1 m 0 3 r 24 m 0 m b m 0 58 r notbusy
02 wcmd 4 m d3 m 0 m \ 0x4d300 
0 20 r 7 m 1 m 0 3 r 24 m 0 m b m 0 3 r e m 3d m a9 m 30 m a1 m 0 m a m 30 m a1 m 0 m 3 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m
30 m a1 m 0 m a m 30 m a1 m 0 m 5 m 30 m e1 m 0 m ff m 30 m c1 m 0 m 81 m 30 m 2 m 0 m d m 3c m 86 m 30 m a1 m 0 m d m 20 m 0
m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m 20 m 0 m ff 8c r
notbusy
20 wcmd 4 m e0 m 0 m notbusy \ 0x4e000
20 wcmd 4 m f0 m 0 m notbusy \ 0x4f000
20 wcmd 5 m 0 m 0 m notbusy \ 0x50000
20 wcmd 5 m 10 m 0 m notbusy \ 0x51000
20 wcmd 5 m 20 m 0 m notbusy \ 0x52000
20 wcmd 5 m 30 m 0 m notbusy \ 0x53000
20 wcmd 5 m 40 m 0 m notbusy \ 0x54000
20 wcmd 5 m 50 m 0 m notbusy \ 0x55000
20 wcmd 5 m 60 m 0 m notbusy \ 0x56000
20 wcmd 5 m 70 m 0 m notbusy \ 0x57000
20 wcmd 5 m 80 m 0 m notbusy \ 0x58000
20 wcmd 5 m 90 m 0 m notbusy \ 0x59000
20 wcmd 5 m a0 m 0 m notbusy \ 0x5a000
20 wcmd 5 m b0 m 0 m notbusy \ 0x5b000
20 wcmd 5 m c0 m 0 m notbusy \ 0x5c000
20 wcmd 5 m d0 m 0 m notbusy \ 0x5d000
20 wcmd 5 m e0 m 0 m notbusy \ 0x5e000
20 wcmd 5 m f0 m 0 m notbusy \ 0x5f000
20 wcmd 6 m 0 m 0 m notbusy \ 0x60000
20 wcmd 6 m 10 m 0 m notbusy \ 0x61000
20 wcmd 6 m 20 m 0 m notbusy \ 0x62000
20 wcmd 6 m 30 m 0 m notbusy \ 0x63000
20 wcmd 6 m 40 m 0 m notbusy \ 0x64000
20 wcmd 6 m 50 m 0 m notbusy \ 0x65000
20 wcmd 6 m 60 m 0 m notbusy \ 0x66000
20 wcmd 6 m 70 m 0 m notbusy \ 0x67000
20 wcmd 6 m 80 m 0 m notbusy \ 0x68000
20 wcmd 6 m 90 m 0 m notbusy \ 0x69000
20 wcmd 6 m a0 m 0 m notbusy \ 0x6a000
20 wcmd 6 m b0 m 0 m notbusy \ 0x6b000
20 wcmd 6 m c0 m 0 m notbusy \ 0x6c000
20 wcmd 6 m d0 m 0 m notbusy \ 0x6d000
20 wcmd 6 m e0 m 0 m notbusy \ 0x6e000
20 wcmd 6 m f0 m 0 m notbusy \ 0x6f000
20 wcmd 7 m 0 m 0 m notbusy \ 0x70000
20 wcmd 7 m 10 m 0 m notbusy \ 0x71000
20 wcmd 7 m 20 m 0 m notbusy \ 0x72000
20 wcmd 7 m 30 m 0 m notbusy \ 0x73000
20 wcmd 7 m 40 m 0 m notbusy \ 0x74000
20 wcmd 7 m 50 m 0 m notbusy \ 0x75000
20 wcmd 7 m 60 m 0 m notbusy \ 0x76000
20 wcmd 7 m 70 m 0 m notbusy \ 0x77000
20 wcmd 7 m 80 m 0 m notbusy \ 0x78000
20 wcmd 7 m 90 m 0 m notbusy \ 0x79000
20 wcmd 7 m a0 m 0 m notbusy \ 0x7a000
20 wcmd 7 m b0 m 0 m notbusy \ 0x7b000
20 wcmd 7 m c0 m 0 m notbusy \ 0x7c000
20 wcmd 7 m d0 m 0 m notbusy \ 0x7d000
20 wcmd 7 m e0 m 0 m notbusy \ 0x7e000
20 wcmd 7 m f0 m 0 m notbusy \ 0x7f000
20 wcmd 8 m 0 m 0 m notbusy \ 0x80000
02 wcmd 8 m 0 m 0 m \ 0x80000 
7a m 94 m 0 m 99 m 0 2 r 7 m 0 2 r 26 m 0 4 r 1 m ff 3 r 0 m ff 3 r 26 m ff 3 r 1a m ff 3 r 60 m 20 m 30 m 0 m 4 m 0 7 r 1a m
ff 3 r 94 m 20 m 30 m 0 m 4 m 0 3 r 83 m 0 3 r 1a m ff 3 r 68 m 20 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 6c m 20 m 30 m 0 m 4 m 0 7
r 1a m ff 3 r 7c m 25 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 2c m 20 m 30 m 0 m 4 m 0 3 r 72 m 6 m 0 2 r 1a m ff 3 r 30 m 20 m 30 m
0 m 4 m 0 3 r 4 m 1 m 0 2 r 1a m ff 3 r 34 m 20 m 30 m 0 m 4 m 0 4 r 5 m 0 2 r 1a m ff 3 r 40 m 20 m 30 m 0 m 4 m 0 3 r ee m 2
m 0 2 r 1a m ff 3 r 44 m 20 m 30 m 0 m 4 m 0 3 r 19 m 0 3 r 1a m ff 3 r 48 m 20 m 30 m 0 m 4 m 0 3 r d0 m 2 m 0 2 r 1a m ff 3
r 3c m 20 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 38 m 20 m 30 m 0 m 4 m 0 3 r 28 m 0 3 r 1a m ff 3 r 50 m 20 m 30 m 0 m 4 m 0 7 r 1a
m ff 3 r 4c m 20 m notbusy
02 wcmd 8 m 1 m 0 m \ 0x80100 
30 m 0 m 4 m 0 3 r 5 m 0 3 r 1a m ff 3 r 70 m 20 m 30 m 0 m 4 m 0 3 r 1 m 0 6 r 5 m 24 m ff 3 r 0 8 r 89 m 50 m 4e m 47 m d m
a m 1a m a m 0 3 r d m 49 m 48 m 44 m 52 m 0 2 r 1 m 8f m 0 3 r 84 m 8 m 3 m 0 3 r 5f m f4 m 57 m a2 m 0 2 r a m 39 m 69 m 43
2 r 50 2 r 68 m 6f m 74 m 6f m 73 m 68 m 6f m 70 m 20 m 49 m 43 2 r 20 m 70 m 72 m 6f m 66 m 69 m 6c m 65 m 0 2 r 78 m da m 9d
m 96 m 77 m 54 2 r d7 m 16 m 87 m cf m bd m 77 m 7a m a1 m cd m 30 m 2 m 52 m 86 m de m bb m c0 m 0 m d2 m 7b m 93 m 5e m 45 m
61 m 98 m 19 m 60 m 28 m 3 m e m 33 m 34 m b1 m 21 m a2 m 2 m 11 m 45 m 44 m 9a m 22 m 48 m 50 m c4 m 80 m d1 m 50 m 24 m 56 m
44 m b1 m 10 m 14 m 54 m b0 m 7 m 24 m 8 m 28 m 31 m 18 m 45 m 54 m 2c m 6f m 46 m d6 m 8b m ae m ac m bc m f7 m f2 2 r fb m
e3 m ac m 6f m ed m b3 m f7 m b9 m fb m ec m bd m cf m 5a m 17 m 0 m 92 m a7 m 2f m 97 2 r 6 m 4b m 1 m 90 m ca m 13 m f0 m 83
m 3c m 9c m e9 m 11 m 91 m 51 m 74 m ec m 0 m 80 m 1 m 1e m 60 m 80 m 29 m 0 m 4c m 56 m 46 m ba m 5f m b0 m 7b m 8 m 10 m c9
m cb m cd m 85 m 9e m 21 m 72 m 2 m 5f m 4 m 1 m f0 m 7a m 58 m bc m 2 m 70 m notbusy
02 wcmd 8 m 2 m 0 m \ 0x80200 
d3 m d0 m 33 m 80 m 4e m 7 m ff m 9f m a4 m 59 m e9 m 7c m 81 m e8 m 98 m 0 m 11 m 9b m b3 m 39 m 19 m 2c m 11 m 17 m 88 m 38
m 25 m 4b m 90 m 2e m b6 m cf m 8a m 98 m 1a m 97 m 2c m 66 m 18 m 25 m 66 m be m 28 m 41 m 11 m cb m 89 m 39 m 61 m 91 m d m
3e m fb m 2c m b2 m a3 m 98 m d9 m a9 m 3c m b6 m 88 m c5 m 39 m a7 m b3 m 53 m d9 m 62 m ee m 15 m f1 m b6 m 4c m 21 m 47 m
c4 m 88 m af m 88 m b m 33 m b9 m 9c m 2c m 11 m df m 12 m b1 m 46 m 8a m 30 m 95 m 2b m e2 m 37 m e2 m d8 m 54 m e m 33 m 3 m
0 m 14 m 49 m 6c m 17 m 70 m 58 m 89 m 22 m 36 m 11 m 31 m 89 m 1f m 12 m e4 m 22 m e2 m e5 m 0 m e0 m 48 m 9 m 5f m 71 m dc m
57 m 2c m e0 m 64 m b m c4 m 97 m 72 m 49 m 4b m cf m e1 m 73 m 13 m 12 m 5 m 74 m 1d m 96 m 2e m dd m d4 m da m 9a m 41 m f7
m e4 m 64 m a5 m 70 m 4 m 2 m c3 m 0 m 26 m 2b m 99 m c9 m 67 m d3 m 5d m d2 m 52 m d3 m 99 m bc m 1c m 0 m 16 m ef m fc m 59
m 32 m e2 m da m d2 m 45 2 r b6 m 34 m b5 m b6 m b4 m 34 2 r 33 m 32 m fd m aa m 50 m ff m 75 m f3 m 6f m 4a m dc m db m 45 m
7a m 19 m f8 m b9 m 67 m 10 m ad m ff m 8b m ed m af m fc m d2 m 1a m 0 m 60 m cc m 89 m 6a m b3 m f3 m 8b m 2d m ae m a m 80
m ce m 2d m 0 m c8 m dd m fb m 62 m d3 m 38 m 0 m 80 m a4 m a8 m 6f m 1d m d7 m bf m ba m f m 4d m 3c m 2f m 89 m 2 m notbusy
02 wcmd 8 m 3 m 0 m \ 0x80300 
41 m ba m 8d m b1 m 71 m 56 2 r 96 m 11 m 97 m c3 m 32 m 12 m 17 m f4 m f m fd m 4f m 87 m bf m a1 m af m be m 67 m 24 m 3e m
ee m 8f m f2 m d0 m 5d m 39 m f1 m 4c m 61 m 8a m 80 m 2e m ae m 1b m 2b m 2d m 25 m 4d m c8 m a7 m 67 m a4 m 33 m 59 m 1c m
ba m e1 m 9f m 87 m f8 m 1f m 7 m fe m 75 m 1e m 6 m 41 m 9c m 78 m e m 9f m c3 m 13 m 45 m 84 m 89 m a6 m 8c m cb m 4b m 10 m
b5 m 9b m c7 m e6 m a m b8 m 69 m 3c m 3a m 97 m f7 m 9f m 9a m f8 m f m c3 m fe m a4 m c5 m b9 m 16 m 89 m d2 m f8 m 11 m 50
m 63 m 8c m 80 m d4 m 75 m 2a m 40 m 7e m ed m 7 m 28 m a m 11 m 20 m d1 m fb m c5 m 5d m ff m a3 m 6f m be m f8 m 30 m 20 m
7e m 79 m e1 m 2a m 93 m 8b m 73 m ff m ef m 37 m fd m 67 m c1 m a5 m e2 m 25 m 83 m 9b m f0 m 39 m ce m 25 m 28 m 84 m ce m
12 m f2 m 33 m 17 m f7 m c4 m cf m 12 m a0 m 1 2 r 48 m 2 m 2a m 90 m 7 m ca m 40 m 1d m e8 m 0 m 43 m 60 m 6 m ac m 80 m 2d m
70 m 4 m 6e m c0 m 1b m f8 m 83 m 10 2 r 9 m 56 m 3 m 16 m 48 m 4 m a9 m 80 m f m b2 m 40 m 1e m d8 m 4 m a m 41 m 31 m d8 m 9
m f6 m 80 m 6a m 50 m 7 m 1a m 41 m 33 m 68 m 5 m c7 m 41 m 27 m 38 m 5 m ce m 83 m 4b m e0 m 1a m b8 m 1 m 6e m 83 m fb m 60
m 14 m 4c m 80 m 67 m 60 m 16 m bc m 6 m b m 10 m 4 m 61 m 21 m 32 m 44 m 81 m e4 m 21 m 15 m 48 m 13 m d2 m notbusy
02 wcmd 8 m 4 m 0 m \ 0x80400 
87 m cc m 20 m 6 m 64 m f m b9 m 41 m be m 50 m 10 m 14 m 9 m c5 m 42 m 9 m 10 m f m 12 m 42 m 79 m d0 m 66 m a8 m 18 m 2a m
83 m aa m a1 m 7a m a8 m 19 m fa m 1e m 3a m 9 m 9d m 87 m ae m 40 m 83 m d0 m 5d m 68 m c m 9a m 86 m 7e m 87 m de m c1 m 8 m
4c m 82 m a9 m b0 m 12 m ac m 5 m 1b m c3 m c m d8 m 9 m f6 m 81 m 43 m e0 m 55 m 70 m 2 m bc m 6 m ce m 85 m b m e0 m 1d m 70
m 25 m dc m 0 m 1f m 85 m 3b m e0 m f3 m f0 m 35 m f8 m 36 m 3c m a m 3f m 83 m e7 m 10 m 80 m 10 m 11 m 1a m a2 m 8a m 18 m
22 m c m c4 m 5 m f1 m 47 m a2 m 90 m 78 m 84 m 8f m ac m 47 m 8a m 90 m a m a4 m 1 m 69 m 45 m ba m 91 m 3e m e4 m 26 m 32 m
8a m cc m 20 m 6f m 51 m 18 m 14 m 5 m 45 m 47 m 19 m a2 m 6c m 51 m 9e m a8 m 50 m 14 m b m b5 m 6 m b5 m 1e m 55 m 82 m aa m
46 m 1d m 46 m 75 m a0 m 7a m 51 m 37 m 51 m 63 m a8 m 59 m d4 m 47 m 34 m 19 m ad m 88 m d6 m 47 m db m a0 m bd m d0 m 11 m
e8 m 4 m 74 m 16 m ba m 10 m 5d m 81 m 6e m 42 m b7 m a3 m 2f m a2 m 6f m a3 m 27 m d0 m af m 31 m 18 m c m d m a3 m 8d m b1 m
c2 m 78 m 62 m 22 m 31 m 49 m 98 m b5 m 98 m 12 m cc m 3e m 4c m 1b m e6 m 1c m 66 m 10 m 33 m 8e m 99 m c3 m 62 m b1 m f2 m
58 m 7d m ac m 1d m d6 m 1f m cb m c4 m a m b0 m 85 m d8 m 2a m ec m 51 m ec m 59 m ec m 10 m 76 m 2 m fb m 6 m 47 m notbusy
02 wcmd 8 m 5 m 0 m \ 0x80500 
c4 m a9 m e0 m cc m 70 m ee m b8 m 28 m 1c m f m 97 m 8f m ab m c0 m 1d m c1 m 9d m c1 m d m e1 m 26 m 71 m b m 78 m 29 m bc m
26 m de m 6 m ef m 8f m 67 m e3 m 73 m f0 m a5 m f8 m 46 m 7c m 37 m fe m 3a m 7e m 2 m bf m 40 m 90 m 26 m 68 m 13 m ec m 8 m
21 m 84 m 24 m c2 m 26 m 42 m 25 m a1 m 95 m 70 m 91 m f0 m 80 m f0 m 92 m 48 m 24 m aa m 11 m ad m 89 m 81 m 44 m 2e m 71 m
23 m b1 m 92 m 78 m 8c m 78 m 99 m 38 m 46 m 7c m 4b m 92 m 21 m e9 m 91 m 5c m 48 m d1 m 24 m 21 m 69 m 7 m e9 m 10 m e9 m 1c
m e9 m 2e m e9 m 25 m 99 m 4c m d6 m 22 m 3b m 92 m a3 m c8 m 2 m f2 m e m 72 m 33 m f9 m 2 m f9 m 11 m f9 m 8d m 4 m 45 m c2
m 48 m c2 m 4b m 82 m 2d m b1 m 41 m a2 m 46 m a2 m 43 m 62 m 48 m e2 m b9 m 24 m 5e m 52 m 53 m d2 m 49 m 72 m b5 m 64 m ae m
64 m 85 m e4 m 9 m c9 m eb m 92 m 33 m 52 m 78 m 29 m 2d m 29 m 17 m 29 m a6 m d4 m 7a m a9 m 1a m a9 m 93 m 52 m 23 m 52 m 73
m d2 m 14 m 69 m 53 m 69 m 7f m e9 m 54 m e9 m 12 m e9 m 23 m d2 m 57 m a4 m a7 m 64 m b0 m 32 m 5a m 32 m 6e m 32 m 6c m 99 m
2 m 99 m 83 m 32 m 17 m 64 m c6 m 29 m 8 m 45 m 9d m e2 m 42 m 61 m 51 m 36 m 53 m 1a m 29 m 17 m 29 m 13 m 54 m c m 55 m 9b m
ea m 45 m 4d m a2 m 16 m 53 m bf m a3 m e m 50 m 67 m 65 2 r 64 m 97 m c9 m 86 m c9 m 66 m cb m d6 m c8 m 9e m 96 m 1d m
notbusy
02 wcmd 8 m 6 m 0 m \ 0x80600 
a5 m 21 m 34 m 2d m 9a m 17 m 2d m 85 m 56 m 4a m 3b m 4e m 1b m a6 m bd m 5b m a2 m b4 m c4 m 69 m 9 m 67 m c9 m f6 m 25 m ad
m 4b m 86 m 96 m cc m cb m 2d m 95 m 73 m 94 m e3 m c8 m 15 m c9 m b5 m c9 m dd m 96 m 7b m 27 m 4f m 97 m 77 m 93 m 4f m 96 m
df m 25 m df m 29 m ff m 50 m 1 m a5 m a0 m a7 m 10 m a8 m 90 m a5 m b0 m 5f m e1 m a2 m c2 m cc m 52 m ea m 52 m db m a5 m ac
m a5 m 45 m 4b m 8f m 2f m bd m a7 m 8 m 2b m ea m 29 m 6 m 29 m ae m 55 m 3c m a8 m d8 m af m 38 m a7 m a4 m ac m e4 m a1 m
94 m ae m 54 m a5 m 74 m 41 m 69 m 46 m 99 m a6 m ec m a8 m 9c m a4 m 5c m ae m 7c m 46 m 79 m 5a m 85 m a2 m 62 m af m c2 m
55 m 29 m 57 m 39 m ab m f2 m 94 m 2e m 4b m 77 m a2 m a7 m d0 m 2b m e9 m bd m f4 m 59 m 55 m 45 m 55 m 4f m 55 m a1 m 6a m
bd m ea m 80 m ea m 82 m 9a m b6 m 5a m a8 m 5a m be m 5a m 9b m da m 43 m 75 m 82 m 3a m 43 m 3d m 5e m bd m 5c m bd m 47 m
7d m 56 m 43 m 45 m c3 m 4f m 23 m 4f m a3 m 45 m e3 m 9e m 26 m 5e m 93 m a1 m 99 m a8 m b9 m 57 m b3 m 4f m 73 m 5e m 4b m
5b m 2b m 5c m 6b m ab m 56 m a7 m d6 m 94 m b6 m 9c m b6 m 97 m 76 m ae m 76 m 8b m f6 m 3 m 1d m b2 m 8e m 83 m ce m 1a m 9d
m 6 m 9d m 5b m ba m 18 m 5d m 86 m 6e m b2 m ee m 3e m dd m 1b m 7a m b0 m 9e m 85 m 5e m a2 m 5e m 8d m de m 75 m 7d m 58 m
df m 52 m 9f m notbusy
02 wcmd 8 m 7 m 0 m \ 0x80700 
ab m bf m 4f m 7f m d0 m 0 m 6d m 60 m 6d m c0 m 33 m 68 m 30 m 18 m 31 m 24 m 19 m 3a m 19 m 66 m 1a m b6 m 18 m 8e m 19 m d1
m 8c m 7c m 8d m f2 m 8d m 3a m 8d m 9e m 1b m 6b m 18 m 47 m 19 m ef m 32 m ee m 33 m fe m 68 m 62 m 61 m 92 m 62 m d2 m 68 m
72 m df m 54 m c6 m d4 m db m 34 m df m b4 m db m f4 m 77 m 33 m 3d m 33 m 96 m 59 m 8d m d9 m 2d m 73 m b2 m b9 m bb m f9 m 6
m f3 m 2e m f3 m 17 m cb m f4 m 97 m 71 m 96 m ed m 5f m 76 m c7 m 82 m 62 m e1 m 67 m b1 m d5 m a2 m c7 m e2 m 83 m a5 m 95 m
25 m df m b2 m d5 m 72 m da m 4a m c3 m 2a m d6 m aa m d6 m 6a m 84 m 41 m 65 m 4 m 30 m 4a m 18 m 97 m ad m d1 m d6 m ce m d6
m 1b m ac m 4f m 59 m bf m b5 m b1 m b4 m 11 m d8 m 1c m b7 m f9 m cd m d6 m d0 m 36 m d9 m f6 m 88 m ed m d4 m 72 m ed m e5 m
9c m e5 m 8d m cb m c7 m ed m d4 m ec m 98 m 76 m f5 m 76 m a3 m f6 m 74 m fb m 58 m fb m 3 m f6 m a3 m e m aa m e m 4c m 87 m
6 m 87 m c7 m 8e m ea m 8e m 6c m c7 m 26 m c7 m 49 m 27 m 5d m a7 m 24 m a7 m a3 m 4e m cf m 9d m 4d m 9c m f9 m ce m ed m ce
m f3 m 2e m 36 m 2e m eb m 5c m ce m b9 m 22 m ae m 1e m ae m 45 m ae m 3 m 6e m 32 m 6e m a1 m 6e m d5 m 6e m 8f m dc m d5 m
dc m 13 m dc m 5b m dc m 67 m 3d m 2c m 3c m d6 m 7a m 9c m f3 m 44 m 7b m fa m 78 m ee m f2 m 1c m f1 m 52 m f2 m 62 m 79 m
35 m notbusy
02 wcmd 8 m 8 m 0 m \ 0x80800 
7b m cd m 7a m 5b m 79 m af m f3 m ee m f5 m 21 m f9 m 4 m fb m 54 m fb m 3c m f6 m d5 m f3 m e5 m fb m 76 m fb m c1 m 7e m de
m 7e m bb m fd m 1e m ac m d0 m 5c m c1 m 5b m d1 m e9 m f m fc m bd m fc m 77 m fb m 3f m c m d0 m e m 58 m 13 m f0 m 63 m 20
m 26 m 30 m 20 m b0 m 26 m f0 m 49 m 90 m 69 m 50 m 5e m 50 m 5f m 30 m 25 m 38 m 26 m f8 m 48 m f0 m eb m 10 m e7 m 90 m d2 m
90 m fb m a1 m 3a m a1 m c2 m d0 m 9e m 30 m c9 m b0 m e8 m b0 m e6 m b0 m f9 m 70 m d7 m f0 m b2 m f0 m d1 m 8 m e3 m 88 m 75
m 11 m d7 m 22 m 15 m 22 m b9 m 91 m 5d m 51 m d8 m a8 m b0 m a8 m a6 m a8 m b9 m 95 m 6e m 2b m f7 m ac m 9c m 88 m b6 m 88 m
2e m 8c m 1e m 5e m a5 m bd m 2a m 7b m d5 m 95 m d5 m a m ab m 53 m 56 m 9f m 8e m 91 m 8c m 61 m c6 m 9c m 88 m 45 m c7 m 86
m c7 m 1e m 89 m 7d m cf m f4 m 67 m 36 m 30 m e7 m e2 m bc m e2 m 6a m e3 m 66 m 59 m 2e m ac m bd m ac m 67 m 6c m 47 m 76 m
39 m 7b m 9a m 63 m c7 m 29 m e3 m 4c m c6 m db m c5 m 97 m c5 m 4f m 25 m d8 m 25 m ec m 4e m 98 m 4e m 74 m 48 m ac m 48 m
9c m e1 m ba m 70 m ab m b9 m 2f m 92 m 3c m 93 m ea m 92 m e6 m 93 m fd m 93 m f m 25 m 7f m 4a m 9 m 4f m 69 m 4b m c5 m a5
m c6 m a6 m 9e m e4 m c9 m f0 m 92 m 79 m bd m 69 m ca m 69 m d9 m 69 m 83 m e9 m fa m e9 m 85 m e9 m a3 m 6b m 6c m d6 m ec m
59 m notbusy
02 wcmd 8 m 9 m 0 m \ 0x80900 
33 m cb m f7 m e1 m 37 m 65 m 40 m 19 m ab m 32 m ba m 4 m 54 m d1 m cf m 54 m bf m 50 m 47 m b8 m 45 m 38 m 96 m 69 m 9f m 59
m 93 m f9 m 26 m 2b m 2c m eb m 44 m b6 m 74 m 36 m 2f m bb m 3f m 47 m 2f m 67 m 7b m ce m 64 m ae m 7b m ee m b7 m 6b m 51 m
6b m 59 m 6b m 7b m f2 m 54 m f3 m 36 m e5 m 8d m ad m 73 m 5a m 57 m bf m 1e m 5a m 1f m b7 m be m 67 m 83 m fa m 86 m 82 m d
m 13 m 1b m 3d m 36 m 1e m de m 44 m d8 m 94 m bc m e9 m a7 m 7c m 93 m fc m b2 m fc m 57 m 9b m c3 m 37 m 77 m 17 m 28 m 15 m
6c m 2c m 18 m df m e2 m b1 m a5 2 r 50 m a2 m 90 m 5f m 38 m b2 m d5 m 76 m 6b m dd m 36 m d4 m 36 m ee m b6 m 81 m ed m e6 m
db m ab m b6 m 7f m 2c m 62 m 17 m 5d m 2d m 36 m 29 m ae m 28 m 7e m 5f m c2 m 2a m b9 m fa m 8d m e9 m 37 m 95 m df m 7c m
da m 11 m bf m 63 m a0 m d4 m b2 m 74 m ff m 4e m cc m 4e m de m ce m e1 m 5d m e m bb m e m 97 m 49 m 97 m e5 m 96 m 8d m ef
m f6 m db m dd m 51 m 4e m 2f 2 r 2a m 7f m b5 m 27 m 66 m cf m 95 m 8a m 65 m 15 m 75 m 7b m 9 m 7b m 85 m 7b m 47 m 2b m 7d
m 2b m bb m aa m 34 m aa m 76 m 56 m bd m af m 4e m ac m be m 5d m e3 m 5c m d3 m 56 m ab m 58 m bb m bd m 76 m 7e m 1f m 7b m
df m d0 m 7e m c7 m fd m ad m 75 m 4a m 75 m c5 m 75 m ef m e m 70 m f m dc m a9 m f7 m a8 m ef m 68 m d0 m 6a m a8 m 38 m 88
m notbusy
02 wcmd 8 m a m 0 m \ 0x80a00 
39 m 98 m 79 m f0 m 49 m 63 m 58 m 63 m df m b7 m 8c m 6f m 9b 2 r 14 m 9a m 8a m 9b m 3e m 1c m e2 m 1d m 1a m 3d m 1c m 74 m
b8 m b7 m d9 m aa m b9 m f9 m 88 m e2 m 91 m d2 m 16 m b8 m 45 m d8 m 32 m 7d m 34 m fa m e8 m 8d m ef m 5c m bf m eb m 6a m
35 m 6c m ad m 6f m a3 m b5 m 15 m 1f m 3 m c7 m 84 m c7 m 9e m 7e m 1f m fb m fd m f0 m 71 m 9f m e3 m 3d m 27 m 18 m 27 m 5a
m 7f m d0 m fc m a1 m b6 m 9d m d2 m 5e m d4 m 1 m 75 m e4 m 74 m cc m 76 m 26 m 76 m 8e m 76 m 45 m 76 m d m 9e m f4 m 3e m
d9 m d3 m 6d m db m dd m fe m a3 m d1 m 8f m 87 m 4e m a9 m 9e m aa m 39 m 2d m 7b m ba m f4 m c m e1 m 4c m c1 m 99 m 4f m 67
m 73 m cf m ce m 9d m 4b m 3f m 37 m 73 m 3e m e1 m fc m 78 m 4f m 4c m cf m fd m b m 11 m 17 m 6e m f5 m 6 m f6 m e m 5c m f4
m b9 m 78 m f9 m 92 m fb m a5 m b m 7d m 4e m 7d m 67 m 2f m db m 5d m 3e m 75 m c5 m e6 m ca m c9 m ab m 8c m ab m 9d m d7 m
2c m af m 75 m f4 m 5b m f4 m b7 m ff m 64 m f1 m 53 m fb m 80 m e5 m 40 m c7 m 75 m ab m eb m 5d m 37 m ac m 6f m 74 m f m 2e
m 1f m 3c m 33 m e4 m 30 m 74 m fe m a6 m eb m cd m 4b m b7 m bc m 6e m 5d m bb m bd m e2 m f6 m e0 m 70 m e8 m f0 m 9d m 91 m
e8 m 91 m d1 m 3b m ec m 3b m 53 m 77 m 53 m ee m be m b8 m 97 m 79 m 6f m e1 m fe m c6 m 7 m e8 m 7 m 45 m f m a5 m 1e m 56 m
notbusy
02 wcmd 8 m b m 0 m \ 0x80b00 
3c m 52 m 7c m d4 m f0 m b3 m ee m cf m 6d m a3 m 96 m a3 m a7 m c7 m 5c m c7 m fa m 1f m 7 m 3f m be m 3f m ce m 1a m 7f m f6
m 4b m c6 m 2f m ef m 27 m a m 9e m 90 m 9f m 54 m 4c m aa m 4c m 36 m 4f m 99 m 4d m 9d m 9a m 76 m 9f m be m f1 m 74 m e5 m
d3 m 89 m 67 m e9 m cf m 16 m 66 m a m 7f m 95 m fe m b5 m f6 m b9 m ce m f3 m 1f m 7e m 73 m fc m ad m 7f m 36 m 62 m 76 m e2
m 5 m ff m c5 m a7 m df m 4b m 5e m ca m bf m 3c m f4 m 6a m d9 m ab m 9e m b9 m 80 m b9 m 47 m af m 53 m 5f m 2f m cc m 17 m
bd m 91 m 7f m 73 m f8 m 2d m e3 m 6d m df m bb m f0 m 77 m 93 m b m 59 m ef m b1 m ef m 2b m 3f m e8 m 7e m e8 m fe m e8 m f3
m f1 m c1 m a7 m d4 m 4f m 9f m fe m 5 m 3 m 98 m f3 m fc m 91 m c0 m 5a m db m 0 2 r 3 m 0 m 50 m 4c m 54 m 45 m f0 3 r da m
dc m b5 m a7 m c9 m 92 m 7f m b4 m 94 m 64 m a1 m a5 m 59 m 82 m 84 m 59 m 6d m 6e m 5b 3 r 52 m 4c m 55 m 45 m 3a m 4d m 37 m
29 m 42 m 22 2 r 37 m 19 2 r 24 m 10 3 r 0 3 r 24 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39
m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2
r 39 m 0 m notbusy
02 wcmd 8 m c m 0 m \ 0x80c00 
0 m 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r notbusy
02 wcmd 8 m d m 0 m \ 0x80d00 
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m notbusy
02 wcmd 8 m e m 0 m \ 0x80e00 
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r
39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m
0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r 39 m 0 2 r d9 m 9d m 75 m 93 m 0 3 r 9 m 70 m 48 m 59 m 73 m 0 2 r b m 13 m 0 2 r b m
13 m 1 m 0 m 9a m 9c m 18 m 0 3 r 7 m 74 m 49 m 4d m 45 m 7 m e4 m 5 m a m 1 m 37 2 r cf m 24 m f3 m 2c m 0 2 r 1c m 53 m 49 m
44 m 41 m 54 m 78 m da m ed m 9d m 89 m 7a m e3 m 38 m ae m 46 m 25 m 71 m df m 94 m f7 m 7f m db m 4b m 70 m 5 m 48 m 4a m 96
m d3 m d5 m 77 m d2 m 29 m 33 m df m 4c m a7 m 12 m c7 m b m 8f m 7e m 0 m 4 m 41 m 68 m fb m fa m 8c m 9f m 34 m b6 m cf m 14
m 7c m 78 m 7c m notbusy
02 wcmd 8 m f m 0 m \ 0x80f00 
c6 m 87 m c7 m 87 m c7 m 67 m 7c m 78 m 7c m 78 m 7c m c6 m 87 m c7 m 87 m c7 m 67 m 7c m 78 m 7c m 78 m 7c m c6 m 7f m 96 m
c7 m 89 m c6 m 8f m fa m 40 m 3f m f0 m 2d m fd m bb m 3c m ce m f5 m f8 m 49 m 34 m fe m c3 m 40 m b6 m 3f m 2 m e3 m a7 m cc
m c1 m 4f m 15 m ed m bf m c3 m 3 m cf m 7d m f0 m de m 59 m 6b m 9d m f3 m 21 m fc m 98 m 59 m 88 m 6f m c0 m 5b m ad m b5 m
71 m ff m 93 m b7 m f2 m 27 m 2e m d0 m ed 2 r 57 m b m de m 19 m ad m 15 m 1a m da m 58 m 17 m 7e m 0 m 11 m c0 m a1 m d8 m
be m 1f m 5c m fb m f6 m 4e m 5e m bf m a7 m e7 m ef m fc m ee m 81 m 7f m c8 m 68 m 6c m ef m d1 m 8 m 91 m 85 m 1a m 87 m 54
m 52 m 2a m 6d m c3 m ff m 98 m 8 m e0 m 90 m fb m 6 m 5f m 47 m 5 m f2 m 60 m 56 m 1e m cf m dd 2 r 3 m ff m 98 m 19 m df m
de m a0 m b1 m 84 m 51 m 99 m c4 m a1 m ab m 4a m fe m b8 m 11 m b8 m fc m d m fd m 77 m d0 m 7b m 1e m db m 61 m d3 m 2f m 1f
m 4c m ca m e3 m a9 m bb m 99 m e4 m 76 m b1 m 5a m 34 m 41 m da m 98 m 6f m cc m c7 m f6 m 9c m 86 m bd m 84 m 91 m 25 m 12 m
87 m b2 m fe m cf m 12 m b9 m 9e m a8 m f9 m 17 m 51 m 1e m 2c m a9 m 3 m 80 m c8 m aa m d6 m 10 m b2 m 83 m bb m 11 m 95 m d1
m 52 m c8 m a4 m a8 m f3 m b9 m 73 m 18 m 7f m 15 m 9f m 25 m cf m 41 m 9a m 7 m 59 m 99 m b8 m 37 m e7 m 63 m 7b m 38 m 27 m
notbusy
20 wcmd 8 m 10 m 0 m notbusy \ 0x81000
02 wcmd 8 m 10 m 0 m \ 0x81000 
fe m 8e m 46 m c5 m 21 m e3 m e7 m 32 m 7f m 92 m c8 m e5 m 95 m bb m fa m c5 m 79 m aa m 7d m 2f m 40 m b6 m c3 m 17 m 67 2 r
c1 m bd m 87 m fe m 40 m fa m 57 m f1 m 5b m ab m c5 m 1 m 83 m e9 m 70 m f3 m b6 m e1 m b9 m 8c m 12 m 3c m e m 45 m c9 m a5
m e7 m b3 m 5a m 92 m 51 m 81 m 44 m 24 m ef m 11 m d9 m 1e m d2 m 50 m f7 m a3 m 1 m e9 m 44 m fe m c5 m f0 m 35 m 5f m f7 m
3e m 8c m 53 m 7b m 6c m db m 5e m bf m 5c m d6 m b4 m 3c m a2 m 7f m 67 m dd m bf m f m 4f m 78 m 9e m 4e m cb m a3 m 8c m 1b
m 20 m 30 m e5 m 8a m 97 m 21 m dd m 39 m f0 m 35 m 72 m c2 m d1 m 80 m a8 m b7 m e6 m 63 m 7b m 30 m 25 m 60 m a9 m e0 m eb m
6 m 86 m 2a m 2c m e2 m 97 m b8 m 26 m 72 m 7f m a5 m ac m 44 m 10 m ac m 2a m 6e m 89 m 3a m a m ab m 58 m bc m a2 m b3 m 79
m ec m 3f m 6d m 30 m b6 m c2 m c3 m f2 m e2 m 50 m 94 m 1f m fc m 49 m fe m b3 m 74 m d1 m b3 m ca m e3 m 30 m 14 m 2f m d1 m
80 m 91 m bc m d m e1 m 48 m f8 m 36 m e1 m 18 m 91 m bc m 41 m 64 m 7b m 7d m 81 m 42 m 78 m ab m 5f m e9 m a3 m cb m 43 m 5c
m 11 m b9 m 77 m 9b m f3 m 6f m e0 m 83 m 32 m 98 m cc m 43 m d m 76 m c9 m f1 m 23 m 4f m f3 m 21 m f1 m cc m 84 m d m c6 m
9e m ff m 1f m 7e m e1 m 2a m 8e m 7d m 4f m 53 m 5d m c2 m 75 m e7 m ab m 47 m 1 m b3 m df m e4 m 71 m 1c m 7c m 92 m 51 m 57
m notbusy
02 wcmd 8 m 11 m 0 m \ 0x81100 
87 m e1 m 68 m 28 m f2 m c0 m b0 m c6 m 81 m 87 m d m f m 81 m 6c m 2f m c5 m 1 m 34 m 1e m e8 m 43 m 75 m 7d m c0 m 50 m 6e m
b2 m ee m e7 m 93 m 80 m 91 m fc m 48 m d7 m 69 m b7 m f8 m c2 m d m f5 m c7 m 30 m b8 m eb m 33 m e3 m 37 m a4 m 8f m 38 m 63
m 41 m f5 m c7 m b1 m e2 m d6 m e2 m fc m 73 m c6 m a4 m d m 45 m 2f m ce m 88 m ce m 63 m 8a m ca m aa m 8a m e2 m c3 m cc m
8e m 81 m 58 m cc m c3 m 8b m 17 m fa m e8 m 6e m e4 m 1f m f1 m 48 m e2 m 78 m 5 m 63 m d0 m 87 m 6c m 48 m 68 m c0 m 92 m 27
m a3 m 5e m 9a m 4f m fc m 73 m 54 m 47 m 9b m 77 m 8e m cc m 12 m 9e m 65 m f8 m 95 m 6f m b3 m e6 m b7 m 3e m c0 m 9f m 1b m
c4 m ed m c8 m fe m c4 m 6b m 96 m ff m 99 m 7d m 5 m 4c m 34 m d2 m 47 m 12 m 62 m 4f m 40 m 94 m 6b m 3a m e3 m 50 m f2 m 40
m 3c m 34 m e1 m 61 m 18 m 2f m 97 m 21 m 6 m 32 m c m f3 m 48 m 22 m db m 3 m 71 m bc m 46 m 32 m eb m 3 m 86 m a3 m ab m e4
m 78 m 69 m a m 2e m 94 m d m 4b m d3 m 14 m 5f m 8c m fc m 3c m 7e m 27 m fa m 6c m f6 m 27 m 1a m 70 m 44 m d7 m 10 m aa m
ed m 71 m d9 m 5c m 25 m 83 m c5 m e3 m 4f m 25 m 7e m 98 m cd m 9f m a7 m 22 m 3a m 54 m 7e m 39 m 6b m 14 m e2 m 21 m 2a m
8d m f4 m 5e m b3 m d5 m cd m d6 m 2a m ae m 26 m 2c m 43 m 6 m 8b m f0 m 70 m c6 m a6 m 61 m 52 m e2 m 42 m 26 m 2c m 6a m 2
m notbusy
02 wcmd 8 m 12 m 0 m \ 0x81200 
f2 m 48 m 22 m db m 1d m e m 6f m ae m 60 m c0 m db m 2b m 23 m 2d m 81 m b0 m 3a m a m 12 m a6 m ad m eb m d7 m 6e m 7c m ae
m 14 m 2c m 72 m c6 m 4d m 98 m 23 m d5 m 18 m bd m 48 m 2e m 3d m e1 m 81 m 2f m ef m f6 m 44 m 6d m c9 m 47 m 67 m 3a m fd m
81 m dd m bb m 3e m e2 m 84 m b9 m 63 m e2 m e1 m 10 m 62 m 5d m 78 m 68 m c4 m 83 m 87 m b2 m ee m 15 m 2c m d m 51 m 82 m d5
m 38 m d3 m c6 m 96 m f m 90 m 43 m 2c m ca m c3 m d2 m 91 m 97 m 22 m d3 m 55 m ab m 1f m 48 m 64 m 7b m 61 m ab m 16 m 40 m
20 m 5d m e5 m bc m f3 m 65 m b8 m f4 m 6 2 r 63 m 95 m 71 m 58 m eb m aa m e2 m bd m ac m 57 m 17 m e3 m 93 m 42 m e2 m 75 m
9b m 82 m 1c m 4 m 24 m fe m 97 m af m e6 m dc m 4c m 38 m 36 m 5e m 63 m 27 m cc m 23 m fa m 6f m 42 m 8e m b9 m 14 m ad m 31
m 64 m c1 m ec m cc m 43 m 84 m 9c m 9f m e3 m ac m c m 9e m 81 m a4 m cf m 48 m 22 m ac m 5b m 1e m f0 m 68 m b5 m 4 m e2 m
5f m 1 m d9 m ae m 97 m 3f m f6 m 12 m 46 m c2 m 91 m bf m 1a m 13 m a3 m 8 m 10 m 2e m 6d m 7a m 97 m d5 m 8d m 8a m 2e m 76
m 26 m 9d m 1f m 4c m 53 m c6 m 71 m 30 m 83 m bc m 33 m f6 m da m 7b m 75 m b4 m f4 m 9a m 1f m 7e m 69 m 8f m ce m c3 m 9e 2
r 4f m 56 m cd m 1b m c4 m 63 m 87 m c9 m 1f m 78 m c8 m b4 m d6 m aa m ea m 80 m 91 m 2f m 91 m 33 m f1 m 50 m 17 m 3c m c2 m
notbusy
02 wcmd 8 m 13 m 0 m \ 0x81300 
82 m 47 m 9a m 90 m 19 m c8 m 14 m bb m 3f m e3 m 81 m 5d m 7 m 46 m a2 m 13 m 8c m 3e m 10 m 12 m f m 6f m a0 m fb m 8e m 82
m a3 m 24 m 7e m 31 m e m 88 m 4e m ca m 8f m 5b m fc m 5a m 97 m 0 m c9 m b9 m 94 m 37 m 30 m 5b m ff m 73 m 98 m e3 m 2a m
10 m 51 m 7d m 33 m c3 m 3c m 2c m 46 m 97 m af m 73 m 47 m 78 m 24 m 81 m 44 m 1e m 6c m 6f m 3c m 74 m c2 m a1 m 79 m e7 m
c1 m 4c m 89 m f9 m cd m 35 m 8f m b m 20 m 71 m 42 m 46 m 1c m 11 m 88 m bd m 7 m b2 m bd m c4 m 51 m 61 m 48 m 65 m 6 m 1a m
5d m 27 m 65 m 18 m 55 m 71 m 70 m 5b m df m a2 m 4f m 66 m 9b m e0 m 88 m eb m 38 m eb m 30 m 8f m 16 m e2 m 48 m db m f2 m
b2 m 1 m 4f m dd m 9e m 67 m e5 m d4 m fb m 6a m 1c m c5 m ed m 7a m de m 79 m 38 m f2 m d8 m 23 m 5b m ee m e8 m 17 m f6 m 41
m 20 m 30 m fb m 3b m 8e m 77 m c1 m 2e m 21 m 1c m 4c m f8 m 5b m 1e m 5f m 64 m 4f m c8 m b9 m 7b m 22 m 30 m 9f m c6 m df m
1 m d9 m 2e m 73 m 6c m 9a m e8 m 43 m 4a m 3d m d3 m 48 m 20 m 4a m be m e m 36 m a8 m a2 m e5 m cd m 44 m e m 53 m df m 98 m
4b m ea m e0 m 74 m 88 m 6a m c8 m f2 m ab m d9 m b6 m 42 m 16 m d5 m 60 m 9d m f4 m f2 m de m 75 m 96 m 19 m 5b m f2 m a8 m
ea m 9 m 12 m f3 m 10 m 1b m 9a m 79 m 9f m 81 m c5 m 60 m 6a m 10 m 8 m b8 m be m 7d m ef m eb m 41 m 6f m a8 m 3c m 18 m b3
m f7 m notbusy
02 wcmd 8 m 14 m 0 m \ 0x81400 
3c m 86 m 85 m d5 m e8 m 4b m f4 m c m e4 m 36 m 73 m b9 m 3d m c4 m a1 m cd m 92 m 6 m d9 m 1c m 84 m b m 24 m 59 m ad 2 r e1
m 48 m 56 m 5b m f2 m 71 m 58 m 24 m 10 m f0 m 14 m 2d m be m d1 m 6d m 45 m a6 m 76 m 3c m 75 m f9 m 33 m a8 m 85 m b1 m 82 m
ff m 65 m 5a m 10 m 7b m 75 m 1e m 84 m 5d m 59 m 9d m c7 m 8f m 45 m 4 m a2 m 73 m f2 m e1 m d8 m f6 m 96 m 2f m 1 m 37 m 41
m 70 m 30 m f9 m 82 m c7 m c8 m 4 m 13 m 71 m f1 m 4b m f m 6 m 2b m e m 77 m d m 64 m 7b m 84 m 63 m 65 m aa m 86 m 9d m 5a m
b2 m 7 m 50 m 74 m 9b m d7 m 60 m 7a m c2 m c1 m 4c m 41 m 95 m 2d m 53 m 5f m 21 m 33 m 6d m 2a m f m ea m 29 m d2 m 72 m 9f
m 3a m f3 m b4 m d8 m c8 m df m d4 m e4 m 3a m a m b0 m 1c m 7e m 70 m 35 m 68 m 10 m a2 m 10 m 8f m 9e m 78 m 28 m 1e m 81 m
0 m 11 m e5 m a3 m 99 m 1e m cc m 55 m c m b1 m fc m 6b m 1e m 84 m a m 95 m 8 m de m 13 m d1 m af m 81 m 6c m 2f m 5c m 79 m
6 m b2 m a4 m 31 m 25 m 15 m 1a m 11 m 8c m e3 m b4 m 13 m e m 7e m 10 m 1e m dd m 5c m c5 m 29 m a9 m eb m 66 m 7f m 10 m 7d
m a4 m 4 m 87 m a4 m 61 m ae m d6 m bc m 64 m 47 m 78 m 8d m e2 m 7a m 80 m e5 m 4c m de m 8 m a9 m f3 m 5e m d7 m d9 m 1a m
5b m 2c m 6 m 88 m 20 m e m 2 m b m 25 m c0 m b0 m 47 m 73 m 65 m f8 m 41 m 81 m 98 m 14 m f0 m 3e m e0 m 81 m f2 m notbusy
02 wcmd 8 m 15 m 0 m \ 0x81500 
10 m 58 m 21 m 44 m 22 m 65 m 4a m 2f m bd m fa m f6 m 3d m 1c m 7e m b9 m 5f m 8e m cc m 56 m c3 m b1 m b0 m 56 m 3c m ca m
c0 m 9a m 96 m 71 m 25 m 1 m a7 m 2a m 97 m b2 m 25 m 38 m 76 m 11 m 3f m 80 m c7 m 3f m d9 m a2 m 5 m b5 m 6a m cb m fa m 68
m 3c m 7a m 80 m e5 m d4 m b6 m 51 m 73 m 55 m 3f m 1a m 12 m de m 91 m c3 m db m f4 m 79 m f3 m 26 m 9 m f0 m 0 m 6 m 18 m 9
m a8 m cf m c1 m 7a m f0 m 25 m 8f m 95 m cd m 2 m 20 m ce m c m fa m d0 m 79 m 69 m f8 m 9a m c7 m a m c7 m 6c m ab m 7c m 78
m b1 m 6d m 7 m ef m a7 m 6c m 8 m 19 m be m e0 m a1 m ac m b1 m 8d m 7 m 4e m 20 m e5 m bd m 85 m bc m fa m 20 m f1 m 6a m 7c
m b8 m a6 m ea m 88 m 1a m 53 m a3 m 3e m 7a m 80 m e5 m aa m 76 m 4a m ee m aa m e6 m 5 m 35 m 16 m c8 m d1 m 82 m 55 m df m
d2 m 8d m 91 m c7 m a0 m f m 48 m 45 m be m d4 m c7 m 6c m b6 m 1b m 10 m 18 m 4d m 22 m 6d m 5a m 2f m 80 m cc m 3c m ec m 88
m 63 m 16 m c7 m ed m 3e m 46 m 91 m 48 m 71 m b1 m 53 m 6c m 95 m d3 m d m 48 m 1f m 81 m 23 m 1e m 4c m d8 m cc m 43 m 52 m
7d m 30 m eb m b0 m 3c m b6 m dd m 0 m f m b6 m a5 m d m c1 m c6 m 3 m 5 m 58 m ee m e8 m fa m 80 m 9 m ad m 9e m 51 m 63 m 81
m 1c m 93 m fb m cb m fa m 38 m d2 m 17 m 36 m 58 m 2e m be m 61 m 7b m c9 m 63 m 51 m c4 m 10 m aa m 44 m 5c m 56 m 48 m
notbusy
02 wcmd 8 m 16 m 0 m \ 0x81600 
91 m 88 m 7e m 5 m 64 m 1b m e7 m d2 m d m 38 m ae m c4 m f1 m 64 m d3 m 1b m 76 m 30 m 86 m 48 m b7 m fc m c7 m 74 m 7d m 78
m e4 m 3e m 62 m c4 m 9b m d3 m 4a m 27 m a7 m fa m 38 m b4 m b3 m d4 m 5a m 81 m c9 m 2b m b9 m f5 m 4d m 54 m 1e m ba m e7 m
4b m fa m de m d4 m ce m 3 m ca m a2 m 69 m 2d m 6 m 7d m 58 m b0 m a8 m 2c m ef m 21 m ba m 95 m 3e m 64 m d2 m c7 m a5 m bd
m 42 m 10 m ea m 40 m 46 m bb m cd m 5f m 76 m eb m af m 4c m d6 m 36 m 86 m 56 m 14 m 87 m be m c0 m f1 m a8 m 28 m 24 m 5d m
b1 m 7c m 39 m b4 m 69 m b9 m 53 m 77 m 10 m 1e m 39 m 41 m 61 m 19 m d5 m c7 m a1 m 1c m a m 76 m b7 m c3 m 0 m f m 5e m 93 m
b9 m aa m f2 m e8 m 1 m 16 m 84 m be m c5 m 5c m ed m b2 m 87 m 1c m 10 m 61 m 49 m ca m c3 m d5 m f5 m 39 m a4 m 54 m 60 m de
m a3 m 5e m a9 m 42 m a2 m fc m ae m f5 m 81 m ab m d2 m 5a 2 r 15 m a m 19 m 7c m 3 m 52 m e6 m 10 m 6c m 16 m d2 m c7 m 1a m
c8 m 76 m eb m 3c m 26 m 75 m f8 m f0 m b8 m 72 m 2c m 1b m bf m 35 m e m 6 m c5 m 30 m 55 m 41 m 84 m 47 m c m 73 m ce m fa m
c3 m 9d m 4 m 58 m 38 m 50 m 95 m f0 m 69 m 54 m c5 m 51 m 56 m 27 m 30 m 29 m 2d m c0 m 52 m 68 m 2b m 5d m e3 m 7d m 3e m ec
m 40 m 92 m 3f m 17 m 3b m da m ae m 85 m 79 m e7 m 83 m b9 m 8a m 4b m c2 m ec m e m 16 m 3c m ea m eb m da m 94 m 2b m
notbusy
02 wcmd 8 m 17 m 0 m \ 0x81700 
a2 m 1b m 52 m e0 m 77 m 91 m 3e m aa m 13 m b9 m 7 m b2 m dd m 3a m 8f m ef m e2 m 88 m cf m 95 m 9f m 4f m 8d m 20 m ea m fe
m 41 m e7 m a1 m 9 m 8f m 23 m ef m 85 m aa m 1 m 47 m 5c m b9 m 1f m 54 m 1e m 5a m b5 m bd m d9 m c3 m 34 m 1e m 2d m c0 m
12 m 5b m dd m c m 49 m cb m 77 m a2 m 7f m 86 m 79 m 18 m b2 m fb m 1 m fa m 10 m a3 m 3e m 98 m 82 m 4 m 2f m d1 m 87 m 44 m
e5 m 76 m 11 m c6 m b4 m 19 m 95 m f7 m 3f m c0 m c7 m 61 m 24 m 90 m 3f m 79 m a1 m 90 m ed m ce m 5a m d9 m 94 m 9d m fa m e
m 8e m fa m 7c m 93 m 37 m 67 m dd m 81 m 14 m 1e m 92 m f2 m 60 m 29 m c2 m 8a m 73 m 42 m d m 16 m c7 m 6b m 73 m 1e m a3 m
c m 51 m 69 m 44 m 77 m 5e m 77 m 54 m 42 m f m b0 m 78 m c3 m 91 m b6 m d2 m c9 m 52 m 97 m 23 m 1e 2 r bd m 3c m 4b m 89 m
75 m 23 m 46 m 1c m d1 m 60 m 25 m 7d m c8 m 81 m 47 m db m b9 m 2a m 38 m e0 m 6b m d8 m ae m 1d m ae m e8 m 4 m 44 m df m 1
m a1 m 3c m cc m 84 m 63 m 8a m ab m de m aa m d6 m 41 m e6 m 8a m 9 m 85 m f4 m 1 m e m a4 m 44 m 60 m 9c m f2 m 88 m 1e m 3d
m 80 m 3b m a7 m fa m d8 m 39 m 4e m 74 m c4 m f m 7e m 94 m d0 m a m 66 m 5d m 76 m 1e m 2d m c0 m aa m 42 m 89 m f m 3a m 3c
m e2 m 1 m e m 44 m 74 m 1e m de m f2 m 91 m 87 m 95 m 59 m 1f m 7 m 2 m 62 m 57 m 3c m ea m 76 m 7c m c7 m b1 m 2a m notbusy
02 wcmd 8 m 18 m 0 m \ 0x81800 
69 m 18 m c2 m 53 m a3 m 86 m 4b m 7e m 0 m b2 m 5d m cb m c3 m 96 m ec m ed m 37 m 71 m 24 m 5b m 84 m 6b m 32 m d2 m fe m 1a
m cb m 48 m 98 m 4a m e m 3d m e5 m 71 m 7 m 1e m 71 2 r 12 m 20 m e6 m a2 m 79 m 2a m c6 m 69 m a6 m a4 m e3 m d8 m 8e m b6 m
5 m 1c m bc m 69 m fb m e7 m dd m 5c m ed m 1e m e7 m fe m 28 m f m 67 m d0 m cb m f3 m cc m a3 m 6e m e0 m 22 m 7 m a2 m 2f m
78 m b8 m 46 m 63 m a9 m f m b9 m d8 m a3 m 98 m 80 m dc m f0 m 20 m f2 m 30 m a3 m b1 m 7a m 1f m 7 m 8e m ae m 84 m 71 m aa
m e1 m 88 m c3 m 94 m 52 m ca m 89 m 47 m 14 m 88 m 9f m dc m f9 m 7e m 2c m 76 m 3e m aa m ab m 68 m 75 m c3 m e1 m 54 m 3b m
e6 m 91 m c1 m 1d m e1 m a4 m f1 m 7c m e7 m 11 m 2c m e6 m 21 m 1b m f m 36 m 0 m 11 m 69 m 29 m 21 m e8 m fe m 79 m c m 7e m
2e m 60 m 50 m 85 m c m a9 m 58 m 3b m 0 m a1 m 67 m 23 m b6 m 2b m 79 m 98 m 85 m 3a m de m 2e m 37 m 47 m e6 m 4a m 5a m a7
m 21 m cc m e7 m e5 m 2b m fa m ba m 92 m 43 m 1f m 70 m ec m 4c m 39 2 r e2 m 88 m 6 m 6b m 91 m da m cd m f3 m d m 9 m ec m
18 m 6e m 6a m c1 m d9 m d1 m e2 m dd m fd m 86 m 87 m ec m 45 m 27 m 6 m f3 m d0 m 99 m 87 m 9e m f5 m 91 m 12 m a0 m 23 m f
m af m 90 m 38 m 66 m 83 m d5 m 15 m 32 m d8 m ac m 21 m 66 m d2 m 64 m 66 m b7 m 2b m 79 m 58 m ef m 31 m 90 m 19 m notbusy
02 wcmd 8 m 19 m 0 m \ 0x81900 
c7 m ab m d2 m fa m c1 m 7d m 40 m ce m 57 m 16 m 18 m 89 m 4f m 5e m 11 m 9e m fe m 98 m 86 m 30 m 7c m d2 m c7 m ce m 26 m
18 m 65 m ca m a5 m 72 m 46 m 22 m 12 m 23 m 8f m ed m 29 m f m 58 m 87 m 5b m c4 m 3 m e7 m 15 m d5 m c0 m 43 m f m b6 m ea m
42 m 1f m ad m d6 m e7 m e m 8 m f1 m e9 m db m b5 m 3c m f2 m ce m b8 m 5f m e1 m 78 m 72 m dc m 61 m 70 m 1f m 60 m 46 m f3
m 4e m 4f m 41 m 52 m c m d6 m cc m 23 m c6 m 52 m 6c m d6 m 7 m bb m 30 m 57 m 87 m e2 m 23 m 8b m 81 m 7 m 23 m 3c 2 r e2 m
c1 m 8 m f m 48 m d5 m 60 m 1e m 82 m d m 6 m b m 7d m 1a m 13 m 62 m f4 m 2b m e0 m b m 21 m 59 m 96 m c4 m 3d m 50 m 88 m 5b
m f3 m b0 m a3 m 3c m 2a m 90 m 88 m 24 m cc m a5 m 6d m 16 m 95 m 91 m c2 m 6a m 79 m cc m f9 m 92 m d5 m 47 m 5c m e6 m 41 m
20 m 5e m 8d m 55 m f6 m e8 m c9 m 60 m b9 m 59 m 1f m 2c m 99 m ab m 1 m c8 m 31 m a9 m 23 m af m 5 m e5 m 2 m 6 m 1d m 8c m
bc m 75 m 6f m 3a m f m 4e m 78 m c0 m bc m 60 m 1e m a m ed m 13 m 72 m 33 m f0 m 48 m 8b m 11 m 31 m 8c m 9b m a2 m 51 m 7b
m 7 m 4 m cd m ee m 76 m b1 m 34 m 77 m e m 1 m 41 m 38 m e6 m 73 m 39 m ad m 5a m 34 m ae m 48 m 51 m aa m 71 m 70 m e7 m 32
m 9d m 35 m 2c m 5b m 6f m 19 m 49 m 36 m 58 m b m 1e m 87 m 98 m cd m d5 m 88 m a7 m e2 m 10 m 17 m 38 m 2e m f5 m notbusy
02 wcmd 8 m 1a m 0 m \ 0x81a00 
1 m 47 m 3 m 5a m dc m 1c m 79 m 20 m 73 m 15 m dd m 10 m 4 m b6 m 35 m be m 32 m 12 m 19 m 2c m 3d m f0 m 88 m de m 6a m d4 m
87 m 80 m 34 m 49 m 1a m 25 m 71 m 82 m f4 m 31 m 2d m 44 m d4 m 45 m 8c m b5 m dd m 78 m f3 m 4e m 4 m 5d m f3 m e3 m 21 m 29
m 74 m f4 m 3 m de m 52 m 8d m 75 m d2 m 43 m 5 m ce m b0 m 47 m 7d m 78 m d3 m d m 16 m 7c m 44 m b7 m e6 m b1 m f3 m 85 m 3e
m 56 m 38 m e2 m b2 m fd m a5 m 3a m ee m 78 m 48 m c2 m c3 m e6 m bd m 34 m 5b m 57 m 88 m 56 m f m 6 m b m 15 m 65 m e8 m 24
m 7d m 2 m 43 m e3 m 7d m 89 m 5a m fe m 84 m ce m 81 m c m 61 m af m 5c m b m 64 m 5b m 9b m 2b m d3 m f5 m e1 m 3d m aa m 32
m c m ce m 5c m 9e m 36 m 90 m 79 m a1 m da m 56 m 3 m 24 m bc m d2 m 69 m 23 m c0 m cb m a6 m f m d8 m 90 m 83 m 47 m ae m f4
m 71 m 54 m 7d m 1c m 2b m 7d m b4 m b8 m 89 m 2b m fd m 0 m c7 m e0 m cf m 31 m f m 85 m 79 m 40 m 92 m 38 m 15 m 88 m 94 m
ed m 63 m 86 m ca m e2 m b2 m c1 m c2 m 8b m 29 m 91 m 92 m d5 m 8d m 6 m da m 24 m b2 m 25 m 8d m a8 m c7 m 43 m 7 m c3 m c2
m 50 m 2c m 5 m b2 m 5d m 44 m 57 m a8 m 8e m c7 m b5 m 9d m d5 m 18 m 9c m 5c m c3 m 68 m 40 m 6a m 6d m fb m e9 m 28 m f m
30 m 58 m 96 m 6 m 91 m 60 m b1 m af m 70 m 1c m 4b m 27 m be m 6f m c m 22 m 24 m b8 m 64 m 8c m 7d m 84 m 63 m e0 m notbusy
02 wcmd 8 m 1b m 0 m \ 0x81b00 
11 m 50 m 4d m 83 m c1 m 3c m 20 m b1 m 9c m 26 m 8a m 55 m 1e m 76 m 30 m 58 m b8 m 7e m 97 m e0 m 90 m a6 m a7 m 32 m 72 m
c2 m 6a m 51 m a2 m a8 m dd m b5 m c5 m 32 m 3 m 8f m b4 m 77 m 30 m 24 m 12 m 3b m 90 m 86 m c3 m de m 1f m 8d m 6a m 40 m 44
m 4e m 60 m e0 m 70 m 17 m 2a m 4e m 5c m 9c m 47 m de m f5 m 1 m 4b m 92 m 70 m a5 m 8f m ac m 87 m d5 m 22 m 50 m d9 m 7c m
e5 m 44 m 3b m 7d m 3c m c1 m b1 m ed m 23 m 8f m 46 m 19 m 8a m e m f m 74 m 3a m 2a m c0 m 44 m b5 m 70 m 37 m 7e m 8b m 37
m 41 m c m d6 m 87 m e4 m 8 2 r 5c m bd m 7d m 6d m 60 m fb m d6 m a0 m be m 71 m e9 m 4e m 2d m d7 m 20 m db m 3a m 57 m e2 m
6a m 9c m 1b m 5f m a8 m 59 m 2b m 73 2 r f4 m 83 m d6 m 52 m e7 m 24 m 2d m e5 m 1 m 1f m 2f m 6d m fc m 60 m 1b m e0 m 9 m f
m 36 m 2 m 91 m b m 1e m 91 m 62 m de m f0 m d6 m 6c m 7b m c6 m c3 m f m f1 m 55 m ab m 71 m 77 m b8 m 5a m 34 m 5e m 43 m 1e
m a6 m 4c m 74 m 1e m 96 m 1a m 2c m 46 m f7 m d5 m a m e m 99 m 96 m 6 m 68 m a9 m d6 m 80 2 r cd m c2 m 67 m 72 m 28 m 8f m
75 m c8 m bb m ad m f7 m 5 m 51 m 1 m 62 m 68 m 3c m 6e m cf m aa m d m f5 m d4 m a0 m 7e m b4 m 37 m c8 m ac m 77 m 8a m e5 m
fc m 55 m 56 m 48 m b6 m 1 m 8e m ac m cf m f9 m 80 m e3 m 50 m 4b m 7d m d8 m a4 m 10 m 33 m fa m f2 m 43 m 48 m notbusy
02 wcmd 8 m 1c m 0 m \ 0x81c00 
76 m c1 m 83 m 9c m 7a m 68 m fb m 1f m c m e m 7b m ee m 88 m 47 m 9a m cd m fa m 7e m 4 m b0 m c1 m 39 m 2c m cb m c6 m b2 m
be m 8e m c3 m b7 m 5a m b4 m 40 m 6a m 19 m 30 m 10 m e3 m af m 79 m d8 m 89 m 87 m 5d m f3 m 70 m a8 m c2 m 59 m 3d m d6 m
47 m 6 m 82 m 79 m 48 m 5d m 83 m 5f m 12 m b4 m c4 m cf m 82 m 13 m 48 m 18 m 7 m 1c m c4 m d4 m c7 m a2 m 9c m 3d m d7 m 34
m 41 m 19 m 1b m 19 m c2 m 5c m 59 m 30 m bc m ff m 11 m bc m e9 m cb m 8f m 13 m ca m 7f m fa m f2 m 23 m 45 m 57 m 4d m 30 m
c0 m 43 m 11 m 83 m c5 m c6 m bd m e7 m 7c m 32 m 6f m 2a m b m ec m 44 m a2 m b m 42 m e m 24 m f8 m 4b m 1e m 66 m e2 m 61 m
2e m 78 m a0 m 58 m 57 m df m 9f m 56 m 1b m 4d m 96 m 33 m cb m ad m 41 m 4e m 3d m 3a m e6 m a1 m 18 m 8d m af m 98 m 59 m
38 m f4 m 23 m 6d m f2 m 18 m a3 m a8 m 3c m 54 m 8a m fc m f9 m 8a m 87 m a2 m 3c m 9a m 53 m 92 m c0 m a3 m e9 m 43 m 45 m
1e m 71 m 22 m 9b m 46 m 65 m f2 m ed m c8 m 60 m e9 m 49 m 1f m 11 m 88 m 21 m 85 m 68 m 41 m 97 m 85 m 58 m ab m 65 m c0 m
a5 m 57 m 29 m 7e m 6b m f3 m ba m 5e m 12 m be m e4 m 81 m 56 m 82 m e6 m d5 m 59 m 67 m 72 m 3c m 8a m eb m d7 m 3c m d4 m
c0 m 43 m 50 m 7d m 8 m 5a m ff m 5c m 5 m 12 m 3f m 6d m bc m 4 m e5 m 2 m 87 m d9 m 57 m b m 42 m 4e m ce m 6a m 74 m cd m
a9 m 13 m notbusy
02 wcmd 8 m 1d m 0 m \ 0x81d00 
d6 m ea m 9d m 47 m 7c m 52 m 94 m 7f m 7 m 1e m d8 m 81 m 30 m 39 m eb m 83 m 1b m 4c m c3 m eb m b6 m 42 m 57 m 75 m 63 m d0
m 48 m cc m 23 m 5c m f2 m f0 m 98 m 47 m 2a m 1d m bf m f0 m 1f m e4 m a8 m f6 m 5c m 1b m ac m 4b m d2 m 64 m 36 m 58 m 71 m
85 m b4 m c2 m 71 m c8 m c1 m a3 m 63 m 7b m 85 m 5 m 2 m 17 m b0 m 91 m fb m 85 m 40 m 7c m 10 m 4 m 47 m 5e m 19 m af m 3d m
fc m d1 m eb m 7d m 60 m a7 m 1b m 9d m 90 m c2 m 3c m a4 m 4d m 89 m 8c m 7e m 71 m c0 m c7 2 r 6f m 96 m 16 m e9 m 27 m 1c m
1a m db m 29 m 84 m 23 m 1 m 49 m 2b m 2e m ca m 3 m 9 m c4 m af m 73 m 58 m af m 78 m 90 m 4c m 9 m 8a m 77 m cb m fa m a7 m
57 m b4 m a4 m 43 m 5a m 24 m 9b m c3 m d5 m a m 7 m 27 m e5 m e3 m 71 m e1 m c9 m f1 m ce m 87 m c0 m fa m 38 m a4 m 51 m 8b
m 5 m 61 m f4 m 20 m d0 m 50 m 8 m 9b m 26 m 91 m c2 m 5f m b2 m 1c m 41 m df m 97 m d m f4 m 34 m 67 m c8 m 5c m c5 m 5 m b9
m d1 m bd m 76 m 58 m a4 m 8f m 23 m 6b m a4 m c7 m 94 m 1b m c m 16 m 63 m 53 m 19 m 99 m c7 m d9 m 21 m 4d m f2 m 57 m 2a m
eb m 83 m da m 2b m 4 m e4 m fb m 3c m 48 m c7 m 88 m 6a m a3 m 20 m ba m ab m b m 9f m 5e m 62 m a4 m 8 m 90 m 5 m 8f m 63 m
d7 m e4 m 9a m 93 m 16 m 6f m 98 m a m 7c m 38 m 3f m 5e m b8 m ca m 20 m 87 m 8e m 5c m bb m 86 m f2 m 46 m ac m 85 m notbusy
02 wcmd 8 m 1e m 0 m \ 0x81e00 
b8 m 52 m 1f m c3 m 5f m cc m 46 m a2 m 2a m b5 m fe m 8c m c2 m 7 m 7c m f8 m 83 m 3b m e2 m 3e m 32 m f m 62 m b0 m 26 m 1e
m 16 m 17 m 2f m 9b m 21 m e3 m ee m 52 m e9 m 2e m 3e m 60 m 9b m 73 m 7f m 35 m 6e m fd m 16 m f m 7f m e m c9 m d1 m ca m
c3 m b6 m 48 m 9b m d4 m b4 m 18 m 2c m 11 m 39 m ab m 63 m 57 m 86 m ac m b2 m b8 m 31 m 88 m 7 m fe m 57 m 9c m 7f m a8 m a
m 3a m 96 m 9 m 77 m a8 m 37 m e5 m 2f m 56 m 1d m 83 m c1 m 3a m 8b m 3c m 24 m 3a m 6d m 0 m 3c m 50 m fe m a m 44 m ce m a8
m 3e m 6c m 8f m b0 m f8 m 2c m 8f m 80 m 70 m 38 m 89 m f2 m bb m f0 m 9d m 77 m d4 m 5c m 29 m 7b m 22 m 81 m 78 m fb m 16 m
f m bb m da m 86 m ca m a m 49 m af m 0 m bb m 49 m 8 2 r 4a m 3 m 60 m 20 m 3 m d m 30 m 56 m f1 m 99 m d m 35 m 58 m b8 m a0
m c0 m 58 m 85 m d3 m 8a m da m a0 m aa m 2b m 92 m f1 m e5 m d1 m f2 m bf m c8 m 92 m 60 m 83 m a5 m bb m 3c m 18 m 3a m 8d m
43 m f4 m 91 m ce m 10 m e9 m 83 m ea m 83 m 1a m ac m 81 m 87 m 41 m 79 m bd m e8 m 3c m 1a m e m 63 m 35 m 97 m 3a m 4d m 3c
m 1c m 7f m ae m 3c m 4a m 41 m f3 m 9a m 87 m ff m 6 m 8f m d2 m f m 4f m 26 m 1e m a6 m fa m 8f m 1 m 8 m 56 m 8 m 8d m ab m
84 m 8a m 76 m 6 m fc m e m 32 m 58 m d1 m 24 m e1 m fa m 12 m a8 m c9 m ed m 3c m a0 m 28 m 8 m 15 m db m 92 m notbusy
02 wcmd 8 m 1f m 0 m \ 0x81f00 
d8 m 97 m 29 m 75 m 9f m bc m 62 m 7 m 4d m f1 m e6 m 23 m 5c m c8 m 21 m 31 m f m 39 m 9 m f4 m ea m ba m b9 m 8f m 54 m eb m
93 m f5 m d1 m d m d6 m ac m f m d7 m 7d m 47 m ae m fa m c9 m 38 m e0 m 22 m d m 59 m 8 m f8 m 4c m 67 m f5 m fd m 3e m e7 m
3d m cc m 4d m bc m 7b m 2e m 4a m 7d m 46 m 77 m de m 81 m c0 m 8b m 48 m 93 m 4 m 32 m eb m 23 m 5e m 12 m 6b m 81 m a8 m 72
m 62 m 3d m 2 m 21 m 6 m 4b m b m ca m a3 m 97 m b m c2 m a m cf m a2 m 80 m 57 m d0 m a m 39 m 79 m 9f m bd m e2 m d8 m 9e m
25 m 81 m 44 m 1c m 16 m 15 m 53 m 8b m 94 m 23 m 42 m fa m 50 m 3d m b7 m b m 9b m e7 m 32 m eb m 5f m 5e m 1a m 2c m 11 m da
m 31 m 86 m fc m a9 m 8b m 3a m 4a m e9 m 47 m b2 m 76 m 28 m 7f m 55 m eb m cd m be m c5 m c3 m ac m 79 m a4 m 20 m cb m 82 m
db m 36 m 59 m 20 m c5 m 97 m a3 m dc m bc m 47 m 16 m 8b m 6c m d7 m a2 m 2 m 7c m 62 m b0 m 50 m 41 m da m 1e m d m 94 m ee
m f1 m 2e m 14 m 31 m 2a m 74 m 8c m 56 m e m 25 m 59 m 77 m 2 m d9 m 25 m d1 m cf m 6e m 7d m 3e m 4c m d7 m 6b m 45 m 4d m
ca m 11 m d m 3c m 78 m d7 m 87 m cc m 9f m 4f m f7 m 1d m 9b m a5 m fb m c8 m 38 m e0 m 43 m 17 m 77 m 5e m f6 m e4 m 60 m da
m 35 m 4e m b8 m fb m fe m e8 m d9 m 9d m d3 m f5 m f9 m 39 m e5 m 4b m 6e m 78 m 4 m 28 m 89 m 61 m 26 m b m 84 m 9e m
notbusy
20 wcmd 8 m 20 m 0 m notbusy \ 0x82000
02 wcmd 8 m 20 m 0 m \ 0x82000 
93 m 2a m 7 m 70 m 56 m fa m 48 m f1 m 71 m e5 m 81 m d2 m 42 m 87 m c6 m fd m 2a m a0 m 68 m bd m ce m d0 m 76 m 80 m 71 m 33
m d8 m 67 m f0 m 71 m cb m f0 m c6 m 7d m c m 6b m f5 m 9d m 3b m 82 m 63 m 7 m 13 m 46 m 79 m c8 m 1e m 5e m 1 m 10 m 91 m f5
m 5f m bd m dd m c m a4 m d6 m 28 m 42 m 1a m c4 m f4 m ed m da m 50 m 70 m c4 m 29 m c7 m 3b m 20 m 6 m 89 m 69 m 76 m 1f m
33 m f m bf m c m b0 m c2 m e2 m dc m 89 m 4f m 9 m 3d m 98 m 2c m ef m 17 m 27 m 8 m 4f m b5 m d6 m 47 m e7 m e1 m 49 m 1e m
1b m d5 m ef m ee m 90 m 68 m 28 m 7c m f6 m 94 m 90 m f2 m bd m 65 m d2 m c6 m dc m b8 m 5c m 5f m 1 m 39 m 32 m 6 m e1 m c6
m dd m 91 m 21 m 22 m 50 m 39 m 87 m ca m 56 m 3c m 92 m 3e m 84 m cf m e6 m 58 m 2e m 61 m d4 m 1e m 26 m 55 m 9 m bc m e9 m
83 m e0 m e8 m 3b m 20 m e m f3 m 98 m cc m d5 m 9c m df m d m ab m d2 m 5d m 1f m 56 m 65 m 3e m 9 m 8 2 r 24 m 2c m b m 4c m
f4 m 4a m 1f m ca m da m 72 m 3a m 3b m 3e m a9 m 23 m e m 4 m 1f m 57 m 4b m 65 m 3 m b0 m f4 m 88 m f2 m 0 m e4 m a1 m 77 m
80 m d9 m 38 m 5c m ac m 34 m 75 m 32 m 1 m 81 m 48 m b8 m 94 m 58 m db m 39 m 99 m d5 m 4f m 14 m e6 m 7e m 3f m 94 m 7 m 47
m 7b m 83 m 47 m 2a m da m 4d m ef m 57 m b3 m b m 20 m f2 m 6c m 1 m 93 m d5 m bc m bb m f3 m 92 m e4 m 55 m a4 m notbusy
02 wcmd 8 m 21 m 0 m \ 0x82100 
ed m 12 m 8a m c5 m 16 m e6 m 6a m b1 m ff m 31 m 4 m 58 m e6 m 42 m 1f m d m 88 m ce m 15 m d1 m b m fd m 2c m 79 m c8 m 74 m
28 m ac m d8 m b7 m 40 m 1c m 8 m 8d m a8 m 20 m e4 m 4f m b9 m 76 m 1 m e5 m e1 m a9 m e0 m b9 m cc m 7d m 7c m 4f m 56 m b3
m 5b m 20 m c9 m c4 m 95 m 12 m 52 m d8 m db m b8 m 80 m 51 m 8e m 78 m 5e m f3 m 38 m 4a m 11 m 75 m ea m 5b m c2 m 57 m b1 m
55 m e7 m 91 m e2 m 7e m d5 m f5 m 11 m 81 m 40 m d7 m c6 m a1 m 6 m cb m 63 m 1e m fe m d2 m 5c m 21 m 1e m a3 m 43 m bf m d0
m 47 m 5 m 2 2 r 59 m ff m 52 m ad m 16 m 84 m c2 m 24 m 20 m 45 m 51 m f2 m 82 m 7 m 14 m 65 m e5 m ce m 99 m 90 m 15 m cb m
dd m 39 m 5d m 2e m 76 m 3b m 52 m 48 m 67 m 86 m c m fc m 46 m 9c m fa m e m a2 m 75 m 90 m dc m 8f m 7f m 19 m df m 23 m 76
m e9 m 3b m 1 m 92 m db m 61 m 39 m 6d m e m c4 m 23 m 7e m 28 m 59 m d4 m 1 m 40 m ac m cf m f6 m 55 m ae m dd m 79 m f6 m e7
m d9 m 1d m 14 m 7d m 88 m 8a m 60 m 2a m f9 m b1 m b8 m 4 m 61 m 36 m 57 m 76 m c1 m c3 m ad m c m 56 m b8 m 38 m 67 m 1d m
92 m 40 m 96 m e2 m 9 m 4b m 7f m 9e m 78 m b8 m 66 m d2 m b0 m 43 m e7 m 54 m 1f m e9 m c m b8 m c9 m 3c m 7c m 6e m a1 m 98
m 52 m c8 m a9 m d m b8 m 33 m e3 m 16 m 95 m ee m e5 m 70 m 2c m 89 m 16 m 4a m 37 m 52 m b1 m 36 m 1c m 1d m d8 m d1 m
notbusy
02 wcmd 8 m 22 m 0 m \ 0x82200 
b1 m 83 m 7d m f0 m 1e m e9 m 23 2 r 1e m 62 m a8 m a5 m d6 m a1 m ec m ba m 5e m e8 m 23 m 9f m 92 m f3 m 8d m c7 m a2 m 40 m
b1 m e2 m d0 m 1 m 2f m 1d m 27 m 79 m a0 m 92 m d1 m ce m c3 m 8f m 6 m cb m 5f m e8 m a3 m 50 m b6 m 7a m cd m c3 m af m 13
m 26 m 88 m c7 m d7 m 89 m d2 m 42 m 47 m 6f m d0 m 6 m 9 m 5d m 30 m 51 m 2e m 3 m c9 m 97 m 4d m fa m 67 m ad m d1 m 4b m ad
m a9 m c6 m ed m 5b m a5 m 4 m f4 m 53 m 64 m ca m e8 m cc m 43 m 27 m 43 m 97 m ce m 72 m 30 m ac m 8e 2 r a4 m 4 m 41 m 76 m
e4 m 91 m b7 m 6f m cb m f1 m f m 79 m e6 m b2 m 84 m 64 m b0 m 56 m c3 m 95 m 65 m 6 m 44 m 6e m cb m 9a m d1 m 5a m d0 m 40
m da m 9b m 42 m 63 m 11 m 73 m 65 m ae m 50 m 7d m c9 m 39 m 6a m 28 m 6d m 7c m ad m ab m a8 m f3 m b1 m 20 m bb m e4 m 61 m
d6 m 3c m b4 m 45 m 3d m 0 m 7c m 4b m b m 1d m ac m e7 m 10 m f7 m 43 m 25 m 1e m c1 m 66 m 20 m 50 m 15 m f1 m 85 m 4f m 88
m e7 m 6b m 9a m 8d m db m 85 m a6 m 2 m cb m 5d m d2 m 4c m 39 m 55 m 11 m 6c m 71 m 21 m 93 m 3a m ea m 79 m 5c m ca m 43 m
5a m 43 m 6a m a9 m 79 m 48 m 81 m 8b m 4d m 75 m 71 m 2b m 1e m a6 m 99 m 2b m 38 m 8b m b0 m aa m 18 m 95 m 38 m b6 m ea m
3c m 46 m 79 m b8 m 25 m 8f m 71 m 89 m 72 m c3 m e3 m eb m ba m 4d m 31 m 5e m 7e m 28 m 1a m 60 m a1 m 9e m c m 6d m 49 m
notbusy
02 wcmd 8 m 23 m 0 m \ 0x82300 
18 m 25 m 61 m 5 m ab m 11 m ae m ce m 41 m 5b m 3a m ae m 57 m ba m 18 m 97 m 23 m fb m 46 m d7 m ee m db m de m 1c m c3 m ee
m 14 m fc m b2 m bc m e7 m 14 m 55 m d7 m 47 m c2 m 2e m 62 m 9 m 7a m 89 m 3e m 64 m 6b m c3 m 47 m 78 m 68 m 20 m cb m ba m
ff m 60 m 2e m 94 m 26 m 7c m 6b m 1c m 42 m 86 m 6a m ae m 6c m 35 m 58 m 62 m d5 m d2 2 r 91 m e6 m 33 m b m 79 m 2c m eb m
45 m c7 m 88 m 37 m b m e4 m be m 9d m ff m d7 m ad m 3c m 8 m 8f m ec m d0 m 5b m db m bd m b2 m cc m ca m 51 m 14 m 0 m d9 m
73 m d6 m bc m 54 m bd m 87 m b2 m 27 m 5d m 2f m 29 m bc m f0 m c m f6 m d8 m 7a m 99 m 22 m 14 m 6 m 57 m 20 m f1 m 8f m 81
m 66 m 7f m 60 m dd m d6 m c5 m a m 49 m 5d m 76 m cf m af m 99 m 7 m 80 m ad m d9 m b4 m 1c m 69 m 84 m 74 m 6c m f0 m c2 m
60 m 45 m ef m e8 m 4a m 74 m 5 m d4 m 60 m f3 m 76 m ad m f m 37 m e4 m c8 m ef m e4 m 81 m eb m a9 m cf m f1 m a4 m 88 m bd
m e1 m 51 m 8e m d0 m de m ca m 43 m 68 m 62 m b0 m c m e2 m 11 m 25 m a0 m a1 m b9 m a5 m 29 m 85 m 6d m 0 m 4e m e6 m ba m
ec m e9 m 76 m 22 m f4 m df m e9 m c2 m af m 40 m a2 m f m 87 m be m 9d m 3e m 27 m 6e m c8 m ea m b4 m 9 m 4b m 11 m 93 m 75
m 8 m d7 m 9f m c8 m e2 m 78 m 97 m a5 m a0 m 51 m 1c m 3d m c2 m 92 m d1 m 60 m 25 m 48 m d1 m 60 m ad m f4 m 21 m 54 m e7 m
notbusy
02 wcmd 8 m 24 m 0 m \ 0x82400 
11 m bd m fe m e4 m d2 m 93 m 3e m f4 m 80 m 23 m dc m ca m 83 m f0 m 18 m cf m 9e m 6b m e7 m df m 3a m 85 m 3 m af m 86 m 77
m a4 2 r d1 m b4 m 27 m 83 m 45 m c5 m 2a m 21 m b5 m a0 m c8 m 23 m 57 m 54 m 25 m 2f m 40 m 78 m 8c m a7 m 1b m 50 m c7 m db
m 7a m da m 40 m 96 m 6d m 85 m c5 m a9 m 87 m d2 m 6e m 41 m f7 m 8d m aa m 48 m a3 m 37 m 26 m ce m 1e m 93 m b7 m e6 m 57 m
32 m b9 m ad m 54 m df m 50 m ce m 72 m 8a m 10 m b2 m 3e m 34 m c9 m b5 m 8b m ba m 5b m b m 2 m f1 m ad m de m 4a m 1c m 7c
m a1 m f m 3d m ed m 58 m 8c m 38 m ae m cf m e3 m 8c m 1e m 1d m 80 m 84 m e7 m 40 m f2 m 26 m 19 m da m 41 m 57 m a4 m a9 m
b3 m 30 m a4 m e9 m d5 m 59 m 8c m 33 m c m 77 m 96 m 6f m da m ad m 6d m ce m b9 m 65 m fd m d0 m 31 m 9d m a5 m 8b m 1d m 6e
m 72 m 31 m 70 m 20 m e4 m 72 m 6c m 96 m 9a m b8 m c7 m 6b m bc m 1e m fc m 44 m 35 m 1c m aa m 34 m bf m 82 m 86 m 97 m 10 m
d7 m 65 m 3 m 96 m 81 m 44 m ff m e0 m f2 m 5b m 14 m 58 m 20 m b2 m 97 m 5f m a9 m e0 m 5b m f9 m 9b m 16 m 3b m 9f m 8e m 74
m d2 m f3 m b3 m f5 m c6 m 4 m 37 m 7 m 8 m 9 m 8f m 49 m 20 m fa m 8d m 63 m 6a m c9 m e2 m 61 m 1c m 42 m 93 m 23 m 90 m c m
82 m 9f m 40 m 2a m e5 m 6b m de m c5 m 77 m b5 m d8 m 27 m 17 m 40 m 29 m 8b m 86 m 3e m 69 m ca m 84 m d9 m bc m 4d m ad m
notbusy
02 wcmd 8 m 25 m 0 m \ 0x82500 
bc m a4 m ea m 2d m 7c m 50 m a8 m 3 m bf m 13 m d9 m f6 m 31 m 28 m 87 m 83 m 37 m 20 m 13 m 9f m 9c m c9 m 49 m 16 m 2f m 5
m 13 m 7 m 2 m a2 m 9a m 3e m 84 m 30 m be m 55 m 23 m c2 m 5e m 23 m 5 m a2 m f4 m 7c m 6e m 26 m 8c m 38 m 86 m 13 m cf m 84
m c7 m 39 m 1e m fe m bc m 6d m 65 m b6 m c2 m 81 m 4b m 7e m 64 m f4 m 3f m 86 m 1c m 39 m b0 m 96 m 74 m 48 m 2e m 40 m d2 m
f m 4b m 43 m 9c m 87 m fc m bb m ee m ef m 3b m a8 m d6 m 1b m 4a m a5 m 62 m 18 m 8a m a3 m f2 m 50 m 22 m 57 m e6 m 85 m 1a
m 58 m f3 m a m 4 m e m c2 m 87 m 72 m 99 m f0 m bd m 75 m a7 m 2e m 65 m 1 m b9 m 5a m 94 m 9b m aa m f m 93 m 8f m 27 m 75 m
1a m e9 m 88 m d2 m 68 m 74 m c3 m 74 m 0 m dd m df m 9c m af m 5d m 8 m a4 m ac m c9 m 9e m d0 m 8 m 46 m 90 m a2 m 9f m 18 m
f m 4 m a7 m fa m de m 79 m 5a m ac m d1 m 93 m 3d m be m e6 m c8 m 70 m c m f5 m d4 m 55 m 81 m a9 m 78 m d5 m dc m 26 m 5b m
88 m ec m 98 m fc m e2 m d6 m 1f m 3a m 75 m 4c m 50 m f9 m 53 m fa m 7c m 96 m 46 m 80 m 8f m 67 m b9 m d3 m 50 m d6 m 4c m
32 m 63 m 8c m 9c m db m 6e m c5 m ed m ba m 37 m 41 m ce m ab m 9f m 52 m ed m dd m 2 m c m 72 m 83 m 21 m 4d m 3a m ca m 4c
m a7 m 6b m c7 m 7e m 0 m 63 m bf m 8c m 7e m 5 m be 2 r 95 m 4f m 29 m 3f m ea m 1d m f5 m 53 m 3e m be m 5a m 2c m notbusy
02 wcmd 8 m 26 m 0 m \ 0x82600 
6 m d m c4 m 5a m 57 m 9f m e5 m 21 m c4 m 10 m ce m f3 m 2d m eb m 18 m c2 m eb m fb m 1 m b5 m c6 m 3b m 8b m fe m f0 m 67 m
be m 31 m 59 m 7d m 5b m a9 m 79 m 62 m ee m 16 m 19 m e7 m bb m f8 m 25 m 5f m fc m 9a m dc m b2 m c5 m 82 m 53 m 2b m a4 m
b8 m 5d m 94 m 62 m c4 m 64 m 6c m 2d m 29 m b7 m f1 m 81 m dc m c4 m 2a m 94 m e2 m 1f m 8c m c3 m de m f7 m cb m 98 m d6 m
20 m 7d m 5d m fc m a2 m e1 m d5 m e9 m 86 m 92 m d1 m 54 m f1 m 0 m 3d m 60 m 73 m 37 m 23 m 26 m 94 m d6 m 94 m c7 m d7 m e4
m 85 m df m ec m c6 m f1 m e8 m 4f m ee m 6e m 33 m 4 m 39 m e0 m 54 m 49 m 57 m f m ac m e4 m 75 m 4c m 9a m d9 m 2a m 5b 2 r
4e m a0 m 45 m 8b m 95 m b m 94 m 62 m bc m 2a m e8 m e1 m 28 m 5d m 81 m 60 m 18 m 15 m c7 m 39 m d0 m 20 m 1d m 65 m ec m 5d
m 3f m 99 m 73 m b1 m 48 m 27 m 12 m b9 m 58 m 1 m 66 m 71 m 8c m f5 m bb m a5 m a9 m 38 m f8 m 85 m 64 m be m cb m 7 m 75 m
ab m 46 m 5e m eb m fb m 41 m 3d m 5 m f2 m 1c m dc m b9 m 72 m 2e m a6 m df m ad m 2f m d8 m b2 m ac m 2c m 38 m be m ce m 96
m 4c m 8b m ea m d6 m e9 m 2e m 72 m 70 m b6 m 40 m 9 m 72 m 38 m 4a m 48 m 9d m 1d m 21 m a9 m 7e m f2 m 1e m 6f m 9a m a2 m
1e m 8a m 5d m 1f m f6 m 7c m d5 m df m a7 m 75 m 9 m ef m bd m 90 m 93 m 9b m 32 m ee m f2 m 46 m 56 m e9 m d5 m a6 m 23 m 7
m notbusy
02 wcmd 8 m 27 m 0 m \ 0x82700 
ba m f6 m 78 m f m 6d m 5 m 6b m 6 m 7b m f5 m ea m 7e m 69 m f m 89 m 7c m ff m a6 m 60 m 65 m eb m bb m da m 95 m 6c m 9d m
72 m 12 m cc m f5 m 5a m 85 m ba m fa m 4f m f3 m 9d m 8e m 7a m c0 m 6e m f9 m 70 m b6 m 56 m 6a m 33 m 94 m da m 20 m 1c m
e3 m 21 m bf m a m c4 m be m e8 m 7f m 95 m 5e m 7e m ee m 66 m 99 m 1b m 54 m 6b m e3 m 2e m e m 9c m 7b m ab m 30 m 8d m 4 m
44 m d5 m 2e m ef m de m f7 m fa m fb m a7 m e1 m ec m ff m db m 58 m dc m 77 m c5 m 1a m 84 m a3 m 2e m 61 m 6 m 1c m 43 m d9
m 5f m 49 m 5c m 29 m 33 m f9 m 8e m f5 m 4d m 2 m ef m 70 m 4c m 3c m a0 m b2 m 6b m 82 m a1 m eb m 11 m d1 m 79 m bf m 1c m
d8 m d3 m 35 m 50 m c1 m d1 m 4e m bc m a1 m ee m 8e m b7 m f2 m f8 m 9f m 2 m c1 m 82 m 19 m e2 m a2 m 64 m c4 m 32 m 25 m 17
m 6a m 83 m 4 m 23 m 25 m 81 m 21 m 6a m 5b m b8 m 5a m 70 m 53 m a m be m 52 m 55 m f3 m aa m 8d m fb m d5 m 4a m 62 m fb m
ba m 5 m a2 m 87 m 5b m 7f m 68 m eb m 6 m 18 m e3 m 9 m 42 m 99 m 70 m f4 m b m 85 m b4 m db m f4 m e7 m f9 m 13 m 6f m cf m
7d m 13 m 24 m d4 m 2c m 18 m f0 2 r d m c7 m 58 m 18 m 8b m 12 m 57 m b5 m b m 99 m cd m f7 m 66 m 59 m 9c m cf m d0 m aa m 5
m 49 m 8f m fa m bd m 46 m 20 m ea m e6 m b6 m 38 m b9 m 15 m 3 m 42 m 2f m 47 m 81 m e8 m 82 m c3 m b7 m c5 m 45 m ca m
notbusy
02 wcmd 8 m 28 m 0 m \ 0x82800 
32 m bf m d9 m ce m ec m 27 m 8 m 6 m ad m 5b m d3 m c5 m 84 m e m 9 m ae m db m 90 m d5 m a4 m ee m f2 m 6 m 39 m 28 m be m
32 m 2e m 3c m e2 m 51 m 36 m 4c m b4 m 5c m aa m 43 m bd m 3c m 5f m 9b m 16 m a6 m c8 m af m ad m 6f m 33 m f7 m f3 m 89 m
4c m 4b m cf m 7c m 31 m 5 m 2 m 44 m de m 34 m 93 m b9 m 9e m af m bc m 4d m 73 m 65 m 29 m b6 m d5 m 3a m eb m 1f m 1 m c1 m
81 m 86 m 1f m 9b m 89 m ff m 17 m 6f m 4b m 4e m 62 m 97 m 76 m 7e m 23 m 97 m 69 m ae m 3b m c3 m dd m 88 m a3 m d0 m f0 m
4f m fb m 85 m 7f m b5 m c2 m e3 m 67 m 38 m e4 m 70 m c2 m 36 m 45 m 19 m f5 m 50 m fc m 90 m 1d m f9 m af m de m 24 m 9e m
78 m cc m 7e m e8 m 1f m ce m 97 m df m 1 m 91 m d7 m 34 m ae m f3 m 42 m db m 3a m e5 m e3 m bd m 55 m 4f m 6e m ac m 46 m ef
m 5 m 99 m 17 m 46 m bd m 2d m 73 m f8 m cf m 22 m 58 m db m 30 m 7c m be m a9 m dc m 6f m 65 m d9 m d8 m e7 m 12 m 46 m a1 m
e1 m fd m f9 m 1e m f m 0 m e2 m de m d4 m 47 m da m ee m 43 m 30 m 7e m f m 8e m 9e m c4 m ef m 40 m 7a m 53 m 8c m 87 m fa m
c0 m 34 m 6e m d2 m a6 m db m d7 m 35 m 10 m f3 m 50 m 1f m 9 m 47 m ca m b4 m 91 m 1b m 5f m f8 m df m 83 2 r e4 m 58 m 86 m
a6 m 18 m 59 m 23 m 2f m f4 m 51 m 60 m bc m c4 m 71 m 75 m bf m a2 m 4 m a4 m ec m f4 m 3e m 51 m 8 m 87 m 5a m 68 m f3 m eb
m notbusy
02 wcmd 8 m 29 m 0 m \ 0x82900 
71 m d4 m 60 m cb m 62 m 20 m 2b m 22 m 4 m 49 m ad m 7c m 49 m 6d m 35 m 6e m ad m d5 m f5 m fd m bc m a m 10 m 97 2 r 35 m
f7 m 38 m 4 m 4b m 67 m cb m a0 m c5 m 79 m c7 m 11 m 7e m 23 m e m c m 84 m 12 m 91 m 39 m e1 m bb m d2 m 87 m ae m f7 m 8 m
ac m 38 m ee m a6 m 66 m bb m 76 m 60 m a1 m 11 m b9 m f3 m e5 m 69 m 73 m a6 m 9c m c6 m 47 m 38 m ce m df m 89 m e3 m f2 m 6
m 90 m 46 m cb m 54 2 r 2a m 86 m 80 m 57 m a3 m 36 m 65 m 5 m 48 m 78 m f7 m fe m 6a m 4 m c8 m d m 91 m dc m 5f m 49 m f5 m
32 m 11 m 83 m 6d m d5 m ef m c4 m 71 m d m 4 m d2 m 15 m 1c m ee m 3a m 92 m 8b m 51 m 72 m f7 m 3e m 94 m 60 m 6c m fa m 38
m bf m c1 m 83 m 2 m 71 m 6d m 1b m 52 m 93 m ae m 3e m ed m 36 m b6 m c6 m 12 m 1c m e1 m 17 m e3 m e8 m 26 m 6b m 2 2 r 89 m
60 m 29 m cb m 86 m 16 m cd m f6 m a2 m 1b m 9a m 7e m e3 m 7e m 90 m 3d m e6 m f6 m 95 m 48 m 59 m 92 m a2 m 4a m 59 m e2 m
bd m 8d m 6d m 38 m 7e m b5 m 38 m 90 m 42 m a6 m 9b m 8 m d7 m aa m e3 m 6e m b9 m 57 m 77 m ce m fc m d6 m fd m 52 m d1 m ce
m 33 m e2 m 81 m 4e m 99 m 3b m bc m ee m 23 m 40 m 7c m f8 m ed m 38 m 6a m 93 m d5 m b m 20 m dd m 72 m a3 m bd m c2 m a7 m
38 m 5e m de m 8f m 3e m 1 m 71 m ab m 61 m 69 m 18 m 8e m c5 m f1 m cb m 71 m d4 m a4 m d2 m a m 8 m 32 m 56 m 76 m notbusy
02 wcmd 8 m 2a m 0 m \ 0x82a00 
be m d9 m ef m eb m fa m 99 m ed m 75 m 9e m e0 m a m 8 m 5e m a6 m 56 m 1a m e1 m 6f m a0 m d1 m 81 m b8 m 5 m 10 m 84 m c3 m
8e m 77 m 33 m fd m 7 m f7 m a3 m 7f m 22 m 11 m aa m 8f m 7 m 77 m fa 2 r 5d m 40 m a8 m cd m 32 m 15 m 47 m 1 m e2 m ec m 37
m 70 m bc m e2 m 41 m d6 m 86 m b7 m 40 m fe m 2a m 1a m dd m bd m 12 m 89 m 18 m 5b m e3 m 7e m 33 m e8 m a3 m d2 m 78 m 39 m
3d m db m c3 m 17 m be m 36 m 5a m f9 m 65 m 7d m 38 m ff m 2a m 1c m 3d m de m 19 m 34 m 82 m a2 m 2b m fb m 36 m 8d m 27 m
3c m 5e m 1a m 2d m d7 m fb m 2 m 7c m fd m 55 m 63 m 41 m 84 m a4 m 29 m be m 81 m e3 m 11 m f m 9a m 3f m b9 m 62 m f1 m b7
m d1 m f8 m ea m 1b m 55 m ad m c6 m 8c m 2e m c4 m 2c m bd m f m f6 m a3 m a7 m dc m de m bc m 16 m 8 m 12 m 8f m 1b m 66 m
7c m fd m 8d m a3 m 13 m 29 m 69 m c m 3b m ae m 3d m de m a2 m f1 m 9c m c7 m 17 m bd m 27 m e8 m d4 m 73 m f6 m eb m 6f m 1d
m f4 m a6 m b5 m c4 m 80 m e0 m ce m bc m 5f m 7f m 9a m c7 m cd m 4d m 71 m be m fe m f2 m 31 m d5 m e9 m fb m 90 m fe m f7 m
9d m 19 m da m fe m c9 m 2b m 7f m 60 m bc 2 r 56 m df m 9d m a2 m ed m 1f m bc m f2 m 7 m c3 m 13 m 24 m ef m 3d m cb m f6 m
99 m c8 m 7f m f m ca m 37 m 9e m e0 m c3 m e3 m 67 m 8d m f m 8f m f m 8f m cf m f8 m f0 m f8 m f0 m f8 m 8c m f m 8f m
notbusy
02 wcmd 8 m 2b m 0 m \ 0x82b00 
f m 8f m cf m f8 m f0 m f8 m f0 m f8 m 8c m f m 8f m f m 8f m cf m f8 m f0 m f8 m 8c m f m 8f m f m 8f m cf m 78 m 3a m fe m f
m 8c m 63 m f2 m 3f m d m cc m b0 m e8 m 0 4 r 49 m 45 m 4e m 44 m ae m 42 m 60 m 82 m 0 6 r 8 m 1 m 0 2 r 5 m 24 m ff 7 r 0 4
r 89 m 50 m 4e m 47 m d m a m 1a m a m 0 3 r d m 49 m 48 m 44 m 52 m 0 3 r 4 m 0 3 r 4 m 8 m 0 4 r 8c m 9a m c1 m a2 m 0 3 r
15 m 49 m 44 m 41 m 54 m 78 m 9c m 63 m 4c m 60 4 r 48 m 60 4 r 62 m 80 m 11 m 0 m c m a6 m 0 m c6 m af m 34 m 3 m 6d m 0 4 r
49 m 45 m 4e m 44 m ae m 42 m 60 m 82 m 0 4 r 1c m 8 m 2 m 0 2 r 5 m 24 m ff 7 r 0 4 r 89 m 50 m 4e m 47 m d m a m 1a m a m 0
3 r d m 49 m 48 m 44 m 52 m 0 2 r 3 m 47 m 0 3 r d3 m 8 m 0 4 r 6f m ce m 37 m 97 m 0 2 r 6c m 9e m 49 m 44 m 41 m 54 m 78 m
9c m ed m fd m 79 m a0 m 6d m 47 m 51 m 2f m 8e m 57 m 55 m af m bd m 93 m 40 m 48 m 0 m 1 m 5 m 7c m 12 m 8 m 84 m 40 m 64 m
78 m 20 m 8 3 r 3e m c1 m 19 m 45 m f0 m a9 m 88 m 8f m a0 m 32 m 28 m 33 m 88 m notbusy
02 wcmd 8 m 2c m 0 m \ 0x82c00 
32 m 9 2 r 88 m 26 m 41 m 19 m 15 m 8 m 2a m 22 m 20 m c3 m b m a m ca m e4 m 3 m d4 m 8 m 21 m 4c m 11 m 48 2 r 20 m 61 m 8 m
61 m a m 90 m 30 m 24 m 64 m 3e m 7b m 75 m f5 m f7 m 8f m ae m aa m ae m 5e m ab m f7 m 3e m 7b m ef m 73 m f6 m b9 m fc m 7e
m f7 m f6 m bd m 77 m 9f m 73 m ee m 59 m 6b m 75 m ad m ee m fa m d4 2 r d5 2 r 8 m fb m b6 m e1 m e8 m 7f m d2 m 3e m a0 m
e2 m 40 m 3b m d0 m 76 m d6 m c6 m 7c m fc m fd m d1 m f5 m 1 m 34 m 7d m 7f m b5 m 3 m f2 m 6e m 71 m db m 57 m 38 m c2 m d6
m 4f m d5 m d4 m 1c m 98 m a7 m ef m 93 m 76 m 40 m de m 2d m d1 m f6 m d m 8e m 70 m f4 m 8d m 6f m 69 m f0 m f5 m 40 m db m
77 m d m 5b m 3f m 1c m 90 m 77 m a3 m b6 m 2f m 70 m 84 m ad m 2f m da m 92 m fb m 3c m 30 m 47 m fb m b8 m 1d m 90 m 77 m cb
m b6 m 7d m 80 m 23 m 87 m 1f m 1c m 91 m 90 m f4 m e3 m 0 m 92 m f6 m 79 m 3b m 20 m ef m 96 m 6f m 7b m 8f m 23 m d4 m 4f m
5 m d2 m 8 m 47 m c9 m 23 m e9 m c0 m 14 m ed m ab m 76 m 40 m de m ad m d0 m f6 m 1c m 47 m 36 m 25 m 28 m 58 m 2a m 50 m d2
m b9 m 49 m 82 m a4 m 3 m 40 m da m 97 m ed m 80 m bc m 5b m a5 m ed m 35 m 8e m 14 m 46 m a8 m 38 m c2 m 8a m 6 m 41 m 91 m
47 m d2 m 7e m 3e m 41 m fb m aa m 2d m 90 m 77 m 5 m 44 m 7 m e4 m 9d m b6 m 7d m 81 m 23 m 85 m 11 m 16 m 34 m notbusy
02 wcmd 8 m 2d m 0 m \ 0x82d00 
e5 m e6 m 50 m 54 m b0 m b4 m 9f m 4f m d0 m 3e m 6a m 8b m e5 m 5d m 9e m 96 m 3 m f2 m ae m b4 m 3d m c6 m 51 m 11 m 70 m 8a
m 23 m 99 m a8 m dc m 12 m 24 m 48 m f6 m f7 m c0 m c m ed m bb m 76 m 40 m de m ad m d6 m f6 m 16 m 47 m a m a3 m 3c m 3d m
28 m 60 m 92 m 19 m d2 m d9 m 49 m 29 m 41 m 52 m 28 m 1d m 98 m a1 m 7d m d2 m ea m 89 m ca m b3 m 5 m 7 m e4 m dd m fc m d6
m ed m 65 m 67 m 6e m 76 m 10 m 1 m 49 m b1 m 94 m a5 m 5d m 32 m 18 m 25 m d m 2 m 61 m 2 m dc m 9f m 67 2 r 5f m 35 m 3f m
51 m 20 m f2 m ae m 68 m 24 m 9b m 28 m 99 m 1c m 9d m a6 m fd m 79 m aa m f6 m 14 m 47 m d2 m 44 m 17 m 95 m e6 m 70 m 64 m
8d m 1 m f2 m c m 1d m 68 m 7b m de m 2a m 79 m 87 m 20 m f2 m 4e m 81 m 74 m 40 m de m 35 m da m 5e m e3 m c8 m 24 m 1c m 22
m 21 m 52 m 1 m 92 m c3 m 11 m a7 m c4 m 40 m 2a m ea m e m cc m d1 m be m 68 m 2 m a5 m ed m e5 m 5d m 4a m 70 m 40 m de m ed
m 2d m 8e m 2c m ee m 23 m 30 m ca m 7f m c m 48 m 86 m 22 m 48 m 9 m 12 m 3 m 24 m 3c m 30 m 43 m fb m ae m cd m 95 m 77 m d9
m 2d m 52 m 79 m 97 m db m 7e m 2f m ef m f6 m de m ae m 73 m 28 m 22 m 43 m 92 m e1 m 88 m 13 m 26 m e4 m 4 m 4c m ac m 36 m
f7 m fe m 3d m 41 m fb m a0 m 55 m f2 m 8e m 10 m 29 m 23 m 89 m 60 m 8e m bc m 3 m 38 m 20 m ef m f6 m 10 m 47 m 3a m 3d m
notbusy
02 wcmd 8 m 2e m 0 m \ 0x82e00 
79 m 82 m 88 m 30 m 20 m 65 m 28 m 79 m 1c m 31 m 26 m 44 m 6 m 60 m e2 m 6c m ec m ed m e7 m 13 m b4 m cf m da m f2 2 r e 2 r
c8 m bb m bd m d7 m 47 m 32 m 3d m 84 m 64 m 2d m 9b m c m 79 m 7a m 88 m 99 m 73 m 78 m 95 m 91 m 72 m ac m 61 m ff m 9e m a0
m bd m 6f m 28 m 5e m 2c m 0 m 66 m 10 m 65 m 89 m 27 m 40 m 32 m 79 m 47 m ac m f2 m 2e m 83 m 6b m ff m 9e m a2 m 3d m 8e m
7b m 9b m 77 m 84 m 44 m 14 m e4 m 1f m e9 m fc m 70 m 4a m cc m 51 m 96 m 94 m 0 m 18 m 21 m c1 m fe m 1d m 4e m dd m 87 m cd
m a6 m 89 m 88 m 42 m 46 m 52 m 2d m ef m 50 m e5 m 9d m 46 m c3 m f7 m 67 m 79 m b7 m e7 m f1 m 3a m 4 m 9b m 1d m a m 21 m
e3 m 88 m 32 m 8e m 52 m 4a m cc m 8c m 1c m 1 m 21 m 1 m 24 m 8b m e3 m 1d m 68 m 7b m db m 2c m 50 m 97 m ad m 3a m 9d m 25
m 91 m 77 m 90 m 12 m 27 m 66 m 8e m 7 m e4 m 5d m 69 m 7b m 8b m a3 m 12 m 4d m 25 m a2 m 10 m 42 m 8 m 14 m 28 m 10 m 92 m
e0 m 88 m 99 m 19 m 23 m e4 m 90 m 10 m 25 m 94 m b9 m d9 m af m 67 m 68 m 9f m 35 m 1 m 12 m 85 m 81 m bc m 3 m 85 m d1 m 1 m
79 m 57 m da m de m e1 m c8 m 1b m 75 m 79 m 7e m a4 m 51 m 40 m 42 m 14 m 75 m 14 m 59 m 84 m 1e m a4 m 44 m 9 m 10 m e1 m c0
m 5a m f9 m de m b7 m ca m fc m 36 m 81 m 27 m f2 m e m d8 m c9 m 3b m 38 m 20 m ef m 0 m 60 m 9f m e4 m 33 m 38 m 31 m
notbusy
02 wcmd 8 m 2f m 0 m \ 0x82f00 
d7 m e5 m 29 m fa m a1 m c7 m dc m 7 m 0 m 2e m 7d m d3 m 9b m 7a m a6 m a8 m 26 m 78 m 4a m 89 m 18 m 30 m e1 m 7e m ef m c3
m ee m 6d m b3 m 34 m e2 m 6c m 80 m 87 m 10 m 42 m e8 m a8 m a3 m 10 m 28 m cb m 3b m 60 m 2f m ef m 52 m 4a m 4 m bc m df m
cb m bb m bd m cb m 53 m cd m 39 m 5a m a4 m 12 m ae m b m 5d m fe m 1b m c2 m ef m 3d m 54 m af m 79 m f4 m 67 m 62 m ec m 63
m df m c7 m be m 8f m b1 m 8f m cc m 91 m 13 m 27 m cd m 85 m 3c m d0 m f6 m a2 m 29 m 82 m cc m f4 m e m 5d m e8 m 42 m 17 m
2 m 85 m 1f m 79 m cc m dd m 1 m e0 m 1b m ff m f8 m af m cc m 31 m c6 m d8 m f7 m b1 m 8f m 31 m c6 m a8 m d3 m b4 m 1f m cf
m d3 m 1e m e3 m 48 m 42 m c m 5d m 8 m 5d m 98 m 74 m 19 m 49 m 4f m fb m 99 m 72 m d1 m 1f m 7d m ac m ef m 63 m 9f m 5b m
8c m 31 m 32 m 73 m e2 m fd m 79 m 7e m f6 m be m 35 m e4 m 5d m 17 m ba m 2e m 84 m f0 m d4 m 5f m d0 m 6b m 8e m fd m 62 m
8c m b1 m 2f m f2 m 2e m f2 m fe m 2e m ef m 68 m af m 3a m d2 m 25 m d8 m bc m 2a m 81 m 44 m 81 m 28 m 84 m ae m eb m ee m
ef m 60 m 4 m 27 m fd m e0 m a4 m eb m 42 m d0 m 68 m 78 m 5e m fa m c3 m 7d m 51 m d4 m 68 m ff m 6e m 16 m c m ca m 3a m a9
m eb m ba m 6e m f2 m 22 m 83 m 11 m bc m e6 m 4e m 93 m ae m eb m f2 m 4c m 49 m 40 m 7c m cf m 77 m 84 m 7e m 7f m b5 m 3d m
c3 m 51 m notbusy
20 wcmd 8 m 30 m 0 m notbusy \ 0x83000
02 wcmd 8 m 30 m 0 m \ 0x83000 
6e m 8 m 95 m fb m da m 75 m 5d m f7 m f4 m ea m 82 m e3 m bb m 2e m 74 m c1 m 96 m 95 m 34 m b4 m ba m bf m 4f m d3 m de m 35
m 93 m 77 m 38 m 40 m d2 m 6f m fc m 4f m 77 m d5 m 8b m 6e m 7c m 40 m de m 55 m 6d m af m 70 m 24 m f9 m 40 m 90 m 67 m 88 m
d4 m fa m ee m ba m fb m d4 m d7 m dd m fa m b0 m 3c m 3f m c1 m 2d m a0 m 1f m 68 m 7b m de m 2a m 27 m 89 m 42 m d7 m 75 m 7
m 3f m b2 m ba m e0 m f9 m 7 m e4 m 5d m d5 m f6 m 52 m 1f m e5 m 54 m 13 m 15 m 74 m e2 m c3 m fe m dc m e0 m a2 m 9f m 96 m
18 m 9e m e6 m dd m 19 m 94 m f6 m d3 m 9 m da m e3 m a6 m f2 m ce m e2 m 75 m 12 m b0 m eb m 7e m b6 m be m ee m e6 m d7 m b
m 73 m e4 m dd m fe m 39 m 4f m 7b m 6e m d7 m d m ed m 85 m a3 m 6 m 57 m 1c m 1d m 2a m 7b m 21 m df m b4 m 7f m ce m cd m
be m 6a m 96 m 4b m ec m 17 m cc m ef m 3f m b8 m e8 m fe m f3 m e4 m dd m fe m d9 m f6 m 72 m 1d m d6 m b9 m 47 m 68 m b m 48
m d7 m 1e m 5c m 76 m a3 m 2e m 85 m e8 m f2 m 57 m 11 m f6 m df m 45 m 89 m 7d m d7 m b2 m e9 m e0 m fd m d8 m 9b m f m ae m
38 m aa m 4b m cc m 1c m 89 m 8 m 31 m a7 m e6 m 3 m ee m c7 m 9b m 27 m f6 m 58 m 1f m 1 m 40 m 49 m 38 m a1 m 10 m c2 m 8 m
c7 m 7 m 89 m 98 m 73 m ee m 2b m c0 m fe m 6a m 2d m ec m 8b m 56 m cb m 3b m 35 m 1c m ba m 83 m 6 m 97 m dd m 40 m ac m 86
m notbusy
02 wcmd 8 m 31 m 0 m \ 0x83100 
4a m de m ed m bf m f3 m b4 m a7 m 38 m b2 m a m 27 m e6 m c0 m 86 m 30 m bc m 26 m a8 m 55 m 27 m 56 m f7 m fe m 3a m 31 m fb
m be m 39 m 71 m 47 m e3 m 79 m 9a m 16 m 79 m 47 m 50 m e4 m dd m fe m da m f6 m 5a m 1f m 15 m 7 m 49 m 44 m dd m f0 m 82 m
10 m c8 m 39 m af m 75 m 79 m bb m 3 m 6d m 6f m 9a m 14 m a m b2 m 88 m dd m 1 m 79 m b7 m 6d m db m 43 m 1c m 49 m 79 m 5b m
b7 m 84 m 14 m 42 m 18 m f5 m 1f m 7c m 94 m 61 m 3f m 9f m 9c m 7d m d8 m ca m d6 m 9 m ca m 96 m c3 m f0 m 82 m 3 m f2 m ae
m 6a m 7b m 1d m f7 m 86 m 12 m 9 m ca m d9 m aa m 23 m 82 m bc m cd m 6d m b m e5 m fb m f3 m 14 m ed m 75 m c3 m 22 m f2 m
74 m 89 m 82 m 16 m ca m bb m fd m dc m a4 m 3 m 80 m bd m 8f m 7b m a3 m 86 m 82 m 48 m 2c m bb m 11 m 41 m 79 m 6e m 6c m d3
m 58 m be m 6d m 2f m 69 m dc m ef m 5b m 2d m ef m f2 m 44 m 1d m 90 m 77 m 8b m db m 9e m c7 m eb m 34 m d2 m a0 m 3e m d2 m
f0 m f7 m 81 m 34 m 63 m b m cd m f0 m de m 6f m 67 2 r 9f m 35 m 27 m ef m c4 m b6 m 1b m 5e m 71 m 40 m de m 55 m 6d m 5f m
c4 m bd m 2d m 70 m 87 m 84 m a3 m fe m d1 m 99 m dc m 0 m 7 m 4c m 86 m 7d m d5 m e m c8 m bb m 95 m da m 1e m c7 m bd m c1 m
1b m de m 88 m b2 m c1 m b2 m 22 m c8 m 8a m 43 m aa m 50 m 3c m d0 m f6 m ba m d9 m 8a m 9d m 42 m 69 m 1b m 79 m 87 m 7 m
notbusy
02 wcmd 8 m 32 m 0 m \ 0x83200 
e4 m dd m 2e m e7 m 33 m d4 m a3 m 39 m 5a m dd m 36 m 15 m 53 m 4a m de m 8e m 2e m f1 m b5 m 3b m e5 m fa m 95 m 57 m c9 m
b7 m 21 m 63 m 47 m 6d m 93 m c m b3 m 1d m a5 m 7b m d5 m b7 m a5 m 7c m c3 m 52 m f2 m 6e m d7 m 9 m db m e4 m fc m 6d m a6
m ed m a m 8e m e6 m 8d m 62 m f9 m 7f m 1d m a m b4 m 75 m 6f m 9d m a2 m d1 m 3d m 2a m e3 m 56 m 9f m 9d m e5 m c9 m 58 m
a7 m ed m 85 m c0 m b5 m 3e m 52 m fb m bf m 37 m df m b7 m c5 m 18 m 0 m 60 m f3 m f2 m ae m 45 m c1 m a2 m ff m df m 2b m 44
m cd m 1f m f0 m 79 m 14 m ec m 10 m 47 m c3 m e m e7 m 9 m 12 m 17 m 1c m 95 m ac m 6f m 3b m 11 m 64 m f8 m 4 m 73 m 8e m b0
m 9a m d9 m dd m 21 m a3 m fe m 71 m e9 m 86 m 73 m 7f m d8 m dd m 66 m a4 m 6d m cf m 52 m 1b m eb m db m d m 3b m e2 m 52 m
f2 m 6e m 17 m 6c m 3a m 5c m f4 m e3 m ce m e7 m 6f m 6d m 42 m 9a m bf m 6f m 11 m b0 m 13 m 1c m 61 m f3 m 5b m 0 m 40 m e9
m 4a m ff m 37 m 55 m 17 m 61 m 41 m 52 m 6b m 7e m 4 m 5d m 3a m 9d m db m cf m d1 m 3a m 64 m ac m 32 m 17 m 8d m 70 m d4 m
46 m d8 m 39 m e9 m 73 m 5b m c4 m 6d m 38 m 26 m 96 m aa m 1e m 4a m 84 m 67 m 29 m 79 m b7 m 43 m ba m e6 m ce m df m f0 m
7f m d7 m 9c m bf m 75 m 8 m 69 m 53 m 52 m 8 m 18 m f5 m bf m 2e m 8e m 86 m 2c m 35 m 98 m e7 m aa m ab m 94 m d m 4 m b0 m
f9 m notbusy
02 wcmd 8 m 33 m 0 m \ 0x83300 
40 m f5 m 61 m 1b m f4 m ba m df m 2d m 81 m a2 m 6d m c9 m 70 m 2f m 9c m 1c m 97 m b6 m 86 m 62 m 71 m f m 38 m fa m 1c m 13
m b1 m 6a m 6b m 91 m a0 m 1c m ed m 7e m 57 m bd m db m c6 m fb m 76 m 73 m 93 m a7 m 6c m b7 m e4 m 5d m b3 m d5 m c3 m 3b m
c6 m d4 m 8e m e7 m 6f m 4d m 42 m c6 m 3 m 9b m 3c m 82 m 47 m fd m af m 87 m a3 m f1 m cc m 36 m c7 m 61 m 60 m e5 m a3 m ff
m 94 m e9 m 9a m 23 m e7 m 46 m 4f m 5b m 97 m 8c m a1 m f0 m 4a m 46 m d7 m 52 m 53 m e1 m 9f m 67 m 1f m cb m db m 9b m cb m
3d m dd m 8 m 4a m ee m e7 m b1 m 29 m e9 m 5e m 70 m 73 m 7d m 63 m f2 m 9 m f6 m 95 m 62 m 1a m dc m bf m 92 m bc m 5b m 4c
m c3 m f0 m f5 m 76 m 6f m fe m d6 m 21 m a4 m a2 m a4 m 74 m 8c m 75 m f7 m 83 m cd m 3c m 6b m e0 m 68 m c8 m 5b m fe m 5f m
f9 m 92 m c0 m 5e m 55 m 8a m 4 m 16 m 9 m e6 m a0 m b4 m a8 m 9f m c5 m bf m 5f m 93 m c m 90 m 21 m 71 m bf m d8 m ae m f m
79 m 6a m fd m 5 m c6 m 43 m bd m 76 m 53 m 82 m ea m 2 m 70 m ce m 28 m d5 m 8f m d m f7 m d m 59 m cd m 40 m 51 m 34 m 36 m
55 m 8b m e4 m dd m 7a m 28 m 6a m 89 m a8 m 31 m 96 m 6 m f3 m 97 m a9 m 5d m 7a m fe m 56 m 26 m 64 m c0 m 45 m 15 m 13 m e9
m e1 m 83 m 46 m 8f m ef m 7c m 65 m 1c m d5 m 90 m b5 m bf m 9e m 85 m 1 m 73 m 67 m 20 m 47 m 81 m e5 m 2 m ea m 3e m 7a m
notbusy
02 wcmd 8 m 34 m 0 m \ 0x83400 
60 m 62 m 6c m ce m c m 34 m 2d m 89 m dd m 20 m c3 m fd m d0 m 18 m 8c m b9 m 7d m 60 m d5 m c9 m 60 m c2 m 77 m de m 92 m 7c
m 54 m 35 m 2f m 93 m 9b m df m 2 m e1 m 8d m f6 m 8d m 90 m fc m 7a m 50 m a5 m 72 m e6 m b7 m 1d m a0 m c8 m b m c1 m 7a m e
m eb 2 r 1c m 1b m 95 m f9 m 1b m 2a m f1 m f5 m da m bc m 51 m f6 m 54 m a0 m 97 m 34 m 50 m 7a m 77 m 2a m 69 m 35 m 1c m d5
m 9d m a2 m 67 m b0 m f1 m 4 m db m c m a9 m 83 m a4 m 71 m 52 m 67 m 56 m 8f m 27 m 61 m 7b m 8 m ed m 84 m 8c m 84 m 76 m e2
m 95 m d m c6 m bc m 99 m b0 m a9 m 46 m 7d m ae m fb m 66 m f7 m b8 m 59 m a9 m 29 m 24 m d6 m f5 m 63 m 1d m 8e m 37 m dd m
77 m d2 m 77 m ac m 43 m 8 m f3 m e7 m 63 m 99 m c9 m 6a m de m 67 m 9f m 3b m 98 m bf m 25 m 24 m e1 m 6a m 84 m 8c m c5 m 65
m 69 m 9 m ca m 51 m 69 m 45 m dc m 95 m 79 m 5a m 5 m 47 m 85 m 7d m cb m 5b m 57 m 3c m e6 m 71 m ec m 5e m 3f m cf m 51 m
59 m 8a m b0 m cd m 2d m eb m bc m f9 m e m c9 m 90 m 13 m 18 m dd m 80 m a8 m b8 m 69 m 76 m 63 m 73 m ab m c m e6 m fb m da
m 3d m 5e m ce m ff m f2 m c1 m ab m 7a m 42 m a4 m 19 m 5a m fe m d m 37 m dc m b7 m 62 m c9 m 56 m 85 m e6 m 1b m e m eb m
42 m 68 m fe m fc m d5 m af m 27 m 97 m ad m 3f m 7f m eb m 10 m 32 m 67 m 8c m 55 m cc m a0 m c3 m 70 m aa m 81 m b4 m 3c m
notbusy
02 wcmd 8 m 35 m 0 m \ 0x83500 
8e m 3c m 74 m 7d m 8f m 8e m bb m 2a m 14 m bb m f9 m 11 m bb m 1 m d1 m a5 m 92 m 20 m 2c m 12 m 74 m cb m 91 m e1 m 99 m 6b
m 40 m 86 m d1 m a1 m 64 m 8 m 9f m 8 m a3 m 62 m d2 m d1 m 18 m f8 m 4e m a3 m ce m a m 7c m 50 m 19 m c m fd m 74 m ef m 88
m 9f m 93 m 7d m 1a m 75 m f2 m d5 m 80 m 24 m aa m bc m fe m d8 m 50 m df m 49 m c m 61 m b7 m c2 m ba m 2b m 70 m f5 m 6d m
c1 m fc m a9 m 49 m 39 m 67 m fe m bc m a0 m 59 m 72 m fe m 96 m a3 m a4 m 26 m c4 m d1 m 91 m 2f m 49 m 50 m d8 m c7 m e9 m
a4 m c m 62 m fd m 79 m 59 m 1c m d5 m 28 m 72 m bc m 5b m b3 m b0 m 49 m 92 m 4 m 45 m 8c m 24 m ad m 56 m 4b m 88 m e5 m 18
m cb m 7c m e9 m 8a m d3 m 34 m 4 m f3 m 1c m 32 m 6c m 26 m 2a m 32 m ec m 6f m 25 m 5a m 44 m 43 m f m 45 m 5a m 99 m 69 m
83 m 90 m 7e m a9 m 99 m 79 m c7 m bc m 5c m a4 m 6d m b2 m 7f m 59 m 29 m 9 m 21 m 9e m 86 m d m f7 m 2d m 36 m 38 m 96 m 91
m dc m 5d m 20 m 79 m 15 m e0 m d5 m bc m 4d m 5f m fd m 76 m 15 m 8d m ab m cd m df m 72 m 94 m 38 m 14 m 39 m 69 m 8c m 6a m
d4 m 16 m 1c m 69 m cf m 60 m 7 m b4 m ab m bd m 90 m bf m 2c m 89 m 23 m 9b m b5 m 82 m 21 m e3 m a9 m d6 m 4 m 57 m 33 m 64
m 92 m e m ed m cc m de m f6 m 1a m f9 m 3a m 64 m 14 m 2a m 1c m 19 m 8a m 68 m 13 m 26 m 7a m 56 m 7d m f9 m c0 m 41 m dc m
61 m notbusy
02 wcmd 8 m 36 m 0 m \ 0x83600 
30 m 13 m 3 m 18 m d m da m f0 m 65 m 77 m d2 m 8a m ac m 93 m 53 m 36 m 92 m 29 m 25 m d0 m 37 m 45 m 47 m c5 m 66 m fb m 86
m 4 m 49 m 47 m 73 m f7 m 81 m b4 m 70 m fe m c m be m de m b0 m 69 m cd m 9f m 40 m 69 m e1 m fc m 2d m 43 m 48 m 5 m e7 m 32
m d3 m ca m 46 m 42 m 68 m 19 m a3 m dc m 37 m 60 m ca m f0 m 46 m 6f m da m 2d m 85 m a3 m 22 m 18 m ab m 97 m 27 m 18 m b2 m
56 m 35 m bb m c9 m f7 m 9f m b5 m 2f m e6 m 6d m 61 m aa m 93 m d6 m d2 m 46 m 45 m b m 7b m 45 m b1 m d m 19 m 26 m 6f m 3d
m ab m fa m f8 m cb m c0 m 38 m 70 m 30 m 42 m 44 m c8 2 r 27 m 44 m 9f m 55 m 86 m 85 m c9 m d6 m 61 m 35 m b m a3 m 42 m 61
m 12 m ae m e8 m 93 m d7 m d5 m 77 m 2c m e2 m 67 m 13 m 7d m 73 m e9 m 18 m 7c m 47 m 6b m f6 m d0 m 6c m db m cf m 9f m 5a m
ce m 3b m 9d m bf m a5 m 9 m f1 m 26 m 8d m 27 m a2 m 70 m 91 m c0 m 58 m 1b m 2b m 8a m 2a m 4f m 6d m 29 m 1c m d m 5f m df
m 75 m 4a m f5 m 20 m 8 m 32 m b0 m 38 m 47 m ca m 1e m d9 m 45 m 42 m d9 m cc m e2 m 4 m eb m f2 m 6d m 1 m 19 m 15 m 21 m 4d
m 32 m aa m 81 m 28 m cd m d9 2 r d m 91 m 56 m 7a m 50 m 8b m 94 m 5c m 47 m bb m c0 m 65 m 62 m b7 m 18 m 79 m 5c m d1 m 57
m d3 m e0 m 15 m f9 m 86 m fa m e6 m a4 m a6 m 1d m 22 m da m 48 m ef m 56 m 5b m 6e m fe m a0 m bc m 9d m d2 m 59 m a3 m
notbusy
02 wcmd 8 m 37 m 0 m \ 0x83700 
68 m 85 m f9 m db m 96 m 90 m 31 m 1d m 15 m 9a m 2a m 2 m 64 m 72 m 90 m 53 m 4a m 3c m 2 m d2 m f6 m 38 m 1a m 60 m 57 m ba
m 25 m fd m a0 m 7a m c m ca m 0 m 68 m f7 m 9e m 2d m 10 m 81 m ec m 88 m 44 m 5c m 6d m 9a m c4 m c m 76 m 6a m d8 m 91 m 30
m d0 m 15 m 4e m 21 m 79 m 18 m 71 m 4a m 89 m a9 m 62 m 57 m 90 m 99 m a8 m 45 m 9a m 99 m 1e m da m 9 m c9 m fe m 6a m 39 m
b7 m 9b m 64 m 24 m 76 m 6e m 5e m a9 m d5 m c0 2 r 29 m 71 m e2 m c4 m 94 m ca m 61 m 42 m 32 m 64 m 5 m c8 m 1b m ee m 9b m
53 m 62 m 48 m 9 m c1 m 4c m 86 m 5d m e8 m 46 m 9a m 6a m d7 m 7a m fe m 1a m 13 m 8 m 15 m 63 m 24 m a5 m 51 m a6 m 6c m a9
m f9 m 5b m 86 m 10 m 6f m 5a m 15 m 28 m 17 m 76 m f6 m 38 m 92 m 8e m 39 m 21 m 27 m 48 m c m c4 m aa m 4 m b5 m e3 m 6d m
71 m 54 m f7 m 5a m 40 m 64 m 13 m 4b m f6 m 33 m 94 m a1 m 4f m 1e m 47 m 9c m 38 m 1 m ab m 65 m 17 m ea m 5d m fd m ab m cd
m 42 m 2d m ca m c8 m 29 m a m 23 m 43 m cd m 6c m d3 m 47 m 95 m 28 m e3 m c4 m 29 m 31 m a7 m 84 m 3a m 17 m 3a m f8 m 2a m
d2 m 40 m ed m 29 m c8 m 78 m 94 m da m 53 m 72 m 36 m 34 m 5a m a9 2 r dd m d0 m a m 1a m 2d m cb m 66 m 15 m 27 m e6 m c4 m
cc m c4 m 64 m 40 m c2 m cc m d3 m a4 m 44 m 6c m ac m ef m 7c m 58 m 65 m 62 m ca m 43 m 22 m 6 m ed m e m 6c m c7 m ba m
notbusy
02 wcmd 8 m 38 m 0 m \ 0x83800 
cd m 9b m bf m c2 m 42 m b5 m 40 m 1e m e0 m a8 m 9a m 3f m a6 m 6a m fe m 30 m 55 m f3 m b7 m d m 92 m da m 28 m 52 m 4a m 2a
m 3a m 40 m c2 m c m da m 35 m 13 m 23 m 32 2 r 24 m 26 m 6 m 33 m 27 m 1 m 60 m 7b m 1c m 99 m 14 m a9 m 50 m a4 m 13 m eb m
4 m b4 m df m 1c m 99 m bb m 87 m 54 m 60 m c4 m c0 m ea m 22 m 5 m f2 m 2a m 69 m c9 m 19 m 12 m 65 m 34 m 7c m 77 m c7 m 5e
m db m 92 m 21 m 84 m 64 m 8e m 49 m 4c m 9c m 18 m d5 m 92 m 1 m a8 m 23 m cd m b9 m 4f m 14 m 8f m ce m 8e m 57 m 27 m 2d m
ee m 41 m 98 m ab m 1f m ee m dc m bc m aa m a4 m 8d m 36 m 3 m 12 m 38 m a m 70 m 6f m fa m e6 m c4 m 79 m 9e m c8 m f1 m d2
m 8e m db m 40 m 19 m d5 m f3 m 67 m 1f m de m 70 m 85 m 12 m 67 m d8 m 6e m fe m f2 m 85 m cb m a9 m 24 m 7 m a3 m da m 6a m
27 m cf m d4 m e6 m c0 m ab m c6 m 96 m 11 m 42 m 44 m 64 m 0 m a6 m c m 24 m 67 m d9 m 2d m c6 m 51 m ab m 57 m 27 m 1c m ed
m a3 m 96 m 93 m 32 m 0 m 9 m d4 m 94 m 62 m b1 m bd m 1 m 20 m d7 m ad m ab m cb m d9 m 2e m 31 m b m 6a m d3 m f9 m 77 m 57
m 5b m 6b m 19 m 32 m 52 m 2a m 73 m 20 m 4c m 43 m 8c m 5 m 49 m 65 m 2e m ac m 4b m 41 m 91 m c0 m 28 m e4 m ea m 53 m 14 m
88 m 28 m f8 m ad m a0 m 2b m 9b m 3d m ee m 6a m 53 m 9 m a6 m 10 m 22 m 33 m 73 m 4c m 31 m 61 m 62 m 8b m 71 m 2a m 8e m
notbusy
02 wcmd 8 m 39 m 0 m \ 0x83900 
89 m 2 m 6e m b4 m ef m c8 m cc m 31 m 61 m 9 m 35 m 98 m 55 m b7 m 43 m 34 m 95 m b0 m 4d m 7b m fe m e4 m 9b m 32 m 7f m a6
m 90 m b6 m 9b m 3f m f5 m 96 m f2 m c5 m d5 m 92 m ce m dc m 1 m 28 m 6a m 81 m 9a m c m 5d m c4 m 31 m 80 m c0 m 98 m 39 m
e5 m d1 m c9 m c m cb m f9 m 77 m a9 m 1c m 2f m bd m 10 m 47 m 6 m 23 m 4 m 44 m 20 m 31 m d4 m 8b m 6c m b4 m d6 m 64 m e0 m
a2 m f m 59 m cc m 29 m 0 2 r 24 m d4 m 73 m a m ea m 5a m 33 m b m c8 m 90 m 5 m 2 m 45 m b3 m 92 m 31 m a4 m a2 m 45 m c6 m
60 m 1a m bc m e0 m 65 m 96 m 99 m 60 m bd m 54 m d6 2 r 74 m e2 m 75 m c6 m 73 m 21 m c4 m 40 m f9 m 9c m 92 m 50 m d4 m c2 m
a m 1e 2 r b6 m 7e m 72 m 66 m a7 m 10 m 14 m 39 m 72 m a4 m 88 m 8c m 99 m 9d m c1 m 53 m a0 m a m 71 m 33 m 7d m c7 m 10 m
89 m 23 2 r a3 m c4 m ec m a8 m 76 m 34 m d7 m 6f m 9e m 8d m e6 m cf m 9f m 89 m c2 m e6 m fc m 71 m b2 m f9 m 8b m c9 m cd m
1f m a6 m 6a m fe m b2 m cf m 32 m cf m b6 m 1b m ab m 5 m d2 m c0 m d7 m 80 m 92 m fc m f6 m 80 m a m a3 m c4 m 1c m 29 m 72
m c4 m 28 m 94 m b1 m e4 m 6 m 2d m b3 m e m 5b m c0 m 3b m e8 m 55 2 r 4a m a8 m bb m 96 m 42 m cf m 19 m aa m de m ae m cc m
ef m 9f m 52 m 2 m 48 3 r 76 m 8e m fc m 52 m 38 m 52 m 6d m ed m 63 m b m c5 m d6 m c2 m b0 m 98 m notbusy
02 wcmd 8 m 3a m 0 m \ 0x83a00 
c m 67 m 5d m a m 88 m a2 m 7d m 30 m 33 m 32 m aa m 50 m cb m b3 m 56 m 6f m fe m 13 m 36 m e m 72 m 5a m 93 m 43 m 92 m 89 m
ac m 95 m 62 m 25 m 83 m af m 1a m 53 m 35 m ca m 62 m a4 m 48 m 91 m 22 m 33 m 8b m d9 m 6f m fa m 30 m 43 m 99 m 36 m d6 m
77 m e4 m d8 m 33 m 45 m e4 m 3c m 53 m 45 m 22 m ed m 86 m 32 m aa m 8d m 89 m 8a m 73 m 8b m 9d m 3f m 50 m 48 m 60 m 6b m
37 m 4e m 1e m 6f m 33 m 7f m c3 m 74 m 9d m 16 m 21 m 43 m db m 8a m 30 m 60 m 40 m 4f m 6 m 21 m 89 m e9 m 9c m c0 m 46 m 88
m 22 m 45 m 8c m 18 m f3 m c8 m e9 m 19 m 1b m a m a6 m 5 m 38 m 72 m 30 m 92 m 0 m 8e m bd m 7d m a8 m d m 1d m 3f m 2 m de m
a0 m 52 m e7 m 59 m ed m ee m 94 m 20 m 1 m c9 m 19 m 62 m 72 m df m 92 m 73 m 61 m a9 m ae m 1e m 44 m 4a m c1 m 36 m 64 m 94
m 69 m 88 m 26 m f4 m 89 m 45 m 4f m 53 m 44 m 86 m 64 m 32 m d m 34 m 8d m c0 m a9 m 23 m 3d m f4 m ac m cb m ff m c8 m 9d m
9e m b5 m 2c m 2b m 63 m fd m 5d m f9 m 51 m a5 m d m 73 m cc m 87 m 80 m c7 m 3e m 22 m 23 m 47 m 24 m 76 m 38 m a m 82 m e4
m 8d m f5 m 1d m 39 m f6 m 44 m 3d m 22 m 46 m 44 m 4e m 79 m 8d m 62 m 77 m e3 m 74 m d8 m 9a m 3f m 37 m 7b m c1 m 34 m c1 m
d8 m ae m e3 m c2 m 47 m 1c m 79 m 38 m 7f m c5 m a6 m a8 m 17 m 47 m 17 m 12 m e2 m 18 m 3a m c m 49 m 41 m 12 m 7d m 64 m a
m notbusy
02 wcmd 8 m 3b m 0 m \ 0x83b00 
3b m 32 m 51 m 44 m c4 m a8 m eb m 5 m 8c m 55 m ce m f7 m 7c m 1c m a9 m 4d m 5b m b4 m 80 m 9c m 46 m 59 m 84 m a3 m e3 m e0
m 52 m cb m ac m d2 m 47 m 9c 2 r 21 m 95 m 18 m 52 m 2 m 44 m a2 m ae m 9c m cd m b2 m cc m 3c m a0 m e6 m b9 m 82 m 9b m 85
m 90 m b9 m 4b m 3e m e6 m 92 m 51 m 99 m 75 m 51 m a6 m 21 m 72 m 8c m 9c m ad m 18 m 46 m ce m 8c m 93 m 38 m 27 m e5 m f m
d4 m 11 m 61 m 39 m 4 m 28 m 74 m c1 m 4e m a1 m 23 m 6f m 80 m ac m 62 m 5f m 61 m f9 m 97 m 6d m ab m 94 m 12 m 27 m 43 m 11
m 51 m 4f m 11 m 23 m 8a m 42 2 r 24 m f4 m ea m 70 m 83 m 7d m 53 m ec m 91 m 32 m 90 m 52 m b2 m c5 m 58 m d8 m 21 m 9a m 94
m 7b m 1d m 1b m d9 m 4 m fa m f9 m cb m 8c m 34 m f0 m fe m bc m 3e m 2a m 30 m 8a m 3c m 98 m 3f m 6 m 3f m 7f m 73 m 80 m
e4 m d5 m 42 m c5 m 48 m 6a m 33 m 2b m 21 m 41 m c9 m 0 m c1 m 91 m 18 m bd m c2 m ad m 39 m 9b m 2 m 11 m d1 m 25 m 9f m cf
m c7 m d1 m 0 m 46 m aa m ff m 8a m ab m 50 m fb m b m d4 m 50 m 4 m d5 m fb m c7 m 1c m b6 m 4b m 0 m aa m 8f m f2 m 8d m db
m 4d m 43 m 7e m 9b m a2 m 8d m cc m ae m ac m a8 m 70 m 64 m 88 m 3c m ab m f4 m 91 m 5a m d7 m 59 m 96 m c5 m 18 m 39 m c6 m
18 m b2 m 5 m 15 m 11 m 31 m c7 m 32 m fd m fa m 38 m 18 m 17 m a9 m 59 m d5 m 65 m 24 m 75 m 21 m 74 m 3 m cb m 6e m 5 m
notbusy
02 wcmd 8 m 3c m 0 m \ 0x83c00 
ad m 60 m e m b7 m d m 93 m 44 m 83 m 22 m c7 m 18 m 63 m df m 53 m 9f m 87 m 31 m 22 m a m 8e m 90 m 28 m 64 m c1 m d3 m 89 m
36 m dc m 50 m df m d4 m b m 74 m 22 m b2 m e2 m 68 m c7 m 51 m 86 m 31 m 1b m 59 m d8 m c6 m 4f m a1 m d7 m 4 m 48 m b5 m 3e
m 4a m b2 m bc m a5 m ae m 7e m cc m 7f m 23 m 71 m 7b m fe m da m d1 m 86 m 96 m 5a m a8 m 38 m 49 m 19 m 49 m f1 m ac m 38 m
e2 m 54 m c3 m 28 m 64 m c1 m 8c m 88 m e8 m 96 m 90 m e6 m e1 m 28 m 77 m 8b m ba m 7e m 81 m 4e m 15 m 5 m 2f m 1c m 33 m 92
m 70 m 5b m 1c m 45 m 35 m ed m 0 m 21 m 3b m 48 m c2 m 13 m 4b m 4c m 45 m 42 m 80 m a4 m b m 29 m 35 m 8a m 42 m 47 m 45 m
4c m 87 m 6 m 19 m e2 m 4b m 9b m 5e m d4 m 49 m 88 m 31 m 46 m 22 m 8a m 14 m b1 m cc m 44 m 9e m 85 m 64 m ac m 66 m 86 m 48
m d0 m c3 m d5 m bb m 2e m ab m 24 m c5 m ac m 0 m 76 m 19 m 2f m 4f m 3e m b2 m 44 m 70 m 6e m 8a m 38 m fa m a2 m 8c m 22 m
f5 m a0 m 40 m 4a m 9 m c0 m cc m e0 m 2e m 64 m 10 m 6f m b0 m 6f m 67 m 1f m a8 m c8 m dd m a9 m 69 m 57 m 73 m 6f m 2d m 5
m bb m 5a m cb m 56 m 41 m 94 m 6a m 11 m 14 m 6a m 39 m 68 m f3 m 17 m 89 m c4 m 6 m ce m f3 m 97 m 18 m a0 m 6c m e m aa m
81 m 34 m 24 m a4 m 30 m 92 m 18 m cc m 5d m a6 m 87 m dc m 69 m 34 m 32 m 10 m cc m 1c m 23 m 91 m 84 m e8 m 52 m a m 29 m 71
m notbusy
02 wcmd 8 m 3d m 0 m \ 0x83d00 
fe m ed m f6 m fb m f8 m a m 8c m 9c m a m c m 5 m 45 m 9d m 1b m 2 m 5 m f0 m 8d m 6f m 7f m d4 m cd m af m 55 m 3d m 65 m f6
m f9 m cf m 9c m f3 m d5 m 2 m 23 m 5b m 9b m 20 m 92 m 27 m 6c m a7 m 8f m f2 m bb m a0 m ed m 5e m 22 m 32 m 8d m d8 m a9 m
8c m ae m 26 m 2 m 89 m 7e m f0 m f6 m b7 m 1e m 90 m f1 m bd m 2f m 9e m 77 m e6 m b7 m 7 m 38 m ea m 95 m 6f m 11 m 19 m a3
m b8 m 8c m 66 m 65 m 7b m 33 m da m e4 m 56 m 8 m e1 m a0 m 87 m fe m fa m 64 m 21 m c1 m 3b m 6e m 5f m 79 m f1 m 67 m cc m
a6 m e4 m 6c m d7 m 65 m a3 m 32 m 1c m f4 m d0 m 5f m df m f0 m 21 m a4 m 5f m 7e m f1 m 67 m e4 m 3b m 64 m ce m 73 m f m 82
m bc m 35 m 55 m 92 m b1 m 11 m c m 98 m 37 m 4 m d1 m b1 m 32 m 81 m 6a m 9a m 23 m e1 m f5 m 6f m 7f m f4 m cd m f m af m 9e
m f2 m bd m f3 m cf m fb m e4 m 77 m 5d m 28 m 26 m c6 m c8 m 7d m 8c m 7d m e8 m 29 m 23 m 29 m 22 m 2 m 20 m cb m ea m 28 m
8a m 75 m de m da m c m 59 m 8 m 41 m d3 m 89 m 15 m 47 m b m 8e m 8 m 11 m c3 m ad m 8e m b9 m f9 m cd m e m b6 m 47 m 7c m
f1 m 1f m de m 2f m 21 m 2b m 62 2 r 4a m 88 m e8 m ba m 69 m 8f m 4f m e9 m 96 m a m 27 m 79 m 10 m 75 m 5 m 49 m 14 m 88 m e
m b9 m c7 m bd m 6e m 3c m 77 m 30 m bf m fa m 81 m f m 5e m 25 m 58 m 4a m 89 m 13 m 2 m 10 m 51 m e8 m ba m 6e m notbusy
02 wcmd 8 m 3e m 0 m \ 0x83e00 
32 m 99 m 74 m d3 m e7 m e m ae m be m ea m a9 m d7 m 5c m 73 m f5 m 35 m 57 m 5f m 73 m cd m 35 m d7 m 6c m cd m fa m be m 8f
m cc m 39 m 35 m 90 m c0 m 74 m 62 m 71 m fa m bb m 32 m 11 m 81 m e8 m 90 m 7b m dc m f3 m 26 m 73 m c9 m f8 m d2 m fb m 3f m
b2 m 25 m 38 m ca m 20 m 8a m b1 m cf m 70 m 8a m 31 m a m d0 m 93 m a6 m 2 m 82 m ad m db m 84 m ac m 89 m 26 m 5d m 37 m 99
m dc m e9 m 85 m 73 m 9f m be m 7b m ed m ac m 67 m 6c m f5 m 7d m 1f m 63 m e4 m 94 m 12 m aa m 15 m dc m dd m e9 m 2f m f6 m
a0 m ef m 33 m 9f m 71 m 8d 2 r 39 m 2 m 51 m d7 m 75 m d3 m e9 m f4 m a0 m 83 m e m 9a m 1e m fc m 92 m c1 m a5 m d5 m 3c m
cd m 32 m c1 m 2e m 9d m 29 m 37 m 34 m ee m 25 m d4 m 88 m 8d m f0 m 51 m e7 m fe m aa m 3d m 31 m b9 m cb m 3d m 8f m 9c m
4b m db m e7 m ff m eb m bf m 7b m c3 m 91 m ce m 5d m 3d m 7f m c9 m 82 m 59 m 39 m 9f m d3 2 r 51 m 11 m 82 m 15 m 3f m 7b m
42 m 4 m 47 m 37 m bd m f7 m bd m 46 m 27 m 6c m c0 m 95 m f m bd m b8 m 9f m f5 m 7d m 3f m cb m dd m 66 m 86 m c9 m 91 m c2
m b6 m 5d m 57 m 19 m 75 2 r af m e2 m 25 m 38 m 20 m d1 m 4d m 7e m ed m b6 m b m 27 m e7 m 87 m 7f m f3 m 37 m e1 m bd m ef
m b8 m bc m 28 m 24 m 44 m 22 m 52 m 63 m 7f m c1 m 8d m 39 m a1 m c0 m c8 m 11 m 8f m 9b m a m 92 m 8b m e7 m 1f m 28 m fc m
notbusy
02 wcmd 8 m 3f m 0 m \ 0x83f00 
d0 m 83 m 6f m b7 m 90 m 8c m 9b m fd m f6 m 6f m c3 m 47 m df m fa m 6d m 8e m 91 m 43 m 8c m b1 m f m 7d m a4 m 9e m 62 m 76
m a m 62 m 56 m 7d m 9a m 16 m 23 m 1d m 42 m 81 m 13 m 51 m a0 m fb m 3e m 67 m 61 m 7 m bb m d4 m 6e m ff m d6 m 5f m 15 m
24 m 73 m 4a m 8 m a2 m b m 7f m ea m 59 m 7b m d1 m f7 m 1d m fe m f9 m 81 m c2 m 17 m 64 m 9 m 24 m 3b m f0 m 8e m d0 m d8 m
88 m ca m 30 m 16 m 67 m af m b m 7e m fe m ae m f7 m 2b m 77 m 5b m f8 m b0 m 5b m de m f2 m 77 m e1 m fd m ff m 72 m 99 m e0
m a8 m f m 31 m 64 m 77 m 92 m 72 m 6c m 24 m 22 m 20 m 3 m 53 m 62 m db m b9 m 6a m a m c9 m f1 m 33 m d m d4 m 82 m 72 m 92
m 32 m 34 m 85 m 10 m ee m f9 m 80 m eb m 34 m 29 m b8 m d6 m 3f 2 r f0 m 62 m 66 m c2 m 9c m cd m 50 m c m bb m 45 m eb m b0
m 25 m da m 6f m 2a m d0 m 8c m f4 m 32 m 4 m 21 m 1c m f6 m 90 m 3b m 2d m 33 m a2 m f7 m bb m df m d6 m cb m cf m f1 m 86 m
1d m a9 m b1 m df m 18 m fb m fa m 3b m 75 m 2 m 44 m 1b m e9 m bb m 4f m b2 m d7 m 2f m f3 m 70 m e8 m 6f m dc m 75 m 19 m 32
m ee m 7a m 57 m 38 m f5 m 9f m ae m 8e m 21 m c6 m 3e m f4 m a1 m 27 m 8a m 3d m 8a m 67 m 1f m 1 m 10 m 19 m b2 m 65 m 97 m
c4 m 8f m b0 m 46 m 48 m 74 m c4 m 9e m c0 m 8 m 60 m 72 m d2 m 93 m 39 m 51 m ca m eb m 3b m 82 m e3 m 23 m f6 m 4 m 46 m
notbusy
20 wcmd 8 m 40 m 0 m notbusy \ 0x84000
02 wcmd 8 m 40 m 0 m \ 0x84000 
0 m 7 m 9d m f4 m 64 m 66 m 92 m fc m 31 m e7 m 1e m ad m 85 m 25 m 15 m 81 m c5 m 35 m 8 m 2 m a3 m 4e m 27 m 4f m f9 m e8 m
a0 m 5f m bd m ef m 32 m 4f m bc m f7 m bd m e1 m 9d m ef m 9c m c5 m 18 m 63 m 88 m 3d m 45 m a2 m 68 m 71 m 19 m 40 m 60 m 0
m c8 m 39 m a4 m 12 m 68 m b0 m 5a m 28 m 1e m 46 m 5e m 2d m a8 m 30 m 96 m f8 m 51 m 8 m 81 m ee m f4 m 7f m e m 99 m df m
ff m 3f m fe m 6c m 8e m e5 m 71 m f6 m c0 m 5d m fa m 4b m b m 47 m 58 m c3 m 48 m ad m 1b m 45 m 51 m 57 m 18 m f8 m 76 m 8f
m 5d m 7a m 50 m a7 m 4f m 84 m bf m 39 m 43 m 70 m 4 m 94 m 3d m a4 m ae m 71 m 5e m e2 m 90 m 14 m 1b m 4 m 8b m ff m ea m
24 m 74 m 36 m 11 m 47 m 3f m 61 m f9 m 63 m 33 m ee m 73 m 9f m 4b m 5f m f6 m e5 m 18 m 33 m 8c m 82 m ac m 99 m c8 m 54 m 0
2 r 48 m 4e m bc m e8 m 23 m 51 m 49 m 84 2 r f8 m fc m a5 m fb m d8 m 61 m bb m cd m 31 m 9f m 12 m ad m 90 m 57 m 9 m 88 m
e8 m cf m f6 m aa m ef m 1f m 3d m e6 m 53 m cc m 89 m 92 m f9 m 44 m 3b m d4 m 46 m b6 m e2 m 99 m e3 m 25 m 14 m 3a m 92 m
d9 m d3 m 8f m 10 m c2 m cd m 1f m 73 m d8 m d2 m 4f m fd m 85 m 5f m f8 m c6 m 2b m be m de m c7 m d0 m 7 m 8a m 44 m 3d m 51
m 2f m b1 m f2 m 98 m 49 m 4d m 9a m fa m 26 m a9 m d m 4a m 4b m 43 m 2d m 28 m 3f m 7 m 23 m e4 m da m f m 59 m 2c m 8e m
notbusy
02 wcmd 8 m 41 m 0 m \ 0x84100 
af m 75 m bf m 7f m 23 m 52 m 3b m a5 m 72 m c0 m 1a m 38 m 2a m ec m a3 m 30 m a m ba m 7c m e2 m 5a m e8 m c2 m 9d m 1e m b5
m f4 m db m 3 m 0 m c0 m 23 m 1e m f1 m e2 m cf m b2 m e6 m 9c m a8 m 89 m d8 m ea m de m be m a2 m b1 m b3 m e4 m e5 m 75 m
54 m 53 m d1 m 75 m a1 m 3b m e6 m f1 m ab m 91 m 71 m f8 m b3 m e0 m cf m 2e m 8 m 21 m 86 m 10 m c4 m 2a m d0 m e0 m c m 2 m
64 m cb m 40 m 87 m c1 m 87 m bf m f m ff m 91 m d5 m ba m d9 m 41 m 7b m e4 m 13 m 88 m 28 m ef m e3 m cb m 93 m 70 m d8 m 7c
m ef m 73 m b7 m db m 23 m 9e m 48 m c4 m 48 m c9 m 4a m 70 m ad m b m 24 m 8d m 96 m e8 m da m 1 m 86 m 8a m 79 m 27 m 61 m
22 m 9a m e0 m c8 m 3f m 5a m ed m c1 m 3f m 74 m fc m d6 m 9f m 7f m ad m f m 3d m e5 m 19 m 44 m ea m 51 m 72 m 5 m 0 m 73 m
e m 69 m d2 m b2 m d m 9e m 16 m e3 m 67 m 34 m 17 m c5 m 73 m 51 m 17 m ba m eb m 3c m e6 m 16 m db m f5 m 7d m ec m ff m ab
m c3 m 98 m b m f6 m 1f m d9 m fb m 17 m 18 m b9 m 5e m 27 m d6 m f5 m dd m 1e m be m da m eb m 3 m 0 m 3c m f1 m a2 m 13 m 66
m d9 m b0 m c3 m 90 m 3d m a4 m 85 m fa m 48 m d9 m 38 m c9 m 32 m ca m 80 m 8c m 49 m d7 m 85 m ee m 8e m 7f m b0 m 3a m 19 m
f0 m c m 38 m e1 m fc m 5e m 17 m 9c m b2 m 4a m 2 m d5 m 48 m c m a4 m 99 m d6 m de m b6 m c4 m 7b m ad m d1 m cf m 9a m
notbusy
02 wcmd 8 m 42 m 0 m \ 0x84200 
ed m a8 m 92 m b m 9f m 7 m 60 m f m fb m be m 2d m 21 m a1 m d3 m 47 m eb m 36 m 75 m 6a m 1 m d0 m 49 m e3 m 2e m 74 m 61 m
e2 m 19 m 29 m 1c m fd m e4 m d5 m 9f m 3d m 7d m e m ff m d9 m 97 m 2 m c5 m 3c m 7f m bd m 72 m 76 m 36 m 28 m 98 m 58 m 6c
m 3a m ef m 1f m 55 m fc m 4c m e m ce m c6 m cf m 87 m 3d m f6 m 88 m ed m 7b m fe m 1f m a m 23 m 1c m 8 m 98 m 11 m 8e m f4
m fd 2 r 12 m 64 m 28 m 9d m 4e m a4 m eb m a3 m fe m 70 m f5 m d7 m 7 m 80 m 1b m bd m f0 m 6f m 3f m 9d m 0 m 24 m c9 m ae m
8d m a3 m ac m 1a m 6c m ad m 43 m b2 m 1b m 25 m fc m 3b m 20 m e3 m 87 m d7 m f5 m 59 m 9e m 6 m 7f m fc m 9d m 6a m a9 m a0
m ac m 94 m e8 m 32 m 44 m 71 m cd m 10 m 0 m f1 m a6 m 6b m f6 m b4 m 4e m 23 m 24 m 62 m d1 m 91 m 88 m 8 m 3f m bc m 87 m
7d m db m 4a m fe m 8e m a0 m 64 m 30 m b2 m 55 m a3 m 90 m 25 m e7 m 24 m 4c m ca m c m 86 m 1b m f m c3 m b5 m 4b m 36 m 7a
m d6 m ec m 99 m df m e9 m dd m 82 m 93 m f1 m 35 m 2 m 23 m 10 m 97 m 4d m b2 m de m b2 m 18 m aa m 85 m 49 m 37 m 11 m 79 m
7c m ed m 27 m df m 6c m dd m 57 m 5 m 80 m 76 m 9c m a1 m 12 m 23 m 2 m 5e m ed m 35 m f7 m 7c m ed m 67 m de m 68 m dd m e m
7f m ef m 53 m af m cb m 38 m 92 m a8 m e3 m b8 m 73 m f5 m 6f m 2d m 5c m 96 m d5 m 51 m a0 m d0 m 5 m 19 m ff m 49 m notbusy
02 wcmd 8 m 43 m 0 m \ 0x84300 
26 m 63 m fa m b8 m c5 m 91 m c2 m 85 m ed m c4 m f m be m 56 m 57 m a m b0 m 38 m 43 m 80 m 20 m 6 m 76 m 21 m 62 m ef m 9b m
88 m b1 m b4 m 2f m fa m af m b8 m 72 m 47 m f m ca m 73 m 69 m 30 m ca m 7c m 34 m 9 m 93 m 49 m d7 m 4d m 26 m 5d m 37 m e9
m a6 m bf 2 r 38 m c4 m ba m a8 m 4d m 4e m fa m c0 m eb m 15 m 47 m 25 m 6d m 37 m 87 m 16 m 18 m 88 m 25 m 83 m 54 m df m a9
m 86 m 51 2 r b m 22 m 90 m 7f m e6 m 57 m 97 m 7e m a9 m 76 m 1b m e2 m c8 m a9 m 1 m 8d m 6c m 68 m af m c2 m be m 93 m ae m
fb m 85 m 5f m 5e m f3 m e5 m 1 m 0 m 6e m 77 m d2 m b3 m 23 m 5a m ec m 6d m 91 m 5d m 67 m 3a m 14 m c4 m aa m 13 m 30 m 2b
m 8e m 7e m fc m f7 m 76 m 40 m 6 m c0 m 4f m fc m c4 m b m 3f m 43 m 25 m 55 m 5f m ff m 5b m 36 m 32 m fb m 96 m 0 m 52 m fa
m ca m 8e m 3a m 5b m ad m b9 m b4 m 10 m 4c m 90 m e0 m cb m 7b m d9 m f7 m 6e m 80 m d7 m f8 m 57 m ad m a9 m cc m bd m 13 2
r c6 m 93 m 6e m d2 m dd m 75 m 67 m f3 m 77 m af m 7b m bd m e8 m 9c m a2 m 8f m b4 m cf m 4 m 0 m c0 m 80 m e0 m b6 m 93 m
f9 m 2c m 86 m bc m 1e m 68 m 94 m 4c m ba m 49 m d7 m dd m f4 m b8 m a5 m 3b m 9d m b7 2 r 69 m 80 m 23 m f7 m fe m 54 m 96 m
d2 m 5 m ba m c2 m c0 m d7 m 7b m c1 m a m 2f m db m 6a m cf m 3d m e9 m 2a m dd m 8c m d0 m 88 m d7 m 99 m b m notbusy
02 wcmd 8 m 44 m 0 m \ 0x84400 
87 m 45 m 37 m 65 m 4a m 54 m 25 m 66 m 4a m e m fa m b3 m eb m ee m 90 m e m 78 m f2 m f9 m 27 m 8e m 36 m 8e m 1 m 68 m f4 m
db m cb m e4 m 4 m e9 m 3 m 3b m ed m 6d m f9 m d6 m 6b m a7 m 92 m 76 m 99 m 3e m f0 m d4 m 3d m eb m fb m 9a m dd m 50 m 81
m e6 m 1c m 18 m 8a m 28 m c3 m 48 m e6 m af m 9b m 4c m 26 m 7 m 9f m 78 m ed m 9d m 76 m f3 m a4 m af m 3e m cf m ec m 89 m
9a m 6c m d9 m d4 m 60 m 35 m 3d m 44 m 2d m 4 m 5d m 56 m 37 m 79 m 3c m e9 m 26 m 93 m 3f m b8 m fd m d2 m 3d m 5e m a8 m db
m 6 m eb m f5 m e6 m d6 m 39 m cb m 2e m 31 m d5 m c1 m 68 m 32 m 9d m 4c m a7 m 93 m e9 m 74 m 3a m bd m eb m 4e m 61 m 4 m
f0 m 47 m 37 m 9c m 4c m 26 m e2 m e1 m 2d m b8 m c m 6b m ad m 28 m 2f m 3f m cd m ed m 47 m 5e m 7e m dd m 1d m d3 m 1 m b7
m 38 m f9 m 46 m d3 m e9 m 74 m 3a m 11 m 68 m 76 m 92 m 3a m 87 m 92 m be m 6 m 7e m 3f m e6 m 65 m e7 m ee m bc m bf m 25 m
db m df m 83 m 96 m c8 m 91 m 14 m b8 m cb m bf m b0 m 67 m 7d m bf m 3a m e7 m 2 m 80 m ee m c7 m 5a m b7 m d9 m 2a m be m 2e
m 9c m a8 m 10 m 9c m 4e m a7 m d3 m 83 m e m 9a m 1e m f9 m 57 m 3b m 86 m 11 m c0 m f m 9f m 7c m d3 m 69 m 66 m 4b m b1 m
f4 m ab m dc m 47 m 51 m 43 m e0 m b2 m 92 m 14 m 46 m 13 m e3 m a3 m e9 m f m be m 72 m 79 m 18 m c1 m df m 9 m 88 m 74 m 5c
m notbusy
02 wcmd 8 m 45 m 0 m \ 0x84500 
6c m 7c m 6a m 1c m 55 m 56 m 9d m 5a m 93 m 99 m 7d m 27 m d3 m dc m f5 m 93 m 1e m b9 m f3 m d7 m 87 m 3f m b8 m a1 m 5 m cf
m 87 m bf m 42 m 8d m 33 m 94 m cc m 5c m f m 67 m 19 m 80 m c9 m cf m ec m d2 m a2 m e8 m 9 m 77 m 97 m e1 m 14 m 20 m 5 m d9
m cf m e1 m b6 m 74 m e8 m 3e m b2 m 3d m 5a m 86 m 5 m 80 m ff m 67 m a5 m 3d m a4 m 28 m b m 3f m 7b m cf m fa m 7e m f m a8
m 5d m bb m 13 m c m f9 m 75 m 6c m db m 74 m 92 m 61 m 94 m b9 m fe m 81 m 4f m df m 1d m 72 m 9f m 77 m 5f m 91 m 83 m d3 m
2c m 99 m f3 m 4 m 5a m 50 m cd m 2d m 5e m 68 m 4e m 99 m c0 m 48 m 39 m e9 m 27 m 56 m 59 m 9a m bb m e4 m bd m 52 m 75 m b
m 6 m 9 m 50 m 73 m f4 m 11 m d8 m fb m 8b m 12 m d4 m 5e m af m 77 m f2 m e m 3c m 7b m d7 m 7e m ef m 7 m 4 m 48 m 2d m bb m
4e m bd m 15 m 8b m 54 m e6 m 8 m 8b m c0 m 79 m 3a m 99 m 4e m 26 m cf m f9 m b5 m 5d m 21 m 3 m 0 m 7e m f7 m b1 m 4e m 23 m
e5 m 89 m 28 m e2 m c m dc m f6 m 7c m be m f0 m 69 m bb m d5 m e7 m 36 m ed m b1 m 19 m 3c m b2 m 1 m 34 m 31 m 33 m 5f m f8
m cc m 3d m ea m fb m f7 m d5 m 6c m b1 m 32 m b8 m 6b m c3 m 9 m 2b m 69 m 9c m f9 m 77 m 3a m 9d m 4c m 27 m d3 m c9 m c1 m
2f m fa m f9 m dd m 22 m f8 m b7 m 9e m a5 m 72 m b0 m 93 m 9 m 24 m cb m 34 m 2d m bc m ec m cc m ab m 5a m 1b m 3d m notbusy
02 wcmd 8 m 46 m 0 m \ 0x84600 
65 m a5 m d5 m 9b m df m 96 m da m 64 m 56 m 6b m 5c m 7f m 91 m 2a m 1c m b9 m 15 m 68 m ff m fe m 82 m a2 m c9 m 74 m 7a m
93 m bf m dc m ad m d7 m 7f m f8 m c1 m 92 m 18 m 34 m fc m 45 m 71 m 8f m a m 19 m fe m fd m 27 m d3 m e9 m e4 m e0 m 57 m ed
m 62 m 20 m f8 m e m 27 m e6 m b7 m 33 m 18 m 85 m 10 m 74 m 1b m 17 m 82 m ed m 3 m e4 m c8 m 1f m 7e m dc m ee m f5 m ba m
a0 m 1d m ff m 2d m 66 m 2d m e m 23 m 49 m ea m 31 m 7e m e8 m 9 m 7b m d2 m f7 m 73 m be m a5 m d9 m ba m a m 20 m ff m b9 m
64 m 43 m e7 m 1c m 55 m eb m 15 m 62 m d3 m 4c m ae m f3 m 8a m 5d m b0 m e9 m b4 m dd m ec m 55 m 7 m 4f m a6 m 93 m c9 m 64
m ea m e6 m af m ec m 19 m c6 m a m 48 m 8e m 9f m 27 m 93 m e9 m 74 m 7a m 9d m 93 m 6f m bd m 42 m 4f m 17 m fc m c2 m a5 m
1c m eb m 6c m 66 m 0 m c8 m 83 m e3 m 71 m 84 m 4e m 19 m a9 m 3a m f2 m 56 m dd m e4 m 56 m cf m db m ad m 97 m 7 m 78 m 64
m d7 m 8e m 7b m bb m 74 m 14 m 4f m 87 m 28 m c5 m e9 m 64 m 3a m 99 m 5c m fb m 15 m bb m 47 m 6 m 0 m 5c m ef m 55 m 7 m 4f
m b3 m 5d m a0 m 50 m 2a m ab m 4a m 52 m c2 m 40 m ca m 17 m 7c m ea m 67 m fe m 61 m b6 m ab m 5d m b7 m da m 8b m 3e m a7 m
b5 m 7 m ca m 4e m 8f m 18 m e3 m a7 m 7e m f6 m b5 m fd m c6 m fb m 7e m e1 m e7 m 58 m 4b m 69 m a8 m 43 m bd m ba m 7d m a7
m notbusy
02 wcmd 8 m 47 m 0 m \ 0x84700 
56 m 5d m f6 m 8e m 8c m 7d m 27 m da m a6 m 37 m 78 m c9 m ee m 52 m fd m 8a m c3 m 64 m f6 m d4 m b2 m a3 m 52 m 3c m ab m
a0 m b9 m e0 m 59 m 14 m d2 m 64 m 72 m fd m 55 m 8 m 39 m ef m 89 m 8f m b8 m c2 m 12 m cb m 4b m b8 m 61 m fe m 7e m 58 m 4
m ef m 1c m 76 m e6 m 96 m 4c m ee m b2 m 7d m 1e m 10 m 9f m f7 m f9 m 4b m 2e m bb m ec m 32 m 3a m f4 m 3a m d7 m 39 m fc m
a8 m a3 m 16 m 46 m 7e m 1e m f1 m 1a m a m 38 m de m 7f m a4 m 6b m c5 m f9 m f5 m 13 m 25 m 40 m 24 m 6f m 5e m 4e m e m 7f
m d1 m f6 m 64 m 7c m f6 m 73 m 97 m 5c m 7e m d9 m f7 m e8 m b0 m 43 m f m bd m de m 2d m b7 m 17 m 39 m af m 78 m 2c m f8 m
88 m 2 m 24 m 0 m 90 m 6c m 47 m d9 m ec m 26 m bb m fd m b6 m 5e m ff m a6 m 65 m f7 m f1 m 39 m a1 m 2c m 63 m 49 m 5d m c9
m f3 m d m 81 m e8 m e0 m 66 m 96 m c2 m df m 9f m 29 m db m a6 m 99 2 r 19 m 40 m b3 m 2b m 60 m eb m f5 m 6f m 5c m 76 m 1f
m df m ba m 7d m bf m fa m 4c m ab m a4 m c1 m ba m b9 m 54 m 3e m 57 m b6 m ee m a m 7 m 7b m ef m 60 m 3a m 99 m 4e m 6e m
7a m fc m f6 m 77 m 5f m f8 m b9 m af m 5e m 7e m d9 m 15 m d7 m 5c m fb m d0 m 43 m f m bf m c5 m 2d m b7 m 4d m be m 7b m c9
m 53 m bf m d m 6a m 84 m 6b m 29 m 1 m 0 m d0 m 1d m b2 m 75 m 71 m 0 m 31 m af m 26 m 93 m e9 m 8d m 97 m 50 m b m 17 m 9e m
notbusy
02 wcmd 8 m 48 m 0 m \ 0x84800 
f3 m a5 m 4b m bf m 7b m c9 m 25 m 5b m 7d m df m cf m ca m 6e m 9 m e6 m c2 m 28 m a3 m fa m c m 95 m 3a m 1e m 6 m 37 m 26 m
d3 m c9 m bd m ff m cf m e2 m 2e m 4f m 3f m f5 m d2 m c4 m 62 m 34 m 5e m f6 m 75 m 84 m 53 m 11 m f1 m f0 m 9f m bc m e7 m
dc m eb m ef m f3 m 41 m a2 m 39 m fb m f8 m 4a m b0 m 23 m 25 m 40 m db m ad m 34 m 99 m 4c m a6 m 93 m eb m 6e m b3 m 9 m e8
m 23 m ff m 71 m 49 m 62 m 11 m 14 m 97 m 1 m e2 m 7f m 20 m d2 m f5 m 7e m 6a m 71 m fe m e1 m 5f m 3d m e m 5c m 88 m c m 38
m 25 m 0 m ce m 3b m c2 m 52 m de m fd m c8 m 51 m 27 m 8a m 39 m c5 m 6d m f7 m 76 m 63 m 15 m 6e m 25 m a2 m 90 m 52 m 40 2
r 64 m 62 m 66 m 4a m 29 m 25 m 6a m b2 m f2 m 5b m 3f m 58 m 76 m 43 m 45 m 4e m 9 m 30 m 61 m 4a m 1 m cc m 51 m db m 78 m
df m 19 m c3 m 72 m b0 m c2 m 68 m 29 m 6d m a9 m e6 m 43 m de m b6 m 90 m af m ea m e8 m c8 m 6d m 22 m c m e7 m ff m d7 m b9
m c6 m a4 m 57 m 7d m b m e1 m 43 m 88 m 38 m bd m eb m bd m af m bb m e8 m 9e m 17 m 3c m eb m 42 m 48 m 4e m 12 m 26 m c8 m
3b m a8 m 85 m 1a m 53 m 8a m 59 m 94 m 8 m 8c m b6 m 23 m e4 m db m ef m 39 m c3 m 36 m aa m 49 m 8b m 82 m 24 m 91 m 33 m f3
2 r 54 m bd m 7b m 64 m 30 m ca m 1d m df m 71 m 11 m 8c m f8 m d5 m 9f m 93 m 8a m 40 m b6 m 7f m 7 m 1 m 11 m bf m f5 m
notbusy
02 wcmd 8 m 49 m 0 m \ 0x84900 
cf m 6f m c3 m 23 m 8f m 3d m b8 m 79 m cf m 11 m 9f m fb m 6e m 3 m 47 m 88 m 7e m f1 m 81 m 52 m 92 m ba m 28 m 8a m a4 m 83
m 17 m c2 m e8 m 75 m 67 m 27 m a5 m 3 m 52 m 79 m ce m 45 m ff m f7 m 14 m ba m ed m c3 m 16 m dc m f7 m b2 m 47 m 5b m 45 m
94 2 r c0 m b6 m 55 m 82 m 1 m 29 m 66 m 6c m 67 m ef m 7f m fb m 5a m 23 2 r 8d m 90 m c7 m 45 m 5e m 89 m 19 m 29 m fd m af
m 16 m 1d m a7 m fe m bf m 58 m 5a m d6 m 47 m 88 m 66 m 64 m 31 m 2f m 53 m e7 m 64 m ed m be m ff m cd m ba m 65 m 4e m 29 m
61 m 4a m 56 m e6 m 6e m 85 m 66 m 59 m 18 m 19 m c6 m 6 m a3 m ec m 1e m 4d m 7e m 70 m 21 m f7 m 7e m e8 m 5d m d7 m c8 m 6e
m 3c m e9 m 35 m bf m c9 m ec m d4 m f7 m d3 m d m ff m f7 m 82 m cc m 9d m 3f m 7d m ca m 77 m 5 m 43 m a5 m fc m 2a m c8 m
26 m 18 m 6f m d6 m 39 m ef m e8 m a8 m 85 m e9 m b1 m 9f m 78 m eb m 15 m b6 m 83 m bd m 8f m 7d m ec m fb m 28 m 40 m 72 m
96 m 9d m c5 m 35 m 7d m dd m 2d m d m 32 m 80 m c8 m 31 m a7 m 8d m 26 m 93 m c9 m e4 m c8 m 5 m 5b m 24 m fe m fd m 7d m 3d
m 73 m b1 m 1b m 85 m 7a m 90 m d m bc m e7 m 3d m 33 m fc m e4 m 2f m b4 m 6e m bb m df m 5b m da m fa m 8 m 8b m 8f m c6 m 8
m 40 m 14 m 82 m 2e m bf m 4e m 26 m 2f m 9f m 4f m c6 m 47 m ff m 75 m cb m ca m 40 m 54 m 38 m 22 m 24 m a2 m b3 m 9e m 3a m
notbusy
02 wcmd 8 m 4a m 0 m \ 0x84a00 
fd m d9 m f9 2 r 9e m 2f m 7a m 82 m c4 m a8 m ac m 6 m 3b m b0 m 70 m 91 m ec m d9 m b2 m 82 m 29 m 51 m 2a m 52 m 28 m 2b m
f m 18 m 59 m dd m 3b m 2c m 15 m 25 m 2 m b1 m 54 m e m 21 m e6 m ac m 13 m b8 m 39 m 22 m 67 m 9d m d2 m f7 m 7d m 54 m b9 m
17 m b3 m 56 m 40 m c1 m 10 m 33 m 6f m b6 m ef m 28 m 12 m 57 m f7 m 89 m d9 m 5c m ae m d2 m 5c m ac m 6a m 20 m 8e m 27 m
93 m c9 m 64 m 72 m dd m 5 m bb m 4f m 2e m 79 m c5 m 25 m d1 m c m 4b m dd m 96 m 2c m ec m 88 m e1 m eb m 2f m a3 m 5b m 3d
m 62 m ee m bd m 7f m f9 m 58 m 5f m f0 m d3 m 74 m 92 m d4 m 3 m 91 m f4 m 99 m 2e m c8 m e2 m eb m 64 m 32 m b9 m c9 m 2 m
18 m 5d m fe m 9a m 2f m 69 m 31 m 1c m 2e m 3b m a7 m 75 m 62 m a m 9f m bb m 3d m b7 m b5 m 3e m d2 m b4 m 3a m b4 m fd m db
m 9a m c9 m 70 m 93 m f9 m 62 m e4 m 2d m 1f m 8b m 51 m b m 99 m 24 m 56 m 53 m 1a m 8b m 59 m 4a m f4 m be m ff m f8 m d1 m
56 m 7c m f1 m c1 m 6f m 9b m ab m 8f m f2 m f8 m 1 m 80 m 99 m 75 m f9 m fd m e7 m 4f m c3 m a9 m ff m 96 m 65 m 45 m 34 m eb
m 35 m 3f m e m 34 m c1 m 8b m e2 m bf m be m e3 m de m 4d m 16 m 2 m 80 m 43 m fe m f0 m 5 m c2 m ae m 8a m a3 m 72 m 6a m 62
m 4a m 6c m e6 m 77 m 8a m 4b m d4 m 81 m ac m 57 m 2d m 88 m 38 m 68 m e9 m 9f m 98 m 99 2 r f1 m 57 m 5a m 44 m 7c m ed m
notbusy
02 wcmd 8 m 4b m 0 m \ 0x84b00 
6f m c5 m 7a m 50 m c1 m 27 m 38 m 62 m a2 m 44 m 56 m fe m 69 m 63 m 7d m cf m 14 m c3 m e2 m 99 m a9 m af m 31 m 77 m c8 m
db m ad m 2c m 1d m 8d m 50 m 34 m 39 m 64 m 7e m c0 m f7 m b3 m af m bf m 5a m fd m 42 m 57 m b6 m db m 9b m a7 m f4 m 99 m
a7 m de m e0 m f m da m 5b m 55 m 1 m fe m ea m 51 m aa m b4 m 4d m 1f m 25 m 2c m 1c m 1d m 2 m 55 m 94 m 5c m 6f m 7e m 82 m
ec m 85 m af m bc m 4a m e4 m 98 m 2b m a9 m 92 m c1 m 94 m ff m 99 m ca m 0 m 30 m 20 m 19 m 8e m bc m 3a m f2 m b1 m f6 m dc
m ef m 61 m 73 m bb m 7d m f3 m c7 m eb m d m f2 m 85 m 81 m 6d m 0 m 28 m 10 m 9d m f9 m e4 m db m 34 m 84 m c9 m f5 m bf m
37 m 47 m 1f m 99 m 42 m 12 m 75 m 24 m 19 m ee m 93 m 47 m dd m 60 m e m 19 m ff m f5 m 6e m 35 m 4a m a2 m d6 m 6e m 35 m 7d
m 54 m b6 m 62 m 86 m ff m 7c m ff m 3c m 24 m 1d m f5 m 1b m 6f m 12 m 41 m a0 m 2 m d m 18 m 13 m 24 m cc m 66 m 1e m 68 m
25 m 33 m 62 m 8a m 54 m b2 m ba m 6 m 9c m ac m 39 m c7 m d5 m 40 m 92 m 54 m 98 m 40 m 8a m ca m cc m cd m e5 m af m ab m 5f
m 30 m 9b m cd m 66 m 6a m 87 m 73 m 64 m 66 m 48 m 8 m c8 m 94 m 38 m 11 m 87 m 1a m 46 m bb m df m b7 m 79 m 0 m 31 m 26 m 6
m a0 m 22 m 8d m 56 m 6d m 59 m 1d m d6 m 29 m 4 m 5d m d7 m 4d m 26 m 7f m 35 m ef m 8e m 6f m bd m f4 m ea m d8 m 5b m 7c m
25 m notbusy
02 wcmd 8 m 4c m 0 m \ 0x84c00 
1f 2 r 93 m 9f m 54 m ec m d3 m 40 m e1 m 9b m cf m bd m c1 m 1f m cf m 79 m c2 m cb m 1e m 3 m 26 m 8 m 33 m e1 m c9 m f4 m
51 m 15 m 34 m eb m ba m c9 m e4 m 5a m 73 m ab m 5d m 7c m f5 m 55 m 57 m f5 m 6 m a0 m 1a m 4a m 85 m c3 m ec m ac m a8 m 24
m 66 m 5d m ad m 8f m 10 m 2b m b2 m b m 90 m ba m 79 m 21 m b2 m cf m be m 3a m 83 m 94 m 1d m 4a m bd m 5d m 27 m 30 m a m
14 m c2 m 39 m 4f m 79 m d0 m 3d m 86 m b7 m df m fb m 9d m 63 m 79 m 5a m d6 m 60 m f3 m 66 m 32 m 9f m 53 m f1 m 63 m 77 m
6e m 93 m d1 m ff m e9 m 15 m 52 m f3 m 82 m 63 m b m ce m 54 m ea m 4b m 9c m 7a m fa m 53 m ae m df m 7c m c6 m ff m fa m e4
m a7 m f3 m 34 m 70 m ea m f2 m 30 m 21 m 82 m c6 m ee m c4 m f0 m 26 m ce m 28 m aa m 59 m b9 m 7e m 87 m 41 m 6e m 59 m 30 m
8d m 40 m 91 m 48 m cc m 96 m 7 m 36 m 29 m 78 m 86 m a0 m a8 m 38 m b4 m 72 m b4 m 40 m 62 m 4a m 44 m 4c m c4 m b8 m c9 m be
m 15 m 49 m 12 m 66 m 58 m b m 44 m d9 m 3b m 2a m 7c m a4 m 6b m 16 m 39 m 3d m 73 m ee m 5e m a3 m bf m b8 m 48 m 4b m 96 m
38 m c3 m e m 40 m cd m 1a m 63 m c8 m 10 m be m f9 m d4 m 5b m b5 m 33 m 6a m a6 m 8f m 78 m 95 m 62 m b0 m 2c m 81 m c9 m db
m bb m bd m 3f m 59 m 2f m bc m 6c m 1e m 21 m 27 m 7c m bb m 14 m 4f m 89 m d1 m ca m 4b m b1 m a0 m 8a m 2b m 6d m d4 m b0 m
eb m notbusy
02 wcmd 8 m 4d m 0 m \ 0x84d00 
6c m 4a m cc m 3b m b2 m 14 m 8a m ae m eb m 7e m 67 m 4e m af m 27 m 7d m ab m ef m 63 m 1f m 63 m cf m 99 m 83 m cb m a m 55
m 51 m 4 m a5 m 30 m cb m 29 m ff m 36 m d2 m 6a m c7 m b4 m 92 m d6 m 74 m 16 m 98 m c0 m cc m ba m ae m 9b m 4c m ba m eb m
ce m 9 m bc m bf m e6 m 33 m d9 m 11 m 74 m 5e m 20 m 17 m 32 m dc m 34 m 74 m 81 m 3 m 9f m 78 m c4 m ef m 37 m 9f m f2 m 94
m c7 m 8b m 13 m 92 m 98 m 39 m a4 2 r 87 m 53 m a7 m 5c m 15 m 3d m 51 m c8 m cc m 2c m 9c m 3c m ef m ec m 14 m b m 97 m 65
m 71 m cc m a2 m 11 m 10 m 89 m 54 m e1 m dd m 7f m da m ea m ff m a9 m 33 m 69 m c5 m bc m 4a m 99 m 2b m 99 m 38 m 2f m c4 2
r cd m f6 m dd m f7 m 3a m 8a m 29 m 1 m 3a m b9 m be m 4a m 93 m fa m 7f m 65 m d8 m 3b m 3 m d2 m 5d m e7 m 2c m 41 m bc m
ff m 5d m 7d m af m c5 m 9b m d8 m f9 m 1f m e0 m cc m 9a m b2 m 89 m f5 m bc m 3f m 7e m 64 m b3 m aa m d0 m 5d m 3f m f2 m
49 m 67 m 9a m 87 m 5c m f8 m 2e m 93 m 62 m 40 m 12 m f7 m 68 m 5e m da m ef m db m 4e m af m aa m 48 m 45 m 1e m ff m c9 m
ea m c8 m c5 m bd m f3 m f8 m 78 m 7d m 54 m e4 m 8 m 9a m 1a m ec m ba m 6e m 32 m b9 m 5d m bb m 92 m cb m 67 m 5f m dd m cb
m c8 m 1b m 8e m 46 m 8a m 0 m a5 m 4a m 58 m 17 m 42 m 97 m 2e m 7d m ca m af m c m 3c m fd m 23 m ce m 1b m 4d m 3 m 16 m 32
m notbusy
02 wcmd 8 m 4e m 0 m \ 0x84e00 
0 2 r 21 m 90 m a9 m e3 m 39 m ca m f8 m d9 m 57 m 29 m 19 m 59 m ed m b6 m ec m ba m 3c m d m 31 m c4 m 8e m f9 m fc m 67 m
3c m b7 m 99 m 1e m fb m 82 m c7 m 49 m a m 41 m 60 m 66 m 4a m 8c m 98 m cf m 7c m 48 m 59 m fa m a7 m 44 m e4 m 2b m 5e m 36
m 59 2 r 34 m 42 m 91 m 22 m 1c m b2 m 59 m 65 m eb m aa m 89 m ef m d2 m 2c m e m f6 m f4 m 6b m b6 m 2a m 5e m 8e m 1c m 93
m d8 m 25 m c8 m c4 m 52 m 16 m 7a m 93 m 7d m f7 m b3 m 59 m 5f m 0 m 8c m 20 m 6f m bf m ea m 5a m ec m c0 m 3b m 2a m f6 m
d4 m f5 m e7 m ec m 93 m 78 m c1 m c5 m bd m f m af m 88 m 3e m d2 m 38 m 83 m 54 m f8 m 91 m 54 m ed m d8 m 71 m e0 m 57 m de
m a2 m 29 m 9 m 1f m f7 m a4 m 4b m 8a m 20 m 4c m 29 m 8 m d9 m b6 m fb m c7 m dc m 83 m bb m df m b2 m 4d m c8 m 9f m 5c m
25 m 81 m 39 m 87 m 23 m f9 m 6b m ff m 8a m fb m 92 m 7c m da m d4 m 38 m 5e m 57 m e9 m 90 m 6e m d2 m 4d m ba m eb m b4 m b
m 20 m bc m fe m 2c m b m ab m f7 m f3 m c m 2a m ab m 29 m 11 m 43 m c7 m dc m a5 m b7 m 9e m f5 m 98 m fa m 21 m 23 m 53 m f
m a m 19 m 29 m 11 m 20 m 5a m f4 m bd m 6b m 7 m de m cf m 7a m 43 m 3f m 2b m 64 m 14 m 38 m b7 m 71 m 94 m 7 m e2 m 99 m bf
m 70 m ef m c6 m 93 m e m fa m c5 m 7f m 75 m 63 m 95 m 28 m 25 m 44 m d m 6c m 26 m 4c m 98 m 58 m 39 m 99 m 2c m 9 m notbusy
02 wcmd 8 m 4f m 0 m \ 0x84f00 
d2 m 71 m b2 m 2d m 57 m a8 m 51 m 8f m 44 m 81 m c4 m 42 m 2f m d1 m 4c m be m 6d m 73 m f3 m da m b3 m ae m dc m 9a m 6d m
29 m 92 m d4 m 9d m 4d m fa m e m 4c m 8c m b2 m 63 m 6d m 93 m 7d m eb m 5a m 63 m 8e m b2 m 94 m 14 m b2 m a5 m 61 m 94 m cf
m 33 m 18 m 66 m 18 m 8b m 59 m 7e m 62 m f3 m 96 m ab m 8f m ef m 65 m 2 m 5d m 59 m b8 m 39 m 38 m ea m 62 m 17 m 63 m 97 m
d2 m e7 m 9f m d9 m 8c m 37 m bd m e8 m 91 m 62 m 51 m 74 m ce m c3 m d5 m a m 80 m c5 m 49 m bb m 41 m 3b m a7 m ee m 23 m ff
m a4 m 6c m 54 m 55 m c5 m ab m b3 m 4b m 74 m 11 m 96 m 7 m 9a m 7a m b0 m e m 2b m ef m 6f m d1 m 8d m 49 m d7 m 75 m 5d m
5b m d m fc m d9 m 77 m fb m 59 m 1e m 81 m a2 m 90 m cb m e3 m 9d m 54 m 14 m 9d m 9a m 67 m f3 m b m cf m ae m 6d m bb m 71
m f8 m a5 m e8 m 23 m 24 m 0 m 44 m db m 47 m 78 m b3 m 9f m 68 m 91 m 71 m ca m 19 m 59 m 8c m ce m 7a m af m 8f m 80 m 21 m
59 2 r 54 m c3 m 51 m 17 m 3b m 59 m 65 m 7c m c7 m f9 m c7 m 36 m 9e m f5 m 80 m f m 7d m 93 m 23 m c7 m 2e m 76 m cc m 4c m
c4 m 28 m 1a m 29 m 25 m 40 m 4c m 98 m b2 m 5e m d0 m 36 m d2 m 8 m 55 m d4 m 39 m bf m 7b m a m 80 m 11 m 31 m 19 m 27 m a7
m 74 m b3 m 16 m 84 m e1 m b9 m 97 m 6d 2 r 9 m 8c m 66 m 16 m 7e m 56 m db m 6 m 10 m 99 m 90 m 71 m d3 m 7d m 4b m d7 m 39 m
notbusy
20 wcmd 8 m 50 m 0 m notbusy \ 0x85000
02 wcmd 8 m 50 m 0 m \ 0x85000 
5a m 7 m c5 m d7 m 5d m d1 m b0 m 73 m d1 m c2 m 52 m d0 m 79 m d2 m b5 2 r d1 m 27 m de m dc m cf m 32 m 23 m 95 m b0 m 72 m
b1 m 9a m b0 m 16 m 84 m d9 m 9e m 48 m dc m a5 m 3f m 7a m 74 m ab m 26 m c9 m 43 m 5f m 2b m cc m de m 25 m 96 m c0 m 37 m
20 m 5a m 61 m 13 m 71 m 53 m 4e m 68 m 12 m 72 m f2 m e7 m fb m 4a m 20 m ab m 8f m 10 m 9d m b5 m af m 51 m a8 m 82 m 22 m 5
m 53 m a7 m ef m e m 46 m 34 m 39 m 3d m 18 m ba m ae m fb m b1 m e6 m 9e m d5 m e3 m 2e m ef m b3 m 21 m 30 m 73 m 72 m a4 m
8a m 33 m 28 m 90 m 42 m a0 m 2e m c4 m 2e m ff m 16 m 2e m 7f m fa m 9f m 6f m 3b m 11 m 42 m 48 m 2 m 0 m 42 m 13 m 24 m cd
m 12 m 6e m ff m 70 m ce m ac m 17 m 6 m e8 m b3 m a3 m c6 m 4d m 7d m 44 m 81 m b2 m 34 m cb m 6b m 23 m e9 m d3 m af m 68 m
99 m 6 m 7f m fe m 48 m 8e m 1c m b9 m e3 m 10 m 3 m 13 m 89 m 49 m 93 m 45 m 32 m 62 m ca m 7a m c1 m 18 m b9 m 70 m b2 m d7
m b m 55 m 5e m 24 m 0 m 46 m 4c m 3a m a9 m 0 2 r 37 m fa m e5 m d6 m 6b m 9c m f8 m 1d m 85 m d1 m ac m c0 m 88 m c5 m ae m
3 m 44 m 40 m 46 m c2 m 8d m f7 m ad m 43 m 98 m 0 m 90 m 34 m e6 m b5 m 68 m aa m 6 m 4d m a2 m c m 2e m ca m 56 m ac m ba m
1b m fd m 58 m eb m 8e m b7 m 7f m 70 m 56 m 26 m 50 m e7 m 2f m c7 m eb m 4c m 1c m 97 m 75 m a8 m d8 m 99 m 59 m f5 m ca m
notbusy
02 wcmd 8 m 51 m 0 m \ 0x85100 
9f m bf m cf m f8 m 69 m f7 m 7e m d7 m 45 m cc m 2c m 57 m a5 m 4 m c8 m b9 m 72 m 59 m d1 m 46 m 5d m d7 m b5 m b m e3 m 9c
m f0 m ad m 7e m d6 m 2b m 1d m 12 m b1 m 73 m 1a m a8 m 60 m c8 m 7c m a3 m 2a m 19 m de m c7 m bd m 47 m 61 m 96 m 8c m e0 m
66 m 78 m e4 m 19 m 6a m 50 m ab m 42 m 2a m b m 37 m 45 m 1f m 19 m 7 m c7 m a0 m 3 m 0 2 r 4f m 6b m cb m 3 m 23 m 44 m e1 m
cc m 84 m 9 m 91 m 34 m ce m 72 m bf m d6 m c5 m af m f8 m e2 m 4c m 64 m 78 m d1 m 47 m 66 m 16 m 24 m b5 m 10 m 65 m 1e m a2
m cc m 3 m a7 m 94 m e0 m fc m 17 m 3d m a9 m f1 m bc m 3b m 9d m 11 m 39 m 72 m c m 21 m 30 m a9 m 42 m 12 m 3e m cc m 6f m
c4 m c2 m c9 m c3 m 70 m 99 m 19 m 56 m 85 m 89 m b2 m 87 m af m 15 m 5a m 65 m c4 m f m ff m ed m d6 m 6b m bc m f8 m c2 m d9
m d6 2 r 6c m 6b 2 r ab m f8 m 47 m 1c m 53 m c1 m 11 m 20 m 22 m 18 m 8a m 36 m da m 77 m af m e1 m f6 m 35 m a2 m de m 76 m
44 m ab m a9 m 23 m 67 m 50 m fd m 69 m eb m 8e m b7 m 7f m 70 m 66 m 13 m 58 m d6 m ae m 5c m 7d m 63 m 27 m 8 m 3 m 75 m a1
m 78 m f9 m f0 m ae m 59 m 83 m 23 m 4e m c8 m 82 m 30 m 4 m 51 m e6 m d9 m ae m b m 25 m 27 m a8 m eb m 6e m 7a m 87 m 16 m
21 m c7 m 5d m 6e m e m a2 m 85 m 4b m 23 m 57 m 0 m 2a m 6e m d1 m 18 m 46 m 82 m 23 m 1 m 91 m 8b m b1 m 95 m b0 m notbusy
02 wcmd 8 m 52 m 0 m \ 0x85200 
f7 m a3 m 5b m dd m 3e m 5d m 63 m 4b m aa m 8 m bc m 3a m 52 m 45 m 20 m 2b m a0 m 81 m 42 m 8 m 6c m e6 m 3e m e0 m 36 m 1a
m a9 m ac m 1d m 25 m 59 m 3d m a m 5d m d7 m 1d m fc m a0 m c6 m a5 m 27 m 7f m 71 m 36 m 9b m 6d m 29 m 8e m dc m 62 m 7c m
a5 m 8f m 8a m 3c m 73 m b1 m 90 m 74 m e1 m 4b m 1b m 6e m df m a3 m 1f m 9d m 63 m 9d m 21 m 30 m b3 m 9e m b9 m 6 m 49 m 4e
m 31 m b0 m d m 96 m 9e m 93 m 2b m db m a m 4d m 80 m 38 m 4e m 36 m 86 m 0 m b8 m 56 m d3 m 41 m 7e m e5 m 17 m b7 m 86 m ea
m 28 m 9f m 73 m 53 m 84 m 92 m 76 m be m e9 m be m b3 m 3d m a9 m 85 m 89 m d7 m 48 m 50 m 75 m 56 m 79 m 55 m f7 m b0 m e5 m
8 m c3 m 3b m 3f m 98 m e7 m 4f m 70 m 94 m d9 m 37 m 8d m 70 m 84 m 44 2 r 31 m 4 m e m 66 m b1 m 25 m 80 m f7 m 6e m 35 m 96
m 2 m 7f m fc m f4 m ae m 44 m fc m 54 m 1f m 79 m 18 m 75 m c7 m b5 m 8 m 79 m e6 m d5 m b3 m 59 m bf m 25 m 7a m 21 m 7 m ce
m 5c m c9 m f0 m a2 m 85 m 6a m 10 m 39 m df m d1 m c5 m bd m 15 m fc m 54 m 1c m b3 m d0 m 85 m 1f m 6c m c1 m f7 m d9 m f2 m
fa m b3 m 99 m c8 m 11 m 8e m 2e m 1a m a8 m fa m 8 m 72 m f4 m 35 m 86 m 18 m 3a m ee m f4 m 64 m 4b m 40 m fc m 93 m 45 m 89
m b6 m 8 m 66 m d6 m 25 m 40 m 22 m 29 m 9a m da m 5a m 7a m 78 m cb m 17 m 32 m 19 m 5b m 66 m 17 m 54 m ab m c1 m aa m
notbusy
02 wcmd 8 m 53 m 0 m \ 0x85300 
8f m 6c m 1e m 2 m 7 m f1 m 16 m 0 m 12 m 7e m f5 m 75 m d m f9 m fc m 5b m af m 8d m 21 m 84 m 2e m af m 78 m 66 m d m 60 m
eb m 10 m 56 m 19 m b1 m 52 m 8 m 95 m 5a m 50 m dc m 26 m 2 m c8 m 9 m 3d m 95 m c3 m 37 m 7d m 4a m eb m 8d m 5f m fb m 99 m
ad m 2d m 65 m e6 m 6c m dd m 98 m b3 m 69 m cc m 4 m 7b m d4 m 77 m ae m 91 m f m 80 m 8c m ca m cc m 2b m 6a m 25 m 74 m e1
m aa m 52 m f m 61 m da m a m 12 m 7d m e8 m b4 m de m c4 m f1 m 4c m cd m 9a m 4a m 1c m 7b m 41 m 68 m 6 m 1b m a4 m 4 m 9 m
11 m df m ff m 3 m e3 m 38 m f2 m ef m 9e m 51 m e m 37 m 49 m 90 m 4b m 1f m 56 m 55 m 4c m 9b m a9 m 85 m cf m ba m 7a m 36
m 9b m cd m 66 m 5b m fd m 60 m 19 m bc m 2c m ca m e7 m d4 m e7 m 11 m 88 m c6 m f9 m c m e0 m 4 m 9a m 2f m 46 m 7f m 5c m
a3 m db m e7 m 5f m 39 m db m 52 m 20 m 59 m f6 m 9e m 72 m a8 m 29 m 2 m d3 m 6e m 4c m 39 m 94 m ac m 2b m 2 m 74 m cd m f3
m 17 m 6d m ef m 14 m 83 m 90 m 9 m 12 m a8 m 85 m 1d m 6e m 70 m c4 m f8 m c2 m f m 7c m 74 m 66 m 78 m ee m 67 m de m 4b m
65 m 48 m 9e m c m 89 m 2 m ab m ff m a9 m 42 m fa m 53 m ef m 1d m 5b m 6 m f7 m 3a m 25 m 46 m ee m 43 m 17 m 3 m 67 m 24 m
1 m 0 m 68 m 2a m 15 m ba m 3f m d m 3f m df m 1c m 94 m cc m ca m 29 m 95 m 78 m b m 12 m 11 m 62 m 68 m ba m 78 m notbusy
02 wcmd 8 m 54 m 0 m \ 0x85400 
6f m f9 m ef m ad m 2d m e7 m a1 m f4 m 16 m fc m cc m c7 m ae m c1 m b0 m e7 m 4d m f7 m 9d m 83 m de m 30 m 8 m 48 m 2d m df
m 2a m 2f m 5b m 4b m ff m b6 m 9c m 83 m ef m be m bd m 9f m 15 m 20 m f5 m b2 m 7c m e2 m cd m 9 m b0 m b7 m 22 2 r 59 m d4
m 2b m 33 m 81 m 6f m 3b m f2 m 86 m a3 m 87 m 3e m e2 m 15 m b1 m e3 m 18 m 3a m 4d m 59 m cf m 26 m 4d m 46 m 73 m e8 m ba m
43 m fe m 77 m 83 m 90 m e7 m 5e m 95 m f9 m 28 m e3 m 28 m e6 m 51 m 88 m 1e m 45 m 8a m 20 m 89 m 3a m 15 m c7 m 51 m 7 m a8
m f8 m 47 m 55 m 56 m 96 m e9 m a3 m 1b m 37 m 56 m 5a m 5e m 79 m 49 m 3f m 9b m cd m b6 m 54 m 21 m 57 m d1 m ca m 62 m 8 m
14 m f m 89 m c9 2 r 18 m 44 m 24 m bc m ac m e9 m e5 m eb m 7d m 90 m 59 m 3f m 51 m 2a m a1 m 96 m 27 m 8e m 2f m bc m fa m
9d m 7d m 3f m db m ca m 64 m cc m dc m 61 m 1a m c9 m 76 m 6f m e4 m f7 m 52 m 20 m 59 m 40 m 3b m 29 m 7d m ef m bb m cb m
75 m 47 m 4f m 7d m d8 m 2b m 43 m e8 m 62 m 8 m 21 m 92 m 3b m 8 m 5a m c3 m bf m a8 m 6 m 54 m c3 m ae m 2a m e m a m 90 m
89 m 53 m 1b m 51 m 22 m a2 m a6 m 1a m fe m b7 m f7 m cf m 32 m 2b m 6f m e5 m a8 m 4d m 6f m b2 m d0 m 9 m e5 m 7c m ba m d9
m c6 m fb m 96 m 1 m d4 m 57 m 5e m c3 m 3d m 32 m 27 m db m 8b m e3 m d0 m 1d m dc m b2 m 6a m fe m 32 m f6 m 7d m df m 2b m
notbusy
02 wcmd 8 m 55 m 0 m \ 0x85500 
8c m 66 m 55 m 94 m c8 m a5 m 69 m 2 m e6 m 14 m 43 m 97 m a7 m 24 m 93 m 8a m 2f m 1c m 7b m 8 m 77 m 3a m 28 m c6 m d0 m 31
m 87 m 6c m fe m b1 m 1d m 7c m 93 m a1 m d4 m 32 m 6b m 5e m f0 m bd m 5e m d9 m 79 m a6 m 61 m 33 m 36 m 86 m 66 m cb m 23 m
7 m d3 m 45 m 16 m a6 m ab m e3 m c m ea m a8 m 2a m e3 m e7 m e3 m 3a m 43 m 8 m 5d m 68 m 64 m 33 m 7d m f4 m fc 2 r ee m 5b
m 6a m 4f m 99 m 39 m cf m 50 m f m 0 m 1 m 31 m 12 m 89 m 32 m 4a m c5 m 5 m d m 5f m fd m e8 m fc m d m 41 m 32 m b m 4c m
29 m 99 m 85 m 79 m d8 m 58 m f0 m c0 m f3 m cc m 47 m db m 9a m e9 m a1 m 34 m de m 2a m 70 m 6a m 91 m d m 47 m c9 m 12 m f2
m 11 2 r 4f m 1c m cf m c3 m 9d m a7 m 31 m 66 m bf m 34 m 44 m cc m a6 m 1d m 94 m 11 m d3 m b3 m fa m 6a m 4e m b6 m a0 m 33
m 88 m 5f m a7 m 41 m db m e2 m 6d m 12 m 11 m 35 m dd m c2 m d3 m df m 25 m 4e m 7e m 9e m c6 m 92 m 1c m e3 m 8c m 1b m 3d m
63 m 6e m e3 m 7d m f7 m 39 m bc m 1 m 8 m 79 m 11 m d6 m 5 m 29 m 56 m 68 m a m e0 m 12 m 6e m e m c7 m 36 m 2e m fb m 73 m
dd m 8c m 30 m 5c m 84 m 2c m e6 m 4 m 28 m 30 m 93 m df m b m a5 m 7c m 8a m 44 m cf m fb m 93 m d1 m 63 m 1f m 7e m 72 m e4
m 18 m 42 m 27 m d6 m 7b m 5e m 39 m d1 m b2 m fc m 87 m 1f m 31 m a6 m e3 m 1f m 2f m 12 m 66 m 76 m b6 m ad m b3 m notbusy
02 wcmd 8 m 56 m 0 m \ 0x85600 
2f m 6b m 5b m ce m 34 m 51 m d m 23 m 8b m 7b m 3b m f7 m b0 m 2c m 44 m 87 m 70 m 83 m 6b m 8d m fb m fd m a7 m de m d8 m 57
m cc m 5a m 77 m 6a m a5 m a2 m 15 m 1 2 r 18 m 99 m 30 m 27 m 2b m a7 m a m 47 m 44 m ef m 98 m 8b m 23 m 1f m 66 m c8 m ab m
b0 m a1 m b m 8d m 4d m 1b m 2f m df m ca m b2 m 4c m 85 m 69 m 65 m 15 m 98 m 21 m a6 m 8e m 5a m 62 m a2 m 24 m 38 m 2a m 56
m 37 m fe m d5 m f8 m c1 m f m 7e m 43 m b0 m e3 m 66 m b3 m 84 m c7 m e4 m 84 m 73 m b2 m a8 m d4 m 58 m 23 m a4 m 6c m 5 m
ca m 22 m 82 m 77 m 35 m 43 m 8 m e1 m 29 m 38 m ec m a m 0 m ce m 7e m 53 m 66 m 65 m 75 m 50 m 9c m 93 m 37 m a8 m 49 m a3 m
85 m 76 m 37 m db m b7 m e9 m eb m b5 m 60 m 84 m 16 m 8c m a9 m 72 m e2 m c2 m b4 m 71 m b8 m cf m bb m af m 88 m 6e m 83 m
5c m 33 m 58 m 5 m 79 m e m 93 m 99 m 5 m 60 m af m 87 m 44 m 91 m 62 m b8 m f2 m 94 m 51 m d6 m ed m 9d m a7 m 6 m 3 m 0 m 46
m a7 m 8f m ba m d0 m 35 m 42 m 4b m e7 m 9f m 39 m 2b m e6 m 95 m 8b m 56 m d m b2 m 16 m 6a m 45 m a4 m 52 m d5 m 5a m 15 m
f7 m 6 m 35 m a7 m 6d m 0 m 1a m 55 m bc m 9f m 13 m fb m be m 9f m cd m b6 m 9c m 1a m e4 m ca m 9c m 72 m 82 m 4 m 30 m 21 m
a6 m 94 m 8a m 4a m 16 m 7d m 14 m 66 m f3 m 5d m 24 m 65 m 72 m 48 m 76 m 92 m ec m b5 m fe m c7 m e8 m aa m 73 m 2f m
notbusy
02 wcmd 8 m 57 m 0 m \ 0x85700 
e8 m cd m b6 m 16 m d3 m 9e m 47 m ea m 48 m e5 m 59 m ca m c1 m 2b m 5d m 10 m 2a m 38 m fa m f2 m a7 m 47 m f5 m 8f m ee m
fb m e6 m 50 m 1 m 9 m 2a m cb m e m 41 m cb m 46 m 63 m 19 m c6 m 7c m bc m a1 m b0 m b2 m 4e m b5 m 1f m c6 m 10 m 2 m fd m
ce m f m 35 m de m f5 m ab m af m ca m 6c 2 r 2b m b0 m f5 m 8a m be m ca m 24 m ed m 49 m 8f m f4 m d9 m 58 m df m 79 m fc m
d0 m de m 77 m 75 m 18 m 81 m 73 m 90 m 6c m 39 m ff m 37 m 1a m 17 m 7f m 68 m 90 m 45 m 5d m cc m 6e m 13 m 83 m fe m 4d m
f3 m 36 m b0 m 8 m c8 m b9 m 3c m 7e m 8c m 91 m 62 m a4 m 33 m 7f m 66 m b4 m eb m fc m a1 m af m e m 21 m 84 m 8e m 53 m 2 m
20 m 76 m e9 m c m a1 m 3b m 74 m cc m 47 m 70 m 72 m af m e6 m d5 m 6c m 4b m 67 m c0 m f9 m 46 m de m 1d m 12 m ee m a9 m 23
m c m b9 2 r 7d m b m 6a m d5 m da m 0 m 84 m 70 m 9d m 71 m 6a m f4 m 7f m 5e m d9 m 4b m 78 m b0 m 30 m b0 m 59 m 23 m 2e m
8f m 42 m 36 m 28 m c7 m 18 m 63 m 14 m f5 m 3d m cb m 6e m 65 m df m f7 m b3 m 59 m 7f m d5 m 87 m e7 m 4f m 87 m 8a m 53 m
e3 m 85 m 46 m 9e m ec m 6b m e4 m 99 m 2a m 4a m 73 m 82 m a1 m 52 m 12 m 1d m 19 m 7a m 82 m 5b m de m d8 m 53 m 5c m db m
be m 9f m f5 m fd m 6b m c7 m 4f m be m 7f m e6 m 3d m 3b m 28 m 54 m ff m 5f m 5d m 4d m 91 m 53 m 6e m de m ab m 3c m 7a m
79 m notbusy
02 wcmd 8 m 58 m 0 m \ 0x85800 
83 m e2 m 67 m e7 m 8f m 7 m 1d m d3 m 78 m d3 m cb m 4f m dc m 9a m 79 m 85 m 10 m 73 m bc m cc m 69 m d5 m 4 m 65 m 9f m ee
m 1e m f4 m ed m 93 m 44 m 57 m 8d m 33 m 68 m b8 m a3 m 58 m 5d m e6 m 98 m 34 m 32 m 51 m 4e m 64 m 9b m 19 m ce m ac m 92 m
fc m 5b m 8c m 5a m ca m bb m 28 m f5 m 5c m 68 m 56 m ec m bd m 78 m 74 m e5 m dd m aa m 3 m f6 m 82 2 r 28 m 84 m 10 m 1a m
6b m 38 m cf m 77 m d2 m b8 m 4e m b7 m f7 m d9 m 74 m 5e m 39 m b5 m 60 m 4 m 39 m 17 m 54 m 17 m 61 m 41 m d m 5b m 61 m e0
m 87 m 8c m fb m fd m b7 m 3e m 67 m 71 m b8 m 4e m fb m 5a m a0 m d8 m 17 m 39 m 61 m 5a m b8 m 38 m a m 90 m f4 m ce m 7f m
9b m 37 m 1d m 56 m 8d m 59 m fc m 34 m a2 m 30 m 2e m 9a m f7 m 96 m fc m b8 m c m ca m b2 m c m 5d m b2 m a1 m f2 m 88 m 1b
m cb m b1 m ec m 6c m ec m 5 m d1 m 19 m cc m 31 m c6 m 7f m 1e m 3d m fa m 57 m 45 m 88 m ab m 5d m 67 m 46 m 5 m d4 m cc m
5c m 7f m 6f m c6 m 3b m 98 m 73 m 1f m 2c m dc m 1a m ba m fb m 37 m b7 m e2 m 3e m 7d m b6 m 55 m 2 m 25 m 12 m 75 m 76 m 9
m 19 m 82 m 5b m e1 m ae m 3d m e8 m bb m 40 m 78 m ed m 52 m 90 m a6 m ea m 8b m 83 m 14 m 7e m 6a m 7c m d9 m 79 m 57 m 27 m
15 m b9 m 25 m 71 m c9 m 9e m 31 m 6c m fa m 8b m fc m d2 m 9c m 4a m 6c m 9b m fb m f7 m 8f m 9e m fd m 73 m 6 m 21 m f7 m a5
m notbusy
02 wcmd 8 m 59 m 0 m \ 0x85900 
eb m ba m ee m 90 m 5b m 8d m ae m 3d m e3 m 92 m 12 m eb m 98 m 59 m a2 m 5f m 61 m e8 m 92 m 7 m 24 m b2 m 45 m 83 m 30 m 83
m a1 m 51 m 7d m 84 m 16 m 26 m f3 m 48 m 1a m 6f m f7 m 79 2 r 91 m e9 m 1e m ba m 6e m e m d8 m e6 m d8 m 80 m c4 m a2 m 94
m 4 m 4a m f2 m f9 m f m f3 m e7 m 42 m ed m 2 m d1 m 8c m d m 5f m ea m 63 m 2 m 87 m 4a m 25 m 96 m 99 m d1 m fd m 5c m 6c m
64 m b0 m 28 m c7 m 5e m 83 m 44 m 22 m 5 m 3e m 32 m 7e m f6 m 8d m 42 m 3e m 85 m 3d m 98 m 87 m 24 m b3 m 68 m 5b m ad m 1d
m 2f m 8b m 9a m aa m dd m 62 m 8b m f8 m 6a m 3a m ca m dd m 7e m b1 m f5 m 9e m 8f m 17 m f7 m b6 m 24 m 7a m fb m 85 m e4 m
4a m 1f m c m e1 m b4 m 91 m be m fd m 32 m f5 m dc m c9 m 59 m dc m b0 m 90 m 51 m fc m b3 m 7 m 8f m af m 7b m 8b m 89 m 5c
m 97 m 9d m 5f m 29 m 33 m b m 35 m ca m 81 m 12 m 20 m 75 m 39 m ad m d4 m ac m 88 m cb m 53 m 47 m cf m fe m a5 m a2 m 87 m
44 m 11 m 9 m 9e m 1a m eb m 85 m a7 m 28 m 1f m 29 m 57 m 56 m 28 m 72 m 91 m 6f m 58 m 0 m 22 m 30 m 1c m 69 m 86 m a3 m 4b
m 67 m 20 m a2 m 86 m 39 m f0 m 25 m 35 m d1 m 9c m 6 m 74 m aa m c8 m d5 m 3e m b3 m 1f m b9 m b6 m ee m 4c m 7f m 9c m 3f m
6f m 2a m 34 m e0 m 61 m 12 m ed m a1 m a3 m 6b m 4e m 8e m 9e m 8e m 58 m 6b m 62 m 87 m 66 m 87 m 67 2 r df m f9 m 5b m
notbusy
02 wcmd 8 m 5a m 0 m \ 0x85a00 
e3 m ab m 47 m f m 7f m a8 m be m 7f m b5 m 63 m ae m 4 m 69 m 1c m 23 m db m 32 m 4b m 61 m 3 m 2a m a7 m 41 m eb m e9 m a m
dd m ed m 7e m ab m f5 m a2 m 4f m da 2 r f2 m 71 m a2 m e1 m 3a m b2 m b m de m 5b m db m 6c m df m b1 m f2 m ac m d7 m 50 m
47 m 1a m 37 m a4 m 62 m 4d m 84 m 10 m 1a m b1 m d6 m f m 24 m 7d m 17 m 75 m 38 m 8a m 16 m 2b m 1a m 35 m 68 m 91 m 31 m b1
m b0 m 49 m bc m d5 m 54 m d m c4 m 29 m a3 m a7 m df m d4 m 8e m 41 m 37 m c m 75 m 6d m b5 m f0 m 77 m e2 m 6f m 88 m 62 m
70 m fb m c6 m d5 m 6e m 76 m 66 m 81 m ce m 40 m eb m cd m 1b m f9 m 75 m 25 m d4 m 32 m 36 m eb m 5e m 52 m 85 m 2a m 8d m
7b m d5 m e m 19 m e m 7d m 42 m dd m bc m 3 m ba m c8 m dd m 13 m 85 m d0 m 87 m be m ef m c3 m 6b m 8e m 9d m 37 m 17 m 9a m
cd m 90 m 29 m 69 m 2c m 61 m 9d m 6f m a8 m d4 m 50 m 8f m 95 m e7 m 70 m 4e m ea m 80 m 14 m b m ef m 13 m 52 m af m 19 m c4
m 71 m b4 m 3 m a m 6e m 6d m f3 m 87 m b2 m 84 m 94 m 9d m 79 m e1 m 2d m 17 m fa m 12 m 9f m 5f m ff m 47 m ac m 62 m 77 m
64 m 54 m 66 m e5 m 23 m 9b m b9 m 55 m 4f m bd m 6a m ab m d8 m e5 m 1a m 62 m f0 m 1a m 61 m cc m ca m 3e m ea m b6 m 89 m
be m 25 m a9 m 15 m 13 m a6 m 95 m f3 m 18 m 94 m 40 m 1f m f6 m cd m a8 m 6e m 64 m 74 m 9d m e m de m 74 m d4 m 5b m ca m 2
m notbusy
02 wcmd 8 m 5b m 0 m \ 0x85b00 
4d m aa m 1f m 6a m d9 m 31 m 58 m 19 m 8 m 79 m 18 m 3e m 37 m 7a m fa m 6f m fe m 45 m 8 m 1c m 38 m ef m 7b m 41 m 54 m 44
m fd m cf m 31 m 1d m e7 m 89 m 79 m e5 m 38 m a9 m a4 m 92 m 28 m 3f m 17 m a3 m 60 m fe m 8b m 97 m f5 m 23 m d3 m 2 m 6a m
52 m 11 m fd m c0 m e8 m f2 m af m 45 m b m fa m c7 m 62 m d2 m 35 m 67 m be m c4 m 68 m e5 m 14 m d m 8c m 88 2 r d4 m 87 m
5e m 70 m f4 m c5 m 36 m 49 m 88 m ce m 59 m b m 14 m c2 m 7d m 47 m 97 m bc m 21 m 6a m d5 m 89 m ca m 3b m d3 m 85 m e0 m 8a
m c m 11 m 23 m 72 m 3e m 18 m 22 m 46 m 44 m ec m 29 m c6 m 3e m c4 m d8 m 87 m 10 m df m f6 m 2b m c3 m c7 m df m f4 m 2 m
a2 m e0 m 50 m 54 m 23 m a7 m bc m 60 m 45 m 74 m 15 m a6 m b1 m 3a m 61 m dd m a4 m eb m 6e m da m cc m c8 m 79 m c6 m 65 m
25 m 68 m df m cf m a2 m 38 m 47 m 69 m 11 m 8c m 5c m 94 m 6e m 23 m 7d m 27 m 4d m ee m c4 m 84 m 8b m 98 m 66 m 4e m cb m
39 m 88 m 50 m b2 m 28 m 42 m 56 m 8e m 77 m 18 m 5d m e9 m 4c m 11 m 21 m 3d m a5 m 1c m 57 m 6d m 49 m e3 m b2 m c8 m ac m
8a m 9 m cb m 0 m 20 m c0 m fb m 7e m 7a m f0 m f8 m 5b m 50 m 13 m 47 m e3 m 68 m d5 m 4b m 8b m 79 m 92 m 75 m 11 m 8f m 24
m 59 m 9 m 95 m 2e m 6c m e4 m d6 m f5 m 2a m 24 m 5 m a2 m a3 m 47 m 57 m bf m 92 m 2d m f2 m 35 m 88 m 2e m 38 m 1d m a8 m
1d m ab m notbusy
02 wcmd 8 m 5c m 0 m \ 0x85c00 
3a m 54 m 43 m b8 2 r 49 m 51 m 4a m e2 m fc m df m 39 m 44 m 29 m 19 m 32 m 6e m bf m 34 m ba m e0 m 4c m 33 m d0 m dc m 1e m
60 m 73 m 57 m db m 64 m 54 m a1 m 9e m e8 m 14 m d9 m 87 m 46 m 8f m ff m 15 m 91 m 23 m 65 m d6 m 14 m 4a m 7e m 34 m 5d m
27 m e2 m 5c m 9a m 83 m 6f m a7 m 45 m 4d m 26 m 93 m c9 m d m 9a m 19 m 39 m c7 m 7d m c7 m 87 m 89 m 24 m 63 m 9e m 17 m c3
m 68 m d3 m 7d m f m d6 m c m d6 m 6b m 7e m f7 m d m 5 m a m a1 m 51 m e m e3 m 5f m d1 m 69 m 2e m bf m 71 m 54 m f6 m 58 m
94 m 53 m 5b m 75 m b m ab m 55 m ee m 76 m c7 m b2 m 68 m 87 m 9f m 1c m 3d m ff m e6 m 1a m 70 m e m 2e m da m d1 m a8 m 81
m fd m d5 m 6a m 29 m 58 m d m 2 m e7 m a0 m 26 m b3 m e4 m b7 m 79 m eb m ce m bd m bb m d9 m d8 m d2 m c6 m e9 m b4 m 5f m
54 m fc m b8 m d4 m 72 m d7 m a3 m 5f m 72 m 40 m a8 m 14 m 62 m 4a m c m 11 m 99 m 23 m c5 m d8 m 87 m d0 m f7 m a1 m ef m fb
m 73 m da m 34 m a1 m 79 m 25 m 19 m cf m a3 m b m 3e m 59 m d7 m 70 m e1 m fa m d5 m 7d m 7c m 5f m 5c m 53 m d4 m 52 m b m
8c 2 r 11 m 28 m 92 m e8 m a3 m 18 m 23 m f3 m f9 m c3 m 2d m 61 m b7 m 73 m 18 m aa m 84 m df m 3c m 7a m c1 m 71 m 84 m b2 m
83 m 70 m 72 m 77 m 58 m 73 m c3 m c0 m 89 m df m b0 m a5 m bf m 2a m c4 m 50 m b1 m f2 m 12 m ec m bc m eb m 7d m 3 m e4 m
notbusy
02 wcmd 8 m 5d m 0 m \ 0x85d00 
c5 m a8 m b5 m a0 m 64 m f6 m bb m 83 m 7 m fd m ec m 22 m b2 m f3 m 45 m 9 m 30 m 22 m 13 m b7 m df m 5c m d7 m a4 m 72 m de
m b3 m 2e m ed m 59 m 19 m 3f m 84 m 8b m 87 m 1e m d8 m 3 m 5e m 92 m 77 m 4e m 0 m e8 m 3a m 2c m 5 m fa m c9 m 11 m 15 m 2f
m 97 m 5a m a9 m c5 m 35 m a8 m 13 m a m 32 m cf m 2c m f5 m e6 m 55 m 9e m 6a m e5 m 1f m 11 m 8d m a2 m 84 m 67 m 71 m e4 m
38 m e8 m b4 m f4 m 3b m b2 m 25 m 11 m 40 m e m 94 m cb m 26 m 15 m 47 m 44 m aa m 20 m 70 m d1 m 9c m 63 m 66 m b3 m a6 m 97
m 51 m 1e m 6f m 7c m fc m 17 m 2b m 74 m 69 m 74 m 58 m 60 m a5 m ce m d8 m 10 m 2c m e9 m 9 m 87 m 4c m 8c 2 r 18 m 29 m 92
m a3 m e2 m 94 m 51 m f2 m d3 m 74 m 56 m cf m 14 m 22 m e2 m 9c m f1 m b4 m f4 m e6 m 8a m 91 m ad m 28 m fc m e4 m 90 m 93 m
5a m 77 m bd m e4 m 2 m 9f m a0 m e9 m 59 m 99 m 4b m ec m 60 m db m 19 m dc m ed m be m 33 m 82 m d7 m 87 m 11 m 48 m 98 m 41
m 14 m 92 m 50 m 35 m 5e m 3c m 7a m 77 m d1 m 57 m 91 m 2 m 3 m 0 m 32 m 96 m f4 m cc m 46 m df m b2 m aa m 2f m 81 m 94 m ac
m 69 m ac m 20 m 26 m fd m cb m 70 m ab m ed m ad m 88 m 42 m 24 m a2 m 9c m 60 m 21 m 61 m df m f1 m 11 m b0 m 17 m 8 m 3 m
b8 m 2 m 41 m ba m 45 m 62 m 35 m 14 m d5 m f5 m 82 m 4 m 45 m 28 m 2c m 34 m 19 m 5d m fc m 56 m 5f m d0 m 8b m e3 m 58 m
notbusy
02 wcmd 8 m 5e m 0 m \ 0x85e00 
b m c m a2 m c m c2 2 r b2 m 37 m 9b m 31 2 r 47 m a2 m ac m cf m ba m 18 m 63 m 7c m e3 m 13 m 1a m 24 m 9 m df m 2 m 8 m 21
m 63 m f7 m e8 m a m 23 m c1 m c5 m ba m 4b m f8 m a7 m 41 m 86 m ba m 6a m 29 m 31 m 20 m 72 m f4 m 70 m e6 m 6f m 8f m 3a m
b8 m f3 m 69 m 5e m 1f m 65 m 75 m 84 m 45 m ad m 19 m a5 m c5 m 74 m 77 m cb m 8e m 5a m 23 m 2d m b7 m 17 m b7 m 46 m fd m
6f m ce m 9d m f9 m 44 m df m a1 m 32 m 5a m 6 m 46 m 9b m e9 m 3b m a9 m 36 m da m 46 m 5 m b7 m 8 m 2a m a7 m b1 m 7a m 85 m
d4 m aa m 98 m fb m a5 m 62 m b3 m e7 m 74 m 52 m cc m ca m 88 m e7 m af m fd m 16 m fe m b4 m 15 m 66 m ca m 48 m 22 m c4 m
ab m 46 m 97 m 4f m 7b m a2 m 90 m 1f m 86 m 24 m d7 m 8e m 8 m f9 m 77 m 71 m e m bc m 59 m 53 m c4 m c9 m 6a m 1 m cb m 4e m
56 m 61 m 1 m 4d m 27 m 93 m f8 m 48 m 63 m f7 m f0 m a m 8e m 56 m 43 m c5 m 2d m d5 m cc m 17 m a0 m 39 m 3b m 2a m 21 m a4
m 6c m 52 m a1 m 86 m 9f m 85 m 8d m bf m 35 m 8f m 2c m 13 m 6a m 48 m 38 m 8a m be m ff m 87 m ae m 5 m 19 m 8a m 52 m d9 m
ed m db m 24 m c3 m b2 m 79 m 12 m 63 m f2 m c7 m a m e5 m 97 m f8 m d4 m b0 m fa m c7 m 4f m 9c m 2e m fe m 99 m f1 m 4 m 58
m c4 m c2 m 11 m 39 m 60 m e5 m da m 43 m c9 m 96 m 55 m b3 m f0 m e1 m 1b m 3f m 6e m db m b7 m 34 m da m 5a m f2 m f4 m
notbusy
02 wcmd 8 m 5f m 0 m \ 0x85f00 
d7 m 83 m d1 m ae m f4 m d m 92 m da m b9 m e m 8c m 0 m 40 m 77 m 68 m 1 m 4a m 89 m 8 m 24 m 22 m 6a m a4 m e2 m 10 m 21 m
85 m 48 m 21 m 84 m 94 m b7 m b0 m 13 m b9 m 4c m a8 m c6 m ab m 2b m 87 m 9a m cc m 90 m 53 m 3f m d4 m 5b m fa m ea m f0 m
3c m ac m 1f m 3b m 8d m 2 m ab m 3e m ca m 35 m 40 m 6f m 3e m 22 m e3 m 7d m 9a m 24 m 50 m 8c m 2b m 5d m 52 m 58 m 39 m ee
m ef m ea m 33 m b8 m 3c m 2 m 42 m 22 m 1c m ed m 60 m 3c m a3 m 70 m 5f m e4 m 91 m 57 m 32 m b7 m db m 24 m 45 m 77 m 38 m
1f m 78 m 90 m 9f m 21 m f5 m 2a m db m 86 m 9d m e9 m 23 m c4 m 96 m 3c m fb m 2f m 39 m 13 m c1 m ed m a1 m f7 m 2b m 11 m d
m 32 m b2 m a5 m 22 m e1 m 20 m 46 m 4a m 1c m 43 m be m 35 m 46 m 66 m 7e m cf m 10 m 47 m b7 m 52 m ab m ce 2 r 47 m 41 m cb
m 4e m 2d m 54 m 3a m 62 m c5 m 84 m e9 m 6 m 86 m d5 m a4 m 99 m 66 m fd m 8e m f m e8 m 66 m 1 m 33 m ac m cc m 36 m 85 m a5
m 61 m b4 m 81 m be m 2d m e5 m 65 m 3d m 18 m b9 m 55 m 58 m 95 m c6 m 44 m 8d m a3 m 2d m ce m 24 m a m 1c m 43 m e0 m d0 m
a5 m e m 0 m 90 m 48 m 76 m 4 m cc m b1 m ea m e4 m 8d m 4d m b4 m 8a m ee m 15 m 35 m 43 m 88 m 1f m f8 m cd m c1 m d5 m 3f m
79 m 3a m 65 m d6 m 49 m ea m 64 m d3 m 78 m 3 m 5f m 1f m 2b m 20 m c5 m b2 m 26 m bc m fa m f2 m 59 m 5d m 77 m ab m a8 m
notbusy
20 wcmd 8 m 60 m 0 m notbusy \ 0x86000
02 wcmd 8 m 60 m 0 m \ 0x86000 
64 m 6c m ac m c2 m 9e m 9a m 54 m d m e9 m ce m f5 m ed m 61 m 94 m d4 m 3b m 49 m 90 m 52 m 62 m f2 m b9 m 42 m 91 m e3 m fb
m 1a m 99 m 47 m a m 6a m d1 m 8d m e3 m ba m 85 m 57 m b3 m 21 m 40 m 91 m 5c m c4 m f8 m 7c m 32 m f2 m 26 m 1e m 1f m 41 m
54 m 61 m 70 m d1 m 98 m 84 m ba m 52 m 5c m ab m 59 m 46 m a6 m 79 m cb m ea m e4 m eb m 91 m 67 m 93 m ee m c9 m ad m a3 m
7b m de m ff m ae m 6a m e9 m 46 m 58 m 39 m 26 m 5b m b4 m 58 m e m 46 m 9b m e8 m 3b m 7b m b5 m eb m c2 m 48 m 6a m 33 m d4
m 94 m d1 m 5d m 46 m d7 m 7d m 2a m 7b m 46 m 81 m bb m 24 m 5 m fc m c9 m 2f m fd m cd m 7f m 69 m a7 m 90 m 74 m 7f m 60 m
ee m e3 m f2 m e1 m b5 m 37 m ce m 89 m 39 m 89 m 92 m 1d m e6 m 35 m 3a m 4d m f9 m b5 m 2c m 49 m 7a m c5 m 35 m 5d m e0 m
1d m 6c m d3 m f2 m fa m 11 m da m 5f m 83 m 11 m 8e m 7 m f3 m 62 m 76 m 6d m 4 m a1 m b9 m da m c8 m c0 m 54 m 2c m 2a m 55
m 4b m fc m 99 m e6 m 3d m c2 m bc m 59 m a8 m 8d m 72 m eb m 66 m 9c m 3c m 19 m 2a m 42 m 16 m 8b m b3 m 84 m 2 m e7 m 12 m
2 m 77 m f m 19 m 5d m 7e m c8 m 16 m 92 m b7 m ea m c6 m 83 m 51 m b3 m 72 m c9 m 81 m b1 m 73 m 9a m 26 m 93 m c9 m ef m b4
m ea m 7e m 9e m f9 m a6 m 3a m 2f m 52 m fd m 5b m 5e m 42 m b5 m 6f m b8 m 6f m 11 m 44 m eb m 6a m 23 m a3 m 4e m 9 m 43 m
c4 m e6 m notbusy
02 wcmd 8 m 61 m 0 m \ 0x86100 
2a m 3a m 5 m 66 m ee m c4 m 84 m 42 m c m 31 m d4 m bb m 25 m da m 76 m 5d m 49 m dd m d3 m 8c m d m 8d m 6c m 63 m e3 m 94 m
63 m 44 m a2 m 94 m f2 m be m 89 m b6 m 9b m 76 m 8e m 5a m 57 m 26 m 90 m 7d m 82 m f7 m 8a m 91 m 96 m ba m be m 77 m 95 m
21 m 38 m ba m 76 m c0 m be m da m eb m 1c m 9b m d6 m ee m d2 m b4 m 28 m f4 m 2c m ac m 5e m dd m bc m bb m b2 m a9 m 8d m
48 m f4 m a3 m c3 m 5f m 9d m 9a m d8 m 3 m 21 m a9 m c m 81 m 5 m 30 m 12 m 20 m 29 m 8e m 98 m ec m 19 m 89 m 99 m f9 m ec m
61 m 27 m 47 m 7f m d4 m 58 m c1 m 5c m 91 m 4 m 2e m d0 m 50 m b1 m b2 m 84 m 63 m 43 m 6d m 57 m 4d m 1e m d4 m aa m 34 m f5
m e5 m 57 m d9 m e6 m cb m b2 m 0 m e6 m 6d m f3 m 15 m 61 m b4 m ab m 7d m eb m 28 m ad m dd m 4c m 1b m 69 m 18 m b1 m c1 m
46 m 40 m 81 m 83 m f4 m a m 88 m 44 m d1 m f6 m 79 m 2e m 78 m 77 m f7 m d2 m 44 m a4 m 7 m c m ca m 6 m 17 m fc m ce m 70 m
91 m ea m da m 33 m 44 2 r 82 m a4 m a2 m 66 m 7c m 22 m ad m 67 m c3 m a1 m 77 m b4 m 72 m c0 m b2 m ab m 96 m 86 m dd m 6a m
2c m 8e m b2 m a2 m ce m e5 m a4 m 49 m dc m 83 m 4c m e3 m 45 m fc m 2b m 1e m 3e m ba m 8c m 28 m cb m 5 m 67 m e6 m ab m e
m 69 m dd m 22 m fe m 11 m 22 2 r 8e m e4 m ea m 27 m 6b m fc m 78 m 55 m bc m d m 19 m 60 2 r 4e m f6 m 1e m 9c m 52 m
notbusy
02 wcmd 8 m 62 m 0 m \ 0x86200 
4a m 67 m e m 71 m 74 m ab m 33 m bc m 5d m a7 m 30 m 72 m 4 m 82 m 2c m 69 m 80 m 25 m a6 m fb m 42 m ce m 93 m c9 m 64 m d2
m fd m 74 m ab m a4 m c6 m f7 m 4e m 74 m 86 m d5 m 38 m 5c m b6 m a m 8c m 76 m bf m ef m 1d m ac m bf m 96 m 55 m 51 m 97 m
1d m 43 m 88 m d8 m 38 m 51 m 99 m 52 m e0 m 60 m 5b m 2a m 2d m c8 m d0 m ca m 27 m 1c m be m b9 m 5a m 4b m 39 m fd m 49 m
a2 m df m 88 m f8 m 99 m 61 m 70 m fd m a8 m 8f m d9 m ec m 65 m 13 m 7d m 24 m 8e m cf m 63 m cd m 5d m e6 m ca m 1a m d8 m
46 m 2d m cc m 69 m ce m 3f m c2 m 12 m fc m 47 m 44 m 3c m 62 m 78 m e9 m b9 m c6 m fe m be m fe m c3 m 12 m e8 m d5 m 70 m
59 m 5 m 24 m 69 m e7 m dd m 71 m ce m 4d m 98 m 84 m 8e m 51 m c5 m d5 m 6f m 3b m bd m 56 m b8 m 6f m fb m 59 m 0 m 5b m 1b
m f1 m 84 m 24 m e6 m 94 m 3e m 3f m bc m f2 m 88 m a2 m 94 m 25 m 90 m 59 m c5 m eb m 8c m 95 m c5 m 9d m e m 5a m 37 m d3 m
69 m 84 m bb m 8d m d7 m 2b m 40 m a m 96 m f9 m a m 5b m 7a m 2 m 1b m ab m 62 m 5f m 1a m 46 m bb m df m 77 m 92 m b5 m 8a m
1d m 36 m 95 m 3e m 88 2 r 74 m c4 m e8 m d7 m 9f m f m 90 m 6c m b1 m 8 m c9 m 82 m c m db m 26 m 52 m 48 m 32 m b5 m 26 m ae
m 89 m 3e m 22 2 r c2 m b m 86 m 38 m ba m c5 m c7 m b0 m 48 m e3 m a6 m 7b m f4 m ef m b5 m 71 m ef m f3 m ba m d7 m 10 m 28
m notbusy
02 wcmd 8 m 63 m 0 m \ 0x86300 
83 m fd m b0 m ce m b0 m bb m d9 m f0 m d2 m f3 m 1c m fb m 39 m 5d m b4 m 64 m 16 m 89 m 98 m 77 m 85 m 7f m 73 m 42 m f8 m
b9 m 77 m 9c m 77 m 83 m e8 m 81 m c6 m 93 m 52 m 72 m 1a m d1 m de m 1e m 60 m 9 m 38 m b m 9 m 50 m c8 m e0 m 94 m 52 m ba m
72 m 78 m ed m cd m bc m 79 m 6b m 48 m 2a m a4 m b9 m d0 m 94 m f7 m f3 m 27 m f9 m 70 m fb m e9 m 64 m d2 m fd m e8 m c3 m
5a m 34 m 3c m 6e m e6 m f6 m 9f m ca m 8e m a9 m aa m b6 m c7 m b6 m 73 m b8 m d9 m be m 77 m a1 m a9 m 3a m 82 m 39 m e2 m
18 m be m 40 m 29 m 9f m b5 m 99 m 52 m 42 m 44 m 24 m 76 m 29 m 4 m db m 3c m da m 6f m 4d m 13 m ef m 8 m 9 m 1 m 47 m fe m
c1 m 2d m 74 m a4 m 40 m 56 m 1 m 47 m 49 m 6e m 17 m 98 m 7b m e2 m b6 m 4d m c2 m 32 m 53 m d0 m 6a m 55 m 5d m e2 m f2 m 17
m 1 m 47 m 11 m e9 m ef m c m 2c m a9 m e2 m 1b m 6d m d7 m 6f m 31 m a9 m 8a m 2e m 90 m fd m 41 m e3 m 64 m 5d m 6b m a8 m
e6 m cb m f0 m 69 m 23 m 32 m b6 m a7 m 60 m 48 m cb m f0 m 11 m c3 m 46 m 5 m 43 m 5a m 2 m b8 m 4 m be m 95 2 r 71 m 98 m 49
m e0 m 74 m c2 m 91 m 8f m 19 m 3d m 13 m 0 m 9e m b8 m 35 m 2a m d8 m 36 m d8 m 29 m b1 m 2c m 8c m 36 m d3 m f7 m 8e m 9c m
23 m 4c m e8 m 26 m 4d m 91 m 74 m e3 m d1 m 75 m 3f m b3 m 7e m 17 m cb m b7 m 9b m 40 m ce m b8 m 2d m 8e m e4 m f0 m 8a m
a4 m notbusy
02 wcmd 8 m 64 m 0 m \ 0x86400 
0 m 72 m bb m 6c m d6 m 28 m 92 m 24 m cd m f6 m f1 m e9 m 87 m ba m 3 m 30 m 4e m f6 2 r 0 m 5a m ca m 8e m 72 m b7 m da m 3f
m cf m be m 9c m d2 m 78 m 29 m 5a m 78 m 15 m 8d m a2 m 6 m 19 m b6 m 77 m 45 m ec m ca m 2a m bf m 6f m 11 2 r a9 m ac m cf
m 28 m f3 m 54 m 59 m ad m d6 m 8a m 3a m 92 m ed m 47 m 45 m 27 m 39 m 56 m f6 m 9b m a4 m 2a m c3 m ea m 26 m cd m 13 m 76 m
fe m f0 m 2a m bf m 4 m da m de m 29 m b1 m 34 m 8c m 36 m d0 m f7 m ee m 69 m 24 m 1d m 37 m c4 m 79 m 7 m 28 m 6e m ba m 29
m 1b m e9 m 60 m 8d m 2f m 70 m 7e m fa m 40 m a0 m ae m 31 m c m 35 m 4c m d5 m 49 m 4 2 r 1c m e1 m c8 m a2 m c6 m 30 m c4 m
ed m 12 m 8e m 89 m 7e m 55 m 53 m d0 m 0 m b5 m e0 m 6a m c4 m 96 m 3e m ba m 52 m 94 m af m dc m bc m a2 m 7b m 6c m 60 m 16
m 3c m ce m 33 m 26 m 7c m 84 m a1 m 6d m d4 m 89 m 23 m ed m 32 m 9 m 8c m 9b m bb m eb m 3f m bb m f5 m cc m 67 m 5c m 66 m
e m 4a m 5f m b6 m 91 m a7 m 15 m c m ab m d m f7 m bd m 1b m 30 m 72 m f1 m 6 m 44 m 40 m d8 m 67 m 38 m 4a m ba m 1c m 86 m
4d m 1c m 5d m 2a m 1b m 3c m 6b m ab m a4 m cd m 90 m 4b m b4 m 82 m 23 m b3 m 5f m e4 m cf m 41 m d m d2 m 44 m 64 m 9a m 16
m 58 m 81 m 89 m 4d m 23 m e9 m cd m 90 m da m 9a m 40 m 2 m 6f m 73 m 1f m 7b m 85 m d m 91 m 41 m 69 m 39 m a m notbusy
02 wcmd 8 m 65 m 0 m \ 0x86500 
86 m 3d m 40 m 81 m d2 m b8 m b9 m a0 m 8b m 1a m da m fa m 8b m da m 4e m 6f m e5 m 87 m 5e m e7 m cf m 5a m bd m 1e m f7 m
1d m 5f m 7 m 40 m b3 m 9a m 56 m 65 m e5 m 7d m d9 m f7 m b6 m a4 m 79 m 95 m 2d m c4 m 36 m 8f m ff m db m 83 m 66 m 59 m af
m 73 m ec m 9a m cf m 57 m fe m 85 m 9 m 56 m 80 m f5 m c6 m a1 m 91 m 45 m b8 m ac m 89 m bc m 4e m a7 m a6 m 98 m e6 m db m
30 m 9 m 16 m d7 m d8 m b8 m 6c m d8 m ed m 52 m 41 m 86 m d1 m 25 m c9 m ff m 4b m 71 m 74 m a9 m 9a m 74 m 6a m a6 m f8 m 5f
m d m 59 m 79 m 90 2 r 73 m 48 m f3 m c0 m a8 m 13 m be m 51 m af m 81 m ae m b1 m 53 m 62 m 94 m 54 m b7 m 87 m 7d m af m d2
m 50 m 43 m 21 m bb m f6 m c4 m d5 m 9b m 7f m 35 m 44 m 18 m c1 m f9 m bb m 55 m f5 m 1 m 6f m 1a m ad m 35 m e m ad m f3 m
c2 m 17 m b5 m f5 m 3b m 5b m f6 m 8e m a2 m e4 m 12 m 40 m 83 m c0 m 41 m 6c m 6d m 55 m 93 m b6 m a9 m 7c m 70 m 14 m b0 m
b3 m fc m 8e m c2 m f m 96 m ae m e4 m 59 2 r f6 m fe m 57 m 8e m fe m 8b m 5b m fd m be m e4 m 4b m ba m 3 m 75 m ed m 9d m
12 m fb m b2 m ef m e5 m 5b m d1 m dc m fb m 14 m 49 m d1 m 2d m ed m 42 m e3 m bc m ba m cb m 6a m 57 m 5d m 46 m 60 m ad m
58 m 1d m c0 m ea m 38 m c2 m c1 m d7 m d5 m ef m 2c m ad m 69 m 53 m 45 m d m 24 m 48 m 24 m 63 m 14 m d1 m 1c m 2c m dc m e
m 2c m notbusy
02 wcmd 8 m 66 m 0 m \ 0x86600 
89 m 95 m c9 m c8 m 48 m 19 m 95 m 8d m 35 m fc m 8c m 1e m 5c m 6b m 4 m d5 m 9 m 4e m 25 m 34 m d3 m ac m ff m f6 m dc m 3a
m b1 m 6d m 17 m 76 m 4a m ec m 65 m df m ab m b7 m 7d m a9 m 8b m 0 2 r b4 m 14 m 5f m fe m 9 m f m 1e m fe 2 r 32 m a8 m 51
m 94 m 96 m 58 m 7 m 5e m d0 m 56 m c5 m 91 m 6b m e8 m 3e m 57 m bb m c7 m 9c m b1 m c6 m 2 m d1 m 95 m 1a m 4f m 2f m ae m
58 m dd m ae m 3 m 50 m df m b7 m 2 m b4 m 7d m c4 m d m fd m 63 m c6 m 5b m 8e m 2d m 56 m 27 m 46 m 5d m e5 m 3e m 96 m 70 m
99 m 9c m c6 m 3d m 29 m cc m dc 2 r 82 m fa m c6 m ff m ae m c m 2b m db m f2 m b1 m da m 4e m 9 m a5 m 6b m cf m fb m 5e m
a5 m 99 m 81 m b0 m 3 m ae m dc m 85 m 56 m aa m eb m 2 m 0 m 8c m ed m ba m ef m 89 m 10 m 19 m f8 m e9 m 3b m 8f m 33 m 58 m
d0 m 4f m 78 m b8 m e5 m 32 m 28 m 63 m 49 m 1c m 18 m 57 m 50 m dd m 2a m db m 2d m 74 m 32 m e7 m be m 2b m c5 m ae m 9b m
2b m 1f m e m 15 m 6 m 2f m f1 m cc m 75 m 45 m 5f m 81 m c4 m f8 m 9 m 6 m f4 m e1 m 3b m 94 m a0 m b3 m e6 m 87 m d6 m 8b m
37 m 4f m bc m 5e m a3 m a7 m 77 m bc m bf m f2 m 4e m d6 m dd m 29 m 51 m 10 m bc m b7 m 7d m af m da m d4 m 56 m dc m ad m
a5 m dd m 35 m da m 97 m 5c m d1 m 3 m 48 m 83 m 3c m 52 m 0 m 80 m ab m 55 m 13 m 95 m b8 m ef m 4e m 88 m ad m f5 m notbusy
02 wcmd 8 m 67 m 0 m \ 0x86700 
91 m 5 m 2c m 12 m a4 m 4b m 87 m 97 m a2 m a m 43 m 18 m a6 m 1a m 6c m cb m c8 m 2e m 7e m 3 m 6e m 6d m a6 m 75 m df m 65 m
69 m d0 m 86 m 17 m 5c m b m c m c9 m 45 m af m 2c m dd m 8c m 1d m 15 m 88 m 2a m e m 46 m d7 m 61 m a5 m 87 m 2c m e0 m 50 m
60 m a4 m c7 m 29 m 54 m 69 m d6 m c7 m 8e m 4b m 76 m 2 m bc m ff m 5d m 83 m 8a m 9d m 79 m f1 m 66 m fd m 9d m 12 m 7b m db
m f7 m a m 6d m e0 m ad m 26 m 80 m 7e m b7 m 1e m bd m 5a m 7b m 9d m 3f m 93 m ac m b5 m be m 5c m 50 m a4 m 56 m cf m 8e m
6 m 41 m 71 m 34 m e m a4 m 8d m f6 m aa m a2 m 6f m d0 m 4c m 35 m 98 m db m 4c m 1b m d5 m b m 9c m 88 m a3 m e8 m fa m 45 m
69 m 90 m f6 m 33 m 7e m 96 m 7b m 84 m 69 m c6 m 65 m f0 m 54 m ae m 5 m 53 m 67 m e3 m 82 m 68 m 8e m 62 m 55 m 48 m b5 m d0
m b0 m c5 m 1b m 4b m b3 m 2e m 8b m 37 m f m 6c m 1d m a3 m 91 m 77 m 2b m d4 m a7 m 28 m ef m 64 m a7 m c4 m 1e m f7 m bd m
5a m 2b m cf m ca m 6c m fa m 9d m 5d m 7c m f6 m f2 m ed m 8a m b3 m e5 m 70 m bf m c4 m b m 5f m 50 m 34 m d1 m ea m e1 m aa
m 61 m f3 m fa m 28 m 49 m 94 m 2c m c3 m f4 m e2 m e1 m a5 m d7 m c5 m 41 m 2b m 92 m 7c m 7b m 6 m 2e m 5a m a0 m 6e m b7 m
1c m 5e m 7b m d1 m 9c m 68 m a4 m 7b m da m 88 m 8c m ed m 29 m 28 m 44 m 66 m 45 m e6 m 8 m c9 m 9b m 23 m 5a m 17 m f m
notbusy
02 wcmd 8 m 68 m 0 m \ 0x86800 
f2 m fb m d0 m 77 m 5d m a5 m 59 m 9b m 61 m f5 m bf m 5a m 87 m 41 m 7f m f9 m e4 m da m b0 m da m c1 m 4e m 9 m 80 m bd m ef
m 7b m f5 m 96 m dc m ca m 5e m 9a m 5b m 3a m 60 m a3 m ed m f m 44 m ef m d6 m c5 m 6f m 7c m ab m 19 m 2c m 15 m 44 m ad m
d7 m 4 m 47 m 49 m 57 m 3f m cb m d3 m bf m 3a m bc m f4 m d6 m ca m 41 m b2 m a5 m 40 m 4c m 9e m b6 m 79 m 36 m 6a m 3 m 6d
m a4 m b5 m 31 m 6f m 3d m bc m ee m 42 m a9 m b6 m 50 m 36 m 97 m 8d m 9e m 64 m ec m 5f m 95 m 4f m d0 m 4e m b6 m 25 m c4 m
b9 m 45 m 19 m 44 2 r 8d m 53 m 9e m dc m 43 m 1d m 0 m c1 m 8a m e1 m b4 m d2 m ac m ef m da m 28 m 64 m d m 97 m 9d m e8 m
f2 m da m 76 m b8 m 53 m c2 m aa m af m ef m 5d m df m 73 m 69 m f2 m 92 m 2c m 37 m 8b m 1d m 8b m ad m 94 m 52 m 4a m e9 m
1b m 6b m 3d m 7d m 87 m ed m d8 m cb m 66 m 7d m df m fb m f2 m 2d m b m db m 2e m 44 2 r aa m 38 m 43 m 2a m df m a4 m 74 m
c1 m f0 m d2 m a3 m ad m 60 m 1 m 3a m 16 m ce m bf m 5b m c8 m c0 m 65 m 31 m b3 m 60 m 48 m 2a m f2 m 8f m 71 m f4 m 65 m d9
m f6 m 2d m 85 m b9 m 53 m da m 1a m 5e m 71 m 7d m e9 m bc m de m fa m bd m 8c m 9d m a9 m ba m 4b m 71 m 2c m a5 m 38 m 70 m
5c m 61 m cc m 2f m 19 m d9 m 7f m 78 m 56 m ae m d3 m ac m b3 m 61 m 75 m db m 87 m b7 m 3a m 7d m da m d0 m b0 m 5a m 77 m
a7 m notbusy
02 wcmd 8 m 69 m 0 m \ 0x86900 
84 m 2a m a3 m 3d m ed m 1b m 2c m 64 m b0 m 88 m 40 m 3f m f2 m 22 m 90 m 15 m 49 m 17 m 6c m f7 m f8 m 5d m 6f m 57 m bc m
f4 m 57 m bf m ab m e7 m 18 m 45 m ab m c3 m 33 m 6c m ba m 42 m 69 m 3 m b1 m b3 m 38 m 43 m a7 m 47 m 50 m 81 m 4 m c9 m b2
m 51 m c7 m 29 m 7d m 65 m 78 m e9 m 6d m 48 m 22 m 45 m 44 m b9 m 6e m 92 m 1c m e7 m d m 30 m ae m 1 m e2 m 9b m 84 m 8e m
bd m 4d m a4 m 2c m 8c m 78 m f8 m f0 m ea m 99 m e4 m e m 2 m 20 2 r 13 m a7 m f3 m 87 m 19 m ef m 77 m 7c m f m 2a m 9 m 4e
m 23 m e5 m 9d m aa m 8b m c9 m 70 m 1a m b1 m d0 m 40 m 44 m 8d m d2 m 48 m a6 m 68 m 1d m 8c m 92 m 6c m d2 m 9d m 93 m 66 m
7d m f3 m c7 m b5 m ba m 7d m 6c m b5 m 74 m b3 m 93 m 9d m 12 m 86 m fd m bd m eb m 5b m 95 m d6 m b6 m 2 m 5b m 46 m c9 m 36
m c7 m 14 m cb m e6 m 82 m f1 m c5 m 6f m cb m 47 m 7e m f4 m ee m 10 m c9 m aa m 66 m dc m 76 m 4d m 66 m 52 m 57 m f8 m 40 m
38 m 97 m 59 m 4b m df m 64 m f8 m 0 m 20 m 1 m 53 m 51 m bc m e3 m 77 m 2b m 2f m b6 m f6 m 2 m ac m b4 m 2a m 1e m a8 m af m
cf m 29 m 25 m 6e m c4 m bd m 49 m 5b m 2e m 1b m 86 m ba m 39 m 67 m 21 m 7 m 8b m 64 m 2f m 8e m bd m 3d m 2 m b1 2 r 6b m
3e m 77 m 2f m 38 m 42 m 4e m fc m e9 m 21 m 8e m ee m fb m de m 42 m 6 m 12 m e1 m 72 m 78 m 46 m f0 m ba m c8 m 94 m 4a m
notbusy
02 wcmd 8 m 6a m 0 m \ 0x86a00 
fe m 18 m 57 m 60 m 1e m 64 m 2 m 8d m 60 m 54 m a7 m 59 m 4f m 27 m 93 m c9 m 8d m 1b m 47 m e9 m 2 m 3c m 71 m b6 m 8b m 3b
m 25 m f6 m ba m ef m 55 m 39 m 2b m d9 m 67 m e1 m a4 m 51 m d8 m 17 m c0 m ea m dc m f4 m 76 m 2a m ec m 7c m 3f m a6 m d1 m
bc m 9d m ad m 1d m db m 29 m 41 m b9 m 96 m 55 m 62 m c8 m b5 m c6 m d9 m ea m 10 m 6d m b6 m 75 m 0 m 90 m 37 m ab m aa m 3d
m a7 m 6e m fe m b8 m 74 m c2 m d m bf m 6e m 9c m d7 m 8b m 2a m a0 m 64 m 67 m 96 m ce m e1 m e0 m 3a m 52 m 67 m 28 m cc m
cf m 19 m ef m ae m 9a m e9 m fe m 44 m c1 m 11 m f3 m 59 m c3 m bd m 9d m 13 m 53 m 23 m 79 m 33 m 24 m a3 m 46 m ee m d2 m
7c m 20 m e1 m d0 m 3b m 23 m cb m 8 m a0 m 56 m a9 m 42 m bd m 4d m 65 m 9f m 9e m 1d m a9 m 79 m d6 m 23 m 95 m 70 m bd m e7
m b4 m ee m ff m c3 m ab m 2a m c3 m 6a m 8d m 9d m 12 m b9 m 7f m 4b m f1 m de m c3 m be m 17 m 2b m a1 m 81 m 7f m 84 m 76 m
20 m 41 m d1 m 45 m 16 m 2e m 1b m 34 m 3d m d4 m 2d m 57 m 79 m f7 m a7 m 0 m 2e m d m dd m 3a m bc m 95 m bb m e4 m 5c m ce
m 4a m bc m 22 m 48 m 88 m 4 m c0 m 79 m 95 m 6c m f1 m d3 m 96 m d6 m 84 m f3 m 5b m d6 m 47 m 52 m 89 m d6 m 14 m 32 m 27 m
4e m e9 m 2b m c3 m a m 7e m 3f m f5 m 6 m 53 m 48 m 21 m 2a m 7 m a3 m 95 m e2 m 69 m 72 m 70 m 15 m 5e m 30 m 8 m 5 m 3d m
69 m notbusy
02 wcmd 8 m 6b m 0 m \ 0x86b00 
6f m 54 m 46 m e0 m 13 m 43 m 1c m 35 m 4 m da m 21 m b3 m c m e6 m 60 m 7a m d m 89 m 41 m a8 m 98 m 4f m 86 m a7 m c3 m 50 m
44 2 r 21 m b4 m 4e m 4f m 1d m 78 m 5b m 28 m db m d4 m 10 m 91 m 42 m 23 m cd m fa m d0 m 66 m b5 m b8 m a7 m 5f m e6 m 38 m
79 m ad m 9d m 12 m 22 m 0 m 2c m 1b m 68 m ef m fa m 5e m 81 m b1 m ca m 9a m 83 m 6c m 4b m 37 m ab m 8e m 1b m e2 m 18 m e
m fd m 8e m 9e m 99 m 90 m ad m cd m 72 m ae m af m 79 m 2d m b m 7b m 1b m 7e m a3 m f2 m 9f m 13 m 73 m 4c m b9 m e0 m 3f m
0 2 r 25 m 40 m 5f m 6 m a7 m f9 m 8e m 9 m 76 m 45 m 5d m 89 m 5d m 97 m cb m 16 m f8 m dd m aa m cc m a7 m ff m fa m e0 m da
m 3b m bd m 49 m ad m 73 m 22 m a m 4c m 44 m 29 m 51 m 1e m b9 m 79 m 40 m 1a m ac m 7b m 54 m 67 m d1 m 7 m 6a m 14 m db m
fc m 88 m 28 m e7 m a2 m 8f m c6 m 13 m 71 m 9f m 77 m 6a m b5 m f4 m 10 m 22 m 11 m 52 m 4a m 9 m d1 m b4 m d1 m 3c m 32 m d0
m eb m 44 m 55 m 45 m 21 m 84 m 40 m f7 m 1f m 8f m b m d6 m f3 m 25 m 30 m d2 m 58 m 5d m 39 m 18 m 41 m dc m fc m 83 m ff m
b2 m 35 m b8 m c7 m 7f m b7 m 4 m 9d m d7 m dc m ad m 30 m 80 m d1 m 9e m f6 m 2d m 6d m 8e m 7f m 51 m e9 m a3 m 2c m a7 m 92
m 5d m af m 6c m 9d m 98 m 3f m 3e m 3a m ab m fc m 5e m 6f m ad m ce m 74 m d3 m 15 m 2d m ef m af m 34 m 8 m 6b m af m
notbusy
02 wcmd 8 m 6c m 0 m \ 0x86c00 
4d m 80 m 5 m b m 44 m 21 m a5 m c8 m 29 m 31 m 24 m 4 m 4c m 9 m d0 m 27 m d9 m 8d m de m 6a m 97 m 30 m 4 m 0 m d0 m 49 m 41
m 67 m b0 m 6c m 9c m a4 m 95 m 74 m 3e m 32 m c4 m 11 m 1c m 7a m a9 m 54 m 28 m f m 21 m 2b m a4 m 94 m 12 m e5 m c3 m 8d m
da m 40 m f2 m 91 m 26 m 33 m e7 m f4 m 14 m d m a2 m 30 m de m e4 m f5 m 5 m 29 m 7a m 9c m 12 m 2a m 8e m 2e m 38 m 62 m 70
m cd m 7d m de m ad m a7 m ce m 9 m 9e m 13 m 23 m 66 m 3a m 16 m 91 m e1 m 82 m dd m a4 m 27 m 6e m e5 m 12 m 68 m ad m 3c m
0 m b0 m d0 m 37 m da m 3 m 0 m c1 m aa m 79 m 56 m 9 m a2 m d3 m 97 m b4 m ee m 3f m e1 m eb m b3 m d2 m 1a m e7 m 3a m ac m
1 m a3 m 3d m ea m db m 34 m 83 m 4a m f2 m 79 m a2 m c9 m e5 m 7c m 40 m 1e m 78 m cf m 47 m 89 m 99 m f9 m 83 m 23 m 1c m 5d
m 5b m 4f m bf m ee m fb m 7c m fa m 52 m 8c m 1c m 57 m f2 m 90 m 94 m 0 m 21 m cd m 59 m 51 m a6 m d8 m 10 m d1 m ab m a3 m
4d m 3b m 48 m 1a m 67 m 28 m f5 m 7c m b4 m f0 m 3 m 8f m f6 m 12 m c0 m 83 m 5e m 13 m 4a m 63 m ce m b1 m 90 m 1c m 68 m 40
m ad m ae m 35 m 7c m d3 m 3a m af m b3 m a0 m 28 m 84 m 10 m 68 m 7c m e4 m 62 m 76 m 13 m b3 m 3e m 4a m 0 m 14 m 29 m fc m
d7 m 11 m c3 m 8b m ae m 3d m 2b m 8f m 89 m 14 m 38 m 51 m 82 m 84 m a8 m ef m 1 m e8 m 67 m c3 m b0 m 30 m a4 m a2 m 13 m
notbusy
02 wcmd 8 m 6d m 0 m \ 0x86d00 
b m 29 m b4 m 6a m 23 m 63 m ad m 8d m 2c m 3d m 88 m f2 m e9 m 5 m 83 m 34 m eb m 97 m b6 m 86 m f6 m 25 m 5f m 92 m a8 m b3
m 3b m bd m b7 m a4 m aa m 2c m 33 m b3 m 65 m 5 m 6b m 41 m 8a m f7 m 66 m fa m 76 m e8 m 69 m 8b m 6c m d5 m 43 m 59 m 21 m
69 m a4 m 7 m 40 m ed m 1a m d6 m aa m b5 m 8d m a m 1c m 1a m 58 m 8b m a5 m 4e m bd m db m b m b5 m b4 m 5d m 67 m 94 m ba m
f8 m 18 m 27 m ce m f5 m 95 m 9 m 8 m 16 m a8 m a3 m dd m 6e m 3e m 5e m 97 m a3 m 1e m c9 m 4a m 24 m 8e 2 r 95 m 39 m 46 m
18 m 30 m a m 3 m b m d0 m 39 m 9b m 76 m d9 m a8 m d2 m 61 m 28 m 41 m 15 m 4 m cf m 4 m 1e m 46 m e1 m 26 m 43 m 72 m ce m
64 m 5 m 52 m 8e m be m 45 m e2 m f8 m f1 m 87 m d m af m fa m d5 m 7f m a8 m f0 m 1c m 12 m a5 m 44 m 89 m b2 m 5 m 28 m 5e m
92 m 44 m 11 m 41 m c8 m 30 m 99 m ee m 42 m 5e m 7a m 74 m e8 m 6f m 34 m 47 m c6 m af m 8c m 15 m a6 m 29 m 9c m ec m 98 m
f9 m b8 m 56 m a0 m 42 m 76 m 2b m d8 m 49 m d0 m 51 m cf m 4c m 34 m a9 m bb m 54 m 30 m b9 m 72 m ea m 46 m eb m 46 m 1b m
eb m 1b m 2c m bd m 45 m bc m 8f m 31 m 75 2 r cb m ff m e7 m 62 m d m 56 m ac m 73 m fc m e4 m 23 m 3f m cd m ec m 82 m 76 m
92 m c2 m e3 m 15 m 52 m cb m a2 m a8 m 7e m 4a m 25 m 38 m 9b m c4 m 41 m e2 m 94 m 18 m 72 m e m 3b m 0 m 32 m 26 m 0 m
notbusy
02 wcmd 8 m 6e m 0 m \ 0x86e00 
5e m ec m 1e m ed m 62 m 33 m 1c m 69 m 8c m 41 m 6b m cb m 45 m e6 m 77 m 1e m 3b m bc m fa m a8 m cf m 64 m de m ed m 62 m 8
m 81 m 93 m 29 m 24 m e2 m 72 m a4 m 83 m 7b m 67 m b5 m 4a m a4 m 42 m ad m 1d m 5d m a3 m 67 m ab m 8d m 97 m 6d m de m 21 m
e3 m cb m 9c m 10 m 1 m 23 m 45 m a m e3 m 0 m fc m 8f m 2a m 86 m ba m 98 m f5 m 62 m 48 m 9 m 92 m 19 m 98 m a2 m 15 m 7 m
fe m 4d m c5 m 8c m a1 m 9c m a2 m da m 35 m ac m 4b m 17 m 26 m cf m 1f m a8 m b9 m 1b m 7a m d8 m 81 m 57 m 9 m 8f m 6b m 1c
m 24 m c m 6f m fe m ef m cc m c7 m 76 m f6 m a8 m cf m 23 m 70 m 66 m 39 m ce m e5 m e9 m a m 46 m a6 m 8b m f6 m a2 m ef m
b2 m a2 m 58 m 6c m c0 m 61 m d3 m 53 m 49 m 3c m 96 m 8a m 2d m a8 m ee m 1 m 73 m 8c m 9f m bc m e3 m f0 m de m 7b m 9d m c3
m fa m 4b m 41 m 92 m 2d m 6b m cd m d m 23 m 62 m fd m 5d m 9 m cc m 26 m c1 m 2d m 58 m 9c m 39 m 65 m 3 m 3c m 1 m aa m 3f
m b8 m c3 m c5 m a1 m 25 m 5a m a7 m ec m 8f m e0 m 94 m 63 m 7e m c7 m 8f m 1e m 3b m bc m fa m 77 m ff m 38 m 84 m 2e m c6 m
18 m 3b m 8e m 9d m 56 m a7 m 7 m 48 m 4c m 22 m bc m dc m cc m 8c m d6 m 3d m 34 m d6 m a4 m 25 m ce m 43 m 18 m 9e m 12 m 0
m f0 m 75 m d1 m f7 m 66 m d7 m 11 m c7 m f8 m 81 m d1 m 91 m 5 m 77 m f9 m b0 m d1 m 91 m 39 m 24 m e4 m f1 m 14 m d9 m 37 m
notbusy
02 wcmd 8 m 6f m 0 m \ 0x86f00 
87 m c m f1 m 30 m 24 m 37 m cd m 4a m 90 m de m b7 m 39 m 30 m 25 m d0 m 80 m 1a m a3 m 0 m 44 m c m a4 m bb m 7e m f2 m da m
cd m 74 m 32 m f9 m ed m f1 m ea m 13 m c0 m 3b m ff m ab m cf m 99 m 38 m 9a m 49 m c0 m de m 3d m 91 m 7 m a7 m 42 m 62 m 69
m 5e m 14 m 99 m 39 m 6a m ce m d1 m e6 m fb m 6 m e3 m d4 m fc m 5f m 73 m f4 m 51 m 28 m 6a m 52 m b2 m 5b m 0 m 6c m 49 m
5f m 7d m 95 m 18 m 23 m f3 m bb m ee m 38 m 26 m 91 m 93 m 71 m 59 m 8c m a2 m 2e m f5 m b0 m 87 m b1 m 42 m 1a m 45 m e8 m
3c m bd m 86 m a3 m 8c m a1 m 4c m 2a m 62 m c2 m 6c m d5 m e5 m 1d m bf m 7b m a3 m 8f m 34 m d0 m 50 m e4 m 48 m 64 m 66 m
ee m e3 m 68 m 7b m db m 11 m 5f m e8 m 62 m d7 m 77 m 91 m 63 m 97 m 94 m 81 m 21 m 1f m b7 m 7 m c5 m 39 m 91 m 86 m 2a m ca
m 65 m bb m c m 39 m 35 m 10 m 42 m 8 m 47 m 8d m a8 m f9 m 72 m 1e m 56 m f3 m 8f m 30 m 12 m 5 m 7e m fb m 8 m 47 m f m fa m
58 m e8 m 62 m e8 m 62 m e4 m 18 m ba m a2 m ba m 99 m 12 m 97 m 73 m 95 m 1d m 15 m b5 m 71 m d9 m 85 m b2 m 0 m d3 m 75 m dd
m bd m db m 23 m e3 m 9c m 22 m 44 m 20 m c6 m 24 m ea m c8 m 2f m 81 m 4e m 27 m 93 m 7 m dc m bd m 71 m f3 m 69 m ef m ca m
c7 m c9 m cf m 74 m fd m b3 m 78 m 0 m 22 m 7b m c4 m 8 m 1e m b m 4a m f4 m df m aa m 18 m 42 m 67 m d4 m 6d m b4 m ef m 8a m
notbusy
20 wcmd 8 m 70 m 0 m notbusy \ 0x87000
02 wcmd 8 m 70 m 0 m \ 0x87000 
53 m 4b m a6 m 5c m 2b m d0 m 90 m 17 m b3 m b1 m ca m 11 m 2b m 9c m 64 m 76 m 4d m bc m 70 m 4c m e2 m 7d m df m ed m 74 m
56 m 8c m 4a m 63 m 55 m 2e m a2 m 35 m 28 m d m 1c m 25 m 8b m 7b m 27 m e0 m 4 m 9 m 18 m 0 m 10 m 31 m 11 m 22 m db m 39 m
1a m 1b m 6f m c5 m ae m cb m e7 m 6c m e9 m 79 m 26 m 31 m 32 m f3 m 1b m 7e m 7b m 78 m f9 m ef m ff m 71 m e8 m 62 m 97 m
23 m 1 m 9d m d1 m 87 m 22 m 7 m 46 m 7 m 4 m 19 m 1b m 4 m 22 m 12 m 0 m d9 m 67 m f8 m dd m 11 m 35 m 6f m 88 m 76 m be m 12
m c8 m 19 m 50 m 14 m e3 m e8 m 54 m e m 80 m 5b m 7f m 3a m 76 m 31 m 76 m d1 m 8e m 7 m 96 m 97 m 60 m 6a m 4d m 81 m 5b m
7e m 9 m 41 m 49 m 98 m 4c m 26 m 5d m d7 m 4d m ba m 51 m c1 m 5a m bd m cb m 5e m 2 m 11 m 89 m c9 m c3 m 48 m f m 47 m 99 m
4c m 26 m f7 m 6d m 1d m 7f m 7a m f6 m 9b m ec m 30 m 79 m 3b m 50 m dd m 99 m 54 m 98 m d0 m 82 m 21 m a3 m 70 m ae m d7 m 9
m 1e m 46 m a2 m 46 m 37 m d9 m 77 m be m a0 m 18 m 75 m 25 m a4 m dc m 60 m 45 m 92 m 94 m 65 m 92 m b5 m 75 m 26 m 61 2 r c8
m 37 m b1 m ac m 8b m 72 m fc m e2 m cd m 87 m f7 m de m 5a m 71 m e4 m d4 m 92 m 3f m 6b m 18 m 2a m 8c m 63 m f9 m f4 m 14 m
7b m e7 m 48 m b5 m 0 m 24 m 48 m 49 m f7 m d3 m a0 m 2c m c8 m ee m c2 m 32 m eb m b6 m cd m e7 m a9 m aa m 5d m 67 m b6 m
notbusy
02 wcmd 8 m 71 m 0 m \ 0x87100 
eb m 7 m c7 m d7 m 1f m a5 m 5c m d8 m 4d m 3a m 3d m 43 m da m 96 m 35 m d1 m 9f m a8 m 6a m 3f m 92 m 25 m 28 m 8b m 8f m 2c
m a m a9 m 61 m 92 m 7c m b9 m 3e m 40 m 59 m db m 3b m 47 m 17 m 3e m dc m 4e m fb m b1 m c7 m 15 m 4a m d0 m a7 m 82 m 13 m
8e m a2 m 1c m 72 m db m a4 m 9b m 4c m 26 m dd m e4 m 57 m da m 3 m 63 m bb m 4 m b1 m 32 m 4d m 3d m 8c m a6 m 93 m e9 m e4
m c7 m 7e m ad m 71 m ef m 85 m 27 m f7 m da m 62 m 74 m c6 m bf m b2 m 72 m 9 m 1e m 34 m 9c m f5 m f2 m 2d m 3a m 18 m 5 m b
m 6f m 6c m b0 m 6f m f9 m ea m 98 m d5 m 14 m c4 m 18 m 48 m 65 m 35 m db m 6 m 5d m 5f m 41 m ee m 54 m 81 m fc m a6 m 31 m
95 m e5 m 50 m a4 m 4 m ba m 82 m ca m cc m 9a m 2a m d4 m 8f m 5b m f6 m a2 m 34 m bc m 97 m f m 29 m 2e m bf m 9d m 15 m d9
m 51 m c7 m 26 m e7 m 29 m b8 m dd m 6e m ba m e m ab m e m 12 m 57 m ba m f6 m f3 m a3 m ed m 41 m bf m fb m b4 m 2e m 2f 2 r
a9 m 3 m 7 m 0 m 80 m a8 m 81 m fa m aa m 78 m ef m c0 m b9 m 57 m fc m 4d m 26 m 19 m 84 m f m 1f m 11 m 73 m 5a m 81 m 8e m
d7 m 47 m f1 m dd m e3 m 93 m d3 m 7f m f2 m 3f m 42 m f6 m 8d m 5c m fa m 54 m 4e m c8 m 53 m 32 m 4c m e2 m d6 m 3b m 58 m b
m 15 m f9 m df m 4f m b7 m c7 m 45 m 57 m 8c m d4 m 45 m a1 m 4 m f9 m e4 m 6b m 4d m 25 m c8 m ac m 7c m 9b m df m 69 m
notbusy
02 wcmd 8 m 72 m 0 m \ 0x87200 
dc m 7b m f5 m 89 m 36 m c5 m d5 m 94 m 82 m f3 m 20 m b4 m 93 m 81 m 6 m 1f m 29 m 74 m d3 m 46 m 3e m c4 m b0 m d1 m be m ed
m cd m d5 m 37 m ca m 60 m fa m f6 m 30 m 1a m 63 m b m ea m 21 m 67 m b7 m 18 m 52 m 11 m 75 m 19 m 32 m 7b m 48 m 71 m b4 m
3 m 7 m e0 m 27 m bc m 88 m 4e m aa m c0 m 74 m 11 m 69 m 18 m 17 m d0 m f5 m 3f m f0 m 18 m 4f m 3 m 65 m 54 m 82 m 22 m 8 m
98 m 8 m 1 m 8b m bf m b5 m 79 m c3 m ae m 3 m 28 m 59 m ba m a6 m 66 m 25 m a9 m 20 m be m 7a m 5c m 54 m f0 m d7 m de m cc m
d5 m ec m 0 m 22 m 46 m 3 m 12 m 24 m f3 m 4c m 8a m 8f m 4c m 72 m 3a m 80 m 9e m 1 m 9c m bf m 69 m ec m 97 m 79 m 8b m 1e m
1d m dd m 6b m 9c m 21 m e3 m 68 m f6 m 8d m 51 m e6 m ce m cf m 9d m 26 m 64 m 18 m 8e m 10 m 23 m 46 m 59 m 79 m 93 m e1 m
cc m 64 m 18 m 37 m aa m 4c m f7 m b6 m d1 m 41 m 2d m f m a3 m d0 m 6f m 20 m e4 m 1c m f4 m 1e m 38 m 28 m ed m 34 m eb m a7
m cb m 6b m f4 m 6a m f8 m 3b m c3 m 48 m 98 m d9 m 16 m da m 2a m be m 18 m 2 m c9 m 47 2 r 46 m ce m d1 m a6 m fa m 16 m d m
ac m bf m 50 m af m f9 m 8b m 43 m 1c m 75 m bd m ad m 67 m 47 m ca m 6b m 20 m 54 m d4 m 56 m 65 m b2 m bd m 6f m 2c m ac m
ee m f9 m 9f m a2 m be m 72 m 5f m c5 m 16 m 1a m 6b m 10 m 43 m 51 m 85 m a3 m 2 m 23 m 3 m 51 m 16 m a0 m 49 m 6b m a5 m
notbusy
02 wcmd 8 m 73 m 0 m \ 0x87300 
d1 m 5e m e9 m 22 m 0 m b5 m eb m 34 m ec m af m 6f m 2f m d9 m e7 m f1 m 5b m e3 m 98 m f3 m 9d m f m 77 m 71 m d7 m ec m a8
m 7 m b3 m aa m 34 m dd m 47 m 13 m 17 m c8 m 2 m dd m 4e m 17 m e5 m 9b m ae m 33 m 3e m e8 m ea m e2 m ab m a2 m 3a m c6 m
83 m f6 m d7 m 63 m c2 m 1f m 23 m 71 m 2 m a3 m 22 m c7 m 1 m 75 m 65 m aa m 90 m 61 m c1 m 76 m d m 2f m e4 m 9b m a6 m 19 m
48 m cd m 92 m f2 m 0 m c5 m 28 m af m 2c m 2b m 53 m 46 m d3 m e9 m 74 m 32 m 9d m fe m 50 m bb m 92 m b6 m 85 m a0 m a m d2
m 93 m 3d m 8b m dc m 11 m c4 m de m 2c m 42 m fd m 2c m 96 2 r 5d m 54 m 50 m d4 m ed m 49 m df m f2 2 r 5 m 44 m 9c m d2 m
f9 m c3 m ae m 8e m ae m 96 m 3 m 25 m cd m 4a m 4e m 72 m cc m 3e m 92 m d9 m 35 m 6f m 1f m 13 m 7a m 8f m 89 m 99 m dd m a8
m b8 m 4d m 6a m d m 96 m 83 m 47 m c5 m f4 m b1 m cd m 68 m b6 m 57 m 9a m 2d m 24 m a8 m 6b m ba m 1c m f3 m b7 m 76 m e8 m
6a m d9 m ac m b8 m b7 m 71 m 86 m 9c m d2 m 20 m ee m a1 m b4 m 3f m 7f m d6 m e8 m 8e m 67 m 3e m cd m 2d m 6e m a1 m e8 m
23 m 66 m e6 m 84 m 2e m fc m 3f m cc m 6 m 2a m b6 m 7d m c6 m 52 m f7 m 27 m 63 m 5a m 5e m a8 m 20 m ea m 4b m dc m 1b m a9
m a7 m 10 m 2f m ba m 7a m 54 m 7f m ec m 26 m b7 m 39 m 87 m 53 m 62 m 4e m 90 m cd m 38 m 44 m 8c m 18 m 11 m c9 m af m 8b m
notbusy
02 wcmd 8 m 74 m 0 m \ 0x87400 
6b m ac m 8e m 4 m 9 m 12 m b2 m 9e m 4e m 5 m 45 m 93 m 5b m b7 m e m 51 m 5 m 30 m 6d m 6a m 36 m 5d m 3e m f7 m 3a m 84 m
6e m d2 m 65 m c m 4e m 27 m d3 m eb m b5 m 2b m 69 m c7 m 72 m 22 m bb m e9 m 6d m 14 m dd m e6 m 4 m 64 m 3d m b9 m 65 m d9
m c0 m ad m 64 m e7 m 20 m 23 m 16 m df m 68 m b3 m 7d m 27 m dd m 1b m 2 m 5 m 48 m c6 m b3 m 23 m 1c m dd m f9 m ec m 50 m
3c m 4e m 9 m aa m 73 m 89 m 5f m a8 m 3e m 8a m 31 m c6 m ad m f3 m 46 m db m 35 m e1 m 71 m 2f m f0 m 38 m 2e m be m 55 m 2
m 5b m b6 m f2 m d3 m a1 m b4 m 81 m 6 m 49 m 5c m 70 m c1 m 62 m c m 49 m 57 m e1 m 49 m b6 m 1d m 95 m c5 m a8 m 3d m 58 m
3f m 2 m 80 m dc m 7f m 4a m 72 m 12 m 72 m c m 39 m b1 m 3d m c4 m d1 m 66 m 3e m 0 m f8 m 9d m bf m 4d m 65 m 86 m c4 m 76 m
e3 m 48 m cc m c4 m a0 m 46 m 56 m e6 m 2 m ca m c m 6c m 7c m 30 m e9 m 32 m ff m 76 m 93 m ae m 71 m be m f2 m 25 m df m c9
m 16 m 49 m 36 m ec m c5 m ae m c3 m 9e m 62 m 1f m e2 m 49 m 63 m b6 m 39 m f6 m d9 m 19 m 46 m a0 m 9c m 82 m 88 m 14 m 99 m
c9 m 27 m 62 m d6 m 1b m 77 m 44 m a1 m 4c m 4d m a3 m 1c m 32 m 4a m 21 m 2c m cd m 3b m fd m 48 m 0 m 88 m 81 m ba m 30 m 99
m 74 m 93 m e9 m 64 m 3a m 9d m 4e m a6 m d7 m 69 m 56 m 8b m 3b m 7e m 2b m 87 m 9e m dc m 7e m b9 m cc m c7 m c4 m 24 m 53 m
notbusy
02 wcmd 8 m 75 m 0 m \ 0x87500 
3d m 9e m 55 m 9d m 6a m f9 m 5b m b2 m 30 m 6 m ce m e5 m 64 m ba m c9 m be m 9d m e8 m 11 m c3 m 4e m 61 m 94 m 12 m 8f m 38
m 41 m f5 m 51 m 17 m 99 m b9 m d3 m 20 m 86 m 74 m 9 m b2 m 86 m c4 m 91 m 39 m f6 m dd m ab m c6 m a9 m b4 m 87 m dc m e2 m
73 m a2 m 6c m 63 m 60 m a6 m 9c m 24 m 89 m 88 m 6e m 79 m 55 m be m 71 m f6 m 79 m 31 m 13 m d2 m 60 m d1 m d7 m fc m 23 m
4c m c8 2 r 68 m 9a m 68 m 5e m 7e m e0 m 2e m 37 m 97 m ef m 6d m cb m 47 m 89 m 63 m 10 m 7d m d4 m ff m f9 m d3 m 47 m b7 m
1c m 75 m cc m d9 m a6 m 2b m 95 m 47 m a3 m 1e m 6 m e5 m 17 m cb m 9d m 8f m ec m 5c m e4 m c9 m 64 m 32 m e9 m 6e m d5 m 88
m 36 m ff m 45 m 2f m 61 m 18 m 8f m 23 m a2 m 18 m 63 m 1f m be m d6 m 20 m fd m b9 m 4f m 73 m 72 m b m b1 m 47 m a2 m 48 m
b1 m 94 m 37 m 14 m 32 m 10 m ca m b6 m 1d m a1 m 62 m 3a m 9d m 4e m 27 m 93 m c9 m 74 m d2 m dc m fe m 66 m e4 m ab m 7f m
c7 m 94 m d5 m 11 m e9 m ca m d1 m 74 m 3a m 9d m 4e m e m 39 m a1 m 75 m db m 49 m 57 m ea m 51 m 20 m 32 m 18 m 8a m c3 m e4
m 58 m b9 m c9 m cb m 6e m 2d m c4 m 8d m a0 m 5 m eb m 3b m 35 m 46 m 37 m d6 m b7 m eb m da m 6d m 1a m 11 m bd m d2 m a8 m
80 m 2e m 28 m 8a m 9d m 2e m f1 m 62 m 4 m 96 m 55 m d0 m 7c m 67 m d6 m 47 m 7d m e8 m af m 1c m e5 m 1a m 3 m 3c m f4 m f9
m 7d m notbusy
02 wcmd 8 m 76 m 0 m \ 0x87600 
56 m 65 m 41 m dc m 6d m 4a m 9 m 12 m 22 m 69 m 22 m 91 m 8f m 57 m d9 m 4a m 38 2 r ff m ae m f2 m c5 m 4c m 21 m d9 m 7f m
f9 m 1f m 5b m c3 m b5 m ab m cd m ad m c3 m a2 m 28 m 24 m d1 m c6 m 7d m 88 m 7d m 8 m 17 m 34 m ee m 79 m d8 m 5f m 7c m 53
m d6 m f3 m 32 m 8a m 7a m 22 m e2 m 68 m 27 m 87 m 7b m 45 m 40 m a6 m 8e m 82 m 58 m 75 m d3 m c9 m b4 m 9b m 5c m ff m 11 m
e3 m a7 m 5e m 7e m 51 m d4 m 98 m a6 m d7 m 47 m d4 m 13 m 85 m 3e m 34 m f0 m c m bf m f9 m 6 m b m 31 m e8 m 16 m b7 m 8c m
e7 m c4 m 9a m b1 m 2c m 56 m 9d m 43 m b3 m e2 m 60 m 3a m 9d m 4e m 9a m a7 m 3f m e6 m a6 m ce m 6d m 66 m 44 m 14 m b3 m
ce m dd m 3d m 69 m 16 m a4 m 7f m d9 m a5 m c2 m c6 m b2 m 72 m 81 m 8 m 88 m 94 m 8 m a0 m b2 m 7a m 7d m b3 m 99 m 4e m ee
m 8f m d0 m 80 m 16 m aa m 13 m 18 m 6d m b4 m 6f m bd m 46 m 6d m 5a m 30 m 85 m c4 m 89 m 79 m 64 m 5a m ff m d8 m 47 m 42 m
e8 m 62 m a7 m fb m e6 m 0 m 21 m 87 m c8 m 34 m 24 m e0 m c m bb m fe m e5 m 27 m 8d m e9 m 7d m e6 m b3 m 39 m 74 m cc m a1
m ab m 2b m da m 24 m 48 m 79 m 35 m 5d m f3 m 24 m 15 m 46 m 59 m 49 m 9a m 23 m 65 m 6f m 90 m 14 m 49 m aa m 7b m c8 m e2 m
f5 m f2 m 1f m 7b m ec m 1f m 41 m 76 m 90 m a m 90 m 42 m 1f m c2 m f3 m 1a m 8e m cc m 1f m 3e m f7 m 7b m c9 m 2 m c2 m 44
m notbusy
02 wcmd 8 m 77 m 0 m \ 0x87700 
14 m fb m 10 m c9 m 3c m 3b m f5 m 8f m 8a m 5b m 62 m 8c m 20 m 76 m dd m 21 m d m 50 m c0 m 9 m 79 m dd m 40 m 96 m e m 65 m
55 m 17 m b1 m a7 m 3e m f4 m 14 m 2e m 18 m 7b m 48 m 70 m 87 m b m 4f m d5 m 88 m a1 m e2 m 39 m 78 m 93 m 26 m 15 m 24 m 54
m ec m a8 m 38 m ba m fb m 31 m 8b m 46 m a6 m dc m 9b m 99 m 52 m 83 m 75 m 72 m f3 m b m 5b m f7 m bc m e6 m 5b m c5 m 75 m
4 m d m 98 m 13 m 0 m 23 m 16 m 11 m d3 m e2 m e5 m 41 m f4 m c9 m 64 m 0 m 12 m 6 m ea m 6c m d1 m 6a m a3 m 7d m 4b m d0 m
cb m 66 m 2f m 6f m 92 m 6 m 96 m ed m 8 m 1f m 1c m ee m b9 m 7c m c0 m 19 m a1 m 2b m bb m 4f m 1 m 10 m 30 m e6 m be m 24 m
1d m 31 m 25 m 9 m 7c m f7 m e1 m 7b m 5f m bb m e9 m 98 m e2 m 7 m 9d m 12 m 38 m 74 m 25 m ff m d m 1 m 23 m 20 m a3 m 7a m
da m 59 m be m 1b m 8c m 8a m 46 m 52 m b7 m 28 m 95 m dd m 9b m 0 m a0 m b0 m b1 m dd m 1b m 43 m b m 71 m 93 m cd m ed m 9b
m 28 m 86 m 1d m 47 m a2 m fc m fe m 7d m f8 m ca m e7 m 1a m bb m 73 m 9e m fd m 2c m 0 m c7 m a2 m 3d m 45 m 52 m ed m 5c m
2b m 2 m 5b m bc m cc m e m 7a m f6 m 4d m 26 m cf m 6d m 10 m 72 m e6 m 37 m 65 m 9 m 2e m db m 75 m c9 m e9 m a3 m 9e m 42 m
1f m fe m e4 m 5 m e3 m 7b m 7e m ee m e2 m b3 m 3d m 19 m 14 m 63 m b1 m 2f m b m 19 m 38 m 44 m 73 m 16 m eb m 93 m notbusy
02 wcmd 8 m 78 m 0 m \ 0x87800 
5b m 36 m b6 m ef m f9 m a6 m 51 m 6f m 4a m e0 m d4 m 91 m 98 m 56 m c7 m b5 m ee m f8 m a7 m af m b8 m f9 m 13 m 74 m 67 m
ae m ca m 21 m e1 m a2 m 10 m ea m b9 m 75 m 28 m b2 m 65 m 90 m 4c m 0 m 11 m 8a m 32 m df m 74 m df m c9 m 64 m b8 m 1 m 9 m
54 m 1f m 31 m 33 m f3 m 69 m a3 m bd m cb m 87 m 7d m 97 m 83 m 1a m 75 m 39 m 89 m 40 m f7 m 29 m a0 m 2 m 49 m 3c m 84 m 3e
m fc m 65 m 3 m fb m 77 m f8 m da m 69 m 5a m d5 m 55 m ba m 8c m 88 m 2c m 1e m 6e m 65 m d7 m 0 m 1a m 92 m c0 m c8 m ca m
99 m dd m 8c m 39 m 45 m 43 m 45 m b8 m ec m 89 m 56 m 71 m 62 m 6a m 6e m c3 m ad m da m 57 m 8e m 29 m 25 m ce m 9b m e7 m
38 m c6 m d8 m 53 m 8 m 7d m 78 m 71 m 23 m e8 m c m 7f m fa m ec m 2b m 8b m 1b m 4c m a1 m 4 m 5a m bd m 3e m 92 m 45 m 1b m
2b m e8 m ae m 1 m bb m e6 m 36 m e8 m 57 m e6 m 25 m 6b m cd m f1 m 4f m 0 m d9 m b9 m cf m 86 m 1d m 85 m 4b m c6 m d9 m aa
m 0 m ff m e7 m ef m 3f m a3 m 38 m c2 m 4c m 46 m 39 m 8e m 44 m 56 m e4 m c0 m 2f m 64 m 76 m 5d m 97 m 75 m e2 m 74 m 3a m
bd m c5 m 43 m 17 m e m 8c m ae m ef m 13 m 31 m 61 m 82 m e2 m 1d m 4d m a7 m d3 m e9 m f4 m 71 m ad m 38 m df m 7b m fd m 56
m 1b m 44 2 r a m 0 m 80 m c8 m 48 m b5 m b9 m 6e m ad m 58 m ef m 49 m 83 m cc m 2e m 9d m d m 73 m ce m 80 m 5f m fa m dd m
notbusy
02 wcmd 8 m 79 m 0 m \ 0x87900 
6c m df m e6 m 67 m 40 m 61 m 5a m cb m 28 m 1d m bb m a8 m 4f m 3e m be m ac m 9b m a m 37 m 44 m b1 m f1 m 34 m f2 m 9d m 38
m 86 m d8 m 87 m d8 m 5f m f9 m ce m f1 m 5a m 3a m fc 2 r c5 m e7 m a m f6 m 31 m 7 m a5 m 50 m 1c m 84 m 32 m 6 m 25 m 86 m
54 m ec m 3a m 89 m 88 m 25 m 64 2 r c8 m a m 57 m ca m 45 m 65 m a1 m 50 m 1c m a8 m 3d m 2 m 11 m b4 m eb m 5 m 89 m 42 m ea
m 43 m ec m 3 m 85 m 6b m 5e m 73 m 6c m e3 m be m e7 m 3e m f7 m 32 m d1 m 37 m 21 m 84 m 3e m c m d7 m ce m 6b m 7b m 4a m
34 m 41 m 56 m 49 m 87 m 3c m af m 45 m c7 m 2b m 4b m 8e m bf m 2c m 1f m e6 m 7d m c1 m 88 m 3d m c5 m d8 m 53 m a0 m 7f m
6c m e0 m 8 m 1e m fe m c6 m 4f m 68 m 65 m 46 m 21 m a3 m ce m 83 m 69 m af m 64 m 4e m 27 m d3 m c9 m d1 m 8d m 88 m 61 m d5
m 34 m 54 m 87 m 4 m 9 m 20 m ab m a3 m 4e m 2c m ab m 87 m 8e m 32 m c6 m 0 m e0 m 8c m b3 m b2 m 3d m 53 m e2 m 83 m 0 m 80
m d1 m 45 m e2 m 9b m 4e m 6f m 9e m 7f m 17 m c4 m b5 m 31 m 44 m 4 m d2 m ac m ba m e2 m 1c m 6d m a6 m 6f m 35 m 94 m a m
2e m 6c m 79 m 54 m d7 m e5 m 47 m b1 m 2 m ba m e1 m 37 m 3b m cb m 6a m 41 m a4 m 1e m 89 m 22 m 6b m ad m 1e m 74 m 40 m 22
m a m 2d m 1c m c1 m c3 m 5e m 73 m ae m a8 m 2f m c0 m 1e m 7b m 8a m 91 m 98 m dc m 62 m ac m 2e m 5c m 14 m 1c m a9 m
notbusy
02 wcmd 8 m 7a m 0 m \ 0x87a00 
59 m c7 m 89 m 99 m 22 m 3 m 40 m de m fa m 8a m 1a m c0 m b3 m fc m c1 m 3d m 4 m 11 m c m f3 m 54 m 31 m a5 m 94 m 18 m 99 m
39 m 86 m 28 m 8a m 80 m 4e m 3f m b6 m 75 m e3 m b3 m 4f m ba m 58 m d7 m f5 m 42 m e6 m 5f m db m 64 m 6f m fa m 88 m 4a m
6e m 9d m d6 m 14 m e8 m ae m d3 m 5c m f8 m b8 m e6 m e3 m 6 m 23 m 29 m c4 m 4 m 8a m 23 m ea m 65 m 5 m ea m a5 m 8f m 6f m
dc m f8 m 9b m d7 m 3a m bd m a8 m bd m ac m 8f m 62 m de m d1 m a5 m fa m 48 m a3 m c m 64 m 5a m 71 m 3a m 99 m 4c m ef m f8
m a0 m a5 m 86 m 27 m bb m 47 m 90 2 r 28 m 84 m 49 m 27 m 11 m f3 m 5f m 1a m 6d m 95 m 6 m 80 m f3 m 3f m 84 m 5 m 7a m c6 m
ca m 4c m a3 m 2c m e6 m 31 m 2f m 67 m a1 m ec m 19 m 59 m 75 m 82 m 4b m 65 m 12 m 20 m 6d m a4 m ef m cc m 99 m c9 m ca m
37 m 64 m 20 m 1 m 68 m d0 m 8d m 63 m 8c m fc m a6 m a7 m d m bb m 7d m ec m f1 m a m bb m d2 m 77 m cc m db m a4 m 41 m d m
3b m e6 m 48 m 31 m c6 m 9e m 4e m 18 m dd m e m 0 m c7 m be m e1 m 2c m b1 m d9 m c4 m 2e m 8f m 31 m 14 m 71 m 2c m 25 m 31
m 80 m c0 m 90 m 94 m a9 m 96 m 24 m 50 m e4 m 28 m 8b m 49 m c3 m 52 m 2 m 35 m 86 m 5a m 98 m da m 65 m 9c m f9 m 3a m 27 m
a8 m b1 m 12 m e6 m 48 m 59 m 23 m f5 m 44 2 r 4f m 69 m 16 m d2 m f8 m a3 m 37 m 7d m 5c m 12 m a0 m fb m 60 m c5 m 93 m
notbusy
02 wcmd 8 m 7b m 0 m \ 0x87b00 
ca m 1e m 97 m 22 m 19 m 49 m f6 m 1c m 4d m ba m ae m eb m 8e m fa m bd m 26 m 19 m cf m a8 m 12 m 2b m 63 m 2e m f8 m 22 m
76 m 1d m f5 m 39 m 3d m e2 m ec m f3 m 6f m d1 m b8 m f3 m 97 m 6f m fd m 1a m c1 m 6b m 1f m 82 m e2 m 68 m a0 m 8f m 24 m
68 m d8 m 95 m c5 m e0 m 7 m dd m 71 m 89 m b1 m 51 m 2f m 3 m 53 m 56 m 47 m d9 m d3 m 9f m 4c m ef m 73 m df m c6 m c5 m 97
m be m c7 m 82 m 86 m 14 m 38 m 88 m 93 m 50 m 96 m d5 m 5b m 6e m 3e m 54 m da m 88 m 15 m 47 m 2e m d5 m 89 m 88 m 34 m 38 m
92 m 81 m b4 m 99 m be m 5 m c2 m 79 m 6 m 39 m 87 m 3b m 11 m 4b m a2 m 1c m 33 m c7 m f8 m 85 m 71 m c7 m f m 3e m 45 m 50 m
24 m 26 m 7e m 9f m 81 m 54 m 80 m 98 2 r 63 m fe m 6f m ba m e0 m 4b m 37 m 6b m 90 m fe m 90 m 43 m 4f m 37 m d3 m 3b m cb m
c1 m 6a m 8b m b9 m 37 m eb m c4 m e9 m 2 m d m c5 m 47 m 8e m 28 m 66 m 1e m e5 m 64 m a0 m d6 m 6b m 2e m c2 m 4b m 5a m f4
m cb m d5 m 5a m b1 m eb m 12 m 5a m e8 m 1b m 19 m 23 m 65 m f m 9f m 28 m d0 m a5 m af m f8 m fd m d6 m ad m bf m f1 m e3 m
27 m 8b m d9 m 16 m 63 m 57 m 95 m 46 m 3 m 0 m f3 m ef m 4b m 31 m ea m ae m eb m c2 m 83 m ef m d2 m 7a m 12 m fc m f5 m a5
m 25 m d5 m 3f m e6 m 3d m 5d m 79 m 9d m 20 m a2 m 79 m 48 m 44 m 2f m 78 m 45 m eb m de m a3 m 4f m 78 m ce m 95 m 19 m cf m
71 m notbusy
02 wcmd 8 m 7c m 0 m \ 0x87c00 
2e m 8e m 28 m 27 m 33 m a8 m 64 m 3f m e8 m b8 m 65 m 86 m 46 m ee m cd m 9c m 42 m 25 m 44 m 71 m e7 m 7 m b4 m ae m fe m 27
m 22 m db m b5 m ae m ac m 4c m 54 m b1 m 72 m 63 m ca m bc m 51 m 97 m 21 m 24 m 3a m a1 m c2 m 51 m 49 m aa m db m 60 m df m
96 m 89 m 43 m 8c m 8e m bd m b2 m 6d m c6 m 91 m 63 m 3c m fd m 1e m c3 m 47 m 1c m f3 m b9 m 4f m e8 m 60 m 69 m c4 m 89 m
88 m 63 m 1e m 7e m d4 m 88 m 1d m 51 m ec m 89 m e8 m a4 m 96 m a3 m d m f m b8 m fd m c9 m 19 m 47 m ce m 2e m af m b6 m 1c
m a2 m 43 m 51 m 6 m 8b m ac m f0 m 52 m 44 m c6 m 98 m df m 80 m 72 m 81 m 9b m 6c m 52 m 95 m 2a m 21 m cb m c0 m 64 m 77 m
90 m 54 m d5 m 67 m c8 m 11 m 43 m c6 m c4 m c8 m 51 m 60 m 44 m 84 m f8 m 89 m 71 m ed m 24 m 0 m 80 m 9b m 9f m f0 m 82 m 8b
m 89 m 22 m e5 m 45 m db m bc m 7f m 84 m 2b m 6 m 46 m 49 m 70 m 93 m d4 m b6 m c3 m c6 m 59 m 46 m 0 2 r f0 m b1 m 4f m e6 m
ed m 9b m 39 m 95 m 21 m bb m 38 m 0 m 98 m 8 m 30 m 8a m dd m 4d m 48 m b4 m f5 m 27 m 4d m d7 m a m 8e m 7f m dd m d9 m 14 m
7a m a m 7d m 88 m 56 m 6 m 90 m 35 m ec m e4 m 57 m 8f m 42 m d7 m 85 m 49 m d7 m 1d m 39 m de m f8 m d4 m 6c m 9a m a m a1 m
51 m 86 m ac m cb m 8e m 6e m c6 m 27 m 5e m 97 m 2b m e9 m 11 2 r 85 m c4 m d9 m d2 m 21 m e m d5 m 5a m 40 m 6b m c2 m
notbusy
02 wcmd 8 m 7d m 0 m \ 0x87d00 
92 m 57 m 9 m 52 m a9 m 4a m cc m 52 m a7 m 8f m 54 m 23 m dd m 66 m 63 m 7d m 73 m e2 m 14 m 99 2 r 23 m 33 m 62 m 1e m 3e m
dd m 1 m a0 m 79 m 62 m ff m 38 m c2 m 11 m fc m ca m 15 m 9f m 5 m 27 m 33 m 91 m 7a m a2 m 88 m ea m 23 m 99 m 61 m d7 m 23
m 11 m e2 m f1 m cf m 69 m 51 m 7f m c4 m 9f m 1f m 77 m 25 m 11 m 85 m 5e m f9 m c8 m 70 m 94 m ca m e2 m 43 m 65 m d6 m 65 m
d m 49 m 91 m 30 m 2 m 24 m 8 m 90 m 52 m ca m da m 13 m 4a m ca m 3 m 38 m 84 m 6c m 63 m d7 m ed m 6 m 92 m 7c m bd m 20 m
a3 m 12 m 11 m 23 m 45 m ec m 75 m fb m 10 m 9d m 7c m 72 m fb m ee m a7 m 7e m ee m ef m 28 m 86 m d8 m 73 m 2b m ce m 60 m
61 m 6f m 8d m 34 m 3c m a8 m ad m 8c m 0 m fe m 56 m f7 m 40 m 47 m 1b m c9 m 6c m 2d m 40 m 4 m b3 m 17 m 8 m e9 m 1b m 6f m
6e m e7 m f1 m fc m 76 m 7c m de m 95 m 24 m d1 m 8e m 86 m 79 m 59 m ea m 27 m 86 m ae m eb m e m fa m c3 m d1 m 99 m bb m 8d
m e6 m 62 m 50 m 90 m 10 m 89 m 74 m ef m df m 8f m 3c m ba m 75 m f9 m 9b m 29 m 21 m 11 m 5 m e6 m 20 m 81 m 5f m 22 m 59 m
12 m ae m a2 m 65 m 4d m b5 m e0 m 58 m 59 m 53 m 33 m d5 m 32 m 92 m 5c m 24 m 51 m 48 m 3f m f2 m a8 m d m f6 m cd m 1c m 38
m 72 m a4 m c8 m 1c m 13 m 32 m 48 m 25 m 28 m 49 m 37 m e5 m 18 m e3 m 55 m d m cb m ec m b7 m de m f2 m 29 m b0 m a0 m 28 m
notbusy
02 wcmd 8 m 7e m 0 m \ 0x87e00 
62 m 54 m d3 m 4e m 54 m 5a m 62 m e4 m 88 m 52 m 18 m fe m 6b m 6f m 69 m 9d m 89 m 1 m 70 m dc m 5b m 3f m 2c m 5e m 76 m cf
m 25 m e0 m 2a m fe m 51 m 65 m d5 m d9 m e2 m cc m b5 m 2e m 9b m 11 m 45 m d m de m 31 m 22 m 25 m b4 m b5 m 5b m 7b m 39 m
99 m c9 m a6 m 55 m 9b m ec m 57 m b0 m 1b m 48 m 1a m c4 m eb m a0 m 0 m 29 m 7b m 26 m 92 m 4 m dc m 76 m 91 m 0 m 6e m 75 m
c2 m 9b m 3f m 1e m 63 m d1 m 3 m 8d m 40 m 99 m b2 m f0 m d1 m e3 m fd m 46 m d2 m 9e m 54 m 4a m 72 m 94 m 4d m 33 m 19 m 47
m 79 m 4f m 86 m 98 m 66 m 84 m ff m 7e m 8f m 51 m e1 m 48 m 0 2 r 8 m c7 m fd m d7 m bb m a3 m 5a m 5 m ce m ae m 73 m fa m
48 m b3 m be m ef m dd m da m 43 m 3a m af m 21 m 22 m 1 m 0 m 64 m 77 m 7f m 32 m 99 m 74 m 37 m 7a m 4a m eb m ba m 7f m 26
m e2 m 4c m 62 m c8 m 5 m 1 m 10 m 89 m 8a m c3 m dc m 9e m 49 m 0 m 70 m eb m 46 m ce m b0 m 8a m 89 m 59 m b7 m 47 m 7 m 3 m
f0 m 64 m b2 m b9 m be m a5 m eb m 48 m 4c m 91 m 62 m 4 m 6 m e4 m cc m 93 m c5 m 3d m 8a m 31 m fe m 75 m 23 m 2b m e1 m c1
m c7 m bc m 49 m 85 m 15 m 22 m f5 m 99 m e1 m 63 m de m 47 m 3 m 0 m 89 m 11 m 39 m ca m 2f m de m 77 m 9f m 56 m 49 m 19 m
80 m 7 m 3e m f0 m f8 m 2b m 28 m 86 m d8 m 7 m 76 m fe m 51 m e m 3 m aa m f3 m 65 m 6b m 52 m 70 m f8 m ef m dc m notbusy
02 wcmd 8 m 7f m 0 m \ 0x87f00 
d m 0 m e0 m ac m 93 m be m 2 m 0 m 90 m 12 m 25 m 29 m 4 m 8a m be m ec m 9b m ad m 1f m cd m 73 m 83 m 44 m 55 m b7 m 3 m 30
m 2b m b7 m 2a m 5e m e7 m 42 m 76 m 59 m 8c m 88 m 42 m 46 m bc m e4 m b8 m e3 m e6 m 3c m e0 m d7 m 7f m fd m 94 m 33 m 22 m
f m ec m 29 m 28 m 32 m 4a m 80 m 74 m cc m ff m 99 m 4b m c2 m 73 m bf m 27 m c5 m a m a3 m 53 m 47 m 1a m ad m 1 m 14 m 3a m
72 m fb m d3 m 39 m 8a m 11 m 7e m f2 m 27 m ff m e3 m 3d m 8a m e6 m 61 m f8 m dd m c1 m f9 m 5e m 3f m bf m e4 m b8 m 98 m
42 m 40 m 24 m 80 m 1c m 7d m e m 5d m 77 m dd m 46 m 76 m 7 m c0 m 3b m 95 m 93 m 29 m 24 m e5 m e4 m 1c m bf m d5 m cc m dd
m 2c m a1 m 9a m 1d m 15 m ab m 8e m c5 m ae m 22 m dd m 2a m 8f m 40 m 82 m a3 m ae m eb m 26 m 87 m 37 m ad m e2 m 5d m e9 m
3b m 67 m 94 m c6 m 10 m 23 m 22 m 3 m 62 m 44 m 16 m 0 m 62 2 r ca m 11 m b7 m d8 m d3 m b7 m 3e m 73 m 9b m f1 m 43 m 6e m
73 m fc m 5f m 7f m bd m 24 m 3 m 63 m 8e m 78 m 44 m 39 m 68 m 3e m 41 m 62 m 8c m a6 m 52 m 9e m d3 m 74 m 91 m 0 m e0 m 39
m e7 m be m 76 m 16 m 63 m 10 m 46 m 4a m 2d m bb m 4e m 42 m e9 m 7 m 3f m ee m 76 m f9 m 96 m db m bf m fe m e4 m 37 m 0 m
24 m 26 m 62 m 29 m f1 m de m c2 m 8a m 45 m 42 m c7 m bf m 52 m 65 m 3d m 57 m 5b m af m d2 m ea m f3 m 67 m 2d m 64 m c7 m
notbusy
20 wcmd 8 m 80 m 0 m notbusy \ 0x88000
02 wcmd 8 m 80 m 0 m \ 0x88000 
18 m 91 m 23 m 2a m fb m 22 m 7e m f5 m a4 m 3f m 9a m f7 m 88 m 5f m fb m b5 m f7 m fd m 7b m ef m f8 m d7 m c5 m eb m 74 m
a7 m cb m 7d m 7e m 6e m 3e m 5 m 7f m f1 m e5 m 5c m ad m 50 m ab m 7e m b2 m ae m e5 m 21 m 30 m 0 m 46 m 40 m c2 m de m 52
m eb m ff m e0 m e5 m f3 m 9e m f3 m 53 m 3f m f5 m 91 m b7 m 6f m 71 m e4 m 14 m 87 m f9 m c m a m e7 m c9 m cf m de m 73 m
e9 m 71 m 11 m 6b m 48 m 67 m 30 m 7 m fb m c2 m b5 m 9e m df m ba m f6 m bd m 9 m 29 2 r 27 m 1b m 2f m 87 m c2 m e m 69 m de
m 2c m 89 m ab m ef m 61 m 14 m 58 m 72 m 4 m 13 m 0 m 94 m 24 m d5 m ae m db m 74 m df m 91 m 63 m 24 m 44 m 8a m 72 m c2 m
b6 m 94 m ae m b1 m 6c m 53 m a m b1 m 7f m 69 m 33 m d2 m f3 m 98 m d9 m cb m 2e m 42 m 1 m 90 m 2d m e0 m 22 m a4 m 7c m a4
m 24 m 83 m 33 m ce m 9e m f4 m a2 m 39 m e3 m 7d m f4 m 9f m 9d m fe m f6 m be m c8 m 41 m 86 m c2 m 47 m 3e m e8 m 1d m 7e m
cb m ad m 22 m 3e m a m 5f m 9f m 38 m 24 m 96 m 3 m 47 m 10 m 35 m 23 m cf m 2c m 2b m 28 m 2b m 63 m c3 m e m dd m e6 m 9f m
34 m 5f m d2 m 2c m dd m 46 m f1 m 3a m c0 m c4 m 94 m 81 m 24 m 50 m c8 m 3 m f4 m d9 m 76 m d0 m e m 0 2 r 7e m fa m a7 m e3
m df m 7f m 8e m 53 m b m 47 m 48 m 74 m e4 m c3 m 46 m 87 m c0 m ba m f6 m ca m 73 m cb m 69 m 71 m c5 m aa m 63 m 80 m
notbusy
02 wcmd 8 m 81 m 0 m \ 0x88100 
5c m 21 m 15 m 11 m 23 m 99 m dd m 80 m 88 m 4f m 7c m f1 m dc m 47 m fd m f8 m 8f m c3 m eb m cf m e6 m b1 m 38 m cb m b1 m
ac m db m 3c m 6c m 95 m 71 m 29 m af m 41 m 9 m 50 m 76 m 3 m 4e m 9b m d6 m ed m 7 m 22 m 12 m db m 96 m bb m cc m fe m 4c m
ec m 59 m 79 m ee m 24 m 25 m e5 m 65 m 4e m b6 m 27 m 8d m 48 m 44 m 92 m c4 m 19 m 72 m 9c m 71 m da m cc m 4d m dd m a5 m
be m 33 m 8e m fa m 5c m 65 m 41 m 7f m cf m b2 m b6 m 94 m 23 m 5 m 14 m 7b m a2 m ab m df m fa m c0 m d6 m 93 m 26 m 4f m 86
m 53 m df m 73 m 95 m ca m 1c m 7d m 3c m 67 m a1 m 4c m 9c m 8d m 73 m 0 m 4 m bc m ec m e9 m cd m 64 m 16 m 0 m 80 m 7b m dc
m e3 m 2b m 7f 2 r 39 m 5b m e1 m 1a m 3f m 81 m 20 m 4f m ee m 1e m 52 m 1f m 81 m fb m c8 m 8f m 9f m 1d m b2 m 36 m 66 m 94
m da m 4e m e6 m 15 m e5 m cf m 62 m b8 m 8e m de m 5e m fb m 30 m 7 m 72 m 47 m 40 m 1a m 9c m 87 m 6e m 55 m 83 m cc m 33 m
b1 m d1 m f9 m ef m 7f m 1c m 57 m 11 m b6 m 16 m 7e m f m e0 m f4 m 53 m 2f m 55 m c7 m 16 m 54 m 13 m 1c m 7e m ef m 6d m 54
m c0 m 1b m ce m 28 m 25 m a8 m 4d m 1b m a9 m 55 m 93 m 2b m b5 m 8a m 5d m 20 m ba m 61 m c1 m 4c m 0 m c0 m 43 m 1 m 3e m
fc m 9f m 97 m d4 m f9 m de m 88 m 78 m fd m fb m b6 m ce m 20 m 5e m d4 m 2c m 52 m 81 m 0 m 98 m 97 m 9f m 28 m fc m 55 m eb
m notbusy
02 wcmd 8 m 82 m 0 m \ 0x88200 
ca m 8f m 5d m 8d m 94 m 88 m 11 m 33 m 27 2 r 0 m a4 m 68 m ab m f2 m db m b2 2 r d8 m 1d m 52 m ea m 23 m 52 m 88 m 24 m d9
m 35 m a9 m e8 m a3 m 10 m c2 m cb m 36 m d9 m 37 m a7 m c8 m 31 m 52 m 4f m 28 m eb m 9a m 29 m 65 m bf m 3d m a1 m 2c m cb m
e7 m d0 m 75 m 78 m 47 m 13 m 47 m 0 m 70 m 9f m fb m c0 m 15 m 67 m 7e m fe m 8b m 97 m 5c m 9a m ab m 59 m 3b m 1e m 65 m 5
m 16 m 22 m 20 m 5c m fc m a7 m 73 m 62 m b6 m 0 m f0 m 3f m 9e m d m ef m 3d m 75 m 56 m cc m 9a m a4 m c9 m 59 m 79 m fe m
6f m fa m 7b m d7 m 1d m de m f1 m 92 m fb m 73 m d9 m 2 m e8 m 36 m 7b m c8 m b m ba m a5 m b1 m 31 m 8e m 6c m c5 m 7b m d1
m 20 m 2d m dd m 1c m 8e m f4 m fc m 15 m 73 m 91 m a2 m a1 m 8 m 10 m 0 m 4e m bd m aa m bd m 86 m aa m ed m 1e m f7 m 0 m 88
m e7 m 7d m e1 m bb m 97 m 7f m ef m 72 m 3c m f4 m b0 m 43 m af m 77 m cb m a3 m e6 m 9f m 2b m a4 m ed m 1f m 4e m 9b m cd m
b6 2 r ec m d8 m 45 m f3 m 8e m c4 m 38 m a7 m c4 m 80 m b1 m d2 m ec m 70 m d1 m d3 m 9a m 9b m 6f m ac m dd m ed m 6e m 0 m
7c m de m e7 m bf m 7b m f9 m 65 m 97 m e1 m 61 m 87 m 5e m e7 m ba m b7 m 1a m ef m c5 m 5c m a2 m 59 m c8 m c m d0 m 4e m 65
m 6d m 6a m 4 m 98 m 17 m 84 m 5c m bb m c5 m b7 m bc m 61 m 2b m 9b m b6 m 8 m b6 m 77 m 7b m 8f m fa m be m e6 m 94 m
notbusy
02 wcmd 8 m 83 m 0 m \ 0x88300 
d7 m 3 m 0 m 87 m c m a4 m cc m 8a m 5c m 16 m 1f m 8 m 9f m f0 m 92 m b9 m f7 m 5e m fb m 1e m 39 m 2e m ce m 6f m 7e m 7d m
e6 m 50 m cc m 1a m af m 66 m ef m 2f m bd m f8 m 89 m b m fa m bf m df m fd m e0 m ac m f7 m 7f m 45 m 36 m 90 m a5 m 92 m 17
m 44 m c7 m fc m cc m f m 36 m 2e m 3f m e8 m 76 m 9f m 74 m bb m e1 m eb m 68 m 9d m 8f m a2 m a4 m 71 m 75 m e4 m b2 m ef m
dc m a4 m cd m 4e m c0 m 84 m f5 m f7 m 6e m bf m 4e m f0 m bb m 86 m 72 m d9 m c1 m 5b m 37 m 6b m 2 m ec m a0 m bd m e8 m 9c
m d9 m 6c m 6b m b6 m 35 m 9b m 6d m f5 m b3 m 99 m 1e m 3d m 20 m ee m 91 m ae m ed m d9 m 6e m 70 m 2b m 94 m 73 m d8 m 3c m
23 m 7b m ed m f6 m ee m 91 m ff m f6 m a4 m ad 3 r d9 m ac m ef m 99 m 25 m 99 m 61 m 32 m 79 m d6 m 9c m 63 m 29 m 36 m d0 m
8e m ff m 8 m 27 m ce m 38 m a2 m ae m eb m 26 m 93 m 67 m 1d m b9 m 67 m 7d m 3f m ed m c3 m 7a m de m a4 m 64 m 95 m 60 m f0
m 1b m af m ee m de m 8c m bd m f m da m e3 m cf m b1 m 27 m 24 m 8d m de m eb m 8e m fc m c9 m 91 m ad m 5d m 33 m 83 m f6 m
85 m 2f m 7c m ed m f2 m 2b m 2e m 8f m 93 m e9 m 41 m d7 m fb m 81 m 1b m 1e m 79 m e3 m b9 m d7 m bd m e7 m 79 m 72 m da m
a0 m d4 m a4 m 10 m 17 m 31 m eb m 71 m 49 m 87 m 3c m e8 m a0 m 83 m a6 m 7 m dd m 76 m 98 m 95 m f4 m ac m 2f m 5f m b3 m
notbusy
02 wcmd 8 m 84 m 0 m \ 0x88400 
75 m cd m d6 m d5 m 5b 4 r b3 m 7e m 16 m 63 m 9f m a2 m 4b m 33 m 5f m b9 m d5 m eb m b0 m 76 m 86 m 50 m 4a m 89 m 75 m b m
15 m 0 m 8 m de m ce m 7b m ce m f1 m eb m f4 m 31 m b7 m 1d m ff m 15 m 3d m ea m aa m f7 m 87 m 69 m 6b m ea m 23 m 0 m 24 m
6 m 4 m 89 m f7 m 58 m ca m d7 m f7 m 1e m 33 m 2f m ec m b3 m 66 m 7b m 2b m 8e m fe m 8b m 2d m 6b m 5c m d m 8b m df m da m
3b m 18 m c1 m 73 m fe m ea m dd m 49 m b6 m 8d m 4 m 22 m a2 m 87 m ee m 1d m 8c m e0 m 84 m 93 m de m 91 m 63 m 60 m 0 2 r 9
m 80 m 29 m 47 m 6f m 91 m 7a m 42 m c4 m f m df m 66 m 4e m fd m 59 m df m 5e m fa m a4 m 4f m 12 m eb m 1e m 24 m 14 m c5 m
6 m f2 m c0 m 2f m 3c m ab m b9 m 29 m be m 6a m 47 m 2e m f9 m c2 m b7 m 43 m 2b m 39 m e4 m 54 m 42 m d2 m 6c m 56 m 97 m d7
m 34 m bc m b3 m 4 m c6 m 60 m 6e m c6 m c7 m a m ad m 32 m bd m 92 m 19 m c7 m a5 m 16 m 64 m cc m 6b m a4 m 5b 2 r b3 m ad 3
r af m fe m e1 m 8e m 3a m 1b m b4 m a7 m 7e m 79 m 6b 2 r 2b m 9b m 75 m ad m f2 m 7d m a6 m 92 m a5 m 3e m 60 m df m cf m 84
m 90 m ab m 1e m 7d m e9 m 6e m d2 m f1 m e6 m d9 m e8 m 4c m 74 m 88 m c5 m bc m 4 m 0 m 44 m bc m ed m 36 m bb m 95 m 76 m
b7 m 3d m f6 m 56 m 64 m 45 m 2d m 89 m 8e m 19 m 6d m fd m d9 m 64 m fb m a3 m 5b m da m e1 m notbusy
02 wcmd 8 m 85 m 0 m \ 0x88500 
bf m e2 m 3e m 45 m e5 m 83 m be m 9f m cd m 5e m d3 m c8 m b3 m 1b m b5 m 17 m 1d m 9a m 9f m 90 m ec m 7e m 99 m be m d9 m
d6 3 r d7 m 9f m bc m 6b m b4 m 5e m 1f m 2b m 93 m 4a m cb m b3 m 80 m c2 m c3 m 82 m 91 m a3 m 6d m f1 m 56 m 93 m cc m 80 m
b4 m a3 m d6 m 38 m e8 m d8 m c2 m 38 m ec m 87 m 6f m b6 m b5 4 r f5 m 9d m 47 m 7d m 76 m 87 m 1d m 5a m fb m d2 m a3 m bf m
bd m b5 2 r 25 m 28 m 2a m 40 m d2 m 34 m cd m a4 m 44 m b0 m cd m a3 m 9c m 8a m b5 3 r 75 m cd m 53 m df m b1 m 5b m 64 m c0
m 77 m 5f m b7 m b5 m 35 m c6 m 11 m 7b m 47 m d m 0 m e0 m 99 m bb m d6 m e1 m 52 m ed m 44 m 39 m cb m 9a m 8 m 11 m 17 m 94
m 91 m d8 m 58 m df m d9 m 1b m 2d m 7c m d8 m 1b m 12 m 9e m 7f m d5 m 12 m cf m 78 m 5c m 9 m 59 m 70 m cc m b7 m cf m 66 m
7a m 5e m ed m a5 m 8f m dd m b1 m 5f m 2f m ed m eb m f5 m 8f m c9 m 7d m b5 m 60 m 23 m 2f m d0 m 47 m 6a m fc m e8 m d m 6b
m 13 m 52 m e3 m 28 m 39 m 75 m 68 m 1a m 49 m 15 m 41 m 66 m e1 m bf m f8 m db m b5 m fb m aa m da m 6b m 9e m 7f m cd m 96 m
9e m 5f m 3a m 73 m 21 m ef m 12 m 3b m 57 m 95 m 54 m 29 m a4 m 2d m 69 m ff m 32 m ae m 50 m b9 m 5e m 7b m ef m 5b m ae m
d9 m ba m a6 m a1 m 8f m ec m ac m c5 m 8c m a4 m 71 m 4d m ff m cd m b6 m 83 m ae m ab m 4a m 1 m f7 m notbusy
02 wcmd 8 m 86 m 0 m \ 0x88600 
bc m ef m 1b m 1e m 6e m 76 m 92 m 44 m c5 m 55 m 8e m e5 m fa m fb m 8f m b9 m 78 m fb m 67 m dc m bf m e4 m c2 m a5 m ca m
a0 m d8 m da 4 r ba m f2 m d1 m ff m b1 m 3b m a4 m 9e m 5 m 63 m e6 m d7 m 75 m d5 m ca m 9e m 69 m e8 m 23 m 57 m 51 m 3c m
2d m 95 m d1 m ba m a8 m b5 m f5 m 51 m b2 m 45 m 85 m 2c m 49 m 74 m 4 m 66 m 5b 3 r 1f m de m 95 m 60 m c3 m 1f m 9f m b6 m
25 m cf m 93 m 3 m 4c m b5 m 14 m b5 m a9 m a3 m e4 m 46 m a2 m 56 m 48 m b3 m ad 4 r 2f m 3c m 76 m 19 m b1 m b8 m 6d m 7b m
d5 m 79 m 5b m d7 m 5c m 73 m cd m 35 m a3 m ff m ef m d9 m 8d m 72 m 4a m 69 m d9 m 3c m 88 m 5d m 6b m 77 m d3 m 55 m 13 m
80 m 7d m d2 m 37 m 0 m a8 m 3e m a9 m c m fc m d9 m d6 m 6c m f6 m c7 m 67 m 6f m ff m 8c m 1b m 83 m a9 m 84 m 14 m 7 m 86 m
dd m d6 3 r 1b m db m 1 m c8 m 55 m db m 1b m 35 m be m 5e m 94 m 89 m 2e m c1 m 16 m 26 m e6 m d8 m c4 m 91 m 2e m fa m 7a m
ab m 63 m 6d m 8d m 34 m 5e m 3f m 2 m 89 m 7e m 33 m 25 m b m fd m db m 82 m 16 m a7 m c4 m df m 7e m e4 m 3 m 7e m 71 m cd m
de m b4 m bd m f7 m 94 m 3e m 8b m b7 m 59 m 2f m 21 m 6 m 5f m d1 m 5d m 82 m 26 m 7a m 2 m 4b m 5e m 10 m 57 m 42 m 8a m 9a
m 7a m c2 m 3d m 8e m dd m 21 m 19 m f0 m d9 m 7f m d5 m 92 m 1e m c3 m 96 m 4f m f7 m ce m notbusy
02 wcmd 8 m 87 m 0 m \ 0x88700 
f6 m 40 m 4a m 29 m 1d m b1 m d3 m ae m 56 m 6d m 37 m 2e m 51 m dc m d6 m b6 m ab m d m f7 m 9d m 97 m 34 m 55 m 4c m 33 m e4
m 1c m 7 m 59 m a8 m 49 m e9 m 85 m bf m b6 m 20 m 41 m 25 m b7 m 9b m 7e m 5 m d4 m d5 m 2e m 87 m a6 m 96 m fc m 2 m 3e m f7
m f1 m 7f m 39 m d9 m 31 m a1 m 17 m 7e m 33 m d9 m 83 m c1 m 99 m 75 m 65 m 15 m 2c m 2b m 43 m 8a m b3 m e1 m ad m 33 m af m
90 m 2a m 20 m ae m d5 m 6 m 38 m 92 m 98 m 5d m 5e m 8d m 65 m e2 m 2a m b m dd m 0 m fe m 2f m ef m 7b m 56 m 3b m e1 m 70 m
b9 m 76 m c9 m f1 m 97 m f5 m 7d m 2f m 10 m 9a m e9 m 6e m f2 m 9c m c7 m 60 m a5 m 15 m 0 m a4 m e4 m 3e m 53 m 6d m db m ea
m fe m 13 m 4e m a7 m 7d m ec m 89 m 3b m 8b m a1 m bd m f0 m 4a m 85 m d1 m 6c m 38 m a7 m d5 m 3e m 28 m 74 m 12 m 65 m af m
da m c m 0 m 12 m 9a m 5d m b9 m f7 m 7d m 1b m 27 m 2 m a2 m 2d m a5 m 69 m 7b m f3 m c7 m b7 m f3 m 17 m c9 m bc m fc m 94 m
12 m 42 m 62 m a m 2e m 4b m 27 m 71 m e2 m c7 m ec m 5c m e m 3e m c9 m b6 m a0 m 2b m 14 m 44 m f6 m a2 m 8f m 31 m 4 m 8e m
f1 m 3b m c3 m 5b m bf m 63 m a m c9 m dc m 88 m c5 m eb m d6 m 8b m db m 10 m 47 m 4a m 5 m 42 m 4a m e0 m 18 m b8 m bc m 3e
m 33 m 73 m 7c m c6 m d1 m eb m c7 m 5c m 5e m 78 m ae m 1c m b5 m a1 m f1 m 5 m dd m 4b m 6e m 4e m 9f m 93 m 2b m 69 m
notbusy
02 wcmd 8 m 88 m 0 m \ 0x88800 
0 m 24 m 23 2 r 31 m c7 m 78 m d2 m 8f m 34 m f3 m 46 m 97 m 6b m ff m 78 m 2e m 80 m 26 m 14 m 7f m 63 m 98 m 47 m 9e m d3 m
2b m 98 m 13 m 0 m 31 m 22 m 5e m 30 m aa m d4 m bf m e1 m f6 m 65 m d1 m cb m 8c m f8 m a5 m eb m ef m 71 m df m 5f m d1 m 6c
m 7 m 61 m 52 m cd m 14 m 70 m db m 51 m 3f m fb m a8 m e7 m b6 m 16 m 46 m 4b m fb m 46 m 51 m 3d m 29 m 1f m 1 m e1 m 1b m
33 2 r 9f m f6 m b1 m c7 m af m b5 m 46 m 6e m ed m d8 m 6f m cb m 76 m 2d m 15 m 37 m 12 m 70 m 46 m 95 m 40 m e2 m 9c m f4 m
d8 m 7f m 73 m 78 m ef m e5 m 32 m c1 m 65 m b7 m e3 m 8e m da m 8 m 47 m 79 m 87 m b9 m 98 m 55 m ba m 86 m 50 m 62 m f m 5a
m 45 m ff m 9c m 47 m dd m fd m d8 m b5 m 3a m 7c m dd m 69 m 7d m 14 m 2d m 94 m 41 m a4 m 5b m 60 m 15 m 46 m 45 m c5 m a2 m
a8 m a4 m 54 m e m ac m 54 m d7 m 49 m ce m cb m e1 m b m 1e m 75 m c7 m f9 m 69 m 7f m b m db m 69 m 6f m 17 m 21 m b m 88 m
80 m e7 m 36 m 70 m 24 m 65 m f4 m 20 m 11 m 20 m be m eb m 6e m eb m 75 m b3 m 76 m fb m 48 m de m 91 m c7 m c4 m f8 m ae m
ff m b9 m e7 m 7d m 1b m 84 m 52 m 4a m a9 m 3e m f0 m 25 m 89 m 41 m f0 m b4 m a3 m 17 m 86 m 11 m 2f m 28 m ce m 65 m de m 4
m e3 m 51 m 24 m 9 m e6 m fc m 97 m 37 m 7d m ce m fa m 54 m fe m e7 m 8b m af m e6 m 1c m d m 72 m 8c m 53 2 r 49 m cc m
notbusy
02 wcmd 8 m 89 m 0 m \ 0x88900 
1c m 89 m 88 m 68 m 36 m 38 m 5b m f2 m 1a m b7 m ce m 52 m 39 m 48 m 6b m b6 m b1 m 3e m 4a m 25 m 61 m 16 m 4c m 23 m 59 m
c2 m 5f m 96 m 24 m 1d m 73 m 3c m ed m 43 m 77 m 7e m e4 m ca m dd m fd m cd m 19 m 83 m 53 m a2 m 62 m 5f m 76 m 6f m 55 m
19 m 4f m 0 m 9a m 36 m b m 4c m 4e m 25 m 15 m 22 m 72 m f4 m e1 m 8c m 47 m dd m ee m b1 m 2b m 93 m 1 m 6f m 7b m 7f m 4e m
c1 m 93 m bc m 2c m fc m cf m fb m d5 m bf m 7f m 47 m df m c7 m 9e m 73 m 39 m 4a m 4 m 88 m f0 m f1 m d5 m fb m d8 m 51 m fb
m e2 m d5 m 92 m a9 m a m 80 m 9f m d8 m e3 m be m cf m ba 2 r 52 m 1d m 20 m d6 m 89 m b4 m 4 m 82 m 83 m 4f m ff m ee m 2f m
ce m cb m b6 m 3 m f8 m 94 2 r 9a m 50 m e9 m 38 m 50 m 48 m 3a m 81 m 5f m 7e m d4 m 6d m 9f m b0 m 1e m 91 m 5f m 7b m f6 m
c5 m b3 m 6a m f3 m a8 m e5 m 9a m ba m 82 m 41 m 12 m 2c m 24 m 44 m 78 m 51 m bd m f4 m 79 m b2 m a6 m a1 m 19 m 8a m 76 m
b6 m 86 m d4 m b2 m fb m 35 m 91 m a1 m ec m 7c m a8 m 4f m 48 m 96 m 63 m 29 m 43 m 17 m 56 m 64 m e1 m 97 m 9d m 1d m a5 m
86 m b7 m af m e m 54 m 19 m aa m 75 m 66 m 86 m 68 m b m 2b m 4c m 54 m 4e m 98 m b5 m c3 m c6 m bb m 10 m ba m a3 m 9f m b8
m 9a m fb m f2 m 37 m 9f m 72 m a7 m a0 m e5 m 9c m 8d m c1 m 86 m 80 m 5f m bf m bc m 94 m ff m 42 m a2 m 10 m ba m 3b m 2e m
4a m notbusy
02 wcmd 8 m 8a m 0 m \ 0x88a00 
8f m dd m fd m f6 m f0 m 8b m 34 m 2b m 87 m 42 m b8 m fd m ee m a6 m 91 m 6c m d7 m 1e m fc m 75 m cd m 1b m e6 m 28 m 99 m
d2 m b2 m a5 m b8 m b3 m 13 m 15 m e5 m bc m 9e m fb m ce m 2b m 2 m f8 m 90 m 2f m f9 m 6c m 1d m 48 m 9a m e4 m a5 m 9b m fb
m c3 m 44 m a7 m af m 3b m aa m b9 m 3d m 71 2 r bb m f2 m b9 m 9f 2 r b9 m 33 m d9 m ad m ce m 8e m 64 m b7 m 5a m 67 m ee m
d0 m c6 m b7 m 5c m d7 m 3f m e0 m a7 m d5 m 20 m b2 m 25 m 97 m 92 m d4 m b7 m 4e m 9b m 83 m a3 m a m 48 m 52 m d5 m 4a m 58
2 r ff m e6 m 53 m 8f m e m 7f m c8 m b2 m 46 m c7 2 r df m f0 m bd m 98 m c3 m e8 m b1 m b7 m bf m 82 m a2 m 92 m 2c m 3f m
48 m 70 m d2 m bc m 79 m f2 m 80 m ee m 1c m 1d m 5d m 3e m 30 m f3 m d0 m 87 m 8c m 8f m 53 m 9a m d3 m ce m 7c m d3 m a5 m
52 m 6 m 5b m ad m 47 m 4 m c4 m 5b m 54 m 69 m c8 m 7f m f7 m 4f m 12 m 66 m 28 m 38 m ea m 7e m 69 m 4d m 3 m 72 m ad m 76 m
dc m 47 m ad m 30 m 29 m 51 m 8 m bf m b8 m 38 m 43 m 78 m 77 m db m 53 m 3f m 9c m 7d m d7 m c m 82 m 24 m 19 m 6b m 28 m 5 m
3d m c3 m 24 m 74 m dd m 24 m 4c m b2 m 30 m b m 74 m ab m df m fa m 91 m c6 m 33 m 5e m f4 m cf m b3 m be m 9f m 45 m f1 m 31
m b3 m 4a m 2b m 87 m 45 m 7 m 95 m c5 m f9 m c4 m aa m ee m 16 m 8f m 3f m 64 m 25 m a m af m fc m d3 m 2f m ce m 2c m
notbusy
02 wcmd 8 m 8b m 0 m \ 0x88b00 
dc m 5b m 36 m a m 98 m 6a m c9 m fb m 6c m 94 m 57 m ba m 6e m 12 m ba m ae m 3b m d4 m 2f m dd m ff m c6 m 37 m fa m 3e m f6
m b3 m 38 m b3 m 3a m d8 m ae m 86 m e9 m 3a m ad m 29 m c8 m b m 90 m c0 m 8e m 57 m d5 m 2 m 7 m 41 2 r d4 m e9 m 9 m 52 m
3f m fc m e0 m c6 m 2e m c9 m 41 m 3b m fb m 2d m 5f m d7 m 33 m 95 m 7a m f7 m 27 m 6a m 99 m 2d m 65 m ec m 12 m ab 2 r c9 m
30 m 20 m 51 m d0 m b2 m 29 m c1 m c3 m 39 m 50 m b8 m f1 m 83 m 6e m b7 m fd m eb m 7e m e2 m 6d m 17 m 71 m 31 m 8a m 6d m
6b m 5 m 20 m 3c m c4 m c5 m f2 m ff m f3 m c4 m 12 m 14 m cd m 38 m a2 m ae m eb m ee m be m 83 m 98 m c6 m 8a m ed m c9 m e7
m 1a m 7 m 67 m 7e m b8 m 7b m ab m f8 m db m 66 m da m 1f m 9c m d3 m fb m 15 m 3d m e3 m 4c m 57 m 2b m 46 m 11 m d0 m 85 m
10 m 88 m e8 m 98 m 5f m 1a m ae m 14 m 9f m f0 m ae m be m ef m 35 m ef m 38 m 8a m 96 m f0 m f5 m 66 m 54 m 8 m ea m 4 m 5e
m eb m c1 m cb m 6f m b1 m 3c m e3 m 35 m 97 m 58 m b8 m 77 m a6 m e5 m da m 54 m 14 m db m 94 m a m b3 m 74 m 6a m be m 84 m
70 m f0 m b m ee m a0 m 8f m f8 m df 2 r 88 m d1 m c9 m f2 m 72 m a2 m e6 m ee m e2 m a8 m 70 m 30 m 90 m d9 m 76 2 r b0 m 5d
m e8 m 82 m 83 m 51 m a0 m 40 m 74 m ad m 9f m b8 m d7 m fc m e8 m cd m d7 m 4f m 3b m ed m ea m 1c m 9c m 50 m 20 m b9 m
notbusy
02 wcmd 8 m 8c m 0 m \ 0x88c00 
63 m f7 m fc m 4e m f0 m 5c m bb m d1 m 2d m 4 m c8 m aa m 3a m ea m ae m d6 m 6c m db m 51 m 4d m 84 m e2 m 28 m 10 m 1d m 72
m cf m 7b m 2e m 8 m ab m 7d m fe m 3 m 67 m f4 m 89 m 39 m a6 m e8 m 6b m f2 m 58 m 9 m 80 m 7 m fd m a6 m 5e m f8 m ea m 37
m 29 m bc m b3 m 2c m 96 m 1a m db m dd m c1 m c7 m fe m f2 m aa m c3 m bb m 4e m db m 7a m e3 m 29 m 7d m 96 m ae m 90 m b7 2
r 52 m 8 m e1 m a0 m 63 m 5b m f5 m 48 m 77 m bd m 5d m f9 m 86 m ff m bb m 55 m a2 m a8 m 2a m 4a m 92 m 32 m a6 m d5 m 50 m
2b m 92 m 94 m 2 m 12 m 1 m 1e m 7d m 87 m 5b m dc m 42 m d7 m e m de m 79 m f2 m a5 m ae m 38 m ae m e8 m 23 m a8 m 80 m 14 m
3a m f7 m 27 m 3f m e6 m 7 m 1e m b8 m cc m 2e m 90 m 2f m fe m f3 m d9 m 9a m ab m e6 m d6 m 4c m f2 m 12 m c5 m a0 m ba m d
m 69 m b1 m b5 m cc m 2b m 81 m e8 m a8 m 47 m dd m 5 m 0 m be m f5 m da m b7 m 69 m 82 m 81 m 89 m 72 m 2e m 62 m 7c m bd m
36 m c7 m b1 m 70 m a6 m 5d m a5 m 92 m 1c m 94 m 3c m 8e m 88 m 90 m e8 m c6 m b7 m bf m f5 m 11 m b5 m 7e m be m e2 m 82 m
f3 m ce m fa m 86 m f8 m 7a m e5 m 8c m bf m 58 m 4e m 2f m 75 m e5 m 51 m 7c m 35 m 81 m 34 m 22 m 3 m 64 m 63 m 2e m 61 m 50
m 40 m 53 m e7 m 9 m 91 m 93 m 2c m 9b m 64 m c0 m 85 m 17 m 9c m 73 m ae m 9e m d m a4 m ea m c8 m 97 m 42 m c9 m 39 m c3 m
notbusy
02 wcmd 8 m 8d m 0 m \ 0x88d00 
d7 m 7f m d4 m 3d m 0 2 r de m 73 m f2 m 25 m 7a m 18 m 57 m 9e m 16 m 3d m 82 m 28 m 98 m 43 m 96 m df m 18 m 49 m 47 m 2f m
69 m 46 m 95 m ae m a6 m 2f m 3b m fa m 25 m 14 m ca m cc m c9 m c6 m c8 m 6f m 66 m 54 m 3 m 45 m 64 m 6 m 6d m a6 m 6f m 4b
m 5d m a9 m 2 m 40 m d9 m 50 m 90 m 51 m b2 m 22 m 6a m 66 m e m 84 m d0 m 51 m c6 m 51 m ae m 2b m 27 m 5b m 11 m 45 m d0 m
eb m 7a m 6 m 3b m 9d m 86 m 6a m 51 m 34 m e4 m 20 m 51 m 98 m de m f5 m 5e m 47 m 2c m a0 m f8 m e2 m f m 7d m f0 m db m 9a
m 1a m a1 m 44 m f6 m 39 m 4e m 95 m e5 m 8e m ec m 46 m 47 m 25 m d7 m 40 m 4b m 5d m 8 m 44 m c1 m 52 m 67 m 65 m a4 m 7d 2
r aa m 9d m 6c m 9a m 80 m b9 m 38 m aa m 6c m 2a m 54 m 24 m 5 m 1d m 4 m 7 m a2 m 7c m 2a m ac m 94 m b8 m 40 m 97 m 1b m 90
m 5c m c4 m 24 m 9 m 8e m 3c m 96 m f4 m 2c m 4f m 3d m ff m 13 m c6 m 30 m 1a m 68 m 24 m 55 m 49 m 19 m 49 m d4 m 51 m 9e m
c9 m 32 m f m 35 m 19 m 1a m 77 m b4 m 10 m 51 m d m 24 m c3 m 11 m f8 m ca m d1 m ac m 9 m 7d m ea m 79 m 22 m 38 m 53 m 5b m
a6 m 9e m 82 m ec m 72 m 77 m e9 m 33 m e5 m cb m 2a m b6 m 41 m 2a m 89 m 60 m 79 m 53 m 2a m eb m c0 m c8 m 82 m 34 m ea m
49 m 62 m 4e m 6a m 6d m a2 m 6f m e6 m c8 m 7d m 34 m 4 m 8 m 8c m a2 m a9 m ed m 12 m 72 m 2a m a8 m e m 21 m c8 m a8 m
notbusy
02 wcmd 8 m 8e m 0 m \ 0x88e00 
6b m 4e m 2b m b m 90 m 32 m 96 m 74 m 59 m 30 m 1b m 1a m a5 m 54 m 86 m 67 m 21 m 27 m 7 m 85 m 8f m 7e m e0 m e m b7 m be m
f9 m b0 m 32 m da m b7 m bf m 70 m de m 67 m be m c3 m ac m 56 m 4d m 5f m 43 m b5 m 2a m b6 m a6 m 76 m 5d m 4d m ae m c m 9c
m 4b m 41 m af m e m 0 m 2d m 31 m bf m dd m c6 m d1 m 80 m 83 m 73 m 79 m b2 m a0 m da m 80 m 4 m 43 m ee m 40 m 63 m ad m 9f
m d0 m c4 m 91 m c m 81 m 41 m 89 m 55 m e6 m c6 m 54 m b2 m 41 m 87 m d9 m 1d m 73 m c8 m 10 m d5 m 58 m 53 m d1 m 22 m 3 m
3d m af m 28 m 9e m 1b m 38 m 12 m 61 m 21 m 2b m 66 m 8e m e2 m a4 m 3e m 76 m 71 m cb m ba m 32 m 25 m 7a m 9e m 30 m e8 m
49 m 7 m 2b m 33 m b2 m de m 55 m 85 m 82 m d9 m d5 m cc m 11 m af m 42 m cb m 43 m 98 m d0 m da m 48 m df m f9 m 28 m 53 m 7
m 1 m ad m ec m 59 m 5c m 8e m e2 m 28 m 93 m 83 m 91 m e2 m 8 m 4a m 76 m 7e m 6f m c2 m 3e m f m 24 m 38 m f7 m bf m 70 m 37
m 99 m 14 m 1c m cf m df m 3c m 3e m 1a m 38 m d9 m b1 m 8f m b6 m 68 m e2 m 8b m 1a m 88 m 15 2 r 50 m 4f m 80 m 16 m 35 m ae
m b9 m b7 m ac m 67 m 89 m 73 m d4 m 3a m 67 m 3b m db m 3e m d1 m ca m 67 m c8 m e4 m 63 m 59 m c0 m 1 m 0 m 46 m 48 m 4 m 98
m 28 m 24 m 62 m 26 m 8e m ca m bd m 65 m 9b m c m 56 m 3 m 90 m 46 m 7a m 20 m 1a m e9 m 19 m 44 m a2 m 8b m 2c m 4e m
notbusy
02 wcmd 8 m 8f m 0 m \ 0x88f00 
d7 m 82 m 51 m 21 m 23 m 37 m ce m a7 m f9 m a4 m 44 m 94 m 98 2 r a3 m 51 m 11 m a m 19 m 4 m 6e m 1e m 92 m 24 m 12 m 9 m 90
m d4 m 3b m 2a m 99 m dc m e8 m f4 m 11 m 0 m 6b m d m 76 m ad m 7d m 25 m 2e m a m 73 m 48 m dc m 45 m 56 m c8 m e m 26 m 7b
m 68 m 53 m ad m a2 m 15 m 2a m 46 m 91 m b0 m 4b m 89 m e1 m 22 2 r 31 m c5 m 10 m dd m 4b m 6e m a4 m ef m 28 m fb m 1b m 62
m b1 m e8 m f2 m af m 64 m 51 m 26 m 57 m 5a m 10 m 4b m 30 2 r 67 m 16 m 50 m d6 m 7 m 0 m c9 m 49 m cd m 86 m 87 m 3d m c3 m
e4 m 11 m e4 m 83 m 21 m e4 m 0 m 64 m 4a m cc m c4 m 1c m a2 m 8a m 42 m 9b m 40 m d3 m b6 m 3a m 81 m 83 m 94 m d3 m 62 m 91
m 39 m a4 m ca m 5c m b9 m 4c m 98 m 4 m 90 m 80 m 29 m 27 m 74 m a5 m 90 m f2 m b3 m 1 m 30 m c1 m 70 m a8 m d3 m 2e m 6c m
e4 m 9b m 8b m 23 m 49 m f6 m d3 m 64 m 51 m 24 m c6 m 94 m 28 m a5 m 44 2 r 1c m 98 m 38 m 92 m 2a m 63 m ff m fe m 2d m 39 m
52 m 2a m b3 m a9 m e3 m 61 m e5 m 95 m 58 m 66 m aa m e8 m d4 m e1 m db m 28 m 19 m b9 m ea m 6 m 22 m b1 m 26 m 3d m 12 m 31
m 13 m 53 m 9c m 47 m c6 m 48 m 1f m 29 m 3e m 5c m 1e m 1f m 58 m bc m ce m d5 m 60 m 4f m 7a m 81 m ba m d8 m f9 m 18 m 60 m
26 m e m 31 m 4 m 22 m a m e5 m 80 m ed m e2 m a5 m c m be m 59 m b2 m 25 m 63 m 66 m 2d m 4a m ec m 16 m d9 m notbusy
20 wcmd 8 m 90 m 0 m notbusy \ 0x89000
02 wcmd 8 m 90 m 0 m \ 0x89000 
5 m 47 m 48 m 44 m d1 m 5e m 72 m 53 m 7d m 17 m 26 m ad m d8 m d3 m 6c m 9d m bc m af m 35 m 9f m 19 m 49 m 1c m 58 m 47 m 9e
m a4 m de m 16 m 94 m cd m 4a m 66 m 79 m a8 m c1 m a4 m fc m 2d m e5 m ec m e5 m 9 m c4 m 1c m 43 m 54 m 69 m 1c m 46 m e2 m
18 m c1 m 41 m dd m 98 m df m 3b m 7 m e6 m 1b m 14 m b9 m 98 m 0 m 50 m cb m f5 m 40 m e2 m 7c m f2 m 73 m 4a m a m f7 m 52 m
1f m bc m 98 m 26 m 4a m e1 m 4e m 80 m 34 m 1f m 47 m 96 m fb m ad m a m 9 m 73 m da m 12 m 13 m 11 m 53 m 60 m a2 m 18 m 22
m 99 m 36 m 26 m 54 m 45 m 60 m c m 9c m f2 m 19 m a m 9e m e8 m 68 m 1f m 12 m 33 2 r 5d m 34 m 7 m 46 m 43 m 32 m 80 m 31 m
2f m 8d m 33 m 11 2 r d3 m 7c m 32 m 86 m fa m a8 m 58 m 76 m c9 m d4 m 51 m 15 m 67 m d0 m 1c m 24 m d1 m 5e m 6a m 58 m 1 m
22 m 26 4 r b6 m ae m 9c m 4a m 30 m 37 m c5 m d3 m bc m c2 m c m 78 m a5 m 60 m 23 m 65 m c6 m 7e m b1 m a7 m b4 m e7 m 4d m
f5 m 5d m 6c m 1d m b5 m 77 m 9c m a1 m 20 m d3 m c0 m 7a m 86 m 70 m 48 m c4 m 44 m 4c m 51 m 44 m 17 m d4 m bb m 8d m d4 m
3e m 55 m 51 m 69 m e9 m a3 m ce m a2 m c8 m 72 m 30 m 86 m 98 m 31 m 54 m ab m 23 m 93 m 6b m 30 m c0 m 91 m 1a m be m b1 m
98 m 65 m ce m ba m 28 m dd m 64 m f1 m 9b m 20 m b1 m a5 m 36 m 98 m f9 m 9 m ba m 2d m a9 m b2 m 4b m 76 m a4 m notbusy
02 wcmd 8 m 91 m 0 m \ 0x89100 
8e m 16 m e1 m c8 m 6f m a2 m 0 m 80 m 44 m 39 m f3 m 37 m 33 m 31 m bb m a9 m 75 m af m 3f m d6 m 47 m 35 m 7f m 18 m 9b m 94
m 85 m d7 m e4 m 6c m ba m e6 m cb m 14 m 32 m 30 m 65 m a9 m 28 m 64 2 r 44 m b7 m c9 m 70 2 r f6 m 39 m b6 m c9 m e3 m 57 m
c m ff m 5a m 1f m d9 m ac m 39 m a0 m 65 m 4e m 66 m 62 m f4 m 42 m 73 m 58 m 15 m 60 m ad m 99 m 48 m 43 m 91 m 9b m 6 m d3
m ab m de m 39 m e m cc m 9e m 5d m ee m bb m 61 m 34 m b8 m 4d m 6e m 90 m 3d m 31 m 55 m 27 m 98 m 12 m 65 m 31 m 86 m c5 m
21 m 5 m 80 m c1 m 83 m 9c m b4 m 57 m fa m 72 m 3d m 7b m 27 m 7 m 89 m 29 m d7 m 1a m 6b m c8 m 41 m a7 m 8f m bc m df m 5a
m 50 m 5a m fa m 60 m cd m 6f m 16 m cc m ab m f0 m 27 m 56 m cf m 8d m d0 m e1 m 28 m 3 m 49 m ff m 3a m a0 m af m 31 m 8a m
b9 m 2d m c2 m 51 m 39 m c7 m 1c m 0 2 r 18 m a5 m fc m ab m c0 m 28 m 17 m 62 m a m 32 m 94 m 8b m 71 m 94 m 98 m b3 m 63 m
e2 m 14 m 82 m 93 m 77 m 8b m 83 m b6 m 35 m 19 m 59 m 35 m 26 m 4a m 9 m 13 m 17 m fe m a2 m 31 m 19 m 38 m c4 m 51 m 86 m 74
m b1 m d9 m f2 m e3 m 4c m 23 m d5 m 64 m db m 51 m 64 m 80 m 98 m 90 m 89 m 8 m 19 m a3 m f1 m 72 m 51 m bd m 3b m 69 m e2 m
ec m 43 m b2 m e3 m 8f m 9c m ba m 34 m b3 m 53 m c2 m 2b m a8 m 6f m b8 m 91 m be m 5d m 40 m a8 m 52 m 8a m 6e m 76 m 54 m
notbusy
02 wcmd 8 m 92 m 0 m \ 0x89200 
9d m 64 m 19 m 86 m 15 m e3 m e7 m 27 m a6 m 22 m ea m 6d m aa m fd m 58 m e7 m a7 m 38 m 39 m e8 m 4 m 21 m 3a m 6d m 3b m 87
m 8f m cc m b1 m f1 m 54 m 26 m b m f7 m 7a m 1b m 37 m b3 m b m 67 m 37 m 0 m 13 m 26 m 44 m 2e m 38 m aa m b8 m 41 m 8 m dc
m 90 m 7f m 94 m df m c1 m 79 m 27 m 0 m 90 m 10 m 13 m 52 m c2 m 84 m 49 m 65 m 51 m 2c m d3 m eb m fd m f5 m 4c m ae m 4a m
28 m a7 m c m 92 m 47 m 91 m 39 m 46 m 8b m 35 m 6b m 4d m 46 m 42 m c4 m 7c m 92 m 21 m 67 m 89 m 68 m 5c m e6 m a5 m 75 m 85
m 23 m b3 m ec m 64 m dc m 2c m cc m 5e m 8a m 8d m 99 m 2 m 2b m 40 m 12 m 82 m 10 m 90 m 91 m 98 m 72 m e5 m d2 m 81 m e5 m
b1 m 7b m cc m ec m 85 m 8e m d7 m 3 m b6 m 76 m e6 m c4 2 r 46 m fa m 76 m fe m a3 m 87 m 40 m 35 m 39 2 r 54 m 80 m 59 m 86
m b1 m 33 m 0 m 72 m 76 m 7e m 82 m c4 m c0 m 5e m d4 m 8f m b8 m 34 m 61 m 91 m 83 m 45 m 1a m 9b m ae m 1d m b8 m 47 m 43 m
2 m 7 m 6b m 80 m 6c m c3 m 5 m c3 m 4e m 12 m c8 m a6 m 1b m 3d m 89 m 59 m a4 m f m 68 m e4 m c2 m 18 m a2 m 6 m e0 m 9a m
6d m db m b9 m 40 m f9 m d0 m 55 m 59 m cc m b3 m aa m 33 m 6b m b3 m ab m 62 m 32 m 4f m b0 m 5 m 55 m 6b m e m b6 m d7 m ae
m 51 m b4 m d m 8c m e6 m 91 m 21 m 5d m 93 m ac m d0 m e m c9 m b0 m f5 m 23 m 63 m d2 m e4 m 98 m 34 m a9 m b6 m 11 m
notbusy
02 wcmd 8 m 93 m 0 m \ 0x89300 
cb m ce m 5 m 26 m f2 m d m 1e m 68 m fa m 6c m cf m 38 m bb m a1 m 12 m 8c m 42 m dd m 11 m 62 m 63 2 r fc m 8b m 60 m 63 m
ee m 64 m f5 m ae m f7 m cd m e0 m 85 m 9d m d3 m 89 m c6 m 9e m b6 m 1e m 8e m d5 m d8 m d7 m da m 63 m a4 m f9 m dd m ab m
24 m 37 m 7f m f6 m 4 m 31 m 59 m 6b m 5e m f2 m fa m d6 m c6 m 46 m 75 m 66 m 52 m 94 m 57 m 5d m 80 m 87 m 91 m d m 1b m 58
m 4f m 4e m c8 m d7 m 62 m cb m 63 m 70 m 7 m 60 m da m 7e m 36 m a m 7 m 3 m d6 m 50 m 2a m 78 m 72 m f3 m 5b m 1e m 68 m a m
c9 m 31 m 30 m 7b m e2 m cd m 2f m 5a m ca m cf m 13 m 3a m 6a m 32 m 94 m 4 m fb m 57 m ab m a3 m a m cf m d6 m f5 m 80 m 3d
m 94 m 45 m 14 m 78 m 49 m 29 m 2f m fa m 8 m a1 m 7a m 61 m 8b m 4c m ec m 6 m 37 m 7b m ad m 0 m f5 m e8 m 58 m f7 m 28 m 9
m 5a m b8 m c1 m be m bd m 3a m 2c m 8 m f0 m ec m 39 m 40 m 52 m 35 m f1 m a2 m fd m 6b m 23 m 7a m fc m c m d1 m fe m d m 39
m 68 m f2 m 18 m 2a m 75 m 54 m 79 m 48 m b5 m 69 m ee m bb m a8 m 8c m 1a m e3 m 14 m 2c m d4 m 8e m 5c m 2e m 70 m d4 m e9 m
cd m 1b m c5 m d1 m 40 m 17 m 94 m 51 m a8 m 46 m 52 m 5f m 5e m ae m cd m af m 54 m 4d m d1 m 80 m 8b m cb m bb m 2f m 1b m
2d m 59 m 40 m 46 m 45 m 8 m 78 m 79 m 9d m 84 m 8e m 9a m 10 m 37 m ee m 8a m 23 m 79 m 7c m 32 m 24 m f9 m c9 m c7 m 41 m
notbusy
02 wcmd 8 m 94 m 0 m \ 0x89400 
73 m 48 m 5d m 72 m c m db m ad m 78 m b7 m 7e m ac m 54 m c4 m 78 m 18 m 1b m 33 m 6c m a8 m 6f m 2f m 68 m 6c m dd m 48 m 45
m 9d m 71 m 67 m cd m 9c m 40 m fa m 7d m fe m 65 m 6a m c8 m 7a m 6f m 70 m a5 m a2 m fd m 2b m 39 m 68 m b2 m 98 m fc m e8 m
d6 m 38 m 82 m f2 m c8 m 82 m a0 m ba m 87 m c2 m 47 m 5 m 48 m d0 m 1a m b5 m f2 m 44 m a8 m 78 m 61 m 27 m b6 m dd m 52 m f3
m 80 m a0 m 84 m f9 m 91 m 2c m c7 m 48 m 1b m a1 m 95 m b9 m 91 m 1a m 1c m c 2 r d5 m e0 m 26 m 37 m 9d m 4b m d2 m e1 m 90
m 34 m 4 m 53 m 4d m 46 m d1 m 47 m 35 m 1d m ce m 9c m d4 m 17 m d3 m 69 m 33 m 83 m b4 m d2 m f3 m 45 m a m 97 m 2f m d6 m
c3 m 6e m b4 m e4 m e6 m d6 m a6 m d6 m 86 m a4 m 7e m d7 m 4d m f6 m 3d m 6c m 95 m bd m 60 m 46 m 49 m 35 m f0 m 45 m ce m
9b m a8 m 7 m 1b m e5 m f1 m 33 m 8a m f6 m 5f m 52 m e m da m f4 m 99 m a2 m cb m 8a m 9 m c m 43 m 2a m 72 m bc m 38 m ae m
80 m 64 m f1 m d8 m ca m 54 m b2 m d1 m 1e m 60 m 70 m cd m b6 m e4 m 74 m 28 m 7 m 2b m 71 m 1e m e7 m 65 m 7e m bd m a0 m ac
m 27 m c8 m ac m 16 m af m 89 m 4c m 6 m 2c m fd m 2 m d m 32 m a m 15 m 6d m 32 m c6 m 74 m d4 m e6 m b0 m e9 m 23 m bb m c5
m 54 m 52 m 99 m fb m 21 m 23 m 3b m 5 m b6 m 2c m e9 m 73 m 9b m 8e m 40 m f2 m b3 m 5b m a2 m 4f m 8 m 50 m 18 m 41 m 5f m
notbusy
02 wcmd 8 m 95 m 0 m \ 0x89500 
7b m 23 m 7d m 57 m 0 m f0 m 3a m b1 m 4c m 4f m 85 m 24 m f7 m d7 m cf m ba m f0 m bc m 93 m 7 m d5 m 33 m 3c m 92 m c6 m 72
m b0 m c m f0 m 80 m 8f m ca m 33 m 2b m 98 m cf m b3 m 6a m 54 m f3 m 55 m 7f m 46 m ac m 59 m 4b m cc m 1d m 85 m 1a m 96 m
9d m b m 93 m dc m 9e m b2 m f2 m da m 8e m d8 m a2 m 8 m a m a1 m 6e m 20 m 3c m f5 m 2b m 29 m a3 m 55 m c9 m 28 m a8 m 70 m
54 m 14 m c7 2 r 3c m 5f m 30 m f1 m 8e m e5 m 7a m 27 m 85 m 7d m 5f m 23 m 56 m de m 2d m 5e m 1e m 4f m ed m 10 m e7 m d m
86 m d8 m ed m be m 1d m 2 m 60 m c0 m a0 m d6 m b0 m f0 m e7 m 80 m 26 m 7b m 64 m 35 m d6 m d5 m 44 m db m 23 m 9a m 72 m d0
m d9 m 5f m 23 m bb m a6 m 85 m 73 m a7 m 4e m c6 m 8c m 84 m 55 m 47 m cd m 47 m e m f8 m 70 m 47 m 30 m 5a m 61 m 2e m 6a m
16 m 9e m cb m 5b m 73 m 88 m ad m 20 m b4 m 2e m 8a m 86 m 64 m c m c1 m d4 m 24 m c3 m fa m ab m 49 m 18 m c9 m 2e m 87 m a3
m d6 m d4 m 37 m 38 m 79 m b7 m 4c m 2b m 7 m de m 81 m 2e m 4c m 46 m d8 m f0 m dd m 36 m d2 m b7 m 67 m fe m 42 m 8e m 5e m
54 m 3c m b2 m 9a m 9e m b9 m d2 m d3 m 1e m 90 m ac m 27 m ff m c m ac m 15 m 2d m 9a m 89 m 58 m c9 m 41 m 2f m 8 m d m e1 m
1e m a6 m 6e m b0 m 5c m f3 m 2 m d2 m db m ed m 76 m a1 m bb m 75 m c7 m 46 m 1d m ac m 36 m 1f m 83 m 81 m 1c m 32 m d6 m
notbusy
02 wcmd 8 m 96 m 0 m \ 0x89600 
60 m 86 m ab m f9 m 19 m f m 6c m 19 m db m 35 m 49 m 5e m 92 m 8c m 26 m 1d m ca m 1d m e8 m 1f m 59 m dd m 61 m fc m 63 m bd
m 15 m 9e m d9 m 3d m bb m 6a m d8 m a3 m 17 m 31 m 63 m 6b m 6a m d3 m 7d m 7b m 11 m dd m 94 m f3 m e3 m 91 m 2f m e3 m d m
60 m b9 m 98 m ee m 59 m f3 m 9e m d1 m 94 m 83 m 5e m 17 m f9 m f7 m 73 m 2 m b9 m 52 m 73 m ed m e m c0 m 77 m 84 m be m af
m e1 m 5b m 7b 2 r 6e m 87 m 30 m 5a m 71 m 3e m ca m 40 m e m 86 m b1 m c m 67 m a5 m 8f m a0 m 1e m cf m 54 m d3 m be m 36 m
f5 m 2b m 91 m d1 m a0 m c3 m d m 1d m 56 m 4f m 2c m 35 m 4c m 8d m c0 m 8a m 77 m 36 m c3 m c9 m 9e m c8 m c1 m 0 m 29 m 59
m 15 m 5 m 9b m ea m bb m fe m db m b4 m 18 m 46 m 23 m ef m 61 m e4 m af m 1f m 4e m 75 m f3 m 19 m b m e4 m e0 m 1c 2 r cd m
15 m c8 m d m 4e m 2a m 88 m ad m 5 m 6b m f5 m ce m f3 m 6f m 5f m ad 2 r 3c m 23 m 35 m 75 m b5 m a1 m 51 m c4 m bb m 67 m
c7 m 6a m 58 m 2b m 59 m bf m 63 m ba m 17 m 91 m e1 m 74 m f8 m 90 m 43 m 87 m 20 m 69 m c m c3 m 3c m e9 m 36 m 7c m fe m 6e
m b5 m 8a m 3 m b7 m 11 m ae m 1b m eb m bb m 9e m ad m 45 m 72 m de m c1 m 79 m c4 m a3 m 15 m 8b m b6 m 5 m e6 m 40 m 29 m
8d m e5 m e0 m 1c m e5 m b1 m 9a m 40 m ae m 64 m e4 m 70 m c8 m aa m 97 m db m 31 m 8c m d6 m 99 m 11 m 4f m 1e m e m notbusy
02 wcmd 8 m 97 m 0 m \ 0x89700 
fe m b9 m 27 m d6 m 1c m 3c m 62 m 91 m dd m 92 m 0 m db m 91 m e1 m 7 m 6c m be m 16 m 1f m f m 43 m 6b m e6 m 9d m 2e m d8 m
5d m 4e m 2e m 1d m ce m 13 m 31 m 38 m fa m dc m 4c m df m 65 m 78 m e6 m cf m 13 m 56 m 5f m 7 m 34 m f9 m db m 6 m ca m 7d
m fc m c m 3f m 79 m b5 m 2c m 1c m f2 m 51 m 53 m 20 m 6f m cb m 4a m f3 m e5 m a4 m bf m 6d m e7 m 28 m 5a m 77 m 4e m c6 m
48 m 1f m 72 m 2f m 0 m b4 m c6 m 74 m d7 m f0 m bf m a m 19 m ad m b9 m 1d m db m 19 m 8d m 96 m 6 m 57 m 34 m d9 m 78 m 67 m
5c m 9d m 9a m 3f m ce m c3 m d1 m 1e m f4 m 5d m 3 m 79 m de m 44 m e1 m e0 m eb m 8 m 47 m db m b3 m e9 m b2 m 72 m 70 m 67
m 2 m 19 m 5b m 3f m 54 m b7 m ec m e m 2f m ae m 3b m 13 m c3 m 1 m c4 m d1 m 6f m a m 7d m c3 m 17 m de m 25 m 14 m 2d m 47
m c6 m 2 m 3a m e6 m 3c m 6a m b1 m 95 m 0 m 3b m e5 m de m 45 m 2d m 35 m bf m f7 m fd m ed m 41 m df m a3 m 1 m 6b m 37 m 6c
m 7e m 3b m ba m 71 m d1 m 33 m 2a m 34 m 2e m 90 m 83 m 63 m 41 m b8 m 1d m ce m e7 m 10 m 3a m 6a m bb m c6 m 8a m 3b m 99 m
97 m b9 m 23 m 89 m 3 m fa m 96 m 1c m d6 m 5d m 26 m 3 m 47 m fd m 8d m 4 m f0 m fa m 56 m ed m e6 m da m 12 m 56 m ca m 5e m
74 m bd m 53 m e m 5d m f2 m 19 m 3 m c5 m d6 m 34 m c4 m 86 m 8 m 5f m 47 m 20 m 6f m 6b m b8 m ef m b0 m ed m 70 m notbusy
02 wcmd 8 m 98 m 0 m \ 0x89800 
6e m 86 m b7 m 37 m ed m ba m b9 m 3f m ef m 5a m 5b m 4c m c6 m b6 m 74 m b4 m 7 m 61 m 29 m d3 m ef m ff m 3f m db m 4a m 13
m b5 m ed m e8 m 2d m 7f 2 r 4b m f3 m ce m 1 m f7 m c6 m 78 m 69 m bd m b6 m 2b m 1c m b2 m fd m 43 m f6 m e4 m ad m 97 m 78
m 97 m dd m 8a m 6e m 6c m b0 m 7d m 9f m e8 m a3 m bd m 6d m db m f8 m 7d m 7b m 26 m 90 m d7 m 6e m bb m 3c m 37 m 8b m f5 m
d1 m 9e m b5 m 6d m f4 m d1 m 81 m f6 m 7d m d9 m 96 m e1 m c5 m ef m d7 m a9 m dc m df m 2c m 96 m 3 m ed m ff m 17 m da m 76
m fa m e8 m fb m af m fd m 7f m 24 m 81 m 50 m fc m b8 m 9f m 86 m 26 m 0 4 r 49 m 45 m 4e m 44 m ae m 42 m 60 m 82 m 0 3 r 20
m 2 m 7 m 0 2 r 26 m 1 m 0 2 r 1f m 0 3 r 22 m 28 m ff 3 r 0 2 r 3 m 0 3 r 3 m 0 m 2a m ff 3 r 0 3 r 5 m 10 m 4 m 4c m 41 m 0
3 r 23 m 0 3 r 22 m 26 m ff 3 r 28 m ff 3 r 0 m c0 m 0 3 r c0 m 0 2 r 2a m ff 3 r 0 2 r 20 m 4 m 1 m 0 2 r 5 m 0 3 r 40 m 0 3
r 23 m 2 m 0 2 r 5 m f0 m 0 2 r 10 m c0 m 17 m e4 m 46 m c m ff 3 r 80 m 2 m b2 m 2 m 1f m 0 2 r 6 m 30 m 2e m 31 m 2e m 30 m
0 7 r 1 m ff 3 r 0 m ff m notbusy
02 wcmd 8 m 99 m 0 m \ 0x89900 
ff 2 r 26 m ff 3 r 6c m 5e m 0 2 r 22 m ff 3 r 0 4 r 78 m 9c m ed m 7d m 9 m 5c m 55 m 45 m fb m ff m dc m cb m 2e m b8 m 97 m
fb m be m e6 m 52 m e6 m 92 m 58 m 6e m 69 m 6a m 65 m 99 m a6 m 95 m f6 m 56 m 6e m a5 m 56 m 9a m 66 m 54 m 5a m 2e m a9 m
b8 m 64 m a8 m 58 m e4 m 8a m 85 m bb m e4 m e m 68 m b8 m e3 m ae m c8 m aa m 2 m 8a m 80 m 22 m a0 m c8 m 8e m c0 m e5 m 2 m
77 m 79 m 7e m f3 m cc m 9c m 73 m 66 m ec m b5 m fe m 2e m dc m 3e m bc m fd m 7b m 3e m 9f m 2e m f3 m f5 m 9c m 99 m 33 m
67 m ce m 33 m cf m 3c m db m 4c m 84 m fc m 4b m e5 m 43 m e7 m e0 m bd m 87 m 6 m c7 m e1 m 2d m 1 m 36 m c2 m 73 m 2 m cc m
83 m 27 m 5 m 18 m 6b m 90 m 9e m d3 m 37 m 56 m 2 m 8d m d7 m fd m 59 m 77 m f4 m 95 m 45 m b9 m 6e m 16 m ac m d6 m c0 m 70
m 80 m 2c m d m d4 m 88 m 2b m f6 m fc m b3 m 16 m 1e m 8f m 7c m c0 m 9d m 6c m 82 m 76 m e5 m 4 m f4 m 76 m fc m bf m 7f m
26 m bd m 1 m 1f m 91 m f1 m f0 m 3a m 7 m 33 m a0 m 1b m f9 m 9 m 9a m 70 m e0 m f m 55 m c8 m b1 m 2 m 1d m 7 m b1 m c9 m 84
m 64 m 9e m c5 m 92 m a7 m 97 2 r 29 m 88 m d4 m 82 m 2b m 5e 2 r ad m 49 m 1e m 0 m 2c m 22 m 7d m e9 m 2f m bc m 4c m af m
8d m a2 m c m 36 m 19 m 7a m f0 m 2a m f3 m a1 m 3 m 59 m b m b5 m 39 m f8 m cd m notbusy
02 wcmd 8 m 9a m 0 m \ 0x89a00 
ec m 44 m ce m 16 m 60 m 69 m f m bd m 37 m 8e m 90 m bb m f4 m 8f m 27 m 19 m eb m bd m a m b6 m 93 m 46 m 10 m ee m ed m 3d
m 90 m 5e m eb m 8 m b3 m c9 m 40 m f8 m 84 m 57 m f9 m 0 m de m 24 m 5f m ab m 8d m 2d m 86 m 96 m 94 m 49 m ab m 71 m b0 m
df m a8 m 27 m 91 m 29 m 8f m f7 m de m bd m a1 m b7 m c m 5e m 54 m 8b m 6f m 1d m cc m 87 m 9c m 6d m 23 m 58 m 79 m 39 m 98
m e2 m 20 m 1d m e0 m 57 m 7b m 42 m 3a m 41 m 7a m eb m e m f0 m ec m d3 m 51 m 77 m bb m 10 m 32 m 9 m e6 m 91 m e m f4 m f5
m aa m b4 m a2 m 77 m 7d m 1 m 73 m 19 m 60 m d4 m 3 m 32 m 3a m 6a m 80 m ec m 0 m 6b m 2 m cc m 56 m c6 m 53 m ff m 55 m 2c
m 8e m d3 m b9 m 56 m ca m c5 m 7e m b0 m ee m 32 m 64 m 2b m af m 44 m eb m d8 m ed m 85 m a9 m 1a m 20 m 6f m e3 m b4 m a9 m
f5 m 95 m 8e m 81 m 49 m 30 m 87 m 90 m 53 m b0 m bd m 21 m 5 m 6d m 53 m 71 m 4c m 1a m c5 m 81 m f5 m 1a m 5c m 33 m 83 m 37
m 56 m a8 m 36 m fb m 52 m 29 m e4 m ed m 1b m a2 m be m c4 m 8b m f7 m be m 9c m 4 m 2a m b5 m ab m f4 m 18 m 83 m 26 m 53 m
cf m b m 85 m 91 m fd m d9 m 4b m de m ad m 51 m df m 70 m 7c m d4 m a1 m d2 m 16 m 74 m 94 m ac m b3 m c8 m 57 m d0 m 8c m d4
m b1 m d2 m a9 m 1d m 9c m e9 m 46 m 56 m e6 m d3 m 3b m d2 m b6 m 90 m 9e m f0 m 39 m 21 m 73 m cc m d5 m 49 m 25 m e3 m 32 m
notbusy
02 wcmd 8 m 9b m 0 m \ 0x89b00 
72 m 2a m c5 m 89 m 90 m 6e m e0 m 55 m cf m 13 m 6 m bc m a m 63 m b1 m 91 m 6f m cd m 60 m 59 m 48 m 9e m 1b m c6 m e7 m 59
m cd m 6e m 54 m 2 m e9 m 9a m b7 m e5 m a8 m c5 m e0 m ea m d m c3 m 0 m ae m b5 m a7 m 65 m 5d m f8 m 35 m fb m 3d m 19 m bd
m 3a m 5e m 9 m a3 m 60 m 18 m c m d7 m 97 m ac m 45 m b6 m 7d m 92 m d8 m c5 m 45 m eb m 6a m c0 m 4c m 42 m de m 87 m a7 m
c9 m 68 m 78 m 8d m 90 m fc m 9d m 84 m 2c m 85 m ca m 8e m c9 m 67 m e8 m ad m 4b m 8b m 67 m 4e m c9 m fe m 8d m e m 24 m 8e
m 85 m f3 m b2 m 5b m 59 m 7e m d5 m ca m 69 m 1c m fe m 8c m de m d m 2b m 4c m 9c m eb m cc m cb m 53 m 21 m 6d m 47 m 3a m
4 m b2 2 r bd m e1 m 4e m 35 m 62 m 7f m 26 m c8 m d m 41 m 5b m d8 m 45 m 7f m 1d m f9 m 5d m 6e m 66 m 59 m bc m 1e m 67 m
33 m 4a m a1 m 4e m 96 m b4 m ea m 6a m d9 m c1 m d3 m c m bf m eb m c9 m 0 m 80 m 4 m 42 m d6 m c1 m cf m db m e0 m 7b m f2 m
26 m ec m fd m 8e m ce m 9e m b m 3a m a7 m 93 m f0 m ce m 38 m a0 m 5f m e2 m 6b m ca m a2 m a4 m c6 m d5 m a2 m dd m f9 m 74
m 10 m bf m 44 m fe m 21 m cd m 32 m e8 m 5c m 43 m 16 m 4d m 69 m 40 m 48 m 83 m 88 m dc m 94 m 3a m 4 m 59 m d4 m 70 m e8 m
a4 m 61 m f1 m eb m d6 m b m 2e m b4 m 6f m df m 46 m 17 m 27 m ce m d0 m 93 m 85 m b0 m 53 m 67 m 83 m 21 m f1 m d5 m 26 m
notbusy
02 wcmd 8 m 9c m 0 m \ 0x89c00 
46 m 79 m 80 m 7f m 9e m 4c m 6e m 94 m 78 m a5 m 91 m 5a m ae m 77 m 23 m aa m a6 m 76 m 61 m 4f m 41 m b m ad m 3c m 84 m 4f
m 18 m 4e m a7 m 53 m ed m b5 m 72 m 53 m f8 m 56 m 5c m f8 m 12 m ba m a m b0 m 6 m 6a m 8 m 10 m 5c m 24 m 3d m 31 m 3c m 4f
m 2 m fb m 8a m 25 m b0 m 42 m 95 m dc m 48 m 93 m 54 m 31 m 8c m 54 m c7 m fc m bd m 74 m df m c1 m 6c m 17 m 1 m 7a m 5a m
a7 m 4b m 97 m d6 m 96 m 49 m 4a m 45 m d5 m b0 m 9b m 2d m 24 m 74 m e0 m 4c m 23 m f2 m e0 m f4 m a1 m 79 m a9 m 84 m 86 m
58 m 64 m e4 m 9 m fd m 4 m b0 m b m 4b m 74 m 16 m e8 m 2d m 18 m 21 m 80 m 7d m ea m 3e m a9 m d6 m 66 m 93 m 9b m 0 m 73 m
a0 m bd m 0 m a3 m 61 m a0 m 0 m ef m c1 m 68 m a9 m 17 m f2 m 8c m 5c m 0 m 4f m 9 m f0 m 5b m b1 m 18 m 4 m 97 m 6c m 7f m
b9 m ca m 20 m ad m 5c m 29 m 3e m 42 m 70 m ec m 3a m 73 m 27 m ad m fc m 39 m 4c m d6 m ca m 63 m 13 m 3e m 25 m 7f m 13 m
f5 m f3 m 10 m c m 46 m 56 m a9 m da m ce m 3d m c0 m bd m 8a m 2 m da m d6 m 27 m 76 m 99 m 25 m 1 m ef m 6f m 81 m 77 m e6 m
c4 m 52 m c9 m e2 m f0 m e1 m 41 m 13 m 2e m 66 m 70 m 67 m 5 m e3 m b3 m 9a m b m 68 m b1 m 8f m 9e m d7 m 72 m 8 m 85 m 4b m
30 m 46 m 69 m eb m 7 m f0 m 7e m 22 m cd m c0 m c7 m ea m 15 m 6b m a4 m 23 m 79 m d1 m 72 m 91 m 7d m a2 m 36 m 27 m 71 m
notbusy
02 wcmd 8 m 9d m 0 m \ 0x89d00 
21 m 9c m f3 m 83 2 r 4d m 5f m f2 m 91 m a9 m dd m cb m 92 m 12 m fb m b0 m e2 m 29 m 8 m 54 m a2 m 1c m e3 m b1 m 69 m d3 m
a6 m 44 m d8 m 4f m 7f m 9f m 79 m a8 m d6 m bc m b3 m 24 m ae m fc m 97 m 8 m 89 m 81 m c2 m 2a m 6a m d9 m c5 m c m ab m b4
m b m 5d m 81 m ae m f9 m 2a m 8d m 87 m 13 m a2 m ca m 2a m 18 m 2e m c0 m b9 m f4 m a m ca m 6b m 7f m a0 m 28 m c6 m 39 m
13 m ee m 3 m fe m a5 m 87 m 20 m e7 m ba m a2 m dc m f0 m 2e m 6c m d6 m c0 m 7b m 0 m 62 m d9 m ab m 79 m a5 m 78 m 91 m d m
3b m d1 m 1e m 7e m 12 m 60 m 19 m 3c m ab m 95 m 1d m 32 m a3 m c4 m 85 m a1 m 30 m 49 m 80 m 7d m a5 m 62 m b5 m ae m 6b m
fe m 4d m 5c m 98 m 26 m af m 3f m 57 m 53 m f5 m 5a m b9 m 3b m cc m 17 2 r d6 m 81 m 58 m 67 m 5d m b m 8f m 8b m b m a3 m
61 m a4 m 0 m 27 m b m 5c m b5 m 72 m b m f0 m 15 m 17 m 16 m c0 m f3 m 5a m d9 m 2e m ed m 8a m b8 m f0 m 2a m 7c m 25 m c0 m
e m 73 m 1d m f1 m 90 m 58 m 3f m f2 m 98 m d4 m 7a m 67 m 66 m 49 m fc m 2c m fe m 42 m 9d m 32 m 21 m 2b m a2 m c m 76 m a0
m 52 m ac m bb m 6e m fd m 8c m 5a m 37 m 67 m d9 m a3 m fb m 71 m 5 m ba m b1 m 35 m 9e m fe 2 r aa m b8 m 32 m 42 m a1 m 33
m 21 m c7 m e0 m 5 m 6 m b6 m a1 m 4b m 23 m e m 5a m 91 m e7 m c6 m d6 m a0 m 36 m 3c m 1d m d3 m 6c m 68 m ae m 2b m notbusy
02 wcmd 8 m 9e m 0 m \ 0x89e00 
a4 m fa m b1 m 37 m b5 m 35 m c9 m 4d m 68 m 4e m 2 m 32 m df m a2 m 60 m 1a m fa m 42 m b8 m a8 m fd m 5 m 3e m 20 m 64 m a7
m b2 m e6 m 1f m 80 m be m 68 m 40 m b0 m e1 m a8 m 5e m 9c m 49 m ad m 14 m c7 m 8c m 52 m da m a6 m cb m 1e m 58 m 80 m ff m
d6 m ff m 2e m dc m 3c m 57 m 4 m 47 m ab m b2 m bb m 9f m 59 m 1f m 9b m 1f m f2 m 9d m ed m 65 m 8a m 7e m 23 m 80 m 49 m 29
m eb m 7c m 21 m 52 m 3 m 2b m e0 m 7c m 5d m 15 m 2c m 81 m 88 m 6a m ae m 2a m 18 m 1d m 55 m 83 m 68 m 80 m 50 m 15 m 51 m
0 m 62 m 33 m d0 m 32 m 38 2 r f8 m 30 m 58 m e9 m ef m 5c m 42 m 3a m 6b m 2b m 60 m d0 m 43 m be m ed m c3 m d2 m ab m 87 m
6f m e5 m 9f m fb m 82 m ab m c1 m b m a9 m 51 m 1c m 67 m 86 m 10 m e4 m a4 m 7e m 50 m 40 m 2d m f5 m 76 m 59 m 4c m 76 m 7e
m 5e m f8 m 35 m 5e m ff m e m d8 m 74 m 72 m 65 m 6 m d7 m 48 m 38 m 2d m 5a m 99 m 3 m 82 m 89 m 2b m a5 m 8 m 95 m d2 m 2e
m 8 m 34 m b5 m 51 m ff m b m c4 m 56 m 55 m ca m 4e m db m 21 m fc m 9 m a5 m 5c m 35 m 4 m f6 m ab m da m 64 m bd m 8b m b0
m 52 m d5 m f2 m 9e m 4a m b6 m 7e m a9 m 35 m ea m 3 m d9 m 87 m 39 m f5 m 44 m a0 m d2 m b0 m c7 m 7e m ff m bf m 24 m dd m
a8 m 53 m d9 m f9 m 11 m 5f m b1 m b9 m 6e m bf m b m e0 m 66 m 58 m 29 m a0 m a1 m 47 m ba m 97 m c6 m b5 m a6 m 6 m c7 m
notbusy
02 wcmd 8 m 9f m 0 m \ 0x89f00 
4d m 34 m cb m 9 m e9 m 52 m 1f m 7f m 67 m c1 m 36 m 51 m 73 m 36 m f8 m 68 m e5 m f6 m 77 m ca m 14 m 55 m 64 m d3 m c1 m 4b
m 96 m c8 m 9e m ca m 3f m a7 m 52 m b6 m f4 m 7f m 46 m bb m ab m ce m c8 m ec m 12 m 21 m 3b m c8 m 7 m 70 m 52 m 80 m 96 m
80 m 56 m 47 m 6d m f6 m 30 m d2 m 1f m ae m d1 m c1 m 8c m 5 m 2f m fa m 19 m 1a m 46 m 31 m f m 46 m 8f m 6c m c8 m 3e m 15
m 51 m c2 m fb m 46 m ea m 7b m c5 m 19 m d2 m 4f m 4e m 10 m a6 m 8d m d m 69 m 2c m c0 m 61 m b5 m 5c m 33 m ab m 40 m 0 m
5f m eb m 64 m d m 3c m 6f m 5d m ed m ae m 2 m bb m e8 m ac m 1a 2 r 98 m 4a m f5 m 5c m 15 m d4 m 2f m 38 m a3 m d3 m c0 m
76 m 33 m 1d m 18 m 5 m bc m c m cb m 88 m a m 9c m 12 m 6e m 57 m d6 m c0 m 10 m b8 m ec m 47 m 69 m 1f m dc m f6 m 9b m 4f m
86 m 69 m 3c m 1 m 97 m d5 m 3e m b8 m 8b m ee m fc m 15 m b0 m d m ad m 57 m 7a m c3 m a4 m e1 m 1e m 38 m c5 m 68 m 1a m 82
m 63 m 85 m d2 m 6d m 91 m a9 m 12 m 48 m ba m 2c m 81 m ec m 53 m 12 m 30 m 5 m 39 m c m f3 m 59 m 3e m 92 m 49 m 4b m 57 m
f0 m df m 8d m 2d m c7 m 36 m a1 m a0 m 56 2 r c1 m 94 m 16 m 6e m 3d m ce m 3 m bf m 9b m 2d m 2 m 4f m 96 m aa m 4e m 48 m
a4 m 58 m 18 m 40 m 7f m 3b m 32 m 7 m 88 m 5d m 3e m 5e m 79 m dd m 14 m d5 m 80 m ca m e6 m e5 m 70 m 81 m fe m 93 m e3 m
notbusy
20 wcmd 8 m a0 m 0 m notbusy \ 0x8a000
02 wcmd 8 m a0 m 0 m \ 0x8a000 
5e m 30 m 85 m 9f m ca m 82 m c m e6 m 58 m d3 m 7d m 70 m 22 m b3 m e0 m c2 m e2 m aa m c4 m f6 m d4 m 24 m 11 m 36 m a8 m 3c
m da m 2a m d m 7e m 50 m 5d m 26 m 2e m 31 m dc m 2b m c7 m 68 m 2d m 4 m 68 m b m b5 m 3b m 64 m 8b m a5 m 7d m 7 m 7c m ac
m 95 m 9b m 5a m 72 m 9d m df m 5e m b6 m f8 m 5d m 36 m 3a m 63 m 61 m 23 m 1f m 1d m 5c m c7 m 97 m 40 m ca m f4 m 86 m 95 m
3a m 1f m 84 m 50 m da m ca m 3e 2 r 27 m 2b m 65 m a0 m 49 m f6 m 1b m bc m cb m ea m 1e m 82 m a1 m 38 m 5b m b9 m a4 m 89 m
45 m 4b m b6 m 51 2 r 3a m 9d m db m ba m 29 m 70 m 19 m 25 m d1 m 38 m 93 m e9 m dc m fe m 24 m c8 m e6 m 33 m b8 m e3 m ce m
84 m a2 m 48 m 6f m c9 m 1d m 60 m 13 m 12 m f6 m 8f m 3b m 82 m 13 m 4c m ee m 19 m 31 m c6 m 10 m 4 m cc m e8 m 6c m 61 m 45
m 5d m 5c m 1 m de m e8 m aa m 22 m ef m 7e m 87 m 73 m df m 35 m df m dc m 40 m 6b m 66 m 2 m ec m 16 m 6d m 5e m 96 m ec m
fc m 17 m e1 m 9a m f0 m 4f m ed m e4 m 32 m 8c m 51 m 3 m 73 m b1 m e6 m 27 m a3 m aa m 8c m 88 m 50 m 38 m 65 m a2 2 r a0 m
d0 m 7 m 70 m 5e m b4 m 1b m 2a m a9 m 45 m cf m 41 m b6 m e4 m 3e m b0 m 19 m e9 m 87 2 r a4 m 1a m 62 m 7f m 69 m c9 m c0 m
af m 60 m 3e m b7 m ff m 6 m 94 m 76 m 23 m a8 m c8 m e5 m d2 m 2f m ab m f7 m 84 m 48 m 82 m b2 m 85 m 5 m 4e m 9c m notbusy
02 wcmd 8 m a1 m 0 m \ 0x8a100 
4d m 66 m 27 m f4 m ac m b3 m 4f m ef m 58 m 86 m 3e m f4 m 2a m 99 m b7 m 50 m 60 m 7f m 6 m cc m f m d2 m 21 m a6 m 28 m 60
m 43 m 98 m 79 m 15 m 63 m 9e m 5a m b m 2d m 74 m d4 m af m b0 m d0 m 4e m b3 m b4 m c2 m f1 m f5 m 5c m 9e m f1 m 87 m b5 m
4 m d9 m 85 m a9 m 98 m 76 m 31 m d0 m 1d m 35 m 21 m ee m 99 m f9 m 5 m d9 m 26 m 2 m 6 m 33 m 70 m 10 m 7d m 1d m b m 20 m
1a m d5 m e6 m 77 m 2c m 25 m 4d m e9 m a0 m 9d m 7 m e3 m f1 m 80 m 38 m b0 m 8c m 67 m 55 m c7 m d1 m 5e m c7 m 6c m 15 m 2
m df m 56 m d4 m 75 m 77 m 52 m fe m a9 m 6f m f9 m cc m 9a m 6c m b6 m 44 m 1f m c9 m 80 m f3 m b8 m be m 3e m 55 m 52 m 40 m
7 m c9 m 69 m 2d m 50 m fd m 82 m 7c m cf m 7e m 89 m 4b m be m 81 m be m f7 m 7e m 78 m 83 m dd m 7d m 8e m ea m 7e m 24 m 58
m f1 m fa m 5c m 44 m a5 m 6e m 29 m 6c m c0 m 72 m 93 m 52 m 7c m ed m 36 m a5 m d6 m 79 m d m 5d m 7b m 9d m ce m 61 m fe m
b0 m 71 m 46 m 3a m 52 m a6 m d1 m 96 m 3b m ec m ee m 96 m 1e m 6b m 3c m db m 7e m 1 m 4b m b4 m 5e m 3c m 99 m 65 m d4 m c
m 8 m dd m e m 58 m ac m 95 m 57 m c1 m 21 m 75 m d6 m bb m 6c m a0 m 5a m 97 m 52 m 6e m 79 m 11 m 36 m 49 m ae m b0 m 8a m
45 m 4f m c4 m 19 m 84 m 95 m 73 m 8f m fd m d3 m a8 m 10 m b6 m 8a m fb m 5c m 1b m 3d m bc m df m b7 m 42 m d8 m 59 m 8f m
45 m notbusy
02 wcmd 8 m a2 m 0 m \ 0x8a200 
b6 m 1c m 9d m 7b m a8 m c2 m 7b m 30 m a4 m e0 m 90 m d3 m 34 m a1 m bf m d m bd m e m ea m 5a m de m f1 m 4 m 14 m 7d m c7 m
6f m ab m b3 m ce m 62 m 59 m c7 m 3f m be m e3 m f4 m 2 m 38 m a4 m 4a m 6 m 77 m 48 m 7a m 45 m ab m da m 19 m 8c m b m 85 m
27 m ad m ff m 65 m c8 m 98 m a0 m 79 m 41 m ed m 3e m ce m 84 m 18 m 61 m d3 m 56 m f5 m 2a m 85 m 60 m e1 m 86 m 6c m b1 m 7
m 24 m 13 m 99 m f4 m 59 m ff m 88 m ef m f4 m 77 m d1 m e7 m 7e m 2a m b5 m ff m 83 m 7 m f0 m 1 m e9 m bf m bc m 86 m 9c m
6c m 2f m 70 m 1f m 8b m 9c m e5 m 39 m e1 m 1e m 2e m 5 m a m 3a m 58 m e0 m b7 m 26 m 1a m ea m 78 m c m 8c m b m 84 m d3 m
fd m 8d m ab m 90 m 3e m 46 m d3 m 8c m ec m 3f m cb m 86 m 8 m 51 m b5 m da m 12 m e9 m d3 m b7 m 3f m 0 m 61 m 4a m b1 m ce
m 5a m b3 m c5 m 97 m c7 m 25 m 5c m 66 m 16 m c2 m 31 m 6e m c2 m eb m 46 m a6 m 42 m 82 m 1a m fb m 74 m 87 m 7c m f m 47 m
b5 m 6a m 97 m 55 m 52 m 26 m 83 m 4d m a9 m eb m de m 9b m 85 m 11 m b3 m b8 m fc m 7f m d7 m a m d7 m c3 m 8b m e1 m 2 m ce
m d5 m 5a m 46 m 5c m 8d m 6a m c5 m 32 m 17 m ff m 33 m 27 m 98 m 70 m fc m 8c m 5b m a1 m 84 m d m dc m c7 m 2c m 26 m c7 m
49 m 7f m 50 m 8d m 0 m 93 m da m fd m f7 m c3 m 25 m 45 m 17 m a9 m f m 50 m ea m a7 m aa m 6c m f5 m e1 m 8a m 26 m 42 m
notbusy
02 wcmd 8 m a3 m 0 m \ 0x8a300 
28 m 8 m d3 m ca m c4 m b1 m bb m e4 m 3c m 26 m 95 m 24 m 49 m 31 m de m 62 m ec m ae m 81 m 60 m 8c m bb m ab m 34 m 3c m ff
m d6 m b3 m c4 m f6 m f4 m ec m e6 m b8 m 82 m 50 m 2f m fe m f1 m bb m 19 m 73 m fd m 17 m ed m b1 m 24 m a2 m f5 m ac m 8b m
be m 8d m 91 m 81 m 1 m f0 m 23 m 41 m e5 m 8b m c7 m af m 8e m 62 m 8a m c8 m 34 m 68 m 4d m da m 86 m df m 59 m ea m 3 m 54
m 93 m f7 m 3 m 67 m 72 m e5 m ee m 37 m 2b m af m 42 m 63 m 42 m e m 17 m 93 m 2e m f0 m d m 21 m 1 m 8 m ce m de m 21 m 23 m
70 m 99 m 9f m 8f m 20 m 22 m 9d m e m 6d m 6f m 8c m 8 m 51 m 70 m 3e m 9d m 8c m 41 m 8d m 91 m 81 m 63 m 79 m e4 m 55 m 18
m 85 m e m 13 m a m 36 m 5b m ed m dc m a m 2f m d4 m e9 m 92 m 82 m 60 m e m 35 m 27 m a6 m 2 m dc m 62 m 57 m fa m a2 m 26 m
f9 m f4 m 2b m ce m d5 m 1a m 53 m 11 m e5 m 90 m 92 m 20 m 31 m cf m 7f m 20 m 66 m 58 m 7d m d m 7d m 6a m c0 m 59 m 3a m 43
m 41 m 95 m 87 m 4d m 9d m 31 m 43 m e2 m fb m 87 m a6 m e7 m 1 m a2 m 35 m 30 m 9f m b6 m ac m a9 m c0 m 51 m 16 m 3f m 18 m
af m 94 m eb m c3 m d9 m 3e m 10 m a0 m 80 m 71 m 30 m db m b1 m b0 m c8 m 89 m 83 m bd m d0 m 95 m 4 m 2a m 82 m c6 m a9 m 28
m 5b m 4f m 3e m 55 m bc m 8e m 3 m 70 m f5 m 6a m e m 49 m c m fc m 88 m 23 m 40 m 12 m 78 m dc m 2a m 51 m 91 m 34 m notbusy
02 wcmd 8 m a4 m 0 m \ 0x8a400 
1e m b4 m dc m 1a m f2 m 50 m 3f m f m 83 m 63 m 4 m b3 m 19 m 7e m c6 m eb m d5 m cd m 65 m 94 m cd m 8e m 2a m e1 m ab m 73
m f0 m 16 m a9 m 5c m 56 m c6 m 3f m e0 m 5c m f0 m 23 m 43 m 21 m 84 m 3f m ba m 3b m dc m b1 m 45 m a4 m 58 m 23 m ee m 47 m
4a m d9 m dd m 86 m 83 m fc m 1d m 3b m f6 m c6 m 83 m b1 m 35 m 3 m 4c m 44 m fc m cc m 16 m 68 m 5 m bc m 0 m 57 m 4 m 70 m
67 m 7f m 14 m 30 m 7 m 66 m 31 m 90 m e9 m ed 2 r 73 m c4 m 30 m 55 m af m 35 m d m 39 m 3f m b8 m 6a m b7 m d5 m 59 m c4 m
9c m 16 m 4a m 1d m 6a m 4d m f5 m 14 m 20 m 0 m 3e m 12 m e0 m 24 m 26 m 18 m 28 m a0 m 63 m 49 m 71 m 6d m 4 m 79 m db m b6
m f9 m 87 m 98 m d0 m b7 m a8 m 34 m 6d m c m 95 m d2 m ad m 6c m 44 m e m 33 m 8f m e4 m 25 m ef m e4 m b6 m 5d m d5 m 23 m
50 m 16 m 71 m 1d m ca m fa m 20 m 58 m 6 m 27 m aa m a1 m 74 m b9 m 43 m 65 m 92 m 6b m 5e m 19 m 73 m d7 m 1e m 3c m d2 m 2
m 83 m a2 m bf m b3 m bb m 99 m ec m f5 m e0 m 5f m 9b m d3 m 52 m ae m 52 m 73 m da m 0 m df m 9 m b0 m 4c m be m 72 m 4f m
9d m b7 m 61 m bf m 0 m 6e m f9 m a5 m 4c m 38 m 7 m ed m 6f m 4e m d0 m ac m 3b m 56 m 5 m 23 m a0 m 19 m a8 m 2d m 54 m 3b m
a m 25 m e7 m e3 m c1 m c4 m 6d m 38 m 87 m d9 m c7 m f2 m 53 m f6 m c8 m e2 m ca m 16 m d4 m 1c m 3f m 42 m c6 m fe m 4f m
notbusy
02 wcmd 8 m a5 m 0 m \ 0x8a500 
15 m 60 m 3c m 7c m e4 m aa m 15 m 36 m 39 m 32 m 70 m 83 m fe m 3e m 95 m c0 m 7c m 83 m 1c m 90 m 5e m 10 m 2b m 0 m 49 m 42
m 7d m 4c m 5 m 87 m e1 m 55 m 1 m b6 m 20 m 1f m a8 m 60 m 13 m 4a m 22 m 71 m 65 m 9c m 0 m 87 m 50 m 2c m a9 m 20 m 11 m 9e
m d1 m 40 m f m b8 m a2 m 53 m 41 m 8b m 78 m 96 m ec m d4 m 1c m 8a m 83 m f m 5c m 36 m c3 m 56 m 27 m b5 m d7 m 99 m c1 m
52 m 40 m c0 m 36 m d4 m 5a m 55 m 36 m f2 m 18 m 30 m 86 m 30 m a m 62 m e0 m 86 m 7c m db m 3 m 2 m 23 m f7 m 6e m ce m 97 m
9b m 7e m f4 m d6 m ee m d7 m f4 m de m 3f m f6 m da m 86 m a4 m 3d m 87 m ae m 43 m 62 m 74 m 42 m 1a m 3e m e6 m 2b m 7c m
28 m 37 m bd m e8 m 61 m 1a m 78 2 r 60 m 53 m 6a m bc m 26 m aa m e8 m 92 m e2 m 65 m eb m 98 m e m 79 m e7 m 73 m 21 m 9e m
79 m 5e m e2 m 60 m be m 8e m b8 m ee m 87 m 5f m 68 m b9 m f m 57 m 4f m 1a m dd m 42 m 77 m d8 m 1a m f8 m 82 m dd m cd m 96
m 8b m 60 m d9 m f1 m 1d m 2d m b2 m ef m 8 m b9 m 8d m 2b m f8 m 14 m 2f m 4a m f6 m d8 m 58 m 5f m 42 m c2 m 70 m ac m e8 m
cc m 8 m 51 m ea m 44 m 21 m d8 m a2 m b4 m 16 m 8b m 60 m 4 m b7 m 4e m dc m 4a m 10 m 38 m e7 m c1 m 14 m ba m c m ae m 2f m
46 m 40 m de m 36 m 41 m ca m d1 m 8c m 25 m ac m e m 21 m 3 m 83 m 72 m d2 m 7e m 74 m 54 m 80 m cd m 68 m 2 m 8f m 25 m
notbusy
02 wcmd 8 m a6 m 0 m \ 0x8a600 
b8 m 2 m 94 m f m b8 m 8d m 9c m 13 m a2 m 0 m 95 m 6c m f0 m 1c m 9 m d8 m 90 m 5e m 56 m df m 0 m 59 m b5 m 8d m 8f 2 r cf m
4d m d8 m e7 m e3 m a3 m ae m 2f m c1 m b8 m b0 m 92 m a m 1 m 9e m f2 m f6 2 r 4e m 86 m 0 m 6f m ef m 59 m 7f m ec m b5 m 2d
m c9 m 55 m 79 m e m f3 m 56 m 3a m 33 m a1 m 63 m 90 m 5c m 97 m e4 m ca m df m 4 m 12 m 18 2 r 10 m 88 m 71 m 33 m 7b m 23 m
cb m 8 m ef m 5 m f9 m 4d m 31 m d9 m f2 m 1a m bb m 61 m 3 m d5 m 6f m 12 m c1 m cc m 73 m 4b m 1d m 26 m 45 m 17 m a5 m ec m
11 m 2e m c m 1b m d1 m 60 m 1e m f5 m d0 m 7 m a3 m d1 m a4 m 80 m f9 m 10 m e3 m aa m 82 m 21 m d6 m fc m 96 m ea m 6d m ad
m ef m 5a m 7 m a9 m 75 m 2a m c7 m b1 m 4 m 48 m e m 7e m 83 m fd m 7a m 15 m 7c m a m d0 m 53 m 6d m fa m 66 m 89 m 45 m 75
m bc m c m a6 m ca m 5b m df m 5b m f0 m 1f m 15 m 8c m 24 m ef m 1 m 8b m db m 50 m 80 m 41 m c3 m d3 m dc m 4f m c8 m 1f m
da m d1 m 62 m 6a m 2b m fa m b6 m 1a m 8e m a m 50 m 33 m 17 m de m d1 m 0 m 99 m 8 m a9 m 22 m e8 m 6e m b m 5a m 85 m 92 m
ef m 7f m 3 m c4 m f3 m f5 m b0 m 23 m 3 m a m bd m f4 m a7 m 2f m 56 m 1e m 14 m 4 m a5 m c8 m c4 m 23 m 98 m 77 m 25 m 8 m 0
m 19 m fb m b8 m 2 m cc m 49 m 3a m d2 m 6 m cc m 1c m ac m 86 m 1 m 64 m 79 m d9 m af m 1c m 74 m notbusy
02 wcmd 8 m a7 m 0 m \ 0x8a700 
35 m ed m 76 m c9 m dd m fe m 3d m 7 m 8d m 76 m 99 m 67 m 42 m 1f m 2f m e m 9a m be m 4 m 70 m 95 m 6a m c6 m c m 34 m d7 m
c5 m 53 m db m d1 m 5b m 1 m 64 m 6a m 71 m 75 m 1 m aa m af m 20 m 2 m 10 m 17 m 19 m 90 m 87 m 3 m 36 m 24 m ba m b0 m cc m
c1 m bf m 51 m ca m 2a m 73 m 53 m 2f m 80 m 1 m fa m b m b0 m c m fc m 5 m f8 m f0 m 7c m 49 m d m 1 m c6 m c1 m 67 m 2 m 54
m 36 m 44 m b m 40 m d6 m 43 m 27 m 1 m 7a m 52 m 3 m 42 m 3 m e4 m 5a m 9e m b3 m 0 m d3 m e1 m 5d m 1 m ea m 9a m 8f m 8 m
40 m 2 m ad m 6 m 1 m 86 m a8 m 2b m 20 m 2 m fb m 3b m b6 m 5e m b3 m e8 m 42 m b5 m 3b m b3 m 24 m 7e m e m f7 m 5c m be m
90 m 3 m 99 m 11 m 65 m 10 m 84 m 76 m 8d m 5d m aa m 75 m 22 m b5 m 6e m ce m 60 m e6 m 39 m 79 m 83 m 9b m 56 m 2d m d8 m e8
m 6d m 61 m 7d m 43 m ed m e6 m 5 m b4 m 17 m 59 m aa m 3c m fd m 9c m 23 m 50 m b4 m f2 m e8 m cb m 6 m f4 m f6 m e4 m 2a m
42 m d7 m f m 33 m 4c m 12 m a1 m 8b m 72 m e5 m b m cc m f7 m e7 m 75 m 2 m 31 m d0 m b7 m 55 m c9 m fa m 8d m c6 m 4c m dc m
21 m 3c m 27 m a1 m 39 m a4 m d2 m e m d9 m a7 m 59 m c7 m 13 m 52 m e5 m 24 m 33 m 70 m 49 m 8f m 3c m b8 m 7d m de m 8 m fb
m b9 m a0 m 69 m 17 m 90 m 5d m 92 m e0 m 69 m eb m 38 m 7a m 7 m 36 m 7b m b m 43 m 27 m e8 m 18 m 28 m a6 m notbusy
02 wcmd 8 m a8 m 0 m \ 0x8a800 
f3 m 3a m c2 m cc m 62 m de m 1d m 30 m 45 m 9d m 90 m e7 m 4a m 4c m 8d m 35 m 40 m f5 m b8 m 37 m 5 m d8 m 8b m 6 m 90 m a m
22 m 90 m c9 m 39 m a8 m f6 m 25 m e4 m 54 m 57 m 9b m 6 m 28 m 7d m 4f m 6b m 7a m cf m a2 m b6 m 44 m 34 m ad m f6 m e0 m 31
m 81 m 4d m 49 m e6 m 9d m e7 m 39 m ef m 4 m a2 m a7 m d0 m 2e m 5 m b3 m 9b m aa m 9f m 63 m 8e m a4 m 41 m 70 m 0 m af m b7
m 82 m 64 m ca m 3b m 9b m d1 m c6 m a4 m 74 m 9 m 93 m b1 m 4e m b2 m f0 m 37 m f2 m ce m 70 m 3a m 5b m fe m 94 m 77 m 6e m
28 m bc m b3 m 1e m 93 m a5 m 42 m 15 m 61 m 1a m 80 m 3e m 9f m ed m 4a m 84 m 33 m 1c m f5 m ec m ff m b0 m 1d m 7 m a4 m 81
m 25 m 8b m b2 m 85 m 5b m 81 m 69 m 28 m 21 m 8e m 81 m dc m 5d m f4 m 8a m c9 m 12 m b1 m 37 m 1d m c2 m 38 m ef m f4 m dd m
5d m 6 m 69 m b m d5 m 1c m 17 m b2 m d m 84 m b m 91 m f8 m c8 m a0 m 87 m 45 m f1 m 23 m 31 m 72 m f7 m f4 m f1 m 79 m 8 m
41 m 7e m 3f m de m 31 m c9 m bc m d3 m f9 m 1 m 79 m 27 m 1c m ed m 6d m 85 m 77 m be m 80 m f4 m 4a m 82 m 77 m f2 m fb m b3
m d6 m 8a m 76 m ec m 30 m c2 m b7 m b5 m 88 m da m f4 m 12 m 58 m 43 m 34 m 50 m f3 m ae m 59 m e2 m aa m 59 m 3c m 69 m 89 m
3 m b7 m 4c m 66 m 9e m 28 m cf m 99 m 2 m 61 m 3a m d m 38 m 25 m 2b m 31 m 78 m 9b m 91 m 6e m e8 m 91 m 94 m 92 m b4 m
notbusy
02 wcmd 8 m a9 m 0 m \ 0x8a900 
5d m cc m a3 m 43 m 2d m 28 m 6b m 5c m a8 m 11 m cc m 68 m f9 m f4 m 86 m dc m 4e m 54 m ed m 1a m 98 m 1d m 47 m 67 m c9 m
37 m 6c m c0 m a8 m 40 m c0 m 70 m fa m 62 m 90 m e2 m 6c m 23 m 20 m 43 m 28 m 65 m 76 m 17 m c0 m 7c m 76 m c9 m 28 m 25 m
73 m cf m 65 m 49 m 2a m 1d m 1c m 6b m a0 m ea m e4 m 6c m 39 m c4 m 2b m 3 m 22 m 44 m 52 m e1 m 93 m 99 m d0 m 47 m 34 m b4
m 13 m 39 m b2 m 99 m b2 m 33 m b m b9 m cb m ee m 12 m ac m 6c m 40 m 55 m b1 m c9 m 90 m 53 m 8d m 90 m 26 m b1 m 0 m 69 m
27 m 6f m 81 m 89 m 85 m 92 m ab m ce m 8a m c8 m 29 m ba m ec m d7 m b2 m 5c m 87 m e2 m bf m 68 m 6 m 8 m aa m fa m 3e m 2a
m ca m 39 m 70 m 9 m ff m 70 m fe m ad m 40 m 96 m c4 m 5f m 3 m 1b m d1 m 14 m 9e m b8 m 63 m 7 m 60 m 67 m 53 m 30 m 99 m 3
m 7b m 0 m ca m 3b m 63 m b8 m 11 m e9 m cc m d2 m bd m de m e4 m 71 m 8e m 1a m 90 m 46 m d0 m 25 m 1a m 83 m a0 m 37 m 9c m
c3 m 3f m c9 m 56 m aa m 17 m 3b m 1e m e4 m 29 m a5 m 1f m 59 m e0 m c6 m d9 m 2 m 48 m e2 m a1 m c4 m 41 m e7 m ee m 9a m d2
m b7 m 68 m 72 m c7 m 36 m d4 m d m ee m f2 m 55 m 71 m 20 m 5c m 20 m fa m 6c m 25 m e7 m 75 m 19 m 26 m a2 m 6c m e5 m b m
29 m 97 m bd m 1f m 70 m 8b m a0 m 36 m e4 m d0 m 37 m ad m 65 2 r 1e m f0 m f7 m 78 m 9a m 1c m 13 m 38 m 54 m f4 m 32 m d9 m
ea m notbusy
02 wcmd 8 m aa m 0 m \ 0x8aa00 
c9 m 66 m 60 m aa m 95 m cd m ad m 17 m 30 m 81 m ab m 35 m 44 m b0 m 66 m ec m 72 m a1 m 36 m d5 m fc m 95 m 4 m 5d m 7f m 2a
m 30 m f6 m a8 m c2 m 73 m 34 m ac m b3 m cb m cf m 53 m a2 m a1 m 75 m ac m 37 m ba m 89 m 50 2 r 24 m f8 m 69 m 3b m 28 m c8
m 2 m ca m e0 m 5a m 8c m bd m 7 m dc m 13 m 15 m b5 m 9 m d m d7 m c4 m 79 m 74 m 6 m e9 m a7 m 85 m 8b m 6e m 5e m 21 m 1d m
b5 m ac m c0 m 82 m d3 m a4 m 11 m 6c m e2 m 65 m 3b m 8 m a0 m 76 m 2b m d5 m 49 m ae m 53 m 35 m a8 m 26 m fc m 4a m 48 m c9
m 69 m fa m d9 m 61 m 2f m 55 m 85 m bc m 8 m b9 m 15 m 43 m fa m 43 m 44 m 1a m e9 m 2 m d3 m e9 m b0 m a6 m 91 m e9 m c6 m
89 m 50 m a7 m 3f m 3a m 4b m 43 m c m 64 m 67 m 68 m 57 m 78 m ed m 1d m cc m 61 m da m 9 m 4e m 37 m 56 m bb m 98 m 67 m 4f
m 40 m f m d0 m 1a m 68 m f m 13 m 48 m 4c m e0 m 37 m 98 m d0 m b4 m 10 m a6 m 42 m 57 m b2 m e9 m b6 m 17 m e m 83 m 7 m 1c
m 34 m bb m 90 m 2f m e0 m 20 m 7a m 71 m 46 m 3 m b2 m 55 m 1f m ba m 82 m 10 m 5c m 42 m b1 m 43 m d5 m 1 m 92 m 6d m 3a 2 r
35 m b3 m 95 m d9 m eb m 8d m 6f m 3a m 1e m 12 m d0 m 9b m d4 m d6 m 94 m 47 m 97 m 16 m 7d m 18 m 8b m 61 m 1d m 86 m 89 m
78 m bd m ab m b5 m b0 m e m 9d m 4 m 51 m fc m b m fb m 82 m af m d3 m 75 m ab m 92 m 20 m f9 m 44 m ae m 65 m b m notbusy
02 wcmd 8 m ab m 0 m \ 0x8ab00 
d6 m e6 m f4 m 9 m 40 m 5e m 2d m 15 m d4 m 32 m 4b m 59 m 4f m be m 60 m b5 m ba m 2b m 65 m 77 m 6b m d2 m a7 m aa m 80 m d6
m 47 m c0 m 60 m 7d m a4 m b2 m 53 m 76 m 22 m da m 97 m bd m 20 m 17 m 25 m 79 m ad m 3c m 66 m 8c m fa m 33 m ff m db m 7a m
6e m a6 m d6 m 2f m a4 m 8f m ed m 6e m e5 m 6 m 2c m f9 m 52 m ed m 90 m 6d m 68 m 22 m c4 m f1 m e6 m bb m 42 m 7e m d m 87
m 44 m 16 m 73 m c2 m 11 m 99 m 86 m 6c m 75 m 3 m 9d m ef m bd m 21 m 8d m 6a m 3f m ba m 8 m 36 m 48 m a7 m b9 m 96 m dc m f
m 6e m 39 m 91 m 97 m d5 m aa m 87 m e8 m a5 m 50 m 25 m 2b m 89 m 74 m b2 m a6 m e m 83 m 33 m 6a m f3 m db m c0 m 28 m 74 m
8f m e6 m 65 m b0 m 57 m 3c m f9 m b0 m 5a m 3 m a9 m a2 m 4a m e5 m 6d m da m 92 m 45 m 99 m 7c m 16 m 77 m 2a m 9f m 6 m 69
m 7b m dd m 3c m 38 m a1 m ad m c1 m cf m 9b m ef m 36 m 56 m cb m 6e m 89 m f0 m be m 76 m d3 m 3a m 29 m 68 m 3c m 18 m c4 m
d6 m d0 m da m 99 m 56 m 91 m 24 m b7 m 4f m d1 m a m 90 m 3e m 86 m cb m 9a m cf m b3 m 95 m a1 m 54 m 8b m bc m d8 m 5f m 0
m 91 m a2 m 3c m 8f m 27 m 4e m 73 m 32 m c3 m 45 m 25 m 5f m 79 m 12 m 21 m 62 m a1 m 15 m 49 m c1 m e5 m 47 m 1e m ac m e5 m
55 m 2a m 58 m ee m e1 2 r d1 m 4f m 5 m 9d m e5 m db m fe m 37 m c1 m d2 m 29 m 53 m a6 m f4 m 55 m 81 m f4 m a6 m f m 42 m
notbusy
02 wcmd 8 m ac m 0 m \ 0x8ac00 
6e m 85 m 21 m 12 m fa m c5 m da m 5c m 80 m ee m 52 m 18 m 9f m 90 m 78 m 69 m 3b m 8 m b5 m a2 m 25 m 67 m 41 m 3d m b3 m b4
m 1f m 91 m ec m 2b m 91 m 72 m 3f m ef m d9 m 76 m e2 m 90 m 15 m 29 m dd m e7 m 2d m 6d m 55 m 21 m 4f m b3 m f8 m bc m 4a m
61 m 39 m 92 m fb m fc m 13 m 78 m 5b m 80 m 6a m c6 m 60 m e9 m be m ad m 16 m 91 m c9 m 49 m 27 m b8 m b4 m 39 m 55 m 9f m
9c m 28 m 5 m 8d m e7 m 42 m 2f m 1 m 9a m 26 m 3c m c4 m 99 m 10 m 76 m 9c m 27 m 79 m 77 m 74 m 94 m 6d m 3c m c2 m 64 m d7
m be m df m ff m 34 m d0 m 51 m b6 m 99 m 12 m aa m 80 m 7b m de m f4 m 11 m a9 m 4e m 91 m 94 m df m bf m 12 m 72 m ac m 1d m
95 m 72 m 8b m b2 m 33 m 2f m 73 m eb m 93 m 60 m 9e m 68 m f m 72 m 44 m 9 m c8 m 74 m b6 m 6 m 10 m d2 m c5 m ca m 93 m 65 m
f m 5b m da m b1 m cb m d4 m 0 m a3 m cb m f9 m af m bc m 22 m 15 m d8 m ba m 8 m 63 m 43 m 76 m c3 m a m 18 m 4b m ec m 3e m
f9 m 9a m 37 m 53 m fb m 6f m c8 m 13 m fd m 97 m 1e m 88 m 42 m 34 m e1 m 3d m 8c m ce m eb m 10 m 95 m 7a m dd m e7 m 56 m
49 m 36 m 54 m 3e m 76 m 4d m 52 m 13 m 7e m 55 m d6 m 71 m 7e m e9 m 46 m a2 m e4 m 52 m ea m 15 m d9 m a4 m bc m 7b m fc m
cf m 27 m e7 m 6f m a2 m b m 33 m 4e m 70 m 7d m c5 m 25 m 1c m d2 m 76 m fd m 5e m a m 2c m 4f m a1 m e6 m b1 m d9 m f4 m b7
m 8b m notbusy
02 wcmd 8 m ad m 0 m \ 0x8ad00 
39 m 9f m 9 m 48 m 2e m 25 m 63 m a1 m 19 m fb m eb m d4 m e1 m d5 m e1 m c3 m 13 m f8 m de m 6c m 8f m 2c m fe m 49 m 11 m c
m 85 m c8 m 6e 2 r 98 m a4 m 83 m 60 m 2d m 57 m 13 m 22 m 18 m f8 m 91 m 39 m 75 m 3b m 96 m 32 m d0 m b9 m d4 m 7c m ea m a7
m bd m e1 m df m c0 m 2e m b4 m 2c m 7a m 1e m cd 2 r f m 6e m f6 m 44 m b8 m e5 m b1 m 37 m ef m fd m 91 m 5a m cb m 49 m 69
m 8f m 8 m 1c m 7e m 4a m cf m 39 m d0 m 95 m 83 m f0 m d m 97 m 7e m bf m 9 m c6 m be m c m a0 m dd m a8 m 5f m 8 m a1 m c m
30 m 27 m 8c m 5d m a m 66 m 34 m a9 m d m ec m 43 m ab m 4c m 5 m 3b m 50 m b9 m 14 m 57 m 5e m 43 m c0 m 82 m 57 m fa m 64 m
68 m c3 m 2 m f1 m 54 m 98 m e9 m e6 m 41 m 38 m 6b m ed m ea m e9 m 88 m 80 m 44 m 28 m e9 m c7 m 7b m e0 m e6 m 7d m 39 m f7
m 50 m b7 m 72 m 1a m 92 m f2 m 25 m a7 m b9 m 67 m b m d3 m 36 m b7 m 66 m e5 m 1a m 17 m 21 m 39 m f0 m 3a m e4 m b1 m c m
a0 m 1f m c1 m c7 m 1e m b3 m fd m 50 m a5 m ab m 64 m e2 m cb m 34 m 3b m 66 m e1 m 59 m 79 m ab m db m 1b m f2 m d6 m a1 m
4e m 5a m 62 m 2f m c1 m 3 m 48 m b2 m 59 m ea m 64 m 5b m c6 m 77 m 2b m c1 m 9b m 4a m 80 m 97 m 4a m d9 m a2 m f1 m 44 m c
m 24 m ed m ba m 2 m 46 m ee m 92 m 76 m 9e m 7f m be m f0 m f6 m ce m 8e m c4 m 56 m d4 m 19 m 42 m 1e m 15 m e8 m be m
notbusy
02 wcmd 8 m ae m 0 m \ 0x8ae00 
89 m 34 m 44 m e m 54 m c0 m 7a m 30 m 85 m 1e m 48 m 9b m c2 m 40 m 7 m c8 m a1 m 6a m af m 4b m 20 m 3 m de m c0 m e m aa m
78 m 89 m 81 m 0 m 78 m 45 m 34 m 10 m c6 m 4f m cb m e1 m e0 m 0 m 57 m a4 m 38 m 58 m c9 m 42 m 46 m 4a m 9d m 1e m 80 m bb
m f3 m 9d m 2 m f8 m 73 m b6 m 43 m d9 m e9 m a0 m 14 m f m e m f4 m b3 m 2f m 16 m 5f m 1c m 74 m 4f m df m 2a m e m d5 m fb
m 25 m a6 m e0 m ec m 4c m 9e m 1b m fa m 7c m b6 m e5 m d0 m ba m 68 m 8 m 47 m 7f m 99 m 7d m 4c m 9 m 35 m ab m 74 m 8b m 1
m cf m f6 m 18 m c2 m fd m c1 m e m 45 2 r 3a m 74 m 86 m ae m 1d m 8e m 94 m 2 m 4d m 71 m c3 m 88 m 64 m be m cc m 55 m 22 m
1c m 8c m 86 m 2b m 6a m 2d m 33 m 58 m 1c m af m 95 m a1 m 73 m a4 m 7f m 31 m 33 m 17 m 7a m e7 m 41 m f8 m ce m 24 m 30 m
f2 m a4 m f0 m fa m eb m 2e m 16 m a7 m 6c m b4 m d1 2 r 6 m 55 m fc m ef m a m 67 m f4 m 2 m 8 m f0 m f3 2 r 53 m 52 m d1 m f
m cb m 47 m 2b m 9c m ba m 2f m f0 m d4 m 5e m 8e m 36 m 30 m 94 m 56 m cd m 90 m 1b m b8 m 7f m 9d m c7 m 6 m cf m fa 3 r de
m 81 m dd m be 2 r 38 m 7c m 83 m d5 m e m 18 m 1f m ea m ad m cb m 9f m ea m 2f m f2 m 9b m a8 m 1 m 1f m 80 m 1d m f8 m b7 m
4b m 60 m 6a m 59 m ae m 92 m 49 m fc m 92 m 25 m c3 m 6b m e6 m 51 m 88 m 66 m 19 m cf m 97 m d8 m notbusy
02 wcmd 8 m af m 0 m \ 0x8af00 
fa m 72 m 88 m 9d m 22 m e6 m 6c m 61 m 99 m 59 m 33 m 99 m be m af m 2b m 2e m 43 m 21 m e4 m cd m dd m e4 m 2b m 61 m 5d m
3d m d7 2 r ef m a6 m b3 m 4d m 5f m 76 m de m f8 m 9e m f1 m dc m 1f m d2 m 76 m bb m cf m a8 m f m 7b m 2a m 19 m cb m 51 m
d7 m a4 m 8e m 9c m 82 m b8 m 43 m c1 2 r 9b m e6 m 34 m 45 m d0 m b2 m 88 m 8f m 8e m 69 m 0 m 21 m dd m b2 m 99 m e1 m 5a m
75 m 34 m c6 m db m d7 m 0 m 77 m 92 m 34 m 41 m d1 m f6 m 2e m 64 m fe m fc m ed m b4 m d9 m be m 59 m 25 m 68 m ce m bf m ba
m 3d m 29 m bf m ec m ce m a5 m e5 m 7f m 9d m 6c m 58 m 53 m ce m eb m 78 m 44 m e0 m b6 m 3e m 33 m 2b m a0 m b9 m 2 m 36 m
64 m 1d m 4c m 83 m 9c m 9a m c m 58 m c7 m ea m 88 m f3 m 51 m b6 m 14 m d7 m 84 m 6c m bc m 61 m 10 m ec m 11 m d m 74 m 60
m 2e m 51 m 5 m b4 m 2b m 1f m 50 m fe m f4 m 6c m 42 m 6c m 53 m d m 4c m 2 m e9 m 64 m 9d m 27 m 97 m 2e m aa m 7c m bf m 1a
m 32 m 5d m c6 m cf m a6 m 1e m fd m 37 m df m cf m 6f m a3 m 74 m e m 20 m 71 m b2 m 11 m 98 m eb 3 r 7 m 25 m 74 m 7e m d m
52 m 7b m 80 m 24 m a5 m b5 m 96 m 23 m 3d m 11 m 95 m 2c m 7c m 38 m fd m 94 m 60 m 3a m 23 m c7 m b9 m 3f m 35 m b8 m 4f m 5
m 89 m 6a m 2a m 3d m 63 m f3 m c2 m 8d m ed m 20 m 29 m 4 m e9 m 6c m 9e m 1b m 15 m 0 m f0 m 2f m bc m 94 m e m notbusy
20 wcmd 8 m b0 m 0 m notbusy \ 0x8b000
02 wcmd 8 m b0 m 0 m \ 0x8b000 
a6 m 6f m a1 m 32 m 3f m d3 m 71 m 26 m 46 m ba m 93 m ff m 7 m 19 m 4d m e5 m 2 m 6 m 95 m a4 m b7 m 51 m c1 m 70 m 53 m 5a m
2b m f5 m ca m 18 m 4b m 72 m 33 m f5 m b6 m 4f m ac m 49 m 8d m d5 m 3a m 1f m 5b m 35 m 7 m ba m 11 m e0 m b8 m 35 m bb m 81
m a m 56 m e8 m 96 m c0 m 49 m 6e m db m 18 m cd m f4 m fb m 84 m 2b m 8e m 14 m d6 m 74 m cb m 42 m cb m 4b m e2 m a1 m 23 m
21 m bd m b6 m e8 m ce m 16 m 38 m 24 m 39 m 59 m ca m 85 m 46 m a9 m 6b m 29 m 52 m 77 m fa m e1 m 53 m e5 m c3 m fa m 82 m
2a m 28 m 78 m 81 m 72 m 41 m a m ec m f3 m f5 m fd m 59 m 7b m 5 m e0 m 2e m f8 m a m 46 m a6 m 53 m c3 m e3 m c3 m 7b m b7 m
3f m 90 m bb m 8e m 7e m 6f m 53 m 72 m a8 m bf m f5 m e2 m 99 m 2d m 69 m 68 m 8 m 98 m a m 9d m 49 m 30 m d5 m 5f m 6 m e3 m
4c m 35 m 9d m 41 m ef m c5 m d3 m dc m cf m 65 m 3a m 85 m b m 56 m 3b m 6a m 3 m f8 m 94 m 37 m a8 m 60 m f4 m 8f m 5f m b3
m 1e m 93 m 5a m 6f m bd m 7a m f7 m 8c m a2 m 2b m f m 31 m 98 m 4f m 50 m 1d m 36 m 1c m e5 m 60 m e5 m f4 m e2 m e7 m a8 m
2 m e3 m c3 m 74 m e5 m 4f m f8 m 87 m 75 m 29 m 2a m 71 m c0 m cd m 28 m 7c m b3 m 4e m 14 m 66 m 8d m 7 m 2a m 47 m d4 m b0
m 3c m 9e m 15 m 18 m ee m 22 m 18 m d8 m a3 m c6 m ea m a7 m dc m 9f m ea m cc m ea m 54 m b9 m 63 m e8 m 44 m 8d m 6 m 6f m
notbusy
02 wcmd 8 m b1 m 0 m \ 0x8b100 
f8 m 1 m ff m ed m cd m 62 m d3 m e1 m 6d m f1 m 10 m c9 m f7 m 78 m 3d m e5 m 7f m ad m e0 m ec 2 r 8a m 78 m 6a m d5 m 7f m
d9 m e8 m 19 m 7 m 35 m 1b m dd m 3c m 58 m 27 m 6c m 74 m 16 m f5 m 7d m 48 m 1b m 3d m 11 m cb m aa m 8d m 8e m 16 m bf m 66
m a3 m 87 m 6f m 8a m c m 14 m 36 m ba m e3 m 8a m c m c5 m 46 m 7f m 14 m 37 m 83 m 2d m 49 m 3f m 23 m ca m 10 m fd m b6 m
62 m 3 m 6e m 41 m 2b m 34 m 73 m 35 m 3 m 5d m b8 m 15 m ba m 9f m 81 m 9f m 64 m 2b m 34 m 48 m b6 m 42 m c3 m 65 m 2b m 74
m 9f m 6c m 85 m fa m c8 m 56 m a8 m fb m 3d m 56 m e8 m b6 m 7b m ac m d0 m 99 m d1 m 7f m b4 m 42 m 1f m 5 m d8 m 82 m 58 m
12 m bb m 4f m a5 m 1f m 92 m 2c m f4 m 41 m 2f m fa m f9 m 9d m 2 m 1f m 7f m 28 m ca m e2 m a1 m bc m 51 m 70 m 3c m b8 m 95
m 1a m 1d m 18 m 5 m 69 m 62 m 47 m f2 m 28 m 69 m 6b m b9 m 7a m 1e m c2 m 83 2 r de m be 2 r 27 m 20 m 96 m 2e m 5c m 1f m
13 m 29 m 8d m 7e m 47 m b9 m be m 58 m 39 m d1 m 6b m c1 m a9 m 86 m 88 m f5 m 3c m cf m 6b m 22 m e4 m 6e m 5b m 15 m 54 m
64 m 66 m c9 m b3 m b7 m 4b m 70 m b m 62 m ed m d m 78 m 30 m 88 m 63 m 69 m 81 m b4 m 59 m 3b m 10 m 92 m 96 m 8d m e9 m ae
m ec m ae m 75 m f3 m c9 m a1 m af m 56 m e6 m af m 84 m 5 m 75 m cd m 5e m f9 m 2a m 8c m 67 m c m f2 m 8d m b1 m 8e m 6 m
notbusy
02 wcmd 8 m b2 m 0 m \ 0x8b200 
3 m 1d m e0 m e7 m d3 m 67 m a0 m 36 m f3 m b4 m 15 m 67 m 68 m a3 m d3 m 90 m 11 m bc m fa m b4 m d1 m 82 m de m 7d m 62 m 37
m f9 m 74 m 76 m 49 m d2 m f6 m bf m c1 m fb m b5 m 4a m d6 m 2f m ee m 1 m ab m 25 m 50 m f5 m 82 m a m da m 49 m 29 m 3f m
a4 m 3e m d3 m 97 m 82 m 51 m 5f m e6 m 1b m 6f m cb m 57 m dd m d9 m 25 m 83 m 6f m 51 m dd m f1 m f5 m e5 m cf m 71 m dd m
9c m cf m 7b m 50 m d1 m 48 m 99 m ba m af m b1 m 40 m 4f m 39 m 80 m 93 m 2 m 34 m e4 m 59 m 15 m c3 m 18 m d0 m e5 m 62 m d8
m cf m 65 m 1f m f m 28 m 7d m e m d6 m d3 m 21 m 45 m df m 2b m d1 m a5 m f1 m 97 m c m 57 m ff m f3 m 9a m 7c m 94 m 54 m 45
m a1 m 4d m da m 89 m 39 m 74 m 6e m bd m c2 m f3 m 20 m 6b m 98 m d0 m 89 m 6c m 9f m 51 m 8c m 73 m 67 m c m df m e6 m e8 m
83 m 49 m fb m 54 m ea m b2 m 8d m b2 m dd m 50 m 46 m 54 m 2d m e5 m c9 m 3c m 24 m c9 m 50 m 89 m bc m af m fa m 97 m 3c m
61 m 28 m d9 m 63 m 51 m 76 m 5 m b7 m 81 m ad m 6e m c6 m 63 m ea m a3 m 22 m b m 46 m 2a m 29 m 9c m 4 m 33 m 2e m 32 m 4a m
b5 m 10 m 7d 2 r 8b m 9c m b3 m 50 m 71 m 68 m 3c m 2e m ca m 61 m a8 m bf m f8 m 1b m 75 m 7d m e0 m 13 m 62 m 57 m c m 2b m
9 m 39 m 17 m 43 m 1a m 50 m 3d m e7 m 29 m d8 m 4f m 75 m e4 m db m 7b m 88 m ae m 78 m 1b m 19 m 5e m 3c m aa m 50 m e7 m 64
m notbusy
02 wcmd 8 m b3 m 0 m \ 0x8b300 
a5 m fa m ca m e5 m b3 m 64 m 61 m e8 m d3 m d0 m a2 m 25 m d6 m db m 7d m 8b m ec m 5b m eb m 50 m f6 m 56 m 3f m cc m 1b m
5c m 6c m 75 m 4c m 9d m 48 m 2e m 79 m 7e m 84 m 7b m 99 m 3f m 82 m e7 m a0 m 7 m d9 m 1c m e4 m 59 m ac m c3 m b3 m 7b m e6
m 59 m ab m 90 m af m 53 m 36 m e2 m 51 2 r f5 m e1 m e6 m 75 m fc m 16 m a9 m 98 m f2 m a2 m 33 m a0 m 8a m 59 m f m c4 m 59
m 2b m 15 m 87 m 3e m 82 m 44 m e4 m 90 m ae m e6 m 5b m 98 m 99 m b6 m 3 m 8f m d4 m 71 m be m 62 m 61 m 9 m 92 m d5 m 53 m
e0 m d m b2 m 94 m 9d m 61 m 44 m a9 m a7 m 25 m e3 m 1d m eb m 29 m 35 m 74 m 36 m f m 20 m b7 m a1 m da m 46 m 55 m a3 m 92
m 72 m 8a m e4 m 7 m c5 m 66 m 35 m 91 m 65 m 4 2 r e m 84 m 9b m fc m 20 m 99 m 26 m f9 m b9 m 75 m c9 m 1a m be m 30 m d9 m
9f m 45 m 37 m 4b m a5 m 78 m c6 m 4a m 9e m 2c m f1 m 9e m 74 m 29 m 33 m b4 m b1 m e1 m 7b m 3e m 1a m c5 m 1 m 8f m 5 m 78
m 61 m 10 m 6b m 32 m f2 m d m 5d m 65 m 32 m 8b m a8 m 12 m 5b m d5 m 90 m 8f m cb m d4 m 3b m ec m c m 22 m e2 m cb m c2 m
88 m 87 m 81 m 9d m 7d m dc m 9 m 83 m 12 m 4d m ad m a1 m bc m 89 m f3 m d0 m 8a m 8e m d6 m 68 m e m 46 m c1 m 42 m dd m cd
m 3c m e5 m 34 m 1d m e7 m 9c m b4 m 97 m 61 m b9 m fa m a8 m 25 m 70 m 43 m 9c m bc m dc m c2 m 2a m eb m 2a m e7 m d8 m bc m
notbusy
02 wcmd 8 m b4 m 0 m \ 0x8b400 
e5 m 54 m cd m 70 m 47 m a8 m cd m 93 m f8 m e9 m 8d m 84 m 79 m 5b m 53 m ee m a8 m 19 m af m 83 m c1 m 14 m 2b m a5 m b8 m
da m 8c m 6a m ca m da m 6 m f7 m ef m f8 m 5d m 97 m 4 m e4 m 40 m 53 m 86 m 96 m d7 m e1 m 6e m 28 m ec m a2 m 96 m 5b m 67
m 95 m d m 50 m cb m 75 m 93 m ad m 5a m fa m 4f m d5 m 8b m 22 m 69 m c7 m 29 m 44 m 9c m 35 m a6 m df m 1 m db m b4 m bc m
8a m d7 m c0 m b2 m 11 m 57 m 2c m 5f m 34 m 2b m 34 m bf m b2 m 7c m 56 m 5b m f9 m d1 m f m e8 m 97 m 55 m fc m c5 m b5 m cd
m 41 m 1e 3 r 4a m f2 m 48 m 67 m 29 m bb m 88 m 2a m df m cb m 5 m b0 m 4b m be m 21 m ed m 85 m 7a m d1 m b2 m 56 m 6a m 6e
m 15 m d4 m 13 m 60 m 91 m 9a m 4c m 33 m 6e m ba m 67 m 80 m 45 m fd m 5f m 89 m 5c m 1 m b0 m 6e m 14 m 27 m 88 m 57 m ee m
1d m 7f m 47 m 5a m 8d m 3d m a4 m 33 m 4c m 75 m 21 m 6 m f1 m a0 m 89 m d2 m 26 m 24 m a7 m bc m 28 m e1 m cd m 69 m cb m ad
m 2f m b5 m d7 m 1e m 2 m d4 m 36 m 7 m 4c m 99 m 32 m 45 m f5 m 1e m 7b m 49 m 6f m fa m a0 m e4 m 5 m 8d m ff m 3f m 1 m d3
m 13 m c4 m 11 m 19 m f m 44 m f4 m 33 m 42 m 92 m 7a m 48 m fc m 18 m ca m 37 m b9 m b2 m da m 90 m 2c m 79 m 5 m 1c m 4a m e
m 9 m 30 m 2 m be m d6 m ca m 75 m b3 m c3 m b4 m e3 m 5e m c8 m 2 m f9 m 14 m 73 m 3f m ab m e4 m 77 m 6d m 9d m 78 m notbusy
02 wcmd 8 m b5 m 0 m \ 0x8b500 
7b m e5 m cc m 69 m ea m 99 m eb m c3 m ae m 8a m cf m f8 m 11 m fc m d4 m 4c m 13 m 15 m 5b m ac m d2 m f9 m 6f m 93 m e4 m
ff m 43 m 8e m 63 m 4c m 86 m 74 m 1c m 48 m 6f m 99 m 5f m f4 m 86 m a3 m 52 m af m 6f m a8 m bd m 1e m 49 m f9 m 26 m 47 m
7d m 1f m 7c m d3 m 1b m d2 m 91 m fc m 15 m 84 m 50 m 5c m e8 m be m 4f m cf m e m 1c m a2 m 27 m bd m 52 m 5e m 42 m 15 m 28
m e9 m 68 m 9 m dc 2 r 57 m 8c m f3 m c9 m 37 m dc m 8e m d4 m f9 m ee m b2 m 21 m 8a m e5 m 8a m 94 m b7 m ef m f3 m 5f m 7a
m 4c m fa m 3f m 58 m 80 m c4 m cc m 0 4 r 5 m 43 m ff 3 r 0 2 r 1 m 0 m 3 m 0 m d m 0 m d8 m 2 m 0 2 r 1b m ff 3 r 0 2 r 1 m
0 5 r 58 m 46 m c m 0 m 1 m 0 2 r 5 m 43 m ff 3 r 0 m 80 m 0 2 r 7 m 0 m 1 m 0 m 1a m 0 3 r d8 m 1e m 0 m 8 m 1 m 0 2 r 29 m
1a m ff 3 r 0 m 80 m 0 2 r 88 m 22 m 0 2 r a5 m 4d m ca m 18 m 25 m 30 m bb m 1d m 6d m 13 m 2c m de m d6 m 23 m 7b m 2e m d9
m 1e m 3f m 72 m 1f m cb m 19 m 71 m 17 m 44 m 94 m d6 m 49 m 3c m 9d m 5c m 34 m 60 m be m 31 m 20 m 1e m 69 m fe m da m a0 m
ee m e8 m b9 m 99 m 7f m 5c m 7c m 29 m 99 m fd m af m e5 m 93 m 25 m 3c m d6 m 54 m af m 4d m fa m d7 m 14 m 27 m a0 m ae m
b3 m fe m e9 m notbusy
02 wcmd 8 m b6 m 0 m \ 0x8b600 
23 m 2f m 8a m f2 m 21 m 1f m 9e m e4 m 91 m c5 m b1 m b m ec m b5 m 56 m 3b m fc m 1e m 6f m 93 m 42 m 7e m cb m c8 m fe m 29
m 55 m e5 m cd m 8e m 46 m dc m 8e m d4 m b7 m c2 m 76 m 4d m 2a m 5a m 4d m 76 m 77 m 6 m f8 m 5d m 86 m 90 m 2 m 4a m d6 m
bd m a3 m 40 m 1b m e9 m c8 m cb m cc m c9 m 35 m f6 m cd m 1f m 61 m 22 m 6a m e1 m 53 m 38 m ae m 1a m 34 m 0 m 4d m 33 m ba
m d m 24 m 6a m c0 m 4c m 81 m b1 m ba m f2 m 3e m 3b m f9 m ee m f5 m f7 m 9f m 2b m 49 m 34 m af m 87 m f5 m 52 m b m 69 m
b9 m 4b m d m 98 m 2e m 85 m bb m 55 m b6 m 72 m a8 m 72 m 63 m 7a m cd m 74 m 66 m fc m b6 m e 2 r 8f m f1 m 84 m 63 m b0 m
e4 m b2 m ba m 29 m 70 m 34 m 74 m f0 m 64 m ac m 68 m f7 m 0 m f5 m b0 m 2b m 3d m c6 m 66 m f4 m 5b m de m aa m 2c m ca m ed
m cd m 2b m 51 m 57 m 41 m e m 4d m ee m 4a m f2 m b3 m 4f m 43 m a m 7 m 34 m 47 m de m 63 m 6c m e m 80 m 6c m 95 m 7b m a6
m 84 m d6 m 43 m 1f m b5 m ea m d7 m 42 m 4d m 9 m e1 m 5d m 2 m 4c m 58 m 48 m f2 m 3d m 1f m a6 m f7 m 36 m 1d m 7f m 61 m
8d m 15 m 32 m e7 m e m 20 m e2 m a6 m 66 m 8d m e7 m f4 m 7e m 84 m 67 m e5 m 46 m d5 m 3e m c8 m e2 m a1 m 25 m 7b m db m 25
m 6c m 9b m 3e m 4f m bb m 49 m 81 m 46 m ef m 70 m 30 m cb m f9 m 53 m 72 m 52 m dc m ce m ad m d7 m 64 m b6 m a3 m 2f m bb m
notbusy
02 wcmd 8 m b7 m 0 m \ 0x8b700 
9 m ad m ea m e1 m 9 m c4 m a9 m 97 m 20 m 39 m 75 m 35 m 2b m 87 m 8b m 14 m 5c m 8a m 42 m d8 m 84 m cf m 4c m fd m a7 m 2d
m 8e m 1d m 5d m d9 m 25 m 89 m 8 m 2d m 85 m 2a m 71 m 22 m 87 m 3e m e8 m 5 m ad m d5 m 89 m 42 m 16 m 7a m 38 m 52 m 86 m
19 m 5c m 67 m 9f m 9c m 69 m 94 m e4 m 5b m 8a m b1 m 9 m 80 m 12 m 7 m 9 m 61 m f3 m 7d m e4 m 36 m dd m fd m c9 m 9d m 6e m
75 m af m 65 m 47 m cf m b1 m 1b m 42 m 7 m 24 m 82 m dc m 53 m 1c m 2b m c3 m 90 m 7c m 96 m 17 m eb m 5e m 50 m 89 m e4 m 1
m 86 m ba m a8 m a5 m 7d m 11 m 9e m 6f m b6 m 5d m 0 m ab m c3 m 2a m f3 m 8e m 66 m 7f m 2 m 2e m 87 m 2d m 49 m cc m 15 m
c9 m b m 99 m 9b m 77 m 2b m 4f m c7 m a6 m fd m 4c m 91 m 4a m 16 m db m 47 m 8 m 75 m 2b m f m 15 m 44 m b8 m 35 m c0 m e7 m
19 m 9 m 7d m fa m 87 m 1 m e9 m 23 m 2f m 21 m f2 m 81 m 26 m 87 m 78 m 69 m 76 m eb m fc m c3 m 27 m f5 m 93 m 17 m 65 m 27
m 4b m a9 m 82 m 9b m 44 m 6 m f6 m 1f m f8 m 89 m 32 m 6f m fa m 94 m 92 m ed m ee 2 r 3c m 66 m 9f m 2b m f2 m 8 m 94 m ea m
27 m e6 m 89 m c6 m 6b 2 r 26 m 2e m 48 m 86 m b8 m 43 m 8f m 39 m ba m 76 m fe m f8 m c9 m c m 51 m 1 m fb m e6 m cf m 9a m
48 m d5 m b0 m c0 m a1 m 3d m a9 m 0 m a6 m ad m cb m 3d m 64 m 6 m 94 m 81 m be m 21 m c9 m c7 m 27 m b8 m db m 8c m notbusy
02 wcmd 8 m b8 m 0 m \ 0x8b800 
18 m 8f m 34 m 1a m 92 m 4c m 7f m 88 m df m a1 m 61 m bf m db m e m cc m 68 m 29 m 19 m d2 m e6 m 46 m 92 m f8 m 19 m 41 m 57
m f1 m d4 m af m 90 m 98 m 82 m 85 m cf m 7a m 9a m f7 m c9 m 3d m 55 m 52 m 26 m 6a m fe m 70 m e7 m aa m e6 m da m 47 m 62 m
7c m 2e m 59 m af m 2e m a3 m 7a m bc m 84 m 67 m a m d3 m c4 m d3 m 6b m c0 m 8a m ad m 1f m ff m 8e m b8 m 40 m 6e m 2f m 8a
m 7f m c4 m cc m e4 m dd m 9f m b m 41 m 10 m d9 m f2 m fa m 0 m 25 m c8 m ef m e5 m 7f m 37 m 72 m 4f m 4d m 37 m ea m 2b m
14 m 0 m 40 m 77 m 13 m 9b m 41 m 80 m df m 39 m 32 m 24 m 99 m 62 m c6 m 85 m 72 m 0 m 5 m 9a m eb m 8e m a1 m 7c m f3 m 78 m
7e m e m d2 m 9d m 1c m b m 63 m ff m d7 m 29 m 83 m 74 m d9 m bd m 74 m fc m 11 m ad m d7 m b9 m ca m 65 m 3 m 95 m 22 m 69 m
fd m 66 m 9f m 63 m 76 m ee m 71 m 87 m 97 m 37 m fd m 5f m 72 m f8 m d5 m 1c m 4a m c9 m 1b m 6d m c m 48 m d4 m 1a m 1e m 5e
m c9 m e6 m a0 m 39 m 28 m 54 m a8 m 61 m 5e m ef m 10 m 9f m c1 m bf m a9 m e2 m 56 m 37 m 1 m 28 m 8f m 29 m b3 m d7 m 3f m
6a m c2 m b6 m 9e m dd m 2c m 19 m f2 m 64 m be m e4 m 62 m a5 m ba m f2 m f m d2 m 7e m cf m 14 m c0 m 11 m ed m 20 m 1f m 83
m 63 m 20 m ad m b9 m 8b m ab m 16 m 86 m a2 m 8d m 98 m 1 m 21 m c m 77 m 36 m f3 m ee m c5 m 80 m dc m fc m 43 m fe m 5d m
notbusy
02 wcmd 8 m b9 m 0 m \ 0x8b900 
4 m 9b m 4d m 78 m a7 m a3 m eb m b9 m 28 m 65 m c8 m 51 m 7e m d0 m 21 m 11 m f6 m a6 m 52 m da m 35 m 24 m 87 m 2b m 6a m 31
m d7 m ff m e4 m 58 m 77 m 44 m d5 m eb m 78 m 3e m 96 2 r 8f m 89 m be m 82 m 85 m 65 m e0 m 7e m 5f m 7d m 78 m 4e m 90 m 60
m a7 m 21 m ca m 80 m 7d m 76 m 33 m ed m 12 m 34 m 2 m f3 m 76 m e5 m bf m 14 m 96 m 77 m 3d m 19 m 61 m 63 m 26 m be m 5b m
e5 m 85 m 3 m 36 m b3 m 6f m 13 m bc m ae m 48 m 16 m 68 m 82 m 13 m 68 m 5 m a7 m d1 m be m 5e m 9f m 27 m 68 m 10 m fd m f7
m 20 m d0 m 33 m ca m 4f m 2e m 53 m cb m 8a m d1 m 91 m 9d m d5 m 1a m 9f m b6 m d4 m d5 m 9 m ba m 64 m c8 m cf m 68 m 3 m
de m 50 m d8 m 3a m 2e m cf m ba m eb m 53 m 42 m 7 m 1a m 48 m cb m 2d m bd m 57 m 4a m b2 m 91 m 52 m 57 m 22 m 37 m c4 m fb
m 65 m 9a m 40 m 16 m f7 m a1 m 1b m c6 m 2c m 52 m 71 m cf m 64 m f2 m 5d m 6f m 15 m cc m 50 m c4 m b7 m 3f m 4c m 7e m 62 m
15 m 13 m a5 m 3c m c7 m e9 m 9c m d7 m 9d m 7f m d9 m c7 m bc m e4 m e0 m 5b m b m 1 m fa m ee m 78 m e4 m ea m 5b m f2 m cc
m 36 m 22 m 41 m b7 m dc m bb m 2e m e2 m 14 2 r 42 m 2a m a0 m 28 m 1b m c1 m 45 m d m 21 m 38 m 63 m 43 m fb m 93 m 54 m 71
m 21 m b3 m 81 m 51 m a5 m 8c m e9 m 49 m 82 m f5 m 6a m 86 m 79 m a3 m be m 12 m 65 m 5d m ce m 52 m 8e m a7 m c0 m 56 m 87 m
notbusy
02 wcmd 8 m ba m 0 m \ 0x8ba00 
3a m 18 m b8 m e7 m 35 m 81 m c9 m be m 87 m c0 m bc m 4a m b8 m a9 m 29 m e2 m 75 m 5a m 18 m 97 m 81 m 9e m a0 m 0 m 11 m 71
m 4c m 94 m dd m d5 m ba m 18 m 43 m fa m 74 m 17 m b m 1b m 1 m b5 m 9b m 36 m b6 m 72 m d3 m 9a m 44 m 68 m bb m f3 m 51 m
44 m 7 m 7c m 4c m e6 m 31 m 20 m 4a m 8a m cd m 87 m 5 m 1c m b3 m e3 m fc m 7f m 54 m 0 m 16 m 1f m c m cf m 5f m 79 m 51 m
1d m 35 m 6 m 64 m 48 m d3 m 66 m d4 m 59 m 9e m 20 m 99 m 18 m f4 m 3 m c0 m df m ee m 29 m e7 m 59 m 73 m 35 m 85 m 76 m 13
m 3f m ab m 86 m 1a m 88 m df m 87 m 97 m 6f m 2b m 7 m 56 m 85 m 78 m 67 m 51 m a7 m 62 m c7 m a8 m 7a m c2 m f0 m f1 m 3 m d
m df m 77 m 9d m 6c m c8 m 27 m 57 m 4a m 10 m d m 39 m 36 m 52 m b0 m 48 m e m f m 15 m 46 m 15 m 22 m 17 m 21 m ba m 66 m 21
m c4 m 36 m 7e m 69 m 68 m 39 m 11 2 r 2c m 93 m f4 m 33 m 43 m 32 m 68 m 96 m a3 m ac m d8 m 85 m a m b3 m 83 m 90 m 18 m bc
m a4 m f3 m 93 m f m d3 m f m df m 32 m b1 m f0 m 18 m 6e m 2e m 93 m 57 m df m 0 m 67 m 93 m 1b m 2 m b2 m fb m 30 m fb m 5e
m fd m b1 m 85 m 51 m 91 m 6d m 76 m ff m 54 m 38 m 29 m fb m 35 m a7 m b6 m 30 m cd m ca m 2c m d8 m c m be m 69 m 9b m 86 m
db m 57 m c2 m 77 m eb m 40 m 11 m b2 m a7 m 4f m e6 m a5 m 56 m ed m e0 m 83 m 76 m 40 m ab m ec m 79 m 62 m 88 m 9a m
notbusy
02 wcmd 8 m bb m 0 m \ 0x8bb00 
4f 2 r 7e m a7 m b2 m 52 m 78 m a7 m 60 m 84 m 34 m 54 m 34 m 64 m c4 m 4d m 4b m 9a m 98 m de m 8c m 64 m 37 m 36 m 8f m 69 m
c6 m ed m 11 m 6 m cc m df m 71 m 97 m ed m b m 48 m 83 m cf m 2 m 7c m dc m d7 m 75 2 r 5c m 3f m e8 m dd m a0 m 85 m 32 m d6
m 7c m cc m 50 m 80 m d8 m f7 m e9 m a m d1 m 5d m a7 m 5 m c7 m fa m 36 m 13 m 80 m 6f m 52 m 66 m b2 m 33 m e9 m 68 m f3 m 8
m bd m af m d2 m e9 m 6b m 5e m c8 m 3e m b6 m 1c m 81 m 8c m c3 m cc m 1f m 6 m 26 m d6 m d7 m b4 m 87 m 37 m 72 m 9b m cd m
70 m c8 m ec m 6c m 54 m 42 m 23 m 62 m f0 m 73 m 4a m b4 m d3 m ef m 96 m 40 m f0 m b5 m 75 m 88 m c0 m 81 m da m 5f m f6 m 1
m 8f m b7 m 7d m 9a m a4 m f5 m f8 m db m 2b m b9 m 4e m 9b m c5 m 1d m 2b m a6 m 47 m b0 m 7 m 5 m 6b m 24 m 96 m 80 m 33 m
49 m 77 m 5f m e7 m b1 m 4e m 6a m ce m 55 m 2e m 98 m 65 m fd m 6d m 28 m e0 m 3b m 3c m 87 m d6 m 77 m 47 m f2 m fc m 1d m
f7 m ef m 49 m fb m 7e m ff m 54 m 3 m 52 m a4 m ef m fe m 97 m ee m bf m da m d6 m 26 m 5c m b8 m e m a m 17 m a9 m 30 m f7 m
f8 m 49 m 11 m 6d m d4 m 40 m ad m 30 m bb m ae m f2 m 6b m 91 m de m af m d8 m 80 m 1a m 94 m 95 m b5 m fc m ce m aa m 8b m
b0 m 68 m fc m 3c m a9 m 62 m a2 m 99 m 41 m 2c m 14 m cc m cf m 19 m cc m 99 m 37 m 3 m 17 m 61 m f3 m 1e m c0 m 4b m 2a m
notbusy
02 wcmd 8 m bc m 0 m \ 0x8bc00 
6c m 14 m ea m 59 m 33 m 5c m 12 m d7 m 33 m 6 m bc m 47 m 9e m 84 m 9a m 5e m d7 m 11 m a3 m a m dc m 1b m fe m 14 m 3c m d7
m cf m e4 m 22 m 7 m c6 m 4f m f3 m d3 m 34 m 2a m f1 m 6c m 4d m 7 m da m 2 m 4 m 3e m 2d m 6f m 3e m 42 m f1 m 9 m 8d m 7c m
e6 m 5f m 19 m bb m 4a m 2b m 96 m ff m eb m 82 m 1a m 10 m 5 m 1f m 7 m 28 m c7 m 9f 2 r 54 m f9 m 1e m a1 m bc m e0 m f0 m
55 m 4a m 3b m b9 m 53 m d5 m f4 m c5 m e7 m 8b m aa m 95 m 8f m 1f m aa m 7 m 4d m 9e m db m 7e m c0 m c6 m c0 m 77 m e7 m 91
m 0 m a4 m 86 m 89 m d8 m 50 m 15 m 93 m 48 m 4b m 8c m ff m b1 m 2b m f8 m c3 m 66 m 77 m 9e m 1d m ca m ee m 69 m 82 m 4 m
c5 m eb m 2c m b5 m 20 m 77 m cb m 84 m a4 m f4 m 67 m 60 m 6c m 62 m 2f m 5c m 94 m b9 m b7 m ce m 4c m 7e m 16 m fc m bf m
36 m be m ed m 29 m 4f m a1 m f m b0 m 8f m a m 30 m 11 m 68 m f8 m 6d m 85 m 8f m da m 31 m e4 m 43 m 82 m 13 m ad m 66 m 5c
m c1 m 2a m e m 1a m 11 m bd m ea m f9 m 20 m cb m 3d m 2e m 83 m a3 m 77 m 2d m c9 m 5d m e5 m 51 m bd m 78 m 71 m 58 m 13 m
83 m b4 m 1e m e m 18 m 84 m f7 m 1c m 33 m 4a m a2 m 2 m 65 m 98 m e1 m 35 m f1 m a5 m be m 83 m c7 m 3f m bf m f6 m c2 m 56
m e1 m 7a m 49 m 6 m ef m 63 m 12 m 50 m 70 m 27 m bf m 47 m e4 m 31 m c5 m b m 26 m e7 m ad m a5 m 77 m f4 m 3b m bb m 49 m
notbusy
02 wcmd 8 m bd m 0 m \ 0x8bd00 
a9 m 71 m 1d m 5c m e7 m 4a m e0 m 4c m 88 m d6 m d2 m 7e m 4f m d m 8a m 97 m ab m 55 m 85 m fb m 37 m a2 m e9 m f7 m 3a m 4e
m 1d m 6c m f4 m 92 m 3d m 83 m 67 m ba m dd m 85 m 7a m 79 m 31 m c7 m 94 m d4 m 53 m 1d m 96 m 49 m 8 m e2 m ae m 47 m e2 m
0 m 92 m 5f m b8 m de m 14 m d1 m 6f m 8d m 5c m 46 m 5c m 75 m 59 m 64 m 28 m 2c m fd m 8c m 59 m 69 m 46 m 62 m 9d m 67 m 5
m 21 m d0 m 1c m b1 m ab m 90 m fc m 2e m 7 m d1 m f4 m 44 m 88 m 7f m 5f m bb m 12 m 53 m be m 2 m b6 m e4 m 24 m 3d m b6 m
7d m a4 m c3 m 1f m 95 m 37 m fd m e4 m d m 44 m a m 7c m 2d m 72 m 5d m 55 m 34 m 9f m 80 m f m 9 m 31 m 63 m 85 m 9 m ed m
7a m e3 m 34 m b3 m 30 m 5b m 17 m 8b m 3f m ee m fc m 8f m 38 m 3e 2 r cf m 46 m 74 2 r 4b m ec m cb m 54 m 9 m c7 m d7 m 12
m ca m 1a m b9 m ad m cd m 7b m ab m df m a4 m cd m 1b m a6 m 4b m b4 m 7f m d8 m 5 m ba m 37 m 5f m 23 m a6 m dd m 66 m a m
73 m 47 m d7 m cb m e8 m 17 m 14 m 11 m 88 m 8b m 12 m 33 m 80 m 3e m 6 m de m 79 m 14 m 93 m 39 m 9c m b1 m 55 m 3d m 1e m 89
m 2b m ee m 4b m e1 m 3f m 43 m 96 m d0 m 93 m 8c m 7c m 2c m 93 m e8 m 71 m c5 m 67 m bb m eb m 9b m f4 m f0 m 9e m f m 7c m
aa m 71 m 60 m c4 m ca m 6 m b4 m 53 m 7a m a5 m a6 m fb m 8a m 91 m 6e m 97 m 1d m b m 51 m 22 m b2 m e1 m 1f m c6 m e1 m
notbusy
02 wcmd 8 m be m 0 m \ 0x8be00 
b5 m 37 m 73 m 4f m d5 m ac m b4 m 47 m 67 m 8d m 30 m f3 m 89 m 41 m d3 m 34 m 2 m d2 m 3c m fe m cb m 4c m d5 m 8f m 38 m c2
m e7 m ea m 93 m b4 m 95 m b4 m c8 m c4 m a4 m 3 m ff m c2 m e3 m 99 m 5e m 9b m 4a m df m c1 m 76 m 2d m a9 m a5 m 7c m a6 m
68 m da m 5 m d m 18 m 83 m fe m 99 m 9f m df m dc m c7 m ed m b7 m 14 m b3 m e7 m 5 m 22 m 75 m 32 m d1 m bf m cd m 4e m 60 m
d7 m f9 m cd m e1 m af m 2f m 57 m b9 m a2 m bb m 26 m 9f m 59 m 38 m 96 m af m d7 m 50 m 94 m 6a m 60 m d3 m 5d m 1e m 36 m
b4 m 15 m d2 m 5 m 1 m 9d m 2 m 9b m cb m 32 m 7 m f m 64 m 59 m fe m 88 m 49 m 65 m d2 m 3e m 4a m 50 m 36 m e m 33 m 26 m 57
m fb m ef m dc m 1f m 6 m a5 m 49 m 79 m b5 m 8d m 56 m 10 m 88 m 32 m 20 m b2 m 62 m e6 m c5 m a m 1b m 70 m ca m 16 m e1 m
1b m 7a m 7f m 72 m 16 m 51 m 58 m a1 m 3 m e9 m 9b m d6 m 81 m fd m 22 m 7c m c7 m 71 m d3 m 9e m cc m f8 m b m 7c m 2c m 58
m 57 m b7 m c2 m 5f m 3 m 94 m ca m b9 m 3a m ab m c5 m ab m ce m 21 m 3f m d8 m b3 m 7d m c6 m 61 m ef m 91 m b0 m 79 m df m
11 m 8e m c m ae m 4f m 7b m 42 m 2f m 64 m 8a m 41 m e2 m ef m 7a m 51 m bc m b4 m 6e m cf m c0 m 6a m 98 m f3 m 68 m 74 m e7
m 43 m 85 m e1 m bc m 7e m ce m 6c m 40 m 3e m 2e m 8a m c5 m e m 4a m 9f m 7 m c7 m 2c m 5a m 76 m a4 m 60 m 37 m 22 m b9 m
notbusy
02 wcmd 8 m bf m 0 m \ 0x8bf00 
98 m 62 m 21 m 9f m 2d m 73 m 93 m 40 m cc m 90 m b6 m ce m ed m 43 m 8d m 5a m f m bb m b3 m d3 m c m ec m 7f m cd m b4 m 32
m 5d m 95 m 3a m 8a m 70 m 14 m cf m 14 m 52 m dc m 65 m 9b m 4f m c2 m 14 m 9f m 5b m 74 m fe m 82 m de m b2 m 0 m 39 m 92 m
15 m 18 m 7d m 38 m 13 m a3 m 6b m b0 m 2c m d5 m c9 m 71 m 8f m 2e m b2 m d9 m e2 m ae m e7 m 1b m 69 m db m 41 m fa m 60 m
16 m 85 m 59 m 53 m 78 m 85 m 7f m 1e m 56 m b7 m b1 m d2 m 2f m 67 m 9f m 46 m 45 m f9 m f7 m 79 m 7b m 3 m e3 m 44 m b3 m 99
m 44 m 48 m 7b m aa m 3c m d9 m 56 m 4f m ec m cf m 69 m 3a m 94 m 6 m b8 m f9 m 69 m 16 m 1e m 8f m 9b m 64 m 38 m 9e m e5 m
39 m 52 m a6 m e3 m ef m b9 m 94 m 56 m 24 m 17 m 5 m ef m f8 m 2a m a9 m 87 m 37 m fa m de m fa m 61 m a4 m 4 m b7 m 2e m 92
m 80 m 7d m 28 m 46 m e m c m ca m 4a m 97 m bc m 5f m 56 m 34 m 9e m a7 m c2 m 5e m b6 m a3 m 75 m bc m 45 m bd m 81 m 7a m
1d m 15 m 36 m ce m 19 m 6e m fd m d8 m ff m 50 m 99 m 29 m 48 m 74 m 53 m 46 m e2 m cd m 2d m 14 m e1 m f5 m 61 m 6f m be m 1
m 10 m d9 m 49 m 91 m 24 m 1c m d7 m ad m 20 m e0 m 4 m 5a m 54 m c1 m 97 m 2 m e2 m b2 m 64 m f0 m 2b m a5 m eb m db m 4f m
cd m 29 m 1e m a9 m 98 m d7 m bc m f6 m 46 m 99 m af m e m 60 m 71 m e5 m 2b m 4b m be m d5 m b8 m 7b m e1 m ca m 85 m 3a m 74
m 5c m notbusy
20 wcmd 8 m c0 m 0 m notbusy \ 0x8c000
02 wcmd 8 m c0 m 0 m \ 0x8c000 
67 m 39 m 71 m 81 m 30 m 60 m 80 m fa m 74 m ea m 73 m 39 m 29 m d0 m 25 m e1 m 44 m 3a m 34 m eb m c8 m 57 m 62 m f3 m 2f m
46 m bf m 1d m cf m 79 m 18 m be m 15 m 7 m 6d m eb m 99 m 3d m 45 m da m 2c m 67 m 3a m b5 m 56 m bb m ae m 5 m 82 m 3e m 7a
m be m b6 m fa m 16 m b4 m 33 m b6 m a7 m 39 m 11 m 7c m 82 m b5 m 62 m e4 m a m e1 m 3a m a m f9 m 38 m 25 m 84 m 5e m 4c m
94 m c2 m 49 m 80 m 89 m e3 m 7 m c m af m 4d m f9 m f7 m 10 m 12 m 26 m 5d m c8 m f3 m 51 m e5 m c9 m 75 m 26 m b8 m a8 m 6e
m 9f m 43 m 16 m 6c m 56 m b8 m ef m a9 m ef m c6 m b5 m a0 m 3 m ab m f7 m aa m 74 m a m 7f m eb m 17 m 4a m 49 m 8b m c4 m
8b m 20 m 86 m b6 m 47 m 11 m 30 m 66 m da m 32 m b9 m 90 m 79 m 48 m 24 m 9b m ae m b9 m 7d m b3 m cf m ab m 1e m ac m a5 m
f6 m bc m 7c m 78 m b2 m 4d m 45 m 69 m 3 m e8 m cf m e4 m ca m 9a m 56 m 21 m 49 m 9a m 9d m 81 m ae m 25 m 61 m 28 m 5b m 9b
m b4 m ef m b6 m db m 22 m f8 m a3 m 59 m 8d m 83 m b m 54 m 89 m 79 m a m 6f m 18 m cc m e5 m 66 m 90 m 32 m 64 m 7b m 1d m
42 m 18 m 28 m 25 m ae m 45 m 2 m 60 m 8a m 7 m a5 m e m 6c m a4 m a7 m d m f8 m cf m ac m 59 m 1d m d4 m 17 m 2c m ab m fd m
cc m 83 m ed m 6 m d m a2 m a0 m 1c m d4 m a8 m 50 m 2f m 9 m 4f m 6b m 49 m 2e m b7 m b9 m d8 m b0 m 4e m a9 m 75 m 84 m f4 m
10 m notbusy
02 wcmd 8 m c1 m 0 m \ 0x8c100 
9e m e8 m 8e m b9 m 8c m 43 m 81 m 4 m f3 m 33 m b9 m 4d m 74 m cd m 2e m e m 44 m 3e m 1e m 68 m 5d m 84 m bb m 4c m 5a m 52
m e m b3 m 7c m e2 m ff m 6d m b0 m c7 m eb m 6c m a5 m d m 37 m 7 m 21 m cd m b3 m 1e m 74 m c0 m d1 m c0 m 72 m f m 80 m a m
86 m de m 7b m 76 m b5 m 68 m a6 m d9 m 8e m 98 m ff m 6e m 50 m f4 m 88 m 45 m 99 m 90 m 2d m a9 m 2 m f8 m 7f m 52 m a3 m e7
m 6c m 1a m 6b m b8 m 17 m e0 m 5d m de m 47 m 98 m c m 39 m 4d m 4 m 44 m 9a m 4d m b4 m 31 m 56 m ed m cb m 2e m d4 m ad m
cb m ab m 10 m 78 m 67 m 7 m 13 m 45 m 76 m dc m 35 m a m 18 m a2 m 21 m 38 m 3d m f9 m 45 m db m 1 m 5b m 72 m 4b m 39 m b5 m
fe m 27 m b2 m 6e m 72 m 25 m 8b m 5a m 7 m 87 m 89 m 23 m 16 m 64 m 18 m d0 m b9 m 88 m 5 m a6 m 15 m e8 m 90 m a9 m d2 m 89
m cc m d8 m a2 m d6 m c4 m 4d m c6 m c5 m d1 m 49 m 2 m 7a m 82 m c1 m 7b m 65 m 3b m 2c m 11 m 19 m cf m a6 m e2 m a1 m e9 m
0 m f2 m f0 m af m c2 m 78 m c1 m b5 m 20 m c9 m 88 m a4 m 24 m 72 m 87 m 86 m f2 m b2 m f4 m 71 m 48 m 21 m ba m 68 m 56 m bb
m 7a m 58 m 4e m eb m 5a m 16 m a4 m c3 m b9 m db m 3e m d1 m 4e m 80 m c0 m 34 m ba m b6 m 9a m e7 m 2d m 8c m ca m 94 m e4 m
39 m e6 m f4 m 59 m 4c m 3 m 42 m bb m fa m 79 m bd m ae m c3 m 81 m 9 m 66 m 0 m 84 m 1d m 5b m 9c m 8c m a5 m 82 m 7b m
notbusy
02 wcmd 8 m c2 m 0 m \ 0x8c200 
87 m e0 m 2e m fc m 2d m 67 m 41 m d8 m 94 m be m 16 m e2 m c0 m bb m 15 m 97 m d0 m dc m 83 m b4 m 7a m c5 m 42 m 62 m be m
20 m 68 m a8 m 24 m 28 m e4 m c2 m c9 m d4 m fe m d m 37 m ec 2 r df m d4 m f2 m 5a m 21 m e1 m cb m fb m 45 m 4 m 76 m 66 m
cd m 14 m 96 m a9 m c6 m eb m 3c m 2e m 71 m 27 m 7 m 34 m fe m 2d m 6e m e8 m 1c m 66 m ab m f7 m 1c m d5 m 47 m d0 m 19 m 4a
m a4 m ab m 61 m 3 m 5f m 8c m 86 m 2c m a0 m c4 m 82 m 98 m ca m d7 m 1a m 9d m 9b m 7f m c2 m df m 83 m 9c m 67 m 43 m 1a m
6a m bf m ed m fa m 48 m bb m ae m 66 m e9 m 1a m a0 m 4 m 22 m d1 m a5 m 12 m 8c m 70 m e0 m 95 m 66 m 6b m e8 m cf m e3 m 68
2 r 1d m 5c m de m 3f m 19 m 46 m 24 m fe m 5c m 7 m 54 m ff m 71 m 96 m 6c m 51 m 4a m 69 m 33 m ee m 30 m 67 m 2e m 19 m d4
m 72 m 83 m e2 m d9 m 4f m 1d m 44 m 15 m 51 m e4 m 96 m 77 m a3 m 4e m 9e m 84 m a6 m 6d m 4d m 76 m c8 m 10 m a7 m c2 m 4f m
95 m 72 m 2f m 65 m ed m 4c m 5e m dc m aa m cd m 3a m 13 m b4 m 3e m 6b m 25 m 94 m fa m b2 m 9 m fe m 2f m 66 m f8 m 8f m 9b
m 2d m 67 m 47 m f0 m 8a m 74 m 99 m 10 m 33 m 0 m b0 m 63 m 4d m 99 m 19 m 58 m aa m b3 m e6 m f6 m 7e m a8 m ba m 5b m 38 m
98 m 23 m e8 m 30 m 39 m 52 m c9 m ec m 12 m 11 m 14 m 31 m d3 m 43 m d4 m b4 m 27 m bf m 53 m b8 m 56 m 2e m a9 m 2 m f5 m 9b
m notbusy
02 wcmd 8 m c3 m 0 m \ 0x8c300 
4c m 85 m 30 m 36 m 7a m 3b m 4e m fe m 8a m 3c m a6 m ef m 7d m 53 m 15 m 83 m bb m 65 m 91 m ce m 68 m 41 m 7a 2 r 30 m 7 m
36 m 1b m fa m 6b m 75 m 2c m 57 m 4e m 87 m f m d9 m c9 m 38 m 95 m 3d m 2b m 6f m 77 m 7c m 1f m 7d m 25 m ac m 32 m 15 m 6e
m 59 m 9b m af m 2b m ec m 5d m 5 m a2 m d2 m d0 m 10 m 2d m 7d m 4b m 55 m 4d m b0 m 47 m 68 m 65 m 70 m a9 m 22 m 1 m f5 m
13 m fe m a8 m 23 m 20 m 65 m 19 m bb m d2 m 2f m b2 m 53 m fc m fe m 45 m 84 m 9b m 1b m ee m 54 m de m c5 m 99 m 3b m 22 m
81 m 76 m 7a m 65 m ea m 79 m fc m 19 m c8 m ca m af m c2 m cf m 2c m 74 m ad m da m 9c m 2 m 99 m fa m 8 m 38 m f3 m d6 m d2
m 99 m ea m 4a m ab m 6d m 2a m b5 m c9 m ee m 10 m 95 m ab m 2d m 8a m 5f m e2 m d0 m 7b m 3d m 6e m 15 m c0 m 5e m c7 m 8a m
aa m 4d m b9 m 55 m 72 m b3 m c9 m 9d m ff m a3 m 60 m 53 m c8 m 4 m 0 m 59 m 35 m 7d m e8 m 80 m b4 m 33 m c0 m 45 m 81 m d5
m 26 m a9 m e3 m 88 m 97 m b9 m 9c m c0 m 1e m ff m fc m ba m 9 m 1d m 3c m c1 m e5 m 9f m 4d m ea m 11 m a6 m f7 m 46 m 3 m
8a m 49 m 60 m 17 m c8 m 58 m 8f m 7b m 95 m d m d7 m d0 m 2b m c2 m fc m b8 m 8e m a5 m 52 m fd m 18 m b1 m 47 m 66 m 1f m 53
m 9d m 57 m 9f m 1b m 98 m c4 m b8 m 5f m 8b m 9e m f3 m 65 m a4 m e0 m ce m 37 m 85 m b9 m c9 m a3 m c5 m f1 m 88 m 39 m 68 m
e6 m notbusy
02 wcmd 8 m c4 m 0 m \ 0x8c400 
d1 m 51 m a1 m 16 m 4d m 8e m f0 m d2 m 27 m 8c m c8 m b9 m ca m 93 m 3e m 84 m e6 m 6 m 15 m 9c m b5 m b8 m 87 m 7c m 23 m 31
m d3 m 38 m 9d m 54 m 5a m 3c m ce m c9 m ae m cc m c8 m ff m ac m b3 m 5f m 49 m d3 m 93 m 44 m 6d m ad m 21 m d3 m 22 m 1 m
78 m dd m ce m 6d m 8c m 43 m 4d m 71 m 7a m 3f m 90 m 11 m c3 m 93 m 43 m c4 m 8c m 22 m 8b m 6d m 72 m 9e m 30 m b8 m 28 m
b8 m b m 24 m 3e m a6 m 6f m 1 m ea m 47 m e4 m 8c m 1e m e4 m 10 m 14 m ef m 38 m f7 m 72 m 96 m ae m a9 m 75 m 6f m 6a m 90
m f m 72 m 58 m e m 89 m d9 m bf m 20 m 8c m 2d m 39 m cc m c7 m d1 m 73 m 1c m be m a8 m 80 m 24 m f4 m 44 m dc m e8 2 r 61 m
ae m 61 m 39 m ce m 54 m 90 m 63 m 27 m 8 m e0 m 65 m 64 m 87 m 67 m 97 m b m 8 m 20 m b5 m 69 m d5 m 6 m 87 m b5 m 53 m a1 m
b5 m 9c m 35 m 16 m 59 m b5 m d7 m f m e8 m 34 m af m 36 m 4e m ba m f1 m f8 m 2a m ac m a3 m f3 m 41 m 37 m 80 m c7 m 6b m b5
m 80 m a m 62 m 8e m df m c4 m 52 m df m 44 m 46 m 6 m 38 m 6d m c2 m e m 4 m 2c m ed m 16 m 68 m 24 m a5 m ad m ec m f8 m 69
m 3 m 7c m 68 m b5 m c3 m 35 m 32 m 40 m 66 m e1 m e9 m e1 m 22 m 1b m f0 m 56 m cc m 7a m f0 m f1 m 48 m 3c m fe m c3 m 20 m
7a m 75 m 2 m c8 m 72 m 13 m 7c m 30 m 66 m 0 m 13 m ee m 18 m cd m 7b m 70 m 16 m d3 m 86 m 15 m 4e m ef m 9 m f5 m 35 m
notbusy
02 wcmd 8 m c5 m 0 m \ 0x8c500 
31 m 5f m 49 m 53 m a5 m 36 m c3 m 1 m 24 m f m 2b m 27 m 1b m 94 m ea m cb m 3 m 6a m c m 5f m ea m 6a m 3e m 6a m db m 38 m
2c m b4 m 30 m 2c m 7a m 33 m 2d m bc m 8c m 9a m 9e m 97 m 4b m fc m ab m 62 m 3 m 28 m 26 m 16 m 3a m 6d m c5 m e9 m d0 m 6b
m 28 m b m 1e m f m 45 m dc m 1c m 5c m 96 m e2 m 82 m 44 m 81 m 99 m b2 m e m a6 m c3 m 30 m 53 m e2 m 53 m f2 m a6 m 8c m 7f
m 6 m d3 m a m ae m 76 m b6 m a8 m 0 m 7a m af m 28 m 52 m 35 m 12 m a0 m d9 m ac m bb m 20 m 3e m ea m 52 m 6c m 1b m 7d m d0
m 2d m 6c m 6f m 93 m 6 m 85 m dc m 3c m 5a m e0 m 55 m 91 m c8 m 7f m ae m 83 m e m 2e m 6b m 84 m 48 m 23 m 22 m c8 m 9b m
27 m 20 m 22 m 7 m 25 m b9 m 26 m 48 m 39 m fc m 8c m e6 m 5b m 33 m 82 m 9b m ca m d1 m 58 m e3 m 30 m eb m af m a5 m 69 m f
m c6 m 73 m 36 m 6a m b3 m ab m 8e m 5 m 61 m 25 m 2d m 50 m 9f m 86 m 5c m 17 m 49 m f6 m 31 m 1d m c4 m 82 m 2d m 72 m 1f m
21 m 97 m 7 m 89 m 42 m b5 m ba m 5a m 46 m bd m 80 m bd m bb m 55 m 39 m 7f m 54 m 92 m c2 m f m 72 m 63 m 70 m c4 m bb m 7b
m f1 m 86 m 3 m 19 m 32 m c1 m bd m 78 m 90 m f m f1 m e0 m f9 m 3b m 38 m eb m fb m 2f m cf m 3c m f8 m f5 m 58 m 76 m da m
e1 m 1f m 3c m 61 m 22 m 88 m b8 m e3 m f0 m 7a m ad m 1d m 24 m 71 m f7 m 6e m c0 m 38 m 1e m dd m 1c m 7a m 57 m a1 m 6c m
notbusy
02 wcmd 8 m c6 m 0 m \ 0x8c600 
33 m 2a m f4 m 87 m ef m eb m 43 m 26 m e7 m a2 m 32 m 69 m 8f m b8 m 22 m 3d m f3 m f6 m 83 m 5c m 5 m c m f0 m 10 m 77 m ff
m 47 m ba m 4a m c6 m a4 m 15 m bc m 5d m 74 m 8 m ea m 29 m e6 m 6f m 12 m 92 m e0 m 47 m 62 m 9b m a0 m 66 m 21 m cd m c m
54 m 6 m b8 m f7 m 77 m 21 m f4 m bf m fb m 6c m 6e m 62 m f0 m 67 m 9e m e9 m 8a m 73 m a4 m 10 m d0 m 5a m af m d3 m b m bf
m 52 m 7a m 0 m 4f m 84 m e8 m f3 m c5 m 46 m 85 m 7b m 3d m 8c m d5 m 4c m 46 m 45 m a4 m 1d m 55 m 77 m d8 m 55 m 29 m e7 m
d1 m 81 m 72 m 4d m 89 m d0 m 30 m 1a m df m 35 m 8 m 94 m 24 m 93 m 59 m 46 m d7 m 25 m c0 m 99 m 3b m e4 m 7c m ff m bd m 62
m df m 26 m 81 m c3 m 5c m 82 m 79 m d2 m bb m 83 m 25 m 1d m f1 m 6c m a7 m 4 m e3 m f3 m ae m 5c m ee m a6 m 77 m dc m 2d m
6a m d1 m cd m 44 m 77 m bd m b8 m c2 m fd m ba m 41 m 71 m 6e m 88 m 39 m 12 m 45 m cf m d7 m 27 m f0 m e8 m aa m b6 m b0 m
df m a1 m 59 m f6 m 9 m 52 m c9 m bd m 3b m 95 m 68 m 7f m 64 m bd m 9a m 82 m 53 m 21 m e8 m 17 m 65 m 7 m d3 m 8b m e m 23 m
2 m 58 m 2b m 7f m 2 m 58 m 75 m 59 m 87 m 79 m 9 m c m 3a m 2a m 2d m 65 m 4c m f0 m ab m 25 m b2 m a3 m 95 m d5 m f5 m 84 m
aa m 1c m 2a m 87 m 53 m 87 m 2e m 20 m 1a m 86 m 43 m a8 m ae m fb m 48 m 60 m 1a m 4e m d8 m c5 m 97 m 8 m 75 m 9f m 24 m f1
m notbusy
02 wcmd 8 m c7 m 0 m \ 0x8c700 
30 m 21 m 4d m 61 m e7 m ef m 76 m 2f m f1 m de m 46 m 6 m 62 m 6e m 37 m ea m 7b m 84 m d8 m a9 m 1d m f m 75 m c m 71 m 94 m
6c m e8 m 62 m 5e m 68 m 9f m 85 m 43 m 50 m 1f m 73 m ed m ad m 9e m cb m a1 m 9c m 1c m a1 m 2d m 96 m 19 m a6 m 79 m 4d m
59 m 7d m ec m f m 65 m a4 m 3d m b9 m f3 m 9f m 26 m 36 m 23 m c6 m df m f7 m 22 m 81 m 71 m e6 m a2 m f4 m d6 m be m e4 m a1
m 1a m 35 m e9 m 2c m 8e m 44 m 13 m 42 m 20 m ee m 11 m 99 m 23 m ae m df m 2b m 4a m c9 m 30 m 1a m 10 m 93 m 45 m 36 m 24 m
a1 m 53 m d0 m 56 m 7a m 58 m c6 m da m ad m b9 m 3f m 7c m ea m 3b m 2e m 84 m c5 m f2 m 73 m 5e m 93 m ee m c9 m 67 m 42 m
63 m fb m 36 m ad m 7e m e m 82 m f0 m 4c m a4 m a0 m 58 m ae m 60 m d6 m 1c m 0 m 76 m b0 m 5 m 82 m 14 m 13 m a7 m 74 m a2 m
88 m bb m 9a m bf m b4 m c9 m c1 m 91 m 38 m 74 m 6 m d2 m 7d m 1a m 57 m 4d m 9d m 81 m a6 m c2 m df m 9d m 44 m 7a m ac m 1c
m b0 m 58 m a3 m 47 m 18 m e9 m ad m f0 m ec m 6d m ae m b8 m 7f m 20 m 33 m 3c m a7 m d 2 r 74 m bd m 24 m 22 m fe m 1a m 65
m ec m cd m 9f m f4 m c1 m 9e m f0 m a3 m b0 m 9f m b4 m 36 m 23 m f7 m e4 m d5 m 6 m 74 m 6a 2 r b9 2 r 3f m 11 m ec m dd m c
m 43 m db m 2f m 5e m 94 m b6 m 33 m 71 m 1d m 70 m bb m dd m 50 m c2 m 27 m d5 m 67 m a7 m 9a m a8 m 5f m fb m 5 m 49 m
notbusy
02 wcmd 8 m c8 m 0 m \ 0x8c800 
c1 m 54 m 5d m 8 m 39 m b9 m 1b m 1c m 6a m b m 6e m ec m 4f m 6d m 49 m 4e m e0 m f m d9 m 45 m 84 m 8d m 77 m d7 m 6e m ef m
1b m 2f m 2 m ae m 54 m 79 m 82 m 76 m 59 m 76 m 59 m 67 m 38 m ec m 6e m 8b m d9 m 1a m fa m 0 m e2 m 2c m 23 m d4 m 48 m a3
m eb m 57 m 6e m ac m d1 m 7d m 65 m 74 m 52 m d1 m b6 m df m 9b m 9e m 52 m 6f m e4 m 2b m 48 m 62 m a1 m 3f m 97 m 5e m d5 m
f5 m e1 m f8 m f2 m 8d m f1 m 65 m f1 m 4a m 56 m 77 m 25 m b4 m c4 m 23 m ce m 33 m b5 m d9 m ab m b4 m c8 m 4d m ee m 3 m 15
m f4 m b5 m cd m dd m 98 m 50 m 2 m 4a m bb m cc m a7 m 70 m ae m 50 m ce m 5d m 92 m 3b m 45 m d m a5 m f5 m e1 m fd m 8c m
ba m a m b3 m a6 m f4 m 3b m aa m 82 m c6 m 85 m 8 m bd m c6 m 22 m b9 m 6 m 8d m aa m 93 m fd m 52 m c1 m b m 26 m 62 m 6b m
1e m 47 m 4b m 9f m 74 m 70 m 1d m df m 87 m 3e m 36 m 49 m 2d m 4c m de m 62 m 14 m fe m c5 m d8 m 2f m 5b m 40 m 9a m 13 m
2b m 1c m 52 m 3f m 13 m b m a7 m 56 m 39 m ed m 52 m 36 m 5c m 65 m b7 m 65 m b8 m 3d m de m a6 m c8 m d1 m 81 m e4 m 77 m f7
m c m 59 m 54 m 5c m 4d m b3 m 1e m e4 m 11 m e1 m 7 m e7 m e0 m b m ac m ca m 4b m 18 m 48 m fe m 59 m c4 m 50 m 2 2 r b9 m
d4 m 60 m c2 m d1 m aa m f5 m 52 m a1 m c0 m 61 m 89 m 6c m 2 m a7 m a2 m 86 m ac m 51 m fa m 8c m 2a m fb m 17 m 4c m db m
notbusy
02 wcmd 8 m c9 m 0 m \ 0x8c900 
2a m d4 m 96 m da m 2 m 2c m 44 m 34 m c0 m 8d m 3a m de m e2 m 83 m 29 m e5 m bc m 31 m 12 m fc m 99 m 6d m 21 m 84 m 8e m bd
m 69 m da m 8e m e9 m a2 m cd m f2 m 3c m 17 m 4a m 97 m 1b m 43 m b4 m c0 m 7f m 84 m 11 m e3 m f4 m d m 2c m 29 m 11 m 6e m
ed m f0 m 29 m 94 m af m 5e m 45 m 3d m 5f m 85 m ac m 54 m 53 m 72 m f2 m 72 m 80 m 84 m 1f m 71 m 52 m 9a m 20 m c4 m e3 m
6c m 32 m d5 m f0 m a0 m 1e m c4 m 76 m ed m f6 m 64 m 84 m 52 m 3d m a2 m cf m 55 m 46 m f0 2 r fc m 89 m bc m 32 m fe m a8 m
53 m af m 30 m bc m c2 m 39 m 47 m ff m 90 m a9 m c5 m 5b m a0 m e m a2 m 68 m ea m 3f m 91 m e9 m bd m b9 m f6 m 65 m 59 m b8
m 60 m 61 m 99 m 96 m 7d m 20 m d7 m 5 m 6b m 24 m 69 m 3c m 79 m 38 m 92 m 33 m 62 m 0 m 88 m 19 m da m 2c m 8f m a0 m 4 m d4
m b3 m 5c m 6 m 67 m 5b m 72 m 34 m 6b m 3e m 88 m a5 m c4 m cf m d m 22 m d9 m 38 m 8a m 4b m db m ba m b m d m 1b m da m c5
m 52 m be m bb m 44 m b7 m bd m 82 m 48 m 53 m 50 m 4d m 4c m 38 m 3f m 51 m 9e m 31 m fe m d3 m ed m 7 m 1d m 78 m d8 m 47 m
79 m 2 m 7b m b6 m 7b m 2f m f4 m c6 m db m ab m f3 m 15 m 71 m 19 m e7 m 7a m 13 m 5c m 65 m 23 m 85 m 2a m a9 m 2d m ad m 28
m d8 m 9d m 25 m e4 m 7d m 4f m 58 m 9c m dd m a6 m 36 m db m 54 m 17 m fe m 3e m 50 m 1d m 91 m 14 m ab m 18 m 34 m 61 m cf m
notbusy
02 wcmd 8 m ca m 0 m \ 0x8ca00 
56 m 75 m 6b m dd m 84 m e8 m 2e m 7a m ef m 1 m 72 m cb m 33 m 65 m d0 m 2c m 93 m ba m ab m 7f m 88 m a9 m 71 m 13 m cd m d5
m dc m 23 m 4f m 2b m 24 m 1d m 62 m 86 m 33 m c3 m fa m 81 m 63 m 32 m fd m e5 m 95 m 20 m f2 m 40 m 48 m 22 m f7 m df m 41 m
c m 5e m 17 m 26 m 39 m a4 m 7a m 1b m 71 m 89 m b2 m 57 m bb m d0 m 8d m 52 m e0 2 r 5b m 1 m 43 m 2e m dc m 78 m 4f m 85 m
3b m 3a m c2 m 2f m 71 m 1 m 4e m 15 m b5 m 2b m 9c m a2 m e2 m 64 m 9f m 68 m f7 m ac m 40 m bf m b5 m 71 m 8e m 41 m b m d6
m dc m 5e m 16 m 96 m 8d m 3c m e4 m bf m f3 m 7f m c0 m 94 m 96 m cd m 10 m 83 m f7 m a4 m 6d m e7 m b7 m 9c m e8 m b8 m 2c m
b8 m 6a m 77 m dd m 82 m bb m 8 m 8b m 1f m ae m b8 m d1 m 10 m df m 9c m 75 m ae m ac m f1 m 37 m 5f m f9 m 34 m bd m 64 m 8a
m f9 m 16 m 43 m ad m d7 m e0 m 93 m d7 m 4f m a0 m 4e m 5d m 50 m b4 m 8f m 1f m 7d m a9 m 12 m 58 m 1b m da m d9 m 62 m 4d m
bf m 3d m 39 m 8b m e1 m cb m 82 m a m c8 m c7 m 5f m c2 m 5 m be m 3a m a4 m aa m 40 m 11 m 60 m 69 m a m 76 m 96 m 32 m 66 m
7b m 77 m f1 m a4 m 3e m 12 m a6 m 2e m eb m 3e m 79 m 6c m e1 m 9f m d5 m b9 m 7 m 74 m 3b m a9 m cc m 7b m d8 m 7c m aa m 7b
m c1 m 13 m 9b m 89 m f0 m f5 m ef m 6 m 1b m c2 m ec m 74 m 59 m f0 m c6 m 51 m 35 m 85 m e1 m 2e m 9f m ec m 6c m 1 m 22 m
notbusy
02 wcmd 8 m cb m 0 m \ 0x8cb00 
2f m 2e m 5e m bc m 2 m dd m d2 m e9 m 94 m b2 m bc m 56 m 33 m fc m 3a m be m 94 m 6b m 70 m c6 m b7 m ab m 8c m 91 m 2b m bd
m 3a m bb m a7 m 46 m a8 m 3a m ad m 52 m d5 m b m b8 m 71 m cd m 1 m 52 m 65 m e4 m b8 m cf m 84 m 77 m 58 m ea m 54 m bf m
1d m e m c0 m 70 m a4 m cd m 15 m fe m f1 m 65 m 58 m 22 m 59 m 5f m 84 m 45 m 57 m a0 m 94 m 44 m f7 m 38 m 44 m 8c m 9e m 9a
m 66 m 71 m e2 m a3 m 40 m ba m fc m e5 m 54 m 1e m 36 m 29 m 10 m 4b m 88 m 23 m 5a m b m 8 m 75 m e1 m 2c m e8 m 7a m 5d m
67 m a0 m ad m d m 43 m ac m be m 21 m 24 m b m 3d m 19 m 51 m 95 m 8e m 99 m 2c m 68 m e1 m 8f m 2 m 1e m 92 m 74 m 9d m 2e m
f7 m 49 m c3 m ed m c0 m e9 m 64 m 70 m 8f m 8a m 7e m 44 m 9c m ca m 17 m 72 m 30 m 6f m e1 m bc m ec m b2 m f8 m d m b6 m cd
m 6b m 51 m b1 m fe m cf m 50 m 4e m d9 m 5e m f1 m 6b m 65 m 7f m b4 m 30 m 87 m 8d m b2 m 3e m f6 m 90 m c0 m 6f m a1 m df m
0 m 9a m 82 m 46 m 40 m 57 m 95 m 30 m de m ef m df 2 r 60 m 33 m 4f m d2 m 58 m 4c m a2 m 71 m de m c6 m 8e m 4c m 33 m 5d m
61 m 52 m f3 m 62 m e1 m f8 m 32 m 8 m 66 m e3 m 13 m 34 m de m 6f m 9c m 74 m 58 m b1 m be m 35 m f5 m 21 m 50 m 9d m 4e m 81
m 33 m 1e m 19 m 65 m 7f m 69 m 2b m 82 m 81 m 2c m 86 m fa m 5d m 80 m 0 m 99 m ec m 72 m be m 7c m d3 m 3a m 72 m 4 m 3a m
notbusy
02 wcmd 8 m cc m 0 m \ 0x8cc00 
a8 m 37 m e7 m fb m b m 73 m 6b m b3 m 12 m a0 m c6 m d2 m c8 m 72 m 9f m d5 m 25 m e1 m df m f3 m 8c m 5b m d0 2 r 6c m 19 m
6e m ec m 7d m 3c m 28 m bc m dc m 4 m 6 m 84 m f9 m 50 m 62 m f0 m 43 m 99 m de m 68 m 49 m c9 m 1 m 97 m b m c3 m e2 m a6 m
76 m ac m 22 m 41 m 18 m 28 m 92 m 16 m 97 m 9c m 53 m 3b m 2e m 22 m 99 m c m bc m 5b m ca m d4 m 3e m 3c m ed m 99 m f9 m e3
m c4 m 36 m de m 74 m c2 m 66 m a4 m f5 m c1 m c9 m 8e m 38 m 15 m e5 m 86 m 67 m 4e m e1 m c7 m 8d m b9 m 4e m 57 m d9 m 4c m
8b m 79 m 3e m 8 m d5 m 29 m 11 m e3 m 9b m e1 m 20 m 34 m 37 m cf m 9a m 9 m c0 m ba m 40 m f2 m 2d m 8 m d m 4d m 71 m 29 m
2e m 63 m 24 m 46 m 94 m d5 m e1 m 80 m 7b m a0 m 18 m 31 m d1 m 9c m 1d m 39 m 33 m db m 20 m 6e m 8e m fe m 94 m 5f m df m a
m 90 m e9 m a6 m 99 m 8c m 2b m 30 m fd m ae m 75 m bc m 3a m a2 m 95 m 9d m bf m 7e m d3 m 8c m 7b m de m ee m 83 m 68 m 45 m
41 m 7 m 28 m 83 m 59 m b8 m 84 m 63 m cc m ec m 59 m 31 m 99 m 35 m 5e m f3 m d6 m 16 m 61 m c8 2 r d9 m 64 m bf m 92 m ce m
cc m ca m 60 m c7 m 48 m ac m ee m 12 m 29 m 7b m 26 m 58 m b8 m 89 m eb m f3 m aa m 9f m bc m 5e m 5a m 57 m 2d m 4f m 6c m
f4 m ac m 34 m 4f m 49 m 72 m a8 m 93 m 9a m 2a m 88 m 69 m ca m 6 m de m 70 m c2 m ee m 6 m e1 m c0 m 0 m 30 m 74 m ce m
notbusy
02 wcmd 8 m cd m 0 m \ 0x8cd00 
81 m 7b m c m 32 m ec m d6 m 2e m 7e m e5 m 92 m 6d m 1d m be m 10 m 3f m a m f8 m 4a m cc m 4f m ec m 88 m b1 m cc m 52 m 61
m 2e m ab m de m 63 m 94 m a6 m 18 m be m 34 m 13 m aa m 82 m 85 m 8c m dc m e4 m e6 m ec m ef m a2 m 38 m 59 m 3a m 7f m 41 m
6b m 45 m 6b m fc m ab m 60 m aa m e4 m f6 m 17 m 58 m 1d m 59 m e4 m 26 m 22 m e7 m f m 9 m f6 m d2 m 2c m d3 m 76 m 46 m 19
m d2 m 79 m ad m 9c m fb m d4 m ca m 1d m 4 m a5 m 13 m dc m 67 m 71 m ab m 6 m d m 30 m 1c m d8 m fa m fc m bf m 32 m c1 m a1
m 6 m c4 m 85 m d1 m 21 m ff m c0 m 35 m fb m 32 m cf m 34 m fe m dd m c m 3b m f0 m 9b m 17 m d7 m 8d m 1 m f2 m 7e m b3 m ef
m c1 m 34 m 97 m 1a m a9 m 9d m 78 m cc m e m dc m eb m 4a m f4 m 9b m 17 m 94 m 7 m 4b m a4 m 1e m 7d m f m 54 m 86 m 79 m c3
m 73 m a6 m 48 m 33 m 7e m e0 m c5 m b1 m 4e m e5 m 59 m 93 m bd m 9 m 8a m fc m 1a m 3e m 53 m 0 m cb m 20 m a7 m a8 m 24 m
4f m c2 m 44 m 9b m 14 m 3e m eb m 49 m f9 m 3d m 6e m 4e m 9d m 75 m 0 m 1b m 84 m 31 m 5d m e0 m a7 m 42 m 5e m a0 m c9 m 4a
m e5 m 8d m 80 m 5d m 45 m be m 4d m 7c m a m 3e m 67 m 9c m 3 m 9c m a5 m 32 m 90 m ee m 51 m e2 m 36 m 2f m b2 m cd m 5c m
52 m 6a m 25 m 3 m 2e m cd m 2a m 40 m 7e m e8 m 1a m d1 m e6 m 3b m f m cb m ae m 66 m 7b m df m b1 m e8 m b9 m 41 m c5 m
notbusy
02 wcmd 8 m ce m 0 m \ 0x8ce00 
22 m 95 m d6 m 90 m 95 m 3c m 6d m df m a6 m e3 m 90 m 60 m f6 m 9b m c2 m 2d m 3c m e6 m 20 m e3 m da m 83 m fd m 84 m ca m
34 m 76 m 50 m dd m 61 m 3 m f6 m c3 m af m c0 m 3f m 2b m c8 m 4f m 9d m d2 m 41 m 93 m a6 m e4 m ef m 93 m f4 m 47 m 58 m 82
m 8 m d3 m c m 8c m fe m bf m 6d m da m a m ef m d2 m 64 m 2f m 2d m 71 m 9e m c0 m 67 m d4 m be m e8 m dd m bb m c7 m 37 m 73
m 23 m 9d m 3a m e4 m d3 m b3 m d6 m 57 m 7a m da m a8 m 80 m c5 m a1 m fc m e4 m 13 m ff m 69 m 1b m 51 m 1c m b1 m 98 m 28 m
6e m 79 m ff m 98 m e2 m d1 m 27 m 15 m 21 m 58 m 6a m 2f m c2 m 4e m 9a m b9 m 22 m 48 m a6 m db m 72 m 3f m 16 m 28 m f9 m
a6 m 11 m ce m 8e m be m e4 m 77 m 88 m 5f m ef m 5c m 51 m e8 m b1 m 44 m c9 m 21 m 61 m 9b m b9 m 8c m 78 m 33 m ab m c4 m
76 m a3 m 6 m 4 m e3 m dc m be m 9a m ff m 76 m 70 m 98 m 6a m b3 m f4 m b6 m c1 m 2a m 5 m f m c6 m a1 m fe m 6a m de m 6b m
fa m 12 m f0 m 6f m a7 m f1 m 0 m 84 m 95 m 46 m e2 m 69 m 91 m fb m 5e m 65 m 9f m cb m af m b m 31 m 97 m b2 m 62 m 4b m 58
m d3 m 92 m 3b m bf m 4b m 31 m 9b m 80 m d3 m 8a m e8 m 91 m af m 82 m 6 m 71 m a9 m 75 m a4 m 65 m dc m 86 m af m c m 9e m
90 m 6 m 8b m 46 m 6c m bb m 3b m bc m af m 3d m 5c m da m 80 m 2c m e4 m ff m 9c m bb m 15 m af m d7 m 86 m 5c m f3 m ff m a8
m 44 m notbusy
02 wcmd 8 m cf m 0 m \ 0x8cf00 
7d m 84 m 32 m 78 m 7e 2 r 11 m 64 m 79 m 42 m fd m b3 m ff m bf m 1d m 62 m 76 m d9 m f3 m 60 m 17 m af m 15 m 2b m 8c m b2 m
3c m f8 m 4c m 59 m 31 m 4c m c0 m 40 m 9b m 6f m ab m f0 m 28 m f5 m ad m cb m 6a m b0 m a m fb m fa m 66 m 65 m 3c m eb m 72
m 33 m ac m 4c m 34 m 61 m a2 m b9 m 28 m d2 m 35 m 16 m 98 m c4 m ec m f1 m 8a m af m 9a m c m 60 m fa m 5a m 28 m 68 m b0 m
d9 m 60 m 20 m 2a m 16 m 40 m 8 m f9 m e0 m 81 m 8c m e m d2 m 8a m 15 m 8a m 45 m ec m 6a m 6b m 7c m 4b m e m 8a m 43 m f9 m
d3 m b9 m 1 m de m d6 m 1d m 35 m ff m 15 m cf m 45 m fc m fb m 59 m 4a m ce m 43 m d7 m 8e m 88 m 2b m 7a m 3b m eb m ba m 32
m 5d m 6e m 46 m 8 m 2f m a8 m 76 m a0 m 74 m 3f m 18 m d6 m 5c m 11 m 2f m f4 m f7 m 6c m d0 m 9a m 69 m 49 m ed m f0 m 55 m
15 m b0 m 6a m ab m 3c m 6b m e1 m 36 m 3c m ab m 4b m 18 m 89 m 3 m fc m d7 m 1b m 42 m a8 m da m d7 m 22 m dd m 7a m b9 m c8
m 4b m da m 85 m be m 98 m 2e m e1 m 8 m a5 m 3a m ca m fd m e5 m 59 m 3d m bb m 12 m 7a m 7 m 4d m 1a m 92 m ee m a5 m 1d m
78 m 7b m e5 m 82 m f0 m e3 m c6 m 3b m 77 m 5f m bb m 3a m b2 m eb m 4a m 1e m d9 m 6e m 23 m e3 m f2 m 42 m 33 m 4 m d7 m d1
m 7f m 3e m 75 m e1 m af m 6f m a6 m 2e m e1 m 5d m a9 m 21 m a7 m 9 m 38 m 80 m d2 m 59 m af m 11 m e5 m 3f m a4 m 69 m 57 m
notbusy
20 wcmd 8 m d0 m 0 m notbusy \ 0x8d000
02 wcmd 8 m d0 m 0 m \ 0x8d000 
9c m 4c m 88 m 82 m 8d m e4 m 4f m 96 m 86 m e0 m 6c m 54 m 62 m e3 m 43 m 6d m aa m 58 m ca m 9c m ce m f3 m ca m 4f m ba m
18 m d9 m 80 m 5a m aa m 69 m c3 m 8b m 45 m 41 m b8 m eb m 69 m 46 m 5a m ac m 87 m 1 m dd m 5f m 23 m 85 m 2e m 6c m 37 m 97
m ff m a7 m 7f m 95 m 8f m b1 m 1b m 3a m 16 m b m 54 m 84 m 28 m dc m 62 m 7b m fa m ae m e8 m 17 m 9c m 83 m 3c m cb m b6 m
98 m 33 m 65 m a5 m 90 m 8c m 8b m 2c m 77 m 16 m 2b m c3 m b3 m 5f m df m ad m 89 m 7e m 54 m 97 m 5b m 38 m 59 m f m 7b m bc
m f3 m 45 m d6 m ef m 54 m 15 m be m 2c m 9 m a2 m 49 m d m 1e m 5e m 41 m 9b m 96 m 37 m 50 m d1 m 4f m 97 m a3 m 59 m 44 m
e5 m 54 m e4 m ce m 5c m 40 m 9b m c5 m 45 m a5 m 7a m ce m bd m 2c m a8 m e9 m 30 m 3c m 82 m 31 m 4d m a8 m a4 m d0 m 9 m 32
m 33 m 5c m d7 m 85 m a2 m 1c m 4a m 8c m 3f m be m b1 m af m 4e m e9 m eb m 16 m ad m 9b m a4 m 33 m a1 m 1c m b4 m ce m b6 m
b9 m e6 m 8c m 46 m 24 m 9c m 2b m 63 m dc m 14 2 r 90 m 5c m d2 m 2e m 44 m 7f m 34 m 47 m e2 m 0 m 79 m 1a m 73 m 5 m 79 m
4e m c1 m 4c m 50 m cb m f5 m 8e m 2 m 76 m a1 m 9b m f9 m 11 m ba m df m 40 m e6 m 42 m a9 m 3 m fa m 4c m 4 m ac m f4 m cb m
be m e m fc m 17 m 3f m f0 m 27 m 2d m cc m a4 m 77 m 85 m e5 m 28 m e3 2 r 9d m b1 m f9 m 6f m dc m 26 m d3 m 3f m b0 m 40 m
notbusy
02 wcmd 8 m d1 m 0 m \ 0x8d100 
d8 m 6a m 7a m 71 m 7b m 71 m ae m b m cd m 8c m 92 m 1c m 7 m d6 m 99 m c7 m 99 m 56 m f1 m e8 m ed m 92 m cd m 14 m 31 m ee
m a5 m 5f m e m fa m 59 m 76 m 8a m bd m 38 m a8 m 3 m b4 m b2 m c6 m 39 m ad m a9 m a8 m 9c m 48 m 5a m b m 20 m ec m a0 m 70
m 35 m 1 m bf m 6e m d1 m 84 m a9 m 81 m d m 26 m 87 m b8 m 25 m c3 m 83 m 9 m b1 m d5 m c m 97 m 82 m 8 m bc m 19 m 1e m 79 m
ea m 30 m ad m 24 m 82 m b2 m 32 m 49 m 27 m ea m e6 m 78 m 5b m 8c m ae m f2 m 80 m d1 m 65 m 2b m c m 1d m 4a m e0 m af m 5e
m d1 m d2 m 97 m db m 62 m 1 m 2f m 43 m 41 m 82 m e2 m 59 m 2 m d m ba m a3 m 9 m 1e m dc m 86 m 79 m 7b m 36 m e6 m 6b m 26
m 75 m 37 m 75 m 72 m 32 m e0 m 39 m a6 m de m a1 m f3 m 53 m cd m f1 m 50 m a5 m c2 m e5 m 5e m 33 m 31 m e7 m fc m 35 m 25 m
7b m bd m 41 m 2a m d3 m f1 2 r c1 m 46 m d8 m fe m 5f m ed m 93 m 30 m 51 m a8 m be m 72 m 79 m 7e m e4 m c8 m fd m df m 49 m
68 m 74 m b0 m a9 m 21 m 24 m 9c m 3c m f3 m 5c m ec m ef m 0 m ce m 24 m 12 m dd m 60 m d m 40 m 67 m b0 m d3 m a6 m 6b m b7
m 62 m 86 m 67 m 2 m 7f m a4 m 1d m 12 m 99 m 7 m 37 m c m c7 m d7 m e0 m b6 m 8 m e7 m 48 m 12 m 50 m ed m a0 m 88 m ef m a m
93 m ae m b2 m 9 m 22 m 25 m e2 m 2 m d5 m 39 m f5 m 2e m 3d m 89 m 6 m c7 m 2f m 78 m ca m 71 m 3d m a6 m 0 m notbusy
02 wcmd 8 m d2 m 0 m \ 0x8d200 
d4 m 54 m 4 m 2a m 5a m 77 m 73 m 59 m a6 m ae m c8 m 1e m b1 m de m 41 m fe m 65 m 9b m 3 m 67 m ac m d3 m 69 m e6 m 76 m 9e
m 15 m ad m c6 m 75 m d0 m c5 m 27 m 2e m 31 m 36 m 9f m 3f m f8 m 18 m 2c m 10 m 69 m 12 m 40 m 74 m d7 m ca m 7a m 89 m b0 m
4c m ad m ea m 58 m e5 m 87 m ee m 1e m 9a m 6f m 74 m f6 m 9a m bb m 0 m 40 m 25 m 39 m 71 m 43 m a m 52 m fd m 52 m 3 m 84 m
bb m c3 m 69 m f7 m 1 m 85 m 7c m a6 m 45 m d4 m 86 m b8 m a7 m a5 m 4b m 9 m 9e m fc m 1 m 77 m 29 m f1 m ea m 69 m f7 m 45 m
3e m e8 m 3c m 2 m a3 m 5e m 61 m c1 m 23 m 8 m 64 m 98 m 26 m 3b m 57 m e3 m b1 m 3b m 66 m c3 m 8e m 65 m 85 m cf m 3b m d5
m 77 m 81 m c3 m d2 m 33 m d9 m 5e m 53 m 45 m 8e m 4c m 48 m 6b m fc m 56 m 69 m 7b m 5e m 4b m c8 m 27 m f0 m b3 m a3 m 2c m
70 m 20 m 9 m d m 30 m 29 m 35 m bd m 7b m d7 m ae m bf m ca m d8 m 53 m 16 m 99 m 68 m 6e m 54 m cb m e1 m 76 m dc m f0 m 71
m 24 m fa m da m d3 m 89 m 9a m df m 87 m fd m 16 m e4 m fe m b7 m d m f0 m 53 m 9d m 98 m 35 m fa m f7 m 26 m 24 m 57 m e0 m
e3 m b2 m f4 m 8d m ad m c6 m 44 m ea m 9 m 2c m bb m 90 m 4c m b4 m a3 m a4 m d3 m fc m 2 m 4c m 43 m 69 m bc m 73 m cc m a9
m c5 m 42 m e0 m 14 m 78 m ab m 12 m 49 m 22 m 9d m bf m d5 m fa m 91 m c0 m bc m 67 m 8d m 77 m 71 m f8 m 8a m 5b m f9 m 3b m
notbusy
02 wcmd 8 m d3 m 0 m \ 0x8d300 
6b m f0 m 26 m d4 m 82 m 24 m 3c m 33 m b6 m fc m 72 m f1 m 28 m f4 m bc m 83 m 4d m fe m 40 m 19 m 53 m 67 m fe m 4d m 72 m
f5 m 88 m ef m 3 m 37 m cb m 86 m 78 m 91 m 36 m 95 m 19 m 80 m 54 m 7a m 46 m eb m 44 m f0 m 4 m 48 m 6b m b0 m 9e m 92 m 1a
m a2 m ed m 23 m 75 m c6 m 82 m e6 m 4f m 83 m 3a m 46 m 7e m 6e m e6 m 55 m 35 m a0 m e9 m a5 m c1 m 5c m 5f m 4e m 8f m ce m
6 m f7 m 30 m 21 m 2a m d8 m 52 m 72 m 35 m 74 m 78 m 18 m a5 m 2c m 26 m c6 m b5 m 32 m 11 m 40 m 32 m f2 m e4 m a7 m 2f m a7
m 2c m 3d m cc m 36 m ac m 1a m 78 m 86 m 18 m aa m b4 m 3f m f2 m 7c m fa m 3c m 6d m 6e m 42 m 2 m 44 m 5 2 r 27 m 59 m 86 m
87 m 6b m 39 m 30 m ac m 7a m 3 m 5c m 64 m d7 m 12 m 3a m 33 m 71 m 5b m 19 m 28 m 36 m 93 m 80 m c1 m cc m b6 m f3 m 10 m 7a
m 23 m e7 m 1d m bc m de m ed m c3 m d8 m 5c m 1a m a4 m f2 m 6 m 4c m a m 85 m a0 m ff m ef m 2f m 93 m 3a m 83 m 42 m e m 72
m c5 m ff m 7a m b6 m a8 m 81 m 45 m 9a m be m 7e m 9e m 24 m c m d m 99 m ac m e2 m 86 m 98 m 52 m c1 m ba m 75 m 2d m eb m
34 m 3b m 6f m 83 m 10 m 9a m fa m f8 m d7 m f0 m 9 m b4 m 90 m 10 m ed m 1b m f9 m c9 m 1 m a4 m b5 m 65 m 2c m 9 m f3 m b7 m
7f m 52 m 2c m c8 m f m bf m c3 m 34 m 16 m 12 m c4 m e7 m 9 m 4b m 16 m b0 m 3f m 2d m 54 m 62 m 2c m 89 m ed m d2 m ae m
notbusy
02 wcmd 8 m d4 m 0 m \ 0x8d400 
49 m 5d m b7 m 3 m 3c m 20 m e1 m 35 m a7 m 5d m a9 m 4c m ed m 17 m 6e m 48 m 35 m 26 m c1 m b8 m fb m 29 m a4 m 58 m 49 m fc
m a7 m 82 m 99 m 71 m eb m 8d m d7 m 9d m 74 m 52 m 50 m 97 m f7 m ba m c2 m 22 m 8a m f4 m 1e m 88 m 9c m 36 m 2b m 30 m f8 m
4c m a4 m 18 m db m f6 m 6a m 5d m 25 m f1 m 41 m 9e m 95 m 3a m ee m fc m 41 m c4 m b m b3 m c3 m 14 m 83 m 24 m bd m 51 m fa
m 7b m 90 m e0 m 3a m 51 m 88 m 96 m 72 m 82 m 5 m d2 m bd m b9 m 27 m 88 m fa m de m e6 m 23 m 1b m b7 m 25 m 4a m 1f m fe m
84 m 72 m 1f m ae m b m ad m 8d m 67 m 35 m 32 m b7 m 94 m 26 m 3e m ed m 7c m ba m 8d m 1a m 7d m 23 m 6d m c7 m d9 m 9e m bd
m ba m a7 m 6c m 4 m 26 m fc m 26 m 60 m ba m f2 m 7 m 63 m 6a m 1f m a3 m 50 m 42 m bd m 45 m b5 m 60 m ef m 5b m ad m 23 m
a6 m f6 m 66 m 94 m f6 m 1e m 1a m 1f m ed m a7 m 27 m 59 m b7 m c6 m bb m 23 m 6b m e1 m eb m 8d m f5 m 48 m 69 m 4a m 2b m
cf m dd m 16 m 1e m d0 m 46 m 17 m 4a m 85 m d7 m 37 m ed m de m d6 m a7 m ce m 8f m 1f m 61 m 43 m b3 m 63 m b1 m 14 m b1 m
ba m 5c m 99 m dd m 6d m a2 m 3d m 8f m fb m d2 m a9 m 95 m 72 m e9 m b5 m db m d7 m 2b m 97 m 39 m f6 m 4b m b2 m 5e m 5d m
ae m 77 2 r 7d m 5d m ed m 49 m 80 m 2a m 25 m fc m db m e1 m 2e m ba m f3 m bf m 3b m 25 m 2d m cc m 20 m bf m 9f m be m 81 m
a m 6b m notbusy
02 wcmd 8 m d5 m 0 m \ 0x8d500 
41 m 21 m 79 m bf m e9 m 55 m dd m c m 42 m 62 m bf m 92 m 89 m a0 m df m 46 m d9 m 4a m fc m 8c m 67 m 3e m 8f m db m 96 m 8d
m 15 m 26 m 6b m 4f m a6 m 1d m 28 m 4f m f9 m 68 m c0 m 5e m 9c m 63 m 18 m 76 m 6f m 46 m 10 m 2a m fe m b7 m 39 m f2 m a3 m
c8 m 13 m d7 m 16 m c5 m b1 m 16 m 91 m 5f m c1 m 1b m 66 m 11 m 44 m 53 m 8 m c7 m b m 54 m 71 m 39 m df m 5a m 6 m d1 m fa m
15 m 6d m f3 m 2a m 6e m 3e m cf m 26 m ed m 70 m 15 m e9 m 58 m c7 m f6 m 2a m da m 97 m ef m 16 m cb m bc m 7a m 85 m fc m
1f m 3c m 4a m ad m 7 m f8 m e8 m ca m 95 m dd m 6e m 10 m 6 m 7b m ed m 31 m 41 m 2d m 12 m 73 m 2f m 44 m bf m d2 m d m b8 m
38 m d5 m ec m 5f m d2 m 5e m 39 m e2 m 2f m f7 m b4 m be m 31 m 2f m 5d m b9 m ef m 67 m f5 m 4a m f0 m 5f m 69 m ab m 7b m
e5 m d4 m 9a m fe m c8 m 6 m d6 m cc m 72 m f7 m de m f0 m b9 m fc m 6 m 6d m b2 m 93 2 r 54 m 69 m 20 m 2f m 69 m b6 m 4e m
2e m 49 m 15 m 8b m a5 m 59 m 9c m 60 m e3 m 77 m 38 m 39 m 5 m 2d m e4 m 9e m 5c m 5d m d2 m 5e m 2b m 4d m 20 m d5 m 13 m 90
m ef m a m 8e m 23 m c0 m 87 m f2 m 26 m 4d m 56 m f4 m 52 m 5 m a0 m bb m 13 m 42 m 66 m 25 m 11 m 1c m 52 m 63 m 87 m 3 m 3f
m 6c m b7 m a0 m 2b m f1 m 42 m b1 m e3 m 39 m fc m 25 m 57 m fd m 21 m 78 m 50 m 57 m 6f m a4 m 3f m 70 m 64 m ab m c m a6 m
notbusy
02 wcmd 8 m d6 m 0 m \ 0x8d600 
22 m bc m b9 m 2c m b8 m 92 m b4 m 7a m cf m 86 m 47 m 73 m 99 m 8 m 4c m 88 m 2a m a8 m 3 m f4 2 r 25 m 4f m 84 2 r f9 m 69 m
52 m 76 m ee m ba m 1 m 89 m 88 m 4 m 39 m fd m f0 m 94 m e4 m 25 m 57 m fe m 42 m 9b m 87 m 38 m cc m a m 24 m 82 m 7f m 10 m
63 m ee m c9 m a5 m 55 m cc m ff m 6e m 85 m fd m 51 m ad m 8d m 27 m 5c m 3 m e3 m 97 m df m 69 m b3 m ef m 1f m 27 m 92 m 82
m e8 m 4c m 10 m 98 m d2 m 41 m 83 m de m be m e6 m b1 m 5 m 38 m 2c m 2 m 87 m d3 m 36 m 27 m 7f m 62 m a2 m 26 m 15 m 2b m
7d m ae m 74 m 41 m a6 m e0 m 5a m 44 m 2f m 7b m f3 m 28 m 7 m 16 m 3b m e6 m 44 m 88 m 41 m b0 m a1 m 1a m c6 m 84 m 95 m 9e
m d7 m a1 m 3d m 5d m 36 m 93 m bc m b6 m 20 m 36 m f4 m 89 m cb m a6 m e9 m 43 m e3 m 90 2 r 8c m 5e m 39 m e m 7b m 40 m b8
m 8 m a3 m 93 m 9b m ff m 22 m 7f m 6f m 7 m 81 m f2 m 4f m 3f m a9 m 2e m 46 m 3e m 34 m 15 m fc m 79 m 99 m 38 m cd m 29 m
f1 m 17 m 3d m ba m 71 m 40 m 17 m 30 m d9 m 4a m 97 m f8 m 76 m cc m f4 m 6c m c5 m 58 m 1f m ac m 6a m fc m 87 m 8e m 6f m
6d m ea m 2 m c8 m 4c m 6b m 1f m eb m ea m 3 m 4 m 16 m db m 3d m 84 m d2 m a0 m 92 m b5 m 6e m fb m 96 m ed m 7d m 9f m be m
a2 m 51 m 95 m c0 m 38 m a3 m 49 m f2 m d4 m e0 m b3 m b9 m ed m d4 m c8 m b8 m 5a m bd m 47 m 3 m 1c m 66 m a2 m ae m notbusy
02 wcmd 8 m d7 m 0 m \ 0x8d700 
5a m f3 m fc m 43 m d2 m 73 m 7e m a2 m 3 m a7 m 8d m c m 6b m 96 m 87 m 7f m cf m 4a m 0 m a m 75 m 1a m 29 m 91 m d8 m 4a m
27 m 74 m 50 m 5c m 7f m 7b m 25 m 14 m 29 m 6c m 60 m 59 m 13 m 2c m 92 m 4e m 22 m 51 m 47 m 2c m c3 m 9a m 32 m 0 m 92 m ac
m 15 m 13 m 32 m 40 m 65 m c0 m 8e m 6c m 3a m 4f m 40 m 13 m ee m 83 m 51 m c m 65 m 81 m 15 m f2 m b9 m e7 m 4 m 53 m b8 m
42 m d5 m ea m fa m 10 m 60 m fe m d3 m 6a m ab m c9 m f m 71 m 9f m 6e m e9 m 72 m 40 m 2b m 6e m 32 m c6 m e7 m 55 m fe m 2f
m b1 m 39 m f m 5d m cf m 9b m 4a m 44 m 4a m 43 m 61 m 2e m 87 m 82 m f9 m 9b m cd m 2d m 98 m 1c m 6 m a2 m 25 m 90 m d6 m
2a m 27 m 3b m af m 6a m 4a m 5a m 70 m d6 m 49 m b3 m 5c m c3 m da m 0 m 28 m d6 m 1f m b m 3b m 43 m 5f m 3a m 99 m a5 m 7a
m f m 38 m 62 m 63 m cf m 14 m 2f m f5 m be m 18 m 5c m 28 m 26 m d m c9 m 39 m 7b m b7 m 81 m c m ef m 83 m df m 99 m c1 m 1c
m c9 m 2e m d7 m 43 m 36 m cc m 8f m cb m 5 m c3 m 1d m 66 m 7c m 76 m 8 m 62 m 59 m 9e m b4 m 3c m a m 2e m 32 m b3 m 22 m e5
m e m 11 m 60 m a7 m a3 m 4c m 5 m 2a m 6 m ca m d6 m 5b m b2 m 6e m 81 m 5f m aa m e1 m d6 m ef m 3f m 77 m 26 m 8f m 58 m f4
m b9 m f7 m e5 m fc m 7c m 2 m 9f m 69 m 15 m cd m ad m 86 m d7 m 4b m b6 m d6 m 4a m b7 m 65 m f8 m ab m d3 m ad m 12 m
notbusy
02 wcmd 8 m d8 m 0 m \ 0x8d800 
6c m 43 m eb m 1f m 2e m 5c m c2 m 45 m de m b9 m 1e m 83 m 74 m 6f m 78 m a6 m 6 m 35 m f9 m d7 m aa m 5 m b4 m d0 m fa m ab
m 62 m ae m 5c m 75 m a4 m fb m b9 m ff m 3c m d6 m 73 m 6 m fb m 3b m e8 m cf m fd m 24 m 35 m b6 m 55 m 15 m df m 62 m 8b m
f4 m bb m 5a m 46 m 88 m a1 m ac m a8 m 9 m 79 m 2d m 9e m a7 m 34 m 64 m 7 m 0 2 r 26 m 0 4 r 1 m ff 3 r 0 m ff 3 r 26 m ff 3
r 1a m ff 3 r 60 m 20 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 94 m 20 m 30 m 0 m 4 m 0 3 r 83 m 0 3 r 1a m ff 3 r 68 m 20 m 30 m 0 m
4 m 0 7 r 1a m ff 3 r 6c m 20 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 7c m 25 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 2c m 20 m 30 m 0 m 4 m
0 3 r 72 m 6 m 0 2 r 1a m ff 3 r 30 m 20 m 30 m 0 m 4 m 0 3 r 4 m 1 m 0 2 r 1a m ff 3 r 34 m 20 m 30 m 0 m 4 m 0 4 r 5 m 0 2 r
1a m ff 3 r 40 m 20 m 30 m 0 m 4 m 0 3 r ee m 2 m 0 2 r 1a m ff 3 r 44 m 20 m 30 m 0 m 4 m 0 3 r 19 m 0 3 r 1a m ff 3 r 48 m
20 m 30 m 0 m 4 m 0 m notbusy
02 wcmd 8 m d9 m 0 m \ 0x8d900 
0 2 r d0 m 2 m 0 2 r 1a m ff 3 r 3c m 20 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 38 m 20 m 30 m 0 m 4 m 0 3 r 28 m 0 3 r 1a m ff 3 r
50 m 20 m 30 m 0 m 4 m 0 7 r 1a m ff 3 r 4c m 20 m 30 m 0 m 4 m 0 3 r 5 m 0 3 r 1a m ff 3 r 70 m 20 m 30 m 0 m 4 m 0 3 r 1 m 0
3 r 1a m ff 3 r d8 m 20 m 30 m 0 m 4 m 0 3 r 60 m 2c m 0 m 2c m 0 3 r 27 m 0 3 r f m 7 m 0 2 r 26 m a m 10 m 0 m 1b m bc m b2
m 4f m 1c m 1 m 0 2 r 1f m e m 0 2 r 20 m 0 3 r 22 m 1 m 0 2 r 5 m 44 m 91 m 0 m 1 m 0 2 r 2 m 15 m 93 m 4 m 2 m 19 m 0 3 r 25
m 0 3 r 6 m 28 m fd m 0 m 40 m 0 m 80 m 0 m 40 m 1 m 0 2 r 6 m 28 m 7d m 8 m 40 m 0 2 r 8 m 40 m 2 m 0 2 r 6 m 28 m fd m f m
40 m 0 m 80 m f m 40 m 3 m 0 2 r 6 m 28 m 7d m 17 m 40 m 0 2 r 17 m 40 m 4 m 0 2 r 6 m 28 m fd m 1e m 40 m 0 m 80 m 1e m 40 m
5 m 0 2 r 6 m 28 m 7d m 26 m 40 m 0 2 r 26 m 40 m 6 m 0 2 r 6 m 28 m fd m 2d m 40 m 0 m 80 m 2d m 40 m 7 m 0 2 r 6 m 28 m 7d m
35 m 40 m 0 2 r 35 m 40 m 8 m 0 2 r 6 m 28 m fd m notbusy
02 wcmd 8 m da m 0 m \ 0x8da00 
3c m 40 m 0 m 80 m 3c m 40 m 9 m 0 2 r 6 m 28 m 7d m 44 m 40 m 0 2 r 44 m 40 m a m 0 2 r 6 m 28 m fd m 4b m 40 m 0 m 80 m 4b m
40 m b m 0 2 r 6 m 28 m 7d m 53 m 40 m 0 2 r 53 m 40 m c m 0 2 r 6 m 28 m fd m 5a m 40 m 0 m 80 m 5a m 40 m d m 0 2 r 6 m 28 m
7d m 62 m 40 m 0 2 r 62 m 40 m e m 0 2 r 6 m 28 m fd m 69 m 40 m 0 m 80 m 69 m 40 m f m 0 2 r 6 m 28 m 7d m 71 m 40 m 0 2 r 71
m 40 m 10 m 0 2 r 6 m 28 m fd m 78 m 40 m 0 m 80 m 78 m 40 m 11 m 0 2 r 6 m 28 m 7d m 80 m 40 m 0 2 r 80 m 40 m 12 m 0 2 r 6 m
28 m fd m 87 m 40 m 0 m 80 m 87 m 40 m 13 m 0 2 r 6 m 28 m 7d m 8f m 40 m 0 2 r 8f m 40 m 14 m 0 2 r 6 m 28 m fd m 96 m 40 m 0
m 80 m 96 m 40 m 15 m 0 2 r 6 m 28 m 7d m 9e m 40 m 0 2 r 9e m 40 m 16 m 0 2 r 6 m 28 m fd m a5 m 40 m 0 m 80 m a5 m 40 m 17 m
0 2 r 6 m 28 m 7d m ad m 40 m 0 2 r ad m 40 m 18 m 0 2 r 6 m 28 m fd m b4 m 40 m 0 m 80 m b4 m 40 m 19 m 0 2 r 6 m 28 m 7d m
bc m 40 m 0 2 r bc m 40 m 1a m 0 2 r 6 m 28 m fd m c3 m 40 m 0 m 80 m c3 m 40 m 1b m 0 2 r 6 m 28 m 7d m cb m 40 m 0 2 r cb m
40 m 1c m 0 2 r 6 m 28 m fd m d2 m 40 m 0 m 80 m d2 m 40 m 1d m 0 2 r 6 m 28 m 7d m da m 40 m 0 2 r notbusy
02 wcmd 8 m db m 0 m \ 0x8db00 
da m 40 m 1e m 0 2 r 6 m 28 m fd m e1 m 40 m 0 m 80 m e1 m 40 m 1f m 0 2 r 6 m 28 m 7d m e9 m 40 m 0 2 r e9 m 40 m 20 m 0 2 r
6 m 28 m fd m f0 m 40 m 0 m 80 m f0 m 40 m 21 m 0 2 r 6 m 28 m 7d m f8 m 40 m 0 2 r f8 m 40 m 22 m 0 2 r 6 m 28 m fd m ff m 40
m 0 m 80 m ff m 40 m 23 m 0 2 r 6 m 28 m 7d m 7 m 41 m 0 2 r 7 m 41 m 24 m 0 2 r 6 m 28 m fd m e m 41 m 0 m 80 m e m 41 m 25 m
0 2 r 6 m 28 m 7d m 16 m 41 m 0 2 r 16 m 41 m 26 m 0 2 r 6 m 28 m fd m 1d m 41 m 0 m 80 m 1d m 41 m 27 m 0 2 r 6 m 28 m 7d m
25 m 41 m 0 2 r 25 m 41 m 28 m 0 2 r 6 m 28 m fd m 2c m 41 m 0 m 80 m 2c m 41 m 29 m 0 2 r 6 m 28 m 7d m 34 m 41 m 0 2 r 34 m
41 m 2a m 0 2 r 6 m 28 m fd m 3b m 41 m 0 m 80 m 3b m 41 m 2b m 0 2 r 6 m 28 m 7d m 43 m 41 m 0 2 r 43 m 41 m 2c m 0 2 r 6 m
28 m fd m 4a m 41 m 0 m 80 m 4a m 41 m 2d m 0 2 r 6 m 28 m 7d m 52 m 41 m 0 2 r 52 m 41 m 2e m 0 2 r 6 m 28 m fd m 59 m 41 m 0
m 80 m 59 m 41 m 2f m 0 2 r 6 m 28 m 7d m 61 m 41 m 0 2 r 61 m 41 m 30 m 0 2 r 6 m 28 m fd m 68 m 41 m 0 m 80 m 68 m 41 m 31 m
0 2 r 6 m 28 m 7d m 70 m 41 m 0 2 r 70 m 41 m 32 m 0 2 r 6 m 28 m fd m 77 m 41 m 0 m 80 m 77 m 41 m 33 m 0 m notbusy
02 wcmd 8 m dc m 0 m \ 0x8dc00 
0 m 6 m 28 m 7d m 7f m 41 m 0 2 r 7f m 41 m 34 m 0 2 r 6 m 28 m fd m 86 m 41 m 0 m 80 m 86 m 41 m 35 m 0 2 r 6 m 28 m 7d m 8e
m 41 m 0 2 r 8e m 41 m 36 m 0 2 r 6 m 28 m fd m 95 m 41 m 0 m 80 m 95 m 41 m 37 m 0 2 r 6 m 28 m 7d m 9d m 41 m 0 2 r 9d m 41
m 38 m 0 2 r 6 m 28 m fd m a4 m 41 m 0 m 80 m a4 m 41 m 39 m 0 2 r 6 m 28 m 7d m ac m 41 m 0 2 r ac m 41 m 3a m 0 2 r 6 m 28 m
fd m b3 m 41 m 0 m 80 m b3 m 41 m 3b m 0 2 r 6 m 28 m 7d m bb m 41 m 0 2 r bb m 41 m 3c m 0 2 r 6 m 28 m fd m c2 m 41 m 0 m 80
m c2 m 41 m 3d m 0 2 r 6 m 28 m 7d m ca m 41 m 0 2 r ca m 41 m 3e m 0 2 r 6 m 28 m fd m d1 m 41 m 0 m 80 m d1 m 41 m 3f m 0 2
r 6 m 28 m 7d m d9 m 41 m 0 2 r d9 m 41 m 40 m 0 2 r 6 m 28 m fd m e0 m 41 m 0 m 80 m e0 m 41 2 r 0 2 r 6 m 28 m 7d m e8 m 41
m 0 2 r e8 m 41 m 42 m 0 2 r 6 m 28 m fd m ef m 41 m 0 m 80 m ef m 41 m 43 m 0 2 r 6 m 28 m 7d m f7 m 41 m 0 2 r f7 m 41 m 44
m 0 2 r 6 m 28 m fd m fe m 41 m 0 m 80 m fe m 41 m 45 m 0 2 r 6 m 28 m 7d m 6 m 42 m 0 2 r 6 m 42 m 46 m 0 2 r 6 m 28 m fd m d
m 42 m 0 m 80 m d m 42 m 47 m 0 2 r 6 m 28 m 7d m 15 m 42 m 0 2 r 15 m 42 m 48 m 0 2 r 6 m 28 m fd m notbusy
02 wcmd 8 m dd m 0 m \ 0x8dd00 
1c m 42 m 0 m 80 m 1c m 42 m 49 m 0 2 r 6 m 28 m 7d m 24 m 42 m 0 2 r 24 m 42 m 4a m 0 2 r 6 m 28 m fd m 2b m 42 m 0 m 80 m 2b
m 42 m 4b m 0 2 r 6 m 28 m 7d m 33 m 42 m 0 2 r 33 m 42 m 4c m 0 2 r 6 m 28 m fd m 3a m 42 m 0 m 80 m 3a m 42 m 4d m 0 2 r 6 m
28 m 7d m 42 2 r 0 2 r 42 2 r 4e m 0 2 r 6 m 28 m fd m 49 m 42 m 0 m 80 m 49 m 42 m 4f m 0 2 r 6 m 28 m 7d m 51 m 42 m 0 2 r
51 m 42 m 50 m 0 2 r 6 m 28 m fd m 58 m 42 m 0 m 80 m 58 m 42 m 51 m 0 2 r 6 m 28 m 7d m 60 m 42 m 0 2 r 60 m 42 m 52 m 0 2 r
6 m 28 m fd m 67 m 42 m 0 m 80 m 67 m 42 m 53 m 0 2 r 6 m 28 m 7d m 6f m 42 m 0 2 r 6f m 42 m 54 m 0 2 r 6 m 28 m fd m 76 m 42
m 0 m 80 m 76 m 42 m 0 3 r 23 m 1 m 0 2 r 20 m 8 m 0 2 r b m 0 3 r 5 m 0 3 r 25 m 0 3 r 6 m 2b m 7d m 1 m 40 m 3 m 0 m 1 m 40
m 1 m 0 2 r 6 m 2b m fd m 8 m 40 m 3 m 80 m 8 m 40 m 2 m 0 2 r 6 m 2b m 7d m 10 m 40 m 3 m 0 m 10 m 40 m 3 m 0 2 r 6 m 2b m fd
m 17 m 40 m 3 m 80 m 17 m 40 m 4 m 0 2 r 6 m 2b m 7d m 1f m 40 m 3 m 0 m 1f m 40 m 5 m 0 2 r 6 m 2b m fd m 26 m 40 m 3 m 80 m
26 m 40 m 6 m 0 2 r 6 m 2b m 7d m 2e m 40 m 3 m 0 m 2e m 40 m 7 m 0 m notbusy
02 wcmd 8 m de m 0 m \ 0x8de00 
0 m 6 m 2b m fd m 35 m 40 m 3 m 80 m 35 m 40 m 8 m 0 2 r 6 m 2b m 7d m 3d m 40 m 3 m 0 m 3d m 40 m 9 m 0 2 r 6 m 2b m fd m 44
m 40 m 3 m 80 m 44 m 40 m a m 0 2 r 6 m 2b m 7d m 4c m 40 m 3 m 0 m 4c m 40 m b m 0 2 r 6 m 2b m fd m 53 m 40 m 3 m 80 m 53 m
40 m c m 0 2 r 6 m 2b m 7d m 5b m 40 m 3 m 0 m 5b m 40 m d m 0 2 r 6 m 2b m fd m 62 m 40 m 3 m 80 m 62 m 40 m e m 0 2 r 6 m 2b
m 7d m 6a m 40 m 3 m 0 m 6a m 40 m f m 0 2 r 6 m 2b m fd m 71 m 40 m 3 m 80 m 71 m 40 m 10 m 0 2 r 6 m 2b m 7d m 79 m 40 m 3 m
0 m 79 m 40 m 11 m 0 2 r 6 m 2b m fd m 80 m 40 m 3 m 80 2 r 40 m 12 m 0 2 r 6 m 2b m 7d m 88 m 40 m 3 m 0 m 88 m 40 m 13 m 0 2
r 6 m 2b m fd m 8f m 40 m 3 m 80 m 8f m 40 m 14 m 0 2 r 6 m 2b m 7d m 97 m 40 m 3 m 0 m 97 m 40 m 15 m 0 2 r 6 m 2b m fd m 9e
m 40 m 3 m 80 m 9e m 40 m 16 m 0 2 r 6 m 2b m 7d m a6 m 40 m 3 m 0 m a6 m 40 m 17 m 0 2 r 6 m 2b m fd m ad m 40 m 3 m 80 m ad
m 40 m 18 m 0 2 r 6 m 2b m 7d m b5 m 40 m 3 m 0 m b5 m 40 m 19 m 0 2 r 6 m 2b m fd m bc m 40 m 3 m 80 m bc m 40 m 1a m 0 2 r 6
m 2b m 7d m c4 m 40 m 3 m 0 m c4 m 40 m 1b m 0 2 r 6 m 2b m fd m cb m 40 m 3 m 80 m cb m 40 m 1c m 0 2 r 6 m 2b m 7d m notbusy
02 wcmd 8 m df m 0 m \ 0x8df00 
d3 m 40 m 3 m 0 m d3 m 40 m 1d m 0 2 r 6 m 2b m fd m da m 40 m 3 m 80 m da m 40 m 1e m 0 2 r 6 m 2b m 7d m e2 m 40 m 3 m 0 m
e2 m 40 m 1f m 0 2 r 6 m 2b m fd m e9 m 40 m 3 m 80 m e9 m 40 m 20 m 0 2 r 6 m 2b m 7d m f1 m 40 m 3 m 0 m f1 m 40 m 21 m 0 2
r 6 m 2b m fd m f8 m 40 m 3 m 80 m f8 m 40 m 22 m 0 2 r 6 m 2b m 7d m 0 m 41 m 3 m 0 2 r 41 m 23 m 0 2 r 6 m 2b m fd m 7 m 41
m 3 m 80 m 7 m 41 m 24 m 0 2 r 6 m 2b m 7d m f m 41 m 3 m 0 m f m 41 m 25 m 0 2 r 6 m 2b m fd m 16 m 41 m 3 m 80 m 16 m 41 m
26 m 0 2 r 6 m 2b m 7d m 1e m 41 m 3 m 0 m 1e m 41 m 27 m 0 2 r 6 m 2b m fd m 25 m 41 m 3 m 80 m 25 m 41 m 28 m 0 2 r 6 m 2b m
7d m 2d m 41 m 3 m 0 m 2d m 41 m 29 m 0 2 r 6 m 2b m fd m 34 m 41 m 3 m 80 m 34 m 41 m 2a m 0 2 r 6 m 2b m 7d m 3c m 41 m 3 m
0 m 3c m 41 m 2b m 0 2 r 6 m 2b m fd m 43 m 41 m 3 m 80 m 43 m 41 m 2c m 0 2 r 6 m 2b m 7d m 4b m 41 m 3 m 0 m 4b m 41 m 2d m
0 2 r 6 m 2b m fd m 52 m 41 m 3 m 80 m 52 m 41 m 2e m 0 2 r 6 m 2b m 7d m 5a m 41 m 3 m 0 m 5a m 41 m 2f m 0 2 r 6 m 2b m fd m
61 m 41 m 3 m 80 m 61 m 41 m 30 m 0 2 r 6 m 2b m 7d m 69 m 41 m 3 m 0 m 69 m 41 m 31 m 0 2 r 6 m 2b m fd m 70 m 41 m 3 m 80 m
notbusy
20 wcmd 8 m e0 m 0 m notbusy \ 0x8e000
02 wcmd 8 m e0 m 0 m \ 0x8e000 
70 m 41 m 32 m 0 2 r 6 m 2b m 7d m 78 m 41 m 3 m 0 m 78 m 41 m 33 m 0 2 r 6 m 2b m fd m 7f m 41 m 3 m 80 m 7f m 41 m 34 m 0 2
r 6 m 2b m 7d m 87 m 41 m 3 m 0 m 87 m 41 m 35 m 0 2 r 6 m 2b m fd m 8e m 41 m 3 m 80 m 8e m 41 m 36 m 0 2 r 6 m 2b m 7d m 96
m 41 m 3 m 0 m 96 m 41 m 37 m 0 2 r 6 m 2b m fd m 9d m 41 m 3 m 80 m 9d m 41 m 38 m 0 2 r 6 m 2b m 7d m a5 m 41 m 3 m 0 m a5 m
41 m 39 m 0 2 r 6 m 2b m fd m ac m 41 m 3 m 80 m ac m 41 m 3a m 0 2 r 6 m 2b m 7d m b4 m 41 m 3 m 0 m b4 m 41 m 3b m 0 2 r 6 m
2b m fd m bb m 41 m 3 m 80 m bb m 41 m 3c m 0 2 r 6 m 2b m 7d m c3 m 41 m 3 m 0 m c3 m 41 m 3d m 0 2 r 6 m 2b m fd m ca m 41 m
3 m 80 m ca m 41 m 3e m 0 2 r 6 m 2b m 7d m d2 m 41 m 3 m 0 m d2 m 41 m 3f m 0 2 r 6 m 2b m fd m d9 m 41 m 3 m 80 m d9 m 41 m
40 m 0 2 r 6 m 2b m 7d m e1 m 41 m 3 m 0 m e1 m 41 2 r 0 2 r 6 m 2b m fd m e8 m 41 m 3 m 80 m e8 m 41 m 42 m 0 2 r 6 m 2b m 7d
m f0 m 41 m 3 m 0 m f0 m 41 m 43 m 0 2 r 6 m 2b m fd m f7 m 41 m 3 m 80 m f7 m 41 m 44 m 0 2 r 6 m 2b m 7d m ff m 41 m 3 m 0 m
ff m 41 m 45 m 0 2 r 6 m 2b m fd m 6 m 42 m 3 m 80 m 6 m 42 m 46 m 0 2 r 6 m 2b m 7d m e m 42 m 3 m 0 m e m 42 m 47 m 0 m
notbusy
02 wcmd 8 m e1 m 0 m \ 0x8e100 
0 m 6 m 2b m fd m 15 m 42 m 3 m 80 m 15 m 42 m 48 m 0 2 r 6 m 2b m 7d m 1d m 42 m 3 m 0 m 1d m 42 m 49 m 0 2 r 6 m 2b m fd m
24 m 42 m 3 m 80 m 24 m 42 m 4a m 0 2 r 6 m 2b m 7d m 2c m 42 m 3 m 0 m 2c m 42 m 4b m 0 2 r 6 m 2b m fd m 33 m 42 m 3 m 80 m
33 m 42 m 4c m 0 2 r 6 m 2b m 7d m 3b m 42 m 3 m 0 m 3b m 42 m 4d m 0 2 r 6 m 2b m fd m 42 2 r 3 m 80 m 42 2 r 4e m 0 2 r 6 m
2b m 7d m 4a m 42 m 3 m 0 m 4a m 42 m 4f m 0 2 r 6 m 2b m fd m 51 m 42 m 3 m 80 m 51 m 42 m 50 m 0 2 r 6 m 2b m 7d m 59 m 42 m
3 m 0 m 59 m 42 m 51 m 0 2 r 6 m 2b m fd m 60 m 42 m 3 m 80 m 60 m 42 m 52 m 0 2 r 6 m 2b m 7d m 68 m 42 m 3 m 0 m 68 m 42 m
53 m 0 2 r 6 m 2b m fd m 6f m 42 m 3 m 80 m 6f m 42 m 54 m 0 2 r 6 m 2b m 7d m 77 m 42 m 3 m 0 m 77 m 42 m e m 0 2 r 20 m 1d m
0 2 r b m 0 3 r 22 m 1 m 0 2 r 5 m 0 m 80 m 0 m 1 m 0 2 r 2 m 15 m 93 m 4 m 2 m 19 m 0 3 r 25 m 0 3 r 6 m 28 m fd m 0 m 40 m 0
m 80 m 0 m 40 m 1 m 0 2 r 6 m 28 m 7d m 8 m 40 m 0 2 r 8 m 40 m 2 m 0 2 r 6 m 28 m fd m f m 40 m 0 m 80 m f m 40 m 3 m 0 2 r 6
m 28 m 7d m 17 m 40 m 0 2 r 17 m 40 m 4 m 0 2 r 6 m 28 m fd m 1e m 40 m 0 m 80 m notbusy
02 wcmd 8 m e2 m 0 m \ 0x8e200 
1e m 40 m 5 m 0 2 r 6 m 28 m 7d m 26 m 40 m 0 2 r 26 m 40 m 6 m 0 2 r 6 m 28 m fd m 2d m 40 m 0 m 80 m 2d m 40 m 7 m 0 2 r 6 m
28 m 7d m 35 m 40 m 0 2 r 35 m 40 m 8 m 0 2 r 6 m 28 m fd m 3c m 40 m 0 m 80 m 3c m 40 m 9 m 0 2 r 6 m 28 m 7d m 44 m 40 m 0 2
r 44 m 40 m a m 0 2 r 6 m 28 m fd m 4b m 40 m 0 m 80 m 4b m 40 m b m 0 2 r 6 m 28 m 7d m 53 m 40 m 0 2 r 53 m 40 m c m 0 2 r 6
m 28 m fd m 5a m 40 m 0 m 80 m 5a m 40 m d m 0 2 r 6 m 28 m 7d m 62 m 40 m 0 2 r 62 m 40 m e m 0 2 r 6 m 28 m fd m 69 m 40 m 0
m 80 m 69 m 40 m f m 0 2 r 6 m 28 m 7d m 71 m 40 m 0 2 r 71 m 40 m 10 m 0 2 r 6 m 28 m fd m 78 m 40 m 0 m 80 m 78 m 40 m 11 m
0 2 r 6 m 28 m 7d m 80 m 40 m 0 2 r 80 m 40 m 12 m 0 2 r 6 m 28 m fd m 87 m 40 m 0 m 80 m 87 m 40 m 13 m 0 2 r 6 m 28 m 7d m
8f m 40 m 0 2 r 8f m 40 m 14 m 0 2 r 6 m 28 m fd m 96 m 40 m 0 m 80 m 96 m 40 m 15 m 0 2 r 6 m 28 m 7d m 9e m 40 m 0 2 r 9e m
40 m 16 m 0 2 r 6 m 28 m fd m a5 m 40 m 0 m 80 m a5 m 40 m 17 m 0 2 r 6 m 28 m 7d m ad m 40 m 0 2 r ad m 40 m 18 m 0 2 r 6 m
28 m fd m b4 m 40 m 0 m 80 m b4 m 40 m 19 m 0 2 r 6 m 28 m 7d m bc m 40 m 0 2 r bc m 40 m 1a m 0 m notbusy
02 wcmd 8 m e3 m 0 m \ 0x8e300 
0 m 6 m 28 m fd m c3 m 40 m 0 m 80 m c3 m 40 m 1b m 0 2 r 6 m 28 m 7d m cb m 40 m 0 2 r cb m 40 m 1c m 0 2 r 6 m 28 m fd m d2
m 40 m 0 m 80 m d2 m 40 m 1d m 0 2 r 6 m 28 m 7d m da m 40 m 0 2 r da m 40 m 1e m 0 2 r 6 m 28 m fd m e1 m 40 m 0 m 80 m e1 m
40 m 1f m 0 2 r 6 m 28 m 7d m e9 m 40 m 0 2 r e9 m 40 m 20 m 0 2 r 6 m 28 m fd m f0 m 40 m 0 m 80 m f0 m 40 m 21 m 0 2 r 6 m
28 m 7d m f8 m 40 m 0 2 r f8 m 40 m 22 m 0 2 r 6 m 28 m fd m ff m 40 m 0 m 80 m ff m 40 m 23 m 0 2 r 6 m 28 m 7d m 7 m 41 m 0
2 r 7 m 41 m 24 m 0 2 r 6 m 28 m fd m e m 41 m 0 m 80 m e m 41 m 25 m 0 2 r 6 m 28 m 7d m 16 m 41 m 0 2 r 16 m 41 m 26 m 0 2 r
6 m 28 m fd m 1d m 41 m 0 m 80 m 1d m 41 m 27 m 0 2 r 6 m 28 m 7d m 25 m 41 m 0 2 r 25 m 41 m 28 m 0 2 r 6 m 28 m fd m 2c m 41
m 0 m 80 m 2c m 41 m 29 m 0 2 r 6 m 28 m 7d m 34 m 41 m 0 2 r 34 m 41 m 2a m 0 2 r 6 m 28 m fd m 3b m 41 m 0 m 80 m 3b m 41 m
2b m 0 2 r 6 m 28 m 7d m 43 m 41 m 0 2 r 43 m 41 m 2c m 0 2 r 6 m 28 m fd m 4a m 41 m 0 m 80 m 4a m 41 m 2d m 0 2 r 6 m 28 m
7d m 52 m 41 m 0 2 r 52 m 41 m 2e m 0 2 r 6 m 28 m fd m 59 m 41 m 0 m 80 m 59 m 41 m 2f m 0 2 r 6 m 28 m 7d m notbusy
02 wcmd 8 m e4 m 0 m \ 0x8e400 
61 m 41 m 0 2 r 61 m 41 m 30 m 0 2 r 6 m 28 m fd m 68 m 41 m 0 m 80 m 68 m 41 m 31 m 0 2 r 6 m 28 m 7d m 70 m 41 m 0 2 r 70 m
41 m 32 m 0 2 r 6 m 28 m fd m 77 m 41 m 0 m 80 m 77 m 41 m 33 m 0 2 r 6 m 28 m 7d m 7f m 41 m 0 2 r 7f m 41 m 34 m 0 2 r 6 m
28 m fd m 86 m 41 m 0 m 80 m 86 m 41 m 35 m 0 2 r 6 m 28 m 7d m 8e m 41 m 0 2 r 8e m 41 m 36 m 0 2 r 6 m 28 m fd m 95 m 41 m 0
m 80 m 95 m 41 m 37 m 0 2 r 6 m 28 m 7d m 9d m 41 m 0 2 r 9d m 41 m 38 m 0 2 r 6 m 28 m fd m a4 m 41 m 0 m 80 m a4 m 41 m 39 m
0 2 r 6 m 28 m 7d m ac m 41 m 0 2 r ac m 41 m 3a m 0 2 r 6 m 28 m fd m b3 m 41 m 0 m 80 m b3 m 41 m 3b m 0 2 r 6 m 28 m 7d m
bb m 41 m 0 2 r bb m 41 m 3c m 0 2 r 6 m 28 m fd m c2 m 41 m 0 m 80 m c2 m 41 m 3d m 0 2 r 6 m 28 m 7d m ca m 41 m 0 2 r ca m
41 m 3e m 0 2 r 6 m 28 m fd m d1 m 41 m 0 m 80 m d1 m 41 m 3f m 0 2 r 6 m 28 m 7d m d9 m 41 m 0 2 r d9 m 41 m 40 m 0 2 r 6 m
28 m fd m e0 m 41 m 0 m 80 m e0 m 41 2 r 0 2 r 6 m 28 m 7d m e8 m 41 m 0 2 r e8 m 41 m 42 m 0 2 r 6 m 28 m fd m ef m 41 m 0 m
80 m ef m 41 m 43 m 0 2 r 6 m 28 m 7d m f7 m 41 m 0 2 r f7 m 41 m 44 m 0 2 r 6 m 28 m fd m fe m 41 m 0 m 80 m notbusy
02 wcmd 8 m e5 m 0 m \ 0x8e500 
fe m 41 m 45 m 0 2 r 6 m 28 m 7d m 6 m 42 m 0 2 r 6 m 42 m 46 m 0 2 r 6 m 28 m fd m d m 42 m 0 m 80 m d m 42 m 47 m 0 2 r 6 m
28 m 7d m 15 m 42 m 0 2 r 15 m 42 m 48 m 0 2 r 6 m 28 m fd m 1c m 42 m 0 m 80 m 1c m 42 m 49 m 0 2 r 6 m 28 m 7d m 24 m 42 m 0
2 r 24 m 42 m 4a m 0 2 r 6 m 28 m fd m 2b m 42 m 0 m 80 m 2b m 42 m 4b m 0 2 r 6 m 28 m 7d m 33 m 42 m 0 2 r 33 m 42 m 4c m 0
2 r 6 m 28 m fd m 3a m 42 m 0 m 80 m 3a m 42 m 4d m 0 2 r 6 m 28 m 7d m 42 2 r 0 2 r 42 2 r 4e m 0 2 r 6 m 28 m fd m 49 m 42 m
0 m 80 m 49 m 42 m 4f m 0 2 r 6 m 28 m 7d m 51 m 42 m 0 2 r 51 m 42 m 50 m 0 2 r 6 m 28 m fd m 58 m 42 m 0 m 80 m 58 m 42 m 51
m 0 2 r 6 m 28 m 7d m 60 m 42 m 0 2 r 60 m 42 m 52 m 0 2 r 6 m 28 m fd m 67 m 42 m 0 m 80 m 67 m 42 m 53 m 0 2 r 6 m 28 m 7d m
6f m 42 m 0 2 r 6f m 42 m 54 m 0 2 r 6 m 28 m fd m 76 m 42 m 0 m 80 m 76 m 42 m 0 3 r 23 m 0 4 r 1 m ff 3 r 0 m ff 3 r 26 m ff
3 r 1d m ff 3 r 0 2 r 1 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 0 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 44
m 91 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m e6 m 0 m \ 0x8e600 
0 2 r 10 2 r 0 2 r 1d m ff 3 r f8 m 24 m 1 m 0 m e0 m 11 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 34 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0
2 r 1a m ff 3 r 78 m 91 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r f0 m 49 m 1 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3
r 68 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r ac m 91 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 64 m 26 m 1 m 0 m ea m
41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 36 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 7a m 91 m 0 2 r 2 m 0 3 r 10 2 r 0 2
r 1d m ff 3 r 5c m 4b m 1 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 6a m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r
ae m 91 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 54 m 70 m 1 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 9e m 80 m 0 2
r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r e2 m 91 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r c8 m 4c m 1 m 0 m ea m 41 m notbusy
02 wcmd 8 m e7 m 0 m \ 0x8e700 
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 6c m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r b0 m 91 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d
m ff 3 r c0 m 71 m 1 m 0 m 1c m 14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r a0 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r e4 m
91 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r b8 m 96 m 1 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r d4 m 80 m 0 2 r 2 m
0 3 r ff 2 r 0 2 r 1a m ff 3 r 18 m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 2c m 73 m 1 m 0 m ea m 41 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r a2 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r e6 m 91 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 24 m 98
m 1 m 0 m 3a m 15 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r d6 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 1a m 92 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r 1c m bd m 1 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r a m 81 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m e8 m 0 m \ 0x8e800 
0 2 r ff 2 r 0 2 r 1a m ff 3 r 4e m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 90 m 99 m 1 m 0 m ea m 41 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r d8 m 80 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 1c m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 88 m be
m 1 m 0 m 58 m 16 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r c m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 50 m 92 m 0 2 r 2 m 0 3
r 10 2 r 0 2 r 1d m ff 3 r 80 m e3 m 1 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 40 m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r
1a m ff 3 r 84 m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r f4 m bf m 1 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r e
m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 52 m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r ec m e4 m 1 m 0 m 76 m 17 m
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 42 m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 86 m 92 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m e9 m 0 m \ 0x8e900 
0 2 r 10 2 r 0 2 r 1d m ff 3 r e4 m 9 m 2 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 76 m 81 m 0 2 r 2 m 0 3 r ff 2 r 0
2 r 1a m ff 3 r ba m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 58 m e6 m 1 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3
r 44 m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 88 m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 50 m b m 2 m 0 m 94 m
18 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 78 m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r bc m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2
r 1d m ff 3 r 48 m 30 m 2 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r ac m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r
f0 m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r bc m c m 2 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 7a m 81 m 0 2 r
2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r be m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r b4 m 31 m 2 m 0 m b2 m 19 m notbusy
02 wcmd 8 m ea m 0 m \ 0x8ea00 
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r ae m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r f2 m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d
m ff 3 r ac m 56 m 2 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r e2 m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 26 m
93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 20 m 33 m 2 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r b0 m 81 m 0 2 r 2 m
0 3 r ff 2 r 0 2 r 1a m ff 3 r f4 m 92 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 18 m 58 m 2 m 0 m d0 m 1a m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r e4 m 81 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 28 m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 10 m 7d
m 2 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 18 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 5c m 93 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r 84 m 59 m 2 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r e6 m 81 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m eb m 0 m \ 0x8eb00 
0 2 r ff 2 r 0 2 r 1a m ff 3 r 2a m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 7c m 7e m 2 m 0 m ee m 1b m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r 1a m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 5e m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 74 m a3
m 2 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 4e m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 92 m 93 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r e8 m 7f m 2 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 1c m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2
r 1a m ff 3 r 60 m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r e0 m a4 m 2 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r
50 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 94 m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r d8 m c9 m 2 m 0 m e0 m
11 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 84 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r c8 m 93 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m ec m 0 m \ 0x8ec00 
0 2 r 10 2 r 0 2 r 1d m ff 3 r d0 m ee m 2 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r b8 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0
2 r 1a m ff 3 r fc m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 4c m a6 m 2 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3
r 52 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 96 m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 44 m cb m 2 m 0 m fe m
12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 86 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r ca m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2
r 1d m ff 3 r 3c m f0 m 2 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r ba m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r
fe m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 34 m 15 m 3 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r ee m 82 m 0 2
r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 32 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r b0 m cc m 2 m 0 m ea m 41 m notbusy
02 wcmd 8 m ed m 0 m \ 0x8ed00 
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 88 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r cc m 93 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d
m ff 3 r a8 m f1 m 2 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r bc m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 0 m
94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r a0 m 16 m 3 m 0 m 1c m 14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r f0 m 82 m 0 2 r 2 m
0 3 r ff 2 r 0 2 r 1a m ff 3 r 34 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 98 m 3b m 3 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r 24 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 68 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 14 m f3
m 2 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r be m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 2 m 94 m 0 2 r 2 m 0 3
r 10 2 r 0 2 r 1d m ff 3 r c m 18 m 3 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r f2 m 82 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m ee m 0 m \ 0x8ee00 
0 2 r ff 2 r 0 2 r 1a m ff 3 r 36 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 4 m 3d m 3 m 0 m 3a m 15 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r 26 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 6a m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r fc m 61
m 3 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 5a m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 9e m 94 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r 78 m 19 m 3 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r f4 m 82 m 0 2 r 2 m 0 3 r ff 2 r 0 2
r 1a m ff 3 r 38 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 70 m 3e m 3 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r
28 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 6c m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 68 m 63 m 3 m 0 m 58 m
16 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 5c m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r a0 m 94 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m ef m 0 m \ 0x8ef00 
0 2 r 10 2 r 0 2 r 1d m ff 3 r 60 m 88 m 3 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 90 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0
2 r 1a m ff 3 r d4 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r dc m 3f m 3 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3
r 2a m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 6e m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r d4 m 64 m 3 m 0 m fe m
12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 5e m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r a2 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2
r 1d m ff 3 r cc m 89 m 3 m 0 m 76 m 17 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 92 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r
d6 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r c4 m ae m 3 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r c6 m 83 m 0 2
r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r a m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 40 m 66 m 3 m 0 m ea m 41 m notbusy
20 wcmd 8 m f0 m 0 m notbusy \ 0x8f000
02 wcmd 8 m f0 m 0 m \ 0x8f000 
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 60 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r a4 m 94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d
m ff 3 r 38 m 8b m 3 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 94 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r d8 m
94 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 30 m b0 m 3 m 0 m 94 m 18 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r c8 m 83 m 0 2 r 2 m
0 3 r ff 2 r 0 2 r 1a m ff 3 r c m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 28 m d5 m 3 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r fc m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 40 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r a4 m 8c
m 3 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 96 m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r da m 94 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r 9c m b1 m 3 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r ca m 83 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m f1 m 0 m \ 0x8f100 
0 2 r ff 2 r 0 2 r 1a m ff 3 r e m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 94 m d6 m 3 m 0 m b2 m 19 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r fe m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 42 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 8c m fb
m 3 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 32 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 76 m 95 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r 8 m b3 m 3 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r cc m 83 m 0 2 r 2 m 0 3 r ff 2 r 0 2
r 1a m ff 3 r 10 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 0 m d8 m 3 m 0 m fe m 12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 0
m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 44 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r f8 m fc m 3 m 0 m d0 m 1a m
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 34 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 78 m 95 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m f2 m 0 m \ 0x8f200 
0 2 r 10 2 r 0 2 r 1d m ff 3 r f0 m 21 m 4 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 68 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0
2 r 1a m ff 3 r ac m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 6c m d9 m 3 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3
r 2 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 46 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 64 m fe m 3 m 0 m fe m
12 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 36 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 7a m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2
r 1d m ff 3 r 5c m 23 m 4 m 0 m ee m 1b m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 6a m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r
ae m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 54 m 48 m 4 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 9e m 84 m 0 2
r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r e2 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r d0 m ff m 3 m 0 m ea m 41 m notbusy
02 wcmd 8 m f3 m 0 m \ 0x8f300 
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 38 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 7c m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d
m ff 3 r c8 m 24 m 4 m 0 m 1c m 14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 6c m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r b0 m
95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r c0 m 49 m 4 m 0 m e0 m 11 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r a0 m 84 m 0 2 r 2 m
0 3 r ff 2 r 0 2 r 1a m ff 3 r e4 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r b8 m 6e m 4 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r d4 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 18 m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 34 m 26
m 4 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 6e m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r b2 m 95 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r 2c m 4b m 4 m 0 m 1c m 14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r a2 m 84 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m f4 m 0 m \ 0x8f400 
0 2 r ff 2 r 0 2 r 1a m ff 3 r e6 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 24 m 70 m 4 m 0 m fe m 12 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r d6 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 1a m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 1c m 95
m 4 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r a m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 4e m 96 m 0 2 r 2 m 0 3
r 10 2 r 0 2 r 1d m ff 3 r 98 m 4c m 4 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r a4 m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r
1a m ff 3 r e8 m 95 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 90 m 71 m 4 m 0 m 1c m 14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r d8
m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 1c m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 88 m 96 m 4 m 0 m 1c m 14 m
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r c m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 50 m 96 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m f5 m 0 m \ 0x8f500 
0 2 r 10 2 r 0 2 r 1d m ff 3 r 80 m bb m 4 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 40 m 85 m 0 2 r 2 m 0 3 r ff 2 r 0
2 r 1a m ff 3 r 84 m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r fc m 72 m 4 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3
r da m 84 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 1e m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r f4 m 97 m 4 m 0 m 1c m
14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r e m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 52 m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r
1d m ff 3 r ec m bc m 4 m 0 m 3a m 15 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 42 m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 86
m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r e4 m e1 m 4 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 76 m 85 m 0 2 r 2
m 0 3 r ff 2 r 0 2 r 1a m ff 3 r ba m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 60 m 99 m 4 m 0 m ea m 41 m notbusy
02 wcmd 8 m f6 m 0 m \ 0x8f600 
0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 10 m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 54 m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d
m ff 3 r 58 m be m 4 m 0 m 1c m 14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 44 m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 88 m
96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 50 m e3 m 4 m 0 m 58 m 16 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 78 m 85 m 0 2 r 2 m
0 3 r ff 2 r 0 2 r 1a m ff 3 r bc m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r 48 m 8 m 5 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r ac m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r f0 m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r c4 m bf
m 4 m 0 m ea m 41 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 46 m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 8a m 96 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r 1d m ff 3 r bc m e4 m 4 m 0 m 1c m 14 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r 7a m 85 m 0 2 r 2 m 0 m notbusy
02 wcmd 8 m f7 m 0 m \ 0x8f700 
0 2 r ff 2 r 0 2 r 1a m ff 3 r be m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r b4 m 9 m 5 m 0 m 76 m 17 m 0 2 r 1e m 1 m 0
2 r 1a m ff 3 r ae m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r f2 m 96 m 0 2 r 2 m 0 3 r 10 2 r 0 2 r 1d m ff 3 r ac m 2e
m 5 m 0 m 26 m 44 m 0 2 r 1e m 1 m 0 2 r 1a m ff 3 r e2 m 85 m 0 2 r 2 m 0 3 r ff 2 r 0 2 r 1a m ff 3 r 26 m 97 m 0 2 r 2 m 0
3 r 10 2 r 0 2 r notbusy
$8f776. fl.check \ expect 293
decimal
