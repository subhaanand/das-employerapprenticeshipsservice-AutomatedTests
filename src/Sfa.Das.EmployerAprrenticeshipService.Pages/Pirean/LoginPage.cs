using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean
{
    public class PireanLoginPage
    {
        private IWebDriver Driver = new ChromeDriver();
        private int waitPeriod = Int32.Parse(ConfigurationManager.AppSettings["WaitinSeconds"]);
        #region Common Methods
        public void findRegisterLink()
        {
            try
            {
                bool isRegisterlinkDisplayed = Driver.FindElement(By.CssSelector("#navbar-collapse > ul > li > a")).Displayed;

            }
            catch (Exception)
            {
                Console.WriteLine("Register Link not found");
                throw;

            }

        }


        public void loginPirean(string username, string password)
        {
            LoadStartPage();

            Driver.FindElement(By.Id("email")).SendKeys(username);
            Driver.FindElement(By.Id("password")).SendKeys(password);
            Driver.FindElement(By.TagName("button")).Click();
        }
        public void LoadStartPage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
        }

        public void quit()
        {
            Driver.Quit();
        }

        public void wait()
        {
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(waitPeriod));
        }

        public void pageRefresh()
        {
            Driver.Navigate().Refresh();
        }

        public void expectedPireanPageTitle(string expectedTitle)
        {
            string ActualPireanPageTitle = Driver.FindElement(By.ClassName("heading-large")).Text;
            Assert.AreEqual(expectedTitle, ActualPireanPageTitle);
        }
        #endregion

    }
}