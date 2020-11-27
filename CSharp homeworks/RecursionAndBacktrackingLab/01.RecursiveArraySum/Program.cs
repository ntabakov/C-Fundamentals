using System;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _01.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(CalcSum(arr,0));
        }

        public static int CalcSum(int[] arr,int index)
        {
            if (index == arr.Length-1)
            {
                return arr[index];
            }

            return arr[index] + CalcSum(arr,++index);
        }
    }
}
