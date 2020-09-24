using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            long totalPetrol = 0;


            for (int i = 0; i < n; i++)
            {
                string intPair = Console.ReadLine();
                intPair += $" {i}";
                queue.Enqueue(intPair);
            }
            for (int i = 0; i < n; i++)
            {
                string currInfo = queue.Dequeue();
                var info = currInfo.Split().Select(int.Parse).ToArray();
                totalPetrol += info[0];
                long distance = info[1];
                if(totalPetrol - distance >= 0)
                {
                    totalPetrol -= distance;
                }
                else
                {
                    totalPetrol = 0;
                    i = -1;
                }
                queue.Enqueue(currInfo);


            }
            var firstE = queue.Dequeue().Split().ToArray();
            Console.WriteLine(firstE[2]);
        }
    }
}
