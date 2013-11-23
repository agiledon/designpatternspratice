using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public abstract class SearchEngineFactory
    {
        public abstract SearchEngine CreateSearchEngine();
    }
}
