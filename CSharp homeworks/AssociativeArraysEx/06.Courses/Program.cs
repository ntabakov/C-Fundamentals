using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();

            while (input!= "end")
            {
                string[] command = input.Split( " : ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string courseName = command[0];
                string studentName = command[1];

                if (list.ContainsKey(courseName))
                {
                    list[courseName].Add(studentName);
                }
                else
                {
                    list.Add(courseName, new List<string>());
                    list[courseName].Add(studentName);
                }
                input = Console.ReadLine();
            }
            
            var done = list.OrderByDescending(c => c.Value.Count);
            

            foreach (var item in done)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                List<string> students = item.Value.OrderBy(c => c).ToList();
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"-- {students[i]}");
                }
            }



        }
    }
}
