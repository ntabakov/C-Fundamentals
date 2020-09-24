using System;
using System.Collections.Generic;
using System.Linq;

namespace Testsetst
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

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
                    plants.Add(plantName, new List<double> {rarity});
                }

            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                var cList = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string plant = cList[1];
                if (cList[0] == "Rate")
                {
                    plants[plant].Add(double.Parse(cList[2]));
                }
                else if (cList[0] == "Update")
                {
                    plants[plant][0] = double.Parse(cList[2]);
                }
                else if (cList[0] == "Reset")
                {
                    plants[plant].RemoveRange(1, plants[plant].Count - 1);

                }
                else
                {
                    Console.WriteLine("error");
                }



                command = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                if(item.Value.Count == 1)
                {
                    item.Value.Add(0);

                }
                else
                {
                    
                }
            }
        }
    }
}
