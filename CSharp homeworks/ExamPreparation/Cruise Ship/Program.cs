using System;

namespace Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double price = 0;
            switch (cruiseType)
            {
                case "Mediterranean":
                    switch (cabinType)
                    {
                        case "standard cabin":
                            price = 27.50;
                            break;
                        case "cabin with balcony":
                            price = 30.20;
                            break;
                        case "apartment":
                            price = 40.50;
                            break;
                    }
                    break;

                case "Adriatic":
                    switch (cabinType)
                    {
                        case "standard cabin":
                            price = 22.99;
                            break;
                        case "cabin with balcony":
                            price = 25.00;
                            break;
                        case "apartment":
                            price = 34.99;
                            break;
                    }
                    break;

                case "Aegean":
                    switch (cabinType)
                    {
                        case "standard cabin":
                            price = 23.00;
                            break;
                        case "cabin with balcony":
                            price = 26.60;
                            break;
                        case "apartment":
                            price = 39.80;
                            break;
                    }
                    break;

            }
            double cost = price * nights*4;
            if (nights > 7)
            {
                cost = cost - cost * 0.25;
            }
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {cost:f2} lv.");
        }
    }
}
