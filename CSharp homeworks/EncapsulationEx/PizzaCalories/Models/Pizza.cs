using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Toppings> toppings;
        

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Toppings>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrWhiteSpace(value) ||value.Length > 15 || value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public int NumberOfToppings
        {
            get
            {
                return this.toppings.Count;
            }
        }

        public void AddTopping(Toppings topping)
        {
            if(this.toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

       
        private double Calories()
        {
            double sum = 0;
            sum += this.dough.Calories();
            foreach (var topp in toppings)
            {
                sum += topp.Calories();
            }
            return sum;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Calories():f2} Calories.";
        }
    }
}
