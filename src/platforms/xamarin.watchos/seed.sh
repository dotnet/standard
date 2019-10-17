#!/bin/bash

ScriptDir="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
SeedAssemblies="mscorlib.dll;System.dll;System.Core.dll;System.ComponentModel.Composition.dll;System.Data.dll;System.Data.DataSetExtensions.dll;System.IO.Compression.dll;System.IO.Compression.FileSystem.dll;System.Net.Http.dll;System.Numerics.dll;System.Numerics.Vectors.dll;System.Runtime.Serialization.dll;System.Transactions.dll;System.Xml.dll;System.Xml.Linq.dll;System.Web.Services.dll;Facades/System.Drawing.Common.dll"

# You may need to update the path below to Microsoft.DotNet.GenAPI.dll to be relative to your package cache, and to use the current version of the package
dotnet ~/.nuget/packages/microsoft.dotnet.genapi/5.0.0-beta.19511.1/tools/netcoreapp2.1/Microsoft.DotNet.GenAPI.dll $SeedAssemblies --lib-path "/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.WatchOS/" --out $ScriptDir --exclude-attributes-list $ScriptDir/../attributeExcludeList.txt --header-file $ScriptDir/../../netstandard/ref/license-header.txt
