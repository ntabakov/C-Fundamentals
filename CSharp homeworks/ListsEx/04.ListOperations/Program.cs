using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
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
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    int insertNumber = int.Parse(command[1]);
                    int insertIndex = int.Parse(command[2]);
                    if(insertIndex >= numbers.Count || insertIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                        
                    }
                    else
                    {
                        numbers.Insert(insertIndex, insertNumber);

                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        

                    }
                    else
                    {
                        numbers.RemoveAt(index);

                    }
                }
                else if (command[0] == "Shift")
                {
                    int count = int.Parse(command[2]);
                    if (command[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }


    }
}
