using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = Math.Max(firstList.Count, secondList.Count);
            List<int> end = new List<int>();

            for (int i = 0; i < max; i++)
            {
                if (i < firstList.Count)
                {
                    end.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    end.Add(secondList[i]);
                }
            }
            Console.WriteLine(String.Join(' ',end));
        }
    }
}
