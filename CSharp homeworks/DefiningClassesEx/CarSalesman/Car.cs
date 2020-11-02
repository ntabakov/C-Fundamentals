using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car()
        {
            
        }
        public string Model { get; set; }
        public string CarEngine { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }

        public string Color { get; set; }
    }
}
