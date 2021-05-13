using System;
using NUnit.Framework;

namespace HiNUnit
{
    class EventTest
    {
        [Test]
        public void Test()
        {
            var p = new Publisher();
            var s0 = new Subscriber();
            var s1 = new Subscriber();
            p.handler += s0.a;
            p.handler += s1.a;

            p.F();
        }
    }

    class Publisher
    {
        public delegate void Handler();

        public event Handler handler;

        public void F()
        {
            handler();
        }
    }

    class Subscriber
    {
        public void a()
        {
            Console.WriteLine("test event delegate");
        }
    }
}