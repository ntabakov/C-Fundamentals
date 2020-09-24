using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeed = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendCount = 0;

            while (moneyHave < moneyNeed && spendCount <5)
            {
                string command = Console.ReadLine();

                if (command == "spend")
                {
                    double moneySpend = double.Parse(Console.ReadLine());
                    moneyHave -= moneySpend;
                    if (moneyHave < 0)
                    {
                        moneyHave = 0;
                    }
                    spendCount++;
                    daysCount++;
                }
                else if (command == "save")
                {
                    double moneySave = double.Parse(Console.ReadLine());
                    moneyHave += moneySave;
                    daysCount++;
                    spendCount = 0;
                }
                if (spendCount == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCount}");

                    break;
                }
                if (moneyHave>= moneyNeed)
                {
                    Console.WriteLine($"You saved the money for {daysCount} days.");

                    break;
                }
            }



        }
    }
}
