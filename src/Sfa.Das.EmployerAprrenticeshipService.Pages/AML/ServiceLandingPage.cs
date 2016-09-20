using System;
using OpenQA.Selenium;
using System.Configuration;
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
                  

        public IWebElement AddAccountButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CreateAccountButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("add_new_account")));
                return CreateAccountButton;
            }
        }

        public IWebElement SigninButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var StartButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("sign_in")));
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

        public IWebElement OpenAccountLink
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var OpenAccountLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Open")));
                return OpenAccountLink;
            }
        }

        public IWebElement ClickCheckStatement
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ClickCheckStatement = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("understood")));
                return ClickCheckStatement;
            }
        }



    }
}
