using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.AbstractFactory.ReportComponent;

namespace DonOfDesign.AbstractFactory.ReportManager
{
    public abstract class UtilManager
    {
        public static IReportFactory Factory = new CrystalReportFactory();

        //public static IReportFactory Factory = new CellReportFactory();
    }
}
