using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DonOfDesign.FactoryPattern.CarMaker.Product;

namespace DonOfDesign.FactoryPattern.CarMaker.Factory {
    public abstract class EngineFactory {
        public abstract Engine MakeEngine();
    }
}
