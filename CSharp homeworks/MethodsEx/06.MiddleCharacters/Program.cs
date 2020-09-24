using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharactersOfString(input);
        }

        static void PrintMiddleCharactersOfString(string input)
        {
            // someTex
            // 0123456
            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if(input.Length / 2 - 1  == i)
                    {
                        Console.Write(input[i]);
                    }
                    else if(input.Length / 2 == i)
                    {
                        Console.Write(input[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (input.Length / 2 == i)
                    {
                        Console.Write(input[i]);
                    }
                }
            }
            
        }
    }
}
