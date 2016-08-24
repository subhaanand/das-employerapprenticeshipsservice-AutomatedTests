Feature: ManageTeams
	In order to be able to add people to my team
	I need to manage team members

@TeamManagement @Regression
Scenario: Invite Team member
	Given I have an account
	When  I invite"email" to my team
	And   give them "role" as a role
	Then  they are added to my team list as "status"

@TeamManagement @Regression
Scenario:Cancel Invitation
	Given I have an account
	When I invite"{p0}" to my team
	And give them "role" as a role
	When I cancel their invitation
	Then they are removed from my team list

@TeamManagement @Regression
Scenario: View Team
	Given I have an account
	And   I have poeple on my team list
	Then  I can view their role

@TeamManagement @Regression
Scenario: Delete Member
	Given I have an account
	And   I have poeple on my team list
	Then  I can delete a member
	And   I cannot delete myself
