param
(
  [string]$shims = "netstandard"
)
$genapi = "\\fxcore\tools\others\GenAPI\GenAPI.exe";

if ($shims -eq "netstandard")
{
    $refPath = Resolve-Path "..\..\..\bin\obj\CompatShims\ref\netstandard1.6"
    $refVersionPath = Resolve-Path "..\..\..\bin\obj\CompatShims\ref\net47"
}
elseif ($shims -eq "netfx")
{
    $refPath = "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7"
}

$shimOutput = $shims;
$shimlistFile = "$shims.shimlist.txt";

if (!(Test-Path $shimlistFile))
{
    Write-Error "Shim list doesn't exist $shimList";
    exit;
}
$shimList = gc $shimlistFile;

$projTemplate = gc shim.projtemplate

$netstandardRef = "..\..\..\bin\ref\netstandard\2.0.0.0\netstandard.dll";
$extensionsDir = "..\..\..\bin\ref\extensions\";
$netstandardAndExtensionsAPIList = "netstandardAndExtensionsAPIList.txt";

& $genapi -writer:DocIds -assembly:$netstandardRef,$extensionsDir -out:$netstandardAndExtensionsAPIList

foreach ($shim in $shimList)
{
    if ($shim[0] -eq '#') { continue; }

    $shimForwards = "$shimOutput\$shim.Forwards.cs";
    $shimProject = "$shimOutput\$shim.csproj";
    $shimContract = "$refPath\$shim.dll";

    if (!(Test-Path $shimContract))
    {
        Write-Host "Assembly $shimContract doesn't exist so skipping."
        continue;
    }

    Write-Host "Generating forwards and project for $shimContract";

    $asmName = [System.Reflection.AssemblyName]::GetAssemblyName($shimContract);
    $asmVersion = $asmName.Version;

    if ($refVersionPath -ne "" -and (Test-Path "$refVersionPath\$shim.dll"))
    {
        $asmRefVersion = [System.Reflection.AssemblyName]::GetAssemblyName("$refVersionPath\$shim.dll");

        if ($asmRefVersion.Version -gt $asmName.Version)
        {
            $asmVersion = $asmRefVersion.Version;
        }
    }

    # Increment the patch version by 1 above the highest stable release to ensure we are higher then any servicing
    $asmVersion = new-object System.Version($asmVersion.Major, $asmVersion.Minor, ($asmVersion.Build+1), 0)

    $asmVersion = $asmVersion.ToString()
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

    & $genapi -writer:TypeForwards -assembly:"$shimContract" -apiList:"$netstandardAndExtensionsAPIList" -out:"$shimForwards" -libpath:"$refPath"
    #& $genapi -writer:TypeForwards -assembly:"$shimContract" -out:"$shimForwards" -libpath:"$refPath"
    $projTemplate.Replace("[SHIM]", $shim).Replace("[TOKEN]", $token).Replace("[VERSION]", $asmVersion).Replace("[KEY]", $token) | sc "$shimProject"
}