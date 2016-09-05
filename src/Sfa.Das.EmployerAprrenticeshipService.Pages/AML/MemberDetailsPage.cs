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
    public class MemberDetailsPage : BasePage
    {
        public MemberDetailsPage(IWebDriver driver) : base(driver)
        {
        }
         public IWebElement CancelInvitationButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CancelInvitationButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#content > div > div > form:nth-child(7) > button")));
                return CancelInvitationButton;
            }
        }
    }
}
