using HiMSTest.Virtual;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;

namespace HiMSTest
{
    [TestClass]
    public class BTest
    {
        [TestMethod]
        public void BMethod()
        {
            Console.WriteLine("this is ms test - Console");

            Logger.LogMessage("this is ms test - Logger", new object[0]);

            //Assert.IsTrue(true);
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void B2Method()
        {
            D d = new D2();

            string[] r = { d.AVirtualMethod(), d.NonVirtualMethod() };

            Logger.LogMessage("Test keyword virtual, method return {0} and {1}", r);

            Assert.IsTrue(true);
        }

    }
}
