using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue.NewTry
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> vehicle = new List<Vehicle>();
            while (command != "End")
            {
                string[] commandElements = command.Split();
                Vehicle inputVehicles = new Vehicle(commandElements[0], commandElements[1], commandElements[2], double.Parse(commandElements[3]));
                vehicle.Add(inputVehicles);
                command = Console.ReadLine();
            }

            string model = Console.ReadLine();
            while (model != "Close the Catalogue")
            {
                Console.WriteLine(vehicle.FirstOrDefault(x => x.Model == model).ToString()); 



                model = Console.ReadLine();
            }
            var cars = vehicle.FindAll(x => x.Type == "car");
            var carHP = cars.Sum(c => c.Horsepower);
            var carAverageHP = carHP / cars.Count;

            var trucks = vehicle.FindAll(x => x.Type == "truck");
            var trucksHP = trucks.Sum(c => c.Horsepower);
            var truckAverageHP = trucksHP / trucks.Count;
            if(cars.Count == 0)
            {
                carAverageHP = 0;
            }
            if (trucks.Count== 0)
            {
                truckAverageHP = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {carAverageHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHP:f2}.");

        }




        class Vehicle
        {
            public Vehicle(string type, string model, string color, double horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();
                if (this.Type == "car")
                {
                    stringBuilder.AppendLine($"Type: Car");

                }
                else
                {
                    stringBuilder.AppendLine($"Type: Truck");

                }
                stringBuilder.AppendLine($"Model: {Model}");
                stringBuilder.AppendLine($"Color: {Color}");
                stringBuilder.AppendLine($"Horsepower: {Horsepower}");




                return stringBuilder.ToString().TrimEnd() ;
            }
        }
    }
}
