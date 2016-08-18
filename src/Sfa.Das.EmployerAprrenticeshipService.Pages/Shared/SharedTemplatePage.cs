namespace Sfa.Das.EmployerAprrenticeshipService.Pages.Shared
{
    using OpenQA.Selenium;
    using SpecBind.Pages;

    public abstract class BasePage
    {
        public readonly IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

       
    }
}
