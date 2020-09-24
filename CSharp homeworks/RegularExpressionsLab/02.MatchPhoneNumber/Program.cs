using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();
            MatchCollection phone = Regex.Matches(input, pattern);
            List<string> temp = new List<string>();
            foreach (Match item in phone)
            {
                temp.Add(item.Value);
            }
            Console.WriteLine(String.Join(", ",temp));
        }
    }
}
