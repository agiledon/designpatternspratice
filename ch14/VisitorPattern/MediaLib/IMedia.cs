using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.MediaLib {
    public interface IMedia {
        void Play();
        void Pause();
        void Stop();
        void Forward();
        void Backward();
    }
}
