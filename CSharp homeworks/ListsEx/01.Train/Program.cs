﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        wagons.Add(int.Parse(command[1]));
                        break;

                    default:
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (wagons[i] + int.Parse(command[0]) <= maxCapacity)
                            {
                                wagons[i] += int.Parse(command[0]);
                                break;
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split().ToList();

            }
            Console.WriteLine(String.Join(' ',wagons));


        }
    }
}
