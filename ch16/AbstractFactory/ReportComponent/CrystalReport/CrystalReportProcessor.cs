using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.AbstractFactory.ReportComponent
{
    public class CrystalReportProcessor:IReportProcessor
    {
        #region IReportProcessorObject Members

        public int Find(IReportObject rptObj, string searchKey, bool stringCase)
        {
            Console.WriteLine("Find Crystal Report.");
            int row = 1;
            return row;
        }

        public int Find(IReportObject rptObj, string searchKey)
        {
            return Find(rptObj, searchKey, true);
        }

        public bool ExportPDFFile(string pdfFileName)
        {
            return true;
        }

        public bool ExportWordFile(string wordFileName)
        {
            return true;
        }

        public bool ExportExcelFile(string excelFileName)
        {
            return true;
        }

        #endregion
    }
}
