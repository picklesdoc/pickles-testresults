@pushd %~dp0

ECHO Remember to build the solution first!
REM pause

Cd "%~dp0\TestHarness\packages\NUnit.Runners.*\tools"
"nunit-console.exe" "%~dp0\TestHarness\nunit\bin\Debug\nunitHarness.dll" /result="%~dp0\results-example-nunit.xml" /nologo /nodots

pause

@popd