using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.DecoratorPattern.MediaLib {
    public interface IVideoMedia : IAudioMedia {
        void ShowScript();
    }
}
