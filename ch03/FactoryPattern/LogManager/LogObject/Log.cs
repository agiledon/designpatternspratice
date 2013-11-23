using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.FactoryPattern.LogManager
{
    public abstract class Log
    {
        public abstract void Write(string logContent);
    }
}
