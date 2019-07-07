using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsabilityPrinciple.Interfaces;

namespace SingleResponsabilityPrinciple.RightWay
{
    public class Logger:ILogger
    {
        public void WriteLog(string information)
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + information);
        }
    }
}
