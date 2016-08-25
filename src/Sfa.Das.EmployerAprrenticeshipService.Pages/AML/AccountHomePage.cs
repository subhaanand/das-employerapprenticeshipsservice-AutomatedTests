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
    public class AccountHomePage : BasePage
    {
        public AccountHomePage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement TeamLink
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var TeamLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Team")));
                return TeamLink;
            }
        }

        public IWebElement FundingLink
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var FundingLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Funding")));
                return FundingLink;
            }
        }
        public IWebElement AgreementsLink
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AgreementsLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Agreements")));
                return AgreementsLink;
            }
        }
        public IWebElement PAYELink
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var PAYELink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("PAYE")));
                return PAYELink;
            }
        }

    }
}
