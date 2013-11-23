using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.AcynlicVisitorPattern.MediaLib;

namespace DonOfDesign.AcynlicVisitorPattern.MediaExtension {
    public interface IAviVisitor:IVideoMediaVisitor {
        void Visit(Avi avi);
    }
}
