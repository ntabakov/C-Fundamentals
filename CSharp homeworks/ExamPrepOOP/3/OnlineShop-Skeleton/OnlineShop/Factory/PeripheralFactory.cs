using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using OnlineShop.Models.Products.Peripherals;
using OnlineShop.Models.Products.Peripherals.Models;

namespace OnlineShop.Factory
{
    public class PeripheralFactory
    {
        public IPeripheral CreatePeripheral(int id, string peripheralType, string manufacturer, string model,
            decimal price,
            double overallPerformance, string connectionType)
        {
            IPeripheral periph = null;
            if (peripheralType == "Headset")
            {
                periph = new Headset(id,manufacturer,model,price,overallPerformance,connectionType);
            }
            else if (peripheralType == "Keyboard")
            {
                periph = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);

            }
            else if (peripheralType == "Monitor")
            {
                periph = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);

            }
            else if (peripheralType == "Mouse")
            {
                periph = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);

            }
            else
            {
                throw new ArgumentException("Peripheral type is invalid.");
            }

            return periph;
        }
    }
}
