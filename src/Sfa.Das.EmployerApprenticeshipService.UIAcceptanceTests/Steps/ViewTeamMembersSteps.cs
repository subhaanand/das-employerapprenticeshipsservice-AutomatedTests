using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests
{
    [Binding]
    public class ViewTeamMembersSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();


        [Then(@"I have people on my team list")]
        [Given(@"I have people on my team list")]
        public void GivenIHavePeopleOnMyTeamList()
        {
            _navigationsteps.viewTeamList();
        }
        
        [Then(@"I can view their role")]
        public void ThenICanViewTheirRole()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
