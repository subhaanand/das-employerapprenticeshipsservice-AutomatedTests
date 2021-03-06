﻿using Sfa.Das.EmployerAprrenticeshipService.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    public class TransactionsPage : BasePage
    {
        public TransactionsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TransactionsTable
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var TransactionsTable = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("responsive-tr")));
                return TransactionsTable;
            }
        }
        public IWebElement AnyViewLink
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AnyViewLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#transactions > div.responsive-tbody > div:nth-child(1) > div:nth-child(6) > div:nth-child(1) > a")));
                return AnyViewLink;
            }
        }
    }
}
