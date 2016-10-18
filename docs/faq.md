# .NET Standard FAQ

*Something missing? [File an issue][issue].*

## What are good resources to learn about .NET Standard?

* [Documentation][netstandard-docs]
* [Introducing .NET Standard][netstandard-post] blog post
* [Intro to .NET Standard](https://channel9.msdn.com/Blogs/Seth-Juarez/What-is-NET-Standard) video
* [Q&A](https://channel9.msdn.com/Shows/On-NET/Immo-Landwerth-Net-Standard) video

## What is .NET Standard?

.NET Standard is a specification that represents a set of APIs that all .NET
platforms have to implement. This unifies the .NET platforms and prevents future
fragmentation. Think of .NET Standard as POSIX for .NET.

Having a standard solves the code sharing problem for .NET developers by
bringing all the APIs that you expect and love across the environments that you
need: desktop applications, mobile apps & games, and cloud services.

For more details, take a look at [Introducing .NET Standard][netstandard-post]
blog post.

## The blog post has 15 pages. Why so complicated?

The general idea of .NET Standard is pretty simple indeed. The [blog
post][netstandard-post] is a bit longer because it also provides more context in
related areas, specifically how we use .NET Standard in tooling, which additions
we're making in .NET Standard 2.0, how we model platform specific APIs, and what
.NET Standard means for .NET Core.

## I still don't get it. Can you provide an analogy that makes sense for a dev?

David Fowler provided a [developer analogy][netstandard-analogy] that explains
.NET Standard in terms of interfaces and classes.

## How is .NET Standard different from .NET Core?

Here is the difference:

* .NET Standard is a specification that covers which APIs a .NET platform has to
  implement.
* .NET Core is a concrete .NET platform and implements the .NET Standard.

## What APIs are part of .NET Standard and which platforms support it?

We have a [version document][netstandard-versions] that points you to the
platform support matrix as well as which APIs are available in a given .NET
Standard version.

## As a library author, which version of .NET Standard should I target?

When choosing a [.NET Standard version][netstandard-versions] you should
consider this trade-off:

* The higher the version, the more APIs are available to you.
* The lower the version, the more platforms you can run on.

So generally speaking, you should target the lowest version you get away with.
The [version document][netstandard-versions] will help inform your decision.

## How does .NET Standard versioning work?

Think of the .NET Standard versions as concentric circles: higher versions
incorporate all APIs from previous versions.

From a project that targets .NET Standard *version x* you'll be able to
reference other libraries and NuGet packages that reference .NET Standard from
1.0 up to, and including, *version X*. For example, when you target .NET
Standard 1.6, you'll be able to use packages that are targeting any version from
.NET Standard 1.0 up to 1.6. However, you'll not be able to use a package that
is targeting a higher version, for example, .NET Standard 2.0.

From a project that is targeting a specific .NET platform, the .NET Standard
versions you can reference depends on which version of .NET Standard the
platform [is implementing][netstandard-versions].

Starting with .NET Standard 2.0 we also enable referencing binaries compiled
for .NET Framework through a [compat shim][netstandard-spec].

## How does .NET Standard work with Portable Class Libraries (PCLs)?

Certain PCL profiles are mapped to .NET Standard versions. The mapping can be
found in [our documentation][netstandard-docs].

For profiles that have a mapping, these two library types will be able to
reference each other.

## What about the breaking change between .NET Standard 1.x and 2.0?

Based on community feedback, we decided not to make .NET Standard 2.0 be a
breaking change from 1.x. Instead, .NET Standard 2.0 is a strict superset of
.NET Standard 1.6. The plan for handling .NET Framework 4.6.1 and .NET Standard
2.0 is outlined in the [spec][netstandard-461].

## If there is no breaking change, why call it .NET Standard 2.0?

We think [.NET Standard 2.0][netstandard-spec] is such a large change that
bumping the major version is justified:

* We more than doubled the API surface
* We added a compat shim that allows referencing existing binaries, even if
  they weren't built against .NET Standard or Portable Class Libraries

| Version |  #APIs | Growth % |
|:--------|-------:|---------:|
| 1.0     |  7,949 |          |
| 1.1     | 10,239 |     +29% |
| 1.2     | 10,285 |      +0% |
| 1.3     | 13,122 |     +28% |
| 1.4     | 13,140 |      +0% |
| 1.5     | 13,355 |      +2% |
| 1.6     | 13,501 |      +1% |
| 2.0     | 32,638 |    +142% |

## Is the API set of a .NET Standard version fixed?

Yes. A specific version of .NET Standard remains frozen once shipped. New APIs
will first become available in specific .NET platforms, such as .NET Core. If we
believe the new APIs should be made available everywhere, we'll create a new
.NET Standard version.

## Is .NET Standard specific to C#?

There is nothing language specific about .NET Standard. From a language view
point, the only tie-in to .NET Standard are the language-specific runtime APIs
(for example `Mirosoft.CSharp`, `Microsoft.VisualBasic`, `FSharp.Core` etc.) and
the project templates that allow you to target .NET Standard.

We don't plan to add any language-specific runtime APIs to .NET Standard. The
expectation is that they sit on top of .NET Standard and are referenced as
needed, for example, from the project template.

## Is `AppDomain` part of .NET Standard?

The `AppDomain` type is part of .NET Standard. Not all platforms will support
the creation of new app domains, for example, .NET Core will not, so the method
`AppDomain.CreateDomain` while being available in .NET Standard might throw
`PlatformNotSupportedException`.

The primary reason we expose this type in .NET Standard is because the usage is
fairly high and typically not associated with creating new app domains but for
interacting with the current app domain, such as registering an unhandled
exception handler or asking for the application's base directory.

## Is `MarshalByRefObject` (remoting) part of .NET Standard?

We don't plan to add remoting support to .NET Standard. However, in order to
avoid potential breaking changes, we'll have the `MarshalByRefObject` type as
many other types derive from it but we will not expose any remoting-specific
members on it, such as `CreateObjRef`.

## Is `System.Data` part of .NET Standard?

.NET Standard will contain the abstractions (`DbProvider`,
`DbProviderFactories`, `DbConnection`, `IDbConnection` etc.) as well as the
general ADO.NET facilities (`DataSet`, `DataTable` etc.) APIs.

We don't plan on adding any specific providers to .NET Standard as their
applicability varies (for example, it's a highly unlikely scenario to use the
SQL Server client from an iOS device, but it would make sense to use a provider
that can store data on the device, such as SQLite). The expectation is that
those sit on top of .NET Standard or remain platform-specific.

## Why is JSON.NET not part of .NET Standard?

Today, one of the most popular libraries for dealing with JSON is JSON.NET. But
by adding it to the .NET Standard we'd do the community a disservice. What
matters is that the JSON support is widely available. And James, the author of
JSON.NET, does a great job making sure that JSON.NET is available everywhere.
His ability to do this successfully is a function of how hard it is for him to
make changes. The best way to do this is by creating a library that targets .NET
Standard because it can be updated independently from the standard itself and
everyone immediately benefits.

Of course, this doesn't mean we can't or shouldn't provide some built-in JSON
support. We've talked with James about this in the past and I believe there is a
lot of opportunity for us to collaborate with him on an even more performant way
to provide JSON support in .NET. However, we're very interested in doing this
with him rather than just building "another" JSON.NET. We want a strong
ecosystem for .NET, but this can only happen if we embrace libraries based on
merit, rather than by who wrote it. That's what open source is all about.

## Why is XYZ not part of .NET Standard?

As explained in the JSON.NET example above, there is a trade-off between adding
components to .NET Standard and having components that are on top of .NET
Standard and can be updated independently.

Check out the [.NET Standard inclusion principles][netstandard-principles] to
see how we approach this.

## Why do you include APIs that don't work everywhere?

We generally don't include APIs in .NET Standard that don't work everywhere, and
instead provide them as libraries that sit above .NET Standard.

But if you think about it: we can't make *type members* (for example, methods,
properties, etc.) additive. The only thing you can make additive are *types*, as
two different types can live in separate assemblies but we don't have a
mechanism to split a single type across two different assemblies. In those
cases, we leave the members on the type and let platforms that cannot
meaningfully implement them throw `PlatformNotSupportedException`.

Moving forward, we try to avoid creating types where only parts of it work
everywhere. But as always, there will be cases where we couldn't predict the
future and are forced to throw.

## Will there be tooling to highlight APIs that don't work everywhere?

Our current focus is on providing APIs either as part of .NET Standard or as
independent packages that sit on top of .NET Standard. In some cases, certain
APIs will not be supported everywhere and throw `PlatformNotSupportedException`.
While that isn't ideal, it's much simpler than the alternatives, which are:

* Using `#if`, also called cross-compiling
* Write complicated reflection code, also called runtime light-up

A simple `if` statement with a platform check is much easier to express. Of
course, there are limits to this. Exceptions are only acceptable for corner
cases to avoid the complexities above. We will generally not expose large set of
APIs that aren't supported.

In the future, my hope is that we can provide tooling to help you with this, by,
for example, providing Roslyn analyzers that can give you squiggles in the IDE.

## Will Unity implement .NET Standard?

Yes. We're working with Unity to make sure this is a smooth experience. In
general, since Unity is a fork of Mono it will mostly get .NET Standard support
for free. The work to support Unity is mostly in tooling.

## I saw your video and I like your watch. What is it?

It's a Garmin Forerunner 920, a triathlon watch. Sadly, my watch is fitter than
I am :-)

## When will Visual Studio support creating .NET Standard libraries?

The upcoming version of Visual Studio ("Dev15") will support the creation of
.NET Standard Libraries, including building NuGet packages.

## When will Xamarin Studio support creating .NET Standard libraries?

The upcoming version of Xamarin Studio will support this.

## What's the difference between .NET Standard Library and .NET Platform Standard?

These were terms we used in earlier discussions. We only have one concept today
called *.NET Standard*.

## Can you explain the assemblies and type forwarding in more detail?

Yes. For now, take a look at the [.NET Standard 2.0 spec][netstandard-spec], as
it has some diagrams.

[netstandard-docs]: https://docs.microsoft.com/en-us/dotnet/articles/standard/library
[netstandard-post]: https://blogs.msdn.microsoft.com/dotnet/2016/09/26/introducing-net-standard/
[netstandard-spec]: netstandard-20/README.md
[netstandard-analogy]: https://gist.github.com/davidfowl/8939f305567e1755412d6dc0b8baf1b7
[netstandard-versions]: versions.md
[netstandard-targeting]: versions.md#how-do-i-know-which-net-standard-version-i-should-target
[netstandard-principles]: review-board/README.md#inclusion-principles
[netstandard-461]: netstandard-20/README.md#net-framework-461-supporting-net-standard-20
[issue]: https://github.com/dotnet/standard/issues/new
