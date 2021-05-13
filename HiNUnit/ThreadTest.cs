using System.Threading;
using NUnit.Framework;

namespace HiNUnit
{
    class ThreadTest
    {
        [Test]
        public void Test()
        {
            var thread = new Thread(() =>
            {
                TestContext.WriteLine(@"in new thread - {0}", Thread.CurrentThread.Name);
            });
            thread.Name = "a name?";
            thread.Start();
            TestContext.WriteLine(@"in new thread - {0}", Thread.CurrentThread.Name);
        }
    }
}