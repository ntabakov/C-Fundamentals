using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int n = int.Parse(number);

            int digit = n;

            int tempSum = 1;
            int sum = 0;

            for (int i = 1; i <= number.Length; i++)
            {
                digit = n % 10;
                n = n / 10;
                for (int j = 1; j <= digit; j++)
                {
                    tempSum *= j;
                }
                digit = n;
                sum += tempSum;

                tempSum = 1;
            }
            if (sum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }

        }
    }
}
