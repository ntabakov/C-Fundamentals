using System;
using System.Text.RegularExpressions;

namespace _03.SoftUnиBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.0-9]{0,}<(?<product>[A-z]+)>[^|$%.0-9]{0,}\|[^|$%.0-9]{0,}(?<count>\d+)[^|$%.0-9]{0,}\|[^|$%.0-9]{0,}(?<price>\d+\.?\d+)[^|$%.0-9]{0,}\$";
            string input = Console.ReadLine();
            double total = 0;
            while (input!="end of shift")
            {
                var matchCol = Regex.Match(input, pattern);
                if (matchCol.Success)
                {
                    string name = matchCol.Groups["customer"].Value;
                    string product = matchCol.Groups["product"].Value;
                    double price = double.Parse(matchCol.Groups["price"].Value)
                        * double.Parse(matchCol.Groups["count"].Value);
                    total += price;
                    Console.WriteLine($"{name}: {product} - {price:f2}");
                
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
