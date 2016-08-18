namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    using OpenQA.Selenium;
    using Shared;
    using SpecBind.Pages;
    



    [PageNavigation("/")]
    public class StartPage : BasePage
    {
        [ElementLocator(Id = "username")]
        public IWebElement UserNameBox { get; set; }

        [ElementLocator(Id = "password")]
        public IWebElement PasswordBox { get; set; }

        [ElementLocator(Value = "Log in", TagName = "button")]
        public IWebElement LoginButton { get; set; }

        [ElementLocator(Class = "button")]
        public IWebElement CreateNewEmployerAccount { get; set; }

        //TO DO: CHANGE OPEN LINK SELECTOR
        [ElementLocator(CssSelector = "#content > div:nth-child(2) > div > div > div.responsive-tbody > div > div:nth-child(3) > div:nth-child(1) > a")]
        public IWebElement openAccountLink { get; set; }
    }
}
