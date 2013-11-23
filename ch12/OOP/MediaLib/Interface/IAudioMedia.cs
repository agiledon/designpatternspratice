using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.OOP.MediaLib {
    public interface IAudioMedia : IMedia {
        void Tune(int volume);
        void Mute();
    }
}
