using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> func = n => 
            {
                int minNum = int.MaxValue;
                foreach (var item in n)
                {
                    if (item < minNum)
                    {
                        minNum = item;
                    }
                }
                return minNum;
            };
            Console.WriteLine(func(input));
        }
    }
}
