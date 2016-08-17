namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    using OpenQA.Selenium;
    using SpecBind.Pages;

    [PageNavigation("/EmployerAccount/Summary")]
    public class EmployerSummaryPage : Shared.BasePage
    {
        [ElementLocator(TagName = "h1")]
        public IWebElement PageHeading { get; set; }

        [ElementLocator(Id = "radio1")]
        public IWebElement YesOption { get; set; }

        [ElementLocator(Id = "radio2")]
        public IWebElement NoOption { get; set; }

        [ElementLocator(TagName = "button", Type = "submit")]
        public IWebElement ContinueButton { get; set; }
    }
}