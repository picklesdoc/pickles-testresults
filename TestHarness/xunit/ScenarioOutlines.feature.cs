﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Pickles.TestHarness.xunit
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ScenarioOutlinesFeature : Xunit.IUseFixture<ScenarioOutlinesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScenarioOutlines.feature"
#line hidden
        
        public ScenarioOutlinesFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenario Outlines", "Here we demonstrate how we deal with scenario outlines", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(ScenarioOutlinesFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Outlines")]
        [Xunit.TraitAttribute("Description", "This is a scenario outline where all scenarios pass")]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
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
        
        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Outlines")]
        [Xunit.TraitAttribute("Description", "This is a scenario outline where one scenario is inconclusive")]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("inconclusive", new string[0])]
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
        
        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Outlines")]
        [Xunit.TraitAttribute("Description", "This is a scenario outline where one scenario fails")]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("fail", new string[0])]
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
        
        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Scenario Outlines")]
        [Xunit.TraitAttribute("Description", "And we can go totally bonkers with multiple example sections.")]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("pass", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("inconclusive", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("inconclusive", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("fail", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("fail", new string[0])]
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ScenarioOutlinesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ScenarioOutlinesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion