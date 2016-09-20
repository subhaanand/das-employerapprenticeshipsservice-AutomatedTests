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
        public IWebElement AddPayeDraft
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AddPayeDraft = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("confirmPayeVisibility")));
                return AddPayeDraft;
            }
        }
        public IWebElement ContinuePaye
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(0));
                var ContinuePaye = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("continue")));
                return ContinuePaye;
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
        public IWebElement RemoveScheme
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var RemoveScheme = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Remove")));
                return RemoveScheme;

            }
        }
        public IWebElement ConfirmRemoval
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ConfirmRemoval = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(" //span[text()='Yes, remove scheme']")));
                return ConfirmRemoval;
            }
        }
        public IWebElement ContinueRemoval
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ContinueRemoval = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("button")));
                return ContinueRemoval;
            }
        }
        public IWebElement PayeSchemeRemoved
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var PayeSchemeRemoved = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("govuk-box-highlight")));
                return PayeSchemeRemoved;
            }
        }
    }
}
