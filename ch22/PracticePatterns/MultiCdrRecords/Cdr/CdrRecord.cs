using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CdrRecord {
        public Guid CdrID {
            get;
            set;
        }
        public string CallingNumber {
            get;
            set;
        }
        public string CalledNumber {
            get;
            set;
        }
        public long CallTime {
            get;
            set;
        }
    }

}
