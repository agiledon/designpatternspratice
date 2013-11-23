using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public interface IReportFactory
    {
        IReportObject CreateReportObject();
        IReportFormatObject CreateReportFormatObject();
        IReportProcessor CreateReportProcessor();
    }
}
