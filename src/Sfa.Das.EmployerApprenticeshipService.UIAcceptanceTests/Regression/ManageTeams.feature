Feature: ManageTeams
	In order to be able to add people to my team
	I need to manage team members

@Regression
Scenario: Invite Team member
	Given I have an account
	When  I invite"email" to my team
	And   give them "role" as a role
	Then  they are added to my team list

@Regression
Scenario: View Team
	Given I have an account
	And   I have poeple on my team list
	Then  I can view their role

@Regression
Scenario: Delete Member
	Given I have an account
	And   I have poeple on my team list
	Then  I can delete a member
	And   I cannot delete myself