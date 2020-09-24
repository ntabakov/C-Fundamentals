using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> totalResourse = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (totalResourse.ContainsKey(resource))
                {
                    totalResourse[resource] += quantity;
                }
                else
                {
                    totalResourse.Add(resource, quantity);
                }

                resource = Console.ReadLine();
            }
            foreach (var item in totalResourse)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
