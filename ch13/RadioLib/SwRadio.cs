using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.AdapterPattern.RadioLib {
    public class SwRadio : Radio {
        public override void Receive() {
            MessageBox.Show("Receive SwRadio.");
        }

        public override void Stop() {
            MessageBox.Show("Stop SwRadio.");
        }

        public override void TurnOn() {
            MessageBox.Show("Turn on SwRadio.");
        }

        public override void TurnOff() {
            MessageBox.Show("Turn off SwRadio.");
        }

        public override void Modulate(Direction direction) {
            MessageBox.Show("SwRadio:Modulelate " + direction.ToString());
        }
    }
}
