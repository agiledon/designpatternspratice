using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DonOfDesign.FactoryPattern.CarMaker.Product;

namespace DonOfDesign.FactoryPattern.CarMaker.Factory {
    public class GasolineEngineFactory:EngineFactory {
        public override Engine MakeEngine() {
            return new GasolineEngine();
        }
    }
}
