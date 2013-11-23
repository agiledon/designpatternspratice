using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.AdapterPattern.MediaLib;
using DonOfDesign.AdapterPattern.RadioLib;

namespace DonOfDesign.ObjectAdapter.MediaAdapter {
    public class RadioAdapter : IMedia {
        private Radio m_radio;
        public RadioAdapter(Radio radio) {
            m_radio = radio;
        }

        #region IMedia Members

        public void Play() {
            m_radio.Receive();
        }

        //Radio类型没有该行为，另其为空，或引入异常机制；
        public void Pause() { }

        public void Stop() {
            m_radio.Stop();
        }

        public void Forward() {
            m_radio.Modulate(Direction.Up);
        }

        public void Backward() {
            m_radio.Modulate(Direction.Down);
        }

        public void Close() {
            m_radio.TurnOff();
        }

        public void Open() {
            m_radio.TurnOn();
        }

        #endregion
    }

}
