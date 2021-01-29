using System;
using System.Collections.Generic;
using System.Text;

namespace HiMSTest.Virtual
{
    public class D2 : D
    {
        public override string AVirtualMethod()
        {
            var r = "hihi";
            Console.WriteLine(r);
            return r;
        }

        // only abstract/override/virtual methods can be override
        //public override string NonVirtualMethod()
        //{
        //    var r = "hihi";
        //    Console.WriteLine(r);
        //    return r;
        //}
    }
}
