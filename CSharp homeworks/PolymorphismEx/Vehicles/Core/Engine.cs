using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {


        public void Run()
        {
            string[] carArgs = Console.ReadLine().Split();
            double carFuel = double.Parse(carArgs[1]);
            double carFuelCons = double.Parse(carArgs[2]);
            double carTankCapacity = double.Parse(carArgs[3]);



            string[] truckArgs = Console.ReadLine().Split();
            double truckFuel = double.Parse(truckArgs[1]);
            double truckFuelCons = double.Parse(truckArgs[2]);
            double truckTankCapacity = double.Parse(truckArgs[3]);

            string[] busArgs = Console.ReadLine().Split();
            double busFuel = double.Parse(busArgs[1]);
            double busFuelCons = double.Parse(busArgs[2]);
            double busTankCapacity = double.Parse(busArgs[3]);



            int n = int.Parse(Console.ReadLine());
            try
            {
                Vehicle car = new Car(carFuel, carFuelCons,carTankCapacity);

                Vehicle truck = new Truck(truckFuel, truckFuelCons,truckTankCapacity);

                Vehicle bus = new Bus(busFuel, busFuelCons, busTankCapacity);

                for (int i = 0; i < n; i++)
                {
                    string[] commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string command = commandArgs[0];
                    string vehicleType = commandArgs[1];

                    if (command == "Drive")
                    {
                        double distance = double.Parse(commandArgs[2]);
                        if (vehicleType == "Car")
                        {
                            car.Drive(distance);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Drive(distance);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.Drive(distance);
                        }
                        else
                        {
                            throw new InvalidOperationException(Messages.InvalidVehicleType);
                        }
                    }
                    else if (command == "Refuel")
                    {
                        double amount = double.Parse(commandArgs[2]);
                        if (vehicleType == "Car")
                        {
                            car.Refuel(amount);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(amount);
                        }
                        else
                        {
                            throw new InvalidOperationException(Messages.InvalidVehicleType);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        double distance = double.Parse(commandArgs[2]);

                        (bus as Bus).DriveEmpty(distance);
                    }
                    else
                    {
                        throw new InvalidOperationException(Messages.InvalidCommand);
                    }

                }

                Console.WriteLine(car);
                Console.WriteLine(truck);
                Console.WriteLine(bus);
            }
            catch (InvalidOperationException a)
            {
                Console.WriteLine(a.Message);
            }



        }
    }
}
