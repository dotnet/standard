#!/bin/bash

ScriptDir="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
SeedAssemblies="mscorlib.dll;System.dll;System.Core.dll;System.ComponentModel.Composition.dll;System.Data.dll;System.IO.Compression.dll;System.IO.Compression.FileSystem.dll;System.Net.Http.dll;System.Numerics.dll;System.Numerics.Vectors.dll;System.Runtime.InteropServices.RuntimeInformation.dll;System.Runtime.Serialization.dll;System.Transactions.dll;System.Xml.dll;System.Xml.Linq.dll;System.Web.Services.dll"

FacadeSeedAssemblies="System.Globalization.Extensions.dll;System.Data.Common.dll;System.Diagnostics.StackTrace.dll;System.Runtime.Serialization.Xml.dll;System.Runtime.Serialization.Primitives.dll;System.Security.Cryptography.Algorithms.dll;System.Security.SecureString.dll;System.Threading.Overlapped.dll;System.Xml.XPath.XDocument.dll"

$ScriptDir/../../Tools/dotnetcli/dotnet $ScriptDir/../../Tools/GenAPI.exe -assembly $SeedAssemblies -libPath /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/Xamarin.Mac/ -out $ScriptDir -excludeAttributesList $ScriptDir/../attributeExcludeList.txt -headerFile $ScriptDir/../../netstandard/ref/license-header.txt -excludeApiList $ScriptDir/apiExcludeList.txt

# we need to process OpenTK.dll and Xamarin.Mac.dll separately as they're
# symlinked to a different directory and GenAPI doesn't like that
$ScriptDir/../../Tools/dotnetcli/dotnet $ScriptDir/../../Tools/GenAPI.exe -assembly "OpenTK.dll;Xamarin.Mac.dll" -libPath /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/reference/mobile -out $ScriptDir -excludeAttributesList $ScriptDir/../attributeExcludeList.txt -headerFile $ScriptDir/../../netstandard/ref/license-header.txt -excludeApiList $ScriptDir/apiExcludeList.txt

$ScriptDir/../../Tools/dotnetcli/dotnet $ScriptDir/../../Tools/GenAPI.exe -assembly $FacadeSeedAssemblies -libPath /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/Xamarin.Mac/Facades/ -out $ScriptDir/Facades -excludeAttributesList $ScriptDir/../attributeExcludeList.txt -headerFile $ScriptDir/../../netstandard/ref/license-header.txt -excludeApiList $ScriptDir/apiExcludeList.txt
