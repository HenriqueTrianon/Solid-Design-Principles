using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.WrongWay
{
    public class Notification
    {
        private Email _email;
        private WhatsappMessage _whatsappMessage;

        public Notification()
        {
            _email = new Email();
            _whatsappMessage = new WhatsappMessage();
        }

        public void Send()
        {
            _email.SendEmail();
            _whatsappMessage.SendMessage();
        }
    }
}
