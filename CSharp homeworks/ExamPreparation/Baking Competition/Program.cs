using System;

namespace Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());
            string particName = "";
            string desert = "";
            int desertCount = 0;

            int cookiesCount = 0;
            int cakesCount = 0;
            int wafflesCount = 0;

            int sumTotalBakery = 0;
            double totalCharitySum = 0;

            for (int i = 1; i <= participants; i++)
            {

                particName = Console.ReadLine();
                while (true)
                {
                    desert = Console.ReadLine();
                    if (desert == "Stop baking!")
                    {
                        break;
                    }
                    desertCount = int.Parse(Console.ReadLine());
                    switch (desert)
                    {
                        case "cookies":
                            cookiesCount += desertCount;
                            break;

                        case "cakes":
                            cakesCount += desertCount;
                            break;

                        case "waffles":
                            wafflesCount += desertCount;
                            break;
                    }

                }
                Console.WriteLine($"{particName} baked {cookiesCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");
                sumTotalBakery += cookiesCount + cakesCount + wafflesCount;
                totalCharitySum += cookiesCount * 1.50 + cakesCount * 7.80 + wafflesCount * 2.30;

                cookiesCount = 0;
                cakesCount = 0;
                wafflesCount = 0;
            }
            Console.WriteLine($"All bakery sold: {sumTotalBakery}");
            Console.WriteLine($"Total sum for charity: {totalCharitySum:f2} lv.");

        }
    }
}
