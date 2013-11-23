using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DonOfDesign.FactoryPattern.CarMaker.Product;

namespace DonOfDesign.FactoryPattern.CarMaker.Factory {
    public class SolarEngineFactory:EngineFactory {
        public override DonOfDesign.FactoryPattern.CarMaker.Product.Engine MakeEngine() {
            return new SolarEngine();
        }
    }
}
