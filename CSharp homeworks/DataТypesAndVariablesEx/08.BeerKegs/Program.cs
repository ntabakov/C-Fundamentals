using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = double.MinValue;
            string biggestKeg = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);
                if(volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
