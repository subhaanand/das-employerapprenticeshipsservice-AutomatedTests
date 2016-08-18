Feature: InviteTeamMember
	In order to be able to add people to my team
	I need to invite team members

@Invitations
Scenario: Invite Member
Given I navigated to the Start page
Then I enter data
	| Field       | Value						|
	| UserNameBox | sfa.aml.test+Jane@gmail.com |
	| PasswordBox | Office01					|
	When I choose LoginButton
	And I wait for the view to become active	   
	When I choose openAccountLink
	And I wait for the view to become active
	Then I am on the EmployerAccountView page	
	When I choose TeamLink
	Then I am on the TeamView page
	And I see
	| Field         | Rule   | Value |	
	| InviteButton  | exists | true  |
	When I choose InviteButton
	Then I am on the MemberInvite page
	And I see
	| Field					   | Rule   | Value	|
	| CreateButton			   | exists | true  |
	| NameTextBox              | exists | true  |
	| EmailTextBox             | exists | true  |
	| ViewerRoleRadioButton    | exists | true  |
	| TransactorRoleRadioButton| exists | true  |
	| OwnerRoleRadioButton     | exists | true  |
	Then I enter data
	| Field        | Value    |
	| NameTextBox  | John Doe |
	| EmailTextBox | sfa.aml.test+JohnDoe@gmail.com |
	When I choose CreateButton
	Then I am on the TeamView page
