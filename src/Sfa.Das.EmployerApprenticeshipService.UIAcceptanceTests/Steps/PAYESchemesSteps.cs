using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class PAYESchemesSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();

       
        [When(@"I add a PAYE scheme")]
        public void WhenIAddAPAYEScheme()
        {
            ScenarioContext.Current.Pending();
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
        
        [Then(@"I can view a PAYE scheme")]
        public void ThenICanViewAPAYEScheme()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"PAYE scheme is removed")]
        public void ThenPAYESchemeIsRemoved()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
