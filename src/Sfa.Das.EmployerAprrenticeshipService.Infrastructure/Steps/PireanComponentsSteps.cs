using Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps
{
    [Binding]
    public class PireanComponentsSteps
    {

        private PireanLoginPage _LoginPage = new PireanLoginPage();
        public string username = ConfigurationManager.AppSettings["PireanUsername"];
        public string password = ConfigurationManager.AppSettings["PireanPassword"];



        [Given(@"I load Pirean")]
        public void GivenILoadPirean()
        {
            _LoginPage.LoadStartPage();
        }

        [Given(@"I login Pirean")]
        public void GivenILoginPirean()
        {
            _LoginPage.loginPirean(username, password);

        }

        [When(@"Pirean Login Page is Titled ""(.*)""")]
        [Then(@"Pirean Login Page is Titled ""(.*)""")]
        public void ThenPireanLoginPageIsTitled(string expectedTitle)
        {
            _LoginPage.expectedPireanPageTitle(expectedTitle);
        }

        [Then(@"I see the Register Button")]
        public void ThenISeeTheRegisterButton()
        {
            _LoginPage.findRegisterLink();
        }


        [When(@"I refresh the page")]
        public void WhenIRefreshThePage()
        {
            _LoginPage.pageRefresh();
        }
        //[AfterScenario]
        //[Then(@"Close Browser")]
        //public void ThenCloseBrowser()
        //{
        //    _LoginPage.quit();

        //}

    }
}
