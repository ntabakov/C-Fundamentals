using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            //51 47 32 61 21 
            //2


            for (int i = 0; i < n; i++)
            {
                int[] newArray = new int[array.Length];

                for (int k = 0; k < array.Length - 1; k++)
                {
                    newArray[k] = array[k + 1];
                }
                newArray[newArray.Length - 1] = array[0];

                array = newArray;

            }
            Console.WriteLine(string.Join(' ', array));


        }
    }
}
