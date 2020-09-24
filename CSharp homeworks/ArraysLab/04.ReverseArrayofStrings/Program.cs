using System;

namespace _04.ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string[] strings = firstInput.Split();

            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(strings[strings.Length - 1 - i] + " ");
            }

        }
    }
}
