using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.StrategyPattern.TaxManager {
    public class TaxManager {
        private ITaxStrategy m_strategy;
        public TaxManager(ITaxStrategy strategy) {
            m_strategy = strategy;
        }
        public double GetTax(double income) {
            return m_strategy.Calculate(income);
        }
    }

}
