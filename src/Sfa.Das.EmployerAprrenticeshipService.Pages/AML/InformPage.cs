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
    public class InformPage : BasePage
    {
        public InformPage(IWebDriver driver) : base(driver)
        {
        }
            public IWebElement StartButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var StartButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("button")));
                return StartButton;
            }
        }
    }
    
}
