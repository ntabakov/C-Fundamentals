#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include <math.h>

int main()
{
    int dice1;
    int dice2;
    int dice3;
    int dice4;
    int dice5;
    int dice6;


    int sumold;
    int playerOneSum=0, playerTwoSum=0, AIsum=0;
    int igrachi;

    printf("Kolko igrachi shte ima? 1 ili 2?:");
    scanf_s("%d" ,  &igrachi);
    srand(time(NULL));
    if (igrachi > 2) {
        return 0;
    }
    if (igrachi == 1) 
    {
        while (playerOneSum <1500 || AIsum <1500)
        {
            dice1 = (rand() % 6) + 1;
            dice2 = (rand() % 6) + 1;
            dice3 = (rand() % 6) + 1;

            if (dice1 == dice2 && dice1 == dice3 && dice3 == dice2) {
                sumold = 400;
            }
            else if (dice2 == dice1 + 1 && dice3 == dice2 + 1) {
                sumold = 200;
            }
            else if (dice1 == 2 && dice2 == 4 && dice3 == 6) {
                sumold = -200;
            }
            else {
                sumold = (dice1 + dice2 + dice3) * 10;
            }
            playerOneSum += sumold;
            printf("Igrach 1 hvyrli:\n%d    %d    %d\nTochkite na igrach 1 sa: %d\n", dice1, dice2, dice3, sumold);
            printf("\n");
            sumold = 0;
            if (playerOneSum >= 1500) {
                break;
            }
            
            ////////////////////////////////////////////////////////////////////////////////////
            dice4 = (rand() % 6) + 1;
            dice5 = (rand() % 6) + 1;
            dice6 = (rand() % 6) + 1;

            if (dice4 == dice5 && dice4 == dice6 && dice5 == dice6) {
                sumold = 400;
            }
            else if (dice5 == dice4 + 1 && dice6 == dice5 + 1) {
                sumold = 200;
            }
            else if (dice4 == 2 && dice5 == 4 && dice6 == 6) {
                sumold = -200;
            }
            else {
                sumold = (dice4 + dice5 + dice6) * 10;
            }
            AIsum += sumold;
            printf("AI hvyrli:\n%d    %d    %d\nTochkite na AI sa: %d\n", dice4, dice5, dice6, sumold);
            printf("\n");

            sumold = 0;
            if (AIsum >= 1500) {
                break;
            }

        }

    }
    else if (igrachi == 2) 
    {
        while (playerOneSum < 1500 || playerTwoSum < 1500)
        {
            dice1 = (rand() % 6) + 1;
            dice2 = (rand() % 6) + 1;
            dice3 = (rand() % 6) + 1;

            if (dice1 == dice2 && dice1 == dice3 && dice3 == dice2) {
                sumold = 400;
            }
            else if (dice2 == dice1 + 1 && dice3 == dice2 + 1) {
                sumold = 200;
            }
            else if (dice1 == 2 && dice2 == 4 && dice3 == 6) {
                sumold = -200;
            }
            else {
                sumold = (dice1 + dice2 + dice3) * 10;
            }
            playerOneSum += sumold;
            printf("Igrach 1 hvyrli:\n%d    %d    %d\nTochkite na igrach 1 sa: %d\n", dice1, dice2, dice3, sumold);
            printf("\n");

            sumold = 0;
            if (playerOneSum >= 1500) {
                break;
            }
            ////////////////////////////////////////////////////////////////////////
            dice4 = (rand() % 6) + 1;
            dice5 = (rand() % 6) + 1;
            dice6 = (rand() % 6) + 1;

            if (dice4 == dice5 && dice4 == dice6 && dice5 == dice6) {
                sumold = 400;
            }
            else if (dice5 == dice4 + 1 && dice6 == dice5 + 1) {
                sumold = 200;
            }
            else if (dice4 == 2 && dice5 == 4 && dice6 == 6) {
                sumold = -200;
            }
            else {
                sumold = (dice4 + dice5 + dice6) * 10;
            }
            playerTwoSum += sumold;
            printf("Igrach 2 hvyrli:\n%d    %d    %d\nTochkite na igrach 2 sa: %d\n", dice4, dice5, dice6, sumold);
            printf("\n");

            sumold = 0;
            if (playerTwoSum >= 1500) {
                break;
            }

        }
    }
    printf("Igrata priklyuchi!");

    if (playerOneSum >= 1500) {
        printf("Igrach 1 pecheli s: %d tochki!",playerOneSum);
    }
    else if (playerTwoSum >= 1500) {
        printf("Igrach 2 pecheli s: %d tochki!", playerTwoSum);
    }
    else if (AIsum >= 1500) {
        printf("AI pecheli s: %d tochki!", AIsum);

    }

    return 0;
}