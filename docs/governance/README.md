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
implemented, we have a [review board](board.md) that has to sign-off on API
additions to the .NET Standard. The board comprises representatives from the
following groups:

  * **.NET platform**. The rationale here is that most, if not all, of the APIs
    that are part of .NET Standard are implemented and evolved by the .NET
    platform team.
  * **Xamarin & Mono**. While Mono mostly copies code from the .NET Framework &
    .NET Core base class libraries, changes and extensions can impact their
    ability to support the .NET Standard. Thus, we need to coordinate any
    changes with Mono.
  * **Unity**. Same rationale as for Xamarin & Mono.
  * **.NET Foundation**. A set of people selected by the .NET Foundation that
    represent the interests of the .NET community at large, which also includes
    pure consumers of the .NET Standard.

The chairman of the review board is [@migueldeicaza](https://github.com/migueldeicaza).
For the most part, we strive to make decisions based on consensus, but as it is
with every group of engineers, consensus can be impossible to achieve at times
so we need to have an ultimate tie breaker. And Miguel has a lot of expertise
and experience building .NET implementations that are supported by multiple
parties.

For a current member list, see [.NET Standard Review Board](board.md).

## Process

* **Anybody can submit proposals** for API additions to the .NET Standard.
  Those will be tracked as issues and labeled with the [netstandard-api] label.
* **We'll track features, not individual APIs**. In order to keep bookkeeping we
  generally will usually file an issue per feature, rather than per API. The
  issue description will then contain the APIs that should be added.
* **New members on standardized types are automatically considered**. To prevent
  accidental fragmentation, we'll automatically consider all members added by
  any .NET implementation on types that are already in the standard. The
  rationale here is that divergence at that the member level is not desirable
  and unless there is something wrong with the API it's likely a good addition.
* **Acceptance requires**
  - A **sponsorship from a board member**. That person will be assigned the
    issue and is expected to shepherd the issue until it's either accepted or
    rejected. If no board member is willing to sponsor the proposal, it's
    considered rejected.
  - A **stable implementation** in at least one .NET implementation. The
    implementation must be licensed under an open source license that is
    compatible with MIT. This will allow other .NET implementations to jump-
    start their own implementations or simply take the feature as-is.
* **.NET Standard updates are planned** and will generally follow a set of
  themes. We avoid releases with a large number of tiny features that aren't
  part of a common set of scenarios (we call them "grab-bag-style releases").
  Instead, we try to define a set of goals that describe what kind of feature
  areas a particular .NET Standard version provides. This simplifies answering
  the question which .NET Standard a given library should depend on. It also
  makes it easier for .NET implementations to decide whether it's worth
  implementing a higher version of .NET Standard.
* **The version number** is subject to discussion and is generally a function of
  how significant the new version is. While we aren't planning on making
  breaking changes, we'll rev the major version if the new version adds large
  chunks of APIs or has sizable changes in the overall developer experience.

[netstandard-api]: https://github.com/dotnet/standard/issues?q=is%3Aopen+is%3Aissue+label%3Anetstandard-api

## "In the standard" vs "on top of the standard"

The .NET Standard represents a set of fundamental APIs that are largely independent
of the type of application you're building.

People often ask us what the difference is between an API that is *part of the
.NET Standard* (such as `XmlReader`) and an API that is *available for the .NET
Standard* via NuGet package (such as `JsonReader` in JSON.NET).

The key differences are:

* **Who provides the API**. APIs that are part of .NET Standard need to be
  provided by each .NET implementation, in other words they must ship in-box.
  APIs delivered via a NuGet package are deployed with the application. This
  allows any 3rd party to provide new APIs without putting them directly into
  each .NET implementation.

* **How the API can be updated**. APIs that are part of the .NET Standard can
  only be updated when the standard itself and all implementations are updated.
  In contrast, APIs that ship as NuGet packages can be updated at any point. And
  so long they target the .NET Standard, will also be updated for all .NET
  implementations at once.

* **How the API is versioned**. This is the flip-side of the previous bullet
  point. Since APIs delivered as NuGet package can be updated frequently there
  is generally no agreement in a larger system which version to use. This can
  generally be solved by NuGet to unify to the latest version required in a
  given graph but it often leads to challenges, especially on .NET Framework
  where the assembly binder is extremely picky about version numbers. In
  contrast, APIs that ship as part of the .NET Standard (or any .NET
  implementation for that matter) have essentially a fixed version number that
  is a function of the version of the .NET Standard you're targeting. This
  drastically reduces the complexity of package graphs and reduces versioning
  conflicts.

* **How the API is acquired**. APIs that are part of the .NET Standard are
  always available and automatically referenced while APIs delivered as NuGet
  packages need to be explicitly referenced. This can be simplified by project
  templates but it tends to be much less convenient.

* **Who can use the API**. APIs that are part of .NET Standard can only use
  types that are also part of the .NET Standard. For example, in order to
  provide new APIs on `String` that accept `Span<T>`, we need to add `Span<T>`
  to .NET Standard as well. Sometimes it's possible to work this around by using
  extension methods but this only works for specific case and isn't a general
  solution.

In the past, we've tried hard to ship new functionality as NuGet packages
because we can update these APIs much faster. However, we're also often forced
to ship the APIs directly with a .NET implementation. You can think of these
events as "pushing down" the component into the platform layer. While doable,
we've learned that doing this without breaking customers is extremely hard.
Hence, we try to avoid doing this moving forward for APIs where we know up-front
they need to be part of the platform layer.

## Inclusion principles

As the previous section explains not every .NET API needs to be -- or even
should be -- part of the .NET Standard.

The following criteria helps us to identify APIs that should be included into
the .NET Standard:

* **Ubiquitous APIs**. APIs in the .NET Standard must be implemented by all .NET
  implementations (excluding .NET implementations that are no longer updated).
  Thus, we're only interested in standardizing APIs that are universal in
  nature. Please note that universal doesn't necessarily mean literally
  everywhere. If that were the bar, we'd end up penalizing the common cases by
  excluding a concept just because there are some rare cases where this concept
  doesn't work or doesn't apply.

* **Fundamental**. The standard is about foundational technologies. We want to
  avoid adding concepts that are often subject to changes because they deal with
  higher-level patterns and applications models. For that reason, dependency
  injection (DI) or object-relational mappers (ORM) aren't good candidates for
  the .NET Standard.

* **Mature APIs**. APIs that are part of the .NET Standard can only be versioned
  when the standard itself is versioned. Thus, we generally only standardize
  APIs that are mature enough that they don't have to be updated frequently.
  This implies that we will never add APIs that aren't stable yet.

* **Runtime-specific APIs**. If the APIs have to be implemented by the runtime,
  they don't benefit from being libraries on top of .NET Standard. Good examples
  of such APIs include primitive types, reflection, GC, and hardware intrinsics.

* **Widely-used APIs**. In order to enable a vibrant .NET ecosystem, it's
  important to have a common vocabulary of types that library authors can rely
  on (often called *exchange types*). Thus, it's beneficial to add widely used
  APIs to the .NET Standard as it simplifies building reusable libraries with a
  minimal number of dependencies.
