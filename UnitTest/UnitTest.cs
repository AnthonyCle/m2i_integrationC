using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblio_IntegratC;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void TestInt()
        {
            var result = Integration.GetInt("10");
            Assert.AreEqual(10, result);
        }
    }
}
