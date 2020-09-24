using System;

namespace Beehive_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            int newBees = 0;
            int deadBees = 0;
            int byeBees = 0;

            for (int i = 1; i <= years; i++)
            {
                newBees = population / 10 * 2;
                population +=newBees;
                if (i % 5 == 0)
                {
                    byeBees = population / 50 * 5;
                    population -= byeBees;
                }
                    deadBees = population / 20 * 2;
                population -= deadBees;
            }
            Console.WriteLine($"Beehive population: {population}");



        }
    }
}
