using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity) 
            : base(fuelQuantity, fuelConsumption,tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + 1.6;

        public override void Refuel(double amount)
        {
            if (amount > 0)
            {


                if (this.FuelQuantity + amount > this.TankCapacity)
                {
                    Console.WriteLine(String.Format(Messages.OvercappedFuel, amount));

                }
                else
                {
                    this.FuelQuantity += amount*0.95;
                }
            }
            else
            {
                Console.WriteLine(Messages.NegativeOrZeroFuel);
            }
        }
    }
}
