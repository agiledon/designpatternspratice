using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.PracticeObserver.EQPMonitor
{
    public partial class MainForm : Form
    {
        private Equipment m_eqp = new Equipment();

        public MainForm()
        {
            InitializeComponent();

            OperatorForm opForm = new OperatorForm();
            ManufactureForm maForm = new ManufactureForm();
            opForm.StartPosition = FormStartPosition.Manual;
            opForm.Top = 0;
            opForm.Show();

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
            lbMessage.Text = string.Format("Equipment's State is changed to {0}.",m_eqp.State);


            Utility.Notifier.ChangeState(m_eqp);
        }
    }
}