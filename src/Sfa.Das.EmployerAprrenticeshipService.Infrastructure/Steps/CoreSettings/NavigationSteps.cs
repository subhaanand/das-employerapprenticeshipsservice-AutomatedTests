﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using Sfa.Das.EmployerAprrenticeshipService.Pages;
using Sfa.Das.EmployerAprrenticeshipService.Pages.AML;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps.NavigationSteps
{
    public  class CoreSteps
    {
        private IWebDriver Driver = new ChromeDriver();      
        public string username = ConfigurationManager.AppSettings["PireanUsername"];
        public string password = ConfigurationManager.AppSettings["PireanPassword"];
        public string CompanyNumber = ConfigurationManager.AppSettings["CompanyNumber"];
        public string CompanyNameExpected = ConfigurationManager.AppSettings["CompanyName"];
        public string HMRCUsername = ConfigurationManager.AppSettings["HMRCUN"];
        public string HMRCPassword = ConfigurationManager.AppSettings["HMRCPW"];

        public void LoadStartPage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
        }

        public void LoginPirean()
        {
            LoadStartPage();
            PireanLoginPage LoginPage = new PireanLoginPage(Driver);
            LoginPage.UsernameBox.SendKeys(username);
            LoginPage.PasswordBox.SendKeys(password);
            LoginPage.LoginButton.Click();
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }

        //public void checkPageTitle(string expectedTitle)
        //{
        //    string actualTtile = Driver.Title;
        //    StringAssert.Equals(actualTtile, expectedTitle);
            
        //}

        public void CreateADasAccount()
        {
            LoginPirean();
            ClickCreateAccountButton();
            ClickStartButton();
            ConfirmGatewayCredentials();
            SearchForCompany();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));//wait for company house to return
            VerifyCompany();
            LoginHmrcCredentials();
            //GrantAuthority();
            DenyAuthority();

        }
        public void ClickCreateAccountButton()
        {
            ServiceLandingPage ServicePage = new ServiceLandingPage(Driver);          
            ServicePage.CreateAccountButton.Click();
        }

        public void ClickStartButton()
        {
            InformPage informPage = new InformPage(Driver);
            informPage.StartButton.Click();
        }

        public void ConfirmGatewayCredentials()
        {
            GatewayConfirmPage gatewayconfirmPage = new GatewayConfirmPage(Driver);
            gatewayconfirmPage.YesOption.Click();
            gatewayconfirmPage.ContinueButton.Click();
        }

        public void SearchForCompany()
        {
            SearchForCompany searchforcompany = new SearchForCompany(Driver);
            searchforcompany.CompanyHouseTextBox.SendKeys(CompanyNumber);
            searchforcompany.ContinueButton.Click();
        }

        public void VerifyCompany()
        {
            VerifyCompanyPage verifycompanypage = new VerifyCompanyPage(Driver);
            string companynamereturned = verifycompanypage.CompanyName.Text;
            StringAssert.Contains(CompanyNameExpected, companynamereturned);

            verifycompanypage.ContinueButton.Click();
        }

        public void LoginHmrcCredentials()
        {
            HMRCLoginPage hmrcpage = new HMRCLoginPage(Driver);
            hmrcpage.UserNameTextBox.SendKeys(HMRCUsername);
            hmrcpage.PasswordTextBox.SendKeys(HMRCPassword);
            hmrcpage.SignInButton.Click();
        }

        public void GrantAuthority()
        {
            HMRCResponsePage hmrcresponsepage = new HMRCResponsePage(Driver);
            hmrcresponsepage.AuthoriseButton.Click();
        }
        public void DenyAuthority()
        {
            HMRCResponsePage hmrcresponsepage = new HMRCResponsePage(Driver);
            hmrcresponsepage.DenyButton.Click();
        }

    }
}
