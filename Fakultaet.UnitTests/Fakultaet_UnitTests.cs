using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fakultaet;

namespace Fakultaet.UnitTests
{
    [TestClass]
    public class Fakultaet_UnitTests
    {
        [TestMethod]
        public void Fakultaet_Test1()
        {
            Fakultaet prg = new Fakultaet();

            var fakultaet = prg.Fakultaet_n(3);

            Assert.AreEqual(6, fakultaet);

        }
    }
}
