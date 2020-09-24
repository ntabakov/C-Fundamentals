using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoeple = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine((double)(Math.Ceiling(numberOfPoeple / (double)capacity)));


        }
    }
}
