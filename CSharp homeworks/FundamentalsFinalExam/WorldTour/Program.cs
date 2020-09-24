using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                var cList = command.Split(":");
                if (command.Contains("Add Stop"))
                {
                    
                    int index = int.Parse(cList[1]);
                    string text = cList[2];
                    if(index < destinations.Length && index >= 0)
                    {
                        destinations = destinations.Insert(index, text);
                    }
                    Console.WriteLine(destinations); 
                }
                else if (command.Contains("Remove Stop"))
                {
                    int startIndex = int.Parse(cList[1]);
                    int endIndex = int.Parse(cList[2]);
                    if (startIndex >= 0 && startIndex < endIndex && endIndex < destinations.Length)
                    {
                        destinations = destinations.Remove(startIndex, endIndex - startIndex + 1);

                    }
                    Console.WriteLine(destinations);


                }
                else
                {
                    string oldString = cList[1];
                    string newString = cList[2];
                    if (destinations.Contains(oldString))
                    {
                        destinations = destinations.Replace(oldString, newString);
                    }
                    Console.WriteLine(destinations);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
