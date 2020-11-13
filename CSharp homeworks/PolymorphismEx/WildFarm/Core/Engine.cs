using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Factory;
using WildFarm.Models;

namespace WildFarm.Core
{
    public class Engine
    {
        private AnimalFactory animalFactory;
        private ICollection<Animal> animals;

        public Engine()
        {
            animalFactory = new AnimalFactory();
            animals = new List<Animal>();
        }
        public void Run()
        {
            Setup();
        }

        private void Setup()
        {

            string command = null;
            while ((command = Console.ReadLine() )!="End")
            {
                string[] animalArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] foodArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Animal currAnimal = animalFactory.ProduceAnimal(animalArgs);
                string foodType = foodArgs[0];
                int foodQuantity = int.Parse(foodArgs[1]);

                currAnimal.ProduceSound();
                currAnimal.Feed(foodType, foodQuantity);

                animals.Add(currAnimal);


                
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
