using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public abstract class CdrFactory {
        public abstract ICdrConverter CreateCdrConverter();
        public abstract CdrConfigReader CreateCdrConfigReader();
    }
}
