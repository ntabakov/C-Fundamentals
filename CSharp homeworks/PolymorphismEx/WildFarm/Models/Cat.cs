using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightIncrease { get; } = 0.30;
        protected override string[] favouriteFoodTypes => new string[] { "Vegetable", "Meat" };
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
