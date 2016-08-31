using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class TransactionsSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();


        [Given(@"I view transactions")]
        [When(@"I view transactions")]
        [Then(@"I view transactions")]
        public void WhenIViewAMonthlyTransaction()
        {
            _navigationsteps.viewTransactionsPage();
        }

        [Then(@"Transactions page is displayed")]
        public void ThenTransactionsPageIsDisplayed()
        {
            _navigationsteps.viewTransactionsTable();
        }

    }
}
