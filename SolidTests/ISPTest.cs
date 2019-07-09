using System;
using ISP.RightWay;
using Xunit;
using Xunit.Sdk;

namespace SolidTests
{
    public class ISPTest
    {
        [Fact]
        public void ISPWrongWayTest()
        {
            ISP.WrongWay.IVehicle vehicle = new ISP.WrongWay.Airplane();
            Assert.Throws<NotImplementedException>(() => vehicle.Drive());
            vehicle = new ISP.WrongWay.Car();
            Assert.Throws<NotImplementedException>(() => vehicle.Fly());
            vehicle = new ISP.WrongWay.FlyingCar();
            vehicle.Drive();
            vehicle.Fly();

        }
        [Fact]
        public void ISPRightWayTest()
        {
            ITerrainableVehicle terrainableVehicle = new Car();
            terrainableVehicle.Drive();
            IFlightableVehicle flightableVehicle = new Airplane();
            flightableVehicle.Fly();
            IVersatileVehicle versatileVehicle = new FlyingCar();
            versatileVehicle.Drive();
            versatileVehicle.Fly();
        }
    }
}
