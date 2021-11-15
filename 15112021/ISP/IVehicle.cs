using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    enum EngineType
    {
        Beniz,
        Dizel,
        Elektrik
    }
    interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        void Drive(int km);

    }
}
