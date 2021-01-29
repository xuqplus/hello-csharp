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

        public string NonVirtualMethod()
        {
            var r = "haha";
            Console.WriteLine(r);
            return r;
        }
    }
}
