using OpenQA.Selenium;
using SpecBind.Pages;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    [PageNavigation("/EmployerTeam/Invite?")]
    public class MemberInvite : Shared.BasePage
    {
        [ElementLocator(Class = "button", Type = "submit", TagName = "button")]
        public IWebElement CreateButton { get; set; }

        [ElementLocator(Id = "Name")]
        public IWebElement NameTextBox { get; set; }

        [ElementLocator(Id = "Email")]
        public IWebElement EmailTextBox { get; set; }

        [ElementLocator(Id = "radio1")]
        public IWebElement ViewerRoleRadioButton { get; set; }

        [ElementLocator(Id = "radio3")]
        public IWebElement TransactorRoleRadioButton { get; set; }

        [ElementLocator(Id = "radio3")]
        public IWebElement OwnerRoleRadioButton { get; set; }
    }
}
