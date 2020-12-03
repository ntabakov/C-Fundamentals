using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals.Factory;
using Animals.Models;

namespace Animals
{
    public class Engine
    {
        private List<Animal> animals;

        public Engine()
        {
            animals = new List<Animal>();
        }
        public void Run()
        {
            AnimalFactory af = new AnimalFactory();
            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                var args = Console.ReadLine().Split();
                string type = input;
                animals.Add(af.CreateAnimal(type,args));
            }
            Print();
        }

        public void Print()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
