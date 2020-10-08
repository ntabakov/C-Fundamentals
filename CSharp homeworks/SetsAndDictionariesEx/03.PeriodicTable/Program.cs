using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                for (int k = 0; k < input.Length; k++)
                {

                    set.Add(input[k]);
                }
            }

            set = set.OrderBy(x => x).ToHashSet();
            Console.WriteLine(String.Join(" ",set));
        }
    }
}
