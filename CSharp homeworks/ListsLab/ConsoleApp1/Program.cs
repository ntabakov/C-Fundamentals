using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            List<int> backup = numbers;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
                else
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            int count = 0;


            string[] command = Console.ReadLine().Split().ToArray();



            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");

                        }
                        break;

                    case "PrintEven":
                        Console.WriteLine(String.Join(' ', evenNumbers));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(String.Join(' ', oddNumbers));

                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        if (command[1] == "<")
                        {
                            Filter(command[1], int.Parse(command[2]), numbers);
                        }
                        else if (command[1] == ">")
                        {
                            Filter(command[1], int.Parse(command[2]), numbers);

                        }
                        else if (command[1] == ">=")
                        {
                            Filter(command[1], int.Parse(command[2]), numbers);

                        }
                        else if (command[1] == "<=")
                        {
                            Filter(command[1], int.Parse(command[2]), numbers);

                        }
                        break;

                    ///////////////////////////////////
                    ///
                    case "Add":

                        numbers.Add(int.Parse(command[1]));
                        count++;
                        break;

                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        

                        break;

                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        count++;

                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        count++;

                        break;




                }
                command = Console.ReadLine().Split().ToArray();

            }
            if (count > 0)
            {
                Console.WriteLine(String.Join(' ', numbers)) ;
            }


        }

        static void Filter(string symbol, int number, List<int> list)
        {
            List<int> temp = new List<int>();
            if (symbol == "<")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < number)
                    {
                        temp.Add(list[i]);

                    }

                }
            }
            else if (symbol == ">")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > number)
                    {
                        temp.Add(list[i]);
                    }

                }
            }
            else if (symbol == ">=")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] >= number)
                    {
                        temp.Add(list[i]);
                    }

                }
            }
            else if (symbol == "<=")
            {
                for (int i = 0; i >= list.Count; i++)
                {
                    if (list[i] <= number)
                    {
                        temp.Add(list[i]);
                    }

                }
            }
            Console.WriteLine(String.Join(' ', temp));
            temp.Clear();
        }
    }
}
