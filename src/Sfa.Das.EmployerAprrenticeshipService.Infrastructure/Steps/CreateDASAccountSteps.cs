using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps
{
    [Binding]
    public class CreateDASAccountSteps
    {
        [When(@"I Create a DAS Account")]
        public void WhenICreateADASAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"An account should be ""(.*)""")]
        public void ThenAnAccountShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
