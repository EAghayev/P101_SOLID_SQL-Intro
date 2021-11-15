using System;
using System.Collections.Generic;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SMS sms = new SMS();

            sms.Send();

            Console.WriteLine("=======================");

            List<IMessage> messageSenders = new List<IMessage>();
            messageSenders.Add(sms);
            messageSenders.Add(new Whatsapp());
            messageSenders.Add(new Facebook());

            Notification notification = new Notification(messageSenders);
            notification.Send();
        }
    }
}
