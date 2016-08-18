using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean
{
    public class PireanLoginPage
    {
        private readonly IWebDriver Driver;

        public PireanLoginPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

            public IWebElement UsernameBox
            {
                get
                {
                    var UsernameBox = Driver.FindElement(By.Id("email"));
                    return UsernameBox;
                }
            }
            public IWebElement PasswordBox
            {
                get
                {
                    var PasswordBox = Driver.FindElement(By.Id("password"));
                    return PasswordBox;
                }
            }

        }


    }

