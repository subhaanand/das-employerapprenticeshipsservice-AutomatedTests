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
    public class HMRCResponsePage : BasePage
    {
        public HMRCResponsePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement AuthoriseButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AuthoriseButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("button")));
                return AuthoriseButton;
            }
        }

        public IWebElement DenyButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var DenyButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Do not grant authority")));
                return DenyButton;
            }
        }
    }
}
