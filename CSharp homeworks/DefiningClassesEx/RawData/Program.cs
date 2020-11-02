using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                List<Tire> tires = new List<Tire>();
                for (int k = 5; k < input.Length; k+=2)
                {
                    double pressure = double.Parse(input[k]);
                    Tire currTire = new Tire(pressure);
                    tires.Add(currTire);
                }
                Car currCar = new Car(model,engine,cargo,tires);
                allCars.Add(currCar);
            }

            string command = Console.ReadLine();
            if(command == "fragile")
            {
                var neededCars = allCars.Where(x => x.Cargo.CargoType == "fragile" &&
                x.Tires.Any(c => c.TirePressure < 1)).ToList();
                foreach (var car in neededCars)
                {
                    Console.WriteLine(car.CarModel);
                }
            }
            else if (command == "flamable")
            {
                var neededCars = allCars.Where(x => x.Cargo.CargoType == "flamable" &&
                x.Engine.EnginePower > 250).ToList();
                foreach (var car in neededCars)
                {
                    Console.WriteLine(car.CarModel);
                }
            }
        }
    }
}
