﻿using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerApprenticeshipService.UIAcceptanceTests
{
    [Binding]
    public class ViewTeamMembersSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();

       
        [Given(@"I have people on my team list")]
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
