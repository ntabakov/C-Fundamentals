using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ").ToArray();
            var queue = new Queue<string>(songs);

            while (queue.Any())
            {
                var command = Console.ReadLine();
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    var songToAdd = command.Substring(4);

                    if (queue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained! ");
                    }
                    else
                    {
                        queue.Enqueue(songToAdd);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
