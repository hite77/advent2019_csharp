# advent2019_csharp

mcs to compile
mono to run

https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest

Create top folder
```dotnet new sln```
Create day1 folder
cd day1
dotnet new classlib
rename Class1.cs to Day1.cs
Update contents of Day1.cs
cd ..
dotnet sln add day1/day1.csproj
mkdir day1.Tests
cd day1.Tests
dotnet new mstest
dotnet add reference ../day1/day1.csproj
go to top level folder and
dotnet sln add .\day1.Tests\day1.Tests.csproj

  101  rm -rf day1
  102  ls
  103  mkdir day1
  104  dotnet new sln
  105  ls
  106  pwd
  107  pwd
  108  cd day1
  109  dotnet new classlib
  110  ls
  111  mv Class1.cs Day1.cs
  112  vim Day1.cs
  113  cd ..
  114  dotnet sln add day1/day1.csproj
  115  mkdir day1.Tests
  116  cd day1.Tests
  117  dotnet new mstest
  118  dotnet add reference ../day1/day1.csproj
  119  cd ..
  120  ls
  121  dotnet sln add day1.Tests/day1.Tests.csproj
