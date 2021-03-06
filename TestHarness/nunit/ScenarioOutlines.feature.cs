﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Pickles.TestHarness.nunit
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Scenario Outlines")]
    public partial class ScenarioOutlinesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScenarioOutlines.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenario Outlines", "Here we demonstrate how we deal with scenario outlines", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario outline where all scenarios pass")]
        [NUnit.Framework.TestCaseAttribute("pass_1", null)]
        [NUnit.Framework.TestCaseAttribute("pass_2", null)]
        [NUnit.Framework.TestCaseAttribute("pass_3", null)]
        public virtual void ThisIsAScenarioOutlineWhereAllScenariosPass(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline where all scenarios pass", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 8
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario outline where one scenario is inconclusive")]
        [NUnit.Framework.TestCaseAttribute("pass_1", null)]
        [NUnit.Framework.TestCaseAttribute("pass_2", null)]
        [NUnit.Framework.TestCaseAttribute("inconclusive_1", null)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline where one scenario is inconclusive", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 21
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario outline where one scenario fails")]
        [NUnit.Framework.TestCaseAttribute("pass_1", null)]
        [NUnit.Framework.TestCaseAttribute("pass_2", null)]
        [NUnit.Framework.TestCaseAttribute("fail_1", null)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioFails(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline where one scenario fails", exampleTags);
#line 30
this.ScenarioSetup(scenarioInfo);
#line 34
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("And we can go totally bonkers with multiple example sections.")]
        [NUnit.Framework.TestCaseAttribute("pass_1", null)]
        [NUnit.Framework.TestCaseAttribute("pass_2", null)]
        [NUnit.Framework.TestCaseAttribute("inconclusive_1", null)]
        [NUnit.Framework.TestCaseAttribute("inconclusive_2", null)]
        [NUnit.Framework.TestCaseAttribute("fail_1", null)]
        [NUnit.Framework.TestCaseAttribute("fail_2", null)]
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections_(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("And we can go totally bonkers with multiple example sections.", exampleTags);
#line 43
this.ScenarioSetup(scenarioInfo);
#line 45
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deal correctly with backslashes in the examples")]
        [NUnit.Framework.TestCaseAttribute("c:\\Temp\\", null)]
        public virtual void DealCorrectlyWithBackslashesInTheExamples(string filePath, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deal correctly with backslashes in the examples", exampleTags);
#line 63
this.ScenarioSetup(scenarioInfo);
#line 65
  testRunner.When(string.Format("I have backslashes in the value, for example a \'{0}\'", filePath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deal correctly with parenthesis in the examples")]
        [NUnit.Framework.TestCaseAttribute("This is a description (and more)", null)]
        public virtual void DealCorrectlyWithParenthesisInTheExamples(string overlyDescriptiveField, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deal correctly with parenthesis in the examples", exampleTags);
#line 72
this.ScenarioSetup(scenarioInfo);
#line 74
  testRunner.When(string.Format("I have parenthesis in the value, for example an \'{0}\'", overlyDescriptiveField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
