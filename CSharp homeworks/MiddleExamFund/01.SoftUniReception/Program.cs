using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());

            int studentCount = int.Parse(Console.ReadLine());

            int totalAnsweredPerHour = employeeOne + employeeTwo + employeeThree;

            int workTime = 1;
            int hours = 0;
            int answeredStudents = 0;



            while (studentCount > answeredStudents)
            {
                if (workTime % 4 == 0 && workTime != 0)
                {
                    hours++;
                }
                else
                {

                    answeredStudents += totalAnsweredPerHour;
                    if (studentCount <= answeredStudents)
                    {
                        hours++;
                        break;
                    }
                    hours++;
                }
                workTime++;

            }
            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
