using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CdrTxtHandler : CdrHandler {
        public CdrTxtHandler(CdrFactory factory) : base(factory) { }

        protected override void Read() {
            using (StreamReader sd = new StreamReader(this.Source)) {
                CdrRecord cdr = null;
                string line;
                while ((line = sd.ReadLine()) != null) {
                    //首先调用ICdrRecord Convert(string record)方法；
                    //再调用ICdrRecord Convert(ICdrRecord record)方法；
                    //至于实现的是何种转换，由构造函数传入的ICdrConvert对象决定；
                    cdr = m_converter.Convert(m_converter.FromString(line));
                    m_list.Add(cdr);
                }
            }
        }

        protected override void Write() {
            using (StreamWriter sw = new StreamWriter(this.Target, true)) {
                foreach (CdrRecord record in m_list) {
                    sw.WriteLine(m_converter.ToString(record));
                }
            }
        }
    }


}
