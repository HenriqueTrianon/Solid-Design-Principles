using System;

namespace ISP.RightWay
{
    public class Car : ITerrainableVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }
}
