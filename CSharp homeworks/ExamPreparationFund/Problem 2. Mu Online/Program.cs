using System;

namespace Problem_2._Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            int health = 100;
            int bitcoins = 0;
            byte roomCount = 0;
            bool win = true;

            for (int i = 0; i < input.Length; i++)
            {
                string[] command = input[i].Split();
                string room = command[0];
                int number = int.Parse(command[1]);

                if (room == "potion")
                {
                    
                    if (health + number > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;

                    }
                    else
                    {
                        health += number;
                        Console.WriteLine($"You healed for {number} hp.");

                    }
                    Console.WriteLine($"Current health: {health} hp.");
                    roomCount++;
                }
                else if (room == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                    roomCount++;

                }
                else
                {
                    health -= number;
                    if (health <= 0)
                    {
                        roomCount++;
                        win = false;
                        Console.WriteLine($"You died! Killed by {room}.");
                        Console.WriteLine($"Best room: {roomCount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {room}.");
                        roomCount++;
                    }
                }
            }
            if (win)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
