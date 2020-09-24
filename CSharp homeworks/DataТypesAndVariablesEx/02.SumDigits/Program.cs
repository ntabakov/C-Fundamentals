using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            int num = int.Parse(number);
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
