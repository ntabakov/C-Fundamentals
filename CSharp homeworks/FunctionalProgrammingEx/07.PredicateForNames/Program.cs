using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split()
                .Where(x => x.Length <= n).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine,input));
            
        }
    }
}
