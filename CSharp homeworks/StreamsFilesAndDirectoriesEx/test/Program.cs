using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int sumOne = 0;
            int sumTwo = 0;

            for (int row = 0; row < arr.Count; row++)
            {
                sumOne += arr[row][row];
            }

            for (int row = 0; row < arr.Count; row++)
            {
                sumTwo += arr[row][arr.Count - row - 1];
            }
            Console.WriteLine(sumOne + sumTwo);
        }
    }
}
