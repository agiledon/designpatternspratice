using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public interface IReportObject
    {
        object DataSource { get; set;}
        void InitReportObject();
    }
}
