// Example program

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>


int function(char key, int size)
{
    int result = 0;
    result = (key << 3) ^ (key >> 8) ^ key;
    return result % size;
}

void main(void)
{
    int r;

    r = function('d', 10);
    printf("\n    %d   ", r);
    getch();
}