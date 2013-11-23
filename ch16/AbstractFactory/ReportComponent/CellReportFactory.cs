using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public class CellReportFactory : IReportFactory
    {
        public IReportObject CreateReportObject()
        {
            return new CellReportObject();
        }
        public IReportFormatObject CreateReportFormatObject()
        {
            return new CellReportFormatObject();
        }
        public IReportProcessor CreateReportProcessor()
        {
            return new CellReportProcessor();
        }
    }

}
