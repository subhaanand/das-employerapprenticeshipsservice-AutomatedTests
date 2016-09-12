using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class InviteTeamMemberSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();
        
        [Given(@"I have an account")]
        public void GivenIHaveAnAccount()
        {
            _navigationsteps.ViewAccount();
        }

        

        [Given(@"I invite ""(.*)"" with email ""(.*)"" to my team")]
        [When(@"I invite ""(.*)"" with email ""(.*)"" to my team")]
        [Then(@"I invite ""(.*)"" with email ""(.*)"" to my team")]
        public void GivenIInviteWithEmailToMyTeam(string username, string email)
        {
            _navigationsteps.InviteUsers(username, email);
        }


        [When(@"give them ""(.*)"" as a role")]
        public void WhenGiveThemAsARole(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        

    }
}
