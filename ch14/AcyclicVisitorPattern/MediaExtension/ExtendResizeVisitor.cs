using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AcynlicVisitorPattern.MediaExtension {
    public class ExtendResizeVisitor:ResizeVisitor,IAviVisitor {
        #region IAviVisitor Members

        public void Visit(Avi avi) {
            Console.WriteLine("Resize Avi.");
        }

        #endregion
    }
}
