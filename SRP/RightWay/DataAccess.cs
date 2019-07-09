using System;
using SRP.Interfaces;

namespace SRP.RightWay
{
    public class DataAccess : IDataAccess
    {
        public void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");
        }
       
    }
}
