using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.Refactoring.Math
{
    public class FibonacciFactory : MathFactory
    {
        public override MathContainer CreateInstance()
        {
            return new FibonacciContainer();
        }
        public override MathContainer CreateInstance(int capacity)
        {
            return new FibonacciContainer(capacity);
        }
    } 

}
