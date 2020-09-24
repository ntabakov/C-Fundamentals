using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 1 4 3 2

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int k = 1 + i; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    if (count == array.Length - 1 - i)
                    {
                        Console.Write(array[i] + " ");
                    }
                }

            }
            Console.Write(array[array.Length - 1]);

        }
    }
}
