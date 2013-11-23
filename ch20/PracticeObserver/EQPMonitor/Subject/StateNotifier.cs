using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticeObserver.EQPMonitor
{
    public delegate void ChangeEQPStateHandler(Equipment eqp);

    public class StateNotifier
    {
        public event ChangeEQPStateHandler ChangeEQPStateEvent;

        public void ChangeState(Equipment eqp)
        {
            if (ChangeEQPStateEvent != null)
            {
                ChangeEQPStateEvent(eqp);
            }
        }
    }
}
