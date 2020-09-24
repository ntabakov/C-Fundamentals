using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int startIndex = 0;

            while (second.IndexOf(first) >= 0)
            {
                second = second.Remove(second.IndexOf(first), first.Length);
            }
            Console.WriteLine(second);

        }
    }
}