using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CMToCUFactory : CdrFactory {
        public override ICdrConverter CreateCdrConverter() {
            return new CMToCUConverter(new CMToCUConfigReader());
        }
        public override CdrConfigReader CreateCdrConfigReader() {
            return new CMToCUConfigReader();
        }
    }
}
