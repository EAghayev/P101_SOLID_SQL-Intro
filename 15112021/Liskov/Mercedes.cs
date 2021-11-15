using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Mercedes : Car,IAirconditioner
    {
        public override string Start()
        {
            return "Mercedes started";
        }

        public string StartAirConditioner()
        {
            return "Mercedes Airconditioner started";
        }
    }
}
