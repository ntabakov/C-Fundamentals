using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            bool isAcquired = false;
            resources.Add("motes", 0);
            resources.Add("fragments", 0);
            resources.Add("shards", 0);

            string itemWon = "";

            while (isAcquired == false)
            {
                string[] input = Console.ReadLine().Split().Select(c => c.ToLower()).ToArray();

                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (resources.ContainsKey(material))
                    {
                        resources[material] += quantity;
                        if (material == "motes" || material == "shards" || material == "fragments")
                        {
                            if (resources[material] >= 250)
                            {
                                isAcquired = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        resources.Add(material, quantity);
                        if (material == "motes" || material == "shards" || material == "fragments")
                        {
                            if (resources[material] >= 250)
                            {
                                isAcquired = true;
                                break;
                            }
                        }
                    }

                }

            }
            if (resources["motes"] >= 250)
            {
                itemWon = "Dragonwrath";
                resources["motes"] -= 250;

            }
            else if (resources["shards"] >= 250)
            {
                itemWon = "Shadowmourne";
                resources["shards"] -= 250;


            }
            else if (resources["fragments"] >= 250)
            {
                itemWon = "Valanyr";
                resources["fragments"] -= 250;

            }
            Dictionary<string, int> theThreeReqMaterials = new Dictionary<string, int>();

            theThreeReqMaterials.Add("motes", resources["motes"]);
            theThreeReqMaterials.Add("shards", resources["shards"]);
            theThreeReqMaterials.Add("fragments", resources["fragments"]);

            
            var lastThree = theThreeReqMaterials.OrderByDescending(x => x.Value).ThenBy(c=>c.Key);

            Console.WriteLine($"{itemWon} obtained!");
            foreach (var item in lastThree)
            {

                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            resources.Remove("motes");
            resources.Remove("shards");
            resources.Remove("fragments");
            
            var junk = resources.OrderBy(c => c.Key);

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
