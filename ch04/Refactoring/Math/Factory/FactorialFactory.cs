using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.Refactoring.Math
{
    public class FactorialFactory : MathFactory
    {
        public override MathContainer CreateInstance()
        {
            return new FactorialContainer();
        }
        public override MathContainer CreateInstance(int capacity)
        {
            return new FactorialContainer(capacity);
        }
    } 

}
