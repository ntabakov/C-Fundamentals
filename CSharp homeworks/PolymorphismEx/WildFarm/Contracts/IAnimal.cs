using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Contracts
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        public int FoodEaten { get; }

        public void ProduceSound();
        public void Feed(string foodType, int foodQuantity);
    }
}
