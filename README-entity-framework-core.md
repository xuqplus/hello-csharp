#### add entity framework core dependencies for mysql
```
$ cd HellpApp
$ dotnet add package MySql.EntityFrameworkCore --prerelease
<PackageReference Include="MySql.EntityFrameworkCore" Version="5.0.0-m8.0.23" />
```

#### code changes
reference HelloApp project in HiXUnit project  
add User.cs/UserContext.cs/test classes in HiXUnit project  

#### database and tables creation
```
$ cd HiXUnit
$ dotnet tool install --global dotnet-ef
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```
