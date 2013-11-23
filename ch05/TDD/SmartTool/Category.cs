using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public class Category
    {
        public Category()
        {
            m_parent = string.Empty;
            m_child = string.Empty;
        }
        public Category(string parent, string child)
        {
            m_parent = parent;
            m_child = child;
        }
        private string m_parent;
        private string m_child;

        public string Parent
        {
            get { return m_parent; }
            set { m_parent = value; }
        }
        public string Child
        {
            get { return m_child; }
            set { m_child = value; }
        }
    }
}
