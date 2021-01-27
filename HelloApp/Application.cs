using HelloCore;
using HelloCore.Folder;
using HiApp;
using HiApp.Folder.B;
using System;

namespace HelloApp
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            A.F();
            new B().F();
            C.F();
            new D().F();
            E.F();
        }
    }
}
