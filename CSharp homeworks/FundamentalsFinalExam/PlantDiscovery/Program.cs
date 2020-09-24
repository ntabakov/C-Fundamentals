using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("<->");
                string plantName = input[0];
                double rarity = double.Parse(input[1]);
                if (plants.ContainsKey(plantName))
                {
                    plants[plantName][0] = rarity;
                }
                else
                {
                    plants.Add(plantName, new List<double> { rarity,0.00,0.00});
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                var cList = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string plant = cList[1];
                if (command.Contains("Rate"))
                {
                    double rating = double.Parse(cList[2]);
                    plants[plant][1] += rating;
                    plants[plant][2] += 1;
                }
                else if (command.Contains("Update"))
                {
                    double newRarity = double.Parse(cList[2]);
                    plants[plant][0] = newRarity;
                }
                else if (command.Contains("Reset"))
                {
                    plants[plant][1] = 0;
                    plants[plant][2] = 0;
                }
                else
                {
                    Console.WriteLine("error");
                }
                command = Console.ReadLine();
            }
            
        }
    }
}
