using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
        //public int Age { get; }
        //public string Group { get; }
        public int Food { get; private set; } = 0;

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
