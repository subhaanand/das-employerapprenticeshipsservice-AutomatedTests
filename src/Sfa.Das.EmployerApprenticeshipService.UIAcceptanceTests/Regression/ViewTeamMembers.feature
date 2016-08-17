Feature: ViewTeamMembers
	In order to know wheo can view my account
	I need to see team members

@Regression
Scenario: View Team
Given I navigated to the Start page
	Then  I see 
	| Field       | Rule   | Value |
	| UserNameBox | exists | true  |
	| PasswordBox | exists | true  |
	| LoginButton | exists | true  |
	Then I enter data
	| Field       | Value						|
	| UserNameBox | sfa.aml.test+Jane@gmail.com |
	| PasswordBox | Office01					|
	When I choose LoginButton
	And I wait for the view to become active
	Then I see
    | Field				| Rule		 | Value	 |
    |   openAccountLink |  exists    |    true   |
	When I choose openAccountLink
	And I wait for the view to become active
	Then I am on the EmployerAccountView page
	And I see
    | Field        | Rule       | Value     |
    | TeamLink      | exists     |  true    |
	When I choose TeamLink
	Then I am on the TeamView page
	And I see
	| Field         | Rule   | Value |
	| ListofMembers | exists | True  |
	| TeamDetails   | exists | True  |
	| ViewLinkJane      | exists | true  |
	| InviteButton  | exists | true  |
	When I choose ViewLinkJane
	Then I am on the TeamMemberReview page
	And I see
	| Field          | Rule   | Value |
	| MemberDetails  | exists | true  |
	| ChangeRoleLink | exists | true  |