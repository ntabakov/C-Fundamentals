using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Common;

namespace WildFarm.Models
{
    public class Owl : Bird
    {

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightIncrease { get; } = 0.25;

        protected override string[] favouriteFoodTypes => new string[] { "Meat" };

       

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
