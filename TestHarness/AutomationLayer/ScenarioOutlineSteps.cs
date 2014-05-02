using System;

using Shouldly;

using TechTalk.SpecFlow;

namespace AutomationLayer
{
  [Binding]
  public class ScenarioOutlineSteps
  {
    [Then(@"the scenario will '(.*)'")]
    public void ThenTheScenarioWill(string result)
    {
      if (result.ToUpperInvariant().StartsWith("PASS"))
      {
        // nothing to be done
      }
      else if (result.ToUpperInvariant().StartsWith("FAIL"))
      {
        true.ShouldBe(false);
      }
      else
      {
        ScenarioContext.Current.Pending();
      }
    }
  }
}
