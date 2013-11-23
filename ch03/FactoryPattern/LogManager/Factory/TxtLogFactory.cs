using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.FactoryPattern.LogManager
{
    public class TxtLogFactory:LogFactory
    {
        public override Log Create()
        {
            return new TxtLog();
        }
    }
}
