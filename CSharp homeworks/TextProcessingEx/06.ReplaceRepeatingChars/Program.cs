using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            StringBuilder test = new StringBuilder();
            test.Append(input);
            //abcd
            //0123
            for (int i = 0; i < input.Length - 1; i++)
            {
                if(test[i]==test[i+1])
                {
                    test.Append(test.Remove(i + 1, 0));
                }
            }
            Console.WriteLine(test);
        }
    }
}
