using System;
using System.Text;

namespace _05.Dig_Let_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder other = new StringBuilder();


            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digit.Append(input[i]);
                }
                else if (char.IsLetter(input[i]))
                {
                    letter.Append(input[i]);
                }
                else 
                {
                    other.Append(input[i]);
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(other);

        }
    }
}
