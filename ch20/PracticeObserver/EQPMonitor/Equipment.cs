using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticeObserver.EQPMonitor
{
    public enum EQPState{Offline=0,Online}
    public class Equipment
    {
        public Equipment()
        {
            m_state = EQPState.Offline;
        }
        private EQPState m_state;
        public EQPState State
        {
            get { return m_state; }
            set { m_state = value; }
        }
    }
}
