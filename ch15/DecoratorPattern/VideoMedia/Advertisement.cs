using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonOfDesign.DecoratorPattern.VideoMedia
{
    public class Advertisement
    {
        public Advertisement(string info)
        {
            m_information = info;
        }
        private string m_information;
        public string Information
        {
            get { return Information; }
            set { Information = value; }
        }

        public void ShowAdvertisement()
        {
            MessageBox.Show(this.m_information);
        }
    }
}
