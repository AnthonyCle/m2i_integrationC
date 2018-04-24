using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblio_IntegratC;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(Integration.GetInt("20"));
            Assert.AreEqual(Integration.GetInt("40"), 40);
            Assert.AreEqual(Integration.GetInt("50"), 50);
            Assert.AreEqual(Integration.GetInt("1000"), 1000);
        }
    }
}
