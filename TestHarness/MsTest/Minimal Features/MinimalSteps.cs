using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Pickles.TestHarness.MsTest
{
    [Binding]
    public class MinimalSteps
    {
        [Then(@"passing step")]
        public void ThenPassingStep()
        {
            
        }
        
        [Then(@"inconclusive step")]
        public void ThenInconclusiveStep()
        {
            Assert.Inconclusive("by design");
        }
        
        [Then(@"failing step")]
        public void ThenFailingStep()
        {
            Assert.Fail("by design");
        }
    }
}
