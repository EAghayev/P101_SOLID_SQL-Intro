using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class Whatsapp : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp uzerinden mesaj gonderildir!");
        }
    }
}
