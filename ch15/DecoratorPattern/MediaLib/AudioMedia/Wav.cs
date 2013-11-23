using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.DecoratorPattern.MediaLib {
    public class Wav : IAudioMedia {
        #region IMedia Members

        public void Play() {
            MessageBox.Show("Play Wav.");
        }

        public void Pause() {
            MessageBox.Show("Pause Wav.");
        }

        public void Stop() {
            MessageBox.Show("Stop Wav.");
        }

        public void Forward() {
            MessageBox.Show("Forward Wav.");
        }

        public void Backward() {
            MessageBox.Show("Backward Wav.");
        }

        #endregion

        #region IAudioMedia Members

        public void Tune(int volume) {
            MessageBox.Show("Tune Wav.");
        }

        public void Mute() {
            MessageBox.Show("Mute Wav.");
        }

        #endregion
    }
}
