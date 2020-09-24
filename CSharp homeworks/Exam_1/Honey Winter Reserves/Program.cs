using System;

namespace Honey_Winter_Reserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantity = double.Parse(Console.ReadLine());
            double totalHoney = 0;

            while (true)
            {
                string beeName = Console.ReadLine();
                if (beeName == "Winter has come")
                {
                    break;
                }
                for (int i = 1; i <= 6; i++)
                {
                    double workedHoney = double.Parse(Console.ReadLine());
                    totalHoney += workedHoney;
                }
                if (totalHoney < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                }
                if (totalHoney >= quantity)
                {
                    break;
                }

            }
            if (totalHoney >= quantity)
            {
                Console.WriteLine($"Well done! Honey surplus {totalHoney - quantity:f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {quantity - totalHoney:f2}.");
            }


        }
    }
}
