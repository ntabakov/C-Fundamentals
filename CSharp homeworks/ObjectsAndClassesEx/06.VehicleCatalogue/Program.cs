using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                if (command[0] == "car")
                {
                    Cars firstCars = new Cars();

                    firstCars.CarModel = command[1];
                    firstCars.CarColor = command[2];
                    firstCars.CarHorsePower = double.Parse(command[3]);
                    cars.Add(firstCars);
                }
                else if (command[0] == "truck")
                {
                    Trucks firstTrucks = new Trucks();

                    firstTrucks.TruckModel = command[1];
                    firstTrucks.TruckColor = command[2];
                    firstTrucks.TruckHorsePower = double.Parse(command[3]);
                    trucks.Add(firstTrucks);
                }
                command = Console.ReadLine().Split();

            }

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                if (cars.Any(x => x.CarModel == model))
                {
                    Console.WriteLine(cars.FirstOrDefault(x => x.CarModel == model).ToString());
                }
                if (trucks.Any(x => x.TruckModel == model))
                {
                    Console.WriteLine(trucks.FirstOrDefault(x => x.TruckModel == model).ToString());
                }

                model = Console.ReadLine();
            }
            double carHP = 0;
            double truckHP = 0;

            if (cars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.");

            }
            else
            {
                carHP = cars.Sum(x => x.CarHorsePower);
                Console.WriteLine($"Cars have average horsepower of: {carHP / cars.Count:f2}.");
            }

            if (trucks.Count == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.");

            }
            else
            {
                truckHP = trucks.Sum(x => x.TruckHorsePower);
                Console.WriteLine($"Trucks have average horsepower of: {truckHP / trucks.Count:f2}.");
            }

        }



        class Cars
        {
            public string CarModel { get; set; }
            public string CarColor { get; set; }
            public double CarHorsePower { get; set; }
            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"Type: Car");
                stringBuilder.AppendLine($"Model: {CarModel}");
                stringBuilder.AppendLine($"Color: {CarColor}");
                stringBuilder.AppendLine($"Horsepower: {CarHorsePower}");


                return stringBuilder.ToString().TrimEnd();
            }

        }

        class Trucks
        {


            public string TruckModel { get; set; }
            public string TruckColor { get; set; }
            public double TruckHorsePower { get; set; }
            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"Type: Truck");
                stringBuilder.AppendLine($"Model: {TruckModel}");
                stringBuilder.AppendLine($"Color: {TruckColor}");
                stringBuilder.AppendLine($"Horsepower: {TruckHorsePower}");


                return stringBuilder.ToString().TrimEnd();
            }
        }

    }
}
