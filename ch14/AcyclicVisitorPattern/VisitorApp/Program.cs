using System;
using System.Collections.Generic;
using System.Text;
using DonOfDesign.AcynlicVisitorPattern.MediaLib;
using DonOfDesign.AcynlicVisitorPattern.MediaExtension;

namespace DonOfDesign.AcynlicVisitorPattern.VisitorApp {
    class Program {
        static void Main(string[] args) {
            IVideoMediaVisitor visitor = new ResizeVisitor();
            IMedia rm = new Rm();
            rm.Play();
            ((IVideoMedia)rm).Accept(visitor);

            IMedia mpeg = new Mpeg();
            mpeg.Play();
            ((IVideoMedia)mpeg).Accept(visitor);

            IVideoMediaVisitor extendVisitor = new ExtendResizeVisitor();
            IMedia avi = new Avi();
            avi.Play();
            ((IVideoMedia)avi).Accept(extendVisitor);

            Console.Read();
        }
    }
}
