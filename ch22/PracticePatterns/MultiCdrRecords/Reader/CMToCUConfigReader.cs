using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CMToCUConfigReader : CdrConfigReader {
        protected override void Read(string configName) {
            base.Read(configName);
            m_sourceTable = m_dsConfig.Tables["CM"];
            m_targetTable = m_dsConfig.Tables["CU"];
        }
    }
}
