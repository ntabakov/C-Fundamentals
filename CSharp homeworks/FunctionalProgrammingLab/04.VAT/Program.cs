using System;
using System.Linq;

namespace _04.VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => x= x* 1.2)
                .ToArray();
            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
