using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split()
                .Select(n=>$"Sir {n}").ToArray();

            Action<string[]> print = x => Console.WriteLine(String.Join(Environment.NewLine,x));
            print(input);
        }
    }
}
