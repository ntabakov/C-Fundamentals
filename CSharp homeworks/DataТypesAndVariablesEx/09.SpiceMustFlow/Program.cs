using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int days = 0;
            int leftSpice = 0;

            while (yield >= 100)
            {
                leftSpice += yield - 26;
                yield -= 10;
                days++;
            }
            leftSpice -= 26;
            if(leftSpice < 0)
            {
                leftSpice = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(leftSpice);
        }
    }
}
