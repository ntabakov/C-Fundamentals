﻿using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>(); 
            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }
            Console.WriteLine(String.Join(Environment.NewLine,set));
        }
    }
}
