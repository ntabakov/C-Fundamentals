using System;
using System.Collections.Generic;
using System.Text;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;

namespace EasterRaces.Factory
{
    public class CarFactory
    {
        public ICar CreateCar(string type,int hp,string model)
        {
            ICar car = null;
            if (type == "Muscle")
            {
                car = new MuscleCar(model,hp);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model,hp);
            }

            return car;
        }
    }
}
