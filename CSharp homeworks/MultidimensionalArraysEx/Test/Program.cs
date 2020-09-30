using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] test = new int[4, 5];

            int rows = test.GetLength(0);
            int cols = test.GetLength(1);
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    test[row, col] = count;
                    count++;


                }
            }
            count = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                    Console.Write(test[row, col] + " ");


                }
                Console.WriteLine();
            }
        }
        static void ReadMatrix(int rows,int cols)
        {

        }
    }
}
