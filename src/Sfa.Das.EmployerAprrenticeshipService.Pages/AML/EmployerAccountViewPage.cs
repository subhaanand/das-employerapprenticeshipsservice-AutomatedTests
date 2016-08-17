using OpenQA.Selenium;
using SpecBind.Pages;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    [PageNavigation("/EmployerTeam?")]
    public class EmployerAccountViewPage : Shared.BasePage
    {

        [ElementLocator(TagName = "h1")]
        public IWebElement PageHeading { get; set; }


        [ElementLocator(TagName = "table")]
        public IWebElement TeamTable { get; set; }

        [ElementLocator(CssSelector = "#content > div > div > div > div:nth-child(1) > div:nth-child(1) > h3 > a")]
        public IWebElement TeamLink { get; set; }



    }
}
