@echo off
powershell -ExecutionPolicy ByPass -NoProfile %~dp0eng\Build.ps1 %*
echo Build.cmd ErrorLevel=%ERRORLEVEL%
exit /b %ERRORLEVEL%