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
            char test = '4';
            Console.WriteLine(test == 52);

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
