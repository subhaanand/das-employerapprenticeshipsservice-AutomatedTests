namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    using OpenQA.Selenium;

    using SpecBind.Pages;

    [PageNavigation("/employeraccount/Gateway?")]
    public class GatewayLoginPage : Shared.BasePage
    {
        [ElementLocator(TagName = "h1")]
        public IWebElement PageHeading { get; set; }
        [ElementLocator(Id = "Email")]
        public IWebElement EmailTextBox { get; set; }

        [ElementLocator(Id = "Password")]
        public IWebElement PasswordTextBox { get; set; }

        [ElementLocator(TagName = "button", Type = "submit")]
        public IWebElement ContinueButton { get; set; }
    }
}

