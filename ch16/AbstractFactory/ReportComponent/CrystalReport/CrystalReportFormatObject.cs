using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public class CrystalReportFormatObject:IReportFormatObject
    {
        #region IReportFormatObject Members

        public DataInfo Parse(string formatFileName)
        {
            DataInfo info = new DataInfo();
            info.Head = "Crystal Report";
            info.Body = "Report Data";
            return info;
        }

        #endregion
    }
}
