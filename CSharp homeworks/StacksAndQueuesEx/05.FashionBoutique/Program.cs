using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int rackCount = 0;
            int sum = 0;
            Stack<int> stack = new Stack<int>(clothes);

            while (stack.Count > 0)
            {
                if(sum + stack.Peek() <= capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    sum = 0;
                    rackCount++;
                }
                if(stack.Count== 0)
                {
                    rackCount++;
                }
            }
            
            Console.WriteLine(rackCount);
        }
    }
}
