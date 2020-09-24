using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);
            string command = Console.ReadLine();
            
            while (queue.Count>0)
            {
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    var cE = command.Split("Add ", StringSplitOptions.RemoveEmptyEntries);
                    if (queue.Contains(cE[0]))
                    {
                        Console.WriteLine($"{cE[0]} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(cE[0]);
                    }
                }
                else
                {
                    Console.WriteLine(String.Join(", ",queue));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
