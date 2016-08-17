namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    using OpenQA.Selenium;

    using SpecBind.Pages;
    [PageNavigation("/employeraccount/SelectEmployer")]
    public class SearchForCompanyPage : Shared.BasePage
    {
        [ElementLocator(TagName = "h1")]
        public IWebElement PageHeading { get; set; }
        [ElementLocator(Id = "EmployerRef")]
        public IWebElement CompanyHouseNumberTextBox { get; set; }

        [ElementLocator(CssSelector = "#content > div > div > form > button")]
        public IWebElement ContinueButton { get; set; }

        [ElementLocator(CssSelector = "#content > div:nth-child(2) > div > form > button")]
        public IWebElement AddCompanyToContractButton { get; set; }
        [ElementLocator(Id = "userId")]
        public IWebElement HMRCUserNameBox { get; set; }

        [ElementLocator(Id = "password")]
        public IWebElement HMRCPasswordBox { get; set; }

        [ElementLocator(Class = "button", Type = "submit", TagName = "button")]
        public IWebElement HMRCSignInButton { get; set; }

        [ElementLocator(Id = "authorise")]
        public IWebElement GrantAuthorityButton { get; set; }



    }
}
