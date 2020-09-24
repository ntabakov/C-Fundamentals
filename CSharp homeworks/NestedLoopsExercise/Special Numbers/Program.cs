using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digit = 0;
            int count = 0;
            int spec = 0;
            bool isMagic = false;

            for (int i = 1111; i <= 9999; i++)
            {
                spec = i;
                count = 0;
                while (count != 4)
                {
             
                    digit = spec % 10;
                    if (digit == 0)
                    {
                        break;
                    }
                    if (n % digit == 0)
                    {
                        spec /= 10;
                        count++;
                        if (count == 4)
                        {
                            Console.Write(i + " ");
                        }
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }


            }






        }
    }
}
