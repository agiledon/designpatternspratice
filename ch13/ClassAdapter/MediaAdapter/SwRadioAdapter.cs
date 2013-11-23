using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.AdapterPattern.RadioLib;
using DonOfDesign.AdapterPattern.MediaLib;

namespace DonOfDesign.ClassAdapter.MediaAdapter {
    public class SwRadioAdapter : SwRadio, IMedia {
        #region IMedia Members

        public void Play() {
            this.Receive();
        }

        //Radio类型没有该行为，令其为空，或引入异常机制；
        public void Pause() { }

        public void Forward() {
            this.Modulate(Direction.Up);
        }

        public void Backward() {
            this.Modulate(Direction.Down);
        }

        public void Close() {
            this.TurnOff();
        }

        public void Open() {
            this.TurnOn();
        }

        #endregion
    }

}
