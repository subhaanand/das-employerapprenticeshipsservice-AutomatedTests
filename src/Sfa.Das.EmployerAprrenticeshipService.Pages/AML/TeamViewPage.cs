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
    public class TeamViewPage : BasePage
    {
        public TeamViewPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement TeamList
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var TeamList = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("responsive-table")));
                return TeamList;
            }
        }

        public IWebElement AddUserButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AddUserButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("addNewUser")));
                return AddUserButton;
            }
        }

        public IWebElement ViewSecondMember
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                //not ideal to use css selector but no choice
                var ViewSecondMember = wait.Until(ExpectedConditions.ElementToBeClickable
                    (By.CssSelector
                    ("#content > div:nth-child(2) > div > div > div.responsive-tbody > div:nth-child(2) > div:nth-child(5) > div:nth-child(1) > a"
                    )));
                return ViewSecondMember;
            }
        }
    }
}
