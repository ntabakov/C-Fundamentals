using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private string name;
        private int laps;
        private List<IDriver> drivers;

        private Race()
        {
            drivers = new List<IDriver>();
        }

        public Race(string name, int laps)
            :this()
        {
            this.name = name;
            this.laps = laps;
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
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidName, value, 5));
                }

                this.name = value;
            }
        }

        public int Laps
        {
            get
            {
                return this.laps;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidNumberOfLaps,1));
                }

                this.laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers
        {
            get
            {
                return this.drivers;
            }
            
        }
        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(IDriver),ExceptionMessages.DriverInvalid);
            }

            if (driver.CanParticipate == false)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.DriverNotParticipate,driver.Name));
            }

            if (Drivers.Contains(driver))
            {
                throw new ArgumentNullException(nameof(IDriver),String.Format(ExceptionMessages.DriverAlreadyAdded,driver.Name,this.Name));
            }
            this.drivers.Add(driver);
        }
    }
}
