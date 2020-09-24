using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> inputStudents = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                string[] enterStundet = Console.ReadLine().Split();
                student.FirstName = enterStundet[0];
                student.LastName = enterStundet[1];
                student.Grade = decimal.Parse(enterStundet[2]);
                inputStudents.Add(student);
            }
            List<Student> orderedStudents = inputStudents.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(String.Join("\n",orderedStudents));
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade}";
            }
        }
    }
}
