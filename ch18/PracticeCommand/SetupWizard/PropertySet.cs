using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.SetupWizard
{
    public static class PropertySet
    {
        private static IDictionary<string, object> m_properties = new Dictionary<string,object>();

        public static void AddProperty(string key, object value)
        {
            m_properties.Add(key,value);
        }

        public static void RemoveProperty(string key)
        {
            m_properties.Remove(key);
        }

        public static object GetValue(string key)
        {
            object value;
            if (m_properties.TryGetValue(key, out value))
            {
                return value;
            }
            else
            {
                throw new Exception("获取属性值出现异常");
            }
        }
    }
}
