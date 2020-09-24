using System;

namespace Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            string gameType = "";
            double points = 0;

            double volleyPoints = 0;
            double tennisPoints = 0;
            double badmintonPoints = 0;

            int volleyGames = 0;
            int tennisGames = 0;
            int badmintonGames = 0;



            for (int i = 1; i <= gamesPlayed; i++)
            {
                gameType = Console.ReadLine();
                points = double.Parse(Console.ReadLine());
                switch (gameType)
                {
                    case "volleyball":
                        points = points + points * 0.07;
                        volleyPoints += points;
                        volleyGames++;
                        break;
                    case "tennis":
                        points = points + points * 0.05;
                        tennisPoints += points;
                        tennisGames++;
                        break;
                    case "badminton":
                        points = points + points * 0.02;
                        badmintonPoints += points;
                        badmintonGames++;
                        break;
                }
            }
            double volleyEnd = Math.Floor(volleyPoints / volleyGames * 100) / 100;
            double tennisEnd = Math.Floor(tennisPoints / tennisGames * 100) / 100;
            double badmintonEnd = Math.Floor(badmintonPoints / badmintonGames * 100) / 100;

            double sum = Math.Floor(volleyPoints + badmintonPoints + tennisPoints);

            if (volleyEnd >= 75 && tennisEnd >= 75 && badmintonEnd >= 75)
            {
                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {sum} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {sum}.");
            }

        }
    }
}
