using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> check = UppercaseCheck;

            var input = Console.ReadLine().Split(' ')
                .Where(check).ToArray();
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        static bool UppercaseCheck(string text)
        {
            if(text[0] == text.ToUpper()[0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
