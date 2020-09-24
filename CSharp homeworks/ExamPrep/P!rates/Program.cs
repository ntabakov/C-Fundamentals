using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> targetCities = new Dictionary<string, List<int>>();

            string city = Console.ReadLine();
            while (city != "Sail")
            {
                var cList = city.Split("||");
                string cityName = cList[0];
                int population = int.Parse(cList[1]);
                int gold = int.Parse(cList[2]);

                if (targetCities.ContainsKey(cityName))
                {
                    targetCities[cityName][0] += population;
                    targetCities[cityName][1] += gold;

                }
                else
                {
                    targetCities.Add(cityName, new List<int> { population, gold });
                }

                city = Console.ReadLine();
            }

            string lines = Console.ReadLine();
            while (lines != "End")
            {
                var cList = lines.Split("=>");
                string town = cList[1];

                if (lines.Contains("Plunder"))
                {
                    int stealedGold = int.Parse(cList[3]);
                    int peopleKilled = int.Parse(cList[2]);

                    targetCities[town][0] -= peopleKilled;
                    targetCities[town][1] -= stealedGold;
                    Console.WriteLine($"{town} plundered! {stealedGold} gold stolen, {peopleKilled} citizens killed.");
                    if(targetCities[town][1] <= 0 || targetCities[town][0] <= 0)
                    {
                        targetCities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else
                {
                    int gold = int.Parse(cList[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        targetCities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {targetCities[town][1]} gold.");
                    }
                }




                lines = Console.ReadLine();
            }
            var sortedCities = targetCities.OrderByDescending(c => c.Value[1]).ThenBy(x => x.Key);
            if (targetCities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {targetCities.Count} wealthy settlements to go to:");
                foreach (var item in sortedCities)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
