using NUnit.Framework;
using System;

namespace HiNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup - nunit test - Console");
        }

        [Test]
        public void CMethod()
        {
            Console.WriteLine("this is nunit test - Console");

            TestContext.WriteLine("this is nunit test - TestContext");

            Assert.Pass("Test passed exception ..");

            Assert.True(true);
            Assert.True(false);
        }
    }
}