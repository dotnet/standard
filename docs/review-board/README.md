# .NET Standard Review Body

We need a .NET Standard review body. We make the following proposal:

  * **.NET Team**. The rationale here is that most, if not all, of the APIs
    that are part of .NET Standard are implemented and evolved by the .NET team.
  * **Xamarin**. They are a platform vendor and have their own implementation.
    While they mostly copy our code, changes and extensions can impact their
    ability to support .NET Standard. Thus, we need to coordinate any changes
    with them.
  * **Unity**. Same rationale as for Xamarin.

Please note that this list isn't meant to be closed: as more platform vendors
and API drivers appear, the review board will expand accordingly.

## Reviews

Decisions made by the review body will be made public and posted here.

## Inclusion principles

Not every .NET API needs (or even should be) part of .NET Standard.

If a library is written in pure IL (for example C#, VB.NET, F# etc.), and
targets .NET Standard, then it can run across all current and future .NET
platforms with no code changes. The only requirement on the .NET platform is
that it has to support at least that version of .NET Standard that the library
was compiled for (or a higher version).

Any modification to such a library, whether it's bug fixes, performance
improvements or additional APIs, will also work across all these .NET platforms
as well, so:

* The library author has great flexibility to version and make releases on their
  own cadence.
* Consumers of that library have great choice on when they upgrade the version
  of that library they are using.

If the library is made a part of .NET Standard it can only version at the same
cadence as the standard, so the update flexibility is much reduced.

The following criteria helps us to identify APIs that can be a part of .NET
Standard:

* **Ubiqutous APIs**. APIs in the .NET Standard must be implemented by all .NET
  platforms. Thus, we're only interested in standardizing APIs that are
  universal in nature and thus should be available everywhere.

* **Mature APIs**. APIs that are part of the .NET Standard can only be versioned
  when the standard itself is versioned. Thus, we generally only standardize
  APIs that are mature enough that they don't have to be updated frequently.

* **Runtime-specific APIs**. If the APIs have to be implemented by the runtime,
  they don't benefit from being libraries on top of .NET Standard. Good examples
  of such APIs include primitive types, reflection, GC, and code-gen intrinsics
  (SIMD).

* **Widely-used APIs**. In order to enable a vibrant .NET ecosystem, it's
  important to have a common vocabulary of types that library authors can rely
  on. Thus, it's beneficial to add widely used APIs to the .NET Standard as it
  simplifies building reusable libraries.