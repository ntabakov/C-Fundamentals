using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            // 1 2 3 4 5
            // 0 1 2 3 4

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                newList.Add(numbers[i] + numbers[numbers.Count - i - 1]);
            }
            if (numbers.Count % 2 == 1)
            {
                newList.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(String.Join(' ', newList));
        }
    }
}
