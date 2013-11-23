using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public class SearchResult
    {
        public SearchResult()
        {
        }

        public SearchResult(Category[] categories, string content)
        {
            m_categories = categories;
            m_content = content;
        }
        private Category[] m_categories;
        private string m_content;

        public Category[] Categories
        {
            get { return m_categories; }
            set { m_categories = value; }
        }
        public string Content
        {
            get { return m_content; }
            set { m_content = value; }
        }
    }
}
