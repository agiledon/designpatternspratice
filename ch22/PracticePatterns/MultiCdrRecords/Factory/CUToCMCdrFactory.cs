using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CUToCMFactory : CdrFactory {
        public override ICdrConverter CreateCdrConverter() {
            return new CUToCMConverter(new CUToCMConfigReader());
        }
        public override CdrConfigReader CreateCdrConfigReader() {
            return new CUToCMConfigReader();
        }
    }
}
