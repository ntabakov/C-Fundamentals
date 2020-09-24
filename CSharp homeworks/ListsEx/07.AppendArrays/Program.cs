using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new List<int>();
            var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                var splittedInput = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < splittedInput.Length; j++)
                {
                    arrays.Add(int.Parse(splittedInput[j]));
                }
            }
            Console.WriteLine(string.Join(" ", arrays));
        }
    }
}
