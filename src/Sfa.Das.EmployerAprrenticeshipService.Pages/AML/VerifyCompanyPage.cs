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
    public class VerifyCompanyPage : BasePage
    {
        public VerifyCompanyPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CompanyName
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(10));
                var CompanyName = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("inline")));
                return CompanyName;
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
    }
}
