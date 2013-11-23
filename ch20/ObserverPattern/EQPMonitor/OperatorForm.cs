using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.ObserverPattern.EQPMonitor
{
    public partial class OperatorForm : Form, IStateChangeable
    {
        public OperatorForm(IStateNotifier notifier)
        {
            InitializeComponent();
            notifier.AddStateChangeable(this);
        }

        #region IStateChangeable Members

        public void FindAndChangeEQPState(Equipment eqp)
        {
            switch (eqp.State)
            {
                case EQPState.Offline:
                    lbMessage.Text = "Offline";
                    lbMessage.BackColor = Color.Red;
                    break;
                case EQPState.Online:
                    lbMessage.Text = "Online";
                    lbMessage.BackColor = Color.Green;
                    break;
            }
        }

        #endregion
    }
}