using System;

namespace _03.Generating01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var vector = new int[n];

            CreateVector(vector, 0);
        }

        private static void CreateVector(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join("",vector));
                return;
            }

            for (int number = 0; number <= 1; number++)
            {
                vector[index] = number;
                CreateVector(vector, index + 1);
            }
        }
    }
}
