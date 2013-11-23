using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DonOfDesign.PracticePatterns.MultiCdrRecords;

namespace DonOfDesign.PracticePatterns.MultiCdrRecords.Test {
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestUtil {
        public TestUtil() {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private string m_connString;
        private string m_filePath;

        [TestInitialize()]
        public void MyTestInitialize() {
            m_connString = ConfigurationManager.AppSettings["dbConnection"];
            m_filePath = Directory.GetCurrentDirectory() + "\\";
        }

        [TestMethod]
        public void ReadConfig() {
            CdrConfigReader reader = new CMToCUConfigReader();

            Assert.AreEqual(";", reader.GetSourceSeparator());
            Assert.AreEqual(11, reader.GetSourceWidth(0));
            Assert.AreEqual(11, reader.GetSourceWidth(1));
            Assert.AreEqual(8, reader.GetSourceWidth(2));

            Assert.AreEqual(",", reader.GetTargetSeparator());
            Assert.AreEqual(12, reader.GetTargetWidth(0));
            Assert.AreEqual(12, reader.GetTargetWidth(1));
            Assert.AreEqual(8, reader.GetTargetWidth(2));

            string[] srcField = reader.GetSourceFieldNames();
            Assert.AreEqual("CalledNumber", srcField[0]);
        }

        [TestMethod]
        public void CMToCUByTxt() {
            CdrTxtHandler handler = new CdrTxtHandler(new CMToCUFactory());
            handler.Source = m_filePath + "cm.txt";
            handler.Target = m_filePath + "cu_target.txt";
            handler.Handle();
            Assert.IsTrue(File.Exists(handler.Target));
        }

        [TestMethod]
        public void CUToCMByTxt() {
            CdrTxtHandler handler = new CdrTxtHandler(new CUToCMFactory());
            handler.Source = m_filePath + "cu.txt";
            handler.Target = m_filePath + "cm_target.txt";
            handler.Handle();
            Assert.IsTrue(File.Exists(handler.Target));
        }

        [TestMethod]
        public void CMToCUByDB() {
            CdrDBHandler handler = new CdrDBHandler(new CMToCUFactory());
            handler.Source = "cm";
            handler.Target = "cu";
            handler.ConnectionString = m_connString;
            handler.Handle();
        }

        [TestMethod]
        public void CUToCMByDB() {
            CdrDBHandler handler = new CdrDBHandler(new CUToCMFactory());
            handler.Source = "cu";
            handler.Target = "cm";
            handler.ConnectionString = m_connString;
            handler.Handle();
        }
    }
}
