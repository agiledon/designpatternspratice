using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AcynlicVisitorPattern.MediaLib {
    public interface IMedia {
        void Play();
        void Pause();
        void Stop();
        void Forward();
        void Backward();
    }
}
