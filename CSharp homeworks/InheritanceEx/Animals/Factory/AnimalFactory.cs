using System;
using System.Collections.Generic;
using System.Text;
using Animals.Models;

namespace Animals.Factory
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type,string[] args)
        {
            Animal animal = null;

            string name = args[0];
            int age = int.Parse(args[1]);
            string gender = null;
            try
            {
                if (args.Length >= 3)
                {
                    gender = args[2];
                }

                if (type == "Dog")
                {
                    animal = new Dog(name, age, gender);
                }
                else if (type == "Cat")
                {
                    animal = new Cat(name, age, gender);

                }
                else if (type == "Frog")
                {
                    animal = new Frog(name, age, gender);

                }
                else if (type == "Kitten")
                {
                    animal = new Kitten(name, age);

                }
                else if (type == "Tomcat")
                {
                    animal = new Tomcat(name, age);

                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            

            return animal;
        }
    }
}
