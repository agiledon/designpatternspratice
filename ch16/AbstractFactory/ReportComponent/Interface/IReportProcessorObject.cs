using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public interface IReportProcessor
    {
        int Find(IReportObject rptObj, string searchKey, bool stringCase);
        int Find(IReportObject rptObj, string searchKey);
        bool ExportPDFFile(string pdfFileName);
        bool ExportWordFile(string wordFileName);
        bool ExportExcelFile(string excelFileName);
    }

}
