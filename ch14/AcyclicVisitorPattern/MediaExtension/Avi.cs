using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.AcynlicVisitorPattern.MediaLib;

namespace DonOfDesign.AcynlicVisitorPattern.MediaExtension {
    public class Avi:IVideoMedia {
        #region IVideoMedia Members

        public void ShowScript() {
            Console.WriteLine("Show Script Avi.");
        }

        public void Accept(IVideoMediaVisitor visitor) {
            if (visitor is IAviVisitor) {
                var rv = visitor as IAviVisitor;
                rv.Visit(this);
            }
        }

        #endregion

        #region IAudioMedia Members

        public void Tune() {
            Console.WriteLine("Tune Avi.");
        }

        public void Mute() {
            Console.WriteLine("Mute Avi.");
        }

        #endregion

        #region IMedia Members

        public void Play() {
            Console.WriteLine("Play Avi.");
        }

        public void Pause() {
            Console.WriteLine("Pause Avi.");
        }

        public void Stop() {
            Console.WriteLine("Stop Avi.");
        }

        public void Forward() {
            Console.WriteLine("Forward Avi.");
        }

        public void Backward() {
            Console.WriteLine("Backward Avi.");
        }

        #endregion
    }
}
