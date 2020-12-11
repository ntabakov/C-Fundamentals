using System;
using System.Collections.Generic;
using System.Linq;

namespace Testsetst
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<double>> plantStorage = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] plantInput = Console.ReadLine().Split("<->",StringSplitOptions.RemoveEmptyEntries);
                string plant = plantInput[0];
                int rarity = int.Parse(plantInput[1]);
                if (plantStorage.ContainsKey(plant))
                {
                    //plantStorage[plant].Add(rarity,0.00);
                    plantStorage[plant][0] = rarity;
                }
                else
                {
                    plantStorage.Add(plant,new List<double>(){rarity,0.00,0});
                }

            }

            string input;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                var inputArgs = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string plant = inputArgs[1];
                if (inputArgs[0] == "Rate:")
                {
                    double rating = double.Parse(inputArgs[3]);
                    plantStorage[plant][1] += rating;
                    plantStorage[plant][2] += 1;

                }
                else if (inputArgs[0] == "Update:")
                {
                    int rarity = int.Parse(inputArgs[3]);
                    plantStorage[plant][0] = rarity;
                }
                else if (inputArgs[0] == "Reset:")
                {
                    plantStorage[plant][1] = 0;
                    plantStorage[plant][2] = 0;

                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            foreach (var plant in plantStorage)
            {
                if (plant.Value[1] != 0)
                {
                    plant.Value[1] /= plant.Value[2];

                }
            }

            var sorted = plantStorage.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]);

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in sorted)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }
        }

    }
}
