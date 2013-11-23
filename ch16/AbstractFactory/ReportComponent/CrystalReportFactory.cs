using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public class CrystalReportFactory : IReportFactory
    {
        public IReportObject CreateReportObject()
        {
            return new CrystalReportObject();
        }
        public IReportFormatObject CreateReportFormatObject()
        {
            return new CrystalReportFormatObject();
        }
        public IReportProcessor CreateReportProcessor()
        {
            return new CrystalReportProcessor();
        }
    }

}
