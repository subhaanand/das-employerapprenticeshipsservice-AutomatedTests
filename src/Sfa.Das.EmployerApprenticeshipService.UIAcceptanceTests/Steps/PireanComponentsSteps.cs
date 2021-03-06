﻿using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps
{
    [Binding]
    public class PireanComponentsSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();        
        
        [Given(@"I login Pirean")]
        public void GivenILoginPirean()
        {
            _navigationsteps.LoginPirean();

        }

        [When(@"Pirean Login Page is Titled ""(.*)""")]
        [Then(@"Pirean Login Page is Titled ""(.*)""")]
        public void ThenPireanLoginPageIsTitled(string expectedTitle)
        {

            //_navigationsteps.checkPageTitle(expectedTitle);
        }       
                
     
        [AfterScenario]
        public void closeBrowser()
        {
            _navigationsteps.CloseBrowser();
        }
       

    }
}
