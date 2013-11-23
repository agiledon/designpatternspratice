using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DonOfDesign.FactoryPattern.CarMaker.Factory;
using DonOfDesign.FactoryPattern.CarMaker.Product;

namespace DonOfDesign.FactoryPattern.CarMaker {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("******Drive the car with gasoline engine.******");
            EngineFactory factory = new GasolineEngineFactory();
            Car car = new Car();
            car.Engine = factory.MakeEngine();
            car.Drive();

            Console.WriteLine("Change the type of factory");
            Console.WriteLine("******Drive the car with solar engine.******");
            factory = new SolarEngineFactory();
            car.Engine = factory.MakeEngine();
            car.Drive();

            Console.Read();
        }
    }
}
