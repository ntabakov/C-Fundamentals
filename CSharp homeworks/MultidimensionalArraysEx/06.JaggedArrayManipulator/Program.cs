using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jaggedMatrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                var cols = Console.ReadLine().
                Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

                jaggedMatrix[row] = new double[cols.Length];

                for (int col = 0; col < cols.Length; col++)
                {
                    jaggedMatrix[row][col] = cols[col];
                }
                if (row > 0)
                {
                    if (jaggedMatrix[row].Length == jaggedMatrix[row-1].Length)
                    {
                        for (int i = 0; i < jaggedMatrix[row].Length; i++)
                        {
                            jaggedMatrix[row][i] *= 2;
                            jaggedMatrix[row - 1][i] *= 2;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < jaggedMatrix[row].Length; i++)
                        {
                            jaggedMatrix[row][i] /= 2;
                        }
                        for (int k = 0; k < jaggedMatrix[row-1].Length; k++)
                        {
                            jaggedMatrix[row - 1][k] /= 2;

                        }
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                var cE = command.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                int row = int.Parse(cE[1]);
                int col = int.Parse(cE[2]);
                int value = int.Parse(cE[3]);
                if (cE[0] == "Add")
                {
                    if(row < jaggedMatrix.Length && row >= 0 &&
                        col < jaggedMatrix[row].Length && col >=0)
                    {
                        jaggedMatrix[row][col] += value;
                    }
                }
                else if (cE[0]== "Subtract")
                {
                    if (row < jaggedMatrix.Length && row >= 0 &&
                        col < jaggedMatrix[row].Length && col >= 0)
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }
            PrintMatrix(jaggedMatrix);

        }
        static void PrintMatrix(double[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
