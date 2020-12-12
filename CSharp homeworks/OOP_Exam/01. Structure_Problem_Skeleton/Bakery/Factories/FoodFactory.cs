using System;
using System.Collections.Generic;
using System.Text;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.BakedFoods.Models;

namespace Bakery.Factories
{
    public class FoodFactory
    {
        public IBakedFood CreateFood(string type, string name, decimal price)
        {
            IBakedFood food = null;
            if (type == "Bread")
            {
                food = new Bread(name,price);
            }
            else if (type == "Cake")
            {
                food = new Cake(name,price);
            }
            else
            {
                throw new ArgumentException("InvalidType");
            }

            return food;
        }
    }
}
