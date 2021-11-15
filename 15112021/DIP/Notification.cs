using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class Notification
    {

        private List<IMessage> _messages;
        public Notification(List<IMessage> messages)
        {
            _messages = messages;
        }
        public void Send()
        {
            foreach (var item in _messages)
            {
                item.Send();
            }
        }
    }
}
