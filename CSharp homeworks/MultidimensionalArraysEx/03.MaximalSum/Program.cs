using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine().Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];

                }
            }
            //ReadMatrix(matrix);
            var maxSum = 0;
            var maxRow = 0;
            var maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (var col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                              + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                              + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} " +
                              $"{matrix[maxRow, maxCol + 1]} " +
                              $"{matrix[maxRow, maxCol + 2]}");

            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} " +
                              $"{matrix[maxRow + 1, maxCol + 1]} " +
                              $"{matrix[maxRow + 1, maxCol + 2]}");

            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} " +
                              $"{matrix[maxRow + 2, maxCol + 1]} " +
                              $"{matrix[maxRow + 2, maxCol + 2]}");
            //Console.WriteLine($"Sum = {maxSum}");
            //Console.Write(matrix[maxRow,maxCol] + " " );
            //Console.Write(matrix[maxRow, maxCol+1] + " ");
            //Console.Write(matrix[maxRow, maxCol+2] + " " );

            //Console.WriteLine();

            //Console.Write(matrix[maxRow+1, maxCol] + " ");
            //Console.Write(matrix[maxRow+1, maxCol + 1] + " ");
            //Console.Write(matrix[maxRow+1, maxCol + 2] + " ");

            //Console.WriteLine();

            //Console.Write(matrix[maxRow+2, maxCol] + " ");
            //Console.Write(matrix[maxRow+2, maxCol + 1] + " ");
            //Console.Write(matrix[maxRow+2, maxCol + 2] + " ");

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
