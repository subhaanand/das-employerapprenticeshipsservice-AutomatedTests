using System;
using OpenQA.Selenium;
using System.Configuration;
using SpecBind.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages
{
    public class ServiceLandingPage
    {
        private readonly IWebDriver Driver;
        public ServiceLandingPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebElement CreateAccountButton
        {
            get
            {
                var CreateAccountButton = Driver.FindElement(By.ClassName("button"));
                return CreateAccountButton;
            }
        }

    }
}
