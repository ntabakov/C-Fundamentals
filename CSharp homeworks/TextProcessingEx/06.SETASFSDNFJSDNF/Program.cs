using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();

            for (int i = 0; i < input.Count-1; i++)
            {
                char first = input[i];
                char second = input[i + 1];

                if (first == second)
                {
                    input.RemoveAt(i + 1);
                    i--;
                }
            }
            Console.WriteLine(String.Join("",input));
        }
    }
}
