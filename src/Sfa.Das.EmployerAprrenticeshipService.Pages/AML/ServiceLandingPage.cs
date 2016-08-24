using System;
using OpenQA.Selenium;
using System.Configuration;
using SpecBind.Selenium;
using OpenQA.Selenium.Chrome;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Shared;
using OpenQA.Selenium.Support.UI;

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
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CreateAccountButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("button")));
                return CreateAccountButton;
            }
        }

        public IWebElement StartButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var StartButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("button-start")));
                return StartButton;
            }
        }


        public IWebElement AccountAdded
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AccountAdded = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("responsive-td")));
                return AccountAdded;
            }
        }

        

    }
}
