using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private double fuelConsumption;
        private double fuelConsumptionWithPeople;


        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.fuelConsumptionWithPeople = this.FuelConsumption + 1.4;
            this.fuelConsumption = this.FuelConsumption;
        }

        

        public override void Drive(double distance)
        {
            this.FuelConsumption = fuelConsumptionWithPeople;
            base.Drive(distance);
        }

        public void DriveEmpty(double distance)
        {
            this.FuelConsumption = fuelConsumption;
            base.Drive(distance);
        }
    }
}
