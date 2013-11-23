using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.MediaLib {
    public interface IVideoMediaVisitor {
        void Visit(Rm rm);
        void Visit(Mpeg mpeg);
    }
}
