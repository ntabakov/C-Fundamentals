using System;
using System.Text;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(input);

            while (command != "Travel")
            {
                string[] splittedInput = command.Split(':');

                if (command.Contains("Add Stop:"))
                {
                    int index = int.Parse(splittedInput[1]);
                    string newString = splittedInput[2];

                    if (index < sb.Length)
                    {
                        sb = sb.Insert(index, newString);
                    }
                }

                if (command.Contains("Remove Stop:"))
                {
                    int startIndex = int.Parse(splittedInput[1]);
                    int endIndex = int.Parse(splittedInput[2]);
                    int lenght = endIndex - startIndex + 1;

                    if (startIndex < sb.Length && endIndex < sb.Length && startIndex <= endIndex)
                    {
                        sb = sb.Remove(startIndex, lenght);
                    }
                }

                if (command.Contains("Switch:"))
                {
                    string oldString = splittedInput[1];
                    string newString = splittedInput[2];

                    sb = sb.Replace(oldString, newString);
                }

                Console.WriteLine(sb);
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {sb}");
        }
    }
}