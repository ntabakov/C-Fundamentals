using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            CalculateNumbers(operation, first, second);

        }

        static void CalculateNumbers(string operation, int a, int b)
        {
            if (operation == "add")
            {
                Add(a, b);
            }
            else if (operation == "multiply")
            {
                Multiply(a, b);
            }
            else if (operation == "substract")
            {
                Substract(a, b);
            }
            else if (operation == "divide")
            {
                Divide(a, b);
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        

    }
}
