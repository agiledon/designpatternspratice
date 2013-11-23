using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.TDD.SmartTool
{
    public class InternetSearchEngineFactory:SearchEngineFactory
    {
        public override SearchEngine CreateSearchEngine()
        {
            return InternetSearchEngine.Instance;
        }
    }
}
