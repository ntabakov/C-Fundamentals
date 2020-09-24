using System;

namespace BackIn30
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;

            if (mins > 59)
            {
                hours++;
                mins -= 60;
                if(hours > 23)
                {
                    hours = 0;
                }
            }
            Console.WriteLine($"{hours}:{mins:d2}");

        }
    }
}
