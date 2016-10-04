@setlocal
pushd \\fxcore\Platforms\ApiCatalog\.NET Framework 4.6.1

::"mscorlib.dll;System.dll;System.Core.dll;System.Drawing.dll;System.IO.Compression.dll;System.IO.Compression.FileSystem.dll;System.Net.Http.dll;System.Numerics.dll;System.Runtime.Serialization.dll;System.Xml.dll;System.Xml.Linq.dll;System.Web.dll"
set SeedAssemblies="System.ComponentModel.Composition.dll"

\\fxcore\tools\others\GenApi\genapi.exe -assembly %SeedAssemblies% -libPath . -out %~dp0 -excludeAttributesList %~dp0..\attributeExcludeList.txt