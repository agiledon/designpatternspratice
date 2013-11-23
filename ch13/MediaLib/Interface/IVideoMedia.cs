using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AdapterPattern.MediaLib {
    public interface IVideoMedia : IAudioMedia {
        void ShowScript();
    }
}
