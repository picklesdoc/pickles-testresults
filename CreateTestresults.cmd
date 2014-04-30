@pushd %~dp0

ECHO Remember to build the solution first!
REM pause

"%~dp0\TestHarness\packages\NUnit.Runners.2.6.3\tools\nunit-console.exe" "%~dp0\TestHarness\nunit\bin\Debug\nunitHarness.dll" /result=results-example-nunit.xml /nologo /nodots


pause

@popd