using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.ObserverPattern.EQPMonitor
{
    public interface IStateChangeable
    {
        void FindAndChangeEQPState(Equipment eqp);
    }
}
