@pushd %~dp0

ECHO Remember to build the solution first!
pause

Cd "%~dp0\TestHarness\packages\NUnit.Runners.*\tools"
"nunit-console.exe" "%~dp0\TestHarness\nunit\bin\Debug\nunitHarness.dll" /result="%~dp0\results-example-nunit.xml"


Cd "%~dp0\TestHarness\packages\SpecRun.Runner.*\tools"
"specrun.exe" run default.srprofile "/baseFolder:%~dp0\TestHarness\SpecRun\bin\Debug" /log:specrun.log /report:"%~dp0\results-example-specrun.html"


Cd "%~dp0\TestHarness\packagesNonNuget\xunit.runner"
"xunit.console.clr4.exe" "%~dp0\TestHarness\xunit\bin\Debug\xunitHarness.dll" /xml "%~dp0\results-example-xunit.xml"

:begin

del "%~dp0\results-example-mstest.trx"
Cd "%~dp0\TestHarness\mstest\bin\Debug\"
"%ProgramFiles(x86)%\Microsoft Visual Studio 12.0\Common7\IDE\MSTest.exe" /testcontainer:"mstestHarness.dll" /resultsfile:"%~dp0\results-example-mstest.trx" /testsettings:"%~dp0\TestHarness\TestSettings.testsettings"

pause

@popd