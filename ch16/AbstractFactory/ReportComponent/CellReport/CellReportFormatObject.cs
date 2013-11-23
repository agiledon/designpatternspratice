using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public class CellReportFormatObject:IReportFormatObject
    {
        #region IReportFormatObject Members

        public DataInfo Parse(string formatFileName)
        {
            DataInfo info = new DataInfo();
            info.Head = "Cell Report";
            info.Body = "Report Data";
            return info;
        }

        #endregion
    }
}
