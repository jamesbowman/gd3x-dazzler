#include <stdio.h>

#pragma output CRT_ORG_CODE = 0x8000
#pragma output CRT_REGISTER_SP = 0xFC00

main() {
  int i;
  for (i = 0; i < 20; i++)
    printf("Hello world %d\n", i);
}
