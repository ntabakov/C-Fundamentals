using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            while(numbers != "END")
            {
                if(SameBackwardAndForwardNumber(numbers))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                numbers = Console.ReadLine();
            }
        }

        static bool SameBackwardAndForwardNumber (string number)
        {
            // 121
            // 012
            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i] == number[number.Length -1 - i])
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
