$genapi = "\\fxcore\tools\others\GenAPI\GenAPI.exe";

$refPath = Resolve-Path "..\..\..\corefx\bin\ref\netcoreapp"

$extensionOutput = ".";
$extensionlistFile = "extensionlist.txt";

if (!(Test-Path $extensionlistFile))
{
    Write-Error "extension list doesn't exist $extensionList";
    exit;
}
$extensionList = gc $extensionlistFile;

$projTemplate = gc extension.projtemplate

foreach ($extension in $extensionList)
{
    if ($extension[0] -eq '#') { continue; }

    $extensionSource = "$extensionOutput\$extension.cs";
    $extensionProject = "$extensionOutput\$extension.csproj";
    $extensionContract = "$refPath\$extension.dll";

    if (!(Test-Path $extensionContract))
    {
        Write-Host "Assembly $extensionContract doesn't exist so skipping."
        continue;
    }

    Write-Host "Generating forwards and project for $extensionContract to $extensionSource";

    $asmName = [System.Reflection.AssemblyName]::GetAssemblyName($extensionContract);
    $asmVersion = $asmName.Version.ToString();

    $asmToken = $asmName.GetPublicKeyToken()[0].ToString("x2");
    if ($asmToken -eq "b0")
    {
        $token = "MSFT";
    }
    elseif ($asmToken -eq "b7")
    {
        $token = "ECMA";
    }
    elseif ($asmToken -eq "cc")
    {
        $token = "Open";
    }
    elseif ($asmToken -eq "31")
    {
        $token = "SilverlightExtension";
    }
    else
    {
        Write-Error "Don't know which key is token $asmToken";
    }

    & $genapi -assembly:"$extensionContract" -out:"$extensionSource" -libpath:"$refPath" -excludeAttributesList ..\attributeExcludeList.txt -headerFile ..\..\netstandard\ref\license-header.txt

    $projTemplate.Replace("[NAME]", $extension).Replace("[TOKEN]", $token).Replace("[VERSION]", $asmVersion).Replace("[KEY]", $token) | sc "$extensionProject"
}