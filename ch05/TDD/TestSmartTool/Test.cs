using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using DonOfDesign.TDD.SmartTool;

namespace DonOfDesign.TDD.TestSmartTool
{
    [TestFixture]
    public class Test
    {
        private Category m_cg1;
        private Category m_cg2;
        private CategoryContainer m_cgContainer;
        private SmartController m_control;
        [SetUp]
        public void InitObject()
        {
            m_cg1 = new Category("SoftWare Engineering", "TDD");
            m_cg2 = new Category("SoftWare Engineering", "Design Patterns");
            m_cgContainer = new CategoryContainer();
            m_cgContainer.Add(m_cg1);
            m_cgContainer.Add(m_cg2);

            m_control = new SmartController();
        }

        [Test]
        public void TestCategory()
        {
            Assert.IsNotNull(m_cgContainer);
            Assert.AreEqual(m_cg1, m_cgContainer[0]);
            Assert.AreEqual(m_cg2, m_cgContainer[1]);
        }

        [Test]
        public void TestController()
        {
            Assert.IsNotNull(m_control);
            Assert.IsTrue(m_control.CustomizeCategories(m_cgContainer));
            Assert.AreEqual(m_cg1,m_control.Categories[0]);
        }

        //[Test]
        //public void TestSearching()
        //{
        //    SearchEngine engine = new SearchEngine();
        //    Assert.IsNotNull(engine);

        //    SearchResult result1 = new SearchResult();
        //    SearchResult result2 = new SearchResult();
        //    Assert.IsNotNull(result1);
        //    Assert.IsNotNull(result2);
        //    result1 = engine.ExactSearch(control.Categaries);
        //    result2 = engine.BlurSearch(control.Categaries);

        //    Assert.AreEqual("contents", result1.Content);
        //    Assert.AreEqual("more contents", result2.Content);
        //}

        [Test]
        public void TestInternetSearching()
        {
            SearchEngineFactory factory = new InternetSearchEngineFactory();
            SearchEngine engine = factory.CreateSearchEngine();
            SearchEngine engine1 = factory.CreateSearchEngine();
            Assert.IsNotNull(engine);
            Assert.IsNotNull(engine1);
            Assert.AreEqual(engine,engine1);

            SearchResult result1 = new SearchResult();
            SearchResult result2 = new SearchResult();
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            result1 = engine.ExactSearch(m_control.Categories);
            result2 = engine.BlurSearch(m_control.Categories);

            Assert.AreEqual("contents", result1.Content);
            Assert.AreEqual("more contents", result2.Content);

        }


    }

}
