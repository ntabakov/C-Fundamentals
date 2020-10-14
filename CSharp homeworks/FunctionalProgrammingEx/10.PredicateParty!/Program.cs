using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            while (command != "Party!")
            {
                var cE = command.Split();
                string action = cE[0];
                string filter = cE[1];
                string given = cE[2];

                var predicate = GetPredicate(filter, given);

                if(action == "Remove")
                {
                    people.RemoveAll(predicate);
                }

                else if (action == "Double")
                {
                    var matches = people.FindAll(predicate);
                    if(matches.Count > 0)
                    {
                        var index = people.FindIndex(predicate);

                        people.InsertRange(index, matches);

                    }
                }

                if (people.Count != 0)

                {

                    Console.WriteLine(string.Join(", ", people) + " are going to the party!");

                }

                else

                {

                    Console.WriteLine("Nobody is going to the party!");

                }


                //if(action == "Remove")
                //{
                //    switch (filter)
                //    {
                //        case "StartsWith":
                //            people = people.Where(x => !x.StartsWith(given)).ToList();
                //            break;

                //        case "Length":
                //            people = people.Where(x => x.Length != int.Parse(given)).ToList();

                //            break;

                //        case "EndsWith":
                //            people = people.Where(x => !x.EndsWith(given)).ToList();

                //            break;
                //    }
                //}
                //else if (action == "Double")
                //{
                //    people.
                //}


                command = Console.ReadLine();
            }
        }

        private static Predicate<string> GetPredicate(string commandType, string arg)

        {
            switch (commandType)

            {

                case "StartsWith":

                    return (name) => name.StartsWith(arg);

                case "EndsWith":

                    return (name) => name.EndsWith(arg);

                case "Length":

                    return (name) => name.Length == int.Parse(arg);

                default:

                    throw new ArgumentException();

            }

            //if (commandType == "StartWith")
            //{
            //    return name => name.StartsWith(arg);
            //}
            //else if (commandType == "EndsWith")
            //{
            //    return name => name.EndsWith(arg);
            //}
            //else
            //{
            //    return name => name.Length == int.Parse(arg);

            //}


        }

    }
}
