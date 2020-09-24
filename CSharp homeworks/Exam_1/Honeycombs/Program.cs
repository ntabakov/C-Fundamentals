using System;

namespace Honeycombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int flowers = int.Parse(Console.ReadLine());

            double honeycomb = 0;

            double totalHoney = bees * flowers * 0.21;

            honeycomb = Math.Floor(totalHoney / 100);
            Console.WriteLine($"{honeycomb} honeycombs filled.");

            double left = totalHoney- honeycomb * 100;
            Console.WriteLine($"{left:f2} grams of honey left.");


        }
    }
}
