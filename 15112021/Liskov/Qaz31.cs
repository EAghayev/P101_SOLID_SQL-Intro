using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Qaz31 : Car
    {
        public override string Start()
        {
            return "Qaz31 started";
        }

        //public override string StartAirconditioner()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
