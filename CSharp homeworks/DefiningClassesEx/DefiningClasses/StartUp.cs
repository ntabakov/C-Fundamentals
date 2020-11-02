using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {

                var input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person people = new Person(name,age);
                family.listPeople.Add(people);
            }

            List<Person> ordered = family.GetOlder(family.listPeople);
            foreach (var human in ordered.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{human.Name} - {human.Age}");
            }

        }
    }
}
