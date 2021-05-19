# advent2019_csharp

mcs to compile
mono to run

https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest

Create top folder
```dotnet new sln```

   45  mkdir day2
   46  cd day2
   47  dotnet new sln
   48  dotnet new classlib
   49  mv Class1.cs Day2.cs
   50  vim Day2.cs
   51  cd ..
   52  dotnet sln add day2/day2.csproj
   53  mkdir day2.Tests
   54  cd day2.Tests
   55  dotnet new mstest
   56  dotnet add reference ../day2/day2.csproj
   57  cd ..
   58  dotnet sln add day2.Tests/day2.Tests.csproj
