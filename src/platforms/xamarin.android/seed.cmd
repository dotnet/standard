@setlocal

set SeedAssemblies="mscorlib.dll;System.dll;System.Core.dll;System.ComponentModel.Composition.dll;System.Data.dll;System.IO.Compression.dll;System.IO.Compression.FileSystem.dll;System.Net.Http.dll;System.Numerics.dll;System.Numerics.Vectors.dll;System.Runtime.Serialization.dll;System.Transactions.dll;System.Xml.dll;System.Xml.Linq.dll;System.Web.Services.dll"

set FacadeSeedAssemblies="System.Globalization.Extensions.dll;System.Diagnostics.StackTrace.dll;System.Runtime.Serialization.Xml.dll;System.Runtime.Serialization.Primitives.dll;System.Security.Cryptography.Algorithms.dll;System.Security.SecureString.dll;System.Xml.XPath.XDocument.dll"

%~dp0..\..\Tools\dotnetcli\dotnet \\fxcore\tools\others\GenApi\genapi.exe -assembly %SeedAssemblies% -libPath "%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\MonoAndroid\v1.0" -out %~dp0 -excludeAttributesList %~dp0..\attributeExcludeList.txt -headerFile %~dp0..\..\netstandard\ref\license-header.txt
%~dp0..\..\Tools\dotnetcli\dotnet \\fxcore\tools\others\GenApi\genapi.exe -assembly "Mono.Android.dll" -libPath "%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\MonoAndroid\v9.0" -out %~dp0 -excludeAttributesList %~dp0..\attributeExcludeList.txt -headerFile %~dp0..\..\netstandard\ref\license-header.txt -excludeApiList %~dp0apiExcludeList.txt

%~dp0..\..\Tools\dotnetcli\dotnet \\fxcore\tools\others\GenApi\genapi.exe -assembly %FacadeSeedAssemblies% -libPath "%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\MonoAndroid\v1.0\Facades" -out %~dp0Facades -excludeAttributesList %~dp0..\attributeExcludeList.txt -headerFile %~dp0..\..\netstandard\ref\license-header.txt
