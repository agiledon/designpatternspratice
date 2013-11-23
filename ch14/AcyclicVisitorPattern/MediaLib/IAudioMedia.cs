using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AcynlicVisitorPattern.MediaLib {
    public interface IAudioMedia : IMedia {
        void Tune();
        void Mute();
    }
}
