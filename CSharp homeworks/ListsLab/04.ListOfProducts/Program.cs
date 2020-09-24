using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> product = new List<string>();
            string currProduct = "";
            for (int i = 0; i < n; i++)
            {
                currProduct = Console.ReadLine();
                product.Add(currProduct);
            }
            product.Sort();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}.{product[i-1]}");
            }
           
        }

    
    }
}
