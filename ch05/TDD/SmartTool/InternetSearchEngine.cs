using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public class InternetSearchEngine : SearchEngine
    {
        private static SearchEngine m_engine;
        private InternetSearchEngine() { }
        public static SearchEngine Instance
        {
            get
            {
                if (m_engine == null)
                {
                    m_engine = new InternetSearchEngine();
                }
                return m_engine;
            }
        }
        public override SearchResult ExactSearch(Category[] categories)
        {
            return new SearchResult(categories, "contents");
        }
        public override SearchResult BlurSearch(Category[] categories)
        {
            return new SearchResult(categories, "more contents");
        }
    }
}
