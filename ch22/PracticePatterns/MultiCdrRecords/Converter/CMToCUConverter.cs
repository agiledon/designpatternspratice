using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CMToCUConverter : CdrConverter {
        public CMToCUConverter(CdrConfigReader reader) : base(reader) { }

        //接收CM话单字符串转换为CM话单
        //顺序：被叫号，主叫号，通话时间
        public override CdrRecord FromString(string record) {
            string[] fields = m_reader.ToFields
                  (record, m_reader.GetSourceSeparator());

            CdrRecord cdr = new CMCdr();
            cdr.CalledNumber = fields[0].Trim();
            cdr.CallingNumber = fields[1].Trim();
            cdr.CallTime = int.Parse(fields[2].Trim());
            return cdr;
        }

        //将CU话单转换为字符串
        //顺序：主叫号，被叫号，通话时间
        public override string ToString(CdrRecord record) {
            string separator = m_reader.GetTargetSeparator();

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(record.CallingNumber.PadLeft(
                 m_reader.GetTargetWidth(0), ' '));
            strBuilder.Append(separator);
            strBuilder.Append(record.CalledNumber.PadLeft(
               m_reader.GetTargetWidth(1), ' '));
            strBuilder.Append(separator);
            strBuilder.Append(record.CallTime.ToString().PadLeft
                  (m_reader.GetTargetWidth(2), ' '));
            return strBuilder.ToString();
        }

        //将CM话单转换为CU话单
        public override CdrRecord Convert(CdrRecord record) {
            if (record is CMCdr) {
                CdrRecord cdr = new CUCdr();
                cdr.CallingNumber = record.CallingNumber;
                cdr.CalledNumber = record.CalledNumber;
                cdr.CallTime = record.CallTime;
                return cdr;
            }
            else {
                throw new NotSupportedException("Source Cdr's Type is not correct.");
            }
        }

    }
}
