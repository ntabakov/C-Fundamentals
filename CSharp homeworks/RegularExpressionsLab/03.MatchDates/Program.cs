using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<separator>[-\/.])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string input = Console.ReadLine();

            MatchCollection datetime = Regex.Matches(input, pattern);

            foreach (Match date in datetime)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }
        }
    }
}
