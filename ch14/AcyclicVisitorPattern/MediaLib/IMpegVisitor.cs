using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AcynlicVisitorPattern.MediaLib {
    public interface IMpegVisitor:IVideoMediaVisitor {
        void Visit(Mpeg mpeg);
    }
}
