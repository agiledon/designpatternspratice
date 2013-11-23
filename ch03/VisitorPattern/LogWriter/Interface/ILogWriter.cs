using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.VisitorPattern.LogWriter {
    public interface ILogWriter {
        void Write(Log log);
    }
}
