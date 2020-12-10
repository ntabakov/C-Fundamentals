using System;
using System.Collections.Generic;
using System.Text;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private string model;
        private int horsePower;

        private int minHP;
        private int maxHP;

        protected Car(string model,int horsePower, double cubicCentimeters, int minHorsePower,int maxHorsePower)
        {
            this.Model = model;
            this.CubicCentimeters = cubicCentimeters;
            this.minHP = minHorsePower;
            this.maxHP = maxHorsePower;
            this.HorsePower = horsePower;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel,value,4));
                }

                this.model = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            private set
            {
                if (value < this.minHP || value > this.maxHP)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidHorsePower,value));
                }

                this.horsePower = value;
            }
        }
        public double CubicCentimeters { get; }
        public double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps;
        }
    }
}
