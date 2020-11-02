using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double fuelCons = double.Parse(input[2]);
                Car car = new Car(model,fuel,fuelCons);
                allCars.Add(car);

            }

            string command = Console.ReadLine();

            while (command!="End")
            {
                var driveCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string givenCarModel = driveCommand[1];
                double givenAmountOfKM = double.Parse(driveCommand[2]);

                foreach (var car in allCars)
                {
                    if(car.Model == givenCarModel)
                    {
                        car.canMove(car.FuelAmount, car.FuelConsumptionPerKilometer, givenAmountOfKM);
                    
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
