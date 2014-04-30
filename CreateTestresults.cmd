@pushd %~dp0

ECHO Remember to build the solution first!
REM pause

Cd "%~dp0\TestHarness\packages\NUnit.Runners.*\tools"
"nunit-console.exe" "%~dp0\TestHarness\nunit\bin\Debug\nunitHarness.dll" /result="%~dp0\results-example-nunit.xml"


Cd "%~dp0\TestHarness\packages\SpecRun.Runner.*\tools"
"specrun.exe" run default.srprofile "/baseFolder:%~dp0\TestHarness\SpecRun\bin\Debug" /log:specrun.log /report:"%~dp0\results-example-specrun.html"

Cd "%~dp0\TestHarness\packagesNonNuget\xunit.runner"
"xunit.console.clr4.exe" "%~dp0\TestHarness\xunit\bin\Debug\xunitHarness.dll" /xml "%~dp0\results-example-xunit.xml"

pause

@popd