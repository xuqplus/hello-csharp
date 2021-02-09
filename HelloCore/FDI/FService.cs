using System;

namespace HelloCore
{
    public class FService : IFService
    {
        public string F()
        {
            string r = "this is HelloCore.FService.F()";
            Console.WriteLine(r);
            return r;
        }
    }
}
