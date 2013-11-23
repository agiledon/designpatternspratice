using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.StrategyPattern.TaxManager {
    public class PersonalTaxStrategy : ITaxStrategy {
        public double Calculate(double income) {
            return income * 0.1;
        }
    }

}
