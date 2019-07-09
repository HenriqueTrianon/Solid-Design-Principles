using System;

namespace ISP.WrongWay
{
    public class FlyingCar: IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
