using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string word = "";
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr[i].Length; j++)
                {
                    word += arr[i];
                }

            }
            Console.WriteLine(word);
        }
    }
}
