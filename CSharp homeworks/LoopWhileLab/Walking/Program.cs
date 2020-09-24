using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 0;
            while (goal < 10000)
            {
                string steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    goal += int.Parse(steps);
                    
                    break;
                }
                else
                {
                    goal += int.Parse(steps);

                }
            }
            if (goal >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int needSteps = 10000 - goal;
                Console.WriteLine($"{needSteps} more steps to reach goal.");
            }






        }
    }
}
