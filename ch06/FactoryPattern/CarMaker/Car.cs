using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DonOfDesign.FactoryPattern.CarMaker.Product;

namespace DonOfDesign.FactoryPattern.CarMaker {
    public class Car {
        public Engine Engine {
            get;
            set;
        }

        public void Drive() {
            Console.WriteLine("The car is driving...");
            Engine.Launch();
        }
    }
}
