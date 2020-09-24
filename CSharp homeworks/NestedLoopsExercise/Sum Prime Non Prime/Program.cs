using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            int n;
            int primeSum = 0;
            int nonPrimeSum = 0;

            while(true)
            {
                number = Console.ReadLine();
                if (number == "stop")
                {
                    break;
                }
                int m = 0;
                int flag = 0;
                n = int.Parse(number);
                m = n / 2;
                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        nonPrimeSum += n;
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    primeSum += n;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
