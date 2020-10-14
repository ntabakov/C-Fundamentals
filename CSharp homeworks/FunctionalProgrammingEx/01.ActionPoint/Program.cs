using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string[]> print = n => Console.WriteLine(String.Join(Environment.NewLine, n)); ;
            print(input);
        }
    }
}
