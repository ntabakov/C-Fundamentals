using System;
using System.Collections.Generic;

namespace _05.FindAllPathsInALabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] lab = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    lab[row, col] = input[col];
                }
            }
            List<char> directions = new List<char>();
            FindAllPaths(lab, 0, 0, directions, '\0');
        }

        private static void FindAllPaths(char[,] lab, int row, int col, List<char> directions, char direction)
        {
            if (IsOutside(lab, row, col)
                || IsWall(lab,row,col)
                || IsVisited(lab,row,col))
            {
                return;
            }

            directions.Add(direction);

            if (IsSolution(lab, row, col))
            {
                Console.WriteLine(string.Join("",directions));
                directions.RemoveAt(directions.Count - 1);

                return;
            }

            lab[row, col] = 'v';

            FindAllPaths(lab, row + 1, col, directions, 'D');
            FindAllPaths(lab, row - 1, col, directions, 'U');
            FindAllPaths(lab, row, col - 1, directions, 'L');
            FindAllPaths(lab, row, col + 1, directions, 'R');
            directions.RemoveAt(directions.Count - 1);
            lab[row, col] = '-';
        }

        private static bool IsSolution(char[,] lab, in int row, in int col)
        {
            return lab[row, col] == 'e';

        }

        private static bool IsVisited(char[,] lab, in int row, in int col)
        {
            return lab[row, col] == 'v';
        }

        private static bool IsWall(char[,] lab, in int row, in int col)
        {
            return lab[row, col] == '*';
        }

        private static bool IsOutside(char[,] lab, int rows, int cols)
        {
            return rows < 0 ||
                   rows >= lab.GetLength(0) ||
                   cols < 0 ||
                   cols >= lab.GetLength(1);
        }
    }
}
