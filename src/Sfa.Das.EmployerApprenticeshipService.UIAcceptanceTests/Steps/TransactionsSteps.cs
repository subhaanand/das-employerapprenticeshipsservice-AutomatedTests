using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class TransactionsSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();
       

        [When(@"I view a monthly transaction")]
        public void WhenIViewAMonthlyTransaction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a detailed view is displayed")]
        public void ThenADetailedViewIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
