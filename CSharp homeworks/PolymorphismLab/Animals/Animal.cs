﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favFood)
        {
            this.name = name;
            this.favouriteFood=favFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my fovourite food is {this.favouriteFood}";
        }
    }
}
