using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.FactoryPattern.LogManager
{
    public class XmlLogFactory:LogFactory
    {
        public override Log Create()
        {
            return new XmlLog();
        }
    }
}
