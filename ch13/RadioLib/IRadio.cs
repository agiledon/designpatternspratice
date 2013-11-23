using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AdapterPattern.RadioLib {
    public enum Direction { Up, Down }

    public interface IRadio {
        void Receive();
        void Stop();
        void TurnOn();
        void TurnOff();
        void Modulate(Direction direction);
    }
}
