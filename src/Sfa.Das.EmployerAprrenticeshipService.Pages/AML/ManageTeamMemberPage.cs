using OpenQA.Selenium;
using SpecBind.Pages;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    [PageNavigation("/EmployerTeam/Review")]
    public class ManageTeamMemberPage : Shared.BasePage
    {
        [ElementLocator(TagName = "table")]
        public IWebElement TeamMemberDetails { get; set; }

        [ElementLocator(Text = "Resend Invitation")]
        public IWebElement ResendInvitation { get; set; }

        [ElementLocator(Text = "Cancel Invitation")]
        public IWebElement CancelInvitation { get; set; }
    }
}

