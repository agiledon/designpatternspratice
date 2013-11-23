using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.AdapterPattern.MediaLib;

namespace DonOfDesign.AdapterPattern.MediaPlayer {
    public static class Client {
        public static void Play(IMedia media) {
            media.Play();
        }
        public static void Pause(IMedia media) {
            media.Pause();
        }
        public static void Stop(IMedia media) {
            media.Stop();
        }
        public static void Forward(IMedia media) {
            media.Forward();
        }
        public static void Backward(IMedia media) {
            media.Backward();
        }
        public static void Open(IMedia media) {
            media.Open();
        }
        public static void Close(IMedia media) {
            media.Close();
        }
    }
}
