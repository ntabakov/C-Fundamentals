using FoodShortage.Contracts;
using FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<IBuyer> people = new List<IBuyer>();
            Citizen citizen = null;
            Rebel rebel = null;

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                string name = tokens[0];
                if (tokens.Length == 4)
                {
                    citizen = new Citizen(name);
                    people.Add(citizen);
                }
                else if (tokens.Length == 3)
                {
                    rebel = new Rebel(name);
                    people.Add(rebel);
                }
            }

            string command = Console.ReadLine();
            while (command !="End")
            {
                if (people.Any(x => x.Name == command))
                {
                    people.First(x => x.Name == command).BuyFood();
                }


                command = Console.ReadLine();
            }

            int sum = 0;
            foreach (var item in people)
            {
                sum += item.Food;
            }
            Console.WriteLine(sum);
        }
    }
}
