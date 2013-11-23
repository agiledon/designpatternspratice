using System;
using System.Collections.Generic;
using System.Text;
using DonOfDesign.VisitorPattern.MediaLib;

namespace DonOfDesign.VisitorPattern.MediaExtension {
    public class ResizeVisitor : IVideoMediaVisitor {

        #region IVideoMediaVisitor Members

        public void Visit(Rm rm) {
            Console.WriteLine("Resize Rm.");
        }

        public void Visit(Mpeg mpeg) {
            Console.WriteLine("Resize Mpeg.");
        }

        #endregion
    }
}
