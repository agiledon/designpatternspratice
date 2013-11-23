using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AdapterPattern.MediaLib {
    public interface IAudioMedia : IMedia {
        void Tune(int volume);
        void Mute();
    }
}
