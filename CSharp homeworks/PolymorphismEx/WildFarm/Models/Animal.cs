using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Common;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        protected abstract double WeightIncrease { get;  }

        protected abstract string[] favouriteFoodTypes { get; }

        public string Name { get; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public virtual void Feed(string foodType, int foodQuantity)
        {
            if (favouriteFoodTypes.Contains(foodType))
            {
                this.FoodEaten += foodQuantity;
                this.Weight += foodQuantity * WeightIncrease;
            }
            else
            {
                Console.WriteLine(String.Format(Messages.WrongAnimalFood, this.GetType().Name, foodType));
            }
        }
        public abstract void ProduceSound();
    }
}
