using Raiding.Common;
using Raiding.Core;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engine engine = new Engine();
            //engine.Run();
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> raid = new List<BaseHero>();
            string[] classes = new string[] {"Druid","Paladin"
            ,"Warrior","Rogue"};

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                try
                {
                    if (!classes.Contains(type))
                    {
                        i--;
                        throw new ArgumentException(ExceptionMessages.InvalidHero);
                    }
                    else
                    {
                        if (type == "Druid")
                        {
                            raid.Add(new Druid(name));
                        }
                        else if (type == "Paladin")
                        {
                            raid.Add(new Paladin(name));
                        }
                        else if (type == "Rogue")
                        {
                            raid.Add(new Rogue(name));
                        }
                        else if (type == "Warrior")
                        {
                            raid.Add(new Warrior(name));
                        }
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

            int bossPower = int.Parse(Console.ReadLine());
            int sum = 0;

            foreach (var item in raid)
            {
                Console.WriteLine(item.CastAbility());
            }

            foreach (var hero in raid)
            {
                sum += hero.Power;
            }
            if (sum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
