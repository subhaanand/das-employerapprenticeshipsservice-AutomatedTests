using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sfa.Das.EmployerAprrenticeshipService.Pages;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps
{


    [Binding]
    public class CreateDASAccountSteps
    {
        [BeforeScenario]

        [Given(@"I Create a DAS Account")]
        [When(@"I Create a DAS Account")]
        public void WhenICreateADASAccount()
        {

            //TODO

        }

        [Then(@"An account should be ""(.*)""")]
        public void ThenAnAccountShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
