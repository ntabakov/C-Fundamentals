using System;
using System.Linq;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            string[] sites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryphone = new StationaryPhone();

            foreach (var number in numbers)
            {
                if (number.All(x => char.IsDigit(x)))
                {


                    if (number.Length == 7)
                    {
                        stationaryphone.Call(number);
                    }
                    else if (number.Length == 10)
                    {
                        smartphone.Call(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var site in sites)
            {
                if (!site.Any(x => char.IsDigit(x)))
                {
                    smartphone.Browse(site);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
    }
}
