using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.AdapterPattern.RadioLib {
    public abstract class Radio : IRadio {

        #region IRadio Members

        public virtual void Receive() {
            MessageBox.Show("Receive radio.");
        }

        public virtual void Stop() {
            MessageBox.Show("Stop radio.");
        }

        public virtual void TurnOn() {
            MessageBox.Show("Turn on radio.");
        }

        public virtual void TurnOff() {
            MessageBox.Show("Turn off radio.");
        }

        public virtual void Modulate(Direction direction) {
            MessageBox.Show("Modulelate " + direction.ToString());
        }

        #endregion
    }
}
