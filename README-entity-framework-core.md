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

#### differences between ObjectContext vs DbContext
functionally and conceptually speaking, are both like `Repository` in JPA  
ObjectContext provides:
* Database connection
* Builtin Add, Update and Delete functions
* Object Set of every entity
* Provide State of pending changes
* It holds the changes done in entities
* under namespace System.Data.Entity.Core.Objects

DbContext:
* is nothing but a ObjectContext wrapper
* is a lightweight alternative choice
* under namespace System.Data.Entity

comparison link  
https://www.c-sharpcorner.com/UploadFile/ff2f08/objectcontext-vs-dbcontext/  
api references  
https://docs.microsoft.com/en-us/dotnet/api/?view=entity-framework-6.2.0  
https://docs.microsoft.com/en-us/dotnet/api/?view=efcore-5.0
