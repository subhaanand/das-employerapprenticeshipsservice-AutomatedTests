using Sfa.Das.EmployerAprrenticeshipService.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    public class HMRCLoginPage : BasePage

    {
        public HMRCLoginPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement UserNameTextBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var UserNameTextBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("userId")));
                return UserNameTextBox;
            }
        }

        public IWebElement PasswordTextBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var PasswordTextBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
                return PasswordTextBox;
            }
        }

        public IWebElement SignInButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var SignInButton = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("button")));
                return SignInButton;
            }
        }
    }
}
