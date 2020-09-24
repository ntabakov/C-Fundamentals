using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Dictionary<string, string> parkList = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];
                string name = commandLine[1];
                string plate = "";

                if (commandLine.Length == 3)
                {
                     plate = commandLine[2];

                }

                if (command== "register")
                {
                    if (parkList.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkList[name]}");
                    }
                    else
                    {
                        parkList.Add(name, plate);
                        Console.WriteLine($"{name} registered {parkList[name]} successfully");
                    }
                }
                else
                {
                    if (parkList.ContainsKey(name))
                    {
                        parkList.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in parkList)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
