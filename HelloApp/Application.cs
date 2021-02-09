using HelloCore;
using HelloCore.Folder;
using HiApp;
using HiApp.Folder.B;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(
                (_, services) =>
                services
                //.AddTransient<IFService, FService>()
                //.AddScoped<IFService, FService>()
                .AddSingleton<IFService, FService>()
                ).Build();

            IFService iFService = host.Services.GetRequiredService<IFService>();
            iFService.F();

            host.RunAsync();
        }
    }
}
