using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Business.Test
{
    [TestClass]
    public class UserBoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Maths bo = new Maths();
            var result = bo.Add(2, 2);
            Assert.AreEqual(5, result);
        }
    }
}
