using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightIncrease { get; } = 1.00;

        protected override string[] favouriteFoodTypes => new string[] { "Meat" };

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
