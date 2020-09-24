using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> carInfo = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                var carInput = Console.ReadLine().Split('|');
                carInfo.Add(carInput[0], new List<int> { int.Parse(carInput[1]), int.Parse(carInput[2]) });

            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                var cList = command.Split(" : ");
                string currCar = cList[1];
                if (command.Contains("Drive"))
                {
                    int givenFuel = int.Parse(cList[3]);
                    if (carInfo[currCar][1] < givenFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        int givenDistance = int.Parse(cList[2]);
                        carInfo[currCar][0] += givenDistance;
                        carInfo[currCar][1] -= givenFuel;
                        Console.WriteLine($"{currCar} driven for {givenDistance} kilometers. {givenFuel} liters of fuel consumed.");
                        if (carInfo[currCar][0] >= 100000)
                        {
                            carInfo.Remove(currCar);
                            Console.WriteLine($"Time to sell the {currCar}!");
                        }
                    }
                }
                else if (command.Contains("Refuel"))
                {
                    int refillFuel = int.Parse(cList[2]);
                    if (carInfo[currCar][1] + refillFuel > 75)
                    {
                        Console.WriteLine($"{currCar} refueled with {75 - carInfo[currCar][1]} liters");
                        carInfo[currCar][1] = 75;
                    }
                    else
                    {
                        carInfo[currCar][1] += refillFuel;
                        Console.WriteLine($"{currCar} refueled with {refillFuel} liters");
                    }
                }
                else
                {
                    int decreasingKms = int.Parse(cList[2]);
                    if (carInfo[currCar][0] - decreasingKms < 10000)
                    {
                        carInfo[currCar][0] = 10000;



                    }
                    else
                    {
                        carInfo[currCar][0] -= decreasingKms;
                        Console.WriteLine($"{currCar} mileage decreased by {decreasingKms} kilometers");
                    }

                }


                command = Console.ReadLine();
            }
            var sortedCars = carInfo.OrderByDescending(c => c.Value[0]).ThenBy(x => x.Key);
            foreach (var item in sortedCars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }


        }
    }
}
