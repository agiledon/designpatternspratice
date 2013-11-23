using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.AbstractFactory.ReportComponent;

namespace DonOfDesign.AbstractFactory.ReportManager
{
    class Program
    {
        static void Main(string[] args)
        {
            IReportObject ro = UtilManager.Factory.CreateReportObject();
            IReportFormatObject rfo = UtilManager.Factory.CreateReportFormatObject();
            IReportProcessor rp = UtilManager.Factory.CreateReportProcessor();

            ro.InitReportObject();
            rfo.Parse("report.xml");
            rp.Find(ro,"key");

            Console.Read();
        }
    }
}
