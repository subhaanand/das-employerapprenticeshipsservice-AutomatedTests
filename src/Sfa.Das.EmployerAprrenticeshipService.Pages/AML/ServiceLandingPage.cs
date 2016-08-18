using System;
using OpenQA.Selenium;
using System.Configuration;
using SpecBind.Selenium;
using OpenQA.Selenium.Chrome;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Shared;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages
{
    public class ServiceLandingPage :BasePage
    {
        public ServiceLandingPage(IWebDriver driver) : base(driver)
        {
           
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
