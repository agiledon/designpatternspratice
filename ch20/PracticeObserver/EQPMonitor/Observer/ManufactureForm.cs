using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.PracticeObserver.EQPMonitor
{
    public partial class ManufactureForm : Form
    {
        public ManufactureForm()
        {
            InitializeComponent();
            Utility.Notifier.ChangeEQPStateEvent += new ChangeEQPStateHandler(FindAndChangeEQPState);
        }

        private void FindAndChangeEQPState(Equipment eqp)
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
    }
}