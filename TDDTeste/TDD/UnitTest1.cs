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
            Potz potz = new Potz(306543219);
            Assert.AreEqual(300, potz.pontos);
        }
    }
}
