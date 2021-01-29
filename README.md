#### creation
* dotnet version 5.0.100
* open Visual Studio 2019
* File => New => Project
* select `language=C#`, `project type=Console` click next
* name the project, the solution, choose the location, and uncheck "Place solution and project in the same directory", cause we have multi project to create
* then create four more projects one by one in those types: `.Net Core library`, `MSTest`, `NUnit test`, `XUnit test`
* `dotnet.exe new sln`, `dotnet.exe new console`, could do projects creation either

#### build
dotnet.exe clean && dotnet.exe build

#### test
dotnet.exe test
```
 Determining projects to restore...
...
Test run for D:\work-cs\hello-csharp\HiXUnit\bin\Debug\netcoreapp3.1\HiXUnit.dll (.NETCoreApp,Version=v3.1)
Test run for D:\work-cs\hello-csharp\HiMSTest\bin\Debug\netcoreapp3.1\HiMSTest.dll (.NETCoreApp,Version=v3.1)
Test run for D:\work-cs\hello-csharp\HiNUnit\bin\Debug\netcoreapp3.1\HiNUnit.dll (.NETCoreApp,Version=v3.1)
...
Failed!  - Failed:     1, Passed:     1, Skipped:     0, Total:     2, Duration: 33 ms - HiMSTest.dll (netcoreapp3.1)
Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 35 ms - HiNUnit.dll (netcoreapp3.1)
this is xunit - Console
Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 4 ms - HiXUnit.dll (netcoreapp3.1)
```

#### run
dotnet.exe .\HelloApp\bin\Debug\netcoreapp3.1\HelloApp.dll

#### references
* https://raygun.com/blog/unit-testing-frameworks-c/
* https://xunit.net/docs/getting-started/netcore/cmdline
* https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test