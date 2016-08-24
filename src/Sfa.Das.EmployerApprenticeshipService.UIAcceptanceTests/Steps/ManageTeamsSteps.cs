using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class ManageTeamsSteps
    {
        [Then(@"I can delete a member")]
        public void ThenICanDeleteAMember()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I cannot delete myself")]
        public void ThenICannotDeleteMyself()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
