using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.DecoratorPattern.MediaLib;

namespace DonOfDesign.DecoratorPattern.VideoMedia {
    public class CopyRightPlayer : IPlay {
        private IPlay m_player;
        public CopyRightPlayer(IPlay player) { m_player = player; }

        private CopyRight m_copyRightMark;
        public CopyRight CopyRightMark {
            get { return m_copyRightMark; }
            set { m_copyRightMark = value; }
        }
        public void Play() {
            if (m_copyRightMark != null) {
                m_copyRightMark.ShowCopyRight();
                m_player.Play();
            }
        }
    }

}
