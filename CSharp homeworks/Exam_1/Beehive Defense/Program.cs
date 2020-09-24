using System;

namespace Beehive_Defense
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesNum = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int attack = int.Parse(Console.ReadLine());

            bool bearWin = false;

            while (true)
            {
                beesNum -= attack;
                if (beesNum < 100)
                {
                    bearWin = true;
                    break;
                }
                health = health - beesNum * 5;
                if (health <= 0)
                {
                    break;
                }
            }
            if (beesNum < 0)
            {
                beesNum = 0;
            }
            if (bearWin)
            {
                Console.WriteLine($"The bear stole the honey! Bees left {beesNum}.");
            }
            else
            {
                Console.WriteLine($"Beehive won! Bees left {beesNum}.");
            }
        }
    }
}
