using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double total = 0;
            int end = 0;
            int endGrade = 0;
            while (grade <= 12)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark < 4.00)
                {
                    end++;
                    if (end > 1)
                    {
                        endGrade = grade-1;
                        Console.WriteLine($"{name} has been excluded at {endGrade} grade");
                        break;
                    }
                }
                else
                {
                    if(end == 1)
                    {
                        end -= 1;
                    }
                }
                total += mark;
                grade++;
            }
            if (grade == 13)
            {
                double average = total / 12;
                Console.Write($"{name} graduated. Average grade: {average:f2}");
            }

        }
    }
}