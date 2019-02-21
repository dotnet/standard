# .NET Standard

This repository contains the principles and definition of the .NET Standard.

.NET Standard solves the code sharing problem for .NET developers across all
platforms by bringing all the APIs that you expect and love across the
environments that you need: desktop applications, mobile apps & games, and cloud
services:

* .NET Standard is a set of APIs that all .NET platforms have to implement. This
  unifies the .NET platforms and prevents future fragmentation.
* .NET Standard 2.0 will be implemented by .NET Framework, .NET Core, and
  Xamarin. For .NET Core, this will add many of the existing APIs that have been
  requested.
* .NET Standard 2.0 includes a compatibility shim for .NET Framework binaries,
  significantly increasing the set of libraries that you can reference from your
  .NET Standard libraries.
* .NET Standard will replace Portable Class Libraries (PCLs) as the tooling
  story for building multi-platform .NET libraries.

## How to Engage, Contribute and Provide Feedback

You are also encouraged to start a discussion by filing an issue.

This project has adopted the code of conduct defined by the [Contributor
Covenant](http://contributor-covenant.org/) to clarify expected behavior in our
community. For more information, see the [.NET Foundation Code of
Conduct](http://www.dotnetfoundation.org/code-of-conduct).

## Learning More

Currently defined versions of the .NET Standard can be located in the 
[Versions](docs/versions.md) document.

For more information, check out the [FAQ](docs/faq.md). It should answer any questions 
you have not covered by the versions documentation.

## Build status

|Windows_NT|
|:------:|
|[![Build Status](https://dev.azure.com/dnceng/public/_apis/build/status/dotnet/standard/standard-CI?branchname=master&jobname=Windows_NT)](https://dev.azure.com/dnceng/public/_build?definitionId=235)|
|Linux|
|[![Build Status](https://dev.azure.com/dnceng/public/_apis/build/status/dotnet/standard/standard-CI?branchname=master&jobname=Linux)](https://dev.azure.com/dnceng/public/_build?definitionId=235)|
|OSX|
|[![Build Status](https://dev.azure.com/dnceng/public/_apis/build/status/dotnet/standard/standard-CI?branchname=master&jobname=OSX)](https://dev.azure.com/dnceng/public/_build?definitionId=235)|
