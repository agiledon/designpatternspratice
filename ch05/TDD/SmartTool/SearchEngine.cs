using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public abstract class SearchEngine
    {
        public virtual SearchResult ExactSearch(Category[] categories)
        {
            throw new NotSupportedException("Operation is not implemented.");
        }
        public virtual SearchResult BlurSearch(Category[] categories)
        {
            throw new NotSupportedException("Operation is not implemented.");
        }
    }
}
