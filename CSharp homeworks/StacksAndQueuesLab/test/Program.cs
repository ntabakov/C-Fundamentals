using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> opa = new Queue<int>(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(String.Join(", ",opa));
            opa.Dequeue();
            Console.WriteLine(String.Join(", ", opa));

            Stack<int> kyk = new Stack<int>(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(String.Join(", ", kyk));
            kyk.Pop();
            Console.WriteLine(String.Join(", ", kyk));








        }
    }
}
