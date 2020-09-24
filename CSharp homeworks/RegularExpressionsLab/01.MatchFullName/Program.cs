using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

            string input = Console.ReadLine();
            MatchCollection neshtoSi = Regex.Matches(input, pattern);
            foreach (Match name in neshtoSi)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
