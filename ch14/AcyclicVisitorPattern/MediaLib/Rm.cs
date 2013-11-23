using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AcynlicVisitorPattern.MediaLib {
    public class Rm : IVideoMedia {
        #region IVideoMedia Members

        public void ShowScript() {
            Console.WriteLine("ShowScript Rm");
        }

        public void Accept(IVideoMediaVisitor visitor) {
            if (visitor is IRmVisitor) {
                var rv = visitor as IRmVisitor;
                rv.Visit(this);
            }
        }

        #endregion

        #region IAudioMedia Members

        public void Tune() {
            Console.WriteLine("Tune Rm.");
        }

        public void Mute() {
            Console.WriteLine("Mute Rm.");
        }

        #endregion

        #region IMedia Members

        public void Play() {
            Console.WriteLine("Play Rm.");
        }

        public void Pause() {
            Console.WriteLine("Pause Rm.");
        }

        public void Stop() {
            Console.WriteLine("Stop Rm.");
        }

        public void Forward() {
            Console.WriteLine("Forward Rm.");
        }

        public void Backward() {
            Console.WriteLine("Backward Rm.");
        }

        #endregion

    }
}
