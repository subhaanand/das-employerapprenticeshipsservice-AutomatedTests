using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class InviteTeamMemberSteps
    {
        [Given(@"I have an account")]
        public void GivenIHaveAnAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I invite""(.*)"" to my team")]
        public void WhenIInviteToMyTeam(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"give them ""(.*)"" as a role")]
        public void WhenGiveThemAsARole(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"they are added to my team list")]
        public void ThenTheyAreAddedToMyTeamList()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
