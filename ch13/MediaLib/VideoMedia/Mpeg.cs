using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.AdapterPattern.MediaLib {
    public class Mpeg : IVideoMedia {
        #region IMedia Members

        public void Play() {
            MessageBox.Show("Play Mpeg.");
        }

        public void Pause() {
            MessageBox.Show("Pause Mpeg.");
        }

        public void Stop() {
            MessageBox.Show("Stop Mpeg.");
        }

        public void Forward() {
            MessageBox.Show("Forward Mpeg.");
        }

        public void Backward() {
            MessageBox.Show("Backward Mpeg.");
        }

        public void Open() {
            MessageBox.Show("Open Mpeg.");
        }

        public void Close() {
            MessageBox.Show("Close Mpeg.");
        }

        #endregion

        #region IAudioMedia Members

        public void Tune(int volume) {
            MessageBox.Show("Tune Mpeg.");
        }

        public void Mute() {
            MessageBox.Show("Mute Mpeg.");
        }

        #endregion

        #region IVideoMedia Members

        public void ShowScript() {
            MessageBox.Show("Showscript Mpeg.");
        }

        #endregion
    }
}
