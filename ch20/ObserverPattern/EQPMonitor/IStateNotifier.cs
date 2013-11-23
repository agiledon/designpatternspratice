using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.ObserverPattern.EQPMonitor
{
    public interface IStateNotifier
    {
        void ChangeState(Equipment eqp);
        void AddStateChangeable(IStateChangeable stateChangeable);
        void RemoveStateChangeable(IStateChangeable stateChangeable);
    }
}
