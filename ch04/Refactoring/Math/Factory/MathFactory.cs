using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.Refactoring.Math
{
    public abstract class MathFactory
    {
        public abstract MathContainer CreateInstance();
        public abstract MathContainer CreateInstance(int capacity);
    } 
}
