using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfParticipants = Console.ReadLine().Split(", ");
            Dictionary<string, int> participants = new Dictionary<string, int>();

            string namePattern = @"[A-Za-z]";
            string kmPattern = @"\d";

            string command = Console.ReadLine();


            while (command != "end of race")
            {
                var name = string.Concat(Regex.Matches(command, namePattern));
                var kmFromRegex = Regex.Matches(command, kmPattern);
                var km = kmFromRegex.Select(x=>int.Parse(x.Value)).Sum();

                if (listOfParticipants.Contains(name))
                {
                    if (participants.ContainsKey(name))
                    {
                        participants[name] += km;
                    }
                    else
                    {
                        participants.Add(name, km);
                    }
                }

                command = Console.ReadLine();
            }
            var sorted = participants.OrderByDescending(x => x.Value).ToList();
            Console.WriteLine($"1st place: {sorted[0].Key}");
            Console.WriteLine($"2nd place: {sorted[1].Key}");
            Console.WriteLine($"3rd place: {sorted[2].Key}");



        }
    }
}
