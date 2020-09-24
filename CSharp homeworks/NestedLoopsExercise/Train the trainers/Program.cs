using System;

namespace Train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judge = int.Parse(Console.ReadLine());
            string presentation = "";
            double totalCurrentMark = 0;
            int presentationCount = 0;
            double totalmark = 0;
            double mark = 0;

            while (true)
            {
                presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    break;
                }
                for (int i = 1; i <= judge; i++)
                {
                    mark = double.Parse(Console.ReadLine());
                    totalCurrentMark += mark;
                }
                Console.WriteLine($"{presentation} - {totalCurrentMark / judge:f2}.");
                presentationCount++;
                totalmark += totalCurrentMark / judge;
                totalCurrentMark = 0;
            }
            Console.WriteLine($"Student's final assessment is {totalmark / presentationCount:f2}.");


        }
    }
}
