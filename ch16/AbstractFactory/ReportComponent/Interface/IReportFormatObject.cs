using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public interface IReportFormatObject
    {
        DataInfo Parse(string formatFileName);
    }
}
