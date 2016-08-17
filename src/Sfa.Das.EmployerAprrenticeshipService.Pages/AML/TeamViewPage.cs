using OpenQA.Selenium;
using SpecBind.Pages;

namespace Sfa.Das.EmployerAprrenticeshipService.Pages.AML
{
    [PageNavigation("/EmployerTeam/View?")]
    public class TeamView : Shared.BasePage
    {
        [ElementLocator(Id = "addNewUser")]
        public IWebElement InviteButton { get; set; }
        [ElementLocator(Class = "responsive-table")]
        public IWebElement TeamListTable { get; set; }

        [ElementLocator(Class = "responsive-table")]
        public IWebElement ListofMembers { get; set; }


        [ElementLocator(Class = "responsive-tbody")]
        public IWebElement TeamDetails { get; set; }

        [ElementLocator(Title = "View details for Jane Doe", TagName = "a")]
        public IWebElement ViewLinkJane { get; set; }
        [ElementLocator(Title = "View details for John Doe", TagName = "a")]
        public IWebElement ViewLinkJohn { get; set; }
    }
}

