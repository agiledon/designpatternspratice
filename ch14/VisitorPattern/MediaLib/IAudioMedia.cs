using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.MediaLib {
    public interface IAudioMedia : IMedia {
        void Tune();
        void Mute();
    }
}
