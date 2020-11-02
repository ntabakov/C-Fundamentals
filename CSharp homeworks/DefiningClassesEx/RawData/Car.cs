using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model,Engine engine,Cargo cargo,List<Tire> tires)
        {
            CarModel = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string CarModel { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }
    }
}
