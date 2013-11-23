using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.DecoratorPattern.MediaLib;

namespace DonOfDesign.DecoratorPattern.VideoMedia {
    public class AdvertisementPlayer : IPlay {
        private IPlay m_player;

        public AdvertisementPlayer(IPlay player) {
            m_player = player;
        }

        private Advertisement m_advertisement;
        public Advertisement Advertisement {
            get { return m_advertisement; }
            set { m_advertisement = value; }
        }
        public void Play() {
            if (m_advertisement != null) {
                m_advertisement.ShowAdvertisement();
                m_player.Play();
            }
        }
    }
}
