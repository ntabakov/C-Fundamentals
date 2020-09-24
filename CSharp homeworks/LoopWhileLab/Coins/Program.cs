using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int coins = 0;
            while (sum > 0)
            {
                if (sum >= 2)
                {
                    sum -= 2;
                    sum = Math.Round(sum, 2);
                    coins++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    sum = Math.Round(sum, 2);

                    coins++;
                }
                else if (sum >= 0.50)
                {
                    sum -= 0.50;
                    sum = Math.Round(sum, 2);

                    coins++;
                }
                else if ( sum >= 0.20)
                {
                    sum -= 0.20;
                    sum = Math.Round(sum, 2);

                    coins++;
                }
                else if ( sum >= 0.10)
                {
                    sum -= 0.10;
                    sum = Math.Round(sum, 2);

                    coins++;
                }
                else if ( sum >= 0.05)
                {
                    sum -= 0.05;
                    sum = Math.Round(sum, 2);

                    coins++;

                }
                else if (sum >= 0.02)
                {
                    sum -= 0.02;
                    sum = Math.Round(sum, 2);

                    coins++;
                }
                else if (sum >= 0.01)
                {
                    sum -= 0.01;
                    sum = Math.Round(sum, 2);

                    coins++;
                }

                if (sum <= 0)
                {
                    break;
                }
            }
            Console.WriteLine($"{coins}");




        }
    }
}
