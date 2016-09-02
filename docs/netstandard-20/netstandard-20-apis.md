The current proposed API list for .NET Standard is being tracked `\\fxcore\Platforms\NetStandard\netstandard20.xlsx`

#Steps used to produce the list of APIs:

1. Intersect .NET 4.6.1 with Xamarin.IOS profile
2. Filter assembly list:
  * Included assemblies: mscorlib, System, System.Core, System.Drawing, System.IO.Compression, System.IO.Compression.FileSystem, System.Net, System.Net.Http, System.Numerics, System.Runtime.Serialization, System.Xml, System.Xml.Linq
  * Excluded assemblies: Microsoft.CSharp, System.ComponentModel.Composition, System.ComponentModel.DataAnnotations, System.Data, System.Data.Services.Client, System.Data.SqlXml, System.ServiceModel, System.ServiceModel.Web, System.Transaction, System.Web, System.Web.Services
3. Filter to just types, as the assumption is that if a type is included all members are also included. There are exceptions to this rule which are discussed below.
4. Assign a value in the “In NETStandard” column to each type
 * Core – These are required APIs in .NET Standard
 * No – These are things we shouldn’t include
 * [Feature] - These are buckets for features we should probably make as optional extensions as opposed to required.

 For reference assemblies see https://github.com/weshaggard/corefx/commits/netstandard.

#Interesting cases for API classification:
1. New APIs in .NET which we want to be in .NET Standard but aren’t in Xamarin.IOS yet. Examples: Array.Empty, AppContext, AsyncLocal, IReadOnly* interfaces, etc
 * We either need to filter these in .NET Standard 2.0 or see about getting them added to Xamarin in time for supporting .NET Standard 2.0.
2. OS platform specific APIs
 * WindowsRuntime Interop
 * COM Interop – Xamarin has some but not all
 * Crypto – CSP/Cng are Windows specific
 * WindowsIdentity
 * EventLog
 * PerfCounters
 * Pipes
 * Symbols APIs (COM specific and tied to the runtime).
3. Cross-cutting APIs
 * AccessControl – Exposed on File/Directory/Threads/Registry/Pipes/Mutex so we will need at least a minimal set of APIs to make this compatible across platforms.
 * Code Access Security - partly in Xamarin but not really implemented.
 * Remoting - partly in Xamarin but not really implemented.
 * Configuration – not in Xamarin but is a compat/portability concern.
4. Runtime specific APIs
 * Reflection Emit
5. APIs to discuss:
 * AppDomain – It had dependencies on CAS, Remoting, and Ref.Emit APIs.
 * Remoting [Split Out](https://github.com/weshaggard/corefx/commit/febd902bb699c2c895ca15d5aa2c3ebce3076f61)
  * Kept MarshalByRefObject but broke the dependency by removing MarshalByRefObject.CreateObjRef.
  * Some simple Remoting types kept because BinaryFormatter APIs depend on them.
 * CAS [Split Out](https://github.com/weshaggard/corefx/commit/10dc1d72be60376f98bc8f18bf469572372132e7)
  * SecurityPermissionAttribute and HostProtectionAttribute have some usage so [keeping](https://github.com/weshaggard/corefx/commit/e5e2a7e17e77d1b008dcd6f4ed1293bbc0b881b4)
 * ArgIterator/TypedReference – Special case APIs that require both runtime and compiler support and expensive to implement on .NET Native/AOT [Removed](https://github.com/weshaggard/corefx/commit/d15c79422ce7d03cc6e7e41d169458492c4022cd)
 *  _* - These are primarily COM interfaces but Xamarin did have in their surface area however they actually subset the interfaces which is a breaking change so we need exclude them because we cannot make them compatible. Example _AppDomain, _Assembly [Removed](https://github.com/weshaggard/corefx/commit/b4f857021d14aadd673e1b5c30c5167986b40d2f)
 *  Crypto – The security board has told us not to provide *Managed versions of the crypto APIs because we shouldn’t be shipping crypto algorithms that we implement ourselves. [Implement] - We will provide these as wrappers around our native implementations
 *  System.Xml – Should all the various Xml technologies be included in .NET Standard or should they be extensions?
 *  Serialization – BinaryFormatter is in the core and we will need to keep it there if we want to support it. What about DataContractSerializer/DataContractJsonSerializer/XmlSerializer? We should probably make them extensions.

 * Obsolete APIs
 * Different base types
  - MarshalByRefObject removed as the base type for a number of things
  - ReadOnlyCollectionBase
 * A number of parameter names are changed.
 * HttpWebRequest has incompatible constructors (likely ok because usually created via WebRequest.Create)
