using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.FactoryPattern.LogManager
{
    public class DBLogFactory:LogFactory
    {
        public override Log Create()
        {
            return new DBLog();
        }
    }
}
