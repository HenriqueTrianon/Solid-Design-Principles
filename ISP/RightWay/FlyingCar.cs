using System;

namespace ISP.RightWay
{
    public class FlyingCar:IVersatileVehicle
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }

        public void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }
}
