using System;
using System.Collections.Generic;
using System.Text;
using DonOfDesign.VisitorPattern.MediaLib;
using DonOfDesign.VisitorPattern.MediaExtension;

namespace DonOfDesign.VisitorPattern.VisitorApp {
    class Program {
        static void Main(string[] args) {
            IVideoMediaVisitor visitor = new ResizeVisitor();
            IMedia rm = new Rm();
            rm.Play();
            ((IVideoMedia)rm).Accept(visitor);

            IMedia mpeg = new Mpeg();
            mpeg.Play();
            ((IVideoMedia)mpeg).Accept(visitor);

            Console.Read();
        }
    }
}
