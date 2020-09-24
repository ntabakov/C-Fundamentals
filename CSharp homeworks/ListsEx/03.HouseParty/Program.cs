using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();
            // Ivan is going!
            //Ivan is not going!
            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split().ToArray();
                if (person[2] == "not")
                {
                    if (guestList.Contains(person[0]))
                    {
                        guestList.Remove(person[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{person[0]} is not in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(person[0]))
                    {
                        Console.WriteLine($"{person[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(person[0]);
                    }
                }
            }
            foreach (var element in guestList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
