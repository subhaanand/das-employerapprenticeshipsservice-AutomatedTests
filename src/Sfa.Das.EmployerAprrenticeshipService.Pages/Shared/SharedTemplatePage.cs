namespace Sfa.Das.EmployerAprrenticeshipService.Pages.Shared
{
    using OpenQA.Selenium;
    using SpecBind.Pages;

    public abstract class BasePage
    {


        #region Common ELements
        [ElementLocator(Text = "Sign In/ Register")]
        public IWebElement SignInLink { get; set; }

        [ElementLocator(Text = "Log out")]
        public IWebElement Logout { get; set; }

        #endregion
    }
}
