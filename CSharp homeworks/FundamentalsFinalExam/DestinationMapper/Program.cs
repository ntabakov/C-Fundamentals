using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=,\/])(?<city>[A-Z][A-z]{2,})\1";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> destinations = new List<string>();
            int sum = 0;
            foreach (Match item in matches)
            {
                destinations.Add(item.Groups["city"].Value);
                sum += item.Groups["city"].Value.Length;
            }
            Console.Write("Destinations: ");
            Console.WriteLine(String.Join(", ",destinations));
            Console.WriteLine($"Travel Points: {sum}");

        }
    }
}
