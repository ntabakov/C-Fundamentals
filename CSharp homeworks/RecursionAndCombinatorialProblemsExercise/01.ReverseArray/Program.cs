using System;

namespace _01.ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split();

            Reverse(0, array);

            Console.WriteLine(string.Join(" ",array));
        }

        private static void Reverse(int left, string[] array)
        {
            if (left >= array.Length/2)
            {
                return;
            }
            var right = array.Length - 1 - left;

            Swap(array, left, right);

            Reverse(left+1,array);
        }

        private static void Swap(string[] array, int left, int right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
