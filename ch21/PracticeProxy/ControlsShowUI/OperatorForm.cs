using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DonOfDesign.PracticeProxy.ControlsShow;

namespace DonOfDesign.PracticeProxy.ControlsShowUI
{
    public partial class OperatorForm : Form
    {
        private ControlsCreator m_creator;

        public OperatorForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            m_creator = new ProxyControlsCreator();

            //订阅事件；
            ((ProxyControlsCreator)m_creator).AddControlsEvent += new AddControlsHandler(AddControlsToGB);
            m_creator.CreateEQPControls();

            //添加控件到GroupBox中；
            AddControlsToGB();
        }

        //事件触发时执行的方法；
        //事件被触发，表明真实对象的CreateEQPControls方法执行完毕，
        //此时Controls属性值已经发生了改变；
        private void AddControlsToGB()
        {
            if (gbEQPControls.InvokeRequired)
            {
                AddControlsHandler handler = new AddControlsHandler(InternalAddControlsToGB);
                gbEQPControls.Invoke(handler);
            }
            else
            {
                InternalAddControlsToGB();
            }
        }

        private void InternalAddControlsToGB()
        {
            gbEQPControls.Controls.Clear();
            foreach (Control control in m_creator.Controls)
            {
                gbEQPControls.Controls.Add(control);
            }
        }

        private void OperatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}