using System;
using SRP.Interfaces;

namespace SRP.RightWay
{
    public class Logger:ILogger
    {
        public void WriteLog(string information)
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + information);
        }
    }
}
