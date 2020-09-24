#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include <math.h>
int main() {
    int dice1;
    int dice2;
    int dice3;
    int sumold;




    srand(time(NULL));
    dice1 = (rand() % 6) + 1;
    dice2 = (rand() % 6) + 1;
    dice3 = (rand() % 6) + 1;
    sumold = dice110 + dice210 + dice3 * 10;

    printf("Hvurlihte:\n%d    %d    %d\nTochkite vi sa: %d\n", dice1, dice2, dice3, sumold);


    printf("Prikluchihte igrata!");
    return 0;
}