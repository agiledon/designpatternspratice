using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public abstract class CdrConverter : ICdrConverter {
        protected CdrConfigReader m_reader;

        public CdrConverter(CdrConfigReader reader) {
            m_reader = reader;
        }

        //将目标话单对象转换为字符串        
        public abstract string ToString(CdrRecord sourceRecord);

        //将源话单字符串转换为话单对象;
        public abstract CdrRecord FromString(string recordLine);

        //将源话单对象转换为目标话单对象
        public abstract CdrRecord Convert(CdrRecord sourceRecord);
    }
}
