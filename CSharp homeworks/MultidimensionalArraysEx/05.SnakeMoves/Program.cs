using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().
                Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];

            var snake = Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < snake.Length; i++)
            {
                queue.Enqueue(snake[i]);
            }

            for (int row = 0; row < rows; row++)
            {
                if (row % 2== 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = queue.Dequeue() ;
                        if(queue.Count == 0)
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Dequeue();
                        if (queue.Count == 0)
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }
                    }
                }
            }
            PrintMatrix(matrix);

            static void PrintMatrix(char[,] matrix)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
