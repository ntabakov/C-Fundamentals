using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text = "";

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command[0] == '1')
                {
                    var cE = command.Split();
                    stack.Push(text);
                    text += cE[1];

                }
                else if(command[0] == '2')
                {
                    var cE = command.Split();
                    int count = int.Parse(cE[1]);
                    stack.Push(text);
                    //abcdfg
                    text = text.Substring(0, text.Length - count) ;
                }
                else if (command[0] == '3')
                {
                    var cE = command.Split();
                    int index = int.Parse(cE[1]);
                    Console.WriteLine(text[index-1]);

                }
                else if (command[0] == '4')
                {
                    text = stack.Pop();
                }
            }
        }

       
    }
}
