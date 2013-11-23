using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.FactoryPattern.CarMaker.Product {
    public class SolarEngine:Engine {
        public override void Launch() {
            Console.WriteLine("Solar Engine");
        }
    }
}
