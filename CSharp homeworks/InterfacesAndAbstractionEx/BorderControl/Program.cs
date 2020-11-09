using BorderControl.Contracts;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IBirthdateable> everyone = new List<IBirthdateable>();
            while (input != "End")
            {

                var tokens = input.Split();
                if (tokens.Length == 5)
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthdate = tokens[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    everyone.Add(citizen);
                }
                else if (tokens.Length == 3)
                {
                    string name = tokens[1];
                    string birthdate = tokens[2];
                    IBirthdateable pet = new Pet(name, birthdate);
                    everyone.Add(pet);
                }
                input = Console.ReadLine();
            }
            string lastBirthdate = Console.ReadLine();
            if (lastBirthdate.Length == 4)
            {
                foreach (var visiter in everyone)
                {
                    if (visiter.Birthdate.EndsWith(lastBirthdate))
                    {
                        Console.WriteLine(visiter.Birthdate);
                    }
                }
            }

        }
    }
}
