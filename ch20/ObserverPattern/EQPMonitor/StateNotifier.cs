using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.ObserverPattern.EQPMonitor
{
    public class StateNotifier : IStateNotifier
    {
        private List<IStateChangeable> m_list = new List<IStateChangeable>();
        public void AddStateChangeable(IStateChangeable stateChangeable)
        {
            m_list.Add(stateChangeable);
        }
        public void RemoveStateChangeable(IStateChangeable stateChangeable)
        {
            m_list.Remove(stateChangeable);
        }
        public void ChangeState(Equipment eqp)
        {
            foreach (IStateChangeable changeable in m_list)
            {
                changeable.FindAndChangeEQPState(eqp);
            }
        }
    }
}
