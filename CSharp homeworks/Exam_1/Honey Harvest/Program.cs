using System;

namespace Honey_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double honey = 0;

            switch (season)
            {
                case "Summer":
                    switch (flowerType)
                    {
                        case "Sunflower":
                            honey = 8 * flowerCount;
                            honey = honey + honey * 0.10;
                            break;

                        case "Daisy":
                            honey = 8 * flowerCount;
                            honey = honey + honey * 0.10;
                            break;

                        case "Lavender":
                            honey = 8 * flowerCount;
                            honey = honey + honey * 0.10;
                            break;

                        case "Mint":
                            honey = 12 * flowerCount;
                            honey = honey + honey * 0.10;
                            break;
                    }
                    break;

                case "Autumn":
                    switch (flowerType)
                    {
                        case "Sunflower":
                            honey = 12 * flowerCount;
                            honey = honey * 0.95;
                            break;

                        case "Daisy":
                            honey = 6 * flowerCount;
                            honey = honey * 0.95;
                            break;

                        case "Lavender":
                            honey = 6 * flowerCount;
                            honey = honey * 0.95;
                            break;

                        case "Mint":
                            honey = 6 * flowerCount;
                            honey = honey * 0.95;
                            break;
                    }
                    break;

                case "Spring":
                    switch (flowerType)
                    {
                        case "Sunflower":
                            honey = 10 * flowerCount;
                            break;

                        case "Daisy":
                            honey = 12 * flowerCount;
                            honey = honey + honey * 0.10;
                            break;

                        case "Lavender":
                            honey = 12 * flowerCount;
                            break;

                        case "Mint":
                            honey = 10 * flowerCount;
                            honey = honey + honey * 0.10;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Total honey harvested: {honey:f2}");




        }
    }
}
