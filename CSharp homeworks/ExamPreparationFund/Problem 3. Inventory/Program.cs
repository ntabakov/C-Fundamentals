using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split(new char[] { ',', ' ','-',':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string action = command[0];
            string givenItem = command[1]; // FOR DROP, COLLECT AND RENEW ACTIONS

            

            while (command[0] != "Craft!")
            {
                if (command[0] == "Collect")
                {
                    if (!(items.Contains(command[1])))
                    {
                        items.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (items.Contains(command[1]))
                    {
                        items.Remove(command[1]);
                    }
                }
                else if (command[0] == "Combine")
                {
                    if (items.Contains(command[2]))
                    {
                        int index = items.IndexOf(command[2]);
                        items.Insert(index + 1, command[3]);
                    }
                }
                else // RENEW
                {
                    if (items.Contains(command[1]))
                    {
                        items.Add(command[1]);
                        items.Remove(command[1]);
                    }
                }
                command = Console.ReadLine().Split(new char[] { ',', ' ', '-', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            }
            Console.WriteLine(String.Join(", ",items ));
        }
    }
}
