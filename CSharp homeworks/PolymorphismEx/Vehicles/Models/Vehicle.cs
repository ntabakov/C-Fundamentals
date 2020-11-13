using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {

        protected Vehicle(double fuelQuantity,double fuelConsumption,double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public virtual double FuelConsumption { get; protected set; }

        public double TankCapacity { get; }


        public virtual void Drive(double distance)
        {
            if (this.FuelQuantity < this.FuelConsumption * distance)
            {
                Console.WriteLine((String.Format(Messages.NotEnoughFuelMsg, this.GetType().Name)));
            }
            else
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
        }

        public virtual void Refuel(double amount)
        {
            if (amount > 0)
            {


                if (this.FuelQuantity + amount > this.TankCapacity)
                {
                    Console.WriteLine(String.Format(Messages.OvercappedFuel, amount));

                }
                else
                {
                    this.FuelQuantity += amount;
                }
            }
            else
            {
                Console.WriteLine(Messages.NegativeOrZeroFuel);
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
