using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.FactoryPattern.CarMaker.Product {
    public class GasolineEngine:Engine {
        public override void Launch() {
            Console.WriteLine("Gasoline Engine");
        }
    }
}
