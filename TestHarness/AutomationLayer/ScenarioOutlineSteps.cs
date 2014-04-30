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
      switch (result.ToUpperInvariant())
      {
        case "PASS":
          {
            // nothing to be done
            break;
          }

        case "FAIL":
          {
            true.ShouldBe(false);
            break;
          }

        default:
          {
            ScenarioContext.Current.Pending();
            break;
          }
      }
    }
  }
}
