using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public Person(string name,int age)
        {
            Age = age;
            Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
