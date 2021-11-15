using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class BMW : Car,IAirconditioner
    {
        public override string Start()
        {
            return "BMW started";
        }


        public string StartAirConditioner()
        {
            return "BMW Airconditioner started";
        }
    }
}
