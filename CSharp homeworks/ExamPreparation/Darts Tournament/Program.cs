using System;

namespace Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoints = int.Parse(Console.ReadLine());
            string shot = "";
            int shotPoints = 0;
            bool win = false;
            int moves = 0;

            while (startPoints > 0 && win == false)
            {
                shot = Console.ReadLine();
                
                switch (shot)
                {
                    case "number section":
                        shotPoints = int.Parse(Console.ReadLine());
                        moves++;
                        break;

                    case "double ring":
                        shotPoints = int.Parse(Console.ReadLine());
                        shotPoints *= 2;
                        moves++;
                        break;

                    case "triple ring":
                        shotPoints = int.Parse(Console.ReadLine());
                        shotPoints *= 3;
                        moves++;
                        break;

                    case "bullseye":
                        win = true;
                        moves++;
                        break;
                }
                startPoints = startPoints - shotPoints;
                if (startPoints <= 0)
                {
                    break;
                }
            }
            if (win == true)
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");

            }
            else if (startPoints < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startPoints)}.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
            }


        }
    }
}
