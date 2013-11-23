using System;
using System.Collections.Generic;
using System.Text;
using DonOfDesign.AcynlicVisitorPattern.MediaLib;

namespace DonOfDesign.AcynlicVisitorPattern.MediaExtension {
    public class ResizeVisitor : IVideoMediaVisitor,IRmVisitor,IMpegVisitor {  
        public void Visit(Rm rm) {
            Console.WriteLine("Resize Rm.");
        }

        public void Visit(Mpeg mpeg) {
            Console.WriteLine("Resize Mpeg.");
        }
    }
}
