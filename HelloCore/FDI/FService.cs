using System;
using System.Configuration;

namespace HelloCore
{
    public class FService : IFService
    {
        public string F()
        {
            string r = "this is HelloCore.FService.F()";
            Console.WriteLine(r);
            
            // test app config file
            Console.WriteLine(ConfigurationManager.AppSettings.Get("aa"));

            return r;
        }
    }
}
