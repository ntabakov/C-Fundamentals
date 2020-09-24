using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{DivideTwoFactorialNumbers(n1,n2):f2}");
        }

        static double DivideTwoFactorialNumbers(double n1, double n2)
        {
            double numOne = 1;
            double numTwo = 1;
            for (int i = 1; i <= n1; i++)
            {
                numOne *= i;
            }
            for (int i = 1; i <= n2; i++)
            {
                numTwo *= i;
            }
            return numOne / numTwo;
        }
    }
}
