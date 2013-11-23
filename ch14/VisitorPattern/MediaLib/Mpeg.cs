using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.MediaLib {
    public class Mpeg : IVideoMedia {
        #region IAudioMedia Members

        public void Tune() {
            Console.WriteLine("Tune Mpeg.");
        }

        public void Mute() {
            Console.WriteLine("Mute Mpeg.");
        }


        #endregion

        #region IMedia Members

        public void Play() {
            Console.WriteLine("Play Mpeg.");
        }

        public void Pause() {
            Console.WriteLine("Pause Mpeg.");
        }

        public void Stop() {
            Console.WriteLine("Stop Mpeg.");
        }

        public void Forward() {
            Console.WriteLine("Forward Mpeg.");
        }

        public void Backward() {
            Console.WriteLine("Backward Mpeg.");
        }

        #endregion



        #region IVideoMedia Members

        public void ShowScript() {
            Console.WriteLine("Show Script Mpeg");
        }

        public void Accept(IVideoMediaVisitor visitor) {
            visitor.Visit(this);
        }

        #endregion
    }
}
