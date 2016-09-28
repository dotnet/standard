# APIs in .NET Standard 1.x that will not be available in .NET Standard 2.0

This document lists all the APIs that are available in .NET Standard 1.6 but
will not be available in .NET Standard 2.0. The reason for the removal is
explained [here](README.md#breaking-change-to-net-standard-1x).

However, We plan on re-exposing these APIs in a later version of .NET Standard.

* `M:System.AppContext.get_TargetFrameworkName`
* `M:System.AppContext.GetData(System.String)`
* `M:System.Diagnostics.Tracing.EventSource.add_EventCommandExecuted(System.EventHandler{System.Diagnostics.Tracing.EventCommandEventArgs})`
* `M:System.Diagnostics.Tracing.EventSource.remove_EventCommandExecuted(System.EventHandler{System.Diagnostics.Tracing.EventCommandEventArgs})`
* <code>M:System.Linq.Enumerable.Append\`1(System.Collections.Generic.IEnumerable{\`0},\`0)</code>
* <code>M:System.Linq.Enumerable.Prepend\`1(System.Collections.Generic.IEnumerable{\`0},\`0)</code>
* <code>M:System.Linq.Expressions.Expression\`1.Compile(System.Boolean)</code>
* `M:System.Linq.Expressions.LambdaExpression.Compile(System.Boolean)`
* `M:System.Runtime.InteropServices.Marshal.PtrToStringUTF8(System.IntPtr)`
* `M:System.Runtime.InteropServices.Marshal.PtrToStringUTF8(System.IntPtr,System.Int32)`
* `M:System.Runtime.InteropServices.Marshal.StringToCoTaskMemUTF8(System.String)`
* `M:System.Runtime.InteropServices.Marshal.ZeroFreeMemoryUTF8(System.IntPtr)`
* `M:System.Security.Cryptography.CngAlgorithm.get_ECDiffieHellman`
* `M:System.Security.Cryptography.CngAlgorithm.get_ECDsa`
* `M:System.Security.Cryptography.CngKeyBlobFormat.get_EccFullPrivateBlob`
* `M:System.Security.Cryptography.CngKeyBlobFormat.get_EccFullPublicBlob`
* `M:System.Security.Cryptography.ECDsa.Create(System.Security.Cryptography.ECCurve)`
* `M:System.Security.Cryptography.ECDsa.Create(System.Security.Cryptography.ECParameters)`
* `M:System.Security.Cryptography.ECDsa.ExportExplicitParameters(System.Boolean)`
* `M:System.Security.Cryptography.ECDsa.ExportParameters(System.Boolean)`
* `M:System.Security.Cryptography.ECDsa.GenerateKey(System.Security.Cryptography.ECCurve)`
* `M:System.Security.Cryptography.ECDsa.ImportParameters(System.Security.Cryptography.ECParameters)`
* `M:System.Security.Cryptography.ECDsaCng.#ctor(System.Security.Cryptography.ECCurve)`
* `M:System.Security.Cryptography.ECDsaCng.ExportExplicitParameters(System.Boolean)`
* `M:System.Security.Cryptography.ECDsaCng.ExportParameters(System.Boolean)`
* `M:System.Security.Cryptography.ECDsaCng.GenerateKey(System.Security.Cryptography.ECCurve)`
* `M:System.Security.Cryptography.ECDsaCng.ImportParameters(System.Security.Cryptography.ECParameters)`
* `M:System.Text.RegularExpressions.Group.get_Name`
* `M:System.Text.RegularExpressions.Regex.get_CapNames`
* `M:System.Text.RegularExpressions.Regex.get_Caps`
* `M:System.Text.RegularExpressions.Regex.set_CapNames(System.Collections.IDictionary)`
* `M:System.Text.RegularExpressions.Regex.set_Caps(System.Collections.IDictionary)`
* `T:System.Runtime.Loader.AssemblyLoadContext`
* `T:System.Security.Cryptography.AesCng`
* `T:System.Security.Cryptography.ECCurve`
* `T:System.Security.Cryptography.ECParameters`
* `T:System.Security.Cryptography.ECPoint`
* `T:System.Security.Cryptography.TripleDESCng`
