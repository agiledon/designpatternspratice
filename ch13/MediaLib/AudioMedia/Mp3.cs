using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.AdapterPattern.MediaLib {
    public class Mp3 : IAudioMedia {

        #region IMedia Members

        public void Play() {
            MessageBox.Show("Play Mp3.");
        }

        public void Pause() {
            MessageBox.Show("Pause Mp3.");
        }

        public void Stop() {
            MessageBox.Show("Stop Mp3.");
        }

        public void Forward() {
            MessageBox.Show("Forward Mp3.");
        }

        public void Backward() {
            MessageBox.Show("Backward Mp3.");
        }

        public void Open() {
            MessageBox.Show("Open Mp3.");
        }

        public void Close() {
            MessageBox.Show("Close Mp3.");
        }

        #endregion

        #region IAudioMedia Members

        public void Tune(int volume) {
            MessageBox.Show("Tune Mp3.");
        }

        public void Mute() {
            MessageBox.Show("Mute Mp3.");
        }

        #endregion
    }
}
