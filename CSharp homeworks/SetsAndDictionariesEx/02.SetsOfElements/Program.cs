using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();



            for (int i = 0; i < n[0]; i++)
            {
                setOne.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n[1]; i++)
            {
                setTwo.Add(int.Parse(Console.ReadLine()));
            }
            setOne.IntersectWith(setTwo);
            Console.WriteLine(String.Join(" ",setOne));

        }
    }
}
