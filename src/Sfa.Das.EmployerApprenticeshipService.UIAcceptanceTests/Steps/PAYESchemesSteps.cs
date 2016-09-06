using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class PAYESchemesSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();


        [Given(@"I add a PAYE scheme for ""(.*)""")]
        [When(@"I add a PAYE scheme for ""(.*)""")]
        public void WhenIAddAPAYESchemeFor(string companyNumber)
        {
            _navigationsteps.AddPayeScheme(companyNumber);
        }


        [When(@"I remove a PAYE scheme")]
        public void WhenIRemoveAPAYEScheme()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"PAYE scheme is added")]
        public void ThenPAYESchemeIsAdded()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I can view a PAYE scheme")]
        [Then(@"I can view a PAYE scheme")]
        public void ThenICanViewAPAYEScheme()
        {
            _navigationsteps.ViewExistingPayeSchemes();
        }
        
        [Then(@"PAYE scheme is removed")]
        public void ThenPAYESchemeIsRemoved()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
