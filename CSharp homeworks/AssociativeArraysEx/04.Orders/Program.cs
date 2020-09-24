using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();

            while (input != "buy")
            {
                var inputItems = input.Split();
                string product = inputItems[0];
                double price = double.Parse(inputItems[1]);
                double quantity = double.Parse(inputItems[2]);
                if (products.ContainsKey(product))
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }
                else
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(quantity);
                }

                input = Console.ReadLine();
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }
        }

    }
}
