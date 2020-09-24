using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            Dictionary<string, int> charCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string first = words[i].ToString();
                if (first == " ")
                {
                    continue;
                }
                else if (charCount.ContainsKey(first))
                {
                    charCount[first]++;
                }
                else
                {
                    charCount.Add(first, 1);
                }
            }

            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
