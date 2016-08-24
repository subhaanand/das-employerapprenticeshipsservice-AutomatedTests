using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class InviteTeamMemberSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();

        [AfterScenario]
        public void ClearDown()
        {
            _navigationsteps.Quit();
        }
        [Given(@"I have an account")]
        public void GivenIHaveAnAccount()
        {
            _navigationsteps.CheckAccountNameAdded();
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
        

    }
}
