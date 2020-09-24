using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsList = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsList.ContainsKey(studentName))
                {
                    studentsList[studentName].Add(grade);
                }
                else
                {
                    studentsList.Add(studentName, new List<double>());
                    studentsList[studentName].Add(grade);
                }
            }

            foreach (var item in studentsList)
            {
                if (studentsList[item.Key].Sum(c=>c) / item.Value.Count < 4.50)
                {
                    studentsList.Remove(item.Key);
                }
            }

            foreach (var item in studentsList.OrderByDescending(c=> c.Value.Sum()/c.Value.Count))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Sum() / item.Value.Count:f2}");
            }

        }
    }
}
