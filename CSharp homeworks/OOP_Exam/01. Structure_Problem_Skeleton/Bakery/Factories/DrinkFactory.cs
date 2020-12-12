using System;
using System.Collections.Generic;
using System.Text;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Drinks.Models;

namespace Bakery.Factories
{
    public class DrinkFactory
    {
        public IDrink CreateDrink(string type, string name, int portion, string brand)
        {
            IDrink drink = null;
            if (type == "Tea")
            {
                drink = new Tea(name,portion,brand);
            }
            else if (type == "Water")
            {
                drink = new Water(name,portion,brand);
            }
            else
            {
                throw new ArgumentException("InvalidType");
            }

            return drink;
        }
    }
}
