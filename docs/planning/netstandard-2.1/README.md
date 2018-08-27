# .NET Standard 2.1

This document describes the plan for .NET Standard 2.1, which includes the
definition of its API surface.

## Goals

* **Include `Span<T>`**. In .NET Core 2.1 we've added `Span<T>` which is an
  array like type that allows representing managed and unmanaged memory in a
  uniform way and supports cheap slicing. It's at the heart of most
  performance-related improvements in .NET Core 2.1 and allows managing buffers
  in a more efficient way as it helps in reducing allocations and copying.  
  `Span<T>` is considered a core type and requires runtime and compiler support
  in order to be fully leveraged. Please note that when we refer to `Span<T>` in
  this document, we really mean the family of span-related features which
  includes other types such as `ReadOnlySpan<T>`, `Memory<T>`,
  `ReadOnlyMemory<T>`, and the new `System.Buffers` namespace.

* **Include core-APIs working with spans**. While `Span<T>` is available as a
  .NET Standard compatible NuGet package (`System.Memory`) adding this package
  cannot extend the members of .NET Standard types that deal with spans. For
  example, .NET Core 2.1 added many APIs that allow working with spans, such as
  `Stream.Read(Span<Byte>)`. Part of the value proposition to add span to .NET
  Standard is to add the companion APIs as those cannot be added using a NuGet
  package.

* **General Goodness**. Since .NET Core was open sourced, we've added many small
  features across the base class libraries such as `System.HashCode` for
  combining hash codes or new overloads on `System.String`. There are about ~800
  new members in .NET Core that are on types that are already in .NET Standard
  2.0.

## Decisions

We did a diff between .NET Core 2.1 and .NET Standard 2.0 to see which APIs that
were added in .NET Core would be great candidates for inclusion in the standard.
From that list we made the following decisions:

* **Include** Brotli as `HttpClient` depends on it
* **Not include** `Microsoft.CSharp` (the standard is language neutral)
* **Not include** `Microsoft.VisualBasic` (the standard is language neutral)
* **Not include** `DataAnnotations` (out-of-band today)
* **Not include** `DiagnosticSource` (out-of-band today)
* **Not include** `System.Collections.Immutable` (out-of-band today)
* **Not include** `System.Reflection.Metadata` (out-of-band today)
* **Not include** `System.Runtime.InteropServices.WindowsRuntime` (out-of-band
  today)
* **Not include** `System.Runtime.Loader` (currently a .NET Core only concept
  and not ready for standardization)
* **Not include** `RegexCompilationInfo` as it throws on .NET Core & Xamarin and
  we don't plan on implementing the API ever.
* **Not include** `System.Threading.Tasks.Dataflow` (out-of-band today)
* **Not include** `IApplicationResourceStreamResolver` (was plumbing for
  Silverlight convergence. It's obsoleted.)
* **Not include** `System.Xml.Serialization.SchemaImporter` (doesn't seem
  useful)

***Note**: I haven't diffed Mono/Unity as my understanding is that neither
platform added any APIs at the base layer that would be good candidates for
inclusion.*

### Why and how did we decide to go with 2.1?

We actually considered a variety of version numbers for this release. The pros
and cons are listed below.

* **2.1**
  - The size of the API surface feels incremental, thus it's the most natural
    choice after 2.0.
  - Pros
    + Obvious when looked at purely from .NET Standard
    + Underlines messaging that .NET Standard and .NET Core are versioned
      independently
  - Cons
    + Can be confusing for customers who expect that they can consume it from
      .NET Core 2.1 and 2.2.
    + Doesn't leave room to inject another version
* **2.3**
  - Allows us to ship a smaller standard (e.g. one without spans) if we had to.
    Avoids confusion why you cannot use .NET Standard 2.1 from .NET Core
    2.1 and 2.2.
  - Pros
    + Leaves room for another .NET Standard that is smaller
    + Unlikely to cause confusion why .NET Core 2.1 and 2.2 cannot consume this
      version
    + Might hit 2.10 earlier and two digit version numbers are prone to version
      comparison bugs
  - Cons
    + Can be confusing to customers as there is no 2.1 or 2.2 when rendered in
      tables or drop downs
    + We're unlikely having to inject a version number  
* **3.0**
  - Aligns with .NET Core, which will be released at the same time as .NET
    Standard vNext
  - Pros
    + Leaves room for another .NET Standard that is smaller
    + Simpler messaging when we ship .NET Core and .NET Standard and aligns with
      what we did for .NET Core 2.0.
  - Cons
    + A 3.0 isn't really warranted for .NET Standard
    + Perpetuates the problem of aligning .NET Core & .NET Standard versions and
      requires arbitrary skipping of version numbers
* **`<year>.<month>`**
  - Using the `<year>.<month>` of when the standard is ratified makes the
    version numbers simple to agree on.
  - Pros
    + Obvious separation between .NET Standard and any implementation,
      specifically .NET Core
  - Cons
    + Massive change from 1.x to 2.0.
    + Both versions will forever show up in tooling and will look odd
* **Levels, letters, or code names**
  - We could be using a different versioning scheme such as Android style API
    levels or letters/code names.
  - Pros
    + Obvious separation between .NET Standard and any implementation,
      specifically .NET Core
  - Cons
    + Our tooling still needs version numbers in assemblies and TFMs, which will
      likely force developers to understand both schemes.

Ultimately, we decided to go with **2.1** because in the end all versioning
schemes have pros & cons and thus will cause *some* confusion, so we went with
the versioning scheme that felt most natural for .NET Standard.

## Open issues

* **Some features require runtime work**. We need to make sure implementers are
  aware what adding these means to their runtime:
    - `Span<T>`
    - `Vector<T>`
    - `DispatchProxy`
    - `RefEmit`
    - For the full list, see issues labelled as [runtime-impact].

## API suggestions

All API suggestions are labelled as [netstandard-api]. API suggestions that
might require runtime changes are labelled [runtime-impact].

[netstandard-api]: https://github.com/dotnet/standard/labels/netstandard-api
[runtime-impact]: https://github.com/dotnet/standard/labels/runtime-impact

### Major features

* [Add reflection emit](https://github.com/dotnet/standard/pull/829)
* [Add Brotli compression](https://github.com/dotnet/standard/pull/822)
* [Add SIMD-accelerated vector types](https://github.com/dotnet/standard/pull/821)
* [Add System.IO.Enumeration](https://github.com/dotnet/standard/pull/820)
* [Add Span<T> and related APIs](https://github.com/dotnet/standard/pull/819)
* [Add runtime API to get ECMA335 metadata](https://github.com/dotnet/standard/pull/805)
* [Add RuntimeFeature](https://github.com/dotnet/standard/pull/804)
* [Add converters for drawing primitives and known colors](https://github.com/dotnet/standard/pull/803)
* [Add DbProviderFactories](https://github.com/dotnet/standard/pull/802)
* [Add ITuple](https://github.com/dotnet/standard/pull/800)
* [Make TypeInfo extensible](https://github.com/dotnet/standard/pull/831)

### Miscellaneous improvements

The long tail of various small improvements have been broken down into PRs for
each of the namespaces:

* [Microsoft.Win32.SafeHandles](https://github.com/dotnet/standard/pull/806)
* [System](https://github.com/dotnet/standard/pull/823)
* [System.Collections.*](https://github.com/dotnet/standard/pull/807)
* [System.ComponentModel](https://github.com/dotnet/standard/pull/808)
* [System.Data.*](https://github.com/dotnet/standard/pull/809)
* [System.Diagnostics.*](https://github.com/dotnet/standard/pull/810)
* [System.Drawing](https://github.com/dotnet/standard/pull/825)
* [System.Globalization.*](https://github.com/dotnet/standard/pull/811)
* [System.IO.*](https://github.com/dotnet/standard/pull/826)
* [System.Linq.*](https://github.com/dotnet/standard/pull/812)
* [System.Net.*](https://github.com/dotnet/standard/pull/827)
* [System.Numerics](https://github.com/dotnet/standard/pull/813)
* [System.Reflection](https://github.com/dotnet/standard/pull/828)
* [System.Resources](https://github.com/dotnet/standard/pull/814)
* [System.Runtime.* ](https://github.com/dotnet/standard/pull/815)
* [System.Security.* ](https://github.com/dotnet/standard/pull/824)
* [System.Text.*](https://github.com/dotnet/standard/pull/816)
* [System.Threading.* ](https://github.com/dotnet/standard/pull/817)
* [System.Xml.*](https://github.com/dotnet/standard/pull/818)
