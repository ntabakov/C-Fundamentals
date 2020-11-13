using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightIncrease { get; } = 0.35;

        protected override string[] favouriteFoodTypes => new string[] { "Everything" };

        public override void Feed(string foodType, int foodQuantity)
        {
            this.Weight += foodQuantity * this.WeightIncrease;
            FoodEaten += foodQuantity;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
