using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public class CdrDBHandler : CdrHandler {
        private string m_connectionString;

        public string ConnectionString {
            get { return m_connectionString; }
            set { m_connectionString = value; }
        }

        public CdrDBHandler(CdrFactory factory) : base(factory) { }

        //私有方法;
        private string ToString(DataRow row, int columns) {
            StringBuilder record = new StringBuilder();
            for (int i = 0; i < columns; i++) {
                record.Append(row[i].ToString().Trim().PadRight(m_reader.GetSourceWidth(i), ' '));
                if (i < columns - 1) {
                    record.Append(m_reader.GetSourceSeparator());
                }
            }
            return record.ToString();
        }

        protected override void Read() {
            CdrRecord cdr = null;
            DataTable table = new DataTable();

            string commText = "select * from " + this.Source;
            table = SQLHelper.ExecuteQuery(m_connectionString, CommandType.Text, commText).Tables[0];

            foreach (DataRow row in table.Rows) {
                string record = ToString(row, table.Columns.Count);
                cdr = m_converter.Convert(m_converter.FromString(record));
                m_list.Add(cdr);
            }
        }
        protected override void Write() {
            foreach (var cdr in m_list) {
                string seperator = m_reader.GetTargetSeparator();

                string record = m_converter.ToString(cdr);
                string[] fields = m_reader.ToFields(record, m_reader.GetTargetSeparator());
                string field0 = fields[0].Trim().PadRight(m_reader.GetTargetWidth(0), ' ');
                string field1 = fields[1].Trim().PadRight(m_reader.GetTargetWidth(1), ' ');
                string field2 = fields[2].Trim().PadRight(m_reader.GetTargetWidth(2), ' ');

                string commText = string.Format("insert into {0} values('{1}','{2}','{3}')",
                    this.Target, field0, field1, field2);
                SQLHelper.ExecuteNonQuery(m_connectionString, CommandType.Text, commText);
            }
        }
    }

}
