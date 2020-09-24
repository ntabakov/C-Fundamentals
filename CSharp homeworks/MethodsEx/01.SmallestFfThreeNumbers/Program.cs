using System;

namespace _01.SmallestFfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            SmallestNumberOfThree(n1, n2, n3);



        }

        static void SmallestNumberOfThree(int numberOne, int numberTwo, int numberThree)
        {
            int small = int.MaxValue;
            if( numberOne < small)
            {
                small = numberOne;
            }
            if (numberTwo < small)
            {
                small = numberTwo;
            }
            if (numberThree < small)
            {
                small = numberThree;
            }

            Console.WriteLine(small);
        }
    }
}
