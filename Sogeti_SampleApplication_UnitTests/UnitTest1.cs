using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sogeti_SampleApplication;
using System.Windows.Forms;

namespace Sogeti_SampleApplication_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = Form1.AddMethod(1,2);
            Assert.AreEqual(a, 3, "Test failed");
        }
    }
}
