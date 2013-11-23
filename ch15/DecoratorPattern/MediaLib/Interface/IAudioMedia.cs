using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.DecoratorPattern.MediaLib {
    public interface IAudioMedia : IMedia {
        void Tune(int volume);
        void Mute();
    }
}
