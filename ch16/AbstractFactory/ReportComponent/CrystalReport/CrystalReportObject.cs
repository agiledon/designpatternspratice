using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public class CrystalReportObject:IReportObject
    {
        private object m_dataSource;

        #region IReportObject Members

        public object DataSource
        {
            get
            {
                return m_dataSource;
            }
            set
            {
                m_dataSource = value;
            }
        }

        public void InitReportObject()
        {
            Console.WriteLine("Init Crystal Report Object.");
        }

        #endregion
    }
}
