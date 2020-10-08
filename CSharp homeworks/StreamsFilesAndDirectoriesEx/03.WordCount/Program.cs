using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordInput = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            for (int i = 0; i < wordInput.Length; i++)
            {
                wordsCount.Add(wordInput[i], 0);
            }
            string lines = File.ReadAllText("../../../text.txt").ToLower();
            var splitted = lines.Split(new char[]
            { '!', '(', ')', ';', ':', '\'', '"', ',', '?', '/', '.', '-',' ' }
            , StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> counter = new List<string>();
            for (int i = 0; i < splitted.Length; i++)
            {
                if (wordsCount.ContainsKey(splitted[i]))
                {
                    foreach (var key in wordsCount)
                    {
                        if (key.Key == splitted[i])
                        {
                            counter.Add(key.Key);
                        }
                    }
                }
            }

            for (int i = 0; i < counter.Count; i++)
            {
                wordsCount[counter[i]]++;
            }

            var sorted = wordsCount.OrderByDescending(x => x.Value);
            foreach (var item in sorted)
            {

            }
            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                foreach (var item in sorted)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }

    }
}
