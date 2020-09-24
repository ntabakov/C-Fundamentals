using System;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool check = false;
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length >= 3 && input[i].Length <= 16)
                {
                    foreach (var symbol in input[i])
                    {
                        if(char.IsLetterOrDigit(symbol)||symbol == '-'|| symbol == '_')
                        {
                            check = true;
                        }
                        else
                        {
                            check = false;
                            break;
                        }

                    }
                    if (check)
                    {
                        Console.WriteLine(input[i]);
                    }
                }
            }
        }
    }
}
