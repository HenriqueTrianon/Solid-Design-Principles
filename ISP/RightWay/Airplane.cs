using System;

namespace ISP.RightWay
{
    public class Airplane:IFlightableVehicle
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
