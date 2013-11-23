using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public class SmartController
    {
        public SmartController()
        {
            m_categories = new Category[]{};
        }

        private Category[] m_categories;
        public Category[] Categories
        {
            get { return m_categories; }
        }
        public bool CustomizeCategories(CategoryContainer categories)
        {
            m_categories = new Category[categories.Count];
            for (int i = 0; i < categories.Count; i++)
            {
                m_categories[i] = categories[i];
            }
            return true;
        }
    }
}
