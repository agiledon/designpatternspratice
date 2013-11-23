using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.LogWriter {
    public class TxtLogWriter : ILogWriter {

        #region ILogWriter Members

        public void Write(Log log) {
            Console.WriteLine("Logging {0} to text file.", log.LogContent);
        }

        #endregion
    }
}
