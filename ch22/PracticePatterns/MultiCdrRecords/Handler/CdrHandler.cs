using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public abstract class CdrHandler {
        protected ICdrConverter m_converter;
        protected CdrConfigReader m_reader;
        protected List<CdrRecord> m_list = new List<CdrRecord>();

        public CdrHandler(CdrFactory factory) {
            m_converter = factory.CreateCdrConverter();
            m_reader = factory.CreateCdrConfigReader();
        }

        public string Source {
            get;
            set;
        }
        public string Target {
            get;
            set;
        }

        public void Handle() {
            Read();
            Write();
        }
        protected abstract void Read();
        protected abstract void Write();
    }

}
