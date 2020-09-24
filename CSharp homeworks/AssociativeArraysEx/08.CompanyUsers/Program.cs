using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();


            while (input != "End")
            {
                string[] commandLine = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string company = commandLine[0];
                string id = commandLine[1];

                if (!list.ContainsKey(company))
                {
                    list.Add(company, new List<string>());
                    list[company].Add(id);
                }
                if (!list[company].Contains(id))
                {
                    list[company].Add(id);
                }

                input = Console.ReadLine();
            }

            foreach (var item in list.OrderBy(c=>c.Key))
            {
                List<string> temp = item.Value;
                Console.WriteLine($"{item.Key}");
                for (int i = 0; i < temp.Count; i++)
                {
                    Console.WriteLine($"-- {temp[i]}");

                }
            }

        }
    }
}
