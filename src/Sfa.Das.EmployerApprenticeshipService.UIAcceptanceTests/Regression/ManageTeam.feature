Feature: ManageTeam
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers



@TeamManagement
Scenario Outline: Invite Member
Given I have a DAS Account
When  I invite "<User Email>"
Then  "<User Email>" is added to list of Team Members
And invite status for"<User Email>" is "<status>"
Examples: 
| User Email                     | status   |
| sfa.aml.test+JohnDoe@gmail.com | pending  |

@TeamManagement
Scenario: Resend Invitation
	Given invite status for"<User Email>" is "<status>"
	
