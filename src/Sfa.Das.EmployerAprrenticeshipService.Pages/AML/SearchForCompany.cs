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
    public class SearchForCompany : BasePage
    {
        public SearchForCompany(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CompanyHouseTextBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CompanyHouseTextBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("EmployerRef")));
                return CompanyHouseTextBox;
            }
        }

        public IWebElement ContinueButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ContinueButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("button")));
                return ContinueButton;
            }
        }
    }
}
