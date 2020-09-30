using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.MatrixShuffling
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
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var test = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = test[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                var cE = command.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (cE[0] == "swap" && cE.Length == 5)
                {
                    int givenRowOne = int.Parse(cE[1]);
                    int givenColOne = int.Parse(cE[2]);
                    int givenRowTwo = int.Parse(cE[3]);
                    int givenColTwo = int.Parse(cE[4]);

                    if (givenRowOne < rows && givenRowOne >= 0 &&
                        givenRowTwo < rows && givenRowTwo >= 0 &&
                        givenColOne < cols && givenColOne >= 0 &&
                        givenColTwo < cols && givenColTwo >= 0)
                    {
                        var a = matrix[givenRowOne, givenColOne];
                        var b =matrix[givenRowTwo, givenColTwo];


                        matrix[givenRowOne, givenColOne] = b;
                        matrix[givenRowTwo, givenColTwo] = a;
                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();

                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");

                }
                command = Console.ReadLine();
            }
        }

        static void PrintMatrix(string[,] matrix)
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
