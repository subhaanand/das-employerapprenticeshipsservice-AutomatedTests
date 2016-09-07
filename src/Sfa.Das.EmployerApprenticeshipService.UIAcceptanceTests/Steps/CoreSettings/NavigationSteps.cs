using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sfa.Das.EmployerAprrenticeshipService.Pages;
using Sfa.Das.EmployerAprrenticeshipService.Pages.AML;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean;
using System;
using System.Configuration;

namespace Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps
{
    public class CoreSteps
    {
        
        private IWebDriver Driver = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriver"].ToString());  
              
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
            ClickLoginButton();
            PireanLoginPage LoginPage = new PireanLoginPage(Driver);
            LoginPage.UsernameBox.Clear();
            LoginPage.UsernameBox.SendKeys(username);
            LoginPage.PasswordBox.Clear();
            LoginPage.PasswordBox.SendKeys(password);
            LoginPage.LoginButton.Click();            
        }
        public void CloseBrowser()
        {
            Driver.Quit();
        }        
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
            GrantAuthority();//empref restriction means this can only run once
            /*DenyAuthority();*/
            ApproveAccountCreation();
            //DenyAccountCreation();
            Logout();
            //CheckAccountNameAdded();

        }
        public void CreatePireanAccountSetFirstName(string firstname)
        {
            PireanRegisterPage pireanregisterpage = new PireanRegisterPage(Driver);
            pireanregisterpage.FirstNameBox.SendKeys(firstname);
        }
        public void CreatePireanAccountSetLastName(string lastname)
        {
            PireanRegisterPage pireanregisterpage = new PireanRegisterPage(Driver);
            pireanregisterpage.LastNameBox.SendKeys(lastname);
        }
        public void CreatePireanAccountSetEmail(string email)
        {
            PireanRegisterPage pireanregisterpage = new PireanRegisterPage(Driver);
            pireanregisterpage.EmailBox.SendKeys(email);

        }
        public void CreatePireanAccountSetPassword(string password)
        {
            PireanRegisterPage pireanregisterpage = new PireanRegisterPage(Driver);            
            pireanregisterpage.PasswordBox.SendKeys(password);
            pireanregisterpage.PasswordConfirmBox.SendKeys(password);
        }
        public void AckonowledgeandCreatePireanAccount()
        {
            PireanRegisterPage pireanregisterpage = new PireanRegisterPage(Driver);
            pireanregisterpage.AgreeCheckBox.Click();
            pireanregisterpage.CreateAnAccountButton.Click();
            //TO DO
        }
        public void RegisterNewUser()
        {
            LoadStartPage();
            ClickLoginButton();
            PireanLoginPage pireanloginpage = new PireanLoginPage(Driver);
            pireanloginpage.CreateAccountLink.Click();
        }
        public void ClickCreateAccountButton()
        {
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.CreateAccountButton.Click();
        }
        public void ClickLoginButton()
        {
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.StartButton.Click();
        }
        public void ClickStartButton()
        {
            InformPage informpage = new InformPage(Driver);
            informpage.StartButton.Click();
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
            searchforcompany.CompanyHouseTextBox.Clear();
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
            hmrcpage.UserNameTextBox.Clear();
            hmrcpage.PasswordTextBox.Clear();
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
        public void ApproveAccountCreation()
        {
            AccountCreationApprovalPage accountcreationapprovalpage = new AccountCreationApprovalPage(Driver);
            string actualcompanynamedisplayed = accountcreationapprovalpage.CompanyNameForAccount.Text;
            StringAssert.Contains(CompanyNameExpected, actualcompanynamedisplayed);
            accountcreationapprovalpage.YesOption.Click();
            accountcreationapprovalpage.ContinueButton.Click();
        }
        public void DenyAccountCreation()
        {
            AccountCreationApprovalPage accountcreationapprovalpage = new AccountCreationApprovalPage(Driver);
            string actualcompanynamedisplayed = accountcreationapprovalpage.CompanyNameForAccount.Text;
            StringAssert.Contains(CompanyNameExpected, actualcompanynamedisplayed);
            accountcreationapprovalpage.NoOption.Click();
            accountcreationapprovalpage.ContinueButton.Click();
        }
        public void CheckAccountNameAdded()
        {
            LoginPirean();
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            string accountadded = servicelandingpage.AccountAdded.Text;
            accountadded.Contains(CompanyNameExpected);
        }
        public void ViewAccount()
        {
            LoginPirean();
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.OpenAccountLink.Click();
            checkAccounthomepage();

        }
        public void Quit()
        {
            Driver.Quit();
        }
        public void Logout()
        {
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.LogoutLink.Click();
        }
        public void checkAccounthomepage()
        {
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.AgreementsLink.Displayed.Equals(true);
            accounthomepage.FundingLink.Displayed.Equals(true);
            accounthomepage.PAYELink.Displayed.Equals(true);
            accounthomepage.TeamLink.Displayed.Equals(true);
        }        
        public void viewTransactionsPage()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.FundingLink.Click();
            TransactionsPage transactionspage = new TransactionsPage(Driver);
            transactionspage.TransactionsTable.Displayed.Equals(true);
        }        
        public void ViewExistingPayeSchemes()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.PAYELink.Click();
            PayeSchemesPage payeschemespage = new PayeSchemesPage(Driver);            
            string existingpayeeschemes = payeschemespage.ListOfPaye.Text;
            existingpayeeschemes.Contains("111/AA00001 OPTISOURCE TECHNOLOGY SOLUTIONS LIMITED");
        }        
        public void AddPayeScheme(string companyNumber)
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.PAYELink.Click();
            PayeSchemesPage payeschemespage = new PayeSchemesPage(Driver);
            payeschemespage.AddPayeButton.Click();
        }       
        public void viewTransactionsTable()
        {
            TransactionsPage transactionspage = new TransactionsPage(Driver);
            transactionspage.TransactionsTable.Displayed.Equals(true);
            transactionspage.AnyViewLink.Click();
            
        }
        public void viewTeamList()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            string teammembers = teamviewpage.TeamList.Text;
            teammembers.Contains(username);

        }
        public void viewTeamListForinvited(string username)
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            string teammembers = teamviewpage.TeamList.Text;
            teammembers.Contains(username);

        }
        public void ViewSecondMember()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            string teammembers = teamviewpage.TeamList.Text;
            teammembers.Contains(username);
            teamviewpage.ViewSecondMember.Click();
            
        }
        public void CancelInvitation()
        {
            MemberDetailsPage memberdetailspage = new MemberDetailsPage(Driver);
            memberdetailspage.CancelInvitationButton.Click();
            CancelInvitationPage cancelinvitationpage = new CancelInvitationPage(Driver);
            cancelinvitationpage.YesRadioOption.Click();
            cancelinvitationpage.ContinueButton.Click();
        }
        public void InviteUsers(string username, string email)
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            teamviewpage.AddUserButton.Click();
            CreateInvitationPage createinvitationpage = new CreateInvitationPage(Driver);            
            createinvitationpage.NameTextBox.Clear();
            createinvitationpage.NameTextBox.SendKeys(username);
            createinvitationpage.EmailTextBox.Clear();
            createinvitationpage.EmailTextBox.SendKeys(email);
            createinvitationpage.ViewerRadioButton.Click();
            createinvitationpage.CreateButton.Click();
        }

    }
}
