using System;
using System.Text.RegularExpressions;

namespace BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-z]+ [A-z]+)#";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match regex = Regex.Match(input, pattern);
                if (regex.Success)
                {
                    string boss = regex.Groups["boss"].Value;
                    string title = regex.Groups["title"].Value;
                    Console.WriteLine($"{boss}, The {title}");
                    Console.WriteLine($">> Strength: {boss.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");

                }
                else
                {
                    Console.WriteLine("Access denied!");
                }

            }
        }
    }
}
