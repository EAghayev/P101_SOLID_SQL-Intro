using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    class Bycle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Drive(int km)
        {
            //procec
        }
    }
}
