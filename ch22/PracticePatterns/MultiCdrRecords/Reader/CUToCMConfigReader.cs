using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CUToCMConfigReader : CdrConfigReader {
        protected override void Read(string configName) {
            base.Read(configName);
            m_sourceTable = m_dsConfig.Tables["CU"];
            m_targetTable = m_dsConfig.Tables["CM"];
        }
    }
}
