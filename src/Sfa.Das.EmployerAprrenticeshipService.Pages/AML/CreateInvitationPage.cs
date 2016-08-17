using OpenQA.Selenium;
using SpecBind.Pages;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    [PageNavigation("/EmployerTeam/Invite")]
    public class CreateInvitationPage : Shared.BasePage
    {
        [ElementLocator(Id = "Name")]
        public IWebElement NameTextBox { get; set; }

        [ElementLocator(Id = "Email")]
        public IWebElement EmailTextBox { get; set; }

        [ElementLocator(Id = "radio1")]
        public IWebElement OwnerOption { get; set; }
        [ElementLocator(Id = "radio2")]
        public IWebElement TransactorOption { get; set; }
        [ElementLocator(Id = "radio3")]
        public IWebElement ViewerOption { get; set; }
        [ElementLocator(TagName = "button", Type = "submit")]
        public IWebElement CreateButton { get; set; }

        [ElementLocator(Id = "invalidMessage")]
        public IWebElement ErrorMessage { get; set; }

    }
}

