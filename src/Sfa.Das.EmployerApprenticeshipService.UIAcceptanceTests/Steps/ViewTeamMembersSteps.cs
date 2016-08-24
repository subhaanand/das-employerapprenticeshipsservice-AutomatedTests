using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests
{
    [Binding]
    public class ViewTeamMembersSteps
    {
        [Given(@"I have poeple on my team list")]
        public void GivenIHavePoepleOnMyTeamList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can view their role")]
        public void ThenICanViewTheirRole()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
