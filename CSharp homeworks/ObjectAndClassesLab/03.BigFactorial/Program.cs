using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigFactorial test = new BigFactorial();
            test.x = int.Parse(Console.ReadLine());
            test.CalculateFactorial();

        }

        public class BigFactorial
        {
            public int x;

            public void CalculateFactorial()
            {
                BigInteger num = 1;
                for (int i = 1; i <= this.x; i++)
                {
                    num *= i;
                }
                Console.WriteLine(num);
            }
        }

    }
}
