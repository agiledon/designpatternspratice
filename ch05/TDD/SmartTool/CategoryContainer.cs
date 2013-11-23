using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public class CategoryContainer
    {
        private IList<Category> m_list = new List<Category>();

        public void Add(Category category)
        {
            m_list.Add(category);
        }
        public void Remove(Category category)
        {
            m_list.Remove(category);            
        }

        public int Count
        {
            get { return m_list.Count; }
        }

        public Category this[int index]
        {
            get { return m_list[index]; }           
        }
    }
}
