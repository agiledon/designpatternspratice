using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.StrategyPattern.TaxManager {
    class Program {
        static void Main(string[] args) {
            TaxManager manager = new TaxManager(new PersonalTaxStrategy());
            Console.WriteLine("The Personal Tax is: {0}", manager.GetTax(1000));

            manager = new TaxManager(new EnterpriseTaxStrategy());
            Console.WriteLine("The Enterprise Tax is: {0}", manager.GetTax(1000));

            Console.Read();
        }
    }
}
