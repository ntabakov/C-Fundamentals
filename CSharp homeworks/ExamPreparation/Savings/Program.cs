using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double sumPrivate = double.Parse(Console.ReadLine());

            double unPlanned = income * 0.3;

            double sumPerMonth = income - (sumPrivate + unPlanned);

            double sumTotalMonths = months * sumPerMonth;

            double percentage = sumPerMonth / income * 100.00;

            Console.WriteLine($"She can save {percentage:f2}%");
            Console.WriteLine($"{sumTotalMonths:f2}");

        }
    }
}
