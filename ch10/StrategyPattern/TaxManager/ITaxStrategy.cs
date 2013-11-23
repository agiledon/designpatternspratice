using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.StrategyPattern.TaxManager {
    public interface ITaxStrategy {
        double Calculate(double income);
    }
}
