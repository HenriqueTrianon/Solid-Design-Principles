using System;

namespace ISP.WrongWay
{
    public class Car:IVehicle
    {
        
        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
