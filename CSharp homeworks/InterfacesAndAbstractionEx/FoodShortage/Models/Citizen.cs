using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Citizen : IBuyer
    {
        public Citizen(string name)
        {
            this.Name = name;
        }


        public string Name { get; }
        //public int Age { get; }
        //public string Id { get; }
        //public string Birthdate { get; }

        public int Food { get; private set; } = 0;

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
