using OpenQA.Selenium;
using SpecBind.Pages;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    [PageNavigation("/EmployerTeam/Review?")]
    public class TeamMemberReview : Shared.BasePage
    {
        [ElementLocator(Class = "th-nopadding")]
        public IWebElement MemberDetails { get; set; }

        [ElementLocator(Text = "Change")]
        public IWebElement ChangeRoleLink { get; set; }

        [ElementLocator(TagName = "button", Text = "CancelInvitation", Type = "submit")]
        public IWebElement CancelInvitationButton { get; set; }
    }
}
