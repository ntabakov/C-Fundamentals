using System;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            byte second = byte.Parse(Console.ReadLine());

            Console.WriteLine(int.Parse(first)*second);

        }
    }
}
