using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = SumOfDigits(i);
                if (NumberDivisibleByEight(sum) == true && OddDigit(i) == true)
                {
                    Console.WriteLine(i);
                }

            }
        }

        static int SumOfDigits(int n)
        {
            //43
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        static bool NumberDivisibleByEight(int n)
        {
            bool isDivisible = false;
            if (n % 8 == 0)
            {
                isDivisible = true;
            }

            return isDivisible;
        }

        static bool OddDigit(int n)
        {
            int number = n;
            int temp = 0;
            bool odd = false;

            while (number > 0)
            {
                temp = number % 10;
                if (temp % 2 == 1)
                {
                    odd = true;
                }
                number /= 10;
            }
            return odd;
        }
    }
}
