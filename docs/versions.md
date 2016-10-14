# .NET Standard Versions

The table below lists all versions of .NET Standard:

* The columns represent .NET Standard versions. The header is a link to a
  document that shows which APIs got added in that version of .NET Standard.
* The rows indicate which version of a given .NET platform implements a given
  .NET Standard version.
* The arrows indicate that the platform supports a higher version of .NET
  Standard. For instance, .NET Core 1.0 supports the .NET Standard version 1.6,
  which is why there are arrows pointing to the right for the lower versions 1.0
  \- 1.5.

You can use this table to understand what the highest version of .NET Standard
is that you can target, based on which .NET platforms you intend to run on. For
instance, if you want to run on .NET Framework 4.5 and .NET Core 1.0, you can at
most target .NET Standard 1.1.

|.NET Platform              | [1.0]| [1.1]| [1.2]| [1.3]| [1.4]| [1.5]| [1.6]| [2.0]|
|:--------------------------|-----:|-----:|-----:|-----:|-----:|-----:|-----:|-----:|
|.NET Core                  |&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|   1.0| vNext|
|.NET Framework             |&rarr;|  4.5 | 4.5.1|   4.6|&rarr;|&rarr;|&rarr;| 4.6.1|
|Mono                       |&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|   4.6| vNext|
|Xamarin.iOS                |&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|  10.0| vNext|
|Xamarin.Android            |&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|&rarr;|   7.0| vNext|
|Universal Windows Platform |&rarr;|&rarr;|&rarr;|&rarr;|  10.0|&rarr;|&rarr;| vNext|
|Windows                    |&rarr;|   8.0|   8.1|      |      |      |      |      |
|Windows Phone              |&rarr;|&rarr;|   8.1|      |      |      |      |      |
|Windows Phone Silverlight  |   8.0|      |      |      |      |      |      |      |

[1.0]: versions/netstandard1.0.md
[1.1]: versions/netstandard1.1.md
[1.2]: versions/netstandard1.2.md
[1.3]: versions/netstandard1.3.md
[1.4]: versions/netstandard1.4.md
[1.5]: versions/netstandard1.5.md
[1.6]: versions/netstandard1.6.md
[2.0]: versions/netstandard2.0.md

## How do I know which .NET Standard version I should target?

When choosing a .NET Standard version, you should consider this trade-off:

* The higher the version, the more APIs are available to you.
* The lower the version, the more platforms implement it.

So generally speaking, you should target the lowest version you get away with.
To inform your decision, you should consider the compatibility matrix and the
APIs additions linked from the table above.

# Versioning rules

There are two primary versioning rules:

1. **Additive**. .NET Standard versions are logically concentric circles: higher
   versions incorporate all APIs from previous versions. There are no breaking
   changes between versions.
2. **Immutable**. Once shipped, .NET Standard versions are frozen.

New APIs will first become available in specific .NET platforms, such as .NET
Core. If the [.NET Standard review board][netstandard-board] believes the new
APIs should be made available everywhere, they'll be added in a new .NET
Standard version.

[netstandard-board]: review-board/README.md