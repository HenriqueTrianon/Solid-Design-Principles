using System.Collections.Generic;
using DIP.RightWay;
using Xunit;

namespace SolidTests
{
    public class DIPTest
    {
        [Fact]
        public void DIPRightWayTest()
        {
            new Notification(new IMessage[] { new WhatsappMessage(), new Email() }).Send();
        }

        [Fact]
        public void DIPWrongWayTest()
        {
            new DIP.WrongWay.Notification().Send();
        }
    }
}
