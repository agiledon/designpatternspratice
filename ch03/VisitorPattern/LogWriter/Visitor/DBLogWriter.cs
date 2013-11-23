using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.LogWriter {
    public class DBLogWriter : ILogWriter {

        #region ILogWriter Members

        public void Write(Log log) {
            Console.WriteLine("Logging {0} to DB.", log.LogContent);
        }

        #endregion
    }
}
