using System;
using System.Collections.Generic;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Computers.Models;

namespace OnlineShop.Factory
{
    public class ComputerFactory
    {
        public IComputer CreateComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            IComputer comp = null;
            if (computerType == "Laptop")
            {
                comp = new Laptop(id,manufacturer,model,price);
            }
            else if (computerType == "DesktopComputer")
            {
                comp = new DesktopComputer(id,manufacturer,model,price);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }

            return comp;
        }
    }
}
