using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<People> people = new List<People>();
            while (command != "End")
            {
                string[] commandElements = command.Split();
                People inputPeople = new People(commandElements[0],
                    commandElements[1], int.Parse(commandElements[2]));
                people.Add(inputPeople);
                command = Console.ReadLine();
            }
            List<People> ordered = people.OrderBy(x => x.Age).ToList();
            for (int i = 0; i < ordered.Count; i++)
            {
                Console.WriteLine(ordered[i]);
            }

        }

        class People
        {
            public People(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
            }
        }
    }
}
