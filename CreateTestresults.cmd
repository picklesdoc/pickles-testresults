@echo off
@pushd %~dp0

ECHO Remember to build the solution first!

"%~dp0\TestHarness\packages\NUnit.Runners.2.6.4\tools\nunit-console.exe" "%~dp0\TestHarness\nunit\bin\Debug\nunitHarness.dll" /result="%~dp0\results-example-nunit.xml"

"%~dp0\TestHarness\packages\NUnit.Console.3.0.0\tools\nunit3-console.exe" "%~dp0\TestHarness\nunit3\bin\Debug\nunit3Harness.dll" /result="%~dp0\results-example-nunit3.xml"

"%~dp0\TestHarness\packages\SpecRun.Runner.1.2.0\tools\specrun.exe" run default.srprofile "/baseFolder:%~dp0\TestHarness\SpecRun\bin\Debug" /log:specrun.log /report:"%~dp0\results-example-specrun.html"

"%~dp0\TestHarness\packagesNonNuget\xunit.runner\xunit.console.clr4.exe" "%~dp0\TestHarness\xunit\bin\Debug\xunitHarness.dll" /xml "%~dp0\results-example-xunit.xml"

"%~dp0\TestHarness\packages\xunit.runner.console.2.1.0\tools\xunit.console.exe" "%~dp0\TestHarness\xunit2\bin\Debug\xunit2Harness.dll" -xml "%~dp0\results-example-xunit2.xml" -parallel none

del "%~dp0\results-example-mstest.trx"
"%ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe" /testcontainer:"%~dp0\TestHarness\mstest\bin\Debug\mstestHarness.dll" /resultsfile:"%~dp0\results-example-mstest.trx" /testsettings:"%~dp0\TestHarness\TestSettings.testsettings"

cd "%~dp0\TestHarness\Cucumber"
call cucumber --format json_pretty --out "%~dp0\results-example-json.json" --tags ~@ignore
cd "%~dp0"

copy "%~dp0\results-example-nunit.xml" "%~dp0\..\Pickles\src\Pickles\Pickles.TestFrameworks.UnitTests\NUnit\NUnit2\"
copy "%~dp0\results-example-nunit3.xml" "%~dp0\..\Pickles\src\Pickles\Pickles.TestFrameworks.UnitTests\NUnit\NUnit3\"
copy "%~dp0\results-example-xunit.xml" "%~dp0\..\Pickles\src\Pickles\Pickles.TestFrameworks.UnitTests\XUnit\XUnit1\"
copy "%~dp0\results-example-xunit2.xml" "%~dp0\..\Pickles\src\Pickles\Pickles.TestFrameworks.UnitTests\XUnit\XUnit2\"
copy "%~dp0\results-example-specrun.html" "%~dp0\..\Pickles\src\Pickles\Pickles.TestFrameworks.UnitTests\SpecRun\"
copy "%~dp0\results-example-mstest.trx" "%~dp0\..\Pickles\src\Pickles\Pickles.TestFrameworks.UnitTests\MsTest\"
copy "%~dp0\results-example-json.json" "%~dp0\..\Pickles\src\Pickles\Pickles.TestFrameworks.UnitTests\CucumberJSON\"

@popd
