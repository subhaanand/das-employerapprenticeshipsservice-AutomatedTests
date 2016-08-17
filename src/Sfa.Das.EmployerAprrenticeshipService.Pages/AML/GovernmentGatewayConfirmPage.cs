namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    using OpenQA.Selenium;

    using SpecBind.Pages;

    [PageNavigation("/employeraccount/GovernmentGatewayConfirm")]
    public class GovernmentGatewayConfirmPage : Shared.BasePage
    {
        [ElementLocator(TagName = "h1")]
        public IWebElement PageHeading { get; set; }
        [ElementLocator(Id = "radio1")]
        public IWebElement YesOption { get; set; }
        [ElementLocator(Class = "button")]
        public IWebElement ContinueButton { get; set; }
    }
}