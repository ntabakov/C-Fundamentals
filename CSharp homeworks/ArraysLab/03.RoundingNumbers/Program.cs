using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =  Console.ReadLine() ;
            string[] nums = input.Split();
            double[] arr = nums.Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (arr[i] == -0 || arr[i] == -0.0 || arr[i] == -0.00)
                {
                    arr[i] = 0;
                }
                Console.WriteLine($"{arr[i]} => {(int)Math.Round(arr[i],MidpointRounding.AwayFromZero)}");
            }


        }
    }
}
