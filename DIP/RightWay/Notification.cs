using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.RightWay
{
    public class Notification
    {
        private IEnumerable<IMessage> _messages;

        public Notification(IEnumerable<IMessage> messages)
        {
            messages = _messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.Send();
            }
        }
    }
}
