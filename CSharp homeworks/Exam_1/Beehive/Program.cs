using System;

namespace Beehive
{
    class Program
    {
        static void Main(string[] args)
        {
            int intelect = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            string role = "";

            if (intelect >= 80)
            {
                if (strength >= 80)
                {
                    if (gender == "female")
                    {
                        role = "Queen Bee";
                    }
                    else if (intelect >= 80)
                    {
                        role = "Repairing Bee";
                    }
                }
                else if (intelect >= 80)
                {
                    role = "Repairing Bee";
                }
            }
            
            else if (intelect >= 60)
            {
                role = "Cleaning Bee";
            }
            else if (strength >= 80)
            {
                if (gender == "male")
                {
                    role = "Drone Bee";
                }
                else if (strength >= 60)
                {
                    role = "Guard Bee";
                }
            }
            else if (strength >= 60)
            {
                role = "Guard Bee";
            }
            else
            {
                role = "Worker Bee";
            }
            Console.WriteLine(role);
        }
    }
}
