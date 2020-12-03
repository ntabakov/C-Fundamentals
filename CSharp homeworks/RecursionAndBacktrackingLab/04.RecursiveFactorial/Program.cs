using System;

namespace _04.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialCalc(num));

        }

        static int FactorialCalc(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * FactorialCalc(n -= 1);
        }
    }
}
