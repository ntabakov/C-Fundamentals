using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> greaterNumber = new List<int>();

            double averageNumber = numbers.Sum() * 1.0 / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNumber)
                {
                    greaterNumber.Add(numbers[i]);
                }
            }

            greaterNumber.Sort();
            greaterNumber.Reverse();
            
            if(greaterNumber.Count> 5)
            {
                greaterNumber.RemoveRange(5, greaterNumber.Count - 5);
                Console.WriteLine(String.Join(' ',greaterNumber));
            }
            else if (greaterNumber.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(String.Join(' ', greaterNumber));

            }

        }
    }
}
