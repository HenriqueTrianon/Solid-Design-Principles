using SRP.RightWay;
using Xunit;

namespace SolidTests
{
    public class SRPTest
    {
        [Fact]
        public void SRPRightWayExample()
        {
            new DataAccess().InsertData();
            new Logger().WriteLog("");
        }

        [Fact]
        public void SRPWrongWayExample()
        {
            new SRP.WrongWay.DataAccess().InsertData();
        }
    }
}
