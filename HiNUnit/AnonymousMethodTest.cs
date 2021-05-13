using System;
using NUnit.Framework;

namespace HiNUnit
{
    class AnonymousMethodTest
    {
        delegate void Handler();

        [Test]
        public void Test()
        {
            Handler h = () => { Console.WriteLine("1"); };
            h += () => { Console.WriteLine("2"); };
            h();
        }
    }
}