# .NET Standard governance

The .NET Standard represents the set of APIs that all .NET implementations have
to provide. Over time, this list has to grow but it's critical that the set
remains implementable by all current and future .NET implementations.

To ensure that's the case, there is a formal process for proposing and accepting
APIs into the .NET Standard. This document outlines the process.

## Review board

Today, we have several different .NET implementations:

* .NET Core
* .NET Framework
* Mono
* Unity
* Xamarin

Some of them have drastically different constraints, based on their runtime
environment (for instance, Xamarin for iOS cannot perform runtime code
generation, based on Apple's app store policy).

To ensure we don't end up adding large chunks of API surface that cannot be
implemented, we have a review board that has to sign-off on API additions to
the .NET Standard. The board is comprised of representatives from the following
groups:

  * **.NET platform**. The rationale here is that most, if not all, of the APIs
    that are part of .NET Standard are implemented and evolved by the .NET
    platform team.
  * **Xamarin & Mono**. While Mono mostly copy code from .NET Framework & .NET
    Core base class library, changes and extensions can impact their ability to
    support the .NET Standard. Thus, we need to coordinate any changes with
    Mono.
  * **Unity**. Same rationale as for Xamarin & Mono.

The chairman of the review board is [@migueldeicaza](https://github.com/migueldeicaza).
For the most part, we strive to make decisions based on consensus, but as it is
with every group of engineers, consensus can be impossible to achieve at times
so we need to have an ultimate tie breaker. And Miguel has a lot of expertise
and experience building .NET implementations that are supported by multiple
parties.

Please note that the member list isn't meant to be closed: as more platform
vendors and API drivers appear, the review board will expand accordingly.

## Process

* **Anybody can submit proposals** for API additions to the .NET Standard.
  Those will be tracked as issues and labeled with the [netstandard-api] label.
* **Acceptance requires**
  - A **sponsorship from a board member**. That person will be assigned the
    issue and is expected to shepard the issue until it's easier accepted or
    rejected.
  - A **prototypic implementation** in at least one .NET implementation. The
    implementation must be open source so that other .NET implementations can
    easily jump-start their own implementations or take it as-is.
* **.NET Standard updates are planned** and will generally follow a set of
  themes. We avoid grab-bag releases of .NET Standard and instead try to define
  a set of goals that describe what kind of feature areas a particular .NET
  Standard version provides. This simplifies answering the question which .NET
  Standard a given library should depend on. It also makes it easier for .NET
  implementations to decide whether it's worth implementing a higher version of
  .NET Standard.
* **The version number** is subject to discussion and is generally a function of
  how significant the new version is. While we aren't planning on making
  breaking changes, we'll rev the major version if the new version adds large
  chunks of APIs or has sizable changes in the overall developer experience.

[netstandard-api]: https://github.com/dotnet/standard/issues?q=is%3Aopen+is%3Aissue+label%3Anetstandard-api

## Inclusion principles

Not every .NET API needs (or even should be) part of the .NET Standard.

If a library is written in pure IL (for example C#, VB.NET, F# etc.), and
targets .NET Standard, then it can run across all current and future .NET
implementations with no code changes. The only requirement on the .NET
implementation is that it has to support at least the version of .NET Standard
that the library was compiled for (or a higher version).

Any modification to such a library, whether it's bug fixes, performance
improvements, or additional APIs, will also work across all these .NET
implementations as well. That means the library author has flexibility to make
releases on their own cadence while consumers of the library have the choice on
when they upgrade the version they are using. If the library is made a part of
.NET Standard, it can only version at the same cadence as the standard, so the
update flexibility is much reduced.

On the other hand, there are also downsides for APIs not being part of the
standard. If an API ships as a library, it's much harder for any .NET
implementation to use the types as part of their implementation or public API
surface. Hence, there is a lot of value in adding widely used concepts to the
.NET Standard in order to use them throughout all .NET implementations.

The following criteria helps us to identify APIs that should be part of .NET
Standard:

* **Ubiqutous APIs**. APIs in the .NET Standard must be implemented by all .NET
  implementations. Thus, we're only interested in standardizing APIs that are
  universal in nature and thus should be available everywhere.

* **Mature APIs**. APIs that are part of the .NET Standard can only be versioned
  when the standard itself is versioned. Thus, we generally only standardize
  APIs that are mature enough that they don't have to be updated frequently.
  This implies that we will never add APIs that aren't stable yet.

* **Runtime-specific APIs**. If the APIs have to be implemented by the runtime,
  they don't benefit from being libraries on top of .NET Standard. Good examples
  of such APIs include primitive types, reflection, GC, and hardware intrinsics.

* **Widely-used APIs**. In order to enable a vibrant .NET ecosystem, it's
  important to have a common vocabulary of types that library authors can rely
  on. Thus, it's beneficial to add widely used APIs to the .NET Standard as it
  simplifies building reusable libraries with a minimal number of dependencies.