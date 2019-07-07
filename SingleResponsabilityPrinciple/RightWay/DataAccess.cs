using System;
using SingleResponsabilityPrinciple.Interfaces;

namespace SingleResponsabilityPrinciple.RightWay
{
    public class DataAccess : IDataAccess
    {
        public void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");
        }
       
    }
}
