pickles-testresults
===================

Contains the scenarios from which test results are derived to test the parsing of test results in Pickles

## .NET Code

The .NET code is found in `./TestHarness/TestHarness.sln` solution. You will need [Visual Studio 2015](https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx) in order to open the solution; the free Community version is fine. Remember to restore the NuGet packages before you compile.

## Cucumber/Ruby Code

In order to generate the thest output of the Cucumber features, you need to install the following software:

- [Ruby](http://rubyinstaller.org/downloads): use the stable 2.2.x version
- Install Cucumber by opening an admin-enabled command line window in the directory where you cloned this repository, and running these gem commands:
  - `gem install cucumber`
  - `gem install rspec`


## CucumberJS/JS Code

In order to generate the test output of the CucumberJS features, you need to install the following software:

- [Node.js](https://nodejs.org/en/download/): the LTE version is good enough. You may have to restart your computer. You can optionally verify the installation of Node.js by running these two commands from a command line:
  - `node -v`
  - `npm -v`
- Install CucumberJS by opening an admin-enabled command line window in the directory where you cloned this repository, and running the `npm install --save-dev cucumber` command.
