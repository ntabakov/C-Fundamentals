using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Displacement - int
            //Efficiency - string
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                Engine engine = new Engine();
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                engine.EngineModel = input[0];
                engine.Power = int.Parse(input[1]);
                if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        engine.Displacement = int.Parse(input[2]);
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }

                if(input.Length == 4)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        engine.Displacement = int.Parse(input[2]);
                        engine.Efficiency = input[3];
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                        engine.Displacement = int.Parse(input[3]);
                    }
                }
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                Car car = new Car();
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                car.Model = input[0];
                car.CarEngine = input[1];
                if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        car.Weight = int.Parse(input[2]);
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                }
                if (input.Length == 4)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        car.Weight = int.Parse(input[2]);
                        car.Color = input[3];
                    }
                    else
                    {
                        car.Color = input[2];
                        car.Weight = int.Parse(input[3]);

                    }
                }
                var searchEngine = engines.FirstOrDefault(x => x.EngineModel == input[1]);
                car.Engine = searchEngine;
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                PrintCars(car);

            }
        }

        static void PrintCars(Car car)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.EngineModel}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");


            if (car.Engine.Displacement == 0)
            {
                Console.WriteLine($"    Displacement: n/a");

            }
            else
            {
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");

            }

            if(car.Engine.Efficiency == null)
            {
                Console.WriteLine($"    Efficiency: n/a");

            }
            else
            {
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");

            }

            if(car.Weight == 0)
            {
                Console.WriteLine($"  Weight: n/a");
            }
            else
            {
                Console.WriteLine($"  Weight: {car.Weight}");
            }

            if(car.Color == null)
            {

                Console.WriteLine("  Color: n/a");
            }
            else
            {
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
