using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model,double fuelA,double fuelCons)
        {
            Model = model;
            FuelAmount = fuelA;
            FuelConsumptionPerKilometer = fuelCons;
            TravelledDistance = 0;

        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool canMove(double fuelAmount, double fuelConsumptionPerKm,double amountOfKm)
        {
            double needFuel = fuelConsumptionPerKm * amountOfKm;
            if(fuelAmount >= needFuel)
            {
                TravelledDistance += amountOfKm;
                FuelAmount -= needFuel;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
        }
    }
}
