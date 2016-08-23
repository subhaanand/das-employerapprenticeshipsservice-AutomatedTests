using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class InviteTeamMemberSteps
    {
        [Given(@"I have a DAS Account")]
        public void GivenIHaveADASAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I invite ""(.*)""")]
        public void WhenIInvite(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"""(.*)"" is added to list of Team Members")]
        public void ThenIsAddedToListOfTeamMembers(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"invite status for""(.*)"" is ""(.*)""")]
        [When(@"invite status for""(.*)"" is ""(.*)""")]
        [Then(@"invite status for""(.*)"" is ""(.*)""")]
        public void ThenStatusIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
