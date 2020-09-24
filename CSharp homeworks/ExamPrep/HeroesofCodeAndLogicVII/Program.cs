using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesofCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string[] heroInput = Console.ReadLine().Split();
                string heroName = heroInput[0];
                int heroHP = int.Parse(heroInput[1]);
                int heroMP = int.Parse(heroInput[2]);
                heroes.Add(heroName, new List<int> { heroHP, heroMP });
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var commandLines = command.Split(" - ");
                string currentHero = commandLines[1];

                if (command.Contains("CastSpell"))
                {
                    int mpNeed = int.Parse(commandLines[2]);
                    string spellName = commandLines[3];
                    if (heroes[currentHero][1] >= mpNeed)
                    {
                        heroes[currentHero][1] -= mpNeed;
                        Console.WriteLine($"{currentHero} has successfully cast {spellName} and now has {heroes[currentHero][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentHero} does not have enough MP to cast {spellName}!");
                    }

                }

                else if (command.Contains("TakeDamage"))
                {
                    int damage = int.Parse(commandLines[2]);
                    string attacker = commandLines[3];
                    heroes[currentHero][0] -= damage;
                    if (heroes[currentHero][0] > 0)
                    {
                        Console.WriteLine($"{currentHero} was hit for {damage} HP by {attacker} and now has {heroes[currentHero][0]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(currentHero);
                        Console.WriteLine($"{currentHero} has been killed by {attacker}!");
                    }



                }

                else if (command.Contains("Recharge"))
                {
                    int amount = int.Parse(commandLines[2]);
                    if (heroes[currentHero][1] + amount > 200)
                    {
                        Console.WriteLine($"{currentHero} recharged for {200 - heroes[currentHero][1]} MP!");
                        heroes[currentHero][1] = 200;
                    }
                    else
                    {
                        heroes[currentHero][1] += amount;
                        Console.WriteLine($"{currentHero} recharged for {amount} MP!");
                    }
                }

                else
                {
                    int amount = int.Parse(commandLines[2]);
                    if (heroes[currentHero][0] + amount > 100)
                    {
                        Console.WriteLine($"{currentHero} healed for {100 - heroes[currentHero][0] } HP!");
                        heroes[currentHero][0] = 100;
                    }
                    else
                    {
                        heroes[currentHero][0] += amount;
                        Console.WriteLine($"{currentHero} healed for {amount} HP!");
                    }
                }
                command = Console.ReadLine();
            }
            var orderedHeroes = heroes.OrderByDescending(x => x.Value[0]).ThenBy(c => c.Key);
            foreach (var name in orderedHeroes)
            {
                Console.WriteLine(name.Key);
                Console.WriteLine($"HP: {name.Value[0]}");
                Console.WriteLine($"MP: {name.Value[1]}");
            }



        }
    }
}
