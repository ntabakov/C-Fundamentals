using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");
            string[] newArray = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int punctCount = PunctuationMarksCount(line);
                int letterCount = LetterCount(line);

                newArray[i] = $"Line {i + 1}: {lines[i]} ({letterCount})({punctCount})";
            }

            File.WriteAllLines("../../../output.txt", newArray);
        }

        static int PunctuationMarksCount(string line)
        {
            int count = 0;
            char[] pMarks = new char[] { '!', '(', ')', ';', ':', '\'', '"', ',', '?', '/', '.', '-' };
            for (int i = 0; i < line.Length; i++)
            {
                if (pMarks.Contains(line[i]))
                {
                    count++;
                }
            }


            return count;
        }

        static int LetterCount(string line)
        {

            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (Char.IsLetter(line[i]))
                {
                    count++;

                }
            }
            return count;
        }
    }
}
