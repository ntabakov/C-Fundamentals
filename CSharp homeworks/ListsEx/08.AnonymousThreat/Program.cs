using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            String.Join(String.Empty, command[1], command[2]);


        }
    }
}
