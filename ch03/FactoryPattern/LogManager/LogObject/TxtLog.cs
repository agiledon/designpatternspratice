using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.FactoryPattern.LogManager
{
    public class TxtLog:Log
    {
        public override void Write(string logContent)
        {
            Console.WriteLine("Logging {0} to text file.", logContent);
        }
    }
}
