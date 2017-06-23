# Comparisons between .NET Standard and other platforms

Many have asked for a diff between .NET Standard and other existing platforms.
The list of diffs is technically quite large so for the sake of manageability
we've only provided ones we thought were interesting.

The diffs are in the format of unified diffs you're used to from Git and GitHub.
.NET Standard is always the left hand side, which means the diffs should be read
as follows:

```diff
+ API that exists in this version of .NET Standard but not in the platform on the right hand side
- API that doesn't exist in this version of .NET Standard but does in the platform on the right hand side
```

For APIs that have modifications (e.g. we made an abstract method virtual),
you'll see a deletion followed by an addition.

* [.NET Standard 1.6 vs .NET Core 1.1](netstandard1.6_vs_netcoreapp1.1/README.md)
* [.NET Standard 2.0 vs .NET Core 2.0](netstandard2.0_vs_netcoreapp2.0/README.md)
* [.NET Standard 2.0 vs .NET Framework 4.6.1](netstandard2.0_vs_net461/README.md)