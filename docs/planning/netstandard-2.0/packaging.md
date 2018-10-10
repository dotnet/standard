# Packaging for .NET Standard 2.0

This document outlines how packaging for .NET Standard 2.0 will work. This
covers package layout, versioning semantics, compatibility with existing
packages, and how package consumption will work.

## Requirements

* **Simple**. In order to be understandable, we want the .NET Standard package
  graph to be extremely simple, ideally a single package.
* **Cumulative**. Upgrading this package should never result in changes of
  platform compatibility or API surface.
* **Packages don't need to depend on the .NET Standard package**. This makes
  building packages that target .NET Standard similar to how it works for other
  .NET platforms (such as .NET Framework).
* **Independent from platform implementations**. The .NET Standard package
  shouldn't need to know about the platforms implementing the standard. This
  avoids having to update the .NET Standard package every time a platform is
  updated or added.
* **Compatible with .NET Standard 1.x**. The package for .NET Standard 2.0 needs
  to work with packages that were built against .NET Standard 1.x.

## Experience

Moving forward we plan on having two types of packages:

* **Platform packages**. These are monolithic packages that represent a given
  .NET platform. This includes .NET Core (`Microsoft.NETCore.App`) as well as
  .NET Standard (`NETStandard.Library`).

* **Library packages**. These are libraries that target .NET Standard and are
  thus shared components across all .NET platforms. This includes some `System`
  packages (such as `System.Collections.Immutable`) but also includes all other
  libraries on NuGet (such as `Newtonsoft.Json`).

*Platform packages* will be referenced by projects but not by packages (except
for very specialized tooling packages). Instead, *library packages* will express
their dependency on the platform by the folder name convention that already
exists today, such as `lib/net45` and `lib/netstandard16`.

The version of the platform package represents the version of its
implementation, not the API surface. For example, it's possible to depend on the
latest version of a platform package and still target an earlier version. That's
because projects express them as separate pieces of configuration:

* The `<TargetFramework>` property (and also `<TargetFrameworks>` if you compile
  for multiple frameworks). This expresses which version of the API surface you
  can target.

* The `<PackageReference />` item. Expresses which version of the platform
  package you are using.

Since platform packages are cumulative, you can always upgrade to the latest
version and continue to target the current version. This is especially useful
for .NET Standard, as the API version controls on which platforms you can run.

> ***Note***: You might ask yourself what *implementation* means for the .NET
> Standard package since it's an API spec but not an actual implementation. The
> package also contains tooling support, for example, the list of available .NET
> Standard versions and, in some cases, even the necessary support for targeting
> existing .NET platforms that were shipped before a given version of .NET
> Standard. So in that context *implementation* includes tooling.

Below are the examples how the project files for .NET Standard and .NET Core
might look like:

**.NET Standard**

```xml
<Project>
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" />
  <PropertyGroup>
    <OutputType>Library</OutputType>
    <TargetFramework>netstandard1.6</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="**\*.cs" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="NETStandard.Library" Version="2.1.3" />
    <PackageReference Include="Microsoft.NET.SDK" Version="1.0.0" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

**.NET Core**

```xml
<Project>
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" />
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp1.0</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="**\*.cs" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.NETCore.App" Version="1.0.0" />
    <PackageReference Include="Microsoft.NET.SDK" Version="1.0.0" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

## Compatiblity with .NET Standard 1.x

The reference assemblies for .NET Standard 1.x use a fine grained factoring.
These assemblies are also shared with .NET Core.

To represent .NET Standard 1.x we use the NuGet package `NETStandard.Library`.
This package is a *meta package* which means it's empty, but in turn depends
on the set of packages that make up .NET Standard. The result looks like this:

    NETStandard.Library_1.3
        ├───System.Runtime_4.1.0
        ├───System.Security.Cryptography.Algorithms_4.2.0
        ├───System.Security.Cryptography.Encoding_4.0.0
        ├───System.Security.Cryptography.Primitives_4.0.0
        ├───System.Security.Cryptography.X509Certificates_4.1.0
        ├───System.Text.Encoding.Extensions_4.0.11
        ├───System.Text.Encoding_4.0.11
        ├───System.Text.RegularExpressions_4.1.0
        ├───System.Threading.Tasks_4.0.11
        ├───System.Threading.Timer_4.0.1
        ├───System.Threading_4.0.11
        ├───System.Xml.ReaderWriter_4.0.11
        ├───...
        └───System.Xml.XDocument_4.0.11

Since we want to decouple .NET Standard from .NET Core, we decided to go with a
different assembly set for .NET Standard 2.0, namely a monolithic assembly
called `netstandard.dll` which contains the entirety of .NET Standard.

In order to stay compatible with .NET Standard 1.x, the fine grained assemblies
need to type forward to `netstandard.dll` when they are consumed from .NET
Standard 2.0. Logically, this requires the following steps:

1. .NET Standard 2.0 has newer versions of the fine grained assemblies that
   type forward to `netstandard.dll`

2. When consuming .NET Standard 1.x binaries from 2.0, references to the fine
   grained assemblies are unified with the higher versions in .NET Standard 2.0
   so that the type forwarding versions are used.

We could use NuGet to model this:

1. We'd have to ship updates to all the fine grained packages to include a type
   forwarding facade for .NET Standard 2.0.

2. To ensure these higher versions are used, the package for .NET Standard 2.0
   has to continue to depend on the fine grained packages so that it can express
   the dependency on the higher version that has the type forwarding facade.

However, we'd like to stop using these fine grained packages for both, .NET
Standard as well as .NET Core:

* **.NET Standard**. Since .NET Standard 2.0 no longer uses the fine grained
  factoring, we don't want to continue to depend on the fine-grained
  `System.Runtime` based packages.

* **.NET Core**. While the `System.Runtime` based factoring will continue to be
  used for .NET Core we don't expect .NET Core to ship these assemblies as
  individual packages either. Instead, we'd like to follow .NET Standard and
  ship a monolithic package that contains most of the .NET Core assembly set.

In order to solve this problem, we'll instead:

* Ship the type forwarding facades directly in the `NETStandard.Library`
  package.
* Add a feature to MSBuild that allows resolving conflicts when multiple
  packages provide a given assembly. This is outlined in more detail in the
  section [MSBuild conflict resolution](#msbuild-conflict-resolution).

### Which assemblies and packages does .NET Standard 2.0 need to be compatible with?

As outlined in the [spec for .NET Standard 2.0][netstandard-spec] we need to be
compatible with two major assembly sets:

1. `mscorlib`-based assemblies
2. `System.Runtime`-based assemblies

These come from the following sources:

1. Any assemblies that are part of .NET Framework and Portable Class Libraries
   that contain types that are also in .NET Standard 2.0.
2. All assemblies that are part of `NETStandard.Library` 1.x
3. All assemblies that are outside of `NETStandard.Library` 1.x but contain
   types that are also in .NET Standard 2.0.

Please note that (3) implies that our package compatibility also has to support
packages that are outside of the closure of `NETStandard.Library` 1.x.

Packaging wise, this translates to the following list of packages we need to be
compatible with:

* `NETStandard.Library`. Since we plan to continue to use this package ID,
  that's trivially fulfilled.
* `Microsoft.Portable.Compat`. This package provided PCL reference support for
  both .NET Standard 1.x and .NET Core.
* `System.*`. We don't need to be compatible with all of them, but only the ones
  that include the assemblies listed above.

## Compatiblity with .NET Core vNext

The expectation is that .NET Core vNext has built-in support for .NET Standard
2.0, that is it directly includes the type forwarding facade `netstandard.dll`.

For .NET Core 1.x, the `Microsoft.NETCore.App` package has a dependency on the
`NETStandard.Library`. We want to continue doing this for .NET Standard 2.0
because it will "lift" package references to .NET Standard 1.6 to 2.0. This will
simplify the package graph. It also provides a clear indicator of what version
of .NET Standard it supports.

However, the `NETStandard.Library` 2.0 package will contribute *zero* assets to
`netcoreapp1.2` because the facade for `netstandard.dll` is provided by
`Microsoft.NETCore.App`.

## Compatiblity with .NET Framework 4.6.1

Even in the upcoming version of Visual Studio ("Dev15"), the NuGet story for
.NET Framework continues to be based on `packages.config`. This means that NuGet
will add `<Reference>` elements to the project for each assembly that is part of
a package.

For .NET Standard 2.0, the set of referenced assemblies is quite large because
it has to provide type forwarders for both, the new `netstandard.dll` as well as
the old .NET Standard 1.x contract assemblies.

This would mean that adding a reference to the `NETStandard.Library` package
into a .NET Framework 4.6.1 project would end up adding hundreds of
`<Reference>` elements to the project file, which is very noisy and thus a bad
experience.

To avoid this, we'll inject a single MSBuild `.targets` file that contains
static references to all these assemblies.

### Layout of .NET Standard (`NETStandard.Library`)

In order to simplify packaging updates, we'll continue to make the
`NETStandard.Library` package cumulative, which means it contains the assets for
all previous .NET Standard versions. This makes it safe to always update this
package to the latest version without losing support for platforms. However, we
don't want to have to download the entire history of .NET Standard every time,
which is why we'll split the package by TFM:

    NETStandard.Library
        ├───NETStandard.Library10
        ├───...        
        ├───NETStandard.Library16
        └───NETStandard.Library20

The idea is that we have a package whose ID is tied to a specific version of
.NET Standard. Those packages are unlisted on NuGet and shouldn't be referenced
by anyone, except the `NETStandard.Library` package which has a TFM specific
dependency on those. For instance, the dependency on `NETStandard.Library16`
is specific to the `netstandard16` TFM.

So when running package restore for `netstandard16`, NuGet will only download
two packages, `NETStandard.Library` as well as `NETStandard.Library16`. When the
developer changes the TFM to `netstandard20` it will trigger another package
restore which will then download `NETStandard.Library20` package instead.

Each of the `NETStandard.LibraryXX` packages will have a structure like this:

* `ref/netstandard{version}`
    - Contains `netstandard.dll` reference assembly
    - Contains `System.Runtime`-based facades, type forwarding to `netstandard.dll`
    - Contains `mscorlib`-based facades, type forwarding to `netstandard.dll`
* `ref/{platform}`
    - Contains the placeholder `_._` so that no other platforms gets any compile
      time assets as they are supposed to be provided by the platform.
    - We will omit version in the TFM (effectively using 0) to avoid having to
      rev this package every time the platform ships a new version

For `NETStandard.Library20` we'll have to add the following additional assets
in order to provide the support for .NET Framework 4.6.1:

* `ref/net461`
    - Contains the placeholder `_._` so that no assets are inserted by NuGet for
      .NET Framework 4.6.1
* `tools/net461`
    - Contains a single `netstandard.targets` file that provides reference items
      to all the facades
    - Contains `netstandard` facade, type forwarding to `mscorlib.dll`
    - Contains `System.Runtime`-based facades, type forwarding to `mscorlib.dll`     

### Layout of contract packages (`System.*`)

Our goal is to discontinue the existing fine-grained contract packages we have
been using for .NET Standard 1.x as well as for .NET Core.

We don't plan to update these packages. Instead we'll rely on [MSBuild conflict
resolution](#msbuild-conflict-resolution) for package graphs that include the
old packages.

## Layout of out-of-band packages (e.g. `System.Collections.Immutable`)

Components that don't have APIs that ship with any platform (i.e. are fully
out-of-band) will remain as individual packages. We'll update them to target
.NET Standard so that they can be used across all .NET platforms.

### Layout of PCL Compat package (`Microsoft.Portable.Compat`)

Similar to the existing `System.*` packages this package will be discontinued as
it's replaced by `NETStandard.Library`.

We don't plan to update this package. Instead we'll rely on [MSBuild conflict
resolution](#msbuild-conflict-resolution) for package graphs that include this
package.

### Layout of `Microsoft.NETCore.App`

* Has a dependency to `NETStandard.Library` 
* `ref/netcoreapp{vNext}`
    - Contains `netstandard.dll` facade type forwarding to `System.Runtime`
    - Contains `mscorlib`-based facade type forwarding to `System.Runtime`
    - Contains `System.Runtime`-based reference assemblies
* No implementations
    - All implementation pieces are in RID-specific packages
    - The implementation will contain pieces we don't expose to the developer
      (i.e. Roslyn, Immutable, native LibUV)
    - They continue to live in OOB packages the developer has to add a reference
      to

## MSBuild conflict resolution

Currently, we assume that a given package graph will not produce assembly assets
with the same simple name but with different versions. That holds true because
we ensure that a given framework assembly ships only in one package. This way,
the unification is performed by NuGet as a side-effect of package unification.

However, since we don't want to ship granular packages for the .NET platform,
we need to deal with situations where multiple packages contain the same
assembly.

We need to have logic in MSBuild that deals with that situation. The idea would
be that:

1. If multiple packages provide the same assembly but in different versions, we
   should unify them to the highest version.
2. If multiple packages provide the same version of an assembly, we should
   prefer the ones coming from a package marked as a *platform package*. If no
   such package exist, it should result in a build time warning or even an
   error.

We currently don't have the notion of a platform package, but intuitively these
are packages like `NETStandard.Library` and `Microsoft.NETCore.App`. It's likely
that these packages already have to provide static MSBuild metadata that
specifies which target framework versions (TFVs) it provides. We could designate
that metadata as the indicator for being a platform package.


[netstandard-spec]: README.md
