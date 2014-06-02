using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotzImpl;

namespace TDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPotz()
        {
            Potz potz = new Potz("5001234560");
            Assert.AreEqual(500, potz.pontos);
        }
    }
}
