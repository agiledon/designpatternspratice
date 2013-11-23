using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public interface ICdrConverter {
        CdrRecord Convert(CdrRecord sourceRecord);
        CdrRecord FromString(string recordLine);
        string ToString(CdrRecord sourceRecord);
    }
}
