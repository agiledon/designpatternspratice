using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CUToCMConverter : CdrConverter {
        public CUToCMConverter(CdrConfigReader reader) : base(reader) { }

        //接收CU话单字符串;
        //转换为CM话单;
        //顺序:主叫号,被叫号，通话时间
        public override CdrRecord FromString(string record) {
            string[] fields = m_reader.ToFields(record, m_reader.GetSourceSeparator());

            CdrRecord cdr = new CUCdr();
            cdr.CallingNumber = fields[0].Trim();
            cdr.CalledNumber = fields[1].Trim();
            cdr.CallTime = int.Parse(fields[2].Trim());
            return cdr;
        }

        //将CNC话单转换为字符串
        //顺序:被叫号，主叫号,通话时间
        public override string ToString(CdrRecord record) {
            string splitter = m_reader.GetTargetSeparator();

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(record.CalledNumber.PadLeft(m_reader.GetTargetWidth(0), ' '));
            strBuilder.Append(splitter);
            strBuilder.Append(record.CallingNumber.PadLeft(m_reader.GetTargetWidth(1), ' '));
            strBuilder.Append(splitter);
            strBuilder.Append(record.CallTime.ToString().PadLeft(m_reader.GetTargetWidth(2), ' '));
            return strBuilder.ToString();
        }

        //将CUC话单转换为CNC话单
        public override CdrRecord Convert(CdrRecord record) {
            if (record is CUCdr) {
                CdrRecord cdr = new CMCdr();
                cdr.CalledNumber = record.CalledNumber;
                cdr.CallingNumber = record.CallingNumber;
                cdr.CallTime = record.CallTime;
                return cdr;
            }
            else {
                throw new NotSupportedException("Source Cdr's Type is not correct.");
            }
        }
    }
}
