using System;

namespace Problem_1._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());

            int courseBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxStudentAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int studentAttendance = int.Parse(Console.ReadLine());
                double bonus = studentAttendance * 1.0 / lecturesCount * (5 + courseBonus);

                if (bonus > maxBonus)
                {
                    maxBonus = bonus;
                    maxStudentAttendance = studentAttendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxStudentAttendance} lectures.");
        }
    }
}
