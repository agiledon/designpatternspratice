using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    internal abstract class CancelAction {
        public CancelAction() { }

        public CancelAction(CancelAction action) {
            this.m_nextAction = action;
            this.m_hasNextAction = true;
        }

        public abstract void Execute(Ticket ticket, Timeline timeline, DateTime cancelTime);

        protected bool m_hasNextAction = false;
        protected CancelAction m_nextAction;

        protected bool Between(DateTime beginTime, DateTime endTime, DateTime currentTime) {
            Debug.Assert(beginTime < endTime);
            return currentTime >= beginTime && currentTime < endTime;
        }
    }
}
