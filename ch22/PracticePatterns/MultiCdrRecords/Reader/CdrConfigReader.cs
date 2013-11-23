using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Reflection;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords {
    public abstract class CdrConfigReader {
        private static string CONFIG_FILE = "CdrConfig.xml";

        protected DataSet m_dsConfig = new DataSet();
        protected DataTable m_sourceTable = new DataTable();
        protected DataTable m_targetTable = new DataTable();

        public CdrConfigReader() {
            Read(CONFIG_FILE);
        }

        protected virtual void Read(string configName) {
            if (File.Exists(configName)) {
                m_dsConfig.ReadXml(configName);
            }
            else {
                throw new FileNotFoundException("Cdr Config is not found.");
            }
        }

        //根据分隔符将字符串分成字段值的集合
        public string[] ToFields(string record, string separator) {
            string[] fields;
            if (!string.IsNullOrEmpty(separator)) {
                fields = record.Split(separator.ToCharArray());
            }
            else {
                int startPosition = 0;
                int index = 0;
                List<string> fieldList = new List<string>();
                while (startPosition < record.Length) {
                    fieldList.Add(record.Substring(startPosition, GetSourceWidth(index)));
                    startPosition += GetSourceWidth(index++);
                }
                fields = fieldList.ToArray();
            }
            return fields;
        }

        public string GetSourceSeparator() {
            return m_sourceTable.Rows[0]["Separator"].ToString();
        }
        public int GetSourceWidth(string fieldName) {
            return int.Parse(m_sourceTable.Rows[0][fieldName].ToString());
        }
        public int GetSourceWidth(int fieldOrder) {
            return int.Parse(m_sourceTable.Rows[0][fieldOrder].ToString());
        }
        public string[] GetSourceFieldNames() {
            int count = m_sourceTable.Columns.Count - 1;
            string[] fields = new string[count];

            //不包括Separator字段
            for (int i = 0; i < count; i++) {
                fields[i] = m_sourceTable.Columns[i].ColumnName;
            }
            return fields;
        }

        public string GetTargetSeparator() {
            return m_targetTable.Rows[0]["Separator"].ToString();
        }
        public int GetTargetWidth(string fieldName) {
            return int.Parse(m_targetTable.Rows[0][fieldName].ToString());
        }
        public int GetTargetWidth(int fieldOrder) {
            return int.Parse(m_targetTable.Rows[0][fieldOrder].ToString());
        }
        public string[] GetTargetFieldNames() {
            int count = m_targetTable.Columns.Count - 1;
            string[] fields = new string[count];

            //不包括Separator字段
            for (int i = 0; i < count; i++) {
                fields[i] = m_targetTable.Columns[i].ColumnName;
            }
            return fields;
        }
    }

}
