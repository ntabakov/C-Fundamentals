using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMark = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblems = 0;
            double sumMark = 0;
            double average = 0;
            string lastExercise = "";
            bool isFailed = true;



            while(failedTimes < badMark)
            {
                string exerciseName = Console.ReadLine();
                if(exerciseName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int mark = int.Parse(Console.ReadLine());
                if (mark <= 4)
                {
                    failedTimes++;
                }
                sumMark += mark;
                solvedProblems++;
                lastExercise = exerciseName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badMark} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumMark/solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastExercise}");

            }



        }
    }
}
