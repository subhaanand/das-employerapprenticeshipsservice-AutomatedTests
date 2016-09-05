Feature: ManageTeams
	In order to be able to add people to my team
	I need to manage team members

@TeamManagement @Regression
Scenario Outline: Invite Team member
	Given I invite "<username>" with email "<email>" to my team	
	Then  they are added to my team list as "<email>"
Examples: 
| username | email|
| James Doe | sfa.aml.test+jamesdoe@gmail.com|

@TeamManagement @Regression
Scenario:Cancel Invitation	
	Given I view second member on the list
	When I cancel their invitation
	#Then they are removed from my team list

@TeamManagement @Regression
Scenario: View Team
	Given I have an account
	Then I have people on my team list
	

@TeamManagement @Regression
Scenario: Delete Member
	Given I have an account
	And   I have people on my team list
	Then  I can delete a member
	And   I cannot delete myself
