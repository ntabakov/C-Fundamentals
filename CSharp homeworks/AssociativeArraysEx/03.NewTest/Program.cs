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
            string[] input = Console.ReadLine().Split().Select(c => c.ToLower()).ToArray();
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                int quantity = int.Parse(input[i]);
                string requirements = input[i + 1];

                if (resources.ContainsKey(requirements))
                {
                    resources[requirements] += quantity;
                }
                else
                {
                    resources.Add(requirements, quantity);
                }

            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
