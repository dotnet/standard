# Developer Metaphor for .NET Standard

It seems there is some confusion on how [.NET Standard versions] work. One way
to think about .NET Standard is that it is an interface and that the concrete
frameworks are classes implementing the interfaces.

Here is a how this would look like for .NET Standard, .NET Framework, and .NET
Core. The other frameworks are analogous.

[versioning]: versions.md

## .NET Standard

Logically, every version of .NET Standard is an interface. Later versions extend
the previous version, i.e. there are no breaking changes. Newer versions have
all APIs that previous versions had:

```C#
// .NET Standard

interface INetStandard10
{
    void Primitives();
    void Reflection();
    void Tasks();
    void Collections();
    void Linq();
}

interface INetStandard11 : INetStandard10
{
    void ConcurrentCollections();
    void EventSource();
    void InteropServices();
}

interface INetStandard12 : INetStandard11
{
    void ThreadingTimer();
}

interface INetStandard13 : INetStandard12
{
    void AppContext();
    void Console();
    void StringInterpolation();
    void Calendars();
    void FileSystem();
    void Sockets();
    void AsyncLocal();
}

interface INetStandard14 : INetStandard13
{
    void CryptoECDsa();
}

interface INetStandard15 : INetStandard14
{
    void EventCounter();
}

interface INetStandard16 : INetStandard15
{
    void LinqInterpretation();
    void CryptoECCurve();
    void PrecompiledRegex();
}

interface INetStandard20 : INetStandard16
{
    void EverythingThatIsInNetFrameworkAndXamarin();
}

```

## Implementations of .NET Standard

Specific versions of given framework will implement specific versions of .NET
Standard. Not every version will implement a new versions of the standard. In
that case, the framework will merely implement the same version of .NET Standard
that its predecessor implemented:

```C#
// .NET Framework

class NetFramework45 : INetStandard11
{
    // ...
}

class NetFramework451 : NetFramework45, INetStandard12
{
    // ...
}

class NetFramework452 : NetFramework451
{
    // ...
}

class NetFramework46 : NetFramework452, INetStandard13
{
    // ...
}

class NetFramework461 : NetFramework46, INetStandard20
{
    // ...
}

class NetFramework462 : NetFramework461
{
    // ...
}

class NetFramework47 : NetFramework462
{
    // ...
}

class NetFramework471 : NetFramework47
{
    // ...
}

// .NET Core

class NetCore10 : INetStandard16
{
    // ...
}

class NetCore11 : NetCore10
{
    // ...
}

class NetCore20 : NetCore11, INetStandard20
{
    // ...
}
```
