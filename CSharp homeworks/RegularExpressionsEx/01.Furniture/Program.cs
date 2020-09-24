using System;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d*\.?\d+)!(?<quantity>\d+)";
            double total = 0;

            string input = Console.ReadLine();
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                var furn = Regex.Match(input, pattern);
                if (furn.Success)
                {
                    Console.WriteLine(furn.Groups["name"]);
                    total += double.Parse(furn.Groups["price"].ToString()) *
                        double.Parse(furn.Groups["quantity"].ToString());
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Total money spend: {total:f2}");

        }
    }
}
