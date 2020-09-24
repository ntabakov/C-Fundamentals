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
            string pattern = @"(#(?<word1>[A-z]{3,})##(?<word2>[A-z]{3,})#)|(\@(?<word3>[A-z]{3,})\@\@(?<word4>[A-z]{3,})\@)";

            string text = Console.ReadLine();

            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();


            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    string currValue = matches[i].Value;
                    if(currValue.Contains("#"))
                    {
                        string wordOne = matches[i].Groups["word1"].Value;
                        string wordTwo = matches[i].Groups["word2"].Value;

                        if (wordOne == Reverse(wordTwo))
                        {
                            mirrorWords.Add(wordOne, wordTwo);
                        }
                    }
                    else
                    {
                        string wordThree = matches[i].Groups["word3"].Value;
                        string wordFour = matches[i].Groups["word4"].Value;

                        if (wordThree == Reverse(wordFour))
                        {
                            mirrorWords.Add(wordThree, wordFour);
                        }
                    }
                }
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            if (mirrorWords.Count > 0)
            {
                StringBuilder thisIsStupid = new StringBuilder();
                Console.WriteLine("The mirror words are:");
                foreach (var item in mirrorWords)
                {
                    thisIsStupid.Append($"{item.Key} <=> {item.Value}, ");
                }
                //456
                //012
                thisIsStupid.Remove(thisIsStupid.Length - 2, 2);
                Console.WriteLine(thisIsStupid);
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
