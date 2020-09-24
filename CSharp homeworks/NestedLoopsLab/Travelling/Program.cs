using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = 0;
            bool ending = false;
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    ending = true;
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                while (true)
                {
                    if (budget > 0)
                    {
                        savings = double.Parse(Console.ReadLine());

                        budget -= savings;
                    }
                    else
                    {
                        Console.WriteLine($"Going to {destination}!");
                        ending = true;

                        break;
                    }
                }

            }







        }
    }
}
