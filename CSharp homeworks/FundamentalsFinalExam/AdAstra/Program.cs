using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#,\|])(?<item>[A-z ]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>\d+)\1";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            int totalCal = 0;

            foreach (Match item in matches)
            {
                totalCal += int.Parse(item.Groups["calories"].Value);
            }

            int lastDays = totalCal / 2000;

            Console.WriteLine($"You have food to last you for: {lastDays} days!");
            if (matches.Count > 0)
            {
                foreach (Match item in matches)
                {
                    Console.WriteLine($"Item: {item.Groups["item"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["calories"].Value}");
                }
            }
        }
    }
}
