using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word!="end")
            {
                string reversed = "";
                //hello
                for (int i = word.Length-1; i >= 0; i--)
                {
                    reversed += word[i];
                }
                Console.WriteLine($"{word} = {reversed}");
                word = Console.ReadLine();
            }
        }
    }
}
