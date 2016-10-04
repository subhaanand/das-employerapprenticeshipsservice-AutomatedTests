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
    public class AccountCreationApprovalPage : BasePage
    {
        public AccountCreationApprovalPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CompanyNameForAccount
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CompanyNameForAccount = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("bold-large")));
                return CompanyNameForAccount;
            }
        }
        public IWebElement YesOption
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var YesOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("radio1")));
                return YesOption;
            }
        }
        public IWebElement NoOption
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var NoOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("radio2")));
                return NoOption;
            }
        }
        public IWebElement ContinueButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ContinueButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("continue")));
                return ContinueButton;
            }
        }
            public IWebElement SignAgreementBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var SignAgreementBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("userAuthorised")));
                return SignAgreementBox;
            }
        }
        public IWebElement SignAgreementBtn
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var SignAgreementBtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("signAgreement")));
                return SignAgreementBtn;
            }
        }
    }
}


