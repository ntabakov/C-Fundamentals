using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split().ToArray();
            //1 2 3
            //0 1 2
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;

                    case "Insert":
                        if (int.Parse(command[2]) >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;

                    case "Remove":
                        if (int.Parse(command[1]) >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;

                    case "Shift":
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;

                }
                command = Console.ReadLine().Split().ToArray();

            }
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
