using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Stack<byte> stack = new Stack<byte>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if(command[0] == '1')
                {
                    var cE = command.Split();
                    byte x = byte.Parse(cE[1]);
                    stack.Push(x);

                }
                else if (command == "2")
                {
                    //
                    stack.Pop();
                }
                else if (command == "3")
                {
                    if (stack.Count> 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
