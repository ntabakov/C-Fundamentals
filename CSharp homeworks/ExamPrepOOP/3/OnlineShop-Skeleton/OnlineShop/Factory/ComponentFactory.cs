using System;
using System.Collections.Generic;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Components.Models;

namespace OnlineShop.Factory
{
    public class ComponentFactory
    {
        public IComponent CreateComponent(int id, string componentType, string manufacturer, string model,
            decimal price,
            double overallPerformance, int generation)
        {
            IComponent comp = null;
            if (componentType == "CentralProcessingUnit")
            {
                comp = new CentralProcessingUnit(id,manufacturer,model,price,overallPerformance,generation);
            }
            else if (componentType == "Motherboard")
            {
                comp = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);

            }
            else if (componentType == "PowerSupply")
            {
                comp = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);

            }
            else if (componentType == "RandomAccessMemory")
            {
                comp = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);

            }
            else if (componentType == "SolidStateDrive")
            {
                comp = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);

            }
            else if (componentType == "VideoCard")
            {
                comp = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }

            return comp;
        }
    }
}
