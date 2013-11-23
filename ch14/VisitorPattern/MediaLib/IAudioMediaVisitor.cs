using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.MediaLib
{
    public interface IAudioMediaVisitor:IVideoMediaVisitor
    {
        void Visit(IAudioMedia media);
    }
}
