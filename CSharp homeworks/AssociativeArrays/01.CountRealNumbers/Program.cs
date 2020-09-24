using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, double> numOrder = new SortedDictionary<double, double>();

            foreach (var number in nums)
            {
                if (numOrder.ContainsKey(number))
                {
                    numOrder[number]+= 1;
                }
                else
                {
                    numOrder.Add(number, 1);
                }
            }
            foreach (var item in numOrder)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }

        }
    }
}
