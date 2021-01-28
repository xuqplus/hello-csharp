using System;
using System.Collections.Generic;
using System.Text;

namespace HiMSTest.Virtual
{
    public class D
    {
        public virtual string AVirtualMethod()
        {
            var r = "haha";
            Console.WriteLine(r);
            return r;
        }

        public virtual string VirtualMethod2()
        {
            var r = "haha";
            Console.WriteLine(r);
            return r;
        }
    }
}
