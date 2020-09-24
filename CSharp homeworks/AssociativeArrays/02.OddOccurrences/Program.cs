using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split().Select(c => c.ToLower()).ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var element in elements)
            {
                if (words.ContainsKey(element)) 
                {
                    words[element]++;
                }
                else
                {
                    words.Add(element, 1);
                }
            }
            foreach (var word in words)
            {
                if (word.Value % 2 == 0)
                {
                    words.Remove(word.Key);
                }
                else
                {
                    Console.Write(word.Key + " ");
                }
            }

        }
    }
}
