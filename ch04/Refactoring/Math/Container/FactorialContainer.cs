using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.Refactoring.Math
{
    public class FactorialContainer : MathContainer
    {
        public FactorialContainer() : base() { }
        public FactorialContainer(int capacity) : base(capacity) { }
        protected override long Count()
        {
            long result = 1;
            int seed = m_mathList.Count + 1;
            for (int i = 1; i <= seed; i++) {
                result *= i;
            }
            return result;
        }
    }

}
