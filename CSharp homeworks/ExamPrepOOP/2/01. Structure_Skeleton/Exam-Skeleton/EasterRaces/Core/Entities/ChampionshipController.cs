using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Core.Contracts;
using EasterRaces.Factory;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Entities;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private CarRepository carRepository = new CarRepository();
        private DriverRepository driverRepository = new DriverRepository();
        private RaceRepository raceRepository = new RaceRepository();

        private CarFactory carFactory = new CarFactory();

        public string CreateDriver(string driverName)
        {
            IDriver driver = new Driver(driverName);
            if (driverRepository.GetByName(driverName) != null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.DriversExists,driverName));
            }
            driverRepository.Add(driver);

            return String.Format(OutputMessages.DriverCreated, driverName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = carFactory.CreateCar(type, horsePower,model);
            if (carRepository.GetByName(model) != null)
            {
                //TODO: If wrong test, edit the EXCPETION MESSAGES CLASS!!!!
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists,car.Model));
            }
            carRepository.Add(car);
            return String.Format(OutputMessages.CarCreated, $"{type}Car", model);
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = new Race(name,laps);
            if (raceRepository.GetByName(name) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceExists,name));
            }
            raceRepository.Add(race);
            return String.Format(OutputMessages.RaceCreated, name);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceNotFound,raceName));
            }

            if (driverRepository.GetByName(driverName) == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.DriverNotFound,driverName));
            }

            IDriver driver = driverRepository.GetByName(driverName);
            raceRepository.GetByName(raceName).AddDriver(driver);

            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            if (driverRepository.GetByName(driverName) == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.DriverNotFound,driverName));
            }

            if (carRepository.GetByName(carModel) == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.CarNotFound,carModel));
            }
            ICar car = carRepository.GetByName(carModel);
            driverRepository.GetByName(driverName).AddCar(car);

            return String.Format(OutputMessages.CarAdded, driverName, carModel);


        }

        public string StartRace(string raceName)
        {
            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceNotFound,raceName));
            }

            if (driverRepository.GetAll().Count < 3)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceInvalid,raceName,3));
            }

            IRace race = raceRepository.GetByName(raceName);
            List<IDriver> fastest = race.Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Driver {fastest[0].Name} wins {race.Name} race.");
            sb.AppendLine($"Driver {fastest[1].Name} is second in {race.Name} race.");
            sb.AppendLine($"Driver {fastest[2].Name} is third in {race.Name} race.");

            raceRepository.Remove(race);

            return sb.ToString().TrimEnd();

        }
    }
}
