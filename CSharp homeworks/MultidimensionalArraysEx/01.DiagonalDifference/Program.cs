using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            ReadMatrix(matrix);

            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumOne += matrix[i, i];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumTwo += matrix[i, matrix.GetLength(0) - i - 1];
            }

            Console.WriteLine(Math.Abs(sumOne - sumTwo));
        }

        static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
