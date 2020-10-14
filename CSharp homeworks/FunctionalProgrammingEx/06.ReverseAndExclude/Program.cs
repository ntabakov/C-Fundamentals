using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Reverse();
            int n = int.Parse(Console.ReadLine());
            Func<int, bool> func = x => x % n != 0;
            list = list.Where(func).ToList();
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
