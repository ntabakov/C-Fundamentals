using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            string word = "";

            for (int f = floor; f > 0; f--)
            {
                for (int r = 0; r < room; r++)
                {
                    if (f % 2 == 0)
                    {
                        word = "O";

                    }
                    else
                    {
                        word = "A";
                    }
                    if (f == floor)
                    {
                        word = "L";
                    }
                    Console.Write($"{word}{f}{r} ");
                }
                Console.WriteLine();

            }

        }
    }
}
