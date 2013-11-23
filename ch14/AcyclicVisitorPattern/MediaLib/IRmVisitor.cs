using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AcynlicVisitorPattern.MediaLib {
    public interface IRmVisitor:IVideoMediaVisitor {
        void Visit(Rm rm);
    }
}
