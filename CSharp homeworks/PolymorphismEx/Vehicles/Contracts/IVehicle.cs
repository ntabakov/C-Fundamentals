using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        public void Drive(double distance);
        public void Refuel(double amount);
    }
}
