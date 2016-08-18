using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using Sfa.Das.EmployerAprrenticeshipService.Pages;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps.NavigationSteps
{
    public  class CoreSteps
    {
        private IWebDriver Driver = new ChromeDriver();      
        public string username = ConfigurationManager.AppSettings["PireanUsername"];
        public string password = ConfigurationManager.AppSettings["PireanPassword"];
        
        public void LoadStartPage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
        }

        public void LoginPirean()
        {
            LoadStartPage();
            PireanLoginPage LoginPage = new PireanLoginPage(Driver);
            LoginPage.UsernameBox.SendKeys(username);
            LoginPage.PasswordBox.SendKeys(password);
            LoginPage.LoginButton.Click();
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }

        //public void checkPageTitle(string expectedTitle)
        //{
        //    string actualTtile = Driver.Title;
        //    StringAssert.Equals(actualTtile, expectedTitle);
            
        //}

        public void CreateADasAccount()
        {
            LoginPirean();
            ClickCreateAccountButton();
        }
        public void ClickCreateAccountButton()
        {
            ///LoginPirean();
            ServiceLandingPage ServicePage = new ServiceLandingPage(Driver);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            ServicePage.CreateAccountButton.Click();


        }
    }
}
