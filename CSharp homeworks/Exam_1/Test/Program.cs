using System;

namespace _06._Honey_Winter_Reserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double neobhodimMed = double.Parse(Console.ReadLine());
            string ime = Console.ReadLine();

            double sum = 0;
            double med = 0;
            while (ime != "Winter has come")
            {
                for (int i = 1; i <= 6; i++)
                {
                    med = double.Parse(Console.ReadLine());
                    sum += med;
                }
                if (sum < 0)
                {
                    Console.WriteLine($"{ime} was banished for gluttony");
                }
                if (sum >= neobhodimMed)
                {
                    break;
                }

                ime = Console.ReadLine();
            }
            if (sum >= neobhodimMed)
            {
                Console.WriteLine($"Well done! Honey surplus {(sum - neobhodimMed):f2}.");

            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {(neobhodimMed - sum):f2}.");
            }
        }
    }
}