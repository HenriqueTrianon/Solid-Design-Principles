using System;
using SingleResponsabilityPrinciple.Interfaces;

namespace SingleResponsabilityPrinciple.WrongWay
{
    public class DataAccess:IDataAccess
    {
        public void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
        }
    }
}
