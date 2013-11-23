using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.DecoratorPattern.VideoMedia
{
    public class CopyRight
    {
        public CopyRight(string info)
        {
            m_information = info;
        }
        private string m_information;
        public string Information
        {
            get { return Information; }
            set { Information = value; }
        }

        public void ShowCopyRight()
        {
            MessageBox.Show(this.m_information);
        }
    }
}
