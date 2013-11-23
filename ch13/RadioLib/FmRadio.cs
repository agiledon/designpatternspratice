using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.AdapterPattern.RadioLib {
    public class FmRadio : Radio {
        public override void Receive() {
            MessageBox.Show("Receive FmRadio.");
        }

        public override void Stop() {
            MessageBox.Show("Stop FmRadio.");
        }

        public override void TurnOn() {
            MessageBox.Show("Turn on FmRadio.");
        }

        public override void TurnOff() {
            MessageBox.Show("Turn off FmRadio.");
        }

        public override void Modulate(Direction direction) {
            MessageBox.Show("FmRadio:Modulelate " + direction.ToString());
        }
    }
}
