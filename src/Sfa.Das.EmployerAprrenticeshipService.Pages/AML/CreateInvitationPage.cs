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
    public class CreateInvitationPage : BasePage
    {
        public CreateInvitationPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement NameTextBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var NameTextBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Name")));
                return NameTextBox;
            }
        }

        public IWebElement EmailTextBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var EmailTextBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Email")));
                return EmailTextBox;
            }
        }

        public IWebElement ViewerRadioButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ViewerRadioButton = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("radio1")));
                return ViewerRadioButton;
            }
        }

        public IWebElement TransactorRadioButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var TransactorRadioButton = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("radio2")));
                return TransactorRadioButton;
            }
        }
        public IWebElement OwnerRadioButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var OwnerRadioButton = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("radio3")));
                return OwnerRadioButton;
            }
        }
        public IWebElement CreateButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CreateButton = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("button")));
                return CreateButton;
            }
        }

    }
}
