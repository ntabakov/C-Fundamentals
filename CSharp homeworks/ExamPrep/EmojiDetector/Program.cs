using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\*\*|\:\:)(?<emoji>[A-Z][a-z]{2,})\1";
            string input = Console.ReadLine();
            MatchCollection numbers = Regex.Matches(input, @"\d");
            Dictionary<string, int> coolEmojis = new Dictionary<string, int>();

            int threshold = 1;
            foreach (Match item in numbers)
            {
                threshold *= int.Parse(item.Value);
            }

            Console.WriteLine($"Cool threshold: {threshold}");

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)
            {
                int coolness = 0;

                string emoji = item.Groups["emoji"].Value;
                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }
                if (coolness >= threshold)
                {
                    coolEmojis.Add(item.Value, coolness);
                }

            }
            int emojisFound = matches.Count;
            Console.WriteLine($"{emojisFound} emojis found in the text. The cool ones are:");
            if (coolEmojis.Count > 0)
            {
                foreach (var item in coolEmojis)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
