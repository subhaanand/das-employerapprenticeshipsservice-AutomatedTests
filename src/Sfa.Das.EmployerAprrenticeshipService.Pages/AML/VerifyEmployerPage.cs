using OpenQA.Selenium;
using SpecBind.Pages;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    [PageNavigation("/employeraccount/VerifyEmployer?")]
    public class VerifyEmployer : Shared.BasePage
    {

        [ElementLocator(TagName = "h1")]
        public IWebElement PageHeading { get; set; }
        [ElementLocator(CssSelector = "#content > div:nth-child(2) > div > form > button")]
        public IWebDriver Button { get; set; }
    }
}

