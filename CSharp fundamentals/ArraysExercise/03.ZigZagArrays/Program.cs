using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];
               


            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arrayOne[i] = numbers[0];
                    arrayTwo[i] = numbers[1];
                }
                else
                {
                    arrayTwo[i] = numbers[0];
                    arrayOne[i] = numbers[1];
                }

            }
            Console.Write(String.Join(" ", arrayOne));
            Console.WriteLine();
            Console.Write(String.Join(" ", arrayTwo));


        }
    }
}
