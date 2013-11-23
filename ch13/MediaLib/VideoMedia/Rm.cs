using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.AdapterPattern.MediaLib {
    public class Rm : IVideoMedia {
        #region IMedia Members

        public void Play() {
            MessageBox.Show("Play Rm.");
        }

        public void Pause() {
            MessageBox.Show("Pause Rm.");
        }

        public void Stop() {
            MessageBox.Show("Stop Rm.");
        }

        public void Forward() {
            MessageBox.Show("Forward Rm.");
        }

        public void Backward() {
            MessageBox.Show("Backward Rm.");
        }

        public void Open() {
            MessageBox.Show("Open Rm.");
        }

        public void Close() {
            MessageBox.Show("Close Rm.");
        }

        #endregion

        #region IAudioMedia Members

        public void Tune(int volume) {
            MessageBox.Show("Tune Rm.");
        }

        public void Mute() {
            MessageBox.Show("Mute Rm.");
        }

        #endregion

        #region IVideoMedia Members

        public void ShowScript() {
            MessageBox.Show("Showscript Rm.");
        }

        #endregion
    }
}
