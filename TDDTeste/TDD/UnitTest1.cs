using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPotz()
        {
            MeuPotz potz = new MeuPotz(306543219);
            Assert.AreEqual(300, potz.pontos);
        }
    }
}
