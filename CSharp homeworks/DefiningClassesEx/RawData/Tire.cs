using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double tirePressure)
        {
            TirePressure = tirePressure;
        }

        public double TirePressure { get; set; }
    }
}
