using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double FuelCapacity { get; set; }
        public EngineType EngineType { get; set; }

        public void AddFuel(double fuel)
        {
            //procec
        }

        public void Drive(int km)
        {
            //procec
        }
    }
}
