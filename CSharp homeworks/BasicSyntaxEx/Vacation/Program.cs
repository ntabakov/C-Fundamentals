using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string dayType = Console.ReadLine();

            double sum = 0;

            switch (peopleType)
            {
                case "Students":
                    if (dayType == "Friday")
                    {
                        sum = peopleCount * 8.45;

                    }
                    else if (dayType == "Saturday")
                    {
                        sum = peopleCount * 9.80;
                    }
                    else if (dayType == "Sunday")
                    {
                        sum = peopleCount * 10.46;
                    }
                    if (peopleCount >= 30)
                    {
                        sum = sum - sum * 0.15;
                    }
                    break;

                case "Business":

                    if (peopleCount >= 100)
                    {
                        if (dayType == "Friday")
                        {
                            sum = (peopleCount - 10) * 10.90;

                        }
                        else if (dayType == "Saturday")
                        {
                            sum = (peopleCount - 10) * 15.60;
                        }
                        else if (dayType == "Sunday")
                        {
                            sum = (peopleCount - 10) * 16;
                        }
                    }
                    else
                    {
                        if (dayType == "Friday")
                        {
                            sum = peopleCount * 10.90;

                        }
                        else if (dayType == "Saturday")
                        {
                            sum = peopleCount * 15.60;
                        }
                        else if (dayType == "Sunday")
                        {
                            sum = peopleCount * 16;
                        }
                    }
                    break;

                case "Regular":
                    if (dayType == "Friday")
                    {
                        sum = peopleCount * 15;

                    }
                    else if (dayType == "Saturday")
                    {
                        sum = peopleCount * 20;
                    }
                    else if (dayType == "Sunday")
                    {
                        sum = peopleCount * 22.50;
                    }

                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        sum = sum - sum * 0.05;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
