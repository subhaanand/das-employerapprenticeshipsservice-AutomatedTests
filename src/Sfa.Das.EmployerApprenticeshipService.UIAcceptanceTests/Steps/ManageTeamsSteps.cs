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

        [Then(@"they are added to my team list as ""(.*)""")]
        public void ThenTheyAreAddedToMyTeamListAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I cancel their invitation")]
        public void WhenICancelTheirInvitation()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"they are removed from my team list")]
        public void ThenTheyAreRemovedFromMyTeamList()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
