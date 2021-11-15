using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class SMS:IMessage
    {
        public void Send()
        {
            Console.WriteLine("SMS userinden mesaj gonderildi");
        }
    }
}
