using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.DecoratorPattern.MediaLib {
    public interface IMedia:IPlay {
        void Pause();
        void Stop();
        void Forward();
        void Backward();
    }

}
