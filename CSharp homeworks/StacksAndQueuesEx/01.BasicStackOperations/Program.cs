using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int s = input[1];
            int x = input[2];

            Queue<int> stack = new Queue<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();

            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count <=0)
            {
                Console.WriteLine("0");
            }
            else 
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
