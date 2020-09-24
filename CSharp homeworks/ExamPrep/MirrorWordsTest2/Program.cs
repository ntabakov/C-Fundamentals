using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#,\@])(?<word1>[A-z]{3,})\1\1(?<word2>[A-z]{3,})\1";

            string text = Console.ReadLine();

            List<string> mirrorWords = new List<string>();


            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                var word1 = item.Groups["word1"].Value;
                var word2 = item.Groups["word2"].Value;
                var reversed = String.Concat(word1.Reverse());
                if (reversed == word2)
                {
                    mirrorWords.Add($"{word1} <=> {word2}");
                }

            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(String.Join(", ",mirrorWords));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }

        }
    }
}
