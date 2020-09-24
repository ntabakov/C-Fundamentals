using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool test = false;
            for (int i = 1; i <= n; i++)
            {
                for (int m = 1; m <= i; m++)
                {
                    if (current > n)
                    {
                        test = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (test)
                {
                    break;
                }
                Console.WriteLine();
            }



        }
    }
}
