using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            List<string> commandTypes = new List<string>();

            while(command != "Print")
            {
                var cE = command.Split(";");
                string filterType = cE[1];
                string parameter = cE[2];
                if (cE[0]=="Add filter")
                {
                    commandTypes.Add($"{filterType};{parameter}");
                }
                else if (cE[0] == "Remove filter")
                {
                    commandTypes.Remove($"{filterType};{parameter}");

                }
                command = Console.ReadLine();

            }


            foreach (var item in commandTypes)
            {
                var split = item.Split(";");
                string filter = split[0];
                string argument = split[1];

                switch (filter)
                {
                    case "Starts with":

                        people = people.Where(p => !p.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(argument)).ToList();

                        break;
                    case "Length":
                        people = people.Where(p => p.Length != int.Parse(argument)).ToList();

                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(argument)).ToList();
                        break;
                }
            }
            Console.WriteLine(String.Join(" ",people));

        }
    }
}
