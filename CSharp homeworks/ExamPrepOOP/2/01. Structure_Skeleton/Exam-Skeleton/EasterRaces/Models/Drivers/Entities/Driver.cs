using System;
using System.Collections.Generic;
using System.Text;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private string name;

        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                //TODO: If wrong test, add IsNullOrWhiteSpace!
                if (string.IsNullOrEmpty(value) || value.Length < 5 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidName,value,5));
                }

                this.name = value;
            }
        }
        public ICar Car { get; private set; }
        public int NumberOfWins { get; private set; }

        public bool CanParticipate
        {
            get
            {
                //TODO: If wrong test, change this:
                return Car != null;
            }
        }
        public void WinRace()
        {
            this.NumberOfWins++;
        }

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(ICar),ExceptionMessages.CarInvalid);
            }

            this.Car = car;
        }
    }
}
