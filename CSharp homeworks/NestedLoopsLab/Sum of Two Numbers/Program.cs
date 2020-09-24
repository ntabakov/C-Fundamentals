using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combCount = 0;
            bool test = false;
            for (int i = num1; i <= num2; i++)
            {
                for (int t = num1; t <= num2; t++)
                {
                    combCount++;

                    if (i + t == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combCount} ({i} + {t} = {magicNum})");
                        test = true;
                        break;
                    }

                  
                }
                if (test)
                {
                    break;
                }
            }
            if (test)
            {

            }
            else
            {
                Console.WriteLine($"{combCount} combinations - neither equals {magicNum}");

            }



        }
    }
}
