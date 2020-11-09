using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories.Models
{
    public class Dough
    {
        //Every dough has 2 calories per gram as a 
        //base and a modifier that gives the exact calories.
        //For example, a white dough has a
        //modifier of 1.5, a chewy dough has a modifier of 
        //1.1, which means that a white chewy dough,
        //weighting 100 grams will have
        //(2 * 100) * 1.5 * 1.1 = 330.00 total calories.
        private const double chewyMod = 1.1;
        private const double whiteMod = 1.5;
        private const double wholeGrainMod = 1.0;
        private const double crispyMod = 0.9;
        private const double homemadeMod = 1.0;

        private string flour;
        private string bakingTechnique;
        private double weight;

        private string[] validFloursAndBakingTechs = new string[]
        {"white","wholegrain","crispy","chewy","homemade"};

        public Dough(string flour, string bakingTech, double weight)
        {
            this.Flour = flour;
            this.BakingTechnique = bakingTech;
            this.Weight = weight;

        }

        public string Flour
        {
            get
            {
                return this.flour;
            }
            private set
            {
                if (!CheckIfValidFlourAndBT(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flour = value;
            }
        }
        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (!CheckIfValidFlourAndBT(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value > 200 || value < 1)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public void CalculateCalories()
        {
            double flourModi;
            double btModi;
            if (this.Flour.ToLower() == "white")
            {
                flourModi = whiteMod;
            }
            else
            {
                flourModi = wholeGrainMod;
            }

            if(this.BakingTechnique.ToLower() == "crispy")
            {
                btModi = crispyMod;
            }
            else if( this.BakingTechnique.ToLower() == "chewy")
            {
                btModi = chewyMod;
            }
            else
            {
                btModi = homemadeMod;
            }

            double calories = 2 * flourModi * btModi * this.weight;
            Console.WriteLine($"{calories:f2}");
        }
        public double Calories()
        {
            double flourModi;
            double btModi;
            if (this.Flour.ToLower() == "white")
            {
                flourModi = whiteMod;
            }
            else
            {
                flourModi = wholeGrainMod;
            }

            if (this.BakingTechnique.ToLower() == "crispy")
            {
                btModi = crispyMod;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                btModi = chewyMod;
            }
            else
            {
                btModi = homemadeMod;
            }

            double calories = 2 * flourModi * btModi * this.weight;
            return calories;
        }

        private bool CheckIfValidFlourAndBT(string value)
        {
            if (!this.validFloursAndBakingTechs.Contains(value.ToLower()))
            {
                return false;
            }
            return true;
        }
    }
}
