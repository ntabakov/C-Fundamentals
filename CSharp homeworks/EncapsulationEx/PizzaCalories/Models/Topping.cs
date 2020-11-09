using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories.Models
{
    public class Toppings
    {
        private const double meatMod = 1.2;
        private const double veggiesMod = 0.8;
        private const double cheeseMod = 1.1;
        private const double sauceMod = 0.9;
        private string[] valid = new string[]
            {"meat","veggies","cheese","sauce"};

        private double grams;
        private string topping;

        public Toppings(string topping,double grams)
        {
            this.Topping = topping;
            this.Grams = grams;
        }

        public string Topping
        {
            get
            {
                return this.topping;
            }
            private set
            {
                if (!CheckIfValidTopping(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.topping = value;
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.topping} weight should be in the range [1..50]."); 
                }
                this.grams = value;
            }
        }

        private bool CheckIfValidTopping(string value)
        {
            if (!valid.Contains(value.ToLower()))
            {
                return false;
            }
            return true;
        }

        public void PrintCalories()
        {
            string currTopping = this.topping;
            double topMod;
            if (currTopping.ToLower() == "meat")
            {
                topMod = meatMod;
            }
            else if (currTopping.ToLower() == "veggies")
            {
                topMod = veggiesMod;
            }
            else if (currTopping.ToLower() == "cheese")
            {
                topMod = cheeseMod;
            }
            else
            {
                topMod = sauceMod;
            }


            double calories = 2 * topMod * this.grams;
            Console.WriteLine($"{calories:f2}");
        }

        public double Calories()
        {
            string currTopping = this.topping;
            double topMod;
            if (currTopping.ToLower() == "meat")
            {
                topMod = meatMod;
            }
            else if (currTopping.ToLower() == "veggies")
            {
                topMod = veggiesMod;
            }
            else if (currTopping.ToLower() == "cheese")
            {
                topMod = cheeseMod;
            }
            else
            {
                topMod = sauceMod;
            }


            double calories = 2 * topMod * this.grams;
            return calories;
        }

    }
}
