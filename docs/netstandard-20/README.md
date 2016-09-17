# .NET Standard 2

This document describes the plan for .NET Standard 2, which includes the
definition of its API surface as well as the principles we use to extend and
review those additions.

## Support Matrix

This table shows which version of .NET Standard 1.x a given platform implements:

|Platform Name              |Alias      |   1.0|   1.1|   1.2|   1.3|   1.4|   1.5|   1.6|
|:--------------------------|:----------|-----:|-----:|-----:|-----:|-----:|-----:|-----:|
|.NET Core                  |netcoreapp |&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|   1.0|
|.NET Framework             |net        |&rarr;|  4.5 | 4.5.1|   4.6| 4.6.1| 4.6.2| vNext|
|Xamarin.iOS                |           |&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|     *|
|Xamarin.Android            |           |&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|     *|
|Universal Windows Platform |uap        |&rarr;|&rarr;|&rarr;|&rarr;|  10.0|      |      |
|Windows                    |win        |&rarr;|   8.0|   8.1|      |      |      |      |
|Windows Phone              |wpa        |&rarr;|&rarr;|   8.1|      |      |      |      |
|Windows Phone Silverlight  |wp         |   8.0|      |      |      |      |      |      |

For .NET Standard 2 we decided to make a breaking change to allow .NET Framework
4.6.1 to support it. More details in [this section](#breaking-change-to-net-standard-1x):

|Platform Name              |Alias      |   2.0|
|:--------------------------|:----------|-----:|
|.NET Core                  |netcoreapp |   1.1|
|.NET Framework             |net        | 4.6.1|
|Xamarin.iOS                |           |     *|
|Xamarin.Android            |           |     *|
|Universal Windows Platform |uap        |      |
|Windows                    |win        |      |
|Windows Phone              |wpa        |      |
|Windows Phone Silverlight  |wp         |      |

## Goals

* **Driving force for consistency**. We want to have an agreed upon set of
  required APIs that all .NET platforms have to implement in order to get access
  to the .NET library ecosystem.

* **Foundation for great cross-platform tooling**. We want a simplified tooling
  experience in Visual Studio and the command line that allows customers to
  target the commonality of all .NET platforms by choosing a single version
  number.

## Customer Scenarios

These are the scenarios we need to be able to support with .NET Standard 2:

* **Wide .NET Standard support**. Stacey builds a .NET Standard-based library.
  She can consume the library from all current platforms.
* **Meet our ecosystem where it is**. Paul can consume an `mscorlib` based
  assembly from a .NET Standard-based library without having to jump through
  hoops.
* **No PCL left behind**. Dakota can consume a PCL based assembly from a .NET
  Standard-based library without having to jump through hoops.
* **Avoid cliffs**. Ariel can extend a .NET Standard-based library to use
  components that aren’t available everywhere without having to cross-compile.

## Requirements

The scenarios above result in these requirements:

* **100% source and binary compatible** surface area for:
    - Classic .NET Framework and Xamarin assemblies (`mscorlib` and friends)
    - Existing portable class libraries (both, mscorlib as well as `System.Runtime`)
* Binary compatibility refers to binding compat, but an understanding that
  **behavioral compatibility may not be 100% possible**.
* We’ll not necessarily bring all the types that .NET Framework has, but that
  **we’ll bring types in their entirety without subsetting members**.
* Focus on APIs that are available everywhere, but
  *allow for platform specific extensions**

## Assembly Unification

Given these requirements, .NET Standard will have to support the following
assembly sets:

* We'll have support for `mscorlib` and friends
* We'll have support for `System.Runtime` and friends

Of course, we can't have two assemblies defining the same type; thus we have to
pick one home for a given type and have the other assembly type forward to it.
At first, it seems quite attractive to have the core assembly called `mscorlib`.
We don't want to use `System.Runtime` as the goal of .NET Standard is to replace
the current version of PCLs and contracts.

However, we can't call the core assembly `mscorlib`. The reason being that we
have two conflicting requirements:

1. We want to be able to consume existing binaries and have the APIs unify in
   .NET Standard, assuming the API is supported in .NET Standard.
2. We also want to be able to model platform specific APIs without forcing
   all platform owners to provide the API.

Let's look at a concrete example. Assume I'm writing a class library that is
targeting .NET Standard. Assume I'm only targeting Windows and thus want to
use the registry. Since the registry is an extension, it sits on top of .NET
Standard. Now I want to reuse a library that was compiled against the .NET
Framework and only uses APIs .NET Standard has, plus the registry. This looks as
follows:

![](unification-mscorlib.png)

Unfortunately, we can't unify `mscorlib!RegistryKey` with `registry!RegistryKey`
as these have different identities.

Fortunately, this conflict can be easily resolved if we call the core assembly
something else, such as `netstandard.dll`:

![](unification-netstandard.png)

***Legend***: *Dotted lines indicate type forwarding, solid lines indicate references*

This frees up the name `mscorlib` in .NET Standard and we can introduce an
assembly that simply type-forwards all its types to the appropriate location:

* Required types go to `netstandard.dll`
* Optional types go to `<extension>.dll`

### Assembly Sets

This means we've logically three assembly sets in .NET Standard:

1. The definition of the .NET Standard `netstandard.dll`
2. Type forwarders for the classic assemblies such as `mscorlib`
3. Type forwarders for the PCL contract assemblies such as `System.Runtime`

The developer will never explicitly have to interact with any of these sets. The
`netstandard.dll` will always be referenced. The build system will automatically
reference the type forwarding assemblies if the developer references a non-.NET
Standard class library.

Please note that the above sets do not include the extensions, such as the
registry. That is intentional. The .NET Standard only includes APIs that are
considered required, and thus must be supported by every platform.

Extensions exist outside of the .NET Standard and must be manually referenced.
This ensures that developers are aware if they start using functionality that
might limit the set of platforms their library can run on. We expect the
extensions to be provided as NuGet packages.

You might wonder how .NET Standard is self-contained if it has type forwarders
to assemblies that aren't part of .NET Standard, i.e. are forwarding to
extensions such as the registry. The answer is that the SDK that makes up the
.NET Standard is in fact not self-contained and points to extension assemblies.
Technically, dangling type forwarders aren't problematic and we have used them
in the past. If the developer references an assembly like above and starts
consuming an API that returns a type that lives in an extension, such as
`RegistryKey`, the compiler will emit an error message like this:

> CS0012: The type 'RegistryKey' is defined in an assembly that is not
> referenced. You must add a reference to assembly 'Microsoft.Win32.Registry,
> Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'

Also, since Visual Studio 2015 Update 3 the Roslyn team added a quick fix that
will suggest missing NuGet packages when a type cannot be resolved. This will
also handle cases like the one above and thus allow the developer to fix the
issue right from the editor without having to know which NuGet package they
need. The key point is that developer will have to take an explicit action to
make the project less portable.

We'll provide another document that goes into more detail on how the user
experience in Visual Studio can be improved to make developers aware of
portability issues.

## Breaking Change to .NET Standard 1.x

Our goal for .NET Core is to significantly extend its surface area so that more
functionality can be shared across all the .NET flavors. This mostly means
filling in existing APIs as .NET Core didn't bring those when it was created.

This allows us to make .NET Standard much bigger. Unfortunately, some of the
existing .NET flavors do not support all the APIs we have already added since
.NET Standard 1.5. We've two options:

1. We can update the existing platforms to include those APIs
2. Perform a breaking change in .NET Standard and remove those APIs from .NET
   Standard 2 and re-introduce them in a later version of .NET Standard.

At first, it seems much more logical to go with option (1). Unfortunately,
updating existing platforms means shipping a new version of that platform.
This doesn't help our adoption problem as those new platforms aren't necessarily
available to target in all circumstances. This is in particular true for .NET
Framework.

At the time we ship .NET Standard 2 we expect .NET Framework 4.6.1 to have
enough adoption to make this a viable prerequisite for .NET Standard 2.

[This document](NetStandardAPIs_MissingFromPlatforms.md) inlcudes all the APIs
that are available in .NET Standard 1.6 but aren't implemented yet in:

* [.NET Framework 4.6.1](NetStandardAPIs_MissingFromPlatforms.md#missing-from-net-framework-461)
* [Xamarin iOS](NetStandardAPIs_MissingFromPlatforms.md#missing-from-ios)
* [Xamarin Android](NetStandardAPIs_MissingFromPlatforms.md#missing-from-android)

Since updating the Xamarin platforms is mostly an SDK problem (since the .NET
plaform doesn't ship with iOS or Android itself) we hope we can update those
platform to simply include those missing APIs. But as outlined above, this isn't
a viable plan for .NET Framework so we plan on removing the APIs from .NET
Standard 2 that [.NET Framework 4.6.1 doesn't implement](NetStandardAPIs_MissingFromPlatforms.md#missing-from-net-framework-461).

We ran an analysis of all packages on NuGet.org that target .NET Standard and
use any of these APIs. At time of this writing we only found six non-Microsoft
owned packages that are impacted. We'll reach out to those package owners and
work with them to mitigate the issue.

The mitigation for these packages is as follows:

* If they absolutely require the APIs, they will have to require .NET Standard
  2.1.
* If they can replace the dependency with other APIs we added in .NET Standard
  2, they can cross-compile and add a specific target to .NET Standard 2 and
  continue to support .NET Standard 1.x.

## Inclusion Principles

In order to decide which APIs will be required by .NET Standard we use the
following principles:

1. All types that are part of the intersection between .NET Framework,
   Xamarin.iOS, and Xamarin.Android are subject to be added to .NET Core.
   Please note that this doesn't mean that these types will become part of
   .NET Standard.

2. APIs that should be required need to be exposed in `netstandard.dll`.

3. Problematic and legacy technologies that we only want to provide for
   backwards compatibility default to being optional components. That means a
   separate assembly per component that sit on top `netstandard.dll`.

4. Any members on types added in (1) and (2) that prevent (3) are subject to be
   removed.

5. All removals in (4) will be reviewed by the .NET Standard's body

## Composition

Based on the list of assemblies that are part of the intersection we're
currently aiming to cover the following assemblies as part of .NET Standard:

| Included                         | Excluded                              |
| -------------------------------- |---------------------------------------|
| Microsoft.CSharp                 | System.ComponentModel.Composition     |
| mscorlib                         | System.ComponentModel.DataAnnotations |
| System                           | System.Data                           |
| System.Core                      | System.Data.Services.Client           |
| System.Drawing                   | System.Data.SqlXml                    |
| System.IO.Compression            | System.ServiceModel                   |
| System.IO.Compression.FileSystem | System.ServiceModel.Web               |
| System.Net                       | System.Transaction                    |
| System.Net.Http                  | System.Web                            |
| System.Numerics                  | System.Web.Services                   |
| System.Runtime.Serialization     |                                       |
| System.Xml                       |                                       |
| System.Xml.Linq                  |                                       |

**Please note:** Just because an assembly is marked as excluded doesn't mean
it's not available on .NET Core. It simply means it's not part of .NET Standard
and thus .NET platforms supporting .NET Standard aren't obligated to provide
implementations for those.

To the included assemblies we applied the following steps:

* Filter to just types
    - Assumption is that if a type is included all members are also included
* Mark Types:
    - **No**. These are things we shouldn’t include
    - **Required**. These are required APIs in .NET Standard
    - **[Feature]** These are buckets for features we should probably make as
      optional extensions as opposed to required.

This is how it looks like at a high level:

| Component       | # Types |
|-----------------|--------:|
| No              |      19 |
| Required        |   1,939 |
| AppDomain       |       8 |
| CAS             |     201 |
| RefEmit         |      23 |
| Registry        |       2 |
| Remoting        |     142 |
| WindowsIdentity |       3 |

Our plan is to review the actual reference assemblies with the .NET Standard
review body.

More details about our classification can be found in
[this document](netstandard-20-apis.md).
