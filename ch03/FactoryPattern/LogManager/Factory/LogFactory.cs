using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.FactoryPattern.LogManager
{
    public abstract class LogFactory
    {
        public abstract Log Create();
    }
}
