using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class ManageTeamsSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();

        
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
        public void ThenTheyAreAddedToMyTeamListAs(string email)
        {
            _navigationsteps.viewTeamListForinvited(email);
        }

        [When(@"I cancel their invitation")]
        public void WhenICancelTheirInvitation()
        {
            _navigationsteps.CancelInvitation();
        }

        [Then(@"they are removed from my team list")]
        public void ThenTheyAreRemovedFromMyTeamList()
        {
            ScenarioContext.Current.Pending();
        }
        [Given(@"I view second member on the list")]
        public void GivenIViewSecondMemberOnTheList()
        {
            _navigationsteps.ViewSecondMember();
        }


    }
}
