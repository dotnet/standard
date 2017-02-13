#!/bin/bash

ScriptDir="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
SeedAssemblies="mscorlib.dll;System.dll;System.Core.dll;System.ComponentModel.Composition.dll;System.Data.dll;System.IO.Compression.dll;System.IO.Compression.FileSystem.dll;System.Net.Http.dll;System.Numerics.dll;System.Runtime.Serialization.dll;System.Transactions.dll;System.Xml.dll;System.Xml.Linq.dll;System.Web.Services.dll;Xamarin.WatchOS.dll"

$ScriptDir/../../Tools/dotnetcli/dotnet $ScriptDir/../../Tools/GenAPI.exe -assembly $SeedAssemblies -libPath /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.WatchOS/ -out $ScriptDir -excludeAttributesList $ScriptDir/../attributeExcludeList.txt -headerFile $ScriptDir/../../netstandard/ref/license-header.txt -excludeApiList $ScriptDir/apiExcludeList.txt

