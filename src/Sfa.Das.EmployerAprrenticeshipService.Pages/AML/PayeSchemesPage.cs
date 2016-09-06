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
    public class PayeSchemesPage : BasePage
    {
        public PayeSchemesPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement AddPayeButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AddPayeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("addNewPaye")));
                return AddPayeButton;
            }
        }

        public IWebElement ListOfPaye
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ListOfPaye = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("responsive-table")));
                return ListOfPaye;
            }
        }
    }
}
