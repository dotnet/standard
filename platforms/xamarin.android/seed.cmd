@setlocal

set SeedAssemblies="mscorlib.dll;System.dll;System.Core.dll;System.ComponentModel.Composition.dll;System.Data.dll;System.IO.Compression.dll;System.IO.Compression.FileSystem.dll;System.Net.Http.dll;System.Numerics.dll;System.Runtime.Serialization.dll;System.Transactions.dll;System.Xml.dll;System.Xml.Linq.dll;System.Web.Services.dll"

%~dp0..\..\Tools\dotnetcli\dotnet %~dp0..\..\Tools\GenAPI.exe -assembly %SeedAssemblies% -libPath "%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\MonoAndroid\v1.0" -out %~dp0 -excludeAttributesList %~dp0..\attributeExcludeList.txt -headerFile %~dp0..\..\netstandard\ref\license-header.txt -excludeApiList %~dp0apiExcludeList.txt
%~dp0..\..\Tools\dotnetcli\dotnet %~dp0..\..\Tools\GenAPI.exe -assembly Mono.Android.dll -libPath "%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\MonoAndroid\v7.1" -out %~dp0 -excludeAttributesList %~dp0..\attributeExcludeList.txt -headerFile %~dp0..\..\netstandard\ref\license-header.txt -excludeApiList %~dp0apiExcludeList.txt
