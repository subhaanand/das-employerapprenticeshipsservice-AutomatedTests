namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    using OpenQA.Selenium;

    using SpecBind.Pages;

    [PageNavigation("/EmployerAccount")]
    public class InformGuidancePage : Shared.BasePage
    {
        [ElementLocator(TagName = "h1")]
        public IWebElement PageHeading { get; set; }
        [ElementLocator(TagName = "button", Type = "submit")]
        public IWebElement StartAccountCreationButton { get; set; }


    }
}
