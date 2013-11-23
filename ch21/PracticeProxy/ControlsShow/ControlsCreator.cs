using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DonOfDesign.PracticeProxy.ControlsShow
{
    public delegate void AddControlsHandler();

    public abstract class ControlsCreator
    {
        protected Control[] m_controls = new Control[] { };
        public Control[] Controls
        {
            get { return m_controls; }
        }       

        public virtual void CreateEQPControls()
        {
            //读取xml文件，获取信息后，创建控件；
            //创建后的控件放到m_controls中；
            //不返回m_controls;

            //为简便起见，我直接创建一些Button控件
            //创建10个Button控件
            m_controls = new Control[10];
            for (int i = 0; i < 5; i++)
            {
                Control btn = new Button();
                btn.BackColor = Color.Green;
                btn.Top = 30 * i + 50;
                btn.Left = 10;
                btn.Width = 180;
                btn.Height = 30;
                m_controls[i] = btn;
            }

            for (int i = 0; i < 5; i++)
            {
                Control btn = new Button();
                btn.BackColor = Color.Green;
                btn.Top = 30 * i + 50;
                btn.Left = 220;
                btn.Width = 180;
                btn.Height = 30;
                m_controls[i+5] = btn;
            }
        }
    }

}
