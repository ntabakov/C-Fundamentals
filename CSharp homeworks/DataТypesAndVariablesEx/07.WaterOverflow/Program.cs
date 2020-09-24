using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litters = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                litters = int.Parse(Console.ReadLine());
                sum += litters;
                if(sum > 255 )
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litters;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
