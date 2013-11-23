using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public class DataInfo
    {
        private string m_head;
        private string m_body;

        public string Head
        {
            get { return m_head; }
            set { m_head = value; }
        }

        public string Body
        {
            get { return m_body; }
            set { m_body = value; }
        }
    }
}
