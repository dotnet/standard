:: This script updates the contents of src\platforms\netcoreapp, stripped down
:: to just the contents that matter for .NET Standard. It's meant to be
:: manually diff'ed against the .NET Standard reference assemblies to propose
:: API changes.
::
:: We should move the GenNetStandard tool to our engineering tools (Arcade) so
:: that they are available to people that don't have access to the internal
:: share. However, since the process is currently manual and only done by me,
:: that seems acceptable. At least this this makes it reproducable by other
:: people, which is better to what we have today.
::
:: The script assume that the caller has an enlistment for dotnet/corefx in a
:: folder that is parallel to dotnet/standard and that is named corefx. In
:: practice, this should hold for most people that work on this.
@echo off

set INPUT_PATH=%~dp0..\corefx\artifacts\bin\ref\netcoreapp
set OUTPUT_PATH=%~dp0src\platforms\netcoreapp
set REF_PATH=%~dp0src\netstandard\ref

echo Updating .NET Core reference assemblies...
echo Input Binaries : %INPUT_PATH%
echo Output Folder  : %OUTPUT_PATH%

"\\fxcore\tools\bin\GenNetStandard.exe" %INPUT_PATH% -out %OUTPUT_PATH%

echo To propose API changes, compare the contents of this folder:
echo.
echo    %REF_PATH%
echo.
echo with the contents of this folder:
echo.
echo   %OUTPUT_PATH%
echo.
