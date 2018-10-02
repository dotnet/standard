[CmdletBinding(PositionalBinding=$false)]
Param(
  [string] $ArchGroup,
  [switch] $Release,
  [switch] $c,
  [switch] $Restore,
  [switch] $Test,
  [switch] $Pack,
  [switch] $SignPackages,
  [switch] $Publish,
  [Parameter(ValueFromRemainingArguments=$true)][String[]]$ExtraArgs
)

$defaultargs = "-build -restore -warnaserror:0"

foreach ($argument in $PSBoundParameters.Keys)
{
  switch($argument)
  {
    "Debug"        { $arguments += "-configuration Debug " }
    "Release"      { $arguments += "-configuration Release " }
    "ExtraArgs"    { $arguments += $ExtraArgs }
    "c"            { $arguments += "-rebuild " }
    "SignPackages" { $arguments += "/p:SignPackages=true " }
    "Publish"      { $arguments += "" }
    default        { $arguments += "/p:$argument=$($PSBoundParameters[$argument]) " }
  }
}

$arguments = "$defaultargs $arguments"

Write-Host "Args: $arguments"

Invoke-Expression "& `"$PSScriptRoot/common/build.ps1`" $arguments"
exit $lastExitCode