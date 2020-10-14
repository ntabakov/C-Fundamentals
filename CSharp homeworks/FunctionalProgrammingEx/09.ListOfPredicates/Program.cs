using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> list = new List<int>();
            list = Result(seq, range);
            Console.WriteLine(String.Join(" ",list));
        }

        static List<int> Result(int[] arr,int range)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                bool isDividable = false;
                for (int k = 0; k < arr.Length; k++)
                {
                    if( i % arr[k] == 0)
                    {
                        isDividable = true;
                    }
                    else
                    {
                        isDividable = false;
                        break;
                    }
                }
                if (isDividable)
                {
                    result.Add(i);
                }
            }
            return result;

        }


    }
}
