﻿using System;

namespace _06.TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int k = 97; k < 97 + n; k++)
                    {
                        Console.Write((char)i);
                        Console.Write((char)j);
                        Console.Write((char)k);
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
