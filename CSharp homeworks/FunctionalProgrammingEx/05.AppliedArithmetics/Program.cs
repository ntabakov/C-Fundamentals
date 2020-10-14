using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            Func<int, int> addFunc = x => x + 1;
            Func<int, int> multiplyFunc = x => x *2;
            Func<int, int> subtractFunc = x => x - 1;


            while (command != "end")
            {
                if(command == "add")
                {
                    input = input.Select(addFunc).ToList();
                }
                else if (command == "multiply")
                {
                    input = input.Select(multiplyFunc).ToList();

                }
                else if (command == "subtract")
                {
                    input = input.Select(subtractFunc).ToList();

                }
                else if (command == "print")
                {
                    Console.WriteLine(String.Join(" ",input));

                }




                command = Console.ReadLine();
            }
        }
    }
}
