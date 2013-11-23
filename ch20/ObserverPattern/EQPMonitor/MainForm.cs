using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.ObserverPattern.EQPMonitor
{
    public partial class MainForm : Form
    {
        private IStateNotifier m_notifier = new StateNotifier();
        private Equipment m_eqp = new Equipment();

        public MainForm()
        {
            InitializeComponent();

            OperatorForm opForm = new OperatorForm(m_notifier);
            opForm.StartPosition = FormStartPosition.Manual;
            opForm.Top = 0;
            opForm.Show();

            ManufactureForm maForm = new ManufactureForm(m_notifier);
            maForm.StartPosition = FormStartPosition.Manual;
            maForm.Top = 300;
            maForm.Show();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //模拟设备状态变化;
            if (m_eqp.State.Equals(EQPState.Offline))
            {
                m_eqp.State = EQPState.Online;
            }
            else
            {
                m_eqp.State = EQPState.Offline;
            }
            lbMessage.Text = string.Format("Equipment's State is changed to {0}.", m_eqp.State);

            m_notifier.ChangeState(m_eqp);
        }
    }
}