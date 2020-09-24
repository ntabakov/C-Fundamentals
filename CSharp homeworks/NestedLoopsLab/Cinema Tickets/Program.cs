using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketNum = 0;
            int studentTicket = 0;
            int kidTicket = 0;
            int standartTicket = 0;
            double ticketCurrentMovie = 0;

            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                double freePlaces = int.Parse(Console.ReadLine());

                while (freePlaces > ticketNum)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        Console.WriteLine($"{movie} - {(ticketCurrentMovie / freePlaces) * 100.00:f2}% full.");
                        ticketCurrentMovie = 0;

                        break;
                    }
                    ticketNum++;
                    ticketCurrentMovie++;
                    if (ticketType == "student")
                    {
                        studentTicket++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicket++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartTicket++;
                    }
                    if (freePlaces == ticketNum)
                    {
                        Console.WriteLine($"{movie} - {(ticketCurrentMovie / freePlaces) * 100.00:f2}% full.");
                        ticketCurrentMovie = 0;

                        break;
                    }
                }
            }
            Console.WriteLine($"Total tickets: {ticketNum}");
            Console.WriteLine($"{studentTicket / ticketNum * 100:f2}% student tickets.");
            Console.WriteLine($"{standartTicket / ticketNum * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTicket / ticketNum * 100:f2}% kids tickets.");








        }
    }
}
