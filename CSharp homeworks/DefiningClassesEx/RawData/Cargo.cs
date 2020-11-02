using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public Cargo(string cargoType, int cargoWeight)
        {
            CargoType = cargoType;
            CargoWeight = cargoWeight;
        }

        public string CargoType { get; set; }
        public int CargoWeight { get; set; }
    }
}
