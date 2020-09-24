using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenDate = Console.ReadLine();

            DateTime date = DateTime.ParseExact(givenDate, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
