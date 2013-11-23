using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.LogWriter {
    public class Log {
        public Log(string logContent) {
            this.LogContent = logContent;
        }

        public string LogContent {
            get;
            set;
        }
        public void Write(ILogWriter logWriter) {
            logWriter.Write(this);
        }
    }
}
