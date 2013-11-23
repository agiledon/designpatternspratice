using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.FactoryPattern.LogManager
{
    public class DBLog:Log
    {
        public override void Write(string logContent)
        {
            Console.WriteLine("Logging {0} to DB.", logContent);
        }
    }
}
