# Missing APIs

This document lists all the APIs that are available in .NET Standard 1.7 but
aren't implemented yet by platforms we need to support:

* [.NET Framework 4.6.1](#missing-from-net-framework-461)
* [Xamarin iOS](#missing-from-ios)
* [Xamarin Android](#missing-from-android)

## Missing from .NET Framework 4.6.1

* `M:System.AppContext.get_TargetFrameworkName`
* `M:System.AppContext.GetData(System.String)`
* `M:System.Diagnostics.Tracing.EventSource.add_EventCommandExecuted(System.EventHandler{System.Diagnostics.Tracing.EventCommandEventArgs})`
* `M:System.Diagnostics.Tracing.EventSource.remove_EventCommandExecuted(System.EventHandler{System.Diagnostics.Tracing.EventCommandEventArgs})`
* `M:System.Linq.Enumerable.Append``1(System.Collections.Generic.IEnumerable{``0},``0)`
* `M:System.Linq.Enumerable.Prepend``1(System.Collections.Generic.IEnumerable{``0},``0)`
* `M:System.Linq.Expressions.Expression`1.Compile(System.Boolean)`
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

## Missing from Xamarin

### Missing from iOS

* `F:System.IO.Pipes.PipeAccessRights.AccessSystemSecurity`
* `F:System.IO.Pipes.PipeAccessRights.ChangePermissions`
* `F:System.IO.Pipes.PipeAccessRights.CreateNewInstance`
* `F:System.IO.Pipes.PipeAccessRights.Delete`
* `F:System.IO.Pipes.PipeAccessRights.FullControl`
* `F:System.IO.Pipes.PipeAccessRights.Read`
* `F:System.IO.Pipes.PipeAccessRights.ReadAttributes`
* `F:System.IO.Pipes.PipeAccessRights.ReadData`
* `F:System.IO.Pipes.PipeAccessRights.ReadExtendedAttributes`
* `F:System.IO.Pipes.PipeAccessRights.ReadPermissions`
* `F:System.IO.Pipes.PipeAccessRights.ReadWrite`
* `F:System.IO.Pipes.PipeAccessRights.Synchronize`
* `F:System.IO.Pipes.PipeAccessRights.TakeOwnership`
* `F:System.IO.Pipes.PipeAccessRights.Write`
* `F:System.IO.Pipes.PipeAccessRights.WriteAttributes`
* `F:System.IO.Pipes.PipeAccessRights.WriteData`
* `F:System.IO.Pipes.PipeAccessRights.WriteExtendedAttributes`
* `M:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle.#ctor(System.IntPtr)`
* `M:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle.get_InvalidHandle`
* `M:System.Environment.GetEnvironmentVariable(System.String,System.EnvironmentVariableTarget)`
* `M:System.Environment.GetEnvironmentVariables(System.EnvironmentVariableTarget)`
* `M:System.Environment.SetEnvironmentVariable(System.String,System.String,System.EnvironmentVariableTarget)`
* `M:System.IO.Pipes.PipeAccessRule.#ctor(System.Security.Principal.IdentityReference,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AccessControlType)`
* `M:System.IO.Pipes.PipeAccessRule.#ctor(System.String,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AccessControlType)`
* `M:System.IO.Pipes.PipeAccessRule.get_PipeAccessRights`
* `M:System.IO.Pipes.PipeAuditRule.#ctor(System.Security.Principal.IdentityReference,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AuditFlags)`
* `M:System.IO.Pipes.PipeAuditRule.#ctor(System.String,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AuditFlags)`
* `M:System.IO.Pipes.PipeAuditRule.get_PipeAccessRights`
* `M:System.IO.Pipes.PipeSecurity.#ctor`
* `M:System.IO.Pipes.PipeSecurity.AddAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.AddAuditRule(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.Persist(System.Runtime.InteropServices.SafeHandle)`
* `M:System.IO.Pipes.PipeSecurity.Persist(System.String)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAccessRuleSpecific(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAuditRule(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAuditRuleAll(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAuditRuleSpecific(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.ResetAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.SetAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.SetAuditRule(System.IO.Pipes.PipeAuditRule)`
* `M:System.Runtime.InteropServices.ComImportAttribute.#ctor`
* `P:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle.InvalidHandle`
* `P:System.IO.Pipes.PipeAccessRule.PipeAccessRights`
* `P:System.IO.Pipes.PipeAuditRule.PipeAccessRights`
* `T:System.IO.Pipes.PipeAccessRights`
* `T:System.IO.Pipes.PipeAccessRule`
* `T:System.IO.Pipes.PipeAuditRule`
* `T:System.IO.Pipes.PipeSecurity`
* `T:System.Runtime.InteropServices.ComImportAttribute`

### Missing from Android

* `F:System.IO.Pipes.PipeAccessRights.AccessSystemSecurity`
* `F:System.IO.Pipes.PipeAccessRights.ChangePermissions`
* `F:System.IO.Pipes.PipeAccessRights.CreateNewInstance`
* `F:System.IO.Pipes.PipeAccessRights.Delete`
* `F:System.IO.Pipes.PipeAccessRights.FullControl`
* `F:System.IO.Pipes.PipeAccessRights.Read`
* `F:System.IO.Pipes.PipeAccessRights.ReadAttributes`
* `F:System.IO.Pipes.PipeAccessRights.ReadData`
* `F:System.IO.Pipes.PipeAccessRights.ReadExtendedAttributes`
* `F:System.IO.Pipes.PipeAccessRights.ReadPermissions`
* `F:System.IO.Pipes.PipeAccessRights.ReadWrite`
* `F:System.IO.Pipes.PipeAccessRights.Synchronize`
* `F:System.IO.Pipes.PipeAccessRights.TakeOwnership`
* `F:System.IO.Pipes.PipeAccessRights.Write`
* `F:System.IO.Pipes.PipeAccessRights.WriteAttributes`
* `F:System.IO.Pipes.PipeAccessRights.WriteData`
* `F:System.IO.Pipes.PipeAccessRights.WriteExtendedAttributes`
* `M:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle.#ctor(System.IntPtr)`
* `M:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle.get_InvalidHandle`
* `M:System.Environment.GetEnvironmentVariable(System.String,System.EnvironmentVariableTarget)`
* `M:System.Environment.GetEnvironmentVariables(System.EnvironmentVariableTarget)`
* `M:System.Environment.SetEnvironmentVariable(System.String,System.String,System.EnvironmentVariableTarget)`
* `M:System.IO.Pipes.PipeAccessRule.#ctor(System.Security.Principal.IdentityReference,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AccessControlType)`
* `M:System.IO.Pipes.PipeAccessRule.#ctor(System.String,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AccessControlType)`
* `M:System.IO.Pipes.PipeAccessRule.get_PipeAccessRights`
* `M:System.IO.Pipes.PipeAuditRule.#ctor(System.Security.Principal.IdentityReference,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AuditFlags)`
* `M:System.IO.Pipes.PipeAuditRule.#ctor(System.String,System.IO.Pipes.PipeAccessRights,System.Security.AccessControl.AuditFlags)`
* `M:System.IO.Pipes.PipeAuditRule.get_PipeAccessRights`
* `M:System.IO.Pipes.PipeSecurity.#ctor`
* `M:System.IO.Pipes.PipeSecurity.AddAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.AddAuditRule(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.Persist(System.Runtime.InteropServices.SafeHandle)`
* `M:System.IO.Pipes.PipeSecurity.Persist(System.String)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAccessRuleSpecific(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAuditRule(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAuditRuleAll(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.RemoveAuditRuleSpecific(System.IO.Pipes.PipeAuditRule)`
* `M:System.IO.Pipes.PipeSecurity.ResetAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.SetAccessRule(System.IO.Pipes.PipeAccessRule)`
* `M:System.IO.Pipes.PipeSecurity.SetAuditRule(System.IO.Pipes.PipeAuditRule)`
* `P:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle.InvalidHandle`
* `P:System.IO.Pipes.PipeAccessRule.PipeAccessRights`
* `P:System.IO.Pipes.PipeAuditRule.PipeAccessRights`
* `T:System.IO.Pipes.PipeAccessRights`
* `T:System.IO.Pipes.PipeAccessRule`
* `T:System.IO.Pipes.PipeAuditRule`
* `T:System.IO.Pipes.PipeSecurity`
