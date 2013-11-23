using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AcynlicVisitorPattern.MediaLib {
    public interface IVideoMedia : IAudioMedia {
        void ShowScript();
        void Accept(IVideoMediaVisitor visitor);
    }
}
