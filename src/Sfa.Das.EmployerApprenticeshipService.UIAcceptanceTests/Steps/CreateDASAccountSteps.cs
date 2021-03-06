﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using Sfa.Das.EmployerAprrenticeshipService.Pages;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps
{
    

    [Binding]
    public class CreateDASAccountSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();
        
        [AfterScenario]
        public void closeBrowser()
        {
            _navigationsteps.Quit();
        }
        [Given(@"I Create a DAS Account")]
        [When(@"I Create a DAS Account")]
        [Then(@"I Create a DAS Account")]
        public void WhenICreateADASAccount()
        {

            _navigationsteps.CreateADasAccount();

        }

        [Then(@"An account should be added")]
        public void ThenAnAccountShouldBe()
        {
            _navigationsteps.CheckAccountNameAdded();
        }

        [Given(@"I view account")]
        [When(@"I view account")]
        public void WhenIViewAccount()
        {
            _navigationsteps.ViewAccount();
        }

        [Given(@"I see Account landing page with its elements")]
        [Then(@"I see Account landing page with its elements")]
        public void ThenISeeAccountLandingPageWithItsElements()
        {
            _navigationsteps.checkAccounthomepage();
        }


    }
}
